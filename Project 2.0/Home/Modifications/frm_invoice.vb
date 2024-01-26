Imports System.Data.Odbc
Public Class frm_invoice
    Dim qty As String '// Selected Product Qty //
    Dim Price As String '// Selected Priduct Unit Price //
    Dim total_amount As String '// Selected Product Total Amount //
    Dim inx As Integer '// DGItems Current Row ,Row ID //
    Dim PCode As String '// Selected Product Code //
    Dim cash As Decimal = 0
    Public ex As String


    Private Sub GunaControlBox1_Click(sender As Object, e As EventArgs) Handles GunaControlBox1.Click

        If ex = "full" Then
            End

        Else
            Me.Dispose()
        End If

    End Sub

    Public Sub Load_items() '// Load Products to Grid //
        connection()
        DgItems.Rows.Clear()

        Try

            cmd.CommandText = "SELECT code,name,sellprice,ourprice,totalqty from items Where Barcode like '%" + txtSearch_items.Text + "%' or code like '%" + txtSearch_items.Text + "%' or name like '%" + txtSearch_items.Text + "%' and loca='" + loca + "' "
            cmd.Connection = cn
            dr = cmd.ExecuteReader

            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    DgItems.Rows.Add(dr("code"), dr("name"), dr("sellprice"), dr("ourprice"), dr("totalqty"))
                End If
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error In Items Load")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Public Sub invoice_no() '// Get New Invoice No //
        connection()

        Try
            cmd.CommandText = "SELECT MAX(INVOICENO)as ID From invoice Where loca='" + loca + "'"
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            Dim id As Integer
            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    id = dr(0) + 1
                    lblInvoice.Text = Format(id, "00000#")
                Else
                    lblInvoice.Text = "000001"
                End If
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error In Invoice No")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Public Sub Credit_customers()
        connection()
        comSearch_customer.Items.Clear()
        comSearch_customer.Items.Add("Cash Customer")
        Try
            cmd.CommandText = "SELECT name from customer WHERE loca='" + loca + "'"
            cmd.Connection = cn
            dr = cmd.ExecuteReader

            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    comSearch_customer.Items.Add(dr(0))
                End If
            End While
            dr.Close()
            cn.Close()
            comSearch_customer.Text = "Cash Customer"
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error In Load Customers")
            dr.Close()
            cn.Close()

        End Try
    End Sub

    Public Sub load_cart()
        connection()

        Try
            cmd.CommandText = "SELECT code,name,sellprice,ourprice FROM Items WHERE Code='" + PCode + "'"
            cmd.Connection = cn
            dr = cmd.ExecuteReader

            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    dgCart.Rows.Add(dr("code"), dr("name"), dr("sellprice"), dr("ourprice"), txtQuantity.Text, Format(Val(txtDiscount.Text), "#,##0.00"), total_amount)
                End If
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error In Load Cart")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Public Sub Items_hold() '// Items to be Hold //
        Dim HID As String
        Dim df As Boolean = False

        HID = "Hold" & " " & Now.ToShortDateString & Now.ToString("hh:mm:ss")
        For i As Integer = 0 To dgCart.RowCount - 2

            connection()
            Try
                cmd.CommandText = "Insert Into itemshold (holdid,custname,code,name,costprice,ourprice,quantity,discount,amount,loca) VALUES ('" + HID + "','" + comSearch_customer.Text + "','" + dgCart.Rows(i).Cells(0).Value.ToString + "','" + dgCart.Rows(i).Cells(1).Value.ToString + "','" + dgCart.Rows(i).Cells(2).Value.ToString + "','" + dgCart.Rows(i).Cells(3).Value.ToString + "','" + dgCart.Rows(i).Cells(4).Value.ToString + "','" + dgCart.Rows(i).Cells(5).Value.ToString + "','" + dgCart.Rows(i).Cells(6).Value.ToString + "','" + loca + "')"
                cmd.Connection = cn
                cmd.ExecuteNonQuery()
                cn.Close()

            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in Items Hold")
                cn.Close()

            End Try

        Next
        MsgBox("Items Hold Successfull", vbOKOnly + vbInformation, "Point Of Sale System")
        dgCart.Rows.Clear()
        Load_items()

        Credit_customers()
    End Sub

    Public Sub Load_Hold_items()
        connection()

        comHold_items.Items.Clear()

        Try
            cmd.CommandText = "SELECT holdid from itemshold WHERE loca='" + loca + "' Group by holdid"
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            While dr.Read

                If Not IsDBNull(dr(0)) Then
                    comHold_items.Items.Add(dr(0))
                End If
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error In Load Hold Items")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Public Sub Load_hold_items_Cart()
        invoice_no()

        connection()
        dgCart.Rows.Clear()

        Try
            cmd.CommandText = "SELECT * FROM itemshold WHERE holdid='" + comHold_items.Text + "' and loca='" + loca + "'"
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    dgCart.Rows.Add(dr("code"), dr("name"), dr("costprice"), dr("ourprice"), dr("quantity"), dr("discount"), dr("amount"))
                    comSearch_customer.Text = dr("custname")
                End If
            End While
            dr.Close()
            cn.Close()
            comPayment_method.StartIndex = 0
            txtSearch_items.Select()
            txtSearch_items.SelectAll()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Hold Items Cart")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Public Sub gen_receipt()
        Dim dt3 As New DataTable

        If chkPrint.Checked = True Then

            '// Print Receipt.

            connection()
            Try

                cmdx.CommandText = "SELECT * FROM Receipt WHERE invoiceno='" + lblInvoice.Text + "'"
                cmdx.Connection = cn
                Dim adp1 As New OdbcDataAdapter(cmdx)
                adp1.Fill(dt3)
                Dim rpt As New Cash_Bill1
                rpt.Database.Tables("Receipt").SetDataSource(dt3)
                rpt.Refresh()
                rpt.PrintToPrinter(1, False, 0, 0)
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in Cash Bill Print")
            End Try

        Else
            '// Preview Receipt

            connection()
            Try

                cmdx.CommandText = "SELECT * FROM Receipt WHERE invoiceno='" + lblInvoice.Text + "'"
                cmdx.Connection = cn
                Dim adp1 As New OdbcDataAdapter(cmdx)
                adp1.Fill(dt3)
                Dim rpt As New Cash_Bill1
                rpt.Database.Tables("Receipt").SetDataSource(dt3)
                Report_viewer.CRV.ReportSource = Nothing
                Report_viewer.CRV.ReportSource = rpt
                Report_viewer.CRV.Refresh()
                Report_viewer.CRV.RefreshReport()
                Report_viewer.Show()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in Cash Bill Preview")
            End Try

        End If
    End Sub

    Public Sub Pay_Amount() '// Pay For Bill //


        If Val(lblPaid.Text) < Val(lblGeand_total.Text) Then

            MsgBox("Need More Money to Proceed", vbOKOnly + vbQuestion, "Point Of Sale System")
            txtpaid.Select()
            txtpaid.SelectAll()
        Else

            Dim k As String
            For i As Integer = 0 To dgCart.RowCount - 1
                connection1()

                Try
                    cmd.CommandText = "Insert into invoice (invoiceno,cashier,custname,Icode,Iname,sellprice,ourprice,qty,discount,amount,dateshort,datelong,time,loca) VALUES ('" + lblInvoice.Text + "','" + lblUser.Text + "','" + comSearch_customer.Text.ToString + "','" + dgCart.Rows(i).Cells(0).Value.ToString() + "','" + dgCart.Rows(i).Cells(1).Value.ToString() + "','" + dgCart.Rows(i).Cells(2).Value.ToString() + "','" + dgCart.Rows(i).Cells(3).Value.ToString() + "','" + dgCart.Rows(i).Cells(4).Value.ToString() + "','" + dgCart.Rows(i).Cells(5).Value.ToString() + "','" + dgCart.Rows(i).Cells(6).Value.ToString() + "','" + Format(Now, "yyMMdd") + "','" + Format(Now, "yyyy-MMM-dd") + "','" + Now.ToShortTimeString + "','" + loca + "'); UPDATE items SET totalqty=totalqty-'" + dgCart.Rows(i).Cells(4).Value.ToString() + "' WHERE code='" + dgCart.Rows(i).Cells(0).Value.ToString() + "' and loca='" + loca + "'"
                    cmd.Connection = cn1
                    cmd.ExecuteNonQuery()
                    cn1.Close()

                    k = "1"
                Catch ex As Exception
                    MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Pay Amount")
                    cn1.Close()
                    k = "2"
                End Try

            Next

            If k = "1" Then
                If lblStatus.Text = "Hold Item Cart" Then
                    connection()

                    Try
                        cmd.CommandText = "Delete from itemshold WHERE holdid='" + comHold_items.Text.ToString + "'"
                        cmd.Connection = cn
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                End If
                payment_total()
                If comPayment_method.Text = "CREDIT" Then
                    credit()
                End If
                gen_receipt()
                MsgBox("Payment Successful", vbOKOnly + vbInformation, "Point of Sale System")
                Refresh_All()
            End If
        End If
    End Sub

    Public Sub payment_total()
        connection()

        Try
            cmd.CommandText = "INSERT Into payment (invoiceno,type,nettotal,tdiscount,grandtotal,payment,balance,shortdate,longdate,time,loca) VALUES ('" + lblInvoice.Text + "','" + comPayment_method.Text + "','" + lblnetTotal.Text + "','" + lblTotal_discount.Text + "','" + lblGeand_total.Text + "','" + lblPaid.Text + "','" + lblbalance.Text + "','" + Format(Now, "yyMMdd") + "','" + Format(Now, "yyyy-MMM-dd") + "','" + Now.ToShortTimeString + "','" + loca + "')"
            cmd.Connection = cn
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in payment Total")
        End Try
    End Sub

    Public Sub Calculation()
        lblItemsQty.Text = dgCart.RowCount
        lblnetTotal.Text = Format(Val((From row As DataGridViewRow In dgCart.Rows Where row.Cells(6).FormattedValue.ToString() <> String.Empty Select Convert.ToDouble(row.Cells(6).FormattedValue)).Sum().ToString()) + Val((From row As DataGridViewRow In dgCart.Rows Where row.Cells(5).FormattedValue.ToString() <> String.Empty Select Convert.ToDouble(row.Cells(5).FormattedValue)).Sum().ToString()), "###0.00")
        lblTotal_discount.Text = Format(Val((From row As DataGridViewRow In dgCart.Rows Where row.Cells(5).FormattedValue.ToString() <> String.Empty Select Convert.ToDouble(row.Cells(5).FormattedValue)).Sum().ToString()), "###0.00")
        lblGeand_total.Text = Format((lblnetTotal.Text) - (lblTotal_discount.Text), "###0.00")
    End Sub

    Public Sub Refresh_All()
        lblDate.Text = Now.ToLongDateString
        lblStatus.Text = "New Bill"
        dgCart.Rows.Clear()
        lblbalance.Text = "0.00"
        lblPaid.Text = "0.00"
        cash = "0"
        Calculation()
        Credit_customers()
        Load_items()
        invoice_no()
        Load_Hold_items()
        Load_invoiceToCom()
        comPayment_method.Text = "cash"
        comSearch_customer.Text = "Cash Customer"
        comSearch_customer.Select()

    End Sub

    Public Sub credit()
        connection()

        Try
            cmd.CommandText = "Insert Into credit (invoiceno,custname,credit,dateshort,datelong,cashier,loca) Values ('" + lblInvoice.Text + "','" + comSearch_customer.Text + "','" + lblGeand_total.Text + "','" + Format(Now, "yyMMdd") + "','" + Format(Now, "yyyy-MMM-dd") + "','" + username + "','" + loca + "')"
            cmd.Connection = cn
            cmd.ExecuteNonQuery()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Credit")
            cn.Close()
        End Try
    End Sub

    Public Sub Print_lastBill()
        Dim dt3 As New DataTable




        If chkPrint.Checked = True Then
            '// Print Last Receipt.

            connection()
            Try

                cmdx.CommandText = "SELECT * FROM Receipt WHERE invoiceno='" + comInvoice.Text + "'"
                cmdx.Connection = cn
                Dim adp1 As New OdbcDataAdapter(cmdx)
                adp1.Fill(dt3)
                Dim rpt As New Cash_Bill1
                rpt.Database.Tables("Receipt").SetDataSource(dt3)
                rpt.Refresh()
                rpt.PrintToPrinter(1, False, 0, 0)
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in OLD Cash Bill Print")
            End Try

        Else
            '// Preview Receipt

            connection()
            Try

                cmdx.CommandText = "SELECT * FROM Receipt WHERE invoiceno='" + comInvoice.Text + "'"
                cmdx.Connection = cn
                Dim adp1 As New OdbcDataAdapter(cmdx)
                adp1.Fill(dt3)
                Dim rpt As New Cash_Bill1
                rpt.Database.Tables("Receipt").SetDataSource(dt3)
                Report_viewer.CRV.ReportSource = Nothing
                Report_viewer.CRV.ReportSource = rpt
                Report_viewer.CRV.Refresh()
                Report_viewer.CRV.RefreshReport()
                Report_viewer.Show()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in OLD Cash Bill Preview")
            End Try

        End If
    End Sub

    Public Sub Load_invoiceToCom()
        connection()

        Try
            cmd.CommandText = "SELECT INVOICENO From invoice Where loca='" + loca + "' Group by Invoiceno"
            cmd.Connection = cn
            dr = cmd.ExecuteReader
            Dim id As Integer
            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    comInvoice.Items.Add(dr(0))
                End If
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error In Invoice No Load")
            dr.Close()
            cn.Close()
        End Try

    End Sub

    Private Sub txtSearch_items_TextChanged(sender As Object, e As EventArgs) Handles txtSearch_items.TextChanged
        Load_items()

    End Sub

    Private Sub frm_invoice_Load(sender As Object, e As EventArgs) Handles Me.Load
        If ex = "full" Then
            Login.Hide()
        End If

        lblUser.Text = username
        lblStore_name.Text = Store_name
        lblDate.Text = Now.ToLongDateString
        Credit_customers()
        Load_items()
        invoice_no()
        Load_Hold_items()
        Load_invoiceToCom()
        comSearch_customer.Text = "Cash Customer"
        comSearch_customer.Select()
    End Sub

    Private Sub dgCart_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgCart.RowsAdded
        Calculation()
    End Sub

    Private Sub comSearch_customer_KeyDown(sender As Object, e As KeyEventArgs) Handles comSearch_customer.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                txtSearch_items.Select()
        End Select
    End Sub

    Private Sub DgItems_KeyDown(sender As Object, e As KeyEventArgs) Handles DgItems.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                inx = DgItems.CurrentRow.Index
                lblSelect_Item.Text = DgItems.Item(1, inx).Value
                Price = DgItems.Item(3, inx).Value
                PCode = DgItems.Item(0, inx).Value
                qty = DgItems.Item(4, inx).Value
                txtQuantity.Text = qty
                txtQuantity.Select()
        End Select
    End Sub

    Private Sub txtQuantity_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQuantity.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If Val(txtQuantity.Text) = "0" Or txtQuantity.Text = "" Then
                    MsgBox("Quantity Cannot be Blank or Zero", vbOKOnly + vbQuestion, "Point of Sale System")
                ElseIf Val(txtQuantity.Text) <= qty Then
                    txtDiscount.Select()
                Else
                    MsgBox("Quantity cannot Exceed Stock Quantity", vbOKOnly + vbQuestion, "Point of Sale System")
                    txtQuantity.SelectAll()
                End If
        End Select
    End Sub

    Private Sub txtDiscount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDiscount.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter

                If Val(txtDiscount.Text) > "0" Then
                    txtAmount.Text = (Price * Val(txtQuantity.Text)) - Val(txtDiscount.Text)
                    txtAmount.Select()

                Else
                    txtAmount.Text = Price * Val(txtQuantity.Text)
                    txtDiscount.Text = "0.00"
                    txtAmount.Select()
                End If
        End Select
    End Sub

    Private Sub txtSearch_items_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch_items.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                DgItems.Select()

            Case Keys.F4
                Items_hold()

            Case Keys.F5 '// Pay for Bill
                Pay_Amount()

            Case Keys.F8 '// Cancel Bill
                Frm_cancel_order.ShowDialog()

            Case Keys.F9 '// Creadit Customers Settlements
                frm_Settlement.ShowDialog()

            Case Keys.F6 '// Select Cash or Credit
                comPayment_method.Select()

            Case Keys.F7 '// Hold items Select
                comHold_items.Select()

            Case Keys.F2
                txtpaid.Select()
                txtpaid.SelectAll()

            Case Keys.F3
                Refresh_All()
        End Select
    End Sub

    Private Sub txtAmount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAmount.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If Val(txtAmount.Text) = "0" Or txtAmount.Text = "" Then
                    MsgBox("Zero Amount Product cannot Add to Cart", vbOKOnly + vbQuestion, "Point of Sale System")

                Else
                    total_amount = Format(Val(txtAmount.Text), "###0.00")
                    load_cart()
                    txtQuantity.Clear()
                    txtDiscount.Text = "0.00"
                    txtAmount.Text = "0.00"
                    lblSelect_Item.Text = "N/A"
                    txtSearch_items.Select()
                    txtSearch_items.SelectAll()
                End If
        End Select
    End Sub

    Private Sub btnHold_Click(sender As Object, e As EventArgs) Handles btnHold.Click
        Items_hold()
    End Sub

    Private Sub comPayment_method_KeyDown(sender As Object, e As KeyEventArgs) Handles comPayment_method.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtpaid.Select()
                txtpaid.SelectAll()

        End Select
    End Sub

    Private Sub txtpaid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpaid.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter

                cash = (Val(cash) + Val(txtpaid.Text))
                lblPaid.Text = Format(cash, "###0.00")
                lblbalance.Text = Format((lblPaid.Text) - ((lblGeand_total.Text)), "###0.00")
                txtpaid.Text = ""
                If lblbalance.Text < "0" Then
                    MsgBox(" Need More Money to Proceed", vbOKOnly + vbQuestion, "Point Of Sale System")
                    txtpaid.Select()
                    txtpaid.SelectAll()
                Else
                    btnpay.Select()
                End If
        End Select
    End Sub

    Private Sub btnpay_Click(sender As Object, e As EventArgs) Handles btnpay.Click
        If MessageBox.Show("Are You sure to Complete this Bill.?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Pay_Amount()
            chkPrint.Checked = True

        Else
            txtSearch_items.Select()
            txtSearch_items.SelectAll()

        End If
    End Sub

    Private Sub dgCart_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCart.CellClick
        Dim colname As String = dgCart.Columns(e.ColumnIndex).Index

        If colname = 7 Then
            dgCart.Rows.Remove(dgCart.CurrentRow)
        End If
    End Sub

    Private Sub dgCart_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgCart.RowsRemoved
        Calculation()
    End Sub

    Private Sub comHold_items_KeyDown(sender As Object, e As KeyEventArgs) Handles comHold_items.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If comHold_items.Text = "" Or IsDBNull(comHold_items.Text) Then
                    MsgBox("Please Select Hold ID")

                Else
                    Load_hold_items_Cart()
                    lblStatus.Text = "Hold Item Cart"
                End If
        End Select
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Frm_cancel_order.ShowDialog()
    End Sub

    Private Sub comPayment_method_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comPayment_method.SelectedIndexChanged
        If comPayment_method.Text = "CREDIT" Then
            If comSearch_customer.Text = "Cash Customer" Then

                MsgBox("Unable to Change 'Credit' for the Cash Customer", vbOKOnly + vbQuestion, "Point Of Sale System")
                comPayment_method.Text = "Cash"
                comSearch_customer.Select()
                comSearch_customer.SelectAll()

            Else
                txtpaid.Text = lblGeand_total.Text
                lblPaid.Text = "0.00"
                cash = 0
            End If


        Else
            txtpaid.Clear()
            cash = 0
            lblPaid.Text = "0.00"
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles btnSettlement.Click
        frm_Settlement.Load_customer()
        frm_Settlement.ShowDialog()
    End Sub

    Private Sub btnSettlement_KeyDown(sender As Object, e As KeyEventArgs) Handles btnSettlement.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter

                frm_Settlement.ShowDialog()
        End Select
    End Sub

    Private Sub btnCancel_KeyDown(sender As Object, e As KeyEventArgs) Handles btnCancel.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Frm_cancel_order.ShowDialog()
        End Select
    End Sub

    Private Sub btnPrint_last_Click(sender As Object, e As EventArgs) Handles btnPrint_last.Click
        If comInvoice.Text <> "" Then
            Print_lastBill()
            comInvoice.Text = ""
        Else
            MsgBox("Please select Invoice No to Print")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Refresh_All()
    End Sub

    Private Sub comInvoice_KeyDown(sender As Object, e As KeyEventArgs) Handles comInvoice.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If comInvoice.Text <> "" Then
                    Print_lastBill()
                    comInvoice.Text = ""
                End If

        End Select
    End Sub
End Class