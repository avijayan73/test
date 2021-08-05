
Imports System.Data.SqlClient
Public Class frmHomePage
    Dim connectionstring As String
    Dim con As SqlConnection
    Dim cmd As SqlCommand




    Private Sub frmHomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        logoutinfo.Visible = False
        Panel3.Visible = False
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
            frmLeadGeneration.Show()
            frmLeadGeneration.LeadToolStripMenuItem1.BackColor = Color.Green
            Me.Hide()
        Else
            MsgBox("Invalid User")

        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Logoutpanel.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        frmLeadGeneration.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles logout.Click
        Panel3.Visible = True
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

    Private Sub ButtonPanel_Click(sender As Object, e As EventArgs) Handles ButtonPanel.Click
        Application.Exit()
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


End Class
