<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OkButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.ChangePasswordButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(133, 54)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(53, 13)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "Passwort:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(192, 51)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.PasswordTextBox.Size = New System.Drawing.Size(267, 20)
        Me.PasswordTextBox.TabIndex = 3
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(265, 92)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(94, 23)
        Me.OkButton.TabIndex = 4
        Me.OkButton.Text = "OK"
        '
        'CloseButton
        '
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Location = New System.Drawing.Point(365, 92)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(94, 23)
        Me.CloseButton.TabIndex = 5
        Me.CloseButton.Text = "&Abbrechen"
        '
        'ErrorLabel
        '
        Me.ErrorLabel.ForeColor = System.Drawing.Color.Crimson
        Me.ErrorLabel.Location = New System.Drawing.Point(133, 74)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(326, 15)
        Me.ErrorLabel.TabIndex = 6
        Me.ErrorLabel.Text = "$ErrorLabel$"
        Me.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ErrorLabel.Visible = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.LogoPictureBox.Image = Global.AdvancedSoundBar.My.Resources.Resources.keychain_access_128x128
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(127, 127)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'ChangePasswordButton
        '
        Me.ChangePasswordButton.Enabled = False
        Me.ChangePasswordButton.Location = New System.Drawing.Point(133, 92)
        Me.ChangePasswordButton.Name = "ChangePasswordButton"
        Me.ChangePasswordButton.Size = New System.Drawing.Size(94, 23)
        Me.ChangePasswordButton.TabIndex = 7
        Me.ChangePasswordButton.Text = "Passwort ändern"
        Me.ChangePasswordButton.UseVisualStyleBackColor = True
        Me.ChangePasswordButton.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 3.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 6)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "7668"
        '
        'LoginForm
        '
        Me.AcceptButton = Me.OkButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(471, 127)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChangePasswordButton)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Zugriffsschutz"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorLabel As System.Windows.Forms.Label
    Friend WithEvents ChangePasswordButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
