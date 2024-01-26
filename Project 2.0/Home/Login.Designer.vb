<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.system_label = New System.Windows.Forms.Label()
        Me.pass_label = New System.Windows.Forms.Label()
        Me.user_label = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtloginusername = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.txtloginpassword = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.edit_group_box = New System.Windows.Forms.GroupBox()
        Me.btnclose = New System.Windows.Forms.Button()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.edit_group_box.SuspendLayout()
        Me.SuspendLayout()
        '
        'system_label
        '
        Me.system_label.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.system_label.Font = New System.Drawing.Font("Times New Roman", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.system_label.ForeColor = System.Drawing.Color.White
        Me.system_label.Location = New System.Drawing.Point(82, 4)
        Me.system_label.Name = "system_label"
        Me.system_label.Size = New System.Drawing.Size(434, 61)
        Me.system_label.TabIndex = 10
        Me.system_label.Text = "Boapagama Stores Pos System"
        Me.system_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pass_label
        '
        Me.pass_label.AutoSize = True
        Me.pass_label.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass_label.ForeColor = System.Drawing.Color.Black
        Me.pass_label.Location = New System.Drawing.Point(32, 138)
        Me.pass_label.Name = "pass_label"
        Me.pass_label.Size = New System.Drawing.Size(97, 23)
        Me.pass_label.TabIndex = 6
        Me.pass_label.Text = "Password"
        '
        'user_label
        '
        Me.user_label.AutoSize = True
        Me.user_label.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_label.ForeColor = System.Drawing.Color.Black
        Me.user_label.Location = New System.Drawing.Point(32, 91)
        Me.user_label.Name = "user_label"
        Me.user_label.Size = New System.Drawing.Size(164, 23)
        Me.user_label.TabIndex = 6
        Me.user_label.Text = "Username / Email"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(6, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(74, 61)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 11
        Me.PictureBox5.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(88, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(257, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Login using your username and Password"
        '
        'txtloginusername
        '
        Me.txtloginusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtloginusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloginusername.ForeColor = System.Drawing.Color.Black
        Me.txtloginusername.Location = New System.Drawing.Point(209, 91)
        Me.txtloginusername.Name = "txtloginusername"
        Me.txtloginusername.Size = New System.Drawing.Size(241, 22)
        Me.txtloginusername.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 68)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(82, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sign in"
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.Color.LimeGreen
        Me.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnlogin.FlatAppearance.BorderSize = 0
        Me.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.ForeColor = System.Drawing.Color.White
        Me.btnlogin.Location = New System.Drawing.Point(23, 27)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(132, 37)
        Me.btnlogin.TabIndex = 23
        Me.btnlogin.Text = "Login"
        Me.btnlogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'txtloginpassword
        '
        Me.txtloginpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtloginpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloginpassword.ForeColor = System.Drawing.Color.Black
        Me.txtloginpassword.Location = New System.Drawing.Point(209, 138)
        Me.txtloginpassword.Name = "txtloginpassword"
        Me.txtloginpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtloginpassword.Size = New System.Drawing.Size(243, 22)
        Me.txtloginpassword.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(510, 74)
        Me.Panel3.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.edit_group_box)
        Me.Panel2.Controls.Add(Me.txtloginpassword)
        Me.Panel2.Controls.Add(Me.txtloginusername)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.pass_label)
        Me.Panel2.Controls.Add(Me.user_label)
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(3, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(510, 261)
        Me.Panel2.TabIndex = 9
        '
        'edit_group_box
        '
        Me.edit_group_box.Controls.Add(Me.btnclose)
        Me.edit_group_box.Controls.Add(Me.btnlogin)
        Me.edit_group_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit_group_box.ForeColor = System.Drawing.Color.Black
        Me.edit_group_box.Location = New System.Drawing.Point(26, 175)
        Me.edit_group_box.Name = "edit_group_box"
        Me.edit_group_box.Size = New System.Drawing.Size(455, 77)
        Me.edit_group_box.TabIndex = 24
        Me.edit_group_box.TabStop = False
        Me.edit_group_box.Text = "Login | Close"
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.Red
        Me.btnclose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclose.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnclose.FlatAppearance.BorderSize = 0
        Me.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclose.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(298, 27)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(133, 37)
        Me.btnclose.TabIndex = 24
        Me.btnclose.Text = "Close"
        Me.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 329)
        Me.Controls.Add(Me.system_label)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.edit_group_box.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents system_label As System.Windows.Forms.Label
    Friend WithEvents pass_label As System.Windows.Forms.Label
    Friend WithEvents user_label As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtloginusername As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents txtloginpassword As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents edit_group_box As System.Windows.Forms.GroupBox
End Class
