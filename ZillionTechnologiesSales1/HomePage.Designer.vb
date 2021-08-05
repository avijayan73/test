<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.PasswrdLab = New System.Windows.Forms.Label()
        Me.UserValidLab = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logout = New System.Windows.Forms.Button()
        Me.logoutinfo = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTxtBxPanel = New System.Windows.Forms.RichTextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.ZillionTechnologiesSales1.My.Resources.Resources.front_page
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.logoutinfo)
        Me.Panel1.Controls.Add(Me.logout)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.PasswrdLab)
        Me.Panel1.Controls.Add(Me.UserValidLab)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtUserName)
        Me.Panel1.Controls.Add(Me.Password)
        Me.Panel1.Controls.Add(Me.UserName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1859, 969)
        Me.Panel1.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Navy
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLogin.Location = New System.Drawing.Point(233, 575)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(141, 42)
        Me.btnLogin.TabIndex = 26
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'PasswrdLab
        '
        Me.PasswrdLab.AutoSize = True
        Me.PasswrdLab.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswrdLab.Location = New System.Drawing.Point(473, 511)
        Me.PasswrdLab.Name = "PasswrdLab"
        Me.PasswrdLab.Size = New System.Drawing.Size(213, 19)
        Me.PasswrdLab.TabIndex = 25
        Me.PasswrdLab.Text = "Please Enter a Valid Password"
        '
        'UserValidLab
        '
        Me.UserValidLab.AutoSize = True
        Me.UserValidLab.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserValidLab.Location = New System.Drawing.Point(467, 457)
        Me.UserValidLab.Name = "UserValidLab"
        Me.UserValidLab.Size = New System.Drawing.Size(221, 19)
        Me.UserValidLab.TabIndex = 24
        Me.UserValidLab.Text = "Please Enter a Valid UserName"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Location = New System.Drawing.Point(222, 511)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(229, 15)
        Me.txtPassword.TabIndex = 21
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUserName.Location = New System.Drawing.Point(222, 457)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(229, 15)
        Me.txtUserName.TabIndex = 20
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.BackColor = System.Drawing.Color.Transparent
        Me.Password.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Password.Location = New System.Drawing.Point(73, 500)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(110, 26)
        Me.Password.TabIndex = 19
        Me.Password.Text = "Password"
        '
        'UserName
        '
        Me.UserName.AutoSize = True
        Me.UserName.BackColor = System.Drawing.Color.Transparent
        Me.UserName.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UserName.Location = New System.Drawing.Point(68, 446)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(125, 26)
        Me.UserName.TabIndex = 18
        Me.UserName.Text = "User Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(21, 354)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 33)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Sales Representative Login  Screen"
        '
        'logout
        '
        Me.logout.BackColor = System.Drawing.SystemColors.Highlight
        Me.logout.Location = New System.Drawing.Point(1735, 16)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(66, 33)
        Me.logout.TabIndex = 27
        Me.logout.Text = "Logout"
        Me.logout.UseVisualStyleBackColor = False
        '
        'logoutinfo
        '
        Me.logoutinfo.Location = New System.Drawing.Point(1676, 55)
        Me.logoutinfo.Name = "logoutinfo"
        Me.logoutinfo.Size = New System.Drawing.Size(172, 61)
        Me.logoutinfo.TabIndex = 28
        Me.logoutinfo.Text = ""
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.RichTxtBxPanel)
        Me.Panel2.Location = New System.Drawing.Point(1638, 55)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(218, 177)
        Me.Panel2.TabIndex = 29
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(81, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTxtBxPanel
        '
        Me.RichTxtBxPanel.Location = New System.Drawing.Point(22, 30)
        Me.RichTxtBxPanel.Name = "RichTxtBxPanel"
        Me.RichTxtBxPanel.Size = New System.Drawing.Size(159, 68)
        Me.RichTxtBxPanel.TabIndex = 0
        Me.RichTxtBxPanel.Text = ""
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1863, 922)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "HomePage"
        Me.Text = "HomePage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents UserName As Label
    Friend WithEvents Password As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents PasswrdLab As Label
    Friend WithEvents UserValidLab As Label
    Friend WithEvents logout As Button
    Friend WithEvents logoutinfo As RichTextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTxtBxPanel As RichTextBox
End Class
