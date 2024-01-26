<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lossprofitreports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lossprofitreports))
        Me.Reportspanel1 = New System.Windows.Forms.Panel()
        Me.lblheadertext1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.edit_group_box = New System.Windows.Forms.GroupBox()
        Me.btnexpiredcancel = New System.Windows.Forms.Button()
        Me.btnexpiredreport = New System.Windows.Forms.Button()
        Me.dpexpiredto = New System.Windows.Forms.DateTimePicker()
        Me.dpexpiredfrom = New System.Windows.Forms.DateTimePicker()
        Me.CdTolbl = New System.Windows.Forms.Label()
        Me.CdFromlbl = New System.Windows.Forms.Label()
        Me.cmbexpiredtoname = New System.Windows.Forms.ComboBox()
        Me.cmbexpiredtocode = New System.Windows.Forms.ComboBox()
        Me.cmbexpiredfromname = New System.Windows.Forms.ComboBox()
        Me.cmbexpiredformcode = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Reportspanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.edit_group_box.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Reportspanel1
        '
        Me.Reportspanel1.BackColor = System.Drawing.Color.White
        Me.Reportspanel1.Controls.Add(Me.lblheadertext1)
        Me.Reportspanel1.Controls.Add(Me.PictureBox1)
        Me.Reportspanel1.Controls.Add(Me.edit_group_box)
        Me.Reportspanel1.Controls.Add(Me.dpexpiredto)
        Me.Reportspanel1.Controls.Add(Me.dpexpiredfrom)
        Me.Reportspanel1.Controls.Add(Me.CdTolbl)
        Me.Reportspanel1.Controls.Add(Me.CdFromlbl)
        Me.Reportspanel1.Controls.Add(Me.cmbexpiredtoname)
        Me.Reportspanel1.Controls.Add(Me.cmbexpiredtocode)
        Me.Reportspanel1.Controls.Add(Me.cmbexpiredfromname)
        Me.Reportspanel1.Controls.Add(Me.cmbexpiredformcode)
        Me.Reportspanel1.Controls.Add(Me.Panel3)
        Me.Reportspanel1.Location = New System.Drawing.Point(2, 2)
        Me.Reportspanel1.Name = "Reportspanel1"
        Me.Reportspanel1.Size = New System.Drawing.Size(464, 329)
        Me.Reportspanel1.TabIndex = 6
        '
        'lblheadertext1
        '
        Me.lblheadertext1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheadertext1.ForeColor = System.Drawing.Color.Black
        Me.lblheadertext1.Location = New System.Drawing.Point(69, 58)
        Me.lblheadertext1.Name = "lblheadertext1"
        Me.lblheadertext1.Size = New System.Drawing.Size(368, 26)
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
        Me.edit_group_box.Controls.Add(Me.btnexpiredcancel)
        Me.edit_group_box.Controls.Add(Me.btnexpiredreport)
        Me.edit_group_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_group_box.ForeColor = System.Drawing.Color.Black
        Me.edit_group_box.Location = New System.Drawing.Point(22, 249)
        Me.edit_group_box.Name = "edit_group_box"
        Me.edit_group_box.Size = New System.Drawing.Size(415, 65)
        Me.edit_group_box.TabIndex = 33
        Me.edit_group_box.TabStop = False
        Me.edit_group_box.Text = "Report | Cancel"
        '
        'btnexpiredcancel
        '
        Me.btnexpiredcancel.BackColor = System.Drawing.Color.Red
        Me.btnexpiredcancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexpiredcancel.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnexpiredcancel.FlatAppearance.BorderSize = 0
        Me.btnexpiredcancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnexpiredcancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnexpiredcancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexpiredcancel.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexpiredcancel.ForeColor = System.Drawing.Color.White
        Me.btnexpiredcancel.Location = New System.Drawing.Point(285, 22)
        Me.btnexpiredcancel.Name = "btnexpiredcancel"
        Me.btnexpiredcancel.Size = New System.Drawing.Size(101, 30)
        Me.btnexpiredcancel.TabIndex = 24
        Me.btnexpiredcancel.Text = "Cancel"
        Me.btnexpiredcancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnexpiredcancel.UseVisualStyleBackColor = False
        '
        'btnexpiredreport
        '
        Me.btnexpiredreport.BackColor = System.Drawing.Color.LimeGreen
        Me.btnexpiredreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexpiredreport.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnexpiredreport.FlatAppearance.BorderSize = 0
        Me.btnexpiredreport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnexpiredreport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnexpiredreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexpiredreport.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexpiredreport.ForeColor = System.Drawing.Color.White
        Me.btnexpiredreport.Location = New System.Drawing.Point(26, 22)
        Me.btnexpiredreport.Name = "btnexpiredreport"
        Me.btnexpiredreport.Size = New System.Drawing.Size(101, 30)
        Me.btnexpiredreport.TabIndex = 23
        Me.btnexpiredreport.Text = "Report"
        Me.btnexpiredreport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnexpiredreport.UseVisualStyleBackColor = False
        '
        'dpexpiredto
        '
        Me.dpexpiredto.CustomFormat = "yyyy-MMM-dd"
        Me.dpexpiredto.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpexpiredto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpexpiredto.Location = New System.Drawing.Point(292, 194)
        Me.dpexpiredto.Name = "dpexpiredto"
        Me.dpexpiredto.Size = New System.Drawing.Size(145, 26)
        Me.dpexpiredto.TabIndex = 32
        '
        'dpexpiredfrom
        '
        Me.dpexpiredfrom.CustomFormat = "yyyy-MMM-dd"
        Me.dpexpiredfrom.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpexpiredfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpexpiredfrom.Location = New System.Drawing.Point(22, 194)
        Me.dpexpiredfrom.Name = "dpexpiredfrom"
        Me.dpexpiredfrom.Size = New System.Drawing.Size(146, 26)
        Me.dpexpiredfrom.TabIndex = 31
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
        'cmbexpiredtoname
        '
        Me.cmbexpiredtoname.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbexpiredtoname.FormattingEnabled = True
        Me.cmbexpiredtoname.Location = New System.Drawing.Point(195, 142)
        Me.cmbexpiredtoname.Name = "cmbexpiredtoname"
        Me.cmbexpiredtoname.Size = New System.Drawing.Size(242, 29)
        Me.cmbexpiredtoname.TabIndex = 28
        '
        'cmbexpiredtocode
        '
        Me.cmbexpiredtocode.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbexpiredtocode.FormattingEnabled = True
        Me.cmbexpiredtocode.Location = New System.Drawing.Point(73, 142)
        Me.cmbexpiredtocode.Name = "cmbexpiredtocode"
        Me.cmbexpiredtocode.Size = New System.Drawing.Size(90, 29)
        Me.cmbexpiredtocode.Sorted = True
        Me.cmbexpiredtocode.TabIndex = 27
        '
        'cmbexpiredfromname
        '
        Me.cmbexpiredfromname.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbexpiredfromname.FormattingEnabled = True
        Me.cmbexpiredfromname.Location = New System.Drawing.Point(195, 101)
        Me.cmbexpiredfromname.Name = "cmbexpiredfromname"
        Me.cmbexpiredfromname.Size = New System.Drawing.Size(242, 29)
        Me.cmbexpiredfromname.TabIndex = 26
        '
        'cmbexpiredformcode
        '
        Me.cmbexpiredformcode.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbexpiredformcode.FormattingEnabled = True
        Me.cmbexpiredformcode.Location = New System.Drawing.Point(73, 101)
        Me.cmbexpiredformcode.Name = "cmbexpiredformcode"
        Me.cmbexpiredformcode.Size = New System.Drawing.Size(91, 29)
        Me.cmbexpiredformcode.Sorted = True
        Me.cmbexpiredformcode.TabIndex = 25
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
        Me.Panel3.Size = New System.Drawing.Size(464, 48)
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
        Me.Label4.Size = New System.Drawing.Size(189, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Loss Profit Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(65, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(252, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Search Your Loss Or Non Profit Reports"
        '
        'Lossprofitreports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 334)
        Me.Controls.Add(Me.Reportspanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Lossprofitreports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loss Or Non Profit Reports"
        Me.Reportspanel1.ResumeLayout(False)
        Me.Reportspanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.edit_group_box.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Reportspanel1 As System.Windows.Forms.Panel
    Friend WithEvents lblheadertext1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents edit_group_box As System.Windows.Forms.GroupBox
    Friend WithEvents btnexpiredcancel As System.Windows.Forms.Button
    Friend WithEvents btnexpiredreport As System.Windows.Forms.Button
    Friend WithEvents dpexpiredto As System.Windows.Forms.DateTimePicker
    Friend WithEvents dpexpiredfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents CdTolbl As System.Windows.Forms.Label
    Friend WithEvents CdFromlbl As System.Windows.Forms.Label
    Friend WithEvents cmbexpiredtoname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbexpiredtocode As System.Windows.Forms.ComboBox
    Friend WithEvents cmbexpiredfromname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbexpiredformcode As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
