classdef SimFunctions < handle
    %SimFunctions Traffic simulator functions
    %   This class holds the requisite traffic simulator functions
    %   to simplify development and testing.
    
    properties (Constant=true)
        % road condition values
        NORMAL=1;
        CONSTRUCTION=2;
        ACCIDENT=3;
        
        
    end
    
    properties
        % all distances are in miles
        % all times are in hours
        % all speeds are in mph
        
        G; % graph data

        p;        % road condition probabilites (for testing)
        pd_cond;  % road condition probability distribution
        pd_S65; % interstate speed probability distribution
        pd_S50; % highway speed probability distribution
        pd_S40; % construction speed probability distribution
        pd_S15; % accident speed probability distribution
        
        node_start; % start of trip
        node_end;   % end of trip
        gcdist;     % great-circle distance

        route_path; % route path without road conditions applied
        route_time; % route time without road conditions applied
        route_time_with_cond % route time with road conditions applied
        route_edges; % vector to store edges, performance tweak

        route_pred_path; % route path found with road conditions applied
        route_pred_time; % travel time for predictive route
    end
    
    methods
        % constructor
        function self = SimFunctions()
        end
        
        % Method: Initialize
        % Description: Load data, create probability distributions for road
        % and accident data
        function Initialize(self, RoadNetworkFN, DistDataFN)
            load(RoadNetworkFN);
            self.G=G;
            
            load(DistDataFN);
            % create probability distributions here
            % pd_conditions=???
            X=T_roadcond_data.nominal;
            nor_perc=size(find(X=='Normal'),1)/size(X,1);
            con_perc=size(find(X=='Construction'),1)/size(X,1);
            acc_perc=size(find(X=='Accident'),1)/size(X,1);
            self.p = [nor_perc con_perc acc_perc]; 
            self.pd_cond = cumsum(self.p);
            
            
            self.pd_S65=fitdist(T_speed_data.S65,'Normal');
            self.pd_S50=fitdist(T_speed_data.S50,'Normal');
            self.pd_S40=fitdist(T_speed_data.S40,'Normal');
            self.pd_S15=fitdist(T_speed_data.S15,'Normal');
            
        end
        
        
        % Method: CreateTrip
        % Description: Randomly finds two nodes > 60 miles.
        function CreateTrip(self)
            %Populate these:
            %node_start;
            %node_dest;
            % randomly choose two nodes
            nodes=self.G.Nodes;
            num_nodes=size(nodes,1);
            tripdist=0;
            
            while tripdist<60
                self.node_start=randi(num_nodes);
                self.node_end=randi(num_nodes);

                % find great-circle distance
                tripdist=distance( ...
                    nodes.Lat(self.node_start), nodes.Long(self.node_start), ...
                    nodes.Lat(self.node_end), nodes.Long(self.node_end), ...
                    referenceSphere('earth','mi'));

            end
            self.gcdist=tripdist;
        end
        
        % Method: FindRoute
        % Description: Find quickest route without road conditions
        function FindRoute(self)
            % set weights equal to time to travel edge using speed limit
            self.G.Edges.Weight=self.G.Edges.Distance./self.G.Edges.Speed;

            % find quickest path
            [self.route_path, self.route_time]=shortestpath( ... 
                self.G, ...
                self.G.Nodes.Name(self.node_start), ... 
                self.G.Nodes.Name(self.node_end));

            
            % find and store the Edges, performance tweak
            % traverse the path and sum the times
            self.route_edges=[];
            for i=1:size(self.route_path,2)-1
                e=findedge(self.G,self.route_path(i),self.route_path(i+1));
                self.route_edges=[self.route_edges e];
            end
            
        end
        
        % Method: ApplyRoadConditions
        % Description: Randomly identify a road condition for each road
        % segment, add as new table column to G.Edges
        function ApplyRoadConditions(self)
            x=rand(size(self.G.Edges,1),1);
            myfunc=@(x) find(self.pd_cond>=x,1);
            self.G.Edges.Conditions=arrayfun(myfunc,x);
        end

        % Method: CalcRoadSpeed
        % Description: Based on road condition and road type, return the
        % random speed from the correct probability distribution
        function speed=CalcRoadSpeed(self, condition,speed_limit)
            %speed=random(self.pd_S65);

            if condition==self.NORMAL && speed_limit==65
                speed=random(self.pd_S65);
            elseif condition==self.NORMAL && speed_limit==50
                speed=random(self.pd_S50);
            elseif condition==self.CONSTRUCTION
                speed=random(self.pd_S40);
            elseif condition==self.ACCIDENT
                speed=random(self.pd_S15);
            else
                disp condition;
                error('Unknown condition encountered');
            end
            % if cond=NORMAL and road_type=INTERSTATE
            %    speed=random(self.pd_S65)
            % if cond=NORMAL and road_type=HIGHWAY
            %    speed=random(self.pf_S50)
            % if cond=CONSTRUCTION
            %    speed=random(self.pd_S40)
            % if cond=ACCIDENT
            %    speed=random(self.pd_S15)
            % else
            %    error
            %
        end
        
        % Method: ApplyRoadSpeeds
        % Description: Based on road condition, apply random road speed
        % Refer to table requirement 1.2.5
        function ApplyRoadSpeeds(self)
            % REPLACE
            % this test code needs to be replaced with actual code
%             self.G.Edges.RandSpeed=random(self.pd_S65,size(self.G.Edges,1),1);
            % 
            f=@self.CalcRoadSpeed;
            conditions=self.G.Edges.Conditions;
            speed_limits=self.G.Edges.Speed;
            self.G.Edges.RandSpeed=arrayfun(f,conditions,speed_limits);
        end
        
        % Method: FindPredictiveRoute
        % Description: Find quickest route given road conditions
        function FindPredictiveRoute(self)
            % set weights equal to time to travel edge using random speeds
            self.G.Edges.Weight=self.G.Edges.Distance./self.G.Edges.RandSpeed;

            % find quickest path
            [self.route_pred_path, self.route_pred_time]=shortestpath( ... 
                self.G, ...
                self.G.Nodes.Name(self.node_start), ... 
                self.G.Nodes.Name(self.node_end));
        end
        
        % Method: CalcRouteTime
        % Description: Calculate time to travel route with road conditions
        % applied.
        function CalcRouteTime(self)
            % use saved_edges vector to find the weights and sum
            self.route_time_with_cond= ...
                sum(self.G.Edges.Weight(self.route_edges));
        end
        
        % Method: ReRouted
        % Description: Determine if trip was rerouted, returns true/false
        function tf = ReRouted(self)
            tf=~isequal(self.route_path, self.route_pred_path);
        end
    end
    
end

