<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reports))
        Me.Reportspanel1 = New System.Windows.Forms.Panel()
        Me.lblheadertext1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.edit_group_box = New System.Windows.Forms.GroupBox()
        Me.btnreportscancel1 = New System.Windows.Forms.Button()
        Me.btnreportsdisplay1 = New System.Windows.Forms.Button()
        Me.dpreports1to = New System.Windows.Forms.DateTimePicker()
        Me.dpreports1from = New System.Windows.Forms.DateTimePicker()
        Me.cmbreportsfromname = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Reportspanel2 = New System.Windows.Forms.Panel()
        Me.cmbreportdocno = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblheadertext2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnreportscacel2 = New System.Windows.Forms.Button()
        Me.btnreportsdisplay2 = New System.Windows.Forms.Button()
        Me.dpreports2to = New System.Windows.Forms.DateTimePicker()
        Me.dpreportsp2from = New System.Windows.Forms.DateTimePicker()
        Me.Reportpanel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CdFromlbl = New System.Windows.Forms.Label()
        Me.cmbreportsfromcode = New System.Windows.Forms.ComboBox()
        Me.cmbreportstocode = New System.Windows.Forms.ComboBox()
        Me.CdTolbl = New System.Windows.Forms.Label()
        Me.cmbreportstoname = New System.Windows.Forms.ComboBox()
        Me.Reportspanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.edit_group_box.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Reportspanel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Reportpanel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Reportspanel1
        '
        Me.Reportspanel1.BackColor = System.Drawing.Color.White
        Me.Reportspanel1.Controls.Add(Me.lblheadertext1)
        Me.Reportspanel1.Controls.Add(Me.PictureBox1)
        Me.Reportspanel1.Controls.Add(Me.edit_group_box)
        Me.Reportspanel1.Controls.Add(Me.dpreports1to)
        Me.Reportspanel1.Controls.Add(Me.dpreports1from)
        Me.Reportspanel1.Controls.Add(Me.CdTolbl)
        Me.Reportspanel1.Controls.Add(Me.CdFromlbl)
        Me.Reportspanel1.Controls.Add(Me.cmbreportstoname)
        Me.Reportspanel1.Controls.Add(Me.cmbreportstocode)
        Me.Reportspanel1.Controls.Add(Me.cmbreportsfromname)
        Me.Reportspanel1.Controls.Add(Me.cmbreportsfromcode)
        Me.Reportspanel1.Controls.Add(Me.Panel3)
        Me.Reportspanel1.Location = New System.Drawing.Point(0, 0)
        Me.Reportspanel1.Name = "Reportspanel1"
        Me.Reportspanel1.Size = New System.Drawing.Size(430, 319)
        Me.Reportspanel1.TabIndex = 3
        '
        'lblheadertext1
        '
        Me.lblheadertext1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheadertext1.ForeColor = System.Drawing.Color.Black
        Me.lblheadertext1.Location = New System.Drawing.Point(69, 60)
        Me.lblheadertext1.Name = "lblheadertext1"
        Me.lblheadertext1.Size = New System.Drawing.Size(339, 26)
        Me.lblheadertext1.TabIndex = 36
        Me.lblheadertext1.Text = "N/A"
        Me.lblheadertext1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'edit_group_box
        '
        Me.edit_group_box.Controls.Add(Me.btnreportscancel1)
        Me.edit_group_box.Controls.Add(Me.btnreportsdisplay1)
        Me.edit_group_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_group_box.ForeColor = System.Drawing.Color.Black
        Me.edit_group_box.Location = New System.Drawing.Point(22, 249)
        Me.edit_group_box.Name = "edit_group_box"
        Me.edit_group_box.Size = New System.Drawing.Size(376, 65)
        Me.edit_group_box.TabIndex = 33
        Me.edit_group_box.TabStop = False
        Me.edit_group_box.Text = "Report | Cancel"
        '
        'btnreportscancel1
        '
        Me.btnreportscancel1.BackColor = System.Drawing.Color.Red
        Me.btnreportscancel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreportscancel1.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnreportscancel1.FlatAppearance.BorderSize = 0
        Me.btnreportscancel1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnreportscancel1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnreportscancel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportscancel1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreportscancel1.ForeColor = System.Drawing.Color.White
        Me.btnreportscancel1.Location = New System.Drawing.Point(248, 22)
        Me.btnreportscancel1.Name = "btnreportscancel1"
        Me.btnreportscancel1.Size = New System.Drawing.Size(101, 30)
        Me.btnreportscancel1.TabIndex = 24
        Me.btnreportscancel1.Text = "Cancel"
        Me.btnreportscancel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnreportscancel1.UseVisualStyleBackColor = False
        '
        'btnreportsdisplay1
        '
        Me.btnreportsdisplay1.BackColor = System.Drawing.Color.LimeGreen
        Me.btnreportsdisplay1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreportsdisplay1.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnreportsdisplay1.FlatAppearance.BorderSize = 0
        Me.btnreportsdisplay1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnreportsdisplay1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnreportsdisplay1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportsdisplay1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreportsdisplay1.ForeColor = System.Drawing.Color.White
        Me.btnreportsdisplay1.Location = New System.Drawing.Point(26, 22)
        Me.btnreportsdisplay1.Name = "btnreportsdisplay1"
        Me.btnreportsdisplay1.Size = New System.Drawing.Size(101, 30)
        Me.btnreportsdisplay1.TabIndex = 23
        Me.btnreportsdisplay1.Text = "Report"
        Me.btnreportsdisplay1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnreportsdisplay1.UseVisualStyleBackColor = False
        '
        'dpreports1to
        '
        Me.dpreports1to.CustomFormat = "yyyy-MMM-dd"
        Me.dpreports1to.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpreports1to.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpreports1to.Location = New System.Drawing.Point(253, 194)
        Me.dpreports1to.Name = "dpreports1to"
        Me.dpreports1to.Size = New System.Drawing.Size(145, 26)
        Me.dpreports1to.TabIndex = 32
        '
        'dpreports1from
        '
        Me.dpreports1from.CustomFormat = "yyyy-MMM-dd"
        Me.dpreports1from.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpreports1from.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpreports1from.Location = New System.Drawing.Point(72, 194)
        Me.dpreports1from.Name = "dpreports1from"
        Me.dpreports1from.Size = New System.Drawing.Size(146, 26)
        Me.dpreports1from.TabIndex = 31
        '
        'cmbreportsfromname
        '
        Me.cmbreportsfromname.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbreportsfromname.FormattingEnabled = True
        Me.cmbreportsfromname.Location = New System.Drawing.Point(195, 101)
        Me.cmbreportsfromname.Name = "cmbreportsfromname"
        Me.cmbreportsfromname.Size = New System.Drawing.Size(203, 29)
        Me.cmbreportsfromname.TabIndex = 26
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(430, 48)
        Me.Panel3.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(14, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(62, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(64, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Search Your  Reports With From | To"
        '
        'Reportspanel2
        '
        Me.Reportspanel2.BackColor = System.Drawing.Color.White
        Me.Reportspanel2.Controls.Add(Me.cmbreportdocno)
        Me.Reportspanel2.Controls.Add(Me.Label5)
        Me.Reportspanel2.Controls.Add(Me.PictureBox3)
        Me.Reportspanel2.Controls.Add(Me.lblheadertext2)
        Me.Reportspanel2.Controls.Add(Me.GroupBox1)
        Me.Reportspanel2.Controls.Add(Me.dpreports2to)
        Me.Reportspanel2.Controls.Add(Me.dpreportsp2from)
        Me.Reportspanel2.Controls.Add(Me.Reportpanel2)
        Me.Reportspanel2.Location = New System.Drawing.Point(2, 1)
        Me.Reportspanel2.Name = "Reportspanel2"
        Me.Reportspanel2.Size = New System.Drawing.Size(431, 318)
        Me.Reportspanel2.TabIndex = 4
        '
        'cmbreportdocno
        '
        Me.cmbreportdocno.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbreportdocno.FormattingEnabled = True
        Me.cmbreportdocno.Location = New System.Drawing.Point(216, 126)
        Me.cmbreportdocno.Name = "cmbreportdocno"
        Me.cmbreportdocno.Size = New System.Drawing.Size(123, 29)
        Me.cmbreportdocno.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(115, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 21)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Doc No  :  "
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(15, 50)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(45, 42)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'lblheadertext2
        '
        Me.lblheadertext2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheadertext2.ForeColor = System.Drawing.Color.Black
        Me.lblheadertext2.Location = New System.Drawing.Point(73, 58)
        Me.lblheadertext2.Name = "lblheadertext2"
        Me.lblheadertext2.Size = New System.Drawing.Size(339, 26)
        Me.lblheadertext2.TabIndex = 34
        Me.lblheadertext2.Text = "N/A"
        Me.lblheadertext2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnreportscacel2)
        Me.GroupBox1.Controls.Add(Me.btnreportsdisplay2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(22, 249)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 65)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report | Cancel"
        '
        'btnreportscacel2
        '
        Me.btnreportscacel2.BackColor = System.Drawing.Color.Red
        Me.btnreportscacel2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreportscacel2.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnreportscacel2.FlatAppearance.BorderSize = 0
        Me.btnreportscacel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnreportscacel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnreportscacel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportscacel2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreportscacel2.ForeColor = System.Drawing.Color.White
        Me.btnreportscacel2.Location = New System.Drawing.Point(248, 22)
        Me.btnreportscacel2.Name = "btnreportscacel2"
        Me.btnreportscacel2.Size = New System.Drawing.Size(101, 30)
        Me.btnreportscacel2.TabIndex = 24
        Me.btnreportscacel2.Text = "Cancel"
        Me.btnreportscacel2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnreportscacel2.UseVisualStyleBackColor = False
        '
        'btnreportsdisplay2
        '
        Me.btnreportsdisplay2.BackColor = System.Drawing.Color.LimeGreen
        Me.btnreportsdisplay2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreportsdisplay2.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnreportsdisplay2.FlatAppearance.BorderSize = 0
        Me.btnreportsdisplay2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnreportsdisplay2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnreportsdisplay2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportsdisplay2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreportsdisplay2.ForeColor = System.Drawing.Color.White
        Me.btnreportsdisplay2.Location = New System.Drawing.Point(26, 22)
        Me.btnreportsdisplay2.Name = "btnreportsdisplay2"
        Me.btnreportsdisplay2.Size = New System.Drawing.Size(101, 30)
        Me.btnreportsdisplay2.TabIndex = 23
        Me.btnreportsdisplay2.Text = "Report"
        Me.btnreportsdisplay2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnreportsdisplay2.UseVisualStyleBackColor = False
        '
        'dpreports2to
        '
        Me.dpreports2to.CustomFormat = "yyyy-MMM-dd"
        Me.dpreports2to.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpreports2to.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpreports2to.Location = New System.Drawing.Point(253, 194)
        Me.dpreports2to.Name = "dpreports2to"
        Me.dpreports2to.Size = New System.Drawing.Size(145, 26)
        Me.dpreports2to.TabIndex = 32
        '
        'dpreportsp2from
        '
        Me.dpreportsp2from.CustomFormat = "yyyy-MMM-dd"
        Me.dpreportsp2from.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpreportsp2from.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpreportsp2from.Location = New System.Drawing.Point(72, 194)
        Me.dpreportsp2from.Name = "dpreportsp2from"
        Me.dpreportsp2from.Size = New System.Drawing.Size(146, 26)
        Me.dpreportsp2from.TabIndex = 31
        '
        'Reportpanel2
        '
        Me.Reportpanel2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Reportpanel2.Controls.Add(Me.Label8)
        Me.Reportpanel2.Controls.Add(Me.PictureBox4)
        Me.Reportpanel2.Controls.Add(Me.Label7)
        Me.Reportpanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Reportpanel2.Location = New System.Drawing.Point(0, 0)
        Me.Reportpanel2.Name = "Reportpanel2"
        Me.Reportpanel2.Size = New System.Drawing.Size(431, 48)
        Me.Reportpanel2.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(65, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(256, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Search Your Reports With Document No"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(14, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(45, 42)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(62, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 26)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Report"
        '
        'CdFromlbl
        '
        Me.CdFromlbl.AutoSize = True
        Me.CdFromlbl.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CdFromlbl.Location = New System.Drawing.Point(18, 104)
        Me.CdFromlbl.Name = "CdFromlbl"
        Me.CdFromlbl.Size = New System.Drawing.Size(49, 21)
        Me.CdFromlbl.TabIndex = 29
        Me.CdFromlbl.Text = "From"
        '
        'cmbreportsfromcode
        '
        Me.cmbreportsfromcode.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbreportsfromcode.FormattingEnabled = True
        Me.cmbreportsfromcode.Location = New System.Drawing.Point(73, 101)
        Me.cmbreportsfromcode.Name = "cmbreportsfromcode"
        Me.cmbreportsfromcode.Size = New System.Drawing.Size(91, 29)
        Me.cmbreportsfromcode.Sorted = True
        Me.cmbreportsfromcode.TabIndex = 25
        '
        'cmbreportstocode
        '
        Me.cmbreportstocode.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbreportstocode.FormattingEnabled = True
        Me.cmbreportstocode.Location = New System.Drawing.Point(73, 142)
        Me.cmbreportstocode.Name = "cmbreportstocode"
        Me.cmbreportstocode.Size = New System.Drawing.Size(90, 29)
        Me.cmbreportstocode.Sorted = True
        Me.cmbreportstocode.TabIndex = 27
        '
        'CdTolbl
        '
        Me.CdTolbl.AutoSize = True
        Me.CdTolbl.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CdTolbl.Location = New System.Drawing.Point(18, 145)
        Me.CdTolbl.Name = "CdTolbl"
        Me.CdTolbl.Size = New System.Drawing.Size(28, 21)
        Me.CdTolbl.TabIndex = 30
        Me.CdTolbl.Text = "To"
        '
        'cmbreportstoname
        '
        Me.cmbreportstoname.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbreportstoname.FormattingEnabled = True
        Me.cmbreportstoname.Location = New System.Drawing.Point(195, 142)
        Me.cmbreportstoname.Name = "cmbreportstoname"
        Me.cmbreportstoname.Size = New System.Drawing.Size(203, 29)
        Me.cmbreportstoname.TabIndex = 28
        '
        'Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 331)
        Me.Controls.Add(Me.Reportspanel1)
        Me.Controls.Add(Me.Reportspanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.Reportspanel1.ResumeLayout(False)
        Me.Reportspanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.edit_group_box.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Reportspanel2.ResumeLayout(False)
        Me.Reportspanel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Reportpanel2.ResumeLayout(False)
        Me.Reportpanel2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Reportspanel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dpreports1to As System.Windows.Forms.DateTimePicker
    Friend WithEvents dpreports1from As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbreportsfromname As System.Windows.Forms.ComboBox
    Friend WithEvents edit_group_box As System.Windows.Forms.GroupBox
    Friend WithEvents btnreportscancel1 As System.Windows.Forms.Button
    Friend WithEvents btnreportsdisplay1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Reportspanel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblheadertext2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnreportscacel2 As System.Windows.Forms.Button
    Friend WithEvents btnreportsdisplay2 As System.Windows.Forms.Button
    Friend WithEvents dpreports2to As System.Windows.Forms.DateTimePicker
    Friend WithEvents dpreportsp2from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Reportpanel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbreportdocno As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblheadertext1 As System.Windows.Forms.Label
    Friend WithEvents CdFromlbl As Label
    Friend WithEvents CdTolbl As Label
    Friend WithEvents cmbreportstoname As ComboBox
    Friend WithEvents cmbreportstocode As ComboBox
    Friend WithEvents cmbreportsfromcode As ComboBox
End Class
