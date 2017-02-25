Module modSystemStatus
    Public pnlSystemMessages As ctlStatusMessages = New ctlStatusMessages()
    Public statusMessage() As clsStatusMessage

    Private Enum enumStatusMessage
        OUT_OF_RANGE
        LOW_PRESSURE
    End Enum

    Public Sub Initialize()
        InitializeStatusMessages()
    End Sub

    Private Sub InitializeStatusMessages()
        ReDim statusMessage([Enum].GetValues(GetType(enumStatusMessage)).Length - 1)
        statusMessage(enumStatusMessage.OUT_OF_RANGE) = New clsStatusMessage(enumStatusMessage.OUT_OF_RANGE, Now(), "A", "Out of range", "Out of range - Details")
        statusMessage(enumStatusMessage.LOW_PRESSURE) = New clsStatusMessage(enumStatusMessage.OUT_OF_RANGE, Now(), "A", "Low Pressure", "Low Pressure - Details")
    End Sub
End Module
