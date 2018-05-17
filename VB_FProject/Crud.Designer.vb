<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crud
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.for_peripherals = New System.Windows.Forms.Button()
        Me.for_gpu = New System.Windows.Forms.Button()
        Me.for_ram = New System.Windows.Forms.Button()
        Me.for_motherboard = New System.Windows.Forms.Button()
        Me.for_processor = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.change_items = New System.Windows.Forms.DataGridView()
        Me.processor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.p_status = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.p_update = New System.Windows.Forms.Button()
        Me.p_delete = New System.Windows.Forms.Button()
        Me.p_add = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.p_price = New System.Windows.Forms.TextBox()
        Me.p_qty = New System.Windows.Forms.TextBox()
        Me.p_name = New System.Windows.Forms.TextBox()
        Me.current_selection = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.change_items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-30, -19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1428, 112)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(72, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(484, 39)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Add, Delete, Update Items"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel2.Controls.Add(Me.current_selection)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.for_peripherals)
        Me.Panel2.Controls.Add(Me.for_gpu)
        Me.Panel2.Controls.Add(Me.for_ram)
        Me.Panel2.Controls.Add(Me.for_motherboard)
        Me.Panel2.Controls.Add(Me.for_processor)
        Me.Panel2.Location = New System.Drawing.Point(-5, 91)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(233, 457)
        Me.Panel2.TabIndex = 1
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.Location = New System.Drawing.Point(0, 373)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(233, 35)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Cancel"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'for_peripherals
        '
        Me.for_peripherals.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.for_peripherals.Cursor = System.Windows.Forms.Cursors.Hand
        Me.for_peripherals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.for_peripherals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.for_peripherals.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.for_peripherals.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.for_peripherals.Location = New System.Drawing.Point(-9, 277)
        Me.for_peripherals.Name = "for_peripherals"
        Me.for_peripherals.Size = New System.Drawing.Size(245, 49)
        Me.for_peripherals.TabIndex = 8
        Me.for_peripherals.Text = "Peripherals"
        Me.for_peripherals.UseVisualStyleBackColor = False
        '
        'for_gpu
        '
        Me.for_gpu.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.for_gpu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.for_gpu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.for_gpu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.for_gpu.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.for_gpu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.for_gpu.Location = New System.Drawing.Point(6, 222)
        Me.for_gpu.Name = "for_gpu"
        Me.for_gpu.Size = New System.Drawing.Size(230, 49)
        Me.for_gpu.TabIndex = 7
        Me.for_gpu.Text = "GPU(Graphics Card)"
        Me.for_gpu.UseVisualStyleBackColor = False
        '
        'for_ram
        '
        Me.for_ram.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.for_ram.Cursor = System.Windows.Forms.Cursors.Hand
        Me.for_ram.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.for_ram.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.for_ram.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.for_ram.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.for_ram.Location = New System.Drawing.Point(-9, 167)
        Me.for_ram.Name = "for_ram"
        Me.for_ram.Size = New System.Drawing.Size(245, 49)
        Me.for_ram.TabIndex = 6
        Me.for_ram.Text = "RAM"
        Me.for_ram.UseVisualStyleBackColor = False
        '
        'for_motherboard
        '
        Me.for_motherboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.for_motherboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.for_motherboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.for_motherboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.for_motherboard.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.for_motherboard.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.for_motherboard.Location = New System.Drawing.Point(3, 112)
        Me.for_motherboard.Name = "for_motherboard"
        Me.for_motherboard.Size = New System.Drawing.Size(233, 49)
        Me.for_motherboard.TabIndex = 5
        Me.for_motherboard.Text = "Motherboard"
        Me.for_motherboard.UseVisualStyleBackColor = False
        '
        'for_processor
        '
        Me.for_processor.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.for_processor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.for_processor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.for_processor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.for_processor.Font = New System.Drawing.Font("Lucida Sans", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.for_processor.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.for_processor.Location = New System.Drawing.Point(3, 57)
        Me.for_processor.Name = "for_processor"
        Me.for_processor.Size = New System.Drawing.Size(233, 49)
        Me.for_processor.TabIndex = 4
        Me.for_processor.Text = "Processor"
        Me.for_processor.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(234, 99)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(519, 50)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List of Items"
        '
        'change_items
        '
        Me.change_items.AllowUserToAddRows = False
        Me.change_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.change_items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.processor, Me.qty, Me.price, Me.status})
        Me.change_items.Location = New System.Drawing.Point(234, 155)
        Me.change_items.Name = "change_items"
        Me.change_items.ReadOnly = True
        Me.change_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.change_items.Size = New System.Drawing.Size(519, 353)
        Me.change_items.TabIndex = 3
        '
        'processor
        '
        Me.processor.HeaderText = "Name"
        Me.processor.Name = "processor"
        Me.processor.ReadOnly = True
        Me.processor.Width = 180
        '
        'qty
        '
        Me.qty.HeaderText = "Quantity"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel4.Controls.Add(Me.p_status)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.p_update)
        Me.Panel4.Controls.Add(Me.p_delete)
        Me.Panel4.Controls.Add(Me.p_add)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.p_price)
        Me.Panel4.Controls.Add(Me.p_qty)
        Me.Panel4.Controls.Add(Me.p_name)
        Me.Panel4.Location = New System.Drawing.Point(759, 91)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(337, 465)
        Me.Panel4.TabIndex = 9
        '
        'p_status
        '
        Me.p_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.p_status.FormattingEnabled = True
        Me.p_status.Items.AddRange(New Object() {"On-Stock", "Out of Stock"})
        Me.p_status.Location = New System.Drawing.Point(44, 237)
        Me.p_status.Name = "p_status"
        Me.p_status.Size = New System.Drawing.Size(254, 21)
        Me.p_status.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(41, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Status"
        '
        'p_update
        '
        Me.p_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.p_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.p_update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.p_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p_update.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_update.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.p_update.Location = New System.Drawing.Point(44, 366)
        Me.p_update.Name = "p_update"
        Me.p_update.Size = New System.Drawing.Size(254, 37)
        Me.p_update.TabIndex = 17
        Me.p_update.Text = "Update Item"
        Me.p_update.UseVisualStyleBackColor = False
        '
        'p_delete
        '
        Me.p_delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.p_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.p_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.p_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p_delete.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_delete.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.p_delete.Location = New System.Drawing.Point(44, 323)
        Me.p_delete.Name = "p_delete"
        Me.p_delete.Size = New System.Drawing.Size(254, 37)
        Me.p_delete.TabIndex = 16
        Me.p_delete.Text = "Delete Item"
        Me.p_delete.UseVisualStyleBackColor = False
        '
        'p_add
        '
        Me.p_add.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.p_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.p_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.p_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.p_add.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_add.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.p_add.Location = New System.Drawing.Point(44, 280)
        Me.p_add.Name = "p_add"
        Me.p_add.Size = New System.Drawing.Size(254, 37)
        Me.p_add.TabIndex = 14
        Me.p_add.Text = "Add Item"
        Me.p_add.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(41, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(41, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(41, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Product Name"
        '
        'p_price
        '
        Me.p_price.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_price.Location = New System.Drawing.Point(44, 173)
        Me.p_price.Name = "p_price"
        Me.p_price.Size = New System.Drawing.Size(254, 24)
        Me.p_price.TabIndex = 2
        '
        'p_qty
        '
        Me.p_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_qty.Location = New System.Drawing.Point(44, 109)
        Me.p_qty.Name = "p_qty"
        Me.p_qty.Size = New System.Drawing.Size(254, 24)
        Me.p_qty.TabIndex = 1
        '
        'p_name
        '
        Me.p_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p_name.Location = New System.Drawing.Point(44, 46)
        Me.p_name.Name = "p_name"
        Me.p_name.Size = New System.Drawing.Size(254, 24)
        Me.p_name.TabIndex = 0
        '
        'current_selection
        '
        Me.current_selection.AutoSize = True
        Me.current_selection.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.current_selection.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.current_selection.Location = New System.Drawing.Point(60, 21)
        Me.current_selection.Name = "current_selection"
        Me.current_selection.Size = New System.Drawing.Size(100, 22)
        Me.current_selection.TabIndex = 1
        Me.current_selection.Text = "Processor"
        '
        'Crud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 511)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.change_items)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Crud"
        Me.Text = "Configure Items"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.change_items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents change_items As DataGridView
    Friend WithEvents for_processor As Button
    Friend WithEvents for_motherboard As Button
    Friend WithEvents for_ram As Button
    Friend WithEvents for_gpu As Button
    Friend WithEvents for_peripherals As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents p_name As TextBox
    Friend WithEvents p_price As TextBox
    Friend WithEvents p_qty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents p_add As Button
    Friend WithEvents p_delete As Button
    Friend WithEvents p_update As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents p_status As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents processor As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents current_selection As Label
End Class
