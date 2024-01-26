Imports System.Data.Odbc
Public Class reportsales

    Private Sub btnreportsdisplay1_Click(sender As Object, e As EventArgs) Handles btnreportsdisplay1.Click

        Dim dt3 As New DataTable

        connection()
        Try

            cmdx.CommandText = "Select datelong,sum(costprice) as costprice , sum(seling_price) as seling_price, sum(discount) as discount,sum(selling_profit) as selling_profit from selling_profit Where dateshort between '" & Format(dpreports1from.Value, "yyMMdd") & "' and '" & Format(dpreports1to.Value, "yyMMdd") & "' group by datelong"
            cmdx.Connection = cn
            Dim adp1 As New OdbcDataAdapter(cmdx)
            adp1.Fill(dt3)
            Dim rpt As New Daily_Profit '//(Department Wise Sale)
            rpt.Database.Tables("Selling_Profit").SetDataSource(dt3)
            Report_viewer.CRV.ReportSource = Nothing
            Report_viewer.CRV.ReportSource = rpt
            Report_viewer.CRV.Refresh()
            Report_viewer.CRV.RefreshReport()
            Report_viewer.Show()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in Daily Profit")
        End Try
    End Sub
End Class