<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Demo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Demo))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeadGenerationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QualifiedLeadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DemoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProposalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NegotiationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpectedRevenueReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDemoMeetingSchedule = New System.Windows.Forms.Button()
        Me.dtpMemoMeet = New System.Windows.Forms.DateTimePicker()
        Me.txtSaleConsultantName = New System.Windows.Forms.TextBox()
        Me.cmbPotentialCustomerName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.Label2.Location = New System.Drawing.Point(314, 190)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(493, 34)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Demo / Meeting For Potential Customer"
        '
        'btnDemoMeetingSchedule
        '
        Me.btnDemoMeetingSchedule.BackColor = System.Drawing.Color.Transparent
        Me.btnDemoMeetingSchedule.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDemoMeetingSchedule.Location = New System.Drawing.Point(472, 443)
        Me.btnDemoMeetingSchedule.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDemoMeetingSchedule.Name = "btnDemoMeetingSchedule"
        Me.btnDemoMeetingSchedule.Size = New System.Drawing.Size(267, 48)
        Me.btnDemoMeetingSchedule.TabIndex = 60
        Me.btnDemoMeetingSchedule.Text = "Demo Meeting Schedule"
        Me.btnDemoMeetingSchedule.UseVisualStyleBackColor = False
        '
        'dtpMemoMeet
        '
        Me.dtpMemoMeet.Location = New System.Drawing.Point(593, 372)
        Me.dtpMemoMeet.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpMemoMeet.Name = "dtpMemoMeet"
        Me.dtpMemoMeet.Size = New System.Drawing.Size(285, 22)
        Me.dtpMemoMeet.TabIndex = 59
        '
        'txtSaleConsultantName
        '
        Me.txtSaleConsultantName.Location = New System.Drawing.Point(593, 327)
        Me.txtSaleConsultantName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSaleConsultantName.Name = "txtSaleConsultantName"
        Me.txtSaleConsultantName.ReadOnly = True
        Me.txtSaleConsultantName.Size = New System.Drawing.Size(285, 22)
        Me.txtSaleConsultantName.TabIndex = 58
        '
        'cmbPotentialCustomerName
        '
        Me.cmbPotentialCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPotentialCustomerName.FormattingEnabled = True
        Me.cmbPotentialCustomerName.Location = New System.Drawing.Point(593, 283)
        Me.cmbPotentialCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbPotentialCustomerName.Name = "cmbPotentialCustomerName"
        Me.cmbPotentialCustomerName.Size = New System.Drawing.Size(285, 24)
        Me.cmbPotentialCustomerName.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(271, 328)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 27)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Sale Consultant Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(271, 372)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 27)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Meeting DateTime"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 283)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(260, 27)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Potential Customer Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(908, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 665)
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label7.Location = New System.Drawing.Point(490, 639)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(235, 16)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "©ZillionTechnologies Sales Organization"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Demo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 665)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnDemoMeetingSchedule)
        Me.Controls.Add(Me.dtpMemoMeet)
        Me.Controls.Add(Me.txtSaleConsultantName)
        Me.Controls.Add(Me.cmbPotentialCustomerName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Demo"
        Me.Text = "Demo"
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
    Friend WithEvents btnDemoMeetingSchedule As Button
    Friend WithEvents dtpMemoMeet As DateTimePicker
    Friend WithEvents txtSaleConsultantName As TextBox
    Friend WithEvents cmbPotentialCustomerName As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
End Class
