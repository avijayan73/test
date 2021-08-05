Imports System.Data.SqlClient

Public Class RevenueReport

    Private Sub RevenueReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionstring As String
        Dim cmd As SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZillionTechnologies;server=DESKTOP-9SA4VPE\MSSQLSERVER01"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "Select * from leadinfo "

        da.SelectCommand = cmd

        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionstring As String
        Dim cmd As SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZillionTechnologies;server=DESKTOP-9SA4VPE\MSSQLSERVER01"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "Select * from LeadInitiateStatus "

        da.SelectCommand = cmd

        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim connectionstring As String
        Dim cmd As SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZillionTechnologies;server=DESKTOP-9SA4VPE\MSSQLSERVER01"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "Select * from DemoSchedule "

        da.SelectCommand = cmd

        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim connectionstring As String
        Dim cmd As SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZillionTechnologies;server=DESKTOP-9SA4VPE\MSSQLSERVER01"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "Select * from Proposal "

        da.SelectCommand = cmd

        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim connectionstring As String
        Dim cmd As SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZillionTechnologies;server=DESKTOP-9SA4VPE\MSSQLSERVER01"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "Select * from Negotiation "

        da.SelectCommand = cmd

        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        HomePage.Show()
    End Sub

    Private Sub LeadGenerationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeadGenerationToolStripMenuItem.Click
        LeadGeneration.Show()
        LeadGeneration.LeadGenerationToolStripMenuItem.BackColor = Color.Green
        Me.Hide()
    End Sub

    Private Sub QualifiedLeadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QualifiedLeadToolStripMenuItem.Click
        QualifiedLeads.Show()
        QualifiedLeads.QualifiedLeadToolStripMenuItem.BackColor = Color.Green
        Me.Hide()
    End Sub

    Private Sub DemoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DemoToolStripMenuItem.Click
        Demo.Show()
        Demo.DemoToolStripMenuItem.BackColor = Color.Green
        Me.Hide()
    End Sub

    Private Sub ProposalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProposalToolStripMenuItem.Click
        Proposal.Show()
        Proposal.ProposalToolStripMenuItem.BackColor = Color.Green
        Me.Hide()
    End Sub

    Private Sub NegotiationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NegotiationToolStripMenuItem.Click
        Negotiation.Show()
        Negotiation.NegotiationToolStripMenuItem.BackColor = Color.Green
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RevenueStatusRpt.Show()
        Me.Hide()
    End Sub
End Class
