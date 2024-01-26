
Imports System.Data.Odbc
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Windows.Forms.DataGridView
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Net.Mail

Public Class Invoice

    Dim RPTObject As New ReportDocument

    Dim AC As String
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" _
(ByVal IpApplication As String, ByVal Ipkeyname As String,
ByVal IpString As String, ByVal IpFileName As String) As Integer

    Private Declare Auto Function GetPrivateProfileString Lib "Kernel32" _
    (ByVal IpApplicationName As String, ByVal IpKeyName As String,
    ByVal IpDefault As String, ByVal IPReturnedString As System.Text.StringBuilder,
    ByVal nsize As Integer, ByVal IpFileName As String) As Integer
    Public strUNIT, strUNIT2, strUNIT3, strUNIT6 As New System.Text.StringBuilder(255)
    Public str1, CusDisplay, CusDis As String

    Public cmd5 As OdbcCommand
    Dim a As Double
    Dim d, g As Integer
    Dim c As Decimal
    Dim unit As Decimal
    Dim description As String
    Dim qty As Decimal
    Dim discount As Decimal
    Dim amount As Decimal
    Dim ccode As String
    Dim ourprice As String
    Dim tid As Integer
    Dim tCode As String
    Dim T_filldisc As String
    Dim Watermark As String = "Yes"
    Dim Bl As Double
    Dim NewBalance, CreditLimit As Double
    Friend TextToBePrinted, CompanyName1 As String
    Private bitmap As Bitmap

    Public Sub GetInvoiceNumber()
        cmd = New OdbcCommand("select COUNT(distinct invoiceno) as IDD from Invoice where loca='" & loca & "'and unitno='" & lblinvunit.Text & "'", cn)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim ID As Integer = 1
        If dr.HasRows Then
            ID = dr.Item("IDD")
            ID = ID + 1
        End If
        dr.Close()
        lblinvno.Text = Format(ID, "00000#")
    End Sub

    Private Sub Invoice_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        btncustomers.Focus()
        btncustomers.Select()
        txtinvitemssearch.Text = "Search Customers"
        txtinvitemssearch.Focus()
        txtinvitemssearch.SelectAll()
        PayementsPanel.Hide()
        ItemsPanel.Hide()
        Statementpanel.Hide()
        Customerspanel.Hide()
        welcomepanel.Show()
    End Sub

    Private Sub Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            invaddcartdatagridview.Refresh()
            GetPrivateProfileString("Unit", "Name", "", strUNIT, 100, My.Application.Info.DirectoryPath & "\Config.ini")
            GetPrivateProfileString("Unit", "CusDis", "", strUNIT2, 100, My.Application.Info.DirectoryPath & "\Config.ini")
            GetPrivateProfileString("Unit", "Dport", "", strUNIT3, 100, My.Application.Info.DirectoryPath & "\Config.ini")
            GetPrivateProfileString("Unit", "CompanyName", "", strUNIT6, 100, My.Application.Info.DirectoryPath & "\Config.ini")
            CompanyName1 = strUNIT6.ToString
            lblinvunit.Text = strUNIT.ToString
            CusDisplay = strUNIT2.ToString
            CusDis = strUNIT2.ToString
            'Dport = strUNIT3.ToString

            lblinvcashier.Text = username

            Timer1.Enabled = True

            GetInvoiceNumber()

            txtinvalldiscounts.Text = "00"

            cmd = New OdbcCommand("delete from Tempinvoice where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
            cmd.ExecuteNonQuery()

            'CustomerDISPLAY("* " & CompanyName1 & " *", False, "", "Next Customer Please", False, "")

            Me.Text = CompanyName1

            cmd = New OdbcCommand("select * from Customer where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    cmbinvcustno.Items.Add(Trim(dr.Item("code")))
                    cmbinvcustname.Items.Add(Trim(dr.Item("name")))
                End While
            End If
            dr.Close()

            cmd = New OdbcCommand("select max(code) as IDD from Customer where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                Dim custno As Integer
                custno = Val(dr("IDD")) + 1
                cmbinvcustno.Text = Format(custno, "00#")
            End If
            dr.Close()

            cmd = New Odbc.OdbcCommand("select distinct invoiceno from Invoice where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    cmbinvloadprint.Items.Add(Trim(dr.Item("invoiceno")))
                End While
            End If
            dr.Close()

            'cmd = New Odbc.OdbcCommand("select distinct invoiceno from Invoice where loca='" & loca & "'", cn)
            'dr = cmd.ExecuteReader()
            'If dr.HasRows Then
            'While dr.Read
            'cmbrecallinvnoload.Items.Add(Trim(dr.Item("invoiceno")))
            'End While
            'End If
            'dr.Close()

            PayementsPanel.Hide()
            ItemsPanel.Hide()
            Statementpanel.Hide()
            Customerspanel.Hide()
            welcomepanel.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmbinvcustno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbinvcustno.SelectedIndexChanged
        Try
            cn.Open()
            cmd3 = New OdbcCommand("select * from Customer where code='" & cmbinvcustno.Text & "' and loca='" & loca & "'", cn)
            dr3 = cmd3.ExecuteReader
            dr3.Read()
            If dr3.HasRows Then
                cmbinvcustno.Text = Trim(dr3.Item("code"))
                cmbinvcustname.Text = dr3.Item("name")
            End If
            dr3.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbinvcustname_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbinvcustname.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                Try

                    cn.Open()
                    cmd = New OdbcCommand("INSERT INTO Customer Values('" & Trim(cmbinvcustno.Text) & "','" & cmbinvcustname.Text & "','" & "0" & "','" & "0" & "','" & "0" & "','" & "0" & "','" & "0" & "','" & "0" & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & loca & "')", cn)
                    cmd.ExecuteNonQuery()
                    cn.Close()

                    MsgBox("Customer Save Successfully....", MsgBoxStyle.Information, "Save Alert")

                    txtinvitemssearch.Focus()
                    txtinvitemssearch.SelectAll()

                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            Case Keys.Escape
                txtinvitemssearch.Focus()
                txtinvitemssearch.SelectAll()

        End Select
    End Sub

    Private Sub cmbinvcustname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbinvcustname.SelectedIndexChanged
        Try
            cn.Open()
            cmd4 = New OdbcCommand("select * from Customer where name='" & cmbinvcustname.Text & "' and loca='" & loca & "'", cn)
            dr4 = cmd4.ExecuteReader
            dr4.Read()
            If dr4.HasRows Then
                cmbinvcustno.Text = Trim(dr4.Item("code"))
                cmbinvcustname.Text = dr4.Item("name")
            End If
            dr4.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub invsearchitemsdatagridview_KeyDown(sender As Object, e As KeyEventArgs) Handles invsearchitemsdatagridview.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                Try
                    Dim inx As Integer
                    inx = invsearchitemsdatagridview.CurrentRow.Index
                    ccode = invsearchitemsdatagridview.Item(0, inx).Value
                    Dim a As Integer
                    For a = 0 To invaddcartdatagridview.Rows.Count - 1
                        If invaddcartdatagridview.Item(1, a).Value = ccode Then
                            MessageBox.Show("You Already Entered This Items Code " & invaddcartdatagridview.Item(2, a).Value, "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            invaddcartdatagridview.FirstDisplayedScrollingRowIndex = invaddcartdatagridview.Rows(a).Index
                            invaddcartdatagridview.Rows(invaddcartdatagridview.Rows(a).Index).Selected = True

                        End If
                    Next

                    Dim i As Integer
                    i = invsearchitemsdatagridview.CurrentRow.Index
                    lblinvitemsname.Text = invsearchitemsdatagridview.Item(1, i).Value
                    ccode = invsearchitemsdatagridview.Item(0, i).Value
                    unit = invsearchitemsdatagridview.Item(2, i).Value
                    ourprice = invsearchitemsdatagridview.Item(3, i).Value

                    txtinvitemsqty.Focus()
                    txtinvitemsqty.SelectAll()

                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            Case Keys.Escape
                txtinvitemssearch.Focus()
                txtinvitemssearch.SelectAll()


            Case Keys.F8

        End Select
    End Sub

    Private Sub txtinvitemsqty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtinvitemsqty.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If IsNumeric(txtinvitemsqty.Text) = True And Val(txtinvitemsqty.Text) > 0 Or Val(txtinvitemsqty.Text) < 0 Then
                    txtinvitemsamount.Text = Format(Val(ourprice) * Val(txtinvitemsqty.Text), "####0.00")
                    txtinvitemsdiscount.Focus()
                    txtinvitemsdiscount.Text = "00"
                    txtinvitemsdiscount.SelectAll()
                Else
                    MessageBox.Show("Please Enter Your Quantity", "Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Case Keys.Escape
                invsearchitemsdatagridview.Focus()
        End Select
    End Sub

    Private Sub txtinvitemsdiscount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtinvitemsdiscount.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                If Mid(txtinvitemsdiscount.Text, txtinvitemsdiscount.Text.Length) = "%" Then
                    txtinvitemsdiscount.Text = txtinvitemsdiscount.Text.Remove(txtinvitemsdiscount.Text.Length - 1)

                    Dim AMT As Decimal
                    AMT = unit * Val(txtinvitemsdiscount.Text) / 100

                    a = AMT * Val(txtinvitemsqty.Text)
                    txtinvitemsdiscount.Text = Format(a, "####0.00")

                    txtinvitemsamount.Text = Format(Val(txtinvitemsamount.Text) - Val(txtinvitemsdiscount.Text), "####0.00")
                    txtinvitemsamount.Focus()

                Else
                    a = Val(txtinvitemsdiscount.Text) * Val(txtinvitemsqty.Text)
                    txtinvitemsdiscount.Text = Format(a, "#####0.00")

                    txtinvitemsamount.Text = Format(Val(txtinvitemsamount.Text) - Val(txtinvitemsdiscount.Text), "####0.00")
                    txtinvitemsamount.Focus()
                End If

            Case Keys.Escape
                txtinvitemssearch.Focus()
                txtinvitemssearch.SelectAll()

            Case Keys.Left
                txtinvitemsqty.Focus()
                txtinvitemsqty.SelectAll()

            Case Keys.Right
                txtinvitemsamount.Focus()
                txtinvitemsamount.SelectAll()
        End Select
    End Sub

    Private Sub txtinvitemsamount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtinvitemsamount.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter


                If IsNumeric(txtinvitemsamount.Text) = True And Val(txtinvitemsamount.Text) > 0 Or Val(txtinvitemsamount.Text) < 0 Then
                    Try

                        cmd = New OdbcCommand("select  (id) as IDD from Tempinvoice where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                        dr = cmd.ExecuteReader()
                        dr.Read()
                        Dim ID As Integer = 0
                        If dr.HasRows Then
                            ID = dr.Item("IDD")
                            ID = ID + 1
                        Else
                            ID = ID + 1
                        End If
                        dr.Close()




                        cmd = New OdbcCommand("INSERT INTO Tempinvoice Values('" & ID & "','" & ccode & "','" & lblinvitemsname.Text & "','" & unit & "','" & txtinvitemsqty.Text & "','" & Format(Val(txtinvitemsdiscount.Text), "####0") & "','" & txtinvitemsamount.Text & "','" & loca & "','" & lblinvunit.Text & "','" + ourprice + "')", cn)
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in invoice insert")
                    End Try
                    da = New OdbcDataAdapter("Select id as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price',ourprice as 'Our Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Tempinvoice where loca='" & loca & "' and unit='" & lblinvunit.Text & "' order by id asc", cn)
                    dt = New DataTable()
                    da.Fill(dt)
                    invaddcartdatagridview.DataSource = dt

                    invaddcartdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    invaddcartdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    invaddcartdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    invaddcartdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    invaddcartdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    invaddcartdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    invaddcartdatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    invaddcartdatagridview.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    invaddcartdatagridview.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    invaddcartdatagridview.Columns(3).DefaultCellStyle.Format = "####0.00" '// Cost Price
                    invaddcartdatagridview.Columns(4).DefaultCellStyle.Format = "####0.00" '// ourprice
                    invaddcartdatagridview.Columns(5).DefaultCellStyle.Format = "####0" '// Quantity
                    invaddcartdatagridview.Columns(6).DefaultCellStyle.Format = "####0" '// Discount
                    invaddcartdatagridview.Columns(7).DefaultCellStyle.Format = "####0.00" '// Amount
                    txtinvitemssearch.Focus()
                    txtinvitemssearch.SelectAll()

                    Dim discount As String = 0
                    Dim stotal As String = 0
                    Dim scharge As String = 0
                    For i As Integer = 0 To invaddcartdatagridview.RowCount - 1
                        discount += invaddcartdatagridview.Rows(i).Cells(6).Value
                        stotal += invaddcartdatagridview.Rows(i).Cells(7).Value
                        scharge += invaddcartdatagridview.Rows(i).Cells(5).Value
                    Next

                    lblinvtotaldiscount.Text = Format(Val(discount), "####0")
                    lblinvtotalamount.Text = Format(Val(stotal), "####0.00")
                    lblinvtotalqty.Text = Format(Val(scharge), "####0")
                    lblnettotal.Text = Format(Val(lblinvtotalamount.Text), "###0.00")
                    Subtotallbl.Text = Format(Val(lblinvtotalamount.Text), "###0.00")

                    invaddcartdatagridview.Columns(0).Width = 60
                    invaddcartdatagridview.Columns(1).Width = 80
                    invaddcartdatagridview.Columns(2).Width = 220
                    invaddcartdatagridview.Columns(3).Width = 80
                    invaddcartdatagridview.Columns(4).Width = 80
                    invaddcartdatagridview.Columns(5).Width = 80
                    invaddcartdatagridview.Columns(6).Width = 80
                    invaddcartdatagridview.Columns(7).Width = 80

                    'CustomerDISPLAY("LINE:", True, Amounttxt.Text, "SUB TOTAL:", True, NetTotal.Text)

                    txtinvitemsqty.Text = "0"
                    txtinvitemsdiscount.Text = "0"
                    txtinvitemsamount.Text = "0.00"

                    invaddcartdatagridview.FirstDisplayedScrollingRowIndex = invaddcartdatagridview.RowCount - 1
                    invaddcartdatagridview.Rows(invaddcartdatagridview.RowCount - 1).Selected = True

                    Dim a As Integer
                    For a = 0 To invaddcartdatagridview.Rows.Count - 1
                        If Mid(invaddcartdatagridview.Rows(a).Cells(4).Value, 1, 1) = "-" Then
                            invaddcartdatagridview.Rows(a).DefaultCellStyle.BackColor = Color.PaleVioletRed
                        End If
                    Next

                    txtinvitemssearch.Focus()
                    txtinvitemssearch.SelectAll()

                Else
                    MessageBox.Show("Please Enter Your Amount", "Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Case Keys.Left
                txtinvitemsdiscount.Focus()
                txtinvitemsdiscount.SelectAll()

            Case Keys.Escape
                txtinvitemssearch.Focus()
                txtinvitemssearch.SelectAll()

        End Select
    End Sub

    Private Sub btninvcancel_Click(sender As Object, e As EventArgs) Handles btninvcancel.Click

        Me.Close()

    End Sub

    Private Sub btninvcheckout_Click(sender As Object, e As EventArgs) Handles btninvcheckout.Click

        Try



            If Paymentdatagridview1.Rows.Count > 0 Then
                Me.Cursor = Cursors.WaitCursor
                Try
                    cmd = New OdbcCommand("select * from Temppayments where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                    dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        While dr.Read()
                            If dr("type") = "Credit" Then
                                AC = "A/C"
                            Else
                                AC = ""
                            End If
                        End While
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Temp Payment")
                End Try

                Try


                    Dim BillCrAmount As Double
                    cn.Open()
                    cmd2 = New OdbcCommand("select * from Temppayments where type='Credit' and loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                    dr2 = cmd2.ExecuteReader
                    While dr2.Read
                        If Not IsDBNull(dr2(0)) Then


                            If dr2.HasRows Then
                                If dr2("amount") > 0 Then
                                    BillCrAmount = dr2("amount")
                                Else
                                    BillCrAmount = "0.00"
                                End If

                            End If
                            BillCrAmount = "0.00"
                        End If
                    End While
                    dr2.Close()

                Catch ex As Exception
                    MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Temp Payment 1")
                    cn.Close()
                    dr2.Close()
                End Try

                cn.Close()
                dr2.Close()

                cmd = New OdbcCommand("select * from Tempinvoice where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                dr = cmd.ExecuteReader()
                If dr.HasRows Then
                    While dr.Read()

                        Dim CrAmount As Double
                        cn.Open()
                        cmd2 = New OdbcCommand("select TOP(1)* from Statement where custcode='" & cmbinvcustno.Text & "' and loca='" & loca & "' order by ID DESC", cn)
                        dr2 = cmd2.ExecuteReader
                        dr2.Read()
                        If dr2.HasRows Then
                            If dr2("Balance") > 0 Then
                                CrAmount = dr2("Balance")
                            Else
                                CrAmount = "0.00"
                            End If
                        End If
                        cn.Close()
                        dr2.Close()

                        cn.Open()
                        cmd3 = New OdbcCommand("INSERT INTO Invoice Values('" & Trim(lblinvno.Text) & "','" & lblinvcashier.Text & "','" & lblinvunit.Text & "','" & cmbinvcustno.Text & "','" & cmbinvcustname.Text & "','" & dr.Item("id") & "','" & dr.Item("code") & "','" & dr.Item("name") & "','" & dr.Item("costprice") & "','" & dr.Item("quantity") & "','" & dr.Item("discount") & "','" & dr.Item("amount") & "','" & lblinvtotaldiscount.Text & "','" & txtinvalldiscounts.Text & "','" & lblinvtotalqty.Text & "','" & lblinvtotalamount.Text & "','" & lblnettotal.Text & "','" & lblpaidpayment.Text & "','" & lblpaymentbalancedue.Text & "','" & CrAmount & "','" & username & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & Format(Now, "hh.mm.ss tt") & "','" & loca & "','" & dr.Item("ourprice") & "')", cn)
                        cmd3.ExecuteNonQuery()
                        cn.Close()

                        'Less Qty
                        cn.Open()
                        cmd2 = New OdbcCommand("select * from Items where code='" & Trim(dr.Item("code")) & "' and loca='" & loca & "'", cn)
                        dr2 = cmd2.ExecuteReader()
                        dr2.Read()

                        If dr2.HasRows Then
                            cn.Open()
                            cmd4 = New OdbcCommand("UPDATE Items set totalqty='" & Val(Trim(dr2.Item("totalqty"))) - Val(Trim(dr.Item("quantity"))) & "' where code='" & Trim(dr.Item("code")) & "' and loca='" & loca & "'", cn)
                            cmd4.ExecuteNonQuery()
                            cn.Close()
                        End If
                        cn.Close()
                        'End Qty less

                    End While
                End If
                dr.Close()

                'Saving Payments Elements
                cmd = New OdbcCommand("select * from Temppayments where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                dr = cmd.ExecuteReader()
                If dr.HasRows Then
                    While dr.Read()
                        If dr("type") = "Credit" Then

                            cn.Open()
                            cmd2 = New OdbcCommand("select MAX(ID) as IDD from Statement where custcode='" & cmbinvcustno.Text & "' and loca='" & loca & "'", cn)
                            dr2 = cmd2.ExecuteReader()
                            dr2.Read()
                            Dim ID As Integer = 0

                            If dr2.HasRows Then
                                ID = dr2.Item("IDD")
                                ID = ID + 1
                            Else
                                ID = ID + 1
                            End If
                            dr2.Close()
                            cn.Close()

                            cn.Open()
                            cmd2 = New OdbcCommand("select MAX(ID) as IDD from Statementhistory where custcode='" & cmbinvcustno.Text & "' and loca='" & loca & "'", cn)
                            dr2 = cmd2.ExecuteReader()
                            dr2.Read()
                            Dim IDR As Integer = 0
                            If dr2.HasRows Then
                                IDR = dr2.Item("IDD")
                                IDR = IDR + 1
                            Else
                                IDR = IDR + 1
                            End If
                            dr2.Close()
                            cn.Close()

                            cn.Open()
                            Dim Balance As Double
                            cmd2 = New OdbcCommand("select TOP(1)* from Statement where custcode='" & cmbinvcustno.Text & "' and loca='" & loca & "' order by ID DESC", cn)
                            dr2 = cmd2.ExecuteReader()
                            dr2.Read()
                            If dr2.HasRows Then
                                Balance = Val(dr2("Balance")) + Val(dr("amount"))
                            Else
                                Balance = dr("amount")
                            End If
                            dr2.Close()
                            cn.Close()

                            cn.Open()
                            cmd3 = New OdbcCommand("INSERT INTO Statement Values('" & ID & "','" & cmbinvcustno.Text & "','" & cmbinvcustname.Text & "','" & lblinvno.Text & "','" & dr("amount") & "','" & "0.00" & "','" & Balance & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & loca & "')", cn)
                            cmd3.ExecuteNonQuery()
                            cn.Close()

                            cn.Open()
                            cmd3 = New OdbcCommand("INSERT INTO Statementhistory Values('" & IDR & "','" & cmbinvcustno.Text & "','" & cmbinvcustname.Text & "','" & lblinvno.Text & "','" & dr("amount") & "','" & "0.00" & "','" & Balance & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & loca & "')", cn)
                            cmd3.ExecuteNonQuery()
                            cn.Close()

                        End If

                        cn.Open()
                        cmd2 = New OdbcCommand("select Max(ID) as IDD from Payementinvoice where loca='" & loca & "'", cn)
                        dr2 = cmd2.ExecuteReader()
                        dr2.Read()
                        Dim IDD As Integer = 0
                        If dr2.HasRows Then
                            IDD = dr2.Item("IDD")
                            IDD = IDD + 1
                        Else
                            IDD = IDD + 1
                        End If
                        cn.Close()

                        cn.Open()
                        cmd = New OdbcCommand("INSERT INTO Payementinvoice Values('" & IDD & "','" & Trim(lblinvno.Text) & "','" & Trim(dr.Item("type")) & "','" & Trim(dr.Item("Cardno")) & "','" & Trim(dr.Item("amount")) & "','" & lblnettotal.Text & "','" & lblinvcashier.Text & "','" & lblinvunit.Text & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & loca & "')", cn)
                        cmd.ExecuteNonQuery()
                        cn.Close()

                    End While
                End If
                'End Saving Payments Elements
                dr.Close()

                'Save Cheque Details
                cmd = New OdbcCommand("select * from Tempcheque where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                dr = cmd.ExecuteReader()
                If dr.HasRows Then
                    While dr.Read()
                        cn.Open()
                        cmd2 = New OdbcCommand("select MAX(id) as IDD from Cheque where custno='" & cmbinvcustno.Text & "' and loca='" & loca & "'", cn)
                        dr2 = cmd2.ExecuteReader()
                        dr2.Read()
                        Dim ID As Integer = 0
                        If dr2.HasRows Then
                            ID = dr2.Item("IDD")
                            ID = ID + 1
                        Else
                            ID = ID + 1
                        End If
                        dr2.Close()
                        cn.Close()

                        cn.Open()
                        cmd = New OdbcCommand("INSERT INTO Cheque Values('" & ID & "','" & cmbinvcustno.Text & "','" & cmbinvcustname.Text & "','" & lblinvno.Text & "','" & dr.Item("Chequeno") & "','" & dr.Item("bank") & "','" & dr.Item("branch") & "','" & dr.Item("chequedate") & "','" & dr.Item("amount") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & Format(Now, "yyMMdd") & "','" & loca & "')", cn)
                        cmd.ExecuteNonQuery()
                        cn.Close()
                    End While
                End If
                dr.Close()

                cmd = New OdbcCommand("delete from TempCheque where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                cmd.ExecuteNonQuery()
                'Save Cheque Details End it
                Try
                    cmd = New OdbcCommand("ALTER VIEW RPT_Invoice as SELECT  dbo.Invoice.invoiceno, dbo.Invoice.cashier, dbo.Invoice.unitno, dbo.Invoice.custcode, dbo.Invoice.custname, dbo.Invoice.id, dbo.Invoice.code, dbo.Invoice.name, dbo.Invoice.costprice,dbo.Invoice.ourprice, dbo.Invoice.quantity, dbo.Invoice.discount, dbo.Invoice.amount, dbo.Invoice.tdiscounts, dbo.Invoice.alldiscounts, dbo.Invoice.tquantity, dbo.Invoice.tamount, dbo.Invoice.nettotal, dbo.Invoice.paidamount, dbo.Invoice.balancedue, dbo.Invoice.cramount, dbo.Invoice.username, dbo.Invoice.dateshort, dbo.Invoice.datelong, dbo.Invoice.time, dbo.Items.sinahalaname FROM  dbo.Invoice INNER JOIN dbo.Items ON dbo.Invoice.code = dbo.Items.code where invoiceno='" & Trim(lblinvno.Text) & "' and dbo.Invoice.loca='" & loca & "'and unitno='" & lblinvunit.Text & "'", cn)
                    cmd.ExecuteNonQuery()

                    cmd = New OdbcCommand("ALTER VIEW RPT_PAY as select * from Payementinvoice where invoiceno='" & Trim(lblinvno.Text) & "' and loca='" & loca & "'and unit='" & lblinvunit.Text & "'", cn)
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in Receipt")
                End Try
                'To Printer
                If checkinvprintreceipt.CheckState = CheckState.Unchecked Then


                    'Dim result As DialogResult = MessageBox.Show("All You Sure Want Print Receipt..?", Me.Text, MessageBoxButtons.YesNo)
                    'If result = Windows.Forms.DialogResult.Yes Then
                    RPTObject.Load(Application.StartupPath & "\RPT\Receipt.rpt")
                    RPTObject.SetDatabaseLogon(SQLUsername, SQLPassword)
                    RPTObject.Refresh()
                    RPTObject.PrintToPrinter(1, False, 0, 0)
                    'End If
                Else
                    RPTFile = My.Application.Info.DirectoryPath & "\RPT\Receipt.rpt"
                    Reportviewer.Show()
                End If
                'End printer

                btnemptycart_Click(sender, e)
                btnitems_Click(sender, e)
                checkinvprintreceipt.Checked = False

                GetInvoiceNumber()
                PayementsPanel.Hide()
                Statementpanel.Hide()
                Customerspanel.Hide()
                welcomepanel.Hide()
                ItemsPanel.Show()
                txtinvitemssearch.Focus()
                txtinvitemssearch.SelectAll()

            Else
                MessageBox.Show("Please Enter Your Paid Amount..", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            'CustomerDISPLAY("* " & CompanyName1 & "  *", False, "", "Next Customer Please", False, "")
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub txtinvitemssearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtinvitemssearch.KeyDown
        Select Case e.KeyCode

            Case Keys.F11
                txtinvitemssearch.Text = "Search Customers"
                txtinvitemssearch.Focus()
                txtinvitemssearch.SelectAll()
                PayementsPanel.Hide()
                ItemsPanel.Hide()
                Statementpanel.Hide()
                welcomepanel.Hide()
                Customerspanel.Show()

            Case Keys.F12
                txtinvitemssearch.Text = "Search Items"
                txtinvitemssearch.Focus()
                txtinvitemssearch.SelectAll()
                PayementsPanel.Hide()
                Statementpanel.Hide()
                Customerspanel.Hide()
                welcomepanel.Hide()
                ItemsPanel.Show()

            Case Keys.Down
                If ItemsPanel.Visible = True Then
                    invsearchitemsdatagridview.Focus()
                ElseIf Customerspanel.Visible = True Then
                    customersdatagridview.Focus()
                ElseIf PayementsPanel.Visible = True Then
                    Paymentdatagridview1.Focus()
                End If

            Case Keys.F5
                ItemsPanel.Hide()
                Statementpanel.Hide()
                Customerspanel.Hide()
                welcomepanel.Hide()
                PayementsPanel.Show()

                btnpay_Click(sender, New System.EventArgs())
                txtinvitemssearch.Text = "Search Items"
                'txtinvitemssearch.Focus()
                'txtinvitemssearch.SelectAll()

            Case Keys.F8
                If lblmode.Text = "RT" Then
                    lblmode.Text = "WS"
                ElseIf lblmode.Text = "WS" Then
                    lblmode.Text = "RT"
                End If

            Case Keys.F6

                da = New OdbcDataAdapter("Select id as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price', ourprice as 'Our Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Itemshold", cn)
                dt = New DataTable()
                da.Fill(dt)
                invaddcartdatagridview.DataSource = dt

                invaddcartdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                invaddcartdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                invaddcartdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                invaddcartdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                invaddcartdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                invaddcartdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                invaddcartdatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                invaddcartdatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                invaddcartdatagridview.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                invaddcartdatagridview.Columns(3).DefaultCellStyle.Format = "####0.00" '// Cost Price
                invaddcartdatagridview.Columns(4).DefaultCellStyle.Format = "####0.00" '// ourprice
                invaddcartdatagridview.Columns(5).DefaultCellStyle.Format = "####0" '// Quantity
                invaddcartdatagridview.Columns(6).DefaultCellStyle.Format = "####0" '// Discount
                invaddcartdatagridview.Columns(7).DefaultCellStyle.Format = "####0.00" '// Amount


            Case Keys.F7

                Dim i As Integer
                i = invaddcartdatagridview.CurrentRow.Index
                tid = invaddcartdatagridview.Item(0, i).Value
                tCode = invaddcartdatagridview.Item(1, i).Value
                description = invaddcartdatagridview.Item(2, i).Value
                unit = invaddcartdatagridview.Item(3, i).Value
                qty = invaddcartdatagridview.Item(4, i).Value
                discount = invaddcartdatagridview.Item(5, i).Value
                amount = invaddcartdatagridview.Item(6, i).Value

                Dim result As DialogResult = MessageBox.Show("All You Sure This Item Hold..?", Me.Text, MessageBoxButtons.YesNo)
                If result = Windows.Forms.DialogResult.Yes Then

                    cmd = New Odbc.OdbcCommand("select max(DISTINCT holdid) AS IDD from Itemshold", cn)
                    dr = cmd.ExecuteReader()
                    dr.Read()
                    Dim ID As Integer
                    If dr.HasRows Then
                        ID = dr.Item("IDD")
                        ID = ID + 1
                    End If
                    dr.Close()

                    cmd = New Odbc.OdbcCommand("INSERT INTO Itemshold Values('" & ID & "','" & Trim(cmbinvcustno.Text) & "','" & cmbinvcustname.Text & "','" & tid & "','" & tCode & "','" & description & "','" & unit & "','" & qty & "','" & discount & "','" & amount & "','" & loca & "')", cn)
                    cmd.ExecuteNonQuery()

                    cmd = New Odbc.OdbcCommand("delete from Tempinvoice", cn)
                    cmd.ExecuteNonQuery()
                    lblinvtotaldiscount.Text = "00"
                    lblinvtotalamount.Text = "0.00"
                    lblinvtotalqty.Text = "00"
                    lblnettotal.Text = "0.00"

                    da = New OdbcDataAdapter("Select Id as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price', Ourprice as 'Our Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Tempinvoice", cn)
                    dt = New DataTable()
                    da.Fill(dt)
                    invaddcartdatagridview.DataSource = dt
                    invaddcartdatagridview.Refresh()

                End If

            Case Keys.F2

                Customerspanel.Hide()
                ItemsPanel.Hide()
                PayementsPanel.Hide()
                Statementpanel.Show()
                Mainstatementpanel.Show()
                welcomepanel.Hide()
                Settlementpanel.Hide()
                Settlementchequepanel.Hide()
                If cmbinvcustno.Text = "N/A" Then
                Else
                    cmd = New OdbcCommand("select TOP(1)* from statement where custcode='" & cmbinvcustno.Text & "' and loca='" & loca & "' order by ID DESC", cn)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        If dr("Balance") > 0 Or dr("Balance") < 0 Then
                            Bl = dr("Balance")

                        End If
                    End If
                    dr.Close()
                End If

                Mainstatementdatagridview.Rows.Clear()
                cmd = New OdbcCommand("select * from statement where custcode='" & cmbinvcustno.Text & "' and loca='" & loca & "' order by ID ASC", cn)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    While dr.Read
                        Mainstatementdatagridview.Rows.Add(dr("Id"), dr("datelong"), dr("description"), Format(dr("credit"), "####0.00"), Format(dr("received"), "####0.00"), Format(dr("balance"), "####0.00"))
                    End While
                    Statementpanel.Refresh()

                    Mainstatementdatagridview.FirstDisplayedScrollingRowIndex = Mainstatementdatagridview.RowCount - 1
                    Mainstatementdatagridview.Rows(Mainstatementdatagridview.RowCount - 1).Selected = True
                End If
                dr.Close()

            Case Keys.F10

                cmd = New OdbcCommand("delete from Tempinvoice where loca='" & loca & "'and unit='" & lblinvunit.Text & "'", cn)
                cmd.ExecuteNonQuery()

                lblinvtotaldiscount.Text = "00"
                lblinvtotalqty.Text = "00"
                lblinvtotalamount.Text = "0.00"
                lblpaymentbalancedue.Text = "0.00"
                cmbinvcustno.Text = "N/A"
                cmbinvcustname.Text = "N/A"
                GetInvoiceNumber()
                txtinvitemsqty.Text = ""
                txtinvitemsdiscount.Text = ""
                txtinvitemsamount.Text = ""

                da = New OdbcDataAdapter("Select id as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price', ourprice as 'Our Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Tempinvoice where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                dt = New DataTable()
                da.Fill(dt)
                invaddcartdatagridview.DataSource = dt
                invaddcartdatagridview.Refresh()

                txtinvitemssearch.Focus()
                txtinvitemssearch.SelectAll()

                invsearchitemsdatagridview.Rows.Clear()

                btnitems_Click(sender, e)

                'CustomerDISPLAY("* " & CompanyName1 & "  *", False, "", "Next Customer Please", False, "")


            Case Keys.F4

                Try

                    cmd = New OdbcCommand("Delete Tempinvoice where Id='" & invaddcartdatagridview.Rows.Count & "' and loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                    cmd.ExecuteNonQuery()

                    da = New OdbcDataAdapter("Select id as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price',Ourprice as 'Our Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Tempinvoice where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                    dt = New DataTable()
                    da.Fill(dt)
                    invaddcartdatagridview.DataSource = dt
                    invaddcartdatagridview.Refresh()

                    Dim discount As String = 0
                    Dim stotal As String = 0
                    Dim scharge As String = 0
                    For i As Integer = 0 To invaddcartdatagridview.RowCount - 1
                        discount += invaddcartdatagridview.Rows(i).Cells(6).Value
                        stotal += invaddcartdatagridview.Rows(i).Cells(7).Value
                        scharge += invaddcartdatagridview.Rows(i).Cells(5).Value
                    Next

                    lblinvtotaldiscount.Text = Format(Val(discount), "####0")
                    lblinvtotalamount.Text = Format(Val(stotal), "####0.00")
                    lblinvtotalqty.Text = Format(Val(scharge), "####0")
                    lblnettotal.Text = Format(Val(lblinvtotalamount.Text), "###0.00")
                    Subtotallbl.Text = Format(Val(lblinvtotalamount.Text), "###0.00")

                    Dim a As Integer
                    For a = 0 To invaddcartdatagridview.Rows.Count - 1
                        If Mid(invaddcartdatagridview.Rows(a).Cells(5).Value, 1, 1) = "-" Then
                            invaddcartdatagridview.Rows(a).DefaultCellStyle.BackColor = Color.PaleVioletRed
                        End If
                    Next

                    txtinvitemssearch.Focus()
                    txtinvitemssearch.SelectAll()

                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try


            Case Keys.Escape

                txtinvitemssearch.Focus()
                txtinvitemssearch.SelectAll()

            Case Keys.Enter

                If ItemsPanel.Visible = True Then
                    cn.Open()
                    cmd2 = New Odbc.OdbcCommand("select * from Items where code = '" & txtinvitemssearch.Text & "' or barcode='" & txtinvitemssearch.Text & "' and loca='" & loca & "'", cn)
                    dr2 = cmd2.ExecuteReader()
                    dr2.Read()
                    If dr2.HasRows Then
                        If txtinvitemsqty.BackColor = Color.GreenYellow Then

                            Label14.Text = Trim(dr2.Item("name"))
                            ccode = Trim(dr2.Item("code"))
                            If lblmode.Text = "RT" Then
                                unit = Trim(dr2.Item("sellprice"))
                            ElseIf lblmode.Text = "WS" Then
                                unit = Trim(dr2.Item("wsprice"))
                            End If
                            '// Edit//
                            Dim row As String() = New String() {dr2("code"), dr2("name"), Format(dr2("sellprice"), "####0.00"), Format(dr2("ourprice"), "####0.00"), dr2("suppname"), Format(dr2("totalqty"), "####0.000")}
                            invsearchitemsdatagridview.Rows.Add(row)
                            invsearchitemsdatagridview.Refresh()
                            txtinvitemsqty.Focus()

                        ElseIf txtinvitemsqty.BackColor = Color.White Then
                            Label14.Text = Trim(dr2.Item("name"))
                            ccode = Trim(dr2.Item("code"))
                            unit = Trim(dr2.Item("sellprice"))
                            txtinvitemsqty.Text = "1"
                            txtinvitemsqty_KeyDown(sender, e)
                            txtinvitemsdiscount_KeyDown(sender, e)
                            txtinvitemsamount_KeyDown(sender, e)
                            txtinvitemssearch.Focus()
                            txtinvitemssearch.SelectAll()
                        End If
                    Else
                        MessageBox.Show("Invalid Code Or Barcode.. Try again..!", "Inventory", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtinvitemssearch.Focus()
                        txtinvitemssearch.SelectAll()
                    End If
                    dr2.Close()
                    cn.Close()
                End If

            Case Keys.ShiftKey
                If txtinvitemsqty.BackColor = Color.White Then
                    txtinvitemsqty.BackColor = Color.GreenYellow
                ElseIf txtinvitemsqty.BackColor = Color.GreenYellow Then
                    txtinvitemsqty.BackColor = Color.White
                End If

            Case Keys.Insert
                cmbinvcustname.Text = txtinvitemssearch.Text
                txtinvitemssearch.Text = ""
                txtinvitemssearch.SelectAll()
        End Select
    End Sub

    Private Sub txtinvitemssearch_TextChanged(sender As Object, e As EventArgs) Handles txtinvitemssearch.TextChanged

        If ItemsPanel.Visible = True Then

            Try
                invsearchitemsdatagridview.ColumnCount = 5
                invsearchitemsdatagridview.Columns(0).Name = "Code"
                invsearchitemsdatagridview.Columns(1).Name = "Name"
                invsearchitemsdatagridview.Columns(2).Name = "Sell Price"
                invsearchitemsdatagridview.Columns(3).Name = "Our Price"
                invsearchitemsdatagridview.Columns(4).Name = "Stock"
                invsearchitemsdatagridview.Rows.Clear()
                Dim IDF As Integer = 0
                invsearchitemsdatagridview.Columns(0).Width = 60
                invsearchitemsdatagridview.Columns(1).Width = 190
                invsearchitemsdatagridview.Columns(2).Width = 85
                invsearchitemsdatagridview.Columns(3).Width = 85
                invsearchitemsdatagridview.Columns(4).Width = 70

                invsearchitemsdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                invsearchitemsdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                invsearchitemsdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                invsearchitemsdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                invsearchitemsdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                invsearchitemsdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

                If txtinvitemssearch.Focus Then
                    Try
                        If txtinvitemssearch.Text.Length > 0 Then

                            cmd = New OdbcCommand("select * from Items where name like '%" & txtinvitemssearch.Text & "%' or barcode like '%" & txtinvitemssearch.Text & "%' and loca='" & loca & "'", cn)
                            dr = cmd.ExecuteReader()
                            If dr.HasRows Then
                                While dr.Read
                                    Dim row As String() = New String() {dr("code"), dr("name"), Format(dr("sellprice"), "####0.00"), Format(dr("ourprice"), "####0.00"), Format(dr("totalqty"), "####0")}
                                    invsearchitemsdatagridview.Rows.Add(row)
                                    If dr("totalqty") <= 0 Then invsearchitemsdatagridview.Rows(IDF).DefaultCellStyle.BackColor = Color.LightGray
                                    IDF = IDF + 1
                                End While
                                invsearchitemsdatagridview.Refresh()
                            End If
                            dr.Close()
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Items Load")
                    End Try
                    'invsearchitemsdatagridview.Focus()
                    'invsearchitemsdatagridview.SelectAll()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical)
                cn.Close()
            End Try

        ElseIf Customerspanel.Visible = True Then

            customersdatagridview.ColumnCount = 5
            customersdatagridview.Columns(0).Name = "Code"
            customersdatagridview.Columns(1).Name = "Name"
            customersdatagridview.Columns(2).Name = "Mobile No"
            customersdatagridview.Columns(3).Name = "Address"
            customersdatagridview.Columns(4).Name = "Outstanding"
            customersdatagridview.Rows.Clear()
            Dim IDS As Integer = 0
            Dim DF As Integer
            customersdatagridview.Columns(0).Width = 60
            customersdatagridview.Columns(1).Width = 140
            customersdatagridview.Columns(2).Width = 70
            customersdatagridview.Columns(3).Width = 100
            customersdatagridview.Columns(4).Width = 80
            customersdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            customersdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            customersdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            customersdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            customersdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            customersdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            If txtinvitemssearch.Focus Then

                If txtinvitemssearch.Text.Length > 0 Then

                    cmd = New OdbcCommand("select * from Customer where name like '%" & txtinvitemssearch.Text & "%' and loca='" & loca & "'", cn)
                    dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        While dr.Read

                            cn.Open()
                            Dim Balance As Double
                            cmd2 = New OdbcCommand("select TOP(1)* from statement where custcode='" & dr("code") & "' and loca='" & loca & "' order by ID DESC", cn)
                            dr2 = cmd2.ExecuteReader()
                            dr2.Read()
                            If dr2.HasRows Then
                                Balance = dr2("Balance")
                                DF = DateDiff(DateInterval.Day, dr2("datelong"), Now)
                            Else
                                Balance = "0.00"
                            End If
                            dr2.Close()
                            cn.Close()


                            Dim row As String() = New String() {dr("code"), dr("name"), dr("mobile"), dr("address"), Format(Balance, "####0.00")}
                            customersdatagridview.Rows.Add(row)
                            If Balance > 0 Then
                                If DF > 30 Then
                                    customersdatagridview.Rows(IDS).DefaultCellStyle.BackColor = Color.LightPink
                                ElseIf DF > 60 Then
                                    customersdatagridview.Rows(IDS).DefaultCellStyle.BackColor = Color.Red
                                Else
                                    customersdatagridview.Rows(IDS).DefaultCellStyle.BackColor = Color.LawnGreen
                                End If
                            End If
                            IDS = IDS + 1
                        End While

                    End If

                    dr.Close()
                    customersdatagridview.Refresh()

                End If
                customersdatagridview.Focus()
                customersdatagridview.SelectAll()
            End If

        End If

    End Sub

    Private Sub btnemptycart_Click(sender As Object, e As EventArgs) Handles btnemptycart.Click

        cmd = New OdbcCommand("delete from Tempinvoice where loca='" & loca & "'and unit='" & lblinvunit.Text & "'", cn)
        cmd.ExecuteNonQuery()

        lblinvtotaldiscount.Text = "00"
        lblinvtotalqty.Text = "00"
        lblinvtotalamount.Text = "0.00"
        lblpaymentbalancedue.Text = "0.00"
        lblnettotal.Text = "0.00"
        txtinvalldiscounts.Text = "00"
        cmbinvcustno.Text = "N/A"
        cmbinvcustname.Text = "N/A"
        lblcustomername.Text = "N/A"
        GetInvoiceNumber()
        txtinvitemsqty.Text = "0"
        txtinvitemsdiscount.Text = "0"
        txtinvitemsamount.Text = "0.00"
        txtinvitemssearch.Text = ""


        da = New OdbcDataAdapter("Select id as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Tempinvoice where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
        dt = New DataTable()
        da.Fill(dt)
        invaddcartdatagridview.DataSource = dt
        invaddcartdatagridview.Refresh()


        cmd = New OdbcCommand("Delete TempPayments where  loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
        cmd.ExecuteNonQuery()

        lblpaidpayment.Text = "0.00"

        da = New OdbcDataAdapter("Select id as 'ID', type as 'Type', cardno as 'Card Number', amount as 'Amount' from Temppayments where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
        dt = New DataTable()
        da.Fill(dt)
        Paymentdatagridview1.DataSource = dt
        Paymentdatagridview1.Columns(0).Width = 50
        Paymentdatagridview1.Columns(1).Width = 100
        Paymentdatagridview1.Columns(2).Width = 220
        Paymentdatagridview1.Columns(3).Width = 100
        Paymentdatagridview1.Columns(3).DefaultCellStyle.Format = "####0.00"
        Paymentdatagridview1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Paymentdatagridview1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Paymentdatagridview1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Paymentdatagridview1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Paymentdatagridview1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Paymentdatagridview1.Refresh()

        txtinvitemssearch.Focus()
        txtinvitemssearch.SelectAll()

        invsearchitemsdatagridview.Rows.Clear()

        btnitems_Click(sender, e)

        'CustomerDISPLAY("* " & CompanyName1 & "  *", False, "", "Next Customer Please", False, "")

    End Sub

    Private Sub btninvcheckout_KeyDown(sender As Object, e As KeyEventArgs) Handles btninvcheckout.KeyDown

        Try
            Select Case e.KeyCode
                Case Keys.Enter

                    Me.Cursor = Cursors.WaitCursor

                    cmd = New OdbcCommand("select * from Tempinvoice where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                    dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        While dr.Read()

                            cn.Open()
                            cmd3 = New OdbcCommand("INSERT INTO Invoice Values('" & Trim(lblinvno.Text) & "','" & lblinvcashier.Text & "','" & lblinvunit.Text & "','" & cmbinvcustno.Text & "','" & cmbinvcustname.Text & "','" & dr.Item("id") & "','" & dr.Item("code") & "','" & dr.Item("name") & "','" & dr.Item("costprice") & "','" & dr.Item("quantity") & "','" & dr.Item("discount") & "','" & dr.Item("amount") & "','" & lblinvtotaldiscount.Text & "','" & lblinvtotalqty.Text & "','" & lblinvtotalamount.Text & "','" & lblpaidpayment.Text & "','" & Cmbayementtype.Text & "','" & lblpaymentbalancedue.Text & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & Format(Now, "hh.mm.ss tt") & "','" & loca & "'," & dr.Item("ourprice") & ")", cn)
                            cmd3.ExecuteNonQuery()
                            cn.Close()

                            'Less Qty
                            cn.Open()
                            cmd2 = New OdbcCommand("select * from Items where code='" & Trim(dr.Item("code")) & "' and loca='" & loca & "'", cn)
                            dr2 = cmd2.ExecuteReader()
                            dr2.Read()

                            If dr2.HasRows Then
                                cn.Open()
                                cmd4 = New OdbcCommand("UPDATE Items set totalqty='" & Val(Trim(dr2.Item("totalqty"))) - Val(Trim(dr.Item("quantity"))) & "' where code='" & Trim(dr.Item("code")) & "' and loca='" & loca & "'", cn)
                                cmd4.ExecuteNonQuery()
                                cn.Close()
                            End If
                            cn.Close()
                            'End Qty less

                        End While
                    End If
                    dr.Close()


                    cmd = New OdbcCommand("ALTER VIEW RPT_Invoice as select * from Invoice where invoiceno='" & Trim(lblinvno.Text) & "' and loca='" & loca & "'and unitno='" & lblinvunit.Text & "'", cn)
                    cmd.ExecuteNonQuery()
                    'To Printer
                    If checkinvprintreceipt.CheckState = CheckState.Unchecked Then


                        reportDocument1.Load(My.Application.Info.DirectoryPath & "\RPT\Receipt.rpt")
                        reportDocument1.SetDatabaseLogon(SQLUsername, SQLPassword)
                        reportDocument1.Refresh()
                        reportDocument1.PrintToPrinter(1, False, 0, 0)
                    Else
                        cmd = New OdbcCommand("ALTER VIEW RPT_Invoice as select * from Invoice where invoiceno='" & Trim(lblinvno.Text) & "' and loca='" & loca & "'and unitno='" & lblinvunit.Text & "'", cn)
                        cmd.ExecuteNonQuery()

                        RPTFile = My.Application.Info.DirectoryPath & "\RPT\Receipt.rpt"
                        Reportviewer.Show()
                    End If
                    'end printer

                    btnemptycart_Click(sender, e)
                    btnitems_Click(sender, e)
                    checkinvprintreceipt.Checked = False

                    GetInvoiceNumber()
                    txtinvitemssearch.Focus()
                    txtinvitemssearch.SelectAll()

                    'CustomerDISPLAY("* " & CompanyName1 & "  *", False, "", "Next Customer Please", False, "")
                    Me.Cursor = Cursors.Default

                Case Keys.Escape

            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btninvcancel_KeyDown(sender As Object, e As KeyEventArgs) Handles btninvcancel.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select

    End Sub


    Private Sub btnpay_Click(sender As Object, e As EventArgs) Handles btnpay.Click

        ItemsPanel.Hide()
        Statementpanel.Hide()
        Customerspanel.Hide()
        welcomepanel.Hide()
        PayementsPanel.Show()

        cmd = New OdbcCommand("Delete TempPayments where  loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
        cmd.ExecuteNonQuery()

        lblpaidpayment.Text = "0.00"

        da = New OdbcDataAdapter("Select id as 'ID', type as 'Type', cardno as 'Card Number', amount as 'Amount' from Temppayments where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
        dt = New DataTable()
        da.Fill(dt)
        Paymentdatagridview1.DataSource = dt
        Paymentdatagridview1.Columns(0).Width = 50
        Paymentdatagridview1.Columns(1).Width = 100
        Paymentdatagridview1.Columns(2).Width = 220
        Paymentdatagridview1.Columns(3).Width = 100
        Paymentdatagridview1.Columns(3).DefaultCellStyle.Format = "####0.00"
        Paymentdatagridview1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Paymentdatagridview1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Paymentdatagridview1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Paymentdatagridview1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Paymentdatagridview1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        Paymentdatagridview1.Refresh()

        Cmbayementtype.Focus()
        Cmbayementtype.SelectedIndex = 0

    End Sub

    Private Sub Cmbayementtype_KeyDown(sender As Object, e As KeyEventArgs) Handles Cmbayementtype.KeyDown

        Select Case e.KeyCode
            Case Keys.Escape
                txtinvitemssearch.Focus()
                txtinvitemssearch.SelectAll()
            Case Keys.Enter
                If Cmbayementtype.Text = "Credit Card" Then
                    txtpaymentcardno.Enabled = True
                    txtpaymentcardno.Focus()
                    txtpaymentcardno.SelectAll()
                ElseIf Cmbayementtype.Text = "Cheque" Then
                    Chequepanel.Show()
                    Label17.Text = "Cheque Entry"
                    lbltotalcheque.Text = "0.00"
                    txtpaymentchequeno.Focus()
                    cmd = New OdbcCommand("delete from Tempcheque", cn)
                    cmd.ExecuteNonQuery()
                    da = New OdbcDataAdapter("Select id as 'ID',  bank as 'Bank', branch as 'Branch', chequeno as 'Cheque No', chequedate as 'Date', amount as 'Amount' from Tempcheque", cn)
                    dt = New DataTable()
                    da.Fill(dt)
                    Paymentdatagridviewcheque2.DataSource = dt
                    Paymentdatagridviewcheque2.Columns(0).Width = 40
                    Paymentdatagridviewcheque2.Columns(1).Width = 100
                    Paymentdatagridviewcheque2.Columns(2).Width = 80
                    Paymentdatagridviewcheque2.Columns(3).Width = 100
                    Paymentdatagridviewcheque2.Columns(4).Width = 70
                    Paymentdatagridviewcheque2.Columns(5).Width = 70
                    Paymentdatagridviewcheque2.Columns(5).DefaultCellStyle.Format = "####0.00"

                    Paymentdatagridviewcheque2.Refresh()

                    Paymentdatagridviewcheque2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Paymentdatagridviewcheque2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    Paymentdatagridviewcheque2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    Paymentdatagridviewcheque2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    Paymentdatagridviewcheque2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    Paymentdatagridviewcheque2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    Paymentdatagridviewcheque2.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                ElseIf cmbinvcustno.Text = "N/A" And Cmbayementtype.Text = "Credit" Then
                    MessageBox.Show("Please Select Your Customer....", "", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Else
                    txtpaymentcardno.Enabled = False
                    txtpaymentamount.Text = Format(Val(lblnettotal.Text) - Val(lblpaidpayment.Text), "######0.00")
                    txtpaymentamount.Focus()
                    txtpaymentamount.SelectAll()
                End If

            Case Keys.F10

                btninvcheckout_Click(sender, e)

        End Select

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnpaychequesave.Click

        Chequepanel.Hide()
        txtpaymentamount.Text = lbltotalcheque.Text
        txtpaymentamount.Focus()
        txtpaymentamount.SelectAll()

    End Sub

    Private Sub txtpaymentchequeamount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpaymentchequeamount.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter

                cmd = New OdbcCommand("select Max(id) as IDD from Tempcheque", cn)
                dr = cmd.ExecuteReader()
                dr.Read()
                Dim ID As Integer = 0
                If dr.HasRows Then
                    ID = dr.Item("IDD")
                    ID = ID + 1
                Else
                    ID = ID + 1
                End If

                dr.Close()

                cmd = New OdbcCommand("INSERT INTO Tempcheque Values('" & ID & "','" & cmbpaymentchequebank.Text & "','" & txtpaymentchequeno.Text & "','" & cmbpaymentchequebranch.Text & "','" & Format(dppaymentchequedate.Value, "yyyy-MMM-dd") & "','" & txtpaymentchequeamount.Text & "','" & lblinvunit.Text & "','" & loca & "')", cn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Successfully Save Your Cheque Details", "Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cmd = New OdbcCommand("select SUM(amount) as Total from Tempcheque", cn)
                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then
                    lbltotalcheque.Text = Format(dr.Item("Total"), "####0.00")
                End If
                dr.Close()

                da = New OdbcDataAdapter("Select id as 'ID',  bank as 'Bank', branch as 'Branch', chequeno as 'Cheque No', chequedate as 'Date', amount as 'Amount' from Tempcheque", cn)
                dt = New DataTable()
                da.Fill(dt)
                Paymentdatagridviewcheque2.DataSource = dt
                Paymentdatagridviewcheque2.Columns(0).Width = 40
                Paymentdatagridviewcheque2.Columns(1).Width = 100
                Paymentdatagridviewcheque2.Columns(2).Width = 80
                Paymentdatagridviewcheque2.Columns(3).Width = 100
                Paymentdatagridviewcheque2.Columns(4).Width = 70
                Paymentdatagridviewcheque2.Columns(5).Width = 70
                Paymentdatagridviewcheque2.Columns(5).DefaultCellStyle.Format = "####0.00"

                Paymentdatagridviewcheque2.Refresh()

                Paymentdatagridviewcheque2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Paymentdatagridviewcheque2.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Paymentdatagridviewcheque2.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Paymentdatagridviewcheque2.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Paymentdatagridviewcheque2.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Paymentdatagridviewcheque2.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Paymentdatagridviewcheque2.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                cmbpaymentchequebank.Select()
                txtpaymentchequeno.Text = ""
                cmbpaymentchequebranch.Select()
                txtpaymentchequeamount.Text = ""
                txtinvitemssearch.Focus()
                txtinvitemssearch.SelectAll()

        End Select

    End Sub

    Private Sub txtpaymentamount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpaymentamount.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                If IsNumeric(txtpaymentamount.Text) = True And Val(txtpaymentamount.Text) > 0 Or Val(txtpaymentamount.Text) < 0 Then

                    If Val(lbloutstanding.Text) + Val(lblnettotal.Text) > CreditLimit And Cmbayementtype.Text = "Credit" Then
                        MessageBox.Show("Customer: " & cmbinvcustname.Text & vbCrLf & "Limit : " & CreditLimit & vbCrLf & "Credit limit exceeded, Plz Contact Admin..", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Else

                        cmd = New OdbcCommand("select COUNT(Id) as IDD from Temppayments where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                        dr = cmd.ExecuteReader()
                        dr.Read()
                        Dim ID As Integer = 0
                        If dr.HasRows Then
                            ID = dr.Item("IDD")
                            ID = ID + 1
                        Else
                            ID = ID + 1
                        End If
                        dr.Close()

                        cmd = New OdbcCommand("INSERT INTO Temppayments Values('" & ID & "','" & Cmbayementtype.Text & "','" & txtpaymentcardno.Text & "','" & txtpaymentamount.Text & "','" & lblinvunit.Text & "','" & loca & "')", cn)
                        cmd.ExecuteNonQuery()
                        Cmbayementtype.Text = ""
                        txtpaymentcardno.Text = ""
                        txtpaymentamount.Text = ""
                        Cmbayementtype.Select()

                        cmd = New OdbcCommand("select SUM(Amount) as AMT from Temppayments where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                        dr = cmd.ExecuteReader()
                        dr.Read()
                        If dr.HasRows Then
                            lblpaidpayment.Text = Format(dr.Item("AMT"), "####0.00")
                        End If
                        dr.Close()

                        lblpaymentbalancedue.Text = Format(Val(lblpaidpayment.Text) - Val(Subtotallbl.Text), "####0.00")

                        da = New OdbcDataAdapter("Select id as 'ID', type as 'Type', cardno as 'Card Number', amount as 'Amount' from Temppayments where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                        dt = New DataTable()
                        da.Fill(dt)
                        Paymentdatagridview1.DataSource = dt
                        Paymentdatagridview1.Columns(0).Width = 60
                        Paymentdatagridview1.Columns(1).Width = 100
                        Paymentdatagridview1.Columns(2).Width = 200
                        Paymentdatagridview1.Columns(3).Width = 100
                        Paymentdatagridview1.Columns(3).DefaultCellStyle.Format = "####0.00"

                        Paymentdatagridview1.Refresh()

                        Paymentdatagridview1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        Paymentdatagridview1.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        Paymentdatagridview1.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        Paymentdatagridview1.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                        Paymentdatagridview1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                        btninvcheckout.Focus()
                        btninvcheckout.Select()

                        'CustomerDISPLAY("PAYMENT:", True, Cpayementlbl.Text, "BALANCE:", True, Balanceduelbl.Text)

                    End If

                Else

                    MessageBox.Show("Please Enter Valid Number Format...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                End If

        End Select

    End Sub


    Private Sub btnpaychequecancel_Click(sender As Object, e As EventArgs) Handles btnpaychequecancel.Click
        Chequepanel.Hide()
        PayementsPanel.Show()
    End Sub

    Private Sub btncustomers_Click(sender As Object, e As EventArgs) Handles btncustomers.Click

        txtinvitemssearch.Text = "Search Customers"
        txtinvitemssearch.Focus()
        txtinvitemssearch.SelectAll()
        PayementsPanel.Hide()
        ItemsPanel.Hide()
        Statementpanel.Hide()
        welcomepanel.Hide()
        Customerspanel.Show()

    End Sub

    Private Sub btnitems_Click(sender As Object, e As EventArgs) Handles btnitems.Click

        txtinvitemssearch.Text = "Search Items"
        txtinvitemssearch.Focus()
        txtinvitemssearch.SelectAll()
        PayementsPanel.Hide()
        Statementpanel.Hide()
        Customerspanel.Hide()
        welcomepanel.Hide()
        ItemsPanel.Show()

    End Sub

    Private Sub customersdatagridview_KeyDown(sender As Object, e As KeyEventArgs) Handles customersdatagridview.KeyDown
        Try

            Select Case e.KeyCode

                Case Keys.Enter

                    Dim i As Integer
                    i = customersdatagridview.CurrentRow.Index
                    cmbinvcustno.Text = customersdatagridview.Item(0, i).Value
                    cmbinvcustname.Text = customersdatagridview.Item(1, i).Value
                    lblcustomername.Text = customersdatagridview.Item(1, i).Value
                    lbloutstanding.Text = Format(Val(customersdatagridview.Item(2, i).Value), "0#########")

                    cn.Open()
                    Dim DF As Integer
                    Dim Balance As Double
                    cmd2 = New OdbcCommand("select TOP(1)* from statement where custcode='" & cmbinvcustno.Text & "' and loca='" & loca & "' order by ID DESC", cn)
                    dr2 = cmd2.ExecuteReader()
                    dr2.Read()
                    If dr2.HasRows Then
                        Balance = dr2("Balance")
                        DF = DateDiff(DateInterval.Day, dr2("datelong"), Now)
                    Else
                        Balance = "0.00"
                    End If
                    dr2.Close()
                    cn.Close()
                    lbloutstanding.Text = Format(Balance, "###0.00")

                    cn.Open()
                    cmd2 = New OdbcCommand("select * from Customer where code='" & cmbinvcustno.Text & "' and loca='" & loca & "'", cn)
                    dr2 = cmd2.ExecuteReader()
                    dr2.Read()
                    If dr2.HasRows Then
                        CreditLimit = dr2("credit")
                    End If
                    dr2.Close()
                    cn.Close()

                    cn.Open()
                    cmd2 = New OdbcCommand("select  distinct invoiceno from invoice where custcode='" & customersdatagridview.Item(0, i).Value & "' and loca='" & loca & "'", cn)
                    dr2 = cmd2.ExecuteReader()
                    If dr2.HasRows Then
                        While dr2.Read
                            cmbrecallinvnoload.Items.Add(Trim(dr2.Item("invoiceno")))
                        End While
                    End If
                    dr2.Close()
                    cn.Close()

                    btnitems_Click(sender, e)

                Case Keys.Escape
                    txtinvitemssearch.Focus()
                    txtinvitemssearch.SelectAll()

            End Select

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub btnremovelast_Click(sender As Object, e As EventArgs) Handles btnremovelast.Click

        Try

            cmd = New OdbcCommand("Delete Tempinvoice where Id='" & invaddcartdatagridview.Rows.Count & "' and loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
            cmd.ExecuteNonQuery()

            da = New OdbcDataAdapter("Select id as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price',ourprice as 'Our Price' quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Tempinvoice where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
            dt = New DataTable()
            da.Fill(dt)
            invaddcartdatagridview.DataSource = dt
            invaddcartdatagridview.Refresh()

            Dim discount As String = 0
            Dim stotal As String = 0
            Dim scharge As String = 0
            For i As Integer = 0 To invaddcartdatagridview.RowCount - 1
                discount += invaddcartdatagridview.Rows(i).Cells(6).Value
                stotal += invaddcartdatagridview.Rows(i).Cells(7).Value
                scharge += invaddcartdatagridview.Rows(i).Cells(5).Value
            Next

            lblinvtotaldiscount.Text = Format(Val(discount), "####0")
            lblinvtotalamount.Text = Format(Val(stotal), "####0.00")
            lblinvtotalqty.Text = Format(Val(scharge), "####0")
            lblnettotal.Text = Format(Val(lblinvtotalamount.Text), "###0.00")
            Subtotallbl.Text = Format(Val(lblinvtotalamount.Text), "###0.00")

            Dim a As Integer
            For a = 0 To invaddcartdatagridview.Rows.Count - 1
                If Mid(invaddcartdatagridview.Rows(a).Cells(4).Value, 1, 1) = "-" Then
                    invaddcartdatagridview.Rows(a).DefaultCellStyle.BackColor = Color.PaleVioletRed
                End If
            Next

            txtinvitemssearch.Focus()
            txtinvitemssearch.SelectAll()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btndeleteselected_Click(sender As Object, e As EventArgs) Handles btndeleteselected.Click

        Dim result As DialogResult = MessageBox.Show("Are You Sure Delete Selected Data..?", Me.Text, MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then

            Dim IDD As Integer = 1
            cmd = New OdbcCommand("Delete Tempinvoice where Id='" & invaddcartdatagridview.Item(0, invaddcartdatagridview.CurrentRow.Index).Value & "' and loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
            cmd.ExecuteNonQuery()

            cmd = New OdbcCommand("select * from Tempinvoice where loca='" & loca & "'and unit='" & lblinvunit.Text & "'", cn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    cn.Open()
                    cmd = New OdbcCommand("Update Tempinvoice set Id='" & IDD & "' where Id='" & Trim(dr.Item("Id")) & "' and loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    IDD = IDD + 1
                End While
            End If

        End If
        dr.Close()

        da = New OdbcDataAdapter("Select id as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Tempinvoice where loca='" & loca & "' and unit='" & lblinvunit.Text & "' order by id asc", cn)
        dt = New DataTable()
        da.Fill(dt)
        invaddcartdatagridview.DataSource = dt

        Dim discount As String = 0
        Dim stotal As String = 0
        Dim scharge As String = 0

        For i As Integer = 0 To invaddcartdatagridview.RowCount - 1

            discount += invaddcartdatagridview.Rows(i).Cells(5).Value
            stotal += invaddcartdatagridview.Rows(i).Cells(6).Value
            scharge += invaddcartdatagridview.Rows(i).Cells(4).Value

        Next

        lblinvtotaldiscount.Text = Format(Val(discount), "####0")
        lblinvtotalamount.Text = Format(Val(stotal), "####0.00")
        lblinvtotalqty.Text = Format(Val(scharge), "####0")
        lblnettotal.Text = Format(Val(lblinvtotalamount.Text), "###0.00")
        Subtotallbl.Text = Format(Val(lblinvtotalamount.Text), "###0.00")

        Dim a As Integer

        For a = 0 To invaddcartdatagridview.Rows.Count - 1

            If Mid(invaddcartdatagridview.Rows(a).Cells(4).Value, 1, 1) = "-" Then
                invaddcartdatagridview.Rows(a).DefaultCellStyle.BackColor = Color.PaleVioletRed
            End If

        Next

    End Sub

    Private Sub btnhold_Click(sender As Object, e As EventArgs) Handles btnhold.Click

        da = New OdbcDataAdapter("Select id as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Itemshold", cn)
        dt = New DataTable()
        da.Fill(dt)
        invaddcartdatagridview.DataSource = dt

        invaddcartdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        invaddcartdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        invaddcartdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        invaddcartdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        invaddcartdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        invaddcartdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        invaddcartdatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        invaddcartdatagridview.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        invaddcartdatagridview.Columns(3).DefaultCellStyle.Format = "####0.00"
        invaddcartdatagridview.Columns(4).DefaultCellStyle.Format = "####0"
        invaddcartdatagridview.Columns(5).DefaultCellStyle.Format = "####0"
        invaddcartdatagridview.Columns(6).DefaultCellStyle.Format = "####0.00"

    End Sub

    Private Sub btnunhold_Click(sender As Object, e As EventArgs) Handles btnunhold.Click

        Dim i As Integer
        i = invaddcartdatagridview.CurrentRow.Index
        tid = invaddcartdatagridview.Item(0, i).Value
        tCode = invaddcartdatagridview.Item(1, i).Value
        description = invaddcartdatagridview.Item(2, i).Value
        unit = invaddcartdatagridview.Item(3, i).Value
        qty = invaddcartdatagridview.Item(4, i).Value
        discount = invaddcartdatagridview.Item(5, i).Value
        amount = invaddcartdatagridview.Item(6, i).Value

        Dim result As DialogResult = MessageBox.Show("All You Sure This Item Hold..?", Me.Text, MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then

            cmd = New Odbc.OdbcCommand("select COUNT(DISTINCT holdid) AS IDD from Itemshold", cn)
            dr = cmd.ExecuteReader()
            dr.Read()
            Dim ID As Integer
            If dr.HasRows Then
                ID = dr.Item("IDD")
                ID = ID + 1
            End If
            dr.Close()

            cmd = New Odbc.OdbcCommand("INSERT INTO Itemshold Values('" & ID & "','" & Trim(cmbinvcustno.Text) & "','" & cmbinvcustname.Text & "','" & tid & "','" & tCode & "','" & description & "','" & unit & "','" & qty & "','" & discount & "','" & amount & "','" & loca & "')", cn)
            cmd.ExecuteNonQuery()

            cmd = New Odbc.OdbcCommand("delete from Tempinvoice", cn)
            cmd.ExecuteNonQuery()
            lblinvtotaldiscount.Text = "00"
            lblinvtotalamount.Text = "0.00"
            lblinvtotalqty.Text = "00"
            lblnettotal.Text = "0.00"

            da = New OdbcDataAdapter("Select Id as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Tempinvoice", cn)
            dt = New DataTable()
            da.Fill(dt)
            invaddcartdatagridview.DataSource = dt
            invaddcartdatagridview.Refresh()

        End If

    End Sub

    Private Sub btnprintlastbill_Click(sender As Object, e As EventArgs) Handles btnprintlastbill.Click
        Try

            cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_Invoice as select * from Invoice where Invoiceno='" & cmbinvloadprint.Text & "'", cn)
            cmd.ExecuteNonQuery()
            RPTFile = My.Application.Info.DirectoryPath & "\RPT\Receipt.rpt"
            Reportviewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmbinvloadprint_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbinvloadprint.SelectedValueChanged

        Try
            cmd = New OdbcCommand("select * from Invoice where invoiceno='" & cmbinvloadprint.Text & "' and loca='" & loca & "' and unitno='" & lblinvno.Text & "'", cn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblloadprintname.Text = dr("custname")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btndeleteselected_KeyDown(sender As Object, e As KeyEventArgs) Handles btndeleteselected.KeyDown

        Select Case e.KeyCode

            Case Keys.Delete
                Dim result As DialogResult = MessageBox.Show("Are You Sure Delete Selected Data..?", Me.Text, MessageBoxButtons.YesNo)
                If result = Windows.Forms.DialogResult.Yes Then

                    Dim IDD As Integer = 1
                    cmd = New OdbcCommand("Delete Tempinvoice where Id='" & invaddcartdatagridview.Item(0, invaddcartdatagridview.CurrentRow.Index).Value & "' and loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                    cmd.ExecuteNonQuery()

                    cmd = New OdbcCommand("select * from Tempinvoice where loca='" & loca & "'and unit='" & lblinvunit.Text & "'", cn)
                    dr = cmd.ExecuteReader()
                    If dr.HasRows Then
                        While dr.Read
                            cn.Open()
                            cmd = New OdbcCommand("Update Tempinvoice set Id='" & IDD & "' where Id='" & Trim(dr.Item("Id")) & "' and loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                            cmd.ExecuteNonQuery()
                            cn.Close()
                            IDD = IDD + 1
                        End While
                    End If

                End If
                dr.Close()

                da = New OdbcDataAdapter("Select id as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Tempinvoice where loca='" & loca & "' and unit='" & lblinvunit.Text & "' order by id asc", cn)
                dt = New DataTable()
                da.Fill(dt)
                invaddcartdatagridview.DataSource = dt

                Dim discount As String = 0
                Dim stotal As String = 0
                Dim scharge As String = 0

                For i As Integer = 0 To invaddcartdatagridview.RowCount - 1

                    discount += invaddcartdatagridview.Rows(i).Cells(5).Value
                    stotal += invaddcartdatagridview.Rows(i).Cells(6).Value
                    scharge += invaddcartdatagridview.Rows(i).Cells(4).Value

                Next

                lblinvtotaldiscount.Text = Format(Val(discount), "####0")
                lblinvtotalamount.Text = Format(Val(stotal), "####0.00")
                lblinvtotalqty.Text = Format(Val(scharge), "####0")
                lblnettotal.Text = Format(Val(lblinvtotalamount.Text), "###0.00")
                Subtotallbl.Text = Format(Val(lblinvtotalamount.Text), "###0.00")

                Dim a As Integer

                For a = 0 To invaddcartdatagridview.Rows.Count - 1

                    If Mid(invaddcartdatagridview.Rows(a).Cells(4).Value, 1, 1) = "-" Then
                        invaddcartdatagridview.Rows(a).DefaultCellStyle.BackColor = Color.PaleVioletRed
                    End If

                Next

        End Select

    End Sub

    Private Sub btnremovelast_KeyDown(sender As Object, e As KeyEventArgs) Handles btnremovelast.KeyDown

        Select Case e.KeyCode

            Case Keys.F4

                Try

                    cmd = New OdbcCommand("Delete Tempinvoice where Id='" & invaddcartdatagridview.Rows.Count & "' and loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                    cmd.ExecuteNonQuery()

                    da = New OdbcDataAdapter("Select id as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Tempinvoice where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                    dt = New DataTable()
                    da.Fill(dt)
                    invaddcartdatagridview.DataSource = dt
                    invaddcartdatagridview.Refresh()

                    Dim discount As String = 0
                    Dim stotal As String = 0
                    Dim scharge As String = 0
                    For i As Integer = 0 To invaddcartdatagridview.RowCount - 1
                        discount += invaddcartdatagridview.Rows(i).Cells(5).Value
                        stotal += invaddcartdatagridview.Rows(i).Cells(6).Value
                        scharge += invaddcartdatagridview.Rows(i).Cells(4).Value
                    Next

                    lblinvtotaldiscount.Text = Format(Val(discount), "####0")
                    lblinvtotalamount.Text = Format(Val(stotal), "####0.00")
                    lblinvtotalqty.Text = Format(Val(scharge), "####0")
                    lblnettotal.Text = Format(Val(lblinvtotalamount.Text), "###0.00")
                    Subtotallbl.Text = Format(Val(lblinvtotalamount.Text), "###0.00")

                    Dim a As Integer
                    For a = 0 To invaddcartdatagridview.Rows.Count - 1
                        If Mid(invaddcartdatagridview.Rows(a).Cells(4).Value, 1, 1) = "-" Then
                            invaddcartdatagridview.Rows(a).DefaultCellStyle.BackColor = Color.PaleVioletRed
                        End If
                    Next

                    txtinvitemssearch.Focus()
                    txtinvitemssearch.SelectAll()

                Catch ex As Exception

                    MsgBox(ex.Message)

                End Try

        End Select

    End Sub

    Private Sub btnunhold_KeyDown(sender As Object, e As KeyEventArgs) Handles btnunhold.KeyDown

        Select Case e.KeyCode

            Case Keys.F9

                Dim i As Integer
                i = invaddcartdatagridview.CurrentRow.Index
                tid = invaddcartdatagridview.Item(0, i).Value
                tCode = invaddcartdatagridview.Item(1, i).Value
                description = invaddcartdatagridview.Item(2, i).Value
                unit = invaddcartdatagridview.Item(3, i).Value
                qty = invaddcartdatagridview.Item(4, i).Value
                discount = invaddcartdatagridview.Item(5, i).Value
                amount = invaddcartdatagridview.Item(6, i).Value

                Dim result As DialogResult = MessageBox.Show("All You Sure This Item Hold..?", Me.Text, MessageBoxButtons.YesNo)
                If result = Windows.Forms.DialogResult.Yes Then

                    cmd = New Odbc.OdbcCommand("select COUNT(DISTINCT holdid) AS IDD from Itemshold", cn)
                    dr = cmd.ExecuteReader()
                    dr.Read()
                    Dim ID As Integer
                    If dr.HasRows Then
                        ID = dr.Item("IDD")
                        ID = ID + 1
                    End If
                    dr.Close()

                    cmd = New Odbc.OdbcCommand("INSERT INTO Itemshold Values('" & ID & "','" & Trim(cmbinvcustno.Text) & "','" & cmbinvcustname.Text & "','" & tid & "','" & tCode & "','" & description & "','" & unit & "','" & qty & "','" & discount & "','" & amount & "','" & loca & "')", cn)
                    cmd.ExecuteNonQuery()

                    cmd = New Odbc.OdbcCommand("delete from Tempinvoice", cn)
                    cmd.ExecuteNonQuery()
                    lblinvtotaldiscount.Text = "00"
                    lblinvtotalamount.Text = "0.00"
                    lblinvtotalqty.Text = "00"
                    lblnettotal.Text = "0.00"

                    da = New OdbcDataAdapter("Select Id as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Tempinvoice", cn)
                    dt = New DataTable()
                    da.Fill(dt)
                    invaddcartdatagridview.DataSource = dt
                    invaddcartdatagridview.Refresh()

                End If

        End Select

    End Sub

    Private Sub btnhold_KeyDown(sender As Object, e As KeyEventArgs) Handles btnhold.KeyDown

        Select Case e.KeyCode

            Case Keys.F8

                da = New OdbcDataAdapter("Select  as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Itemshold", cn)
                dt = New DataTable()
                da.Fill(dt)
                invaddcartdatagridview.DataSource = dt

                invaddcartdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                invaddcartdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                invaddcartdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                invaddcartdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                invaddcartdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                invaddcartdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                invaddcartdatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                invaddcartdatagridview.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                invaddcartdatagridview.Columns(3).DefaultCellStyle.Format = "####0.00"
                invaddcartdatagridview.Columns(4).DefaultCellStyle.Format = "####0"
                invaddcartdatagridview.Columns(5).DefaultCellStyle.Format = "####0"
                invaddcartdatagridview.Columns(6).DefaultCellStyle.Format = "####0.00"

        End Select

    End Sub

    Private Sub btnstatement_Click(sender As Object, e As EventArgs) Handles btnstatement.Click
        Customerspanel.Hide()
        ItemsPanel.Hide()
        PayementsPanel.Hide()
        Statementpanel.Show()
        Mainstatementpanel.Show()
        welcomepanel.Hide()
        Settlementpanel.Hide()
        Settlementchequepanel.Hide()
        If cmbinvcustno.Text = "N/A" Then
        Else
            cmd = New OdbcCommand("select TOP(1)* from statement where custcode='" & cmbinvcustno.Text & "' and loca='" & loca & "' order by ID DESC", cn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If dr("Balance") > 0 Or dr("Balance") < 0 Then
                    Bl = dr("Balance")

                End If
            End If
            dr.Close()
        End If

        Mainstatementdatagridview.Rows.Clear()
        cmd = New OdbcCommand("select * from statement where custcode='" & cmbinvcustno.Text & "' and loca='" & loca & "' order by ID ASC", cn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                Mainstatementdatagridview.Rows.Add(dr("Id"), dr("datelong"), dr("description"), Format(dr("credit"), "####0.00"), Format(dr("received"), "####0.00"), Format(dr("balance"), "####0.00"))
            End While
            Statementpanel.Refresh()

            Mainstatementdatagridview.FirstDisplayedScrollingRowIndex = Mainstatementdatagridview.RowCount - 1
            Mainstatementdatagridview.Rows(Mainstatementdatagridview.RowCount - 1).Selected = True
        End If
        dr.Close()
    End Sub

    Private Sub btnstatement_KeyDown(sender As Object, e As KeyEventArgs) Handles btnstatement.KeyDown

        Select Case e.KeyCode

            Case Keys.F8

                If cmbinvcustno.Text = "N/A" Then
                Else
                    cmd = New OdbcCommand("select TOP(1)* from statement where custcode='" & cmbinvcustno.Text & "' and loca='" & loca & "' order by ID DESC", cn)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        If dr("Balance") > 0 Or dr("Balance") < 0 Then
                            Bl = dr("Balance")
                            Customerspanel.Hide()
                            ItemsPanel.Hide()
                            PayementsPanel.Hide()
                            Statementpanel.Show()
                        End If
                    End If
                    dr.Close()
                End If

                Mainstatementdatagridview.Rows.Clear()
                cmd = New OdbcCommand("select * from statement where custcode='" & cmbinvcustno.Text & "' and loca='" & loca & "' order by ID ASC", cn)
                dr = cmd.ExecuteReader
                If dr.HasRows Then
                    While dr.Read
                        Mainstatementdatagridview.Rows.Add(dr("Id"), dr("datelong"), dr("description"), Format(dr("credit"), "####0.00"), Format(dr("received"), "####0.00"), Format(dr("balance"), "####0.00"))
                    End While
                    Statementpanel.Refresh()

                    Mainstatementdatagridview.FirstDisplayedScrollingRowIndex = Mainstatementdatagridview.RowCount - 1
                    Mainstatementdatagridview.Rows(Mainstatementdatagridview.RowCount - 1).Selected = True
                End If
                dr.Close()

        End Select

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Settlementpanel.Show()
        lblstheadertitle.Text = "Settlement"

        cmd = New OdbcCommand("select COUNT(distinct docno) as IDD from Settlement", cn)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim ID As Integer = 0
        If dr.HasRows Then
            ID = dr.Item("IDD")
            ID = ID + 1
        Else
            ID = ID + 1
        End If
        dr.Close()

        cmbstdocno.Text = Format(ID, "000#")
        CmbstType.Focus()
        CmbstType.SelectedIndex = 0

    End Sub

    Private Sub btnschequesave_Click(sender As Object, e As EventArgs) Handles btnschequesave.Click
        If txtstamount.TextLength > 0 Then
            txtstamount.Text = Format(Val(lblstchequetotal.Text), "####0.00")
            Settlementchequepanel.Hide()
        End If
    End Sub

    Private Sub btnchequecancel_Click(sender As Object, e As EventArgs) Handles btnchequecancel.Click
        Settlementchequepanel.Hide()
        CmbstType.Focus()
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter

                'Cheque Entry Settlements

                cmd = New OdbcCommand("select COUNT(Id) as IDD from Tempcheque where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                dr = cmd.ExecuteReader()
                dr.Read()
                Dim ID As Integer = 1
                If dr.HasRows Then
                    ID = dr.Item("IDD")
                    ID = ID + 1
                End If
                dr.Close()

                cmd = New OdbcCommand("INSERT INTO Tempcheque Values('" & ID & "','" & cmbstbank.Text & "','" & txtstchequeno.Text & "','" & cmbstbranch.Text & "','" & Format(dpstchequedate.Value, "yyyy-MMM-dd") & "','" & txtstamount.Text & "','" & loca & "','" & lblinvunit.Text & "')", cn)
                cmd.ExecuteNonQuery()

                cmd = New OdbcCommand("select SUM(amount) as Total from Tempcheque  where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then
                    lblstchequetotal.Text = Format(dr.Item("Total"), "####0.00")
                End If
                dr.Close()

                da = New OdbcDataAdapter("Select Id as 'ID',  bank as 'Bank', branch as 'Branch', chequeno as 'Cheque No', chequedate as 'Date', amount as 'Amount' from Tempcheque where unit='" & lblinvunit.Text & "' and loca='" & loca & "'", cn)
                dt = New DataTable()
                da.Fill(dt)
                Stchquedatagridview.DataSource = dt
                Stchquedatagridview.Columns(0).Width = 40
                Stchquedatagridview.Columns(1).Width = 180
                Stchquedatagridview.Columns(2).Width = 140
                Stchquedatagridview.Columns(3).Width = 80
                Stchquedatagridview.Columns(4).Width = 80
                Stchquedatagridview.Columns(5).Width = 80
                Stchquedatagridview.Columns(5).DefaultCellStyle.Format = "####0.00"

                Stchquedatagridview.Refresh()

                Stchquedatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Stchquedatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Stchquedatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                Stchquedatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Stchquedatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Stchquedatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Stchquedatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                cmbstbank.Select()
                txtstchequeno.Text = ""
                cmbstbank.Text = ""
                cmbstbranch.Select()
                txtstamount.Text = ""

                txtstchequeno.Focus()

                'End Cheque Entry Settlements

        End Select
    End Sub

    Private Sub txtstamount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtstamount.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnstsettlementsave.Focus()
                btnstsettlementsave.Select()
            Case Keys.Escape
                txtstamount.Focus()
        End Select
    End Sub

    Private Sub btnstsettlementsave_Click(sender As Object, e As EventArgs) Handles btnstsettlementsave.Click
        Try

            cmd = New OdbcCommand("select COUNT(id) as IDD from Settlement where custcode='" & cmbinvcustno.Text & "' and loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            dr.Read()
            Dim ID As Integer = 0
            If dr.HasRows Then
                ID = dr.Item("IDD")
                ID = ID + 1
            Else
                ID = ID + 1
            End If
            dr.Close()

            Dim IDD As Integer
            Dim NewBalance As Double
            cmd = New OdbcCommand("select TOP(1)* from statement where custcode='" & cmbinvcustno.Text & "' and loca='" & loca & "' order by ID DESC", cn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If dr("Balance") > 0 Then
                    Bl = dr("Balance")
                    IDD = dr("ID") + 1
                End If
            End If
            dr.Close()

            cmd = New OdbcCommand("INSERT INTO Settlement Values('" & ID & "','" & cmbstdocno.Text & "','" & CmbstType.Text & "','" & txtstamount.Text & "','" & Format(Now, "yyyy-MMM-dd") & "','" & Format(Now, "yyMMdd") & "','" & loca & "','" & cmbinvcustno.Text & "','" & cmbinvcustname.Text & "','" & Bl & "','" & Trim(lblinvunit.Text) & "')", cn)
            cmd.ExecuteNonQuery()

            If Val(txtstamount.Text) = Bl Then
                cn.Open()
                cmd3 = New OdbcCommand("delete from Statement where custcode='" & cmbinvcustno.Text & "' and loca='" & loca & "'", cn)
                cmd3.ExecuteNonQuery()
                cn.Close()
            Else
                NewBalance = Bl - Val(txtstamount.Text)
                cn.Open()
                cmd3 = New OdbcCommand("INSERT INTO Statement Values('" & IDD & "','" & cmbinvcustno.Text & "','" & cmbinvcustname.Text & "','" & CmbstType.Text & "','" & "0" & "','" & txtstamount.Text & "','" & NewBalance & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & loca & "')", cn)
                cmd3.ExecuteNonQuery()
                cn.Close()

                cn.Open()
                cmd3 = New OdbcCommand("INSERT INTO Statementhistory Values('" & IDD & "','" & cmbinvcustno.Text & "','" & cmbinvcustname.Text & "','" & CmbstType.Text & "','" & "0" & "','" & txtstamount.Text & "','" & NewBalance & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & loca & "')", cn)
                cmd3.ExecuteNonQuery()
                cn.Close()

                'cn.Open()
                'cmd3 = New OdbcCommand("INSERT INTO SMS Values('" & cmbinvcustno.Text & "','" & cmbinvcustname.Text & "','" & lbloutstanding.Text & "','" & "We received your payement of LKR: " & Format(Val(txtstamount.Text), "###.00") & " on " & Format(Now, "yyyy-MMM-dd") & " " & Format(Now, "hh:mm:ss tt") & ", Which brings your balance LKR: " & Format(NewBalance, "###.00") & " , " & CompanyName1 & " - 0452287396" & "','" & "Date1" & "','" & "Datec" & "')", cn)
                'cmd3.ExecuteNonQuery()
                'cn.Close()

            End If


            cmd = New OdbcCommand("ALTER VIEW RPT_Settlements as select * from Settlement  where docno='" & cmbstdocno.Text & "' and unit='" & lblinvunit.Text & "' and loca='" & loca & "'", cn)
            cmd.ExecuteNonQuery()

            'To Printer
            reportDocument1.Load(My.Application.Info.DirectoryPath & "\RPT\Settlements.rpt")
            reportDocument1.SetDatabaseLogon(SQLUsername, SQLPassword)
            reportDocument1.Refresh()
            reportDocument1.PrintToPrinter(1, False, 0, 0)
            'End printer

            btnstatement_Click(sender, e)
            Settlementpanel.Hide()

            MessageBox.Show("Successfully Save Data", "Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information)

            txtstamount.Text = ""

            Settlementpanel.Hide()
            btnstatement_Click(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnstsettlementcancel_Click(sender As Object, e As EventArgs) Handles btnstsettlementcancel.Click
        Settlementpanel.Hide()
    End Sub

    Private Sub CmbstType_KeyDown(sender As Object, e As KeyEventArgs) Handles CmbstType.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If CmbstType.Text = "Cheque" Then
                    Settlementchequepanel.Show()
                    txtstamount.Focus()
                    txtstamount.SelectAll()
                Else
                    Settlementchequepanel.Hide()
                    txtstamount.Focus()
                    txtstamount.SelectAll()
                End If
            Case Keys.Escape
                CmbstType.Focus()
        End Select
    End Sub

    Private Sub cmbinvloadprint_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbinvloadprint.SelectedIndexChanged
        Try
            cmd = New OdbcCommand("select * from Invoice where invoiceno='" & cmbinvloadprint.Text & "' and loca='" & loca & "' and unitno='" & lblinvunit.Text & "'", cn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblloadprintname.Text = dr("custname")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnrecallbill_Click(sender As Object, e As EventArgs) Handles btnrecallbill.Click

        Try
            cn.Open()
            cmd4 = New OdbcCommand("select * from Invoice where invoiceno='" & cmbrecallinvnoload.Text & "' and loca='" & loca & "' and unitno='" & lblinvunit.Text & "'", cn)
            dr4 = cmd4.ExecuteReader
            If dr4.HasRows Then
                While dr4.Read

                    'lblrecallcustname.Text = dr("custname")

                    cmd = New OdbcCommand("select MAX(id) as IDD from Tempinvoice where loca='" & loca & "' and unit='" & lblinvunit.Text & "'", cn)
                    dr = cmd.ExecuteReader()
                    dr.Read()
                    Dim ID As Integer = 0
                    If dr.HasRows Then
                        ID = dr.Item("IDD")
                        ID = ID + 1
                    Else
                        ID = ID + 1
                    End If
                    dr.Close()

                    cmd = New OdbcCommand("INSERT INTO Tempinvoice Values('" & ID & "','" & dr4("code") & "','" & dr4("name") & "','" & dr4("costprice") & "','" & dr4("quantity") & "','" & Format(Val(dr4("discount")), "####0") & "','" & dr4("amount") & "','" & dr4("loca") & "','" & dr4("unitno") & "','" & dr4("ourprice") & "')", cn)
                    cmd.ExecuteNonQuery()

                    da = New OdbcDataAdapter("Select id as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price', ourprice as 'Our Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Tempinvoice where loca='" & loca & "' and unit='" & lblinvunit.Text & "' order by id asc", cn)
                    dt = New DataTable()
                    da.Fill(dt)
                    invaddcartdatagridview.DataSource = dt

                    invaddcartdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    invaddcartdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    invaddcartdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    invaddcartdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    invaddcartdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    invaddcartdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    invaddcartdatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    invaddcartdatagridview.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    invaddcartdatagridview.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    invaddcartdatagridview.Columns(3).DefaultCellStyle.Format = "####0.00" '// Cost Price
                    invaddcartdatagridview.Columns(4).DefaultCellStyle.Format = "####0.00" '// Our Price
                    invaddcartdatagridview.Columns(5).DefaultCellStyle.Format = "####0" '// Quantity
                    invaddcartdatagridview.Columns(6).DefaultCellStyle.Format = "####0" '// Discount
                    invaddcartdatagridview.Columns(7).DefaultCellStyle.Format = "####0.00" '// Amount
                    txtinvitemssearch.Focus()
                    txtinvitemssearch.SelectAll()

                    Dim discount As String = 0
                    Dim stotal As String = 0
                    Dim scharge As String = 0
                    For i As Integer = 0 To invaddcartdatagridview.RowCount - 1
                        discount += invaddcartdatagridview.Rows(i).Cells(6).Value
                        stotal += invaddcartdatagridview.Rows(i).Cells(7).Value
                        scharge += invaddcartdatagridview.Rows(i).Cells(4).Value
                    Next

                    lblinvtotaldiscount.Text = Format(Val(discount), "####0")
                    lblinvtotalamount.Text = Format(Val(stotal), "####0.00")
                    lblinvtotalqty.Text = Format(Val(scharge), "####0")
                    lblnettotal.Text = Format(Val(lblinvtotalamount.Text), "###0.00")
                    Subtotallbl.Text = Format(Val(lblinvtotalamount.Text), "###0.00")

                    invaddcartdatagridview.Columns(0).Width = 60
                    invaddcartdatagridview.Columns(1).Width = 80
                    invaddcartdatagridview.Columns(2).Width = 220
                    invaddcartdatagridview.Columns(3).Width = 80
                    invaddcartdatagridview.Columns(4).Width = 80
                    invaddcartdatagridview.Columns(5).Width = 80
                    invaddcartdatagridview.Columns(6).Width = 80
                    invaddcartdatagridview.Columns(7).Width = 80

                    'CustomerDISPLAY("LINE:", True, Amounttxt.Text, "SUB TOTAL:", True, NetTotal.Text)

                    txtinvitemsqty.Text = "0"
                    txtinvitemsdiscount.Text = "0"
                    txtinvitemsamount.Text = "0.00"

                    invaddcartdatagridview.FirstDisplayedScrollingRowIndex = invaddcartdatagridview.RowCount - 1
                    invaddcartdatagridview.Rows(invaddcartdatagridview.RowCount - 1).Selected = True

                    Dim a As Integer
                    For a = 0 To invaddcartdatagridview.Rows.Count - 1
                        If Mid(invaddcartdatagridview.Rows(a).Cells(4).Value, 1, 1) = "-" Then
                            invaddcartdatagridview.Rows(a).DefaultCellStyle.BackColor = Color.PaleVioletRed
                        End If
                    Next


                End While

            End If
            dr4.Close()
            cn.Close()


            txtinvitemssearch.Focus()
            txtinvitemssearch.SelectAll()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmbrecallinvnoload_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbrecallinvnoload.SelectedIndexChanged

        Try

            cmd = New OdbcCommand("select * from Invoice where invoiceno='" & cmbrecallinvnoload.Text & "' and  loca='" & loca & "' and unitno='" & lblinvunit.Text & "'", cn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblrecallcustname.Text = dr("custname")
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmbrecallinvnoload_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmbrecallinvnoload.SelectedValueChanged

        Try

            cmd = New OdbcCommand("select * from Invoice where invoiceno='" & cmbrecallinvnoload.Text & "' and loca='" & loca & "' and unitno='" & lblinvunit.Text & "'", cn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblrecallcustname.Text = dr("custname")
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnstatementprint.Click

        Try
            Dim INPUT As Integer
            INPUT = InputBox("How many Days You want to print Statement..?", "Statement")

            Dim de As Integer = -+INPUT
            Dim newDate As Date = DateAdd(DateInterval.Day, de, Now)

            cmd = New OdbcCommand("ALTER VIEW RPT_Statement as select * from Statement where custcode='" & Trim(cmbinvcustno.Text) & "' and loca='" & loca & "' and dateshort >='" & Format(newDate, "yyMMdd") & "' and dateshort <='" & Format(Now, "yyMMdd") & "'", cn)
            cmd.ExecuteNonQuery()

            'reportDocument1.Load(My.Application.Info.DirectoryPath & "\RPT\Statement.rpt")
            'reportDocument1.SetDatabaseLogon(SQLUsername, SQLPassword)
            'reportDocument1.Refresh()
            'reportDocument1.PrintToPrinter(1, False, 0, 0)
            RPTFile = My.Application.Info.DirectoryPath & "\RPT\Statement.rpt"
            Reportviewer.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnministatemnetprint.Click

        Try
            Dim de As Integer = -30
            Dim newDate As Date = DateAdd(DateInterval.Day, de, Now)

            cmd = New OdbcCommand("ALTER VIEW RPT_Statement as select * from Statement where custcode='" & Trim(cmbinvcustno.Text) & "' and loca='" & loca & "' and dateshort >='" & Format(newDate, "yyMMdd") & "' and dateshort <='" & Format(Now, "yyMMdd") & "'", cn)
            cmd.ExecuteNonQuery()

            reportDocument1.Load(My.Application.Info.DirectoryPath & "\RPT\MiniStatement.rpt")
            reportDocument1.SetDatabaseLogon(SQLUsername, SQLPassword)
            reportDocument1.Refresh()
            reportDocument1.PrintToPrinter(1, False, 0, 0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtinvalldiscounts_KeyDown(sender As Object, e As KeyEventArgs) Handles txtinvalldiscounts.KeyDown

        Select Case e.KeyCode

            Case Keys.Enter

                If Mid(txtinvalldiscounts.Text, txtinvalldiscounts.Text.Length) = "%" Then
                    txtinvalldiscounts.Text = txtinvalldiscounts.Text.Remove(txtinvalldiscounts.Text.Length - 1)

                    Dim AMT As Decimal
                    AMT = lblinvtotalqty.Text * Val(txtinvalldiscounts.Text) / 100

                    a = AMT * Val(lblinvtotalqty.Text)
                    txtinvalldiscounts.Text = Format(a, "####0.00")

                    lblinvtotalamount.Text = Format(Val(lblinvtotalamount.Text) - Val(txtinvalldiscounts.Text), "####0.00")
                    lblnettotal.Text = Format(Val(lblinvtotalamount.Text) - Val(txtinvalldiscounts.Text), "####0.00")
                    btnpay.Focus()

                Else
                    a = Val(txtinvalldiscounts.Text) * Val(lblinvtotalqty.Text)
                    txtinvalldiscounts.Text = Format(a, "#####0.00")

                    lblinvtotalamount.Text = Format(Val(lblinvtotalamount.Text) - Val(txtinvalldiscounts.Text), "####0.00")
                    lblnettotal.Text = Format(Val(lblinvtotalamount.Text) - Val(txtinvalldiscounts.Text), "####0.00")
                    btnpay.Focus()
                End If

            Case Keys.Escape

                txtinvitemssearch.Focus()
                txtinvitemssearch.SelectAll()

        End Select

    End Sub

    Private Sub txtinvalldiscounts_TextChanged(sender As Object, e As EventArgs) Handles txtinvalldiscounts.TextChanged

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub cart_api2_Enter(sender As Object, e As EventArgs) Handles cart_api2.Enter

    End Sub
End Class