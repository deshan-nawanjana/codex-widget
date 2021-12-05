Public Class Form6


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
    Private Sub ollod()
        Dim n = Form1.ListBox1.Items.Count - 1
        Me.lstocb.Items.Clear()
        Do While n >= 0
            Me.lstocb.Items.Add(Form1.ListBox1.Items.Item(n))
            n -= 1
        Loop
    End Sub

    Private Sub Form6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            unfader.Stop()
            fader.Start()
        End If
    End Sub


    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ollod()
        Dim workarea = My.Computer.Screen.WorkingArea
        Location = New Point(workarea.Width - Me.Width - 30, workarea.height - Me.Height - 71)
        fader.Stop()
        unfader.Start()
    End Sub

    Private Sub l1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstocb.SelectedIndexChanged
        Try
            rt.Text = lstocb.SelectedItem
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Form1.Button3.Tag = 0
            My.Computer.Clipboard.SetText(rt.Text)
            Form1.Button3.Tag = 1

        Catch ex As Exception

        End Try
        unfader.Stop()
        fader.Start()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        unfader.Stop()
        fader.Start()
    End Sub

    Private Sub llo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles llo.Tick
        If Not Form1.ListBox1.Items.Count = Me.lstocb.Items.Count Then
            ollod()
        End If
    End Sub

    Private Sub lstocb_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rt.KeyDown, lstocb.KeyDown, Button3.KeyDown
        If e.KeyCode = Keys.Escape Then
            unfader.Stop()
            fader.Start()
        End If
    End Sub
End Class