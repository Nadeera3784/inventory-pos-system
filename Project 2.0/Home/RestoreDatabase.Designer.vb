<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestoreDatabase
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestoreDatabase))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.P1 = New System.Windows.Forms.Panel()
        Me.P2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.cmbServer = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btn_restore = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.P1.SuspendLayout()
        Me.P2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(5, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(112, 250)
        Me.Panel1.TabIndex = 0
        '
        'P1
        '
        Me.P1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.P1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P1.Controls.Add(Me.P2)
        Me.P1.Controls.Add(Me.cmbServer)
        Me.P1.Controls.Add(Me.Label4)
        Me.P1.Controls.Add(Me.Label3)
        Me.P1.Controls.Add(Me.ComboBox1)
        Me.P1.Controls.Add(Me.Button3)
        Me.P1.Controls.Add(Me.btn_restore)
        Me.P1.Controls.Add(Me.btn_cancel)
        Me.P1.Controls.Add(Me.Label2)
        Me.P1.Controls.Add(Me.Label1)
        Me.P1.Location = New System.Drawing.Point(118, 6)
        Me.P1.Name = "P1"
        Me.P1.Size = New System.Drawing.Size(304, 250)
        Me.P1.TabIndex = 1
        '
        'P2
        '
        Me.P2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.P2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.P2.Controls.Add(Me.Label5)
        Me.P2.Controls.Add(Me.Button4)
        Me.P2.Location = New System.Drawing.Point(-1, -1)
        Me.P2.Name = "P2"
        Me.P2.Size = New System.Drawing.Size(304, 250)
        Me.P2.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(274, 132)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Please Wait a moment.....Backup is Procesing!"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(220, 219)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "&Finish"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'cmbServer
        '
        Me.cmbServer.FormattingEnabled = True
        Me.cmbServer.Items.AddRange(New Object() {"DESKTOP-MKEFVDD\SQLEXPRESS"})
        Me.cmbServer.Location = New System.Drawing.Point(110, 23)
        Me.cmbServer.Name = "cmbServer"
        Me.cmbServer.Size = New System.Drawing.Size(185, 21)
        Me.cmbServer.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Server Name :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(107, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 73)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Please Browse backup file"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"InventryPOS"})
        Me.ComboBox1.Location = New System.Drawing.Point(110, 65)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(146, 21)
        Me.ComboBox1.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(26, 132)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "&Browse"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btn_restore
        '
        Me.btn_restore.Location = New System.Drawing.Point(139, 219)
        Me.btn_restore.Name = "btn_restore"
        Me.btn_restore.Size = New System.Drawing.Size(75, 23)
        Me.btn_restore.TabIndex = 3
        Me.btn_restore.Text = "&Restore"
        Me.btn_restore.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(220, 219)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 2
        Me.btn_cancel.Text = "&Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Backup File :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Database Name :"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer1
        '
        '
        'RestoreDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 258)
        Me.ControlBox = False
        Me.Controls.Add(Me.P1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "RestoreDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restore Database"
        Me.P1.ResumeLayout(False)
        Me.P1.PerformLayout()
        Me.P2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents P1 As System.Windows.Forms.Panel
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents btn_restore As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmbServer As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents P2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
