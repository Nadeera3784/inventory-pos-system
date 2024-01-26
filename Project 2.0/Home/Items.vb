
Imports System.Data.Odbc

Public Class Items
    Dim da1 As New OdbcDataAdapter
    Dim ds1 As New DataSet
    Private Sub RefreshData()
        connection()

        Try
            If ds1.Tables.Contains("Items") Then
                ds1.Tables.Remove("Items")
            End If

            cmdx.CommandText = "select * from items where loca='" & loca & "'"
            cmdx.Connection = cn
            da1.SelectCommand = cmdx
            da1.Fill(ds1, "Items")
            cmbicode.DataSource = ds1.Tables("Items")
            cmbiname.DataSource = ds1.Tables("Items")
            cmbicode.DisplayMember = "code"
            cmbiname.DisplayMember = "name"
            Clear_all()

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Load Items")
            cn.Close()
        End Try
    End Sub

    Private Sub Medicine_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtibarcode.Focus()
    End Sub
    Private Sub Load_Supplier()
        Try
            connection()
            cmd = New OdbcCommand("select * from Supplier where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            While dr.Read

                If Not IsDBNull(dr(0)) Then
                    cmbisupcode.Items.Add(dr.Item("code"))
                    cmbisupname.Items.Add(Trim(dr.Item("name")))
                End If
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Load Supplier")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub Search_itemId()
        connection()

        Try
            cmd = New OdbcCommand("select max(code) as IDD from Items where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            While dr.Read

                If Not IsDBNull(dr(0)) Then
                    Dim itemscode As Integer
                    itemscode = Val(dr("IDD")) + 1
                    cmbicode.Text = Format(itemscode, "0000#")

                Else
                    cmbicode.Text = "00001"
                End If
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Item ID")
            dr.Close()
        End Try
    End Sub
    Private Sub Clear_all()
        cmbicode.Text = ""
        txtibarcode.Text = ""
        cmbiname.Text = ""
        txtinsinhala.Text = ""
        cmbicatecode.Text = ""
        cmbicatename.Text = ""
        cmbisupcode.Text = ""
        cmbisupname.Text = ""
        Cmbdeptcode.Text = ""
        cmbdeptname.Text = ""
        txtidetails.Text = ""
        txticostprice.Text = ""
        txtiprofit.Text = ""
        txtisellprice.Text = ""
        txtiwsprice.Text = ""
        cmbiunit.Text = ""
        cmbipacksize.Text = ""
        txtiopstockqty.Text = ""
        txtitotalqtybalance.Text = ""
        txtourPrice.Text = ""
        cmbiname.Select()
    End Sub

    Private Sub Medicine_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RefreshData()
        Load_Supplier()
        Category_load()
        Clear_all()
        Search_itemId()
        DtpExp.Value = Now
    End Sub

    Private Sub btnitemsdelete_Click(sender As Object, e As EventArgs) Handles btnitemsdelete.Click
        connection()

        Try
            cmd = New OdbcCommand("delete Items where code='" & cmbicode.Text & "' and loca='" & loca & "'", cn)
            cmd.ExecuteNonQuery()
            cmbicode.Text = ""
            txtibarcode.Text = ""
            cmbiname.Text = ""
            txtinsinhala.Text = ""
            cmbicatecode.Text = ""
            cmbicatename.Text = ""
            cmbisupcode.Text = ""
            cmbisupname.Text = ""
            Cmbdeptcode.Text = ""
            cmbdeptname.Text = ""
            txtidetails.Text = ""
            txticostprice.Text = ""
            txtiprofit.Text = ""
            txtisellprice.Text = ""
            txtiwsprice.Text = ""
            cmbiunit.Text = ""
            cmbipacksize.Text = ""
            txtiopstockqty.Text = ""
            txtitotalqtybalance.Text = ""
            txtourPrice.Text = ""
            cmbicode.Select()
            MsgBox("Items Delete Successfully....", MsgBoxStyle.Critical, "Delete Alert")
            RefreshData()
            Search_itemId()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Item Delete")
        End Try
    End Sub

    Private Sub btnitemssave_Click(sender As Object, e As EventArgs) Handles btnitemssave.Click
        If Format(DtpExp.Value, "yyyy-MMM-dd") = Format(Now, "yyyy-MMM-dd") Then
            MsgBox("Please Select Expiry Date", vbOKOnly + vbQuestion, "Point Of Sale System")

        Else
            connection()
            Try

                'cmdx.CommandText = "INSERT INTO Items Values('" & Trim(cmbicode.Text) & "','" & cmbiname.Text & "','" & txtibarcode.Text & "','" & txtinsinhala.Text & "','" & Cmbdeptcode.Text & "','" & cmbdeptname.Text & "','" & cmbicatecode.Text & "','" & cmbicatename.Text & "','" & cmbisupcode.Text & "','" & cmbisupname.Text & "','" & txtidetails.Text & "','" & cmbiunit.Text & "','" & cmbipacksize.Text & "','" & txticostprice.Text & "','" & txtiprofit.Text & "','" & txtisellprice.Text & "','" & txtiwsprice.Text & "','" & txtiopstockqty.Text & "','" & txtitotalqtybalance.Text & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & loca & "'"
                cmdx.CommandText = "INSERT INTO Items (code,name,barcode,sinahalaname,catecode,catename,supcode,supname,details,unit,packsize,costprice,profit,sellprice,wsprice,opstockqty,totalqty,dateshort,datelong,loca,deptcode,deptname,ourprice,expdate) values ('" & Trim(cmbicode.Text.ToString) & "','" & Trim(cmbiname.Text.ToString) & "','" & Trim(txtibarcode.Text.ToString) & "','" & Trim(txtinsinhala.Text.ToString) & "','" & Trim(cmbicatecode.Text.ToString) & "','" & Trim(cmbicatename.Text.ToString) & "','" & Trim(cmbisupcode.Text.ToString) & "','" & Trim(cmbisupname.Text.ToString) & "','" & Trim(txtidetails.Text.ToString) & "','" & Trim(cmbiunit.Text.ToString) & "','" & Trim(cmbipacksize.Text.ToString) & "','" & Trim(txticostprice.Text.ToString) & "','" & Trim(txtiprofit.Text.ToString) & "','" & Trim(txtisellprice.Text.ToString) & "','" & Trim(txtiwsprice.Text.ToString) & "','" & Trim(txtiopstockqty.Text.ToString) & "','" & Trim(txtitotalqtybalance.Text.ToString) & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & loca.ToString & "','" & Cmbdeptcode.Text.ToString & "','" & cmbdeptname.Text.ToString & "','" & txtourPrice.Text.ToString & "','" + Format(DtpExp.Value, "yyyy-MMM-dd") + "')"
                cmdx.Connection = cn
                cmdx.ExecuteNonQuery()
                cn.Close()
                cmbicode.Text = ""
                txtibarcode.Text = ""
                cmbiname.Text = ""
                txtinsinhala.Text = ""
                Cmbdeptcode.Text = ""
                cmbdeptname.Text = ""
                cmbicatecode.Text = ""
                cmbicatename.Text = ""
                cmbisupcode.Text = ""
                cmbisupname.Text = ""
                txticostprice.Text = ""
                txtiprofit.Text = ""
                txtisellprice.Text = ""
                txtourPrice.Text = ""
                txtidetails.Text = ""
                cmbiunit.Text = ""
                cmbipacksize.Text = ""
                txtiopstockqty.Text = ""
                txtitotalqtybalance.Text = ""
                txtiwsprice.Text = ""
                DtpExp.Value = Now
                cmbicode.Select()
                MsgBox("Items Save Successfully....", MsgBoxStyle.Information, "Save Alert")
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in Save")
            End Try

            RefreshData()
            Search_itemId()
        End If
    End Sub

    Private Sub cmbiname_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbiname.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtinsinhala.Focus()
                txtinsinhala.SelectAll()
        End Select
    End Sub

    Private Sub cmbiname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbiname.SelectedIndexChanged

        Try
            connection2()
            cmd2 = New OdbcCommand("select * from Items where name='" & Trim(cmbiname.Text) & "'and loca='" & loca & "'", cn2)
            dr5 = cmd2.ExecuteReader
            dr5.Read()
            If dr5.HasRows Then

                txtibarcode.Text = Trim(dr5.Item("barcode"))
                cmbiname.Text = Trim(dr5.Item("name"))
                txtinsinhala.Text = Trim(dr5.Item("sinahalaname"))
                Cmbdeptcode.Text = Trim(dr5.Item("deptcode"))
                cmbdeptname.Text = Trim(dr5.Item("deptname"))
                cmbicatecode.Text = Trim(dr5.Item("catecode"))
                cmbicatename.Text = Trim(dr5.Item("catename"))
                cmbisupcode.Text = Trim(dr5.Item("supcode"))
                cmbisupname.Text = Trim(dr5.Item("supname"))
                txtidetails.Text = Trim(dr5.Item("details"))
                cmbiunit.Text = Trim(dr5.Item("unit"))
                cmbipacksize.Text = Trim(dr5.Item("packsize"))
                txticostprice.Text = Format(Val(Trim(dr5.Item("costprice"))), "####0.00")
                txtiprofit.Text = Format(Val(Trim(dr5.Item("profit"))), "####0.00")
                txtisellprice.Text = Format(Val(Trim(dr5.Item("sellprice"))), "####0.00")
                txtiwsprice.Text = Format(Val(Trim(dr5.Item("wsprice"))), "####0.00")
                txtiopstockqty.Text = Format(Val(Trim(dr5.Item("opstockqty"))), "####0")
                txtitotalqtybalance.Text = Format(Val(Trim(dr5.Item("totalqty"))), "####0")
                txtourPrice.Text = Format(Val(Trim(dr5.Item("ourprice"))), "####0.00")
                If Not IsDBNull(dr5.Item("expdate")) Then
                    DtpExp.Value = dr5.Item("expdate")
                End If
            End If
                dr5.Close()
            cn2.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in Item Name")
            dr5.Close()
            cn2.Close()
        End Try

    End Sub

    Private Sub cmbicatename_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbicatename.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cmbisupcode.Focus()
                cmbisupname.SelectAll()
        End Select
    End Sub

    Private Sub cmbicatecode_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbicatecode.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cmbicatename.Focus()
                cmbicatename.SelectAll()
        End Select
    End Sub

    Private Sub cmbisupcode_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbisupcode.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cmbisupname.Focus()
                cmbisupname.SelectAll()
        End Select
    End Sub

    Private Sub cmbisupname_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbisupname.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtidetails.Focus()
                txtidetails.SelectAll()
        End Select
    End Sub

    Private Sub txtidetails_KeyDown(sender As Object, e As KeyEventArgs) Handles txtidetails.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cmbiunit.Focus()
                cmbiunit.SelectAll()
        End Select
    End Sub

    Private Sub cmbiunit_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbiunit.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cmbipacksize.Focus()
                cmbipacksize.SelectAll()
        End Select
    End Sub

    Private Sub txticostprice_KeyDown(sender As Object, e As KeyEventArgs) Handles txticostprice.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter

                If txticostprice.Text.Contains("/") = True Then
                    Dim A, B As Double
                    A = Mid(txticostprice.Text, 1, InStr(txticostprice.Text, "/", CompareMethod.Text) - 1)
                    B = Mid(txticostprice.Text, InStr(txticostprice.Text, "/", CompareMethod.Text) + 1)

                    txticostprice.Text = A / B

                ElseIf txticostprice.Text.Contains("*") = True Then
                    Dim A, B As Double
                    A = Mid(txticostprice.Text, 1, InStr(txticostprice.Text, "*", CompareMethod.Text) - 1)
                    B = Mid(txticostprice.Text, InStr(txticostprice.Text, "*", CompareMethod.Text) + 1)

                    txticostprice.Text = A * B

                ElseIf txticostprice.Text.Contains("+") = True Then
                    Dim A, B As Double
                    A = Mid(txticostprice.Text, 1, InStr(txticostprice.Text, "+", CompareMethod.Text) - 1)
                    B = Mid(txticostprice.Text, InStr(txticostprice.Text, "+", CompareMethod.Text) + 1)

                    txticostprice.Text = A + B

                ElseIf txticostprice.Text.Contains("-") = True Then
                    Dim A, B As Double
                    A = Mid(txticostprice.Text, 1, InStr(txticostprice.Text, "-", CompareMethod.Text) - 1)
                    B = Mid(txticostprice.Text, InStr(txticostprice.Text, "-", CompareMethod.Text) + 1)

                    txticostprice.Text = A - B

                Else
                    txtisellprice.Focus()
                End If

                txtisellprice.Focus()
                txtisellprice.SelectAll()
        End Select
    End Sub

    Private Sub txtiprofit_KeyDown(sender As Object, e As KeyEventArgs) Handles txtiprofit.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter

                If Mid(txtiprofit.Text, txtiprofit.Text.Length) = "%" Then
                    txtiprofit.Text = txtiprofit.Text.Remove(txtiprofit.Text.Length - 1)

                    Dim AMT As Decimal
                    AMT = Val(txticostprice.Text) * Val(txtiprofit.Text) / 100
                    txtiprofit.Text = AMT
                End If

                txtisellprice.Text = Val(txticostprice.Text) + Val(txtiprofit.Text)

                txtisellprice.Focus()
                txtisellprice.SelectAll()

        End Select
    End Sub

    Private Sub txtisellprice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtisellprice.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter

                If Mid(txtisellprice.Text, txtisellprice.Text.Length) = "%" Then
                    txtiprofit.Text = txtiprofit.Text.Remove(txtiprofit.Text.Length - 1)

                    Dim AMT As Decimal
                    AMT = Val(txticostprice.Text) * Val(txtiprofit.Text) / 100
                    txtiprofit.Text = AMT
                End If

                txtiprofit.Text = Val(txtisellprice.Text) - Val(txticostprice.Text)

                txtourPrice.Focus()
                txtourPrice.SelectAll()
        End Select
    End Sub

    Private Sub txtiopstockqty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtiopstockqty.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtitotalqtybalance.Focus()
                txtitotalqtybalance.SelectAll()
        End Select
    End Sub

    Private Sub txtitotalqtybalance_KeyDown(sender As Object, e As KeyEventArgs) Handles txtitotalqtybalance.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnitemssave.Focus()
                btnitemssave.Select()
        End Select
    End Sub

    Private Sub cmbicode_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbicode.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtibarcode.Focus()
                txtibarcode.SelectAll()
        End Select
    End Sub

    Private Sub txtibarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtibarcode.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cmbiname.Focus()
                cmbiname.SelectAll()
        End Select
    End Sub

    Private Sub cmbicode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbicode.SelectedIndexChanged
        Try
            connection1()
            cmd3 = New OdbcCommand("select * from Items where code='" & Trim(cmbicode.Text) & "'and loca='" & loca & "'", cn1)
            dr3 = cmd3.ExecuteReader
            dr3.Read()
            If dr3.HasRows Then

                'cmbicode.Text = Trim(dr2.Item("code"))
                txtibarcode.Text = Trim(dr3.Item("barcode"))
                cmbiname.Text = Trim(dr3.Item("name"))
                txtinsinhala.Text = Trim(dr3.Item("sinahalaname"))
                Cmbdeptcode.Text = Trim(dr3.Item("deptcode"))
                cmbdeptname.Text = Trim(dr3.Item("deptname"))
                cmbicatecode.Text = Trim(dr3.Item("catecode"))
                cmbicatename.Text = Trim(dr3.Item("catename"))
                cmbisupcode.Text = Trim(dr3.Item("supcode"))
                cmbisupname.Text = Trim(dr3.Item("supname"))
                txtidetails.Text = Trim(dr3.Item("details"))
                cmbiunit.Text = Trim(dr3.Item("unit"))
                cmbipacksize.Text = Trim(dr3.Item("packsize"))
                txticostprice.Text = Format(Val(Trim(dr3.Item("costprice"))), "####0.00")
                txtiprofit.Text = Format(Val(Trim(dr3.Item("profit"))), "####0.00")
                txtisellprice.Text = Format(Val(Trim(dr3.Item("sellprice"))), "####0.00")
                txtiwsprice.Text = Format(Val(Trim(dr3.Item("wsprice"))), "####0.00")
                txtiopstockqty.Text = Format(Val(Trim(dr3.Item("opstockqty"))), "####0")
                txtitotalqtybalance.Text = Format(Val(Trim(dr3.Item("totalqty"))), "####0")
                txtourPrice.Text = Format(Val(Trim(dr3.Item("ourprice"))), "####0.00")
                If Not IsDBNull(dr3.Item("expdate")) Then
                    DtpExp.Value = dr3.Item("expdate")
                End If
            End If

            dr3.Close()
            cn1.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Item Code")
            dr3.Close()
            cn1.Close()
        End Try
    End Sub

    Private Sub cmbisupname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbisupname.SelectedIndexChanged
        Try
            connection()
            cmd4 = New OdbcCommand("select * from Supplier where name='" & cmbisupname.Text & "' and loca='" & loca & "'", cn)
            dr4 = cmd4.ExecuteReader
            dr4.Read()
            If dr4.HasRows Then
                cmbisupcode.Text = Trim(dr4.Item("code"))
                'cmbisupname.Text = Trim(dr4.Item("name"))
            End If
            dr4.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Supplier Name")
            dr4.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub cmbisupcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbisupcode.SelectedIndexChanged
        Try
            connection1()
            cmd3 = New OdbcCommand("select * from Supplier where code='" & cmbisupcode.Text & "' and loca='" & loca & "'", cn1)
            dr3 = cmd3.ExecuteReader
            dr3.Read()
            If dr3.HasRows Then
                'cmbisupcode.Text = Trim(dr3.Item("code"))
                cmbisupname.Text = Trim(dr3.Item("name"))
            End If
            dr3.Close()
            cn1.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Supplier Code")
            dr3.Close()
            cn1.Close()
        End Try
    End Sub

    Private Sub btnitemsupdate_Click(sender As Object, e As EventArgs) Handles btnitemsupdate.Click
        Try
            connection()
            cmd = New OdbcCommand("select * from Items where code='" & cmbicode.Text & "' and loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader
            Dim df As Boolean = False
            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    df = True
                End If
            End While
            dr.Close()
            cn.Close()

            If df = True Then

                connection()

                Try
                    cmd2 = New OdbcCommand("UPDATE Items set code='" & Trim(cmbicode.Text.ToString) & "',name='" & cmbiname.Text.ToString & "', barcode='" & txtibarcode.Text.ToString & "',  sinahalaname='" & txtinsinhala.Text.ToString & "', deptcode='" & Cmbdeptcode.Text.ToString & "', deptname='" & cmbdeptname.Text & "', catecode='" & cmbicatecode.Text.ToString & "', catename='" & cmbicatename.Text.ToString & "', supcode='" & cmbisupcode.Text.ToString & "', supname='" & cmbisupname.Text.ToString & "',  details='" & txtidetails.Text.ToString & "',  unit='" & cmbiunit.Text.ToString & "',packsize='" & cmbipacksize.Text.ToString & "', costprice='" & txticostprice.Text.ToString & "', profit='" & txtiprofit.Text.ToString & "', sellprice='" & txtisellprice.Text.ToString & "',wsprice='" & txtiwsprice.Text.ToString & "',  opstockqty='" & txtiopstockqty.Text.ToString & "', totalqty='" & txtitotalqtybalance.Text.ToString & "', ourprice='" + txtourPrice.Text + "',expdate='" + Format(DtpExp.Value, "yyyy-MMM-dd") + "' where code='" & cmbicode.Text.ToString & "' and loca='" & loca.ToString & "'", cn)
                    cmd2.ExecuteNonQuery()
                    cn.Close()
                    cmbicode.Text = ""
                    txtibarcode.Text = ""
                    cmbiname.Text = ""
                    txtinsinhala.Text = ""
                    Cmbdeptcode.Text = ""
                    cmbdeptname.Text = ""
                    cmbicatecode.Text = ""
                    cmbicatename.Text = ""
                    cmbisupcode.Text = ""
                    cmbisupname.Text = ""
                    txticostprice.Text = ""
                    txtiprofit.Text = ""
                    txtisellprice.Text = ""
                    txtiwsprice.Text = ""
                    txtidetails.Text = ""
                    cmbiunit.Text = ""
                    cmbipacksize.Text = ""
                    txtiopstockqty.Text = ""
                    txtitotalqtybalance.Text = ""
                    txtourPrice.Text = ""
                    DtpExp.Value = Now
                    cmbicode.Select()
                    MsgBox("Items Update Successfully....", MsgBoxStyle.Information, "Update Alert")
                    RefreshData()
                Catch ex As Exception
                    MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Item Search")
                    cn.Close()
                End Try

            Else
                MsgBox("Item Code Not in Use")
            End If
            Search_itemId()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Item Search")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub cmbicatename_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbicatename.SelectedIndexChanged
        cmbicatecode.Text = cmbicatename.SelectedValue.ToString

        Department_load()

    End Sub



    Private Sub txtinsinhala_KeyDown(sender As Object, e As KeyEventArgs) Handles txtinsinhala.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cmbicatename.Focus()
                cmbicatename.SelectAll()
        End Select
    End Sub

    Private Sub cmbipacksize_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbipacksize.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txticostprice.Focus()
                txticostprice.SelectAll()
        End Select
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdeptname.SelectedIndexChanged
        Cmbdeptcode.Text = cmbdeptname.SelectedValue.ToString

    End Sub
    Private Sub Category_load()

        Dim ds2 As New DataSet
        Dim da2 As New OdbcDataAdapter
        Try
            connection()

            If ds2.Tables.Contains("category") Then
                ds2.Tables.Remove("category")
            End If

            cmdx.CommandText = "select name,code from Category where loca='" & loca & "'"
            cmdx.Connection = cn
            da2.SelectCommand = cmdx
            da2.Fill(ds2, "category")
            cmbicatename.DataSource = ds2.Tables("category")
            cmbicatename.DisplayMember = "name"
            cmbicatename.ValueMember = "code"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Category")
            cn.Close()
        End Try
    End Sub

    Private Sub Department_load()
        Dim da1 As New OdbcDataAdapter
        Dim ds1 As New DataSet

        Try
            connection3()

            If ds1.Tables.Contains("Department") Then
                ds1.Tables.Remove("Department")
            End If

            cmd.CommandText = "select deptname,deptcode from category where loca='" & loca & "' and code='" + cmbicatename.SelectedValue.ToString + "'"
            cmd.Connection = cn3
            da1.SelectCommand = cmd
            da1.Fill(ds1, "Department")
            cmbdeptname.DataSource = ds1.Tables("Department")
            cmbdeptname.DisplayMember = "deptname"
            cmbdeptname.ValueMember = "deptcode"

            cn3.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Departments")
            cn3.Close()
        End Try
    End Sub

    Private Sub txtiwsprice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtiwsprice.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter


                If txtiwsprice.Text.Contains("/") = True Then
                    Dim A, B As Double
                    A = Mid(txtiwsprice.Text, 1, InStr(txtiwsprice.Text, "/", CompareMethod.Text) - 1)
                    B = Mid(txtiwsprice.Text, InStr(txtiwsprice.Text, "/", CompareMethod.Text) + 1)

                    txtiwsprice.Text = A / B

                ElseIf txtiwsprice.Text.Contains("*") = True Then
                    Dim A, B As Double
                    A = Mid(txtourPrice.Text, 1, InStr(txtiwsprice.Text, "*", CompareMethod.Text) - 1)
                    B = Mid(txtourPrice.Text, InStr(txtiwsprice.Text, "*", CompareMethod.Text) + 1)

                    txtiwsprice.Text = A * B

                ElseIf txtourPrice.Text.Contains("+") = True Then
                    Dim A, B As Double
                    A = Mid(txtiwsprice.Text, 1, InStr(txtiwsprice.Text, "+", CompareMethod.Text) - 1)
                    B = Mid(txtiwsprice.Text, InStr(txtiwsprice.Text, "+", CompareMethod.Text) + 1)

                    txtiwsprice.Text = A + B

                ElseIf txtiwsprice.Text.Contains("-") = True Then
                    Dim A, B As Double
                    A = Mid(txtiwsprice.Text, 1, InStr(txtiwsprice.Text, "-", CompareMethod.Text) - 1)
                    B = Mid(txtiwsprice.Text, InStr(txtiwsprice.Text, "-", CompareMethod.Text) + 1)

                    txtiwsprice.Text = A - B

                Else
                    txtiwsprice.Focus()
                End If
                txtiopstockqty.Focus()
                txtiopstockqty.SelectAll()
        End Select
    End Sub

    Private Sub txtourPrice_KeyDown(sender As Object, e As KeyEventArgs) Handles txtourPrice.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter

                If Mid(txtisellprice.Text, txtisellprice.Text.Length) = "%" Then
                    txtiprofit.Text = txtiprofit.Text.Remove(txtiprofit.Text.Length - 1)

                    Dim AMT As Decimal
                    AMT = Val(txticostprice.Text) * Val(txtiprofit.Text) / 100
                    txtiprofit.Text = AMT
                End If

                txtiprofit.Text = Val(txtourPrice.Text) - Val(txticostprice.Text)

                txtiwsprice.Focus()
                txtiwsprice.SelectAll()
        End Select
    End Sub
End Class