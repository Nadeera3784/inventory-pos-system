<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barcodeprint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Barcodeprint))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbbarcodename = New System.Windows.Forms.ComboBox()
        Me.comCopies = New System.Windows.Forms.ComboBox()
        Me.txtbarcodecode = New System.Windows.Forms.TextBox()
        Me.lblbarcodeprice = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.edit_group_box = New System.Windows.Forms.GroupBox()
        Me.btnbarcodeupdate = New System.Windows.Forms.Button()
        Me.btnbarcodesave = New System.Windows.Forms.Button()
        Me.btnbarcodeclear = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.header2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.header1 = New System.Windows.Forms.Label()
        Me.reportDocument1 = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
        Me.Panel1.SuspendLayout()
        Me.edit_group_box.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmbbarcodename)
        Me.Panel1.Controls.Add(Me.comCopies)
        Me.Panel1.Controls.Add(Me.txtbarcodecode)
        Me.Panel1.Controls.Add(Me.lblbarcodeprice)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(2, 76)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 106)
        Me.Panel1.TabIndex = 1
        '
        'cmbbarcodename
        '
        Me.cmbbarcodename.FormattingEnabled = True
        Me.cmbbarcodename.Location = New System.Drawing.Point(309, 23)
        Me.cmbbarcodename.Name = "cmbbarcodename"
        Me.cmbbarcodename.Size = New System.Drawing.Size(198, 21)
        Me.cmbbarcodename.TabIndex = 1
        '
        'comCopies
        '
        Me.comCopies.FormattingEnabled = True
        Me.comCopies.Location = New System.Drawing.Point(309, 66)
        Me.comCopies.Name = "comCopies"
        Me.comCopies.Size = New System.Drawing.Size(66, 21)
        Me.comCopies.TabIndex = 8
        Me.comCopies.Text = "1"
        '
        'txtbarcodecode
        '
        Me.txtbarcodecode.Location = New System.Drawing.Point(80, 22)
        Me.txtbarcodecode.Name = "txtbarcodecode"
        Me.txtbarcodecode.Size = New System.Drawing.Size(103, 20)
        Me.txtbarcodecode.TabIndex = 7
        '
        'lblbarcodeprice
        '
        Me.lblbarcodeprice.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbarcodeprice.Location = New System.Drawing.Point(81, 64)
        Me.lblbarcodeprice.Name = "lblbarcodeprice"
        Me.lblbarcodeprice.Size = New System.Drawing.Size(121, 23)
        Me.lblbarcodeprice.TabIndex = 6
        Me.lblbarcodeprice.Text = "Label6"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(208, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Copies :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Code :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(189, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Price :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'edit_group_box
        '
        Me.edit_group_box.Controls.Add(Me.btnbarcodeupdate)
        Me.edit_group_box.Controls.Add(Me.btnbarcodesave)
        Me.edit_group_box.Controls.Add(Me.btnbarcodeclear)
        Me.edit_group_box.Location = New System.Drawing.Point(3, 190)
        Me.edit_group_box.Name = "edit_group_box"
        Me.edit_group_box.Size = New System.Drawing.Size(520, 65)
        Me.edit_group_box.TabIndex = 24
        Me.edit_group_box.TabStop = False
        Me.edit_group_box.Text = "Save | Update | Delete"
        '
        'btnbarcodeupdate
        '
        Me.btnbarcodeupdate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnbarcodeupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbarcodeupdate.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnbarcodeupdate.FlatAppearance.BorderSize = 0
        Me.btnbarcodeupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnbarcodeupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnbarcodeupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbarcodeupdate.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbarcodeupdate.ForeColor = System.Drawing.Color.White
        Me.btnbarcodeupdate.Location = New System.Drawing.Point(224, 19)
        Me.btnbarcodeupdate.Name = "btnbarcodeupdate"
        Me.btnbarcodeupdate.Size = New System.Drawing.Size(93, 32)
        Me.btnbarcodeupdate.TabIndex = 21
        Me.btnbarcodeupdate.Text = "Update"
        Me.btnbarcodeupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnbarcodeupdate.UseVisualStyleBackColor = False
        '
        'btnbarcodesave
        '
        Me.btnbarcodesave.BackColor = System.Drawing.Color.LimeGreen
        Me.btnbarcodesave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbarcodesave.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnbarcodesave.FlatAppearance.BorderSize = 0
        Me.btnbarcodesave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnbarcodesave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnbarcodesave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbarcodesave.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbarcodesave.ForeColor = System.Drawing.Color.White
        Me.btnbarcodesave.Location = New System.Drawing.Point(46, 19)
        Me.btnbarcodesave.Name = "btnbarcodesave"
        Me.btnbarcodesave.Size = New System.Drawing.Size(97, 32)
        Me.btnbarcodesave.TabIndex = 6
        Me.btnbarcodesave.Text = "Save"
        Me.btnbarcodesave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnbarcodesave.UseVisualStyleBackColor = False
        '
        'btnbarcodeclear
        '
        Me.btnbarcodeclear.BackColor = System.Drawing.Color.Red
        Me.btnbarcodeclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbarcodeclear.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnbarcodeclear.FlatAppearance.BorderSize = 0
        Me.btnbarcodeclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnbarcodeclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnbarcodeclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbarcodeclear.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbarcodeclear.ForeColor = System.Drawing.Color.White
        Me.btnbarcodeclear.Location = New System.Drawing.Point(391, 19)
        Me.btnbarcodeclear.Name = "btnbarcodeclear"
        Me.btnbarcodeclear.Size = New System.Drawing.Size(87, 32)
        Me.btnbarcodeclear.TabIndex = 24
        Me.btnbarcodeclear.Text = "Clear"
        Me.btnbarcodeclear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnbarcodeclear.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.header1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(523, 69)
        Me.Panel2.TabIndex = 25
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.header2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(282, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(236, 44)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'header2
        '
        Me.header2.AutoSize = True
        Me.header2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header2.ForeColor = System.Drawing.Color.White
        Me.header2.Location = New System.Drawing.Point(114, 15)
        Me.header2.Name = "header2"
        Me.header2.Size = New System.Drawing.Size(107, 21)
        Me.header2.TabIndex = 6
        Me.header2.Text = "New Barcode"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(43, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Home  /  "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(4, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(11, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(66, 68)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 3
        Me.PictureBox5.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(84, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 21)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Print Barcode here"
        '
        'header1
        '
        Me.header1.AutoSize = True
        Me.header1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header1.ForeColor = System.Drawing.Color.White
        Me.header1.Location = New System.Drawing.Point(83, 9)
        Me.header1.Name = "header1"
        Me.header1.Size = New System.Drawing.Size(146, 26)
        Me.header1.TabIndex = 2
        Me.header1.Text = "Barcode Print"
        '
        'Barcodeprint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 254)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.edit_group_box)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Barcodeprint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barcode Print"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.edit_group_box.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbbarcodename As System.Windows.Forms.ComboBox
    Friend WithEvents comCopies As System.Windows.Forms.ComboBox
    Friend WithEvents txtbarcodecode As System.Windows.Forms.TextBox
    Friend WithEvents lblbarcodeprice As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents edit_group_box As System.Windows.Forms.GroupBox
    Friend WithEvents btnbarcodeupdate As System.Windows.Forms.Button
    Friend WithEvents btnbarcodesave As System.Windows.Forms.Button
    Friend WithEvents btnbarcodeclear As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents header2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents header1 As System.Windows.Forms.Label
    Friend WithEvents reportDocument1 As CrystalDecisions.CrystalReports.Engine.ReportDocument
End Class
