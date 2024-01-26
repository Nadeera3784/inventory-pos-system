
Imports System.Data.Odbc

Public Class Managecustomers

    Private Sub LoadRecord()
        connection()
        da = New OdbcDataAdapter("select code as 'Code', name as 'Name',email as 'Email', mobile as 'Mobile No', fax as 'Fax', address as 'Address',datelong as 'Date',loca as 'Location' from Customer", cn)
        dt = New DataTable()
        da.Fill(dt)
        viewcustomersdatagrid.DataSource = dt

        viewcustomersdatagrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        viewcustomersdatagrid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        viewcustomersdatagrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        viewcustomersdatagrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        viewcustomersdatagrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        viewcustomersdatagrid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        viewcustomersdatagrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        viewcustomersdatagrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        viewcustomersdatagrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        viewcustomersdatagrid.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        viewcustomersdatagrid.Columns(0).Width = 60
        viewcustomersdatagrid.Columns(1).Width = 200
        viewcustomersdatagrid.Columns(2).Width = 100
        viewcustomersdatagrid.Columns(3).Width = 100
        viewcustomersdatagrid.Columns(4).Width = 100
        viewcustomersdatagrid.Columns(5).Width = 100
        viewcustomersdatagrid.Columns(6).Width = 100
        viewcustomersdatagrid.Columns(7).Width = 100
        cn.Close()
    End Sub

    Private Sub Managecustomers_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        txtviewcustomersearch.Focus()
        txtviewcustomersearch.SelectAll()

    End Sub

    Private Sub Managecustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadRecord()

    End Sub

    Private Sub txtviewcustomersearch_TextChanged(sender As Object, e As EventArgs) Handles txtviewcustomersearch.TextChanged
        

        If txtviewcustomersearch.Focus Then

            If txtviewcustomersearch.Text.Length > 0 Then

                connection()
                da = New OdbcDataAdapter("select code as 'Code', name as 'Name',email as 'Email', mobile as 'Mobile No', fax as 'Fax', address as 'Address',datelong as 'Date',loca as 'Location' from Customer where  name like '%" & txtviewcustomersearch.Text & "%' and loca='" & loca & "'", cn)
                dt = New DataTable()
                da.Fill(dt)
                viewcustomersdatagrid.DataSource = dt
                viewcustomersdatagrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                viewcustomersdatagrid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                viewcustomersdatagrid.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                viewcustomersdatagrid.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                viewcustomersdatagrid.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                viewcustomersdatagrid.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                viewcustomersdatagrid.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                viewcustomersdatagrid.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                viewcustomersdatagrid.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                viewcustomersdatagrid.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                viewcustomersdatagrid.Columns(0).Width = 60
                viewcustomersdatagrid.Columns(1).Width = 200
                viewcustomersdatagrid.Columns(2).Width = 100
                viewcustomersdatagrid.Columns(3).Width = 100
                viewcustomersdatagrid.Columns(4).Width = 100
                viewcustomersdatagrid.Columns(5).Width = 100
                viewcustomersdatagrid.Columns(6).Width = 100
                viewcustomersdatagrid.Columns(7).Width = 100
                viewcustomersdatagrid.Refresh()

           

            End If

        End If
        cn.Close()
    End Sub

    Private Sub btnviewcustomersprint_Click(sender As Object, e As EventArgs) Handles btnviewcustomersprint.Click
        connection()
        cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_AllCustomers as select * from Customer", cn)
        cmd.ExecuteNonQuery()
        RPTFile = My.Application.Info.DirectoryPath & "\RPT\AllCustomer.rpt"
        Reportviewer.Show()
        cn.Close()
    End Sub
End Class