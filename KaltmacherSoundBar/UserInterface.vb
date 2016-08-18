Imports AdvancedSoundBar.Functions, AdvancedSoundBar.Enumerations

Public Class UserInterface
    Public StatusObj As ToolStripStatusLabel = StatusToolStripLabel
    Public intInputBoxCancel As Integer = StrPtr(String.Empty)
    Public ToolTipCtl As New ToolTip
    Public IsItemSelected As Boolean = False

    '' <?34573r_366
    Public e66 As Boolean = False
    '' ?>

    Public Function StrPtr(ByVal obj As Object) As Integer
        Dim Handle As System.Runtime.InteropServices.GCHandle = System.Runtime.InteropServices.GCHandle.Alloc(obj, System.Runtime.InteropServices.GCHandleType.Pinned)
        Dim intReturn As Integer = Handle.AddrOfPinnedObject.ToInt32
        Handle.Free()
        Return intReturn
    End Function

    Public Sub refreshSoundsListView()
        SoundsListView.Groups.Clear()
        SoundsListView.Items.Clear()

        Dim Groups As New Dictionary(Of String, ListViewGroup)
        For Each cItem As Category In Categories
            Groups.Add(cItem.Name, New ListViewGroup(cItem.Name, cItem.Name))
            SoundsListView.Groups.Add(Groups(cItem.Name))
        Next

        For Each sound As Sound In Sounds
            Dim newListViewItem As New ListViewItem
            Dim relPath As String = "..." + My.Settings.SoundsPath + "\" + Split(sound.Path, "\").Last
            With newListViewItem
                .Text = sound.Name
                If Groups.Keys.Contains(sound.Category) Then : .Group = Groups(sound.Category) : Else
                    .Group = New ListViewGroup("Unkategorisiert") : End If
                .SubItems.Add(sound.Duration)
                .SubItems.Add(relPath)
            End With
            SoundsListView.Items.Add(newListViewItem)
        Next
    End Sub

    Private Sub UserInterface_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            initialize(Application.StartupPath + My.Settings.SoundsXmlPath, Application.StartupPath + My.Settings.CategoriesXmlPath)

            For Each Sound As Sound In Sounds
                MsgBox(Sound.Name + " -- " + CStr(Sound.GetIndex))
            Next

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

            refreshSoundsListView()

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
        Try
            Application.Exit()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub AdminButton_Click(sender As System.Object, e As System.EventArgs) Handles AdminButton.Click
        Try
            LoginForm.Method = LoginMethod.Admin
            LoginForm.ShowDialog()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub ChangeUserPasswordButton_Click(sender As System.Object, e As System.EventArgs) Handles ChangeUserPasswordButton.Click
        Try
            ChangePassword.ShowDialog()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub LockButton_Click(sender As System.Object, e As System.EventArgs) Handles LockButton.Click
        Try
            LockedPanel.Show()
            LockedPanel.BringToFront()
            SubmitStatus(Me, StatusToolStripLabel, StatusType.Warning, "Programm gesperrt!")
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub UnlockButton_Click(sender As System.Object, e As System.EventArgs) Handles UnlockButton.Click
        Try
            LoginForm.Method = LoginMethod.Unlock
            LoginForm.ShowDialog()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub PlayButton_Click(sender As System.Object, e As System.EventArgs) Handles PlayButton.Click
        Try
            If IsItemSelected Then : SoundPlayer.Ctlcontrols.play() : End If
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub PauseButton_Click(sender As System.Object, e As System.EventArgs) Handles PauseButton.Click
        Try
            If IsItemSelected Then : SoundPlayer.Ctlcontrols.pause() : End If
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub StopButton_Click(sender As System.Object, e As System.EventArgs) Handles StopButton.Click
        Try
            If IsItemSelected Then : SoundPlayer.Ctlcontrols.stop() : End If
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub SoundsListView_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles SoundsListView.SelectedIndexChanged
        Try
            Dim itemSelected As Boolean = False
            For Each selectedIndex As Integer In SoundsListView.SelectedIndices
                SoundPlayer.URL = Sounds(selectedIndex).Path
                SoundPlayer.Ctlcontrols.stop()
                itemSelected = True
            Next
            IsItemSelected = itemSelected
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub
End Class
