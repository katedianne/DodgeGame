Public Class Form1
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If (e.KeyChar = "a") Then
            obs1.Left = obs1.Left - 3
            obs2.Left = obs2.Left - 3
            obs3.Left = obs3.Left - 3
        ElseIf (e.KeyChar = "d") Then
            obs1.Left = obs1.Left + 3
            obs2.Left = obs2.Left + 3
            obs3.Left = obs3.Left + 3
        ElseIf (e.KeyChar = "w") Then
            picplayer.Top = picplayer.Top - 100
        ElseIf (e.KeyChar = "s") Then
            picplayer.Top = picplayer.Top + 100

        End If

        IsDead()
    End Sub


    Private Sub IsDead()
        If picplayer.Left + 100 > picplayer.Left Then
            MessageBox.Show("Dead")
        End If
    End Sub
End Class
