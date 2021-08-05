Imports System.Data.SqlClient

Public Class Proposal
    Private Sub Proposal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cmd.CommandText = ("select CustomerName FROM DemoSchedule")

        da.SelectCommand = cmd

        dr = cmd.ExecuteReader()
        While dr.Read()
            cmbCustomerName.Items.Add(dr("CustomerName"))
            'txtSalesConsultantName.Text = dr("SalesConsultant")
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
        cmd.CommandText = ("select SalesConsultant FROM DemoSchedule")

        da.SelectCommand = cmd

        dr = cmd.ExecuteReader()
        While dr.Read()

            'cmbCustomerName.Items.Add(dr("CustomerName"))
            txtSalesConsultantName.Text = dr("SalesConsultant")
        End While
        con.Close()

        con.Open()


        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = ("select Products FROM LeadInfo where LeadOwner='" & txtSalesConsultantName.Text & "'")

        da.SelectCommand = cmd
        dr = cmd.ExecuteReader()

        Dim txt As String
        Dim i As Integer
        Do While dr.Read
            txt = dr.Item(0).ToString
            For i = 1 To dr.FieldCount - 1
                txt &= vbTab & dr.Item(i).ToString
            Next i
            lstServiceProducts.Items.Add(txt)

        Loop
        con.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmd As SqlCommand
        Dim connetionString As String
        Dim con As SqlConnection
        Dim CN As String = cmbCustomerName.Text
        Dim SCN As String = txtSalesConsultantName.Text
        Dim PPrice As Int64 = txtPropasalPrice.Text
        Dim CExpPrice As Int64 = txtCustomerExpectedPrice.Text
        'Dim SuccessFail As String = txtSuccessFail.Text
        Dim SuccesFail As String = cmdSuccessFail.Text


        connetionString = "Persist Security Info=False;Integrated Security=True;Initial Catalog=ZillionTechnologies;server=DESKTOP-9SA4VPE\MSSQLSERVER01"
        con = New SqlConnection(connetionString)
        con.Open()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text

        cmd.CommandText = "insert into Proposal values ('" & CN & "','" & SCN & "','" & PPrice & "','" & CExpPrice & "','" & SuccesFail & "')"

        cmd.ExecuteNonQuery()
        MsgBox("Record inserted successfully")

        cmbCustomerName.ResetText()
        txtSalesConsultantName.ResetText()
        lstServiceProducts.ResetText()
        txtPropasalPrice.Text = ""
        txtCustomerExpectedPrice.Text = ""
        cmdSuccessFail.ResetText()

    End Sub

    Private Sub DemoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DemoToolStripMenuItem.Click
        Demo.Show()
        Demo.DemoToolStripMenuItem.BackColor = Color.Green
        Me.Hide()
    End Sub

    Private Sub NegotiationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NegotiationToolStripMenuItem.Click
        Negotiation.Show()
        Negotiation.NegotiationToolStripMenuItem.BackColor = Color.Green
        Me.Hide()
    End Sub

    Private Sub QualifiedLeadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QualifiedLeadToolStripMenuItem.Click
        QualifiedLeads.Show()
        QualifiedLeads.QualifiedLeadToolStripMenuItem.BackColor = Color.Green
        Me.Hide()
    End Sub

    Private Sub LeadGenerationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeadGenerationToolStripMenuItem.Click
        LeadGeneration.Show()
        LeadGeneration.LeadGenerationToolStripMenuItem.BackColor = Color.Green
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
