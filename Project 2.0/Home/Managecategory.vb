
Imports System.Data.Odbc

Public Class Managecategory

    Private Sub LoadRecord()
        connection()
        da = New OdbcDataAdapter("select code as 'Code', name as 'Name',datelong as 'Date',loca as 'Location' from Category", cn)
        dt = New DataTable()
        da.Fill(dt)
        viewcategorydatagridview.DataSource = dt
        viewcategorydatagridview.Refresh()
        viewcategorydatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        viewcategorydatagridview.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        viewcategorydatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        viewcategorydatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        viewcategorydatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        viewcategorydatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        viewcategorydatagridview.Columns(0).Width = 80
        viewcategorydatagridview.Columns(1).Width = 250
        viewcategorydatagridview.Columns(2).Width = 120
        viewcategorydatagridview.Columns(3).Width = 100
        cn.Close()
    End Sub

    Private Sub Managecategory_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtviewcategorysearch.Focus()
        txtviewcategorysearch.SelectAll()
    End Sub

    Private Sub Managecategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecord()
    End Sub

    Private Sub txtviewcategorysearch_TextChanged(sender As Object, e As EventArgs) Handles txtviewcategorysearch.TextChanged
        If txtviewcategorysearch.Focus Then

            If txtviewcategorysearch.Text.Length > 0 Then

                connection()
                da = New OdbcDataAdapter("select code as 'Code', name as 'Name',datelong as 'Date',loca as 'Location' from Category where  name like '%" & txtviewcategorysearch.Text & "%' and loca='" & loca & "'", cn)
                dt = New DataTable()
                da.Fill(dt)
                viewcategorydatagridview.DataSource = dt
                viewcategorydatagridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                viewcategorydatagridview.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                viewcategorydatagridview.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                viewcategorydatagridview.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                viewcategorydatagridview.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                viewcategorydatagridview.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                viewcategorydatagridview.Columns(0).Width = 80
                viewcategorydatagridview.Columns(1).Width = 250
                viewcategorydatagridview.Columns(2).Width = 120
                viewcategorydatagridview.Columns(3).Width = 100
                viewcategorydatagridview.Refresh()

            End If

        End If
        cn.Close()
    End Sub

    Private Sub btnviewcategoryprint_Click(sender As Object, e As EventArgs) Handles btnviewcategoryprint.Click
        connection()
        cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_AllCategory as select * from Category", cn)
        cmd.ExecuteNonQuery()
        RPTFile = My.Application.Info.DirectoryPath & "\RPT\AllCategory.rpt"
        Reportviewer.Show()
        cn.Close()
    End Sub
End Class