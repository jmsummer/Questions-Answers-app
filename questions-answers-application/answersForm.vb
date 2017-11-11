Public Class answersForm
    Protected db As New db
    Protected Sub LoadAnswers()
        db.sql = "SELECT * FROM answers ORDER BY created_at DESC;"
        db.fill(answersDGV)
    End Sub

    Private Sub answersForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAnswers()
        'add data grid view
        'inject dependency to have a question id 
        ' 3 buttons: new, update, and delete
        '
    End Sub


    Protected question_id As Integer

    Public Sub New(ByRef qid As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = qid
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        db.sql = "SELECT * FROM answers WHERE question_id = @question_id"
        db.bind("@question_id", question_id)
        db.fill(answersDGV)
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click
        '11/9 trying to get this to work 
        'Dim updateAnswer As New updateAnswerForm(getQuestionId())
        'answersForm.ShowDialog()
        LoadAnswers()
    End Sub

    Public Function getAnswerId() As Integer
        Return getAnswerValue("question_id")
    End Function

    Public Function getAnswerValue(ByVal column As String)
        Return answersDGV.Item(column, answersDGV.CurrentRow.Index).Value
    End Function

    Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
        Me.Dispose()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim confirmed As Integer = MessageBox.Show("Are you sure you want to delete this?", "Delete", MessageBoxButtons.YesNoCancel)
        If confirmed = DialogResult.Yes Then
            db.sql = "DELETE FROM answers WHERE id = @answer_id"
            db.bind("@question_id", getAnswerId())
            db.execute()
            LoadAnswers()
        End If
    End Sub
End Class