Imports System.Data.SqlClient
Imports System.Text

Public Class LeadGeneration
    Private Sub ZillionCustomTemplate31_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cmd.CommandText = "select * FROM LeadOwner"
        da.SelectCommand = cmd

        dr = cmd.ExecuteReader()
        While dr.Read()
            cmbleadOwner.Items.Add(dr("Lead Owner"))
        End While
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim connectionstring As String

        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZillionTechnologies;server=DESKTOP-9SA4VPE\MSSQLSERVER01"
        Dim con As New SqlConnection(connectionstring)

        'con.Open()

        For i As Integer = 0 To chlServicesInquiry.CheckedItems.Count - 1

            Dim cmd1 As New SqlCommand("insert into LeadInfo ( LeadOwner,CustName,EmailId,PhoneNumber,Products,EnquireDate,Interested,Company)values (@LeadOwner,@CustName,@EmailId,@PhoneNumber,@Products,@EnquireDate,@Interested,@Company)", con)


            cmd1.Parameters.AddWithValue("@LeadOwner", cmbleadOwner.SelectedItem)
            cmd1.Parameters.AddWithValue("@CustName", txtCusomerName.Text)
            cmd1.Parameters.AddWithValue("@EmailId", txEmailID.Text)
            cmd1.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text)
            cmd1.Parameters.AddWithValue("@Products", chlServicesInquiry.CheckedItems(i))
            cmd1.Parameters.AddWithValue("@EnquireDate", dtpEnquireDate.Value)
            cmd1.Parameters.AddWithValue("@Interested", clbInterested.SelectedItem)
            cmd1.Parameters.AddWithValue("@Company", txtCompany.Text)
            con.Open()
            cmd1.ExecuteNonQuery()
            con.Close()
        Next
        MessageBox.Show("Record Inserted")
        cmbleadOwner.ResetText()
        txtCusomerName.Text = ""
        txEmailID.Text = ""
        txtPhoneNumber.Text = ""
        'chlServicesInquiry.Items.Clear()
        dtpEnquireDate.ResetText()
        'clbInterested.Items. ""
        'clbInterested.ResetText()
        txtCompany.Text = ""


    End Sub

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        HomePage.Show()
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
