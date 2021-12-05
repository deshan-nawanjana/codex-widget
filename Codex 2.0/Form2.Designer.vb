<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.LText = New System.Windows.Forms.RichTextBox
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FontSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DefaultToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VeryLargeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VeryLargeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchOnGogoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WrapTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.l2 = New System.Windows.Forms.ListBox
        Me.l1 = New System.Windows.Forms.ListBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.fs4 = New System.Windows.Forms.Label
        Me.fs3 = New System.Windows.Forms.Label
        Me.fs2 = New System.Windows.Forms.Label
        Me.fs1 = New System.Windows.Forms.Label
        Me.lbt = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.fader = New System.Windows.Forms.Timer(Me.components)
        Me.unfader = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.LText)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(876, 618)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(737, 555)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.TabStop = False
        Me.Button1.Text = "Copy"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LText
        '
        Me.LText.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.LText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LText.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LText.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LText.ForeColor = System.Drawing.Color.White
        Me.LText.Location = New System.Drawing.Point(253, 40)
        Me.LText.Name = "LText"
        Me.LText.ReadOnly = True
        Me.LText.ShortcutsEnabled = False
        Me.LText.ShowSelectionMargin = True
        Me.LText.Size = New System.Drawing.Size(611, 566)
        Me.LText.TabIndex = 8
        Me.LText.TabStop = False
        Me.LText.Text = ""
        Me.LText.WordWrap = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontSizeToolStripMenuItem, Me.CopyToolStripMenuItem, Me.SearchOnGogoleToolStripMenuItem, Me.WrapTextToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(168, 92)
        '
        'FontSizeToolStripMenuItem
        '
        Me.FontSizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefaultToolStripMenuItem, Me.LargeToolStripMenuItem, Me.VeryLargeToolStripMenuItem, Me.VeryLargeToolStripMenuItem1})
        Me.FontSizeToolStripMenuItem.Name = "FontSizeToolStripMenuItem"
        Me.FontSizeToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.FontSizeToolStripMenuItem.Text = "Font Size"
        '
        'DefaultToolStripMenuItem
        '
        Me.DefaultToolStripMenuItem.Name = "DefaultToolStripMenuItem"
        Me.DefaultToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.DefaultToolStripMenuItem.Text = "Small"
        '
        'LargeToolStripMenuItem
        '
        Me.LargeToolStripMenuItem.Checked = True
        Me.LargeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.LargeToolStripMenuItem.Name = "LargeToolStripMenuItem"
        Me.LargeToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.LargeToolStripMenuItem.Text = "Default"
        '
        'VeryLargeToolStripMenuItem
        '
        Me.VeryLargeToolStripMenuItem.Name = "VeryLargeToolStripMenuItem"
        Me.VeryLargeToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.VeryLargeToolStripMenuItem.Text = "Large"
        '
        'VeryLargeToolStripMenuItem1
        '
        Me.VeryLargeToolStripMenuItem1.Name = "VeryLargeToolStripMenuItem1"
        Me.VeryLargeToolStripMenuItem1.Size = New System.Drawing.Size(129, 22)
        Me.VeryLargeToolStripMenuItem1.Text = "Very Large"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'SearchOnGogoleToolStripMenuItem
        '
        Me.SearchOnGogoleToolStripMenuItem.Name = "SearchOnGogoleToolStripMenuItem"
        Me.SearchOnGogoleToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.SearchOnGogoleToolStripMenuItem.Text = "Search on Google"
        '
        'WrapTextToolStripMenuItem
        '
        Me.WrapTextToolStripMenuItem.Name = "WrapTextToolStripMenuItem"
        Me.WrapTextToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.WrapTextToolStripMenuItem.Text = "Word Wrap"
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(253, 606)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(611, 10)
        Me.Panel7.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(253, 30)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(611, 10)
        Me.Panel6.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(243, 30)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(10, 586)
        Me.Panel5.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(864, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 586)
        Me.Panel4.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.l2)
        Me.Panel3.Controls.Add(Me.l1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel3.Size = New System.Drawing.Size(243, 586)
        Me.Panel3.TabIndex = 1
        '
        'l2
        '
        Me.l2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.l2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.l2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.l2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l2.ForeColor = System.Drawing.Color.Gold
        Me.l2.FormattingEnabled = True
        Me.l2.ItemHeight = 18
        Me.l2.Location = New System.Drawing.Point(8, 160)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(227, 414)
        Me.l2.TabIndex = 1
        Me.l2.TabStop = False
        '
        'l1
        '
        Me.l1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.l1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.l1.Dock = System.Windows.Forms.DockStyle.Top
        Me.l1.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.l1.ForeColor = System.Drawing.Color.SpringGreen
        Me.l1.FormattingEnabled = True
        Me.l1.ItemHeight = 19
        Me.l1.Location = New System.Drawing.Point(8, 8)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(227, 152)
        Me.l1.TabIndex = 0
        Me.l1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.fs4)
        Me.Panel2.Controls.Add(Me.fs3)
        Me.Panel2.Controls.Add(Me.fs2)
        Me.Panel2.Controls.Add(Me.fs1)
        Me.Panel2.Controls.Add(Me.lbt)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(874, 30)
        Me.Panel2.TabIndex = 0
        '
        'fs4
        '
        Me.fs4.AutoSize = True
        Me.fs4.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fs4.ForeColor = System.Drawing.Color.White
        Me.fs4.Location = New System.Drawing.Point(622, 5)
        Me.fs4.Name = "fs4"
        Me.fs4.Size = New System.Drawing.Size(70, 22)
        Me.fs4.TabIndex = 11
        Me.fs4.Text = "Label1"
        Me.fs4.Visible = False
        '
        'fs3
        '
        Me.fs3.AutoSize = True
        Me.fs3.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fs3.ForeColor = System.Drawing.Color.White
        Me.fs3.Location = New System.Drawing.Point(539, 7)
        Me.fs3.Name = "fs3"
        Me.fs3.Size = New System.Drawing.Size(63, 19)
        Me.fs3.TabIndex = 10
        Me.fs3.Text = "Label1"
        Me.fs3.Visible = False
        '
        'fs2
        '
        Me.fs2.AutoSize = True
        Me.fs2.Font = New System.Drawing.Font("Consolas", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fs2.ForeColor = System.Drawing.Color.White
        Me.fs2.Location = New System.Drawing.Point(477, 9)
        Me.fs2.Name = "fs2"
        Me.fs2.Size = New System.Drawing.Size(56, 18)
        Me.fs2.TabIndex = 9
        Me.fs2.Text = "Label1"
        Me.fs2.Visible = False
        '
        'fs1
        '
        Me.fs1.AutoSize = True
        Me.fs1.Font = New System.Drawing.Font("Consolas", 9.75!)
        Me.fs1.ForeColor = System.Drawing.Color.White
        Me.fs1.Location = New System.Drawing.Point(422, 9)
        Me.fs1.Name = "fs1"
        Me.fs1.Size = New System.Drawing.Size(49, 15)
        Me.fs1.TabIndex = 8
        Me.fs1.Text = "Label1"
        Me.fs1.Visible = False
        '
        'lbt
        '
        Me.lbt.AutoSize = True
        Me.lbt.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbt.Location = New System.Drawing.Point(5, 6)
        Me.lbt.Name = "lbt"
        Me.lbt.Size = New System.Drawing.Size(288, 19)
        Me.lbt.TabIndex = 1
        Me.lbt.Text = "Codex 2.0 Programming Libraries"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Codex_2._0.My.Resources.Resources.close1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Location = New System.Drawing.Point(844, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'fader
        '
        Me.fader.Interval = 10
        '
        'unfader
        '
        Me.unfader.Interval = 10
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(876, 618)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Opacity = 0
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Tag = "0"
        Me.Text = "Form2"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Indigo
        Me.Panel1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents fader As System.Windows.Forms.Timer
    Friend WithEvents unfader As System.Windows.Forms.Timer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents l1 As System.Windows.Forms.ListBox
    Friend WithEvents l2 As System.Windows.Forms.ListBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lbt As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchOnGogoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontSizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefaultToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LargeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fs3 As System.Windows.Forms.Label
    Friend WithEvents fs2 As System.Windows.Forms.Label
    Friend WithEvents fs1 As System.Windows.Forms.Label
    Friend WithEvents VeryLargeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LText As System.Windows.Forms.RichTextBox
    Friend WithEvents VeryLargeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents fs4 As System.Windows.Forms.Label
    Friend WithEvents WrapTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
