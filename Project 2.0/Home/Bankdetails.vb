
Imports System.Data.Odbc

Public Class Bankdetails

    Dim a As Double
    Dim d, g As Integer
    Dim c As Decimal
    Dim unit As Decimal
    Dim description As String
    Dim qty As Decimal
    Dim discount As Decimal
    Dim amount As Decimal
    Dim ccode As String
    Dim tid As Integer
    Dim tCode As String
    Dim ID As Integer = 0

    Private Sub Bankdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bank_ID()
        connection()
        cmd = New OdbcCommand("select * from Supplier", cn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cmbsuppcode.Items.Add(dr("code"))
                cmbsuppname.Items.Add(dr("name"))
            End While
        End If
        dr.Close()
        cn.Close()

        connection()

        da = New OdbcDataAdapter("Select Id as 'ID',code as 'Code',name as 'Name',bank as 'Bank',branch as 'Branch', accountno as 'Account No' from Banks where loca='" & loca & "' order by ID asc", cn)
        dt = New DataTable()
        da.Fill(dt)
        banksdatagridview.DataSource = dt

        banksdatagridview.Columns(0).Width = 40
        banksdatagridview.Columns(1).Width = 80
        banksdatagridview.Columns(2).Width = 180
        banksdatagridview.Columns(3).Width = 160
        banksdatagridview.Columns(4).Width = 120
        banksdatagridview.Columns(5).Width = 150
        banksdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        banksdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        banksdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        banksdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        banksdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        banksdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        banksdatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        banksdatagridview.Refresh()

    End Sub

    Private Sub Load_grid()

        Try

                connection()
                da = New OdbcDataAdapter("Select Id as 'ID',code as 'Code',name as 'Name',bank as 'Bank',branch as 'Branch', accountno as 'Account No' from Banks where loca='" & loca & "' order by ID asc", cn)
                dt = New DataTable()
                da.Fill(dt)
                banksdatagridview.DataSource = dt

                banksdatagridview.Columns(0).Width = 40
                banksdatagridview.Columns(1).Width = 80
                banksdatagridview.Columns(2).Width = 180
                banksdatagridview.Columns(3).Width = 160
                banksdatagridview.Columns(4).Width = 120
                banksdatagridview.Columns(5).Width = 150
                banksdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                banksdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                banksdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                banksdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                banksdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                banksdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                banksdatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                banksdatagridview.Refresh()

            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Grid")
            End Try
    End Sub

    Private Sub Bank_ID()

        Try

            connection()
            cmd2 = New OdbcCommand("select max(id) AS IDD from Banks where loca='" & loca & "'", cn)
            dr2 = cmd2.ExecuteReader()

            While dr2.Read

                If Not IsDBNull(dr2(0)) Then
                    ID = dr2.Item("IDD")
                    ID = ID + 1

                Else
                    ID = "1"
                End If
            End While
            dr2.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Bank ID")
            dr2.Close()
            cn.Close()
        End Try

    End Sub

    Private Sub btnbankssave_Click(sender As Object, e As EventArgs) Handles btnbankssave.Click

        connection()
            Try
                cmd = New OdbcCommand("INSERT INTO Banks Values('" & ID & "','" & cmbsuppcode.Text & "','" & cmbsuppname.Text & "','" & cmbbanks.Text & "','" & cmbbranch.Text & "','" & cmbaccountno.Text & "','" & Format(Now, "yyyy-MMM-dd") & "','" & Format(Now, "yyMMdd") & "','" & loca & "')", cn)
                cmd.ExecuteNonQuery()
                cn.Close()

                cmbsuppcode.Text = ""
                cmbsuppname.Text = ""
                cmbbanks.Text = ""
                cmbbranch.Text = ""
                cmbaccountno.Text = ""
            cmbsuppcode.Focus()
            MessageBox.Show("Bank Details Save Successfully..", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Insert Bank Values")
                cn.Close()
            End Try

            Try

                connection()
                da = New OdbcDataAdapter("Select Id as 'ID',code as 'Code',name as 'Name',bank as 'Bank',branch as 'Branch', accountno as 'Account No' from Banks where loca='" & loca & "' order by ID asc", cn)
                dt = New DataTable()
                da.Fill(dt)
                banksdatagridview.DataSource = dt

                banksdatagridview.Columns(0).Width = 40
                banksdatagridview.Columns(1).Width = 80
                banksdatagridview.Columns(2).Width = 180
                banksdatagridview.Columns(3).Width = 160
                banksdatagridview.Columns(4).Width = 120
                banksdatagridview.Columns(5).Width = 150
                banksdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                banksdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                banksdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                banksdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                banksdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                banksdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                banksdatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                banksdatagridview.Refresh()


        Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Insert Bank Values")
                cn.Close()
            End Try

        Bank_ID()

    End Sub

    Private Sub btnbanksupdate_Click(sender As Object, e As EventArgs) Handles btnbanksupdate.Click
        connection()

        Try
            cmd2 = New OdbcCommand("UPDATE banks set bank='" & cmbbanks.Text & "', branch='" & cmbbranch.Text & "', accountno='" & cmbaccountno.Text & "' where code='" & Trim(cmbsuppcode.Text) & "' and loca = '" & loca & "'", cn)
            cmd2.ExecuteNonQuery()
            cn.Close()

            cmbsuppcode.Text = ""
            cmbsuppname.Text = ""
            cmbbanks.Text = ""
            cmbbranch.Text = ""
            cmbaccountno.Text = ""
            cmbsuppcode.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Update Bank Values")
            cn.Close()
        End Try
        Load_grid()
        Bank_ID()

    End Sub

    Private Sub cmbsuppcode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsuppcode.SelectedIndexChanged
        Try
            connection1()
            cmd2 = New OdbcCommand("select * from Supplier where code='" & cmbsuppcode.Text & "' and loca='" & loca & "'", cn1)
            dr2 = cmd2.ExecuteReader
            dr2.Read()
            If dr2.HasRows Then
                cmbsuppcode.Text = Trim(dr2.Item("code"))
                cmbsuppname.Text = dr2.Item("name")
            End If
            dr2.Close()
            cn1.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Supplir Code")
            dr2.Close()
            cn1.Close()
        End Try
    End Sub

    Private Sub cmbsuppname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsuppname.SelectedIndexChanged
        Try
            connection()
            cmd3 = New OdbcCommand("select * from Supplier where name='" & cmbsuppname.Text & "' and loca='" & loca & "'", cn)
            dr3 = cmd3.ExecuteReader
            dr3.Read()
            If dr3.HasRows Then
                cmbsuppcode.Text = Trim(dr3.Item("code"))
                cmbsuppname.Text = dr3.Item("name")
            End If
            dr3.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Supplir Name")
            dr2.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub btnbanksdelete_Click(sender As Object, e As EventArgs) Handles btnbanksdelete.Click

        Try

            connection()

            cmd = New OdbcCommand("delete from banks where code='" & cmbsuppcode.Text & "' and loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()

            da = New OdbcDataAdapter("Select Id as 'ID',code as 'Code',name as 'Name',bank as 'Bank',branch as 'Branch', accountno as 'Account No' from Banks where loca='" & loca & "' order by ID asc", cn)
            dt = New DataTable()
            da.Fill(dt)
            banksdatagridview.DataSource = dt

            banksdatagridview.Columns(0).Width = 40
            banksdatagridview.Columns(1).Width = 80
            banksdatagridview.Columns(2).Width = 180
            banksdatagridview.Columns(3).Width = 160
            banksdatagridview.Columns(4).Width = 120
            banksdatagridview.Columns(5).Width = 150
            banksdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            banksdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            banksdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            banksdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            banksdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            banksdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            banksdatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            banksdatagridview.Refresh()


            cmbsuppcode.Text = ""
            cmbsuppname.Text = ""
            cmbbanks.Text = ""
            cmbbranch.Text = ""
            cmbaccountno.Text = ""
            cmbsuppcode.Focus()

            banksdatagridview.ClearSelection()
            banksdatagridview.Refresh()
            Bank_ID()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in bank Details Delete")
            cn.Close()
        End Try
    End Sub

    Private Sub cmbbanks_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbbanks.KeyDown

        Select Case e.KeyCode
            Case Keys.Enter
                cmbbranch.Focus()
                cmbbranch.SelectAll()
        End Select

    End Sub

    Private Sub cmbbranch_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbbranch.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                cmbaccountno.Focus()
                cmbaccountno.SelectAll()
        End Select
    End Sub

    Private Sub cmbaccountno_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbaccountno.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnbankssave.Focus()
                btnbankssave.Select()
        End Select
    End Sub

    Private Sub banksdatagridview_KeyDown(sender As Object, e As KeyEventArgs) Handles banksdatagridview.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                Try
                    Dim inx As Integer
                    inx = banksdatagridview.CurrentRow.Index
                    ccode = banksdatagridview.Item(0, inx).Value
                    Dim a As Integer
                    For a = 0 To banksdatagridview.Rows.Count - 1
                        If banksdatagridview.Item(1, a).Value = ccode Then
                            MessageBox.Show("You Already Entered This Bank Details " & banksdatagridview.Item(2, a).Value, "", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            banksdatagridview.FirstDisplayedScrollingRowIndex = banksdatagridview.Rows(a).Index
                            banksdatagridview.Rows(banksdatagridview.Rows(a).Index).Selected = True

                        End If
                    Next

                    Dim i As Integer
                    i = banksdatagridview.CurrentRow.Index
                    cmbsuppcode.Text = banksdatagridview.Item(1, i).Value
                    cmbsuppname.Text = banksdatagridview.Item(2, i).Value
                    cmbbanks.Text = banksdatagridview.Item(3, i).Value
                    cmbbranch.Text = banksdatagridview.Item(4, i).Value
                    cmbaccountno.Text = banksdatagridview.Item(5, i).Value


                Catch ex As Exception
                    MessageBox.Show(ex.ToString())
                End Try
        End Select
    End Sub
End Class