Imports System.Data.SqlClient

Module publicVariables
    'declare variables 
    Public strCode As String
    Public strCourse As String
    Public intCreditHrs As Integer
    Public dblGrade As Double
    Public dblGradePoint As Double
    Public dblTGP As Double
    Public intTCR As Integer
    Public dblSGPA As Double
    Public intCCR As Integer
    Public dblCGP As Double
    Public dblCGPA As Double
    Public intLevel As Integer = 100
    Public intSemester As Integer = 1
    Public key = 0

    Public strClass As String
    Public strComment As String

    '' db varables
    'assign sql server connection strin to a variable
    Public con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EARL_KALF\Desktop\VB PROJECTS\UEWCOE Std Performance Tracker Solution\UEWCOE Std Performance Tracker\dbgpa.mdf;Integrated Security=True")
    Public query As String
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter
    Public dt As New DataTable
End Module
