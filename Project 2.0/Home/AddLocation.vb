
Imports System.Data.Odbc

Public Class AddLocation

    Private Sub RefreshData()
        Try
            cmbalcode.Items.Clear()
            cmbalname.Items.Clear()
            connection()
            cmdx.CommandText = "select * from Location"
            cmdx.Connection = cn
            dr = cmdx.ExecuteReader()
            While dr.Read

                If Not IsDBNull(dr(0)) Then
                    cmbalcode.Items.Add(dr("code"))
                    cmbalname.Items.Add(dr("name"))
                End If
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Location Select")
            dr.Close()
            cn.Close()
        End Try
    End Sub
    Private Sub Location_ID()
        Try
            connection()
            cmd = New OdbcCommand("select MAX(code) as IDD from Location", cn)
            dr = cmd.ExecuteReader()
            While dr.Read
                If Not IsDBNull(dr(0)) Then

                    Dim lno As Integer
                    lno = Val(dr("IDD")) + 1
                    cmbalcode.Text = Format(lno, "00#")

                Else
                    cmbalcode.Text = Format("001")
                End If
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error In Location Id")
            dr.Close()
            cn.Close()
        End Try
    End Sub
    Private Sub AddLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RefreshData()
        Location_ID()

    End Sub

    Private Sub btnalsave_Click(sender As Object, e As EventArgs) Handles btnalsave.Click

        connection()

        Try
            cmd = New OdbcCommand("INSERT INTO Location Values('" & Trim(cmbalcode.Text) & "','" & cmbalname.Text & "','" & txtaladdress.Text & "','" & txtaltelephone.Text & "')", cn)
            cmd.ExecuteNonQuery()
            cmbalcode.Text = ""
            cmbalname.Text = ""
            txtaladdress.Text = ""
            txtaltelephone.Text = ""
            cmbalcode.Select()
            MsgBox("Location Save Successfully....", MsgBoxStyle.Information, "Save Alert")
            RefreshData()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Location Save")
        End Try

        Location_ID()
    End Sub

    Private Sub btnalupdate_Click(sender As Object, e As EventArgs) Handles btnalupdate.Click
        connection()

        Try
            cmd = New OdbcCommand("select * from Location where code='" & cmbalcode.Text & "'", cn)
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                dr.Close()
                cn.Close()

                connection()
                cmd2 = New OdbcCommand("UPDATE Location set code='" & Trim(cmbalcode.Text) & "', name='" & cmbalname.Text & "', address='" & txtaladdress.Text & "', telephone='" & txtaltelephone.Text & "' where code='" & cmbalcode.Text & "'", cn)
                cmd2.ExecuteNonQuery()
                cmbalcode.Text = ""
                cmbalname.Text = ""
                txtaladdress.Text = ""
                txtaltelephone.Text = ""
                cmbalcode.Select()
                MsgBox("Location Update Successfully....", MsgBoxStyle.Information, "Update Alert")
                RefreshData()
            End If
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Update")
            dr.Close()
            cn.Close()
        End Try
        Location_ID()
    End Sub

    Private Sub btnaldelete_Click(sender As Object, e As EventArgs) Handles btnaldelete.Click

        connection()

        Try
            cmd = New OdbcCommand("delete Location where code='" & cmbalcode.Text & "'", cn)
            cmd.ExecuteNonQuery()
            cmbalcode.Text = ""
            cmbalname.Text = ""
            txtaladdress.Text = ""
            txtaltelephone.Text = ""
            cmbalcode.Select()
            MsgBox("Location Delete Successfully..", MsgBoxStyle.Critical, "Delete Alert")
            cn.Close()
            RefreshData()
            Location_ID()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Location Delete")
        End Try
    End Sub

    Private Sub cmbalcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbalcode.SelectedIndexChanged

        connection1()

        Try
            cmd = New OdbcCommand("select * from Location where code='" & cmbalcode.Text & "'", cn1)
            dr = cmd.ExecuteReader

            While dr.Read

                If Not IsDBNull(dr(0)) Then

                    cmbalname.Text = dr.Item("name")
                    txtaladdress.Text = dr.Item("address")
                    txtaltelephone.Text = dr.Item("telephone")
                End If
            End While
            dr.Close()
            cn1.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Location Code Search")
            dr.Close()
            cn1.Close()
        End Try
    End Sub

    Private Sub cmbalname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbalname.SelectedIndexChanged
        connection()

        Try

            cmdx.CommandText = "select * from Location where name='" & cmbalname.Text & "'"
            cmdx.Connection = cn
            dr2 = cmdx.ExecuteReader
            While dr2.Read
                If Not IsDBNull(dr2(0)) Then
                    cmbalcode.Text = dr2("code")
                    txtaladdress.Text = dr2("address")
                    txtaltelephone.Text = dr2("telephone")
                End If
            End While
            dr2.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Location Name Search")
            dr2.Close()
            cn.Close()
        End Try
    End Sub
End Class