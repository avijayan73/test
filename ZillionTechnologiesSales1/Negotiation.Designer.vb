<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Negotiation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Negotiation))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeadGenerationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QualifiedLeadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DemoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProposalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NegotiationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpectedRevenueReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpCloseDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbAgreementDone = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtAccepted = New System.Windows.Forms.TextBox()
        Me.txtZillionPrice = New System.Windows.Forms.TextBox()
        Me.txtCustomerPrice = New System.Windows.Forms.TextBox()
        Me.lstProduct = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSalesConsultantName = New System.Windows.Forms.TextBox()
        Me.cmbCustomerName = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(50, 50)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.LeadGenerationToolStripMenuItem, Me.QualifiedLeadToolStripMenuItem, Me.DemoToolStripMenuItem, Me.ProposalToolStripMenuItem, Me.NegotiationToolStripMenuItem, Me.ExpectedRevenueReportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(138, 786)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Image = CType(resources.GetObject("HomeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(125, 74)
        Me.HomeToolStripMenuItem.Text = "Home"
        Me.HomeToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HomeToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.HomeToolStripMenuItem.ToolTipText = "Lead Generator"
        '
        'LeadGenerationToolStripMenuItem
        '
        Me.LeadGenerationToolStripMenuItem.Image = CType(resources.GetObject("LeadGenerationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LeadGenerationToolStripMenuItem.Name = "LeadGenerationToolStripMenuItem"
        Me.LeadGenerationToolStripMenuItem.Size = New System.Drawing.Size(125, 74)
        Me.LeadGenerationToolStripMenuItem.Text = "Lead Generation"
        Me.LeadGenerationToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LeadGenerationToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'QualifiedLeadToolStripMenuItem
        '
        Me.QualifiedLeadToolStripMenuItem.Image = CType(resources.GetObject("QualifiedLeadToolStripMenuItem.Image"), System.Drawing.Image)
        Me.QualifiedLeadToolStripMenuItem.Name = "QualifiedLeadToolStripMenuItem"
        Me.QualifiedLeadToolStripMenuItem.Size = New System.Drawing.Size(125, 74)
        Me.QualifiedLeadToolStripMenuItem.Text = "Qualified Lead"
        Me.QualifiedLeadToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DemoToolStripMenuItem
        '
        Me.DemoToolStripMenuItem.Image = CType(resources.GetObject("DemoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DemoToolStripMenuItem.Name = "DemoToolStripMenuItem"
        Me.DemoToolStripMenuItem.Size = New System.Drawing.Size(125, 74)
        Me.DemoToolStripMenuItem.Text = "Demo"
        Me.DemoToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ProposalToolStripMenuItem
        '
        Me.ProposalToolStripMenuItem.Image = CType(resources.GetObject("ProposalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProposalToolStripMenuItem.Name = "ProposalToolStripMenuItem"
        Me.ProposalToolStripMenuItem.Size = New System.Drawing.Size(125, 74)
        Me.ProposalToolStripMenuItem.Text = "Proposal"
        Me.ProposalToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'NegotiationToolStripMenuItem
        '
        Me.NegotiationToolStripMenuItem.Image = CType(resources.GetObject("NegotiationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NegotiationToolStripMenuItem.Name = "NegotiationToolStripMenuItem"
        Me.NegotiationToolStripMenuItem.Size = New System.Drawing.Size(125, 74)
        Me.NegotiationToolStripMenuItem.Text = "Negotiation"
        Me.NegotiationToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ExpectedRevenueReportToolStripMenuItem
        '
        Me.ExpectedRevenueReportToolStripMenuItem.Image = CType(resources.GetObject("ExpectedRevenueReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExpectedRevenueReportToolStripMenuItem.Name = "ExpectedRevenueReportToolStripMenuItem"
        Me.ExpectedRevenueReportToolStripMenuItem.Size = New System.Drawing.Size(125, 74)
        Me.ExpectedRevenueReportToolStripMenuItem.Text = " Revenue Report"
        Me.ExpectedRevenueReportToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(425, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 34)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Negotiation"
        '
        'dtpCloseDate
        '
        Me.dtpCloseDate.Location = New System.Drawing.Point(575, 593)
        Me.dtpCloseDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpCloseDate.Name = "dtpCloseDate"
        Me.dtpCloseDate.Size = New System.Drawing.Size(337, 22)
        Me.dtpCloseDate.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(236, 593)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 22)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Close Date"
        '
        'cmbAgreementDone
        '
        Me.cmbAgreementDone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAgreementDone.FormattingEnabled = True
        Me.cmbAgreementDone.Items.AddRange(New Object() {"Yes", "No"})
        Me.cmbAgreementDone.Location = New System.Drawing.Point(575, 544)
        Me.cmbAgreementDone.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbAgreementDone.Name = "cmbAgreementDone"
        Me.cmbAgreementDone.Size = New System.Drawing.Size(337, 24)
        Me.cmbAgreementDone.TabIndex = 70
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(513, 640)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(143, 50)
        Me.btnSave.TabIndex = 69
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtAccepted
        '
        Me.txtAccepted.Location = New System.Drawing.Point(576, 509)
        Me.txtAccepted.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAccepted.Name = "txtAccepted"
        Me.txtAccepted.Size = New System.Drawing.Size(337, 22)
        Me.txtAccepted.TabIndex = 68
        '
        'txtZillionPrice
        '
        Me.txtZillionPrice.Location = New System.Drawing.Point(576, 458)
        Me.txtZillionPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtZillionPrice.Name = "txtZillionPrice"
        Me.txtZillionPrice.Size = New System.Drawing.Size(337, 22)
        Me.txtZillionPrice.TabIndex = 67
        '
        'txtCustomerPrice
        '
        Me.txtCustomerPrice.Location = New System.Drawing.Point(575, 418)
        Me.txtCustomerPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerPrice.Name = "txtCustomerPrice"
        Me.txtCustomerPrice.Size = New System.Drawing.Size(337, 22)
        Me.txtCustomerPrice.TabIndex = 66
        '
        'lstProduct
        '
        Me.lstProduct.FormattingEnabled = True
        Me.lstProduct.ItemHeight = 16
        Me.lstProduct.Location = New System.Drawing.Point(575, 267)
        Me.lstProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.lstProduct.Name = "lstProduct"
        Me.lstProduct.Size = New System.Drawing.Size(337, 116)
        Me.lstProduct.TabIndex = 65
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(236, 322)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 22)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Product /Services"
        '
        'txtSalesConsultantName
        '
        Me.txtSalesConsultantName.Location = New System.Drawing.Point(575, 222)
        Me.txtSalesConsultantName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalesConsultantName.Name = "txtSalesConsultantName"
        Me.txtSalesConsultantName.ReadOnly = True
        Me.txtSalesConsultantName.Size = New System.Drawing.Size(337, 22)
        Me.txtSalesConsultantName.TabIndex = 63
        '
        'cmbCustomerName
        '
        Me.cmbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomerName.FormattingEnabled = True
        Me.cmbCustomerName.Location = New System.Drawing.Point(575, 179)
        Me.cmbCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCustomerName.Name = "cmbCustomerName"
        Me.cmbCustomerName.Size = New System.Drawing.Size(337, 24)
        Me.cmbCustomerName.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(236, 547)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 22)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "Agreement Done?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(236, 507)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(276, 22)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Accepted Price Upon Negotiation"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(236, 467)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 22)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Zillion Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(236, 429)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 22)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Customer Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(236, 226)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 22)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "SalesConsultant Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(236, 181)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 22)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Customer Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(938, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 786)
        Me.PictureBox1.TabIndex = 73
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label10.Location = New System.Drawing.Point(502, 768)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(235, 16)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "©ZillionTechnologies Sales Organization"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Negotiation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1239, 786)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dtpCloseDate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbAgreementDone)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtAccepted)
        Me.Controls.Add(Me.txtZillionPrice)
        Me.Controls.Add(Me.txtCustomerPrice)
        Me.Controls.Add(Me.lstProduct)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSalesConsultantName)
        Me.Controls.Add(Me.cmbCustomerName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Negotiation"
        Me.Text = "Negotiation"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeadGenerationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QualifiedLeadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DemoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProposalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NegotiationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExpectedRevenueReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpCloseDate As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbAgreementDone As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtAccepted As TextBox
    Friend WithEvents txtZillionPrice As TextBox
    Friend WithEvents txtCustomerPrice As TextBox
    Friend WithEvents lstProduct As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSalesConsultantName As TextBox
    Friend WithEvents cmbCustomerName As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
End Class
