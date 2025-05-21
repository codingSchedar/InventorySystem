<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PurchaseItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BranchManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvMain = New System.Windows.Forms.DataGridView()
        Me.cItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDateOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cSource = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDestination = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cAction = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PurchaseItemsToolStripMenuItem, Me.BranchManagementToolStripMenuItem, Me.ItemManagementToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(785, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PurchaseItemsToolStripMenuItem
        '
        Me.PurchaseItemsToolStripMenuItem.Name = "PurchaseItemsToolStripMenuItem"
        Me.PurchaseItemsToolStripMenuItem.Size = New System.Drawing.Size(121, 24)
        Me.PurchaseItemsToolStripMenuItem.Text = "Purchase Items"
        '
        'BranchManagementToolStripMenuItem
        '
        Me.BranchManagementToolStripMenuItem.Name = "BranchManagementToolStripMenuItem"
        Me.BranchManagementToolStripMenuItem.Size = New System.Drawing.Size(133, 24)
        Me.BranchManagementToolStripMenuItem.Text = "Inventory Report"
        '
        'ItemManagementToolStripMenuItem
        '
        Me.ItemManagementToolStripMenuItem.Name = "ItemManagementToolStripMenuItem"
        Me.ItemManagementToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.ItemManagementToolStripMenuItem.Text = "Logout"
        '
        'dgvMain
        '
        Me.dgvMain.AllowUserToAddRows = False
        Me.dgvMain.AllowUserToOrderColumns = True
        Me.dgvMain.AllowUserToResizeColumns = False
        Me.dgvMain.AllowUserToResizeRows = False
        Me.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMain.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgvMain.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cItem, Me.cDateOrder, Me.cAmount, Me.cSource, Me.cDestination, Me.cAction})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMain.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMain.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.dgvMain.Location = New System.Drawing.Point(16, 31)
        Me.dgvMain.MultiSelect = False
        Me.dgvMain.Name = "dgvMain"
        Me.dgvMain.ReadOnly = True
        Me.dgvMain.RowHeadersVisible = False
        Me.dgvMain.RowHeadersWidth = 51
        Me.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMain.Size = New System.Drawing.Size(757, 412)
        Me.dgvMain.TabIndex = 5
        '
        'cItem
        '
        Me.cItem.DataPropertyName = "itemName"
        Me.cItem.HeaderText = "Item Name"
        Me.cItem.MinimumWidth = 6
        Me.cItem.Name = "cItem"
        Me.cItem.ReadOnly = True
        '
        'cDateOrder
        '
        Me.cDateOrder.DataPropertyName = "date"
        Me.cDateOrder.FillWeight = 60.0!
        Me.cDateOrder.HeaderText = "Purchase Date"
        Me.cDateOrder.MinimumWidth = 6
        Me.cDateOrder.Name = "cDateOrder"
        Me.cDateOrder.ReadOnly = True
        '
        'cAmount
        '
        Me.cAmount.DataPropertyName = "amount"
        Me.cAmount.FillWeight = 55.0!
        Me.cAmount.HeaderText = "Amount"
        Me.cAmount.MinimumWidth = 6
        Me.cAmount.Name = "cAmount"
        Me.cAmount.ReadOnly = True
        '
        'cSource
        '
        Me.cSource.DataPropertyName = "source"
        Me.cSource.HeaderText = "Source"
        Me.cSource.MinimumWidth = 6
        Me.cSource.Name = "cSource"
        Me.cSource.ReadOnly = True
        '
        'cDestination
        '
        Me.cDestination.DataPropertyName = "destination"
        Me.cDestination.HeaderText = "Destination"
        Me.cDestination.MinimumWidth = 6
        Me.cDestination.Name = "cDestination"
        Me.cDestination.ReadOnly = True
        '
        'cAction
        '
        Me.cAction.FillWeight = 40.0!
        Me.cAction.HeaderText = "Action"
        Me.cAction.MinimumWidth = 6
        Me.cAction.Name = "cAction"
        Me.cAction.ReadOnly = True
        Me.cAction.Text = "Edit"
        Me.cAction.UseColumnTextForButtonValue = True
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Crimson
        Me.btnRemove.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(16, 449)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(170, 44)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "REMOVE"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 503)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.dgvMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Management"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PurchaseItemsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BranchManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ItemManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvMain As DataGridView
    Friend WithEvents cItem As DataGridViewTextBoxColumn
    Friend WithEvents cDateOrder As DataGridViewTextBoxColumn
    Friend WithEvents cAmount As DataGridViewTextBoxColumn
    Friend WithEvents cSource As DataGridViewTextBoxColumn
    Friend WithEvents cDestination As DataGridViewTextBoxColumn
    Friend WithEvents cAction As DataGridViewButtonColumn
    Friend WithEvents btnRemove As Button
End Class
