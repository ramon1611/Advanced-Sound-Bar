<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddSound
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Kategorie", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Neuer Sound", "00:00", "C:\..."}, -1)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddSound))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PathTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddCategoryButton = New System.Windows.Forms.Button()
        Me.DurationTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.BrowsePathButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ApplyButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PreviewListView = New System.Windows.Forms.ListView()
        Me.NameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DurationColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PathColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SoundPreviewButton = New System.Windows.Forms.Button()
        Me.PausePreviewButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        'NameTextBox
        '
        Me.NameTextBox.AccessibleDescription = "Name des Sounds"
        Me.NameTextBox.Location = New System.Drawing.Point(76, 19)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(351, 20)
        Me.NameTextBox.TabIndex = 1
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
        'PathTextBox
        '
        Me.PathTextBox.AccessibleDescription = "Speicherort des Sounds"
        Me.PathTextBox.Location = New System.Drawing.Point(76, 45)
        Me.PathTextBox.Name = "PathTextBox"
        Me.PathTextBox.Size = New System.Drawing.Size(351, 20)
        Me.PathTextBox.TabIndex = 3
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddCategoryButton)
        Me.GroupBox1.Controls.Add(Me.DurationTextBox)
        Me.GroupBox1.Controls.Add(Me.CategoryComboBox)
        Me.GroupBox1.Controls.Add(Me.BrowsePathButton)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PathTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(463, 132)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Allgemeines"
        '
        'AddCategoryButton
        '
        Me.AddCategoryButton.Location = New System.Drawing.Point(433, 96)
        Me.AddCategoryButton.Name = "AddCategoryButton"
        Me.AddCategoryButton.Size = New System.Drawing.Size(24, 21)
        Me.AddCategoryButton.TabIndex = 5
        Me.AddCategoryButton.Text = "+"
        Me.AddCategoryButton.UseVisualStyleBackColor = True
        '
        'DurationTextBox
        '
        Me.DurationTextBox.AccessibleDescription = "Dauer des Sounds"
        Me.DurationTextBox.Location = New System.Drawing.Point(76, 71)
        Me.DurationTextBox.Name = "DurationTextBox"
        Me.DurationTextBox.Size = New System.Drawing.Size(351, 20)
        Me.DurationTextBox.TabIndex = 5
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.AccessibleDescription = "Kategorie des Sounds"
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(76, 97)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(351, 21)
        Me.CategoryComboBox.TabIndex = 1
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Kategorie:"
        '
        'ApplyButton
        '
        Me.ApplyButton.AccessibleDescription = "Importieren beginnen"
        Me.ApplyButton.Location = New System.Drawing.Point(318, 256)
        Me.ApplyButton.Name = "ApplyButton"
        Me.ApplyButton.Size = New System.Drawing.Size(76, 23)
        Me.ApplyButton.TabIndex = 7
        Me.ApplyButton.Text = "Importieren"
        Me.ApplyButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.AccessibleDescription = "Abbrechen"
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Location = New System.Drawing.Point(400, 256)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 8
        Me.CloseButton.Text = "Abbrechen"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PreviewListView)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 150)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(463, 100)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Vorschau"
        '
        'PreviewListView
        '
        Me.PreviewListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameColumn, Me.DurationColumn, Me.PathColumn})
        Me.PreviewListView.FullRowSelect = True
        ListViewGroup1.Header = "Kategorie"
        ListViewGroup1.Name = "PreviewGroup"
        Me.PreviewListView.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1})
        ListViewItem1.Group = ListViewGroup1
        Me.PreviewListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.PreviewListView.Location = New System.Drawing.Point(6, 19)
        Me.PreviewListView.MultiSelect = False
        Me.PreviewListView.Name = "PreviewListView"
        Me.PreviewListView.Scrollable = False
        Me.PreviewListView.Size = New System.Drawing.Size(451, 75)
        Me.PreviewListView.TabIndex = 14
        Me.PreviewListView.UseCompatibleStateImageBehavior = False
        Me.PreviewListView.View = System.Windows.Forms.View.Details
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
        Me.PathColumn.Width = 275
        '
        'SoundPreviewButton
        '
        Me.SoundPreviewButton.AccessibleDescription = "Sound vorhören"
        Me.SoundPreviewButton.Enabled = False
        Me.SoundPreviewButton.Location = New System.Drawing.Point(12, 256)
        Me.SoundPreviewButton.Name = "SoundPreviewButton"
        Me.SoundPreviewButton.Size = New System.Drawing.Size(75, 23)
        Me.SoundPreviewButton.TabIndex = 17
        Me.SoundPreviewButton.Text = "Vorhören"
        Me.SoundPreviewButton.UseVisualStyleBackColor = True
        '
        'PausePreviewButton
        '
        Me.PausePreviewButton.AccessibleDescription = "Vorhören pausieren"
        Me.PausePreviewButton.Location = New System.Drawing.Point(93, 256)
        Me.PausePreviewButton.Name = "PausePreviewButton"
        Me.PausePreviewButton.Size = New System.Drawing.Size(75, 23)
        Me.PausePreviewButton.TabIndex = 18
        Me.PausePreviewButton.Text = "Pause"
        Me.PausePreviewButton.UseVisualStyleBackColor = True
        Me.PausePreviewButton.Visible = False
        '
        'AddSound
        '
        Me.AcceptButton = Me.ApplyButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(487, 291)
        Me.Controls.Add(Me.PausePreviewButton)
        Me.Controls.Add(Me.SoundPreviewButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.ApplyButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddSound"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sound importieren"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BrowsePathButton As System.Windows.Forms.Button
    Friend WithEvents DurationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ApplyButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents SoundPreviewButton As System.Windows.Forms.Button
    Friend WithEvents PausePreviewButton As System.Windows.Forms.Button
    Friend WithEvents AddCategoryButton As System.Windows.Forms.Button
    Friend WithEvents PreviewListView As System.Windows.Forms.ListView
    Friend WithEvents NameColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents PathColumn As System.Windows.Forms.ColumnHeader
    Friend WithEvents DurationColumn As System.Windows.Forms.ColumnHeader
End Class
