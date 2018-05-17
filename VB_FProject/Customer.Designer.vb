<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Me.customer_list = New System.Windows.Forms.DataGridView()
        Me.cust_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.full_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.invisible_data = New System.Windows.Forms.Label()
        Me.clear = New System.Windows.Forms.Button()
        Me.add_cust = New System.Windows.Forms.Button()
        Me.update_cust = New System.Windows.Forms.Button()
        Me.delete_cust = New System.Windows.Forms.Button()
        Me.cancel_cust = New System.Windows.Forms.Button()
        Me.select_cust = New System.Windows.Forms.Button()
        Me.c_contact_number = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.c_gender = New System.Windows.Forms.ComboBox()
        Me.full_address = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fullname = New System.Windows.Forms.TextBox()
        Me.id_cust = New System.Windows.Forms.TextBox()
        CType(Me.customer_list, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'customer_list
        '
        Me.customer_list.AllowUserToAddRows = False
        Me.customer_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.customer_list.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cust_id, Me.full_name, Me.gender, Me.contact_num, Me.address})
        Me.customer_list.Location = New System.Drawing.Point(0, 55)
        Me.customer_list.Name = "customer_list"
        Me.customer_list.ReadOnly = True
        Me.customer_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.customer_list.Size = New System.Drawing.Size(635, 411)
        Me.customer_list.TabIndex = 0
        '
        'cust_id
        '
        Me.cust_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cust_id.HeaderText = "Customer ID"
        Me.cust_id.Name = "cust_id"
        Me.cust_id.ReadOnly = True
        '
        'full_name
        '
        Me.full_name.HeaderText = "Full Name"
        Me.full_name.Name = "full_name"
        Me.full_name.ReadOnly = True
        '
        'gender
        '
        Me.gender.HeaderText = "Gender"
        Me.gender.Name = "gender"
        Me.gender.ReadOnly = True
        '
        'contact_num
        '
        Me.contact_num.HeaderText = "Contact #"
        Me.contact_num.Name = "contact_num"
        Me.contact_num.ReadOnly = True
        '
        'address
        '
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.Width = 200
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(84, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-12, -7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1124, 100)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(46, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(417, 39)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Customer Information"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.customer_list)
        Me.Panel2.Location = New System.Drawing.Point(419, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(638, 481)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(3, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(635, 50)
        Me.Panel3.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(29, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer List"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel4.Controls.Add(Me.invisible_data)
        Me.Panel4.Controls.Add(Me.clear)
        Me.Panel4.Controls.Add(Me.add_cust)
        Me.Panel4.Controls.Add(Me.update_cust)
        Me.Panel4.Controls.Add(Me.delete_cust)
        Me.Panel4.Controls.Add(Me.cancel_cust)
        Me.Panel4.Controls.Add(Me.select_cust)
        Me.Panel4.Controls.Add(Me.c_contact_number)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.c_gender)
        Me.Panel4.Controls.Add(Me.full_address)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.fullname)
        Me.Panel4.Controls.Add(Me.id_cust)
        Me.Panel4.Location = New System.Drawing.Point(-9, 92)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(425, 510)
        Me.Panel4.TabIndex = 3
        '
        'invisible_data
        '
        Me.invisible_data.AutoSize = True
        Me.invisible_data.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.invisible_data.Location = New System.Drawing.Point(34, 21)
        Me.invisible_data.Name = "invisible_data"
        Me.invisible_data.Size = New System.Drawing.Size(39, 13)
        Me.invisible_data.TabIndex = 16
        Me.invisible_data.Text = "Label8"
        '
        'clear
        '
        Me.clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clear.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.clear.Location = New System.Drawing.Point(99, 247)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(236, 30)
        Me.clear.TabIndex = 15
        Me.clear.Text = "Clear"
        Me.clear.UseVisualStyleBackColor = False
        '
        'add_cust
        '
        Me.add_cust.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.add_cust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.add_cust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.add_cust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_cust.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_cust.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.add_cust.Location = New System.Drawing.Point(99, 357)
        Me.add_cust.Name = "add_cust"
        Me.add_cust.Size = New System.Drawing.Size(236, 49)
        Me.add_cust.TabIndex = 14
        Me.add_cust.Text = "Add Customer"
        Me.add_cust.UseVisualStyleBackColor = False
        '
        'update_cust
        '
        Me.update_cust.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.update_cust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.update_cust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.update_cust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.update_cust.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_cust.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.update_cust.Location = New System.Drawing.Point(34, 412)
        Me.update_cust.Name = "update_cust"
        Me.update_cust.Size = New System.Drawing.Size(176, 40)
        Me.update_cust.TabIndex = 13
        Me.update_cust.Text = "Update Customer"
        Me.update_cust.UseVisualStyleBackColor = False
        '
        'delete_cust
        '
        Me.delete_cust.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.delete_cust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.delete_cust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(43, Byte), Integer))
        Me.delete_cust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete_cust.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_cust.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.delete_cust.Location = New System.Drawing.Point(216, 412)
        Me.delete_cust.Name = "delete_cust"
        Me.delete_cust.Size = New System.Drawing.Size(176, 40)
        Me.delete_cust.TabIndex = 12
        Me.delete_cust.Text = "Delete Customer"
        Me.delete_cust.UseVisualStyleBackColor = False
        '
        'cancel_cust
        '
        Me.cancel_cust.BackColor = System.Drawing.Color.White
        Me.cancel_cust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancel_cust.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cancel_cust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel_cust.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_cust.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cancel_cust.Location = New System.Drawing.Point(99, 458)
        Me.cancel_cust.Name = "cancel_cust"
        Me.cancel_cust.Size = New System.Drawing.Size(236, 30)
        Me.cancel_cust.TabIndex = 11
        Me.cancel_cust.Text = "Cancel"
        Me.cancel_cust.UseVisualStyleBackColor = False
        '
        'select_cust
        '
        Me.select_cust.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.select_cust.Cursor = System.Windows.Forms.Cursors.Hand
        Me.select_cust.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.select_cust.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.select_cust.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.select_cust.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.select_cust.Location = New System.Drawing.Point(99, 297)
        Me.select_cust.Name = "select_cust"
        Me.select_cust.Size = New System.Drawing.Size(236, 54)
        Me.select_cust.TabIndex = 10
        Me.select_cust.Text = "Select Customer"
        Me.select_cust.UseVisualStyleBackColor = False
        '
        'c_contact_number
        '
        Me.c_contact_number.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_contact_number.Location = New System.Drawing.Point(37, 207)
        Me.c_contact_number.Name = "c_contact_number"
        Me.c_contact_number.Size = New System.Drawing.Size(173, 24)
        Me.c_contact_number.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(34, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 18)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Contact Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(213, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Gender"
        '
        'c_gender
        '
        Me.c_gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c_gender.FormattingEnabled = True
        Me.c_gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.c_gender.Location = New System.Drawing.Point(216, 205)
        Me.c_gender.Name = "c_gender"
        Me.c_gender.Size = New System.Drawing.Size(186, 26)
        Me.c_gender.TabIndex = 6
        '
        'full_address
        '
        Me.full_address.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.full_address.Location = New System.Drawing.Point(37, 137)
        Me.full_address.Name = "full_address"
        Me.full_address.Size = New System.Drawing.Size(365, 24)
        Me.full_address.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(34, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(213, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(34, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer ID"
        '
        'fullname
        '
        Me.fullname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fullname.Location = New System.Drawing.Point(216, 62)
        Me.fullname.Name = "fullname"
        Me.fullname.Size = New System.Drawing.Size(186, 24)
        Me.fullname.TabIndex = 1
        '
        'id_cust
        '
        Me.id_cust.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_cust.Location = New System.Drawing.Point(37, 62)
        Me.id_cust.Name = "id_cust"
        Me.id_cust.Size = New System.Drawing.Size(173, 24)
        Me.id_cust.TabIndex = 0
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 592)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Customer"
        Me.Text = "Customers"
        CType(Me.customer_list, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents customer_list As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents id_cust As TextBox
    Friend WithEvents fullname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents full_address As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents c_gender As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents c_contact_number As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents select_cust As Button
    Friend WithEvents cancel_cust As Button
    Friend WithEvents update_cust As Button
    Friend WithEvents delete_cust As Button
    Friend WithEvents add_cust As Button
    Friend WithEvents cust_id As DataGridViewTextBoxColumn
    Friend WithEvents full_name As DataGridViewTextBoxColumn
    Friend WithEvents gender As DataGridViewTextBoxColumn
    Friend WithEvents contact_num As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents clear As Button
    Friend WithEvents invisible_data As Label
End Class
