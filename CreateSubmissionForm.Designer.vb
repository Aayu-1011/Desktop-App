<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        Me.txtName = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.Label()
        Me.txtGithub = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btnToggleStopwatch = New System.Windows.Forms.Button()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.AutoSize = True
        Me.txtName.Location = New System.Drawing.Point(170, 72)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(44, 16)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = "Name"
        '
        'txtEmail
        '
        Me.txtEmail.AutoSize = True
        Me.txtEmail.Location = New System.Drawing.Point(170, 103)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(41, 16)
        Me.txtEmail.TabIndex = 1
        Me.txtEmail.Text = "Email"
        '
        'txtPhone
        '
        Me.txtPhone.AutoSize = True
        Me.txtPhone.Location = New System.Drawing.Point(170, 138)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(46, 16)
        Me.txtPhone.TabIndex = 2
        Me.txtPhone.Text = "Phone"
        '
        'txtGithub
        '
        Me.txtGithub.AutoSize = True
        Me.txtGithub.Location = New System.Drawing.Point(170, 166)
        Me.txtGithub.Name = "txtGithub"
        Me.txtGithub.Size = New System.Drawing.Size(45, 16)
        Me.txtGithub.TabIndex = 3
        Me.txtGithub.Text = "Github"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(290, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(290, 100)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(290, 135)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.TabIndex = 6
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(290, 163)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 22)
        Me.TextBox4.TabIndex = 7
        '
        'btnToggleStopwatch
        '
        Me.btnToggleStopwatch.BackColor = System.Drawing.Color.Gold
        Me.btnToggleStopwatch.Location = New System.Drawing.Point(173, 220)
        Me.btnToggleStopwatch.Name = "btnToggleStopwatch"
        Me.btnToggleStopwatch.Size = New System.Drawing.Size(168, 23)
        Me.btnToggleStopwatch.TabIndex = 8
        Me.btnToggleStopwatch.Text = "TOOGLE STOPWATCH (&CTRL+T)"
        Me.btnToggleStopwatch.UseVisualStyleBackColor = False
        '
        'lblStopwatch
        '
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblStopwatch.Location = New System.Drawing.Point(360, 223)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(55, 16)
        Me.lblStopwatch.TabIndex = 9
        Me.lblStopwatch.Text = "00:00:00"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnSubmit.Location = New System.Drawing.Point(173, 270)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(217, 23)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "SUBMIT(&CTRL+S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.btnToggleStopwatch)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtGithub)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As Label
    Friend WithEvents txtEmail As Label
    Friend WithEvents txtPhone As Label
    Friend WithEvents txtGithub As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnSubmit As Button
End Class
