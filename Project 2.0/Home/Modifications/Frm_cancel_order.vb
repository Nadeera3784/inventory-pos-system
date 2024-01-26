Public Class Frm_cancel_order
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cominvoice.Text = ""
        txttotal.Text = ""
        lbltype.Text = ""
    End Sub

    Public Sub load_invoice()
        connection()
        cominvoice.Items.Clear()

        Try
            cmd.CommandText = "SELECT invoiceno FROM payment WHERE isdelete='0' and loca='" + loca + "' order by invoiceno desc"
            cmd.Connection = cn
            dr = cmd.ExecuteReader

            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    cominvoice.Items.Add(dr(0))
                End If

            End While
            dr.Close()
            cn.Close()
            lbltype.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
            dr.Close()
            cn.Close()

        End Try
    End Sub

    Public Sub Refresh_All()
        load_invoice()
        cominvoice.Text = ""
        txttotal.Text = ""
        lbltype.Text = ""

    End Sub

    Private Sub cominvoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cominvoice.SelectedIndexChanged
        connection()

        Try
            cmd.CommandText = "SELECT grandtotal,type FROM payment WHERE invoiceno='" + cominvoice.Text.ToString + "'"
            cmd.Connection = cn
            dr = cmd.ExecuteReader

            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    txttotal.Text = dr("grandtotal")
                    lbltype.Text = dr("type")
                End If

            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            dr.Close()
            cn.Close()

        End Try
    End Sub

    Public Sub cancel_Order()

        connection()

        Try
            cmd.CommandText = "UPDATE invoice SET isdelete='1',deldate='" + Format(Now, "yyyy-MMM-dd") + "' WHERE invoiceno='" + cominvoice.Text + "' and loca='" + loca + "' ; UPDATE payment SET isdelete='1',deldate='" + Format(Now, "yyyy-MMM-dd") + "' WHERE invoiceno='" + cominvoice.Text + "' and loca='" + loca + "'"
            cmd.Connection = cn
            cmd.ExecuteNonQuery()
            cn.Close()

            If lbltype.Text = "CREDIT" Then
                connection()

                Try
                    cmd.CommandText = "UPDATE credit SET isdelete='1',deldate='" + Format(Now, "yyyy-MMM-dd") + "' WHERE invoiceno='" + cominvoice.Text + "'"
                    cmd.Connection = cn
                    cmd.ExecuteNonQuery()

                Catch ex As Exception
                    MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Cancel From Credit")
                End Try

            End If

            MsgBox("Invoice Successfuly Canceled", vbOKOnly + vbInformation, "Point Of Sale System")
            Refresh_All()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Frm_cancel_order_Load(sender As Object, e As EventArgs) Handles Me.Load

        Refresh_All()

    End Sub

    Private Sub btnCan_invoice_Click(sender As Object, e As EventArgs) Handles btnCan_invoice.Click
        If MessageBox.Show("Are You sure to Cancel this Order.?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            cancel_Order()

        End If
    End Sub
End Class