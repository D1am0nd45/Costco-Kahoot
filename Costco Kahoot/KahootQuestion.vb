Public Class KahootQuestion
    Public Property Question As String
    Public Property AnswerList As New List(Of String)
    Public Property Answer As Integer
    Public Overrides Function ToString() As String
        Dim questionstring As String = Question
        For Each a As String In AnswerList
            questionstring &= "," & a
        Next
        questionstring &= "," & Answer
        Return questionstring
        Return MyBase.ToString()
    End Function
End Class
