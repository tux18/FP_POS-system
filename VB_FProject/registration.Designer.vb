<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registration
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.c_address = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.male = New System.Windows.Forms.RadioButton()
        Me.female = New System.Windows.Forms.RadioButton()
        Me.birthdate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.contact_num = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-5, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(676, 74)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(17, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Registration Form"
        '
        'lname
        '
        Me.lname.Location = New System.Drawing.Point(257, 119)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(177, 20)
        Me.lname.TabIndex = 2
        '
        'c_address
        '
        Me.c_address.Location = New System.Drawing.Point(40, 226)
        Me.c_address.Name = "c_address"
        Me.c_address.Size = New System.Drawing.Size(394, 20)
        Me.c_address.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Firstname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(254, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Lastname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Complete Address"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.birthdate)
        Me.GroupBox1.Controls.Add(Me.female)
        Me.GroupBox1.Controls.Add(Me.male)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 252)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(394, 82)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'male
        '
        Me.male.AutoSize = True
        Me.male.Location = New System.Drawing.Point(34, 19)
        Me.male.Name = "male"
        Me.male.Size = New System.Drawing.Size(48, 17)
        Me.male.TabIndex = 0
        Me.male.TabStop = True
        Me.male.Text = "Male"
        Me.male.UseVisualStyleBackColor = True
        '
        'female
        '
        Me.female.AutoSize = True
        Me.female.Location = New System.Drawing.Point(34, 42)
        Me.female.Name = "female"
        Me.female.Size = New System.Drawing.Size(59, 17)
        Me.female.TabIndex = 1
        Me.female.TabStop = True
        Me.female.Text = "Female"
        Me.female.UseVisualStyleBackColor = True
        '
        'birthdate
        '
        Me.birthdate.Location = New System.Drawing.Point(155, 42)
        Me.birthdate.Name = "birthdate"
        Me.birthdate.Size = New System.Drawing.Size(200, 20)
        Me.birthdate.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Your Birthday"
        '
        'fname
        '
        Me.fname.Location = New System.Drawing.Point(40, 119)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(177, 20)
        Me.fname.TabIndex = 1
        '
        'contact_num
        '
        Me.contact_num.Location = New System.Drawing.Point(150, 171)
        Me.contact_num.Name = "contact_num"
        Me.contact_num.Size = New System.Drawing.Size(177, 20)
        Me.contact_num.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(147, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Contact Number"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(-5, 340)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(513, 113)
        Me.Panel2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(76, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(133, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(221, 47)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(133, 68)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(221, 28)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "CANCEL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 449)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.contact_num)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.c_address)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "registration"
        Me.Text = "Registration"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lname As TextBox
    Friend WithEvents c_address As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents female As RadioButton
    Friend WithEvents male As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents birthdate As DateTimePicker
    Friend WithEvents fname As TextBox
    Friend WithEvents contact_num As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
