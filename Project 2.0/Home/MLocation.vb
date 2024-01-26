
Imports System.Data.Odbc

Public Class MLocation

    Private Sub RefreshData()
        Try
            cmbmlocacode.Items.Clear()
            cmbmlocaname.Items.Clear()
            connection()
            cmd = New OdbcCommand("select * from Location", cn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    If Not IsDBNull(dr(0)) Then
                        cmbmlocacode.Items.Add(Trim(dr.Item("code")))
                        cmbmlocaname.Items.Add(dr.Item("name"))
                    Else
                        MsgBox("No Any Location Found", vbOKOnly + vbInformation)
                    End If
                End While
                dr.Close()
                cn.Close()
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Location")
        End Try
    End Sub

    Private Sub btnmlocaok_Click(sender As Object, e As EventArgs) Handles btnmlocaok.Click
        If cmbmlocacode.Text <> "" Or cmbmlocaname.Text <> "" Then
            Login.ShowDialog()
            Me.Hide()
            loca = Trim(cmbmlocacode.Text)
            HomeN.Text = HomeN.Text & " - " & cmbmlocaname.Text
        Else
            MessageBox.Show("Please Select The Your Location....!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub MLocation_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        cmbmlocacode.Focus()
        cmbmlocacode.SelectAll()
    End Sub

    Private Sub MLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RefreshData()

    End Sub

    Private Sub cmbmlocacode_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbmlocacode.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                cmbmlocaname.Focus()
                cmbmlocaname.SelectAll()
        End Select
    End Sub

    Private Sub cmbmlocacode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmlocacode.SelectedIndexChanged
        Try
            connection()
            cmd2 = New OdbcCommand("select name from Location where code='" & cmbmlocacode.Text & "'", cn)
            dr2 = cmd2.ExecuteReader
            While dr2.Read
                If Not IsDBNull(dr2(0)) Then
                    cmbmlocaname.Text = dr2(0).ToString
                Else
                    cmbmlocaname.Text = ""
                End If
            End While
            dr2.Close()
            cn.Close()

        Catch ex As Exception
            'MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Location Code")
            dr2.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub cmbmlocaname_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbmlocaname.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                btnmlocaok.Focus()
                btnmlocaok.Select()
        End Select
    End Sub

    Private Sub cmbmlocaname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmlocaname.SelectedIndexChanged
        Try
            connection()
            cmd2 = New OdbcCommand("select code from Location where name='" & cmbmlocaname.Text & "'", cn)
            dr2 = cmd2.ExecuteReader
            While dr2.Read
                If Not IsDBNull(dr2(0)) Then
                    cmbmlocacode.Text = dr2(0).ToString
                Else
                    cmbmlocacode.Text = ""
                End If
            End While
            dr2.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Location Name")
            dr2.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub btnmlocaclose_Click(sender As Object, e As EventArgs) Handles btnmlocaexit.Click
        End
    End Sub
End Class