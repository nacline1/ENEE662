function statusMessage = simMain(user_VolumetricFlowRate, user_ConcentrationAmmoniaInitial, user_ConcentrationHydrogenSulfide, user_MaxAppliedPressure, user_CpG_CuS, user_CpG_NH3, user_CpG_H2SO4, user_CpKwH)

    debug = true; % Flag for additional print statements

    %%%%%%%%%%%%%%%%%%% SIMULATION USER VARIABLES %%%%%%%%%%%%%%%%%%%%%%
    volumetric_Flow_Rate = user_VolumetricFlowRate;
    concentration_Ammonia_Initial = user_ConcentrationAmmoniaInitial;
    concentration_Hydrogen_Sulfide = user_ConcentrationHydrogenSulfide;
    max_Applied_Pressure = user_MaxAppliedPressure;
    cost_Per_Gram_Copper_Sulfate = user_CpG_CuS;
    cost_Per_Gram_Ammonia = user_CpG_NH3;
    cost_Per_Gram_Sulfuric_Acid = user_CpG_H2SO4;
    cost_Per_KwH = user_CpKwH;
    %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    %%%%%%%%%%%%%%%%%%% SIMULATION PRECONDITIONS %%%%%%%%%%%%%%%%%%%%%%%
    %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    % Calculate variables based on inputs
    max_Osmotic_Pressure = (max_Applied_Pressure - 100) / 1.1; % Equation 20 solving for Pi
    %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    
    %%%%%%%%%%%%%%%%%%%%% SIMULATION CONSTANTS %%%%%%%%%%%%%%%%%%%%%%%%%  
    NGSWAT_100_THRESHOLD                        = 0.008;    % 8 ppb residual Hydrogen Sulfide
    NGSWAT_200_THRESHOLD                        = 10;       % 10 ppm residual Ammonia
    NGSWAT_300_THRESHOLD                        = 50.0;     % Percentage of initial water that goes to clean water stream
    NGSWAT_400_THRESHOLD                        = 20.00;    % Fine (in dollars) per liter of dirty water
    MOLAR_MASS_HYDROGEN_SULFIDE                 = 34.08090; % g/mol
    MOLAR_MASS_AMMONIA                          = 17.03100; % g/mol
    MOLAR_MASS_WATER                            = 18.01528; % g/mol
    MOLAR_MASS_COPPER_SULFATE                   = 159.6090; % g/mol
    MOLAR_MASS_SULFURIC_ACID                    = 98.07900; % g/mol
    NUM_MOLES_AMMONIA_PER_MOLE_SULFURIC_ACID    = 2; % Equation 16
    REACTION_PROBABILITY                        = 1 - 0.999999; % 99.9999 percent
    STAGE_2_FILTER_PROBABILITY_HYDROGEN_SULFIDE = 1 - 0.999; % 99.9 percent
    STAGE_2_FILTER_PROBABILITY_AMMONIA          = 1 - 0.9999; % 99.99 percent
    GAMMA_I                                     = 0.8; % Activity Coefficient of Water
    STAGE_3_FILTER_PROBABILITY_HYDROGEN_SULFIDE = 1 - 0.999;
    STAGE_3_FILTER_PROBABILITY_AMMONIA          = 1 - 0.9999; % 99.99 percent
	R                                           = 8.3144621; % Ideal gas constant (L kPa K^-1 mol^-1)
    T                                           = 290; % Degrees Kelvin
	MINUTES_PER_HOUR							= 60;
    SECONDS_PER_MINUTE							= 60;
	GRAMS_PER_MILLIGRAM                         = 0.001; % 1g / 1000mg
    MILLIGRAMS_PER_GRAM                         = 1 / GRAMS_PER_MILLIGRAM;
    PARTS_PER_MILLION                           = 1000000;
    %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    %%%%%%%%%%%%%%%%%%% POWER RELATED CONSTANTS %%%%%%%%%%%%%%%%%%%%%%%%
    DEVICE_NAME_1 = 1; % Index for Device 1
    DEVICE_NAME_2 = 2; % Index for Device 2
    DEVICE_NAME_3 = 3; % Index for Device 3
    DEVICE_NAME_4 = 4; % Index for Device 4
    DEVICE_NAME_1_POWER = 20; % KwH for Device 1
    DEVICE_NAME_2_POWER = 30; % KwH for Device 2
    DEVICE_NAME_3_POWER = 40; % KwH for Device 3
    DEVICE_NAME_4_POWER = 100; % KwH for Device 4
    powArray = [DEVICE_NAME_1_POWER, DEVICE_NAME_2_POWER, DEVICE_NAME_3_POWER, DEVICE_NAME_4_POWER]; % Device Array
    timeFactor = (MINUTES_PER_HOUR * SECONDS_PER_MINUTE); % (Minutes/Hr * Seconds/Minutes)
    %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    
    
    %%%%%%%%%%%%%%%%%%% POWER RELATED VARIABLES %%%%%%%%%%%%%%%%%%%%%%%%
    bPowActive = zeros(4,1); % Start with all devices OFF
    %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    
    
    %%%%%%%%%%%%%%%%%%% POWER RELATED FUNCTIONS %%%%%%%%%%%%%%%%%%%%%%%%%
    function p = calculatePowerCost()
        p = ((powArray * bPowActive) * cost_Per_KwH)/ timeFactor;
    end

    function enableDevice(b)
       bPowActive(b) = 1;
    end

    function disableDevice(b)
       bPowActive(b) = 0; 
    end
    %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
   

    %%%%%%%%%%%%%%%%%%%%%%%% SIMULATION SETUP %%%%%%%%%%%%%%%%%%%%%%%%%%%
    % Default all power devices to ON
    for i = 1 : size(powArray,2) % 2nd dimension = columns
       enableDevice(i); 
    end
    
    % Calculate Molar Concentration (mol/L) of Hydrogen Sulfide
    molar_Concentration_Hydrogen_Sulfide = (concentration_Hydrogen_Sulfide / MOLAR_MASS_HYDROGEN_SULFIDE) * GRAMS_PER_MILLIGRAM;
    % Calculate Number of Hydrogen Sulfide Moles per Second
    num_Moles_Hydrogen_Sulfide_Per_Second = molar_Concentration_Hydrogen_Sulfide * volumetric_Flow_Rate;
    
    % Calculate Initial Molar Concentration (mol/L) of Ammonia
    molar_Concentration_Ammonia_Initial = (concentration_Ammonia_Initial / MOLAR_MASS_AMMONIA) * GRAMS_PER_MILLIGRAM;
    % Calculate Initial Number of Ammonia Moles per Second
    num_Moles_Ammonia_Initial_Per_Second = molar_Concentration_Ammonia_Initial * volumetric_Flow_Rate;
    
    % Calculate Initial Concentration of Water
    concentration_Water_Initial = PARTS_PER_MILLION - concentration_Hydrogen_Sulfide - concentration_Ammonia_Initial;
    % Calculate Initial Molar Concentration (mol/L) of Water
    molar_Concentration_Water_Initial = (concentration_Water_Initial / MOLAR_MASS_WATER) * GRAMS_PER_MILLIGRAM;
    % Calculate Initial Number of Water Moles per Second
    num_Moles_Water_Initial_Per_Second = molar_Concentration_Water_Initial * volumetric_Flow_Rate;
    
    %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    
    % Display simulation conditions
    fprintf('\nINITIAL CONDITIONS\n\n');
    fprintf('Volumetric Flow Rate (L/s): %.2f\n', volumetric_Flow_Rate);
    
    fprintf('Hydrogen Sulfide Concentration (ppm): %.2f\n', concentration_Hydrogen_Sulfide);
    if debug
        fprintf('Hydrogen Sulfide Molar Concentration: %.8f\n', molar_Concentration_Hydrogen_Sulfide);
        fprintf('Hydrogen Sulfide Moles Per Second: %.3f\n\n', num_Moles_Hydrogen_Sulfide_Per_Second);
    end
    
    fprintf('Ammonia Concentration (ppm): %.2f\n', concentration_Ammonia_Initial);
    if debug
        fprintf('Ammonia Molar Concentration : %.8f\n', molar_Concentration_Ammonia_Initial);
        fprintf('Ammonia Moles (Initial) Per Second: %.3f\n\n', num_Moles_Ammonia_Initial_Per_Second);
    end
    
    fprintf('Water Concentration (ppm): %.2f\n', concentration_Water_Initial);
    if debug
        fprintf('Water Molar Concentration: %.8f\n', molar_Concentration_Water_Initial);
        fprintf('Water Moles (Initial) Per Second: %.3f\n\n', num_Moles_Water_Initial_Per_Second);
    end
    
    fprintf('Max Applied Pressure (kPa): %i\n\n', max_Applied_Pressure);
    
    fprintf('Cost Per Gram (Copper Sulfide): %.4f\n', cost_Per_Gram_Copper_Sulfate);
    fprintf('Cost Per Gram (Ammonia): %.4f\n', cost_Per_Gram_Ammonia);
    fprintf('Cost Per Gram (Sulfuric Acid): %.4f\n', cost_Per_Gram_Sulfuric_Acid);
    fprintf('Cost Per Kilowatt Hour: %.4f\n', cost_Per_KwH);
    
    fprintf('-------------------------------------------------------\nSTART SIMULATION\n-------------------------------------------------------\n\n');
    %%%%%%%%%% Calculate all the Stages and associated variables %%%%%%%%%%%
    %%%%%%%%%%%%%%%%%%%%%%%%%%%%% STAGE 1 %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    grams_Per_Liter_Copper_Sulfate = MOLAR_MASS_COPPER_SULFATE * molar_Concentration_Hydrogen_Sulfide; % Equation 14
    %Convert to per second
    grams_Per_Second_Copper_Sulfate = grams_Per_Liter_Copper_Sulfate * volumetric_Flow_Rate;
    if debug == true
        fprintf('Grams Copper (II) Sulfate Per Second: %.3fg\n\n', grams_Per_Second_Copper_Sulfate); 
    end
    
    % Need to initialize following variables since they're sometimes left at 0
    num_Moles_Ammonia_Additional_Per_Second = 0;
    grams_Per_Second_Ammonia_Additional = 0;
    num_Moles_Ammonium_Sulfate_Per_Second = 0;
    num_Moles_Sulfuric_Acid_Additional_Per_Second = 0; 
    grams_Per_Second_Sulfuric_Acid_Additional = 0;
    num_Moles_Ammonium_Sulfate_Per_Second = 0;
    
    
    num_Moles_Sulfuric_Acid_Per_Second_Stage_1 = num_Moles_Hydrogen_Sulfide_Per_Second; % Equation 15
    num_Moles_Delta = (num_Moles_Ammonia_Initial_Per_Second / NUM_MOLES_AMMONIA_PER_MOLE_SULFURIC_ACID) - num_Moles_Sulfuric_Acid_Per_Second_Stage_1; %Equation 17
    if num_Moles_Delta < 0 
       % Need to add more Ammonia
       num_Moles_Ammonia_Additional_Per_Second = (-1 * NUM_MOLES_AMMONIA_PER_MOLE_SULFURIC_ACID) * num_Moles_Delta; % Equation 18
       % Convert Moles to Grams and add to Aggregate
       grams_Per_Second_Ammonia_Additional = num_Moles_Ammonia_Additional_Per_Second * MOLAR_MASS_AMMONIA;
       % Numer of Moles of Ammonium Sulfate produced is equal to number of Sulfuric Acid Moles
        num_Moles_Ammonium_Sulfate_Per_Second = num_Moles_Sulfuric_Acid_Per_Second_Stage_1;
       if debug
           fprintf('Additional Moles of Ammonia Per Second: %.3f\n\n', num_Moles_Ammonia_Additional_Per_Second);
           fprintf('Moles of Ammonium Sulfate Per Second: %.3f\n\n', num_Moles_Ammonium_Sulfate_Per_Second);
       end
    elseif num_Moles_Delta > 0
        % Need to add more Sulfuric Acid
        num_Moles_Sulfuric_Acid_Additional_Per_Second = num_Moles_Delta; % Equation 19
        % Convert Moles to Grams and add to Aggregate
        grams_Per_Second_Sulfuric_Acid_Additional = num_Moles_Sulfuric_Acid_Additional_Per_Second * MOLAR_MASS_SULFURIC_ACID;
        % Numer of Moles of Ammonium Sulfate produced is Half number of Ammonia Moles
        num_Moles_Ammonium_Sulfate_Per_Second = (num_Moles_Ammonia_Initial_Per_Second / NUM_MOLES_AMMONIA_PER_MOLE_SULFURIC_ACID);
        if debug
            fprintf('Additional Moles of Sulfuric Acid Per Second: %.3f\n\n', num_Moles_Sulfuric_Acid_Additional_Per_Second);
            fprintf('Moles of Ammonium Sulfate Per Second: %.3f\n\n', num_Moles_Ammonium_Sulfate_Per_Second);
        end
    else
       %Do nothing since it's already balanced
    end

    % Simulate reaction probability of Equations 13 and 16
    num_Moles_Hydrogen_Sulfide_Per_Second_Stage_2 = num_Moles_Hydrogen_Sulfide_Per_Second * REACTION_PROBABILITY;
    num_Moles_Ammonia_Per_Second_Stage_2 = (num_Moles_Ammonia_Initial_Per_Second + num_Moles_Ammonia_Additional_Per_Second) * REACTION_PROBABILITY;
    if debug
        fprintf('Moles of Hydrogen Sulfide going to Stage 2 Per Second: %e\n\n', num_Moles_Hydrogen_Sulfide_Per_Second_Stage_2);
        fprintf('Moles of Ammonia going to Stage 2 Per Second: %e\n\n', num_Moles_Ammonia_Per_Second_Stage_2);
    end
    %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    %%%%%%%%%%%%%%%%%%%%%%%%%%%%% STAGE 2 %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    num_Moles_Hydrogen_Sulfide_Per_Second_Stage_3 = num_Moles_Hydrogen_Sulfide_Per_Second_Stage_2 * STAGE_2_FILTER_PROBABILITY_HYDROGEN_SULFIDE;
    num_Moles_Ammonia_Per_Second_Stage_3 = num_Moles_Ammonia_Per_Second_Stage_2 * STAGE_2_FILTER_PROBABILITY_AMMONIA;
    if debug
        fprintf('Moles of Hydrogen Sulfide going to Stage 3 Per Second: %e\n\n', num_Moles_Hydrogen_Sulfide_Per_Second_Stage_3);
        fprintf('Moles of Ammonia going to Stage 3 Per Second: %e\n\n', num_Moles_Ammonia_Per_Second_Stage_3);
    end
    %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


    %%%%%%%%%%%%%%%%%%%%%%%%%%%%% STAGE 3 %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    if debug
        fprintf('Gamma %f\n',  GAMMA_I);
        fprintf('max_Osmotic_Pressure %f\n',  max_Osmotic_Pressure);
        fprintf('Flow Rate %f\n',  volumetric_Flow_Rate);
        fprintf('Moles Ammonium Sulfate Per Second %f mol\n',  num_Moles_Ammonium_Sulfate_Per_Second);
        fprintf('Gamma %f\n', GAMMA_I);
        fprintf('R %f\n',  R);
        fprintf('T %f\n',  T);
        fprintf('Exponent: %f\n', (max_Osmotic_Pressure * volumetric_Flow_Rate) / (num_Moles_Ammonium_Sulfate_Per_Second * R * T));
    end
    min_Dirty_Water_Concentration = (1/(GAMMA_I * exp( (max_Osmotic_Pressure * volumetric_Flow_Rate) / (num_Moles_Ammonium_Sulfate_Per_Second * R * T)))); % Equation 24
    num_Moles_Water_Needed_Per_Second_Stage_3 = (min_Dirty_Water_Concentration * num_Moles_Ammonium_Sulfate_Per_Second) / (1 - min_Dirty_Water_Concentration); % Equation 22
    clean_Water_Production_Ratio = 1 - (num_Moles_Water_Needed_Per_Second_Stage_3 / num_Moles_Water_Initial_Per_Second); 
    if debug
       fprintf('Minimum Dirty Water Concentration: %.6f\n\n',  min_Dirty_Water_Concentration);
       fprintf('Moles of Water Needed (Stage 3) Per Second: %.8f\n\n', num_Moles_Water_Needed_Per_Second_Stage_3);
       fprintf('Clean Water Production Ratio: %.10f\n\n', clean_Water_Production_Ratio);
    end

    num_Moles_Hydrogen_Sulfide_Per_Second_Final = num_Moles_Hydrogen_Sulfide_Per_Second_Stage_3 * STAGE_3_FILTER_PROBABILITY_HYDROGEN_SULFIDE;
    num_Moles_Ammonia_Per_Second_Final = num_Moles_Ammonia_Per_Second_Stage_3 * STAGE_3_FILTER_PROBABILITY_AMMONIA;
    if debug
        fprintf('Final Moles of Hydrogen Sulfide Per Second: %e\n\n', num_Moles_Hydrogen_Sulfide_Per_Second_Final);
        fprintf('Final Moles of Ammonia Per Second: %e\n\n', num_Moles_Ammonia_Per_Second_Final);
    end       
    %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
    cost_Chemicals_Per_Second_Copper_Sulfate = grams_Per_Second_Copper_Sulfate * cost_Per_Gram_Copper_Sulfate;
    cost_Chemicals_Per_Second_Total_Ammonia = grams_Per_Second_Ammonia_Additional* cost_Per_Gram_Ammonia;
    cost_Chemicals_Per_Second_Sulfuric_Acid = grams_Per_Second_Sulfuric_Acid_Additional* cost_Per_Gram_Sulfuric_Acid;
	cost_Power_Per_Second = calculatePowerCost();
    cost_Total_Per_Second = cost_Chemicals_Per_Second_Copper_Sulfate + cost_Chemicals_Per_Second_Total_Ammonia + cost_Chemicals_Per_Second_Sulfuric_Acid + cost_Power_Per_Second;

    if debug
       fprintf('Cost of Copper (II) Sulfate Per Second: $%.2f\n',  cost_Chemicals_Per_Second_Copper_Sulfate);
       fprintf('Cost of Ammonia Per Second: $%.2f\n',  cost_Chemicals_Per_Second_Total_Ammonia);
       fprintf('Cost of Sulfuric_Acid Per Second: $%.2f\n',  cost_Chemicals_Per_Second_Sulfuric_Acid);
       fprintf('Current Total Cost Per Second: $%.2f\n',  cost_Total_Per_Second);
    end
    
    %%%%%%%%%%%%%%%%%%%%%%%%% END STAGE CALCULATION %%%%%%%%%%%%%%%%%%%%%%%
    
    
    %%%%%%%%%%%%%%%%%%% PRINT INTERMEDIATE DATA %%%%%%%%%%%%%%%%%%%%%%%%
    fprintf('Grams CuS per second: %.4f\n', grams_Per_Second_Copper_Sulfate);
    fprintf('Grams NH3 per second: %.4f\n', grams_Per_Second_Ammonia_Additional);
    fprintf('Grams H2SO4 per second: %.4f\n', grams_Per_Second_Sulfuric_Acid_Additional);
    %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
      
    fprintf('\n-------------------------------------------------------\nEND SIMULATION\n-------------------------------------------------------\n\n');
    
    if debug
        fprintf('Additional Moles of Ammonia Per Second: %.3f\n\n', num_Moles_Ammonia_Additional_Per_Second);
        fprintf('Additional Moles of Sulfuric Acid Per Second: %.3f\n\n', num_Moles_Sulfuric_Acid_Additional_Per_Second);
    end
    
    if debug
        fprintf('Grams Copper (II) Sulfate Per Second: %0.3fg\n', grams_Per_Second_Copper_Sulfate);
        fprintf('Grams Ammonia Per Second: %0.3fg\n', grams_Per_Second_Ammonia_Additional);
        fprintf('Grams Sulfuric Acid Per Second: %0.3fg\n', grams_Per_Second_Sulfuric_Acid_Additional);
        fprintf('Chemical Cost Per Second: $%.2f\n',  cost_Total_Per_Second - cost_Power_Per_Second);
    end

    fprintf('Final Concentration of Hydrogen Sulfide Per Second: %.4e\n', (num_Moles_Hydrogen_Sulfide_Per_Second_Final * MOLAR_MASS_HYDROGEN_SULFIDE) * MILLIGRAMS_PER_GRAM);
    if( ((num_Moles_Hydrogen_Sulfide_Per_Second_Final * MOLAR_MASS_HYDROGEN_SULFIDE) * MILLIGRAMS_PER_GRAM) < NGSWAT_100_THRESHOLD)
        fprintf('NGSWAT-100: PASS\n\n');
    else
        fprintf('NGSWAT-100: FAIL\n\n');
    end
    
    fprintf('Final Concentration of Ammonia Per Second: %.4e\n', (num_Moles_Ammonia_Per_Second_Final * MOLAR_MASS_AMMONIA) * MILLIGRAMS_PER_GRAM);
    if ( ((num_Moles_Ammonia_Per_Second_Final * MOLAR_MASS_AMMONIA) * MILLIGRAMS_PER_GRAM) < NGSWAT_200_THRESHOLD)
        fprintf('NGSWAT-200: PASS\n\n');
    else
        fprintf('NGSWAT-200: FAIL\n\n');
    end
    
    fprintf('Total Liters of Sour Water Treated: %i\n', volumetric_Flow_Rate);
    fprintf('Total Liters of Clean Water Produced: %.0f\n', (volumetric_Flow_Rate) * clean_Water_Production_Ratio);
    fprintf('Clean Water Production Percentage: %.10f\n', clean_Water_Production_Ratio * 100);
    if ( (clean_Water_Production_Ratio * 100) > NGSWAT_300_THRESHOLD)
        fprintf('NGSWAT-300: PASS\n\n');
    else
        fprintf('NGSWAT-300: FAIL\n\n');
    end
    
    fprintf('Total Cost Per Second: $%.2f\n', cost_Total_Per_Second);
    fprintf('Total Cost Per Liter: %.4f\n', cost_Total_Per_Second / (volumetric_Flow_Rate));
    if ( (cost_Total_Per_Second / (volumetric_Flow_Rate)) < NGSWAT_400_THRESHOLD)
        fprintf('NGSWAT-400: PASS\n\n');
    else
        fprintf('NGSWAT-400: FAIL\n\n');
    end
    
    statusMessage = 1;
end