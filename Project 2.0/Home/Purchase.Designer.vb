<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Purchase))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.boxcontrol1 = New System.Windows.Forms.GroupBox()
        Me.purchaseitemsdatagridview = New System.Windows.Forms.DataGridView()
        Me.lblpurchaseitemsname = New System.Windows.Forms.Label()
        Me.txtpurchaseitemssearch = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtpurchaseitemsdiscount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtpurchaseitemsamount = New System.Windows.Forms.TextBox()
        Me.txtpurchaseitemsqty = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtpurchaseitemscostprice = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblpurchasedocno = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbpursupname = New System.Windows.Forms.ComboBox()
        Me.cmbpursupcode = New System.Windows.Forms.ComboBox()
        Me.boxcontrol2 = New System.Windows.Forms.GroupBox()
        Me.cmbpurchasedocno = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.purchaseaddcartdatagridview = New System.Windows.Forms.DataGridView()
        Me.btnpurgetorder = New System.Windows.Forms.Button()
        Me.btnpurselected = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnpurcancel = New System.Windows.Forms.Button()
        Me.btnpurcheckoutsupply = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpurgtotal = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dppurexpireddate = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dppurpurchasedate = New System.Windows.Forms.DateTimePicker()
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
        Me.Panel2.SuspendLayout()
        Me.boxcontrol1.SuspendLayout()
        CType(Me.purchaseitemsdatagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.boxcontrol2.SuspendLayout()
        CType(Me.purchaseaddcartdatagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.boxcontrol1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox8)
        Me.Panel2.Controls.Add(Me.boxcontrol2)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(2, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1090, 525)
        Me.Panel2.TabIndex = 4
        '
        'boxcontrol1
        '
        Me.boxcontrol1.Controls.Add(Me.purchaseitemsdatagridview)
        Me.boxcontrol1.Controls.Add(Me.lblpurchaseitemsname)
        Me.boxcontrol1.Controls.Add(Me.txtpurchaseitemssearch)
        Me.boxcontrol1.Controls.Add(Me.Label21)
        Me.boxcontrol1.Controls.Add(Me.GroupBox7)
        Me.boxcontrol1.Controls.Add(Me.Label8)
        Me.boxcontrol1.Location = New System.Drawing.Point(10, 117)
        Me.boxcontrol1.Name = "boxcontrol1"
        Me.boxcontrol1.Size = New System.Drawing.Size(335, 405)
        Me.boxcontrol1.TabIndex = 27
        Me.boxcontrol1.TabStop = False
        Me.boxcontrol1.Text = "Return Order"
        '
        'purchaseitemsdatagridview
        '
        Me.purchaseitemsdatagridview.AllowUserToAddRows = False
        Me.purchaseitemsdatagridview.AllowUserToDeleteRows = False
        Me.purchaseitemsdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.purchaseitemsdatagridview.Location = New System.Drawing.Point(6, 75)
        Me.purchaseitemsdatagridview.Name = "purchaseitemsdatagridview"
        Me.purchaseitemsdatagridview.RowHeadersVisible = False
        Me.purchaseitemsdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.purchaseitemsdatagridview.Size = New System.Drawing.Size(319, 161)
        Me.purchaseitemsdatagridview.TabIndex = 16
        '
        'lblpurchaseitemsname
        '
        Me.lblpurchaseitemsname.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpurchaseitemsname.ForeColor = System.Drawing.Color.Black
        Me.lblpurchaseitemsname.Location = New System.Drawing.Point(76, 243)
        Me.lblpurchaseitemsname.Name = "lblpurchaseitemsname"
        Me.lblpurchaseitemsname.Size = New System.Drawing.Size(243, 21)
        Me.lblpurchaseitemsname.TabIndex = 15
        Me.lblpurchaseitemsname.Text = "Name"
        '
        'txtpurchaseitemssearch
        '
        Me.txtpurchaseitemssearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpurchaseitemssearch.Location = New System.Drawing.Point(6, 42)
        Me.txtpurchaseitemssearch.Name = "txtpurchaseitemssearch"
        Me.txtpurchaseitemssearch.Size = New System.Drawing.Size(319, 26)
        Me.txtpurchaseitemssearch.TabIndex = 14
        Me.txtpurchaseitemssearch.Text = "Search Items Or Products"
        Me.txtpurchaseitemssearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.GroupBox7.Controls.Add(Me.txtpurchaseitemsdiscount)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.txtpurchaseitemsamount)
        Me.GroupBox7.Controls.Add(Me.txtpurchaseitemsqty)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.txtpurchaseitemscostprice)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Location = New System.Drawing.Point(10, 268)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(319, 131)
        Me.GroupBox7.TabIndex = 8
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Add Item"
        '
        'txtpurchaseitemsdiscount
        '
        Me.txtpurchaseitemsdiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpurchaseitemsdiscount.Location = New System.Drawing.Point(9, 72)
        Me.txtpurchaseitemsdiscount.Name = "txtpurchaseitemsdiscount"
        Me.txtpurchaseitemsdiscount.Size = New System.Drawing.Size(118, 26)
        Me.txtpurchaseitemsdiscount.TabIndex = 13
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
        'txtpurchaseitemsamount
        '
        Me.txtpurchaseitemsamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpurchaseitemsamount.Location = New System.Drawing.Point(196, 75)
        Me.txtpurchaseitemsamount.Name = "txtpurchaseitemsamount"
        Me.txtpurchaseitemsamount.Size = New System.Drawing.Size(114, 26)
        Me.txtpurchaseitemsamount.TabIndex = 11
        '
        'txtpurchaseitemsqty
        '
        Me.txtpurchaseitemsqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpurchaseitemsqty.Location = New System.Drawing.Point(195, 18)
        Me.txtpurchaseitemsqty.Name = "txtpurchaseitemsqty"
        Me.txtpurchaseitemsqty.Size = New System.Drawing.Size(114, 26)
        Me.txtpurchaseitemsqty.TabIndex = 10
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
        'txtpurchaseitemscostprice
        '
        Me.txtpurchaseitemscostprice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpurchaseitemscostprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpurchaseitemscostprice.ForeColor = System.Drawing.Color.Red
        Me.txtpurchaseitemscostprice.Location = New System.Drawing.Point(8, 18)
        Me.txtpurchaseitemscostprice.Name = "txtpurchaseitemscostprice"
        Me.txtpurchaseitemscostprice.Size = New System.Drawing.Size(124, 24)
        Me.txtpurchaseitemscostprice.TabIndex = 9
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
        Me.Label8.Location = New System.Drawing.Point(115, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 21)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Items/Producs"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.lblpurchasedocno)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(866, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(212, 57)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Purchase Order No"
        '
        'lblpurchasedocno
        '
        Me.lblpurchasedocno.AutoSize = True
        Me.lblpurchasedocno.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpurchasedocno.ForeColor = System.Drawing.Color.Black
        Me.lblpurchasedocno.Location = New System.Drawing.Point(107, 23)
        Me.lblpurchasedocno.Name = "lblpurchasedocno"
        Me.lblpurchasedocno.Size = New System.Drawing.Size(39, 21)
        Me.lblpurchasedocno.TabIndex = 3
        Me.lblpurchasedocno.Text = "N/A"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(9, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 21)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Doc No :"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Controls.Add(Me.Label18)
        Me.GroupBox8.Controls.Add(Me.cmbpursupname)
        Me.GroupBox8.Controls.Add(Me.cmbpursupcode)
        Me.GroupBox8.Location = New System.Drawing.Point(4, 54)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(856, 57)
        Me.GroupBox8.TabIndex = 26
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Supplier Information"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(362, 23)
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
        'cmbpursupname
        '
        Me.cmbpursupname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbpursupname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbpursupname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbpursupname.FormattingEnabled = True
        Me.cmbpursupname.Location = New System.Drawing.Point(492, 20)
        Me.cmbpursupname.Name = "cmbpursupname"
        Me.cmbpursupname.Size = New System.Drawing.Size(348, 26)
        Me.cmbpursupname.TabIndex = 1
        '
        'cmbpursupcode
        '
        Me.cmbpursupcode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbpursupcode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbpursupcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbpursupcode.FormattingEnabled = True
        Me.cmbpursupcode.Location = New System.Drawing.Point(125, 20)
        Me.cmbpursupcode.Name = "cmbpursupcode"
        Me.cmbpursupcode.Size = New System.Drawing.Size(210, 26)
        Me.cmbpursupcode.TabIndex = 1
        '
        'boxcontrol2
        '
        Me.boxcontrol2.Controls.Add(Me.cmbpurchasedocno)
        Me.boxcontrol2.Controls.Add(Me.Label9)
        Me.boxcontrol2.Controls.Add(Me.purchaseaddcartdatagridview)
        Me.boxcontrol2.Controls.Add(Me.btnpurgetorder)
        Me.boxcontrol2.Controls.Add(Me.btnpurselected)
        Me.boxcontrol2.Controls.Add(Me.GroupBox4)
        Me.boxcontrol2.Location = New System.Drawing.Point(351, 117)
        Me.boxcontrol2.Name = "boxcontrol2"
        Me.boxcontrol2.Size = New System.Drawing.Size(728, 405)
        Me.boxcontrol2.TabIndex = 23
        Me.boxcontrol2.TabStop = False
        Me.boxcontrol2.Text = "Shop Cart"
        '
        'cmbpurchasedocno
        '
        Me.cmbpurchasedocno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpurchasedocno.FormattingEnabled = True
        Me.cmbpurchasedocno.Location = New System.Drawing.Point(361, 32)
        Me.cmbpurchasedocno.Name = "cmbpurchasedocno"
        Me.cmbpurchasedocno.Size = New System.Drawing.Size(121, 21)
        Me.cmbpurchasedocno.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(274, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 21)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Doc No :"
        '
        'purchaseaddcartdatagridview
        '
        Me.purchaseaddcartdatagridview.AllowUserToAddRows = False
        Me.purchaseaddcartdatagridview.AllowUserToDeleteRows = False
        Me.purchaseaddcartdatagridview.AllowUserToResizeColumns = False
        Me.purchaseaddcartdatagridview.AllowUserToResizeRows = False
        Me.purchaseaddcartdatagridview.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        Me.purchaseaddcartdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.purchaseaddcartdatagridview.Location = New System.Drawing.Point(13, 62)
        Me.purchaseaddcartdatagridview.Name = "purchaseaddcartdatagridview"
        Me.purchaseaddcartdatagridview.RowHeadersVisible = False
        Me.purchaseaddcartdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.purchaseaddcartdatagridview.Size = New System.Drawing.Size(699, 255)
        Me.purchaseaddcartdatagridview.TabIndex = 13
        '
        'btnpurgetorder
        '
        Me.btnpurgetorder.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnpurgetorder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpurgetorder.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnpurgetorder.FlatAppearance.BorderSize = 0
        Me.btnpurgetorder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnpurgetorder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnpurgetorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpurgetorder.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpurgetorder.ForeColor = System.Drawing.Color.White
        Me.btnpurgetorder.Location = New System.Drawing.Point(531, 27)
        Me.btnpurgetorder.Name = "btnpurgetorder"
        Me.btnpurgetorder.Size = New System.Drawing.Size(180, 29)
        Me.btnpurgetorder.TabIndex = 11
        Me.btnpurgetorder.Text = "Get Return Order"
        Me.btnpurgetorder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnpurgetorder.UseVisualStyleBackColor = False
        '
        'btnpurselected
        '
        Me.btnpurselected.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnpurselected.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpurselected.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnpurselected.FlatAppearance.BorderSize = 0
        Me.btnpurselected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnpurselected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnpurselected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpurselected.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpurselected.ForeColor = System.Drawing.Color.White
        Me.btnpurselected.Location = New System.Drawing.Point(12, 27)
        Me.btnpurselected.Name = "btnpurselected"
        Me.btnpurselected.Size = New System.Drawing.Size(230, 29)
        Me.btnpurselected.TabIndex = 12
        Me.btnpurselected.Text = "Selected Row Remove"
        Me.btnpurselected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnpurselected.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnpurcancel)
        Me.GroupBox4.Controls.Add(Me.btnpurcheckoutsupply)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtpurgtotal)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 323)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(699, 75)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        '
        'btnpurcancel
        '
        Me.btnpurcancel.BackColor = System.Drawing.Color.Red
        Me.btnpurcancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpurcancel.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnpurcancel.FlatAppearance.BorderSize = 0
        Me.btnpurcancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnpurcancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnpurcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpurcancel.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpurcancel.ForeColor = System.Drawing.Color.White
        Me.btnpurcancel.Location = New System.Drawing.Point(536, 20)
        Me.btnpurcancel.Name = "btnpurcancel"
        Me.btnpurcancel.Size = New System.Drawing.Size(146, 42)
        Me.btnpurcancel.TabIndex = 27
        Me.btnpurcancel.Text = "Cancel"
        Me.btnpurcancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnpurcancel.UseVisualStyleBackColor = False
        '
        'btnpurcheckoutsupply
        '
        Me.btnpurcheckoutsupply.BackColor = System.Drawing.Color.LimeGreen
        Me.btnpurcheckoutsupply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpurcheckoutsupply.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnpurcheckoutsupply.FlatAppearance.BorderSize = 0
        Me.btnpurcheckoutsupply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnpurcheckoutsupply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnpurcheckoutsupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpurcheckoutsupply.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpurcheckoutsupply.ForeColor = System.Drawing.Color.White
        Me.btnpurcheckoutsupply.Location = New System.Drawing.Point(370, 20)
        Me.btnpurcheckoutsupply.Name = "btnpurcheckoutsupply"
        Me.btnpurcheckoutsupply.Size = New System.Drawing.Size(146, 42)
        Me.btnpurcheckoutsupply.TabIndex = 26
        Me.btnpurcheckoutsupply.Text = "Purchase"
        Me.btnpurcheckoutsupply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnpurcheckoutsupply.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(32, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 21)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Grand Total"
        '
        'txtpurgtotal
        '
        Me.txtpurgtotal.Cursor = System.Windows.Forms.Cursors.No
        Me.txtpurgtotal.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpurgtotal.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.txtpurgtotal.Location = New System.Drawing.Point(157, 27)
        Me.txtpurgtotal.Multiline = True
        Me.txtpurgtotal.Name = "txtpurgtotal"
        Me.txtpurgtotal.ReadOnly = True
        Me.txtpurgtotal.Size = New System.Drawing.Size(154, 25)
        Me.txtpurgtotal.TabIndex = 11
        Me.txtpurgtotal.Text = "0.00"
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
        Me.Panel3.Controls.Add(Me.dppurexpireddate)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.dppurpurchasedate)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1090, 48)
        Me.Panel3.TabIndex = 1
        '
        'dppurexpireddate
        '
        Me.dppurexpireddate.CustomFormat = "yyyy-MMM-dd"
        Me.dppurexpireddate.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dppurexpireddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dppurexpireddate.Location = New System.Drawing.Point(630, 11)
        Me.dppurexpireddate.Name = "dppurexpireddate"
        Me.dppurexpireddate.Size = New System.Drawing.Size(148, 26)
        Me.dppurexpireddate.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(516, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 21)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Expired Date"
        '
        'dppurpurchasedate
        '
        Me.dppurpurchasedate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dppurpurchasedate.CustomFormat = "yyyy-MMM-dd"
        Me.dppurpurchasedate.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dppurpurchasedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dppurpurchasedate.Location = New System.Drawing.Point(927, 11)
        Me.dppurpurchasedate.Name = "dppurpurchasedate"
        Me.dppurpurchasedate.Size = New System.Drawing.Size(148, 26)
        Me.dppurpurchasedate.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(802, 14)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(117, 21)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Date Purchase"
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
        Me.Label4.Size = New System.Drawing.Size(255, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Add Your Purchase Order"
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
        Me.Panel1.Size = New System.Drawing.Size(1092, 69)
        Me.Panel1.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(800, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 44)
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
        Me.Label3.Size = New System.Drawing.Size(159, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "New Purchase Order"
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
        Me.Label1.Size = New System.Drawing.Size(191, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Add New Purchase Order"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(84, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 26)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Add Purchase"
        '
        'Purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 599)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Purchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RNewpurchase"
        Me.Panel2.ResumeLayout(False)
        Me.boxcontrol1.ResumeLayout(False)
        Me.boxcontrol1.PerformLayout()
        CType(Me.purchaseitemsdatagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.boxcontrol2.ResumeLayout(False)
        Me.boxcontrol2.PerformLayout()
        CType(Me.purchaseaddcartdatagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents dppurpurchasedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmbpursupcode As System.Windows.Forms.ComboBox
    Friend WithEvents boxcontrol2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnpurgetorder As System.Windows.Forms.Button
    Friend WithEvents btnpurselected As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnpurcheckoutsupply As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpurgtotal As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
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
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbpursupname As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnpurcancel As System.Windows.Forms.Button
    Friend WithEvents purchaseaddcartdatagridview As System.Windows.Forms.DataGridView
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dppurexpireddate As System.Windows.Forms.DateTimePicker
    Friend WithEvents boxcontrol1 As System.Windows.Forms.GroupBox
    Friend WithEvents purchaseitemsdatagridview As System.Windows.Forms.DataGridView
    Friend WithEvents lblpurchaseitemsname As System.Windows.Forms.Label
    Friend WithEvents txtpurchaseitemssearch As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpurchaseitemsdiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtpurchaseitemsamount As System.Windows.Forms.TextBox
    Friend WithEvents txtpurchaseitemsqty As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtpurchaseitemscostprice As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblpurchasedocno As System.Windows.Forms.Label
    Friend WithEvents cmbpurchasedocno As System.Windows.Forms.ComboBox
End Class
