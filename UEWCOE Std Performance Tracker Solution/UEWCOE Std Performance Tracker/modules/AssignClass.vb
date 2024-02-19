Module AssignClass
    Public Sub GetClass()
        'Assign classes
        Select Case True
            Case dblCGPA < 0.99
                strClass = "Fail"
                strComment = "Better Luck next time"
            Case dblCGPA >= 1.0 And dblCGPA <= 1.99
                strClass = "Pass"
                strComment = "Sit up you will get there"
            Case dblCGPA >= 2.0 And dblCGPA <= 2.49
                strClass = "Third Class Upper"
                strComment = "Work hard and be focus"
            Case dblCGPA >= 2.5 And dblCGPA <= 2.99
                strClass = "Second Class Lower"
                strComment = "Put in a little work"
            Case dblCGPA >= 3.0 And dblCGPA <= 3.49
                strClass = "Second Class Upper"
                strComment = "Good Keep it up"
            Case dblCGPA >= 3.5
                strClass = "First Class"
                strComment = "Amazing! Keep it up"
        End Select
    End Sub
End Module
