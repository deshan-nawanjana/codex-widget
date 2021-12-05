Public Class Form3

    Private Sub Form3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            unfader.Stop()
            fader.Start()
        End If
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim workarea = My.Computer.Screen.WorkingArea
        Location = New Point(workarea.Width - Me.Width - 30, workarea.height - Me.Height - 71)
        fader.Stop()
        unfader.Start()
        PictureBox4.BackColor = Form1.Label1.BackColor
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

    Private Sub PictureBox2_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseClick
        Dim col As Color = GetColor(PictureBox2, e.X, e.Y)
        Me.PictureBox4.BackColor = col
        Form1.Label1.BackColor = PictureBox4.BackColor
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        Dim col As Color = GetColor(PictureBox2, e.X, e.Y)
        Me.PictureBox3.BackColor = col
    End Sub
    Private Function GetColor(ByVal pic As PictureBox, ByVal X As Integer, ByVal Y As Integer) As Color

        Try
            If pic Is Nothing Then Return Nothing
            Using tmp As New Bitmap(pic.ClientSize.Width, pic.ClientSize.Height)
                Dim r As New Rectangle(0, 0, tmp.Width, tmp.Height)
                Using g As Graphics = Graphics.FromImage(tmp)
                    g.DrawImage(pic.Image, r, r, GraphicsUnit.Pixel)
                End Using
                Return tmp.GetPixel(X, Y)
            End Using
        Catch ex As Exception

        End Try

    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Computer.Clipboard.SetText(l2.Text)
        unfader.Stop()
        fader.Start()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Computer.Clipboard.SetText(l1.Text)
        unfader.Stop()
        fader.Start()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.ColorDialog1.Color = PictureBox4.BackColor
        If Me.ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox4.BackColor = Me.ColorDialog1.Color
        End If
    End Sub

    Private Sub PictureBox4_BackColorChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.BackColorChanged
        Dim v1 = PictureBox4.BackColor.R
        Dim v2 = PictureBox4.BackColor.G
        Dim v3 = PictureBox4.BackColor.B

        l2.Text = "rgba(" & v1 & "," & v2 & "," & v3 & "," & 1 & ")"

        v1 = Hex(v1)
        If v1.ToString.Length = 1 Then : v1 = "0" & v1 : End If
        v2 = Hex(v2)
        If v2.ToString.Length = 1 Then : v2 = "0" & v2 : End If
        v3 = Hex(v3)
        If v3.ToString.Length = 1 Then : v3 = "0" & v3 : End If

        l1.Text = "#" & v1 & v2 & v3



        Try
            My.Computer.Clipboard.SetText(l1.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button3.KeyDown
        If e.KeyCode = Keys.Escape Then
            unfader.Stop()
            fader.Start()
        End If
    End Sub

    Private Sub Button1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button1.KeyDown
        If e.KeyCode = Keys.Escape Then
            unfader.Stop()
            fader.Start()
        End If
    End Sub

    Private Sub Button2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Button2.KeyDown
        If e.KeyCode = Keys.Escape Then
            unfader.Stop()
            fader.Start()
        End If
    End Sub
End Class