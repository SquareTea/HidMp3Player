<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pro = New System.Windows.Forms.ProgressBar()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.fbd = New System.Windows.Forms.FolderBrowserDialog()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pro
        '
        Me.pro.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pro.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.pro.Location = New System.Drawing.Point(12, 172)
        Me.pro.Name = "pro"
        Me.pro.Size = New System.Drawing.Size(380, 10)
        Me.pro.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(2, 28)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(392, 121)
        Me.ListBox1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(179, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 21)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Play"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(221, 188)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 21)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Pause"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "HidMP3 Hide To Tray 2xClick notify icon to show"
        Me.NotifyIcon1.BalloonTipTitle = "HidMP3"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "HidMp3"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.ShowWindowToolStripMenuItem, Me.ToolStripSeparator2, Me.PlayToolStripMenuItem, Me.PauseToolStripMenuItem, Me.StopToolStripMenuItem, Me.PreviosToolStripMenuItem, Me.NextToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem, Me.ToolStripSeparator4})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(151, 182)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(147, 6)
        '
        'ShowWindowToolStripMenuItem
        '
        Me.ShowWindowToolStripMenuItem.Name = "ShowWindowToolStripMenuItem"
        Me.ShowWindowToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ShowWindowToolStripMenuItem.Text = "Show Window"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(147, 6)
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PlayToolStripMenuItem.Text = "Play"
        '
        'PauseToolStripMenuItem
        '
        Me.PauseToolStripMenuItem.Name = "PauseToolStripMenuItem"
        Me.PauseToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PauseToolStripMenuItem.Text = "Pause"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'PreviosToolStripMenuItem
        '
        Me.PreviosToolStripMenuItem.Name = "PreviosToolStripMenuItem"
        Me.PreviosToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PreviosToolStripMenuItem.Text = "Previos"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.NextToolStripMenuItem.Text = "Next"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(147, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(147, 6)
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Timer3
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Multiselect = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(72, 188)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(47, 21)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Stop"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(335, 188)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(59, 21)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "AddFiles"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(116, 188)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(66, 21)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Previos"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(274, 188)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(64, 21)
        Me.Button6.TabIndex = 9
        Me.Button6.Text = "Next"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(0, 188)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(80, 21)
        Me.Button7.TabIndex = 10
        Me.Button7.Text = "RepeatOFF"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(0, 215)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(275, 20)
        Me.TextBox1.TabIndex = 11
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(2, 230)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(275, 30)
        Me.AxWindowsMediaPlayer1.TabIndex = 12
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(4, 1)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(88, 21)
        Me.Button8.TabIndex = 14
        Me.Button8.Text = "Hide To Tray"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(271, 215)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(123, 45)
        Me.TrackBar1.TabIndex = 15
        Me.TrackBar1.Value = 50
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(240, 1)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(72, 21)
        Me.Button9.TabIndex = 16
        Me.Button9.Text = "AddFolder"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'fbd
        '
        Me.fbd.RootFolder = System.Environment.SpecialFolder.MyComputer
        '
        'TrackBar2
        '
        Me.TrackBar2.AutoSize = False
        Me.TrackBar2.Location = New System.Drawing.Point(0, 155)
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(397, 27)
        Me.TrackBar2.TabIndex = 17
        '
        'Button10
        '
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Location = New System.Drawing.Point(87, 1)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(54, 21)
        Me.Button10.TabIndex = 18
        Me.Button10.Text = "Clear"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(309, 1)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(83, 21)
        Me.Button11.TabIndex = 19
        Me.Button11.Text = "ShuffleOFF"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(396, 265)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.pro)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HidMP3"
        Me.TransparencyKey = System.Drawing.Color.DimGray
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pro As ProgressBar
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Button8 As Button
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ShowWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents PlayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PauseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreviosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents Button9 As Button
    Friend WithEvents fbd As FolderBrowserDialog
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Timer2 As Timer
End Class
