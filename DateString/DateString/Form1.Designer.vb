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
        Me.txtDayofMonth = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtDayofWeek = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDateString = New System.Windows.Forms.Label()
        Me.txtShowDate = New System.Windows.Forms.Button()
        Me.btnlear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDayofMonth
        '
        Me.txtDayofMonth.Location = New System.Drawing.Point(172, 109)
        Me.txtDayofMonth.Name = "txtDayofMonth"
        Me.txtDayofMonth.Size = New System.Drawing.Size(100, 20)
        Me.txtDayofMonth.TabIndex = 0
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(172, 67)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(100, 20)
        Me.txtMonth.TabIndex = 1
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(172, 152)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 2
        '
        'txtDayofWeek
        '
        Me.txtDayofWeek.Location = New System.Drawing.Point(172, 24)
        Me.txtDayofWeek.Name = "txtDayofWeek"
        Me.txtDayofWeek.Size = New System.Drawing.Size(100, 20)
        Me.txtDayofWeek.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter the Day of the Week"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter the Month"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Enter the day of the Month"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Enter the Year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 8
        '
        'lblDateString
        '
        Me.lblDateString.AutoSize = True
        Me.lblDateString.Location = New System.Drawing.Point(104, 243)
        Me.lblDateString.Name = "lblDateString"
        Me.lblDateString.Size = New System.Drawing.Size(0, 13)
        Me.lblDateString.TabIndex = 9
        '
        'txtShowDate
        '
        Me.txtShowDate.Location = New System.Drawing.Point(42, 232)
        Me.txtShowDate.Name = "txtShowDate"
        Me.txtShowDate.Size = New System.Drawing.Size(72, 29)
        Me.txtShowDate.TabIndex = 10
        Me.txtShowDate.Text = "Show Date"
        Me.txtShowDate.UseVisualStyleBackColor = True
        '
        'btnlear
        '
        Me.btnlear.Location = New System.Drawing.Point(141, 232)
        Me.btnlear.Name = "btnlear"
        Me.btnlear.Size = New System.Drawing.Size(53, 29)
        Me.btnlear.TabIndex = 11
        Me.btnlear.Text = "Clear"
        Me.btnlear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(219, 224)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(53, 29)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDate.Location = New System.Drawing.Point(70, 189)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(170, 23)
        Me.lblDate.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnlear)
        Me.Controls.Add(Me.txtShowDate)
        Me.Controls.Add(Me.lblDateString)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDayofWeek)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtDayofMonth)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDayofMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents txtDayofWeek As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblDateString As System.Windows.Forms.Label
    Friend WithEvents txtShowDate As System.Windows.Forms.Button
    Friend WithEvents btnlear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label

End Class
