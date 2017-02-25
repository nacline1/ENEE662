Public Class ctlStatusMessages

    Public Sub addMessage(id As clsStatusMessage)
        dgvStatusMessages.Rows.Add(id.time, id.status, id.text)
    End Sub
End Class
