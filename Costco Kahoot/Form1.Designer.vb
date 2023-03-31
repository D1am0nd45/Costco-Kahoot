<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadQuestionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripTimeContainer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu20Sec = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu40Sec = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnu60Sec = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnAnsOne = New System.Windows.Forms.Button()
        Me.lblQuestions = New System.Windows.Forms.Label()
        Me.btnAnsTwo = New System.Windows.Forms.Button()
        Me.btnAnsThree = New System.Windows.Forms.Button()
        Me.btnAnsFour = New System.Windows.Forms.Button()
        Me.lblQuestionNum = New System.Windows.Forms.Label()
        Me.darnyouisaac = New System.Windows.Forms.Timer(Me.components)
        Me.LblTotalSc = New System.Windows.Forms.Label()
        Me.btnGoToNextQuestion = New System.Windows.Forms.Button()
        Me.ShowCorrectAnswerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShuffleAnswersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShuffleQuestionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadQuestionsToolStripMenuItem, Me.ResetToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LoadQuestionsToolStripMenuItem
        '
        Me.LoadQuestionsToolStripMenuItem.Name = "LoadQuestionsToolStripMenuItem"
        Me.LoadQuestionsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.LoadQuestionsToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.LoadQuestionsToolStripMenuItem.Text = "Load Questions"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(199, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuStripTimeContainer, Me.ShowCorrectAnswerToolStripMenuItem, Me.ShuffleAnswersToolStripMenuItem, Me.ShuffleQuestionsToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'MenuStripTimeContainer
        '
        Me.MenuStripTimeContainer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu20Sec, Me.mnu40Sec, Me.mnu60Sec})
        Me.MenuStripTimeContainer.Name = "MenuStripTimeContainer"
        Me.MenuStripTimeContainer.Size = New System.Drawing.Size(171, 22)
        Me.MenuStripTimeContainer.Text = "Time Per Question"
        '
        'mnu20Sec
        '
        Me.mnu20Sec.Checked = True
        Me.mnu20Sec.CheckOnClick = True
        Me.mnu20Sec.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnu20Sec.Name = "mnu20Sec"
        Me.mnu20Sec.Size = New System.Drawing.Size(86, 22)
        Me.mnu20Sec.Tag = "20"
        Me.mnu20Sec.Text = "20"
        '
        'mnu40Sec
        '
        Me.mnu40Sec.CheckOnClick = True
        Me.mnu40Sec.Name = "mnu40Sec"
        Me.mnu40Sec.Size = New System.Drawing.Size(86, 22)
        Me.mnu40Sec.Tag = "40"
        Me.mnu40Sec.Text = "40"
        '
        'mnu60Sec
        '
        Me.mnu60Sec.CheckOnClick = True
        Me.mnu60Sec.Name = "mnu60Sec"
        Me.mnu60Sec.Size = New System.Drawing.Size(86, 22)
        Me.mnu60Sec.Tag = "60"
        Me.mnu60Sec.Text = "60"
        '
        'lblTime
        '
        Me.lblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(12, 24)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(100, 100)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "00"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAnsOne
        '
        Me.btnAnsOne.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnAnsOne.Location = New System.Drawing.Point(12, 271)
        Me.btnAnsOne.Name = "btnAnsOne"
        Me.btnAnsOne.Size = New System.Drawing.Size(375, 75)
        Me.btnAnsOne.TabIndex = 2
        Me.btnAnsOne.UseVisualStyleBackColor = False
        '
        'lblQuestions
        '
        Me.lblQuestions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuestions.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestions.Location = New System.Drawing.Point(118, 24)
        Me.lblQuestions.Name = "lblQuestions"
        Me.lblQuestions.Size = New System.Drawing.Size(564, 244)
        Me.lblQuestions.TabIndex = 3
        Me.lblQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAnsTwo
        '
        Me.btnAnsTwo.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAnsTwo.Location = New System.Drawing.Point(413, 271)
        Me.btnAnsTwo.Name = "btnAnsTwo"
        Me.btnAnsTwo.Size = New System.Drawing.Size(375, 75)
        Me.btnAnsTwo.TabIndex = 5
        Me.btnAnsTwo.UseVisualStyleBackColor = False
        '
        'btnAnsThree
        '
        Me.btnAnsThree.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnAnsThree.Location = New System.Drawing.Point(12, 355)
        Me.btnAnsThree.Name = "btnAnsThree"
        Me.btnAnsThree.Size = New System.Drawing.Size(375, 75)
        Me.btnAnsThree.TabIndex = 6
        Me.btnAnsThree.UseVisualStyleBackColor = False
        '
        'btnAnsFour
        '
        Me.btnAnsFour.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnAnsFour.Location = New System.Drawing.Point(413, 355)
        Me.btnAnsFour.Name = "btnAnsFour"
        Me.btnAnsFour.Size = New System.Drawing.Size(375, 75)
        Me.btnAnsFour.TabIndex = 7
        Me.btnAnsFour.UseVisualStyleBackColor = False
        '
        'lblQuestionNum
        '
        Me.lblQuestionNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblQuestionNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionNum.Location = New System.Drawing.Point(688, 24)
        Me.lblQuestionNum.Name = "lblQuestionNum"
        Me.lblQuestionNum.Size = New System.Drawing.Size(100, 100)
        Me.lblQuestionNum.TabIndex = 8
        Me.lblQuestionNum.Text = "0"
        Me.lblQuestionNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'darnyouisaac
        '
        Me.darnyouisaac.Interval = 1000
        '
        'LblTotalSc
        '
        Me.LblTotalSc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblTotalSc.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalSc.Location = New System.Drawing.Point(688, 168)
        Me.LblTotalSc.Name = "LblTotalSc"
        Me.LblTotalSc.Size = New System.Drawing.Size(100, 100)
        Me.LblTotalSc.TabIndex = 10
        Me.LblTotalSc.Text = "0"
        Me.LblTotalSc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGoToNextQuestion
        '
        Me.btnGoToNextQuestion.BackColor = System.Drawing.Color.White
        Me.btnGoToNextQuestion.Location = New System.Drawing.Point(12, 127)
        Me.btnGoToNextQuestion.Name = "btnGoToNextQuestion"
        Me.btnGoToNextQuestion.Size = New System.Drawing.Size(100, 141)
        Me.btnGoToNextQuestion.TabIndex = 11
        Me.btnGoToNextQuestion.Text = "Go To Next Question"
        Me.btnGoToNextQuestion.UseVisualStyleBackColor = False
        '
        'ShowCorrectAnswerToolStripMenuItem
        '
        Me.ShowCorrectAnswerToolStripMenuItem.Checked = True
        Me.ShowCorrectAnswerToolStripMenuItem.CheckOnClick = True
        Me.ShowCorrectAnswerToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowCorrectAnswerToolStripMenuItem.Name = "ShowCorrectAnswerToolStripMenuItem"
        Me.ShowCorrectAnswerToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ShowCorrectAnswerToolStripMenuItem.Text = "Show Correct Answer"
        '
        'ShuffleAnswersToolStripMenuItem
        '
        Me.ShuffleAnswersToolStripMenuItem.CheckOnClick = True
        Me.ShuffleAnswersToolStripMenuItem.Name = "ShuffleAnswersToolStripMenuItem"
        Me.ShuffleAnswersToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ShuffleAnswersToolStripMenuItem.Text = "Shuffle Answers"
        '
        'ShuffleQuestionsToolStripMenuItem
        '
        Me.ShuffleQuestionsToolStripMenuItem.CheckOnClick = True
        Me.ShuffleQuestionsToolStripMenuItem.Name = "ShuffleQuestionsToolStripMenuItem"
        Me.ShuffleQuestionsToolStripMenuItem.Size = New System.Drawing.Size(187, 22)
        Me.ShuffleQuestionsToolStripMenuItem.Text = "Shuffle Questions"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 442)
        Me.Controls.Add(Me.btnGoToNextQuestion)
        Me.Controls.Add(Me.LblTotalSc)
        Me.Controls.Add(Me.lblQuestionNum)
        Me.Controls.Add(Me.btnAnsFour)
        Me.Controls.Add(Me.btnAnsThree)
        Me.Controls.Add(Me.btnAnsTwo)
        Me.Controls.Add(Me.lblQuestions)
        Me.Controls.Add(Me.btnAnsOne)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "Costco Kahoot"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadQuestionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStripTimeContainer As ToolStripMenuItem
    Friend WithEvents mnu20Sec As ToolStripMenuItem
    Friend WithEvents mnu40Sec As ToolStripMenuItem
    Friend WithEvents mnu60Sec As ToolStripMenuItem
    Friend WithEvents lblTime As Label
    Friend WithEvents btnAnsOne As Button
    Friend WithEvents lblQuestions As Label
    Friend WithEvents btnAnsTwo As Button
    Friend WithEvents btnAnsThree As Button
    Friend WithEvents btnAnsFour As Button
    Friend WithEvents lblQuestionNum As Label
    Friend WithEvents darnyouisaac As Timer
    Friend WithEvents LblTotalSc As Label
    Friend WithEvents btnGoToNextQuestion As Button
    Friend WithEvents ShowCorrectAnswerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShuffleAnswersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShuffleQuestionsToolStripMenuItem As ToolStripMenuItem
End Class
