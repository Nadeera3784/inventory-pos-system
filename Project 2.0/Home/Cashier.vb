
Imports System.Data.Odbc

Public Class Cashier

    Private Sub RefreshData()
        Try


            cmbcashiercode.Items.Clear()
            cmbcashiername.Items.Clear()
            connection()
            cmd5 = New OdbcCommand("select * from Cashier where loca='" & loca & "'", cn)
            dr5 = cmd5.ExecuteReader()
            While dr5.Read
                If Not IsDBNull(dr5(0)) Then
                    cmbcashiercode.Items.Add(Trim(dr5.Item("code")))
                    cmbcashiername.Items.Add(dr5.Item("name"))
                End If
            End While

            dr5.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Load Cashier")
            dr5.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub btncashiersave_Click(sender As Object, e As EventArgs) Handles btncashiersave.Click
        Try

            connection()
            cmd2 = New OdbcCommand("INSERT INTO Cashier Values('" & Trim(cmbcashiercode.Text) & "','" & cmbcashiername.Text & "','" + "CASHIER" + "','" & txtchashierpassword.Text & "','" & txtchashierpassword.Text & "','" & cmblcode.Text & "','" & cmblname.Text & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & loca & "')", cn)
            cmd2.ExecuteNonQuery()
            cn.Close()
            cmbcashiercode.Text = ""
            cmbcashiername.Text = ""
            txtchashierpassword.Text = ""
            txtcashiercwpassword.Text = ""
            cmblcode.Text = ""
            cmblname.Text = ""
            cmbcashiercode.Select()
            MsgBox("Cashier Save Successfully....", MsgBoxStyle.Information, "Save Alert")
            RefreshData()
            Pick_id()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Save")
        End Try


    End Sub

    Private Sub Pick_id()
        Try
            connection()
            cmd = New OdbcCommand("select max(code) as IDD from Cashier where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    Dim cashiercode As Integer
                    cashiercode = Val(dr("IDD")) + 1
                    cmbcashiercode.Text = Format(cashiercode, "00#")

                Else
                    cmbcashiercode.Text = "001"
                End If

            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Cashier Code")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        RefreshData()

        Pick_id()
        connection()

        Try
            cmd = New OdbcCommand("select * from Location", cn)
            dr = cmd.ExecuteReader()
            cmblcode.Items.Clear()
            cmblname.Items.Clear()

            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    cmblcode.Items.Add(Trim(dr.Item("code")))
                    cmblname.Items.Add(dr.Item("name"))

                Else
                    MsgBox("No Locations Found", vbOKOnly + vbInformation)
                End If
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Load Locations")
        End Try
    End Sub

    Private Sub btncashierdelete_Click(sender As Object, e As EventArgs) Handles btncashierdelete.Click
        Try
            connection()
            cmd = New OdbcCommand("delete Cashier where code='" & cmbcashiercode.Text & "' and loca='" & loca & "'", cn)
            cmd.ExecuteNonQuery()
            cn.Close()
            cmbcashiercode.Text = ""
            cmbcashiername.Text = ""
            txtchashierpassword.Text = ""
            txtcashiercwpassword.Text = ""
            cmblcode.Text = ""
            cmblname.Text = ""
            cmbcashiercode.Select()
            MsgBox("Cashier Delete Successfully....", MsgBoxStyle.Information, "Delete Alert")
            RefreshData()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Delete Cashier")
            cn.Close()

        End Try
    End Sub

    Private Sub cmbcashiercode_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbcashiercode.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                cmbcashiername.Focus()
                cmbcashiername.SelectAll()
        End Select
    End Sub

    Private Sub cmbcashiercode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcashiercode.SelectedIndexChanged
        Try
            connection1()
            cmd = New OdbcCommand("select name from Cashier where code='" & cmbcashiercode.Text & "' and loca='" & loca & "'", cn1)
            dr = cmd.ExecuteReader
            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    cmbcashiername.Text = dr(0).ToString

                End If
            End While
            dr.Close()
            cn1.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Cashier Code")
            dr.Close()
            cn1.Close()
        End Try
    End Sub

    Private Sub cmbcashiername_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbcashiername.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                btncashiersave.Focus()
                btncashiersave.Select()
        End Select
    End Sub

    Private Sub cmbcashiername_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcashiername.SelectedIndexChanged
        Try
            connection()
            cmd4 = New OdbcCommand("select code from Cashier where name='" & cmbcashiername.Text & "' and loca='" & loca & "'", cn)
            dr4 = cmd4.ExecuteReader
            While dr4.Read
                If Not IsDBNull(dr4(0)) Then
                    cmbcashiercode.Text = dr4(0).ToString

                End If
            End While
            dr4.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Cashier Name")
            dr4.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub btncashierupdate_Click(sender As Object, e As EventArgs) Handles btncashierupdate.Click

        connection()

        Try
            cmd = New OdbcCommand("select * from Cashier where code='" & cmbcashiercode.Text & "' and loca='" & loca & "'", cn)
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

                    cmd3 = New OdbcCommand("UPDATE Cashier set code='" & Trim(cmbcashiercode.Text) & "', name='" & cmbcashiername.Text & "', password='" & txtchashierpassword.Text & "', cwpassword='" & txtcashiercwpassword.Text & "', lcode='" & cmblcode.Text & "', lname='" & cmblname.Text & "' where code='" & cmbcashiercode.Text & "' and loca='" & loca & "'", cn)
                    cmd3.ExecuteNonQuery()
                    cn.Close()
                    cmbcashiercode.Text = ""
                    cmbcashiername.Text = ""
                    txtchashierpassword.Text = ""
                    txtcashiercwpassword.Text = ""
                    cmblcode.Text = ""
                    cmblname.Text = ""
                    cmbcashiercode.Select()
                    MsgBox("Cashier Update Successfully....", MsgBoxStyle.Information, "Update Alert")
                    RefreshData()

                Catch ex As Exception
                    MsgBox(ex.Message, vbOK + vbCritical, "Error in Cashier Update")
                End Try

            Else
                MsgBox("Cashier Code is Wrong....!")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbOK + vbCritical, "Error in Search Cashier")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub cmblcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmblcode.SelectedIndexChanged
        Try
            connection1()
            cmd = New OdbcCommand("select name from Location where code='" & cmblcode.Text & "'", cn1)
            dr = cmd.ExecuteReader
            While dr.Read

                If Not IsDBNull(dr(0)) Then
                    cmblname.Text = dr(0).ToString

                Else
                    cmblname.Text = ""
                End If
            End While
            dr.Close()
            cn1.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOK + vbCritical, "Error in Location Code")
            dr.Close()
            cn1.Close()
        End Try
    End Sub

    Private Sub cmblname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmblname.SelectedIndexChanged
        Try
            connection()
            cmd = New OdbcCommand("select code from Location where name='" & cmblname.Text & "'", cn)
            dr2 = cmd.ExecuteReader
            While dr2.Read
                If Not IsDBNull(dr2(0)) Then
                    cmblcode.Text = dr2(0).ToString

                Else
                    cmblcode.Text = ""
                End If
            End While
            dr2.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOK + vbCritical, "Error in Location Name")
            dr2.Close()
            cn.Close()
        End Try
    End Sub
End Class
