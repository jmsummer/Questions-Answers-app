Public Class questionsAnswersForm
    Protected db As New db
    Protected Sub LoadQuestions()
        db.sql = "SELECT * FROM questions ORDER BY created_at DESC;"
        db.fill(QuestionsDGV)
    End Sub
    Protected Sub LoadAnswers()
        db.sql = "SELECT * FROM answers ORDER BY created_at DESC;"
        db.fill(AnswersDGV)
    End Sub

    Private Sub questionsAnswersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadQuestionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadQuestionsToolStripMenuItem.Click
        LoadAnswers()
        LoadQuestions()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class