
Imports System.Data.Odbc

Public Class Bankreports

    Private Sub Bankreports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ReportMode = 26 Then 'Bank Details
            Me.Text = "Bank Details"
            lblheadertext1.Text = "Bank Details Report"

            connection()
            cmd = New Odbc.OdbcCommand("select * from supplier where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            While dr.Read

                If Not IsDBNull(dr(0)) Then
                    cmbbankssupcode.Items.Add(Trim(dr.Item("code")))
                    cmbbankssupname.Items.Add(dr.Item("name"))

                Else
                    MsgBox("Suppliers Not Available")
                End If
            End While
            dr.Close()
            cn.Close()
        End If

    End Sub

    Private Sub btnbanksreports_Click(sender As Object, e As EventArgs) Handles btnbanksreports.Click

        If ReportMode = 26 Then 'Bank Details Report
            connection()
            cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_BankDetails as select * from Banks where code='" & cmbbankssupcode.Text & "' and name='" & cmbbankssupname.Text & "'", cn)
            cmd.ExecuteNonQuery()
            RPTFile = My.Application.Info.DirectoryPath & "\RPT\BankDetails.rpt"
            Reportviewer.Show()

        End If

    End Sub

    Private Sub btnbankscancel_Click(sender As Object, e As EventArgs) Handles btnbankscancel.Click
        Me.Close()
    End Sub

    Private Sub cmbbankssupcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbankssupcode.SelectedIndexChanged

        If ReportMode = 26 Then 'Bank Details Report
            Me.Text = "Bank Details Report"

            connection1()
            cmd = New Odbc.OdbcCommand("select * from supplier where code='" & cmbbankssupcode.Text & "' and loca='" & loca & "'", cn1)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then

                cmbbankssupname.Text = Trim(dr.Item("name"))
            End If
            dr.Close()
            cn1.Close()
        End If

    End Sub

    Private Sub cmbbankssupname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbankssupname.SelectedIndexChanged

        If ReportMode = 26 Then 'Bank Details Report
            Me.Text = "Bank Details Report"

            connection()
            cmd = New Odbc.OdbcCommand("select * from supplier where name='" & cmbbankssupname.Text & "' and loca='" & loca & "'", cn)
            dr2 = cmd.ExecuteReader
            dr2.Read()
            If dr2.HasRows Then
                cmbbankssupcode.Text = Trim(dr2.Item("code"))
                cmbbankssupname.Text = Trim(dr2.Item("name"))
            End If
            dr2.Close()
            cn.Close()
        End If

    End Sub
End Class