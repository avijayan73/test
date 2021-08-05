<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QualifiedLeads
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QualifiedLeads))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeadGenerationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QualifiedLeadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DemoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProposalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NegotiationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpectedRevenueReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtpLeadQualifiedDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstProductName = New System.Windows.Forms.ListBox()
        Me.cmbCustomerName = New System.Windows.Forms.ComboBox()
        Me.txtItSalesConsultantName = New System.Windows.Forms.TextBox()
        Me.lblSalesConsultantName = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(140, 665)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(473, 111)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 34)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Qualified Leads"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(441, 534)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 43)
        Me.btnSave.TabIndex = 50
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dtpLeadQualifiedDate
        '
        Me.dtpLeadQualifiedDate.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLeadQualifiedDate.Location = New System.Drawing.Point(525, 472)
        Me.dtpLeadQualifiedDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpLeadQualifiedDate.Name = "dtpLeadQualifiedDate"
        Me.dtpLeadQualifiedDate.Size = New System.Drawing.Size(359, 22)
        Me.dtpLeadQualifiedDate.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(267, 472)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 27)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Lead Qualified Date"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Demo"})
        Me.cmbStatus.Location = New System.Drawing.Point(525, 427)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(359, 24)
        Me.cmbStatus.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(267, 428)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 27)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Status"
        '
        'lstProductName
        '
        Me.lstProductName.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProductName.FormattingEnabled = True
        Me.lstProductName.ItemHeight = 15
        Me.lstProductName.Location = New System.Drawing.Point(525, 226)
        Me.lstProductName.Margin = New System.Windows.Forms.Padding(4)
        Me.lstProductName.Name = "lstProductName"
        Me.lstProductName.Size = New System.Drawing.Size(359, 124)
        Me.lstProductName.TabIndex = 45
        '
        'cmbCustomerName
        '
        Me.cmbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomerName.FormattingEnabled = True
        Me.cmbCustomerName.Location = New System.Drawing.Point(525, 194)
        Me.cmbCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCustomerName.Name = "cmbCustomerName"
        Me.cmbCustomerName.Size = New System.Drawing.Size(359, 24)
        Me.cmbCustomerName.TabIndex = 44
        '
        'txtItSalesConsultantName
        '
        Me.txtItSalesConsultantName.Location = New System.Drawing.Point(525, 369)
        Me.txtItSalesConsultantName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItSalesConsultantName.Name = "txtItSalesConsultantName"
        Me.txtItSalesConsultantName.ReadOnly = True
        Me.txtItSalesConsultantName.Size = New System.Drawing.Size(359, 22)
        Me.txtItSalesConsultantName.TabIndex = 43
        '
        'lblSalesConsultantName
        '
        Me.lblSalesConsultantName.AutoSize = True
        Me.lblSalesConsultantName.BackColor = System.Drawing.Color.Transparent
        Me.lblSalesConsultantName.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesConsultantName.Location = New System.Drawing.Point(267, 369)
        Me.lblSalesConsultantName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSalesConsultantName.Name = "lblSalesConsultantName"
        Me.lblSalesConsultantName.Size = New System.Drawing.Size(234, 27)
        Me.lblSalesConsultantName.TabIndex = 42
        Me.lblSalesConsultantName.Text = "Sales Consultant Name"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.BackColor = System.Drawing.Color.Transparent
        Me.lblProductName.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProductName.Location = New System.Drawing.Point(267, 286)
        Me.lblProductName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(151, 27)
        Me.lblProductName.TabIndex = 41
        Me.lblProductName.Text = "Product Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(267, 191)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 27)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Customer Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label7.Location = New System.Drawing.Point(447, 643)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(235, 16)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "©ZillionTechnologies Sales Organization"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(891, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 665)
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        '
        'QualifiedLeads
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 665)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpLeadQualifiedDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstProductName)
        Me.Controls.Add(Me.cmbCustomerName)
        Me.Controls.Add(Me.txtItSalesConsultantName)
        Me.Controls.Add(Me.lblSalesConsultantName)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "QualifiedLeads"
        Me.Text = "QualifiedLeads"
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
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents dtpLeadQualifiedDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lstProductName As ListBox
    Friend WithEvents cmbCustomerName As ComboBox
    Friend WithEvents txtItSalesConsultantName As TextBox
    Friend WithEvents lblSalesConsultantName As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
End Class
