<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Daily_Expenses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Daily_Expenses))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.header2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.header1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbcatecode = New System.Windows.Forms.ComboBox()
        Me.dtexpdate = New System.Windows.Forms.DateTimePicker()
        Me.txtexpamount = New System.Windows.Forms.TextBox()
        Me.txtexpdescription = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.edit_group_box = New System.Windows.Forms.GroupBox()
        Me.btnexpupdate = New System.Windows.Forms.Button()
        Me.btnexpsave = New System.Windows.Forms.Button()
        Me.btnexpdelete = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.header3 = New System.Windows.Forms.Label()
        Me.lblsales = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.edit_group_box.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.header1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(782, 69)
        Me.Panel1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.header2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(491, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 44)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'header2
        '
        Me.header2.AutoSize = True
        Me.header2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header2.ForeColor = System.Drawing.Color.White
        Me.header2.Location = New System.Drawing.Point(115, 15)
        Me.header2.Name = "header2"
        Me.header2.Size = New System.Drawing.Size(158, 21)
        Me.header2.TabIndex = 6
        Me.header2.Text = "New Daily Expenses"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(43, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Home  /  "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(11, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(66, 68)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(84, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Edit and Add Daily Expenses here"
        '
        'header1
        '
        Me.header1.AutoSize = True
        Me.header1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header1.ForeColor = System.Drawing.Color.White
        Me.header1.Location = New System.Drawing.Point(83, 9)
        Me.header1.Name = "header1"
        Me.header1.Size = New System.Drawing.Size(160, 26)
        Me.header1.TabIndex = 2
        Me.header1.Text = "Daily Expenses"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(0, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(779, 292)
        Me.Panel2.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbcatecode)
        Me.GroupBox2.Controls.Add(Me.dtexpdate)
        Me.GroupBox2.Controls.Add(Me.txtexpamount)
        Me.GroupBox2.Controls.Add(Me.txtexpdescription)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.edit_group_box)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(751, 228)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fill these Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(9, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 21)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Expences Code"
        '
        'cmbcatecode
        '
        Me.cmbcatecode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcatecode.FormattingEnabled = True
        Me.cmbcatecode.Location = New System.Drawing.Point(134, 16)
        Me.cmbcatecode.Name = "cmbcatecode"
        Me.cmbcatecode.Size = New System.Drawing.Size(166, 24)
        Me.cmbcatecode.TabIndex = 34
        '
        'dtexpdate
        '
        Me.dtexpdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtexpdate.Location = New System.Drawing.Point(134, 87)
        Me.dtexpdate.Name = "dtexpdate"
        Me.dtexpdate.Size = New System.Drawing.Size(200, 20)
        Me.dtexpdate.TabIndex = 33
        '
        'txtexpamount
        '
        Me.txtexpamount.Location = New System.Drawing.Point(466, 88)
        Me.txtexpamount.Name = "txtexpamount"
        Me.txtexpamount.Size = New System.Drawing.Size(256, 20)
        Me.txtexpamount.TabIndex = 32
        '
        'txtexpdescription
        '
        Me.txtexpdescription.Location = New System.Drawing.Point(134, 46)
        Me.txtexpdescription.Multiline = True
        Me.txtexpdescription.Name = "txtexpdescription"
        Me.txtexpdescription.Size = New System.Drawing.Size(588, 35)
        Me.txtexpdescription.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 21)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(381, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 21)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Amount"
        '
        'edit_group_box
        '
        Me.edit_group_box.Controls.Add(Me.btnexpupdate)
        Me.edit_group_box.Controls.Add(Me.btnexpsave)
        Me.edit_group_box.Controls.Add(Me.btnexpdelete)
        Me.edit_group_box.Location = New System.Drawing.Point(13, 130)
        Me.edit_group_box.Name = "edit_group_box"
        Me.edit_group_box.Size = New System.Drawing.Size(723, 83)
        Me.edit_group_box.TabIndex = 23
        Me.edit_group_box.TabStop = False
        Me.edit_group_box.Text = "Save | Update | Delete"
        '
        'btnexpupdate
        '
        Me.btnexpupdate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnexpupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexpupdate.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnexpupdate.FlatAppearance.BorderSize = 0
        Me.btnexpupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnexpupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnexpupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexpupdate.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexpupdate.ForeColor = System.Drawing.Color.White
        Me.btnexpupdate.Location = New System.Drawing.Point(262, 34)
        Me.btnexpupdate.Name = "btnexpupdate"
        Me.btnexpupdate.Size = New System.Drawing.Size(188, 32)
        Me.btnexpupdate.TabIndex = 21
        Me.btnexpupdate.Text = "Update"
        Me.btnexpupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnexpupdate.UseVisualStyleBackColor = False
        '
        'btnexpsave
        '
        Me.btnexpsave.BackColor = System.Drawing.Color.LimeGreen
        Me.btnexpsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexpsave.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnexpsave.FlatAppearance.BorderSize = 0
        Me.btnexpsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnexpsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnexpsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexpsave.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexpsave.ForeColor = System.Drawing.Color.White
        Me.btnexpsave.Location = New System.Drawing.Point(35, 34)
        Me.btnexpsave.Name = "btnexpsave"
        Me.btnexpsave.Size = New System.Drawing.Size(182, 32)
        Me.btnexpsave.TabIndex = 6
        Me.btnexpsave.Text = "Save"
        Me.btnexpsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnexpsave.UseVisualStyleBackColor = False
        '
        'btnexpdelete
        '
        Me.btnexpdelete.BackColor = System.Drawing.Color.Red
        Me.btnexpdelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexpdelete.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnexpdelete.FlatAppearance.BorderSize = 0
        Me.btnexpdelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnexpdelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnexpdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexpdelete.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexpdelete.ForeColor = System.Drawing.Color.White
        Me.btnexpdelete.Location = New System.Drawing.Point(496, 34)
        Me.btnexpdelete.Name = "btnexpdelete"
        Me.btnexpdelete.Size = New System.Drawing.Size(182, 32)
        Me.btnexpdelete.TabIndex = 24
        Me.btnexpdelete.Text = "Delete"
        Me.btnexpdelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnexpdelete.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(220, 379)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 32)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Delete"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LimeGreen
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(32, 379)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 32)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Update and Save"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(19, 87)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 21)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Date"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblsales)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.header3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(779, 48)
        Me.Panel3.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(405, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(212, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total Daily Sales : "
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'header3
        '
        Me.header3.AutoSize = True
        Me.header3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header3.ForeColor = System.Drawing.Color.Black
        Me.header3.Location = New System.Drawing.Point(80, 11)
        Me.header3.Name = "header3"
        Me.header3.Size = New System.Drawing.Size(318, 25)
        Me.header3.TabIndex = 6
        Me.header3.Text = "Add | Update Daily Expenses"
        '
        'lblsales
        '
        Me.lblsales.AutoSize = True
        Me.lblsales.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsales.ForeColor = System.Drawing.Color.Black
        Me.lblsales.Location = New System.Drawing.Point(605, 11)
        Me.lblsales.Name = "lblsales"
        Me.lblsales.Size = New System.Drawing.Size(58, 25)
        Me.lblsales.TabIndex = 8
        Me.lblsales.Text = "0.00"
        '
        'Daily_Expenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 367)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Daily_Expenses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daily Expenses"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.edit_group_box.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents header2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents header1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents edit_group_box As System.Windows.Forms.GroupBox
    Friend WithEvents btnexpupdate As System.Windows.Forms.Button
    Friend WithEvents btnexpsave As System.Windows.Forms.Button
    Friend WithEvents btnexpdelete As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents header3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtexpdescription As System.Windows.Forms.TextBox
    Friend WithEvents txtexpamount As System.Windows.Forms.TextBox
    Friend WithEvents dtexpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbcatecode As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblsales As Label
End Class
