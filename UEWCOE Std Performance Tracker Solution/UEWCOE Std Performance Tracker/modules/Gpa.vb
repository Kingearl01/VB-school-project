Module Gpa
    Public Sub CalculateGPA()
        Try
            calcTCR()
            calcTGP()
            calcGradePoint()
            calcSGPA()
            calcCCR()
            calcCGP()
            calcCGPA()
            'display level and semester
            MainForm.lblLevel.Text = intLevel.ToString
            MainForm.lblSem.Text = intSemester.ToString
            'display cummulative grade point, cummulative credit and cummulative GPA
            MainForm.lblCCR.Text = intCCR.ToString()
            MainForm.lblCGV.Text = dblCGP.ToString("n2")
            MainForm.lblCGPA.Text = dblCGPA.ToString("n2")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function calcTCR()
        'calcuate and display total credit
        intTCR += intCreditHrs
        MainForm.lblTCR.Text = intTCR.ToString()
        Return intTCR
    End Function

    Public Function calcTGP()
        'calcuate and display total grade point
        dblTGP += dblGradePoint
        MainForm.lblTGP.Text = dblTGP.ToString("n2")
        Return dblTGP
    End Function

    Public Function calcGradePoint()
        'calcuate and display grade point
        dblGradePoint = intCreditHrs * dblGrade
        Return dblGradePoint
    End Function

    Public Function calcSGPA()
        'calcuate and display semester grade point
        dblSGPA = dblTGP / intTCR
        MainForm.lblSGPA.Text = dblSGPA.ToString("n2")
        Return dblSGPA
    End Function

    Public Function calcCCR()
        'calcuate cummulative Credit
        intCCR += intCreditHrs
        Return intCCR
    End Function

    Public Function calcCGP()
        'calcuate cummulative total grade point
        dblCGP += dblGradePoint
        Return dblCGP
    End Function

    Public Function calcCGPA()
        'calcuate cummulative semester grade point
        dblCGPA = dblCGP / intCCR
        Return dblCGPA
    End Function
End Module
