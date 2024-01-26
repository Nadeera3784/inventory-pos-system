
Imports System.Data.Odbc

Public Class Manageitems

    Private Sub Managemediciens_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        txtviewmedicinesearch.Focus()
        txtviewmedicinesearch.SelectAll()

    End Sub

    Private Sub Managemediciens_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load_Records_All()

    End Sub

    Private Sub txtviewmedicinesearch_TextChanged(sender As Object, e As EventArgs) Handles txtviewmedicinesearch.TextChanged
        If txtviewmedicinesearch.Focus Then

            If txtviewmedicinesearch.Text.Length > 0 Then
                Load_Records()
            End If

        End If

    End Sub

    Private Sub btnviewmedicineprint_Click(sender As Object, e As EventArgs) Handles btnviewmedicineprint.Click
        Try


            connection()
            cmd = New Odbc.OdbcCommand("ALTER VIEW RPT_AllItems as select * from Items", cn)
            cmd.ExecuteNonQuery()
            RPTFile = My.Application.Info.DirectoryPath & "\RPT\AllItems.rpt"
            Reportviewer.Show()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Load_Records()
        connection()

        Try
            cmdx.CommandText = "SELECT * FROM Items WHERE name like '%" + txtviewmedicinesearch.Text + "%' or code like '%" + txtviewmedicinesearch.Text + "%'  or barcode like '%" + txtviewmedicinesearch.Text + "%' and loca='" + loca + "'"
            cmdx.Connection = cn
            dr = cmdx.ExecuteReader
            viewmedicinedatagridview.Rows.Clear()

            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    viewmedicinedatagridview.Rows.Add(dr("Code"), dr("Name"), dr("barcode"), dr("sinahalaname"), dr("catecode"), dr("catename"), dr("supcode"), dr("supname"), dr("deptcode"), dr("deptname"), dr("details"), dr("unit"), dr("packsize"), dr("costprice"), dr("sellprice"), dr("ourprice"), dr("profit"), dr("datelong"))
                End If
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Items Load")
            dr.Close()
            cn.Close()
        End Try
    End Sub

    Private Sub Load_Records_All()
        connection()

        Try
            cmdx.CommandText = "SELECT * FROM Items where loca ='" + loca + "'"
            cmdx.Connection = cn
            dr = cmdx.ExecuteReader
            viewmedicinedatagridview.Rows.Clear()

            While dr.Read
                If Not IsDBNull(dr(0)) Then
                    viewmedicinedatagridview.Rows.Add(dr("Code"), dr("Name"), dr("barcode"), dr("sinahalaname"), dr("catecode"), dr("catename"), dr("supcode"), dr("supname"), dr("deptcode"), dr("deptname"), dr("details"), dr("unit"), dr("packsize"), dr("costprice"), dr("sellprice"), dr("ourprice"), dr("profit"), dr("datelong"))
                End If
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in All Items Load")
            dr.Close()
            cn.Close()
        End Try
    End Sub
End Class