Imports System.Data.SqlClient
Public Class Librarian
    Dim key = 0
    Private Sub DisplayLiberians()
        Con.open()
        Dim query = "select * from tblLibrarian"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        LibrriansDGV.DataSource = ds.Tables(0)
        Con.close()
    End Sub

    Private Sub Reset()
        txtLibName.Text = String.Empty
        txtlibPhone.Text = String.Empty
        txtLibPsswd.Text = String.Empty
        'Key=0
    End Sub

    Private Sub Librarians_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplayLiberians()
    End Sub

    Private Sub picExit_Click(sender As Object, e As EventArgs) Handles picExit.Click
        Application.Exit()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtLibName.Text = "" Or txtlibPhone.Text = "" Or txtlibPhone.Text = "" Then
            MsgBox("Missing information")
        Else
            Con.open()
            Dim query = "insert into tblLibrarian Values('" & txtUserName.Text & "','" & txtLibName.Text & "'," & txtlibPhone.Text & ", '" & txtLibPsswd.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Librarian Saved")
            Con.close()
            DisplayLiberians()
            Reset()
        End If
    End Sub

    Private Sub LibrriansDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles LibrriansDGV.CellMouseClick
        Try
            Dim row As DataGridViewRow = LibrriansDGV.Rows(e.RowIndex)

            txtLibName.Text = row.Cells(0).Value.ToString
            txtlibPhone.Text = row.Cells(1).Value
            txtLibPsswd.Text = row.Cells(2).Value.ToString
            txtUserName.Text = row.Cells(3).Value.ToString
            If txtLibName.Text = "" Then
                key = 0
            Else
                key = Convert.ToInt32(row.Cells(0).Value.ToString)
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtLibName.Text = "" Or txtlibPhone.Text = "" Or txtlibPhone.Text = "" Then
            MsgBox("Missing information")
        Else
            Con.open()
            Dim query = "Update tblLibrarian set UserName= '" & txtUserName.Text & "',LibName= '" & txtLibName.Text & "',LibPhone = '" & txtlibPhone.Text & "',LibPassword= '" & txtLibPsswd.Text & "' where UserName = " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Librarian Edited")
            Con.close()
            DisplayLiberians()
            Reset()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If key = 0 Then
            MsgBox("Missing information")
        Else
            Con.open()
            Dim query = "Delete from tblLibrarian where LibId = " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Librarian Deleted")
            Con.close()
            DisplayLiberians()
            Reset()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Dim obj = New Login
        ' obj.Show()
        '  Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
