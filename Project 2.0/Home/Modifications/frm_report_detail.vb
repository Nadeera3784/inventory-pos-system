Imports CrystalDecisions.CrystalReports.Engine
Imports System.Data.Odbc
Public Class frm_report_detail
    Dim da1 As New OdbcDataAdapter
    Dim ds1 As New DataSet
    Dim da2 As New OdbcDataAdapter
    Dim ds2 As New DataSet
    Dim str1 As String
    Dim RPT_DOC1 As New ReportDocument
    Dim tbl As String
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Dispose()
    End Sub
    Public Sub Items_load()
        Try

            '// From data
            connection()

            If ds2.Tables.Contains("Items") Then
                ds2.Tables.Remove("Items")
            End If

            cmd.CommandText = "select * from Items where loca='" & loca & "' order by code asc"
            cmd.Connection = cn
            da2.SelectCommand = cmd
            da2.Fill(ds2, "Items")
            comCode_from.DataSource = ds2.Tables("Items")
            ComFrom_name.DataSource = ds2.Tables("Items")
            ComFrom_name.DisplayMember = "Name"
            comCode_from.DisplayMember = "Code"
            ComFrom_name.ValueMember = "code"
            ComFrom_name.Text = ""
            comCode_from.Text = ""
            cn.Close()

            '// To data

            connection1()

            If ds1.Tables.Contains("Items") Then
                ds1.Tables.Remove("Items")
            End If

            cmdx.CommandText = "select * from Items where loca='" & loca & "' order by code asc"
            cmdx.Connection = cn1
            da1.SelectCommand = cmdx
            da1.Fill(ds1, "Items")
            Comcode_to.DataSource = ds1.Tables("Items")
            comTo_name.DataSource = ds1.Tables("Items")
            comTo_name.DisplayMember = "name"
            Comcode_to.DisplayMember = "Code"


            cn1.Close()


        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Items Load")
            cn.Close()
            cn1.Close()
        End Try
        '//..............
    End Sub
    Public Sub Catagory_load()
        Try

            '// From data
            connection()

            If ds2.Tables.Contains("Category") Then
                ds2.Tables.Remove("Category")
            End If

            cmd.CommandText = "select * from Category where loca='" & loca & "' order by code asc"
            cmd.Connection = cn
            da2.SelectCommand = cmd
            da2.Fill(ds2, "Category")
            comCode_from.DataSource = ds2.Tables("Category")
            ComFrom_name.DataSource = ds2.Tables("Category")
            ComFrom_name.DisplayMember = "name"
            comCode_from.DisplayMember = "Code"
            ComFrom_name.Text = ""
            comCode_from.Text = ""
            cn.Close()

            '// To data

            connection1()

            If ds1.Tables.Contains("Category") Then
                ds1.Tables.Remove("Category")
            End If

            cmdx.CommandText = "select * from Category where loca='" & loca & "' order by code asc"
            cmdx.Connection = cn1
            da1.SelectCommand = cmdx
            da1.Fill(ds1, "Category")
            Comcode_to.DataSource = ds1.Tables("Category")
            comTo_name.DataSource = ds1.Tables("Category")
            comTo_name.DisplayMember = "name"
            Comcode_to.DisplayMember = "Code"


            cn1.Close()


        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Category Load")
            cn.Close()
            cn1.Close()
        End Try
        '//..............
    End Sub

    Public Sub Department_load()
        Try

            '// From data
            connection()

            If ds2.Tables.Contains("Department") Then
                ds2.Tables.Remove("Department")
            End If

            cmd.CommandText = "select * from Department where loca='" & loca & "' order by dcode asc"
            cmd.Connection = cn
            da2.SelectCommand = cmd
            da2.Fill(ds2, "Department")
            comCode_from.DataSource = ds2.Tables("Department")
            ComFrom_name.DataSource = ds2.Tables("Department")
            ComFrom_name.DisplayMember = "dname"
            comCode_from.DisplayMember = "dcode"
            ComFrom_name.Text = ""
            comCode_from.Text = ""
            cn.Close()

            '// To data

            connection1()

            If ds1.Tables.Contains("Department") Then
                ds1.Tables.Remove("Department")
            End If

            cmdx.CommandText = "select * from Department where loca='" & loca & "' order by dcode asc"
            cmdx.Connection = cn1
            da1.SelectCommand = cmdx
            da1.Fill(ds1, "Department")
            Comcode_to.DataSource = ds1.Tables("Department")
            comTo_name.DataSource = ds1.Tables("Department")
            comTo_name.DisplayMember = "dname"
            Comcode_to.DisplayMember = "dcode"


            cn1.Close()


        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Department Load")
            cn.Close()
            cn1.Close()
        End Try
        '//..............
    End Sub

    Public Sub Supplier_load()
        Try

            '// From data
            connection()

            If ds2.Tables.Contains("Supplier") Then
                ds2.Tables.Remove("Supplier")
            End If

            cmd.CommandText = "select * from Supplier where loca='" & loca & "' order by code asc"
            cmd.Connection = cn
            da2.SelectCommand = cmd
            da2.Fill(ds2, "Supplier")
            comCode_from.DataSource = ds2.Tables("Supplier")
            ComFrom_name.DataSource = ds2.Tables("Supplier")
            ComFrom_name.DisplayMember = "name"
            comCode_from.DisplayMember = "code"
            ComFrom_name.Text = ""
            comCode_from.Text = ""
            cn.Close()

            '// To data

            connection1()

            If ds1.Tables.Contains("Supplier") Then
                ds1.Tables.Remove("Supplier")
            End If

            cmdx.CommandText = "select * from Supplier where loca='" & loca & "' order by code asc"
            cmdx.Connection = cn1
            da1.SelectCommand = cmdx
            da1.Fill(ds1, "Supplier")
            Comcode_to.DataSource = ds1.Tables("Supplier")
            comTo_name.DataSource = ds1.Tables("Supplier")
            comTo_name.DisplayMember = "name"
            Comcode_to.DisplayMember = "code"


            cn1.Close()


        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Supplier Load")
            cn.Close()
            cn1.Close()
        End Try
        '//..............
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click

        If RPTMode = 1 Then '// Item Wise Sales report

            RPT_DOC1 = New ItemWise_sales
            Dim dt3 As New DataTable
            connection()
            Try

                cmd.CommandText = "SELECT * FROM Invoice WHERE loca='" + loca + "' and isdelete='0' and icode>='" + comCode_from.Text.ToString + "' and icode<= '" + Comcode_to.Text.ToString + "' and dateshort between '" + Format(fromdtp.Value, "yyMMdd") + "' and '" + Format(todtp.Value, "yyMMdd") + "'"
                cmd.Connection = cn
                Dim adp1 As New OdbcDataAdapter(cmd)
                adp1.Fill(dt3)
                RPT_DOC1.Database.Tables("Invoice").SetDataSource(dt3)
                Report_viewer.CRV.ReportSource = Nothing
                Report_viewer.CRV.ReportSource = RPT_DOC1
                Report_viewer.CRV.Refresh()
                Report_viewer.CRV.RefreshReport()
                Report_viewer.Show()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbInformation, "Error In Item Wise Sales")
            End Try

        ElseIf RPTMode = 2 Then '// Category Wise Sales Summary report ............................................//

            RPT_DOC1 = New CatagoryWiseSales
            Dim dt3 As New DataTable
            connection()
            Try

                cmd.CommandText = "SELECT * FROM RPT_CategoryWiseSales WHERE loca='" + loca + "' and isdelete='0' and catecode between'" + comCode_from.Text.ToString + "' and '" + Comcode_to.Text.ToString + "' and dateshort between '" + Format(fromdtp.Value, "yyMMdd") + "' and '" + Format(todtp.Value, "yyMMdd") + "'"
                cmd.Connection = cn
                Dim adp1 As New OdbcDataAdapter(cmd)
                adp1.Fill(dt3)
                RPT_DOC1.Database.Tables("RPT_CategoryWiseSales").SetDataSource(dt3)
                Report_viewer.CRV.ReportSource = Nothing
                Report_viewer.CRV.ReportSource = RPT_DOC1
                Report_viewer.CRV.Refresh()
                Report_viewer.CRV.RefreshReport()
                Report_viewer.Show()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbInformation, "Error In Category Wise Sales")
            End Try

        ElseIf RPTMode = 3 Then '// Department Wise sales Summary Report ...........................................//

            RPT_DOC1 = New Dept_wise_sale
            Dim dt3 As New DataTable
            connection()
            Try

                cmd.CommandText = "SELECT * FROM RPT_DepartmentWiseSales WHERE loca='" + loca + "' and isdelete='0' and deptcode between'" + comCode_from.Text.ToString + "' and '" + Comcode_to.Text.ToString + "' and dateshort between '" + Format(fromdtp.Value, "yyMMdd") + "' and '" + Format(todtp.Value, "yyMMdd") + "'"
                cmd.Connection = cn
                Dim adp1 As New OdbcDataAdapter(cmd)
                adp1.Fill(dt3)
                RPT_DOC1.Database.Tables("RPT_DepartmentWiseSales1").SetDataSource(dt3)
                Report_viewer.CRV.ReportSource = Nothing
                Report_viewer.CRV.ReportSource = RPT_DOC1
                Report_viewer.CRV.Refresh()
                Report_viewer.CRV.RefreshReport()
                Report_viewer.Show()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbInformation, "Error In Department Wise Sales")
            End Try

        ElseIf RPTMode = 4 Then '// Supplier Wise Sales Summary Report ..........................................//

            RPT_DOC1 = New SupplierWiseReport
            Dim dt3 As New DataTable
            connection()
            Try

                cmd.CommandText = "SELECT * FROM RPT_SupplierWiseSales WHERE loca='" + loca + "' and isdelete='0' and supcode between'" + comCode_from.Text.ToString + "' and '" + Comcode_to.Text.ToString + "' and dateshort between '" + Format(fromdtp.Value, "yyMMdd") + "' and '" + Format(todtp.Value, "yyMMdd") + "'"
                cmd.Connection = cn
                Dim adp1 As New OdbcDataAdapter(cmd)
                adp1.Fill(dt3)
                RPT_DOC1.Database.Tables("RPT_SupplierWiseSales").SetDataSource(dt3)
                Report_viewer.CRV.ReportSource = Nothing
                Report_viewer.CRV.ReportSource = RPT_DOC1
                Report_viewer.CRV.Refresh()
                Report_viewer.CRV.RefreshReport()
                Report_viewer.Show()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbInformation, "Error In Supplier Wise Sales")
            End Try

        ElseIf RPTMode = 5 Then '// Category Wise Detailed Sales Report ..............................................//

            RPT_DOC1 = New CategoryWiseSalesDetail
            Dim dt3 As New DataTable
            connection()
            Try

                cmd.CommandText = "SELECT * FROM All_IN_ONE_Sale WHERE loca='" + loca + "' and isdelete='0' and catecode between'" + comCode_from.Text.ToString + "' and '" + Comcode_to.Text.ToString + "' and dateshort between '" + Format(fromdtp.Value, "yyMMdd") + "' and '" + Format(todtp.Value, "yyMMdd") + "'"
                cmd.Connection = cn
                Dim adp1 As New OdbcDataAdapter(cmd)
                adp1.Fill(dt3)
                RPT_DOC1.Database.Tables("All_IN_ONE_Sale").SetDataSource(dt3)
                Report_viewer.CRV.ReportSource = Nothing
                Report_viewer.CRV.ReportSource = RPT_DOC1
                Report_viewer.CRV.Refresh()
                Report_viewer.CRV.RefreshReport()
                Report_viewer.Show()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbInformation, "Error In Supplier Wise Sales")
            End Try

        ElseIf RPTMode = 6 Then '// Department Wise Detailed Sales Report ..............................................//

            RPT_DOC1 = New DepartmentWiseSalesDetail
            Dim dt3 As New DataTable
            connection()
            Try

                cmd.CommandText = "SELECT * FROM All_IN_ONE_Sale WHERE loca='" + loca + "' and isdelete='0' and deptcode between'" + comCode_from.Text.ToString + "' and '" + Comcode_to.Text.ToString + "' and dateshort between '" + Format(fromdtp.Value, "yyMMdd") + "' and '" + Format(todtp.Value, "yyMMdd") + "'"
                cmd.Connection = cn
                Dim adp1 As New OdbcDataAdapter(cmd)
                adp1.Fill(dt3)
                RPT_DOC1.Database.Tables("All_IN_ONE_Sale").SetDataSource(dt3)
                Report_viewer.CRV.ReportSource = Nothing
                Report_viewer.CRV.ReportSource = RPT_DOC1
                Report_viewer.CRV.Refresh()
                Report_viewer.CRV.RefreshReport()
                Report_viewer.Show()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbInformation, "Error In Department Wise Sales")
            End Try

        ElseIf RPTMode = 7 Then '// Supplier Wise Detailed Sales Report ..............................................//

            RPT_DOC1 = New SupplierWiseSalesDetail
            Dim dt3 As New DataTable
            connection()
            Try

                cmd.CommandText = "SELECT * FROM All_IN_ONE_Sale WHERE loca='" + loca + "' and isdelete='0' and supcode between'" + comCode_from.Text.ToString + "' and '" + Comcode_to.Text.ToString + "' and dateshort between '" + Format(fromdtp.Value, "yyMMdd") + "' and '" + Format(todtp.Value, "yyMMdd") + "'"
                cmd.Connection = cn
                Dim adp1 As New OdbcDataAdapter(cmd)
                adp1.Fill(dt3)
                RPT_DOC1.Database.Tables("All_IN_ONE_Sale").SetDataSource(dt3)
                Report_viewer.CRV.ReportSource = Nothing
                Report_viewer.CRV.ReportSource = RPT_DOC1
                Report_viewer.CRV.Refresh()
                Report_viewer.CRV.RefreshReport()
                Report_viewer.Show()
                cn.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbInformation, "Error In Supplier Wise Sales")
            End Try

        End If
    End Sub

    Private Sub frm_report_detail_Load(sender As Object, e As EventArgs) Handles Me.Load
        todtp.Value = Today
        fromdtp.Value = Today

    End Sub
End Class