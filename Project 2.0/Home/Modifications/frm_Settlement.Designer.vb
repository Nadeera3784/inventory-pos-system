<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Settlement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Settlement))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.comcode = New System.Windows.Forms.ComboBox()
        Me.comname = New System.Windows.Forms.ComboBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.txtcredit = New System.Windows.Forms.TextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txtpayment = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.header2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.header1 = New System.Windows.Forms.Label()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblreceiptno = New Guna.UI.WinForms.GunaLabel()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(7, 80)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(118, 21)
        Me.GunaLabel1.TabIndex = 0
        Me.GunaLabel1.Text = "Customer Code"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(247, 80)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(124, 21)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Customer Name"
        '
        'comcode
        '
        Me.comcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.comcode.FormattingEnabled = True
        Me.comcode.Location = New System.Drawing.Point(131, 80)
        Me.comcode.Name = "comcode"
        Me.comcode.Size = New System.Drawing.Size(102, 30)
        Me.comcode.TabIndex = 2
        '
        'comname
        '
        Me.comname.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.comname.FormattingEnabled = True
        Me.comname.Location = New System.Drawing.Point(377, 80)
        Me.comname.Name = "comname"
        Me.comname.Size = New System.Drawing.Size(184, 30)
        Me.comname.TabIndex = 3
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(7, 118)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(98, 21)
        Me.GunaLabel3.TabIndex = 4
        Me.GunaLabel3.Text = "Due Amount"
        '
        'txtcredit
        '
        Me.txtcredit.Enabled = False
        Me.txtcredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.txtcredit.ForeColor = System.Drawing.Color.Red
        Me.txtcredit.Location = New System.Drawing.Point(131, 116)
        Me.txtcredit.Name = "txtcredit"
        Me.txtcredit.Size = New System.Drawing.Size(184, 27)
        Me.txtcredit.TabIndex = 5
        Me.txtcredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(7, 156)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(70, 21)
        Me.GunaLabel4.TabIndex = 6
        Me.GunaLabel4.Text = "Payment"
        '
        'txtpayment
        '
        Me.txtpayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.txtpayment.ForeColor = System.Drawing.Color.SeaGreen
        Me.txtpayment.Location = New System.Drawing.Point(131, 152)
        Me.txtpayment.Name = "txtpayment"
        Me.txtpayment.Size = New System.Drawing.Size(184, 27)
        Me.txtpayment.TabIndex = 7
        Me.txtpayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.PictureBox5)
        Me.Panel3.Controls.Add(Me.header1)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(575, 71)
        Me.Panel3.TabIndex = 18
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
        Me.header2.Size = New System.Drawing.Size(93, 21)
        Me.header2.TabIndex = 6
        Me.header2.Text = "Settlement"
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
        'header1
        '
        Me.header1.AutoSize = True
        Me.header1.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.header1.ForeColor = System.Drawing.Color.White
        Me.header1.Location = New System.Drawing.Point(83, 9)
        Me.header1.Name = "header1"
        Me.header1.Size = New System.Drawing.Size(220, 26)
        Me.header1.TabIndex = 2
        Me.header1.Text = "Customer Settlement"
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.LimeGreen
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(88, 224)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(164, 32)
        Me.btnsave.TabIndex = 25
        Me.btnsave.Text = "Settle"
        Me.btnsave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnsave.UseVisualStyleBackColor = False
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
        Me.btnclose.Font = New System.Drawing.Font("Franklin Gothic Heavy", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclose.ForeColor = System.Drawing.Color.White
        Me.btnclose.Location = New System.Drawing.Point(290, 224)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(166, 32)
        Me.btnclose.TabIndex = 26
        Me.btnclose.Text = "Close"
        Me.btnclose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'lblreceiptno
        '
        Me.lblreceiptno.AutoSize = True
        Me.lblreceiptno.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblreceiptno.Location = New System.Drawing.Point(12, 191)
        Me.lblreceiptno.Name = "lblreceiptno"
        Me.lblreceiptno.Size = New System.Drawing.Size(86, 21)
        Me.lblreceiptno.TabIndex = 27
        Me.lblreceiptno.Text = "Receipt No"
        Me.lblreceiptno.Visible = False
        '
        'frm_Settlement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(573, 277)
        Me.Controls.Add(Me.lblreceiptno)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.txtpayment)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.txtcredit)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.comname)
        Me.Controls.Add(Me.comcode)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.MaximizeBox = False
        Me.Name = "frm_Settlement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settlement"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents comcode As ComboBox
    Friend WithEvents comname As ComboBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtcredit As TextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtpayment As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents header2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents header1 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents lblreceiptno As Guna.UI.WinForms.GunaLabel
End Class
