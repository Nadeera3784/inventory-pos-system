<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_cancel_order
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
        Me.Reportspanel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCan_invoice = New System.Windows.Forms.Button()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.cominvoice = New System.Windows.Forms.ComboBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.lbltype = New Guna.UI.WinForms.GunaLabel()
        Me.Reportspanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Reportspanel1
        '
        Me.Reportspanel1.BackColor = System.Drawing.Color.White
        Me.Reportspanel1.Controls.Add(Me.lbltype)
        Me.Reportspanel1.Controls.Add(Me.GunaLabel3)
        Me.Reportspanel1.Controls.Add(Me.btnClear)
        Me.Reportspanel1.Controls.Add(Me.btnCan_invoice)
        Me.Reportspanel1.Controls.Add(Me.txttotal)
        Me.Reportspanel1.Controls.Add(Me.GunaLabel2)
        Me.Reportspanel1.Controls.Add(Me.cominvoice)
        Me.Reportspanel1.Controls.Add(Me.GunaLabel1)
        Me.Reportspanel1.Controls.Add(Me.Panel3)
        Me.Reportspanel1.Location = New System.Drawing.Point(0, -1)
        Me.Reportspanel1.Name = "Reportspanel1"
        Me.Reportspanel1.Size = New System.Drawing.Size(430, 269)
        Me.Reportspanel1.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(247, 198)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(156, 30)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCan_invoice
        '
        Me.btnCan_invoice.BackColor = System.Drawing.Color.LimeGreen
        Me.btnCan_invoice.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCan_invoice.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btnCan_invoice.FlatAppearance.BorderSize = 0
        Me.btnCan_invoice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.btnCan_invoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen
        Me.btnCan_invoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCan_invoice.Font = New System.Drawing.Font("Franklin Gothic Heavy", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCan_invoice.ForeColor = System.Drawing.Color.White
        Me.btnCan_invoice.Location = New System.Drawing.Point(56, 198)
        Me.btnCan_invoice.Name = "btnCan_invoice"
        Me.btnCan_invoice.Size = New System.Drawing.Size(156, 30)
        Me.btnCan_invoice.TabIndex = 23
        Me.btnCan_invoice.Text = "Cancel Invoice"
        Me.btnCan_invoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCan_invoice.UseVisualStyleBackColor = False
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(125, 138)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(246, 20)
        Me.txttotal.TabIndex = 37
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(19, 135)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(95, 21)
        Me.GunaLabel2.TabIndex = 36
        Me.GunaLabel2.Text = "Invoice Total"
        '
        'cominvoice
        '
        Me.cominvoice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cominvoice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cominvoice.FormattingEnabled = True
        Me.cominvoice.Location = New System.Drawing.Point(125, 75)
        Me.cominvoice.Name = "cominvoice"
        Me.cominvoice.Size = New System.Drawing.Size(246, 21)
        Me.cominvoice.TabIndex = 35
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(19, 72)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(84, 21)
        Me.GunaLabel1.TabIndex = 34
        Me.GunaLabel1.Text = "Invoice No"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(430, 48)
        Me.Panel3.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Heavy", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cancel Invoice"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(19, 103)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(42, 21)
        Me.GunaLabel3.TabIndex = 38
        Me.GunaLabel3.Text = "Type"
        '
        'lbltype
        '
        Me.lbltype.AutoSize = True
        Me.lbltype.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbltype.Location = New System.Drawing.Point(124, 103)
        Me.lbltype.Name = "lbltype"
        Me.lbltype.Size = New System.Drawing.Size(42, 21)
        Me.lbltype.TabIndex = 39
        Me.lbltype.Text = "Type"
        '
        'Frm_cancel_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 263)
        Me.Controls.Add(Me.Reportspanel1)
        Me.Name = "Frm_cancel_order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancel Order"
        Me.Reportspanel1.ResumeLayout(False)
        Me.Reportspanel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Reportspanel1 As Panel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCan_invoice As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents txttotal As TextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cominvoice As ComboBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbltype As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
End Class
