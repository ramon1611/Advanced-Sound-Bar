<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.NewPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RepeatTextBox = New System.Windows.Forms.TextBox()
        Me.OldPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.AdvancedSoundBar.My.Resources.Resources.keychain_access_128x128
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'CloseButton
        '
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Location = New System.Drawing.Point(384, 100)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 5
        Me.CloseButton.Text = "Abbrechen"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'OkButton
        '
        Me.OkButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OkButton.Location = New System.Drawing.Point(303, 100)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(75, 23)
        Me.OkButton.TabIndex = 4
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'NewPasswordTextBox
        '
        Me.NewPasswordTextBox.Location = New System.Drawing.Point(226, 32)
        Me.NewPasswordTextBox.Name = "NewPasswordTextBox"
        Me.NewPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.NewPasswordTextBox.Size = New System.Drawing.Size(233, 20)
        Me.NewPasswordTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Neues Passwort:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Wiederholung:"
        '
        'RepeatTextBox
        '
        Me.RepeatTextBox.Location = New System.Drawing.Point(226, 58)
        Me.RepeatTextBox.Name = "RepeatTextBox"
        Me.RepeatTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.RepeatTextBox.Size = New System.Drawing.Size(233, 20)
        Me.RepeatTextBox.TabIndex = 3
        '
        'OldPasswordTextBox
        '
        Me.OldPasswordTextBox.Location = New System.Drawing.Point(226, 6)
        Me.OldPasswordTextBox.Name = "OldPasswordTextBox"
        Me.OldPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.OldPasswordTextBox.Size = New System.Drawing.Size(233, 20)
        Me.OldPasswordTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(133, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Altes Passwort:"
        '
        'ErrorLabel
        '
        Me.ErrorLabel.ForeColor = System.Drawing.Color.Crimson
        Me.ErrorLabel.Location = New System.Drawing.Point(133, 81)
        Me.ErrorLabel.Name = "ErrorLabel"
        Me.ErrorLabel.Size = New System.Drawing.Size(326, 16)
        Me.ErrorLabel.TabIndex = 9
        Me.ErrorLabel.Text = "$ErrorLabel$"
        Me.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ErrorLabel.Visible = False
        '
        'ChangePassword
        '
        Me.AcceptButton = Me.OkButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(471, 127)
        Me.Controls.Add(Me.ErrorLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OldPasswordTextBox)
        Me.Controls.Add(Me.RepeatTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NewPasswordTextBox)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Passwort ändern"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents OkButton As System.Windows.Forms.Button
    Friend WithEvents NewPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RepeatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OldPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ErrorLabel As System.Windows.Forms.Label
End Class
