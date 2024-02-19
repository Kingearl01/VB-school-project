Option Explicit On
Option Infer Off
Option Strict On

Public Class Level100

    Dim dblGradePoint As Double

    Private Sub Level100_Load(sender As Object, e As EventArgs) Handles Me.Load
        'fill the combobox with credit hrs from 1 to 12
        For intCredit As Integer = 1 To 12
            cmbCrdHrs1.Items.Add(intCredit)
            cmbCrdHrs1.SelectedItem = 3
            cmbCrdHrs2.Items.Add(intCredit)
            cmbCrdHrs2.SelectedItem = 3
            cmbCrdHrs3.Items.Add(intCredit)
            cmbCrdHrs3.SelectedItem = 3
            cmbCrdHrs4.Items.Add(intCredit)
            cmbCrdHrs4.SelectedItem = 3
            cmbCrdHrs5.Items.Add(intCredit)
            cmbCrdHrs5.SelectedItem = 3
            cmbCrdHrs6.Items.Add(intCredit)
            cmbCrdHrs6.SelectedItem = 3
            cmbCrdHrs7.Items.Add(intCredit)
            cmbCrdHrs7.SelectedItem = 3
            cmbCrdHrs8.Items.Add(intCredit)
            cmbCrdHrs8.SelectedItem = 3
        Next

        'fill the grade point combo with grade from A to E

        Dim Grade() As String = {"A", "B+", "B", "C+", "C", "D+", "D", "E"}
        For Each strGrade As String In Grade
            cmbGrade1.Items.Add(strGrade)
            cmbGrade2.Items.Add(strGrade)
            cmbGrade3.Items.Add(strGrade)
            cmbGrade4.Items.Add(strGrade)
            cmbGrade5.Items.Add(strGrade)
            cmbGrade6.Items.Add(strGrade)
            cmbGrade7.Items.Add(strGrade)
            cmbGrade8.Items.Add(strGrade)
        Next

    End Sub

    Private Function GetGrade() As Double
        Dim dblGrade As Double
        'assign value to the grade
        Select Case cmbGrade2.SelectedIndex 'cmbGrade1.SelectedIndex Or
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
        Return dblGrade
    End Function

    Private Sub DisplayGradeP(ByVal dblgrdP As Double)

    End Sub


    Public Function CalculateGradePoint(ByVal intCrdHrs As String,
                                         ByVal dblGrd As Double) As Double
        Dim intCredit As Integer
        Integer.TryParse(intCrdHrs, intCredit)
        'Dim total As Double = GetGrade() * intCredit
        ' intCrdHrs = intCredit.ToString
        Return GetGrade() * intCredit
    End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        dblGradePoint = CalculateGradePoint(cmbCrdHrs1.SelectedItem.ToString, GetGrade)
        lblGradeP1.Text = dblGradePoint.ToString
        dblGradePoint = CalculateGradePoint(cmbCrdHrs2.SelectedItem.ToString, GetGrade)
        lblGradeP2.Text = dblGradePoint.ToString



    End Sub
End Class
