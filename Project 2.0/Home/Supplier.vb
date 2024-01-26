
Imports System.Data.Odbc

Public Class Supplier

    Private Sub RefreshData()
        cmbsupcode.Items.Clear()
        cmbsupname.Items.Clear()
        connection()
        Try


            cmd3 = New OdbcCommand("select * from Supplier where loca='" & loca & "'", cn)
            dr3 = cmd3.ExecuteReader()

            While dr3.Read
                If Not IsDBNull(dr3(0)) Then
                    cmbsupcode.Items.Add(Trim(dr3.Item("code")))
                    cmbsupname.Items.Add(dr3.Item("name"))

                Else
                    MsgBox("No any Suppliers Found")
                End If

            End While
            dr3.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in load suppliers")
            dr3.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub Supplier_Id()
        Try
            connection()
            cmd = New OdbcCommand("select MAX(code) as IDD from Supplier where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    Dim supno As Integer
                    supno = Val(dr("IDD")) + 1
                    cmbsupcode.Text = Format(supno, "00#")
                Else
                    cmbsupcode.Text = "001"
                End If
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in load Supplier ID")
        End Try
    End Sub

    Private Sub btnsupsave_Click(sender As Object, e As EventArgs) Handles btnsupsave.Click
        Try
            connection()
            cmd2 = New OdbcCommand("INSERT INTO Supplier Values('" & Trim(cmbsupcode.Text) & "','" & cmbsupname.Text & "','" & txtsupmobileno.Text & "','" & txtsupfaxno.Text & "','" & txtsupemail.Text & "','" & txtsupaddress.Text & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & loca & "')", cn)
            cmd2.ExecuteNonQuery()
            cn.Close()
            cmbsupcode.Text = ""
            cmbsupname.Text = ""
            txtsupmobileno.Text = ""
            txtsupfaxno.Text = ""
            txtsupemail.Text = ""
            txtsupaddress.Text = ""
            cmbsupcode.Select()

            MsgBox("Supplier Save Successfully....", MsgBoxStyle.Information, "Save Alert")

            RefreshData()
            Supplier_Id()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in load save Supplier")
        End Try
    End Sub

    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData()
        Supplier_Id()
    End Sub

    Private Sub btnsupdelete_Click(sender As Object, e As EventArgs) Handles btnsupdelete.Click

        connection()

        Try
            cmd = New OdbcCommand("delete Supplier where code='" & cmbsupcode.Text & "' and loca='" & loca & "'", cn)
            cmd.ExecuteNonQuery()
            cn.Close()
            cmbsupcode.Text = ""
            cmbsupname.Text = ""
            txtsupmobileno.Text = ""
            txtsupfaxno.Text = ""
            txtsupemail.Text = ""
            txtsupaddress.Text = ""
            cmbsupcode.Select()
            MsgBox("Supplier Delete Successfully....", MsgBoxStyle.Information, "Delete Alert")
            RefreshData()
            Supplier_Id()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Delete suppliers")
        End Try
    End Sub

    Private Sub cmbsupcode_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbsupcode.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                cmbsupname.Focus()
                cmbsupname.SelectAll()
        End Select
    End Sub

    Private Sub cmbsupcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsupcode.SelectedIndexChanged
        connection()

        Try
            cmd = New OdbcCommand("select * from Supplier where code='" & cmbsupcode.Text & "' and loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                'cmbsupcode.Text = Trim(dr.Item("code"))
                cmbsupname.Text = dr.Item("name")
                txtsupmobileno.Text = dr.Item("mobileno")
                txtsupfaxno.Text = dr.Item("faxno")
                txtsupemail.Text = dr.Item("email")
                txtsupaddress.Text = dr.Item("address")
            End If
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Supplier Code")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub cmbsupname_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbsupname.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                txtsupmobileno.Focus()
                txtsupmobileno.SelectAll()
        End Select
    End Sub

    Private Sub cmbsupname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsupname.SelectedIndexChanged
        Try
            connection1()
            cmd2 = New OdbcCommand("select * from Supplier where name='" & cmbsupname.Text & "' and loca='" & loca & "'", cn1)
            dr2 = cmd2.ExecuteReader
            dr2.Read()
            If dr2.HasRows Then
                cmbsupcode.Text = Trim(dr2.Item("code"))
                'cmbsupname.Text = dr2.Item("name")
                txtsupmobileno.Text = dr2.Item("mobileno")
                txtsupfaxno.Text = dr2.Item("faxno")
                txtsupemail.Text = dr2.Item("email")
                txtsupaddress.Text = dr2.Item("address")
            End If
            dr2.Close()
            cn1.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Supplier Name")
            dr2.Close()
            cn1.Close()
        End Try
    End Sub

    Private Sub txtsupaddress_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsupaddress.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                btnsupsave.Focus()
        End Select
    End Sub

    Private Sub txtsupmobileno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsupmobileno.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                txtsupfaxno.Focus()
                txtsupfaxno.SelectAll()
        End Select
    End Sub

    Private Sub txtsupfaxno_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsupfaxno.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                txtsupemail.Focus()
                txtsupemail.SelectAll()
        End Select
    End Sub

    Private Sub txtsupemail_KeyDown(sender As Object, e As KeyEventArgs) Handles txtsupemail.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                txtsupaddress.Focus()
                txtsupaddress.SelectAll()
        End Select
    End Sub

    Private Sub btnsupupdate_Click(sender As Object, e As EventArgs) Handles btnsupupdate.Click

        connection()

        Try
            cmd = New OdbcCommand("select * from Supplier where code='" & cmbsupcode.Text & "' and loca='" & loca & "'", cn)
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

                    cmd2 = New OdbcCommand("UPDATE Supplier set code='" & Trim(cmbsupcode.Text) & "', name='" & cmbsupname.Text & "', mobileno='" & txtsupmobileno.Text & "', faxno='" & txtsupfaxno.Text & "', email='" & txtsupemail.Text & "', address='" & txtsupaddress.Text & "' where code='" & cmbsupcode.Text & "' and loca='" & loca & "'", cn)
                    cmd2.ExecuteNonQuery()
                    cn.Close()
                    cmbsupcode.Text = ""
                    cmbsupname.Text = ""
                    txtsupmobileno.Text = ""
                    txtsupfaxno.Text = ""
                    txtsupemail.Text = ""
                    txtsupaddress.Text = ""
                    cmbsupcode.Select()
                    MsgBox("Supplier Update Successfully....", MsgBoxStyle.Information, "Update Alert")
                    RefreshData()
                Catch ex As Exception
                    MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Update Supplier")
                End Try
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Search Supplier")
            dr.Close()
            cn.Close()

        End Try
    End Sub
End Class