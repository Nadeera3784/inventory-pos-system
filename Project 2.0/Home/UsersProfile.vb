
Imports System.Data.Odbc

Public Class UsersProfile

    Private Sub RefreshData()

        connection()
        cmbusername.Items.Clear()
        cmd = New OdbcCommand("select * from userlogin", cn)
        dr = cmd.ExecuteReader()

        While dr.Read

            If Not IsDBNull(dr(0)) Then
                cmbusername.Items.Add(Trim(dr.Item("username")))

            Else
                MsgBox("No Users Available")
            End If
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub btnalsave_Click(sender As Object, e As EventArgs) Handles btnuserssave.Click
        Try
            connection()
            cmd = New OdbcCommand("INSERT INTO userlogin Values('" & Trim(cmbusername.Text) & "','" & txtpassword.Text & "','" & loca & "')", cn)
            cmd.ExecuteNonQuery()
            cn.Close()
            cmbusername.Text = ""
            txtpassword.Text = ""
            cmbusername.Select()
            MsgBox("Users Save Successfully....", MsgBoxStyle.Information, "Save Alert")
            RefreshData()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error In User Enroll")
            cn.Close()
        End Try
    End Sub

    Private Sub UsersProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
    End Sub

    Private Sub btnusersupdate_Click(sender As Object, e As EventArgs) Handles btnusersupdate.Click
        Try
            connection()
            cmd = New OdbcCommand("select * from userlogin where username='" & cmbusername.Text & "' and loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader
            Dim df As Boolean = False
            While dr.Read
                df = True
            End While
            dr.Close()
            cn.Close()

            If df = True Then
                connection()

                cmd2 = New OdbcCommand("UPDATE userlogin set username='" & Trim(cmbusername.Text) & "', password='" & txtpassword.Text & "' where username='" & cmbusername.Text & "' and loca='" & loca & "'", cn)
                cmd2.ExecuteNonQuery()
                cmbusername.Text = ""
                txtpassword.Text = ""
                cmbusername.Select()
                MsgBox("Users Update Successfully....", MsgBoxStyle.Information, "Update Alert")
                cn.Close()
                RefreshData()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub cmbusername_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbusername.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                txtpassword.Focus()
                txtpassword.SelectAll()
        End Select
    End Sub

    Private Sub cmbusername_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbusername.SelectedIndexChanged
        Try
            connection()
            cmd = New OdbcCommand("select * from userlogin where username='" & cmbusername.Text & "' and loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                cmbusername.Text = Trim(dr.Item("username"))
                txtpassword.Text = dr.Item("password")
            End If
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            dr.Close()
            cn.Close()

        End Try
    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                btnuserssave.Focus()
        End Select
    End Sub

End Class