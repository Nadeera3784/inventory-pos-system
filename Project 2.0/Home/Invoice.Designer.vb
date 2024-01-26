<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoice
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invoice))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.search_results = New System.Windows.Forms.GroupBox()
        Me.lblinvitemsname = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.invsearchitemsdatagridview = New System.Windows.Forms.DataGridView()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtinvitemsamount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtinvitemsqty = New System.Windows.Forms.TextBox()
        Me.txtinvitemsdiscount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblinvtotalqty = New System.Windows.Forms.TextBox()
        Me.lblinvtotaldiscount = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.invoice_type_nav = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblinvtotalamount = New System.Windows.Forms.TextBox()
        Me.cart_api = New System.Windows.Forms.GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblrecallcustname = New System.Windows.Forms.Label()
        Me.cmbrecallinvnoload = New System.Windows.Forms.ComboBox()
        Me.btnrecallbill = New System.Windows.Forms.Button()
        Me.btnstatement = New System.Windows.Forms.Button()
        Me.btnunhold = New System.Windows.Forms.Button()
        Me.btnhold = New System.Windows.Forms.Button()
        Me.btnremovelast = New System.Windows.Forms.Button()
        Me.invaddcartdatagridview = New System.Windows.Forms.DataGridView()
        Me.btnemptycart = New System.Windows.Forms.Button()
        Me.btndeleteselected = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtinvalldiscounts = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.btninvcancel = New System.Windows.Forms.Button()
        Me.btnpay = New System.Windows.Forms.Button()
        Me.checkinvprintreceipt = New System.Windows.Forms.CheckBox()
        Me.lblnettotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Statementpanel = New System.Windows.Forms.Panel()
        Me.lblstheadertitle = New System.Windows.Forms.Label()
        Me.Settlementpanel = New System.Windows.Forms.Panel()
        Me.Settlementchequepanel = New System.Windows.Forms.Panel()
        Me.cmbstbranch = New System.Windows.Forms.ComboBox()
        Me.cmbstbank = New System.Windows.Forms.ComboBox()
        Me.dpstchequedate = New System.Windows.Forms.DateTimePicker()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnschequesave = New System.Windows.Forms.Button()
        Me.btnchequecancel = New System.Windows.Forms.Button()
        Me.lblstchequetotal = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtstchequeno = New System.Windows.Forms.TextBox()
        Me.Stchquedatagridview = New System.Windows.Forms.DataGridView()
        Me.btnstsettlementcancel = New System.Windows.Forms.Button()
        Me.btnstsettlementsave = New System.Windows.Forms.Button()
        Me.cmbstdocno = New System.Windows.Forms.ComboBox()
        Me.txtstamount = New System.Windows.Forms.TextBox()
        Me.CmbstType = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Mainstatementpanel = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnministatemnetprint = New System.Windows.Forms.Button()
        Me.btnstatementprint = New System.Windows.Forms.Button()
        Me.Mainstatementdatagridview = New System.Windows.Forms.DataGridView()
        Me.welcomepanel = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblloadprintname = New System.Windows.Forms.Label()
        Me.cmbinvloadprint = New System.Windows.Forms.ComboBox()
        Me.btnprintlastbill = New System.Windows.Forms.Button()
        Me.Chequepanel = New System.Windows.Forms.Panel()
        Me.cmbpaymentchequebranch = New System.Windows.Forms.ComboBox()
        Me.cmbpaymentchequebank = New System.Windows.Forms.ComboBox()
        Me.dppaymentchequedate = New System.Windows.Forms.DateTimePicker()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.btnpaychequesave = New System.Windows.Forms.Button()
        Me.btnpaychequecancel = New System.Windows.Forms.Button()
        Me.lbltotalcheque = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.l = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtpaymentchequeamount = New System.Windows.Forms.TextBox()
        Me.txtpaymentchequeno = New System.Windows.Forms.TextBox()
        Me.Paymentdatagridviewcheque2 = New System.Windows.Forms.DataGridView()
        Me.btninvcheckout = New System.Windows.Forms.Button()
        Me.lblpaymentbalancedue = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblinvno = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblinvunit = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PayementsPanel = New System.Windows.Forms.Panel()
        Me.lblpaidpayment = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtpaymentamount = New System.Windows.Forms.TextBox()
        Me.Cmbayementtype = New System.Windows.Forms.ComboBox()
        Me.txtpaymentcardno = New System.Windows.Forms.TextBox()
        Me.Paymentdatagridview1 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Subtotallbl = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.P7 = New System.Windows.Forms.PictureBox()
        Me.Customerspanel = New System.Windows.Forms.Panel()
        Me.lblcustomername = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.customersdatagridview = New System.Windows.Forms.DataGridView()
        Me.ItemsPanel = New System.Windows.Forms.Panel()
        Me.cart_api2 = New System.Windows.Forms.GroupBox()
        Me.txtinvitemssearch = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.lblinvcashier = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbloutstanding = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbinvcustname = New System.Windows.Forms.ComboBox()
        Me.invoice_due_date = New System.Windows.Forms.DateTimePicker()
        Me.customer_label_tag = New System.Windows.Forms.Label()
        Me.invoice_due_label = New System.Windows.Forms.Label()
        Me.cmbinvcustno = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.invoice_type_header = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.invoice_type_dsc = New System.Windows.Forms.Label()
        Me.invoice_type_header2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblmode = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.btnitems = New System.Windows.Forms.Button()
        Me.btncustomers = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.search_results.SuspendLayout()
        CType(Me.invsearchitemsdatagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cart_api.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.invaddcartdatagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Statementpanel.SuspendLayout()
        Me.Settlementpanel.SuspendLayout()
        Me.Settlementchequepanel.SuspendLayout()
        CType(Me.Stchquedatagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Mainstatementpanel.SuspendLayout()
        CType(Me.Mainstatementdatagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Chequepanel.SuspendLayout()
        CType(Me.Paymentdatagridviewcheque2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PayementsPanel.SuspendLayout()
        CType(Me.Paymentdatagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.P7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Customerspanel.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.customersdatagridview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ItemsPanel.SuspendLayout()
        Me.cart_api2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'search_results
        '
        Me.search_results.Controls.Add(Me.lblinvitemsname)
        Me.search_results.Controls.Add(Me.Label10)
        Me.search_results.Controls.Add(Me.invsearchitemsdatagridview)
        Me.search_results.Controls.Add(Me.GroupBox7)
        Me.search_results.Location = New System.Drawing.Point(2, 11)
        Me.search_results.Name = "search_results"
        Me.search_results.Size = New System.Drawing.Size(515, 466)
        Me.search_results.TabIndex = 4
        Me.search_results.TabStop = False
        Me.search_results.Text = "Found / Selected Items/Products"
        '
        'lblinvitemsname
        '
        Me.lblinvitemsname.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblinvitemsname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvitemsname.ForeColor = System.Drawing.Color.Black
        Me.lblinvitemsname.Location = New System.Drawing.Point(81, 354)
        Me.lblinvitemsname.Name = "lblinvitemsname"
        Me.lblinvitemsname.Size = New System.Drawing.Size(423, 21)
        Me.lblinvitemsname.TabIndex = 11
        Me.lblinvitemsname.Text = "N/A"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(9, 353)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 20)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Name :"
        '
        'invsearchitemsdatagridview
        '
        Me.invsearchitemsdatagridview.AllowUserToAddRows = False
        Me.invsearchitemsdatagridview.AllowUserToDeleteRows = False
        Me.invsearchitemsdatagridview.AllowUserToResizeColumns = False
        Me.invsearchitemsdatagridview.AllowUserToResizeRows = False
        Me.invsearchitemsdatagridview.BackgroundColor = System.Drawing.Color.Green
        Me.invsearchitemsdatagridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.invsearchitemsdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.invsearchitemsdatagridview.GridColor = System.Drawing.Color.White
        Me.invsearchitemsdatagridview.Location = New System.Drawing.Point(6, 18)
        Me.invsearchitemsdatagridview.Name = "invsearchitemsdatagridview"
        Me.invsearchitemsdatagridview.RowHeadersVisible = False
        Me.invsearchitemsdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.invsearchitemsdatagridview.Size = New System.Drawing.Size(505, 329)
        Me.invsearchitemsdatagridview.TabIndex = 9
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtinvitemsamount)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.txtinvitemsqty)
        Me.GroupBox7.Controls.Add(Me.txtinvitemsdiscount)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Location = New System.Drawing.Point(7, 382)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(497, 77)
        Me.GroupBox7.TabIndex = 8
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Add Item"
        '
        'txtinvitemsamount
        '
        Me.txtinvitemsamount.Location = New System.Drawing.Point(345, 21)
        Me.txtinvitemsamount.Multiline = True
        Me.txtinvitemsamount.Name = "txtinvitemsamount"
        Me.txtinvitemsamount.Size = New System.Drawing.Size(106, 22)
        Me.txtinvitemsamount.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(362, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Amount"
        '
        'txtinvitemsqty
        '
        Me.txtinvitemsqty.Location = New System.Drawing.Point(57, 20)
        Me.txtinvitemsqty.Multiline = True
        Me.txtinvitemsqty.Name = "txtinvitemsqty"
        Me.txtinvitemsqty.Size = New System.Drawing.Size(106, 22)
        Me.txtinvitemsqty.TabIndex = 10
        '
        'txtinvitemsdiscount
        '
        Me.txtinvitemsdiscount.Location = New System.Drawing.Point(199, 20)
        Me.txtinvitemsdiscount.Multiline = True
        Me.txtinvitemsdiscount.Name = "txtinvitemsdiscount"
        Me.txtinvitemsdiscount.Size = New System.Drawing.Size(106, 22)
        Me.txtinvitemsdiscount.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(209, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Discount"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(66, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 20)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Quantity"
        '
        'lblinvtotalqty
        '
        Me.lblinvtotalqty.BackColor = System.Drawing.Color.White
        Me.lblinvtotalqty.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblinvtotalqty.Cursor = System.Windows.Forms.Cursors.No
        Me.lblinvtotalqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvtotalqty.ForeColor = System.Drawing.Color.Red
        Me.lblinvtotalqty.Location = New System.Drawing.Point(3, 167)
        Me.lblinvtotalqty.Multiline = True
        Me.lblinvtotalqty.Name = "lblinvtotalqty"
        Me.lblinvtotalqty.ReadOnly = True
        Me.lblinvtotalqty.Size = New System.Drawing.Size(146, 26)
        Me.lblinvtotalqty.TabIndex = 100
        Me.lblinvtotalqty.TabStop = False
        Me.lblinvtotalqty.Text = "00"
        Me.lblinvtotalqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblinvtotaldiscount
        '
        Me.lblinvtotaldiscount.BackColor = System.Drawing.Color.White
        Me.lblinvtotaldiscount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblinvtotaldiscount.Cursor = System.Windows.Forms.Cursors.No
        Me.lblinvtotaldiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvtotaldiscount.ForeColor = System.Drawing.Color.Red
        Me.lblinvtotaldiscount.Location = New System.Drawing.Point(6, 40)
        Me.lblinvtotaldiscount.Multiline = True
        Me.lblinvtotaldiscount.Name = "lblinvtotaldiscount"
        Me.lblinvtotaldiscount.ReadOnly = True
        Me.lblinvtotaldiscount.Size = New System.Drawing.Size(142, 26)
        Me.lblinvtotaldiscount.TabIndex = 101
        Me.lblinvtotaldiscount.TabStop = False
        Me.lblinvtotaldiscount.Text = "00"
        Me.lblinvtotaldiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(6, 137)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(124, 24)
        Me.Label15.TabIndex = 99
        Me.Label15.Text = "Total Quantity"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.invoice_type_nav)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(1012, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 51)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'invoice_type_nav
        '
        Me.invoice_type_nav.AutoSize = True
        Me.invoice_type_nav.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoice_type_nav.ForeColor = System.Drawing.Color.White
        Me.invoice_type_nav.Location = New System.Drawing.Point(109, 17)
        Me.invoice_type_nav.Name = "invoice_type_nav"
        Me.invoice_type_nav.Size = New System.Drawing.Size(113, 20)
        Me.invoice_type_nav.TabIndex = 6
        Me.invoice_type_nav.Text = "New POS Sale"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(45, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Home /"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(10, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 24)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Total Amount"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(2, 11)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(134, 24)
        Me.Label16.TabIndex = 98
        Me.Label16.Text = "Total Discount "
        '
        'lblinvtotalamount
        '
        Me.lblinvtotalamount.BackColor = System.Drawing.Color.White
        Me.lblinvtotalamount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblinvtotalamount.Cursor = System.Windows.Forms.Cursors.No
        Me.lblinvtotalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvtotalamount.ForeColor = System.Drawing.Color.Red
        Me.lblinvtotalamount.Location = New System.Drawing.Point(6, 230)
        Me.lblinvtotalamount.Multiline = True
        Me.lblinvtotalamount.Name = "lblinvtotalamount"
        Me.lblinvtotalamount.ReadOnly = True
        Me.lblinvtotalamount.Size = New System.Drawing.Size(144, 26)
        Me.lblinvtotalamount.TabIndex = 67
        Me.lblinvtotalamount.TabStop = False
        Me.lblinvtotalamount.Text = "0.00"
        Me.lblinvtotalamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cart_api
        '
        Me.cart_api.Controls.Add(Me.Panel5)
        Me.cart_api.Controls.Add(Me.btnstatement)
        Me.cart_api.Controls.Add(Me.btnunhold)
        Me.cart_api.Controls.Add(Me.btnhold)
        Me.cart_api.Controls.Add(Me.btnremovelast)
        Me.cart_api.Controls.Add(Me.invaddcartdatagridview)
        Me.cart_api.Controls.Add(Me.btnemptycart)
        Me.cart_api.Controls.Add(Me.btndeleteselected)
        Me.cart_api.Controls.Add(Me.GroupBox4)
        Me.cart_api.Location = New System.Drawing.Point(-4, 111)
        Me.cart_api.Name = "cart_api"
        Me.cart_api.Size = New System.Drawing.Size(1340, 552)
        Me.cart_api.TabIndex = 2
        Me.cart_api.TabStop = False
        Me.cart_api.Text = "Shop Cart"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lblrecallcustname)
        Me.Panel5.Controls.Add(Me.cmbrecallinvnoload)
        Me.Panel5.Controls.Add(Me.btnrecallbill)
        Me.Panel5.Location = New System.Drawing.Point(6, 496)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(454, 56)
        Me.Panel5.TabIndex = 67
        '
        'lblrecallcustname
        '
        Me.lblrecallcustname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrecallcustname.ForeColor = System.Drawing.Color.Black
        Me.lblrecallcustname.Location = New System.Drawing.Point(119, 14)
        Me.lblrecallcustname.Name = "lblrecallcustname"
        Me.lblrecallcustname.Size = New System.Drawing.Size(175, 22)
        Me.lblrecallcustname.TabIndex = 68
        Me.lblrecallcustname.Text = "N/A"
        '
        'cmbrecallinvnoload
        '
        Me.cmbrecallinvnoload.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbrecallinvnoload.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbrecallinvnoload.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbrecallinvnoload.FormattingEnabled = True
        Me.cmbrecallinvnoload.Location = New System.Drawing.Point(6, 13)
        Me.cmbrecallinvnoload.Name = "cmbrecallinvnoload"
        Me.cmbrecallinvnoload.Size = New System.Drawing.Size(103, 26)
        Me.cmbrecallinvnoload.TabIndex = 67
        Me.cmbrecallinvnoload.TabStop = False
        '
        'btnrecallbill
        '
        Me.btnrecallbill.BackColor = System.Drawing.Color.ForestGreen
        Me.btnrecallbill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrecallbill.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnrecallbill.FlatAppearance.BorderSize = 0
        Me.btnrecallbill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnrecallbill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnrecallbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrecallbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrecallbill.ForeColor = System.Drawing.Color.White
        Me.btnrecallbill.Location = New System.Drawing.Point(304, 8)
        Me.btnrecallbill.Name = "btnrecallbill"
        Me.btnrecallbill.Size = New System.Drawing.Size(134, 38)
        Me.btnrecallbill.TabIndex = 62
        Me.btnrecallbill.Text = "Recall Bill"
        Me.btnrecallbill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnrecallbill.UseVisualStyleBackColor = False
        '
        'btnstatement
        '
        Me.btnstatement.BackColor = System.Drawing.Color.Blue
        Me.btnstatement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstatement.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnstatement.FlatAppearance.BorderSize = 0
        Me.btnstatement.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnstatement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnstatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstatement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstatement.ForeColor = System.Drawing.Color.White
        Me.btnstatement.Location = New System.Drawing.Point(748, 503)
        Me.btnstatement.Name = "btnstatement"
        Me.btnstatement.Size = New System.Drawing.Size(132, 39)
        Me.btnstatement.TabIndex = 65
        Me.btnstatement.Text = "&Statement - F2"
        Me.btnstatement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnstatement.UseVisualStyleBackColor = False
        '
        'btnunhold
        '
        Me.btnunhold.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnunhold.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnunhold.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnunhold.FlatAppearance.BorderSize = 0
        Me.btnunhold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnunhold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnunhold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnunhold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnunhold.ForeColor = System.Drawing.Color.White
        Me.btnunhold.Location = New System.Drawing.Point(609, 503)
        Me.btnunhold.Name = "btnunhold"
        Me.btnunhold.Size = New System.Drawing.Size(129, 38)
        Me.btnunhold.TabIndex = 64
        Me.btnunhold.Text = "Hold Off - F7"
        Me.btnunhold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnunhold.UseVisualStyleBackColor = False
        '
        'btnhold
        '
        Me.btnhold.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnhold.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhold.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnhold.FlatAppearance.BorderSize = 0
        Me.btnhold.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnhold.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnhold.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhold.ForeColor = System.Drawing.Color.White
        Me.btnhold.Location = New System.Drawing.Point(468, 503)
        Me.btnhold.Name = "btnhold"
        Me.btnhold.Size = New System.Drawing.Size(127, 38)
        Me.btnhold.TabIndex = 63
        Me.btnhold.Text = "Hold On - F6"
        Me.btnhold.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnhold.UseVisualStyleBackColor = False
        '
        'btnremovelast
        '
        Me.btnremovelast.BackColor = System.Drawing.Color.DarkBlue
        Me.btnremovelast.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnremovelast.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnremovelast.FlatAppearance.BorderSize = 0
        Me.btnremovelast.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnremovelast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnremovelast.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnremovelast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnremovelast.ForeColor = System.Drawing.Color.White
        Me.btnremovelast.Location = New System.Drawing.Point(224, 20)
        Me.btnremovelast.Name = "btnremovelast"
        Me.btnremovelast.Size = New System.Drawing.Size(179, 33)
        Me.btnremovelast.TabIndex = 14
        Me.btnremovelast.Text = "&Remove Last - F4"
        Me.btnremovelast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnremovelast.UseVisualStyleBackColor = False
        '
        'invaddcartdatagridview
        '
        Me.invaddcartdatagridview.AllowUserToAddRows = False
        Me.invaddcartdatagridview.AllowUserToDeleteRows = False
        Me.invaddcartdatagridview.AllowUserToResizeColumns = False
        Me.invaddcartdatagridview.AllowUserToResizeRows = False
        Me.invaddcartdatagridview.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        Me.invaddcartdatagridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.invaddcartdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.invaddcartdatagridview.GridColor = System.Drawing.Color.White
        Me.invaddcartdatagridview.Location = New System.Drawing.Point(7, 56)
        Me.invaddcartdatagridview.Name = "invaddcartdatagridview"
        Me.invaddcartdatagridview.RowHeadersVisible = False
        Me.invaddcartdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.invaddcartdatagridview.Size = New System.Drawing.Size(599, 435)
        Me.invaddcartdatagridview.TabIndex = 13
        '
        'btnemptycart
        '
        Me.btnemptycart.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnemptycart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnemptycart.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnemptycart.FlatAppearance.BorderSize = 0
        Me.btnemptycart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnemptycart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnemptycart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnemptycart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnemptycart.ForeColor = System.Drawing.Color.White
        Me.btnemptycart.Location = New System.Drawing.Point(415, 18)
        Me.btnemptycart.Name = "btnemptycart"
        Me.btnemptycart.Size = New System.Drawing.Size(183, 33)
        Me.btnemptycart.TabIndex = 12
        Me.btnemptycart.Text = "&Empty Items - F10"
        Me.btnemptycart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnemptycart.UseVisualStyleBackColor = False
        '
        'btndeleteselected
        '
        Me.btndeleteselected.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndeleteselected.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndeleteselected.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btndeleteselected.FlatAppearance.BorderSize = 0
        Me.btndeleteselected.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndeleteselected.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btndeleteselected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeleteselected.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeleteselected.ForeColor = System.Drawing.Color.White
        Me.btndeleteselected.Location = New System.Drawing.Point(6, 20)
        Me.btndeleteselected.Name = "btndeleteselected"
        Me.btndeleteselected.Size = New System.Drawing.Size(211, 33)
        Me.btndeleteselected.TabIndex = 10
        Me.btndeleteselected.Text = "&Delete selected - Delete"
        Me.btndeleteselected.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btndeleteselected.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtinvalldiscounts)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.btninvcancel)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.btnpay)
        Me.GroupBox4.Controls.Add(Me.lblinvtotaldiscount)
        Me.GroupBox4.Controls.Add(Me.checkinvprintreceipt)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.lblnettotal)
        Me.GroupBox4.Controls.Add(Me.lblinvtotalqty)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.lblinvtotalamount)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox4.Location = New System.Drawing.Point(615, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(154, 486)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        '
        'txtinvalldiscounts
        '
        Me.txtinvalldiscounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinvalldiscounts.ForeColor = System.Drawing.Color.Red
        Me.txtinvalldiscounts.Location = New System.Drawing.Point(6, 101)
        Me.txtinvalldiscounts.Multiline = True
        Me.txtinvalldiscounts.Name = "txtinvalldiscounts"
        Me.txtinvalldiscounts.Size = New System.Drawing.Size(139, 34)
        Me.txtinvalldiscounts.TabIndex = 105
        Me.txtinvalldiscounts.Text = "00"
        Me.txtinvalldiscounts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(-1, 73)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(151, 24)
        Me.Label25.TabIndex = 104
        Me.Label25.Text = "All Discount "
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btninvcancel
        '
        Me.btninvcancel.BackColor = System.Drawing.Color.Red
        Me.btninvcancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btninvcancel.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btninvcancel.FlatAppearance.BorderSize = 0
        Me.btninvcancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btninvcancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btninvcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninvcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninvcancel.ForeColor = System.Drawing.Color.White
        Me.btninvcancel.Location = New System.Drawing.Point(3, 430)
        Me.btninvcancel.Name = "btninvcancel"
        Me.btninvcancel.Size = New System.Drawing.Size(144, 40)
        Me.btninvcancel.TabIndex = 9
        Me.btninvcancel.Text = "&Cancel"
        Me.btninvcancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btninvcancel.UseVisualStyleBackColor = False
        '
        'btnpay
        '
        Me.btnpay.BackColor = System.Drawing.Color.LimeGreen
        Me.btnpay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpay.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnpay.FlatAppearance.BorderSize = 0
        Me.btnpay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnpay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnpay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpay.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpay.ForeColor = System.Drawing.Color.White
        Me.btnpay.Location = New System.Drawing.Point(3, 378)
        Me.btnpay.Name = "btnpay"
        Me.btnpay.Size = New System.Drawing.Size(144, 46)
        Me.btnpay.TabIndex = 61
        Me.btnpay.Text = "PAY - F5"
        Me.btnpay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnpay.UseVisualStyleBackColor = False
        '
        'checkinvprintreceipt
        '
        Me.checkinvprintreceipt.AutoSize = True
        Me.checkinvprintreceipt.Checked = True
        Me.checkinvprintreceipt.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkinvprintreceipt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.checkinvprintreceipt.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.checkinvprintreceipt.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime
        Me.checkinvprintreceipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkinvprintreceipt.Location = New System.Drawing.Point(10, 344)
        Me.checkinvprintreceipt.Name = "checkinvprintreceipt"
        Me.checkinvprintreceipt.Size = New System.Drawing.Size(119, 24)
        Me.checkinvprintreceipt.TabIndex = 57
        Me.checkinvprintreceipt.Text = "Print Receipt"
        Me.checkinvprintreceipt.UseVisualStyleBackColor = True
        '
        'lblnettotal
        '
        Me.lblnettotal.BackColor = System.Drawing.Color.White
        Me.lblnettotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblnettotal.Cursor = System.Windows.Forms.Cursors.No
        Me.lblnettotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnettotal.ForeColor = System.Drawing.Color.Green
        Me.lblnettotal.Location = New System.Drawing.Point(6, 304)
        Me.lblnettotal.Multiline = True
        Me.lblnettotal.Name = "lblnettotal"
        Me.lblnettotal.ReadOnly = True
        Me.lblnettotal.Size = New System.Drawing.Size(142, 26)
        Me.lblnettotal.TabIndex = 103
        Me.lblnettotal.TabStop = False
        Me.lblnettotal.Text = "0.00"
        Me.lblnettotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Green
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(7, 265)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 31)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Net Total"
        '
        'Statementpanel
        '
        Me.Statementpanel.BackColor = System.Drawing.Color.DarkCyan
        Me.Statementpanel.Controls.Add(Me.lblstheadertitle)
        Me.Statementpanel.Controls.Add(Me.Settlementpanel)
        Me.Statementpanel.Controls.Add(Me.Mainstatementpanel)
        Me.Statementpanel.Location = New System.Drawing.Point(783, 116)
        Me.Statementpanel.Name = "Statementpanel"
        Me.Statementpanel.Size = New System.Drawing.Size(531, 494)
        Me.Statementpanel.TabIndex = 6
        '
        'lblstheadertitle
        '
        Me.lblstheadertitle.BackColor = System.Drawing.Color.Green
        Me.lblstheadertitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstheadertitle.ForeColor = System.Drawing.Color.White
        Me.lblstheadertitle.Location = New System.Drawing.Point(4, 11)
        Me.lblstheadertitle.Name = "lblstheadertitle"
        Me.lblstheadertitle.Size = New System.Drawing.Size(518, 30)
        Me.lblstheadertitle.TabIndex = 83
        Me.lblstheadertitle.Text = "Statement"
        Me.lblstheadertitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Settlementpanel
        '
        Me.Settlementpanel.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Settlementpanel.Controls.Add(Me.Settlementchequepanel)
        Me.Settlementpanel.Controls.Add(Me.btnstsettlementcancel)
        Me.Settlementpanel.Controls.Add(Me.btnstsettlementsave)
        Me.Settlementpanel.Controls.Add(Me.cmbstdocno)
        Me.Settlementpanel.Controls.Add(Me.txtstamount)
        Me.Settlementpanel.Controls.Add(Me.CmbstType)
        Me.Settlementpanel.Controls.Add(Me.Label44)
        Me.Settlementpanel.Controls.Add(Me.Label40)
        Me.Settlementpanel.Controls.Add(Me.Label39)
        Me.Settlementpanel.Location = New System.Drawing.Point(1, 44)
        Me.Settlementpanel.Name = "Settlementpanel"
        Me.Settlementpanel.Size = New System.Drawing.Size(527, 445)
        Me.Settlementpanel.TabIndex = 71
        '
        'Settlementchequepanel
        '
        Me.Settlementchequepanel.BackColor = System.Drawing.Color.DarkGray
        Me.Settlementchequepanel.Controls.Add(Me.cmbstbranch)
        Me.Settlementchequepanel.Controls.Add(Me.cmbstbank)
        Me.Settlementchequepanel.Controls.Add(Me.dpstchequedate)
        Me.Settlementchequepanel.Controls.Add(Me.Label28)
        Me.Settlementchequepanel.Controls.Add(Me.btnschequesave)
        Me.Settlementchequepanel.Controls.Add(Me.btnchequecancel)
        Me.Settlementchequepanel.Controls.Add(Me.lblstchequetotal)
        Me.Settlementchequepanel.Controls.Add(Me.Label30)
        Me.Settlementchequepanel.Controls.Add(Me.Label31)
        Me.Settlementchequepanel.Controls.Add(Me.Label32)
        Me.Settlementchequepanel.Controls.Add(Me.Label33)
        Me.Settlementchequepanel.Controls.Add(Me.Label37)
        Me.Settlementchequepanel.Controls.Add(Me.TextBox2)
        Me.Settlementchequepanel.Controls.Add(Me.txtstchequeno)
        Me.Settlementchequepanel.Controls.Add(Me.Stchquedatagridview)
        Me.Settlementchequepanel.Location = New System.Drawing.Point(2, 0)
        Me.Settlementchequepanel.Name = "Settlementchequepanel"
        Me.Settlementchequepanel.Size = New System.Drawing.Size(529, 447)
        Me.Settlementchequepanel.TabIndex = 98
        '
        'cmbstbranch
        '
        Me.cmbstbranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstbranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbstbranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstbranch.FormattingEnabled = True
        Me.cmbstbranch.Items.AddRange(New Object() {"Akkaraipattu", "Ambalangoda", "Ampara", "Anuradhapura", "Badulla", "Balangoda", "Bandarawela", "Batticaloa", "Beruwala", "Boralesgamuwa", "Chavakachcheri", "Chilaw", "Colombo", "Dambulla", "Dehiwala-Mount Lavinia", "Embilipitiya", "Eravur", "Galle", "Gampaha", "Gampola", "Hambantota", "Haputale", "Hatton-Dickoya", "Hikkaduwa", "Horana", "Ja-Ela", "Jaffna", "Kadugannawa", "Kaduwela", "Kalmunai", "Kalutara", "Kattankudy", "Katunayake", "Kegalle", "Kesbewa", "Kilinochchi", "Kinniya", "Kolonnawa", "Kuliyapitiya", "Kurunegala", "Maharagama", "Mannar", "Matale", "Matara", "Minuwangoda", "Moneragala", "Moratuwa", "Mullaitivu", "Nawalapitiya", "Negombo", "Nuwara Eliya", "Panadura", "Peliyagoda", "Point Pedro", "Polonnaruwa", "Puttalam", "Ratnapura", "Avissawella", "Sri Jayawardenepura", "Tangalle", "Thalawakele", "Trincomalee", "Valvettithurai", "Vavuniya", "Wattala-Mabole", "Wattegama", "Weligama"})
        Me.cmbstbranch.Location = New System.Drawing.Point(143, 317)
        Me.cmbstbranch.Name = "cmbstbranch"
        Me.cmbstbranch.Size = New System.Drawing.Size(181, 28)
        Me.cmbstbranch.TabIndex = 93
        '
        'cmbstbank
        '
        Me.cmbstbank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstbank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbstbank.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstbank.FormattingEnabled = True
        Me.cmbstbank.Items.AddRange(New Object() {"Amana Bank", "Axis Bank Limited", "Bank of Ceylon", "Cargills Bank", "Citibank", "Commercial Bank", "Deutsche Bank", "DFCC Bank", "Habib Bank", "Hatton National Bank", "ICICI Bank", "Indian Bank", "Indian Overseas Bank", "MCB Bank Ltd", "National Development Bank", "Nations Trust Bank", "Pan Asia Bank", "People’s Bank", "Public Bank Berhad", "Sampath Bank", "Seylan Bank", "Standard Chartered Bank", "State Bank", "Union Bank"})
        Me.cmbstbank.Location = New System.Drawing.Point(143, 282)
        Me.cmbstbank.Name = "cmbstbank"
        Me.cmbstbank.Size = New System.Drawing.Size(181, 28)
        Me.cmbstbank.TabIndex = 92
        '
        'dpstchequedate
        '
        Me.dpstchequedate.CustomFormat = "dd/MMM/yyyy"
        Me.dpstchequedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpstchequedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpstchequedate.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dpstchequedate.Location = New System.Drawing.Point(143, 353)
        Me.dpstchequedate.Name = "dpstchequedate"
        Me.dpstchequedate.Size = New System.Drawing.Size(181, 26)
        Me.dpstchequedate.TabIndex = 91
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(29, 398)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(94, 26)
        Me.Label28.TabIndex = 90
        Me.Label28.Text = "Amount"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnschequesave
        '
        Me.btnschequesave.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnschequesave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnschequesave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnschequesave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnschequesave.Location = New System.Drawing.Point(355, 299)
        Me.btnschequesave.Name = "btnschequesave"
        Me.btnschequesave.Size = New System.Drawing.Size(135, 30)
        Me.btnschequesave.TabIndex = 89
        Me.btnschequesave.Text = "Save"
        Me.btnschequesave.UseVisualStyleBackColor = False
        '
        'btnchequecancel
        '
        Me.btnchequecancel.BackColor = System.Drawing.Color.Red
        Me.btnchequecancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnchequecancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchequecancel.ForeColor = System.Drawing.Color.White
        Me.btnchequecancel.Location = New System.Drawing.Point(356, 370)
        Me.btnchequecancel.Name = "btnchequecancel"
        Me.btnchequecancel.Size = New System.Drawing.Size(134, 30)
        Me.btnchequecancel.TabIndex = 88
        Me.btnchequecancel.Text = "Cancel"
        Me.btnchequecancel.UseVisualStyleBackColor = False
        '
        'lblstchequetotal
        '
        Me.lblstchequetotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblstchequetotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstchequetotal.ForeColor = System.Drawing.Color.White
        Me.lblstchequetotal.Location = New System.Drawing.Point(146, 210)
        Me.lblstchequetotal.Name = "lblstchequetotal"
        Me.lblstchequetotal.Size = New System.Drawing.Size(129, 30)
        Me.lblstchequetotal.TabIndex = 87
        Me.lblstchequetotal.Text = "N/A"
        Me.lblstchequetotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(44, 316)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(93, 30)
        Me.Label30.TabIndex = 86
        Me.Label30.Text = "Branch"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(58, 283)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(74, 24)
        Me.Label31.TabIndex = 85
        Me.Label31.Text = "Bank"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(9, 357)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(124, 22)
        Me.Label32.TabIndex = 84
        Me.Label32.Text = "Cheque Date"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(19, 246)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(111, 29)
        Me.Label33.TabIndex = 83
        Me.Label33.Text = "Cheque No"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(70, 216)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(48, 20)
        Me.Label37.TabIndex = 82
        Me.Label37.Text = "Total "
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(143, 393)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(181, 31)
        Me.TextBox2.TabIndex = 81
        '
        'txtstchequeno
        '
        Me.txtstchequeno.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstchequeno.Location = New System.Drawing.Point(143, 249)
        Me.txtstchequeno.Multiline = True
        Me.txtstchequeno.Name = "txtstchequeno"
        Me.txtstchequeno.Size = New System.Drawing.Size(181, 28)
        Me.txtstchequeno.TabIndex = 80
        '
        'Stchquedatagridview
        '
        Me.Stchquedatagridview.AllowUserToAddRows = False
        Me.Stchquedatagridview.AllowUserToDeleteRows = False
        Me.Stchquedatagridview.AllowUserToResizeColumns = False
        Me.Stchquedatagridview.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stchquedatagridview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Stchquedatagridview.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        Me.Stchquedatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Stchquedatagridview.CausesValidation = False
        Me.Stchquedatagridview.ColumnHeadersHeight = 22
        Me.Stchquedatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Stchquedatagridview.Location = New System.Drawing.Point(2, 8)
        Me.Stchquedatagridview.Name = "Stchquedatagridview"
        Me.Stchquedatagridview.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stchquedatagridview.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.Stchquedatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Stchquedatagridview.Size = New System.Drawing.Size(518, 180)
        Me.Stchquedatagridview.TabIndex = 79
        '
        'btnstsettlementcancel
        '
        Me.btnstsettlementcancel.BackColor = System.Drawing.Color.Red
        Me.btnstsettlementcancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstsettlementcancel.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnstsettlementcancel.FlatAppearance.BorderSize = 0
        Me.btnstsettlementcancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnstsettlementcancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnstsettlementcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstsettlementcancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstsettlementcancel.ForeColor = System.Drawing.Color.White
        Me.btnstsettlementcancel.Location = New System.Drawing.Point(294, 266)
        Me.btnstsettlementcancel.Name = "btnstsettlementcancel"
        Me.btnstsettlementcancel.Size = New System.Drawing.Size(116, 37)
        Me.btnstsettlementcancel.TabIndex = 97
        Me.btnstsettlementcancel.Text = "&Cancel"
        Me.btnstsettlementcancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnstsettlementcancel.UseVisualStyleBackColor = False
        '
        'btnstsettlementsave
        '
        Me.btnstsettlementsave.BackColor = System.Drawing.Color.Green
        Me.btnstsettlementsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstsettlementsave.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnstsettlementsave.FlatAppearance.BorderSize = 0
        Me.btnstsettlementsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnstsettlementsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnstsettlementsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstsettlementsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstsettlementsave.ForeColor = System.Drawing.Color.White
        Me.btnstsettlementsave.Location = New System.Drawing.Point(103, 266)
        Me.btnstsettlementsave.Name = "btnstsettlementsave"
        Me.btnstsettlementsave.Size = New System.Drawing.Size(124, 37)
        Me.btnstsettlementsave.TabIndex = 96
        Me.btnstsettlementsave.Text = "&Save"
        Me.btnstsettlementsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnstsettlementsave.UseVisualStyleBackColor = False
        '
        'cmbstdocno
        '
        Me.cmbstdocno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstdocno.FormattingEnabled = True
        Me.cmbstdocno.Location = New System.Drawing.Point(247, 72)
        Me.cmbstdocno.Name = "cmbstdocno"
        Me.cmbstdocno.Size = New System.Drawing.Size(162, 21)
        Me.cmbstdocno.TabIndex = 95
        '
        'txtstamount
        '
        Me.txtstamount.Location = New System.Drawing.Point(247, 178)
        Me.txtstamount.Multiline = True
        Me.txtstamount.Name = "txtstamount"
        Me.txtstamount.Size = New System.Drawing.Size(162, 28)
        Me.txtstamount.TabIndex = 94
        '
        'CmbstType
        '
        Me.CmbstType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbstType.FormattingEnabled = True
        Me.CmbstType.Items.AddRange(New Object() {"Cash", "Cheque", "Cradit Card"})
        Me.CmbstType.Location = New System.Drawing.Point(247, 125)
        Me.CmbstType.Name = "CmbstType"
        Me.CmbstType.Size = New System.Drawing.Size(162, 21)
        Me.CmbstType.TabIndex = 92
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.Transparent
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.White
        Me.Label44.Location = New System.Drawing.Point(60, 175)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(157, 30)
        Me.Label44.TabIndex = 91
        Me.Label44.Text = "Amount  :"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.Transparent
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.White
        Me.Label40.Location = New System.Drawing.Point(77, 118)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(138, 26)
        Me.Label40.TabIndex = 90
        Me.Label40.Text = "Type  :"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(83, 62)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(138, 34)
        Me.Label39.TabIndex = 89
        Me.Label39.Text = "DOC NO  :"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Mainstatementpanel
        '
        Me.Mainstatementpanel.BackColor = System.Drawing.Color.Olive
        Me.Mainstatementpanel.Controls.Add(Me.Button7)
        Me.Mainstatementpanel.Controls.Add(Me.Button6)
        Me.Mainstatementpanel.Controls.Add(Me.btnministatemnetprint)
        Me.Mainstatementpanel.Controls.Add(Me.btnstatementprint)
        Me.Mainstatementpanel.Controls.Add(Me.Mainstatementdatagridview)
        Me.Mainstatementpanel.Location = New System.Drawing.Point(4, 43)
        Me.Mainstatementpanel.Name = "Mainstatementpanel"
        Me.Mainstatementpanel.Size = New System.Drawing.Size(525, 448)
        Me.Mainstatementpanel.TabIndex = 0
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Red
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button7.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(399, 373)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(116, 37)
        Me.Button7.TabIndex = 70
        Me.Button7.Text = "Cancel"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(269, 373)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(124, 37)
        Me.Button6.TabIndex = 69
        Me.Button6.Text = "&Settlement"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btnministatemnetprint
        '
        Me.btnministatemnetprint.BackColor = System.Drawing.Color.DarkGreen
        Me.btnministatemnetprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnministatemnetprint.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnministatemnetprint.FlatAppearance.BorderSize = 0
        Me.btnministatemnetprint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnministatemnetprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnministatemnetprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnministatemnetprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnministatemnetprint.ForeColor = System.Drawing.Color.White
        Me.btnministatemnetprint.Location = New System.Drawing.Point(140, 373)
        Me.btnministatemnetprint.Name = "btnministatemnetprint"
        Me.btnministatemnetprint.Size = New System.Drawing.Size(125, 37)
        Me.btnministatemnetprint.TabIndex = 68
        Me.btnministatemnetprint.Text = "Mini Statement"
        Me.btnministatemnetprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnministatemnetprint.UseVisualStyleBackColor = False
        '
        'btnstatementprint
        '
        Me.btnstatementprint.BackColor = System.Drawing.Color.OrangeRed
        Me.btnstatementprint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnstatementprint.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnstatementprint.FlatAppearance.BorderSize = 0
        Me.btnstatementprint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnstatementprint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnstatementprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnstatementprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnstatementprint.ForeColor = System.Drawing.Color.White
        Me.btnstatementprint.Location = New System.Drawing.Point(6, 373)
        Me.btnstatementprint.Name = "btnstatementprint"
        Me.btnstatementprint.Size = New System.Drawing.Size(130, 37)
        Me.btnstatementprint.TabIndex = 67
        Me.btnstatementprint.Text = "Statement Print"
        Me.btnstatementprint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnstatementprint.UseVisualStyleBackColor = False
        '
        'Mainstatementdatagridview
        '
        Me.Mainstatementdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Mainstatementdatagridview.Location = New System.Drawing.Point(6, 12)
        Me.Mainstatementdatagridview.Name = "Mainstatementdatagridview"
        Me.Mainstatementdatagridview.Size = New System.Drawing.Size(511, 341)
        Me.Mainstatementdatagridview.TabIndex = 0
        '
        'welcomepanel
        '
        Me.welcomepanel.BackColor = System.Drawing.Color.White
        Me.welcomepanel.BackgroundImage = CType(resources.GetObject("welcomepanel.BackgroundImage"), System.Drawing.Image)
        Me.welcomepanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.welcomepanel.Location = New System.Drawing.Point(770, 116)
        Me.welcomepanel.Name = "welcomepanel"
        Me.welcomepanel.Size = New System.Drawing.Size(548, 494)
        Me.welcomepanel.TabIndex = 84
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblloadprintname)
        Me.Panel4.Controls.Add(Me.cmbinvloadprint)
        Me.Panel4.Controls.Add(Me.btnprintlastbill)
        Me.Panel4.Location = New System.Drawing.Point(880, 611)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(438, 49)
        Me.Panel4.TabIndex = 66
        '
        'lblloadprintname
        '
        Me.lblloadprintname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloadprintname.ForeColor = System.Drawing.Color.Black
        Me.lblloadprintname.Location = New System.Drawing.Point(131, 16)
        Me.lblloadprintname.Name = "lblloadprintname"
        Me.lblloadprintname.Size = New System.Drawing.Size(168, 22)
        Me.lblloadprintname.TabIndex = 68
        Me.lblloadprintname.Text = "N/A"
        '
        'cmbinvloadprint
        '
        Me.cmbinvloadprint.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbinvloadprint.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbinvloadprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbinvloadprint.FormattingEnabled = True
        Me.cmbinvloadprint.Location = New System.Drawing.Point(6, 14)
        Me.cmbinvloadprint.Name = "cmbinvloadprint"
        Me.cmbinvloadprint.Size = New System.Drawing.Size(116, 26)
        Me.cmbinvloadprint.TabIndex = 67
        Me.cmbinvloadprint.TabStop = False
        '
        'btnprintlastbill
        '
        Me.btnprintlastbill.BackColor = System.Drawing.Color.DeepPink
        Me.btnprintlastbill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprintlastbill.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnprintlastbill.FlatAppearance.BorderSize = 0
        Me.btnprintlastbill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnprintlastbill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnprintlastbill.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnprintlastbill.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprintlastbill.ForeColor = System.Drawing.Color.White
        Me.btnprintlastbill.Location = New System.Drawing.Point(319, 4)
        Me.btnprintlastbill.Name = "btnprintlastbill"
        Me.btnprintlastbill.Size = New System.Drawing.Size(114, 40)
        Me.btnprintlastbill.TabIndex = 66
        Me.btnprintlastbill.Text = "&Print Last Bill"
        Me.btnprintlastbill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnprintlastbill.UseVisualStyleBackColor = False
        '
        'Chequepanel
        '
        Me.Chequepanel.Controls.Add(Me.cmbpaymentchequebranch)
        Me.Chequepanel.Controls.Add(Me.cmbpaymentchequebank)
        Me.Chequepanel.Controls.Add(Me.dppaymentchequedate)
        Me.Chequepanel.Controls.Add(Me.Label38)
        Me.Chequepanel.Controls.Add(Me.btnpaychequesave)
        Me.Chequepanel.Controls.Add(Me.btnpaychequecancel)
        Me.Chequepanel.Controls.Add(Me.lbltotalcheque)
        Me.Chequepanel.Controls.Add(Me.Label36)
        Me.Chequepanel.Controls.Add(Me.Label35)
        Me.Chequepanel.Controls.Add(Me.Label34)
        Me.Chequepanel.Controls.Add(Me.l)
        Me.Chequepanel.Controls.Add(Me.Label26)
        Me.Chequepanel.Controls.Add(Me.txtpaymentchequeamount)
        Me.Chequepanel.Controls.Add(Me.txtpaymentchequeno)
        Me.Chequepanel.Controls.Add(Me.Paymentdatagridviewcheque2)
        Me.Chequepanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chequepanel.Location = New System.Drawing.Point(4, 38)
        Me.Chequepanel.Name = "Chequepanel"
        Me.Chequepanel.Size = New System.Drawing.Size(518, 444)
        Me.Chequepanel.TabIndex = 72
        Me.Chequepanel.Visible = False
        '
        'cmbpaymentchequebranch
        '
        Me.cmbpaymentchequebranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpaymentchequebranch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbpaymentchequebranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbpaymentchequebranch.FormattingEnabled = True
        Me.cmbpaymentchequebranch.Items.AddRange(New Object() {"Akkaraipattu", "Ambalangoda", "Ampara", "Anuradhapura", "Badulla", "Balangoda", "Bandarawela", "Batticaloa", "Beruwala", "Boralesgamuwa", "Chavakachcheri", "Chilaw", "Colombo", "Dambulla", "Dehiwala-Mount Lavinia", "Embilipitiya", "Eravur", "Galle", "Gampaha", "Gampola", "Hambantota", "Haputale", "Hatton-Dickoya", "Hikkaduwa", "Horana", "Ja-Ela", "Jaffna", "Kadugannawa", "Kaduwela", "Kalmunai", "Kalutara", "Kattankudy", "Katunayake", "Kegalle", "Kesbewa", "Kilinochchi", "Kinniya", "Kolonnawa", "Kuliyapitiya", "Kurunegala", "Maharagama", "Mannar", "Matale", "Matara", "Minuwangoda", "Moneragala", "Moratuwa", "Mullaitivu", "Nawalapitiya", "Negombo", "Nuwara Eliya", "Panadura", "Peliyagoda", "Point Pedro", "Polonnaruwa", "Puttalam", "Ratnapura", "Avissawella", "Sri Jayawardenepura", "Tangalle", "Thalawakele", "Trincomalee", "Valvettithurai", "Vavuniya", "Wattala-Mabole", "Wattegama", "Weligama"})
        Me.cmbpaymentchequebranch.Location = New System.Drawing.Point(140, 307)
        Me.cmbpaymentchequebranch.Name = "cmbpaymentchequebranch"
        Me.cmbpaymentchequebranch.Size = New System.Drawing.Size(181, 28)
        Me.cmbpaymentchequebranch.TabIndex = 78
        '
        'cmbpaymentchequebank
        '
        Me.cmbpaymentchequebank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbpaymentchequebank.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbpaymentchequebank.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbpaymentchequebank.FormattingEnabled = True
        Me.cmbpaymentchequebank.Items.AddRange(New Object() {"Amana Bank", "Axis Bank Limited", "Bank of Ceylon", "Cargills Bank", "Citibank", "Commercial Bank", "Deutsche Bank", "DFCC Bank", "Habib Bank", "Hatton National Bank", "ICICI Bank", "Indian Bank", "Indian Overseas Bank", "MCB Bank Ltd", "National Development Bank", "Nations Trust Bank", "Pan Asia Bank", "People’s Bank", "Public Bank Berhad", "Sampath Bank", "Seylan Bank", "Standard Chartered Bank", "State Bank", "Union Bank"})
        Me.cmbpaymentchequebank.Location = New System.Drawing.Point(140, 273)
        Me.cmbpaymentchequebank.Name = "cmbpaymentchequebank"
        Me.cmbpaymentchequebank.Size = New System.Drawing.Size(181, 28)
        Me.cmbpaymentchequebank.TabIndex = 77
        '
        'dppaymentchequedate
        '
        Me.dppaymentchequedate.CustomFormat = "dd/MMM/yyyy"
        Me.dppaymentchequedate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dppaymentchequedate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dppaymentchequedate.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dppaymentchequedate.Location = New System.Drawing.Point(140, 342)
        Me.dppaymentchequedate.Name = "dppaymentchequedate"
        Me.dppaymentchequedate.Size = New System.Drawing.Size(181, 26)
        Me.dppaymentchequedate.TabIndex = 76
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(26, 388)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(94, 26)
        Me.Label38.TabIndex = 75
        Me.Label38.Text = "Amount"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnpaychequesave
        '
        Me.btnpaychequesave.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnpaychequesave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpaychequesave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpaychequesave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnpaychequesave.Location = New System.Drawing.Point(352, 290)
        Me.btnpaychequesave.Name = "btnpaychequesave"
        Me.btnpaychequesave.Size = New System.Drawing.Size(135, 30)
        Me.btnpaychequesave.TabIndex = 74
        Me.btnpaychequesave.Text = "Save"
        Me.btnpaychequesave.UseVisualStyleBackColor = False
        '
        'btnpaychequecancel
        '
        Me.btnpaychequecancel.BackColor = System.Drawing.Color.Red
        Me.btnpaychequecancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpaychequecancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpaychequecancel.ForeColor = System.Drawing.Color.White
        Me.btnpaychequecancel.Location = New System.Drawing.Point(353, 359)
        Me.btnpaychequecancel.Name = "btnpaychequecancel"
        Me.btnpaychequecancel.Size = New System.Drawing.Size(134, 30)
        Me.btnpaychequecancel.TabIndex = 73
        Me.btnpaychequecancel.Text = "Cancel"
        Me.btnpaychequecancel.UseVisualStyleBackColor = False
        '
        'lbltotalcheque
        '
        Me.lbltotalcheque.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbltotalcheque.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotalcheque.ForeColor = System.Drawing.Color.White
        Me.lbltotalcheque.Location = New System.Drawing.Point(143, 200)
        Me.lbltotalcheque.Name = "lbltotalcheque"
        Me.lbltotalcheque.Size = New System.Drawing.Size(129, 30)
        Me.lbltotalcheque.TabIndex = 72
        Me.lbltotalcheque.Text = "N/A"
        Me.lbltotalcheque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(41, 306)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(93, 30)
        Me.Label36.TabIndex = 71
        Me.Label36.Text = "Branch"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(55, 274)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(74, 24)
        Me.Label35.TabIndex = 70
        Me.Label35.Text = "Bank"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(6, 346)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(124, 22)
        Me.Label34.TabIndex = 69
        Me.Label34.Text = "Cheque Date"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'l
        '
        Me.l.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l.ForeColor = System.Drawing.Color.White
        Me.l.Location = New System.Drawing.Point(16, 236)
        Me.l.Name = "l"
        Me.l.Size = New System.Drawing.Size(111, 29)
        Me.l.TabIndex = 68
        Me.l.Text = "Cheque No"
        Me.l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(67, 206)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(48, 20)
        Me.Label26.TabIndex = 66
        Me.Label26.Text = "Total "
        '
        'txtpaymentchequeamount
        '
        Me.txtpaymentchequeamount.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaymentchequeamount.Location = New System.Drawing.Point(140, 383)
        Me.txtpaymentchequeamount.Multiline = True
        Me.txtpaymentchequeamount.Name = "txtpaymentchequeamount"
        Me.txtpaymentchequeamount.Size = New System.Drawing.Size(181, 31)
        Me.txtpaymentchequeamount.TabIndex = 64
        '
        'txtpaymentchequeno
        '
        Me.txtpaymentchequeno.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaymentchequeno.Location = New System.Drawing.Point(140, 239)
        Me.txtpaymentchequeno.Multiline = True
        Me.txtpaymentchequeno.Name = "txtpaymentchequeno"
        Me.txtpaymentchequeno.Size = New System.Drawing.Size(181, 28)
        Me.txtpaymentchequeno.TabIndex = 62
        '
        'Paymentdatagridviewcheque2
        '
        Me.Paymentdatagridviewcheque2.AllowUserToAddRows = False
        Me.Paymentdatagridviewcheque2.AllowUserToDeleteRows = False
        Me.Paymentdatagridviewcheque2.AllowUserToResizeColumns = False
        Me.Paymentdatagridviewcheque2.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paymentdatagridviewcheque2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Paymentdatagridviewcheque2.BackgroundColor = System.Drawing.Color.DeepSkyBlue
        Me.Paymentdatagridviewcheque2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Paymentdatagridviewcheque2.CausesValidation = False
        Me.Paymentdatagridviewcheque2.ColumnHeadersHeight = 22
        Me.Paymentdatagridviewcheque2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Paymentdatagridviewcheque2.Location = New System.Drawing.Point(3, 6)
        Me.Paymentdatagridviewcheque2.Name = "Paymentdatagridviewcheque2"
        Me.Paymentdatagridviewcheque2.RowHeadersVisible = False
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Paymentdatagridviewcheque2.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Paymentdatagridviewcheque2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Paymentdatagridviewcheque2.Size = New System.Drawing.Size(510, 180)
        Me.Paymentdatagridviewcheque2.TabIndex = 59
        '
        'btninvcheckout
        '
        Me.btninvcheckout.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btninvcheckout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btninvcheckout.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btninvcheckout.FlatAppearance.BorderSize = 0
        Me.btninvcheckout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btninvcheckout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btninvcheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninvcheckout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninvcheckout.ForeColor = System.Drawing.Color.White
        Me.btninvcheckout.Location = New System.Drawing.Point(284, 435)
        Me.btninvcheckout.Name = "btninvcheckout"
        Me.btninvcheckout.Size = New System.Drawing.Size(234, 40)
        Me.btninvcheckout.TabIndex = 59
        Me.btninvcheckout.Text = "Checkout - ENTER"
        Me.btninvcheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btninvcheckout.UseVisualStyleBackColor = False
        '
        'lblpaymentbalancedue
        '
        Me.lblpaymentbalancedue.BackColor = System.Drawing.Color.Red
        Me.lblpaymentbalancedue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaymentbalancedue.ForeColor = System.Drawing.Color.White
        Me.lblpaymentbalancedue.Location = New System.Drawing.Point(384, 382)
        Me.lblpaymentbalancedue.Name = "lblpaymentbalancedue"
        Me.lblpaymentbalancedue.Size = New System.Drawing.Size(132, 33)
        Me.lblpaymentbalancedue.TabIndex = 56
        Me.lblpaymentbalancedue.Text = "0.00"
        Me.lblpaymentbalancedue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Red
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(282, 383)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(98, 30)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Balance"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblinvno
        '
        Me.lblinvno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvno.ForeColor = System.Drawing.Color.Black
        Me.lblinvno.Location = New System.Drawing.Point(126, 22)
        Me.lblinvno.Name = "lblinvno"
        Me.lblinvno.Size = New System.Drawing.Size(109, 21)
        Me.lblinvno.TabIndex = 3
        Me.lblinvno.Text = "N/A"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.lblinvno)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Location = New System.Drawing.Point(445, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 55)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Invoice No"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(7, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 20)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Invoice No :"
        '
        'lblinvunit
        '
        Me.lblinvunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvunit.ForeColor = System.Drawing.Color.Black
        Me.lblinvunit.Location = New System.Drawing.Point(77, 22)
        Me.lblinvunit.Name = "lblinvunit"
        Me.lblinvunit.Size = New System.Drawing.Size(90, 21)
        Me.lblinvunit.TabIndex = 3
        Me.lblinvunit.Text = "N/A"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(16, 22)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(46, 20)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Unit :"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.lblinvunit)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Location = New System.Drawing.Point(13, 53)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(186, 55)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Unit"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.welcomepanel)
        Me.Panel2.Controls.Add(Me.Statementpanel)
        Me.Panel2.Controls.Add(Me.PayementsPanel)
        Me.Panel2.Controls.Add(Me.Customerspanel)
        Me.Panel2.Controls.Add(Me.ItemsPanel)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.cart_api2)
        Me.Panel2.Controls.Add(Me.GroupBox6)
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.cart_api)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(4, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1334, 666)
        Me.Panel2.TabIndex = 6
        '
        'PayementsPanel
        '
        Me.PayementsPanel.BackColor = System.Drawing.Color.ForestGreen
        Me.PayementsPanel.Controls.Add(Me.Chequepanel)
        Me.PayementsPanel.Controls.Add(Me.lblpaidpayment)
        Me.PayementsPanel.Controls.Add(Me.Label23)
        Me.PayementsPanel.Controls.Add(Me.Label14)
        Me.PayementsPanel.Controls.Add(Me.Label18)
        Me.PayementsPanel.Controls.Add(Me.btninvcheckout)
        Me.PayementsPanel.Controls.Add(Me.Label21)
        Me.PayementsPanel.Controls.Add(Me.txtpaymentamount)
        Me.PayementsPanel.Controls.Add(Me.lblpaymentbalancedue)
        Me.PayementsPanel.Controls.Add(Me.Label17)
        Me.PayementsPanel.Controls.Add(Me.Cmbayementtype)
        Me.PayementsPanel.Controls.Add(Me.txtpaymentcardno)
        Me.PayementsPanel.Controls.Add(Me.Paymentdatagridview1)
        Me.PayementsPanel.Controls.Add(Me.Label11)
        Me.PayementsPanel.Controls.Add(Me.Subtotallbl)
        Me.PayementsPanel.Controls.Add(Me.Label13)
        Me.PayementsPanel.Controls.Add(Me.P7)
        Me.PayementsPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayementsPanel.Location = New System.Drawing.Point(783, 116)
        Me.PayementsPanel.Name = "PayementsPanel"
        Me.PayementsPanel.Size = New System.Drawing.Size(525, 486)
        Me.PayementsPanel.TabIndex = 5
        '
        'lblpaidpayment
        '
        Me.lblpaidpayment.BackColor = System.Drawing.Color.Orange
        Me.lblpaidpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaidpayment.ForeColor = System.Drawing.Color.White
        Me.lblpaidpayment.Location = New System.Drawing.Point(383, 328)
        Me.lblpaidpayment.Name = "lblpaidpayment"
        Me.lblpaidpayment.Size = New System.Drawing.Size(134, 33)
        Me.lblpaidpayment.TabIndex = 71
        Me.lblpaidpayment.Text = "0.00"
        Me.lblpaidpayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Orange
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(282, 330)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(94, 30)
        Me.Label23.TabIndex = 70
        Me.Label23.Text = "Paid"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(16, 446)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 20)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "Amount  :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(14, 387)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 20)
        Me.Label18.TabIndex = 68
        Me.Label18.Text = "Card No :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(15, 334)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 20)
        Me.Label21.TabIndex = 67
        Me.Label21.Text = "Type      :"
        '
        'txtpaymentamount
        '
        Me.txtpaymentamount.Location = New System.Drawing.Point(109, 439)
        Me.txtpaymentamount.Multiline = True
        Me.txtpaymentamount.Name = "txtpaymentamount"
        Me.txtpaymentamount.Size = New System.Drawing.Size(167, 31)
        Me.txtpaymentamount.TabIndex = 66
        '
        'Cmbayementtype
        '
        Me.Cmbayementtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbayementtype.FormattingEnabled = True
        Me.Cmbayementtype.Items.AddRange(New Object() {"Cash", "Cheque", "Credit Card", "Credit"})
        Me.Cmbayementtype.Location = New System.Drawing.Point(109, 332)
        Me.Cmbayementtype.Name = "Cmbayementtype"
        Me.Cmbayementtype.Size = New System.Drawing.Size(167, 28)
        Me.Cmbayementtype.TabIndex = 65
        '
        'txtpaymentcardno
        '
        Me.txtpaymentcardno.Location = New System.Drawing.Point(109, 381)
        Me.txtpaymentcardno.Multiline = True
        Me.txtpaymentcardno.Name = "txtpaymentcardno"
        Me.txtpaymentcardno.Size = New System.Drawing.Size(167, 35)
        Me.txtpaymentcardno.TabIndex = 64
        '
        'Paymentdatagridview1
        '
        Me.Paymentdatagridview1.AllowUserToAddRows = False
        Me.Paymentdatagridview1.AllowUserToDeleteRows = False
        Me.Paymentdatagridview1.AllowUserToResizeColumns = False
        Me.Paymentdatagridview1.AllowUserToResizeRows = False
        Me.Paymentdatagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Paymentdatagridview1.Location = New System.Drawing.Point(6, 38)
        Me.Paymentdatagridview1.Name = "Paymentdatagridview1"
        Me.Paymentdatagridview1.RowHeadersVisible = False
        Me.Paymentdatagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Paymentdatagridview1.Size = New System.Drawing.Size(515, 272)
        Me.Paymentdatagridview1.TabIndex = 63
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(10, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 24)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Payments"
        '
        'Subtotallbl
        '
        Me.Subtotallbl.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Subtotallbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subtotallbl.ForeColor = System.Drawing.Color.White
        Me.Subtotallbl.Location = New System.Drawing.Point(359, 6)
        Me.Subtotallbl.Name = "Subtotallbl"
        Me.Subtotallbl.Size = New System.Drawing.Size(150, 18)
        Me.Subtotallbl.TabIndex = 61
        Me.Subtotallbl.Text = "0.00"
        Me.Subtotallbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(179, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(146, 22)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "NET  TOTAL:"
        '
        'P7
        '
        Me.P7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.P7.Location = New System.Drawing.Point(0, 1)
        Me.P7.Name = "P7"
        Me.P7.Size = New System.Drawing.Size(525, 31)
        Me.P7.TabIndex = 59
        Me.P7.TabStop = False
        '
        'Customerspanel
        '
        Me.Customerspanel.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Customerspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Customerspanel.Controls.Add(Me.lblcustomername)
        Me.Customerspanel.Controls.Add(Me.Label20)
        Me.Customerspanel.Controls.Add(Me.GroupBox3)
        Me.Customerspanel.Location = New System.Drawing.Point(783, 115)
        Me.Customerspanel.Name = "Customerspanel"
        Me.Customerspanel.Size = New System.Drawing.Size(527, 488)
        Me.Customerspanel.TabIndex = 73
        '
        'lblcustomername
        '
        Me.lblcustomername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcustomername.ForeColor = System.Drawing.Color.White
        Me.lblcustomername.Location = New System.Drawing.Point(170, 457)
        Me.lblcustomername.Name = "lblcustomername"
        Me.lblcustomername.Size = New System.Drawing.Size(340, 21)
        Me.lblcustomername.TabIndex = 5
        Me.lblcustomername.Text = "N/A"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(10, 456)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(132, 20)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Customer Name :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.customersdatagridview)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(513, 437)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Found / Selected Your Customers"
        '
        'customersdatagridview
        '
        Me.customersdatagridview.AllowUserToAddRows = False
        Me.customersdatagridview.AllowUserToDeleteRows = False
        Me.customersdatagridview.AllowUserToResizeColumns = False
        Me.customersdatagridview.AllowUserToResizeRows = False
        Me.customersdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.customersdatagridview.Location = New System.Drawing.Point(6, 26)
        Me.customersdatagridview.Name = "customersdatagridview"
        Me.customersdatagridview.RowHeadersVisible = False
        Me.customersdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.customersdatagridview.Size = New System.Drawing.Size(502, 405)
        Me.customersdatagridview.TabIndex = 0
        '
        'ItemsPanel
        '
        Me.ItemsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ItemsPanel.Controls.Add(Me.search_results)
        Me.ItemsPanel.Location = New System.Drawing.Point(785, 115)
        Me.ItemsPanel.Name = "ItemsPanel"
        Me.ItemsPanel.Size = New System.Drawing.Size(524, 488)
        Me.ItemsPanel.TabIndex = 12
        '
        'cart_api2
        '
        Me.cart_api2.BackColor = System.Drawing.Color.White
        Me.cart_api2.Controls.Add(Me.txtinvitemssearch)
        Me.cart_api2.Controls.Add(Me.Label8)
        Me.cart_api2.Location = New System.Drawing.Point(698, 55)
        Me.cart_api2.Name = "cart_api2"
        Me.cart_api2.Size = New System.Drawing.Size(618, 55)
        Me.cart_api2.TabIndex = 3
        Me.cart_api2.TabStop = False
        Me.cart_api2.Text = "Search Box"
        '
        'txtinvitemssearch
        '
        Me.txtinvitemssearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtinvitemssearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList
        Me.txtinvitemssearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinvitemssearch.Location = New System.Drawing.Point(80, 17)
        Me.txtinvitemssearch.Name = "txtinvitemssearch"
        Me.txtinvitemssearch.Size = New System.Drawing.Size(526, 26)
        Me.txtinvitemssearch.TabIndex = 3
        Me.txtinvitemssearch.Text = "Search Items Or Customers"
        Me.txtinvitemssearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(9, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Search "
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.lblinvcashier)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Location = New System.Drawing.Point(205, 54)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(234, 55)
        Me.GroupBox6.TabIndex = 11
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "User"
        '
        'lblinvcashier
        '
        Me.lblinvcashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinvcashier.ForeColor = System.Drawing.Color.Black
        Me.lblinvcashier.Location = New System.Drawing.Point(92, 24)
        Me.lblinvcashier.Name = "lblinvcashier"
        Me.lblinvcashier.Size = New System.Drawing.Size(131, 21)
        Me.lblinvcashier.TabIndex = 10
        Me.lblinvcashier.Text = "N/A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cashier :"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lbloutstanding)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.cmbinvcustname)
        Me.Panel3.Controls.Add(Me.invoice_due_date)
        Me.Panel3.Controls.Add(Me.customer_label_tag)
        Me.Panel3.Controls.Add(Me.invoice_due_label)
        Me.Panel3.Controls.Add(Me.cmbinvcustno)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.invoice_type_header)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1334, 47)
        Me.Panel3.TabIndex = 1
        '
        'lbloutstanding
        '
        Me.lbloutstanding.AutoSize = True
        Me.lbloutstanding.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloutstanding.ForeColor = System.Drawing.Color.Black
        Me.lbloutstanding.Location = New System.Drawing.Point(1006, 14)
        Me.lbloutstanding.Name = "lbloutstanding"
        Me.lbloutstanding.Size = New System.Drawing.Size(40, 20)
        Me.lbloutstanding.TabIndex = 10
        Me.lbloutstanding.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(892, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 20)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Outstanding :"
        '
        'cmbinvcustname
        '
        Me.cmbinvcustname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbinvcustname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbinvcustname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbinvcustname.FormattingEnabled = True
        Me.cmbinvcustname.Location = New System.Drawing.Point(663, 11)
        Me.cmbinvcustname.Name = "cmbinvcustname"
        Me.cmbinvcustname.Size = New System.Drawing.Size(218, 26)
        Me.cmbinvcustname.TabIndex = 0
        Me.cmbinvcustname.TabStop = False
        '
        'invoice_due_date
        '
        Me.invoice_due_date.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoice_due_date.CustomFormat = "yyyy-MMM-dd "
        Me.invoice_due_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoice_due_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.invoice_due_date.Location = New System.Drawing.Point(1171, 12)
        Me.invoice_due_date.MinDate = New Date(2018, 6, 6, 0, 0, 0, 0)
        Me.invoice_due_date.Name = "invoice_due_date"
        Me.invoice_due_date.Size = New System.Drawing.Size(142, 26)
        Me.invoice_due_date.TabIndex = 1
        Me.invoice_due_date.TabStop = False
        '
        'customer_label_tag
        '
        Me.customer_label_tag.AutoSize = True
        Me.customer_label_tag.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customer_label_tag.ForeColor = System.Drawing.Color.Black
        Me.customer_label_tag.Location = New System.Drawing.Point(529, 13)
        Me.customer_label_tag.Name = "customer_label_tag"
        Me.customer_label_tag.Size = New System.Drawing.Size(124, 20)
        Me.customer_label_tag.TabIndex = 2
        Me.customer_label_tag.Text = "Customer Name"
        '
        'invoice_due_label
        '
        Me.invoice_due_label.AutoSize = True
        Me.invoice_due_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoice_due_label.ForeColor = System.Drawing.Color.Black
        Me.invoice_due_label.Location = New System.Drawing.Point(1056, 14)
        Me.invoice_due_label.Name = "invoice_due_label"
        Me.invoice_due_label.Size = New System.Drawing.Size(106, 20)
        Me.invoice_due_label.TabIndex = 6
        Me.invoice_due_label.Text = "Invoice Date :"
        '
        'cmbinvcustno
        '
        Me.cmbinvcustno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbinvcustno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbinvcustno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbinvcustno.FormattingEnabled = True
        Me.cmbinvcustno.Location = New System.Drawing.Point(398, 10)
        Me.cmbinvcustno.Name = "cmbinvcustno"
        Me.cmbinvcustno.Size = New System.Drawing.Size(123, 26)
        Me.cmbinvcustno.TabIndex = 7
        Me.cmbinvcustno.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(289, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Customer No"
        '
        'invoice_type_header
        '
        Me.invoice_type_header.AutoSize = True
        Me.invoice_type_header.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoice_type_header.ForeColor = System.Drawing.Color.Black
        Me.invoice_type_header.Location = New System.Drawing.Point(113, 12)
        Me.invoice_type_header.Name = "invoice_type_header"
        Me.invoice_type_header.Size = New System.Drawing.Size(161, 25)
        Me.invoice_type_header.TabIndex = 6
        Me.invoice_type_header.Text = "Add POS Sale"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(92, 67)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'invoice_type_dsc
        '
        Me.invoice_type_dsc.AutoSize = True
        Me.invoice_type_dsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoice_type_dsc.ForeColor = System.Drawing.Color.White
        Me.invoice_type_dsc.Location = New System.Drawing.Point(119, 40)
        Me.invoice_type_dsc.Name = "invoice_type_dsc"
        Me.invoice_type_dsc.Size = New System.Drawing.Size(203, 20)
        Me.invoice_type_dsc.TabIndex = 2
        Me.invoice_type_dsc.Text = "Add New Point of Sale here"
        '
        'invoice_type_header2
        '
        Me.invoice_type_header2.AutoSize = True
        Me.invoice_type_header2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.invoice_type_header2.ForeColor = System.Drawing.Color.White
        Me.invoice_type_header2.Location = New System.Drawing.Point(122, 7)
        Me.invoice_type_header2.Name = "invoice_type_header2"
        Me.invoice_type_header2.Size = New System.Drawing.Size(235, 29)
        Me.invoice_type_header2.TabIndex = 2
        Me.invoice_type_header2.Text = "Boapagama Stores"
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.lblmode)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.btnitems)
        Me.Panel1.Controls.Add(Me.btncustomers)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.invoice_type_dsc)
        Me.Panel1.Controls.Add(Me.invoice_type_header2)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1340, 784)
        Me.Panel1.TabIndex = 5
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LimeGreen
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(942, 746)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(141, 31)
        Me.Button4.TabIndex = 65
        Me.Button4.Text = "PAY - F5"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LimeGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(784, 746)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 31)
        Me.Button2.TabIndex = 63
        Me.Button2.Text = "PAY - F5"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LimeGreen
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(642, 746)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(126, 33)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "PAY - F5"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(833, 24)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(74, 22)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Mode :"
        '
        'lblmode
        '
        Me.lblmode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmode.Location = New System.Drawing.Point(915, 24)
        Me.lblmode.Name = "lblmode"
        Me.lblmode.Size = New System.Drawing.Size(83, 22)
        Me.lblmode.TabIndex = 15
        Me.lblmode.Text = "N/A"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.White
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(610, 14)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(46, 40)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 14
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.ErrorImage = Nothing
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(387, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(46, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'btnitems
        '
        Me.btnitems.BackColor = System.Drawing.Color.Black
        Me.btnitems.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnitems.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnitems.FlatAppearance.BorderSize = 0
        Me.btnitems.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnitems.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnitems.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnitems.ForeColor = System.Drawing.Color.White
        Me.btnitems.Location = New System.Drawing.Point(609, 13)
        Me.btnitems.Name = "btnitems"
        Me.btnitems.Size = New System.Drawing.Size(204, 42)
        Me.btnitems.TabIndex = 12
        Me.btnitems.Text = "ITEMS - F12"
        Me.btnitems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnitems.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnitems.UseVisualStyleBackColor = False
        '
        'btncustomers
        '
        Me.btncustomers.BackColor = System.Drawing.Color.Black
        Me.btncustomers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncustomers.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btncustomers.FlatAppearance.BorderSize = 0
        Me.btncustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btncustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncustomers.ForeColor = System.Drawing.Color.White
        Me.btncustomers.Location = New System.Drawing.Point(382, 13)
        Me.btncustomers.Name = "btncustomers"
        Me.btncustomers.Size = New System.Drawing.Size(211, 42)
        Me.btncustomers.TabIndex = 11
        Me.btncustomers.Text = "CUSTOMERS - F11"
        Me.btncustomers.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btncustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncustomers.UseVisualStyleBackColor = False
        '
        'Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1096, 599)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.search_results.ResumeLayout(False)
        Me.search_results.PerformLayout()
        CType(Me.invsearchitemsdatagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cart_api.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.invaddcartdatagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Statementpanel.ResumeLayout(False)
        Me.Settlementpanel.ResumeLayout(False)
        Me.Settlementpanel.PerformLayout()
        Me.Settlementchequepanel.ResumeLayout(False)
        Me.Settlementchequepanel.PerformLayout()
        CType(Me.Stchquedatagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Mainstatementpanel.ResumeLayout(False)
        CType(Me.Mainstatementdatagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Chequepanel.ResumeLayout(False)
        Me.Chequepanel.PerformLayout()
        CType(Me.Paymentdatagridviewcheque2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.PayementsPanel.ResumeLayout(False)
        Me.PayementsPanel.PerformLayout()
        CType(Me.Paymentdatagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.P7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Customerspanel.ResumeLayout(False)
        Me.Customerspanel.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.customersdatagridview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ItemsPanel.ResumeLayout(False)
        Me.cart_api2.ResumeLayout(False)
        Me.cart_api2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents search_results As System.Windows.Forms.GroupBox
    Friend WithEvents invsearchitemsdatagridview As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtinvitemsamount As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtinvitemsqty As System.Windows.Forms.TextBox
    Friend WithEvents txtinvitemsdiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblinvtotalqty As System.Windows.Forms.TextBox
    Friend WithEvents lblinvtotaldiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents invoice_type_nav As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblinvtotalamount As System.Windows.Forms.TextBox
    Friend WithEvents cart_api As System.Windows.Forms.GroupBox
    Friend WithEvents btnemptycart As System.Windows.Forms.Button
    Friend WithEvents btndeleteselected As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btninvcheckout As System.Windows.Forms.Button
    Friend WithEvents btninvcancel As System.Windows.Forms.Button
    Friend WithEvents checkinvprintreceipt As System.Windows.Forms.CheckBox
    Friend WithEvents lblpaymentbalancedue As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblinvno As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblinvunit As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbinvcustno As System.Windows.Forms.ComboBox
    Friend WithEvents customer_label_tag As System.Windows.Forms.Label
    Friend WithEvents cmbinvcustname As System.Windows.Forms.ComboBox
    Friend WithEvents cart_api2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblinvcashier As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents invoice_due_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents invoice_due_label As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents invoice_type_header As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents invoice_type_dsc As System.Windows.Forms.Label
    Friend WithEvents invoice_type_header2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents invaddcartdatagridview As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblinvitemsname As System.Windows.Forms.Label
    Friend WithEvents txtinvitemssearch As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ItemsPanel As System.Windows.Forms.Panel
    Friend WithEvents PayementsPanel As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Subtotallbl As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents P7 As System.Windows.Forms.PictureBox
    Friend WithEvents Paymentdatagridview1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnpay As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtpaymentamount As System.Windows.Forms.TextBox
    Friend WithEvents Cmbayementtype As System.Windows.Forms.ComboBox
    Friend WithEvents txtpaymentcardno As System.Windows.Forms.TextBox
    Friend WithEvents lblpaidpayment As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblnettotal As System.Windows.Forms.TextBox
    Friend WithEvents Chequepanel As System.Windows.Forms.Panel
    Friend WithEvents cmbpaymentchequebranch As System.Windows.Forms.ComboBox
    Friend WithEvents cmbpaymentchequebank As System.Windows.Forms.ComboBox
    Friend WithEvents dppaymentchequedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents btnpaychequesave As System.Windows.Forms.Button
    Friend WithEvents btnpaychequecancel As System.Windows.Forms.Button
    Friend WithEvents lbltotalcheque As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents l As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtpaymentchequeamount As System.Windows.Forms.TextBox
    Friend WithEvents txtpaymentchequeno As System.Windows.Forms.TextBox
    Friend WithEvents Paymentdatagridviewcheque2 As System.Windows.Forms.DataGridView
    Friend WithEvents btncustomers As System.Windows.Forms.Button
    Friend WithEvents btnitems As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Customerspanel As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents customersdatagridview As System.Windows.Forms.DataGridView
    Friend WithEvents lblcustomername As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblmode As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents btnremovelast As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbloutstanding As System.Windows.Forms.Label
    Friend WithEvents btnstatement As System.Windows.Forms.Button
    Friend WithEvents btnunhold As System.Windows.Forms.Button
    Friend WithEvents btnhold As System.Windows.Forms.Button
    Friend WithEvents btnrecallbill As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnprintlastbill As System.Windows.Forms.Button
    Friend WithEvents cmbinvloadprint As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtinvalldiscounts As System.Windows.Forms.TextBox
    Friend WithEvents lblloadprintname As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblrecallcustname As System.Windows.Forms.Label
    Friend WithEvents cmbrecallinvnoload As System.Windows.Forms.ComboBox
    Friend WithEvents Statementpanel As System.Windows.Forms.Panel
    Friend WithEvents Mainstatementpanel As System.Windows.Forms.Panel
    Friend WithEvents Mainstatementdatagridview As System.Windows.Forms.DataGridView
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnministatemnetprint As System.Windows.Forms.Button
    Friend WithEvents btnstatementprint As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents lblstheadertitle As System.Windows.Forms.Label
    Friend WithEvents Settlementpanel As System.Windows.Forms.Panel
    Friend WithEvents txtstamount As System.Windows.Forms.TextBox
    Friend WithEvents CmbstType As System.Windows.Forms.ComboBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents btnstsettlementcancel As System.Windows.Forms.Button
    Friend WithEvents btnstsettlementsave As System.Windows.Forms.Button
    Friend WithEvents cmbstdocno As System.Windows.Forms.ComboBox
    Friend WithEvents Settlementchequepanel As System.Windows.Forms.Panel
    Friend WithEvents cmbstbranch As System.Windows.Forms.ComboBox
    Friend WithEvents cmbstbank As System.Windows.Forms.ComboBox
    Friend WithEvents dpstchequedate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents btnschequesave As System.Windows.Forms.Button
    Friend WithEvents btnchequecancel As System.Windows.Forms.Button
    Friend WithEvents lblstchequetotal As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtstchequeno As System.Windows.Forms.TextBox
    Friend WithEvents Stchquedatagridview As System.Windows.Forms.DataGridView
    Friend WithEvents welcomepanel As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
