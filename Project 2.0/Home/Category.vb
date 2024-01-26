
Imports System.Data.Odbc

Public Class Category
    Dim cat_ID As String
    Dim da1 As New OdbcDataAdapter
    Dim ds1 As New DataSet
    Dim da2 As New OdbcDataAdapter
    Dim ds2 As New DataSet

    Private Sub RefreshData()
        '// Load Department //

        Dim da1 As New OdbcDataAdapter
        Dim ds1 As New DataSet

        connection()

        Try
            If ds1.Tables.Contains("Department") Then
                ds1.Tables.Remove("Department")
            End If

            cmdx.CommandText = "select dname,dcode from Department where loca='" & loca & "'"
            cmdx.Connection = cn
            da1.SelectCommand = cmdx
            da1.Fill(ds1, "Department")
            ComDeptname.DataSource = ds1.Tables("Department")
            ComDeptname.DisplayMember = "dname"
            ComDeptname.ValueMember = "dcode"
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Departments")
            cn.Close()
        End Try
        catagory()
        New_catagory_id()
    End Sub
    Private Sub catagory()
        ''// Load catagory //
        connection()

        Try
            If ds2.Tables.Contains("catagory") Then
                ds2.Tables.Remove("catagory")
            End If

            cmdx.CommandText = "select name,code from Category where loca='" & loca & "' and deptcode='" + ComDeptname.SelectedValue.ToString + "'"
            cmdx.Connection = cn
            da2.SelectCommand = cmdx
            da2.Fill(ds2, "catagory")
            ComCatName.DataSource = ds2.Tables("catagory")
            comCatCode.DataSource = ds2.Tables("catagory")
            ComCatName.DisplayMember = "Name"
            comCatCode.DisplayMember = "Code"
            ComCatName.Text = ""
            comCatCode.Text = ""
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Catagory")
            cn.Close()
        End Try
    End Sub
    Private Sub New_catagory_id()
        '// Get New Catagory ID //
        connection()

        Try
            cmd = New OdbcCommand("select max(code) as IDD from Category where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    Dim ctno As Integer
                    ctno = Val(dr("IDD")) + 1
                    comCatCode.Text = Format(ctno, "0000#")
                    cat_ID = Format(ctno, "0000#")
                Else
                    comCatCode.Text = "00001"
                    cat_ID = "00001"
                End If

            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in New Catagory Id")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub btncustsave_Click(sender As Object, e As EventArgs) Handles btncustsave.Click

        Try


            connection()
            cmd2 = New OdbcCommand("INSERT INTO Category Values('" & cat_ID & "','" & ComCatName.Text & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & loca & "','" & Trim(ComDeptname.SelectedValue.ToString) & "','" & ComDeptname.Text & "')", cn)
            cmd2.ExecuteNonQuery()
            cn.Close()
            MsgBox("Category Save Successfully....", MsgBoxStyle.Information, "Save Alert")

            RefreshData()
            New_catagory_id()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Catagory Save")
        End Try
    End Sub

    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RefreshData()

    End Sub

    Private Sub btncustdelete_Click(sender As Object, e As EventArgs) Handles btncustdelete.Click


        If MessageBox.Show("If You Need to Delete This Catagory.?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            connection()

            Try
                cmdx.CommandText = "delete Category where code ='" & comCatCode.Text.ToString & "' and loca='" & loca & "'"
                cmdx.Connection = cn
                cmdx.ExecuteNonQuery()
                MsgBox("Category Delete Successfully....", MsgBoxStyle.Information, "Delete Alert")
                RefreshData()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Delete Catagory ")
            End Try

            RefreshData()

        End If
    End Sub

    Private Sub cmbcatecode_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode

            Case Keys.Enter
                ComCatName.Focus()
                ComCatName.SelectAll()
        End Select
    End Sub

    Private Sub cmbcatename_KeyDown(sender As Object, e As KeyEventArgs) Handles ComCatName.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                btncustsave.Focus()
        End Select
    End Sub

    Private Sub btncustupdate_Click(sender As Object, e As EventArgs) Handles btncustupdate.Click

        If MessageBox.Show("If You Need to Update This Catagory.?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            connection()

            Try
                cmdx.CommandText = "UPDATE Category set name='" & ComCatName.Text & "' where code='" & comCatCode.Text.ToString & "' and loca='" & loca & "'"
                cmdx.Connection = cn
                cmdx.ExecuteNonQuery()
                MsgBox("Category Update Successfully....", MsgBoxStyle.Information, "Update Alert")
                RefreshData()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Catagory Update")
            End Try

        End If
    End Sub

    Private Sub ComDeptname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComDeptname.SelectedIndexChanged
        If Not IsDBNull(ComDeptname.SelectedValue.ToString) Then
            catagory()

        Else
            ComCatName.Text = ""
        End If

    End Sub
End Class