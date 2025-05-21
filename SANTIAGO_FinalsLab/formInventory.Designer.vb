<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formInventory
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.cmbBranches = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdOutOfStock = New System.Windows.Forms.RadioButton()
        Me.rdIncoming = New System.Windows.Forms.RadioButton()
        Me.rdCurrentStock = New System.Windows.Forms.RadioButton()
        Me.dgvResult = New System.Windows.Forms.DataGridView()
        Me.cItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCurrent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cIncoming = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbBranches
        '
        Me.cmbBranches.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBranches.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbBranches.FormattingEnabled = True
        Me.cmbBranches.Location = New System.Drawing.Point(103, 12)
        Me.cmbBranches.Name = "cmbBranches"
        Me.cmbBranches.Size = New System.Drawing.Size(278, 29)
        Me.cmbBranches.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 21)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Branches:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdOutOfStock)
        Me.GroupBox1.Controls.Add(Me.rdIncoming)
        Me.GroupBox1.Controls.Add(Me.rdCurrentStock)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 108)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inventory Type"
        '
        'rdOutOfStock
        '
        Me.rdOutOfStock.AutoSize = True
        Me.rdOutOfStock.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdOutOfStock.Location = New System.Drawing.Point(393, 52)
        Me.rdOutOfStock.Name = "rdOutOfStock"
        Me.rdOutOfStock.Size = New System.Drawing.Size(122, 25)
        Me.rdOutOfStock.TabIndex = 2
        Me.rdOutOfStock.TabStop = True
        Me.rdOutOfStock.Text = "Out of Stock"
        Me.rdOutOfStock.UseVisualStyleBackColor = True
        '
        'rdIncoming
        '
        Me.rdIncoming.AutoSize = True
        Me.rdIncoming.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdIncoming.Location = New System.Drawing.Point(219, 54)
        Me.rdIncoming.Name = "rdIncoming"
        Me.rdIncoming.Size = New System.Drawing.Size(144, 25)
        Me.rdIncoming.TabIndex = 1
        Me.rdIncoming.TabStop = True
        Me.rdIncoming.Text = "Incoming Stock"
        Me.rdIncoming.UseVisualStyleBackColor = True
        '
        'rdCurrentStock
        '
        Me.rdCurrentStock.AutoSize = True
        Me.rdCurrentStock.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdCurrentStock.Location = New System.Drawing.Point(48, 52)
        Me.rdCurrentStock.Name = "rdCurrentStock"
        Me.rdCurrentStock.Size = New System.Drawing.Size(131, 25)
        Me.rdCurrentStock.TabIndex = 0
        Me.rdCurrentStock.TabStop = True
        Me.rdCurrentStock.Text = "Current Stock"
        Me.rdCurrentStock.UseVisualStyleBackColor = True
        '
        'dgvResult
        '
        Me.dgvResult.AllowUserToAddRows = False
        Me.dgvResult.AllowUserToOrderColumns = True
        Me.dgvResult.AllowUserToResizeColumns = False
        Me.dgvResult.AllowUserToResizeRows = False
        Me.dgvResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        Me.dgvResult.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cItem, Me.cCurrent, Me.cIncoming})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(103, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResult.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvResult.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.dgvResult.Location = New System.Drawing.Point(17, 171)
        Me.dgvResult.MultiSelect = False
        Me.dgvResult.Name = "dgvResult"
        Me.dgvResult.ReadOnly = True
        Me.dgvResult.RowHeadersVisible = False
        Me.dgvResult.RowHeadersWidth = 51
        Me.dgvResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResult.Size = New System.Drawing.Size(569, 322)
        Me.dgvResult.TabIndex = 23
        '
        'cItem
        '
        Me.cItem.DataPropertyName = "itemName"
        Me.cItem.HeaderText = "Item Name"
        Me.cItem.MinimumWidth = 6
        Me.cItem.Name = "cItem"
        Me.cItem.ReadOnly = True
        '
        'cCurrent
        '
        Me.cCurrent.DataPropertyName = "currentStock"
        Me.cCurrent.FillWeight = 55.0!
        Me.cCurrent.HeaderText = "Current Stock"
        Me.cCurrent.MinimumWidth = 6
        Me.cCurrent.Name = "cCurrent"
        Me.cCurrent.ReadOnly = True
        '
        'cIncoming
        '
        Me.cIncoming.DataPropertyName = "incomingStock"
        Me.cIncoming.HeaderText = "Incoming Stock"
        Me.cIncoming.MinimumWidth = 6
        Me.cIncoming.Name = "cIncoming"
        Me.cIncoming.ReadOnly = True
        '
        'formInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 505)
        Me.Controls.Add(Me.dgvResult)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbBranches)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbBranches As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdOutOfStock As RadioButton
    Friend WithEvents rdIncoming As RadioButton
    Friend WithEvents rdCurrentStock As RadioButton
    Friend WithEvents dgvResult As DataGridView
    Friend WithEvents cItem As DataGridViewTextBoxColumn
    Friend WithEvents cCurrent As DataGridViewTextBoxColumn
    Friend WithEvents cIncoming As DataGridViewTextBoxColumn
End Class
