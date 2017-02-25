Public Class clsStatusMessage
    Public time As String
    Public status As String
    Public text As String
    Public detailedText As String
    Public id As Integer

    Sub New(ByVal id_t As Integer, ByVal time_t As String, status_t As String, text_t As String, detailedText_t As String)
        id = id_t
        time = time_t
        status = status_t
        text = text_t
        detailedText = detailedText_t
    End Sub


End Class
