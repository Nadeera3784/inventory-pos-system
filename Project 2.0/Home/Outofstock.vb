Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.Odbc

Public Class Outofstock

    Private Sub LoadRecord()
        connection()
        DGOutofstock.Rows.Clear()

        Try

            cmd.CommandText = "SELECT * FROM outofstock WHERE LOCA='" + loca + "'"
            cmd.Connection = cn
            dr = cmd.ExecuteReader

            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    DGOutofstock.Rows.Add(dr("code"), dr("Name"), dr("costprice"), dr("ourprice"), dr("totalqty"))
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

    Private Sub Outofstock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecord()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dt3 As New DataTable
        Dim RPT_DOC As New ReportDocument
        connection()
        Try
            RPT_DOC = New OutOfStock1
            cmd.CommandText = "SELECT * FROM outofstock where loca='" + loca + "'"
            cmd.Connection = cn
            Dim adp1 As New OdbcDataAdapter(cmd)
            adp1.Fill(dt3)
            RPT_DOC.Database.Tables("OutofStock").SetDataSource(dt3)
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
End Class