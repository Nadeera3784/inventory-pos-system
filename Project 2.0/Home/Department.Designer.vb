﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Department
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Department))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbdeptname = New System.Windows.Forms.ComboBox()
        Me.cmbdeptcode = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.edit_group_box = New System.Windows.Forms.GroupBox()
        Me.btndeptupdate = New System.Windows.Forms.Button()
        Me.btndeptsave = New System.Windows.Forms.Button()
        Me.btndeptdelete = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.header3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.header2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.header1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.edit_group_box.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(2, 83)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(790, 243)
        Me.Panel2.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbdeptname)
        Me.GroupBox2.Controls.Add(Me.cmbdeptcode)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.edit_group_box)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(763, 178)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fill these Details"
        '
        'cmbdeptname
        '
        Me.cmbdeptname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdeptname.FormattingEnabled = True
        Me.cmbdeptname.Location = New System.Drawing.Point(483, 35)
        Me.cmbdeptname.Name = "cmbdeptname"
        Me.cmbdeptname.Size = New System.Drawing.Size(265, 24)
        Me.cmbdeptname.TabIndex = 29
        '
        'cmbdeptcode
        '
        Me.cmbdeptcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdeptcode.FormattingEnabled = True
        Me.cmbdeptcode.Location = New System.Drawing.Point(144, 34)
        Me.cmbdeptcode.Name = "cmbdeptcode"
        Me.cmbdeptcode.Size = New System.Drawing.Size(166, 24)
        Me.cmbdeptcode.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(334, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 21)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Department Name"
        '
        'edit_group_box
        '
        Me.edit_group_box.Controls.Add(Me.btndeptupdate)
        Me.edit_group_box.Controls.Add(Me.btndeptsave)
        Me.edit_group_box.Controls.Add(Me.btndeptdelete)
        Me.edit_group_box.Controls.Add(Me.PictureBox3)
        Me.edit_group_box.Location = New System.Drawing.Point(13, 76)
        Me.edit_group_box.Name = "edit_group_box"
        Me.edit_group_box.Size = New System.Drawing.Size(735, 90)
        Me.edit_group_box.TabIndex = 23
        Me.edit_group_box.TabStop = False
        Me.edit_group_box.Text = "Save | Update | Delete"
        '
        'btndeptupdate
        '
        Me.btndeptupdate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btndeptupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndeptupdate.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btndeptupdate.FlatAppearance.BorderSize = 0
        Me.btndeptupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btndeptupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btndeptupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeptupdate.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeptupdate.ForeColor = System.Drawing.Color.White
        Me.btndeptupdate.Location = New System.Drawing.Point(271, 35)
        Me.btndeptupdate.Name = "btndeptupdate"
        Me.btndeptupdate.Size = New System.Drawing.Size(188, 32)
        Me.btndeptupdate.TabIndex = 21
        Me.btndeptupdate.Text = "Update"
        Me.btndeptupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btndeptupdate.UseVisualStyleBackColor = False
        '
        'btndeptsave
        '
        Me.btndeptsave.BackColor = System.Drawing.Color.LimeGreen
        Me.btndeptsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndeptsave.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btndeptsave.FlatAppearance.BorderSize = 0
        Me.btndeptsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btndeptsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btndeptsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeptsave.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeptsave.ForeColor = System.Drawing.Color.White
        Me.btndeptsave.Location = New System.Drawing.Point(34, 35)
        Me.btndeptsave.Name = "btndeptsave"
        Me.btndeptsave.Size = New System.Drawing.Size(182, 32)
        Me.btndeptsave.TabIndex = 6
        Me.btndeptsave.Text = "Save"
        Me.btndeptsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btndeptsave.UseVisualStyleBackColor = False
        '
        'btndeptdelete
        '
        Me.btndeptdelete.BackColor = System.Drawing.Color.Red
        Me.btndeptdelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndeptdelete.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btndeptdelete.FlatAppearance.BorderSize = 0
        Me.btndeptdelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btndeptdelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btndeptdelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndeptdelete.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndeptdelete.ForeColor = System.Drawing.Color.White
        Me.btndeptdelete.Location = New System.Drawing.Point(518, 35)
        Me.btndeptdelete.Name = "btndeptdelete"
        Me.btndeptdelete.Size = New System.Drawing.Size(182, 32)
        Me.btndeptdelete.TabIndex = 24
        Me.btndeptdelete.Text = "Delete"
        Me.btndeptdelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btndeptdelete.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.PictureBox3.Location = New System.Drawing.Point(102, 35)
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
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(2, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(140, 21)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Department Code"
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
        Me.header3.Size = New System.Drawing.Size(328, 25)
        Me.header3.TabIndex = 6
        Me.header3.Text = "Add | Update New Department"
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
        'header2
        '
        Me.header2.AutoSize = True
        Me.header2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header2.ForeColor = System.Drawing.Color.White
        Me.header2.Location = New System.Drawing.Point(115, 15)
        Me.header2.Name = "header2"
        Me.header2.Size = New System.Drawing.Size(134, 21)
        Me.header2.TabIndex = 6
        Me.header2.Text = "New Department"
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
        Me.Panel1.Size = New System.Drawing.Size(789, 69)
        Me.Panel1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.header2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(522, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(256, 44)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
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
        Me.header1.Size = New System.Drawing.Size(175, 26)
        Me.header1.TabIndex = 2
        Me.header1.Text = "New Department"
        '
        'Department
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(789, 326)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Department"
        Me.Text = "Department"
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.edit_group_box.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbdeptname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbdeptcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents edit_group_box As System.Windows.Forms.GroupBox
    Friend WithEvents btndeptupdate As System.Windows.Forms.Button
    Friend WithEvents btndeptsave As System.Windows.Forms.Button
    Friend WithEvents btndeptdelete As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents header3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents header2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents header1 As System.Windows.Forms.Label
End Class
