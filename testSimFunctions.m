% testSimFunctions.m
% 
% Description:
% Tests the simulator functions in a controlled environment
% Essentially runs one loop of the main program and displays the result.
%

clear;

% for initial testing, use same random numbers
s = RandStream('mt19937ar','Seed',1);
RandStream.setGlobalStream(s);

%
SF=SimFunctions();
SF.Initialize('EastCoast.mat', 'Supporting_Data_Team_04.mat');


%% Test 1: Review initialize output
assert(isempty(SF.G)==false);

%% Test 2: Check road conditions
SF.CreateTrip();
SF.FindRoute();
SF.ApplyRoadConditions();

% confirm percentages match expected pd_cond
X=SF.G.Edges.Conditions;
nor_perc=size(find(X==SF.NORMAL),1)/size(X,1);
con_perc=size(find(X==SF.CONSTRUCTION),1)/size(X,1);
acc_perc=size(find(X==SF.ACCIDENT),1)/size(X,1);
SF.p
% BP: I visually inspected, probably want to do more here
% e.g write some code to do a perc diff between actual and expected


%% Test 3: One trip
SF.CreateTrip();
SF.FindRoute();
SF.ApplyRoadConditions();
SF.ApplyRoadSpeeds();
SF.FindPredictiveRoute();
SF.CalcRouteTime();

% display results
fprintf('Route Time: %f  Predictive Route Time: %f  ReRouted: %d\n', ...
    SF.route_time_with_cond, SF.route_pred_time, SF.ReRouted);
