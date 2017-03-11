classdef SimFunctions < handle
    %SimFunctions Traffic simulator functions
    %   This class holds the requisite traffic simulator functions
    %   to simplify development and testing.
    
    properties
        % all distances are in miles
        % all times are in hours
        % all speeds are in mph
        
        G; % graph data
        
        pd_conditions;  % road condition probability distribution
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

        end
        
        % Method: ApplyRoadConditions
        % Description: Randomly identify a road condition for each road
        % segment, add as new table column to G.Edges
        function ApplyRoadConditions(self)
            % REPLACE
            % this test code needs to be replaced with actual code
            self.G.Edges.Conditions=ones(size(self.G.Edges,1),1);
            % REPLACE
        end
        
        % Method: ApplyRoadSpeeds
        % Description: Based on road condition, apply random road speed
        % Refer to table requirement 1.2.5
        function ApplyRoadSpeeds(self)
            % REPLACE
            % this test code needs to be replaced with actual code
            self.G.Edges.RandSpeed=random(self.pd_S65,size(self.G.Edges,1),1);
            % REPLACE
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
            % traverse the path and sum the times
            %route_time_with_cond;
            travel_time=0;
            for i=1:size(self.route_path,2)-1
                e=findedge(self.G,self.route_path(i),self.route_path(i+1));
                travel_time=travel_time+self.G.Edges.Weight(e);
            end
            self.route_time_with_cond=travel_time;
        end
        
        % Method: ReRouted
        % Description: Determine if trip was rerouted, returns true/false
        function tf = ReRouted(self)
            tf=~isequal(self.route_path, self.route_pred_path);
        end
    end
    
end

