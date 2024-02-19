
Imports System.Data.SqlClient
Module querydb
    Public Sub DisplayResult()
        Try
            'open the connection
            con.open()
            'create a sql query to display all records in the Student table
            Dim query = "select * from result"
            Dim adapter As SqlDataAdapter
            'execute the command
            Dim cmd = New SqlCommand(query, con)
            adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            MainForm.resultDGV.DataSource = ds.Tables(0)
            con.close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub insertCourse()
        Try
            'save data to the database
            con.open()
            Dim query = "insert into result values('" & MainForm.txtCourse.Text & "'," & MainForm.cmbCrdHrs.SelectedItem.ToString & ",'" & MainForm.cmbGrade.SelectedItem.ToString() & "'," & dblGradePoint & ")"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("New Course Added ", "GPA AND CGPA CALCULATOR",
                        MessageBoxButtons.OK, MessageBoxIcon.Information)

            con.close()
            DisplayResult()
            'enable buttons
            MainForm.btnNextSem.Enabled = True
            MainForm.btnDeleteAll.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub deleteCourse()
        Try
            con.open()
            query = "Delete from result where ID = " & key & ""
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Course deleted")
            con.close()
            DisplayResult()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Sub deleetAllCorses()
        Try
            con.open()
            query = "Delete from result"
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("ALL Course and Inputs deleted")
            con.close()
            DisplayResult()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Reset()

    End Sub

End Module
