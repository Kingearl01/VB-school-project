'Option Explicit On
'Option Infer Off
'Option Strict On

'import data from the sqlserver
Imports System.ComponentModel
'Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'fill the combo with credits hours from 1 to 12
        For intCreditHr As Integer = 1 To 12
            cmbCrdHrs.Items.Add(intCreditHr)
        Next
        'select the 3 credit hrs
        cmbCrdHrs.SelectedIndex = 2
        'declare an array of Grades
        Dim Grade() As String = {"A", "B+", "B", "C+", "C", "D+", "D", "E"}
        'loop and fill the combo with Grade
        For Each strGrade As String In Grade
            cmbGrade.Items.Add(strGrade)
        Next
        cmbGrade.SelectedItem = "A"

        DisplayResult()
        searchCourse()

    End Sub

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        If cmbGrade.SelectedIndex = -1 Then
            MessageBox.Show("Please Select Grade ", "GPA AND CGPA CALCULATOR",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtCourse.Text = String.Empty Then
            MessageBox.Show("The course title cannot be left empty: Please fill the course tile ", "GPA AND CGPA CALCULATOR",
            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            GetGrade()
            CalculateGPA()
            GetClass()
            insertCourse()
            lblClasses.Text = strClass
            lblComment.Text = strComment
            btnPrint.Enabled = True
        End If
    End Sub

    Private Sub btnNextSem_Click(sender As Object, e As EventArgs) Handles btnNextSem.Click
        'change level and semester
        If intLevel = 400 And intSemester = 2 Then
            MessageBox.Show("Please Your Completed College! Start Over ", "GPA AND CGPA CALCULATOR",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            intLevel = 100
            intSemester = 1
        ElseIf intSemester = 2 Then
            intLevel += 100
            intSemester = 1
        Else
            intSemester += 1
            intLevel = intLevel
        End If
        'display level and sem
        lblLevel.Text = intLevel.ToString
        lblSem.Text = intSemester

        'swicth the text content in the btnNextSem
        If intSemester = 1 Then
            btnNextSem.Text = "&New Semester"
        Else
            btnNextSem.Text = "&New Level"
        End If

        intTCR = 0
        dblTGP = 0

        'display empty
        lblTCR.Text = String.Empty
        lblTGP.Text = String.Empty
        lblSGPA.Text = String.Empty
    End Sub



    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        deleteCourse()
    End Sub

    Public Sub Reset()
        Try
            txtCourse.Text = String.Empty
            cmbCrdHrs.SelectedIndex = 2
            cmbGrade.SelectedIndex = 0
            '  lblGradeP.Text = String.Empty
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        intTCR = 0
        intCCR = 0
        dblTGP = 0
        dblSGPA = 0
        dblCGP = 0
        dblCGPA = 0
        lblTCR.Text = String.Empty
        lblTGP.Text = String.Empty
        lblSGPA.Text = String.Empty
        lblCCR.Text = String.Empty
        lblCGV.Text = String.Empty
        lblCGPA.Text = String.Empty
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Reset()
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        deleetAllCorses()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        resultDGV.DefaultCellStyle.SelectionBackColor = Color.White
        resultDGV.DefaultCellStyle.SelectionForeColor = Color.Black

        GetPrint()
    End Sub

    Private bitmap As Bitmap

    Private Sub GetPrint()
        resultDGV.Height = resultDGV.RowCount * resultDGV.RowTemplate.Height + 50
        bitmap = New Bitmap(Me.resultDGV.Width, Me.resultDGV.Height)
        resultDGV.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.resultDGV.Width, Me.resultDGV.Height))
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        resultDGV.Height = Height
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim printView As RectangleF = e.PageSettings.PrintableArea

        If Me.resultDGV.Height - printView.Height > 0 Then
            e.HasMorePages = True
        End If

    End Sub

    Private Sub llblInstruction_Click(sender As Object, e As EventArgs) Handles llblInstruction.Click
        If grpKey.Visible = True Then
            grpKey.Visible = False
            grpIntruc.Visible = True

        Else
            grpIntruc.Visible = False
            grpKey.Visible = True
        End If
    End Sub



    Private Sub txtCourse_GotFocus(sender As Object, e As EventArgs) Handles txtCourse.GotFocus
        txtCourse.Text = String.Empty
    End Sub

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        deleetAllCorses()
    End Sub
End Class
