Imports System.Data.Odbc
Public Class ReturnToSupplier
    Dim da1 As New OdbcDataAdapter
    Dim ds1 As New DataSet
    Public Sub generate_AODNO()

        connection()
        Try

            cmdx.CommandText = "SELECT MAX(AODNO)as AOD from returnToSupplier WHERE loca='" + loca + "'"
            cmdx.Connection = cn
            dr = cmdx.ExecuteReader

            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    Dim aodNo As Integer
                    aodNo = Val(dr(0)) + 1
                    txtaod.Text = Format(aodNo, "000#")
                Else
                    txtaod.Text = "0001"
                End If

            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            dr.Close()
            cn.Close()
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
    Public Sub load_invoices()
        '// Invoices to Combo Box //


        cominvoice.Items.Clear()
        connection()
        Try
            cmdx.CommandText = "select invNo from GoodsReceive where loca='" & loca & "' and supcode='" + comSupplier.SelectedValue.ToString + "' group by invno"
            cmdx.Connection = cn
            dr = cmdx.ExecuteReader
            Dim df As Boolean = False
            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    cominvoice.Items.Add(dr(0))
                    df = True

                Else
                    cominvoice.Items.Clear()
                    cominvoice.Text = ""
                End If
            End While
            dr.Close()
            cn.Close()

            If df = False Then
                cominvoice.Items.Clear()
                cominvoice.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            dr.Close()
            cn.Close()

        End Try
    End Sub

    Public Sub DGPick_load()
        '// Load Items To DGPick Items //

        connection()
        Try
            cmdx.CommandText = "Select icode,iname,catename,invprice,sellingprice,receive from grndetail WHERE loca='" + loca + "' and invno='" + cominvoice.Text + "'"
            cmdx.Connection = cn
            dr = cmdx.ExecuteReader
            DGPickItem.Rows.Clear()
            Dim i As Integer = 1
            While dr.Read

                DGPickItem.Rows.Add(i, dr("iCode"), dr("iName"), dr("catename"), dr("invprice"), dr("sellingprice"), dr("receive"))
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

    Public Sub place_returnOrder()

        Try
            ' Dim i As Integer = 0
            For i As Integer = 0 To DGReturn.RowCount - 2

                Dim iCode As String = DGReturn.Rows(i).Cells(0).Value.ToString
                Dim iName As String = DGReturn.Rows(i).Cells(1).Value.ToString
                Dim catName As String = DGReturn.Rows(i).Cells(2).Value.ToString
                Dim invPrice As String = DGReturn.Rows(i).Cells(3).Value.ToString
                Dim RQty As String = DGReturn.Rows(i).Cells(4).Value.ToString

                Try
                    connection()
                    cmdx.CommandText = "insert into returntoSupplier (aodno,invno,catname,itemname,invprice,rqty,dateshort,datelong,returnby,loca,icode,supcode) VALUES ('" + txtaod.Text + "','" + cominvoice.Text.ToString + "','" + catName + "','" + iName + "' ,'" + invPrice + "','" + RQty + "','" + Format(dtp.Value, "yyMMdd") + "','" + Format(dtp.Value, "yyyy-MMM-dd") + "','" + txtuser.Text + "','" + loca + "','" + iCode + "','" + comSupplier.SelectedValue.ToString + "')"
                    cmdx.Connection = cn
                    cmdx.ExecuteNonQuery()
                    cn.Close()

                    Try
                        connection()

                        cmdx.CommandText = "UPDATE items SET totalqty=totalqty - '" + RQty.ToString + "' WHERE loca='" + loca + "' and code='" + iCode.ToString + "'"
                        cmdx.Connection = cn
                        cmdx.ExecuteNonQuery()
                        cn.Close()
                    Catch ex As Exception
                        MsgBox(ex.Message, vbOKOnly + vbInformation, "Error In Stock Update")
                    End Try
                Catch ex As Exception
                    MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in Insert Return Order")
                End Try

            Next

            MsgBox("Items Successfuly Returned.")
            DGReturn.Rows.Clear()
            cominvoice.Text = ""
            comSupplier.Text = ""
            btnReturn.Enabled = False
            ReturnAOD()
            generate_AODNO()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in Loop")
        End Try
    End Sub

    Public Sub ReturnAOD()
        Dim dt3 As New DataTable
        Dim cmdR As New OdbcCommand
        connection()
        Try

            cmdR.CommandText = "select * from ReturnAOD WHERE loca='" + loca + "' and AODno='" + txtaod.Text + "'"
            cmdR.Connection = cn
            Dim adp1 As New OdbcDataAdapter(cmdR)
            adp1.Fill(dt3)
            Dim rpt As New ReturnAOD '//(Return ADO Report)
            rpt.Database.Tables("ReturnAOD").SetDataSource(dt3)
            Report_viewer.CRV.ReportSource = Nothing
            Report_viewer.CRV.ReportSource = rpt
            Report_viewer.CRV.Refresh()
            Report_viewer.CRV.RefreshReport()
            Report_viewer.Show()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in Return AOD Generate")
        End Try
    End Sub

    Private Sub ReturnToSupplier_Load(sender As Object, e As EventArgs) Handles Me.Load
        generate_AODNO()
        Supplier()
        txtuser.Text = username
        btnReturn.Enabled = False
        DGReturn.Rows.Clear()

    End Sub

    Private Sub comSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comSupplier.SelectedIndexChanged
        load_invoices()
        DGReturn.Rows.Clear()
    End Sub

    Private Sub cominvoice_TextChanged(sender As Object, e As EventArgs) Handles cominvoice.TextChanged
        If cominvoice.Text <> "" Then
            DGPick_load()

        Else
            DGPickItem.Rows.Clear()
        End If
    End Sub
    Private Sub DGReturn_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGReturn.CellClick
        Dim colname As String = DGReturn.Columns(e.ColumnIndex).Index

        If colname = 5 Then
            DGReturn.Rows.Remove(DGReturn.CurrentRow)
            DGReturn.Refresh()
        End If
    End Sub

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Dim df As Boolean = False
        For i As Integer = 0 To DGReturn.RowCount - 1



            Try
                    connection()
                    cmdx.CommandText = "select totalqty from items WHERE loca='" + loca + "' and code='" + DGReturn.Rows(i).Cells(0).Value.ToString + "'"
                    cmdx.Connection = cn
                    dr = cmdx.ExecuteReader

                    While dr.Read
                        If Val(dr(0).ToString) - Val(DGReturn.Rows(i).Cells(4).Value.ToString) >= 0 Then
                            df = True

                        Else
                            MsgBox("Insufficient Stock (Item Code '" + DGReturn.Rows(i).Cells(0).Value.ToString + "')", vbOKOnly + vbExclamation)
                            Exit Sub
                            dr.Close()
                            cn.Close()
                        End If
                    End While
                    dr.Close()
                    cn.Close()

                Catch ex As Exception
                    'MsgBox(ex.Message)
                    dr.Close()
                    cn.Close()
                End Try

        Next

        If df = True Then
            MsgBox("Verified and Ready to Return")
            btnReturn.Enabled = True
        End If

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        place_returnOrder()
    End Sub

    Private Sub DGPickItem_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPickItem.CellClick
        Dim colname As String = DGPickItem.Columns(e.ColumnIndex).Index

        If colname = 7 Then
            'Dim i As Integer

            If Not IsDBNull(DGPickItem.CurrentRow.Cells(1).Value.ToString) Then
                DGReturn.Rows.Add(DGPickItem.CurrentRow.Cells(1).Value.ToString, DGPickItem.CurrentRow.Cells(2).Value.ToString, DGPickItem.CurrentRow.Cells(3).Value.ToString, DGPickItem.CurrentRow.Cells(5).Value.ToString(), DGPickItem.CurrentRow.Cells(6).Value.ToString())
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DGReturn.Rows.Clear()
        comSupplier.Text = ""
        cominvoice.Text = ""
        DGPickItem.Rows.Clear()

    End Sub
End Class