Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Public Class frm_Statement
    Private Sub btnreportscancel1_Click(sender As Object, e As EventArgs) Handles btnreportscancel1.Click
        Me.Dispose()
    End Sub

    Public Sub Load_customers()
        Dim da2 As New OdbcDataAdapter
        Dim ds2 As New DataSet

        Try

            connection()

            If ds2.Tables.Contains("Items") Then
                ds2.Tables.Remove("Items")
            End If

            cmd.CommandText = "select * from Customer where loca='" & loca & "' order by code asc"
            cmd.Connection = cn
            da2.SelectCommand = cmd
            da2.Fill(ds2, "Items")
            comcode.DataSource = ds2.Tables("Items")
            comname.DataSource = ds2.Tables("Items")
            comname.DisplayMember = "Name"
            comcode.DisplayMember = "Code"
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error In Load Customers")
            dr.Close()
            cn.Close()

        End Try
    End Sub

    Public Sub statement()
        Dim dt3 As New DataTable
        Dim RPT_DOC As New ReportDocument
        connection()
        Try
            RPT_DOC = New CUS_Statement
            cmd.CommandText = "SELECT * FROM settlement where loca='" + loca + "' and dateshort between '" + Format(dtpFrom.Value, "yyMMdd") + "' and '" + Format(dtpTo.Value, "yyMMdd") + "' and custname='" + comname.Text.ToString + "'"
            cmd.Connection = cn
            Dim adp1 As New OdbcDataAdapter(cmd)
            adp1.Fill(dt3)
            RPT_DOC.Database.Tables("settlement").SetDataSource(dt3)
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

    Private Sub frm_Statement_Load(sender As Object, e As EventArgs) Handles Me.Load
        Load_customers()
        dtpFrom.Value = Now
        dtpTo.Value = Now

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        statement()
    End Sub
End Class