<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class questionsAnswersForm
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
        Me.QuestionsDGV = New System.Windows.Forms.DataGridView()
        Me.AnswersDGV = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.LoadQuestionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.QuestionsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnswersDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'QuestionsDGV
        '
        Me.QuestionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QuestionsDGV.Location = New System.Drawing.Point(12, 56)
        Me.QuestionsDGV.Name = "QuestionsDGV"
        Me.QuestionsDGV.RowTemplate.Height = 24
        Me.QuestionsDGV.Size = New System.Drawing.Size(529, 419)
        Me.QuestionsDGV.TabIndex = 0
        '
        'AnswersDGV
        '
        Me.AnswersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AnswersDGV.Location = New System.Drawing.Point(567, 56)
        Me.AnswersDGV.Name = "AnswersDGV"
        Me.AnswersDGV.RowTemplate.Height = 24
        Me.AnswersDGV.Size = New System.Drawing.Size(482, 419)
        Me.AnswersDGV.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadQuestionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1061, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'LoadQuestionsToolStripMenuItem
        '
        Me.LoadQuestionsToolStripMenuItem.Name = "LoadQuestionsToolStripMenuItem"
        Me.LoadQuestionsToolStripMenuItem.Size = New System.Drawing.Size(208, 24)
        Me.LoadQuestionsToolStripMenuItem.Text = "Load Questions and answers"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Questions:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(564, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Answers:"
        '
        'questionsAnswersForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 487)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AnswersDGV)
        Me.Controls.Add(Me.QuestionsDGV)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "questionsAnswersForm"
        Me.Text = "questionsAnswersForm"
        CType(Me.QuestionsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnswersDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QuestionsDGV As DataGridView
    Friend WithEvents AnswersDGV As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LoadQuestionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
