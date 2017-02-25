Public Class frmMain

    Private MatLabHandle As Object
    Private simulationStarted As Boolean = False
    Private bInitialParameterChanged As Boolean = False
    Private bCostParametersChanged As Boolean = False
    Private bTimeIntervalChanged As Boolean = False
    Private total_FinalConcentration_Hydrogen_Sulfide As Double = 0.0
    Private total_FinalConcentration_Ammonia As Double = 0.0
    Private total_CleanWater_Percentage As Double = 0.0

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MatLabHandle = CreateObject("Matlab.Application")
        MatLabHandle.Execute("cd " + Application.StartupPath)
    End Sub

    'TODO: Move this to module
    Private Sub parseStatusMessage(ByVal statusMessage As String)
        Debug.Print(statusMessage)
        For Each line As String In statusMessage.Split(ControlChars.Lf)
            ' Check for Initial Condition Text
            If line.Contains("Volumetric Flow Rate") Then
                txtVolumetricFlowRate.Text = System.Text.RegularExpressions.Regex.Replace(line, "[^0-9.]", "")
            ElseIf line.Contains("Hydrogen Sulfide Concentration") Then
                txtHydrogenSulfideConcentration_Initial.Text = line.Split(":")(1).Trim()
            ElseIf line.Contains("Ammonia Concentration") Then
                txtAmmoniaConcentration_Initial.Text = line.Split(":")(1).Trim()
            ElseIf line.Contains("Water Concentration (ppm)") Then
                txtWaterConcentration.Text = line.Split(":")(1).Trim()
            ElseIf line.Contains("Max Applied Pressure") Then
                txtMaxPressure.Text = line.Split(":")(1).Trim()
                ' Check for Simulation Result Text
            ElseIf line.Contains("Final Concentration of Hydrogen Sulfide") Then
                txtCurrentHydrogenSulfideConcentration_Final.Text = line.Split(":")(1).Trim()
            ElseIf line.Contains("Final Concentration of Ammonia") Then
                txtCurrentAmmoniaConcentration_Final.Text = line.Split(":")(1).Trim()
            ElseIf line.Contains("Clean Water Production Percentage") Then
                txtCurrentCleanWaterPercentage.Text = line.Split(":")(1).Trim()
            ElseIf line.Contains("Total Cost of Simulation Per Liter") Then
                txtCurrentCostPerSecond.Text = "$" + line.Split(":")(1).Trim()
                ' Check for Intermediate Simulation Text
            ElseIf line.Contains("Grams CuS") Then
                txtGrams_CuS_Per_Second.Text = line.Split(":")(1).Trim()
            ElseIf line.Contains("Grams NH3") Then
                txtGrams_NH3_Per_Second.Text = line.Split(":")(1).Trim()
            ElseIf line.Contains("Grams H2SO4") Then
                txtGrams_H2SO4_Per_Second.Text = line.Split(":")(1).Trim()
                ' Check for KPP PASS/FAIL Results
            ElseIf line.Contains("NGSWAT-100") Then
                txtNGSWAT_100.Text = line.Split(":")(1).Trim()
            ElseIf line.Contains("NGSWAT-200") Then
                txtNGSWAT_200.Text = line.Split(":")(1).Trim()
            ElseIf line.Contains("NGSWAT-300") Then
                txtNGSWAT_300.Text = line.Split(":")(1).Trim()
            ElseIf line.Contains("NGSWAT-400") Then
                txtNGSWAT_400.Text = line.Split(":")(1).Trim()
            End If
        Next

        ' ----------------------------------------------
        ' Update values derived from MATLAB output
        '-----------------------------------------------
        ' Update current cost per second for this segment
        txtCurrentCostPerSecond.Text = FormatNumber((CDbl(txtCost_Per_Gram_Copper_Sulfate.Text) * CDbl(txtGrams_CuS_Per_Second.Text)) + (CDbl(txtCost_Per_Gram_Ammonia.Text) * CDbl(txtGrams_NH3_Per_Second.Text)) + (CDbl(txtCost_Per_Gram_Sulfuric_Acid.Text) * CDbl(txtGrams_H2SO4_Per_Second.Text)), 2)
        ' Update current segment cost per liter
        txtCurrentCostPerLiter.Text = FormatNumber((CDbl(txtCurrentCostPerSecond.Text) / CDbl(txtVolumetricFlowRate.Text)), 4)
    End Sub

    Private Sub tmrSim_Tick(sender As Object, e As EventArgs) Handles tmrSim.Tick
        ' Increment the simulation time counter
        txtSimTime.Text = CDbl(txtSimTime.Text) + 1
        ' Increment the segment time counter
        txtSegmentTime.Text = CDbl(txtSegmentTime.Text) + 1

        ' Update count for current volume treated for this segment
        txtCurrentVolumeTreated.Text = FormatNumber(CDbl(txtCurrentVolumeTreated.Text) + CDbl(txtVolumetricFlowRate.Text), 0)
        ' Update current segment cost
        txtCurrentCost.Text = FormatNumber(CDbl(txtCurrentCost.Text) + (CDbl(txtCurrentCostPerSecond.Text)), 2)

        updateSimulationDisplay()

        ' TODO: Check for KPP Fails

    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        Dim statusMessage As String

        ' Disable 'Start' command until 'Pause' or 'Stop' is selected
        cmdStart.Enabled = False
        cmdStop.Enabled = True
        cmdPause.Enabled = True

        ' Don't allow operator to change input fields
        disableInitialConditionFields()
        ' Clear calculated values
        initializeDisplayValues()

        statusMessage = MatLabHandle.Execute("simMain(" + txtVolumetricFlowRate.Text + "," + txtAmmoniaConcentration_Initial.Text + "," + txtHydrogenSulfideConcentration_Initial.Text + "," + txtMaxPressure.Text + "," + txtCost_Per_Gram_Copper_Sulfate.Text + "," + txtCost_Per_Gram_Ammonia.Text + "," + txtCost_Per_Gram_Sulfuric_Acid.Text + "," + txtCost_Per_kWh.Text + ")")
        parseStatusMessage(statusMessage)

        ' Set simulation timer based on user input
        tmrSim.Interval = CInt(txtTimePerStep.Text)
        ' Start simulation timer
        tmrSim.Enabled = True
        simulationStarted = True
    End Sub

    Private Sub cmdStop_Click(sender As Object, e As EventArgs) Handles cmdStop.Click
        ' Disable timer
        tmrSim.Enabled = False
        ' Enabled 'Start' command
        cmdStart.Enabled = True
        ' Disable 'Pause' command
        cmdPause.Enabled = False
        ' Disable 'Stop' command
        cmdStop.Enabled = False

        'Set Pause option for next simulation
        cmdPause.Text = "Pause Simulation"

        ' Allow operator to change input fields
        enableInitialConditionFields()
        ' Now that simulation has stopped, allow user to change Max Pressure, Volumetric Flow Rate and Cost per Gram
        txtMaxPressure.Enabled = True
        txtVolumetricFlowRate.Enabled = True
        txtCost_Per_Gram_Copper_Sulfate.Enabled = True
        txtCost_Per_Gram_Ammonia.Enabled = True
        txtCost_Per_Gram_Sulfuric_Acid.Enabled = True
        txtCost_Per_kWh.Enabled = True

        simulationStarted = False
    End Sub

    Private Sub cmdPause_Click(sender As Object, e As EventArgs) Handles cmdPause.Click
        If cmdPause.Text = "Resume Simulation" Then
            ' Change button text
            cmdPause.Text = "Pause Simulation"
            ' Don't allow operator to change input fields
            disableInitialConditionFields()

            ' Check if the user has changed a field that would cause MATLAB to recalculate values for the segment
            If (bCostParametersChanged = True OrElse bInitialParameterChanged = True) Then
                handleNewSegment()
                bCostParametersChanged = False
                bInitialParameterChanged = False
            End If
            If (bTimeIntervalChanged = True) Then
                ' Set simulation timer based on user input
                tmrSim.Interval = CInt(txtTimePerStep.Text)
                bTimeIntervalChanged = False
            End If

            ' Resume the timer
            tmrSim.Enabled = True
        ElseIf cmdPause.Text = "Pause Simulation" Then
            ' Pause the timer
            tmrSim.Enabled = False
            ' Change button text
            cmdPause.Text = "Resume Simulation"
            ' Allow operator to change input fields
            enableInitialConditionFields()
        End If
    End Sub

    Private Sub initializeDisplayValues()
        txtSimTime.Text = 0
        txtSegmentTime.Text = 0
        txtCurrentSegment.Text = 1
        txtCurrentCostPerSecond.Text = 0
        txtCurrentVolumeTreated.Text = 0
        txtCurrentCost.Text = 0
        txtCurrentCostPerLiter.Text = 0
        txtGrams_CuS_Per_Second.Text = 0
        txtGrams_NH3_Per_Second.Text = 0
        txtGrams_H2SO4_Per_Second.Text = 0
        txtCurrentHydrogenSulfideConcentration_Final.Text = 0
        txtCurrentAmmoniaConcentration_Final.Text = 0
        txtCurrentCleanWaterPercentage.Text = 0

        txtAverageHydrogenSulfideConcentration_Final.Text = -1
        txtMaxHydrogenSulfideConcentration_Final.Text = -1
        txtMinHydrogenSulfideConcentration_Final.Text = -1

        txtAverageAmmoniaConcentration_Final.Text = -1
        txtMaxAmmoniaConcentration_Final.Text = -1
        txtMinAmmoniaConcentration_Final.Text = -1

        txtAverageCleanWaterPercentage.Text = -1
        txtMaxCleanWaterPercentage.Text = -1
        txtMinCleanWaterPercentage.Text = -1

        txtAverageCostPerLiter.Text = -1
        txtMaxCostPerLiter.Text = -1
        txtMinCostPerLiter.Text = -1

        txtTotalVolumeTreated.Text = 0
        txtTotalCost.Text = 0
        txtNGSWAT_100.Text = ""
        txtNGSWAT_200.Text = ""
        txtNGSWAT_300.Text = ""
        txtNGSWAT_400.Text = ""
    End Sub

    Private Sub initializeSegmentDisplayValues()
        txtSegmentTime.Text = 0
        txtCurrentCostPerSecond.Text = 0
        txtCurrentVolumeTreated.Text = 0
        txtCurrentCost.Text = 0
        txtCurrentCostPerLiter.Text = 0
        txtGrams_CuS_Per_Second.Text = 0
        txtGrams_NH3_Per_Second.Text = 0
        txtGrams_H2SO4_Per_Second.Text = 0
        txtCurrentHydrogenSulfideConcentration_Final.Text = 0
        txtCurrentAmmoniaConcentration_Final.Text = 0
        txtCurrentCleanWaterPercentage.Text = 0
    End Sub

    Private Sub disableInitialConditionFields()
        txtHydrogenSulfideConcentration_Initial.Enabled = False
        txtAmmoniaConcentration_Initial.Enabled = False
        txtWaterConcentration.Enabled = False
        txtTimePerStep.Enabled = False
        txtMaxPressure.Enabled = False
        txtVolumetricFlowRate.Enabled = False
        txtCost_Per_Gram_Copper_Sulfate.Enabled = False
        txtCost_Per_Gram_Ammonia.Enabled = False
        txtCost_Per_Gram_Sulfuric_Acid.Enabled = False
        txtCost_Per_kWh.Enabled = False
    End Sub

    Private Sub enableInitialConditionFields()
        txtHydrogenSulfideConcentration_Initial.Enabled = True
        txtAmmoniaConcentration_Initial.Enabled = True
        txtWaterConcentration.Enabled = True
        txtTimePerStep.Enabled = True

        ' NOTE: Once simulation has started, do NOT let user change Cost per Gram, Max Pressure, or Volumetric Flow Rate
        'txtMaxPressure.Enabled = True
        'txtVolumetricFlowRate.Enabled = True
        'txtCost_Per_Gram_Copper_Sulfate.Enabled = True
        'txtCost_Per_Gram_Ammonia.Enabled = True
        'txtCost_Per_Gram_Sulfuric_Acid.Enabled = True
        'txtCost_Per_kWh.Enabled = True
    End Sub

    Private Sub handleNewSegment()
        Dim statusMessage As String

        ' Increment segment counter
        txtCurrentSegment.Text = CInt(txtCurrentSegment.Text) + 1

        ' Reset values in the Segment panel (Except Current Segment)
        initializeSegmentDisplayValues()

        ' Re-calculate Status from MATLAB
        statusMessage = MatLabHandle.Execute("simMain(" + txtVolumetricFlowRate.Text + "," + txtAmmoniaConcentration_Initial.Text + "," + txtHydrogenSulfideConcentration_Initial.Text + "," + txtMaxPressure.Text + "," + txtCost_Per_Gram_Copper_Sulfate.Text + "," + txtCost_Per_Gram_Ammonia.Text + "," + txtCost_Per_Gram_Sulfuric_Acid.Text + "," + txtCost_Per_kWh.Text + ")")
        parseStatusMessage(statusMessage)

    End Sub

    Private Sub cost_Parameter_TextChanged(sender As Object, e As EventArgs) Handles txtCost_Per_Gram_Copper_Sulfate.TextChanged, txtCost_Per_Gram_Ammonia.TextChanged, txtCost_Per_Gram_Sulfuric_Acid.TextChanged, txtCost_Per_kWh.TextChanged
        ' Ignore setting flag if parameters are changed without simulation running
        If simulationStarted Then
            bCostParametersChanged = True
        End If
    End Sub


    Private Sub initial_Parameter_TextChanged(sender As Object, e As EventArgs) Handles txtHydrogenSulfideConcentration_Initial.TextChanged, txtAmmoniaConcentration_Initial.TextChanged, txtWaterConcentration.TextChanged, txtMaxPressure.TextChanged, txtVolumetricFlowRate.TextChanged
        ' Ignore setting flag if parameters are changed without simulation running
        If simulationStarted Then
            bInitialParameterChanged = True
        End If
    End Sub


    Private Sub txtTimePerStep_TextChanged(sender As Object, e As EventArgs) Handles txtTimePerStep.TextChanged
        ' Ignore setting flag if parameters are changed without simulation running
        If simulationStarted Then
            bTimeIntervalChanged = True
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub updateSimulationDisplay()

        checkMinMaxValues()

        ' Update total simulation cost
        txtTotalCost.Text = FormatNumber(CDbl(txtTotalCost.Text) + (CDbl(txtCurrentCostPerSecond.Text)), 2)
        ' Update Total Volume Treated for entire simulation
        txtTotalVolumeTreated.Text = FormatNumber(CDbl(txtTotalVolumeTreated.Text) + CDbl(txtVolumetricFlowRate.Text), 0)


        ' Update Average Cost Per Liter for entire simulation
        txtAverageCostPerLiter.Text = FormatNumber(CDbl(txtTotalCost.Text) / CDbl(txtTotalVolumeTreated.Text), 4)

        ' NOTE: The equations below assume that the Volumetric Flow Rate is FIXED for a given simulation as it performs an aggregate average where each time step is equally weighted (i.e., equal flow)
        ' Update total final concentration of hydrogen sulfide
        total_FinalConcentration_Hydrogen_Sulfide = total_FinalConcentration_Hydrogen_Sulfide + CDbl(txtCurrentHydrogenSulfideConcentration_Final.Text)
        ' Update average concentration of hydrogen sulfide
        txtAverageHydrogenSulfideConcentration_Final.Text = (total_FinalConcentration_Hydrogen_Sulfide / CDbl(txtSimTime.Text)).ToString("0.0000e+0")

        ' Update total final concentration of ammonia
        total_FinalConcentration_Ammonia = total_FinalConcentration_Ammonia + CDbl(txtCurrentAmmoniaConcentration_Final.Text)
        ' Update average concentration of ammonia
        txtAverageAmmoniaConcentration_Final.Text = (total_FinalConcentration_Ammonia / CDbl(txtSimTime.Text)).ToString("0.0000e+0")

        ' Update total clean water percentage
        total_CleanWater_Percentage = total_CleanWater_Percentage + CDbl(txtCurrentCleanWaterPercentage.Text)
        ' Update average clean water percentage yield
        txtAverageCleanWaterPercentage.Text = FormatNumber(total_CleanWater_Percentage / CDbl(txtSimTime.Text), 6)
    End Sub

    Private Sub checkMinMaxValues()

        ' Max H2S Concentration
        If CDbl(txtMaxHydrogenSulfideConcentration_Final.Text) = -1 OrElse CDbl(txtMaxHydrogenSulfideConcentration_Final.Text) < CDbl(txtCurrentHydrogenSulfideConcentration_Final.Text) Then
            txtMaxHydrogenSulfideConcentration_Final.Text = txtCurrentHydrogenSulfideConcentration_Final.Text
        End If

        ' Min H2S Concentration
        If CDbl(txtMinHydrogenSulfideConcentration_Final.Text) = -1 OrElse CDbl(txtMinHydrogenSulfideConcentration_Final.Text) > CDbl(txtCurrentHydrogenSulfideConcentration_Final.Text) Then
            txtMinHydrogenSulfideConcentration_Final.Text = txtCurrentHydrogenSulfideConcentration_Final.Text
        End If

        ' Max NH3 Concentration
        If CDbl(txtMaxAmmoniaConcentration_Final.Text) = -1 OrElse CDbl(txtMaxAmmoniaConcentration_Final.Text) < CDbl(txtCurrentAmmoniaConcentration_Final.Text) Then
            txtMaxAmmoniaConcentration_Final.Text = txtCurrentAmmoniaConcentration_Final.Text
        End If

        ' Min NH3 Concentration
        If CDbl(txtMinAmmoniaConcentration_Final.Text) = -1 OrElse CDbl(txtMinAmmoniaConcentration_Final.Text) > CDbl(txtCurrentAmmoniaConcentration_Final.Text) Then
            txtMinAmmoniaConcentration_Final.Text = txtCurrentAmmoniaConcentration_Final.Text
        End If

        ' Max Clean Water Yield
        If CDbl(txtMaxCleanWaterPercentage.Text) = -1 OrElse CDbl(txtMaxCleanWaterPercentage.Text) < CDbl(txtCurrentCleanWaterPercentage.Text) Then
            txtMaxCleanWaterPercentage.Text = FormatNumber(CDbl(txtCurrentCleanWaterPercentage.Text), 6)
        End If

        ' Min Clean Water Yield
        If CDbl(txtMinCleanWaterPercentage.Text) = -1 OrElse CDbl(txtMinCleanWaterPercentage.Text) > CDbl(txtCurrentCleanWaterPercentage.Text) Then
            txtMinCleanWaterPercentage.Text = FormatNumber(CDbl(txtCurrentCleanWaterPercentage.Text), 6)
        End If

        ' Max Cost Per Liter
        If CDbl(txtMaxCostPerLiter.Text) = -1 OrElse CDbl(txtMaxCostPerLiter.Text) < CDbl(txtCurrentCostPerLiter.Text) Then
            txtMaxCostPerLiter.Text = FormatNumber(CDbl(txtCurrentCostPerLiter.Text), 4)
        End If

        ' Min Cost Per Liter
        If CDbl(txtMinCostPerLiter.Text) = -1 OrElse CDbl(txtMinCostPerLiter.Text) > CDbl(txtCurrentCostPerLiter.Text) Then
            txtMinCostPerLiter.Text = FormatNumber(CDbl(txtCurrentCostPerLiter.Text), 4)
        End If


    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
