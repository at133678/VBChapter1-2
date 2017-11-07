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
        Me.lblShowAnswer = New System.Windows.Forms.Button()
        Me.lblExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblShowAnswer
        '
        Me.lblShowAnswer.Location = New System.Drawing.Point(44, 177)
        Me.lblShowAnswer.Name = "lblShowAnswer"
        Me.lblShowAnswer.Size = New System.Drawing.Size(103, 23)
        Me.lblShowAnswer.TabIndex = 0
        Me.lblShowAnswer.Text = "Show Answer"
        Me.lblShowAnswer.UseVisualStyleBackColor = True
        '
        'lblExit
        '
        Me.lblExit.Location = New System.Drawing.Point(177, 177)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(75, 23)
        Me.lblExit.TabIndex = 1
        Me.lblExit.Text = "Exit"
        Me.lblExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 34)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "18+64=?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblShowAnswer)
        Me.Name = "Form1"
        Me.Text = "MathTutor "
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblShowAnswer As System.Windows.Forms.Button
    Friend WithEvents lblExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
