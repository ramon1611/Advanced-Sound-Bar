Imports AdvancedSoundBar.Functions

Public Class AdminInterface
    Public StatusObj As ToolStripStatusLabel = StatusToolStripLabel
    Public ToolTipCtl As New ToolTip
    Public FilesToDelete As New List(Of String)
    Public UnsavedSettings As Boolean = False

    Private Sub AdminInterface_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If UnsavedSettings <> False Then
            If MessageBox.Show("Es wurden noch nicht alle Einstellungen gespeichert! Wollen Sie das fenster Schließen ohne die Einstellungen zu speichern?", "Nicht gespeicherte Einstellungen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                initialize(Application.StartupPath + My.Settings.SoundsXmlPath, Application.StartupPath + My.Settings.CategoriesXmlPath)
            End If
        End If
    End Sub

    Private Sub AdminInterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            OldPasswordTextBox.Clear()
            NewPasswordTextBox.Clear()
            RepeatTextBox.Clear()
            AdminCredentialCheckBox.Checked = False
            AdminCredentialGroupBox.Enabled = False

            ToolTipCtl.AutoPopDelay = 5000
            ToolTipCtl.InitialDelay = 1000
            ToolTipCtl.ReshowDelay = 500
            ToolTipCtl.ShowAlways = True

            Dim ctl As Control
            For Each ctl In Me.Controls
                If ctl.AccessibleDescription <> String.Empty Then
                    ToolTipCtl.SetToolTip(ctl, ctl.AccessibleDescription)
                End If
            Next

            SubmitStatus(Me, StatusToolStripLabel)
            refreshSoundsListView()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub CloseButton_Click(sender As System.Object, e As System.EventArgs) Handles CloseButton.Click
        Try
            Me.Close()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub



    Private Sub SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveButton.Click
        Try
            If AdminCredentialCheckBox.Checked = True Then
                If MD5StringHash(OldPasswordTextBox.Text) = My.Settings.UserPasswordMD5 Then
                    If NewPasswordTextBox.Text = RepeatTextBox.Text Then
                        My.Settings.UserPasswordMD5 = MD5StringHash(NewPasswordTextBox.Text)
                        SubmitStatus(Me, StatusToolStripLabel, StatusType.Success, "Einstellungen gespeichert")
                    Else
                        SubmitStatus(Me, StatusToolStripLabel, StatusType.Failure, "Die Passwörter stimmen nicht überein!")
                    End If
                Else
                    SubmitStatus(Me, StatusToolStripLabel, StatusType.Failure, "Das alte Passwort ist falsch!")
                End If
            End If

            For Each file As String In FilesToDelete
                If My.Computer.FileSystem.FileExists(file) Then
                    My.Computer.FileSystem.DeleteFile(file)
                End If
            Next

            SaveSounds(Application.StartupPath + My.Settings.SoundsXmlPath, Sounds)
            SaveCategories(Application.StartupPath + My.Settings.CategoriesXmlPath, Categories)

            My.Settings.Save()
            My.Settings.Reload()

            UnsavedSettings = False
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub AddButton_Click(sender As System.Object, e As System.EventArgs) Handles AddButton.Click
        Try
            SoundConfigForm.ActionMode = SoundConfigForm.Mode.Add
            SoundConfigForm.ShowDialog()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub ConfigureButton_Click(sender As System.Object, e As System.EventArgs) Handles ConfigureButton.Click
        Try
            For Each selectedIndex As Integer In SoundsListView.SelectedIndices
                If selectedIndex >= 0 Then
                    SoundConfigForm.ActionMode = SoundConfigForm.Mode.Modify
                    SoundConfigForm.SelectedSoundIndex = selectedIndex
                    SoundConfigForm.ShowDialog()
                End If
            Next
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub RemoveButton_Click(sender As System.Object, e As System.EventArgs) Handles RemoveButton.Click
        Try
            For Each selectedIndex As Integer In SoundsListView.SelectedIndices
                If selectedIndex >= 0 And MessageBox.Show("Wollen Sie den Sound """ + SoundsListView.Items(selectedIndex).Text + """ wirklich löschen?", "Sound löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    FilesToDelete.Add(Sounds(selectedIndex).Path())
                    Sounds.Remove(Sounds(selectedIndex))
                    refreshSoundsListView()

                    UnsavedSettings = True
                End If
            Next
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub AdminCredentialCheckBox_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles AdminCredentialCheckBox.CheckedChanged
        Try
            AdminCredentialGroupBox.Enabled = AdminCredentialCheckBox.Checked
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub ViewCategoriesButton_Click(sender As System.Object, e As System.EventArgs) Handles ViewCategoriesButton.Click
        CategoryInterface.ShowDialog()
    End Sub

    Public Sub refreshSoundsListView()
        SoundsListView.Groups.Clear()
        SoundsListView.Items.Clear()

        Dim Groups As New Dictionary(Of String, ListViewGroup)
        For Each cItem As Functions.Category In Categories
            Groups.Add(cItem.Name, New ListViewGroup(cItem.Name, cItem.Name))
            SoundsListView.Groups.Add(Groups(cItem.Name))
        Next

        For Each sound As Sound In Sounds
            Dim newListViewItem As New ListViewItem
            Dim relPath As String = "..." + My.Settings.SoundsPath + "\" + Split(sound.Path, "\").Last
            With newListViewItem
                .Text = sound.Name
                If Groups.Keys.Contains(sound.Category) Then : .Group = Groups(sound.Category) : Else
                    .Group = New ListViewGroup("Unkategoriesiert") : End If
                .SubItems.Add(sound.Duration)
                .SubItems.Add(relPath)
            End With
            SoundsListView.Items.Add(newListViewItem)
        Next
    End Sub

    Private Sub SoundsListView_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)
        Dim selectedItems As New ListView.SelectedListViewItemCollection(SoundsListView)
        selectedItems = SoundsListView.SelectedItems

        For Each item As ListViewItem In selectedItems
            For Each sound As Sound In Sounds
                If sound.Name = item.Text Then
                    SoundMediaPlayer.URL = sound.Path
                    SoundMediaPlayer.Ctlcontrols.stop()
                End If
            Next
        Next
    End Sub
End Class