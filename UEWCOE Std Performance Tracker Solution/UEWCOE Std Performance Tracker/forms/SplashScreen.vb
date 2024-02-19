Public Class SplashScreen
    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        prgBar.Increment(5)
        If prgBar.Value = 100 Then
            ' Me.Hide()
            'MainForm.Show()
            Timer1.Enabled = False
        End If
    End Sub
End Class