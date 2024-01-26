
Imports System.Data.Odbc
Imports CrystalDecisions.CrystalReports.Engine

Module Module1

    Public cmdx As New OdbcCommand
    Public cmd As New OdbcCommand
    Public cmd2 As OdbcCommand
    Public cmd3 As OdbcCommand
    Public cmd4 As OdbcCommand
    Public cmd5 As OdbcCommand
    Public cmd6 As OdbcCommand
    Public cmd7 As OdbcCommand
    Public cmd8 As OdbcCommand
    Public ds As New DataSet
    Public dt As New DataTable
    Public dr As OdbcDataReader
    Public dr2 As OdbcDataReader
    Public dr3 As OdbcDataReader
    Public dr4 As OdbcDataReader
    Public dr5 As OdbcDataReader
    Public dr6 As OdbcDataReader
    Public dr7 As OdbcDataReader
    Public dr8 As OdbcDataReader
    Public da As OdbcDataAdapter
    Public loca As String
    Public cmdSelect, cmdDelete As String
    Public username As String
    Public SQLUsername, SQLPassword, RPTFile As String
    Public ReportMode As Integer
    Public cn As New OdbcConnection
    Public cn1 As New OdbcConnection
    Public cn2 As New OdbcConnection
    Public cn3 As New OdbcConnection
    Public RPTObject As New ReportDocument
    Public RPTMode As String
    Public Store_name As String = "Bopagama Super"
    Dim str As String = "dsn=INTDB;uid=sa;pwd=sahan;"



    Public Sub connection()
        If cn.State = ConnectionState.Closed Then
            cn.ConnectionString = str
            cn.Open()
        End If

    End Sub
    Public Sub connection1()
        If cn1.State = ConnectionState.Closed Then
            cn1.ConnectionString = str
            cn1.Open()
        End If

    End Sub

    Public Sub connection2()
        If cn2.State = ConnectionState.Closed Then
            cn2.ConnectionString = str
            cn2.Open()
        End If

    End Sub
    Public Sub connection3()
        If cn3.State = ConnectionState.Closed Then
            cn3.ConnectionString = str
            cn3.Open()
        End If

    End Sub

    Sub Main()
        Try
            SQLUsername = "Sa"
            SQLPassword = "sahan"
            HomeN.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Module
