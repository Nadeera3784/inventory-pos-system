<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Credit_Entry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Credit_Entry))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbcreditcustname = New System.Windows.Forms.ComboBox()
        Me.cmbcreditcustcode = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcreditamount = New System.Windows.Forms.TextBox()
        Me.txtcreditdescription = New System.Windows.Forms.TextBox()
        Me.Dpcreditdate = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.header2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.header1 = New System.Windows.Forms.Label()
        Me.edit_group_box = New System.Windows.Forms.GroupBox()
        Me.btncreditupdate = New System.Windows.Forms.Button()
        Me.btncreditsave = New System.Windows.Forms.Button()
        Me.btncreditclose = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.edit_group_box.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(210, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 51)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(47, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Date"
        '
        'cmbcreditcustname
        '
        Me.cmbcreditcustname.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcreditcustname.FormattingEnabled = True
        Me.cmbcreditcustname.Location = New System.Drawing.Point(346, 12)
        Me.cmbcreditcustname.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbcreditcustname.Name = "cmbcreditcustname"
        Me.cmbcreditcustname.Size = New System.Drawing.Size(212, 21)
        Me.cmbcreditcustname.Sorted = True
        Me.cmbcreditcustname.TabIndex = 5
        '
        'cmbcreditcustcode
        '
        Me.cmbcreditcustcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcreditcustcode.FormattingEnabled = True
        Me.cmbcreditcustcode.Location = New System.Drawing.Point(130, 15)
        Me.cmbcreditcustcode.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbcreditcustcode.Name = "cmbcreditcustcode"
        Me.cmbcreditcustcode.Size = New System.Drawing.Size(72, 21)
        Me.cmbcreditcustcode.Sorted = True
        Me.cmbcreditcustcode.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(355, 106)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Amount"
        '
        'txtcreditamount
        '
        Me.txtcreditamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcreditamount.Location = New System.Drawing.Point(426, 106)
        Me.txtcreditamount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcreditamount.Name = "txtcreditamount"
        Me.txtcreditamount.Size = New System.Drawing.Size(129, 20)
        Me.txtcreditamount.TabIndex = 11
        '
        'txtcreditdescription
        '
        Me.txtcreditdescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcreditdescription.Location = New System.Drawing.Point(130, 50)
        Me.txtcreditdescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcreditdescription.Multiline = True
        Me.txtcreditdescription.Name = "txtcreditdescription"
        Me.txtcreditdescription.Size = New System.Drawing.Size(425, 40)
        Me.txtcreditdescription.TabIndex = 13
        '
        'Dpcreditdate
        '
        Me.Dpcreditdate.CustomFormat = "yyy-MMM-dd"
        Me.Dpcreditdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dpcreditdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dpcreditdate.Location = New System.Drawing.Point(132, 103)
        Me.Dpcreditdate.Margin = New System.Windows.Forms.Padding(4)
        Me.Dpcreditdate.Name = "Dpcreditdate"
        Me.Dpcreditdate.Size = New System.Drawing.Size(117, 20)
        Me.Dpcreditdate.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Dpcreditdate)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtcreditdescription)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtcreditamount)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.cmbcreditcustname)
        Me.Panel2.Controls.Add(Me.cmbcreditcustcode)
        Me.Panel2.Location = New System.Drawing.Point(5, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(575, 137)
        Me.Panel2.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.PictureBox5)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.header1)
        Me.Panel3.Location = New System.Drawing.Point(5, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(575, 71)
        Me.Panel3.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.header2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(335, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 44)
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
        Me.header2.Size = New System.Drawing.Size(91, 21)
        Me.header2.TabIndex = 6
        Me.header2.Text = "New Credit"
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
        Me.PictureBox5.Location = New System.Drawing.Point(11, 9)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(66, 59)
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
        Me.Label7.Size = New System.Drawing.Size(188, 21)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Edit and Add Credit here"
        '
        'header1
        '
        Me.header1.AutoSize = True
        Me.header1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header1.ForeColor = System.Drawing.Color.White
        Me.header1.Location = New System.Drawing.Point(83, 9)
        Me.header1.Name = "header1"
        Me.header1.Size = New System.Drawing.Size(226, 26)
        Me.header1.TabIndex = 2
        Me.header1.Text = "Customer Credit Entry"
        '
        'edit_group_box
        '
        Me.edit_group_box.Controls.Add(Me.btncreditupdate)
        Me.edit_group_box.Controls.Add(Me.btncreditsave)
        Me.edit_group_box.Controls.Add(Me.btncreditclose)
        Me.edit_group_box.Location = New System.Drawing.Point(5, 221)
        Me.edit_group_box.Name = "edit_group_box"
        Me.edit_group_box.Size = New System.Drawing.Size(575, 72)
        Me.edit_group_box.TabIndex = 24
        Me.edit_group_box.TabStop = False
        Me.edit_group_box.Text = "Save | Update | Delete"
        '
        'btncreditupdate
        '
        Me.btncreditupdate.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btncreditupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncreditupdate.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btncreditupdate.FlatAppearance.BorderSize = 0
        Me.btncreditupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btncreditupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btncreditupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncreditupdate.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreditupdate.ForeColor = System.Drawing.Color.White
        Me.btncreditupdate.Location = New System.Drawing.Point(199, 26)
        Me.btncreditupdate.Name = "btncreditupdate"
        Me.btncreditupdate.Size = New System.Drawing.Size(173, 32)
        Me.btncreditupdate.TabIndex = 21
        Me.btncreditupdate.Text = "Update"
        Me.btncreditupdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncreditupdate.UseVisualStyleBackColor = False
        '
        'btncreditsave
        '
        Me.btncreditsave.BackColor = System.Drawing.Color.LimeGreen
        Me.btncreditsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncreditsave.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btncreditsave.FlatAppearance.BorderSize = 0
        Me.btncreditsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btncreditsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btncreditsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncreditsave.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreditsave.ForeColor = System.Drawing.Color.White
        Me.btncreditsave.Location = New System.Drawing.Point(11, 26)
        Me.btncreditsave.Name = "btncreditsave"
        Me.btncreditsave.Size = New System.Drawing.Size(164, 32)
        Me.btncreditsave.TabIndex = 6
        Me.btncreditsave.Text = "Save"
        Me.btncreditsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncreditsave.UseVisualStyleBackColor = False
        '
        'btncreditclose
        '
        Me.btncreditclose.BackColor = System.Drawing.Color.Red
        Me.btncreditclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncreditclose.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btncreditclose.FlatAppearance.BorderSize = 0
        Me.btncreditclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btncreditclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btncreditclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncreditclose.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreditclose.ForeColor = System.Drawing.Color.White
        Me.btncreditclose.Location = New System.Drawing.Point(393, 26)
        Me.btncreditclose.Name = "btncreditclose"
        Me.btncreditclose.Size = New System.Drawing.Size(166, 32)
        Me.btncreditclose.TabIndex = 24
        Me.btncreditclose.Text = "Close"
        Me.btncreditclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btncreditclose.UseVisualStyleBackColor = False
        '
        'Credit_Entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 297)
        Me.ControlBox = False
        Me.Controls.Add(Me.edit_group_box)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Credit_Entry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credit_Entry"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.edit_group_box.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbcreditcustname As System.Windows.Forms.ComboBox
    Friend WithEvents cmbcreditcustcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcreditamount As System.Windows.Forms.TextBox
    Friend WithEvents txtcreditdescription As System.Windows.Forms.TextBox
    Friend WithEvents Dpcreditdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents header2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents header1 As System.Windows.Forms.Label
    Friend WithEvents edit_group_box As System.Windows.Forms.GroupBox
    Friend WithEvents btncreditupdate As System.Windows.Forms.Button
    Friend WithEvents btncreditsave As System.Windows.Forms.Button
    Friend WithEvents btncreditclose As System.Windows.Forms.Button
End Class
