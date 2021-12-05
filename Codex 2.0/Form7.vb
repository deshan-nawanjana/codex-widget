Public Class Form7

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim workarea = My.Computer.Screen.WorkingArea
        Location = New Point(workarea.Width - Me.Width - 30, workarea.height - Me.Height - 71)
        fader.Stop()
        unfader.Start()
    End Sub
    Private Sub fader_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fader.Tick
        fader.Stop()
        If Me.Opacity > 0.1 Then
            Me.Opacity -= 0.1
            fader.Start()
        Else
            Form1.Button2.Tag = 1
            Me.Close()
        End If
    End Sub

    Private Sub unfader_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unfader.Tick
        unfader.Stop()
        If Me.Opacity > 1 Then
            Me.Opacity = 1
            fader.Stop()
            unfader.Stop()
        Else
            Me.Opacity += 0.1
            unfader.Start()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        unfader.Stop()
        fader.Start()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Try
            System.Diagnostics.Process.Start("http://dn-w.blogspot.com/")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form7_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            unfader.Stop()
            fader.Start()
        End If
    End Sub
End Class