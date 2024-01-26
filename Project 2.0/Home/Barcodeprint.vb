
Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine

Public Class Barcodeprint
    Dim RPT_DOC1 As New ReportDocument

    Private Sub Barcodeprint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblbarcodeprice.Text = ""
        Dim a As Integer
        For a = 1 To 30
            comCopies.Items.Add(a)
        Next

        connection()
        cmd = New Odbc.OdbcCommand("select * from Items where loca='" & loca & "'", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            While dr.Read
                cmbbarcodename.Items.Add(dr("name"))
            End While
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbarcodecode.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                connection()
                cmd = New Odbc.OdbcCommand("select * from Items where code='" & txtbarcodecode.Text & "' or barcode='" & txtbarcodecode.Text & "' and loca='" & loca & "'", cn)
                dr = cmd.ExecuteReader()
                dr.Read()
                If dr.HasRows Then
                    cmbbarcodename.Text = dr("name")
                    lblbarcodeprice.Text = Format(dr("sellprice"), "#####0.00")
                    comCopies.Focus()
                End If
                dr.Close()
        End Select
    End Sub

    Private Sub btncashierdelete_Click(sender As Object, e As EventArgs) Handles btnbarcodeclear.Click
        lblbarcodeprice.Text = ""
        comCopies.Text = ""

        txtbarcodecode.Text = ""
        txtbarcodecode.Focus()
    End Sub

    Private Sub btncashiersave_Click(sender As Object, e As EventArgs) Handles btnbarcodesave.Click
        Try
            connection()
            cmd = New Odbc.OdbcCommand("DELETE from RPT_Barcode", cn)
            cmd.ExecuteNonQuery()
            cn.Close()

            Try
                For i As Integer = 1 To Integer.Parse(comCopies.Text)

                    connection()
                    cmd = New Odbc.OdbcCommand("INSERT INTO RPT_Barcode values('" & txtbarcodecode.Text & "','" & cmbbarcodename.Text & "','" & lblbarcodeprice.Text & "')", cn)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                Next

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            RPT_DOC1 = New Barcode_new
            Dim dt3 As New DataTable
            connection()
            Try

                cmd.CommandText = "SELECT * FROM RPT_Barcode"
                cmd.Connection = cn
                Dim adp1 As New OdbcDataAdapter(cmd)
                adp1.Fill(dt3)
                RPT_DOC1.Database.Tables("RPT_Barcode").SetDataSource(dt3)
                Report_viewer.CRV.ReportSource = Nothing
                Report_viewer.CRV.ReportSource = RPT_DOC1
                Report_viewer.CRV.Refresh()
                Report_viewer.CRV.RefreshReport()
                Report_viewer.ShowDialog()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbInformation, "Error In Item Wise Sales")
            End Try



            txtbarcodecode.Focus()
            txtbarcodecode.SelectAll()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles comCopies.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnbarcodesave.Focus()
        End Select
    End Sub

    'Private Sub cmbbarcodename_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbbarcodename.SelectedIndexChanged
    'conn2.Open()
    'cmd2 = New Odbc.OdbcCommand("select * from Items where name='" & cmbbarcodename.Text & "'", conn2)
    'dr2 = cmd2.ExecuteReader()
    'dr2.Read()
    'If dr2.HasRows Then
    'txtbarcodecode.Text = dr2("code")
    'lblbarcodeprice.Text = Format(dr2("sellprice"), "#####0.00")
    'End If
    'dr2.Close()
    'conn2.Close()
    'End Sub

End Class