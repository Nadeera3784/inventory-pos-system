<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Statement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Statement))
        Me.Reportspanel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.comcode = New Guna.UI.WinForms.GunaComboBox()
        Me.CdFromlbl = New System.Windows.Forms.Label()
        Me.comname = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.edit_group_box = New System.Windows.Forms.GroupBox()
        Me.btnreportscancel1 = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Reportspanel1.Controls.Add(Me.Label5)
        Me.Reportspanel1.Controls.Add(Me.comcode)
        Me.Reportspanel1.Controls.Add(Me.CdFromlbl)
        Me.Reportspanel1.Controls.Add(Me.comname)
        Me.Reportspanel1.Controls.Add(Me.Label3)
        Me.Reportspanel1.Controls.Add(Me.Label1)
        Me.Reportspanel1.Controls.Add(Me.lblTitle)
        Me.Reportspanel1.Controls.Add(Me.PictureBox1)
        Me.Reportspanel1.Controls.Add(Me.edit_group_box)
        Me.Reportspanel1.Controls.Add(Me.dtpTo)
        Me.Reportspanel1.Controls.Add(Me.dtpFrom)
        Me.Reportspanel1.Controls.Add(Me.Panel3)
        Me.Reportspanel1.Location = New System.Drawing.Point(1, 0)
        Me.Reportspanel1.Name = "Reportspanel1"
        Me.Reportspanel1.Size = New System.Drawing.Size(430, 319)
        Me.Reportspanel1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(173, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 21)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Customer Name"
        '
        'comcode
        '
        Me.comcode.BackColor = System.Drawing.Color.Transparent
        Me.comcode.BaseColor = System.Drawing.Color.White
        Me.comcode.BorderColor = System.Drawing.Color.Silver
        Me.comcode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.comcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comcode.FocusedColor = System.Drawing.Color.Empty
        Me.comcode.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.comcode.ForeColor = System.Drawing.Color.Black
        Me.comcode.FormattingEnabled = True
        Me.comcode.Location = New System.Drawing.Point(48, 141)
        Me.comcode.Name = "comcode"
        Me.comcode.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.comcode.OnHoverItemForeColor = System.Drawing.Color.White
        Me.comcode.Size = New System.Drawing.Size(94, 30)
        Me.comcode.TabIndex = 42
        '
        'CdFromlbl
        '
        Me.CdFromlbl.AutoSize = True
        Me.CdFromlbl.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CdFromlbl.Location = New System.Drawing.Point(46, 117)
        Me.CdFromlbl.Name = "CdFromlbl"
        Me.CdFromlbl.Size = New System.Drawing.Size(48, 21)
        Me.CdFromlbl.TabIndex = 41
        Me.CdFromlbl.Text = "Code"
        '
        'comname
        '
        Me.comname.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comname.FormattingEnabled = True
        Me.comname.Location = New System.Drawing.Point(173, 142)
        Me.comname.Name = "comname"
        Me.comname.Size = New System.Drawing.Size(203, 29)
        Me.comname.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(227, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 26)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "To Date"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(46, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 26)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "From Date"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(69, 60)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(339, 26)
        Me.lblTitle.TabIndex = 36
        Me.lblTitle.Text = "Customer Statement Report"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'dtpTo
        '
        Me.dtpTo.CustomFormat = "yyyy-MMM-dd"
        Me.dtpTo.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(231, 208)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(145, 26)
        Me.dtpTo.TabIndex = 32
        '
        'dtpFrom
        '
        Me.dtpFrom.CustomFormat = "yyyy-MMM-dd"
        Me.dtpFrom.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFrom.Location = New System.Drawing.Point(50, 208)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(146, 26)
        Me.dtpFrom.TabIndex = 31
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Label4)
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
        'frm_Statement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 317)
        Me.Controls.Add(Me.Reportspanel1)
        Me.Name = "frm_Statement"
        Me.Text = "frm_Statement"
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents edit_group_box As GroupBox
    Friend WithEvents btnreportscancel1 As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpFrom As DateTimePicker
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents comcode As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents CdFromlbl As Label
    Friend WithEvents comname As ComboBox
End Class
