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
assert(isempty(SF.G)==false);

SF.CreateTrip();
SF.FindRoute();
SF.ApplyRoadConditions();
SF.ApplyRoadSpeeds();
SF.CalcRouteTime();
SF.FindPredictiveRoute();

% display results
fprintf('Route Time: %f  Predictive Route Time: %f  ReRouted: %d\n', ...
    SF.route_time_with_cond, SF.route_pred_time, SF.ReRouted);
