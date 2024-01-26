
Imports System.Data.Odbc

Public Class Customer

    Private Sub RefreshData()
        cmbcustcode.Items.Clear()
        cmbcustname.Items.Clear()
        connection()
        Try


            cmd5 = New OdbcCommand("select * from Customer where loca='" & loca & "'", cn)
            dr5 = cmd5.ExecuteReader()
            While dr5.Read
                If Not IsDBNull(dr5(0)) Then
                    cmbcustcode.Items.Add(Trim(dr5.Item("code")))
                    cmbcustname.Items.Add(dr5.Item("name"))

                Else
                    MsgBox("No Any Customers Found")

                End If
            End While
            dr5.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Load Customers")
            dr5.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub Customer_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        cmbcustcode.Focus()
        cmbcustcode.SelectAll()
    End Sub
    Private Sub Customer_id()

        connection()

        Try
            cmd = New OdbcCommand("select MAX(code) as IDD from Customer where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            While dr.Read

                If Not IsDBNull(dr(0)) Then
                    Dim custno As Integer
                    custno = Val(dr("IDD")) + 1
                    cmbcustcode.Text = Format(custno, "00#")

                Else
                    cmbcustcode.Text = "001"
                End If
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Customer Id")
            dr.Close()
            cn.Close()
        End Try
    End Sub
    Private Sub Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        Customer_id()
    End Sub

    Private Sub btncustsave_Click(sender As Object, e As EventArgs) Handles btncustsave.Click

        connection()

        Try

            cmd = New OdbcCommand("INSERT INTO Customer Values('" & Trim(cmbcustcode.Text) & "','" & cmbcustname.Text & "','" & txtcustemail.Text & "','" & txtcustmobile.Text & "','" & txtcustfaxno.Text & "','" & txtcustaddress.Text & "','" & txtxcustcreditlimit.Text & "','" & txtcustopbalance.Text & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & loca & "')", cn)
            cmd.ExecuteNonQuery()
            cn.Close()
            cmbcustcode.Text = ""
            cmbcustname.Text = ""
            txtcustaddress.Text = ""
            txtxcustcreditlimit.Text = ""
            txtcustopbalance.Text = ""
            txtcustmobile.Text = ""
            txtcustfaxno.Text = ""
            txtcustemail.Text = ""
            cmbcustcode.Select()

            MsgBox("Customer Save Successfully....", MsgBoxStyle.Information, "Save Alert")

            RefreshData()
            Customer_id()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in save customers")
        End Try
    End Sub

    Private Sub btncustupdate_Click(sender As Object, e As EventArgs) Handles btncustupdate.Click
        Try
            connection()
            cmd2 = New OdbcCommand("select * from Customer where code='" & cmbcustcode.Text & "' and loca='" & loca & "'", cn)
            dr2 = cmd2.ExecuteReader
            Dim df As Boolean = False
            While dr2.Read
                If Not IsDBNull(dr2(0)) Then
                    df = True
                End If
            End While
            dr2.Close()
            cn.Close()

            If df = True Then
                connection()
                Try

                    cmd = New OdbcCommand("UPDATE Customer set name='" & cmbcustname.Text & "', email='" & txtcustemail.Text & "', mobile='" & txtcustmobile.Text & "', fax='" & txtcustfaxno.Text & "', address='" & txtcustaddress.Text & "', credit='" & txtxcustcreditlimit.Text & "', balance='" & txtcustopbalance.Text & "' where code='" & cmbcustcode.Text & "' and loca='" & loca & "'", cn)
                    cmd.ExecuteNonQuery()
                    cn.Close()
                    cmbcustcode.Text = ""
                    cmbcustname.Text = ""
                    txtcustaddress.Text = ""
                    txtxcustcreditlimit.Text = ""
                    txtcustopbalance.Text = ""
                    txtcustmobile.Text = ""
                    txtcustfaxno.Text = ""
                    txtcustemail.Text = ""
                    cmbcustcode.Select()
                    MsgBox("Customer Update Successfully....", MsgBoxStyle.Information, "Update Alert")
                    RefreshData()
                Catch ex As Exception
                    MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Update Customers")
                    cn.Close()
                End Try
            Else
                MsgBox("Customer Code Not Found..")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Customer Search")
            dr2.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub btncustdelete_Click(sender As Object, e As EventArgs) Handles btncustdelete.Click

        connection()

        Try
            cmd = New OdbcCommand("delete Customer where code='" & cmbcustcode.Text & "' and loca='" & loca & "'", cn)
            cmd.ExecuteNonQuery()
            cn.Close()

            cmbcustcode.Text = ""
            cmbcustname.Text = ""
            txtcustaddress.Text = ""
            txtxcustcreditlimit.Text = ""
            txtcustopbalance.Text = ""
            txtcustmobile.Text = ""
            txtcustfaxno.Text = ""
            txtcustemail.Text = ""
            cmbcustcode.Select()
            MsgBox("Customer Delete Successfully....", MsgBoxStyle.Critical, "Delete Alert")
            RefreshData()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Delete Customers")
            cn.Close()

        End Try
    End Sub

    Private Sub cmbcustcode_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbcustcode.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                cmbcustname.Focus()
                cmbcustname.SelectAll()
        End Select
    End Sub

    Private Sub cmbcustcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcustcode.SelectedIndexChanged
        Try
            connection1()
            cmd3 = New OdbcCommand("select * from Customer where code='" & cmbcustcode.Text & "' and loca='" & loca & "'", cn1)
            dr3 = cmd3.ExecuteReader
            'dr3.Read()
            'If dr3.HasRows Then

            While dr3.Read
                    If Not IsDBNull(dr3(0)) Then
                        cmbcustcode.Text = Trim(dr3.Item("code"))
                        cmbcustname.Text = dr3.Item("name")
                        txtcustemail.Text = dr3.Item("email")
                        txtcustmobile.Text = dr3.Item("mobile")
                        txtcustfaxno.Text = dr3.Item("fax")
                        txtcustaddress.Text = dr3.Item("address")
                        txtxcustcreditlimit.Text = dr3.Item("credit")
                        txtcustopbalance.Text = dr3.Item("balance")
                    End If
                End While
                'cmbcustcode.Text = Trim(dr3.Item("code"))
                'cmbcustname.Text = dr3.Item("name")
                'txtcustemail.Text = dr3.Item("email")
                'txtcustmobile.Text = dr3.Item("mobile")
                'txtcustfaxno.Text = dr3.Item("fax")
                'txtcustaddress.Text = dr3.Item("address")
                'txtxcustcreditlimit.Text = dr3.Item("credit")
                'txtcustopbalance.Text = dr3.Item("balance")
                'End If
                dr3.Close()
            cn1.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Customer Code")
            dr3.Close()
            cn1.Close()
        End Try
    End Sub

    Private Sub cmbcustname_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbcustname.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                txtcustemail.Focus()
                txtcustemail.SelectAll()
        End Select
    End Sub

    Private Sub cmbcustname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcustname.SelectedIndexChanged
        Try
            connection()
            cmd4 = New OdbcCommand("select * from Customer where name='" & cmbcustname.Text & "' and loca='" & loca & "'", cn)
            dr4 = cmd4.ExecuteReader
            'dr4.Read()
            'If dr4.HasRows Then

            While dr4.Read

                    If Not IsDBNull(dr4(0)) Then
                        cmbcustcode.Text = Trim(dr4.Item("code"))
                        cmbcustname.Text = dr4.Item("name")
                        txtcustemail.Text = dr4.Item("email")
                        txtcustmobile.Text = dr4.Item("mobile")
                        txtcustfaxno.Text = dr4.Item("fax")
                        txtcustaddress.Text = dr4.Item("address")
                        txtxcustcreditlimit.Text = dr4.Item("credit")
                        txtcustopbalance.Text = dr4.Item("balance")
                    End If
                End While
                '    cmbcustcode.Text = Trim(dr4.Item("code"))
                '    cmbcustname.Text = dr4.Item("name")
                '    txtcustemail.Text = dr4.Item("email")
                '    txtcustmobile.Text = dr4.Item("mobile")
                '    txtcustfaxno.Text = dr4.Item("fax")
                '    txtcustaddress.Text = dr4.Item("address")
                '    txtxcustcreditlimit.Text = dr4.Item("credit")
                '    txtcustopbalance.Text = dr4.Item("balance")
                'End If
                dr4.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Customer name")
            dr4.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub txtcustemail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcustemail.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                txtcustmobile.Focus()
                txtcustmobile.SelectAll()
        End Select
    End Sub

    Private Sub txtcustmobile_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcustmobile.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                txtcustfaxno.Focus()
                txtcustfaxno.SelectAll()
        End Select
    End Sub

    Private Sub txtcustfaxno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcustfaxno.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                txtcustaddress.Focus()
                txtcustaddress.SelectAll()
        End Select
    End Sub

    Private Sub txtcustaddress_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcustaddress.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                btncustsave.Focus()
        End Select
    End Sub

End Class