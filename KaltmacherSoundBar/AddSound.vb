Imports AdvancedSoundBar.Functions

Public Class AddSound
    Public SoundName As String = String.Empty
    Public ToolTipCtl As New ToolTip

    Private OFD As New OpenFileDialog
    Private Categories As List(Of Category) = LoadCategories(Application.StartupPath + My.Settings.CategoriesXmlPath)

    Private Sub AddSound_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        AdminInterface.SoundMediaPlayer.Ctlcontrols.stop()
        PausePreviewButton.Visible = False
    End Sub

    Private Sub AddSound_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            NameTextBox.Text = "Neuer Sound"
            PathTextBox.Text = "C:\..."
            DurationTextBox.Text = "00:00"

            OFD.AddExtension = True
            OFD.CheckFileExists = True
            OFD.CheckPathExists = True
            OFD.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            OFD.Multiselect = False
            OFD.ShowHelp = False

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

            For Each cItem As Category In Categories
                If CategoryComboBox.Items.Contains(cItem.Name) = False Then
                    CategoryComboBox.Items.Add(cItem.Name)

                    If cItem.IsDefault = True Then
                        Dim index As Integer = CategoryComboBox.FindString(cItem.Name)
                        CategoryComboBox.SelectedIndex = index
                    End If
                End If
            Next
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub SoundPreviewButton_Click(sender As System.Object, e As System.EventArgs) Handles SoundPreviewButton.Click
        AdminInterface.SoundMediaPlayer.Ctlcontrols.play()
        PausePreviewButton.Show()
    End Sub

    Private Sub ApplyButton_Click(sender As System.Object, e As System.EventArgs) Handles ApplyButton.Click
        Dim fName As String = Split(PathTextBox.Text, "\").Last.ToLower
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
            fName = Replace(fName, rplce, ReplaceFName(rplce))
        Next

        ImportSound.oldFile = PathTextBox.Text
        ImportSound.newFile = Application.StartupPath + My.Settings.SoundsPath + "\" + fName
        ImportSound.ShowDialog()

        If ImportSound.iStatus = ImportSound.ImportStatus.Success Or ImportSound.iStatus = ImportSound.ImportStatus.SuccessWithFailure Then
            Me.Close()
        End If
    End Sub

    Private Sub CloseButton_Click(sender As System.Object, e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub BrowsePathButton_Click(sender As System.Object, e As System.EventArgs) Handles BrowsePathButton.Click
        OFD.Title = "Sound Speicherort suchen ..."
        OFD.Filter = "Musikdateien|*.mp3;*.wav;*.wma"
        OFD.ShowDialog()
        If OFD.FileName <> String.Empty Then
            PathTextBox.Text = OFD.FileName
        End If
    End Sub

    Private Sub PausePreviewButton_Click(sender As System.Object, e As System.EventArgs) Handles PausePreviewButton.Click
        AdminInterface.SoundMediaPlayer.Ctlcontrols.stop()
        PausePreviewButton.Hide()
    End Sub

    Private Sub PathTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles PathTextBox.TextChanged
        If My.Computer.FileSystem.FileExists(PathTextBox.Text) Then
            SoundPreviewButton.Enabled = True
            AdminInterface.SoundMediaPlayer.URL = PathTextBox.Text
            AdminInterface.SoundMediaPlayer.Ctlcontrols.stop()
        Else
            SoundPreviewButton.Enabled = False
        End If

        If PathTextBox.Text <> String.Empty And PathTextBox.Text <> "C:\..." Then
            PreviewListView.Items(0).SubItems(2).Text = PathTextBox.Text
        Else
            PreviewListView.Items(0).SubItems(2).Text = "C:\..."
        End If
    End Sub

    Private Sub NameTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles NameTextBox.TextChanged
        If NameTextBox.Text <> String.Empty And NameTextBox.Text <> "Neuer Sound" Then
            PreviewListView.Items(0).Text = NameTextBox.Text
        Else
            PreviewListView.Items(0).Text = "Neuer Sound"
        End If
    End Sub

    Private Sub CategoryComboBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CategoryComboBox.SelectedIndexChanged
        If CategoryComboBox.Text <> String.Empty Then
            PreviewListView.Groups(0).Header = CategoryComboBox.Text
        Else
            PreviewListView.Groups(0).Header = "Kategorie"
        End If
    End Sub

    Private Sub DurationTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles DurationTextBox.TextChanged
        If DurationTextBox.Text <> String.Empty And DurationTextBox.Text <> "00:00" Then
            PreviewListView.Items(0).SubItems(1).Text = DurationTextBox.Text
        Else
            PreviewListView.Items(0).SubItems(1).Text = "00:00"
        End If
    End Sub
End Class