<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.sideBarPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.productsMenu = New System.Windows.Forms.Panel()
        Me.btnSold = New System.Windows.Forms.Button()
        Me.btnYearly = New System.Windows.Forms.Button()
        Me.btnMonthly = New System.Windows.Forms.Button()
        Me.btnDaily = New System.Windows.Forms.Button()
        Me.productsManager = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.activePanel = New System.Windows.Forms.Panel()
        Me.headerPanel = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pageTitle = New System.Windows.Forms.Label()
        Me.mainPanel = New System.Windows.Forms.Panel()
        Me.sideBarPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.productsMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.headerPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'sideBarPanel
        '
        Me.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.sideBarPanel.Controls.Add(Me.Panel2)
        Me.sideBarPanel.Controls.Add(Me.Panel1)
        Me.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sideBarPanel.Location = New System.Drawing.Point(0, 0)
        Me.sideBarPanel.Name = "sideBarPanel"
        Me.sideBarPanel.Size = New System.Drawing.Size(285, 749)
        Me.sideBarPanel.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Controls.Add(Me.btnReports)
        Me.Panel2.Controls.Add(Me.productsMenu)
        Me.Panel2.Controls.Add(Me.productsManager)
        Me.Panel2.Controls.Add(Me.btnInventory)
        Me.Panel2.Controls.Add(Me.btnDashboard)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 177)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(285, 484)
        Me.Panel2.TabIndex = 3
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnLogout.Image = Global.INVENTORY_MANAGEMENT_SYSTEM.My.Resources.Resources.icons8_shutdown_48px
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(0, 431)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(268, 54)
        Me.btnLogout.TabIndex = 9
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnReports
        '
        Me.btnReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReports.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReports.FlatAppearance.BorderSize = 0
        Me.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReports.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnReports.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnReports.Image = Global.INVENTORY_MANAGEMENT_SYSTEM.My.Resources.Resources.icons8_combo_chart_48px
        Me.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReports.Location = New System.Drawing.Point(0, 377)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(268, 54)
        Me.btnReports.TabIndex = 8
        Me.btnReports.Text = "Reports"
        Me.btnReports.UseVisualStyleBackColor = False
        '
        'productsMenu
        '
        Me.productsMenu.BackColor = System.Drawing.Color.White
        Me.productsMenu.Controls.Add(Me.btnSold)
        Me.productsMenu.Controls.Add(Me.btnYearly)
        Me.productsMenu.Controls.Add(Me.btnMonthly)
        Me.productsMenu.Controls.Add(Me.btnDaily)
        Me.productsMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.productsMenu.Location = New System.Drawing.Point(0, 162)
        Me.productsMenu.Name = "productsMenu"
        Me.productsMenu.Size = New System.Drawing.Size(268, 215)
        Me.productsMenu.TabIndex = 6
        Me.productsMenu.Visible = False
        '
        'btnSold
        '
        Me.btnSold.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnSold.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSold.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSold.FlatAppearance.BorderSize = 0
        Me.btnSold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSold.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnSold.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnSold.Image = Global.INVENTORY_MANAGEMENT_SYSTEM.My.Resources.Resources.icons8_expensive_48px_1
        Me.btnSold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSold.Location = New System.Drawing.Point(0, 162)
        Me.btnSold.Name = "btnSold"
        Me.btnSold.Size = New System.Drawing.Size(268, 54)
        Me.btnSold.TabIndex = 11
        Me.btnSold.Text = "Sold"
        Me.btnSold.UseVisualStyleBackColor = False
        '
        'btnYearly
        '
        Me.btnYearly.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnYearly.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYearly.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnYearly.FlatAppearance.BorderSize = 0
        Me.btnYearly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYearly.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnYearly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnYearly.Image = Global.INVENTORY_MANAGEMENT_SYSTEM.My.Resources.Resources.icons8_2021_48px1
        Me.btnYearly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnYearly.Location = New System.Drawing.Point(0, 108)
        Me.btnYearly.Name = "btnYearly"
        Me.btnYearly.Size = New System.Drawing.Size(268, 54)
        Me.btnYearly.TabIndex = 10
        Me.btnYearly.Text = "Yearly"
        Me.btnYearly.UseVisualStyleBackColor = False
        '
        'btnMonthly
        '
        Me.btnMonthly.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnMonthly.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMonthly.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMonthly.FlatAppearance.BorderSize = 0
        Me.btnMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonthly.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnMonthly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnMonthly.Image = Global.INVENTORY_MANAGEMENT_SYSTEM.My.Resources.Resources.icons8_calendar_30_48px
        Me.btnMonthly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMonthly.Location = New System.Drawing.Point(0, 54)
        Me.btnMonthly.Name = "btnMonthly"
        Me.btnMonthly.Size = New System.Drawing.Size(268, 54)
        Me.btnMonthly.TabIndex = 9
        Me.btnMonthly.Text = "Monthly"
        Me.btnMonthly.UseVisualStyleBackColor = False
        '
        'btnDaily
        '
        Me.btnDaily.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDaily.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDaily.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDaily.FlatAppearance.BorderSize = 0
        Me.btnDaily.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDaily.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnDaily.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnDaily.Image = Global.INVENTORY_MANAGEMENT_SYSTEM.My.Resources.Resources.icons8_calendar_1_48px
        Me.btnDaily.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDaily.Location = New System.Drawing.Point(0, 0)
        Me.btnDaily.Name = "btnDaily"
        Me.btnDaily.Size = New System.Drawing.Size(268, 54)
        Me.btnDaily.TabIndex = 8
        Me.btnDaily.Text = "Daily"
        Me.btnDaily.UseVisualStyleBackColor = False
        '
        'productsManager
        '
        Me.productsManager.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.productsManager.Cursor = System.Windows.Forms.Cursors.Hand
        Me.productsManager.Dock = System.Windows.Forms.DockStyle.Top
        Me.productsManager.FlatAppearance.BorderSize = 0
        Me.productsManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.productsManager.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.productsManager.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.productsManager.Image = Global.INVENTORY_MANAGEMENT_SYSTEM.My.Resources.Resources.icons8_box_48px
        Me.productsManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.productsManager.Location = New System.Drawing.Point(0, 108)
        Me.productsManager.Name = "productsManager"
        Me.productsManager.Size = New System.Drawing.Size(268, 54)
        Me.productsManager.TabIndex = 2
        Me.productsManager.Text = "Products Manager"
        Me.productsManager.UseVisualStyleBackColor = False
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventory.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnInventory.FlatAppearance.BorderSize = 0
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInventory.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnInventory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnInventory.Image = Global.INVENTORY_MANAGEMENT_SYSTEM.My.Resources.Resources.icons8_product_48px
        Me.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInventory.Location = New System.Drawing.Point(0, 54)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(268, 54)
        Me.btnInventory.TabIndex = 1
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = False
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDashboard.FlatAppearance.BorderSize = 0
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnDashboard.Image = Global.INVENTORY_MANAGEMENT_SYSTEM.My.Resources.Resources.icons8_dashboard_layout_48px
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(0, 0)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(268, 54)
        Me.btnDashboard.TabIndex = 0
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(285, 177)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(87, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Inventory"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.INVENTORY_MANAGEMENT_SYSTEM.My.Resources.Resources.icons8_sell_stock_96px_1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(285, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'activePanel
        '
        Me.activePanel.AutoScroll = True
        Me.activePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.activePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.activePanel.Location = New System.Drawing.Point(285, 84)
        Me.activePanel.Name = "activePanel"
        Me.activePanel.Size = New System.Drawing.Size(945, 662)
        Me.activePanel.TabIndex = 3
        '
        'headerPanel
        '
        Me.headerPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.headerPanel.Controls.Add(Me.lblUser)
        Me.headerPanel.Controls.Add(Me.PictureBox2)
        Me.headerPanel.Controls.Add(Me.pageTitle)
        Me.headerPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.headerPanel.Location = New System.Drawing.Point(285, 0)
        Me.headerPanel.Name = "headerPanel"
        Me.headerPanel.Size = New System.Drawing.Size(945, 84)
        Me.headerPanel.TabIndex = 2
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Nirmala UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.lblUser.Location = New System.Drawing.Point(104, 49)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(62, 35)
        Me.lblUser.TabIndex = 2
        Me.lblUser.Text = "user"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.INVENTORY_MANAGEMENT_SYSTEM.My.Resources.Resources.icons8_speedometer_96px
        Me.PictureBox2.InitialImage = Global.INVENTORY_MANAGEMENT_SYSTEM.My.Resources.Resources.icons8_speedometer_96px
        Me.PictureBox2.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(98, 81)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'pageTitle
        '
        Me.pageTitle.AutoSize = True
        Me.pageTitle.Font = New System.Drawing.Font("Nirmala UI", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.pageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.pageTitle.Location = New System.Drawing.Point(104, 9)
        Me.pageTitle.Name = "pageTitle"
        Me.pageTitle.Size = New System.Drawing.Size(171, 41)
        Me.pageTitle.TabIndex = 0
        Me.pageTitle.Text = "Dashboard"
        '
        'mainPanel
        '
        Me.mainPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.mainPanel.Controls.Add(Me.activePanel)
        Me.mainPanel.Controls.Add(Me.headerPanel)
        Me.mainPanel.Controls.Add(Me.sideBarPanel)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mainPanel.Location = New System.Drawing.Point(0, 0)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(1230, 749)
        Me.mainPanel.TabIndex = 0
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1230, 749)
        Me.ControlBox = False
        Me.Controls.Add(Me.mainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.sideBarPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.productsMenu.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.headerPanel.ResumeLayout(False)
        Me.headerPanel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sideBarPanel As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnReports As Button
    Friend WithEvents productsMenu As Panel
    Friend WithEvents btnSold As Button
    Friend WithEvents btnYearly As Button
    Friend WithEvents btnMonthly As Button
    Friend WithEvents btnDaily As Button
    Friend WithEvents productsManager As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents activePanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents headerPanel As Panel
    Friend WithEvents pageTitle As Label
    Friend WithEvents mainPanel As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblUser As Label
End Class
