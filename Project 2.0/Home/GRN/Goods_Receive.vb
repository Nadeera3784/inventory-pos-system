Imports System.Data.Odbc
Public Class Goods_Receive
    Dim da1 As New OdbcDataAdapter
    Dim ds1 As New DataSet

    Public Sub Load_items()

        '// Load Items To DGPick Items //

        connection()
        Try
            cmdx.CommandText = "Select code,name,costprice,sellprice,totalqty,barcode from items WHERE loca='" + loca + "' and name like '%" + txtsearch.Text + "%'"
            cmdx.Connection = cn
            dr = cmdx.ExecuteReader
            DGPickItem.Rows.Clear()
            Dim i As Integer = 1
            While dr.Read

                DGPickItem.Rows.Add(i, dr("Code"), dr("Name"), dr("barcode"), dr("costprice"), dr("sellprice"), dr("totalqty"))
                i = i + 1
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
            dr.Close()

        End Try
    End Sub

    Public Sub Supplier()

        '// Supplier to Combo Box //

        connection()
        Try

            If ds1.Tables.Contains("Supplier") Then
                ds1.Tables.Remove("Supplier")
            End If

            cmdx.CommandText = "select name,code from Supplier where loca='" & loca & "'"
            cmdx.Connection = cn
            da1.SelectCommand = cmdx
            da1.Fill(ds1, "Supplier")
            comSupplier.DataSource = ds1.Tables("Supplier")
            comSupplier.DisplayMember = "name"
            comSupplier.ValueMember = "code"
            comSupplier.Text = ""
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub

    Private Sub Goods_Receive_Load(sender As Object, e As EventArgs) Handles Me.Load
        Supplier()
        txtsearch.Clear()
        Load_items()
        txtuser.Text = username
        DGReceive.Rows.Clear()
        dtp.Value = Now
        txtinvoice.Clear()
    End Sub

    Private Sub DGPickItem_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DGPickItem.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then


        End If
    End Sub

    Private Sub DGReceive_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGReceive.CellEndEdit
        If e.ColumnIndex = 6 Then
            Try

                DGReceive.CurrentRow.Cells(7).Value = Val(DGReceive.CurrentRow.Cells(5).Value.ToString()) + Val(DGReceive.CurrentRow.Cells(6).Value.ToString)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub btnReceive_Click(sender As Object, e As EventArgs) Handles btnReceive.Click
        If txtinvoice.Text <> "" Then

            If comSupplier.Text <> "" Then
                If DGReceive.Rows.Count <= 0 Then

                    MsgBox("Please Add Items to GRN", vbOKOnly + vbCritical)
                Else

                    Try

                        For x As Integer = 0 To DGReceive.RowCount - 1
                            Dim stock1 As String = DGReceive.Rows(x).Cells(7).Value
                            Dim code As String = DGReceive.Rows(x).Cells(0).Value
                            Dim name As String = DGReceive.Rows(x).Cells(1).Value
                            Dim barcode As String = DGReceive.Rows(x).Cells(2).Value
                            Dim invPrice As String = DGReceive.Rows(x).Cells(3).Value
                            Dim selPrice As String = DGReceive.Rows(x).Cells(4).Value
                            Dim OldStock As String = DGReceive.Rows(x).Cells(5).Value
                            Dim receive As String = DGReceive.Rows(x).Cells(6).Value

                            Try

                                connection()
                                cmdx.CommandText = "INSERT INTO GoodsReceive (iCode,iName,barcode,invPrice,sellingPrice,stock,receive,newStock,dateshort,datelong,enteredby,supcode,invno,loca) VALUES ('" + code + "','" + name + "','" + barcode + "','" + invPrice + "','" + selPrice + "','" + OldStock + "','" + receive + "','" + stock1 + "','" + Format(dtp.Value, "yyMMdd") + "','" + Format(dtp.Value, "yyyy-MMM-dd") + "','" + txtuser.Text + "','" + comSupplier.SelectedValue.ToString + "','" + txtinvoice.Text + "','" + loca.ToString + "')"
                                cmdx.Connection = cn
                                cmdx.ExecuteNonQuery()
                            Catch ex As Exception
                                MsgBox(ex.Message, vbOKOnly + vbInformation, "Insert Goods Receive")
                                Exit Sub
                            End Try

                            Try
                                connection()

                                cmdx.CommandText = "UPDATE items Set totalqty='" + stock1 + "' WHERE code='" + DGReceive.Rows(x).Cells(0).Value + "'"
                                cmdx.Connection = cn
                                cmdx.ExecuteNonQuery()
                            Catch ex As Exception
                                MsgBox(ex.Message, vbOKOnly + vbInformation, "Stock Update")

                            End Try
                        Next

                        MsgBox("GRN Successfull", vbOKOnly + vbInformation)
                        cn.Close()
                        DGReceive.Rows.Clear()
                        txtinvoice.Clear()
                        dtp.Value = Now
                        comSupplier.Text = ""
                        txtsearch.Clear()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        cn.Close()
                    End Try

                End If
            Else
                MsgBox("Please Select Supplier", vbOKOnly + vbCritical)
            End If

        Else

            MsgBox("Invoice No Canot be Blank", vbOKOnly + vbCritical)

        End If
    End Sub

    Private Sub DGReceive_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGReceive.CellClick
        Dim colname As String = DGReceive.Columns(e.ColumnIndex).Index

        If colname = 8 Then
            DGReceive.Rows.Remove(DGReceive.CurrentRow)
            DGReceive.Refresh()
        End If
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Load_items()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DGReceive.Rows.Clear()
        txtsearch.Clear()
        comSupplier.Text = ""
        txtinvoice.Clear()
        dtp.Value = Now
        Load_items()

    End Sub

    Private Sub DGPickItem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPickItem.CellClick
        Dim colname As String = DGReceive.Columns(e.ColumnIndex).Index

        If colname = 7 Then
            DGReceive.Rows.Add(DGPickItem.CurrentRow.Cells(1).Value.ToString, DGPickItem.CurrentRow.Cells(2).Value.ToString, DGPickItem.CurrentRow.Cells(3).Value.ToString, DGPickItem.CurrentRow.Cells(4).Value.ToString, DGPickItem.CurrentRow.Cells(5).Value.ToString(), DGPickItem.CurrentRow.Cells(6).Value.ToString, "0", (DGPickItem.CurrentRow.Cells(6).Value.ToString()))
        End If
    End Sub
End Class