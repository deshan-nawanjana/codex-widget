Public Class Form1

    Dim clsp = 0

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If clsp = 0 Then
            e.Cancel = True
        End If

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim workarea = My.Computer.Screen.WorkingArea
        Location = New Point(workarea.Width - Me.Width - 30, workarea.height - Me.Height - 26)



        Try
            Dim fo() As String = IO.Directory.GetDirectories(Application.StartupPath & "\data\")
            For Each file As String In fo
                Dim fx As New IO.DirectoryInfo(file)
                Form2.l1.Items.Add(fx.Name)

                Dim oContextMenu As ContextMenuStrip
                oContextMenu = Me.ContextMenuStrip2
                Dim oNewToolStripItem As New ToolStripMenuItem
                oNewToolStripItem.Text = fx.Name

                Dim fo2() As String = IO.Directory.GetFiles(Application.StartupPath & "\data\" & fx.Name)
                For Each file2 As String In fo2

                    Dim fx2 As New IO.FileInfo(file2)
                    Dim menu2 As New ToolStripMenuItem()
                    menu2.Text = fx2.Name.ToString.Replace(fx2.Extension, "")
                    menu2.Tag = fx.Name
                    AddHandler menu2.Click, AddressOf opnqlrb
                    oNewToolStripItem.DropDownItems.Add(menu2)

                Next
                oContextMenu.Items.Add(oNewToolStripItem)
            Next
        Catch ex As Exception
        End Try

        Dim sp1 As New ToolStripSeparator


    End Sub


    Private Sub opnqlrb(ByVal sender As Object, ByVal e As System.EventArgs)

        Me.Label1.Text = sender.tag
        Me.Button6.Tag = sender.text

        show_cds()
        Form2.LText.Focus()
        Try : Form2.l1.SelectedItem = sender.tag : Catch ex As Exception : End Try
        Try : Form2.l1.SelectedItem = sender.tag : Form2.l2.SelectedItem = sender.text : Catch ex As Exception : End Try

    End Sub

    Private Sub NotifyIcon1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles noti.MouseClick
        Me.Show()
        unfader.Start()
    End Sub

    Private Sub unfade(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button5.MouseMove, Button4.MouseMove, Button3.MouseMove, Button2.MouseMove, Button1.MouseMove
        unfader.Start()
    End Sub

    Private Sub fade(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave, Button4.MouseLeave, Button3.MouseLeave, Button2.MouseLeave, Button1.MouseLeave

        If Button2.Tag = 0 Then
            Exit Sub
        End If
        fadex.Start()
        unfader.Stop()
    End Sub

    Private Sub fadex_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fadex.Tick
        fadex.Stop()
        fader.Start()
    End Sub

    Private Sub fader_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fader.Tick
        fader.Stop()
        If Button2.Tag = 0 Then
            Exit Sub
        End If

        If Me.Opacity < 0.5 Then
        Else
            Me.Opacity -= 0.1
            fader.Start()
        End If
    End Sub

    Private Sub unfader_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unfader.Tick
        unfader.Stop()
        If Me.Opacity < 1 Then
            Me.Opacity += 0.1
            unfader.Start()
        Else

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form3.unfader.Stop() : Form3.fader.Start()
        Form4.unfader.Stop() : Form4.fader.Start()
        Form5.unfader.Stop() : Form5.fader.Start()
        Form6.unfader.Stop() : Form6.fader.Start()
        Form7.unfader.Stop() : Form7.fader.Start()
        Button2.Tag = 0
        Me.Button6.Tag = ""
        Label1.Text = ""
        Form2.Show()
        Form2.Focus()
    End Sub

    Private Sub show_cds()
        Form3.unfader.Stop() : Form3.fader.Start()
        Form4.unfader.Stop() : Form4.fader.Start()
        Form5.unfader.Stop() : Form5.fader.Start()
        Form6.unfader.Stop() : Form6.fader.Start()
        Form7.unfader.Stop() : Form7.fader.Start()
        Button2.Tag = 0
        Form2.Show()
        Form2.Focus()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.unfader.Stop() : Form2.fader.Start()
        Form4.unfader.Stop() : Form4.fader.Start()
        Form5.unfader.Stop() : Form5.fader.Start()
        Form6.unfader.Stop() : Form6.fader.Start()
        Form7.unfader.Stop() : Form7.fader.Start()
        Button2.Tag = 0
        Form3.Show()
        Form3.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form2.unfader.Stop() : Form2.fader.Start()
        Form3.unfader.Stop() : Form3.fader.Start()
        Form5.unfader.Stop() : Form5.fader.Start()
        Form6.unfader.Stop() : Form6.fader.Start()
        Form7.unfader.Stop() : Form7.fader.Start()
        Button2.Tag = 0
        Form4.Show()
        Form4.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form2.unfader.Stop() : Form2.fader.Start()
        Form3.unfader.Stop() : Form3.fader.Start()
        Form4.unfader.Stop() : Form4.fader.Start()
        Form6.unfader.Stop() : Form6.fader.Start()
        Form7.unfader.Stop() : Form7.fader.Start()
        Button2.Tag = 0
        Form5.Show()
        Form5.Focus()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form2.unfader.Stop() : Form2.fader.Start()
        Form3.unfader.Stop() : Form3.fader.Start()
        Form4.unfader.Stop() : Form4.fader.Start()
        Form5.unfader.Stop() : Form5.fader.Start()
        Form7.unfader.Stop() : Form7.fader.Start()
        Button2.Tag = 0
        Form6.Show()
        Form6.Focus()
    End Sub

    Dim ocb = ""
    Private Sub cbchk_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbchk.Tick

        Try
            If Not (ocb = My.Computer.Clipboard.GetText) And Button3.Tag = "1" Then

                ocb = My.Computer.Clipboard.GetText
                Dim n = 0
                Dim ool = 0
                Do While n < ListBox1.Items.Count
                    If (ocb = ListBox1.Items.Item(n)) Then
                        ool = 1
                    End If
                    n += 1
                Loop
                If ool = 0 Then
                    ListBox1.Items.Add(My.Computer.Clipboard.GetText)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        clsp = 1
        Me.Close()
    End Sub

    Private Sub HideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HideToolStripMenuItem.Click
        Form2.unfader.Stop() : Form2.fader.Start()
        Form3.unfader.Stop() : Form3.fader.Start()
        Form4.unfader.Stop() : Form4.fader.Start()
        Form5.unfader.Stop() : Form5.fader.Start()
        Form6.unfader.Stop() : Form6.fader.Start()
        Form7.unfader.Stop() : Form7.fader.Start()
        unfader.Stop()

        ffull.Start()

    End Sub

    Private Sub noti_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles noti.MouseDoubleClick

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        Form2.unfader.Stop() : Form2.fader.Start()
        Form3.unfader.Stop() : Form3.fader.Start()
        Form4.unfader.Stop() : Form4.fader.Start()
        Form5.unfader.Stop() : Form5.fader.Start()
        Form6.unfader.Stop() : Form6.fader.Start()
        Button2.Tag = 0
        Form7.Show()
        Form7.Focus()
    End Sub

    Private Sub lll_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ffull_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ffull.Tick
        ffull.Stop()
        If Me.Opacity > 0 Then
            Me.Opacity -= 0.1
            ffull.Start()
        Else
            Me.Hide()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        System.Diagnostics.Process.Start("https://www.blogger.com/blogger.g?blogID=2965330809333664824#allposts/src=dashboard")

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        System.Diagnostics.Process.Start("https://drive.google.com/")
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        System.Diagnostics.Process.Start("http://www.danstools.com/javascript-obfuscate/")
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        System.Diagnostics.Process.Start("http://www.w3schools.com/")
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Try
            System.Diagnostics.Process.Start("C:\Windows\system32\notepad.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Try
            System.Diagnostics.Process.Start("C:\Program Files (x86)\Microsoft Visual Studio 8\Common7\IDE\vbexpress.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub HTMLToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Try : Form2.l1.SelectedItem = "HTML" : Form2.l2.SelectedIndex = 0 : Catch ex As Exception : End Try
        Me.Label1.Text = "HTML"
        show_cds()
    End Sub

    Private Sub PHPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try : Form2.l1.SelectedItem = "PHP" : Form2.l2.SelectedIndex = 0 : Catch ex As Exception : End Try
        Me.Label1.Text = "PHP"
        show_cds()
    End Sub

    Private Sub JavaScriptToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try : Form2.l1.SelectedItem = "JS" : Form2.l2.SelectedIndex = 0 : Catch ex As Exception : End Try
        Me.Label1.Text = "JS"
        show_cds()
    End Sub

    Private Sub VisualBasicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try : Form2.l1.SelectedItem = "VB" : Form2.l2.SelectedIndex = 0 : Catch ex As Exception : End Try
        Me.Label1.Text = "VB"
        show_cds()
    End Sub

    Private Sub LibrariesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LibrariesToolStripMenuItem.Click
        System.Diagnostics.Process.Start("data\")
    End Sub

    Private Sub PYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try : Form2.l1.SelectedItem = "PY" : Form2.l2.SelectedIndex = 0 : Catch ex As Exception : End Try
        Me.Label1.Text = "PY"
        show_cds()
    End Sub

    Private Sub CSSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try : Form2.l1.SelectedItem = "CSS" : Form2.l2.SelectedIndex = 0 : Catch ex As Exception : End Try
        Me.Label1.Text = "CSS"
        show_cds()
    End Sub
End Class
