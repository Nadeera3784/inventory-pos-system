<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Category
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Category))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.header2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.header1 = New System.Windows.Forms.Label()
        Me.btncustsave = New System.Windows.Forms.Button()
        Me.ComCatName = New System.Windows.Forms.ComboBox()
        Me.btncustupdate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComDeptname = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.edit_group_box = New System.Windows.Forms.GroupBox()
        Me.btncustdelete = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.header3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.comCatCode = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.edit_group_box.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.header1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(793, 69)
        Me.Panel1.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.header2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(522, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 44)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'header2
        '
        Me.header2.AutoSize = True
        Me.header2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header2.ForeColor = System.Drawing.Color.White
        Me.header2.Location = New System.Drawing.Point(115, 15)
        Me.header2.Name = "header2"
        Me.header2.Size = New System.Drawing.Size(113, 21)
        Me.header2.TabIndex = 6
        Me.header2.Text = "New Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(43, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Home  /  "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 8)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(84, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Edit and Add Categories here"
        '
        'header1
        '
        Me.header1.AutoSize = True
        Me.header1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header1.ForeColor = System.Drawing.Color.White
        Me.header1.Location = New System.Drawing.Point(83, 9)
        Me.header1.Name = "header1"
        Me.header1.Size = New System.Drawing.Size(147, 26)
        Me.header1.TabIndex = 2
        Me.header1.Text = "New Category"
        '
        'btncustsave
        '
        Me.btncustsave.BackColor = System.Drawing.Color.LimeGreen
        Me.btncustsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncustsave.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btncustsave.FlatAppearance.BorderSize = 0
        Me.btncustsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btncustsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btncustsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncustsave.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncustsave.ForeColor = System.Drawing.Color.White
        Me.btncustsave.Location = New System.Drawing.Point(34, 45)
        Me.btncustsave.Name = "btncustsave"
        Me.btncustsave.Size = New System.Drawing.Size(182, 32)
        Me.btncustsave.TabIndex = 6
        Me.btncustsave.Text = "Save"
        Me.btncustsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncustsave.UseVisualStyleBackColor = False
        '
        'ComCatName
        '
        Me.ComCatName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComCatName.FormattingEnabled = True
        Me.ComCatName.Location = New System.Drawing.Point(167, 120)
        Me.ComCatName.Name = "ComCatName"
        Me.ComCatName.Size = New System.Drawing.Size(265, 24)
        Me.ComCatName.TabIndex = 29
        '
        'btncustupdate
        '
        Me.btncustupdate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btncustupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncustupdate.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btncustupdate.FlatAppearance.BorderSize = 0
        Me.btncustupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncustupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btncustupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncustupdate.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncustupdate.ForeColor = System.Drawing.Color.White
        Me.btncustupdate.Location = New System.Drawing.Point(271, 45)
        Me.btncustupdate.Name = "btncustupdate"
        Me.btncustupdate.Size = New System.Drawing.Size(188, 32)
        Me.btncustupdate.TabIndex = 21
        Me.btncustupdate.Text = "Update"
        Me.btncustupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncustupdate.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 21)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Category Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.comCatCode)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ComDeptname)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ComCatName)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.edit_group_box)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(763, 280)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fill these Details"
        '
        'ComDeptname
        '
        Me.ComDeptname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComDeptname.FormattingEnabled = True
        Me.ComDeptname.Location = New System.Drawing.Point(167, 40)
        Me.ComDeptname.Name = "ComDeptname"
        Me.ComDeptname.Size = New System.Drawing.Size(265, 24)
        Me.ComDeptname.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 21)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Department Name"
        '
        'edit_group_box
        '
        Me.edit_group_box.Controls.Add(Me.btncustupdate)
        Me.edit_group_box.Controls.Add(Me.btncustsave)
        Me.edit_group_box.Controls.Add(Me.btncustdelete)
        Me.edit_group_box.Controls.Add(Me.PictureBox3)
        Me.edit_group_box.Location = New System.Drawing.Point(13, 163)
        Me.edit_group_box.Name = "edit_group_box"
        Me.edit_group_box.Size = New System.Drawing.Size(735, 111)
        Me.edit_group_box.TabIndex = 23
        Me.edit_group_box.TabStop = False
        Me.edit_group_box.Text = "Save | Update | Delete"
        '
        'btncustdelete
        '
        Me.btncustdelete.BackColor = System.Drawing.Color.Red
        Me.btncustdelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncustdelete.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btncustdelete.FlatAppearance.BorderSize = 0
        Me.btncustdelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btncustdelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btncustdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncustdelete.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncustdelete.ForeColor = System.Drawing.Color.White
        Me.btncustdelete.Location = New System.Drawing.Point(518, 45)
        Me.btncustdelete.Name = "btncustdelete"
        Me.btncustdelete.Size = New System.Drawing.Size(182, 32)
        Me.btncustdelete.TabIndex = 24
        Me.btncustdelete.Text = "Delete"
        Me.btncustdelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncustdelete.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.PictureBox3.Location = New System.Drawing.Point(102, 45)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(220, 379)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 32)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Delete"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LimeGreen
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(32, 379)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 32)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Update and Save"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 42)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'header3
        '
        Me.header3.AutoSize = True
        Me.header3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header3.ForeColor = System.Drawing.Color.Black
        Me.header3.Location = New System.Drawing.Point(80, 11)
        Me.header3.Name = "header3"
        Me.header3.Size = New System.Drawing.Size(302, 25)
        Me.header3.TabIndex = 6
        Me.header3.Text = "Add | Update New Category"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.header3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(790, 48)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(2, 69)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(790, 343)
        Me.Panel2.TabIndex = 6
        '
        'comCatCode
        '
        Me.comCatCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comCatCode.FormattingEnabled = True
        Me.comCatCode.Location = New System.Drawing.Point(167, 80)
        Me.comCatCode.Name = "comCatCode"
        Me.comCatCode.Size = New System.Drawing.Size(265, 24)
        Me.comCatCode.TabIndex = 35
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(13, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 21)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Category Code"
        '
        'Category
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 415)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Category"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.edit_group_box.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents header2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents header1 As System.Windows.Forms.Label
    Friend WithEvents btncustsave As System.Windows.Forms.Button
    Friend WithEvents ComCatName As System.Windows.Forms.ComboBox
    Friend WithEvents btncustupdate As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents edit_group_box As System.Windows.Forms.GroupBox
    Friend WithEvents btncustdelete As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents header3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ComDeptname As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents comCatCode As ComboBox
    Friend WithEvents Label5 As Label
End Class
