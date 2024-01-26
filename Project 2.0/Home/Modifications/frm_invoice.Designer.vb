<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_invoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_invoice))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaControlBox3 = New Guna.UI.WinForms.GunaControlBox()
        Me.lblUser = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.lblStore_name = New Guna.UI.WinForms.GunaLabel()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.comInvoice = New System.Windows.Forms.ComboBox()
        Me.btnPrint_last = New Guna.UI.WinForms.GunaButton()
        Me.btnClear = New Guna.UI.WinForms.GunaButton()
        Me.btnSettlement = New Guna.UI.WinForms.GunaButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lblPaid = New Guna.UI.WinForms.GunaLabel()
        Me.lblbalance = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel18 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel19 = New Guna.UI.WinForms.GunaLabel()
        Me.lblGeand_total = New Guna.UI.WinForms.GunaLabel()
        Me.lblTotal_discount = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.lblDate = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.lblInvoice = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.btnpay = New Guna.UI.WinForms.GunaButton()
        Me.btnHold = New Guna.UI.WinForms.GunaButton()
        Me.btnCancel = New Guna.UI.WinForms.GunaButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.chkPrint = New System.Windows.Forms.CheckBox()
        Me.GunaLabel15 = New Guna.UI.WinForms.GunaLabel()
        Me.lblSelect_Item = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.DgItems = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearch_items = New MetroFramework.Controls.MetroTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblStatus = New Guna.UI.WinForms.GunaLabel()
        Me.txtpaid = New System.Windows.Forms.TextBox()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.comHold_items = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel14 = New Guna.UI.WinForms.GunaLabel()
        Me.comPayment_method = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel13 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lblnetTotal = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.lblItemsQty = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnAdd_Customer = New Guna.UI.WinForms.GunaImageButton()
        Me.comSearch_customer = New System.Windows.Forms.ComboBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.dgCart = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DgItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GunaControlBox3)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.GunaLabel2)
        Me.Panel1.Controls.Add(Me.lblStore_name)
        Me.Panel1.Controls.Add(Me.GunaControlBox2)
        Me.Panel1.Controls.Add(Me.GunaControlBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1294, 28)
        Me.Panel1.TabIndex = 0
        '
        'GunaControlBox3
        '
        Me.GunaControlBox3.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox3.AnimationSpeed = 0.03!
        Me.GunaControlBox3.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaControlBox3.IconColor = System.Drawing.Color.WhiteSmoke
        Me.GunaControlBox3.IconSize = 15.0!
        Me.GunaControlBox3.Location = New System.Drawing.Point(1192, 0)
        Me.GunaControlBox3.Name = "GunaControlBox3"
        Me.GunaControlBox3.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox3.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox3.Size = New System.Drawing.Size(34, 28)
        Me.GunaControlBox3.TabIndex = 11
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.lblUser.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblUser.Location = New System.Drawing.Point(72, 7)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(62, 13)
        Me.lblUser.TabIndex = 10
        Me.lblUser.Text = "User Name"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.GunaLabel2.Location = New System.Drawing.Point(6, 7)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(60, 13)
        Me.GunaLabel2.TabIndex = 9
        Me.GunaLabel2.Text = "Logged By"
        '
        'lblStore_name
        '
        Me.lblStore_name.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblStore_name.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblStore_name.Location = New System.Drawing.Point(104, 4)
        Me.lblStore_name.Name = "lblStore_name"
        Me.lblStore_name.Size = New System.Drawing.Size(947, 21)
        Me.lblStore_name.TabIndex = 9
        Me.lblStore_name.Text = "Store Name"
        Me.lblStore_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MaximizeBox
        Me.GunaControlBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaControlBox2.IconColor = System.Drawing.Color.WhiteSmoke
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(1226, 0)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(34, 28)
        Me.GunaControlBox2.TabIndex = 2
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaControlBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GunaControlBox1.IconColor = System.Drawing.Color.Red
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(1260, 0)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.Red
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(34, 28)
        Me.GunaControlBox1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel2.Controls.Add(Me.comInvoice)
        Me.Panel2.Controls.Add(Me.btnPrint_last)
        Me.Panel2.Controls.Add(Me.btnClear)
        Me.Panel2.Controls.Add(Me.btnSettlement)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.lblDate)
        Me.Panel2.Controls.Add(Me.GunaLabel3)
        Me.Panel2.Controls.Add(Me.lblInvoice)
        Me.Panel2.Controls.Add(Me.GunaLabel1)
        Me.Panel2.Controls.Add(Me.btnpay)
        Me.Panel2.Controls.Add(Me.btnHold)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1294, 700)
        Me.Panel2.TabIndex = 1
        '
        'comInvoice
        '
        Me.comInvoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comInvoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comInvoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.comInvoice.FormattingEnabled = True
        Me.comInvoice.Location = New System.Drawing.Point(261, 663)
        Me.comInvoice.Name = "comInvoice"
        Me.comInvoice.Size = New System.Drawing.Size(262, 25)
        Me.comInvoice.TabIndex = 15
        '
        'btnPrint_last
        '
        Me.btnPrint_last.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint_last.Animated = True
        Me.btnPrint_last.AnimationHoverSpeed = 0.07!
        Me.btnPrint_last.AnimationSpeed = 0.03!
        Me.btnPrint_last.BackColor = System.Drawing.Color.Transparent
        Me.btnPrint_last.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPrint_last.BaseColor = System.Drawing.Color.Chocolate
        Me.btnPrint_last.BorderColor = System.Drawing.Color.Black
        Me.btnPrint_last.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnPrint_last.FocusedColor = System.Drawing.Color.Empty
        Me.btnPrint_last.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.75!)
        Me.btnPrint_last.ForeColor = System.Drawing.Color.White
        Me.btnPrint_last.Image = Nothing
        Me.btnPrint_last.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnPrint_last.Location = New System.Drawing.Point(131, 652)
        Me.btnPrint_last.Name = "btnPrint_last"
        Me.btnPrint_last.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrint_last.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnPrint_last.OnHoverForeColor = System.Drawing.Color.White
        Me.btnPrint_last.OnHoverImage = Nothing
        Me.btnPrint_last.OnPressedColor = System.Drawing.Color.Black
        Me.btnPrint_last.Radius = 5
        Me.btnPrint_last.Size = New System.Drawing.Size(124, 42)
        Me.btnPrint_last.TabIndex = 14
        Me.btnPrint_last.Text = "Print Invoice [F12]"
        Me.btnPrint_last.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MetroToolTip1.SetToolTip(Me.btnPrint_last, "Settle Credit Customers Bill")
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.Animated = True
        Me.btnClear.AnimationHoverSpeed = 0.07!
        Me.btnClear.AnimationSpeed = 0.03!
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnClear.BorderColor = System.Drawing.Color.Black
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClear.FocusedColor = System.Drawing.Color.Empty
        Me.btnClear.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.75!)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Image = Nothing
        Me.btnClear.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnClear.Location = New System.Drawing.Point(4, 652)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnPressedColor = System.Drawing.Color.Black
        Me.btnClear.Radius = 5
        Me.btnClear.Size = New System.Drawing.Size(121, 42)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear [F3]"
        Me.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MetroToolTip1.SetToolTip(Me.btnClear, "Cancel Cart Items")
        '
        'btnSettlement
        '
        Me.btnSettlement.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSettlement.Animated = True
        Me.btnSettlement.AnimationHoverSpeed = 0.07!
        Me.btnSettlement.AnimationSpeed = 0.03!
        Me.btnSettlement.BackColor = System.Drawing.Color.Transparent
        Me.btnSettlement.BaseColor = System.Drawing.Color.RoyalBlue
        Me.btnSettlement.BorderColor = System.Drawing.Color.Black
        Me.btnSettlement.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSettlement.FocusedColor = System.Drawing.Color.Empty
        Me.btnSettlement.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.75!)
        Me.btnSettlement.ForeColor = System.Drawing.Color.White
        Me.btnSettlement.Image = Nothing
        Me.btnSettlement.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnSettlement.Location = New System.Drawing.Point(382, 604)
        Me.btnSettlement.Name = "btnSettlement"
        Me.btnSettlement.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSettlement.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSettlement.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSettlement.OnHoverImage = Nothing
        Me.btnSettlement.OnPressedColor = System.Drawing.Color.Black
        Me.btnSettlement.Radius = 5
        Me.btnSettlement.Size = New System.Drawing.Size(140, 42)
        Me.btnSettlement.TabIndex = 13
        Me.btnSettlement.Text = "Settlement [F9]"
        Me.btnSettlement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MetroToolTip1.SetToolTip(Me.btnSettlement, "Settle Credit Customers Bill")
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Controls.Add(Me.lblPaid)
        Me.Panel7.Controls.Add(Me.lblbalance)
        Me.Panel7.Controls.Add(Me.GunaLabel18)
        Me.Panel7.Controls.Add(Me.GunaLabel19)
        Me.Panel7.Controls.Add(Me.lblGeand_total)
        Me.Panel7.Controls.Add(Me.lblTotal_discount)
        Me.Panel7.Controls.Add(Me.GunaLabel12)
        Me.Panel7.Controls.Add(Me.GunaLabel11)
        Me.Panel7.Location = New System.Drawing.Point(2, 337)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(520, 111)
        Me.Panel7.TabIndex = 12
        '
        'lblPaid
        '
        Me.lblPaid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPaid.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblPaid.ForeColor = System.Drawing.Color.Black
        Me.lblPaid.Location = New System.Drawing.Point(122, 21)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(129, 25)
        Me.lblPaid.TabIndex = 25
        Me.lblPaid.Text = "0.00"
        Me.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblbalance
        '
        Me.lblbalance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblbalance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblbalance.ForeColor = System.Drawing.Color.Black
        Me.lblbalance.Location = New System.Drawing.Point(115, 70)
        Me.lblbalance.Name = "lblbalance"
        Me.lblbalance.Size = New System.Drawing.Size(133, 21)
        Me.lblbalance.TabIndex = 24
        Me.lblbalance.Text = "0.00"
        Me.lblbalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GunaLabel18
        '
        Me.GunaLabel18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel18.AutoSize = True
        Me.GunaLabel18.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel18.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel18.Location = New System.Drawing.Point(3, 69)
        Me.GunaLabel18.Name = "GunaLabel18"
        Me.GunaLabel18.Size = New System.Drawing.Size(63, 21)
        Me.GunaLabel18.TabIndex = 23
        Me.GunaLabel18.Text = "Balance"
        '
        'GunaLabel19
        '
        Me.GunaLabel19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel19.AutoSize = True
        Me.GunaLabel19.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel19.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel19.Location = New System.Drawing.Point(3, 24)
        Me.GunaLabel19.Name = "GunaLabel19"
        Me.GunaLabel19.Size = New System.Drawing.Size(99, 21)
        Me.GunaLabel19.TabIndex = 22
        Me.GunaLabel19.Text = "Paid Amount"
        '
        'lblGeand_total
        '
        Me.lblGeand_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGeand_total.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblGeand_total.ForeColor = System.Drawing.Color.Black
        Me.lblGeand_total.Location = New System.Drawing.Point(389, 67)
        Me.lblGeand_total.Name = "lblGeand_total"
        Me.lblGeand_total.Size = New System.Drawing.Size(129, 25)
        Me.lblGeand_total.TabIndex = 21
        Me.lblGeand_total.Text = "0.00"
        Me.lblGeand_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal_discount
        '
        Me.lblTotal_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal_discount.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblTotal_discount.ForeColor = System.Drawing.Color.Black
        Me.lblTotal_discount.Location = New System.Drawing.Point(385, 24)
        Me.lblTotal_discount.Name = "lblTotal_discount"
        Me.lblTotal_discount.Size = New System.Drawing.Size(133, 21)
        Me.lblTotal_discount.TabIndex = 20
        Me.lblTotal_discount.Text = "0.00"
        Me.lblTotal_discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GunaLabel12
        '
        Me.GunaLabel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel12.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel12.Location = New System.Drawing.Point(264, 69)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(89, 21)
        Me.GunaLabel12.TabIndex = 19
        Me.GunaLabel12.Text = "Grand Total"
        '
        'GunaLabel11
        '
        Me.GunaLabel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel11.ForeColor = System.Drawing.Color.Black
        Me.GunaLabel11.Location = New System.Drawing.Point(264, 24)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(107, 21)
        Me.GunaLabel11.TabIndex = 18
        Me.GunaLabel11.Text = "Total Discount"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblDate.Location = New System.Drawing.Point(96, 25)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(42, 21)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Date"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel3.Location = New System.Drawing.Point(6, 25)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(42, 21)
        Me.GunaLabel3.TabIndex = 7
        Me.GunaLabel3.Text = "Date"
        '
        'lblInvoice
        '
        Me.lblInvoice.AutoSize = True
        Me.lblInvoice.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblInvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInvoice.Location = New System.Drawing.Point(96, 4)
        Me.lblInvoice.Name = "lblInvoice"
        Me.lblInvoice.Size = New System.Drawing.Size(84, 21)
        Me.lblInvoice.TabIndex = 6
        Me.lblInvoice.Text = "Invoice No"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel1.Location = New System.Drawing.Point(6, 4)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(84, 21)
        Me.GunaLabel1.TabIndex = 5
        Me.GunaLabel1.Text = "Invoice No"
        '
        'btnpay
        '
        Me.btnpay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnpay.Animated = True
        Me.btnpay.AnimationHoverSpeed = 0.07!
        Me.btnpay.AnimationSpeed = 0.03!
        Me.btnpay.BackColor = System.Drawing.Color.Transparent
        Me.btnpay.BaseColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.btnpay.BorderColor = System.Drawing.Color.Black
        Me.btnpay.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnpay.FocusedColor = System.Drawing.Color.Empty
        Me.btnpay.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.75!)
        Me.btnpay.ForeColor = System.Drawing.Color.White
        Me.btnpay.Image = CType(resources.GetObject("btnpay.Image"), System.Drawing.Image)
        Me.btnpay.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnpay.Location = New System.Drawing.Point(255, 604)
        Me.btnpay.Name = "btnpay"
        Me.btnpay.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnpay.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnpay.OnHoverForeColor = System.Drawing.Color.White
        Me.btnpay.OnHoverImage = Nothing
        Me.btnpay.OnPressedColor = System.Drawing.Color.Black
        Me.btnpay.Radius = 5
        Me.btnpay.Size = New System.Drawing.Size(121, 42)
        Me.btnpay.TabIndex = 4
        Me.btnpay.Text = "Pay [F5]"
        Me.btnpay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MetroToolTip1.SetToolTip(Me.btnpay, "Pay For Invoice")
        '
        'btnHold
        '
        Me.btnHold.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHold.Animated = True
        Me.btnHold.AnimationHoverSpeed = 0.07!
        Me.btnHold.AnimationSpeed = 0.03!
        Me.btnHold.BackColor = System.Drawing.Color.Transparent
        Me.btnHold.BaseColor = System.Drawing.Color.Magenta
        Me.btnHold.BorderColor = System.Drawing.Color.Black
        Me.btnHold.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnHold.FocusedColor = System.Drawing.Color.Empty
        Me.btnHold.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.75!)
        Me.btnHold.ForeColor = System.Drawing.Color.White
        Me.btnHold.Image = CType(resources.GetObject("btnHold.Image"), System.Drawing.Image)
        Me.btnHold.ImageSize = New System.Drawing.Size(23, 23)
        Me.btnHold.Location = New System.Drawing.Point(129, 604)
        Me.btnHold.Name = "btnHold"
        Me.btnHold.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnHold.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHold.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHold.OnHoverImage = Nothing
        Me.btnHold.OnPressedColor = System.Drawing.Color.Black
        Me.btnHold.Radius = 5
        Me.btnHold.Size = New System.Drawing.Size(121, 42)
        Me.btnHold.TabIndex = 3
        Me.btnHold.Text = "Hold [F4]"
        Me.btnHold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MetroToolTip1.SetToolTip(Me.btnHold, "Hold Products in the Cart")
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Animated = True
        Me.btnCancel.AnimationHoverSpeed = 0.07!
        Me.btnCancel.AnimationSpeed = 0.03!
        Me.btnCancel.BackColor = System.Drawing.Color.Transparent
        Me.btnCancel.BaseColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(9, Byte), Integer))
        Me.btnCancel.BorderColor = System.Drawing.Color.Black
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancel.FocusedColor = System.Drawing.Color.Empty
        Me.btnCancel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.75!)
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Image = Nothing
        Me.btnCancel.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnCancel.Location = New System.Drawing.Point(4, 604)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCancel.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCancel.OnHoverImage = Nothing
        Me.btnCancel.OnPressedColor = System.Drawing.Color.Black
        Me.btnCancel.Radius = 5
        Me.btnCancel.Size = New System.Drawing.Size(121, 42)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel [F8]"
        Me.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MetroToolTip1.SetToolTip(Me.btnCancel, "Cancel Cart Items")
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.chkPrint)
        Me.Panel4.Controls.Add(Me.GunaLabel15)
        Me.Panel4.Controls.Add(Me.lblSelect_Item)
        Me.Panel4.Controls.Add(Me.GunaLabel7)
        Me.Panel4.Controls.Add(Me.txtAmount)
        Me.Panel4.Controls.Add(Me.GunaLabel6)
        Me.Panel4.Controls.Add(Me.txtDiscount)
        Me.Panel4.Controls.Add(Me.GunaLabel5)
        Me.Panel4.Controls.Add(Me.txtQuantity)
        Me.Panel4.Controls.Add(Me.DgItems)
        Me.Panel4.Controls.Add(Me.txtSearch_items)
        Me.Panel4.Location = New System.Drawing.Point(529, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(736, 682)
        Me.Panel4.TabIndex = 1
        '
        'chkPrint
        '
        Me.chkPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPrint.AutoSize = True
        Me.chkPrint.Checked = True
        Me.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrint.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.chkPrint.Location = New System.Drawing.Point(610, 646)
        Me.chkPrint.Name = "chkPrint"
        Me.chkPrint.Size = New System.Drawing.Size(87, 17)
        Me.chkPrint.TabIndex = 15
        Me.chkPrint.Text = "Print Receipt"
        Me.chkPrint.UseVisualStyleBackColor = True
        '
        'GunaLabel15
        '
        Me.GunaLabel15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel15.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel15.ForeColor = System.Drawing.Color.White
        Me.GunaLabel15.Location = New System.Drawing.Point(354, 614)
        Me.GunaLabel15.Name = "GunaLabel15"
        Me.GunaLabel15.Size = New System.Drawing.Size(99, 21)
        Me.GunaLabel15.TabIndex = 14
        Me.GunaLabel15.Text = "Picked Item :"
        '
        'lblSelect_Item
        '
        Me.lblSelect_Item.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSelect_Item.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblSelect_Item.ForeColor = System.Drawing.Color.Gold
        Me.lblSelect_Item.Location = New System.Drawing.Point(454, 614)
        Me.lblSelect_Item.Name = "lblSelect_Item"
        Me.lblSelect_Item.Size = New System.Drawing.Size(237, 21)
        Me.lblSelect_Item.TabIndex = 13
        Me.lblSelect_Item.Text = "N/A"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel7.Location = New System.Drawing.Point(244, 648)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(66, 21)
        Me.GunaLabel7.TabIndex = 12
        Me.GunaLabel7.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(227, 618)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 26)
        Me.txtAmount.TabIndex = 11
        Me.txtAmount.Text = "0.00"
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MetroToolTip1.SetToolTip(Me.txtAmount, "Total Amount of the Procuct")
        '
        'GunaLabel6
        '
        Me.GunaLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel6.Location = New System.Drawing.Point(136, 648)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(71, 21)
        Me.GunaLabel6.TabIndex = 10
        Me.GunaLabel6.Text = "Discount"
        '
        'txtDiscount
        '
        Me.txtDiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.Location = New System.Drawing.Point(121, 618)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(100, 26)
        Me.txtDiscount.TabIndex = 9
        Me.txtDiscount.Text = "0.00"
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.MetroToolTip1.SetToolTip(Me.txtDiscount, "Discount For the Item")
        '
        'GunaLabel5
        '
        Me.GunaLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel5.Location = New System.Drawing.Point(30, 648)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(70, 21)
        Me.GunaLabel5.TabIndex = 8
        Me.GunaLabel5.Text = "Quantity"
        '
        'txtQuantity
        '
        Me.txtQuantity.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(15, 618)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 26)
        Me.txtQuantity.TabIndex = 2
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MetroToolTip1.SetToolTip(Me.txtQuantity, "Picked Quantity")
        '
        'DgItems
        '
        Me.DgItems.AllowUserToAddRows = False
        Me.DgItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgItems.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DgItems.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgItems.Location = New System.Drawing.Point(15, 54)
        Me.DgItems.Name = "DgItems"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(167, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LawnGreen
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgItems.RowHeadersVisible = False
        Me.DgItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgItems.Size = New System.Drawing.Size(676, 558)
        Me.DgItems.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 95
        '
        'Column2
        '
        Me.Column2.HeaderText = "Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 250
        '
        'Column3
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column3.HeaderText = "Sell Price"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 120
        '
        'Column4
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column4.HeaderText = "Our Price"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 120
        '
        'Column5
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "N0"
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column5.HeaderText = "Stock"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 70
        '
        'txtSearch_items
        '
        '
        '
        '
        Me.txtSearch_items.CustomButton.Image = Nothing
        Me.txtSearch_items.CustomButton.Location = New System.Drawing.Point(642, 1)
        Me.txtSearch_items.CustomButton.Name = ""
        Me.txtSearch_items.CustomButton.Size = New System.Drawing.Size(33, 33)
        Me.txtSearch_items.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSearch_items.CustomButton.TabIndex = 1
        Me.txtSearch_items.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSearch_items.CustomButton.UseSelectable = True
        Me.txtSearch_items.CustomButton.Visible = False
        Me.txtSearch_items.DisplayIcon = True
        Me.txtSearch_items.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtSearch_items.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtSearch_items.Icon = CType(resources.GetObject("txtSearch_items.Icon"), System.Drawing.Image)
        Me.txtSearch_items.Lines = New String(-1) {}
        Me.txtSearch_items.Location = New System.Drawing.Point(15, 13)
        Me.txtSearch_items.MaxLength = 32767
        Me.txtSearch_items.Name = "txtSearch_items"
        Me.txtSearch_items.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearch_items.PromptText = "Search Products"
        Me.txtSearch_items.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSearch_items.SelectedText = ""
        Me.txtSearch_items.SelectionLength = 0
        Me.txtSearch_items.SelectionStart = 0
        Me.txtSearch_items.ShortcutsEnabled = True
        Me.txtSearch_items.Size = New System.Drawing.Size(676, 35)
        Me.txtSearch_items.TabIndex = 0
        Me.txtSearch_items.UseCustomBackColor = True
        Me.txtSearch_items.UseCustomForeColor = True
        Me.txtSearch_items.UseSelectable = True
        Me.txtSearch_items.WaterMark = "Search Products"
        Me.txtSearch_items.WaterMarkColor = System.Drawing.Color.Silver
        Me.txtSearch_items.WaterMarkFont = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(167, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblStatus)
        Me.Panel3.Controls.Add(Me.txtpaid)
        Me.Panel3.Controls.Add(Me.GunaLabel10)
        Me.Panel3.Controls.Add(Me.comHold_items)
        Me.Panel3.Controls.Add(Me.GunaLabel14)
        Me.Panel3.Controls.Add(Me.comPayment_method)
        Me.Panel3.Controls.Add(Me.GunaLabel13)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.dgCart)
        Me.Panel3.Location = New System.Drawing.Point(3, 55)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(520, 546)
        Me.Panel3.TabIndex = 0
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblStatus.Location = New System.Drawing.Point(263, 517)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(47, 19)
        Me.lblStatus.TabIndex = 24
        Me.lblStatus.Text = "Status"
        '
        'txtpaid
        '
        Me.txtpaid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.txtpaid.Location = New System.Drawing.Point(267, 446)
        Me.txtpaid.Name = "txtpaid"
        Me.txtpaid.Size = New System.Drawing.Size(250, 26)
        Me.txtpaid.TabIndex = 23
        Me.txtpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MetroToolTip1.SetToolTip(Me.txtpaid, "Paid Amount")
        '
        'GunaLabel10
        '
        Me.GunaLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel10.Location = New System.Drawing.Point(0, 448)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(130, 21)
        Me.GunaLabel10.TabIndex = 22
        Me.GunaLabel10.Text = "Paid Amount [F2]"
        '
        'comHold_items
        '
        Me.comHold_items.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comHold_items.BackColor = System.Drawing.Color.Transparent
        Me.comHold_items.BaseColor = System.Drawing.Color.White
        Me.comHold_items.BorderColor = System.Drawing.Color.Silver
        Me.comHold_items.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comHold_items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comHold_items.FocusedColor = System.Drawing.Color.Empty
        Me.comHold_items.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comHold_items.ForeColor = System.Drawing.Color.Black
        Me.comHold_items.FormattingEnabled = True
        Me.comHold_items.Location = New System.Drawing.Point(267, 488)
        Me.comHold_items.Name = "comHold_items"
        Me.comHold_items.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comHold_items.OnHoverItemForeColor = System.Drawing.Color.White
        Me.comHold_items.Size = New System.Drawing.Size(250, 26)
        Me.comHold_items.TabIndex = 21
        '
        'GunaLabel14
        '
        Me.GunaLabel14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel14.AutoSize = True
        Me.GunaLabel14.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel14.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel14.Location = New System.Drawing.Point(0, 493)
        Me.GunaLabel14.Name = "GunaLabel14"
        Me.GunaLabel14.Size = New System.Drawing.Size(120, 21)
        Me.GunaLabel14.TabIndex = 20
        Me.GunaLabel14.Text = "Hold Items  [F7]"
        '
        'comPayment_method
        '
        Me.comPayment_method.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comPayment_method.BackColor = System.Drawing.Color.Transparent
        Me.comPayment_method.BaseColor = System.Drawing.Color.White
        Me.comPayment_method.BorderColor = System.Drawing.Color.Silver
        Me.comPayment_method.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comPayment_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPayment_method.FocusedColor = System.Drawing.Color.Empty
        Me.comPayment_method.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.comPayment_method.ForeColor = System.Drawing.Color.Black
        Me.comPayment_method.FormattingEnabled = True
        Me.comPayment_method.Items.AddRange(New Object() {"CASH", "CREDIT"})
        Me.comPayment_method.Location = New System.Drawing.Point(267, 403)
        Me.comPayment_method.Name = "comPayment_method"
        Me.comPayment_method.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comPayment_method.OnHoverItemForeColor = System.Drawing.Color.White
        Me.comPayment_method.Size = New System.Drawing.Size(250, 26)
        Me.comPayment_method.StartIndex = 0
        Me.comPayment_method.TabIndex = 19
        '
        'GunaLabel13
        '
        Me.GunaLabel13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel13.AutoSize = True
        Me.GunaLabel13.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel13.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel13.Location = New System.Drawing.Point(0, 403)
        Me.GunaLabel13.Name = "GunaLabel13"
        Me.GunaLabel13.Size = New System.Drawing.Size(163, 21)
        Me.GunaLabel13.TabIndex = 18
        Me.GunaLabel13.Text = "Payment Method  [F6]"
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel6.BackColor = System.Drawing.Color.DimGray
        Me.Panel6.Controls.Add(Me.lblnetTotal)
        Me.Panel6.Controls.Add(Me.GunaLabel9)
        Me.Panel6.Controls.Add(Me.lblItemsQty)
        Me.Panel6.Controls.Add(Me.GunaLabel8)
        Me.Panel6.Location = New System.Drawing.Point(-1, 249)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(520, 34)
        Me.Panel6.TabIndex = 11
        '
        'lblnetTotal
        '
        Me.lblnetTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblnetTotal.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblnetTotal.ForeColor = System.Drawing.Color.White
        Me.lblnetTotal.Location = New System.Drawing.Point(389, 4)
        Me.lblnetTotal.Name = "lblnetTotal"
        Me.lblnetTotal.Size = New System.Drawing.Size(132, 25)
        Me.lblnetTotal.TabIndex = 17
        Me.lblnetTotal.Text = "0.00"
        Me.lblnetTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GunaLabel9
        '
        Me.GunaLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel9.Location = New System.Drawing.Point(263, 7)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(42, 21)
        Me.GunaLabel9.TabIndex = 16
        Me.GunaLabel9.Text = "Total"
        '
        'lblItemsQty
        '
        Me.lblItemsQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblItemsQty.AutoSize = True
        Me.lblItemsQty.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblItemsQty.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblItemsQty.Location = New System.Drawing.Point(59, 5)
        Me.lblItemsQty.Name = "lblItemsQty"
        Me.lblItemsQty.Size = New System.Drawing.Size(52, 21)
        Me.lblItemsQty.TabIndex = 15
        Me.lblItemsQty.Text = "Items"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel8.Location = New System.Drawing.Point(5, 5)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(48, 21)
        Me.GunaLabel8.TabIndex = 14
        Me.GunaLabel8.Text = "Items"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Panel5.Controls.Add(Me.btnAdd_Customer)
        Me.Panel5.Controls.Add(Me.comSearch_customer)
        Me.Panel5.Controls.Add(Me.GunaLabel4)
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(520, 44)
        Me.Panel5.TabIndex = 10
        '
        'btnAdd_Customer
        '
        Me.btnAdd_Customer.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAdd_Customer.Image = CType(resources.GetObject("btnAdd_Customer.Image"), System.Drawing.Image)
        Me.btnAdd_Customer.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnAdd_Customer.Location = New System.Drawing.Point(480, 6)
        Me.btnAdd_Customer.Name = "btnAdd_Customer"
        Me.btnAdd_Customer.OnHoverImage = Nothing
        Me.btnAdd_Customer.OnHoverImageOffset = New System.Drawing.Point(0, 0)
        Me.btnAdd_Customer.Size = New System.Drawing.Size(36, 32)
        Me.btnAdd_Customer.TabIndex = 22
        Me.MetroToolTip1.SetToolTip(Me.btnAdd_Customer, "Add New Creadit Customer")
        '
        'comSearch_customer
        '
        Me.comSearch_customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comSearch_customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comSearch_customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.comSearch_customer.FormattingEnabled = True
        Me.comSearch_customer.Location = New System.Drawing.Point(213, 9)
        Me.comSearch_customer.Name = "comSearch_customer"
        Me.comSearch_customer.Size = New System.Drawing.Size(241, 25)
        Me.comSearch_customer.TabIndex = 10
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GunaLabel4.Location = New System.Drawing.Point(5, 10)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(78, 21)
        Me.GunaLabel4.TabIndex = 9
        Me.GunaLabel4.Text = "Customer"
        '
        'dgCart
        '
        Me.dgCart.AllowUserToAddRows = False
        Me.dgCart.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCart.BackgroundColor = System.Drawing.Color.White
        Me.dgCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column7, Me.Column10, Me.Column8, Me.Column9, Me.Column11, Me.Column12, Me.Column13})
        Me.dgCart.Location = New System.Drawing.Point(-3, 44)
        Me.dgCart.Name = "dgCart"
        Me.dgCart.RowHeadersVisible = False
        Me.dgCart.Size = New System.Drawing.Size(523, 206)
        Me.dgCart.TabIndex = 0
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Code"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 57
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column7.HeaderText = "Name"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Sell Price"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Visible = False
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column8.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column8.HeaderText = "Price"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 56
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Column9.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column9.HeaderText = "Qty"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 48
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column11.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column11.HeaderText = "Discount"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 74
        '
        'Column12
        '
        Me.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Column12.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column12.HeaderText = "Amount"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 68
        '
        'Column13
        '
        Me.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column13.HeaderText = ""
        Me.Column13.Image = CType(resources.GetObject("Column13.Image"), System.Drawing.Image)
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 5
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'frm_invoice
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1294, 728)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_invoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DgItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtSearch_items As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DgItems As DataGridView
    Friend WithEvents lblDate As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblInvoice As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnpay As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnHold As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnCancel As Guna.UI.WinForms.GunaButton
    Friend WithEvents dgCart As DataGridView
    Friend WithEvents lblUser As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblStore_name As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents GunaControlBox3 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents lblSelect_Item As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblnetTotal As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblItemsQty As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblGeand_total As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblTotal_discount As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents comPayment_method As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel13 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents comSearch_customer As ComboBox
    Friend WithEvents btnSettlement As Guna.UI.WinForms.GunaButton
    Friend WithEvents comHold_items As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel14 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel15 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnAdd_Customer As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewImageColumn
    Friend WithEvents lblPaid As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblbalance As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel18 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel19 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtpaid As TextBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents chkPrint As CheckBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents lblStatus As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnPrint_last As Guna.UI.WinForms.GunaButton
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaButton
    Friend WithEvents comInvoice As ComboBox
End Class
