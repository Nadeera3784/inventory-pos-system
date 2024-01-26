<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Yearlyreports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Yearlyreports))
        Me.Reportspanel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbyearlyinvno = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblheadertext2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnyearlycancel = New System.Windows.Forms.Button()
        Me.btnyearlyreport = New System.Windows.Forms.Button()
        Me.dpyearlymonth = New System.Windows.Forms.DateTimePicker()
        Me.Reportpanel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Reportspanel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Reportpanel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Reportspanel2
        '
        Me.Reportspanel2.BackColor = System.Drawing.Color.White
        Me.Reportspanel2.Controls.Add(Me.Label1)
        Me.Reportspanel2.Controls.Add(Me.cmbyearlyinvno)
        Me.Reportspanel2.Controls.Add(Me.Label5)
        Me.Reportspanel2.Controls.Add(Me.PictureBox3)
        Me.Reportspanel2.Controls.Add(Me.lblheadertext2)
        Me.Reportspanel2.Controls.Add(Me.GroupBox1)
        Me.Reportspanel2.Controls.Add(Me.dpyearlymonth)
        Me.Reportspanel2.Controls.Add(Me.Reportpanel2)
        Me.Reportspanel2.Location = New System.Drawing.Point(3, 3)
        Me.Reportspanel2.Name = "Reportspanel2"
        Me.Reportspanel2.Size = New System.Drawing.Size(405, 270)
        Me.Reportspanel2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(103, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 21)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Year  :  "
        '
        'cmbyearlyinvno
        '
        Me.cmbyearlyinvno.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbyearlyinvno.FormattingEnabled = True
        Me.cmbyearlyinvno.Location = New System.Drawing.Point(198, 103)
        Me.cmbyearlyinvno.Name = "cmbyearlyinvno"
        Me.cmbyearlyinvno.Size = New System.Drawing.Size(132, 29)
        Me.cmbyearlyinvno.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(81, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 21)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Invoice   :  "
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
        Me.lblheadertext2.Location = New System.Drawing.Point(68, 58)
        Me.lblheadertext2.Name = "lblheadertext2"
        Me.lblheadertext2.Size = New System.Drawing.Size(329, 26)
        Me.lblheadertext2.TabIndex = 34
        Me.lblheadertext2.Text = "N/A"
        Me.lblheadertext2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnyearlycancel)
        Me.GroupBox1.Controls.Add(Me.btnyearlyreport)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(14, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 65)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report | Cancel"
        '
        'btnyearlycancel
        '
        Me.btnyearlycancel.BackColor = System.Drawing.Color.Red
        Me.btnyearlycancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnyearlycancel.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnyearlycancel.FlatAppearance.BorderSize = 0
        Me.btnyearlycancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnyearlycancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnyearlycancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnyearlycancel.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnyearlycancel.ForeColor = System.Drawing.Color.White
        Me.btnyearlycancel.Location = New System.Drawing.Point(248, 22)
        Me.btnyearlycancel.Name = "btnyearlycancel"
        Me.btnyearlycancel.Size = New System.Drawing.Size(101, 30)
        Me.btnyearlycancel.TabIndex = 24
        Me.btnyearlycancel.Text = "Cancel"
        Me.btnyearlycancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnyearlycancel.UseVisualStyleBackColor = False
        '
        'btnyearlyreport
        '
        Me.btnyearlyreport.BackColor = System.Drawing.Color.LimeGreen
        Me.btnyearlyreport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnyearlyreport.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnyearlyreport.FlatAppearance.BorderSize = 0
        Me.btnyearlyreport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnyearlyreport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnyearlyreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnyearlyreport.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnyearlyreport.ForeColor = System.Drawing.Color.White
        Me.btnyearlyreport.Location = New System.Drawing.Point(26, 22)
        Me.btnyearlyreport.Name = "btnyearlyreport"
        Me.btnyearlyreport.Size = New System.Drawing.Size(101, 30)
        Me.btnyearlyreport.TabIndex = 23
        Me.btnyearlyreport.Text = "Report"
        Me.btnyearlyreport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnyearlyreport.UseVisualStyleBackColor = False
        '
        'dpyearlymonth
        '
        Me.dpyearlymonth.CustomFormat = "yyyy"
        Me.dpyearlymonth.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dpyearlymonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dpyearlymonth.Location = New System.Drawing.Point(198, 142)
        Me.dpyearlymonth.Name = "dpyearlymonth"
        Me.dpyearlymonth.Size = New System.Drawing.Size(132, 26)
        Me.dpyearlymonth.TabIndex = 31
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
        Me.Reportpanel2.Size = New System.Drawing.Size(405, 48)
        Me.Reportpanel2.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Heavy", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(65, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(205, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Search Your Yearly Report here"
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
        Me.Label7.Size = New System.Drawing.Size(144, 26)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Yearly Report"
        '
        'Yearlyreports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(411, 274)
        Me.Controls.Add(Me.Reportspanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Yearlyreports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yearlyreports"
        Me.Reportspanel2.ResumeLayout(False)
        Me.Reportspanel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Reportpanel2.ResumeLayout(False)
        Me.Reportpanel2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Reportspanel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbyearlyinvno As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents lblheadertext2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnyearlycancel As System.Windows.Forms.Button
    Friend WithEvents btnyearlyreport As System.Windows.Forms.Button
    Friend WithEvents dpyearlymonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents Reportpanel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
