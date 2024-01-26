Public Class ReportDaily

    Private Sub btnreportsdisplay1_Click(sender As Object, e As EventArgs) Handles btnreportsdisplay1.Click
        lblheadertext1.Text = "Daily Expenses"
        Reportspanel1.Show()
        connection()
        cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_DailyExpenses as select * from expenses where dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "'", cn)
        cmd.ExecuteNonQuery()
        RPTFile = My.Application.Info.DirectoryPath & "\RPT\DailyExpenses.rpt"
        Reportviewer.Show()
        cn.Close()
    End Sub
End Class