
Imports System.Data.Odbc

Public Class Outofstockreports

    Private Sub Outofstockreports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try


            If ReportMode = 30 Then 'Out Of Stock Report
                Me.Text = "Out Of Stock Report"
                lblheadertext1.Text = "Out Of Stock Report"

                connection()
                cmd = New Odbc.OdbcCommand("select * from items where loca='" & loca & "'", cn)
                dr = cmd.ExecuteReader()
                If dr.HasRows Then
                    While dr.Read
                        cmbreportsfromcode.Items.Add(Trim(dr.Item("code")))
                        cmbreportsfromname.Items.Add(dr.Item("name"))
                        cmbreportstocode.Items.Add(Trim(dr.Item("code")))
                        cmbreportstoname.Items.Add(dr.Item("name"))
                    End While
                End If
                dr.Close()
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnreportsdisplay1_Click(sender As Object, e As EventArgs) Handles btnreportsdisplay1.Click

        Try


            If ReportMode = 30 Then 'Out Of Stock Items
                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_OutOfStock as select * from items where totalqty <= 0 and expdate >='" & Format(dpreports1from.Value, "yyyy-MM-dd") & "' and expdate <='" & Format(dpreports1to.Value, "yyyy-MM-dd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\OutOfStock.rpt"

                Reportviewer.Show()
                cn.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbreportsfromcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbreportsfromcode.SelectedIndexChanged
        If ReportMode = 30 Then 'Out Of Stock Items Report
            Me.Text = "Out Of Stock Items Report"
            Try


                connection()
                cmd = New Odbc.OdbcCommand("select * from Items where code='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn)
                dr = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    cmbreportsfromcode.Text = Trim(dr.Item("code"))
                    cmbreportsfromname.Text = Trim(dr.Item("name"))
                End If
                dr.Close()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cmbreportstocode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbreportstocode.SelectedIndexChanged
        If ReportMode = 30 Then 'Out Of Stock Items Report
            Me.Text = "Out Of Stock Items Report"

            connection()
            cmd = New Odbc.OdbcCommand("select * from Items where code='" & cmbreportstocode.Text & "' and loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                cmbreportstocode.Text = Trim(dr.Item("code"))
                cmbreportstoname.Text = Trim(dr.Item("name"))
            End If
            dr.Close()
            cn.Close()
        End If
    End Sub

    Private Sub cmbreportsfromname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbreportsfromname.SelectedIndexChanged
        If ReportMode = 30 Then 'Out Of Stock Items Report
            Me.Text = "Out Of Stock Items Report"

            connection1()
            cmd = New Odbc.OdbcCommand("select * from Items where name='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn1)
            dr2 = cmd.ExecuteReader
            dr2.Read()
            If dr2.HasRows Then
                cmbreportsfromcode.Text = Trim(dr2.Item("code"))
                cmbreportsfromname.Text = Trim(dr2.Item("name"))
            End If
            dr2.Close()
            cn1.Close()
        End If
    End Sub

    Private Sub cmbreportstoname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbreportstoname.SelectedIndexChanged
        If ReportMode = 30 Then 'Out Of Stock Items Report
            Me.Text = "Out Of Stock Items Report"

            connection1()
            cmd = New Odbc.OdbcCommand("select * from Items where name='" & cmbreportstoname.Text & "' and loca='" & loca & "'", cn1)
            dr2 = cmd.ExecuteReader
            dr2.Read()
            If dr2.HasRows Then
                cmbreportstocode.Text = Trim(dr2.Item("code"))
                cmbreportstoname.Text = Trim(dr2.Item("name"))
            End If
            dr2.Close()
            cn1.Close()
        End If
    End Sub
End Class