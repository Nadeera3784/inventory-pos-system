
Imports System.Data.Odbc

Public Class ExpiredReports

    Private Sub ExpiredReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ReportMode = 29 Then 'Expired Items Report
            Me.Text = "Expired Items Report"
            lblheadertext1.Text = "Expired Items Report"

            connection()
            cmd = New Odbc.OdbcCommand("select * from items where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    cmbexpiredformcode.Items.Add(Trim(dr.Item("code")))
                    cmbexpiredfromname.Items.Add(dr.Item("name"))
                    cmbexpiredtocode.Items.Add(Trim(dr.Item("code")))
                    cmbexpiredtoname.Items.Add(dr.Item("name"))
                End While
            End If
            dr.Close()
            cn.Close()

        End If
    End Sub

    Private Sub btnexpiredreport_Click(sender As Object, e As EventArgs) Handles btnexpiredreport.Click
        If ReportMode = 29 Then 'Expired Items
            connection()
            cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_ExpiredItems as select * from items where expdate >='" & Format(dpexpiredfrom.Value, "yyyy-MM-dd") & "' and expdate <='" & Format(dpexpiredto.Value, "yyyy-MM-dd") & "'", cn)
            cmd.ExecuteNonQuery()
            RPTFile = My.Application.Info.DirectoryPath & "\RPT\ExpiredItems.rpt"
            Reportviewer.Show()
            cn.Close()
        End If
    End Sub

    Private Sub cmbexpiredformcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbexpiredformcode.SelectedIndexChanged
        If ReportMode = 29 Then 'Expired Items Report
            Me.Text = "Expired Items Report"

            connection1()
            cmd = New Odbc.OdbcCommand("select * from Items where code='" & cmbexpiredformcode.Text & "' and loca='" & loca & "'", cn1)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then

                cmbexpiredfromname.Text = Trim(dr.Item("name"))
            End If
            dr.Close()
            cn1.Close()
        End If
    End Sub

    Private Sub cmbexpiredtocode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbexpiredtocode.SelectedIndexChanged
        If ReportMode = 29 Then 'Expired Items Report
            Me.Text = "Expired Items Report"

            connection1()
            cmd = New Odbc.OdbcCommand("select * from Items where code='" & cmbexpiredtocode.Text & "' and loca='" & loca & "'", cn1)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then

                cmbexpiredtoname.Text = Trim(dr.Item("name"))
            End If
            dr.Close()
            cn1.Close()
        End If
    End Sub

    Private Sub cmbexpiredfromname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbexpiredfromname.SelectedIndexChanged
        If ReportMode = 29 Then 'Expired Items Report
            Me.Text = "Expired Items Report"
            connection()

            cmd = New Odbc.OdbcCommand("select * from Items where name='" & cmbexpiredfromname.Text & "' and loca='" & loca & "'", cn)
            dr2 = cmd.ExecuteReader
            dr2.Read()
            If dr2.HasRows Then
                cmbexpiredformcode.Text = Trim(dr2.Item("code"))

            End If
            dr2.Close()
            cn.Close()
        End If
    End Sub

    Private Sub cmbexpiredtoname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbexpiredtoname.SelectedIndexChanged
        If ReportMode = 29 Then 'Expired Items Report
            Me.Text = "Expired Items Report"

            connection()
            cmd = New Odbc.OdbcCommand("select * from Items where name='" & cmbexpiredtoname.Text & "' and loca='" & loca & "'", cn)
            dr2 = cmd.ExecuteReader
            dr2.Read()
            If dr2.HasRows Then
                cmbexpiredtocode.Text = Trim(dr2.Item("code"))
                cmbexpiredtoname.Text = Trim(dr2.Item("name"))
            End If
            dr2.Close()
            cn.Close()
        End If
    End Sub
End Class