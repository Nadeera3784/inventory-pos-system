
Imports CrystalDecisions.CrystalReports.Engine

Public Class Reportviewer

    Private Sub ReportViwer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cryRpt As New ReportDocument
        cryRpt.Load(RPTFile)
        cryRpt.SetDatabaseLogon(SQLUsername, SQLPassword)
        CrystalReportViewer2.ReportSource = cryRpt
        CrystalReportViewer2.RefreshReport()

        If ReportMode = 1 Then 'Item Wise Sales Report
            Me.Text = "Item Wise Sales Report"
        ElseIf ReportMode = 2 Then 'Catagory Wise Sales Report
            Me.Text = "Catagory Wise Sales Report"
        ElseIf ReportMode = 3 Then 'Supplier Wise Sales Report
            Me.Text = "Supplier Wise Sales Report"
        ElseIf ReportMode = 4 Then 'Sales Summery Report
            Me.Text = "Sales Summery Report"
        ElseIf ReportMode = 5 Then 'Item Wise Gross Profit Report
            Me.Text = "Item Wise Gross Profit Report"
        ElseIf ReportMode = 6 Then 'Category Wise Gross Profit Report
            Me.Text = "Category Wise Gross Profit Report"
        ElseIf ReportMode = 8 Then 'Supplier Wise  Gross Profit Report
            Me.Text = "Supplier Wise  Gross Profit Report"
        ElseIf ReportMode = 8 Then 'Item Wise Purchasing Report
            Me.Text = "Item Wise Purchasing Report"
        ElseIf ReportMode = 9 Then 'Catagory Wise Purchasing Report
            Me.Text = "Catagory Wise Purchasing Report"
        ElseIf ReportMode = 10 Then 'Supplier Wise Purchasing Report
            Me.Text = "Supplier Wise Purchasing Report"
        ElseIf ReportMode = 11 Then 'Item Wise Stock Valuation Report
            Me.Text = "Item Wise Stock Valuation Report"
        ElseIf ReportMode = 12 Then 'Category Wise Stock Valuation Report
            Me.Text = "Category Wise Stock Valuation Report"
        ElseIf ReportMode = 13 Then 'Supplier Wise Stock Valuation Report
            Me.Text = "Supplier Wise Stock Valuation Report"
        ElseIf ReportMode = 14 Then 'Item Wise Stock Balance Report
            Me.Text = "Item Wise Stock Balance Report"
        ElseIf ReportMode = 15 Then 'Item Wise Stock Balance(Minus) Report
            Me.Text = "Item Wise Stock Balance(Minus) Report"
        ElseIf ReportMode = 16 Then 'Catagory Wise Stock Balance Report
            Me.Text = "Catagory Wise Stock Balance Report"
        ElseIf ReportMode = 17 Then 'Supplier Wise Stock Balance Report
            Me.Text = "Supplier Wise Stock Balance Report"
        ElseIf ReportMode = 18 Then 'Stock Balance Summary Report
            Me.Text = "Stock Balance Summary Report"
        ElseIf ReportMode = 19 Then 'Purchase Order Note Report
            Me.Text = "Purchase Order Note Report"
        ElseIf ReportMode = 20 Then 'Purchase Order Note Summery Report
            Me.Text = "Purchase Order Note Summery Report"
        ElseIf ReportMode = 21 Then 'Invoice Details Report
            Me.Text = "Invoice Details Report"
        ElseIf ReportMode = 22 Then 'Invoice Details Summary Report
            Me.Text = "Invoice Details Summary Report"
        ElseIf ReportMode = 23 Then 'Daily Report
            Me.Text = "Daily Report"
        ElseIf ReportMode = 24 Then 'Monthly Report
            Me.Text = "Monthly Report"
        ElseIf ReportMode = 25 Then 'Yearly Report
            Me.Text = "Yearly Report"
        ElseIf ReportMode = 26 Then 'Bank Details Report
            Me.Text = "Bank Details Report"
        ElseIf ReportMode = 27 Then 'Purchase Return Order Note Report
            Me.Text = "Purchase Return Order Note Report"
        ElseIf ReportMode = 28 Then 'Purchase Return Order Note Summery Report
            Me.Text = "Purchase Return Order Note Summery Report"
        ElseIf ReportMode = 29 Then 'Expired Items Report
            Me.Text = "Expired Items Report"
        ElseIf ReportMode = 30 Then 'Out Of Stock Report
            Me.Text = "Out Of Stock Report"
        ElseIf ReportMode = 31 Then 'Items Wise Loss Or Non Profit Report
            Me.Text = "Items Wise Loss Or Non Profit Report"
        ElseIf ReportMode = 32 Then 'Category Wise Loss Or Non Profit Report
            Me.Text = "Category Wise Loss Or Non Profit Report"
        ElseIf ReportMode = 33 Then 'Supplier Wise Loss Or Non Profit Report
            Me.Text = "Supplier Wise Loss Or Non Profit Report"
        ElseIf ReportMode = 34 Then 'Creditors Report
            Me.Text = "Creditors Report"
        ElseIf ReportMode = 35 Then 'Debutors Report
            Me.Text = "Debutors Report"
        ElseIf ReportMode = 36 Then 'Fast Moving Items
            Me.Text = "Fast Moving Items"
        ElseIf ReportMode = 37 Then 'Slow Moving Items
            Me.Text = "Slow Moving Items"
        ElseIf ReportMode = 38 Then 'None Moving Items
            Me.Text = "None Moving Items"
        End If

    End Sub

End Class