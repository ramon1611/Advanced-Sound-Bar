<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminInterface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminInterface))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.OldPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.NewPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.RepeatTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusToolStripLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SoundsListView = New System.Windows.Forms.ListView()
        Me.NameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DurationColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PathColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AdminCredentialCheckBox = New System.Windows.Forms.CheckBox()
        Me.AdminCredentialGroupBox = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SoundMediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ViewCategoriesButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.RemoveButton = New System.Windows.Forms.Button()
        Me.ConfigureButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        Me.AdminCredentialGroupBox.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoundMediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Location = New System.Drawing.Point(12, 270)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(672, 1)
        Me.Panel1.TabIndex = 0
        '
        'OldPasswordTextBox
        '
        Me.OldPasswordTextBox.AccessibleDescription = "Das bisher gültige Passwort"
        Me.OldPasswordTextBox.Location = New System.Drawing.Point(86, 86)
        Me.OldPasswordTextBox.Name = "OldPasswordTextBox"
        Me.OldPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.OldPasswordTextBox.Size = New System.Drawing.Size(164, 20)
        Me.OldPasswordTextBox.TabIndex = 2
        Me.OldPasswordTextBox.Tag = ""
        '
        'NewPasswordTextBox
        '
        Me.NewPasswordTextBox.AccessibleDescription = "Das neue Passwort"
        Me.NewPasswordTextBox.Location = New System.Drawing.Point(86, 112)
        Me.NewPasswordTextBox.Name = "NewPasswordTextBox"
        Me.NewPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.NewPasswordTextBox.Size = New System.Drawing.Size(164, 20)
        Me.NewPasswordTextBox.TabIndex = 3
        Me.NewPasswordTextBox.Tag = ""
        '
        'RepeatTextBox
        '
        Me.RepeatTextBox.AccessibleDescription = "Die Wiederholung des neuen Passworts"
        Me.RepeatTextBox.Location = New System.Drawing.Point(86, 138)
        Me.RepeatTextBox.Name = "RepeatTextBox"
        Me.RepeatTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.RepeatTextBox.Size = New System.Drawing.Size(164, 20)
        Me.RepeatTextBox.TabIndex = 4
        Me.RepeatTextBox.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Altes Passwort:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Neus Passwort:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Wiederholung:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusToolStripLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 324)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(696, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusToolStripLabel
        '
        Me.StatusToolStripLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.StatusToolStripLabel.Name = "StatusToolStripLabel"
        Me.StatusToolStripLabel.Size = New System.Drawing.Size(37, 17)
        Me.StatusToolStripLabel.Text = "Bereit"
        '
        'SoundsListView
        '
        Me.SoundsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameColumn, Me.DurationColumn, Me.PathColumn})
        Me.SoundsListView.FullRowSelect = True
        Me.SoundsListView.Location = New System.Drawing.Point(12, 104)
        Me.SoundsListView.Name = "SoundsListView"
        Me.SoundsListView.Size = New System.Drawing.Size(410, 160)
        Me.SoundsListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.SoundsListView.TabIndex = 13
        Me.SoundsListView.UseCompatibleStateImageBehavior = False
        Me.SoundsListView.View = System.Windows.Forms.View.Details
        '
        'NameColumn
        '
        Me.NameColumn.Text = "Name"
        Me.NameColumn.Width = 120
        '
        'DurationColumn
        '
        Me.DurationColumn.Text = "Duration"
        Me.DurationColumn.Width = 52
        '
        'PathColumn
        '
        Me.PathColumn.Text = "Path"
        Me.PathColumn.Width = 234
        '
        'AdminCredentialCheckBox
        '
        Me.AdminCredentialCheckBox.AccessibleDescription = "Legt fest ob das Passwort für die Administrationsoberfläche geändert werden soll " & _
    "oder nicht"
        Me.AdminCredentialCheckBox.AutoSize = True
        Me.AdminCredentialCheckBox.Location = New System.Drawing.Point(436, 103)
        Me.AdminCredentialCheckBox.Name = "AdminCredentialCheckBox"
        Me.AdminCredentialCheckBox.Size = New System.Drawing.Size(224, 17)
        Me.AdminCredentialCheckBox.TabIndex = 1
        Me.AdminCredentialCheckBox.Tag = ""
        Me.AdminCredentialCheckBox.Text = "Passwort für die Administrationsoberfläche"
        Me.AdminCredentialCheckBox.UseVisualStyleBackColor = True
        '
        'AdminCredentialGroupBox
        '
        Me.AdminCredentialGroupBox.Controls.Add(Me.PictureBox2)
        Me.AdminCredentialGroupBox.Controls.Add(Me.Label1)
        Me.AdminCredentialGroupBox.Controls.Add(Me.OldPasswordTextBox)
        Me.AdminCredentialGroupBox.Controls.Add(Me.NewPasswordTextBox)
        Me.AdminCredentialGroupBox.Controls.Add(Me.Label4)
        Me.AdminCredentialGroupBox.Controls.Add(Me.RepeatTextBox)
        Me.AdminCredentialGroupBox.Controls.Add(Me.Label2)
        Me.AdminCredentialGroupBox.Enabled = False
        Me.AdminCredentialGroupBox.Location = New System.Drawing.Point(428, 104)
        Me.AdminCredentialGroupBox.Name = "AdminCredentialGroupBox"
        Me.AdminCredentialGroupBox.Size = New System.Drawing.Size(256, 164)
        Me.AdminCredentialGroupBox.TabIndex = 2
        Me.AdminCredentialGroupBox.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.AdvancedSoundBar.My.Resources.Resources.keychain_access_128x128
        Me.PictureBox2.Location = New System.Drawing.Point(6, 19)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(244, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'SoundMediaPlayer
        '
        Me.SoundMediaPlayer.Enabled = True
        Me.SoundMediaPlayer.Location = New System.Drawing.Point(276, 275)
        Me.SoundMediaPlayer.Name = "SoundMediaPlayer"
        Me.SoundMediaPlayer.OcxState = CType(resources.GetObject("SoundMediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SoundMediaPlayer.Size = New System.Drawing.Size(276, 46)
        Me.SoundMediaPlayer.TabIndex = 14
        '
        'SaveButton
        '
        Me.SaveButton.AccessibleDescription = "Speichern"
        Me.SaveButton.BackgroundImage = Global.AdvancedSoundBar.My.Resources.Resources.document_save
        Me.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SaveButton.Location = New System.Drawing.Point(582, 273)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(48, 48)
        Me.SaveButton.TabIndex = 11
        Me.SaveButton.Tag = ""
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ViewCategoriesButton
        '
        Me.ViewCategoriesButton.AccessibleDescription = "Zeige Kategorien"
        Me.ViewCategoriesButton.BackgroundImage = Global.AdvancedSoundBar.My.Resources.Resources.inventory_category_binoculars
        Me.ViewCategoriesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ViewCategoriesButton.Location = New System.Drawing.Point(198, 273)
        Me.ViewCategoriesButton.Name = "ViewCategoriesButton"
        Me.ViewCategoriesButton.Size = New System.Drawing.Size(48, 48)
        Me.ViewCategoriesButton.TabIndex = 15
        Me.ViewCategoriesButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.AccessibleDescription = "Schließen"
        Me.CloseButton.BackgroundImage = Global.AdvancedSoundBar.My.Resources.Resources.system_log_out
        Me.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CloseButton.Location = New System.Drawing.Point(636, 273)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(48, 48)
        Me.CloseButton.TabIndex = 12
        Me.CloseButton.Tag = ""
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'RemoveButton
        '
        Me.RemoveButton.AccessibleDescription = "Sound löschen"
        Me.RemoveButton.BackgroundImage = Global.AdvancedSoundBar.My.Resources.Resources.list_remove
        Me.RemoveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.RemoveButton.Location = New System.Drawing.Point(120, 273)
        Me.RemoveButton.Name = "RemoveButton"
        Me.RemoveButton.Size = New System.Drawing.Size(48, 48)
        Me.RemoveButton.TabIndex = 7
        Me.RemoveButton.Tag = ""
        Me.RemoveButton.UseVisualStyleBackColor = True
        '
        'ConfigureButton
        '
        Me.ConfigureButton.AccessibleDescription = "Sound konfigurieren"
        Me.ConfigureButton.BackgroundImage = Global.AdvancedSoundBar.My.Resources.Resources.configure
        Me.ConfigureButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ConfigureButton.Location = New System.Drawing.Point(66, 273)
        Me.ConfigureButton.Name = "ConfigureButton"
        Me.ConfigureButton.Size = New System.Drawing.Size(48, 48)
        Me.ConfigureButton.TabIndex = 6
        Me.ConfigureButton.Tag = ""
        Me.ConfigureButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.AccessibleDescription = "Sound importieren"
        Me.AddButton.BackgroundImage = Global.AdvancedSoundBar.My.Resources.Resources.list_add
        Me.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.AddButton.Location = New System.Drawing.Point(12, 273)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(48, 48)
        Me.AddButton.TabIndex = 5
        Me.AddButton.Tag = ""
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AdvancedSoundBar.My.Resources.Resources.gerard_butler_admin_256x256
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(672, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'AdminInterface
        '
        Me.AcceptButton = Me.SaveButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 346)
        Me.Controls.Add(Me.ViewCategoriesButton)
        Me.Controls.Add(Me.SoundMediaPlayer)
        Me.Controls.Add(Me.AdminCredentialCheckBox)
        Me.Controls.Add(Me.AdminCredentialGroupBox)
        Me.Controls.Add(Me.SoundsListView)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.RemoveButton)
        Me.Controls.Add(Me.ConfigureButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AdminInterface"
        Me.Tag = ""
        Me.Text = "Administrationsoberfläche"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.AdminCredentialGroupBox.ResumeLayout(False)
        Me.AdminCredentialGroupBox.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoundMediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ConfigureButton As System.Windows.Forms.Button
    Friend WithEvents RemoveButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents OldPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NewPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RepeatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusToolStripLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SoundsListView As System.Windows.Forms.ListView
    Friend WithEvents AdminCredentialCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents AdminCredentialGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents SoundMediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents NameColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents PathColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents DurationColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents ViewCategoriesButton As System.Windows.Forms.Button
End Class
