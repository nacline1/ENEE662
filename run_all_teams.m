%run_all_teams.m
clear;

global team_data;
global num_trips;
global num_scenarios;

num_trips=2;
num_scenarios=5;


% run
team_data='Supporting_Data_Team_01.mat';
TrafficRouteSim

team_data='Supporting_Data_Team_02.mat';
TrafficRouteSim

team_data='Supporting_Data_Team_03.mat';
TrafficRouteSim

team_data='Supporting_Data_Team_04.mat';
TrafficRouteSim

team_data='Supporting_Data_Team_05.mat';
TrafficRouteSim
