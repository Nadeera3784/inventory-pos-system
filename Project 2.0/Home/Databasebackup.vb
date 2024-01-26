
Imports System.Data.Odbc

Public Class Databasebackup

    Private Sub btncustsave_Click(sender As Object, e As EventArgs) Handles btncustsave.Click
        Try
            connection()
            cmd = New OdbcCommand("BACKUP DATABASE [inventoryPOS] TO  DISK = N'" & My.Application.Info.DirectoryPath & "\Database\Inventory_" & Format(Now, "yyyyMMMMdd_hhmmsstt") & ".BAK' WITH NOFORMAT, NOINIT,  NAME = N'PharmacyPOS-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10", cn)
            cmd.ExecuteNonQuery()
            cn.Close()
            MessageBox.Show("Backup Database Successfully..Done", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox(ex.Message)
            cn.Close()
        End Try
    End Sub
End Class