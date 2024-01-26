<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supplier))
        Me.update_supplier = New System.ComponentModel.BackgroundWorker()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.header3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtsupmobileno = New System.Windows.Forms.TextBox()
        Me.txtsupaddress = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.header2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.header1 = New System.Windows.Forms.Label()
        Me.register_supplier = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.edit_group_box = New System.Windows.Forms.GroupBox()
        Me.btnsupupdate = New System.Windows.Forms.Button()
        Me.btnsupsave = New System.Windows.Forms.Button()
        Me.btnsupdelete = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.cmbsupname = New System.Windows.Forms.ComboBox()
        Me.cmbsupcode = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsupemail = New System.Windows.Forms.TextBox()
        Me.txtsupfaxno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.edit_group_box.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(16, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'header3
        '
        Me.header3.AutoSize = True
        Me.header3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header3.ForeColor = System.Drawing.Color.Black
        Me.header3.Location = New System.Drawing.Point(98, 12)
        Me.header3.Name = "header3"
        Me.header3.Size = New System.Drawing.Size(294, 25)
        Me.header3.TabIndex = 6
        Me.header3.Text = "Add | Update New Supplier"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.header3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(994, 48)
        Me.Panel3.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(13, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Supplier Mobile No"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(48, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(114, 21)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Supplier Code"
        '
        'txtsupmobileno
        '
        Me.txtsupmobileno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupmobileno.Location = New System.Drawing.Point(178, 71)
        Me.txtsupmobileno.Name = "txtsupmobileno"
        Me.txtsupmobileno.Size = New System.Drawing.Size(262, 22)
        Me.txtsupmobileno.TabIndex = 5
        '
        'txtsupaddress
        '
        Me.txtsupaddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsupaddress.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtsupaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupaddress.Location = New System.Drawing.Point(3, 16)
        Me.txtsupaddress.Name = "txtsupaddress"
        Me.txtsupaddress.Size = New System.Drawing.Size(311, 53)
        Me.txtsupaddress.TabIndex = 9
        Me.txtsupaddress.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(461, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 21)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Supplier Address"
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
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtsupaddress)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Location = New System.Drawing.Point(629, 110)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(317, 72)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
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
        Me.Panel1.Size = New System.Drawing.Size(995, 69)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.header2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(657, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 44)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'header2
        '
        Me.header2.AutoSize = True
        Me.header2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header2.ForeColor = System.Drawing.Color.White
        Me.header2.Location = New System.Drawing.Point(198, 15)
        Me.header2.Name = "header2"
        Me.header2.Size = New System.Drawing.Size(108, 21)
        Me.header2.TabIndex = 6
        Me.header2.Text = "New Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(51, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Home / Suppliers /"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(16, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(62, 59)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(84, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(279, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Edit and Add Suppliers here"
        '
        'header1
        '
        Me.header1.AutoSize = True
        Me.header1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header1.ForeColor = System.Drawing.Color.White
        Me.header1.Location = New System.Drawing.Point(86, 9)
        Me.header1.Name = "header1"
        Me.header1.Size = New System.Drawing.Size(140, 26)
        Me.header1.TabIndex = 2
        Me.header1.Text = "New Supplier"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.edit_group_box)
        Me.GroupBox2.Controls.Add(Me.cmbsupname)
        Me.GroupBox2.Controls.Add(Me.cmbsupcode)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtsupemail)
        Me.GroupBox2.Controls.Add(Me.txtsupfaxno)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtsupmobileno)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(14, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(960, 296)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fill these Details"
        '
        'edit_group_box
        '
        Me.edit_group_box.Controls.Add(Me.btnsupupdate)
        Me.edit_group_box.Controls.Add(Me.btnsupsave)
        Me.edit_group_box.Controls.Add(Me.btnsupdelete)
        Me.edit_group_box.Controls.Add(Me.PictureBox3)
        Me.edit_group_box.Location = New System.Drawing.Point(17, 188)
        Me.edit_group_box.Name = "edit_group_box"
        Me.edit_group_box.Size = New System.Drawing.Size(929, 90)
        Me.edit_group_box.TabIndex = 30
        Me.edit_group_box.TabStop = False
        Me.edit_group_box.Text = "Save | Update | Delete"
        '
        'btnsupupdate
        '
        Me.btnsupupdate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnsupupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsupupdate.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnsupupdate.FlatAppearance.BorderSize = 0
        Me.btnsupupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnsupupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnsupupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsupupdate.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsupupdate.ForeColor = System.Drawing.Color.White
        Me.btnsupupdate.Location = New System.Drawing.Point(380, 35)
        Me.btnsupupdate.Name = "btnsupupdate"
        Me.btnsupupdate.Size = New System.Drawing.Size(188, 32)
        Me.btnsupupdate.TabIndex = 21
        Me.btnsupupdate.Text = "Update"
        Me.btnsupupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsupupdate.UseVisualStyleBackColor = False
        '
        'btnsupsave
        '
        Me.btnsupsave.BackColor = System.Drawing.Color.LimeGreen
        Me.btnsupsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsupsave.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnsupsave.FlatAppearance.BorderSize = 0
        Me.btnsupsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnsupsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnsupsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsupsave.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsupsave.ForeColor = System.Drawing.Color.White
        Me.btnsupsave.Location = New System.Drawing.Point(77, 35)
        Me.btnsupsave.Name = "btnsupsave"
        Me.btnsupsave.Size = New System.Drawing.Size(182, 32)
        Me.btnsupsave.TabIndex = 6
        Me.btnsupsave.Text = "Save"
        Me.btnsupsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsupsave.UseVisualStyleBackColor = False
        '
        'btnsupdelete
        '
        Me.btnsupdelete.BackColor = System.Drawing.Color.Red
        Me.btnsupdelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsupdelete.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnsupdelete.FlatAppearance.BorderSize = 0
        Me.btnsupdelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnsupdelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnsupdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsupdelete.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsupdelete.ForeColor = System.Drawing.Color.White
        Me.btnsupdelete.Location = New System.Drawing.Point(669, 35)
        Me.btnsupdelete.Name = "btnsupdelete"
        Me.btnsupdelete.Size = New System.Drawing.Size(182, 32)
        Me.btnsupdelete.TabIndex = 24
        Me.btnsupdelete.Text = "Delete"
        Me.btnsupdelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsupdelete.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.PictureBox3.Location = New System.Drawing.Point(102, 35)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'cmbsupname
        '
        Me.cmbsupname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsupname.FormattingEnabled = True
        Me.cmbsupname.Location = New System.Drawing.Point(629, 28)
        Me.cmbsupname.Name = "cmbsupname"
        Me.cmbsupname.Size = New System.Drawing.Size(314, 24)
        Me.cmbsupname.TabIndex = 29
        '
        'cmbsupcode
        '
        Me.cmbsupcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsupcode.FormattingEnabled = True
        Me.cmbsupcode.Location = New System.Drawing.Point(178, 26)
        Me.cmbsupcode.Name = "cmbsupcode"
        Me.cmbsupcode.Size = New System.Drawing.Size(262, 24)
        Me.cmbsupcode.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(48, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Supplier Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(461, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Supplier Fax No"
        '
        'txtsupemail
        '
        Me.txtsupemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupemail.Location = New System.Drawing.Point(178, 121)
        Me.txtsupemail.Name = "txtsupemail"
        Me.txtsupemail.Size = New System.Drawing.Size(262, 22)
        Me.txtsupemail.TabIndex = 5
        '
        'txtsupfaxno
        '
        Me.txtsupfaxno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsupfaxno.Location = New System.Drawing.Point(629, 68)
        Me.txtsupfaxno.Name = "txtsupfaxno"
        Me.txtsupfaxno.Size = New System.Drawing.Size(317, 22)
        Me.txtsupfaxno.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(469, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Supplier Name"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(0, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(994, 363)
        Me.Panel2.TabIndex = 4
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 435)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Supplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RNewsupplier"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.edit_group_box.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents update_supplier As System.ComponentModel.BackgroundWorker
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents header3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtsupmobileno As System.Windows.Forms.TextBox
    Friend WithEvents txtsupaddress As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents header2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents header1 As System.Windows.Forms.Label
    Friend WithEvents register_supplier As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtsupfaxno As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmbsupname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbsupcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtsupemail As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents edit_group_box As System.Windows.Forms.GroupBox
    Friend WithEvents btnsupupdate As System.Windows.Forms.Button
    Friend WithEvents btnsupsave As System.Windows.Forms.Button
    Friend WithEvents btnsupdelete As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
