Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Configuration.Install
Module publicVariable
    ' Public con = New SqlConnection("Data Source=" & Application.StartupPath & "\dbLibrary.mdf")
    'Public con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\dbLibrary.mdf;Integrated Security=True;Connect Timeout=30")
    '   Dim connectionStringReference = ConfigurationManager.ConnectionStrings("ApplicationServies").ConnectionString
    '  Public Con = New SqlConnection(connectionStringReference)
    Public con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\EARL_KALF\Desktop\VB PROJECTS\PCE Library Management System Solution\PCE Library Management System\dbLibrary.mdf;Integrated Security=True;Connect Timeout=30")
End Module
