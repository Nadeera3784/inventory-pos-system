
Imports System.Data.Odbc
Public Class Manageinvoice

    Private Sub LoadRecord()
        connection()
        viewinvoicedatagridview.Rows.Clear()

        Try
            cmdx.CommandText = "SELECT * FROM All_in_one_sale WHERE invoiceno like '%" + txtviewinvoicessearch.Text + "%' and loca='" + loca + "' and isdelete='0'"
            cmdx.Connection = cn
            dr = cmdx.ExecuteReader
            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    viewinvoicedatagridview.Rows.Add(dr("invoiceno"), dr("catename"), dr("icode"), dr("iname"), dr("sellprice"), dr("ourprice"), dr("qty"), dr("discount"), dr("amount"), dr("cashier"), dr("custname"), dr("datelong"), dr("time"))
                    lblInvTotal.Text = Format(Val((From row As DataGridViewRow In viewinvoicedatagridview.Rows Where row.Cells(8).FormattedValue.ToString() <> String.Empty Select Convert.ToDouble(row.Cells(8).FormattedValue)).Sum().ToString()), "#,##0.00")
                    lblTotalDiscount.Text = Format(Val((From row As DataGridViewRow In viewinvoicedatagridview.Rows Where row.Cells(7).FormattedValue.ToString() <> String.Empty Select Convert.ToDouble(row.Cells(7).FormattedValue)).Sum().ToString()), "#,##0.00")
                End If
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Load Data")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub LoadRecord_All()
        connection()
        viewinvoicedatagridview.Rows.Clear()

        Try
            cmdx.CommandText = "SELECT * FROM All_in_one_sale WHERE loca='" + loca + "' and isdelete='0'"
            cmdx.Connection = cn
            dr = cmdx.ExecuteReader
            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    viewinvoicedatagridview.Rows.Add(dr("invoiceno"), dr("catename"), dr("icode"), dr("iname"), dr("sellprice"), dr("ourprice"), dr("qty"), dr("discount"), dr("amount"), dr("cashier"), dr("custname"), dr("datelong"), dr("time"))
                    lblInvTotal.Text = Format(Val((From row As DataGridViewRow In viewinvoicedatagridview.Rows Where row.Cells(8).FormattedValue.ToString() <> String.Empty Select Convert.ToDouble(row.Cells(8).FormattedValue)).Sum().ToString()), "#,##0.00")
                    lblTotalDiscount.Text = Format(Val((From row As DataGridViewRow In viewinvoicedatagridview.Rows Where row.Cells(7).FormattedValue.ToString() <> String.Empty Select Convert.ToDouble(row.Cells(7).FormattedValue)).Sum().ToString()), "#,##0.00")
                End If
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Load Data")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub Manageinvoice_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtviewinvoicessearch.Focus()
        txtviewinvoicessearch.SelectAll()
    End Sub

    Private Sub Manageinvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadRecord_All()

    End Sub

    Private Sub txtviewinvoicessearch_TextChanged(sender As Object, e As EventArgs) Handles txtviewinvoicessearch.TextChanged
        If txtviewinvoicessearch.Focus Then

            If txtviewinvoicessearch.Text.Length > 0 Then

                LoadRecord()

            End If

        End If
        cn.Close()
    End Sub

    Private Sub btnviewinvoicesprint_Click(sender As Object, e As EventArgs) Handles btnviewinvoicesprint.Click
        connection()
        cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_AllInvoice select * from Invoice", cn)
        cmd.ExecuteNonQuery()
        RPTFile = My.Application.Info.DirectoryPath & "\RPT\AllInvoice.rpt"
        Reportviewer.Show()
        cn.Close()
    End Sub
End Class