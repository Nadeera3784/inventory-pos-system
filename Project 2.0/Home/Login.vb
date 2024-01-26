
Imports System.Data.Odbc

Public Class Login

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click

        Dim type As String

        connection()
        cmd = New OdbcCommand("select * from userprofile where username='" & txtloginusername.Text & "' and password='" & txtloginpassword.Text & "'", cn)
        dr = cmd.ExecuteReader
        Dim df As Boolean = False
        While dr.Read
            If Not IsDBNull(dr(0)) Then
                df = True
                type = dr("type")
            End If

        End While
        dr.Close()
        cn.Close()

        If df = True Then
            If type = "ADMIN" Then


                Try


                    connection()
                    cmd2 = New OdbcCommand("select * from userprofile where username='" & Trim(txtloginusername.Text) & "'", cn)
                    dr2 = cmd2.ExecuteReader
                    dr2.Read()
                    If dr2.HasRows Then

                        If Trim(dr2.Item("mlogin")) = "True" Then
                            HomeN.ToolStripButton5.Enabled = True
                        Else
                            HomeN.ToolStripButton5.Enabled = False
                        End If

                        If Trim(dr2.Item("mlocation")) = "True" Then
                            HomeN.ToolStripButton6.Enabled = True
                        Else
                            HomeN.ToolStripButton6.Enabled = False
                        End If

                        If Trim(dr2.Item("mcashier")) = "True" Then
                            HomeN.ToolStripButton7.Enabled = True
                        Else
                            HomeN.ToolStripButton7.Enabled = False
                        End If

                        If Trim(dr2.Item("mcategory")) = "True" Then
                            HomeN.ToolStripButton8.Enabled = True
                        Else
                            HomeN.ToolStripButton8.Enabled = False
                        End If

                        If Trim(dr2.Item("mcustomer")) = "True" Then
                            HomeN.ToolStripButton9.Enabled = True
                        Else
                            HomeN.ToolStripButton9.Enabled = False
                        End If

                        If Trim(dr2.Item("msupplier")) = "True" Then
                            HomeN.ToolStripButton10.Enabled = True
                        Else
                            HomeN.ToolStripButton10.Enabled = False
                        End If

                        If Trim(dr2.Item("mitems")) = "True" Then
                            HomeN.ToolStripButton11.Enabled = True
                        Else
                            HomeN.ToolStripButton11.Enabled = False
                        End If

                        If Trim(dr2.Item("minvoice")) = "True" Then
                            HomeN.ToolStripButton12.Enabled = True
                        Else
                            HomeN.ToolStripButton12.Enabled = False
                        End If

                        If Trim(dr2.Item("mpurchase")) = "True" Then
                            HomeN.ToolStripButton13.Enabled = True
                        Else
                            HomeN.ToolStripButton13.Enabled = False
                        End If

                        If Trim(dr2.Item("mreturn")) = "True" Then
                            HomeN.ToolStripButton1.Enabled = True
                        Else
                            HomeN.ToolStripButton1.Enabled = False
                        End If

                        If Trim(dr2.Item("fcashier")) = "True" Then
                            HomeN.CashierfToolStripMenuItem.Enabled = True
                        Else
                            HomeN.CashierfToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("flogin")) = "True" Then
                            HomeN.LoginfToolStripMenuItem.Enabled = True
                        Else
                            HomeN.LoginfToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("flocations")) = "True" Then
                            HomeN.LocationfToolStripMenuItem.Enabled = True
                        Else
                            HomeN.LocationfToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("fuserprofile")) = "True" Then
                            HomeN.UserProfilefToolStripMenuItem.Enabled = True
                        Else
                            HomeN.UserProfilefToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("fbanks")) = "True" Then
                            HomeN.BankDetailsToolStripMenuItem.Enabled = True
                        Else
                            HomeN.BankDetailsToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("ancustomer")) = "True" Then
                            HomeN.CustomeradToolStripMenuItem.Enabled = True
                        Else
                            HomeN.CustomeradToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("ancategory")) = "True" Then
                            HomeN.CategoryanToolStripMenuItem.Enabled = True
                        Else
                            HomeN.CategoryanToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("ansupplier")) = "True" Then
                            HomeN.SupplieranToolStripMenuItem.Enabled = True
                        Else
                            HomeN.SupplieranToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("anitems")) = "True" Then
                            HomeN.ItemsanToolStripMenuItem.Enabled = True
                        Else
                            HomeN.ItemsanToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("vcustomer")) = "True" Then
                            HomeN.CustomervToolStripMenuItem.Enabled = True
                        Else
                            HomeN.CustomervToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("vcategory")) = "True" Then
                            HomeN.CateogryvToolStripMenuItem.Enabled = True
                        Else
                            HomeN.CateogryvToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("vsupplier")) = "True" Then
                            HomeN.SuppliervToolStripMenuItem.Enabled = True
                        Else
                            HomeN.SuppliervToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("vitems")) = "True" Then
                            HomeN.ItemsvToolStripMenuItem.Enabled = True
                        Else
                            HomeN.ItemsvToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("vpurchase")) = "True" Then
                            HomeN.PurchasevToolStripMenuItem.Enabled = True
                        Else
                            HomeN.PurchasevToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("vinvoice")) = "True" Then
                            HomeN.InvoicevToolStripMenuItem.Enabled = True
                        Else
                            HomeN.InvoicevToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("vreturn")) = "True" Then
                            HomeN.ReturnToolStripMenuItem.Enabled = True
                        Else
                            HomeN.ReturnToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("meexpired")) = "True" Then
                            HomeN.ExpiredItemsmToolStripMenuItem.Enabled = True
                        Else
                            HomeN.ExpiredItemsmToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("meoutofstock")) = "True" Then
                            HomeN.OutOfStockmToolStripMenuItem.Enabled = True
                        Else
                            HomeN.OutOfStockmToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("sdbbackup")) = "True" Then
                            HomeN.DatabaseConfigsToolStripMenuItem.Enabled = True
                        Else
                            HomeN.DatabaseConfigsToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("rsales")) = "True" Then
                            HomeN.SalesReportsrToolStripMenuItem.Enabled = True
                        Else
                            HomeN.SalesReportsrToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("rcurrent")) = "True" Then
                            HomeN.CurrentStockReportsrToolStripMenuItem.Enabled = True
                        Else
                            HomeN.CurrentStockReportsrToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("rstockvaluation")) = "True" Then
                            HomeN.StockValuationReportsrToolStripMenuItem.Enabled = True
                        Else
                            HomeN.StockValuationReportsrToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("rexpired")) = "True" Then
                            HomeN.ExpiredReportsrToolStripMenuItem.Enabled = True
                        Else
                            HomeN.ExpiredReportsrToolStripMenuItem.Enabled = False
                        End If

                        If Trim(dr2.Item("routofstock")) = "True" Then
                            HomeN.OutOfStockReportsrToolStripMenuItem.Enabled = True
                        Else
                            HomeN.OutOfStockReportsrToolStripMenuItem.Enabled = False
                        End If


                        If Trim(dr2.Item("rbanks")) = "True" Then
                            HomeN.BankDetailReportsToolStripMenuItem.Enabled = True
                        Else
                            HomeN.BankDetailReportsToolStripMenuItem.Enabled = False
                        End If
                    End If

                    dr2.Close()
                    cn.Close()



                    Me.Hide()
                    HomeN.Show()
                    username = txtloginusername.Text
                    HomeN.Text = HomeN.Text & " | " & txtloginusername.Text


                Catch ex As Exception
                    MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Access Control")
                End Try

            Else
                username = txtloginusername.Text
                HomeN.Hide()
                frm_invoice.Show()
                frm_invoice.ex = "full"
            End If
        Else
            MessageBox.Show("Invalid Username and Password..!", "", MessageBoxButtons.OK, MessageBoxIcon.Error)

            txtloginusername.Focus()
            txtloginusername.SelectAll()
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub txtloginusername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtloginusername.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                txtloginpassword.Focus()
                txtloginpassword.SelectAll()
        End Select
    End Sub

    Private Sub txtloginpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtloginpassword.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                btnlogin.Focus()
                btnlogin.Select()
        End Select
    End Sub

    Private Sub Login_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtloginusername.Focus()
        txtloginusername.SelectAll()
    End Sub

End Class