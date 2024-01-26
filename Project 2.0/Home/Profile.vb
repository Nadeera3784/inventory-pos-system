
Imports System.Data.Odbc

Public Class Profile

    Dim IDS As Integer

    Private Sub ClearAllCombo()
        Checkmlogin.Checked = False
        Checkmcategory.Checked = False
        Checkmcustomers.Checked = False
        Checkmsuppiers.Checked = False
        Checkmitems.Checked = False
        Checkminvoice.Checked = False
        Checkmcashier.Checked = False
        Checkmpurchase.Checked = False
        Checkmlocation.Checked = False
        Checkmreturn.Checked = False

        Checkfcashier.Checked = False
        Checkflogin.Checked = False
        Checkflocations.Checked = False
        Checkfuserprofile.Checked = False
        Checkfbanks.Checked = False

        Checkancustomer.Checked = False
        Checkancategory.Checked = False
        Checkansupplier.Checked = False
        Checkanitems.Checked = False

        Checkvcustomer.Checked = False
        Checkvcategory.Checked = False
        Checkvsupplier.Checked = False
        Checkvitems.Checked = False
        Checkvpurchase.Checked = False
        Checkvinvoice.Checked = False
        Checkvreturn.Checked = False

        Checkmexpired.Checked = False
        Checkmoutofstock.Checked = False

        Checksdatabasebackup.Checked = False

        Checkrsalesreports.Checked = False
        Checkrcurrentstock.Checked = False
        Checkrgrossprofit.Checked = False
        Checkrstockvaluation.Checked = False
        Checkrpurchasing.Checked = False
        Checkrpurchase.Checked = False
        Checkrexpired.Checked = False
        Checkrinvoice.Checked = False
        Checkroutofstock.Checked = False
        Checkrtime.Checked = False
        Checkrbanks.Checked = False
        Checkrreturn.Checked = False

        cmbusername.Text = ""
        txtpassword.Text = ""

    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            connection()
            cmd = New OdbcCommand("select * from userprofile where loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader()
            If dr.HasRows Then
                While dr.Read
                    cmbusername.Items.Add(Trim(dr.Item("username")))
                End While
            End If
            dr.Close()
            cn.Close()
            ClearAllCombo()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in User Name")
            dr.Close()
            cn.Close()
        End Try

    End Sub

    Private Sub BtnUpclose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnUpdel_Click(sender As Object, e As EventArgs)

        connection()
        cmd2 = New OdbcCommand("Delete userprofile where ID='" & IDS & "' and loca='" & loca & "'", cn)
        cmd2.ExecuteNonQuery()
        cn.Close()

        ClearAllCombo()
        cmbusername.Focus()
    End Sub

    Private Sub btnuserssave_Click(sender As Object, e As EventArgs) Handles btnuserssave.Click

        Dim ID As Integer
        connection()
        cmd = New OdbcCommand("select max(id) as ID from userprofile where loca='" & loca & "'", cn)
        dr = cmd.ExecuteReader
        While dr.Read
            If Not IsDBNull(dr(0)) Then
                ID = Val(Trim(dr.Item("ID"))) + 1

            Else
                ID = "1"
            End If
        End While
        dr.Close()
        cn.Close()

        Try


            connection()
            cmd2 = New OdbcCommand("INSERT INTO userprofile Values('" & ID & "','" & Trim(cmbusername.Text) & "','" & txtpassword.Text & "','" & Checkmlogin.Checked & "','" & Checkmcustomers.Checked & "','" & Checkmitems.Checked & "','" & Checkmcategory.Checked & "','" & Checkmsuppiers.Checked & "','" & Checkminvoice.Checked & "','" & Checkmpurchase.Checked & "','" & Checkmlocation.Checked & "','" & Checkmcashier.Checked & "','" & Checkmreturn.Checked & "','" & Checkfcashier.Checked & "','" & Checkflogin.Checked & "','" & Checkflocations.Checked & "','" & Checkfuserprofile.Checked & "','" & Checkfbanks.Checked & "','" & Checkancustomer.Checked & "','" & Checkancategory.Checked & "','" & Checkansupplier.Checked & "','" & Checkanitems.Checked & "','" & Checkvcustomer.Checked & "','" & Checkvsupplier.Checked & "','" & Checkvcategory.Checked & "','" & Checkvitems.Checked & "','" & Checkvpurchase.Checked & "','" & Checkvinvoice.Checked & "','" & Checkvreturn.Checked & "','" & Checkmitems.Checked & "','" & Checkmoutofstock.Checked & "','" & Checksdatabasebackup.Checked & "','" & Checkrsalesreports.Checked & "','" & Checkrgrossprofit.Checked & "','" & Checkrcurrentstock.Checked & "','" & Checkrstockvaluation.Checked & "','" & Checkrpurchasing.Checked & "','" & Checkrpurchase.Checked & "','" & Checkrexpired.Checked & "','" & Checkrinvoice.Checked & "','" & Checkroutofstock.Checked & "','" & Checkrtime.Checked & "','" & Checkrbanks.Checked & "','" & Checkrreturn.Checked & "','" & Format(Now, "yyMMdd") & "','" & Format(Now, "yyyy-MMM-dd") & "','" & "191220" & "','" & loca & "','" & comtype.Text & "')", cn)
            cmd2.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Insert User")
        End Try

        ClearAllCombo()
        MessageBox.Show("User Profile Save Successfully..", "", MessageBoxButtons.OK, MessageBoxIcon.Information)


        connection()
        cmbusername.Items.Clear()
        cmd = New OdbcCommand("select * from userprofile where loca='" & loca & "'", cn)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                cmbusername.Items.Add(Trim(dr.Item("username")))
            End While
        End If
        dr.Close()
        cn.Close()
    End Sub

    Private Sub btnusersdelete_Click(sender As Object, e As EventArgs) Handles btnusersdelete.Click

        connection()

        cmd2 = New OdbcCommand("Delete userprofile where ID='" & IDS & "' and loca='" & loca & "'", cn)
        cmd2.ExecuteNonQuery()
        cn.Close()

        ClearAllCombo()
        cmbusername.Focus()
    End Sub

    Private Sub btnusersupdate_Click(sender As Object, e As EventArgs) Handles btnusersupdate.Click

        connection()
        cmd = New OdbcCommand("select * from userprofile where username='" & Trim(cmbusername.Text) & "' and loca='" & loca & "'", cn)
        dr = cmd.ExecuteReader
        Dim df As Boolean = False

        While dr.Read

            If Not IsDBNull(dr(0)) Then
                IDS = dr("id")
                df = True
            End If
        End While
        dr.Close()
        cn.Close()

        If df = True Then
            Try

                connection()
                cmd2 = New OdbcCommand("UPDATE userprofile set username='" & Trim(cmbusername.Text) & "',password='" & txtpassword.Text & "',mlogin='" & Checkmlogin.Checked & "',mcustomer='" & Checkmcustomers.Checked & "',mitems='" & Checkmitems.Checked & "',mcategory='" & Checkmcategory.Checked & "',msupplier='" & Checkmsuppiers.Checked & "',minvoice='" & Checkminvoice.Checked & "',mpurchase='" & Checkmpurchase.Checked & "',mlocation='" & Checkmlocation.Checked & "',mcashier='" & Checkmcashier.Checked & "',mreturn='" & Checkmreturn.Checked & "',fcashier='" & Checkfcashier.Checked & "',flogin='" & Checkflogin.Checked & "',flocations='" & Checkflocations.Checked & "',fuserprofile='" & Checkfuserprofile.Checked & "',fbanks='" & Checkfbanks.Checked & "',ancustomer='" & Checkancustomer.Checked & "',ancategory='" & Checkancategory.Checked & "',ansupplier='" & Checkansupplier.Checked & "',anitems='" & Checkanitems.Checked & "',vcustomer='" & Checkvcustomer.Checked & "',vsupplier='" & Checkvsupplier.Checked & "',vcategory='" & Checkvcategory.Checked & "',vitems='" & Checkvitems.Checked & "',vpurchase='" & Checkvpurchase.Checked & "',vinvoice='" & Checkvinvoice.Checked & "',vreturn='" & Checkvreturn.Checked & "',meexpired='" & Checkmitems.Checked & "',meoutofstock='" & Checkmoutofstock.Checked & "',sdbbackup='" & Checksdatabasebackup.Checked & "',rsales='" & Checkrsalesreports.Checked & "',rgrossprofit='" & Checkrgrossprofit.Checked & "',rcurrent='" & Checkrcurrentstock.Checked & "',rstockvaluation='" & Checkrstockvaluation.Checked & "',rpurchasing='" & Checkrpurchasing.Checked & "',rpurchase='" & Checkrpurchase.Checked & "',rexpired='" & Checkrexpired.Checked & "',rinvoice='" & Checkrinvoice.Checked & "',routofstock='" & Checkroutofstock.Checked & "',rtime='" & Checkrtime.Checked & "',rbanks='" & Checkrbanks.Checked & "',rreturn='" & Checkrreturn.Checked & "' where ID='" & IDS & "' and loca='" & loca & "',type='" + comtype.Text.ToString + "'", cn)
                cmd2.ExecuteNonQuery()
                cn.Close()

                ClearAllCombo()
                MessageBox.Show("User Profile Update Successfully..", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in Update User")
            End Try
        End If

    End Sub

    Private Sub cmbusername_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbusername.SelectedIndexChanged
        Try
            connection()
            cmd = New OdbcCommand("select * from userprofile where username='" & cmbusername.Text & "' and loca='" & loca & "'", cn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                cmbusername.Text = Trim(dr.Item("username"))
                txtpassword.Text = dr.Item("password")
                comtype.Text = dr.Item("type")
            End If
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly + vbCritical, "Error in User Name 1")
            dr.Close()
            cn.Close()
        End Try
    End Sub
End Class