
Imports System.Data.Odbc

Public Class Purchase

    Dim a As Double
    Dim d, g As Integer
    Dim c As Decimal
    Dim unit As Decimal
    Dim description As String
    Dim qty As Decimal
    Dim discount As Decimal
    Dim amount As Decimal
    Dim ccode As String
    Dim tid As Integer
    Dim tCode As String

    Private Sub RefreshData()
        cmbpursupcode.Items.Clear()
        cmbpursupname.Items.Clear()
        cmd = New Odbc.OdbcCommand("select * from Supplier where loca='" & loca & "'", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read
                cmbpursupcode.Items.Add(Trim(dr.Item("code")))
                cmbpursupname.Items.Add(dr.Item("name"))
            End While
        End If
        dr.Close()
        LoadRecord()
    End Sub

    Private Sub LoadRecord()

        da = New OdbcDataAdapter("Select id as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Temppurchase", cn)
        dt = New DataTable()
        da.Fill(dt)
        purchaseaddcartdatagridview.DataSource = dt

        purchaseaddcartdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        purchaseaddcartdatagridview.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        purchaseaddcartdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        purchaseaddcartdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        purchaseaddcartdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        purchaseaddcartdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        purchaseaddcartdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        purchaseaddcartdatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        purchaseaddcartdatagridview.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        purchaseaddcartdatagridview.Columns(3).DefaultCellStyle.Format = "####0.00"
        purchaseaddcartdatagridview.Columns(4).DefaultCellStyle.Format = "####0"
        purchaseaddcartdatagridview.Columns(5).DefaultCellStyle.Format = "####0"
        purchaseaddcartdatagridview.Columns(6).DefaultCellStyle.Format = "####0.00"

        purchaseaddcartdatagridview.Columns(0).Width = 60
        purchaseaddcartdatagridview.Columns(1).Width = 60
        purchaseaddcartdatagridview.Columns(2).Width = 250
        purchaseaddcartdatagridview.Columns(3).Width = 100
        purchaseaddcartdatagridview.Columns(4).Width = 100
        purchaseaddcartdatagridview.Columns(5).Width = 100
        purchaseaddcartdatagridview.Columns(6).Width = 100

    End Sub

    Private Sub btnpurcheckoutsupply_Click(sender As Object, e As EventArgs) Handles btnpurcheckoutsupply.Click
        cmd = New Odbc.OdbcCommand("select * from Temppurchase", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                cn.Open()
                cmd2 = New Odbc.OdbcCommand("INSERT INTO Purchase Values('" & Trim(lblpurchasedocno.Text) & "','" & Format(dppurpurchasedate.Value, "yyyy-MMM-dd") & "','" & Format(dppurexpireddate.Value, "yyyy-MMM-dd") & "','" & cmbpursupcode.Text & "','" & cmbpursupname.Text & "','" & dr.Item("id") & "','" & dr.Item("code") & "','" & dr.Item("name") & "','" & Format(dr.Item("costprice"), "####0.00") & "','" & dr.Item("quantity") & "','" & dr.Item("discount") & "','" & dr.Item("amount") & "','" & txtpurgtotal.Text & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & loca & "')", cn)
                cmd2.ExecuteNonQuery()
                cn.Close()
            End While
        End If

        'dr.Close()
        'cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_Purchaseorder as select * from Purchase where docno='" & Trim(TxtCrndocno.Text) & "'", cn)
        'cmd.ExecuteNonQuery()

        'reportDocument1.Load(My.Application.Info.DirectoryPath & "\RPT\Purchaseorder.rpt")
        'reportDocument1.SetDatabaseLogon(SQLUsername, SQLPassword)
        'reportDocument1.Refresh()
        'reportDocument1.PrintToPrinter(1, False, 0, 0)

        cmbpursupcode.Text = ""
        cmbpursupname.Text = ""
        lblpurchaseitemsname.Text = "N/A"
        txtpurchaseitemscostprice.Text = ""
        txtpurchaseitemsqty.Text = ""
        txtpurchaseitemsdiscount.Text = ""
        txtpurchaseitemsamount.Text = ""
        txtpurgtotal.Text = "0.00"

        MsgBox("Purchase Details Save Successfully..")

        dr.Close()

        btnpurcancel_Click(sender, e)

        cmd = New Odbc.OdbcCommand("select COUNT(DISTINCT docno) AS IDD from Purchase", cn)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim ID As Integer = 0
        If dr.HasRows Then
            ID = dr.Item("IDD")
            ID = ID + 1
        Else
            ID = ID + 1
        End If

        lblpurchasedocno.Text = Format(ID, "000#")

        dr.Close()

        cmd = New Odbc.OdbcCommand("select * from Purchase where loca='" & loca & "'", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read
                cmbpurchasedocno.Items.Add(Trim(dr.Item("docno")))
            End While
        End If
        dr.Close()

        cmbpursupcode.Focus()
        cmbpursupname.SelectAll()

    End Sub

    Private Sub Purchase_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        cmbpursupcode.Focus()
        cmbpursupname.SelectAll()
    End Sub

    Private Sub Purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmd = New Odbc.OdbcCommand("select * from Supplier", cn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    cmbpursupcode.Items.Add(Trim(dr.Item("code")))
                    cmbpursupname.Items.Add(dr.Item("name"))
                End While
            End If

            'Load Doc No

            dr.Close()

            cmd = New Odbc.OdbcCommand("select * from Purchase where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    cmbpurchasedocno.Items.Add(Trim(dr.Item("docno")))
                End While
            End If
            dr.Close()

            cmd = New Odbc.OdbcCommand("select COUNT(DISTINCT docno) AS IDD from Purchase", cn)
            dr = cmd.ExecuteReader()
            dr.Read()
            Dim ID As Integer = 0
            If dr.HasRows Then
                ID = dr.Item("IDD")
                ID = ID + 1
            Else
                ID = ID + 1
            End If

            lblpurchasedocno.Text = Format(ID, "000#")

            dppurpurchasedate.Value = Now
            dppurexpireddate.Value = Now

            dr.Close()

            'LoadRecord()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbpursupcode_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbpursupcode.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                cmbpursupname.Focus()
                cmbpursupname.SelectAll()
        End Select
    End Sub

    Private Sub cmbpursupcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpursupcode.SelectedIndexChanged
        Try
            cmd = New Odbc.OdbcCommand("select * from Supplier where code='" & cmbpursupcode.Text & "'", cn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                cmbpursupcode.Text = Trim(dr.Item("code"))
                cmbpursupname.Text = dr.Item("name")
            End If
            dr.Close()

            txtpurchaseitemssearch.Focus()
            txtpurchaseitemssearch.SelectAll()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbpursupname_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbpursupname.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                txtpurchaseitemssearch.Focus()
                txtpurchaseitemssearch.SelectAll()
        End Select
    End Sub

    Private Sub cmbpursupname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbpursupname.SelectedIndexChanged
        Try
            cn.Open()
            cmd2 = New Odbc.OdbcCommand("select * from Supplier where name='" & cmbpursupname.Text & "'", cn)
            dr2 = cmd2.ExecuteReader
            dr2.Read()
            If dr2.HasRows Then
                cmbpursupcode.Text = Trim(dr2.Item("code"))
                cmbpursupname.Text = dr2.Item("name")
            End If
            dr2.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnpurselected_Click(sender As Object, e As EventArgs) Handles btnpurselected.Click
        Try

            For i As Integer = Me.purchaseaddcartdatagridview.SelectedRows.Count - 1 To 0 Step -1
                Dim result As DialogResult = MessageBox.Show("Are You Sure Delete Data..?", Me.Text, MessageBoxButtons.YesNo)
                If result = Windows.Forms.DialogResult.Yes Then
                    cmdDelete = "delete Temppurchase where id='" & Me.purchaseaddcartdatagridview.SelectedRows(i).Cells(0).Value.ToString() & "'"
                    da = New OdbcDataAdapter(cmdDelete, cn)
                    ds = New DataSet()
                    da.Fill(ds)
                    Me.purchaseaddcartdatagridview.Rows.Remove(Me.purchaseaddcartdatagridview.SelectedRows(i))
                End If
            Next

            LoadRecord()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnpurcancel_Click(sender As Object, e As EventArgs) Handles btnpurcancel.Click
        Try

            cmd = New OdbcCommand("delete from Temppurchase", cn)
            cmd.ExecuteNonQuery()

            txtpurgtotal.Text = ""

            da = New OdbcDataAdapter("select id as 'ID', code as 'Code', name as 'Name',costprice as 'Cost Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Temppurchase", cn)
            dt = New DataTable()
            da.Fill(dt)
            purchaseaddcartdatagridview.DataSource = dt
            purchaseaddcartdatagridview.Refresh()

            cmbpursupcode.Text = ""
            cmbpursupcode.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub dppurexpireddate_KeyDown(sender As Object, e As KeyEventArgs) Handles dppurexpireddate.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                dppurpurchasedate.Focus()
                dppurpurchasedate.Select()
        End Select
    End Sub

    Private Sub dppurpurchasedate_KeyDown(sender As Object, e As KeyEventArgs) Handles dppurpurchasedate.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                cmbpursupcode.Focus()
                cmbpursupcode.SelectAll()
        End Select
    End Sub

    Private Sub txtpurchaseitemsamount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpurchaseitemsamount.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                If IsNumeric(txtpurchaseitemsamount.Text) = True And Val(txtpurchaseitemsamount.Text) > 0 Or Val(txtpurchaseitemsamount.Text) < 0 Then
                    cmd = New OdbcCommand("select COUNT(id) as IDD from Temppurchase where loca='" & loca & "'", cn)
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

                    cmd = New OdbcCommand("INSERT INTO Temppurchase Values('" & ID & "','" & ccode & "','" & lblpurchaseitemsname.Text & "','" & unit & "','" & txtpurchaseitemsqty.Text & "','" & Format(Val(txtpurchaseitemsdiscount.Text), "####0") & "','" & txtpurchaseitemsamount.Text & "','" & loca & "')", cn)
                    cmd.ExecuteNonQuery()

                    da = New OdbcDataAdapter("Select id as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Temppurchase where loca='" & loca & "' order by id asc", cn)
                    dt = New DataTable()
                    da.Fill(dt)
                    purchaseaddcartdatagridview.DataSource = dt

                    purchaseaddcartdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    purchaseaddcartdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    purchaseaddcartdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    purchaseaddcartdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    purchaseaddcartdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    purchaseaddcartdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    purchaseaddcartdatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    purchaseaddcartdatagridview.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    purchaseaddcartdatagridview.Columns(3).DefaultCellStyle.Format = "####0.00"
                    purchaseaddcartdatagridview.Columns(4).DefaultCellStyle.Format = "####0"
                    purchaseaddcartdatagridview.Columns(5).DefaultCellStyle.Format = "####0"
                    purchaseaddcartdatagridview.Columns(6).DefaultCellStyle.Format = "####0.00"
                    purchaseaddcartdatagridview.Focus()
                    purchaseaddcartdatagridview.SelectAll()

                    Dim discount As String = 0
                    Dim stotal As String = 0
                    Dim scharge As String = 0
                    For i As Integer = 0 To purchaseaddcartdatagridview.RowCount - 1
                        discount += purchaseaddcartdatagridview.Rows(i).Cells(5).Value
                        stotal += purchaseaddcartdatagridview.Rows(i).Cells(6).Value
                        scharge += purchaseaddcartdatagridview.Rows(i).Cells(4).Value
                    Next

                    txtpurgtotal.Text = Format(Val(stotal), "####0.00")

                    purchaseaddcartdatagridview.Columns(0).Width = 60
                    purchaseaddcartdatagridview.Columns(1).Width = 80
                    purchaseaddcartdatagridview.Columns(2).Width = 220
                    purchaseaddcartdatagridview.Columns(3).Width = 80
                    purchaseaddcartdatagridview.Columns(4).Width = 80
                    purchaseaddcartdatagridview.Columns(5).Width = 80
                    purchaseaddcartdatagridview.Columns(6).Width = 80

                    txtpurchaseitemsqty.Text = "0"
                    txtpurchaseitemsdiscount.Text = "0"
                    txtpurchaseitemscostprice.Text = "0.00"

                    purchaseaddcartdatagridview.FirstDisplayedScrollingRowIndex = purchaseaddcartdatagridview.RowCount - 1
                    purchaseaddcartdatagridview.Rows(purchaseaddcartdatagridview.RowCount - 1).Selected = True

                    'Dim a As Integer
                    'For a = 0 To purchaseaddcartdatagridview.Rows.Count - 1
                    'If Mid(purchaseaddcartdatagridview.Rows(a).Cells(4).Value, 1, 1) = "-" Then
                    'purchaseaddcartdatagridview.Rows(a).DefaultCellStyle.BackColor = Color.PaleVioletRed
                    'End If
                    'Next

                    txtpurchaseitemssearch.Focus()
                    txtpurchaseitemssearch.SelectAll()

                Else
                    MessageBox.Show("Please Enter Your Amount", "Return", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Case Keys.Left
                txtpurchaseitemsdiscount.Focus()
                txtpurchaseitemsdiscount.SelectAll()

            Case Keys.Escape
                txtpurchaseitemssearch.Focus()
                txtpurchaseitemssearch.SelectAll()

        End Select
    End Sub

    Private Sub txtpurchaseitemssearch_TextChanged(sender As Object, e As EventArgs) Handles txtpurchaseitemssearch.TextChanged

        purchaseitemsdatagridview.ColumnCount = 4
        purchaseitemsdatagridview.Columns(0).Name = "Code"
        purchaseitemsdatagridview.Columns(1).Name = "Name"
        purchaseitemsdatagridview.Columns(2).Name = "Sell Price"
        purchaseitemsdatagridview.Columns(3).Name = "Stock"
        purchaseitemsdatagridview.Rows.Clear()
        Dim IDF As Integer = 0
        purchaseitemsdatagridview.Columns(0).Width = 50
        purchaseitemsdatagridview.Columns(1).Width = 120
        purchaseitemsdatagridview.Columns(2).Width = 70
        purchaseitemsdatagridview.Columns(3).Width = 70
        purchaseitemsdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        purchaseitemsdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        purchaseitemsdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        purchaseitemsdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        purchaseitemsdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        If txtpurchaseitemssearch.Focus Then

            If txtpurchaseitemssearch.Text.Length > 0 Then

                cmd = New OdbcCommand("select * from Items where name like '%" & txtpurchaseitemssearch.Text & "%' or barcode like '%" & txtpurchaseitemssearch.Text & "%' and loca='" & loca & "'", cn)
                dr = cmd.ExecuteReader()
                If dr.HasRows Then
                    While dr.Read
                        Dim row As String() = New String() {dr("code"), dr("name"), Format(dr("costprice"), "####0.00"), Format(dr("totalqty"), "####0")}
                        purchaseitemsdatagridview.Rows.Add(row)
                    End While
                    purchaseitemsdatagridview.Refresh()
                End If
                dr.Close()
            End If
            purchaseitemsdatagridview.Focus()
            purchaseitemsdatagridview.SelectAll()
        End If
    End Sub

    Private Sub purchaseitemsdatagridview_KeyDown(sender As Object, e As KeyEventArgs) Handles purchaseitemsdatagridview.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                Try
                    Dim inx As Integer
                    inx = purchaseitemsdatagridview.CurrentRow.Index
                    ccode = purchaseitemsdatagridview.Item(0, inx).Value
                    Dim a As Integer
                    For a = 0 To purchaseaddcartdatagridview.Rows.Count - 1
                        If purchaseaddcartdatagridview.Item(1, a).Value = ccode Then
                            MessageBox.Show("You Already Entered This Items Code " & purchaseaddcartdatagridview.Item(2, a).Value, "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            purchaseaddcartdatagridview.FirstDisplayedScrollingRowIndex = purchaseaddcartdatagridview.Rows(a).Index
                            purchaseaddcartdatagridview.Rows(purchaseaddcartdatagridview.Rows(a).Index).Selected = True

                        End If
                    Next

                    Dim i As Integer
                    i = purchaseitemsdatagridview.CurrentRow.Index
                    lblpurchaseitemsname.Text = purchaseitemsdatagridview.Item(1, i).Value
                    ccode = purchaseitemsdatagridview.Item(0, i).Value
                    unit = purchaseitemsdatagridview.Item(2, i).Value
                    txtpurchaseitemscostprice.Text = Format(Val(unit), "####0.00")

                    txtpurchaseitemsqty.Focus()
                    txtpurchaseitemsqty.SelectAll()

                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            Case Keys.Escape
                txtpurchaseitemssearch.Focus()
                txtpurchaseitemssearch.SelectAll()
            Case Keys.F8

        End Select
    End Sub

    Private Sub txtpurchaseitemsqty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpurchaseitemsqty.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If IsNumeric(txtpurchaseitemsqty.Text) = True And Val(txtpurchaseitemsqty.Text) > 0 Or Val(txtpurchaseitemsqty.Text) < 0 Then
                    txtpurchaseitemsamount.Text = Format(Val(unit) * Val(txtpurchaseitemsqty.Text), "####0.00")
                    txtpurchaseitemsdiscount.Focus()
                    txtpurchaseitemsdiscount.Text = "00"
                    txtpurchaseitemsdiscount.SelectAll()
                Else
                    MessageBox.Show("Please Enter Your Quantity", "Purchase", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Case Keys.Escape
                purchaseitemsdatagridview.Focus()
        End Select
    End Sub

    Private Sub txtpurchaseitemsdiscount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpurchaseitemsdiscount.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                If Mid(txtpurchaseitemsdiscount.Text, txtpurchaseitemsdiscount.Text.Length) = "%" Then
                    txtpurchaseitemsdiscount.Text = txtpurchaseitemsdiscount.Text.Remove(txtpurchaseitemsdiscount.Text.Length - 1)

                    Dim AMT As Decimal
                    AMT = unit * Val(txtpurchaseitemsdiscount.Text) / 100

                    a = AMT * Val(txtpurchaseitemsqty.Text)
                    txtpurchaseitemsdiscount.Text = Format(a, "####0.00")

                    txtpurchaseitemsamount.Text = Format(Val(txtpurchaseitemsamount.Text) - Val(txtpurchaseitemsdiscount.Text), "####0.00")
                    txtpurchaseitemsamount.Focus()

                Else
                    a = Val(txtpurchaseitemsdiscount.Text) * Val(txtpurchaseitemsqty.Text)
                    txtpurchaseitemsdiscount.Text = Format(a, "#####0.00")

                    txtpurchaseitemsamount.Text = Format(Val(txtpurchaseitemsamount.Text) - Val(txtpurchaseitemsdiscount.Text), "####0.00")
                    txtpurchaseitemsamount.Focus()
                End If

            Case Keys.Escape
                txtpurchaseitemssearch.Focus()
                txtpurchaseitemssearch.SelectAll()

            Case Keys.Left
                txtpurchaseitemsqty.Focus()
                txtpurchaseitemsqty.SelectAll()

            Case Keys.Right
                txtpurchaseitemsamount.Focus()
                txtpurchaseitemsamount.SelectAll()
        End Select
    End Sub

    Private Sub txtpurgtotal_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpurgtotal.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                btnpurcheckoutsupply.Focus()
        End Select
    End Sub

    Private Sub btnpurgetorder_Click(sender As Object, e As EventArgs) Handles btnpurgetorder.Click
        'purchaseaddcartdatagridview.ColumnCount = 7
        'purchaseaddcartdatagridview.Columns(0).Name = "ID"
        'purchaseaddcartdatagridview.Columns(1).Name = "Code"
        'purchaseaddcartdatagridview.Columns(2).Name = "Name"
        'purchaseaddcartdatagridview.Columns(3).Name = "Cost Price"
        'purchaseaddcartdatagridview.Columns(4).Name = "Quantity"
        'purchaseaddcartdatagridview.Columns(5).Name = "Discount"
        'purchaseaddcartdatagridview.Columns(6).Name = "Amount"
        'purchaseaddcartdatagridview.Rows.Clear()
        'Dim IDF As Integer = 0
        'purchaseaddcartdatagridview.Columns(0).Width = 60
        'purchaseaddcartdatagridview.Columns(1).Width = 80
        'purchaseaddcartdatagridview.Columns(2).Width = 220
        'purchaseaddcartdatagridview.Columns(3).Width = 80
        'purchaseaddcartdatagridview.Columns(4).Width = 80
        'purchaseaddcartdatagridview.Columns(5).Width = 80
        'purchaseaddcartdatagridview.Columns(6).Width = 80
        'purchaseaddcartdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'purchaseaddcartdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'purchaseaddcartdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'purchaseaddcartdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'purchaseaddcartdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'purchaseaddcartdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'purchaseaddcartdatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'purchaseaddcartdatagridview.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        cmd = New OdbcCommand("select * from Purchasereturn where docno ='" & cmbpurchasedocno.Text & "' and supcode='" & cmbpursupcode.Text & "' and loca='" & loca & "'", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            'While dr.Read
            Dim row As String() = New String() {dr("id"), dr("code"), dr("name"), Format(dr("costprice"), "####0.00"), Format(dr("quantity"), "####0"), Format(dr("discount"), "####0"), Format(dr("amount"), "####0")}
            purchaseaddcartdatagridview.Rows.Add(row)
            txtpurgtotal.Text = Format(Val(dr("total")), "####0.00")
            'End While
            dppurpurchasedate.Value = dr("rdate")
            purchaseaddcartdatagridview.Refresh()
        End If
        dr.Close()

        txtpurchaseitemssearch.Focus()
        txtpurchaseitemssearch.SelectAll()

        cmd = New Odbc.OdbcCommand("select COUNT(DISTINCT docno) AS IDD from Purchase", cn)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim ID As Integer = 0
        If dr.HasRows Then
            ID = dr.Item("IDD")
            ID = ID + 1
        Else
            ID = ID + 1
        End If

        lblpurchasedocno.Text = Format(ID, "000#")

    End Sub

End Class