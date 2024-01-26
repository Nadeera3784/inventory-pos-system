Imports System.Data.Odbc

Public Class Department

    Private Sub RefreshData()

        cmbdeptcode.Items.Clear()
        cmbdeptname.Items.Clear()
        connection()

        Try
            cmd = New OdbcCommand("select * from department where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    cmbdeptcode.Items.Add(Trim(dr.Item("dcode")))
                    cmbdeptname.Items.Add(dr.Item("dname"))

                Else
                    MsgBox("No any Department")
                End If
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Load Departments")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub Department_id()

        Try

            connection()
            cmd = New OdbcCommand("select max(dcode) as IDD from department where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    Dim ctno As Integer
                    ctno = Val(dr("IDD")) + 1
                    cmbdeptcode.Text = Format(ctno, "00#")

                Else
                    cmbdeptcode.Text = "001"
                End If
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOK + vbCritical, "Error in department Id")
            dr.Close()
            cn.Close()
        End Try
    End Sub
    Private Sub Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RefreshData()
        Department_id()

    End Sub

    Private Sub btncustsave_Click(sender As Object, e As EventArgs) Handles btndeptsave.Click
        Try

            connection()
            cmd2 = New OdbcCommand("INSERT INTO department Values('" & Trim(cmbdeptcode.Text) & "','" & cmbdeptname.Text & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & loca & "')", cn)
            cmd2.ExecuteNonQuery()
            cn.Close()
            cmbdeptcode.Text = ""
            cmbdeptname.Text = ""
            cmbdeptcode.Select()

            MsgBox("Department Save Successfully....", MsgBoxStyle.Information, "Save Alert")

            RefreshData()
            Department_id()

        Catch ex As Exception
            MsgBox(ex.Message, vbOK + vbCritical, "Error in Save departments ")
        End Try
    End Sub

    Private Sub btncustupdate_Click(sender As Object, e As EventArgs) Handles btndeptupdate.Click
        Try
            connection()
            cmd = New OdbcCommand("select * from department where dcode='" & cmbdeptcode.Text & "' and loca='" & loca & "'", cn)
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
                    cmd3 = New OdbcCommand("UPDATE department set dcode='" & Trim(cmbdeptcode.Text) & "', dname='" & cmbdeptname.Text & "' where dcode='" & cmbdeptcode.Text & "' and loca='" & loca & "'", cn)
                    cmd3.ExecuteNonQuery()
                    cn.Close()
                    cmbdeptcode.Text = ""
                    cmbdeptname.Text = ""
                    cmbdeptcode.Select()
                    MsgBox("Department Update Successfully....", MsgBoxStyle.Information, "Update Alert")
                    RefreshData()
                Catch ex As Exception
                    MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Department Update")
                    cn.Close()

                End Try
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Search Department")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub btncustdelete_Click(sender As Object, e As EventArgs) Handles btndeptdelete.Click
        Try
            connection()
            cmd = New OdbcCommand("delete department where dcode='" & cmbdeptcode.Text & "' and loca='" & loca & "'", cn)
            cmd.ExecuteNonQuery()
            cmbdeptcode.Text = ""
            cmbdeptname.Text = ""
            cmbdeptcode.Select()
            MsgBox("Department Delete Successfully....", MsgBoxStyle.Information, "Delete Alert")
            cn.Close()

            RefreshData()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Department Delete")
        End Try
    End Sub

    Private Sub cmbcatecode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdeptcode.SelectedIndexChanged
        Try
            connection()
            cmd = New OdbcCommand("select Dname from department where dcode='" & cmbdeptcode.Text & "' and loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader
            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    cmbdeptname.Text = dr(0).ToString
                Else
                    cmbdeptname.Text = ""
                End If
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            'MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Department Code X")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub cmbcatename_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdeptname.SelectedIndexChanged
        Try
            connection()
            cmd4 = New OdbcCommand("select Dcode from department where dname='" & cmbdeptname.Text & "' and loca='" & loca & "'", cn)
            dr4 = cmd4.ExecuteReader
            While dr4.Read
                If Not IsDBNull(dr4(0)) Then
                    cmbdeptcode.Text = dr4(0).ToString
                Else
                    cmbdeptcode.Text = ""
                End If
            End While

            dr4.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Department Name X")
            dr4.Close()
            cn.Close()
        End Try
    End Sub
End Class