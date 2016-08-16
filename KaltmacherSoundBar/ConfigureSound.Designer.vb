<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigureSound
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigureSound))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PreviewListView = New System.Windows.Forms.ListView()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ApplyButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BrowseSymbolButton = New System.Windows.Forms.Button()
        Me.SymbolTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DurationTextBox = New System.Windows.Forms.TextBox()
        Me.BrowsePathButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PathTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SoundPreviewButton = New System.Windows.Forms.Button()
        Me.PausePreviewButton = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PreviewListView)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 193)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(463, 100)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Vorschau"
        '
        'PreviewListView
        '
        Me.PreviewListView.Location = New System.Drawing.Point(6, 19)
        Me.PreviewListView.Name = "PreviewListView"
        Me.PreviewListView.Size = New System.Drawing.Size(451, 75)
        Me.PreviewListView.TabIndex = 9
        Me.PreviewListView.UseCompatibleStateImageBehavior = False
        '
        'CloseButton
        '
        Me.CloseButton.AccessibleDescription = "Abbrechen"
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Location = New System.Drawing.Point(400, 299)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 14
        Me.CloseButton.Text = "Abbrechen"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ApplyButton
        '
        Me.ApplyButton.AccessibleDescription = "Übernehmen und Sound hinzufügen"
        Me.ApplyButton.Location = New System.Drawing.Point(318, 299)
        Me.ApplyButton.Name = "ApplyButton"
        Me.ApplyButton.Size = New System.Drawing.Size(76, 23)
        Me.ApplyButton.TabIndex = 13
        Me.ApplyButton.Text = "Übernehmen"
        Me.ApplyButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BrowseSymbolButton)
        Me.GroupBox2.Controls.Add(Me.SymbolTextBox)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.CategoryComboBox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 115)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(463, 72)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Erweitert"
        '
        'BrowseSymbolButton
        '
        Me.BrowseSymbolButton.AccessibleDescription = "Durchsuchen"
        Me.BrowseSymbolButton.Location = New System.Drawing.Point(433, 46)
        Me.BrowseSymbolButton.Name = "BrowseSymbolButton"
        Me.BrowseSymbolButton.Size = New System.Drawing.Size(24, 20)
        Me.BrowseSymbolButton.TabIndex = 4
        Me.BrowseSymbolButton.Text = "..."
        Me.BrowseSymbolButton.UseVisualStyleBackColor = True
        '
        'SymbolTextBox
        '
        Me.SymbolTextBox.AccessibleDescription = "Symbol des Sounds"
        Me.SymbolTextBox.Location = New System.Drawing.Point(67, 46)
        Me.SymbolTextBox.Name = "SymbolTextBox"
        Me.SymbolTextBox.Size = New System.Drawing.Size(360, 20)
        Me.SymbolTextBox.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Symbol:"
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.AccessibleDescription = "Kategorie des Sounds"
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(67, 19)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(360, 21)
        Me.CategoryComboBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Kategorie:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DurationTextBox)
        Me.GroupBox1.Controls.Add(Me.BrowsePathButton)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PathTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(463, 97)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Allgemeines"
        '
        'DurationTextBox
        '
        Me.DurationTextBox.AccessibleDescription = "Dauer des Sounds"
        Me.DurationTextBox.Location = New System.Drawing.Point(76, 71)
        Me.DurationTextBox.Name = "DurationTextBox"
        Me.DurationTextBox.Size = New System.Drawing.Size(351, 20)
        Me.DurationTextBox.TabIndex = 5
        '
        'BrowsePathButton
        '
        Me.BrowsePathButton.AccessibleDescription = "Durchsuchen"
        Me.BrowsePathButton.Location = New System.Drawing.Point(433, 45)
        Me.BrowsePathButton.Name = "BrowsePathButton"
        Me.BrowsePathButton.Size = New System.Drawing.Size(24, 20)
        Me.BrowsePathButton.TabIndex = 4
        Me.BrowsePathButton.Text = "..."
        Me.BrowsePathButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Dauer:"
        '
        'NameTextBox
        '
        Me.NameTextBox.AccessibleDescription = "Name des Sounds"
        Me.NameTextBox.Location = New System.Drawing.Point(76, 19)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(351, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'PathTextBox
        '
        Me.PathTextBox.AccessibleDescription = "Speicherort des Sounds"
        Me.PathTextBox.Location = New System.Drawing.Point(76, 45)
        Me.PathTextBox.Name = "PathTextBox"
        Me.PathTextBox.Size = New System.Drawing.Size(351, 20)
        Me.PathTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Speicherort:"
        '
        'SoundPreviewButton
        '
        Me.SoundPreviewButton.AccessibleDescription = "Sound vorhören"
        Me.SoundPreviewButton.Location = New System.Drawing.Point(12, 299)
        Me.SoundPreviewButton.Name = "SoundPreviewButton"
        Me.SoundPreviewButton.Size = New System.Drawing.Size(75, 23)
        Me.SoundPreviewButton.TabIndex = 16
        Me.SoundPreviewButton.Text = "Vorhören"
        Me.SoundPreviewButton.UseVisualStyleBackColor = True
        '
        'PausePreviewButton
        '
        Me.PausePreviewButton.AccessibleDescription = "Vorhören pausieren"
        Me.PausePreviewButton.Location = New System.Drawing.Point(93, 299)
        Me.PausePreviewButton.Name = "PausePreviewButton"
        Me.PausePreviewButton.Size = New System.Drawing.Size(75, 23)
        Me.PausePreviewButton.TabIndex = 17
        Me.PausePreviewButton.Text = "Pause"
        Me.PausePreviewButton.UseVisualStyleBackColor = True
        Me.PausePreviewButton.Visible = False
        '
        'ConfigureSound
        '
        Me.AcceptButton = Me.ApplyButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(487, 334)
        Me.Controls.Add(Me.PausePreviewButton)
        Me.Controls.Add(Me.SoundPreviewButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.ApplyButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConfigureSound"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sound konfigurieren"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents PreviewListView As System.Windows.Forms.ListView
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents ApplyButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BrowseSymbolButton As System.Windows.Forms.Button
    Friend WithEvents SymbolTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DurationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BrowsePathButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SoundPreviewButton As System.Windows.Forms.Button
    Friend WithEvents PausePreviewButton As System.Windows.Forms.Button
End Class
