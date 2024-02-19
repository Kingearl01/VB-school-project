Module Grade

    Public Sub GetGrade()
        Try
            'convert the credit to integer and assign it to intCreditHrs varieble
            Integer.TryParse(MainForm.cmbCrdHrs.SelectedItem.ToString, intCreditHrs)

            'assign approprite value to the grade
            Select Case MainForm.cmbGrade.SelectedIndex
                Case 0
                    dblGrade = 4.0
                Case 1
                    dblGrade = 3.5
                Case 2
                    dblGrade = 3.0
                Case 3
                    dblGrade = 2.5
                Case 4
                    dblGrade = 2.0
                Case 5
                    dblGrade = 1.5
                Case 6
                    dblGrade = 1.0
                Case 7
                    dblGrade = 0.0
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Module
