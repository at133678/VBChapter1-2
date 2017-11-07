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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShowGreetings = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblGreetings = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EnterYourName"
        '
        'btnShowGreetings
        '
        Me.btnShowGreetings.Location = New System.Drawing.Point(27, 160)
        Me.btnShowGreetings.Name = "btnShowGreetings"
        Me.btnShowGreetings.Size = New System.Drawing.Size(64, 44)
        Me.btnShowGreetings.TabIndex = 1
        Me.btnShowGreetings.Text = "Show Greetings"
        Me.btnShowGreetings.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(162, 171)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblGreetings
        '
        Me.lblGreetings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGreetings.Location = New System.Drawing.Point(49, 96)
        Me.lblGreetings.Name = "lblGreetings"
        Me.lblGreetings.Size = New System.Drawing.Size(174, 40)
        Me.lblGreetings.TabIndex = 4
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(82, 51)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(114, 20)
        Me.txtUserName.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.lblGreetings)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowGreetings)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnShowGreetings As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblGreetings As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox

End Class
