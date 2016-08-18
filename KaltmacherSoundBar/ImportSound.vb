Imports AdvancedSoundBar.Functions

Public Class ImportSound
    Public oldFile As String = String.Empty
    Public newFile As String = String.Empty
    Public iStatus As ImportStatus = ImportStatus.None

    Public Enum ImportStatus As Integer
        None = 0
        Success = 1
        SuccessWithFailure = 2
        Failure = 3
    End Enum

    Private Sub ImportSound_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        Try
            If oldFile <> String.Empty Or newFile <> String.Empty Then
                ImportStatusLabel.Text = oldFile + " -> " + newFile
                Select Case Import(oldFile, newFile)
                    Case ImportStatus.Success
                        SubmitStatus(AdminInterface, AdminInterface.StatusToolStripLabel, StatusType.Success, "Sound erfolgreich importiert")
                        iStatus = ImportStatus.Success
                    Case ImportStatus.SuccessWithFailure
                        SubmitStatus(AdminInterface, AdminInterface.StatusToolStripLabel, StatusType.Warning, "Sound wurde mit Fehlern importiert (Quell- und Zieldatei unterscheiden sich)")
                        iStatus = ImportStatus.SuccessWithFailure
                    Case ImportStatus.Failure
                        SubmitStatus(AdminInterface, AdminInterface.StatusToolStripLabel, StatusType.Failure, "Sound konnte nicht importiert werden!")
                        iStatus = ImportStatus.Failure
                    Case Else
                        SubmitStatus(AdminInterface, AdminInterface.StatusToolStripLabel, StatusType.Failure, "Sound konnte nicht importiert werden!")
                        iStatus = ImportStatus.Failure
                End Select

                Me.Close()
            End If
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Function Import(ByVal oldF As String, newF As String) As ImportStatus
        Try
            Dim streamRead As New IO.FileStream(oldF, IO.FileMode.Open, IO.FileAccess.Read, IO.FileShare.Read)
            Dim streamWrite As New IO.FileStream(newF, IO.FileMode.Create, IO.FileAccess.Write, IO.FileShare.Write)

            Dim lngLen As Long = streamRead.Length - 1
            Dim byteBuffer(1048576) As Byte
            Dim intBytesRead As Integer

            While streamRead.Position < lngLen
                intBytesRead = (streamRead.Read(byteBuffer, 0, 1048576))
                streamWrite.Write(byteBuffer, 0, intBytesRead)

                ImportProgressBar.Value = CInt(streamRead.Position / lngLen * 100)
                Application.DoEvents()
            End While

            streamWrite.Flush()
            streamWrite.Close()
            streamRead.Close()

            If My.Computer.FileSystem.GetFileInfo(oldF).Length = My.Computer.FileSystem.GetFileInfo(newF).Length Then
                Return ImportStatus.Success
            Else
                If MessageBox.Show("Quell- und Zieldatei unterscheiden sich. Soll die Zieldatei gelöscht oder beibehalten werden?", "Fehler beim Kopieren", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    My.Computer.FileSystem.DeleteFile(newF)
                    Throw New Exception("Quell- und Zieldatei unterscheiden sich")
                    Return ImportStatus.Failure
                Else
                    Return ImportStatus.SuccessWithFailure
                End If
            End If
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
            Return ImportStatus.Failure
        End Try
    End Function
End Class