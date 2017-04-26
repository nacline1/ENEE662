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
global map_data;
global team_data;
global num_trips;
global num_scenarios;

% for initial testing, use same random numbers
s = RandStream('mt19937ar','Seed',1);
RandStream.setGlobalStream(s);

% set default values as needed, can be overridden 
% from another calling program
if isempty(map_data)==1
    map_data='EastCoast.mat';
end
if isempty(team_data)==1
    team_data='Supporting_Data_Team_04.mat';
end
if isempty(num_trips)==1
    num_trips=10; %REPLACE with 10
end
if isempty(num_scenarios)==1
    num_scenarios=10;  %REPLACE with TBD
end


% create sim functions object and initialize with selected data
SF=SimFunctions();
SF.Initialize(map_data, team_data);


n=1;
trip=1;
while trip<=num_trips
    SF.CreateTrip();
%    fprintf('GCD: %f\n',SF.gcdist);

    if SF.FindRoute()==false
        fprintf('Impossible route\n');
        continue;
    end

    
    % for some number of times (TBD), apply different road conditions
    % and calculate different trip times
    for scenario=1:num_scenarios
        SF.ApplyRoadConditions();
        SF.ApplyRoadSpeeds();
        % next line should never be false since we are checking for
        % this in the outer loop
        assert(SF.FindPredictiveRoute()==true); 
        SF.CalcRouteTime();
        
        % display results
%        fprintf('Ideal Route Time: %f Route Time: %f  Predictive Route Time: %f  ReRouted: %d\n', ...
%            SF.route_time, SF.route_time_with_cond, SF.route_pred_time, SF.ReRouted);
        savings_abs(n)=60*(SF.route_time_with_cond-SF.route_pred_time);
        savings_perc(n)=100*savings_abs(n)/(SF.route_time_with_cond*60);
        n=n+1;

        % save off results
        Results.RouteTime(trip,scenario)     = SF.route_time_with_cond;
        Results.PredRouteTime(trip,scenario) = SF.route_pred_time;
        Results.ReRouted(trip,scenario)      = SF.ReRouted;
        
        % add option to print random numbers!!!!!
        % try to test with ust all normal conditions, create a separate
        % file
    end
    
    % increment for next trip
    trip=trip+1;
    
end
fprintf('%f%% [%f %f %f]\n',mean(savings_perc),SF.p);

%%%%%%%%%%%%%%%%%%%%%%%%% Data Analysis %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
hold on;
% Plot un-sorted percent savings
title('Percent Time Savings Per Iteration');
xlabel('Iteration');
ylabel('Percent Time Saved');
plot(savings_perc);

% Calculate and plot sorted percent savings
sorted_savings = sort(savings_perc);
plot(sorted_savings);
legend('Unsorted', 'Sorted');

% Bin data and display on histogram
figure;
hold on;
% Calculate number of histogram bins via Sturge's rule
nBins = floor(1 + log(size(sorted_savings, 2))/log(2));
% Normalize Histogram
histogram(sorted_savings, nBins, 'Normalization', 'pdf');
% Fit exponential to sorted data (dfittool analysis to determine best fit)
savings_fit = fitdist(sorted_savings', 'Exponential');
y = pdf(savings_fit, sorted_savings');
% Display fit
plot(sorted_savings, y);
xlabel('Percent Saved');
ylabel('Probability Density');
legend('Binned Trip Time Data', 'Exponential Fit');

% Get 95% confidence interval
savings_ci = paramci(savings_fit, 'Alpha', 0.05);
fprintf('95%% Confidence Interval [%.4f, %.4f]\n', savings_ci(1), savings_ci(2));
% Check if lower CI bound is > 5% threshold to answer question
if(savings_ci(1) > 5)
   fprintf('Predictive routing DOES save more than 5%% of the trip time to a 95%% confidence interval\n');
else
   fprintf('Predictive routing DOES NOT save more than 5%% of the trip time to a 95%% confidence interval\n');
end

fprintf('Percent Re-Routes %.2f\n', sum(sum(Results.ReRouted)) / (num_trips * num_scenarios) * 100);