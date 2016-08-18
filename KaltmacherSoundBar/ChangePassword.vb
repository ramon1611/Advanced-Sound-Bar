Imports AdvancedSoundBar.Functions, AdvancedSoundBar.Enumerations

Public Class ChangePassword
    '' <?34573r_366
    Public e4573r_366_cpw As Boolean = False
    '' ?>

    Private Sub ChangePassword_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            '' <?34573r_366
            If e4573r_366_cpw = True Then
                Label3.Show()
                OldPasswordTextBox.Show()
            End If
            '' ?>
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub ChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            '' <?34573r_366
            If e4573r_366_cpw = True Then
                Label3.Hide()
                OldPasswordTextBox.Hide()
            End If
            '' ?>

            OldPasswordTextBox.Clear()
            NewPasswordTextBox.Clear()
            RepeatTextBox.Clear()
            OldPasswordTextBox.Select()
            ErrorLabel.Hide()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Try
            Me.Close()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub OkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkButton.Click
        Try
            '' <?34573r_366
            If e4573r_366_cpw = True Then : GoTo 366 : End If
            '' ?>

            If MD5StringHash(OldPasswordTextBox.Text) = My.Settings.UserPasswordMD5 Then
366:            If NewPasswordTextBox.Text = RepeatTextBox.Text Then
                    My.Settings.UserPasswordMD5 = MD5StringHash(NewPasswordTextBox.Text)
                    My.Settings.Save()
                    My.Settings.Reload()

                    If e4573r_366_cpw = False Then : SubmitStatus(UserInterface, UserInterface.StatusToolStripLabel, StatusType.Success, "Passwort erfolgreich geändert") : End If
                    Me.Close()
                Else
                    ErrorLabel.Text = "Die Passwörter stimmen nicht überein!"
                    ErrorLabel.Show()
                End If
            Else
                ErrorLabel.Text = "Das alte Passwort ist falsch!"
                ErrorLabel.Show()
            End If
        Catch ex As Exception
            ErrorLabel.Text = "!! Kritischer Fehler !!"
            ErrorLabel.Show()
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub
End Class