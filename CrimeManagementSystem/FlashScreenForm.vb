Public Class FlashScreenForm

    Private Sub FlashScreen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("welcome to CRIME MANAGEMENT SYSTEM")
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Me.ProgressBar1.Value = ProgressBar1.Value + 1
        If ProgressBar1.Value >= 100 Then
            Timer1.Stop()
            LoginForm.Show()
        End If
    End Sub
End Class