Imports AdvancedSoundBar.Functions, AdvancedSoundBar.Enumerations

Public Class LoginForm
    Public Method As LoginMethod
    Public Access As AccessType

    Private falsePasswordMessage As String = "Das eingegebene Passwort ist falsch!"
    Private emptyPasswordMessage As String = "Bitte geben Sie ein Passwort ein"

    '' <?34573r_366
    Public e4573r_366 As New Dictionary(Of String, String)
    Private e66_n4m3 As String = String.Empty
    Private e66_ur1_c4ch3 As String = UserInterface.SoundPlayer.URL
    Private h3lp_73x7 As String = String.Empty
    '' ?>

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            UserTextBox.Clear()
            PasswordTextBox.Clear()
            PasswordTextBox.Select()
            ErrorLabel.Hide()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub OkButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OkButton.Click
        Try
            ErrorLabel.ForeColor = Color.Crimson

            If PasswordTextBox.Text.Trim(CChar(" ")) <> String.Empty Then
                '' <?e4573r_366
                Select Case MD5StringHash(PasswordTextBox.Text)
                    Case MD5StringHash("*#7370")
                        PasswordTextBox.PasswordChar = Nothing
                        e66_n4m3 = "ShowPassword"
                    Case MD5StringHash("*#6370")
                        ChangePasswordButton.Show()
                        ChangePasswordButton.Enabled = True
                        e66_n4m3 = "ChangePassword"
                    Case MD5StringHash("*#7668")
                        e66_n4m3 = "ViewHelp"
                        h3lp_73x7 = "*#7668 -- View Help" + vbNewLine + _
                                    "*#7370 -- Show Passwort" + vbNewLine + _
                                    "*#6370 -- Change Password" + vbNewLine + _
                                    "*#7373 -- Special Sounds" + vbNewLine

                        For Each e66 As String In e4573r_366.Keys
                            h3lp_73x7 = h3lp_73x7 + "-> :" + e66 + " -- " + e4573r_366(e66) + vbNewLine
                        Next
                    Case Else
                        For Each e66 As String In e4573r_366.Keys
                            If MD5StringHash(PasswordTextBox.Text) = MD5StringHash("*#7373:" + e66) Then
                                UserInterface.SoundPlayer.URL = SoundsAbsPath + "\" + e66 + My.Settings.SoundsDefaultExt
                                e66_n4m3 = e4573r_366(e66)
                                UserInterface.e66 = True
                            End If
                        Next
                End Select
                '' ?>

                Select Case Method
                    Case LoginMethod.Admin
                        If MD5StringHash(PasswordTextBox.Text) = My.Settings.AdminPasswordMD5 Then
                            AdminInterface.Show()
                            Me.Close()
                        Else
                            ErrorLabel.Text = falsePasswordMessage
                            ErrorLabel.Show()
                        End If
                    Case LoginMethod.User
                        If MD5StringHash(PasswordTextBox.Text) = My.Settings.UserPasswordMD5 Then
                            UserInterface.Show()
                            Me.Close()
                        Else
                            ErrorLabel.Text = falsePasswordMessage
                            ErrorLabel.Show()
                        End If

                    Case LoginMethod.Unlock
                        If MD5StringHash(PasswordTextBox.Text) = My.Settings.UserPasswordMD5 Then
                            UserInterface.LockedPanel.Hide()
                            SubmitStatus(UserInterface, UserInterface.StatusToolStripLabel)
                            Me.Close()
                        Else
                            ErrorLabel.Text = falsePasswordMessage
                            ErrorLabel.Show()
                        End If
                    Case Else
                        ErrorLabel.Text = "!! Kritischer Fehler !!"
                        ErrorLabel.Show()

                        Throw New Exception("00: Invalid method" + vbNewLine + "01: Procedure = OKButton_Click" + vbNewLine + "02: SubProcedure = Try -> Select -> Case(4) Else")
                End Select

                '' <?e4573r_366
                If e66_n4m3 <> String.Empty Then
                    ErrorLabel.Text = "Easter Egg aktiviert [" + e66_n4m3 + "]"
                    ErrorLabel.ForeColor = Color.Green
                    ErrorLabel.Show()
                    e66_n4m3 = String.Empty
                    PasswordTextBox.Text = String.Empty
                    If h3lp_73x7 <> String.Empty Then : MessageBox.Show(h3lp_73x7, "Easter Egg List", MessageBoxButtons.OK, MessageBoxIcon.Information) : h3lp_73x7 = String.Empty : End If
                End If
                '' ?>
            Else
                ErrorLabel.Text = emptyPasswordMessage
                ErrorLabel.Show()
            End If
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Try
            Select Case Method
                Case LoginMethod.Admin
                    Me.Close()
                Case LoginMethod.User
                    UserInterface.Opacity = 0
                    Application.Exit()
                Case LoginMethod.Unlock
                    Me.Close()
            End Select
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub LoginForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            '' <?e4573r_366
            UserInterface.SoundPlayer.URL = e66_ur1_c4ch3
            UserInterface.SoundPlayer.Ctlcontrols.stop()
            UserInterface.e66 = False
            PasswordTextBox.PasswordChar = CChar("•")
            '' ?>
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub ChangePasswordButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordButton.Click
        Try
            '' <?e4573r_366
            ChangePassword.e4573r_366_cpw = True
            ChangePassword.ShowDialog()
            ChangePasswordButton.Hide()
            ChangePasswordButton.Enabled = False
            '' ?>
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub
End Class
