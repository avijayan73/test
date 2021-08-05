Imports System.Data.SqlClient

Public Class QualifiedLeads
    Private Sub QualifiedLeads_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        cmd.CommandText = ("select CustName FROM LeadInfo where interested= 'Yes'")

        da.SelectCommand = cmd

        dr = cmd.ExecuteReader()
        While dr.Read()
            cmbCustomerName.Items.Add(dr("CustName"))
        End While

    End Sub

    Private Sub cmbCustomerName_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbCustomerName.SelectedValueChanged

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
        cmd.CommandText = "SELECT Products,LeadOwner FROM LeadInfo where CustName = '" & cmbCustomerName.Text & "' "

        da.SelectCommand = cmd
        dr = cmd.ExecuteReader()
        Dim txt As String
        Dim i As Integer
        Do While dr.Read
            txt = dr.Item(0).ToString
            For i = 1 To dr.FieldCount - 1
                txt &= vbTab & dr.Item(i).ToString
            Next i
            lstProductName.Items.Add(txt)
            txtItSalesConsultantName.Text = (dr("LeadOwner"))

        Loop

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As SqlCommand
        Dim connetionString As String
        Dim con As SqlConnection
        Dim CN As String = cmbCustomerName.Text
        Dim SCN As String = txtItSalesConsultantName.Text
        Dim S As String = cmbStatus.Text
        Dim D As Date = dtpLeadQualifiedDate.Value


        connetionString = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZillionTechnologies;server=DESKTOP-9SA4VPE\MSSQLSERVER01"
        con = New SqlConnection(connetionString)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "insert into LeadInitiateStatus values ('" & CN & "','" & SCN & "','" & S & "','" & D & "')"

        cmd.ExecuteNonQuery()
        MsgBox("Record inserted successfully")

        cmbCustomerName.ResetText()
        txtItSalesConsultantName.Text = ""
        txtItSalesConsultantName.Text = ""
        cmbStatus.ResetText()
        dtpLeadQualifiedDate.ResetText()


    End Sub

    Private Sub LeadGenerationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeadGenerationToolStripMenuItem.Click
        LeadGeneration.Show()
        LeadGeneration.LeadGenerationToolStripMenuItem.BackColor = Color.Green
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

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        HomePage.Show()
    End Sub
End Class
