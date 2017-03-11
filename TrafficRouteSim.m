%
% TrafficRouteSim.m  
% Description: Main program file for the Traffic Routing Simulator
%
%
% Author : Team 4
% Version: 1.0 (3/11/17)
%
% Inputs:
% 1.) Road Network
%     Data type: Matlab Graph
%     Filename: EastCoast.mat
%
% 2.) Speed and Accident data
%     Data type: Table
%     Filename: Supporting_Data_team_04.mat
%
% Outputs:
% Currently undecided
% Option 1: Datafile for further analysis
% Option 2: Analysis answering the following questions:
% (Q1) On average, does predictive routing save more than 5% of the trip
% time to a 95% confidence for trips greater than 60 miles.
% (Q2) What fraction of trips is re-routed due to road conditions?
%
% Restrictions
% None
%
% Needed local classes
% SimFunctions
%
% Needed local functions
% None
%
% References
% ITS Simulation Assignment revA.pdf
% Team 4 Modeling and Simulation Plan
%
% Revision history
% Version 1.0
%
clear;

% for initial testing, use same random numbers
s = RandStream('mt19937ar','Seed',1);
RandStream.setGlobalStream(s);


SF=SimFunctions();
SF.Initialize('EastCoast.mat', 'Supporting_Data_Team_04.mat');

num_trips=3; %REPLACE with 10
for trip=1:num_trips
    SF.CreateTrip();
    SF.FindRoute();

    fprintf('GCD: %f\n',SF.gcdist);
    
    % for some number of times (TBD), apply different road conditions
    % and calculate different trip times
    num_scenarios=4;  %REPLACE with TBD
    for scenario=1:num_scenarios
        SF.ApplyRoadConditions();
        SF.ApplyRoadSpeeds();
        SF.FindPredictiveRoute();
        SF.CalcRouteTime();
        
        % display results
        fprintf('Route Time: %f  Predictive Route Time: %f  ReRouted: %d\n', ...
            SF.route_time_with_cond, SF.route_pred_time, SF.ReRouted);
    end
end