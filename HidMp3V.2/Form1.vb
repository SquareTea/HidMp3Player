Public Class Form1



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        On Error Resume Next
        OpenFileDialog1.ShowDialog()
        On Error Resume Next
        ListBox1.Items.Add(OpenFileDialog1.FileName)
    End Sub

	Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        On Error Resume Next
        TextBox1.Text = ListBox1.Text
        Timer3.Enabled = True
        If Button7.Text = "RepeatON" Then
            Timer1.Enabled = True
            Timer1.Interval = 100

            Button7.Text = "RepeatON"
        Else
            Timer1.Enabled = False
            Timer1.Interval = 100

            Button7.Text = "RepeatOFF"
        End If

    End Sub

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
		AxWindowsMediaPlayer1.URL = TextBox1.Text
	End Sub



    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        On Error Resume Next
        TrackBar2.Maximum = AxWindowsMediaPlayer1.currentMedia.duration
        pro.Maximum = AxWindowsMediaPlayer1.currentMedia.duration
        pro.Value = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
        TrackBar2.Value = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
        Label1.Text = AxWindowsMediaPlayer1.currentMedia.name & " " & AxWindowsMediaPlayer1.Ctlcontrols.currentPositionString


        If TextBox1.Text = "xexit" Then
            End
        ElseIf TextBox1.Text = "listclear" Then
            ListBox1.Items.Clear()

        End If
    End Sub

    Private Sub pro_Click(sender As Object, e As EventArgs) Handles pro.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error Resume Next
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        If Button7.Text = "RepeatON" Then
            Timer1.Enabled = True
            Timer1.Interval = 100

            Button7.Text = "RepeatON"
        ElseIf Button11.Text = "ShuffleON" Then
            Timer2.Enabled = True
            Timer1.Enabled = False
        Timer1.Interval = 100

        Button7.Text = "RepeatOFF"
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Focus()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        NotifyIcon1.ShowBalloonTip(5000)
        NotifyIcon1.Visible = True
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
            Timer1.Interval = 100

            Button7.Text = "RepeatON"
        Else
            Timer1.Enabled = False
            Timer1.Interval = 100

            Button7.Text = "RepeatOFF"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim inlist1 As Integer



        inlist1 = ListBox1.SelectedIndex
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then

            On Error GoTo ErrorHandler
            ListBox1.SelectedIndex = inlist1 + 1
            On Error GoTo ErrorHandler
            TextBox1.Text = ListBox1.Text

        End If
        Exit Sub
ErrorHandler:
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then


            ListBox1.SelectedIndex = 0
            TextBox1.Text = ListBox1.Text
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim inlist1 As Integer

        If Button11.Text = "ShuffleON" Then
            inlist1 = ListBox1.SelectedIndex
            Dim rnd As New Random
            On Error Resume Next
            Dim randomIndex As Integer = rnd.Next(0, ListBox1.Items.Count - 1)
            TextBox1.Text = ListBox1.Items.Item(randomIndex)
            ListBox1.SelectedIndex = randomIndex
        Else
            inlist1 = ListBox1.SelectedIndex

            ListBox1.SelectedIndex = inlist1 + 1
            TextBox1.Text = ListBox1.Text

        End If
        Exit Sub
ErrorHandler:
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then


            ListBox1.SelectedIndex = 0
            TextBox1.Text = ListBox1.Text
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim inlist1 As Integer



        inlist1 = ListBox1.SelectedIndex

        ListBox1.SelectedIndex = inlist1 - 1
        TextBox1.Text = ListBox1.Text
        AxWindowsMediaPlayer1.Ctlcontrols.play()
        If Button7.Text = "RepeatON" Then
            Timer1.Enabled = True
            Timer1.Interval = 100

            Button7.Text = "RepeatON"
        Else
            Timer1.Enabled = False
            Timer1.Interval = 100

            Button7.Text = "RepeatOFF"
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        AxWindowsMediaPlayer1.settings.volume = TrackBar1.Value
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ShowWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowWindowToolStripMenuItem.Click
        Me.Visible = True
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        Dim inlist1 As Integer



        inlist1 = ListBox1.SelectedIndex

        ListBox1.SelectedIndex = inlist1 + 1
        TextBox1.Text = ListBox1.Text
    End Sub

    Private Sub PauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PauseToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub PreviosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviosToolStripMenuItem.Click
        Dim inlist1 As Integer



        inlist1 = ListBox1.SelectedIndex

        ListBox1.SelectedIndex = inlist1 - 1
        TextBox1.Text = ListBox1.Text
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        On Error Resume Next
        fbd.ShowDialog()
        On Error Resume Next
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(fbd.SelectedPath, FileIO.SearchOption.SearchAllSubDirectories, "*.mp3")
            On Error Resume Next
            ListBox1.Items.Add(foundFile)
        Next

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        On Error Resume Next

        pro.Value = TrackBar2.Value
        On Error Resume Next
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = TrackBar2.Value
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        On Error Resume Next
        If Timer2.Enabled = False Then
            Timer2.Enabled = True
            Button11.Text = "ShuffleON"
            Timer1.Enabled = False
            Button7.Text = "RepeatOFF"

        Else
            On Error Resume Next
            Timer2.Enabled = False
            Button11.Text = "ShuffleOFF"
        End If
    End Sub

    Private Sub Timer2_Tick_1(sender As Object, e As EventArgs) Handles Timer2.Tick
        On Error Resume Next
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsStopped Then
            On Error Resume Next
            Dim rnd As New Random
            On Error Resume Next
            Dim randomIndex As Integer = rnd.Next(0, ListBox1.Items.Count - 1)
            TextBox1.Text = ListBox1.Items.Item(randomIndex)
            ListBox1.SelectedIndex = randomIndex

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class

