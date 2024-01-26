
Imports System.Data.Odbc

Public Class Purchasereturn

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
        cmbreturnsupcode.Items.Clear()
        cmbreturnsupname.Items.Clear()

        cmd = New Odbc.OdbcCommand("select * from Supplier where loca='" & loca & "'", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read
                cmbreturnsupcode.Items.Add(Trim(dr.Item("code")))
                cmbreturnsupname.Items.Add(dr.Item("name"))
            End While
        End If
        dr.Close()

        LoadRecord()

    End Sub

    Private Sub LoadRecord()

        cmdSelect = "SELECT id as 'ID', code as 'Code', name as 'Name',costprice as 'Cost Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Temppreturn"
        da = New OdbcDataAdapter(cmdSelect, cn)
        dt = New DataTable()
        da.Fill(dt)
        returncartdatagridview.DataSource = dt

        returncartdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        returncartdatagridview.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        returncartdatagridview.Columns(3).DefaultCellStyle.Format = "####0.00"
        returncartdatagridview.Columns(4).DefaultCellStyle.Format = "####0"
        returncartdatagridview.Columns(5).DefaultCellStyle.Format = "####0.00"
        returncartdatagridview.Columns(6).DefaultCellStyle.Format = "####0.00"

        returncartdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        returncartdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        returncartdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        returncartdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        returncartdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        returncartdatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        returncartdatagridview.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        returncartdatagridview.Columns(0).Width = 60
        returncartdatagridview.Columns(1).Width = 80
        returncartdatagridview.Columns(2).Width = 220
        returncartdatagridview.Columns(3).Width = 100
        returncartdatagridview.Columns(4).Width = 100
        returncartdatagridview.Columns(5).Width = 100
        returncartdatagridview.Columns(6).Width = 100

    End Sub

    Private Sub Purchasereturn_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        cmbreturnsupcode.Focus()
        cmbreturnsupcode.SelectAll()

    End Sub

    Private Sub Purchasereturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmd = New Odbc.OdbcCommand("select * from Supplier", cn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    cmbreturnsupcode.Items.Add(Trim(dr.Item("code")))
                    cmbreturnsupname.Items.Add(dr.Item("name"))
                End While
            End If

            dr.Close()

            cmd = New Odbc.OdbcCommand("select * from Purchasereturn where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    cmbreturnprnno.Items.Add(Trim(dr.Item("docno")))
                End While
            End If
            dr.Close()

            'Load Doc No
            cn.Open()
            cmd2 = New Odbc.OdbcCommand("select COUNT(DISTINCT docno) AS IDD from Purchasereturn", cn)
            dr2 = cmd2.ExecuteReader()
            dr2.Read()
            Dim ID As Integer = 0
            If dr2.HasRows Then
                ID = dr2.Item("IDD")
                ID = ID + 1
            Else
                ID = ID + 1
            End If

            lblreturndocno.Text = Format(ID, "000#")
            dr2.Close()
            cn.Close()

            dpreturnpurchasedate.Value = Now


            'LoadRecord()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbreturnsupcode_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbreturnsupcode.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                cmbreturnsupname.Focus()
                cmbreturnsupname.SelectAll()
        End Select
    End Sub

    Private Sub cmbreturnsupcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbreturnsupcode.SelectedIndexChanged
        Try
            cn.Open()
            cmd2 = New Odbc.OdbcCommand("select * from Supplier where code='" & cmbreturnsupcode.Text & "'", cn)
            dr2 = cmd2.ExecuteReader
            dr2.Read()
            If dr2.HasRows Then
                cmbreturnsupcode.Text = Trim(dr2.Item("code"))
                cmbreturnsupname.Text = dr2.Item("name")
            End If
            dr2.Close()
            cn.Close()

            txtreturnitemssearch.Focus()
            txtreturnitemssearch.SelectAll()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbreturnsupname_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbreturnsupname.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                lblreturndocno.Focus()
        End Select
    End Sub

    Private Sub cmbreturnsupname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbreturnsupname.SelectedIndexChanged
        Try
            cn.Open()
            cmd3 = New Odbc.OdbcCommand("select * from Supplier where name='" & cmbreturnsupname.Text & "'", cn)
            dr3 = cmd3.ExecuteReader
            dr3.Read()
            If dr3.HasRows Then
                cmbreturnsupcode.Text = Trim(dr3.Item("code"))
                cmbreturnsupname.Text = dr3.Item("name")
            End If
            dr3.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtreturnitemssearch_TextChanged(sender As Object, e As EventArgs) Handles txtreturnitemssearch.TextChanged

        returnoitemsdatagridview.ColumnCount = 4
        returnoitemsdatagridview.Columns(0).Name = "Code"
        returnoitemsdatagridview.Columns(1).Name = "Name"
        returnoitemsdatagridview.Columns(2).Name = "Sell Price"
        returnoitemsdatagridview.Columns(3).Name = "Stock"
        returnoitemsdatagridview.Rows.Clear()
        Dim IDF As Integer = 0
        returnoitemsdatagridview.Columns(0).Width = 50
        returnoitemsdatagridview.Columns(1).Width = 120
        returnoitemsdatagridview.Columns(2).Width = 70
        returnoitemsdatagridview.Columns(3).Width = 70
        returnoitemsdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        returnoitemsdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        returnoitemsdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        returnoitemsdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        returnoitemsdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        If txtreturnitemssearch.Focus Then

            If txtreturnitemssearch.Text.Length > 0 Then

                cmd = New OdbcCommand("select * from Items where name like '%" & txtreturnitemssearch.Text & "%' or barcode like '%" & txtreturnitemssearch.Text & "%' and loca='" & loca & "'", cn)
                dr = cmd.ExecuteReader()
                If dr.HasRows Then
                    While dr.Read
                        Dim row As String() = New String() {dr("code"), dr("name"), Format(dr("costprice"), "####0.00"), Format(dr("totalqty"), "####0")}
                        returnoitemsdatagridview.Rows.Add(row)
                    End While
                    returnoitemsdatagridview.Refresh()
                End If
                dr.Close()
            End If
            returnoitemsdatagridview.Focus()
            returnoitemsdatagridview.SelectAll()
        End If
    End Sub

    Private Sub returnoitemsdatagridview_KeyDown(sender As Object, e As KeyEventArgs) Handles returnoitemsdatagridview.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                Try
                    Dim inx As Integer
                    inx = returnoitemsdatagridview.CurrentRow.Index
                    ccode = returnoitemsdatagridview.Item(0, inx).Value
                    Dim a As Integer
                    For a = 0 To returncartdatagridview.Rows.Count - 1
                        If returncartdatagridview.Item(1, a).Value = ccode Then
                            MessageBox.Show("You Already Entered This Items Code " & returncartdatagridview.Item(2, a).Value, "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            returncartdatagridview.FirstDisplayedScrollingRowIndex = returncartdatagridview.Rows(a).Index
                            returncartdatagridview.Rows(returncartdatagridview.Rows(a).Index).Selected = True

                        End If
                    Next

                    Dim i As Integer
                    i = returnoitemsdatagridview.CurrentRow.Index
                    lblreturnitemsname.Text = returnoitemsdatagridview.Item(1, i).Value
                    ccode = returnoitemsdatagridview.Item(0, i).Value
                    unit = returnoitemsdatagridview.Item(2, i).Value
                    txtreturnitemscostprice.Text = Format(Val(unit), "####0.00")

                    txtreturnitemsqty.Focus()
                    txtreturnitemsqty.SelectAll()

                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
            Case Keys.Escape
                txtreturnitemssearch.Focus()
                txtreturnitemssearch.SelectAll()
            Case Keys.F8

        End Select
    End Sub

    Private Sub txtreturnitemsqty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtreturnitemsqty.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If IsNumeric(txtreturnitemsqty.Text) = True And Val(txtreturnitemsqty.Text) > 0 Or Val(txtreturnitemsqty.Text) < 0 Then
                    txtreturnitemsamount.Text = Format(Val(unit) * Val(txtreturnitemsqty.Text), "####0.00")
                    txtreturnitemsdiscount.Focus()
                    txtreturnitemsdiscount.Text = "00"
                    txtreturnitemsdiscount.SelectAll()
                Else
                    MessageBox.Show("Please Enter Your Quantity", "Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Case Keys.Escape
                returnoitemsdatagridview.Focus()
        End Select
    End Sub

    Private Sub txtreturnitemsdiscount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtreturnitemsdiscount.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                If Mid(txtreturnitemsdiscount.Text, txtreturnitemsdiscount.Text.Length) = "%" Then
                    txtreturnitemsdiscount.Text = txtreturnitemsdiscount.Text.Remove(txtreturnitemsdiscount.Text.Length - 1)

                    Dim AMT As Decimal
                    AMT = unit * Val(txtreturnitemsdiscount.Text) / 100

                    a = AMT * Val(txtreturnitemsqty.Text)
                    txtreturnitemsdiscount.Text = Format(a, "####0.00")

                    txtreturnitemsamount.Text = Format(Val(txtreturnitemsamount.Text) - Val(txtreturnitemsdiscount.Text), "####0.00")
                    txtreturnitemsamount.Focus()

                Else
                    a = Val(txtreturnitemsdiscount.Text) * Val(txtreturnitemsqty.Text)
                    txtreturnitemsdiscount.Text = Format(a, "#####0.00")

                    txtreturnitemsamount.Text = Format(Val(txtreturnitemsamount.Text) - Val(txtreturnitemsdiscount.Text), "####0.00")
                    txtreturnitemsamount.Focus()
                End If

            Case Keys.Escape
                txtreturnitemssearch.Focus()
                txtreturnitemssearch.SelectAll()

            Case Keys.Left
                txtreturnitemsqty.Focus()
                txtreturnitemsqty.SelectAll()

            Case Keys.Right
                txtreturnitemsamount.Focus()
                txtreturnitemsamount.SelectAll()
        End Select
    End Sub

    Private Sub txtreturnitemsamount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtreturnitemsamount.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                If IsNumeric(txtreturnitemsamount.Text) = True And Val(txtreturnitemsamount.Text) > 0 Or Val(txtreturnitemsamount.Text) < 0 Then
                    cmd = New OdbcCommand("select COUNT(id) as IDD from Temppreturn where loca='" & loca & "'", cn)
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

                    cmd = New OdbcCommand("INSERT INTO Temppreturn Values('" & ID & "','" & ccode & "','" & lblreturnitemsname.Text & "','" & unit & "','" & txtreturnitemsqty.Text & "','" & Format(Val(txtreturnitemsdiscount.Text), "####0") & "','" & txtreturnitemsamount.Text & "','" & loca & "')", cn)
                    cmd.ExecuteNonQuery()

                    da = New OdbcDataAdapter("Select id as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Temppreturn where loca='" & loca & "' order by id asc", cn)
                    dt = New DataTable()
                    da.Fill(dt)
                    returncartdatagridview.DataSource = dt

                    returncartdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    returncartdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    returncartdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    returncartdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    returncartdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    returncartdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    returncartdatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    returncartdatagridview.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    returncartdatagridview.Columns(3).DefaultCellStyle.Format = "####0.00"
                    returncartdatagridview.Columns(4).DefaultCellStyle.Format = "####0"
                    returncartdatagridview.Columns(5).DefaultCellStyle.Format = "####0"
                    returncartdatagridview.Columns(6).DefaultCellStyle.Format = "####0.00"
                    txtreturnitemssearch.Focus()
                    txtreturnitemssearch.SelectAll()

                    Dim discount As String = 0
                    Dim stotal As String = 0
                    Dim scharge As String = 0
                    For i As Integer = 0 To returncartdatagridview.RowCount - 1
                        discount += returncartdatagridview.Rows(i).Cells(5).Value
                        stotal += returncartdatagridview.Rows(i).Cells(6).Value
                        scharge += returncartdatagridview.Rows(i).Cells(4).Value
                    Next


                    Txtreturngrandtotal.Text = Format(Val(stotal), "####0.00")

                    returncartdatagridview.Columns(0).Width = 60
                    returncartdatagridview.Columns(1).Width = 80
                    returncartdatagridview.Columns(2).Width = 220
                    returncartdatagridview.Columns(3).Width = 80
                    returncartdatagridview.Columns(4).Width = 80
                    returncartdatagridview.Columns(5).Width = 80
                    returncartdatagridview.Columns(6).Width = 80

                    txtreturnitemsqty.Text = "0"
                    txtreturnitemsdiscount.Text = "0"
                    txtreturnitemsamount.Text = "0.00"

                    returncartdatagridview.FirstDisplayedScrollingRowIndex = returncartdatagridview.RowCount - 1
                    returncartdatagridview.Rows(returncartdatagridview.RowCount - 1).Selected = True

                    txtreturnitemssearch.Focus()
                    txtreturnitemssearch.SelectAll()

                Else
                    MessageBox.Show("Please Enter Your Amount", "Return", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Case Keys.Left
                txtreturnitemsdiscount.Focus()
                txtreturnitemsdiscount.SelectAll()

            Case Keys.Escape
                txtreturnitemssearch.Focus()
                txtreturnitemssearch.SelectAll()

        End Select
    End Sub

    Private Sub btnreturncancel_Click(sender As Object, e As EventArgs) Handles btnreturncancel.Click
        Try

            cmd = New OdbcCommand("delete from Temppreturn", cn)
            cmd.ExecuteNonQuery()

            Txtreturngrandtotal.Text = ""

            da = New OdbcDataAdapter("select id as 'ID', code as 'Code', name as 'Name', costprice as 'Cost Price', quantity as 'Quantity', discount as 'Discount', amount as 'Amount' from Temppreturn", cn)
            dt = New DataTable()
            da.Fill(dt)
            returncartdatagridview.DataSource = dt
            returncartdatagridview.Refresh()

            cmbreturnsupcode.Text = ""
            cmbreturnsupcode.Text = ""
            cmbreturnsupcode.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Txtreturngrandtotal_KeyDown(sender As Object, e As KeyEventArgs) Handles Txtreturngrandtotal.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                btnreturnckoutsupply.Focus()
        End Select
    End Sub

    Private Sub txtreturntotalqty_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode

            Case Keys.Enter
                Txtreturngrandtotal.Focus()
                Txtreturngrandtotal.SelectAll()
        End Select
    End Sub

    Private Sub btnreturnckoutsupply_Click(sender As Object, e As EventArgs) Handles btnreturnckoutsupply.Click

        cmd = New Odbc.OdbcCommand("select * from Temppreturn", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read()
                cn.Open()
                cmd2 = New Odbc.OdbcCommand("INSERT INTO Purchasereturn Values('" & Trim(lblreturndocno.Text) & "','" & Format(dpreturnpurchasedate.Value, "yyyy-MMM-dd") & "','" & cmbreturnsupcode.Text & "','" & cmbreturnsupname.Text & "','" & dr.Item("id") & "','" & dr.Item("code") & "','" & dr.Item("name") & "','" & dr.Item("costprice") & "','" & dr.Item("quantity") & "','" & dr.Item("discount") & "','" & dr.Item("amount") & "','" & Txtreturngrandtotal.Text & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & loca & "')", cn)
                cmd2.ExecuteNonQuery()
                cn.Close()
            End While
        End If
        dr.Close()

        cmbreturnsupcode.Text = ""
        cmbreturnsupname.Text = ""
        lblreturnitemsname.Text = "N/A"
        txtreturnitemscostprice.Text = ""
        txtreturnitemsqty.Text = ""
        txtreturnitemsdiscount.Text = ""
        txtreturnitemsamount.Text = ""
        Txtreturngrandtotal.Text = ""

        RefreshData()

        cmd = New Odbc.OdbcCommand("select * from Purchasereturn where loca='" & loca & "'", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read
                cmbreturnprnno.Items.Add(Trim(dr.Item("docno")))
            End While
        End If
        dr.Close()

        'Load Doc No
        cn.Open()
        cmd2 = New Odbc.OdbcCommand("select COUNT(DISTINCT docno) AS IDD from Purchasereturn", cn)
        dr2 = cmd2.ExecuteReader()
        dr2.Read()
        Dim ID As Integer = 0
        If dr2.HasRows Then
            ID = dr2.Item("IDD")
            ID = ID + 1
        Else
            ID = ID + 1
        End If

        lblreturndocno.Text = Format(ID, "000#")
        dr2.Close()
        cn.Close()

        btnreturncancel_Click(sender, e)

        cmbreturnsupcode.Focus()
        cmbreturnsupcode.SelectAll()

        MsgBox("Return Details Save Successfully..")

    End Sub

    Private Sub btnreturnselected_Click(sender As Object, e As EventArgs) Handles btnreturnselected.Click
        Try

            For i As Integer = Me.returncartdatagridview.SelectedRows.Count - 1 To 0 Step -1
                Dim result As DialogResult = MessageBox.Show("Are You Sure Delete Data..?", Me.Text, MessageBoxButtons.YesNo)
                If result = Windows.Forms.DialogResult.Yes Then
                    cmdDelete = "delete Temppurchase where id='" & Me.returncartdatagridview.SelectedRows(i).Cells(0).Value.ToString() & "'"
                    da = New OdbcDataAdapter(cmdDelete, cn)
                    ds = New DataSet()
                    da.Fill(ds)
                    Me.returncartdatagridview.Rows.Remove(Me.returncartdatagridview.SelectedRows(i))
                End If
            Next

            LoadRecord()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub btnreturngetorder_Click(sender As Object, e As EventArgs) Handles btnreturngetorder.Click
        'returncartdatagridview.ColumnCount = 7
        'returncartdatagridview.Columns(0).Name = "ID"
        'returncartdatagridview.Columns(1).Name = "Code"
        'returncartdatagridview.Columns(2).Name = "Name"
        'returncartdatagridview.Columns(3).Name = "Cost Price"
        'returncartdatagridview.Columns(4).Name = "Quantity"
        'returncartdatagridview.Columns(5).Name = "Discount"
        'returncartdatagridview.Columns(6).Name = "Amount"
        'returncartdatagridview.Rows.Clear()
        'Dim IDF As Integer = 0
        'returncartdatagridview.Columns(0).Width = 60
        'returncartdatagridview.Columns(1).Width = 80
        'returncartdatagridview.Columns(2).Width = 220
        'returncartdatagridview.Columns(3).Width = 80
        'returncartdatagridview.Columns(4).Width = 80
        'returncartdatagridview.Columns(5).Width = 80
        'returncartdatagridview.Columns(6).Width = 80
        'returncartdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        'returncartdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'returncartdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'returncartdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'returncartdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'returncartdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        'returncartdatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'returncartdatagridview.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        cmd = New OdbcCommand("select * from Purchase where docno ='" & cmbreturnprnno.Text & "' and supcode='" & cmbreturnsupcode.Text & "' and loca='" & loca & "'", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            'While dr.Read
            Dim row As String() = New String() {dr("id"), dr("code"), dr("name"), Format(dr("costprice"), "####0.00"), Format(dr("quantity"), "####0"), Format(dr("discount"), "####0"), Format(dr("amount"), "####0")}
            returncartdatagridview.Rows.Add(row)

            dpreturnpurchasedate.Value = dr("date")
            Txtreturngrandtotal.Text = Format(Val(dr("gtotal")), "####0.00")
            'End While

            returncartdatagridview.Refresh()
        End If
        dr.Close()

        txtreturnitemssearch.Focus()
        txtreturnitemssearch.SelectAll()

        cmd = New Odbc.OdbcCommand("select COUNT(DISTINCT docno) AS IDD from Purchasereturn", cn)
        dr = cmd.ExecuteReader()
        dr.Read()
        Dim ID As Integer = 0
        If dr.HasRows Then
            ID = dr.Item("IDD")
            ID = ID + 1
        Else
            ID = ID + 1
        End If

        lblreturndocno.Text = Format(ID, "000#")

    End Sub

End Class