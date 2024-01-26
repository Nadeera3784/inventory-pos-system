Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine
Public Class frm_Settlement
    Dim da2 As New OdbcDataAdapter
    Dim ds2 As New DataSet
    Dim credit As String
    Dim payments As String
    Dim RPT_DOC1 As New ReportDocument

    Public Sub Load_customer()
        connection()
        Try


            If ds2.Tables.Contains("Customer") Then
                ds2.Tables.Remove("Customer")
            End If

            cmdx.CommandText = "select * from Customer where loca='" & loca & "'"
            cmdx.Connection = cn
            da2.SelectCommand = cmdx
            da2.Fill(ds2, "Customer")
            comcode.DataSource = ds2.Tables("Customer")
            comname.DataSource = ds2.Tables("Customer")
            comname.DisplayMember = "name"
            comcode.DisplayMember = "code"
            comcode.Text = ""
            comname.Text = ""
            txtcredit.Text = "0.00"
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Refresh_all()
        Load_customer()
        txtcredit.Text = "0.00"
        txtpayment.Text = ""
        receiptNo()
    End Sub

    Public Sub Print_receipt()

        RPT_DOC1 = New settlement
        Dim dt3 As New DataTable
        connection()
        Try

            cmd.CommandText = "SELECT * FROM settlement WHERE loca='" + loca + "' and isdelete='0' and receiptno='" + lblreceiptno.Text + "'"
            cmd.Connection = cn
            Dim adp1 As New OdbcDataAdapter(cmd)
            adp1.Fill(dt3)
            RPT_DOC1.Database.Tables("settlement").SetDataSource(dt3)
            RPT_DOC1.Refresh()
            RPT_DOC1.PrintToPrinter(1, False, 0, 0)
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbInformation, "Error In Print receipt")
        End Try
    End Sub

    Public Sub receiptNo()
        lblreceiptno.Text = Format(Now, "yyMMdd") & Format(Now, "HHmmss")
    End Sub
    Private Sub frm_Settlement_Load(sender As Object, e As EventArgs) Handles Me.Load
        Load_customer()
        comname.Select()
        comname.SelectAll()
        receiptNo()
    End Sub

    Public Sub search_credit()
        connection()

        Try
            cmd.CommandText = "SELECT SUM(credit) as Credit from credit WHERE custname='" + comname.Text + "' and isdelete='0' and loca='" + loca + "'"
            cmd.Connection = cn
            dr = cmd.ExecuteReader

            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    credit = dr(0)

                Else
                    credit = "0"
                End If
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Search Credit")
        End Try
    End Sub
    Public Sub search_payment()
        connection()

        Try
            cmd.CommandText = "SELECT SUM(payment) as payment from settlement WHERE custname='" + comname.Text + "' and isdelete='0' and loca='" + loca + "'"
            cmd.Connection = cn
            dr = cmd.ExecuteReader

            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    payments = dr(0)

                Else
                    payments = "0"
                End If
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Search Payments")
        End Try
    End Sub

    Private Sub comname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comname.SelectedIndexChanged
        If comname.Text <> "" Then
            search_credit()
            search_payment()

            txtcredit.Text = Format(Val(credit) - Val(payments), "###0.00")

        Else
            txtcredit.Text = "0.00"
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Dispose()
    End Sub

    Private Sub comname_KeyDown(sender As Object, e As KeyEventArgs) Handles comname.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtpayment.Select()
                txtpayment.SelectAll()

        End Select
    End Sub

    Private Sub comcode_KeyDown(sender As Object, e As KeyEventArgs) Handles comcode.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtpayment.Select()
                txtpayment.SelectAll()

        End Select
    End Sub

    Private Sub txtpayment_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpayment.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter

                If txtpayment.Text <> "" Or txtpayment.Text = "0.00" Then

                    connection()

                    Try
                        cmd.CommandText = "insert into settlement (receiptno,custname,payment,dateshort,datelong,balance,cashier,loca) Values ('" + lblreceiptno.Text + "','" + comname.Text.ToString + "','" + txtpayment.Text + "','" + Format(Now, "yyMMdd") + "','" + Format(Now, "yyyy-MMM-dd") + "','" + txtcredit.Text + "','" + username + "','" + loca + "')"
                        cmd.Connection = cn
                        cmd.ExecuteNonQuery()
                        MsgBox("Sattlement has been Succsessful")
                        Print_receipt()
                        Refresh_all()
                    Catch ex As Exception
                        MsgBox(ex.Message,, "Error in Settle Payment")
                    End Try
                Else
                    MsgBox("Please Enter Amount")
                End If
        End Select
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtpayment.Text <> "" Or txtpayment.Text = "0.00" Then

            connection()

            Try
                cmd.CommandText = "insert into settlement (receiptno,custname,payment,dateshort,datelong,balance,cashier,loca) Values ('" + lblreceiptno.Text + "','" + comname.Text.ToString + "','" + txtpayment.Text + "','" + Format(Now, "yyMMdd") + "','" + Format(Now, "yyyy-MMM-dd") + "','" + txtcredit.Text + "','" + username + "','" + loca + "')"
                cmd.Connection = cn
                cmd.ExecuteNonQuery()
                MsgBox("Sattlement has been Succsessful")
                Print_receipt()
                Refresh_all()
            Catch ex As Exception
                MsgBox(ex.Message,, "Error in Settle Payment")
            End Try
        Else
            MsgBox("Please Enter Amount")
        End If
    End Sub
End Class