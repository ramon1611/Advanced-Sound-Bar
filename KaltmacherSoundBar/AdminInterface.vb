Imports AdvancedSoundBar.Functions

Public Class AdminInterface
    Public StatusObj As ToolStripStatusLabel = StatusToolStripLabel
    Public ToolTipCtl As New ToolTip
    Public Sounds As List(Of Sound) = LoadSounds(Application.StartupPath + My.Settings.SoundsXmlPath)
    Public Categories As List(Of Category) = LoadCategories(Application.StartupPath + My.Settings.CategoriesXmlPath)

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

            For Each cItem As Category In Categories
                SoundsListView.Groups.Add(New ListViewGroup(cItem.Name))
            Next

            For Each sound As Sound In Sounds
                Dim newListViewItem As New ListViewItem
                With newListViewItem
                    .Text = sound.Name
                    .Group = New ListViewGroup(sound.Category)
                    .SubItems.Add(sound.Path)
                    .SubItems.Add(sound.Duration)
                End With

                SoundsListView.Items.Add(newListViewItem)
            Next
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

            My.Settings.Save()
            My.Settings.Reload()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub AddButton_Click(sender As System.Object, e As System.EventArgs) Handles AddButton.Click
        Try
            AddSound.ShowDialog()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub ConfigureButton_Click(sender As System.Object, e As System.EventArgs) Handles ConfigureButton.Click
        Try
            ConfigureSound.ShowDialog()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub RemoveButton_Click(sender As System.Object, e As System.EventArgs) Handles RemoveButton.Click
        Try
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
        Dim categoriesMessage As String = "Anzahl Vorhandener Kategorien: " + Categories.Count.ToString

        For Each cItem As Category In Categories
            categoriesMessage = categoriesMessage + vbNewLine + "- " + cItem.Name
        Next

        MessageBox.Show(categoriesMessage, "Kategorien", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class