Imports System.Data.SqlClient
Module search
    'Dim conn As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EARL_KALF\Desktop\VB PROJECTS\UEWCOE Std Performance Tracker Solution\UEWCOE Std Performance Tracker\dbgpa.mdf;Integrated Security=True")


    'Dim sql As String

    Public Sub searchCourse()
        Try
            dt = New DataTable
            'opening he connection
            con.Open()
            'holds the data to be executed
            With cmd
                .Connection = con
                .CommandText = "SELECT Title FROM tblCourses"
            End With
            'fill the data in the datatable
            da.SelectCommand = cmd
            da.Fill(dt)
            'set Variable as a row of data in the textbox
            Dim r As DataRow
            'cleaning the autocomplete source of the textbox
            MainForm.txtCourse.AutoCompleteCustomSource.Clear()
            'looping the row of data in the datatable
            For Each r In dt.Rows
                'ADDING THE DATA IN THE AUTO COMPLETE SOURCE 0OF THE TEXTBOX
                MainForm.txtCourse.AutoCompleteCustomSource.Add(r.Item(0).ToString)
            Next
            'closing the connection
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

            da.Dispose()
        End Try


    End Sub
End Module
