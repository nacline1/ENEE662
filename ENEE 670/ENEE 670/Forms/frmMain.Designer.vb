<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTimePerStep = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtWaterConcentration = New System.Windows.Forms.TextBox()
        Me.txtCost_Per_kWh = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCost_Per_Gram_Sulfuric_Acid = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCost_Per_Gram_Ammonia = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCost_Per_Gram_Copper_Sulfate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtVolumetricFlowRate = New System.Windows.Forms.TextBox()
        Me.txtMaxPressure = New System.Windows.Forms.TextBox()
        Me.txtAmmoniaConcentration_Initial = New System.Windows.Forms.TextBox()
        Me.txtHydrogenSulfideConcentration_Initial = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Line2 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtMinCostPerLiter = New System.Windows.Forms.Label()
        Me.txtMaxCostPerLiter = New System.Windows.Forms.Label()
        Me.txtMinCleanWaterPercentage = New System.Windows.Forms.Label()
        Me.txtMaxCleanWaterPercentage = New System.Windows.Forms.Label()
        Me.txtMinAmmoniaConcentration_Final = New System.Windows.Forms.Label()
        Me.txtMaxAmmoniaConcentration_Final = New System.Windows.Forms.Label()
        Me.txtMinHydrogenSulfideConcentration_Final = New System.Windows.Forms.Label()
        Me.txtMaxHydrogenSulfideConcentration_Final = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtAverageCostPerLiter = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAverageHydrogenSulfideConcentration_Final = New System.Windows.Forms.Label()
        Me.txtTotalCost = New System.Windows.Forms.Label()
        Me.txtAverageCleanWaterPercentage = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAverageAmmoniaConcentration_Final = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtTotalVolumeTreated = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCurrentCostPerSecond = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNGSWAT_100 = New System.Windows.Forms.Label()
        Me.txtNGSWAT_400 = New System.Windows.Forms.Label()
        Me.txtNGSWAT_200 = New System.Windows.Forms.Label()
        Me.txtNGSWAT_300 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtSegmentTime = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtCurrentSegment = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtCurrentCostPerLiter = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtCurrentCost = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtCurrentVolumeTreated = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtCurrentHydrogenSulfideConcentration_Final = New System.Windows.Forms.Label()
        Me.txtCurrentCleanWaterPercentage = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtCurrentAmmoniaConcentration_Final = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtGrams_NH3_Per_Second = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtGrams_H2SO4_Per_Second = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtGrams_CuS_Per_Second = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtSimTime = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tmrSim = New System.Windows.Forms.Timer(Me.components)
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.cmdPause = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(499, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Volumetric Flow Rate (L/s)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Hydrogen Sulfide Concentration (ppm)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(131, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 33)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ammonia Concentration (ppm)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(253, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 33)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Water Concentration (ppm)"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(375, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 33)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Max Applied Pressure (kPa)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(658, 41)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(117, 23)
        Me.cmdStart.TabIndex = 10
        Me.cmdStart.Text = "Start Simulation"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTimePerStep)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.txtWaterConcentration)
        Me.GroupBox1.Controls.Add(Me.txtCost_Per_kWh)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtCost_Per_Gram_Sulfuric_Acid)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtCost_Per_Gram_Ammonia)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtCost_Per_Gram_Copper_Sulfate)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtVolumetricFlowRate)
        Me.GroupBox1.Controls.Add(Me.txtMaxPressure)
        Me.GroupBox1.Controls.Add(Me.txtAmmoniaConcentration_Initial)
        Me.GroupBox1.Controls.Add(Me.txtHydrogenSulfideConcentration_Initial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(625, 195)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Initial Conditions"
        '
        'txtTimePerStep
        '
        Me.txtTimePerStep.Location = New System.Drawing.Point(503, 96)
        Me.txtTimePerStep.Name = "txtTimePerStep"
        Me.txtTimePerStep.Size = New System.Drawing.Size(116, 20)
        Me.txtTimePerStep.TabIndex = 27
        Me.txtTimePerStep.Text = "1000"
        Me.txtTimePerStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(503, 119)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(116, 23)
        Me.Label30.TabIndex = 26
        Me.Label30.Text = "Time Per Step (ms)"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtWaterConcentration
        '
        Me.txtWaterConcentration.BackColor = System.Drawing.SystemColors.Control
        Me.txtWaterConcentration.Location = New System.Drawing.Point(253, 33)
        Me.txtWaterConcentration.Name = "txtWaterConcentration"
        Me.txtWaterConcentration.ReadOnly = True
        Me.txtWaterConcentration.Size = New System.Drawing.Size(116, 20)
        Me.txtWaterConcentration.TabIndex = 25
        Me.txtWaterConcentration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCost_Per_kWh
        '
        Me.txtCost_Per_kWh.Location = New System.Drawing.Point(375, 96)
        Me.txtCost_Per_kWh.Name = "txtCost_Per_kWh"
        Me.txtCost_Per_kWh.Size = New System.Drawing.Size(116, 20)
        Me.txtCost_Per_kWh.TabIndex = 24
        Me.txtCost_Per_kWh.Text = "0.12"
        Me.txtCost_Per_kWh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(375, 119)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(116, 31)
        Me.Label19.TabIndex = 23
        Me.Label19.Text = "Cost per Kilowatt Hour ($)"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCost_Per_Gram_Sulfuric_Acid
        '
        Me.txtCost_Per_Gram_Sulfuric_Acid.Location = New System.Drawing.Point(253, 96)
        Me.txtCost_Per_Gram_Sulfuric_Acid.Name = "txtCost_Per_Gram_Sulfuric_Acid"
        Me.txtCost_Per_Gram_Sulfuric_Acid.Size = New System.Drawing.Size(116, 20)
        Me.txtCost_Per_Gram_Sulfuric_Acid.TabIndex = 22
        Me.txtCost_Per_Gram_Sulfuric_Acid.Text = "0.000814"
        Me.txtCost_Per_Gram_Sulfuric_Acid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(253, 119)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(116, 31)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Cost of Sulfuric Acid Per Gram ($)"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCost_Per_Gram_Ammonia
        '
        Me.txtCost_Per_Gram_Ammonia.Location = New System.Drawing.Point(131, 96)
        Me.txtCost_Per_Gram_Ammonia.Name = "txtCost_Per_Gram_Ammonia"
        Me.txtCost_Per_Gram_Ammonia.Size = New System.Drawing.Size(116, 20)
        Me.txtCost_Per_Gram_Ammonia.TabIndex = 20
        Me.txtCost_Per_Gram_Ammonia.Text = "0.09921"
        Me.txtCost_Per_Gram_Ammonia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(131, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 31)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Cost of Ammonia Per Gram ($)"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCost_Per_Gram_Copper_Sulfate
        '
        Me.txtCost_Per_Gram_Copper_Sulfate.Location = New System.Drawing.Point(9, 96)
        Me.txtCost_Per_Gram_Copper_Sulfate.Name = "txtCost_Per_Gram_Copper_Sulfate"
        Me.txtCost_Per_Gram_Copper_Sulfate.Size = New System.Drawing.Size(116, 20)
        Me.txtCost_Per_Gram_Copper_Sulfate.TabIndex = 18
        Me.txtCost_Per_Gram_Copper_Sulfate.Text = "0.0976"
        Me.txtCost_Per_Gram_Copper_Sulfate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(9, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 31)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Cost of Copper Sulfide Per Gram ($)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVolumetricFlowRate
        '
        Me.txtVolumetricFlowRate.Location = New System.Drawing.Point(499, 32)
        Me.txtVolumetricFlowRate.Name = "txtVolumetricFlowRate"
        Me.txtVolumetricFlowRate.Size = New System.Drawing.Size(116, 20)
        Me.txtVolumetricFlowRate.TabIndex = 16
        Me.txtVolumetricFlowRate.Text = "315.45"
        Me.txtVolumetricFlowRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMaxPressure
        '
        Me.txtMaxPressure.Location = New System.Drawing.Point(375, 32)
        Me.txtMaxPressure.Name = "txtMaxPressure"
        Me.txtMaxPressure.Size = New System.Drawing.Size(116, 20)
        Me.txtMaxPressure.TabIndex = 15
        Me.txtMaxPressure.Text = "70000"
        Me.txtMaxPressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAmmoniaConcentration_Initial
        '
        Me.txtAmmoniaConcentration_Initial.Location = New System.Drawing.Point(131, 32)
        Me.txtAmmoniaConcentration_Initial.Name = "txtAmmoniaConcentration_Initial"
        Me.txtAmmoniaConcentration_Initial.Size = New System.Drawing.Size(116, 20)
        Me.txtAmmoniaConcentration_Initial.TabIndex = 14
        Me.txtAmmoniaConcentration_Initial.Text = "34"
        Me.txtAmmoniaConcentration_Initial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtHydrogenSulfideConcentration_Initial
        '
        Me.txtHydrogenSulfideConcentration_Initial.Location = New System.Drawing.Point(9, 32)
        Me.txtHydrogenSulfideConcentration_Initial.Name = "txtHydrogenSulfideConcentration_Initial"
        Me.txtHydrogenSulfideConcentration_Initial.Size = New System.Drawing.Size(116, 20)
        Me.txtHydrogenSulfideConcentration_Initial.TabIndex = 13
        Me.txtHydrogenSulfideConcentration_Initial.Text = "17"
        Me.txtHydrogenSulfideConcentration_Initial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Line2)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.txtMinCostPerLiter)
        Me.GroupBox2.Controls.Add(Me.txtMaxCostPerLiter)
        Me.GroupBox2.Controls.Add(Me.txtMinCleanWaterPercentage)
        Me.GroupBox2.Controls.Add(Me.txtMaxCleanWaterPercentage)
        Me.GroupBox2.Controls.Add(Me.txtMinAmmoniaConcentration_Final)
        Me.GroupBox2.Controls.Add(Me.txtMaxAmmoniaConcentration_Final)
        Me.GroupBox2.Controls.Add(Me.txtMinHydrogenSulfideConcentration_Final)
        Me.GroupBox2.Controls.Add(Me.txtMaxHydrogenSulfideConcentration_Final)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txtAverageCostPerLiter)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtAverageHydrogenSulfideConcentration_Final)
        Me.GroupBox2.Controls.Add(Me.txtTotalCost)
        Me.GroupBox2.Controls.Add(Me.txtAverageCleanWaterPercentage)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtAverageAmmoniaConcentration_Final)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtTotalVolumeTreated)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 447)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(745, 177)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Simulation Results"
        '
        'Line2
        '
        Me.Line2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Line2.Location = New System.Drawing.Point(585, 7)
        Me.Line2.Name = "Line2"
        Me.Line2.Size = New System.Drawing.Size(2, 168)
        Me.Line2.TabIndex = 507
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(6, 62)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(58, 23)
        Me.Label37.TabIndex = 30
        Me.Label37.Text = "Average"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(0, 137)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(58, 23)
        Me.Label36.TabIndex = 29
        Me.Label36.Text = "Min"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(1, 99)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(58, 23)
        Me.Label33.TabIndex = 28
        Me.Label33.Text = "Max"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMinCostPerLiter
        '
        Me.txtMinCostPerLiter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtMinCostPerLiter.Location = New System.Drawing.Point(441, 137)
        Me.txtMinCostPerLiter.Name = "txtMinCostPerLiter"
        Me.txtMinCostPerLiter.Size = New System.Drawing.Size(116, 20)
        Me.txtMinCostPerLiter.TabIndex = 27
        Me.txtMinCostPerLiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMaxCostPerLiter
        '
        Me.txtMaxCostPerLiter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtMaxCostPerLiter.Location = New System.Drawing.Point(441, 101)
        Me.txtMaxCostPerLiter.Name = "txtMaxCostPerLiter"
        Me.txtMaxCostPerLiter.Size = New System.Drawing.Size(116, 20)
        Me.txtMaxCostPerLiter.TabIndex = 26
        Me.txtMaxCostPerLiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMinCleanWaterPercentage
        '
        Me.txtMinCleanWaterPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtMinCleanWaterPercentage.Location = New System.Drawing.Point(312, 137)
        Me.txtMinCleanWaterPercentage.Name = "txtMinCleanWaterPercentage"
        Me.txtMinCleanWaterPercentage.Size = New System.Drawing.Size(116, 20)
        Me.txtMinCleanWaterPercentage.TabIndex = 21
        Me.txtMinCleanWaterPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMaxCleanWaterPercentage
        '
        Me.txtMaxCleanWaterPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtMaxCleanWaterPercentage.Location = New System.Drawing.Point(312, 101)
        Me.txtMaxCleanWaterPercentage.Name = "txtMaxCleanWaterPercentage"
        Me.txtMaxCleanWaterPercentage.Size = New System.Drawing.Size(116, 20)
        Me.txtMaxCleanWaterPercentage.TabIndex = 20
        Me.txtMaxCleanWaterPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMinAmmoniaConcentration_Final
        '
        Me.txtMinAmmoniaConcentration_Final.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtMinAmmoniaConcentration_Final.Location = New System.Drawing.Point(190, 137)
        Me.txtMinAmmoniaConcentration_Final.Name = "txtMinAmmoniaConcentration_Final"
        Me.txtMinAmmoniaConcentration_Final.Size = New System.Drawing.Size(116, 20)
        Me.txtMinAmmoniaConcentration_Final.TabIndex = 19
        Me.txtMinAmmoniaConcentration_Final.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMaxAmmoniaConcentration_Final
        '
        Me.txtMaxAmmoniaConcentration_Final.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtMaxAmmoniaConcentration_Final.Location = New System.Drawing.Point(190, 101)
        Me.txtMaxAmmoniaConcentration_Final.Name = "txtMaxAmmoniaConcentration_Final"
        Me.txtMaxAmmoniaConcentration_Final.Size = New System.Drawing.Size(116, 20)
        Me.txtMaxAmmoniaConcentration_Final.TabIndex = 18
        Me.txtMaxAmmoniaConcentration_Final.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMinHydrogenSulfideConcentration_Final
        '
        Me.txtMinHydrogenSulfideConcentration_Final.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtMinHydrogenSulfideConcentration_Final.Location = New System.Drawing.Point(68, 137)
        Me.txtMinHydrogenSulfideConcentration_Final.Name = "txtMinHydrogenSulfideConcentration_Final"
        Me.txtMinHydrogenSulfideConcentration_Final.Size = New System.Drawing.Size(116, 20)
        Me.txtMinHydrogenSulfideConcentration_Final.TabIndex = 17
        Me.txtMinHydrogenSulfideConcentration_Final.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMaxHydrogenSulfideConcentration_Final
        '
        Me.txtMaxHydrogenSulfideConcentration_Final.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtMaxHydrogenSulfideConcentration_Final.Location = New System.Drawing.Point(68, 101)
        Me.txtMaxHydrogenSulfideConcentration_Final.Name = "txtMaxHydrogenSulfideConcentration_Final"
        Me.txtMaxHydrogenSulfideConcentration_Final.Size = New System.Drawing.Size(116, 20)
        Me.txtMaxHydrogenSulfideConcentration_Final.TabIndex = 16
        Me.txtMaxHydrogenSulfideConcentration_Final.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.Location = New System.Drawing.Point(441, 30)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(116, 23)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "Cost Per Liter ($ / L)"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAverageCostPerLiter
        '
        Me.txtAverageCostPerLiter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtAverageCostPerLiter.Location = New System.Drawing.Point(440, 62)
        Me.txtAverageCostPerLiter.Name = "txtAverageCostPerLiter"
        Me.txtAverageCostPerLiter.Size = New System.Drawing.Size(116, 20)
        Me.txtAverageCostPerLiter.TabIndex = 14
        Me.txtAverageCostPerLiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(312, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 30)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Clean Water Percentage"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAverageHydrogenSulfideConcentration_Final
        '
        Me.txtAverageHydrogenSulfideConcentration_Final.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtAverageHydrogenSulfideConcentration_Final.Location = New System.Drawing.Point(68, 62)
        Me.txtAverageHydrogenSulfideConcentration_Final.Name = "txtAverageHydrogenSulfideConcentration_Final"
        Me.txtAverageHydrogenSulfideConcentration_Final.Size = New System.Drawing.Size(116, 20)
        Me.txtAverageHydrogenSulfideConcentration_Final.TabIndex = 2
        Me.txtAverageHydrogenSulfideConcentration_Final.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalCost
        '
        Me.txtTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTotalCost.Location = New System.Drawing.Point(607, 114)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.Size = New System.Drawing.Size(116, 20)
        Me.txtTotalCost.TabIndex = 12
        Me.txtTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAverageCleanWaterPercentage
        '
        Me.txtAverageCleanWaterPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtAverageCleanWaterPercentage.Location = New System.Drawing.Point(312, 62)
        Me.txtAverageCleanWaterPercentage.Name = "txtAverageCleanWaterPercentage"
        Me.txtAverageCleanWaterPercentage.Size = New System.Drawing.Size(116, 20)
        Me.txtAverageCleanWaterPercentage.TabIndex = 8
        Me.txtAverageCleanWaterPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.Location = New System.Drawing.Point(607, 138)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(116, 23)
        Me.Label24.TabIndex = 13
        Me.Label24.Text = "Total Cost"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(68, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 34)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Hydrogen Sulfide Concentration (ppm)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(607, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 23)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Total Liters Treated"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAverageAmmoniaConcentration_Final
        '
        Me.txtAverageAmmoniaConcentration_Final.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtAverageAmmoniaConcentration_Final.Location = New System.Drawing.Point(190, 62)
        Me.txtAverageAmmoniaConcentration_Final.Name = "txtAverageAmmoniaConcentration_Final"
        Me.txtAverageAmmoniaConcentration_Final.Size = New System.Drawing.Size(116, 20)
        Me.txtAverageAmmoniaConcentration_Final.TabIndex = 4
        Me.txtAverageAmmoniaConcentration_Final.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(190, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(116, 27)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Ammonia Concentration (ppm)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalVolumeTreated
        '
        Me.txtTotalVolumeTreated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTotalVolumeTreated.Location = New System.Drawing.Point(607, 58)
        Me.txtTotalVolumeTreated.Name = "txtTotalVolumeTreated"
        Me.txtTotalVolumeTreated.Size = New System.Drawing.Size(116, 20)
        Me.txtTotalVolumeTreated.TabIndex = 6
        Me.txtTotalVolumeTreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(127, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 30)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Segment Cost Per Second"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCurrentCostPerSecond
        '
        Me.txtCurrentCostPerSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCurrentCostPerSecond.Location = New System.Drawing.Point(141, 25)
        Me.txtCurrentCostPerSecond.Name = "txtCurrentCostPerSecond"
        Me.txtCurrentCostPerSecond.Size = New System.Drawing.Size(116, 20)
        Me.txtCurrentCostPerSecond.TabIndex = 10
        Me.txtCurrentCostPerSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtNGSWAT_100)
        Me.GroupBox3.Controls.Add(Me.txtNGSWAT_400)
        Me.GroupBox3.Controls.Add(Me.txtNGSWAT_200)
        Me.GroupBox3.Controls.Add(Me.txtNGSWAT_300)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 636)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(568, 71)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "KPP Analysis"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Result"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNGSWAT_100
        '
        Me.txtNGSWAT_100.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtNGSWAT_100.Location = New System.Drawing.Point(75, 37)
        Me.txtNGSWAT_100.Name = "txtNGSWAT_100"
        Me.txtNGSWAT_100.Size = New System.Drawing.Size(116, 20)
        Me.txtNGSWAT_100.TabIndex = 2
        Me.txtNGSWAT_100.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNGSWAT_400
        '
        Me.txtNGSWAT_400.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtNGSWAT_400.Location = New System.Drawing.Point(441, 37)
        Me.txtNGSWAT_400.Name = "txtNGSWAT_400"
        Me.txtNGSWAT_400.Size = New System.Drawing.Size(116, 20)
        Me.txtNGSWAT_400.TabIndex = 8
        Me.txtNGSWAT_400.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNGSWAT_200
        '
        Me.txtNGSWAT_200.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtNGSWAT_200.Location = New System.Drawing.Point(197, 37)
        Me.txtNGSWAT_200.Name = "txtNGSWAT_200"
        Me.txtNGSWAT_200.Size = New System.Drawing.Size(116, 20)
        Me.txtNGSWAT_200.TabIndex = 4
        Me.txtNGSWAT_200.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNGSWAT_300
        '
        Me.txtNGSWAT_300.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtNGSWAT_300.Location = New System.Drawing.Point(319, 37)
        Me.txtNGSWAT_300.Name = "txtNGSWAT_300"
        Me.txtNGSWAT_300.Size = New System.Drawing.Size(116, 20)
        Me.txtNGSWAT_300.TabIndex = 6
        Me.txtNGSWAT_300.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(441, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 30)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "NGSWAT-400"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(75, 13)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 23)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "NGSWAT-100"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(319, 14)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(116, 23)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "NGSWAT-300"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(197, 13)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(116, 23)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "NGSWAT-200"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtSegmentTime)
        Me.GroupBox4.Controls.Add(Me.Label35)
        Me.GroupBox4.Controls.Add(Me.txtCurrentSegment)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.txtCurrentCostPerLiter)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.txtCurrentCost)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.txtCurrentVolumeTreated)
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.txtCurrentCostPerSecond)
        Me.GroupBox4.Controls.Add(Me.GroupBox6)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(27, 233)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(745, 201)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Simulation Segment Status"
        '
        'txtSegmentTime
        '
        Me.txtSegmentTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtSegmentTime.Location = New System.Drawing.Point(12, 87)
        Me.txtSegmentTime.Name = "txtSegmentTime"
        Me.txtSegmentTime.Size = New System.Drawing.Size(116, 20)
        Me.txtSegmentTime.TabIndex = 20
        Me.txtSegmentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(12, 111)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(116, 23)
        Me.Label35.TabIndex = 21
        Me.Label35.Text = "Segment Ticks"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCurrentSegment
        '
        Me.txtCurrentSegment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCurrentSegment.Location = New System.Drawing.Point(12, 25)
        Me.txtCurrentSegment.Name = "txtCurrentSegment"
        Me.txtCurrentSegment.Size = New System.Drawing.Size(116, 20)
        Me.txtCurrentSegment.TabIndex = 18
        Me.txtCurrentSegment.Text = "1"
        Me.txtCurrentSegment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(12, 49)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(116, 23)
        Me.Label34.TabIndex = 19
        Me.Label34.Text = "Current Segment"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCurrentCostPerLiter
        '
        Me.txtCurrentCostPerLiter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCurrentCostPerLiter.Location = New System.Drawing.Point(141, 137)
        Me.txtCurrentCostPerLiter.Name = "txtCurrentCostPerLiter"
        Me.txtCurrentCostPerLiter.Size = New System.Drawing.Size(116, 20)
        Me.txtCurrentCostPerLiter.TabIndex = 16
        Me.txtCurrentCostPerLiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(141, 161)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(116, 23)
        Me.Label32.TabIndex = 17
        Me.Label32.Text = "Segment Cost Per Liter"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCurrentCost
        '
        Me.txtCurrentCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCurrentCost.Location = New System.Drawing.Point(141, 87)
        Me.txtCurrentCost.Name = "txtCurrentCost"
        Me.txtCurrentCost.Size = New System.Drawing.Size(116, 20)
        Me.txtCurrentCost.TabIndex = 14
        Me.txtCurrentCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(136, 109)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(128, 23)
        Me.Label31.TabIndex = 15
        Me.Label31.Text = "Total Segment Cost ($)"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(12, 161)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(116, 28)
        Me.Label28.TabIndex = 13
        Me.Label28.Text = "Segment Liters Treated"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCurrentVolumeTreated
        '
        Me.txtCurrentVolumeTreated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCurrentVolumeTreated.Location = New System.Drawing.Point(12, 137)
        Me.txtCurrentVolumeTreated.Name = "txtCurrentVolumeTreated"
        Me.txtCurrentVolumeTreated.Size = New System.Drawing.Size(116, 20)
        Me.txtCurrentVolumeTreated.TabIndex = 12
        Me.txtCurrentVolumeTreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label29)
        Me.GroupBox7.Controls.Add(Me.txtCurrentHydrogenSulfideConcentration_Final)
        Me.GroupBox7.Controls.Add(Me.txtCurrentCleanWaterPercentage)
        Me.GroupBox7.Controls.Add(Me.Label26)
        Me.GroupBox7.Controls.Add(Me.txtCurrentAmmoniaConcentration_Final)
        Me.GroupBox7.Controls.Add(Me.Label27)
        Me.GroupBox7.Location = New System.Drawing.Point(311, 99)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(403, 83)
        Me.GroupBox7.TabIndex = 10
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Stage 3"
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(278, 41)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(116, 30)
        Me.Label29.TabIndex = 13
        Me.Label29.Text = "Segment Clean Water Percentage"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCurrentHydrogenSulfideConcentration_Final
        '
        Me.txtCurrentHydrogenSulfideConcentration_Final.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCurrentHydrogenSulfideConcentration_Final.Location = New System.Drawing.Point(15, 16)
        Me.txtCurrentHydrogenSulfideConcentration_Final.Name = "txtCurrentHydrogenSulfideConcentration_Final"
        Me.txtCurrentHydrogenSulfideConcentration_Final.Size = New System.Drawing.Size(116, 20)
        Me.txtCurrentHydrogenSulfideConcentration_Final.TabIndex = 4
        Me.txtCurrentHydrogenSulfideConcentration_Final.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCurrentCleanWaterPercentage
        '
        Me.txtCurrentCleanWaterPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCurrentCleanWaterPercentage.Location = New System.Drawing.Point(278, 16)
        Me.txtCurrentCleanWaterPercentage.Name = "txtCurrentCleanWaterPercentage"
        Me.txtCurrentCleanWaterPercentage.Size = New System.Drawing.Size(116, 20)
        Me.txtCurrentCleanWaterPercentage.TabIndex = 12
        Me.txtCurrentCleanWaterPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(156, 40)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(116, 30)
        Me.Label26.TabIndex = 7
        Me.Label26.Text = "Segment Ammonia Concentration (ppm)"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCurrentAmmoniaConcentration_Final
        '
        Me.txtCurrentAmmoniaConcentration_Final.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCurrentAmmoniaConcentration_Final.Location = New System.Drawing.Point(156, 16)
        Me.txtCurrentAmmoniaConcentration_Final.Name = "txtCurrentAmmoniaConcentration_Final"
        Me.txtCurrentAmmoniaConcentration_Final.Size = New System.Drawing.Size(116, 20)
        Me.txtCurrentAmmoniaConcentration_Final.TabIndex = 6
        Me.txtCurrentAmmoniaConcentration_Final.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(15, 40)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(116, 34)
        Me.Label27.TabIndex = 5
        Me.Label27.Text = "Segment Hydrogen Sulfide Concentration (ppm)"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtGrams_NH3_Per_Second)
        Me.GroupBox6.Controls.Add(Me.Label22)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.txtGrams_H2SO4_Per_Second)
        Me.GroupBox6.Location = New System.Drawing.Point(460, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(254, 74)
        Me.GroupBox6.TabIndex = 9
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Stage 2"
        '
        'txtGrams_NH3_Per_Second
        '
        Me.txtGrams_NH3_Per_Second.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtGrams_NH3_Per_Second.Location = New System.Drawing.Point(7, 16)
        Me.txtGrams_NH3_Per_Second.Name = "txtGrams_NH3_Per_Second"
        Me.txtGrams_NH3_Per_Second.Size = New System.Drawing.Size(116, 20)
        Me.txtGrams_NH3_Per_Second.TabIndex = 4
        Me.txtGrams_NH3_Per_Second.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(129, 40)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(116, 23)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Grams of H2SO4 / s"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(7, 40)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(116, 23)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "Grams of NH3 / s"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtGrams_H2SO4_Per_Second
        '
        Me.txtGrams_H2SO4_Per_Second.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtGrams_H2SO4_Per_Second.Location = New System.Drawing.Point(129, 16)
        Me.txtGrams_H2SO4_Per_Second.Name = "txtGrams_H2SO4_Per_Second"
        Me.txtGrams_H2SO4_Per_Second.Size = New System.Drawing.Size(116, 20)
        Me.txtGrams_H2SO4_Per_Second.TabIndex = 6
        Me.txtGrams_H2SO4_Per_Second.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtGrams_CuS_Per_Second)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Location = New System.Drawing.Point(311, 19)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(143, 74)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Stage 1"
        '
        'txtGrams_CuS_Per_Second
        '
        Me.txtGrams_CuS_Per_Second.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtGrams_CuS_Per_Second.Location = New System.Drawing.Point(15, 18)
        Me.txtGrams_CuS_Per_Second.Name = "txtGrams_CuS_Per_Second"
        Me.txtGrams_CuS_Per_Second.Size = New System.Drawing.Size(116, 20)
        Me.txtGrams_CuS_Per_Second.TabIndex = 2
        Me.txtGrams_CuS_Per_Second.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(15, 42)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(116, 23)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Grams of CuS / s"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSimTime
        '
        Me.txtSimTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtSimTime.Location = New System.Drawing.Point(659, 181)
        Me.txtSimTime.Name = "txtSimTime"
        Me.txtSimTime.Size = New System.Drawing.Size(116, 20)
        Me.txtSimTime.TabIndex = 10
        Me.txtSimTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(659, 205)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 23)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Simulation Ticks"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmrSim
        '
        Me.tmrSim.Interval = 1000
        '
        'cmdStop
        '
        Me.cmdStop.Enabled = False
        Me.cmdStop.Location = New System.Drawing.Point(658, 137)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(117, 23)
        Me.cmdStop.TabIndex = 14
        Me.cmdStop.Text = "Stop Simulation"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'cmdPause
        '
        Me.cmdPause.Enabled = False
        Me.cmdPause.Location = New System.Drawing.Point(658, 89)
        Me.cmdPause.Name = "cmdPause"
        Me.cmdPause.Size = New System.Drawing.Size(117, 23)
        Me.cmdPause.TabIndex = 15
        Me.cmdPause.Text = "Pause Simulation"
        Me.cmdPause.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(788, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 738)
        Me.Controls.Add(Me.cmdPause)
        Me.Controls.Add(Me.cmdStop)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.txtSimTime)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Training"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAverageHydrogenSulfideConcentration_Final As System.Windows.Forms.Label
    Friend WithEvents txtAverageCleanWaterPercentage As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAverageAmmoniaConcentration_Final As System.Windows.Forms.Label
    Friend WithEvents txtTotalVolumeTreated As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentCostPerSecond As System.Windows.Forms.Label
    Friend WithEvents txtVolumetricFlowRate As System.Windows.Forms.TextBox
    Friend WithEvents txtMaxPressure As System.Windows.Forms.TextBox
    Friend WithEvents txtAmmoniaConcentration_Initial As System.Windows.Forms.TextBox
    Friend WithEvents txtHydrogenSulfideConcentration_Initial As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNGSWAT_100 As System.Windows.Forms.Label
    Friend WithEvents txtNGSWAT_400 As System.Windows.Forms.Label
    Friend WithEvents txtNGSWAT_200 As System.Windows.Forms.Label
    Friend WithEvents txtNGSWAT_300 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGrams_CuS_Per_Second As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtGrams_NH3_Per_Second As System.Windows.Forms.Label
    Friend WithEvents txtGrams_H2SO4_Per_Second As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents tmrSim As System.Windows.Forms.Timer
    Friend WithEvents txtSimTime As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents txtCost_Per_kWh As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCost_Per_Gram_Sulfuric_Acid As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCost_Per_Gram_Ammonia As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCost_Per_Gram_Copper_Sulfate As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCost As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentHydrogenSulfideConcentration_Final As System.Windows.Forms.Label
    Friend WithEvents txtCurrentCleanWaterPercentage As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentAmmoniaConcentration_Final As System.Windows.Forms.Label
    Friend WithEvents cmdPause As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtAverageCostPerLiter As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentVolumeTreated As System.Windows.Forms.Label
    Friend WithEvents txtWaterConcentration As System.Windows.Forms.TextBox
    Friend WithEvents txtCurrentCost As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentCostPerLiter As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtTimePerStep As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentSegment As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtSegmentTime As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtMinCostPerLiter As System.Windows.Forms.Label
    Friend WithEvents txtMaxCostPerLiter As System.Windows.Forms.Label
    Friend WithEvents txtMinCleanWaterPercentage As System.Windows.Forms.Label
    Friend WithEvents txtMaxCleanWaterPercentage As System.Windows.Forms.Label
    Friend WithEvents txtMinAmmoniaConcentration_Final As System.Windows.Forms.Label
    Friend WithEvents txtMaxAmmoniaConcentration_Final As System.Windows.Forms.Label
    Friend WithEvents txtMinHydrogenSulfideConcentration_Final As System.Windows.Forms.Label
    Friend WithEvents txtMaxHydrogenSulfideConcentration_Final As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Public WithEvents Line2 As System.Windows.Forms.Label

End Class
