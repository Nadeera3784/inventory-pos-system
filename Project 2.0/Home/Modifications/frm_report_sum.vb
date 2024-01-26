Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.Odbc

Public Class frm_report_sum
    Dim str As String
    Dim RPT_DOC As New ReportDocument
    Dim tbl As String
    Private Sub btnreportsdisplay1_Click(sender As Object, e As EventArgs) Handles btnreportsdisplay1.Click
        Dim dt3 As New DataTable
        connection()
        Try

            cmd.CommandText = str
            cmd.Connection = cn
            Dim adp1 As New OdbcDataAdapter(cmd)
            adp1.Fill(dt3)
            RPT_DOC.Database.Tables(tbl).SetDataSource(dt3)
            Report_viewer.CRV.ReportSource = Nothing
            Report_viewer.CRV.ReportSource = RPT_DOC
            Report_viewer.CRV.Refresh()
            Report_viewer.CRV.RefreshReport()
            Report_viewer.Show()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbInformation,)
        End Try
    End Sub

    Private Sub frm_report_sum_Load(sender As Object, e As EventArgs) Handles Me.Load
        If RPTMode = 1 Then '// Sales Summary

            str = ("SELECT * FROM RPT_DepartmentWiseSales WHERE loca='" + loca + "' and isdelete='0' and dateshort >= '" + Format(dtpFrom.Value, "yyMMdd") + "' and dateshort <='" + Format(dtpTo.Value, "yyMMdd") + "' order by invoiceno desc")
            tbl = "RPT_DepartmentWiseSales"
            RPT_DOC = New Sales_Summary

        ElseIf RPTMode = 2 Then

        End If
    End Sub

    Private Sub btnreportscancel1_Click(sender As Object, e As EventArgs) Handles btnreportscancel1.Click
        Me.Dispose()
    End Sub
End Class