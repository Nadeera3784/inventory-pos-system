
Imports System.Data.Odbc

Public Class Managesupplers

    Private Sub LoadRecord()
        connection()
        da = New OdbcDataAdapter("select code as 'Code', name as 'Name',email as 'Email', mobileno as 'Mobile No', faxno as 'Fax',email as 'Email', address as 'Address',datelong as 'Date',loca as 'Location' from Supplier", cn)
        dt = New DataTable()
        da.Fill(dt)
        viewsuppliersdatagridview.DataSource = dt
        viewsuppliersdatagridview.Refresh()
        viewsuppliersdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        viewsuppliersdatagridview.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        viewsuppliersdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        viewsuppliersdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        viewsuppliersdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        viewsuppliersdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        viewsuppliersdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        viewsuppliersdatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        viewsuppliersdatagridview.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        viewsuppliersdatagridview.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        viewsuppliersdatagridview.Columns(0).Width = 60
        viewsuppliersdatagridview.Columns(1).Width = 200
        viewsuppliersdatagridview.Columns(2).Width = 100
        viewsuppliersdatagridview.Columns(3).Width = 100
        viewsuppliersdatagridview.Columns(4).Width = 100
        viewsuppliersdatagridview.Columns(5).Width = 100
        viewsuppliersdatagridview.Columns(6).Width = 100
        viewsuppliersdatagridview.Columns(7).Width = 100
        cn.Close()
    End Sub

    Private Sub Managesupplers_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        txtviewsupplierssearch.Focus()
        txtviewsupplierssearch.SelectAll()

    End Sub

    Private Sub Managesupplers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadRecord()

    End Sub

    Private Sub txtviewsupplierssearch_TextChanged(sender As Object, e As EventArgs) Handles txtviewsupplierssearch.TextChanged
        If txtviewsupplierssearch.Focus Then

            If txtviewsupplierssearch.Text.Length > 0 Then
                connection()
                da = New OdbcDataAdapter("select code as 'Code', name as 'Name',email as 'Email', mobileno as 'Mobile No', faxno as 'Fax',email as 'Email', address as 'Address',datelong as 'Date',loca as 'Location' from Supplier where  name like '%" & txtviewsupplierssearch.Text & "%' and loca='" & loca & "'", cn)
                dt = New DataTable()
                da.Fill(dt)
                viewsuppliersdatagridview.DataSource = dt
                viewsuppliersdatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                viewsuppliersdatagridview.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                viewsuppliersdatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                viewsuppliersdatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                viewsuppliersdatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                viewsuppliersdatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                viewsuppliersdatagridview.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                viewsuppliersdatagridview.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                viewsuppliersdatagridview.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                viewsuppliersdatagridview.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                viewsuppliersdatagridview.Columns(0).Width = 60
                viewsuppliersdatagridview.Columns(1).Width = 200
                viewsuppliersdatagridview.Columns(2).Width = 100
                viewsuppliersdatagridview.Columns(3).Width = 100
                viewsuppliersdatagridview.Columns(4).Width = 100
                viewsuppliersdatagridview.Columns(5).Width = 100
                viewsuppliersdatagridview.Columns(6).Width = 100
                viewsuppliersdatagridview.Columns(7).Width = 100
                viewsuppliersdatagridview.Refresh()

            End If

        End If
        cn.Close()
    End Sub

    Private Sub btnviewsuppliersprint_Click(sender As Object, e As EventArgs) Handles btnviewsuppliersprint.Click
        Try


            connection()
            cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_AllSuppliers as select * from Supplier", cn)
            cmd.ExecuteNonQuery()
            RPTFile = My.Application.Info.DirectoryPath & "\RPT\AllSuppliers.rpt"
            Reportviewer.Show()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class