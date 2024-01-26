<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GRN_Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GRN_Report))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Reportspanel1 = New System.Windows.Forms.Panel()
        Me.lblcomtext = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblheadertext1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.edit_group_box = New System.Windows.Forms.GroupBox()
        Me.btnreportscancel1 = New System.Windows.Forms.Button()
        Me.btnreportsdisplay1 = New System.Windows.Forms.Button()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker()
        Me.comInvoice = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Reportspanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.edit_group_box.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel3.Size = New System.Drawing.Size(428, 48)
        Me.Panel3.TabIndex = 2
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
        'Reportspanel1
        '
        Me.Reportspanel1.BackColor = System.Drawing.Color.White
        Me.Reportspanel1.Controls.Add(Me.lblcomtext)
        Me.Reportspanel1.Controls.Add(Me.Label6)
        Me.Reportspanel1.Controls.Add(Me.Label5)
        Me.Reportspanel1.Controls.Add(Me.lblheadertext1)
        Me.Reportspanel1.Controls.Add(Me.PictureBox1)
        Me.Reportspanel1.Controls.Add(Me.edit_group_box)
        Me.Reportspanel1.Controls.Add(Me.dtpTo)
        Me.Reportspanel1.Controls.Add(Me.dtpfrom)
        Me.Reportspanel1.Controls.Add(Me.comInvoice)
        Me.Reportspanel1.Controls.Add(Me.Panel1)
        Me.Reportspanel1.Location = New System.Drawing.Point(-1, 6)
        Me.Reportspanel1.Name = "Reportspanel1"
        Me.Reportspanel1.Size = New System.Drawing.Size(430, 319)
        Me.Reportspanel1.TabIndex = 4
        '
        'lblcomtext
        '
        Me.lblcomtext.AutoSize = True
        Me.lblcomtext.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcomtext.ForeColor = System.Drawing.Color.Black
        Me.lblcomtext.Location = New System.Drawing.Point(69, 100)
        Me.lblcomtext.Name = "lblcomtext"
        Me.lblcomtext.Size = New System.Drawing.Size(90, 21)
        Me.lblcomtext.TabIndex = 39
        Me.lblcomtext.Text = "Invoice NO"
        Me.lblcomtext.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(239, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 21)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "To Date"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(69, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 21)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "From Date"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'dtpTo
        '
        Me.dtpTo.CustomFormat = "yyyy-MMM-dd"
        Me.dtpTo.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTo.Location = New System.Drawing.Point(238, 194)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(145, 26)
        Me.dtpTo.TabIndex = 32
        '
        'dtpfrom
        '
        Me.dtpfrom.CustomFormat = "yyyy-MMM-dd"
        Me.dtpfrom.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfrom.Location = New System.Drawing.Point(67, 194)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(146, 26)
        Me.dtpfrom.TabIndex = 31
        '
        'comInvoice
        '
        Me.comInvoice.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comInvoice.FormattingEnabled = True
        Me.comInvoice.Location = New System.Drawing.Point(73, 124)
        Me.comInvoice.Name = "comInvoice"
        Me.comInvoice.Size = New System.Drawing.Size(228, 29)
        Me.comInvoice.TabIndex = 26
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 48)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(14, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(45, 42)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 26)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Report"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(64, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Search Your  Reports With From | To"
        '
        'GRN_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 331)
        Me.Controls.Add(Me.Reportspanel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "GRN_Report"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GRN Report Generator"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Reportspanel1.ResumeLayout(False)
        Me.Reportspanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.edit_group_box.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Reportspanel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblheadertext1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents edit_group_box As GroupBox
    Friend WithEvents btnreportscancel1 As Button
    Friend WithEvents btnreportsdisplay1 As Button
    Friend WithEvents dtpTo As DateTimePicker
    Friend WithEvents dtpfrom As DateTimePicker
    Friend WithEvents comInvoice As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblcomtext As Label
End Class
