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
            NameTextBox.Clear()
            PathTextBox.Clear()
            DurationTextBox.Clear()
            CategoryComboBox.Refresh()
            PreviewListView.Clear()

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
                If CategoryComboBox.Items.Contains(cItem.Name) = False Then : CategoryComboBox.Items.Add(cItem.Name) : End If
            Next

            PreviewListView.Groups.Add(New ListViewGroup("Kategorie"))
            PreviewListView.Items.Add("Neuer Sound").Group = PreviewListView.Groups(0)
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub SoundPreviewButton_Click(sender As System.Object, e As System.EventArgs) Handles SoundPreviewButton.Click
        AdminInterface.SoundMediaPlayer.Ctlcontrols.play()
        PausePreviewButton.Show()
    End Sub

    Private Sub ApplyButton_Click(sender As System.Object, e As System.EventArgs) Handles ApplyButton.Click

    End Sub

    Private Sub CloseButton_Click(sender As System.Object, e As System.EventArgs) Handles CloseButton.Click

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
        AdminInterface.SoundMediaPlayer.Ctlcontrols.pause()
        PausePreviewButton.Hide()
    End Sub

    Private Sub PathTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles PathTextBox.TextChanged
        AdminInterface.SoundMediaPlayer.URL = PathTextBox.Text
        AdminInterface.SoundMediaPlayer.Ctlcontrols.stop()
    End Sub

    Private Sub NameTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles NameTextBox.TextChanged
        If NameTextBox.Text <> String.Empty Then
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
End Class