<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_report_detail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_report_detail))
        Me.Reportspanel1 = New System.Windows.Forms.Panel()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.edit_group_box = New System.Windows.Forms.GroupBox()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.CdTolbl = New System.Windows.Forms.Label()
        Me.CdFromlbl = New System.Windows.Forms.Label()
        Me.comTo_name = New System.Windows.Forms.ComboBox()
        Me.ComFrom_name = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fromdtp = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.todtp = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.comCode_from = New Guna.UI.WinForms.GunaComboBox()
        Me.Comcode_to = New Guna.UI.WinForms.GunaComboBox()
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
        Me.Reportspanel1.Controls.Add(Me.Comcode_to)
        Me.Reportspanel1.Controls.Add(Me.comCode_from)
        Me.Reportspanel1.Controls.Add(Me.todtp)
        Me.Reportspanel1.Controls.Add(Me.fromdtp)
        Me.Reportspanel1.Controls.Add(Me.lbltitle)
        Me.Reportspanel1.Controls.Add(Me.PictureBox1)
        Me.Reportspanel1.Controls.Add(Me.edit_group_box)
        Me.Reportspanel1.Controls.Add(Me.CdTolbl)
        Me.Reportspanel1.Controls.Add(Me.CdFromlbl)
        Me.Reportspanel1.Controls.Add(Me.comTo_name)
        Me.Reportspanel1.Controls.Add(Me.ComFrom_name)
        Me.Reportspanel1.Controls.Add(Me.Panel3)
        Me.Reportspanel1.Location = New System.Drawing.Point(0, 1)
        Me.Reportspanel1.Name = "Reportspanel1"
        Me.Reportspanel1.Size = New System.Drawing.Size(430, 319)
        Me.Reportspanel1.TabIndex = 4
        '
        'lbltitle
        '
        Me.lbltitle.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.Black
        Me.lbltitle.Location = New System.Drawing.Point(69, 60)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(339, 26)
        Me.lbltitle.TabIndex = 36
        Me.lbltitle.Text = "N/A"
        Me.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.edit_group_box.Controls.Add(Me.btncancel)
        Me.edit_group_box.Controls.Add(Me.btnReport)
        Me.edit_group_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_group_box.ForeColor = System.Drawing.Color.Black
        Me.edit_group_box.Location = New System.Drawing.Point(22, 249)
        Me.edit_group_box.Name = "edit_group_box"
        Me.edit_group_box.Size = New System.Drawing.Size(376, 65)
        Me.edit_group_box.TabIndex = 33
        Me.edit_group_box.TabStop = False
        Me.edit_group_box.Text = "Report | Cancel"
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.Red
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btncancel.FlatAppearance.BorderSize = 0
        Me.btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(248, 22)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(101, 30)
        Me.btncancel.TabIndex = 24
        Me.btncancel.Text = "Cancel"
        Me.btncancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnReport
        '
        Me.btnReport.BackColor = System.Drawing.Color.LimeGreen
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Location = New System.Drawing.Point(26, 22)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(101, 30)
        Me.btnReport.TabIndex = 23
        Me.btnReport.Text = "Report"
        Me.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnReport.UseVisualStyleBackColor = False
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
        'comTo_name
        '
        Me.comTo_name.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comTo_name.FormattingEnabled = True
        Me.comTo_name.Location = New System.Drawing.Point(195, 142)
        Me.comTo_name.Name = "comTo_name"
        Me.comTo_name.Size = New System.Drawing.Size(203, 29)
        Me.comTo_name.TabIndex = 28
        '
        'ComFrom_name
        '
        Me.ComFrom_name.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComFrom_name.FormattingEnabled = True
        Me.ComFrom_name.Location = New System.Drawing.Point(195, 101)
        Me.ComFrom_name.Name = "ComFrom_name"
        Me.ComFrom_name.Size = New System.Drawing.Size(203, 29)
        Me.ComFrom_name.TabIndex = 26
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
        'fromdtp
        '
        Me.fromdtp.BaseColor = System.Drawing.Color.White
        Me.fromdtp.BorderColor = System.Drawing.Color.Silver
        Me.fromdtp.CustomFormat = Nothing
        Me.fromdtp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.fromdtp.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fromdtp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.fromdtp.ForeColor = System.Drawing.Color.Black
        Me.fromdtp.Location = New System.Drawing.Point(73, 201)
        Me.fromdtp.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.fromdtp.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.fromdtp.Name = "fromdtp"
        Me.fromdtp.OnHoverBaseColor = System.Drawing.Color.White
        Me.fromdtp.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fromdtp.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fromdtp.OnPressedColor = System.Drawing.Color.Black
        Me.fromdtp.Size = New System.Drawing.Size(161, 30)
        Me.fromdtp.TabIndex = 37
        Me.fromdtp.Text = "29 March 2021"
        Me.fromdtp.Value = New Date(2021, 3, 29, 15, 48, 29, 177)
        '
        'todtp
        '
        Me.todtp.BaseColor = System.Drawing.Color.White
        Me.todtp.BorderColor = System.Drawing.Color.Silver
        Me.todtp.CustomFormat = Nothing
        Me.todtp.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.todtp.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.todtp.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.todtp.ForeColor = System.Drawing.Color.Black
        Me.todtp.Location = New System.Drawing.Point(240, 201)
        Me.todtp.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.todtp.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.todtp.Name = "todtp"
        Me.todtp.OnHoverBaseColor = System.Drawing.Color.White
        Me.todtp.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.todtp.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.todtp.OnPressedColor = System.Drawing.Color.Black
        Me.todtp.Size = New System.Drawing.Size(158, 30)
        Me.todtp.TabIndex = 38
        Me.todtp.Text = "29 March 2021"
        Me.todtp.Value = New Date(2021, 3, 29, 15, 48, 29, 177)
        '
        'comCode_from
        '
        Me.comCode_from.BackColor = System.Drawing.Color.Transparent
        Me.comCode_from.BaseColor = System.Drawing.Color.White
        Me.comCode_from.BorderColor = System.Drawing.Color.Silver
        Me.comCode_from.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comCode_from.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comCode_from.FocusedColor = System.Drawing.Color.Empty
        Me.comCode_from.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.comCode_from.ForeColor = System.Drawing.Color.Black
        Me.comCode_from.FormattingEnabled = True
        Me.comCode_from.Location = New System.Drawing.Point(73, 100)
        Me.comCode_from.Name = "comCode_from"
        Me.comCode_from.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comCode_from.OnHoverItemForeColor = System.Drawing.Color.White
        Me.comCode_from.Size = New System.Drawing.Size(94, 30)
        Me.comCode_from.TabIndex = 39
        '
        'Comcode_to
        '
        Me.Comcode_to.BackColor = System.Drawing.Color.Transparent
        Me.Comcode_to.BaseColor = System.Drawing.Color.White
        Me.Comcode_to.BorderColor = System.Drawing.Color.Silver
        Me.Comcode_to.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.Comcode_to.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Comcode_to.FocusedColor = System.Drawing.Color.Empty
        Me.Comcode_to.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Comcode_to.ForeColor = System.Drawing.Color.Black
        Me.Comcode_to.FormattingEnabled = True
        Me.Comcode_to.Location = New System.Drawing.Point(73, 142)
        Me.Comcode_to.Name = "Comcode_to"
        Me.Comcode_to.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Comcode_to.OnHoverItemForeColor = System.Drawing.Color.White
        Me.Comcode_to.Size = New System.Drawing.Size(94, 30)
        Me.Comcode_to.TabIndex = 40
        '
        'frm_report_detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 315)
        Me.Controls.Add(Me.Reportspanel1)
        Me.Name = "frm_report_detail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.Reportspanel1.ResumeLayout(False)
        Me.Reportspanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.edit_group_box.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Reportspanel1 As Panel
    Friend WithEvents lbltitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents edit_group_box As GroupBox
    Friend WithEvents btncancel As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents CdTolbl As Label
    Friend WithEvents CdFromlbl As Label
    Friend WithEvents comTo_name As ComboBox
    Friend WithEvents ComFrom_name As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents todtp As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents fromdtp As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents Comcode_to As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents comCode_from As Guna.UI.WinForms.GunaComboBox
End Class
