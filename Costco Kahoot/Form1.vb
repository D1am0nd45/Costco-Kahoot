Public Class Form1
    Private QuestionTimerStart As Integer = 20
    Private CurrentTimeLeft As Integer
    Dim timeleft As Integer
    Private QuestionList As New List(Of KahootQuestion)
    Private currentQuestion As Integer = 0
    Private answerButtons() As Button
    Private Const CORRECTTAG As String = "C"
    Private score As Integer
    Private ResponseTime As Integer
    Private total As Integer
    Private AnsweredQuestion As Boolean = False
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub OnToolStripMenuItem_Click(sender As ToolStripMenuItem, e As EventArgs) Handles mnu20Sec.Click, mnu40Sec.Click, mnu60Sec.Click
        mnu20Sec.Checked = False
        mnu40Sec.Checked = False
        mnu60Sec.Checked = False
        sender.Checked = True
        QuestionTimerStart = CInt(sender.Tag)
        resetTimer()
        If lblQuestions.Text = "" Then
            darnyouisaac.Stop()
        End If
    End Sub
    Private Sub LoadQuestionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadQuestionsToolStripMenuItem.Click
        GetLoadQ()
    End Sub
    Private Sub LoadQuestion()
        If currentQuestion >= 0 And currentQuestion < QuestionList.Count Then
            Dim q As KahootQuestion = QuestionList(currentQuestion)
            lblQuestions.Text = q.Question
            ClearButtons()
            Dim answerIdx = q.Answer - 1

            For i As Integer = 3 To 0 Step -1
                If i < q.AnswerList.Count Then
                    answerButtons(i).Text = q.AnswerList(i)
                    answerButtons(i).Visible = True
                    If answerButtons(i).Text = "" Then
                        answerButtons(i).Visible = False
                    End If
                    If answerIdx = i Then
                        answerButtons(i).Tag = CORRECTTAG
                    End If
                End If
            Next
            If ShuffleAnswersToolStripMenuItem.Checked Then
                ShuffleAnswers()
            End If
        End If
        If lblTime.Text = "0" Or CurrentTimeLeft <= 0 Then
            resetTimer()
        End If
        If currentQuestion < QuestionList.Count Then
            lblQuestionNum.Text = currentQuestion + 1 & "/" & QuestionList.Count
        End If
    End Sub

    Private Sub ShuffleAnswers()
        Dim rand As New Random()
        For i As Integer = answerButtons.Length - 1 To 1 Step -1
            If answerButtons(i).Visible = True Then
                Dim newbtnidx As Integer = rand.Next(0, i + 1)
                Dim swaptext As String = answerButtons(i).Text
                Dim swaptag As String = answerButtons(i).Tag
                answerButtons(i).Text = answerButtons(newbtnidx).Text
                answerButtons(i).Tag = answerButtons(newbtnidx).Tag
                answerButtons(newbtnidx).Text = swaptext
                answerButtons(newbtnidx).Tag = swaptag
            End If
        Next

    End Sub
    Private Sub ClearButtons()
        For Each b As Button In answerButtons
            b.Text = ""
            b.Tag = ""
            b.Visible = False
        Next
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        answerButtons = {btnAnsOne, btnAnsTwo, btnAnsThree, btnAnsFour}
    End Sub

    Private Sub btnAnsOne_Click(sender As Object, e As EventArgs) Handles btnAnsOne.Click, btnAnsTwo.Click, btnAnsThree.Click, btnAnsFour.Click
        If currentQuestion >= 0 And currentQuestion < QuestionList.Count Then
            If sender.tag = CORRECTTAG Then
                If AnsweredQuestion = False Then
                    For Each b As Button In answerButtons
                        b.Visible = False
                        sender.visible = True
                    Next
                    darnyouisaac.Stop()
                        MsgBox("Correct!")
                        GetScore()
                        LblTotalSc.Text = total.ToString
                        AnsweredQuestion = True
                        If currentQuestion < QuestionList.Count Then
                            currentQuestion += 1
                        End If
                    End If
                Else
                If AnsweredQuestion = False Then
                    darnyouisaac.Stop()
                    MsgBox("Incorrect.")
                    AnsweredQuestion = True
                    For Each b As Button In answerButtons
                        If b.Tag <> CORRECTTAG Then
                            b.Visible = False
                        Else
                            If ShowCorrectAnswerToolStripMenuItem.Checked = True Then
                                b.Visible = True
                            End If
                        End If
                            sender.visible = True
                    Next
                    If currentQuestion < QuestionList.Count Then
                        currentQuestion += 1
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub resetTimer()
        darnyouisaac.Stop()
        CurrentTimeLeft = QuestionTimerStart
        lblTime.Text = QuestionTimerStart
        darnyouisaac.Start()
    End Sub
    Private Sub darnyouisaac_Tick(sender As Object, e As EventArgs) Handles darnyouisaac.Tick
        If currentQuestion <> QuestionList.Count Then
            CurrentTimeLeft -= 1
            If lblTime.Text = "0" Or CurrentTimeLeft <= 0 Then
                lblTime.Text = "0"
                darnyouisaac.Stop()
                MsgBox("Incorrect.")
                currentQuestion += 1
                LoadQuestion()
            End If
        End If
        lblTime.Text = CurrentTimeLeft
    End Sub
    Private Sub GetScore()
        ResponseTime = QuestionTimerStart - CurrentTimeLeft
        score = (1 - ((ResponseTime / QuestionTimerStart) / 2)) * 1000
        total += score
    End Sub
    Private Sub btnGoToNextQuestion_Click(sender As Object, e As EventArgs) Handles btnGoToNextQuestion.Click
        If AnsweredQuestion = True Then
            LoadQuestion()
            resetTimer()
            AnsweredQuestion = False
        End If
    End Sub
    Private Sub ResetGame()
        currentQuestion = 1
        total = 0
        currentQuestion = QuestionTimerStart
        GetLoadQ()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        ResetGame()
    End Sub
    Private Sub GetLoadQ()
        'Creates new file selection dialog
        Dim csv As New OpenFileDialog()
        'Makes the file selection dialog open in the downloads folder (when it opens)
        csv.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
        'Only lets the user select .csv files in the file selection dialog
        csv.Filter = "csv (*.csv)|*.csv"
        'Finally Shows the dialog
        csv.ShowDialog()
        'Gets the file location of the selected file
        Dim filelocation As String = csv.FileName
        If filelocation <> Nothing Then
            QuestionList.Clear()
            Dim csvFileReader As New FileIO.TextFieldParser(filelocation)
            csvFileReader.Delimiters = New String() {","}
            csvFileReader.ReadLine()
            While csvFileReader.EndOfData = False
                Dim record = csvFileReader.ReadFields
                Dim q As New KahootQuestion
                q.Question = record(0)
                For i As Integer = 1 To 4
                    q.AnswerList.Add(record(i))
                Next
                q.Answer = record(6)
                QuestionList.Add(q)
            End While
            If ShuffleQuestionsToolStripMenuItem.Checked Then
                ShuffleQuestions()
            End If
            LoadQuestion()
        End If
        'Writes the file location to the console.
        Console.WriteLine(filelocation)
    End Sub

    Private Sub ShuffleQuestions()
        Dim rand As New Random()
        For i As Integer = QuestionList.Count - 1 To 1 Step -1

            Dim swapint As Integer = rand.Next(0, i + 1)

            Dim current As KahootQuestion = QuestionList(i)
            QuestionList(i) = QuestionList(swapint)
            QuestionList(swapint) = current

        Next

    End Sub
End Class
