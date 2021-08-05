
Imports System.Data.SqlClient

Public Class RevenueStatusRpt
    Private Sub ZillionCustomTemplate31_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionstring As String
        Dim cmd As SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable


        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZillionTechnologies;server=DESKTOP-9SA4VPE\MSSQLSERVER01"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "select CustomerName,SalesConsultant,AcceptedPrice,ClosingDate from Negotiation where Month(ClosingDate) = (SELECT MONTH(getdate())) And YEAR(ClosingDate) =(SELECT YEAR(getdate())) And DAY(ClosingDate) <=(Select DAY(getdate())) And datediff(day,CASt(ClosingDate As DATE), cast(getdate() as date)) <=7"

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

        cmd.CommandText = "select CustomerName,SalesConsultant,AcceptedPrice, ClosingDate from Negotiation where MONTH(ClosingDate) = '" & ComboBox2.Text & "' And Year(ClosingDate) = '" & ComboBox3.Text & "'"

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

        cmd.CommandText = "Select CustomerName, SalesConsultant, AcceptedPrice, CAST(ClosingDate As Date) from Negotiation where YEAR(ClosingDate) = '" & ComboBox1.Text & "'"

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

        cmd.CommandText = "select CustomerName,SalesConsultant,AcceptedPrice, ClosingDate from Negotiation where YEAR(ClosingDate) ='" & Qtryear.Text & "' And datepart(quarter,ClosingDate) = '" & Qtr.Text & "'"

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

    Private Sub ExpectedRevenueReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpectedRevenueReportToolStripMenuItem.Click
        RevenueReport.Show()
        RevenueReport.ExpectedRevenueReportToolStripMenuItem.BackColor = Color.Green
        Me.Hide()
    End Sub
End Class
