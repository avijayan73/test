<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeadGeneration
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LeadGeneration))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeadGenerationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QualifiedLeadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DemoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProposalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NegotiationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpectedRevenueReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblLeadInformation = New System.Windows.Forms.Label()
        Me.cmbleadOwner = New System.Windows.Forms.ComboBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbLeadSource = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.lblCompany = New System.Windows.Forms.Label()
        Me.dtpEnquireDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.clbInterested = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txEmailID = New System.Windows.Forms.TextBox()
        Me.lblEmailId = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtCusomerName = New System.Windows.Forms.TextBox()
        Me.chlServicesInquiry = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(140, 869)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HomeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HomeToolStripMenuItem.Checked = True
        Me.HomeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HomeToolStripMenuItem.Image = CType(resources.GetObject("HomeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HomeToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HomeToolStripMenuItem.Margin = New System.Windows.Forms.Padding(2)
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(121, 74)
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
        'lblLeadInformation
        '
        Me.lblLeadInformation.AutoSize = True
        Me.lblLeadInformation.BackColor = System.Drawing.Color.Transparent
        Me.lblLeadInformation.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLeadInformation.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblLeadInformation.Location = New System.Drawing.Point(416, 21)
        Me.lblLeadInformation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLeadInformation.Name = "lblLeadInformation"
        Me.lblLeadInformation.Size = New System.Drawing.Size(244, 37)
        Me.lblLeadInformation.TabIndex = 4
        Me.lblLeadInformation.Text = "Lead Information"
        '
        'cmbleadOwner
        '
        Me.cmbleadOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbleadOwner.FormattingEnabled = True
        Me.cmbleadOwner.Location = New System.Drawing.Point(673, 138)
        Me.cmbleadOwner.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbleadOwner.Name = "cmbleadOwner"
        Me.cmbleadOwner.Size = New System.Drawing.Size(303, 24)
        Me.cmbleadOwner.TabIndex = 26
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.BackColor = System.Drawing.Color.Transparent
        Me.lbl.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(363, 138)
        Me.lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(171, 27)
        Me.lbl.TabIndex = 25
        Me.lbl.Text = "Sales Consultant"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label7.Location = New System.Drawing.Point(712, 843)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(235, 16)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "©ZillionTechnologies Sales Organization"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmbLeadSource
        '
        Me.cmbLeadSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLeadSource.FormattingEnabled = True
        Me.cmbLeadSource.Items.AddRange(New Object() {"Newspaper", "Call", "Paper Ads", "Online Ads", "Referral", ""})
        Me.cmbLeadSource.Location = New System.Drawing.Point(675, 672)
        Me.cmbLeadSource.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbLeadSource.Name = "cmbLeadSource"
        Me.cmbLeadSource.Size = New System.Drawing.Size(303, 24)
        Me.cmbLeadSource.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Symbol", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.Label6.Location = New System.Drawing.Point(370, 682)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 30)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Lead Source"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(675, 639)
        Me.txtCompany.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(303, 22)
        Me.txtCompany.TabIndex = 42
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.BackColor = System.Drawing.Color.Transparent
        Me.lblCompany.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(370, 640)
        Me.lblCompany.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.Size = New System.Drawing.Size(105, 27)
        Me.lblCompany.TabIndex = 41
        Me.lblCompany.Text = "Company"
        '
        'dtpEnquireDate
        '
        Me.dtpEnquireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpEnquireDate.Location = New System.Drawing.Point(675, 513)
        Me.dtpEnquireDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpEnquireDate.Name = "dtpEnquireDate"
        Me.dtpEnquireDate.Size = New System.Drawing.Size(303, 22)
        Me.dtpEnquireDate.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(370, 520)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 27)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Enquire Date"
        '
        'clbInterested
        '
        Me.clbInterested.CheckOnClick = True
        Me.clbInterested.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbInterested.FormattingEnabled = True
        Me.clbInterested.Items.AddRange(New Object() {"Yes", "No"})
        Me.clbInterested.Location = New System.Drawing.Point(673, 567)
        Me.clbInterested.Margin = New System.Windows.Forms.Padding(4)
        Me.clbInterested.Name = "clbInterested"
        Me.clbInterested.Size = New System.Drawing.Size(82, 54)
        Me.clbInterested.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(365, 579)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 27)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Shown Interest"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(675, 289)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(303, 22)
        Me.txtPhoneNumber.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(370, 283)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 27)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Phone Number"
        '
        'txEmailID
        '
        Me.txEmailID.Location = New System.Drawing.Point(675, 244)
        Me.txEmailID.Margin = New System.Windows.Forms.Padding(4)
        Me.txEmailID.Name = "txEmailID"
        Me.txEmailID.Size = New System.Drawing.Size(303, 22)
        Me.txEmailID.TabIndex = 34
        '
        'lblEmailId
        '
        Me.lblEmailId.AutoSize = True
        Me.lblEmailId.BackColor = System.Drawing.Color.Transparent
        Me.lblEmailId.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmailId.Location = New System.Drawing.Point(370, 244)
        Me.lblEmailId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmailId.Name = "lblEmailId"
        Me.lblEmailId.Size = New System.Drawing.Size(99, 27)
        Me.lblEmailId.TabIndex = 33
        Me.lblEmailId.Text = "Email ID"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSubmit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(529, 731)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(129, 58)
        Me.btnSubmit.TabIndex = 32
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'txtCusomerName
        '
        Me.txtCusomerName.Location = New System.Drawing.Point(675, 185)
        Me.txtCusomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCusomerName.Name = "txtCusomerName"
        Me.txtCusomerName.Size = New System.Drawing.Size(303, 22)
        Me.txtCusomerName.TabIndex = 31
        '
        'chlServicesInquiry
        '
        Me.chlServicesInquiry.CheckOnClick = True
        Me.chlServicesInquiry.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chlServicesInquiry.FormattingEnabled = True
        Me.chlServicesInquiry.Items.AddRange(New Object() {"Digital Transformation", "Cybersecurity", "dotz-Zillion ERP Solutions", "Zillion ERP Solutions", "AI Cyber Risk Engine", "neasaa"})
        Me.chlServicesInquiry.Location = New System.Drawing.Point(675, 333)
        Me.chlServicesInquiry.Margin = New System.Windows.Forms.Padding(4)
        Me.chlServicesInquiry.Name = "chlServicesInquiry"
        Me.chlServicesInquiry.Size = New System.Drawing.Size(303, 154)
        Me.chlServicesInquiry.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(365, 185)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 27)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(365, 389)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 27)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Products"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1202, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(307, 869)
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'LeadGeneration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1509, 869)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbLeadSource)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCompany)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.dtpEnquireDate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.clbInterested)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txEmailID)
        Me.Controls.Add(Me.lblEmailId)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtCusomerName)
        Me.Controls.Add(Me.chlServicesInquiry)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbleadOwner)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.lblLeadInformation)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "LeadGeneration"
        Me.Text = "LeadGeneration"
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
    Friend WithEvents lblLeadInformation As Label
    Friend WithEvents cmbleadOwner As ComboBox
    Friend WithEvents lbl As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbLeadSource As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCompany As TextBox
    Friend WithEvents lblCompany As Label
    Friend WithEvents dtpEnquireDate As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents clbInterested As CheckedListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txEmailID As TextBox
    Friend WithEvents lblEmailId As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtCusomerName As TextBox
    Friend WithEvents chlServicesInquiry As CheckedListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
