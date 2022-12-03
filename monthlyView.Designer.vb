<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class monthlyView
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAddProducts = New System.Windows.Forms.Button()
        Me.productsTable = New System.Windows.Forms.DataGridView()
        Me.tablePanel = New System.Windows.Forms.Panel()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnProductsOut = New System.Windows.Forms.Button()
        Me.btnProductsIn = New System.Windows.Forms.Button()
        CType(Me.productsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tablePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddProducts
        '
        Me.btnAddProducts.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnAddProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddProducts.FlatAppearance.BorderSize = 0
        Me.btnAddProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProducts.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnAddProducts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnAddProducts.Image = Global.INVENTORY_MANAGEMENT_SYSTEM.My.Resources.Resources.icons8_print_24px
        Me.btnAddProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddProducts.Location = New System.Drawing.Point(12, 9)
        Me.btnAddProducts.Name = "btnAddProducts"
        Me.btnAddProducts.Size = New System.Drawing.Size(130, 50)
        Me.btnAddProducts.TabIndex = 10
        Me.btnAddProducts.Text = "Print"
        Me.btnAddProducts.UseVisualStyleBackColor = False
        '
        'productsTable
        '
        Me.productsTable.AllowUserToAddRows = False
        Me.productsTable.AllowUserToDeleteRows = False
        Me.productsTable.AllowUserToResizeColumns = False
        Me.productsTable.AllowUserToResizeRows = False
        Me.productsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.productsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.productsTable.BackgroundColor = System.Drawing.Color.White
        Me.productsTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.productsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.productsTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.productsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.productsTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.productsTable.ColumnHeadersHeight = 50
        Me.productsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.productsTable.DefaultCellStyle = DataGridViewCellStyle14
        Me.productsTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.productsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.productsTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.productsTable.Location = New System.Drawing.Point(0, 0)
        Me.productsTable.MultiSelect = False
        Me.productsTable.Name = "productsTable"
        Me.productsTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.productsTable.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.productsTable.RowHeadersVisible = False
        Me.productsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Nirmala UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle16.Padding = New System.Windows.Forms.Padding(5)
        Me.productsTable.RowsDefaultCellStyle = DataGridViewCellStyle16
        Me.productsTable.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(5)
        Me.productsTable.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.productsTable.RowTemplate.DividerHeight = 1
        Me.productsTable.RowTemplate.Height = 40
        Me.productsTable.RowTemplate.ReadOnly = True
        Me.productsTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.productsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.productsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.productsTable.ShowCellErrors = False
        Me.productsTable.ShowCellToolTips = False
        Me.productsTable.ShowEditingIcon = False
        Me.productsTable.ShowRowErrors = False
        Me.productsTable.Size = New System.Drawing.Size(1020, 522)
        Me.productsTable.TabIndex = 0
        '
        'tablePanel
        '
        Me.tablePanel.AutoScroll = True
        Me.tablePanel.BackColor = System.Drawing.Color.White
        Me.tablePanel.Controls.Add(Me.productsTable)
        Me.tablePanel.Location = New System.Drawing.Point(12, 65)
        Me.tablePanel.Name = "tablePanel"
        Me.tablePanel.Size = New System.Drawing.Size(1020, 522)
        Me.tablePanel.TabIndex = 9
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Nirmala UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.lblStatus.Location = New System.Drawing.Point(500, 24)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(164, 32)
        Me.lblStatus.TabIndex = 14
        Me.lblStatus.Text = "PRODUCTS IN"
        '
        'btnProductsOut
        '
        Me.btnProductsOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnProductsOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductsOut.FlatAppearance.BorderSize = 0
        Me.btnProductsOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductsOut.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnProductsOut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnProductsOut.Image = Global.INVENTORY_MANAGEMENT_SYSTEM.My.Resources.Resources.icons8_shipped_48px
        Me.btnProductsOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductsOut.Location = New System.Drawing.Point(284, 9)
        Me.btnProductsOut.Name = "btnProductsOut"
        Me.btnProductsOut.Size = New System.Drawing.Size(140, 50)
        Me.btnProductsOut.TabIndex = 13
        Me.btnProductsOut.Text = "Products out"
        Me.btnProductsOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProductsOut.UseVisualStyleBackColor = False
        '
        'btnProductsIn
        '
        Me.btnProductsIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.btnProductsIn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductsIn.FlatAppearance.BorderSize = 0
        Me.btnProductsIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductsIn.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.btnProductsIn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.btnProductsIn.Image = Global.INVENTORY_MANAGEMENT_SYSTEM.My.Resources.Resources.icons8_box_48px
        Me.btnProductsIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductsIn.Location = New System.Drawing.Point(148, 9)
        Me.btnProductsIn.Name = "btnProductsIn"
        Me.btnProductsIn.Size = New System.Drawing.Size(130, 50)
        Me.btnProductsIn.TabIndex = 12
        Me.btnProductsIn.Text = "Products in"
        Me.btnProductsIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProductsIn.UseVisualStyleBackColor = False
        '
        'monthlyView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(962, 749)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnProductsOut)
        Me.Controls.Add(Me.btnProductsIn)
        Me.Controls.Add(Me.btnAddProducts)
        Me.Controls.Add(Me.tablePanel)
        Me.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "monthlyView"
        Me.Text = "monthlyView"
        CType(Me.productsTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tablePanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddProducts As Button
    Friend WithEvents productsTable As DataGridView
    Friend WithEvents tablePanel As Panel
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnProductsOut As Button
    Friend WithEvents btnProductsIn As Button
End Class
