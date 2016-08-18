Imports AdvancedSoundBar.Functions, AdvancedSoundBar.Enumerations

Public Class SoundConfigForm
    Public SoundName As String = String.Empty
    Public ToolTipCtl As New ToolTip
    Public ActionMode As SoundConfigMode = SoundConfigMode.Add
    Public SelectedSound As Sound

    Private OFD As New OpenFileDialog
    Private Categories As List(Of Category) = LoadCategories(Application.StartupPath + My.Settings.CategoriesXmlPath)

    Private Sub AddSound_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            AdminInterface.SoundMediaPlayer.Ctlcontrols.stop()
            PausePreviewButton.Visible = False
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub AddSound_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            OFD.AddExtension = True
            OFD.CheckFileExists = True
            OFD.CheckPathExists = True
            OFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            OFD.Multiselect = False
            OFD.ShowHelp = False
            OFD.Title = "Sound Speicherort suchen ..."
            OFD.Filter = "Musikdateien|*.mp3;*.wav;*.wma"

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

            Select Case ActionMode
                Case SoundConfigMode.Add
                    Me.Text = "Sound importieren"
                    ApplyButton.Text = "Importieren"

                    NameTextBox.Text = "Neuer Sound"
                    PathTextBox.Text = "C:\..."
                    DurationTextBox.Text = "00:00"

                    For Each cItem As Category In Categories
                        If CategoryComboBox.Items.Contains(cItem.Name) = False Then
                            CategoryComboBox.Items.Add(cItem.Name)

                            If cItem.IsDefault = True Then
                                Dim index As Integer = CategoryComboBox.FindString(cItem.Name)
                                CategoryComboBox.SelectedIndex = index
                            End If
                        End If
                    Next

                Case SoundConfigMode.Modify
                    Me.Text = "Sound bearbeiten"
                    ApplyButton.Text = "Übernehmen"

                    NameTextBox.Text = SelectedSound.Name
                    PathTextBox.Text = SelectedSound.Path
                    DurationTextBox.Text = SelectedSound.Duration

                    For Each cItem As Category In Categories
                        If CategoryComboBox.Items.Contains(cItem.Name) = False Then
                            CategoryComboBox.Items.Add(cItem.Name)

                            Dim index As Integer = CategoryComboBox.FindString(SelectedSound.Category)
                            CategoryComboBox.SelectedIndex = index
                        End If
                    Next
                Case Else
            End Select
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub SoundPreviewButton_Click(sender As System.Object, e As System.EventArgs) Handles SoundPreviewButton.Click
        Try
            AdminInterface.SoundMediaPlayer.Ctlcontrols.play()
            PausePreviewButton.Show()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Function parseFileName(ByVal originalFileName As String) As String
        Try
            Dim ReplaceFName As New Dictionary(Of String, String)

            With ReplaceFName
                .Add(" - ", "_")
                .Add(", ", "_")
                .Add(") (", "_")
                .Add(").", ".")
                .Add("(", "_")
                .Add(")", "_")
                .Add("] [", "_")
                .Add("].", ".")
                .Add("[", "_")
                .Add("]", "_")
                .Add(",", "_")
                .Add("'", "")
                .Add(" & ", "+")
                .Add("&", "+")
                .Add(" ", "-")
                .Add("#", "")
            End With

            For Each rplce As String In ReplaceFName.Keys
                originalFileName = Replace(originalFileName, rplce, ReplaceFName(rplce))
            Next

            Return originalFileName.ToLower
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
            Return String.Empty
        End Try
    End Function

    Private Sub ApplyButton_Click(sender As System.Object, e As System.EventArgs) Handles ApplyButton.Click
        Try
            Dim newPath As String = Application.StartupPath + My.Settings.SoundsPath
            newPath = newPath + "\" + parseFileName(NameTextBox.Text.ToLower + "." + Split(PathTextBox.Text, ".").Last.ToLower)

            ImportSound.oldFile = PathTextBox.Text
            ImportSound.newFile = newPath
            ImportSound.ShowDialog()

            If ImportSound.iStatus = ImportStatus.Success Or ImportSound.iStatus = ImportStatus.SuccessWithFailure Then
                Select Case ActionMode
                    Case SoundConfigMode.Add
                        Sounds.Add(New Sound(Sounds.Count, NameTextBox.Text, newPath, DurationTextBox.Text, CategoryComboBox.Text))
                    Case SoundConfigMode.Modify
                        Sounds(SelectedSound.GetIndex) = New Sound(Sounds.Count, NameTextBox.Text, newPath, DurationTextBox.Text, CategoryComboBox.Text)
                    Case Else
                End Select

                AdminInterface.refreshSoundsListView()
                AdminInterface.UnsavedSettings = True
                Me.Close()
            End If
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

    Private Sub BrowsePathButton_Click(sender As System.Object, e As System.EventArgs) Handles BrowsePathButton.Click
        Try
            OFD.ShowDialog()
            If OFD.FileName <> String.Empty Then
                PathTextBox.Text = OFD.FileName
            End If
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub PausePreviewButton_Click(sender As System.Object, e As System.EventArgs) Handles PausePreviewButton.Click
        Try
            AdminInterface.SoundMediaPlayer.Ctlcontrols.stop()
            PausePreviewButton.Hide()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub PathTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles PathTextBox.TextChanged
        Try
            If My.Computer.FileSystem.FileExists(PathTextBox.Text) Then
                SoundPreviewButton.Enabled = True
                AdminInterface.SoundMediaPlayer.URL = PathTextBox.Text
                AdminInterface.SoundMediaPlayer.Ctlcontrols.stop()
            Else
                SoundPreviewButton.Enabled = False
            End If

            If PathTextBox.Text <> String.Empty And PathTextBox.Text <> "C:\..." Then
                PreviewListView.Items(0).SubItems(2).Text = "..." + My.Settings.SoundsPath + "\" + parseFileName(NameTextBox.Text + "." + Split(PathTextBox.Text, ".").Last)
            Else
                PreviewListView.Items(0).SubItems(2).Text = "C:\..."
            End If
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub NameTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles NameTextBox.TextChanged
        Try
            If NameTextBox.Text <> String.Empty And NameTextBox.Text <> "Neuer Sound" Then
                PreviewListView.Items(0).Text = NameTextBox.Text
            Else
                PreviewListView.Items(0).Text = "Neuer Sound"
            End If

            If PathTextBox.Text <> String.Empty And PathTextBox.Text <> "C:\..." Then
                PreviewListView.Items(0).SubItems(2).Text = "..." + My.Settings.SoundsPath + "\" + parseFileName(NameTextBox.Text + "." + Split(PathTextBox.Text, ".").Last)
            Else
                PreviewListView.Items(0).SubItems(2).Text = "C:\..."
            End If
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub CategoryComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CategoryComboBox.SelectedIndexChanged
        Try
            If CategoryComboBox.Text <> String.Empty Then
                PreviewListView.Groups(0).Header = CategoryComboBox.Text
            Else
                PreviewListView.Groups(0).Header = "Kategorie"
            End If
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub DurationTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles DurationTextBox.TextChanged
        Try
            If DurationTextBox.Text <> String.Empty And DurationTextBox.Text <> "00:00" Then
                PreviewListView.Items(0).SubItems(1).Text = DurationTextBox.Text
            Else
                PreviewListView.Items(0).SubItems(1).Text = "00:00"
            End If
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub
End Class