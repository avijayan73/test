Imports System.Data.SqlClient

Public Class Negotiation
    Private Sub Negotiation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        cmd.CommandText = ("select CustomerName FROM Proposal where SuccessFail='Success'")

        da.SelectCommand = cmd

        dr = cmd.ExecuteReader()
        While dr.Read()
            cmbCustomerName.Items.Add(dr("CustomerName"))
        End While

    End Sub

    Private Sub cmbCustomerName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCustomerName.SelectedIndexChanged



        Dim connectionstring As String
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dr As SqlDataReader

        connectionstring = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZillionTechnologies;server=DESKTOP-9SA4VPE\MSSQLSERVER01"
        Dim con As New SqlConnection(connectionstring)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = ("Select SalesConsultant,CustomerExpectedPrice,ProposalPrice FROM Proposal")

        da.SelectCommand = cmd

        dr = cmd.ExecuteReader()
        While dr.Read()

            'cmbCustomerName.Items.Add(dr("CustomerName"))
            txtSalesConsultantName.Text = dr("SalesConsultant")
            txtCustomerPrice.Text = dr("CustomerExpectedPrice")
            txtZillionPrice.Text = dr("ProposalPrice")
        End While
        con.Close()


        con.Open()


        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = ("Select Products FROM LeadInfo where LeadOwner='" & txtSalesConsultantName.Text & "'")

        da.SelectCommand = cmd
        dr = cmd.ExecuteReader()

        Dim txt As String
        Dim i As Integer
        Do While dr.Read
            txt = dr.Item(0).ToString
            For i = 1 To dr.FieldCount - 1
                txt &= vbTab & dr.Item(i).ToString
            Next i
            lstProduct.Items.Add(txt)

        Loop
        con.Close()




    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim cmd As SqlCommand
        Dim connetionString As String
        Dim con As SqlConnection
        Dim CN As String = cmbCustomerName.Text
        Dim SCN As String = txtSalesConsultantName.Text
        Dim AccPrice As Int64 = txtAccepted.Text
        Dim Agreement As String = cmbAgreementDone.Text
        Dim CloseDate As Date = dtpCloseDate.Value


        connetionString = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZillionTechnologies;server=DESKTOP-9SA4VPE\MSSQLSERVER01"
        con = New SqlConnection(connetionString)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "insert into Negotiation values ('" & CN & "','" & SCN & "','" & AccPrice & "','" & Agreement & "','" & CloseDate & "')"

        cmd.ExecuteNonQuery()
        MsgBox("Deal Closed")
        cmbCustomerName.Text = ""
        txtSalesConsultantName.Text = ""
        lstProduct.ResetText()
        txtCustomerPrice.Text = ""
        txtZillionPrice.Text = ""
        txtAccepted.Text = ""
        cmbAgreementDone.Text = ""
        'dtpCloseDate.Value = ""


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

    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        HomePage.Show()
    End Sub
    Private Sub ExpectedRevenueReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpectedRevenueReportToolStripMenuItem.Click
        RevenueReport.Show()
        RevenueReport.ExpectedRevenueReportToolStripMenuItem.BackColor = Color.Green
        Me.Hide()
    End Sub

End Class
