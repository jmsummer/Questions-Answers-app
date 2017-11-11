<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateAnswerForm
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
        Me.updateAnswersButton = New System.Windows.Forms.Button()
        Me.updateAnswersTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'updateAnswersButton
        '
        Me.updateAnswersButton.Location = New System.Drawing.Point(12, 201)
        Me.updateAnswersButton.Name = "updateAnswersButton"
        Me.updateAnswersButton.Size = New System.Drawing.Size(380, 179)
        Me.updateAnswersButton.TabIndex = 0
        Me.updateAnswersButton.Text = "Update Answer"
        Me.updateAnswersButton.UseVisualStyleBackColor = True
        '
        'updateAnswersTextBox
        '
        Me.updateAnswersTextBox.Location = New System.Drawing.Point(12, 12)
        Me.updateAnswersTextBox.Multiline = True
        Me.updateAnswersTextBox.Name = "updateAnswersTextBox"
        Me.updateAnswersTextBox.Size = New System.Drawing.Size(380, 183)
        Me.updateAnswersTextBox.TabIndex = 1
        '
        'updateAnswerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 392)
        Me.Controls.Add(Me.updateAnswersTextBox)
        Me.Controls.Add(Me.updateAnswersButton)
        Me.Name = "updateAnswerForm"
        Me.Text = "updateAnswerForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents updateAnswersButton As Button
    Friend WithEvents updateAnswersTextBox As TextBox
End Class
