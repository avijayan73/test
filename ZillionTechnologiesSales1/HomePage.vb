Imports System.Data.SqlClient

Public Class HomePage
    Dim connectionstring As String
    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized
        logoutinfo.Visible = False
        Panel2.Visible = False
        UserValidLab.Visible = False
        PasswrdLab.Visible = False

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim Dr As SqlDataReader
        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZillionTechnologies;server=DESKTOP-9SA4VPE\MSSQLSERVER01"
        con = New SqlConnection(connectionstring)

        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text


        cmd.CommandText = "Select * from Login where  UserName = '" & txtUserName.Text & "' and  password='" & txtPassword.Text & "' "
        Dr = cmd.ExecuteReader

        If Dr.Read Then
            MsgBox("Valid User")
            'logout.Text = txtUserName.Text
            LeadGeneration.Show()
            LeadGeneration.LeadGenerationToolStripMenuItem.BackColor = Color.Green
            Me.Hide()
        Else
            MsgBox("Invalid User")

        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles logout.Click
        Panel2.Visible = True
        RichTxtBxPanel.Text = txtUserName.Text & "  Do you want to Logout?"
    End Sub

    Private Sub logout_MouseHover(sender As Object, e As System.EventArgs) Handles logout.MouseHover
        logoutinfo.Visible = True
        logoutinfo.Text += "User Account" & vbCr
        logoutinfo.Text += "User:" & txtUserName.Text
    End Sub

    Private Sub logout_MouseLeave(sender As Object, e As System.EventArgs) Handles logout.MouseLeave
        logoutinfo.Clear()
        logoutinfo.Visible = False
    End Sub

    Private Sub txtUserName_MouseHover(sender As Object, e As EventArgs) Handles txtUserName.MouseHover
        UserValidLab.Visible = True
    End Sub

    Private Sub txtUserName_MouseLeave(sender As Object, e As EventArgs) Handles txtUserName.MouseLeave
        UserValidLab.Visible = False
    End Sub

    Private Sub txtPassword_MouseHover(sender As Object, e As EventArgs) Handles txtPassword.MouseHover
        PasswrdLab.Visible = True
    End Sub

    Private Sub txtPassword_MouseLeave(sender As Object, e As EventArgs) Handles txtPassword.MouseLeave
        PasswrdLab.Visible = False
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub





End Class