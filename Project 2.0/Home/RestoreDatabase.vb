Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Threading
Public Class RestoreDatabase
    Public conn As SqlConnection
    Public cmd As SqlCommand
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Server As String = String.Empty
        Dim instance As SqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance
        Dim table As System.Data.DataTable = instance.GetDataSources()

        For Each row As System.Data.DataRow In table.Rows
            Server = String.Empty
            Server = row("ServerName")
            'If row("InstanceName").ToString.Length > 0 Then
            'Server = Server & "\" & row("InstanceName")
            'End If 
            cmbServer.Items.Add(Server & "\" & "SQLEXPRESS")
        Next

        'cmbServer.SelectedIndex = 0
        'OpenFileDialog1.Filter = "Backup Files (*.bak)|*bak*.bak"
        OpenFileDialog1.FileName = ""

        P2.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            Label3.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btn_restore_Click(sender As Object, e As EventArgs) Handles btn_restore.Click
        P2.Show()
        Timer1.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try

            Dim rescon As New SqlConnection("Data Source=" & cmbServer.Text & ";Initial Catalog=master;Integrated Security=True")
            Dim resCmd As SqlCommand
            Dim strResSQLsentencia As String = "RESTORE DATABASE " & ComboBox1.Text & " FROM DISK='" & Label3.Text & "'"

            rescon.Open()
            resCmd = New SqlCommand(strResSQLsentencia, rescon)
            resCmd.ExecuteNonQuery()
            rescon.Close()
            Button4.Visible = True
            Label5.Text = "Restore Databse Successfully...Done"
            Timer1.Enabled = False
        Catch ex As Exception
            Label5.Text = ex.Message
            Button4.Visible = True
            Button4.Text = "&Close"
            Timer1.Enabled = False
        End Try
    End Sub
End Class
