﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateQuestion
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
        Me.btnUpdateQuestionSubmit = New System.Windows.Forms.Button()
        Me.tbUpdateQuestion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnUpdateQuestionSubmit
        '
        Me.btnUpdateQuestionSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateQuestionSubmit.Location = New System.Drawing.Point(16, 426)
        Me.btnUpdateQuestionSubmit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdateQuestionSubmit.Name = "btnUpdateQuestionSubmit"
        Me.btnUpdateQuestionSubmit.Size = New System.Drawing.Size(672, 128)
        Me.btnUpdateQuestionSubmit.TabIndex = 0
        Me.btnUpdateQuestionSubmit.Text = "Submit"
        Me.btnUpdateQuestionSubmit.UseVisualStyleBackColor = True
        '
        'tbUpdateQuestion
        '
        Me.tbUpdateQuestion.Location = New System.Drawing.Point(16, 15)
        Me.tbUpdateQuestion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbUpdateQuestion.Multiline = True
        Me.tbUpdateQuestion.Name = "tbUpdateQuestion"
        Me.tbUpdateQuestion.Size = New System.Drawing.Size(671, 403)
        Me.tbUpdateQuestion.TabIndex = 1
        '
        'UpdateQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 569)
        Me.Controls.Add(Me.tbUpdateQuestion)
        Me.Controls.Add(Me.btnUpdateQuestionSubmit)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UpdateQuestion"
        Me.Text = "UpdateQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdateQuestionSubmit As Button
    Friend WithEvents tbUpdateQuestion As TextBox
End Class
