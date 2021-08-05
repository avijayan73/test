Imports System.Data.SqlClient

Public Class Demo
    Private Sub Demo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim connectionstring As String
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dr As SqlDataReader



        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZillionTechnologies;server=DESKTOP-9SA4VPE\MSSQLSERVER01"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = ("select CustomerName from leadinitiatestatus where status='Demo'")

        da.SelectCommand = cmd

        dr = cmd.ExecuteReader()
        While dr.Read()
            cmbPotentialCustomerName.Items.Add(dr("CustomerName"))
        End While
    End Sub

    Private Sub cmbPotentialCustomerName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbPotentialCustomerName.SelectedValueChanged


        Dim cmd As SqlCommand
        Dim connectionstring As String
        Dim con As New SqlConnection
        Dim da As New SqlDataAdapter
        Dim dr As SqlDataReader
        Dim dt As New DataTable


        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZillionTechnologies;server=DESKTOP-9SA4VPE\MSSQLSERVER01"
        con = New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT SalesConsultant FROM LeadInitiateStatus where CustomerName = '" & cmbPotentialCustomerName.Text & "' "

        da.SelectCommand = cmd
        dr = cmd.ExecuteReader()
        dr.Read()

        txtSaleConsultantName.Text = dr("SalesConsultant")

    End Sub

    Private Sub btnDemoMeetingSchedule_Click(sender As Object, e As EventArgs) Handles btnDemoMeetingSchedule.Click

        Dim cmd As New SqlCommand
        Dim connectionstring As String
        Dim con As SqlConnection


        Dim CN As String = cmbPotentialCustomerName.Text
        Dim SCN As String = txtSaleConsultantName.Text
        Dim SDate As Date = dtpMemoMeet.Value

        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZillionTechnologies;server=DESKTOP-9SA4VPE\MSSQLSERVER01"
        con = New SqlConnection(connectionstring)
        con.Open()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "insert into DemoSchedule values ('" & CN & "', '" & SCN & "','" & SDate & "')"

        cmd.ExecuteNonQuery()
        MsgBox("Meeting is Scheduled")

        cmbPotentialCustomerName.ResetText()
        txtSaleConsultantName.Text = ""
        dtpMemoMeet.ResetText()


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

