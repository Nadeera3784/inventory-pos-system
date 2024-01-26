
Imports System.Data.Odbc

Public Class Managepurchase

    Private Sub LoadRecord_ALL()
        connection()
        DGGRN.Rows.Clear()
        Try
            cmd.CommandText = "select * from GRNDetail WHERE loca='" + loca + "'"
            cmd.Connection = cn
            dr = cmd.ExecuteReader

            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    DGGRN.Rows.Add(dr("InvNo"), dr("icode"), dr("iname"), dr("invprice"), dr("sellingprice"), dr("stock"), dr("receive"), dr("newstock"), dr("name"), dr("enteredby"), dr("datelong"))
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

    Private Sub LoadRecord()
        connection()
        DGGRN.Rows.Clear()
        Try
            cmd.CommandText = "select * from GRNDetail WHERE invno like '%" + txtviewpurchasesearch.Text + "%' and loca='" + loca + "'"
            cmd.Connection = cn
            dr = cmd.ExecuteReader

            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    DGGRN.Rows.Add(dr("InvNo"), dr("icode"), dr("iname"), dr("invprice"), dr("sellingprice"), dr("stock"), dr("receive"), dr("newstock"), dr("name"), dr("enteredby"), dr("datelong"))
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

    Private Sub Managepurchase_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtviewpurchasesearch.Focus()
        txtviewpurchasesearch.SelectAll()
    End Sub

    Private Sub Managepurchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadRecord_ALL()

    End Sub

    Private Sub txtviewpurchasesearch_TextChanged(sender As Object, e As EventArgs) Handles txtviewpurchasesearch.TextChanged
        If txtviewpurchasesearch.Focus Then

            LoadRecord()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnpurchaseview.Click

        connection()
        cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_AllPurchase as select * from Purchase", cn)
        cmd.ExecuteNonQuery()
        RPTFile = My.Application.Info.DirectoryPath & "\RPT\AllPurchase.rpt"
        Reportviewer.Show()
        cn.Close()
    End Sub
End Class