
Imports System.Data.Odbc

Public Class Expiremediciene

    Private Sub LoadRecord()
        connection()
        expiredmedicinedatagridview.Rows.Clear()

        Try
            cmd.CommandText = "SELECT * FROM items WHERE expdate <= DATEADD(day,+30,GETDATE()) and loca='" & loca & "'"
            cmd.Connection = cn
            dr = cmd.ExecuteReader

            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    expiredmedicinedatagridview.Rows.Add(dr("code"), dr("name"), dr("costprice"), dr("OurPrice"), dr("totalqty"), dr("expdate"))
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

    Private Sub Expiremediciene_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Dim IDF As Integer = 0
        'cmd = New OdbcCommand("select * from Items where expdate='" & Format(Now, "yyMMdd") & "' and loca='" & loca & "'", cn)
        'dr = cmd.ExecuteReader()
        'If dr.HasRows Then
        'While dr.Read

        'If dr("expdate") <= 0 Then expiredmedicinedatagridview.Rows(IDF).DefaultCellStyle.BackColor = Color.LightGray
        'IDF = IDF + 1

        'End While

        'expiredmedicinedatagridview.Refresh()
        'If dr("expdate") > DateTime.Today And dr("expdate") < dr("expdate").AddDays(30) Then
        'expiredmedicinedatagridview.Rows(IDF).DefaultCellStyle.BackColor = Color.Red
        'Else
        'expiredmedicinedatagridview.Rows(IDF).DefaultCellStyle.BackColor = Color.Green
        'End If
        'IDF = IDF + 1

        'End If

        'dr.Close()
        LoadRecord()

    End Sub
End Class