Imports AdvancedSoundBar.Functions
Imports WMPLib, AxWMPLib
Imports System.Runtime.InteropServices

Public Class UserInterface
    Public StatusObj As ToolStripStatusLabel = StatusToolStripLabel
    Public intInputBoxCancel As Integer = StrPtr(String.Empty)
    Public ToolTipCtl As New ToolTip
    Public Sounds As List(Of Sound) = LoadSounds(Application.StartupPath + My.Settings.SoundsXmlPath)

    '' <?34573r_366
    Public e66 As Boolean = False
    '' ?>

    Public Function StrPtr(ByVal obj As Object) As Integer
        Dim Handle As GCHandle = GCHandle.Alloc(obj, GCHandleType.Pinned)
        Dim intReturn As Integer = Handle.AddrOfPinnedObject.ToInt32
        Handle.Free()
        Return intReturn
    End Function

    Private Sub UserInterface_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            '' <?34573r_366
            LoginForm.e4573r_366.Add("bgs01", "Background Sound 01 {06:59}")
            LoginForm.e4573r_366.Add("bgs02", "Background Sound 02 {21:22}")
            LoginForm.e4573r_366.Add("tkn1217", "Techno Song 2012 #17 {07:17}")
            LoginForm.e4573r_366.Add("flutetune", "Flute Tune {02:17}")
            LoginForm.e4573r_366.Add("funnyblue", "Funny Blue (Eifel 65 - Im Blue) {03:55}")
            '' ?>

            Me.Hide()
            Me.Text = My.Settings.ApplicationName
            LockedPanel.Location = New Point(12, 12)
            SoundPlayer.Ctlcontrols.stop()
            LoginForm.Method = LoginMethod.User
            LoginForm.ShowDialog()

            ToolTipCtl.AutoPopDelay = 5000
            ToolTipCtl.InitialDelay = 1000
            ToolTipCtl.ReshowDelay = 500
            ToolTipCtl.ShowAlways = True

            For Each sound As Sound In Sounds
                With SoundsListView.Items.Add(sound.Name)
                    .SubItems.Add(sound.Path)
                    .SubItems.Add(sound.Duration)
                    .SubItems.Add(sound.Category)
                End With
            Next

            Dim ctl As Control
            For Each ctl In Me.Controls
                If ctl.AccessibleDescription <> String.Empty Then
                    ToolTipCtl.SetToolTip(ctl, ctl.AccessibleDescription)
                End If
            Next

            Me.Text = Me.Text + " (v" + Application.ProductVersion + ")"
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub


    Private Sub CloseButton_Click(sender As System.Object, e As System.EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private Sub AdminButton_Click(sender As System.Object, e As System.EventArgs) Handles AdminButton.Click
        LoginForm.Method = LoginMethod.Admin
        LoginForm.ShowDialog()
    End Sub

    Private Sub ChangeUserPasswordButton_Click(sender As System.Object, e As System.EventArgs) Handles ChangeUserPasswordButton.Click
        ChangePassword.ShowDialog()
    End Sub

    Private Sub LockButton_Click(sender As System.Object, e As System.EventArgs) Handles LockButton.Click
        LockedPanel.Show()
        LockedPanel.BringToFront()
        SubmitStatus(Me, StatusToolStripLabel, StatusType.Warning, "Programm gesperrt!")
    End Sub

    Private Sub UnlockButton_Click(sender As System.Object, e As System.EventArgs) Handles UnlockButton.Click
        LoginForm.Method = LoginMethod.Unlock
        LoginForm.ShowDialog()
    End Sub

    Private Sub PlayButton_Click(sender As System.Object, e As System.EventArgs) Handles PlayButton.Click
        SoundPlayer.Ctlcontrols.play()
    End Sub

    Private Sub PauseButton_Click(sender As System.Object, e As System.EventArgs) Handles PauseButton.Click
        SoundPlayer.Ctlcontrols.pause()
    End Sub

    Private Sub StopButton_Click(sender As System.Object, e As System.EventArgs) Handles StopButton.Click
        SoundPlayer.Ctlcontrols.stop()
    End Sub

    Private Sub SoundsListView_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub
End Class
