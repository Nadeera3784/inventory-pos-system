Imports System.Data.Odbc

Public Class Daily_Expenses

    Private Sub RefreshData()

        connection()

        Try
            cmbcatecode.Items.Clear()

            cmd5 = New OdbcCommand("select * from expenses where loca='" & loca & "'", cn)
            dr5 = cmd5.ExecuteReader()
            If dr5.HasRows Then
                While dr5.Read
                    cmbcatecode.Items.Add(Trim(dr5.Item("code")))
                End While
            End If
            dr5.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Select Expenses")
        End Try

    End Sub

    Private Sub Expenses_id()

        Try
            connection()
            cmd = New OdbcCommand("select max(code) as IDD from expenses where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            While dr.Read

                If Not IsDBNull(dr(0)) Then
                    Dim ctno As Integer
                    ctno = Val(dr("IDD")) + 1
                    cmbcatecode.Text = Format(ctno, "00#")

                Else
                    cmbcatecode.Text = Format("001")
                End If
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Expenses ID")
        End Try
    End Sub
    Private Sub btnexpupdate_Click(sender As Object, e As EventArgs) Handles btnexpupdate.Click

        connection()

        Try
            cmd = New OdbcCommand("select * from expenses where code='" & cmbcatecode.Text & "' and loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader
            Dim df As Boolean = False

            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    df = True

                End If
            End While
            dr.Close()
            cn.Close()

            If df = True Then
                connection()

                Try
                    cmd3 = New OdbcCommand("UPDATE expenses set code='" & Trim(cmbcatecode.Text) & "', description='" & txtexpdescription.Text & "',amount='" & Convert.ToDouble(txtexpamount.Text) & "',date='" & Format(dtexpdate.Value, "yyyy-MMM-dd") & "'  where code='" & cmbcatecode.Text & "' and loca='" & loca & "'", cn)
                    cmd3.ExecuteNonQuery()
                    cn.Close()
                    cmbcatecode.Text = ""
                    txtexpamount.Text = ""
                    txtexpdescription.Text = ""
                    cmbcatecode.Select()
                    MsgBox("Expenses Update Successfully....", MsgBoxStyle.Information, "Update Alert")
                    RefreshData()
                    Expenses_id()
                Catch ex As Exception
                    MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Update")
                    cn.Close()
                End Try
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Search Expenses")
            dr.Close()
            cn.Close()
        End Try


    End Sub
    Private Sub btnexpsave_Click(sender As Object, e As EventArgs) Handles btnexpsave.Click

        connection()

        Try

            cmd2 = New OdbcCommand("INSERT INTO expenses Values('" & Trim(cmbcatecode.Text) & "','" & txtexpdescription.Text & "','" & Format(dtexpdate.Value, "yyyy-MMM-dd") & "','" & txtexpamount.Text & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & loca & "')", cn)
            cmd2.ExecuteNonQuery()
            cn.Close()
            cmbcatecode.Text = ""
            txtexpamount.Text = ""
            txtexpdescription.Text = ""
            cmbcatecode.Select()

            MsgBox("Expences Save Successfully....", MsgBoxStyle.Information, "Save Alert")
            RefreshData()
            Expenses_id()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Expenses Id")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub Daily_Expenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Expenses_id()

        connection()
        Try


            cmd = New OdbcCommand("select isnull(sum(amount),0) as sales from Invoice where  datelong='" & Format(Now, "yyyy-MMM-dd") & "' and loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                Dim sales As Integer
                sales = Val(dr("sales"))
                lblsales.Text = sales.ToString
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Sale")
            dr.Close()
            cn.Close()
        End Try

        RefreshData()
    End Sub

    Private Sub btnexpdelete_Click(sender As Object, e As EventArgs) Handles btnexpdelete.Click

        connection()

        Try
            cmd = New OdbcCommand("delete expenses where code='" & cmbcatecode.Text & "' and loca='" & loca & "'", cn)
            cmd.ExecuteNonQuery()
            cn.Close()
            cmbcatecode.Text = ""
            cmbcatecode.Select()
            MsgBox("Expences Delete Successfully....", MsgBoxStyle.Information, "Delete Alert")
            RefreshData()
            Expenses_id()
            txtexpamount.Text = ""
            txtexpdescription.Text = ""
            cmbcatecode.Select()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Delete Expenses")
            cn.Close()
        End Try
    End Sub

    Private Sub cmbcatecode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcatecode.SelectedIndexChanged

        connection()

        Try

            cmd3 = New OdbcCommand("select * from expenses where code='" & cmbcatecode.Text & "' and loca='" & loca & "'", cn)
            dr3 = cmd3.ExecuteReader
            While dr3.Read

                If Not IsDBNull(dr3(0)) Then
                    cmbcatecode.Text = Trim(dr3.Item("code"))
                    txtexpdescription.Text = dr3.Item("description")
                    txtexpamount.Text = dr3.Item("amount")
                    dtexpdate.Text = dr3.Item("date")

                Else
                    MsgBox("No Any Expenses Found", vbOKOnly + vbInformation)
                End If
            End While
            dr3.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error In Select Expenses")
            dr3.Close()
            cn.Close()
        End Try
    End Sub
End Class