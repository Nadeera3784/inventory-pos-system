
Imports System.Data.Odbc

Public Class Managereturn

    Private Sub LoadRecord()

        connection()
        viewreturndatagridview.Rows.Clear()
        Try
            cmdx.CommandText = "SELECT * FROM ReturnAOD WHERE AODNO like '%" + txtviewreturnchasesearch.Text + "%' and loca='" + loca + "'"
            cmdx.Connection = cn
            dr = cmdx.ExecuteReader
            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    viewreturndatagridview.Rows.Add(dr("aodno"), dr("invno"), dr("catname"), dr("icode"), dr("itemname"), dr("invprice"), dr("rqty"), dr("datelong"), dr("returnby"), dr("name"))
                End If
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Data Load")
            dr.Close()
            cn.Close()
        End Try

    End Sub

    Private Sub LoadRecord_All()

        connection()
        viewreturndatagridview.Rows.Clear()
        Try
            cmdx.CommandText = "SELECT * FROM ReturnAOD WHERE loca='" + loca + "'"
            cmdx.Connection = cn
            dr = cmdx.ExecuteReader
            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    viewreturndatagridview.Rows.Add(dr("aodno"), dr("invno"), dr("catname"), dr("icode"), dr("itemname"), dr("invprice"), dr("rqty"), dr("datelong"), dr("returnby"), dr("name"))
                End If
            End While
            dr.Close()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Data Load")
            dr.Close()
            cn.Close()
        End Try

    End Sub

    Private Sub Managereturn_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        txtviewreturnchasesearch.Focus()
        txtviewreturnchasesearch.SelectAll()
    End Sub

    Private Sub Managereturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadRecord_All()

    End Sub

    Private Sub txtviewreturnchasesearch_TextChanged(sender As Object, e As EventArgs) Handles txtviewreturnchasesearch.TextChanged
        If txtviewreturnchasesearch.Focus Then

            If txtviewreturnchasesearch.Text.Length > 0 Then

                LoadRecord()

            End If

        End If

    End Sub

    Private Sub btnreturnview_Click(sender As Object, e As EventArgs) Handles btnreturnview.Click

        connection()
        cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_AllReturn as select * from Purchasereturn", cn)
        cmd.ExecuteNonQuery()
        RPTFile = My.Application.Info.DirectoryPath & "\RPT\AllReturn.rpt"
        Reportviewer.Show()
        cn.Close()
    End Sub
End Class