<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInterface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserInterface))
        Me.SoundPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LockedPanel = New System.Windows.Forms.Panel()
        Me.UnlockButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusToolStripLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ChangeUserPasswordButton = New System.Windows.Forms.Button()
        Me.AdminButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.LockButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.PauseButton = New System.Windows.Forms.Button()
        Me.PlayButton = New System.Windows.Forms.Button()
        Me.SoundsListView = New System.Windows.Forms.ListView()
        Me.NameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DurationColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PathColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.SoundPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LockedPanel.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SoundPlayer
        '
        Me.SoundPlayer.Enabled = True
        Me.SoundPlayer.Location = New System.Drawing.Point(174, 277)
        Me.SoundPlayer.Name = "SoundPlayer"
        Me.SoundPlayer.OcxState = CType(resources.GetObject("SoundPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SoundPlayer.Size = New System.Drawing.Size(32, 48)
        Me.SoundPlayer.TabIndex = 0
        Me.SoundPlayer.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Location = New System.Drawing.Point(12, 270)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(410, 1)
        Me.Panel1.TabIndex = 5
        '
        'LockedPanel
        '
        Me.LockedPanel.Controls.Add(Me.UnlockButton)
        Me.LockedPanel.Controls.Add(Me.Label1)
        Me.LockedPanel.Location = New System.Drawing.Point(455, 12)
        Me.LockedPanel.Name = "LockedPanel"
        Me.LockedPanel.Size = New System.Drawing.Size(410, 313)
        Me.LockedPanel.TabIndex = 11
        Me.LockedPanel.Visible = False
        '
        'UnlockButton
        '
        Me.UnlockButton.Location = New System.Drawing.Point(3, 282)
        Me.UnlockButton.Name = "UnlockButton"
        Me.UnlockButton.Size = New System.Drawing.Size(404, 23)
        Me.UnlockButton.TabIndex = 1
        Me.UnlockButton.Text = "Entsperren"
        Me.UnlockButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 279)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Programm gesperrt!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusToolStripLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 328)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(434, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 13
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusToolStripLabel
        '
        Me.StatusToolStripLabel.Name = "StatusToolStripLabel"
        Me.StatusToolStripLabel.Size = New System.Drawing.Size(37, 17)
        Me.StatusToolStripLabel.Text = "Bereit"
        '
        'ChangeUserPasswordButton
        '
        Me.ChangeUserPasswordButton.BackgroundImage = Global.AdvancedSoundBar.My.Resources.Resources.keychain_access_48x84
        Me.ChangeUserPasswordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ChangeUserPasswordButton.Location = New System.Drawing.Point(266, 277)
        Me.ChangeUserPasswordButton.Name = "ChangeUserPasswordButton"
        Me.ChangeUserPasswordButton.Size = New System.Drawing.Size(48, 48)
        Me.ChangeUserPasswordButton.TabIndex = 10
        Me.ChangeUserPasswordButton.UseVisualStyleBackColor = True
        '
        'AdminButton
        '
        Me.AdminButton.BackgroundImage = Global.AdvancedSoundBar.My.Resources.Resources.settings_48x48
        Me.AdminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AdminButton.Location = New System.Drawing.Point(212, 277)
        Me.AdminButton.Name = "AdminButton"
        Me.AdminButton.Size = New System.Drawing.Size(48, 48)
        Me.AdminButton.TabIndex = 9
        Me.AdminButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AdvancedSoundBar.My.Resources.Resources.gerard_butler_256x256
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(410, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'CloseButton
        '
        Me.CloseButton.BackgroundImage = Global.AdvancedSoundBar.My.Resources.Resources.system_log_out
        Me.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CloseButton.Location = New System.Drawing.Point(374, 277)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(48, 48)
        Me.CloseButton.TabIndex = 12
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'LockButton
        '
        Me.LockButton.BackgroundImage = Global.AdvancedSoundBar.My.Resources.Resources.system_lock_screen
        Me.LockButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.LockButton.Location = New System.Drawing.Point(320, 277)
        Me.LockButton.Name = "LockButton"
        Me.LockButton.Size = New System.Drawing.Size(48, 48)
        Me.LockButton.TabIndex = 11
        Me.LockButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.BackgroundImage = Global.AdvancedSoundBar.My.Resources.Resources.media_playback_stop
        Me.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.StopButton.Location = New System.Drawing.Point(120, 277)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(48, 48)
        Me.StopButton.TabIndex = 4
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'PauseButton
        '
        Me.PauseButton.BackgroundImage = Global.AdvancedSoundBar.My.Resources.Resources.media_playback_pause
        Me.PauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PauseButton.Location = New System.Drawing.Point(66, 277)
        Me.PauseButton.Name = "PauseButton"
        Me.PauseButton.Size = New System.Drawing.Size(48, 48)
        Me.PauseButton.TabIndex = 3
        Me.PauseButton.UseVisualStyleBackColor = True
        '
        'PlayButton
        '
        Me.PlayButton.BackgroundImage = Global.AdvancedSoundBar.My.Resources.Resources.media_playback_start
        Me.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PlayButton.Location = New System.Drawing.Point(12, 277)
        Me.PlayButton.Name = "PlayButton"
        Me.PlayButton.Size = New System.Drawing.Size(48, 48)
        Me.PlayButton.TabIndex = 2
        Me.PlayButton.UseVisualStyleBackColor = True
        '
        'SoundsListView
        '
        Me.SoundsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameColumn, Me.DurationColumn, Me.PathColumn})
        Me.SoundsListView.FullRowSelect = True
        Me.SoundsListView.Location = New System.Drawing.Point(12, 104)
        Me.SoundsListView.Name = "SoundsListView"
        Me.SoundsListView.Size = New System.Drawing.Size(410, 160)
        Me.SoundsListView.TabIndex = 14
        Me.SoundsListView.UseCompatibleStateImageBehavior = False
        Me.SoundsListView.View = System.Windows.Forms.View.Details
        '
        'NameColumn
        '
        Me.NameColumn.Text = "Name"
        Me.NameColumn.Width = 80
        '
        'DurationColumn
        '
        Me.DurationColumn.Text = "Duration"
        Me.DurationColumn.Width = 52
        '
        'PathColumn
        '
        Me.PathColumn.Text = "Path"
        Me.PathColumn.Width = 274
        '
        'UserInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 350)
        Me.Controls.Add(Me.SoundsListView)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.LockedPanel)
        Me.Controls.Add(Me.ChangeUserPasswordButton)
        Me.Controls.Add(Me.AdminButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.LockButton)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SoundPlayer)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.PauseButton)
        Me.Controls.Add(Me.PlayButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "UserInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdvancedSoundBar"
        CType(Me.SoundPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LockedPanel.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PlayButton As System.Windows.Forms.Button
    Friend WithEvents PauseButton As System.Windows.Forms.Button
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LockButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents AdminButton As System.Windows.Forms.Button
    Friend WithEvents ChangeUserPasswordButton As System.Windows.Forms.Button
    Friend WithEvents LockedPanel As System.Windows.Forms.Panel
    Friend WithEvents UnlockButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents StatusToolStripLabel As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents SoundPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents SoundsListView As System.Windows.Forms.ListView
    Friend WithEvents NameColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents PathColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents DurationColumn As System.Windows.Forms.ColumnHeader

End Class
