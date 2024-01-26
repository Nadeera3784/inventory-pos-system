<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchasereturn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Purchasereturn))
        Me.returncartdatagridview = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbreturnsupname = New System.Windows.Forms.ComboBox()
        Me.btnreturnselected = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dpreturnpurchasedate = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnreturngetorder = New System.Windows.Forms.Button()
        Me.cmbreturnsupcode = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblreturndocno = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.boxcontrol1 = New System.Windows.Forms.GroupBox()
        Me.returnoitemsdatagridview = New System.Windows.Forms.DataGridView()
        Me.lblreturnitemsname = New System.Windows.Forms.Label()
        Me.txtreturnitemssearch = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtreturnitemsdiscount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtreturnitemsamount = New System.Windows.Forms.TextBox()
        Me.txtreturnitemsqty = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtreturnitemscostprice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.boxcontrol2 = New System.Windows.Forms.GroupBox()
        Me.cmbreturnprnno = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnreturncancel = New System.Windows.Forms.Button()
        Me.btnreturnckoutsupply = New System.Windows.Forms.Button()
        Me.Txtreturngrandtotal = New System.Windows.Forms.TextBox()
        Me.PrnTotallbl = New System.Windows.Forms.Label()
        CType(Me.returncartdatagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.boxcontrol1.SuspendLayout()
        CType(Me.returnoitemsdatagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.boxcontrol2.SuspendLayout()
        Me.SuspendLayout()
        '
        'returncartdatagridview
        '
        Me.returncartdatagridview.AllowUserToAddRows = False
        Me.returncartdatagridview.AllowUserToDeleteRows = False
        Me.returncartdatagridview.AllowUserToResizeColumns = False
        Me.returncartdatagridview.AllowUserToResizeRows = False
        Me.returncartdatagridview.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        Me.returncartdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.returncartdatagridview.Location = New System.Drawing.Point(13, 53)
        Me.returncartdatagridview.Name = "returncartdatagridview"
        Me.returncartdatagridview.RowHeadersVisible = False
        Me.returncartdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.returncartdatagridview.Size = New System.Drawing.Size(699, 292)
        Me.returncartdatagridview.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(270, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 21)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Supplier Name"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(6, 22)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 21)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Supplier Code"
        '
        'cmbreturnsupname
        '
        Me.cmbreturnsupname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbreturnsupname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbreturnsupname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbreturnsupname.FormattingEnabled = True
        Me.cmbreturnsupname.Location = New System.Drawing.Point(406, 18)
        Me.cmbreturnsupname.Name = "cmbreturnsupname"
        Me.cmbreturnsupname.Size = New System.Drawing.Size(419, 26)
        Me.cmbreturnsupname.TabIndex = 1
        '
        'btnreturnselected
        '
        Me.btnreturnselected.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnreturnselected.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreturnselected.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnreturnselected.FlatAppearance.BorderSize = 0
        Me.btnreturnselected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnreturnselected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnreturnselected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreturnselected.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturnselected.ForeColor = System.Drawing.Color.White
        Me.btnreturnselected.Location = New System.Drawing.Point(13, 19)
        Me.btnreturnselected.Name = "btnreturnselected"
        Me.btnreturnselected.Size = New System.Drawing.Size(237, 31)
        Me.btnreturnselected.TabIndex = 12
        Me.btnreturnselected.Text = "Selected Row Remove"
        Me.btnreturnselected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnreturnselected.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LimeGreen
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(630, 366)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(173, 32)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Update and Save"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dpreturnpurchasedate)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1090, 48)
        Me.Panel3.TabIndex = 1
        '
        'dpreturnpurchasedate
        '
        Me.dpreturnpurchasedate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpreturnpurchasedate.CustomFormat = "yyyy-MMM-dd"
        Me.dpreturnpurchasedate.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpreturnpurchasedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpreturnpurchasedate.Location = New System.Drawing.Point(927, 11)
        Me.dpreturnpurchasedate.Name = "dpreturnpurchasedate"
        Me.dpreturnpurchasedate.Size = New System.Drawing.Size(148, 26)
        Me.dpreturnpurchasedate.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(802, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(99, 21)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Date Return"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(14, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(82, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(326, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Add Your Purchase Return Order"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1094, 69)
        Me.Panel1.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(748, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 44)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(101, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "New Purchase Return Order"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(39, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Home / "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(16, 7)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(62, 53)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(86, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Add New Purchase Return Order"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(84, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 26)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Add Purchase Return"
        '
        'btnreturngetorder
        '
        Me.btnreturngetorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnreturngetorder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreturngetorder.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnreturngetorder.FlatAppearance.BorderSize = 0
        Me.btnreturngetorder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnreturngetorder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnreturngetorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreturngetorder.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturngetorder.ForeColor = System.Drawing.Color.White
        Me.btnreturngetorder.Location = New System.Drawing.Point(526, 15)
        Me.btnreturngetorder.Name = "btnreturngetorder"
        Me.btnreturngetorder.Size = New System.Drawing.Size(185, 33)
        Me.btnreturngetorder.TabIndex = 11
        Me.btnreturngetorder.Text = "Get Purchase Order"
        Me.btnreturngetorder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnreturngetorder.UseVisualStyleBackColor = False
        '
        'cmbreturnsupcode
        '
        Me.cmbreturnsupcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbreturnsupcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbreturnsupcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbreturnsupcode.FormattingEnabled = True
        Me.cmbreturnsupcode.Location = New System.Drawing.Point(125, 20)
        Me.cmbreturnsupcode.Name = "cmbreturnsupcode"
        Me.cmbreturnsupcode.Size = New System.Drawing.Size(129, 26)
        Me.cmbreturnsupcode.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.boxcontrol1)
        Me.Panel2.Controls.Add(Me.GroupBox8)
        Me.Panel2.Controls.Add(Me.boxcontrol2)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(2, 74)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1090, 531)
        Me.Panel2.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.lblreturndocno)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(861, 54)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(214, 57)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Purchase Return No"
        '
        'lblreturndocno
        '
        Me.lblreturndocno.AutoSize = True
        Me.lblreturndocno.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreturndocno.ForeColor = System.Drawing.Color.Black
        Me.lblreturndocno.Location = New System.Drawing.Point(99, 25)
        Me.lblreturndocno.Name = "lblreturndocno"
        Me.lblreturndocno.Size = New System.Drawing.Size(39, 21)
        Me.lblreturndocno.TabIndex = 3
        Me.lblreturndocno.Text = "N/A"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 21)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Prn No :"
        '
        'boxcontrol1
        '
        Me.boxcontrol1.Controls.Add(Me.returnoitemsdatagridview)
        Me.boxcontrol1.Controls.Add(Me.lblreturnitemsname)
        Me.boxcontrol1.Controls.Add(Me.txtreturnitemssearch)
        Me.boxcontrol1.Controls.Add(Me.Label21)
        Me.boxcontrol1.Controls.Add(Me.GroupBox7)
        Me.boxcontrol1.Controls.Add(Me.Label8)
        Me.boxcontrol1.Location = New System.Drawing.Point(4, 117)
        Me.boxcontrol1.Name = "boxcontrol1"
        Me.boxcontrol1.Size = New System.Drawing.Size(335, 405)
        Me.boxcontrol1.TabIndex = 24
        Me.boxcontrol1.TabStop = False
        Me.boxcontrol1.Text = "Return Order"
        '
        'returnoitemsdatagridview
        '
        Me.returnoitemsdatagridview.AllowUserToAddRows = False
        Me.returnoitemsdatagridview.AllowUserToDeleteRows = False
        Me.returnoitemsdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.returnoitemsdatagridview.Location = New System.Drawing.Point(6, 75)
        Me.returnoitemsdatagridview.Name = "returnoitemsdatagridview"
        Me.returnoitemsdatagridview.RowHeadersVisible = False
        Me.returnoitemsdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.returnoitemsdatagridview.Size = New System.Drawing.Size(319, 161)
        Me.returnoitemsdatagridview.TabIndex = 16
        '
        'lblreturnitemsname
        '
        Me.lblreturnitemsname.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreturnitemsname.ForeColor = System.Drawing.Color.Black
        Me.lblreturnitemsname.Location = New System.Drawing.Point(76, 243)
        Me.lblreturnitemsname.Name = "lblreturnitemsname"
        Me.lblreturnitemsname.Size = New System.Drawing.Size(243, 21)
        Me.lblreturnitemsname.TabIndex = 15
        Me.lblreturnitemsname.Text = "Name"
        '
        'txtreturnitemssearch
        '
        Me.txtreturnitemssearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreturnitemssearch.Location = New System.Drawing.Point(6, 42)
        Me.txtreturnitemssearch.Name = "txtreturnitemssearch"
        Me.txtreturnitemssearch.Size = New System.Drawing.Size(319, 26)
        Me.txtreturnitemssearch.TabIndex = 14
        Me.txtreturnitemssearch.Text = "Search Items Or Products"
        Me.txtreturnitemssearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(15, 242)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 21)
        Me.Label21.TabIndex = 13
        Me.Label21.Text = "Name"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtreturnitemsdiscount)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.txtreturnitemsamount)
        Me.GroupBox7.Controls.Add(Me.txtreturnitemsqty)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.txtreturnitemscostprice)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Location = New System.Drawing.Point(10, 268)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(319, 131)
        Me.GroupBox7.TabIndex = 8
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Add Item"
        '
        'txtreturnitemsdiscount
        '
        Me.txtreturnitemsdiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreturnitemsdiscount.Location = New System.Drawing.Point(9, 72)
        Me.txtreturnitemsdiscount.Name = "txtreturnitemsdiscount"
        Me.txtreturnitemsdiscount.Size = New System.Drawing.Size(118, 26)
        Me.txtreturnitemsdiscount.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(34, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Discount"
        '
        'txtreturnitemsamount
        '
        Me.txtreturnitemsamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreturnitemsamount.Location = New System.Drawing.Point(195, 75)
        Me.txtreturnitemsamount.Name = "txtreturnitemsamount"
        Me.txtreturnitemsamount.Size = New System.Drawing.Size(114, 26)
        Me.txtreturnitemsamount.TabIndex = 11
        '
        'txtreturnitemsqty
        '
        Me.txtreturnitemsqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreturnitemsqty.Location = New System.Drawing.Point(195, 18)
        Me.txtreturnitemsqty.Name = "txtreturnitemsqty"
        Me.txtreturnitemsqty.Size = New System.Drawing.Size(114, 26)
        Me.txtreturnitemsqty.TabIndex = 10
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(217, 104)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 21)
        Me.Label20.TabIndex = 9
        Me.Label20.Text = "Amount"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(215, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 21)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Quantity"
        '
        'txtreturnitemscostprice
        '
        Me.txtreturnitemscostprice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtreturnitemscostprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreturnitemscostprice.ForeColor = System.Drawing.Color.Red
        Me.txtreturnitemscostprice.Location = New System.Drawing.Point(8, 18)
        Me.txtreturnitemscostprice.Name = "txtreturnitemscostprice"
        Me.txtreturnitemscostprice.Size = New System.Drawing.Size(124, 24)
        Me.txtreturnitemscostprice.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(24, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 21)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Cost Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(85, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 21)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Items/Products"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.Label18)
        Me.GroupBox8.Controls.Add(Me.cmbreturnsupname)
        Me.GroupBox8.Controls.Add(Me.cmbreturnsupcode)
        Me.GroupBox8.Location = New System.Drawing.Point(4, 54)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(843, 57)
        Me.GroupBox8.TabIndex = 26
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Supplier Information"
        '
        'boxcontrol2
        '
        Me.boxcontrol2.Controls.Add(Me.cmbreturnprnno)
        Me.boxcontrol2.Controls.Add(Me.Label9)
        Me.boxcontrol2.Controls.Add(Me.btnreturncancel)
        Me.boxcontrol2.Controls.Add(Me.btnreturnckoutsupply)
        Me.boxcontrol2.Controls.Add(Me.Txtreturngrandtotal)
        Me.boxcontrol2.Controls.Add(Me.PrnTotallbl)
        Me.boxcontrol2.Controls.Add(Me.returncartdatagridview)
        Me.boxcontrol2.Controls.Add(Me.btnreturngetorder)
        Me.boxcontrol2.Controls.Add(Me.btnreturnselected)
        Me.boxcontrol2.Location = New System.Drawing.Point(351, 117)
        Me.boxcontrol2.Name = "boxcontrol2"
        Me.boxcontrol2.Size = New System.Drawing.Size(728, 405)
        Me.boxcontrol2.TabIndex = 23
        Me.boxcontrol2.TabStop = False
        Me.boxcontrol2.Text = "Shop Cart"
        '
        'cmbreturnprnno
        '
        Me.cmbreturnprnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbreturnprnno.FormattingEnabled = True
        Me.cmbreturnprnno.Location = New System.Drawing.Point(365, 23)
        Me.cmbreturnprnno.Name = "cmbreturnprnno"
        Me.cmbreturnprnno.Size = New System.Drawing.Size(121, 21)
        Me.cmbreturnprnno.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(283, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 21)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Prn No :"
        '
        'btnreturncancel
        '
        Me.btnreturncancel.BackColor = System.Drawing.Color.Red
        Me.btnreturncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreturncancel.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnreturncancel.FlatAppearance.BorderSize = 0
        Me.btnreturncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnreturncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnreturncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreturncancel.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturncancel.ForeColor = System.Drawing.Color.White
        Me.btnreturncancel.Location = New System.Drawing.Point(598, 353)
        Me.btnreturncancel.Name = "btnreturncancel"
        Me.btnreturncancel.Size = New System.Drawing.Size(114, 42)
        Me.btnreturncancel.TabIndex = 35
        Me.btnreturncancel.Text = "Cancel"
        Me.btnreturncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnreturncancel.UseVisualStyleBackColor = False
        '
        'btnreturnckoutsupply
        '
        Me.btnreturnckoutsupply.BackColor = System.Drawing.Color.LimeGreen
        Me.btnreturnckoutsupply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreturnckoutsupply.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnreturnckoutsupply.FlatAppearance.BorderSize = 0
        Me.btnreturnckoutsupply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnreturnckoutsupply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnreturnckoutsupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreturnckoutsupply.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreturnckoutsupply.ForeColor = System.Drawing.Color.White
        Me.btnreturnckoutsupply.Location = New System.Drawing.Point(468, 354)
        Me.btnreturnckoutsupply.Name = "btnreturnckoutsupply"
        Me.btnreturnckoutsupply.Size = New System.Drawing.Size(124, 42)
        Me.btnreturnckoutsupply.TabIndex = 34
        Me.btnreturnckoutsupply.Text = "Return"
        Me.btnreturnckoutsupply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnreturnckoutsupply.UseVisualStyleBackColor = False
        '
        'Txtreturngrandtotal
        '
        Me.Txtreturngrandtotal.BackColor = System.Drawing.SystemColors.Control
        Me.Txtreturngrandtotal.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtreturngrandtotal.Location = New System.Drawing.Point(219, 364)
        Me.Txtreturngrandtotal.Multiline = True
        Me.Txtreturngrandtotal.Name = "Txtreturngrandtotal"
        Me.Txtreturngrandtotal.Size = New System.Drawing.Size(144, 27)
        Me.Txtreturngrandtotal.TabIndex = 33
        Me.Txtreturngrandtotal.Text = "0.00"
        '
        'PrnTotallbl
        '
        Me.PrnTotallbl.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.PrnTotallbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PrnTotallbl.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrnTotallbl.ForeColor = System.Drawing.Color.White
        Me.PrnTotallbl.Location = New System.Drawing.Point(91, 364)
        Me.PrnTotallbl.Name = "PrnTotallbl"
        Me.PrnTotallbl.Size = New System.Drawing.Size(113, 27)
        Me.PrnTotallbl.TabIndex = 32
        Me.PrnTotallbl.Text = "Grand Total"
        Me.PrnTotallbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Purchasereturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1094, 605)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Purchasereturn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Return"
        CType(Me.returncartdatagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.boxcontrol1.ResumeLayout(False)
        Me.boxcontrol1.PerformLayout()
        CType(Me.returnoitemsdatagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.boxcontrol2.ResumeLayout(False)
        Me.boxcontrol2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents returncartdatagridview As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmbreturnsupname As System.Windows.Forms.ComboBox
    Friend WithEvents btnreturnselected As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dpreturnpurchasedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnreturngetorder As System.Windows.Forms.Button
    Friend WithEvents cmbreturnsupcode As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents boxcontrol1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtreturnitemssearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtreturnitemsdiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtreturnitemsamount As System.Windows.Forms.TextBox
    Friend WithEvents txtreturnitemsqty As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents boxcontrol2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtreturnitemscostprice As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblreturnitemsname As System.Windows.Forms.Label
    Friend WithEvents returnoitemsdatagridview As System.Windows.Forms.DataGridView
    Friend WithEvents Txtreturngrandtotal As System.Windows.Forms.TextBox
    Friend WithEvents PrnTotallbl As System.Windows.Forms.Label
    Friend WithEvents btnreturncancel As System.Windows.Forms.Button
    Friend WithEvents btnreturnckoutsupply As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbreturnprnno As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblreturndocno As System.Windows.Forms.Label
End Class
