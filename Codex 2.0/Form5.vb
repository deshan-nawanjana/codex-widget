Public Class Form5

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

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim workarea = My.Computer.Screen.WorkingArea
        Location = New Point(workarea.Width - Me.Width - 30, workarea.height - Me.Height - 71)
        fader.Stop()
        unfader.Start()


        Try
            Me.RichTextBox1.Text = My.Computer.Clipboard.GetText
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Me.RichTextBox1.Text = Me.RichTextBox1.Text.ToUpper
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Me.RichTextBox1.Text = Me.RichTextBox1.Text.ToLower
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            My.Computer.Clipboard.SetText(Me.RichTextBox1.Text)
        Catch ex As Exception

        End Try
        unfader.Stop()
        fader.Start()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        unfader.Stop()
        fader.Start()
    End Sub

    Private Sub Button3_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown, Button3.KeyDown, Button2.KeyDown, Button1.KeyDown
        If e.KeyCode = Keys.Escape Then
            unfader.Stop()
            fader.Start()
        End If
    End Sub

    Private Sub RichTextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles RichTextBox1.KeyDown
        If e.KeyCode = Keys.Escape Then
            unfader.Stop()
            fader.Start()
        End If
    End Sub
End Class