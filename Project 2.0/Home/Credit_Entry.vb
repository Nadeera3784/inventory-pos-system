
Imports System.Data.Odbc

Public Class Credit_Entry
    Dim da1 As New OdbcDataAdapter
    Dim ds1 As New DataSet
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            connection()
            cmd = New OdbcCommand("select max(id) as IDD from Statement where cust_code = '" & cmbcreditcustcode.Text & "'", cn)
            dr = cmd.ExecuteReader()
            Dim ID As Integer
            While dr.Read
                If Not IsDBNull(dr(0)) Then

                    ID = dr.Item("IDD")
                    ID = ID + 1

                Else
                    ID = "1"
                End If
            End While
            dr.Close()
            cn.Close()

            connection()
            cmd = New OdbcCommand("select top(1) * from Statement where cust_code = '" & cmbcreditcustcode.Text & "' order by Id DESC", cn)
            dr = cmd.ExecuteReader()
            dr.Read()
            Dim Balance As Double
            If dr.HasRows Then
                Balance = dr("balance") + Val(txtcreditamount.Text)
            Else
                Balance = txtcreditamount.Text
            End If
            dr.Close()

            connection()
            cmd = New OdbcCommand("INSERT INTO Statement Values('" & ID & "','" & cmbcreditcustcode.Text & "','" & cmbcreditcustname.Text & "','" & txtcreditdescription.Text & "','" & txtcreditamount.Text & "', '" & 0 & "', '" & Balance & "','" & Format(Dpcreditdate.Value, "yyyy-MMM-dd") & "','" & Format(Dpcreditdate.Value, "yyMMdd") & "','" & loca & "')", cn)
            cmd.ExecuteNonQuery()

            cmbcreditcustcode.Text = ""
            cmbcreditcustname.Text = ""
            txtcreditdescription.Text = ""
            txtcreditamount.Text = ""
            cmbcreditcustname.Focus()

            MsgBox("Credit Entry Save Successfully..")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbcreditcustcode.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                cmbcreditcustname.Focus()
        End Select
    End Sub

    'Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcreditcustcode.SelectedIndexChanged
    '    Try
    '        connection()
    '        cmd = New OdbcCommand("select * from Customer where code='" & cmbcreditcustcode.Text & "' and loca='" & loca & "'", cn)
    '        dr = cmd.ExecuteReader
    '        dr.Read()
    '        If dr.HasRows Then
    '            cmbcreditcustcode.Text = Trim(dr.Item("code"))
    '            cmbcreditcustname.Text = dr.Item("name")
    '        End If
    '        dr.Close()
    '        cn.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, vbOKOnly + vbCritical, "Error In Customer Code")
    '        dr.Close()
    '        cn.Close()
    '    End Try
    'End Sub

    Private Sub ComboBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbcreditcustname.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                txtcreditdescription.Focus()
        End Select
    End Sub

    'Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbcreditcustname.SelectedIndexChanged
    '    Try
    '        connection1()
    '        cmd2 = New OdbcCommand("select * from Customer where name='" & cmbcreditcustname.Text & "' and loca='" & loca & "'", cn1)
    '        dr2 = cmd2.ExecuteReader
    '        dr2.Read()
    '        If dr2.HasRows Then
    '            cmbcreditcustcode.Text = Trim(dr2.Item("code"))
    '            cmbcreditcustname.Text = dr2.Item("name")
    '        End If
    '        dr2.Close()
    '        cn1.Close()

    '    Catch ex As Exception
    '        MsgBox(ex.Message, vbOKOnly + vbCritical, "Error In Customer Name")
    '        dr2.Close()
    '        cn1.Close()
    '    End Try

    'End Sub
    Private Sub Load_customers()
        connection()

        Try
            If ds1.Tables.Contains("Customer") Then
                ds1.Tables.Remove("Customer")
            End If

            cmdx.CommandText = "select * from Customer where loca='" & loca & "'"
            cmdx.Connection = cn
            da1.SelectCommand = cmdx
            da1.Fill(ds1, "Customer")
            cmbcreditcustcode.DataSource = ds1.Tables("Customer")
            cmbcreditcustname.DataSource = ds1.Tables("Customer")
            cmbcreditcustname.DisplayMember = "Name"
            cmbcreditcustcode.DisplayMember = "Code"
            cmbcreditcustcode.Text = ""
            cmbcreditcustname.Text = ""
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Customers")
            cn.Close()
        End Try

    End Sub

    Private Sub Credit_Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_customers()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcreditdescription.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                Dpcreditdate.Focus()
        End Select
    End Sub

    Private Sub DateTimePicker1_KeyDown(sender As Object, e As KeyEventArgs) Handles Dpcreditdate.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                txtcreditamount.Focus()
        End Select
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcreditamount.KeyDown
        Select Case e.KeyCode

            Case Keys.Enter
                btncreditsave.Focus()
        End Select
    End Sub

    Private Sub btncreditsave_Click(sender As Object, e As EventArgs) Handles btncreditsave.Click
        Dim Balance As Double

        Try
            connection()
            cmd = New OdbcCommand("select max(id) as IDD from Statement where custcode = '" & cmbcreditcustcode.Text & "'", cn)
            dr = cmd.ExecuteReader()
            Dim ID As Integer
            While dr.Read
                If Not IsDBNull(dr(0)) Then

                    ID = dr.Item("IDD")
                    ID = ID + 1

                Else
                    ID = "1"
                End If
            End While
            dr.Close()
            cn.Close()

            connection()
            Try


                cmd = New OdbcCommand("select top(1) * from Statement where custcode = '" & cmbcreditcustcode.Text & "' order by Id DESC", cn)
                dr = cmd.ExecuteReader()
                dr.Read()

                If dr.HasRows Then
                    Balance = dr("balance") + Val(txtcreditamount.Text)
                Else
                    Balance = txtcreditamount.Text
                End If
                dr.Close()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error In Statement Balance")
                dr.Close()
                cn.Close()
            End Try

            connection()
            Try


                cmd = New OdbcCommand("INSERT INTO Statement Values('" & ID & "','" & cmbcreditcustcode.Text & "','" & cmbcreditcustname.Text & "','" & txtcreditdescription.Text & "','" & txtcreditamount.Text & "', '" & 0 & "', '" & Balance & "','" & Format(Dpcreditdate.Value, "yyyy-MMM-dd") & "','" & Format(Dpcreditdate.Value, "yyMMdd") & "','" & loca & "')", cn)
                cmd.ExecuteNonQuery()

                cmbcreditcustcode.Text = ""
                cmbcreditcustname.Text = ""
                txtcreditdescription.Text = ""
                txtcreditamount.Text = ""
                cmbcreditcustname.Focus()

                MsgBox("Credit Entry Save Successfully..")
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error In Insert Statement")
                dr.Close()
                cn.Close()
            End Try

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error In Statement ID 1")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub btncustdelete_Click(sender As Object, e As EventArgs) Handles btncreditclose.Click
        Me.Close()
    End Sub
End Class