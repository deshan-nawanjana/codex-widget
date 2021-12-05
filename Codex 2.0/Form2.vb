Public Class Form2

    Private Sub Form2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            unfader.Stop()
            fader.Start()
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            l1.Items.Clear()
            Dim fo() As String = IO.Directory.GetDirectories(Application.StartupPath & "\data\")
            For Each file As String In fo
                Dim fx As New IO.FileInfo(file)
                l1.Items.Add(fx.Name)
            Next
            l1.SelectedItem = Form1.Tag
            l2.SelectedItem = Form1.Button1.Tag

            If Form1.Label1.Text = "" Then
            Else
                l1.SelectedItem = Form1.Label1.Text
            End If
        Catch ex As Exception
        End Try

        Dim workarea = My.Computer.Screen.WorkingArea
        Location = New Point(workarea.Width - Me.Width - 30, workarea.height - Me.Height - 71)
        fader.Stop()
        unfader.Start()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        unfader.Stop()
        fader.Start()
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

    Private Sub l1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            unfader.Stop()
            fader.Start()
        End If
    End Sub


    Private Sub l1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l1.SelectedIndexChanged
        Try
            l2.Items.Clear()
            Form1.Tag = l1.SelectedItem
            Me.LText.Text = ""
            Dim fo() As String = IO.Directory.GetFiles(Application.StartupPath & "\data\" & l1.SelectedItem)
            For Each file As String In fo
                Dim fx As New IO.FileInfo(file)
                l2.Items.Add(fx.Name.ToString.Replace(fx.Extension, ""))
            Next

            If Form1.Label1.Text = "" Then
            Else
                l2.SelectedIndex = 0
                Form1.Label1.Text = ""
            End If



        Catch ex As Exception

        End Try
        If Form1.Button6.Tag = "" Then
            Me.lbt.Text = Me.l1.SelectedItem & " : Programming Libraries"
        Else
            Me.lbt.Text = Me.l1.SelectedItem & " : " & Form1.Button6.Tag
            l2.SelectedItem = Form1.Button6.Tag
            Form1.Button6.Tag = ""
        End If
    End Sub

    Private Sub l2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            unfader.Stop()
            fader.Start()
        End If
    End Sub

    Private Sub l2_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles l2.ControlAdded

    End Sub

    Private Sub l2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l2.SelectedIndexChanged
        Try
            Form1.Button1.Tag = l2.SelectedItem
            Me.LText.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\data\" & l1.SelectedItem & "\" & l2.SelectedItem & ".txt")

            Me.lbt.Text = Me.l1.SelectedItem & " : " & l2.SelectedItem
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            My.Computer.Clipboard.SetText(Me.LText.Text)

        Catch ex As Exception

        End Try
        unfader.Stop()
        fader.Start()
    End Sub

    Private Sub RichTextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            unfader.Stop()
            fader.Start()
        End If
    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub l1_KeyDown_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles l2.KeyDown, l1.KeyDown
        If e.KeyCode = Keys.Escape Then
            unfader.Stop()
            fader.Start()
        End If
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        Try
            My.Computer.Clipboard.SetText(Me.LText.SelectedText)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SearchOnGogoleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchOnGogoleToolStripMenuItem.Click
        Try
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" & Me.LText.SelectedText)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DefaultToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.LText.Font = fs1.Font
        DefaultToolStripMenuItem.Checked = True
        LargeToolStripMenuItem.Checked = False
        VeryLargeToolStripMenuItem.Checked = False
        VeryLargeToolStripMenuItem1.Checked = False
        LText.ZoomFactor = 1
    End Sub

    Private Sub LargeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LargeToolStripMenuItem.Click
        Me.LText.Font = fs2.Font
        DefaultToolStripMenuItem.Checked = False
        LargeToolStripMenuItem.Checked = True
        VeryLargeToolStripMenuItem.Checked = False
        VeryLargeToolStripMenuItem1.Checked = False
        LText.ZoomFactor = 1
    End Sub

    Private Sub VeryLargeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VeryLargeToolStripMenuItem.Click
        Me.LText.Font = fs3.Font
        DefaultToolStripMenuItem.Checked = False
        LargeToolStripMenuItem.Checked = False
        VeryLargeToolStripMenuItem.Checked = True
        VeryLargeToolStripMenuItem1.Checked = False
        LText.ZoomFactor = 1
    End Sub

    Private Sub VeryLargeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VeryLargeToolStripMenuItem1.Click
        Me.LText.Font = fs4.Font
        DefaultToolStripMenuItem.Checked = False
        LargeToolStripMenuItem.Checked = False
        VeryLargeToolStripMenuItem.Checked = False
        VeryLargeToolStripMenuItem1.Checked = True
        LText.ZoomFactor = 1
    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If Me.LText.SelectedText = "" Then
            CopyToolStripMenuItem.Enabled = False
            SearchOnGogoleToolStripMenuItem.Enabled = False
        Else
            CopyToolStripMenuItem.Enabled = True
            SearchOnGogoleToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub WrapTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WrapTextToolStripMenuItem.Click
        If WrapTextToolStripMenuItem.Checked = True Then
            WrapTextToolStripMenuItem.Checked = False
            LText.WordWrap = False
            Exit Sub
        Else
            LText.WordWrap = True
            WrapTextToolStripMenuItem.Checked = True
            Exit Sub
        End If
    End Sub

    Private Sub LText_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LText.KeyDown
        If e.KeyCode = Keys.Escape Then
            unfader.Stop()
            fader.Start()
        End If
    End Sub

    Private Sub LText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LText.TextChanged

    End Sub
End Class