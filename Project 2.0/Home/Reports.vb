
Imports System.Data.Odbc

Public Class Reports
    Dim da1 As New OdbcDataAdapter
    Dim ds1 As New DataSet
    Dim da2 As New OdbcDataAdapter
    Dim ds2 As New DataSet
    Private Sub btnreportsdisplay2_Click_1(sender As Object, e As EventArgs) Handles btnreportsdisplay2.Click
       
        Try
            If ReportMode = 19 Then 'Purchase Order Note
                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_Purchaseorder as select * from Purchase where docno='" & Trim(cmbreportdocno.Text) & "'and dateshort >='" & Format(dpreports2to.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreportsp2from.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\Purchaseorder.rpt"
                Reportviewer.Show()
                cn.Close()
            ElseIf ReportMode = 20 Then 'Purchase Order Note Summery
                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_PurchaseorderSummery as select * from Purchase where docno='" & Trim(cmbreportdocno.Text) & "'and dateshort >='" & Format(dpreports2to.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreportsp2from.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\PurchaseorderSummery.rpt"
                Reportviewer.Show()
                cn.Close()
            ElseIf ReportMode = 21 Then 'Invoice Details

                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_Invoice_details as select * from Invoice_Details where docno='" & Trim(cmbreportdocno.Text) & "'and dateshort >='" & Format(dpreports2to.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreportsp2from.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\Invoice_details.rpt"
                Reportviewer.Show()
                cn.Close()
            ElseIf ReportMode = 22 Then 'Invoice Details Summery

                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_Invoice_detailssummery as select * from Invoice_Details where docno='" & Trim(cmbreportdocno.Text) & "'and dateshort >='" & Format(dpreports2to.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreportsp2from.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\Invoice_detailssummery.rpt"
                Reportviewer.Show()
                cn.Close()
            ElseIf ReportMode = 27 Then 'Purchase Return Order Note

                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_Purchasereturnorder as select * from Purchasereturn where docno='" & Trim(cmbreportdocno.Text) & "'and dateshort >='" & Format(dpreports2to.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreportsp2from.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\Purchasereturnorder.rpt"
                Reportviewer.Show()
                cn.Close()
            ElseIf ReportMode = 28 Then 'Purchase Return Order Note Summery

                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_PurchasereturnorderSummery as select * from Purchasereturn where docno='" & Trim(cmbreportdocno.Text) & "'and dateshort >='" & Format(dpreports2to.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreportsp2from.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\PurchasereturnorderSummery.rpt"
                Reportviewer.Show()
                cn.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ReportMode = 1 Then 'Item Wise Sales Report

            Me.Text = "Item Wise Sales Report"
            lblheadertext1.Text = "Item Wise Sales Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

        ElseIf ReportMode = 43 Then 'Department Wise Sales Report

            Me.Text = "Department Wise Sales Report"
            lblheadertext1.Text = "Department Wise Sales Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

        ElseIf ReportMode = 2 Then 'Category Wise Sales Report

            Me.Text = "Category Wise Sales Report"
            lblheadertext1.Text = "Category Wise Sales Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            cmbreportsfromcode.Enabled = False
            'cmbreportsfromname.Enabled = False
            cmbreportstocode.Enabled = False
            'cmbreportstoname.Enabled = False

        ElseIf ReportMode = 2 Then 'Daily Expenses Report

            Me.Text = "Daily Expenses Sales Report"
            lblheadertext1.Text = "Daily Expenses Sales Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            cmbreportsfromcode.Enabled = False
            cmbreportsfromname.Enabled = False
            cmbreportstocode.Enabled = False
            cmbreportstoname.Enabled = False


        ElseIf ReportMode = 3 Then 'Supplier Wise Sales Report

            Me.Text = "Supplier Wise Sales Report"
            lblheadertext1.Text = "Supplier Wise Sales Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            cmbreportsfromcode.Enabled = False
            'cmbreportsfromname.Enabled = False
            cmbreportstocode.Enabled = False
            'cmbreportstoname.Enabled = False

        ElseIf ReportMode = 4 Then 'Sales Summery

            Me.Text = "Sales Summery"
            lblheadertext1.Text = "Sales Summery Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            cmbreportsfromcode.Enabled = True
            cmbreportsfromname.Enabled = True
            cmbreportstocode.Enabled = True
            cmbreportstoname.Enabled = True

        ElseIf ReportMode = 42 Then 'Daily Expenses Sales Summery

            Me.Text = "Daily Expenses Sales Summery"
            lblheadertext1.Text = "Daily Expenses Sales Summery"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            cmbreportsfromcode.Enabled = False
            cmbreportsfromname.Enabled = False
            cmbreportstocode.Enabled = False
            cmbreportstoname.Enabled = False

        ElseIf ReportMode = 5 Then 'Item Wise Gross Profit

            Me.Text = "Item Wise Gross Profit"
            lblheadertext1.Text = "Item Wise Gross Profit Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()
            '//..............


            Try

                '// From data
                connection()

                If ds2.Tables.Contains("Items") Then
                    ds2.Tables.Remove("Items")
                End If

                cmd.CommandText = "select * from Items where loca='" & loca & "'"
                cmd.Connection = cn
                da2.SelectCommand = cmd
                da2.Fill(ds2, "Items")
                cmbreportsfromcode.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DisplayMember = "Name"
                cmbreportsfromcode.DisplayMember = "Code"
                cmbreportsfromname.Text = ""
                cmbreportsfromcode.Text = ""
                cn.Close()

                '// To data

                connection1()

                If ds1.Tables.Contains("Items") Then
                    ds1.Tables.Remove("Items")
                End If

                cmdx.CommandText = "select * from Items where loca='" & loca & "'"
                cmdx.Connection = cn1
                da1.SelectCommand = cmdx
                da1.Fill(ds1, "Items")
                cmbreportstocode.DataSource = ds1.Tables("Items")
                cmbreportstoname.DataSource = ds1.Tables("Items")
                cmbreportstoname.DisplayMember = "Name"
                cmbreportstocode.DisplayMember = "Code"
                cmbreportstoname.Text = ""
                cmbreportstocode.Text = ""
                cn1.Close()


            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Items Load")
                cn.Close()
                cn1.Close()
            End Try
            '//..............


        ElseIf ReportMode = 6 Then 'Category Wise Gross Profit
            Me.Text = "Category Wise Gross Profit"
            lblheadertext1.Text = "Category Wise Gross Profit Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            cmbreportsfromcode.Enabled = False
            cmbreportsfromname.Enabled = False
            cmbreportstocode.Enabled = False
            cmbreportstoname.Enabled = False

        ElseIf ReportMode = 7 Then 'Supplier Wise Gross Profit
            Me.Text = "Supplier Wise Gross Profit"
            lblheadertext1.Text = "Supplier Wise Gross Profit Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            cmbreportsfromcode.Enabled = False
            cmbreportsfromname.Enabled = False
            cmbreportstocode.Enabled = False
            cmbreportstoname.Enabled = False


        ElseIf ReportMode = 8 Then 'Item Wise Purchasing Reports

            Me.Text = "Item Wise Purchasing Report"
            lblheadertext1.Text = "Item Wise Purchasing Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()


            '//..............


            Try

                '// From data
                connection()

                If ds2.Tables.Contains("Items") Then
                    ds2.Tables.Remove("Items")
                End If

                cmd.CommandText = "select * from Items where loca='" & loca & "'"
                cmd.Connection = cn
                da2.SelectCommand = cmd
                da2.Fill(ds2, "Items")
                cmbreportsfromcode.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DisplayMember = "Name"
                cmbreportsfromcode.DisplayMember = "Code"
                cmbreportsfromname.Text = ""
                cmbreportsfromcode.Text = ""
                cn.Close()

                '// To data

                connection1()

                If ds1.Tables.Contains("Items") Then
                    ds1.Tables.Remove("Items")
                End If

                cmdx.CommandText = "select * from Items where loca='" & loca & "'"
                cmdx.Connection = cn1
                da1.SelectCommand = cmdx
                da1.Fill(ds1, "Items")
                cmbreportstocode.DataSource = ds1.Tables("Items")
                cmbreportstoname.DataSource = ds1.Tables("Items")
                cmbreportstoname.DisplayMember = "Name"
                cmbreportstocode.DisplayMember = "Code"
                cmbreportstoname.Text = ""
                cmbreportstocode.Text = ""
                cn1.Close()


            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Items Load 1")
                cn.Close()
                cn1.Close()
            End Try
            '//..............


        ElseIf ReportMode = 9 Then 'Category Wise Purchasing Reports

            Me.Text = "Category Wise Purchasing Report"
            lblheadertext1.Text = "Category Wise Purchasing Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            cmbreportsfromcode.Enabled = False
            cmbreportsfromname.Enabled = False
            cmbreportstocode.Enabled = False
            cmbreportstoname.Enabled = False

        ElseIf ReportMode = 10 Then 'Supplier Wise Purchasing Reports

            Me.Text = "Supplier Wise Purchasing Report"
            lblheadertext1.Text = "Supplier Wise Purchasing Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            cmbreportsfromcode.Enabled = False
            cmbreportsfromname.Enabled = False
            cmbreportstocode.Enabled = False
            cmbreportstoname.Enabled = False

        ElseIf ReportMode = 11 Then 'Item Wise Stock Valuation
            Me.Text = "Item Wise Stock Valuation"
            lblheadertext1.Text = "Item Wise Stock Valuation Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            '//..............


            Try

                '// From data
                connection()

                If ds2.Tables.Contains("Items") Then
                    ds2.Tables.Remove("Items")
                End If

                cmd.CommandText = "select * from Items where loca='" & loca & "'"
                cmd.Connection = cn
                da2.SelectCommand = cmd
                da2.Fill(ds2, "Items")
                cmbreportsfromcode.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DisplayMember = "Name"
                cmbreportsfromcode.DisplayMember = "Code"
                cmbreportsfromname.Text = ""
                cmbreportsfromcode.Text = ""
                cn.Close()

                '// To data

                connection1()

                If ds1.Tables.Contains("Items") Then
                    ds1.Tables.Remove("Items")
                End If

                cmdx.CommandText = "select * from Items where loca='" & loca & "'"
                cmdx.Connection = cn1
                da1.SelectCommand = cmdx
                da1.Fill(ds1, "Items")
                cmbreportstocode.DataSource = ds1.Tables("Items")
                cmbreportstoname.DataSource = ds1.Tables("Items")
                cmbreportstoname.DisplayMember = "Name"
                cmbreportstocode.DisplayMember = "Code"
                cmbreportstoname.Text = ""
                cmbreportstocode.Text = ""
                cn1.Close()


            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Items Load 2")
                cn.Close()
                cn1.Close()
            End Try
            '//..............

        ElseIf ReportMode = 12 Then 'Category Wise Stock Valuation
            Me.Text = "Category Wise Stock Valuation"
            lblheadertext1.Text = "Category Wise Stock Valuation Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            '//..............


            Try

                '// From data
                connection()

                If ds2.Tables.Contains("Category") Then
                    ds2.Tables.Remove("Category")
                End If

                cmd.CommandText = "select * from Category where loca='" & loca & "'"
                cmd.Connection = cn
                da2.SelectCommand = cmd
                da2.Fill(ds2, "Category")
                cmbreportsfromcode.DataSource = ds2.Tables("Category")
                cmbreportsfromname.DataSource = ds2.Tables("Category")
                cmbreportsfromname.DisplayMember = "Name"
                cmbreportsfromcode.DisplayMember = "Code"
                cmbreportsfromname.Text = ""
                cmbreportsfromcode.Text = ""
                cn.Close()

                '// To data

                connection1()

                If ds1.Tables.Contains("Category") Then
                    ds1.Tables.Remove("Category")
                End If

                cmdx.CommandText = "select * from Category where loca='" & loca & "'"
                cmdx.Connection = cn1
                da1.SelectCommand = cmdx
                da1.Fill(ds1, "Category")
                cmbreportstocode.DataSource = ds1.Tables("Category")
                cmbreportstoname.DataSource = ds1.Tables("Category")
                cmbreportstoname.DisplayMember = "Name"
                cmbreportstocode.DisplayMember = "Code"
                cmbreportstoname.Text = ""
                cmbreportstocode.Text = ""
                cn1.Close()


            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Category Load")
                cn.Close()
                cn1.Close()
            End Try
            '//..............


        ElseIf ReportMode = 13 Then 'Supplier Wise Stock Valuation
            Me.Text = "Supplier Wise Stock Valuation"
            lblheadertext1.Text = "Supplier Wise Stock Valuation Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            '//..............


            Try

                '// From data
                connection()

                If ds2.Tables.Contains("supplier") Then
                    ds2.Tables.Remove("supplier")
                End If

                cmd.CommandText = "select * from supplier where loca='" & loca & "'"
                cmd.Connection = cn
                da2.SelectCommand = cmd
                da2.Fill(ds2, "supplier")
                cmbreportsfromcode.DataSource = ds2.Tables("supplier")
                cmbreportsfromname.DataSource = ds2.Tables("supplier")
                cmbreportsfromname.DisplayMember = "Name"
                cmbreportsfromcode.DisplayMember = "Code"
                cmbreportsfromname.Text = ""
                cmbreportsfromcode.Text = ""
                cn.Close()

                '// To data

                connection1()

                If ds1.Tables.Contains("supplier") Then
                    ds1.Tables.Remove("supplier")
                End If

                cmdx.CommandText = "select * from supplier where loca='" & loca & "'"
                cmdx.Connection = cn1
                da1.SelectCommand = cmdx
                da1.Fill(ds1, "supplier")
                cmbreportstocode.DataSource = ds1.Tables("supplier")
                cmbreportstoname.DataSource = ds1.Tables("supplier")
                cmbreportstoname.DisplayMember = "Name"
                cmbreportstocode.DisplayMember = "Code"
                cmbreportstoname.Text = ""
                cmbreportstocode.Text = ""
                cn1.Close()


            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in supplier Load")
                cn.Close()
                cn1.Close()
            End Try
            '//..............


        ElseIf ReportMode = 14 Then 'Item Wise Report
            Me.Text = "Item Wise Stock Balance Report"
            lblheadertext1.Text = "Item Wise Stock Balance Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            '//..............


            Try

                '// From data
                connection()

                If ds2.Tables.Contains("Items") Then
                    ds2.Tables.Remove("Items")
                End If

                cmd.CommandText = "select * from Items where loca='" & loca & "'"
                cmd.Connection = cn
                da2.SelectCommand = cmd
                da2.Fill(ds2, "Items")
                cmbreportsfromcode.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DisplayMember = "Name"
                cmbreportsfromcode.DisplayMember = "Code"
                cmbreportsfromname.Text = ""
                cmbreportsfromcode.Text = ""
                cn.Close()

                '// To data

                connection1()

                If ds1.Tables.Contains("Items") Then
                    ds1.Tables.Remove("Items")
                End If

                cmdx.CommandText = "select * from Items where loca='" & loca & "'"
                cmdx.Connection = cn1
                da1.SelectCommand = cmdx
                da1.Fill(ds1, "Items")
                cmbreportstocode.DataSource = ds1.Tables("Items")
                cmbreportstoname.DataSource = ds1.Tables("Items")
                cmbreportstoname.DisplayMember = "Name"
                cmbreportstocode.DisplayMember = "Code"
                cmbreportstoname.Text = ""
                cmbreportstocode.Text = ""
                cn1.Close()


            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Items Load 3")
                cn.Close()
                cn1.Close()
            End Try
            '//..............

        ElseIf ReportMode = 15 Then 'Item Wise Report (minus)
            Me.Text = "Item Wise Stock Balance Report (Minus)"
            lblheadertext1.Text = "Item Wise Stock Balance Report (Minus)"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            '//..............


            Try

                '// From data
                connection()

                If ds2.Tables.Contains("Items") Then
                    ds2.Tables.Remove("Items")
                End If

                cmd.CommandText = "select * from Items where loca='" & loca & "'"
                cmd.Connection = cn
                da2.SelectCommand = cmd
                da2.Fill(ds2, "Items")
                cmbreportsfromcode.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DisplayMember = "Name"
                cmbreportsfromcode.DisplayMember = "Code"
                cmbreportsfromname.Text = ""
                cmbreportsfromcode.Text = ""
                cn.Close()

                '// To data

                connection1()

                If ds1.Tables.Contains("Items") Then
                    ds1.Tables.Remove("Items")
                End If

                cmdx.CommandText = "select * from Items where loca='" & loca & "'"
                cmdx.Connection = cn1
                da1.SelectCommand = cmdx
                da1.Fill(ds1, "Items")
                cmbreportstocode.DataSource = ds1.Tables("Items")
                cmbreportstoname.DataSource = ds1.Tables("Items")
                cmbreportstoname.DisplayMember = "Name"
                cmbreportstocode.DisplayMember = "Code"
                cmbreportstoname.Text = ""
                cmbreportstocode.Text = ""
                cn1.Close()


            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Items Load 4")
                cn.Close()
                cn1.Close()
            End Try
            '//..............

        ElseIf ReportMode = 16 Then 'Categary Wise Stock Balance
            Me.Text = "Categary Wise Stock Balance"
            lblheadertext1.Text = "Categary Wise Stock Balance Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            '//..............


            Try

                '// From data
                connection()

                If ds2.Tables.Contains("Items") Then
                    ds2.Tables.Remove("Items")
                End If

                cmd.CommandText = "select * from Items where loca='" & loca & "'"
                cmd.Connection = cn
                da2.SelectCommand = cmd
                da2.Fill(ds2, "Items")
                cmbreportsfromcode.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DisplayMember = "cateName"
                cmbreportsfromcode.DisplayMember = "cateCode"
                cmbreportsfromname.Text = ""
                cmbreportsfromcode.Text = ""
                cn.Close()

                '// To data

                connection1()

                If ds1.Tables.Contains("Items") Then
                    ds1.Tables.Remove("Items")
                End If

                cmdx.CommandText = "select * from Items where loca='" & loca & "'"
                cmdx.Connection = cn1
                da1.SelectCommand = cmdx
                da1.Fill(ds1, "Items")
                cmbreportstocode.DataSource = ds1.Tables("Items")
                cmbreportstoname.DataSource = ds1.Tables("Items")
                cmbreportstoname.DisplayMember = "cateName"
                cmbreportstocode.DisplayMember = "cateCode"
                cmbreportstoname.Text = ""
                cmbreportstocode.Text = ""
                cn1.Close()


            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Items Load 5")
                cn.Close()
                cn1.Close()
            End Try
            '//..............

        ElseIf ReportMode = 17 Then 'Supplier Wise Stock Balance

            Me.Text = "Supplier Wise Stock Balance"
            lblheadertext1.Text = "Supplier Wise Stock Balance Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            '//..............


            Try

                '// From data
                connection()

                If ds2.Tables.Contains("supplier") Then
                    ds2.Tables.Remove("supplier")
                End If

                cmd.CommandText = "select * from supplier where loca='" & loca & "'"
                cmd.Connection = cn
                da2.SelectCommand = cmd
                da2.Fill(ds2, "supplier")
                cmbreportsfromcode.DataSource = ds2.Tables("supplier")
                cmbreportsfromname.DataSource = ds2.Tables("supplier")
                cmbreportsfromname.DisplayMember = "Name"
                cmbreportsfromcode.DisplayMember = "Code"
                cmbreportsfromname.Text = ""
                cmbreportsfromcode.Text = ""
                cn.Close()

                '// To data

                connection1()

                If ds1.Tables.Contains("supplier") Then
                    ds1.Tables.Remove("supplier")
                End If

                cmdx.CommandText = "select * from supplier where loca='" & loca & "'"
                cmdx.Connection = cn1
                da1.SelectCommand = cmdx
                da1.Fill(ds1, "supplier")
                cmbreportstocode.DataSource = ds1.Tables("supplier")
                cmbreportstoname.DataSource = ds1.Tables("supplier")
                cmbreportstoname.DisplayMember = "Name"
                cmbreportstocode.DisplayMember = "Code"
                cmbreportstoname.Text = ""
                cmbreportstocode.Text = ""
                cn1.Close()


            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in supplier Load 2")
                cn.Close()
                cn1.Close()
            End Try
            '//..............

        ElseIf ReportMode = 18 Then 'Stock Balance Summery
            Me.Text = "Stock Balance Summery"
            lblheadertext1.Text = "Stock Balance Summery Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            '//..............


            Try

                '// From data
                connection()

                If ds2.Tables.Contains("Items") Then
                    ds2.Tables.Remove("Items")
                End If

                cmd.CommandText = "select * from Items where loca='" & loca & "'"
                cmd.Connection = cn
                da2.SelectCommand = cmd
                da2.Fill(ds2, "Items")
                cmbreportsfromcode.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DisplayMember = "Name"
                cmbreportsfromcode.DisplayMember = "Code"
                cmbreportsfromname.Text = ""
                cmbreportsfromcode.Text = ""
                cn.Close()

                '// To data

                connection1()

                If ds1.Tables.Contains("Items") Then
                    ds1.Tables.Remove("Items")
                End If

                cmdx.CommandText = "select * from Items where loca='" & loca & "'"
                cmdx.Connection = cn1
                da1.SelectCommand = cmdx
                da1.Fill(ds1, "Items")
                cmbreportstocode.DataSource = ds1.Tables("Items")
                cmbreportstoname.DataSource = ds1.Tables("Items")
                cmbreportstoname.DisplayMember = "Name"
                cmbreportstocode.DisplayMember = "Code"
                cmbreportstoname.Text = ""
                cmbreportstocode.Text = ""
                cn1.Close()


            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Items Load 6")
                cn.Close()
                cn1.Close()
            End Try
            '//..............

        ElseIf ReportMode = 19 Then 'Purchase Order Note
            'Me.Text = "Purchase Order Note"
            'lblheadertext1.Text = "Purchase Order Note Report"
            'Reportspanel1.Hide()
            'Reportspanel2.Show()

            'connection()
            'cmd = New Odbc.OdbcCommand("select * from Purchase where loca='" & loca & "'", cn)
            'dr = cmd.ExecuteReader()
            'If dr.HasRows Then
            '    While dr.Read
            '        cmbreportdocno.Items.Add(Trim(dr.Item("docno")))
            '    End While
            'End If
            'dr.Close()
            'cn.Close()
            MsgBox("This Function Temporary Disabled ")
        ElseIf ReportMode = 20 Then 'Purchase Order Note Summery
            'Me.Text = "Purchase Order Note Summery"
            'lblheadertext1.Text = "Purchase Order Note Summery Report"
            'Reportspanel1.Hide()
            'Reportspanel2.Show()

            'connection()
            'cmd = New Odbc.OdbcCommand("select * from Purchase where loca='" & loca & "'", cn)
            'dr = cmd.ExecuteReader()
            'If dr.HasRows Then
            '    While dr.Read
            '        cmbreportdocno.Items.Add(Trim(dr.Item("docno")))
            '    End While
            'End If
            'dr.Close()
            'cn.Close()
            MsgBox("This Function Temporary Disabled ")

        ElseIf ReportMode = 21 Then 'Invoice Details

            Me.Text = "Invoice Details"
            lblheadertext1.Text = "Invoice Details Report"
            Reportspanel1.Hide()
            Reportspanel2.Show()

            connection()
            cmd = New Odbc.OdbcCommand("select * from Invoice_Details where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    cmbreportdocno.Items.Add(Trim(dr.Item("docno")))
                End While
            End If
            dr.Close()
            cn.Close()

        ElseIf ReportMode = 22 Then 'Invoice Details Summery

            Me.Text = "Invoice Details Summery"
            lblheadertext1.Text = "Invoice Details Summery"
            Reportspanel1.Hide()
            Reportspanel2.Show()

            connection()
            cmd = New Odbc.OdbcCommand("select * from Invoice_Details where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    cmbreportdocno.Items.Add(Trim(dr.Item("docno")))
                End While
            End If
            dr.Close()
            cn.Close()

        ElseIf ReportMode = 27 Then 'Purchase Return Order Note
            'Me.Text = "Purchase Return Order Note"
            'lblheadertext1.Text = "Purchase Return Order Note Report"
            'Reportspanel1.Hide()
            'Reportspanel2.Show()

            'connection()
            'cmd = New Odbc.OdbcCommand("select * from Purchasereturn where loca='" & loca & "'", cn)
            'dr = cmd.ExecuteReader()
            'If dr.HasRows Then
            '    While dr.Read
            '        cmbreportdocno.Items.Add(Trim(dr.Item("docno")))
            '    End While
            'End If
            'dr.Close()
            'cn.Close()
            MsgBox("This Function Temporary Disabled ")

        ElseIf ReportMode = 28 Then 'Purchase Return Order Note Summery
            Me.Text = "Purchase Return Order Note Summery"
            lblheadertext1.Text = "Purchase Return Order Note Summery Report"
            Reportspanel1.Hide()
            Reportspanel2.Show()

            'connection()
            'cmd = New Odbc.OdbcCommand("select * from Purchasereturn where loca='" & loca & "'", cn)
            'dr = cmd.ExecuteReader()
            'If dr.HasRows Then
            '    While dr.Read
            '        cmbreportdocno.Items.Add(Trim(dr.Item("docno")))
            '    End While
            'End If
            'dr.Close()
            'cn.Close()
            MsgBox("This Function Temporary Disabled ")

        ElseIf ReportMode = 31 Then 'Item Wise Loss Or Non Profit

            Me.Text = "Item Wise Loss Or Non Profit"
            lblheadertext1.Text = "Item Wise Loss Or Non Profit Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            '//..............


            Try

                '// From data
                connection()

                If ds2.Tables.Contains("Items") Then
                    ds2.Tables.Remove("Items")
                End If

                cmd.CommandText = "select * from Items where loca='" & loca & "'"
                cmd.Connection = cn
                da2.SelectCommand = cmd
                da2.Fill(ds2, "Items")
                cmbreportsfromcode.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DisplayMember = "Name"
                cmbreportsfromcode.DisplayMember = "Code"
                cmbreportsfromname.Text = ""
                cmbreportsfromcode.Text = ""
                cn.Close()

                '// To data

                connection1()

                If ds1.Tables.Contains("Items") Then
                    ds1.Tables.Remove("Items")
                End If

                cmdx.CommandText = "select * from Items where loca='" & loca & "'"
                cmdx.Connection = cn1
                da1.SelectCommand = cmdx
                da1.Fill(ds1, "Items")
                cmbreportstocode.DataSource = ds1.Tables("Items")
                cmbreportstoname.DataSource = ds1.Tables("Items")
                cmbreportstoname.DisplayMember = "Name"
                cmbreportstocode.DisplayMember = "Code"
                cmbreportstoname.Text = ""
                cmbreportstocode.Text = ""
                cn1.Close()


            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Items Load 7")
                cn.Close()
                cn1.Close()
            End Try
            '//..............

        ElseIf ReportMode = 32 Then 'Category Wise Loss Or Non Profit
            Me.Text = "Category Wise Loss Or Non Profit"
            lblheadertext1.Text = "Category Wise Loss Or Non Profit Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            cmbreportsfromcode.Enabled = False
            cmbreportsfromname.Enabled = False
            cmbreportstocode.Enabled = False
            cmbreportstoname.Enabled = False

        ElseIf ReportMode = 33 Then 'Supplier Wise Loss Or Non Profit
            Me.Text = "Supplier Wise Loss Or Non Profit"
            lblheadertext1.Text = "Supplier Wise Loss Or Non Profit Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            cmbreportsfromcode.Enabled = False
            cmbreportsfromname.Enabled = False
            cmbreportstocode.Enabled = False
            cmbreportstoname.Enabled = False

        ElseIf ReportMode = 34 Then 'Creditors Reports
            Me.Text = "Creditors Report"
            lblheadertext1.Text = "Creditors Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            cmbreportsfromcode.Enabled = False
            cmbreportsfromname.Enabled = False
            cmbreportstocode.Enabled = False
            cmbreportstoname.Enabled = False

        ElseIf ReportMode = 35 Then 'Debutors Reports
            Me.Text = "Debutors Report"
            lblheadertext1.Text = "Debutors Report"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            cmbreportsfromcode.Enabled = False
            cmbreportsfromname.Enabled = False
            cmbreportstocode.Enabled = False
            cmbreportstoname.Enabled = False


        ElseIf ReportMode = 32 Then 'Fast Moving Item 

            Me.Text = "Fast Moving Item"
            lblheadertext1.Text = "Fast Moving Item"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            '//..............


            Try

                '// From data
                connection()

                If ds2.Tables.Contains("Items") Then
                    ds2.Tables.Remove("Items")
                End If

                cmd.CommandText = "select * from Items where loca='" & loca & "'"
                cmd.Connection = cn
                da2.SelectCommand = cmd
                da2.Fill(ds2, "Items")
                cmbreportsfromcode.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DisplayMember = "Name"
                cmbreportsfromcode.DisplayMember = "Code"
                cmbreportsfromname.Text = ""
                cmbreportsfromcode.Text = ""
                cn.Close()

                '// To data

                connection1()

                If ds1.Tables.Contains("Items") Then
                    ds1.Tables.Remove("Items")
                End If

                cmdx.CommandText = "select * from Items where loca='" & loca & "'"
                cmdx.Connection = cn1
                da1.SelectCommand = cmdx
                da1.Fill(ds1, "Items")
                cmbreportstocode.DataSource = ds1.Tables("Items")
                cmbreportstoname.DataSource = ds1.Tables("Items")
                cmbreportstoname.DisplayMember = "Name"
                cmbreportstocode.DisplayMember = "Code"
                cmbreportstoname.Text = ""
                cmbreportstocode.Text = ""
                cn1.Close()


            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Items Load 8")
                cn.Close()
                cn1.Close()
            End Try
            '//..............

        ElseIf ReportMode = 33 Then 'Slow Moving Item 
            Me.Text = "Slow Moving Item"
            lblheadertext1.Text = "Slow Moving Item"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            '//..............


            Try

                '// From data
                connection()

                If ds2.Tables.Contains("Items") Then
                    ds2.Tables.Remove("Items")
                End If

                cmd.CommandText = "select * from Items where loca='" & loca & "'"
                cmd.Connection = cn
                da2.SelectCommand = cmd
                da2.Fill(ds2, "Items")
                cmbreportsfromcode.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DataSource = ds2.Tables("Items")
                cmbreportsfromname.DisplayMember = "Name"
                cmbreportsfromcode.DisplayMember = "Code"
                cmbreportsfromname.Text = ""
                cmbreportsfromcode.Text = ""
                cn.Close()

                '// To data

                connection1()

                If ds1.Tables.Contains("Items") Then
                    ds1.Tables.Remove("Items")
                End If

                cmdx.CommandText = "select * from Items where loca='" & loca & "'"
                cmdx.Connection = cn1
                da1.SelectCommand = cmdx
                da1.Fill(ds1, "Items")
                cmbreportstocode.DataSource = ds1.Tables("Items")
                cmbreportstoname.DataSource = ds1.Tables("Items")
                cmbreportstoname.DisplayMember = "Name"
                cmbreportstocode.DisplayMember = "Code"
                cmbreportstoname.Text = ""
                cmbreportstocode.Text = ""
                cn1.Close()


            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Items Load 9")
                cn.Close()
                cn1.Close()
            End Try
            '//..............

        ElseIf ReportMode = 34 Then 'Non Moving Item
            Me.Text = "Non Moving Item"
            lblheadertext1.Text = "Non Moving Item"
            Reportspanel2.Hide()
            Reportspanel1.Show()

            cmbreportsfromcode.Enabled = False
            cmbreportsfromname.Enabled = False
            cmbreportstocode.Enabled = False
            cmbreportstoname.Enabled = False
            dpreports1from.Enabled = False
            dpreports1to.Enabled = False

        End If


    End Sub

    Private Sub cmbreportdocno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbreportdocno.SelectedIndexChanged
        If ReportMode = 17 Then 'Purchase Order Note
            Me.Text = "Purchase Order Note"
            lblheadertext1.Text = "Purchase Order Note"

        ElseIf ReportMode = 18 Then 'Purchase Order Note Summery
            Me.Text = "Purchase Order Note Summery"
            lblheadertext1.Text = "Purchase Order Note Summery Report"

        ElseIf ReportMode = 27 Then 'Purchase Return Order Note
            Me.Text = "Purchase Return Order Note"
            lblheadertext1.Text = "Purchase Return Order Note"

        ElseIf ReportMode = 28 Then 'Purchase Return Order Note Summery
            Me.Text = "Purchase Return Order Note Summery"
            lblheadertext1.Text = "Purchase Return Order Note Summery Report"

        ElseIf ReportMode = 19 Then 'Invoice Details
            Me.Text = "Invoice Details"
            lblheadertext1.Text = "Invoice Details Report"


        ElseIf ReportMode = 20 Then 'Invoice Details Summery
            Me.Text = "Invoice Details Summery"
            lblheadertext1.Text = "Invoice Details Summery Report"

        End If
    End Sub

    Private Sub Load_recoeds_code()

        'Try
        '    If ReportMode = 14 Then 'Item Wise Report
        '        Me.Text = "Item Wise Stock Balance Report"


        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where code='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("name"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 15 Then 'Item Wise Report (minus)
        '        Me.Text = "Item Wise Stock Balance Report (Minus)"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where code='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("name"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 16 Then 'Categary Wise Stock Balance
        '        Me.Text = "Categary Wise Stock Balance"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where catecode='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("catecode"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("catename"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 17 Then 'Supplier Wise Stock Balance
        '        Me.Text = "Supplier Wise Stock Balance"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from supplier where code='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromname.Text = Trim(dr2.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("name"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 18 Then 'Stock Summery Balance
        '        Me.Text = "Stock Summery Balance"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where code='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("name"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 11 Then 'Item Wise Stock Valuation
        '        Me.Text = "Item Wise Stock Valuation"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where code='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("name"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()
        '    ElseIf ReportMode = 12 Then 'Category Wise Stock Valuation
        '        Me.Text = "Category Wise Stock Valuation"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Category where code='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("name"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()
        '    ElseIf ReportMode = 13 Then 'Supplier Wise Stock Valuation
        '        Me.Text = "Supplier Wise Stock Valuation"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from supplier where code='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("name"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 8 Then 'Item Wise Purchasing
        '        Me.Text = "Item Wise Purchasing"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where code='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromname.Text = Trim(dr2.Item("name"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 9 Then 'Catagory Wise Purchasing Report
        '        Me.Text = "Catagory Wise Purchasing Report"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where catecode='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromname.Text = Trim(dr2.Item("catename"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 10 Then 'Supplier Wise Purchasing Report
        '        Me.Text = "Supplier Wise Purchasing Report"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where supcode='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromname.Text = Trim(dr2.Item("supname"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 1 Then 'Item Wise Sales Report

        '        Me.Text = "Item Wise Sales Report"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where code='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("name"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 2 Then 'Category Wise Sales Report
        '        Me.Text = "Category Wise Sales Report"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where catecode='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("catecode"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("catename"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 3 Then 'Supplier Wise Sales Report
        '        Me.Text = "Supplier Wise Sales Report"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where supcode='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("supcode"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("supname"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 4 Then 'Sales Summery
        '        Me.Text = "Sales Summery"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where code='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("name"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 5 Then 'Item Wise Gross Profit
        '        Me.Text = "Item Wise Gross Profit"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where code='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("name"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 6 Then 'Category Wise Gross Profit
        '        Me.Text = "Category Wise Gross Profit"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where catecode='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("catecode"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("catename"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 7 Then 'Supplier Wise Gross Profit
        '        Me.Text = "Supplier Wise Gross Profit"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where supcode='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("supcode"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("supname"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 31 Then 'Item Wise Loss Or Non Profit
        '        Me.Text = "Item Wise Loss Or Non Profit"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where code='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("name"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 32 Then 'Category Wise Loss Or Non Profit
        '        Me.Text = "Category Wise Loss Or Non Profit"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where catecode='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("catecode"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("catename"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 33 Then 'Supplier Wise Loss Or Non Profit
        '        Me.Text = "Supplier Wise Loss Or Non Profit"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where supcode='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("supcode"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("supname"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 36 Then 'Fast Moving Item Report
        '        Me.Text = "Fast Moving Item Report"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where Code='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("Code"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("Name"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 37 Then 'Slow Moving Item Report
        '        Me.Text = "Slow Moving Item Report"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where Code='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("Code"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("Name"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    ElseIf ReportMode = 38 Then 'None Moving Item Report
        '        Me.Text = "None Moving Item Report"

        '        connection1()
        '        cmd = New Odbc.OdbcCommand("select * from Items where Code='" & cmbreportsfromcode.Text & "' and loca='" & loca & "'", cn1)
        '        dr2 = cmd.ExecuteReader
        '        dr2.Read()
        '        If dr2.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr2.Item("Code"))
        '            cmbreportsfromname.Text = Trim(dr2.Item("Name"))
        '        End If
        '        dr2.Close()
        '        cn1.Close()

        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    'Private Sub cmbreportsfromcode_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbreportsfromcode.SelectedIndexChanged
    '    Load_recoeds_code()
    'End Sub

    'Private Sub cmbreportsfromname_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbreportsfromname.SelectedIndexChanged
    '    Load_records_Name()

    'End Sub
    Private Sub Load_records_Name()
        'cmbreportsfromcode.Text = cmbreportsfromname.SelectedValue.ToString
        'Try

        '    If ReportMode = 14 Then 'Item Wise Report

        '        Me.Text = "Item Wise Stock Balance Report"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where name='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr2 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("code"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 15 Then 'Item Wise Report (minus)

        '        Me.Text = "Item Wise Stock Balance Report (Minus)"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where name='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("name"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 16 Then 'Categary Wise Stock Balance
        '        Me.Text = "Categary Wise Stock Balance"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where catename='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("catecode"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("catename"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 17 Then 'Supplier Wise Stock Balance
        '        Me.Text = "Supplier Wise Stock Balance"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from supplier where name='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("name"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 18 Then 'Stock Summery Balance
        '        Me.Text = "Stock Summery Balance"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where name='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("name"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 11 Then 'Item Wise Stock Valuation
        '        Me.Text = "Item Wise Stock Valuation"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where name='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("name"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 12 Then 'Category Wise Stock Valuation
        '        Me.Text = "Category Wise Stock Valuation"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Category where name='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("name"))
        '        End If
        '        dr3.Close()
        '        cn.Close()


        '    ElseIf ReportMode = 13 Then 'Supplier Wise Stock Valuation
        '        Me.Text = "Supplier Wise Stock Valuation"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from supplier where name='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("name"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 8 Then 'Item Wise Purchasing
        '        Me.Text = "Item Wise Purchasing"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where name='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("code"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 9 Then 'Catagory Wise Purchasing Report
        '        Me.Text = "Catagory Wise Purchasing Report"

        '        connection()
        '        cmd = New Odbc.OdbcCommand("select * from Items where catename='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr = cmd.ExecuteReader
        '        dr.Read()
        '        If dr.HasRows Then
        '            cmbreportsfromname.Text = Trim(dr.Item("catecode"))
        '        End If
        '        dr.Close()
        '        cn.Close()
        '    ElseIf ReportMode = 10 Then 'Supplier Wise Purchasing Report
        '        Me.Text = "Supplier Wise Purchasing Report"

        '        connection()
        '        cmd = New Odbc.OdbcCommand("select * from Items where supname='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr = cmd.ExecuteReader
        '        dr.Read()
        '        If dr.HasRows Then
        '            cmbreportsfromname.Text = Trim(dr.Item("supcode"))
        '        End If
        '        dr.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 1 Then 'Item Wise Sales Report

        '        Me.Text = "Item Wise Sales Report"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where name='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("code"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 2 Then 'Category Wise Sales Report
        '        Me.Text = "Category Wise Sales Report"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where catename='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("catecode"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("catename"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 3 Then 'Supplier Wise Sales Report
        '        Me.Text = "Supplier Wise Sales Report"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where supname='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("supcode"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("supname"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 4 Then 'Sales Summery
        '        Me.Text = "Sales Summery"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where name='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("name"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 5 Then 'Item Wise Gross Profit
        '        Me.Text = "Item Wise Gross Profit"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where name='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("name"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 6 Then 'Category Wise Gross Profit
        '        Me.Text = "Category Wise Gross Profit"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where catename='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("catecode"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("catename"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 7 Then 'Supplier Wise Gross Profit
        '        Me.Text = "Supplier Wise Gross Profit"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where supname='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("supcode"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("supname"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 31 Then 'Item Wise Loss Or Non Profit
        '        Me.Text = "Item Wise Loss Or Non Profit"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where name='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("code"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("name"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 32 Then 'Category Wise Loss Or Non Profit
        '        Me.Text = "Category Wise Loss Or Non Profit"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where catename='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("catecode"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("catename"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 33 Then 'Supplier Wise Loss Or Non Profit
        '        Me.Text = "Supplier Wise Loss Or Non Profit"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where supname='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("supcode"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("supname"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 36 Then 'Fast Moving Item Report
        '        Me.Text = "Fast Moving Item Report"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where Name='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("Code"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("Name"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 37 Then 'Slow Moving Item Report
        '        Me.Text = "Slow Moving Item Report"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where Name='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("Code"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("Name"))
        '        End If
        '        dr3.Close()
        '        cn.Close()

        '    ElseIf ReportMode = 38 Then 'None Moving Item Report
        '        Me.Text = "None Moving Item Report"

        '        connection()
        '        cmd2 = New Odbc.OdbcCommand("select * from Items where Name='" & cmbreportsfromname.Text & "' and loca='" & loca & "'", cn)
        '        dr3 = cmd2.ExecuteReader
        '        dr3.Read()
        '        If dr3.HasRows Then
        '            cmbreportsfromcode.Text = Trim(dr3.Item("Code"))
        '            cmbreportsfromname.Text = Trim(dr3.Item("Name"))
        '        End If
        '        dr3.Close()
        '        cn.Close()
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    'Private Sub ToCode_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbreportstocode.SelectedIndexChanged
    '    Load_recoeds_code()
    'End Sub

    'Private Sub ToDescrip_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbreportstoname.SelectedIndexChanged
    '    Load_records_Name()

    'End Sub

    Private Sub btnreportsdisplay1_Click(sender As Object, e As EventArgs) Handles btnreportsdisplay1.Click
        Try
            If ReportMode = 1 Then 'Item Wise Sales

                Dim dt3 As New DataTable
                Dim cmdR As New OdbcCommand
                connection()
                Try

                    cmdR.CommandText = "select code,name,sum(tquantity)as tquantity,sum(tamount)as tamount from RPT_DepartmentWiseSales where dateshort between '" & Format(dpreports1from.Value, "yyMMdd") & "' and '" & Format(dpreports1to.Value, "yyMMdd") & "'and code between '" + cmbreportsfromname.SelectedValue + "'  and '" + cmbreportstoname.SelectedValue + "' group by code,name"
                    cmdR.Connection = cn
                    Dim adp1 As New OdbcDataAdapter(cmdR)
                    adp1.Fill(dt3)
                    Dim rpt As New ItemWise_sales '//(Item Wise Sale)
                    rpt.Database.Tables("DepartmentWiseSales").SetDataSource(dt3)
                    Report_viewer.CRV.ReportSource = Nothing
                    Report_viewer.CRV.ReportSource = rpt
                    Report_viewer.CRV.Refresh()
                    Report_viewer.CRV.RefreshReport()
                    Report_viewer.Show()
                    cn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in Item wise sale")
                End Try

            ElseIf ReportMode = 2 Then 'Category Wise Sales

                Dim dt3 As New DataTable
                Dim cmdR As New OdbcCommand
                connection()
                Try

                    cmdR.CommandText = "select catecode,catename,sum(tquantity)as tquantity,sum(tamount)as tamount from CatagorywiseSales where dateshort between '" & Format(dpreports1from.Value, "yyMMdd") & "' and '" & Format(dpreports1to.Value, "yyMMdd") & "'and catecode between '" + cmbreportsfromname.SelectedValue + "'  and '" + cmbreportstoname.SelectedValue + "' group by catecode,catename"
                    cmdR.Connection = cn
                    Dim adp1 As New OdbcDataAdapter(cmdR)
                    adp1.Fill(dt3)
                    Dim rpt As New CatagoryWiseSales '//(Category Wise Sale)
                    rpt.Database.Tables("CatagorywiseSales").SetDataSource(dt3)
                    Report_viewer.CRV.ReportSource = Nothing
                    Report_viewer.CRV.ReportSource = rpt
                    Report_viewer.CRV.Refresh()
                    Report_viewer.CRV.RefreshReport()
                    Report_viewer.Show()
                    cn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in Category wise sale")
                End Try

            ElseIf ReportMode = 3 Then 'Supplier Wise Sales

                Dim dt3 As New DataTable
                Dim cmdR As New OdbcCommand
                connection()
                Try

                    cmdR.CommandText = "select supcode,supname,sum(tquantity)as tquantity,sum(tamount)as tamount from SupplierWiseSale where dateshort between '" & Format(dpreports1from.Value, "yyMMdd") & "' and '" & Format(dpreports1to.Value, "yyMMdd") & "'and supcode between '" + cmbreportsfromname.SelectedValue + "'  and '" + cmbreportstoname.SelectedValue + "' group by supcode,supname"
                    cmdR.Connection = cn
                    Dim adp1 As New OdbcDataAdapter(cmdR)
                    adp1.Fill(dt3)
                    Dim rpt As New SupplierWiseReport '//(Department Wise Sale)
                    rpt.Database.Tables("SupplierWiseSale").SetDataSource(dt3)
                    Report_viewer.CRV.ReportSource = Nothing
                    Report_viewer.CRV.ReportSource = rpt
                    Report_viewer.CRV.Refresh()
                    Report_viewer.CRV.RefreshReport()
                    Report_viewer.Show()
                    cn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in SupplierWiseSale")
                End Try

            ElseIf ReportMode = 43 Then 'Department Wise Sales
                Dim dt3 As New DataTable
                Dim cmdR As New OdbcCommand
                connection()
                Try

                    cmdR.CommandText = "select Deptcode,deptname,sum(tquantity)as tquantity,sum(tamount)as tamount from RPT_DepartmentWiseSales where dateshort between '" & Format(dpreports1from.Value, "yyMMdd") & "' and '" & Format(dpreports1to.Value, "yyMMdd") & "'and deptcode between '" + cmbreportsfromname.SelectedValue + "'  and '" + cmbreportstoname.SelectedValue + "' group by deptcode,deptname"
                    cmdR.Connection = cn
                    Dim adp1 As New OdbcDataAdapter(cmdR)
                    adp1.Fill(dt3)
                    Dim rpt As New Dept_wise_sale '//(Department Wise Sale)
                    rpt.Database.Tables("DepartmentWiseSales").SetDataSource(dt3)
                    Report_viewer.CRV.ReportSource = Nothing
                    Report_viewer.CRV.ReportSource = rpt
                    Report_viewer.CRV.Refresh()
                    Report_viewer.CRV.RefreshReport()
                    Report_viewer.Show()
                    cn.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, vbOKOnly + vbInformation, "Error in Department wise sale")
                End Try
            ElseIf ReportMode = 4 Then 'Sales Wise Summery

                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_SalesSummery as select * from Invoice where dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\SalesSummery.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 42 Then 'Sales  Summery Daily Expenses

                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_SalesSummery as select * from Items where dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\SalesSummery.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 5 Then 'Item Wise Gross Profit
                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_ItemWiseGrossProfit as select * from Invoice where code>='" & Trim(cmbreportsfromcode.Text) & "'and code <='" & Trim(cmbreportstocode.Text) & "' and dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                cn.Close()

                connection()
                cmd = New Odbc.OdbcCommand("DELETE from RPT_Header", cn)
                cmd.ExecuteNonQuery()
                cn.Close()

                connection()
                cmd = New Odbc.OdbcCommand("INSERT INTO RPT_Header values('" & "From: " & Format(dpreports1from.Value, "yyyy-MMMM-dd") & " TO: " & Format(dpreports1to.Value, "yyyy-MMMM-dd") & "')", cn)
                cmd.ExecuteNonQuery()

                RPTFile = My.Application.Info.DirectoryPath & "\RPT\ItemWiseGrossProfit.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 6 Then 'Cateogry Wise Gross Profit
                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_CategoryWiseGrossProfit as select * from Invoice where dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\CategoryWiseGrossProfit.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 7 Then 'Supplier Wise Gross Report
                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_SupplierWiseGrossProfit as select * from Invoice where dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\SupplierWiseGrossProfit.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 8 Then 'Item Wise Purchasing
                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_ItemWisePurchasing as select * from Purchase where code>='" & Trim(cmbreportsfromcode.Text) & "' and code<='" & Trim(cmbreportstocode.Text) & "' and dateshort >='" & Format(dpreports2to.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreportsp2from.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\ItemWisePurchasing.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 9 Then 'Category Wise Purchasing
                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_CategoryWisePurchasing as select * from Purchase where  dateshort >='" & Format(dpreports2to.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreportsp2from.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\CategoryWisePurchasing.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 10 Then 'Supplier Wise Purchasing
                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_SupplierWisePurchasing as select * from Purchase where dateshort >='" & Format(dpreports2to.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreportsp2from.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\SupplierWisePurchasing.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 11 Then 'Item Wise Stock Valuation
                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_ItemWiseStockValuation as select * from Items where code>='" & Trim(cmbreportsfromcode.Text) & "'and code <='" & Trim(cmbreportstocode.Text) & "' and dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\ItemWiseStockValuation.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 12 Then 'Category Wise Stock Valuation
                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_CategoryWiseStockValuation as select * from Items where catecode>='" & Trim(cmbreportsfromcode.Text) & "'and catecode <='" & Trim(cmbreportstocode.Text) & "' and dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\CategoryWiseStockValuation.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 13 Then 'Supplier Wise Stock Valuation
                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_SupplierWiseStockValuation as select * from Items where supcode>='" & Trim(cmbreportsfromcode.Text) & "'and supcode <='" & Trim(cmbreportstocode.Text) & "' and dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\SupplierWiseStockValuation.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 14 Then 'Item Wise Stock Balance Report

                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_Itemwisestock as select * from Items where code>='" & Trim(cmbreportsfromcode.Text) & "'and code<='" & Trim(cmbreportstocode.Text) & "' and dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\ItemwiceStock.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 15 Then 'Item Wise Stock Balance Report (minus)
                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_Itemwisestockminus as select * from Items where code>='" & Trim(cmbreportsfromcode.Text) & "'and code<='" & Trim(cmbreportstocode.Text) & "' and dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\ItemwiceStockminus.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 16 Then 'Categary Wise Stock Balance
                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_CategaryWiseStrock as select * from Items where catecode>='" & Trim(cmbreportsfromcode.Text) & "'and catecode<='" & Trim(cmbreportstocode.Text) & "' and dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\CategaryWiseStrock.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 17 Then 'Supplier Wise Stock Balance
                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_SupplierWiseStrock as select * from Items where supcode>='" & Trim(cmbreportsfromcode.Text) & "'and supcode<='" & Trim(cmbreportstocode.Text) & "' and dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\SupplierWiseStrock.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 18 Then 'Stock Balance Summery
                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_StockBalanceSummery as select * from Items where code >='" & Trim(cmbreportsfromcode.Text) & "'and code <='" & Trim(cmbreportstocode.Text) & "' and dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\StockBalanceSummery.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 31 Then 'Item Wise Loss Or Non Profit

                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_ItemWiseLossProfit as select * from Invoice where  profit => 0 and code>='" & Trim(cmbreportsfromcode.Text) & "'and code <='" & Trim(cmbreportstocode.Text) & "' and dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                cn.Close()

                connection()
                cmd = New Odbc.OdbcCommand("DELETE from RPT_Header", cn)
                cmd.ExecuteNonQuery()
                cn.Close()

                connection()
                cmd = New Odbc.OdbcCommand("INSERT INTO RPT_Header values('" & "From: " & Format(dpreports1from.Value, "yyyy-MMMM-dd") & " TO: " & Format(dpreports1to.Value, "yyyy-MMMM-dd") & "')", cn)
                cmd.ExecuteNonQuery()

                RPTFile = My.Application.Info.DirectoryPath & "\RPT\ItemWiseLossProfit.rpt"
                Reportviewer.Show()
                cn.Close()
            ElseIf ReportMode = 32 Then 'Cateogry Wise Loss Or Non Profit

                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_CategoryWiseLossProfit as select * from Invoice where profit => 0 and dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\CategoryWiseLossProfit.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 33 Then 'Supplier Wise Loss Or Non Report

                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_SupplierWiseLossProfit as select * from Invoice where profit => 0 and dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "'", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\SupplierWiseLossProfit.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 34 Then 'Creditors Report

                Me.Cursor = Cursors.WaitCursor
                connection()
                cmd = New OdbcCommand("DELETE RPT_Custcreditsum", cn)
                cmd.ExecuteNonQuery()
                cn.Close()

                connection()
                cmd = New OdbcCommand("select * from Customer order by code", cn)
                dr = cmd.ExecuteReader()
                If dr.HasRows Then
                    While dr.Read

                        Dim SD As Date
                        connection1()
                        cmd2 = New OdbcCommand("select top(1)* from Statement where custcode='" & dr("code") & "' and loca='" & loca & "' order by id ASC", cn1)
                        dr2 = cmd2.ExecuteReader()
                        dr2.Read()
                        If dr2.HasRows Then
                            SD = dr2("date1")
                        End If
                        dr2.Close()
                        cn1.Close()

                        connection1()
                        cmd2 = New OdbcCommand("select top(1)* from Statement where custcode='" & dr("code") & "' and loca='" & loca & "' order by id DESC", cn1)
                        dr2 = cmd2.ExecuteReader()
                        dr2.Read()
                        If dr2.HasRows Then

                            Dim DF As Integer
                            connection2()
                            cmd3 = New OdbcCommand("select top(1)* from Statement where custcode='" & dr("code") & "' and received > '0'  and loca='" & loca & "' order by id DESC", cn2)
                            dr3 = cmd3.ExecuteReader()
                            dr3.Read()
                            If dr3.HasRows Then
                                DF = DateDiff(DateInterval.Day, dr3("Date1"), Now)
                            Else
                                DF = DateDiff(DateInterval.Day, SD, Now)
                            End If
                            dr3.Close()
                            cn2.Close()

                            If dr2("balance") > 0 Then
                                connection2()
                                cmd3 = New OdbcCommand("INSERT INTO RPT_Custcreditsum values('" & dr2("custcode") & "','" & dr2("custname") & "','" & dr("telephone") & "','" & dr2("balance") & "','" & DF & "')", cn2)
                                cmd3.ExecuteNonQuery()
                                cn2.Close()
                            End If

                        End If
                        dr2.Close()
                        cn.Close()

                    End While
                End If
                dr.Close()

                Me.Cursor = Cursors.Default
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\CreditorsReport.rpt"
                Reportviewer.Show()

            ElseIf ReportMode = 36 Then 'Fast Moving Item Report

                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_FastMovingItem as select * from Invoice where Code>='" & Trim(cmbreportsfromcode.Text) & "'and Code <='" & Trim(cmbreportstocode.Text) & "' and dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "' and Quantity > 0", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\FastMovingItem.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 37 Then 'Slow Moving Item Report

                connection()
                cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_SlowMovingItem as select * from Invoice where Code>='" & Trim(cmbreportsfromcode.Text) & "'and Code <='" & Trim(cmbreportstocode.Text) & "' and dateshort >='" & Format(dpreports1from.Value, "yyMMdd") & "' and dateshort <='" & Format(dpreports1to.Value, "yyMMdd") & "' and Quantity > 0", cn)
                cmd.ExecuteNonQuery()
                RPTFile = My.Application.Info.DirectoryPath & "\RPT\SlowMovingItem.rpt"
                Reportviewer.Show()
                cn.Close()

            ElseIf ReportMode = 38 Then 'Non Moving Item Report

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnreportscacel2_Click(sender As Object, e As EventArgs) Handles btnreportscacel2.Click
        Me.Close()
    End Sub

    Private Sub btnreportscancel1_Click(sender As Object, e As EventArgs) Handles btnreportscancel1.Click
        Me.Close()
    End Sub

End Class
