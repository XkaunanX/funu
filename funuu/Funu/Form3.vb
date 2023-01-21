Public Class Carga
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Text = "CARGANDO..." Then
            Label1.Text = "CARGANDO.."
        ElseIf Label1.Text = "CARGANDO.." Then
            Label1.Text = "CARGANDO..."
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Timer2.Stop()
            Timer1.Stop()
            Funu.Visible = True
            Funu.Show()
            Funu.WindowState = WindowState.Normal
            Me.Close()
        End If
    End Sub

    Private Sub Carga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start()
        Timer1.Start()
    End Sub


End Class