Imports System.Data.Odbc
Public Class GRN_Report
    Public Select_RPT As String
    Public Sub Load_invoice()
        connection()
        Dim da1 As New OdbcDataAdapter
        Dim ds1 As New DataSet

        Try
            If ds1.Tables.Contains("GoodsReceive") Then
                ds1.Tables.Remove("GoodsReceive")
            End If

            cmdx.CommandText = "select invno from GoodsReceive where loca='" & loca & "' group by invno"
            cmdx.Connection = cn
            da1.SelectCommand = cmdx
            da1.Fill(ds1, "GoodsReceive")
            comInvoice.DataSource = ds1.Tables("GoodsReceive")
            comInvoice.DisplayMember = "invno"
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub Load_AOD()
        connection()
        Dim da1 As New OdbcDataAdapter
        Dim ds1 As New DataSet

        Try
            If ds1.Tables.Contains("returntoSupplier") Then
                ds1.Tables.Remove("returntoSupplier")
            End If

            cmdx.CommandText = "select aodno from returntoSupplier where loca='" & loca & "' group by aodno"
            cmdx.Connection = cn
            da1.SelectCommand = cmdx
            da1.Fill(ds1, "returntoSupplier")
            comInvoice.DataSource = ds1.Tables("returntoSupplier")
            comInvoice.DisplayMember = "aodno"
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnreportsdisplay1_Click(sender As Object, e As EventArgs) Handles btnreportsdisplay1.Click
        If Select_RPT = 1 Then
            '// Invoice GRN Report //

            Dim dt3 As New DataTable
            Dim cmdR As New OdbcCommand
            connection()
            Try

                cmdR.CommandText = "select * from GRNDetail WHERE loca='" + loca + "' and Invno='" + comInvoice.Text.ToString + "'"
                cmdR.Connection = cn
                Dim adp1 As New OdbcDataAdapter(cmdR)
                adp1.Fill(dt3)
                Dim rpt As New InvoiceGRN '//(Invoice GRN Report)
                rpt.Database.Tables("GRNDetail").SetDataSource(dt3)
                Report_viewer.CRV.ReportSource = Nothing
                Report_viewer.CRV.ReportSource = rpt
                Report_viewer.CRV.Refresh()
                Report_viewer.CRV.RefreshReport()
                Report_viewer.Show()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in Invoice GRN")
            End Try

        ElseIf Select_RPT = 2 Then
            '// GRN Summery //

            Dim dt3 As New DataTable
            Dim cmdR As New OdbcCommand
            connection()
            Try

                cmdR.CommandText = "select * from GRNDetail WHERE loca='" + loca + "' and dateshort>='" + Format(dtpfrom.Value, "yyMMdd") + "' and dateshort<='" + Format(dtpTo.Value, "yyMMdd") + "'"
                cmdR.Connection = cn
                Dim adp1 As New OdbcDataAdapter(cmdR)
                adp1.Fill(dt3)
                Dim rpt As New GRNSummary '//(GRN Summary Report)
                rpt.Database.Tables("GRNDetail").SetDataSource(dt3)
                Report_viewer.CRV.ReportSource = Nothing
                Report_viewer.CRV.ReportSource = rpt
                Report_viewer.CRV.Refresh()
                Report_viewer.CRV.RefreshReport()
                Report_viewer.Show()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in GRN Summary")
            End Try

        ElseIf Select_RPT = 3 Then

            Dim dt3 As New DataTable
            Dim cmdR As New OdbcCommand
            connection()
            Try

                cmdR.CommandText = "select * from ReturnAOD WHERE loca='" + loca + "' and AODno='" + comInvoice.Text + "'"
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

        ElseIf Select_RPT = 4 Then

            Dim dt3 As New DataTable
            Dim cmdR As New OdbcCommand
            connection()
            Try

                cmdR.CommandText = "select * from ReturnAOD WHERE loca='" + loca + "' and dateshort>='" + Format(dtpfrom.Value, "yyMMdd") + "' and dateshort<='" + Format(dtpTo.Value, "yyMMdd") + "' Order by AODNO asc"
                cmdR.Connection = cn
                Dim adp1 As New OdbcDataAdapter(cmdR)
                adp1.Fill(dt3)
                Dim rpt As New SupplierReturnSummary '//(Supplier return Summary Report)
                rpt.Database.Tables("ReturnAOD").SetDataSource(dt3)
                Report_viewer.CRV.ReportSource = Nothing
                Report_viewer.CRV.ReportSource = rpt
                Report_viewer.CRV.Refresh()
                Report_viewer.CRV.RefreshReport()
                Report_viewer.Show()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in Supplier Return Summary")
            End Try
        End If
    End Sub
End Class