<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Proposal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proposal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeadGenerationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QualifiedLeadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DemoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProposalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NegotiationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpectedRevenueReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblProposal = New System.Windows.Forms.Label()
        Me.cmdSuccessFail = New System.Windows.Forms.ComboBox()
        Me.lstServiceProducts = New System.Windows.Forms.ListBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtSalesConsultantName = New System.Windows.Forms.TextBox()
        Me.txtCustomerExpectedPrice = New System.Windows.Forms.TextBox()
        Me.txtPropasalPrice = New System.Windows.Forms.TextBox()
        Me.cmbCustomerName = New System.Windows.Forms.ComboBox()
        Me.lblSuccessFail = New System.Windows.Forms.Label()
        Me.lblSalesConsultantName = New System.Windows.Forms.Label()
        Me.lblCustomerExpectedPrice = New System.Windows.Forms.Label()
        Me.lblPropasedPrice = New System.Windows.Forms.Label()
        Me.lblServicesProducts = New System.Windows.Forms.Label()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(138, 812)
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
        'lblProposal
        '
        Me.lblProposal.AutoSize = True
        Me.lblProposal.BackColor = System.Drawing.Color.Transparent
        Me.lblProposal.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProposal.Location = New System.Drawing.Point(439, 104)
        Me.lblProposal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProposal.Name = "lblProposal"
        Me.lblProposal.Size = New System.Drawing.Size(118, 34)
        Me.lblProposal.TabIndex = 54
        Me.lblProposal.Text = "Proposal"
        '
        'cmdSuccessFail
        '
        Me.cmdSuccessFail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdSuccessFail.FormattingEnabled = True
        Me.cmdSuccessFail.Items.AddRange(New Object() {"Success", "Fail"})
        Me.cmdSuccessFail.Location = New System.Drawing.Point(578, 633)
        Me.cmdSuccessFail.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSuccessFail.Name = "cmdSuccessFail"
        Me.cmdSuccessFail.Size = New System.Drawing.Size(416, 24)
        Me.cmdSuccessFail.TabIndex = 67
        '
        'lstServiceProducts
        '
        Me.lstServiceProducts.FormattingEnabled = True
        Me.lstServiceProducts.ItemHeight = 16
        Me.lstServiceProducts.Location = New System.Drawing.Point(578, 320)
        Me.lstServiceProducts.Margin = New System.Windows.Forms.Padding(4)
        Me.lstServiceProducts.Name = "lstServiceProducts"
        Me.lstServiceProducts.Size = New System.Drawing.Size(416, 164)
        Me.lstServiceProducts.TabIndex = 66
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(539, 698)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 52)
        Me.btnSave.TabIndex = 65
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtSalesConsultantName
        '
        Me.txtSalesConsultantName.Location = New System.Drawing.Point(578, 276)
        Me.txtSalesConsultantName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalesConsultantName.Name = "txtSalesConsultantName"
        Me.txtSalesConsultantName.ReadOnly = True
        Me.txtSalesConsultantName.Size = New System.Drawing.Size(416, 22)
        Me.txtSalesConsultantName.TabIndex = 64
        '
        'txtCustomerExpectedPrice
        '
        Me.txtCustomerExpectedPrice.Location = New System.Drawing.Point(578, 576)
        Me.txtCustomerExpectedPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerExpectedPrice.Name = "txtCustomerExpectedPrice"
        Me.txtCustomerExpectedPrice.Size = New System.Drawing.Size(416, 22)
        Me.txtCustomerExpectedPrice.TabIndex = 63
        '
        'txtPropasalPrice
        '
        Me.txtPropasalPrice.Location = New System.Drawing.Point(578, 518)
        Me.txtPropasalPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPropasalPrice.Name = "txtPropasalPrice"
        Me.txtPropasalPrice.Size = New System.Drawing.Size(416, 22)
        Me.txtPropasalPrice.TabIndex = 62
        '
        'cmbCustomerName
        '
        Me.cmbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomerName.FormattingEnabled = True
        Me.cmbCustomerName.Location = New System.Drawing.Point(578, 217)
        Me.cmbCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCustomerName.Name = "cmbCustomerName"
        Me.cmbCustomerName.Size = New System.Drawing.Size(416, 24)
        Me.cmbCustomerName.TabIndex = 61
        '
        'lblSuccessFail
        '
        Me.lblSuccessFail.AutoSize = True
        Me.lblSuccessFail.BackColor = System.Drawing.Color.Transparent
        Me.lblSuccessFail.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuccessFail.Location = New System.Drawing.Point(252, 630)
        Me.lblSuccessFail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSuccessFail.Name = "lblSuccessFail"
        Me.lblSuccessFail.Size = New System.Drawing.Size(130, 27)
        Me.lblSuccessFail.TabIndex = 60
        Me.lblSuccessFail.Text = "Success/Fail"
        '
        'lblSalesConsultantName
        '
        Me.lblSalesConsultantName.AutoSize = True
        Me.lblSalesConsultantName.BackColor = System.Drawing.Color.Transparent
        Me.lblSalesConsultantName.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesConsultantName.Location = New System.Drawing.Point(250, 276)
        Me.lblSalesConsultantName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalesConsultantName.Name = "lblSalesConsultantName"
        Me.lblSalesConsultantName.Size = New System.Drawing.Size(234, 27)
        Me.lblSalesConsultantName.TabIndex = 59
        Me.lblSalesConsultantName.Text = "Sales Consultant Name"
        '
        'lblCustomerExpectedPrice
        '
        Me.lblCustomerExpectedPrice.AutoSize = True
        Me.lblCustomerExpectedPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerExpectedPrice.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerExpectedPrice.Location = New System.Drawing.Point(250, 576)
        Me.lblCustomerExpectedPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerExpectedPrice.Name = "lblCustomerExpectedPrice"
        Me.lblCustomerExpectedPrice.Size = New System.Drawing.Size(258, 27)
        Me.lblCustomerExpectedPrice.TabIndex = 58
        Me.lblCustomerExpectedPrice.Text = "Customer Expected Price"
        '
        'lblPropasedPrice
        '
        Me.lblPropasedPrice.AutoSize = True
        Me.lblPropasedPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPropasedPrice.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPropasedPrice.Location = New System.Drawing.Point(250, 512)
        Me.lblPropasedPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPropasedPrice.Name = "lblPropasedPrice"
        Me.lblPropasedPrice.Size = New System.Drawing.Size(152, 27)
        Me.lblPropasedPrice.TabIndex = 57
        Me.lblPropasedPrice.Text = "Proposal Price"
        '
        'lblServicesProducts
        '
        Me.lblServicesProducts.AutoSize = True
        Me.lblServicesProducts.BackColor = System.Drawing.Color.Transparent
        Me.lblServicesProducts.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicesProducts.Location = New System.Drawing.Point(248, 394)
        Me.lblServicesProducts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServicesProducts.Name = "lblServicesProducts"
        Me.lblServicesProducts.Size = New System.Drawing.Size(190, 27)
        Me.lblServicesProducts.TabIndex = 56
        Me.lblServicesProducts.Text = "Services /Products"
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.BackColor = System.Drawing.Color.Transparent
        Me.lblCustomerName.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.Location = New System.Drawing.Point(248, 217)
        Me.lblCustomerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(168, 27)
        Me.lblCustomerName.TabIndex = 55
        Me.lblCustomerName.Text = "Customer Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1060, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(296, 812)
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label7.Location = New System.Drawing.Point(561, 790)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(235, 16)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "©ZillionTechnologies Sales Organization"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Proposal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 812)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdSuccessFail)
        Me.Controls.Add(Me.lstServiceProducts)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtSalesConsultantName)
        Me.Controls.Add(Me.txtCustomerExpectedPrice)
        Me.Controls.Add(Me.txtPropasalPrice)
        Me.Controls.Add(Me.cmbCustomerName)
        Me.Controls.Add(Me.lblSuccessFail)
        Me.Controls.Add(Me.lblSalesConsultantName)
        Me.Controls.Add(Me.lblCustomerExpectedPrice)
        Me.Controls.Add(Me.lblPropasedPrice)
        Me.Controls.Add(Me.lblServicesProducts)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.lblProposal)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Proposal"
        Me.Text = "Proposal"
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
    Friend WithEvents lblProposal As Label
    Friend WithEvents cmdSuccessFail As ComboBox
    Friend WithEvents lstServiceProducts As ListBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtSalesConsultantName As TextBox
    Friend WithEvents txtCustomerExpectedPrice As TextBox
    Friend WithEvents txtPropasalPrice As TextBox
    Friend WithEvents cmbCustomerName As ComboBox
    Friend WithEvents lblSuccessFail As Label
    Friend WithEvents lblSalesConsultantName As Label
    Friend WithEvents lblCustomerExpectedPrice As Label
    Friend WithEvents lblPropasedPrice As Label
    Friend WithEvents lblServicesProducts As Label
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
End Class
