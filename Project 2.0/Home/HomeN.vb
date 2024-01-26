Imports CrystalDecisions.CrystalReports.Engine

Imports System.Data.Odbc
Public Class HomeN

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        'Login.MdiParent = Me
        Login.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton8.Click
        Category.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        'RNewcustomer.MdiParent = Me
        Customer.Show()
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click
        'RNewsupplier.MdiParent = Me
        Supplier.Show()
    End Sub

    Private Sub ToolStripButton8_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click
        'Items.MdiParent = Me
        Items.Show()
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click
        'Invoice.MdiParent = Me
        ' Invoice.Show()
        frm_invoice.ShowDialog()
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click
        'RNewpurchase.MdiParent = Me
        Goods_Receive.ShowDialog()
    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        End
    End Sub

    Private Sub HomeN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DigitalClocklbl.Text = TimeOfDay
        Datelbl.Text = Date.Today.ToString("yyyy-MMMM-dd")

        ToolStripButton1.Enabled = False
        'ToolStripButton2.Enabled = False
        ToolStripButton5.Enabled = False
        ToolStripButton6.Enabled = False
        ToolStripButton7.Enabled = False
        ToolStripButton8.Enabled = False
        ToolStripButton9.Enabled = False
        ToolStripButton10.Enabled = False
        ToolStripButton11.Enabled = False
        ToolStripButton12.Enabled = False
        ToolStripButton13.Enabled = False

    End Sub

    Private Sub HomeN_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Loading.ShowDialog()
        MLocation.ShowDialog()

        'user_name = ToolStripStatusLabel1.Text
        'loca = ToolStripStatusLabel2.Text
    End Sub

    Private Sub LocationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LocationfToolStripMenuItem.Click
        AddLocation.Show()
    End Sub

    Private Sub UserProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserProfilefToolStripMenuItem.Click
        Profile.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DigitalClocklbl.Text = TimeOfDay
    End Sub

    Private Sub ItemsMedicineWiseSalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemsMedicineWiseSalesReportToolStripMenuItem.Click
        RPTMode = 1
        frm_report_detail.lbltitle.Text = "Item Wise Sales Report"
        frm_report_detail.Items_load()
        frm_report_detail.ShowDialog()
    End Sub



    Private Sub SupplierWiseSalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierWiseSalesReportToolStripMenuItem.Click
        ReportMode = 3

        Reports.cmbreportstoname.Enabled = True
        Reports.cmbreportsfromname.Enabled = True
        Dim da1 As New OdbcDataAdapter
        Dim ds1 As New DataSet

        Reports.cmbreportstoname.Items.Clear()
        Reports.cmbreportsfromname.Items.Clear()
        connection()
        Try
            If ds1.Tables.Contains("Supplier") Then
                ds1.Tables.Remove("Supplier")
            End If

            cmdx.CommandText = "select name,code from Supplier where loca='" & loca & "' order by code asc"
            cmdx.Connection = cn
            da1.SelectCommand = cmdx
            da1.Fill(ds1, "Supplier")

            Reports.cmbreportstoname.DataSource = ds1.Tables("Supplier")
            Reports.cmbreportstoname.DisplayMember = "name"
            Reports.cmbreportstoname.ValueMember = "code"

            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Supplier")

        End Try
        connection()
        Try
            If ds1.Tables.Contains("Supplier") Then
                ds1.Tables.Remove("Supplier")
            End If

            cmdx.CommandText = "select name,code from Supplier where loca='" & loca & "' order by code asc"
            cmdx.Connection = cn
            da1.SelectCommand = cmdx
            da1.Fill(ds1, "Supplier")
            Reports.cmbreportsfromname.DataSource = ds1.Tables("Supplier")

            Reports.cmbreportsfromname.DisplayMember = "name"
            Reports.cmbreportsfromname.ValueMember = "code"
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Supplier")
            cn.Close()
        End Try
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub SalesReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalesReportToolStripMenuItem1.Click
        RPTMode = 1 '// Sales Summary ......................
        frm_report_sum.lblTitle.Text = "Sales Summary Report"
        frm_report_sum.ShowDialog()
    End Sub

    Private Sub ItemsMedicineWiseGrossProfitReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ReportMode = 5
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub CategoryWiseGrossProfitReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ReportMode = 6
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub ItemsMedicineWiseGrossProfitReportToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        ReportMode = 7
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub ItemWisePurchasingReportToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        ReportMode = 8
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub CatagoryWisePurchasingReportToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        ReportMode = 9
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub SupplierWisePurchasingReportToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        ReportMode = 10
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub ItemWiseStockValuationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemWiseStockValuationToolStripMenuItem.Click
        ReportMode = 11
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub CategoryWiseStockValuationReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoryWiseStockValuationReportToolStripMenuItem.Click
        ReportMode = 12
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub SupplierWiseStockValuationReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierWiseStockValuationReportToolStripMenuItem.Click
        ReportMode = 13
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub ItemWiseStockBalanceReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemWiseStockBalanceReportToolStripMenuItem.Click
        ReportMode = 14
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub ItemWiseStockBalanceMinusReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemWiseStockBalanceMinusReportToolStripMenuItem.Click
        ReportMode = 15
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub CatagoryWiseStockBalanceReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatagoryWiseStockBalanceReportToolStripMenuItem.Click
        ReportMode = 16
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub SupplierWiseStockBalanceReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierWiseStockBalanceReportToolStripMenuItem.Click
        ReportMode = 17
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub StockBalanceSummaryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockBalanceSummaryReportToolStripMenuItem.Click
        ReportMode = 18
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub PurchaseOrderNoteReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ReportMode = 19
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub PurchaseOrderNoteSummeryReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ReportMode = 20
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub InvoiceDetailsReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ReportMode = 21
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub InvoiceDetailsSummeryReportToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        ReportMode = 22
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub ExpiredReportsrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpiredReportsrToolStripMenuItem.Click
        '// Expired Items Report
        Dim dt3 As New DataTable
        Dim RPT_DOC As New ReportDocument
        connection()
        Try
            RPT_DOC = New Expired_Items
            cmd.CommandText = "SELECT * FROM items where expdate <= DATEADD(day,+0,GETDATE())  " ' and loca='" + loca + "'"
            cmd.Connection = cn
            Dim adp1 As New OdbcDataAdapter(cmd)
            adp1.Fill(dt3)
            RPT_DOC.Database.Tables("items").SetDataSource(dt3)
            Report_viewer.CRV.ReportSource = Nothing
            Report_viewer.CRV.ReportSource = RPT_DOC
            Report_viewer.CRV.Refresh()
            Report_viewer.CRV.RefreshReport()
            Report_viewer.Show()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbInformation,)
        End Try

    End Sub

    Private Sub OutOfStockReportsrToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutOfStockReportsrToolStripMenuItem.Click
        '// Out of Report
        Dim dt3 As New DataTable
        Dim RPT_DOC As New ReportDocument
        connection()
        Try
            RPT_DOC = New OutOfStock1
            cmd.CommandText = "SELECT * FROM outofstock where loca='" + loca + "'"
            cmd.Connection = cn
            Dim adp1 As New OdbcDataAdapter(cmd)
            adp1.Fill(dt3)
            RPT_DOC.Database.Tables("OutofStock").SetDataSource(dt3)
            Report_viewer.CRV.ReportSource = Nothing
            Report_viewer.CRV.ReportSource = RPT_DOC
            Report_viewer.CRV.Refresh()
            Report_viewer.CRV.RefreshReport()
            Report_viewer.Show()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbInformation,)
        End Try

    End Sub

    Private Sub YearlyReportsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ReportMode = 25
        'Reports.MdiParent = Me
        Yearlyreports.Show()
    End Sub

    Private Sub CustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomervToolStripMenuItem.Click
        Managecustomers.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuppliervToolStripMenuItem.Click
        Managesupplers.Show()
    End Sub

    Private Sub MedicineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemsvToolStripMenuItem.Click
        Manageitems.Show()
    End Sub

    Private Sub PurchaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PurchasevToolStripMenuItem.Click
        Managepurchase.Show()
    End Sub

    Private Sub InvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoicevToolStripMenuItem.Click
        Manageinvoice.Show()
    End Sub

    Private Sub OutOfStockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutOfStockmToolStripMenuItem.Click
        Outofstock.Show()
    End Sub

    Private Sub ExpiredMedicineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpiredItemsmToolStripMenuItem.Click
        '// Temporary Desabled

        ' MsgBox("This Option Temporary Desabled by System Admin. if You need to Activate this, Please Contact System Admin")
        Expiremediciene.Show()
    End Sub

    Private Sub NewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomeradToolStripMenuItem.Click
        Customer.Show()
    End Sub

    Private Sub NewSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplieranToolStripMenuItem.Click
        Supplier.Show()
    End Sub

    Private Sub NewMedicieneToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemsanToolStripMenuItem.Click
        Items.Show()
    End Sub

    Private Sub DatabaseConfigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DatabaseConfigsToolStripMenuItem.Click
        Databasebackup.Show()
    End Sub

    Private Sub AboutSystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutSystemToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        AddLocation.Show()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Cashier.Show()
    End Sub

    Private Sub CateogryvToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CateogryvToolStripMenuItem.Click
        Managecategory.Show()
    End Sub

    Private Sub BarcodePrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarcodePrintToolStripMenuItem.Click
        Barcodeprint.Show()
    End Sub

    Private Sub BankDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BankDetailsToolStripMenuItem.Click
        Bankdetails.Show()
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        ReturnToSupplier.ShowDialog()
    End Sub

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        Managereturn.Show()
    End Sub

    Private Sub ReturnOrderNoteReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ReportMode = 27
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub ReturnOrderNoteSummeryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ReportMode = 28
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub DailyReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        ReportMode = 23
        'Reports.MdiParent = Me
        Dailyreports.Show()
    End Sub

    Private Sub MonthlyReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        ReportMode = 24
        'Reports.MdiParent = Me
        Monthlyreports.Show()
    End Sub

    Private Sub BankDetailReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BankDetailReportsToolStripMenuItem.Click
        ReportMode = 26
        'Reports.MdiParent = Me
        Bankreports.Show()
    End Sub

    Private Sub LoginfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginfToolStripMenuItem.Click
        Login.Show()
    End Sub

    Private Sub CashierfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashierfToolStripMenuItem.Click
        Cashier.Show()
    End Sub

    Private Sub RestoreDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreDatabaseToolStripMenuItem.Click
        RestoreDatabase.Show()
    End Sub

    Private Sub CreditEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditEntryToolStripMenuItem.Click
        Credit_Entry.Show()
    End Sub

    Private Sub CreditorsReportsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ReportMode = 34
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub DeboutorsReportsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ReportMode = 35
        'Reports.MdiParent = Me
        Reports.Show()
    End Sub

    Private Sub FastItemsSaleReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastItemsSaleReportsToolStripMenuItem.Click
        '// Fast Items Sale

        Dim dt3 As New DataTable
        Dim RPT_DOC As New ReportDocument
        connection()
        Try
            RPT_DOC = New Fast_sale
            cmd.CommandText = "SELECT top(50) icode,iname,qty FROM fast_sale Order by qty desc"
            cmd.Connection = cn
            Dim adp1 As New OdbcDataAdapter(cmd)
            adp1.Fill(dt3)
            RPT_DOC.Database.Tables("Fast_sale").SetDataSource(dt3)
            Report_viewer.CRV.ReportSource = Nothing
            Report_viewer.CRV.ReportSource = RPT_DOC
            Report_viewer.CRV.Refresh()
            Report_viewer.CRV.RefreshReport()
            Report_viewer.Show()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbInformation,)
        End Try
    End Sub

    Private Sub SlowItemsSaleReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SlowItemsSaleReportsToolStripMenuItem.Click
        '// Fast Items Sale

        Dim dt3 As New DataTable
        Dim RPT_DOC As New ReportDocument
        connection()
        Try
            RPT_DOC = New Slow_sale
            cmd.CommandText = "SELECT top(50) icode,iname,qty FROM fast_sale Order by qty asc"
            cmd.Connection = cn
            Dim adp1 As New OdbcDataAdapter(cmd)
            adp1.Fill(dt3)
            RPT_DOC.Database.Tables("Fast_sale").SetDataSource(dt3)
            Report_viewer.CRV.ReportSource = Nothing
            Report_viewer.CRV.ReportSource = RPT_DOC
            Report_viewer.CRV.Refresh()
            Report_viewer.CRV.RefreshReport()
            Report_viewer.Show()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbInformation,)
        End Try
    End Sub

    Private Sub ItemsMedicineWiseLossProfitReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ReportMode = 31
        'Reports.MdiParent = Me
        Lossprofitreports.Show()
    End Sub

    Private Sub CategoryWiseLossProfitReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ReportMode = 32
        'Reports.MdiParent = Me
        Lossprofitreports.Show()
    End Sub

    Private Sub SupplierWiseLossProfitReportToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ReportMode = 33
        'Reports.MdiParent = Me
        Lossprofitreports.Show()
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Department.Show()
    End Sub

    Private Sub DailyExpensesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyExpensesToolStripMenuItem.Click
        Daily_Expenses.Show()

    End Sub

    Private Sub DailyExpensesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyExpensesReportToolStripMenuItem.Click
        ReportMode = 40
        'Reports.MdiParent = Me
        ReportDaily.Show()
    End Sub

    Private Sub SalesSummaryDailyExpensesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesSummaryDailyExpensesToolStripMenuItem.Click

        'Reports.MdiParent = Me
        reportsales.Show()
    End Sub

    Private Sub ToolStripButton3_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Daily_Expenses.Show()
    End Sub

    Private Sub SalesSummaryWithProfitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalesSummaryWithProfitToolStripMenuItem.Click
        reportsales.ShowDialog()
    End Sub

    Private Sub InvoiceGRNReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvoiceGRNReportToolStripMenuItem.Click
        GRN_Report.lblheadertext1.Text = "Invoice GRN Report"
        GRN_Report.dtpfrom.Enabled = False
        GRN_Report.dtpTo.Enabled = False
        GRN_Report.comInvoice.Enabled = True
        GRN_Report.Select_RPT = 1
        GRN_Report.Load_invoice()
        GRN_Report.ShowDialog()
    End Sub

    Private Sub GRNSummaryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GRNSummaryReportToolStripMenuItem.Click
        GRN_Report.lblheadertext1.Text = "GRN Summary Report"
        GRN_Report.comInvoice.Enabled = False
        GRN_Report.dtpfrom.Enabled = True
        GRN_Report.dtpTo.Enabled = True
        GRN_Report.Select_RPT = 2
        GRN_Report.ShowDialog()
    End Sub

    Private Sub SupplierReturnAODToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierReturnAODToolStripMenuItem.Click
        GRN_Report.Text = "Supplier Return"
        GRN_Report.lblheadertext1.Text = "Supplier Return AOD"
        GRN_Report.dtpfrom.Enabled = False
        GRN_Report.dtpTo.Enabled = False
        GRN_Report.comInvoice.Enabled = True
        GRN_Report.lblcomtext.Text = "AOD No"
        GRN_Report.Select_RPT = 3
        GRN_Report.Load_AOD()
        GRN_Report.ShowDialog()

    End Sub

    Private Sub SupplierReturnSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierReturnSummaryToolStripMenuItem.Click
        GRN_Report.Text = "Supplier Return"
        GRN_Report.lblheadertext1.Text = "Supplier Return Summary"
        GRN_Report.dtpfrom.Enabled = True
        GRN_Report.dtpTo.Enabled = True
        GRN_Report.comInvoice.Enabled = False
        GRN_Report.lblcomtext.Text = "AOD No"
        GRN_Report.Select_RPT = 4
        GRN_Report.ShowDialog()
    End Sub

    Private Sub CategoryanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoryanToolStripMenuItem.Click
        Category.ShowDialog()

    End Sub

    Private Sub SummaryReportToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SummaryReportToolStripMenuItem2.Click
        RPTMode = 3 '// Department Wise Sales Summary Report

        frm_report_detail.lbltitle.Text = "Department Wise Sales Summary Report"
        frm_report_detail.Department_load()
        frm_report_detail.ShowDialog()
    End Sub

    Private Sub SummaryReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SummaryReportToolStripMenuItem1.Click
        RPTMode = 2 '// Catagory Wise Sales Summary Report

        frm_report_detail.lbltitle.Text = "Catagory Wise Sales Summary Report"
        frm_report_detail.Catagory_load()
        frm_report_detail.ShowDialog()
    End Sub

    Private Sub SummaryReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SummaryReportToolStripMenuItem.Click
        RPTMode = 4 '// Supplier Wise Sales Summary report

        frm_report_detail.lbltitle.Text = "Catagory Wise Sales Summary Report"
        frm_report_detail.Supplier_load()
        frm_report_detail.ShowDialog()
    End Sub

    Private Sub DetailReportToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DetailReportToolStripMenuItem1.Click
        RPTMode = 5 '// Category Wise Detail Sales report

        frm_report_detail.lbltitle.Text = "Catagory Wise Detail Sales Report"
        frm_report_detail.Catagory_load()
        frm_report_detail.ShowDialog()
    End Sub

    Private Sub DetailReportToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DetailReportToolStripMenuItem2.Click
        RPTMode = 6 '// Department Wise Detail Sales report

        frm_report_detail.lbltitle.Text = "Department Wise Detail Sales Report"
        frm_report_detail.Department_load()
        frm_report_detail.ShowDialog()
    End Sub

    Private Sub DetailReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailReportToolStripMenuItem.Click
        RPTMode = 7 '// Supplier Wise Detail Sales report

        frm_report_detail.lbltitle.Text = "Supplier Wise Detail Sales Report"
        frm_report_detail.Supplier_load()
        frm_report_detail.ShowDialog()

    End Sub

    Private Sub CustomerToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles CustomerToolStripMenuItem.Click
        frm_Statement.ShowDialog()
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        '// Customer

        Dim dt3 As New DataTable
        Dim RPT_DOC As New ReportDocument
        connection()
        Try
            RPT_DOC = New Customers
            cmd.CommandText = "SELECT * from Customer Where loca='" + loca + "'"
            cmd.Connection = cn
            Dim adp1 As New OdbcDataAdapter(cmd)
            adp1.Fill(dt3)
            RPT_DOC.Database.Tables("Customer").SetDataSource(dt3)
            Report_viewer.CRV.ReportSource = Nothing
            Report_viewer.CRV.ReportSource = RPT_DOC
            Report_viewer.CRV.Refresh()
            Report_viewer.CRV.RefreshReport()
            Report_viewer.ShowDialog()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbInformation,)
        End Try


    End Sub
End Class