Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AutoScroll = False
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                timerright.Enabled = True
                timerleft.Enabled = False
            Case Keys.Left
                timerleft.Enabled = True
                timerright.Enabled = False
        End Select
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                timerright.Enabled = False
            Case Keys.Left
                timerleft.Enabled = False

        End Select
    End Sub

    Private Sub timerright_Tick(sender As Object, e As EventArgs) Handles timerright.Tick
        Dim Objects() As PictureBox = {obs1, obs2, obs3}
        For x = 0 To Objects.Length - 1
            Objects(x).Left -= 3
        Next
    End Sub

    Private Sub timerleft_Tick(sender As Object, e As EventArgs) Handles timerleft.Tick
        Dim Objects() As PictureBox = {obs1, obs2, obs3}
        For x = 0 To Objects.Length - 1
            Objects(x).Left += 3
        Next
    End Sub
End Class
