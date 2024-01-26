<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bankreports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Bankreports))
        Me.Reportspanel1 = New System.Windows.Forms.Panel()
        Me.lblheadertext1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.edit_group_box = New System.Windows.Forms.GroupBox()
        Me.btnbankscancel = New System.Windows.Forms.Button()
        Me.btnbanksreports = New System.Windows.Forms.Button()
        Me.CdFromlbl = New System.Windows.Forms.Label()
        Me.cmbbankssupname = New System.Windows.Forms.ComboBox()
        Me.cmbbankssupcode = New System.Windows.Forms.ComboBox()
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
        Me.Reportspanel1.Controls.Add(Me.CdFromlbl)
        Me.Reportspanel1.Controls.Add(Me.cmbbankssupname)
        Me.Reportspanel1.Controls.Add(Me.cmbbankssupcode)
        Me.Reportspanel1.Controls.Add(Me.Panel3)
        Me.Reportspanel1.Location = New System.Drawing.Point(0, 1)
        Me.Reportspanel1.Name = "Reportspanel1"
        Me.Reportspanel1.Size = New System.Drawing.Size(421, 241)
        Me.Reportspanel1.TabIndex = 5
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
        Me.edit_group_box.Controls.Add(Me.btnbankscancel)
        Me.edit_group_box.Controls.Add(Me.btnbanksreports)
        Me.edit_group_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_group_box.ForeColor = System.Drawing.Color.Black
        Me.edit_group_box.Location = New System.Drawing.Point(19, 158)
        Me.edit_group_box.Name = "edit_group_box"
        Me.edit_group_box.Size = New System.Drawing.Size(383, 65)
        Me.edit_group_box.TabIndex = 33
        Me.edit_group_box.TabStop = False
        Me.edit_group_box.Text = "Report | Cancel"
        '
        'btnbankscancel
        '
        Me.btnbankscancel.BackColor = System.Drawing.Color.Red
        Me.btnbankscancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbankscancel.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnbankscancel.FlatAppearance.BorderSize = 0
        Me.btnbankscancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnbankscancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnbankscancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbankscancel.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbankscancel.ForeColor = System.Drawing.Color.White
        Me.btnbankscancel.Location = New System.Drawing.Point(248, 22)
        Me.btnbankscancel.Name = "btnbankscancel"
        Me.btnbankscancel.Size = New System.Drawing.Size(101, 30)
        Me.btnbankscancel.TabIndex = 24
        Me.btnbankscancel.Text = "Cancel"
        Me.btnbankscancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnbankscancel.UseVisualStyleBackColor = False
        '
        'btnbanksreports
        '
        Me.btnbanksreports.BackColor = System.Drawing.Color.LimeGreen
        Me.btnbanksreports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbanksreports.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnbanksreports.FlatAppearance.BorderSize = 0
        Me.btnbanksreports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnbanksreports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnbanksreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbanksreports.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbanksreports.ForeColor = System.Drawing.Color.White
        Me.btnbanksreports.Location = New System.Drawing.Point(26, 22)
        Me.btnbanksreports.Name = "btnbanksreports"
        Me.btnbanksreports.Size = New System.Drawing.Size(101, 30)
        Me.btnbanksreports.TabIndex = 23
        Me.btnbanksreports.Text = "Report"
        Me.btnbanksreports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnbanksreports.UseVisualStyleBackColor = False
        '
        'CdFromlbl
        '
        Me.CdFromlbl.AutoSize = True
        Me.CdFromlbl.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CdFromlbl.Location = New System.Drawing.Point(15, 113)
        Me.CdFromlbl.Name = "CdFromlbl"
        Me.CdFromlbl.Size = New System.Drawing.Size(72, 21)
        Me.CdFromlbl.TabIndex = 29
        Me.CdFromlbl.Text = "Supplier"
        '
        'cmbbankssupname
        '
        Me.cmbbankssupname.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbankssupname.FormattingEnabled = True
        Me.cmbbankssupname.Location = New System.Drawing.Point(199, 109)
        Me.cmbbankssupname.Name = "cmbbankssupname"
        Me.cmbbankssupname.Size = New System.Drawing.Size(203, 29)
        Me.cmbbankssupname.TabIndex = 26
        '
        'cmbbankssupcode
        '
        Me.cmbbankssupcode.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbankssupcode.FormattingEnabled = True
        Me.cmbbankssupcode.Location = New System.Drawing.Point(100, 109)
        Me.cmbbankssupcode.Name = "cmbbankssupcode"
        Me.cmbbankssupcode.Size = New System.Drawing.Size(91, 29)
        Me.cmbbankssupcode.Sorted = True
        Me.cmbbankssupcode.TabIndex = 25
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
        Me.Panel3.Size = New System.Drawing.Size(421, 48)
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
        Me.Label4.Size = New System.Drawing.Size(144, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Banks Report"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(64, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(314, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Search Your Suppliers Bank Details Reports here"
        '
        'Bankreports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 243)
        Me.Controls.Add(Me.Reportspanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Bankreports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bankreports"
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
    Friend WithEvents btnbankscancel As System.Windows.Forms.Button
    Friend WithEvents btnbanksreports As System.Windows.Forms.Button
    Friend WithEvents CdFromlbl As System.Windows.Forms.Label
    Friend WithEvents cmbbankssupname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbbankssupcode As System.Windows.Forms.ComboBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
