Imports AdvancedSoundBar.Functions

Public Class ConfigureSound
    Public SoundName As String = String.Empty
    Public ToolTipCtl As New ToolTip

    Private OFD As New OpenFileDialog

    Private Sub ConfigureSound_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
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
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub BrowsePathButton_Click(sender As System.Object, e As System.EventArgs) Handles BrowsePathButton.Click
        OFD.Title = "Sound Speicherort suchen ..."
        OFD.Filter = "Musikdateien|*.mp3;*.wav;*.wma"
        OFD.ShowDialog()
        If OFD.FileName <> String.Empty Then
            PathTextBox.Text = OFD.FileName
        End If
    End Sub

    Private Sub SoundPreviewButton_Click(sender As System.Object, e As System.EventArgs) Handles SoundPreviewButton.Click
        AdminInterface.SoundMediaPlayer.Ctlcontrols.play()
        PausePreviewButton.Show()
    End Sub

    Private Sub CloseButton_Click(sender As System.Object, e As System.EventArgs) Handles CloseButton.Click
        AdminInterface.SoundMediaPlayer.Ctlcontrols.stop()
    End Sub

    Private Sub ApplyButton_Click(sender As System.Object, e As System.EventArgs) Handles ApplyButton.Click
        AdminInterface.SoundMediaPlayer.Ctlcontrols.stop()
    End Sub

    Private Sub BrowseSymbolButton_Click(sender As System.Object, e As System.EventArgs) Handles BrowseSymbolButton.Click
        OFD.Title = "Symbol Speicherort suchen ..."
        OFD.Filter = "Bilddateien|*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.wmf"
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
End Class