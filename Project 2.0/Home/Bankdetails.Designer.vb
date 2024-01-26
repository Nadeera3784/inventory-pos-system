<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bankdetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bankdetails))
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.banksdatagridview = New System.Windows.Forms.DataGridView()
        Me.cmbaccountno = New System.Windows.Forms.ComboBox()
        Me.cmbbranch = New System.Windows.Forms.ComboBox()
        Me.cmbbanks = New System.Windows.Forms.ComboBox()
        Me.cmbsuppname = New System.Windows.Forms.ComboBox()
        Me.cmbsuppcode = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.edit_group_box = New System.Windows.Forms.GroupBox()
        Me.btnbanksupdate = New System.Windows.Forms.Button()
        Me.btnbankssave = New System.Windows.Forms.Button()
        Me.btnbanksdelete = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.header3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.banksdatagridview, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(791, 69)
        Me.Panel1.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.header2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(517, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 44)
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
        Me.header2.Size = New System.Drawing.Size(140, 21)
        Me.header2.TabIndex = 6
        Me.header2.Text = "New Bank Details"
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
        Me.PictureBox1.Location = New System.Drawing.Point(4, 8)
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
        Me.Label1.Size = New System.Drawing.Size(237, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Edit and Add Bank Details here"
        '
        'header1
        '
        Me.header1.AutoSize = True
        Me.header1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header1.ForeColor = System.Drawing.Color.White
        Me.header1.Location = New System.Drawing.Point(83, 9)
        Me.header1.Name = "header1"
        Me.header1.Size = New System.Drawing.Size(183, 26)
        Me.header1.TabIndex = 2
        Me.header1.Text = "New Bank Details"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(0, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(790, 467)
        Me.Panel2.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.banksdatagridview)
        Me.GroupBox2.Controls.Add(Me.cmbaccountno)
        Me.GroupBox2.Controls.Add(Me.cmbbranch)
        Me.GroupBox2.Controls.Add(Me.cmbbanks)
        Me.GroupBox2.Controls.Add(Me.cmbsuppname)
        Me.GroupBox2.Controls.Add(Me.cmbsuppcode)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.edit_group_box)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(763, 402)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fill these Details"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(457, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 21)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Account No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(225, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 21)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Branch"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 21)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Bank"
        '
        'banksdatagridview
        '
        Me.banksdatagridview.AllowUserToAddRows = False
        Me.banksdatagridview.AllowUserToDeleteRows = False
        Me.banksdatagridview.AllowUserToResizeColumns = False
        Me.banksdatagridview.AllowUserToResizeRows = False
        Me.banksdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.banksdatagridview.Location = New System.Drawing.Point(13, 105)
        Me.banksdatagridview.Name = "banksdatagridview"
        Me.banksdatagridview.RowHeadersVisible = False
        Me.banksdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.banksdatagridview.Size = New System.Drawing.Size(735, 202)
        Me.banksdatagridview.TabIndex = 33
        '
        'cmbaccountno
        '
        Me.cmbaccountno.FormattingEnabled = True
        Me.cmbaccountno.Location = New System.Drawing.Point(560, 69)
        Me.cmbaccountno.Name = "cmbaccountno"
        Me.cmbaccountno.Size = New System.Drawing.Size(187, 21)
        Me.cmbaccountno.TabIndex = 32
        '
        'cmbbranch
        '
        Me.cmbbranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbranch.FormattingEnabled = True
        Me.cmbbranch.Items.AddRange(New Object() {"Akkaraipattu", "Ambalangoda", "Ampara", "Anuradhapura", "Avissawella", "Badulla" & Global.Microsoft.VisualBasic.ChrW(9) & "MC", "Balangoda", "Bandarawela", "Batticaloa", "Beruwala", "Boralesgamuwa", "Chavakachcheri", "Chilaw", "Colombo", "Dambulla", "Dehiwala-Mount Lavinia", "Embilipitiya", "Eravur", "Galle", "Gampaha", "Gampola", "Hambantota", "Haputale", "Hatton-Dickoya", "Hikkaduwa", "Horana", "Ja-Ela", "Jaffna", "Kadugannawa", "Kaduwela (Battaramulla)", "Kalmunai", "Kalutara", "Kandy", "Kattankudy", "Katunayake", "Kegalle", "Kesbewa", "Kilinochchi", "Kinniya", "Kolonnawa", "Kuliyapitiya", "Kurunegala", "Maharagama", "Mannar", "Matale", "Matara", "Minuwangoda", "Moneragala", "Moratuwa", "Mullaitivu", "Nawalapitiya", "Negombo", "Nuwara Eliya", "Panadura", "Peliyagoda", "Point Pedro", "Polonnaruwa", "Puttalam", "Ratnapura", "Sri Jayawardenepura", "Tangalle", "Thalawakele-Lindula", "Trincomalee", "Valvettithurai", "Vavuniya", "Wattala-Mabole", "Wattegama", "Weligama"})
        Me.cmbbranch.Location = New System.Drawing.Point(292, 67)
        Me.cmbbranch.Name = "cmbbranch"
        Me.cmbbranch.Size = New System.Drawing.Size(157, 24)
        Me.cmbbranch.Sorted = True
        Me.cmbbranch.TabIndex = 31
        '
        'cmbbanks
        '
        Me.cmbbanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbanks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbanks.FormattingEnabled = True
        Me.cmbbanks.Items.AddRange(New Object() {"Amana Bank", "Axis Bank Limited", "Bank of Ceylon", "Banking Corporation Ltd", "Cargills Bank Ltd", "Citibank N.A", "Commercial Bank of Ceylon PLC", "Corporation Bank of Sri Lanka", "Deutsche Bank AG", "DFCC Bank PLC", "Habib Bank Ltd", "Hatton National Bank PLC", "Housing Development Finance", "ICICI Bank Ltd", "Indian Bank", "Indian Overseas Bank", "Lankaputhra Development Bank Ltd", "MBSL Savings Bank Ltd", "MCB Bank Ltd", "National Development Bank PLC", "National Savings Bank", "Nations Trust Bank PLC", "Pan Asia Banking Corporation PLC", "People’s Bank", "Pradeshiya Sanwardhana Bank", "Public Bank Berhad", "Sampath Bank PLC", "Sanasa Development Bank Ltd", "Seylan Bank PLC", "Sri Lanka Savings Bank Ltd", "Standard Chartered Bank", "State Bank of India", "State Mortgage and Investment Bank", "The Hongkong & Shanghai", "Union Bank of Colombo PLC"})
        Me.cmbbanks.Location = New System.Drawing.Point(75, 66)
        Me.cmbbanks.Name = "cmbbanks"
        Me.cmbbanks.Size = New System.Drawing.Size(143, 24)
        Me.cmbbanks.Sorted = True
        Me.cmbbanks.TabIndex = 30
        '
        'cmbsuppname
        '
        Me.cmbsuppname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsuppname.FormattingEnabled = True
        Me.cmbsuppname.Location = New System.Drawing.Point(351, 27)
        Me.cmbsuppname.Name = "cmbsuppname"
        Me.cmbsuppname.Size = New System.Drawing.Size(397, 24)
        Me.cmbsuppname.TabIndex = 29
        '
        'cmbsuppcode
        '
        Me.cmbsuppcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbsuppcode.FormattingEnabled = True
        Me.cmbsuppcode.Location = New System.Drawing.Point(75, 27)
        Me.cmbsuppcode.Name = "cmbsuppcode"
        Me.cmbsuppcode.Size = New System.Drawing.Size(190, 24)
        Me.cmbsuppcode.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(279, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 21)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = " Name"
        '
        'edit_group_box
        '
        Me.edit_group_box.Controls.Add(Me.btnbanksupdate)
        Me.edit_group_box.Controls.Add(Me.btnbankssave)
        Me.edit_group_box.Controls.Add(Me.btnbanksdelete)
        Me.edit_group_box.Location = New System.Drawing.Point(13, 313)
        Me.edit_group_box.Name = "edit_group_box"
        Me.edit_group_box.Size = New System.Drawing.Size(735, 75)
        Me.edit_group_box.TabIndex = 23
        Me.edit_group_box.TabStop = False
        Me.edit_group_box.Text = "Save | Update | Delete"
        '
        'btnbanksupdate
        '
        Me.btnbanksupdate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnbanksupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbanksupdate.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnbanksupdate.FlatAppearance.BorderSize = 0
        Me.btnbanksupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnbanksupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnbanksupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbanksupdate.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbanksupdate.ForeColor = System.Drawing.Color.White
        Me.btnbanksupdate.Location = New System.Drawing.Point(272, 27)
        Me.btnbanksupdate.Name = "btnbanksupdate"
        Me.btnbanksupdate.Size = New System.Drawing.Size(188, 32)
        Me.btnbanksupdate.TabIndex = 21
        Me.btnbanksupdate.Text = "Update"
        Me.btnbanksupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnbanksupdate.UseVisualStyleBackColor = False
        '
        'btnbankssave
        '
        Me.btnbankssave.BackColor = System.Drawing.Color.LimeGreen
        Me.btnbankssave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbankssave.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnbankssave.FlatAppearance.BorderSize = 0
        Me.btnbankssave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnbankssave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnbankssave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbankssave.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbankssave.ForeColor = System.Drawing.Color.White
        Me.btnbankssave.Location = New System.Drawing.Point(34, 28)
        Me.btnbankssave.Name = "btnbankssave"
        Me.btnbankssave.Size = New System.Drawing.Size(182, 32)
        Me.btnbankssave.TabIndex = 6
        Me.btnbankssave.Text = "Save"
        Me.btnbankssave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnbankssave.UseVisualStyleBackColor = False
        '
        'btnbanksdelete
        '
        Me.btnbanksdelete.BackColor = System.Drawing.Color.Red
        Me.btnbanksdelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbanksdelete.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnbanksdelete.FlatAppearance.BorderSize = 0
        Me.btnbanksdelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnbanksdelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnbanksdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbanksdelete.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbanksdelete.ForeColor = System.Drawing.Color.White
        Me.btnbanksdelete.Location = New System.Drawing.Point(518, 26)
        Me.btnbanksdelete.Name = "btnbanksdelete"
        Me.btnbanksdelete.Size = New System.Drawing.Size(182, 32)
        Me.btnbanksdelete.TabIndex = 24
        Me.btnbanksdelete.Text = "Delete"
        Me.btnbanksdelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnbanksdelete.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(16, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 21)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Code"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.header3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(790, 48)
        Me.Panel3.TabIndex = 1
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
        Me.header3.Size = New System.Drawing.Size(347, 25)
        Me.header3.TabIndex = 6
        Me.header3.Text = "Add | Update New  Bank Details"
        '
        'Bankdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 545)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Bankdetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bank Details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.banksdatagridview, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmbsuppname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbsuppcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents edit_group_box As System.Windows.Forms.GroupBox
    Friend WithEvents btnbanksupdate As System.Windows.Forms.Button
    Friend WithEvents btnbankssave As System.Windows.Forms.Button
    Friend WithEvents btnbanksdelete As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents header3 As System.Windows.Forms.Label
    Friend WithEvents banksdatagridview As System.Windows.Forms.DataGridView
    Friend WithEvents cmbaccountno As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbranch As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbanks As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
