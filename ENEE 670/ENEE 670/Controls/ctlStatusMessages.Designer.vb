<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlStatusMessages
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.dgvStatusMessages = New System.Windows.Forms.DataGridView()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdDetails = New System.Windows.Forms.Button()
        Me.colTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colText = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvStatusMessages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvStatusMessages
        '
        Me.dgvStatusMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStatusMessages.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTime, Me.colStatus, Me.colText})
        Me.dgvStatusMessages.Location = New System.Drawing.Point(0, 0)
        Me.dgvStatusMessages.Name = "dgvStatusMessages"
        Me.dgvStatusMessages.Size = New System.Drawing.Size(341, 157)
        Me.dgvStatusMessages.TabIndex = 0
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(71, 163)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(75, 23)
        Me.cmdDelete.TabIndex = 1
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdDetails
        '
        Me.cmdDetails.Location = New System.Drawing.Point(189, 163)
        Me.cmdDetails.Name = "cmdDetails"
        Me.cmdDetails.Size = New System.Drawing.Size(75, 23)
        Me.cmdDetails.TabIndex = 2
        Me.cmdDetails.Text = "Details"
        Me.cmdDetails.UseVisualStyleBackColor = True
        '
        'colTime
        '
        Me.colTime.HeaderText = "Time"
        Me.colTime.Name = "colTime"
        '
        'colStatus
        '
        Me.colStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 62
        '
        'colText
        '
        Me.colText.HeaderText = "Text"
        Me.colText.Name = "colText"
        Me.colText.Width = 135
        '
        'ctlStatusMessages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cmdDetails)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.dgvStatusMessages)
        Me.Name = "ctlStatusMessages"
        Me.Size = New System.Drawing.Size(341, 191)
        CType(Me.dgvStatusMessages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvStatusMessages As System.Windows.Forms.DataGridView
    Friend WithEvents colTime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStatus As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colText As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdDetails As System.Windows.Forms.Button

End Class
