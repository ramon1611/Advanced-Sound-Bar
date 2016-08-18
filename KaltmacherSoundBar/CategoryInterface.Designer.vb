<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryInterface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CategoryInterface))
        Me.CategoriesListBox = New System.Windows.Forms.ListBox()
        Me.AddCategoryButton = New System.Windows.Forms.Button()
        Me.EditCategoryButton = New System.Windows.Forms.Button()
        Me.DeleteCategoryButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CategoriesListBox
        '
        Me.CategoriesListBox.FormattingEnabled = True
        Me.CategoriesListBox.Location = New System.Drawing.Point(12, 12)
        Me.CategoriesListBox.Name = "CategoriesListBox"
        Me.CategoriesListBox.Size = New System.Drawing.Size(388, 290)
        Me.CategoriesListBox.TabIndex = 0
        '
        'AddCategoryButton
        '
        Me.AddCategoryButton.BackgroundImage = Global.AdvancedSoundBar.My.Resources.Resources.inventory_category_add
        Me.AddCategoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AddCategoryButton.Location = New System.Drawing.Point(406, 12)
        Me.AddCategoryButton.Name = "AddCategoryButton"
        Me.AddCategoryButton.Size = New System.Drawing.Size(48, 48)
        Me.AddCategoryButton.TabIndex = 1
        Me.AddCategoryButton.UseVisualStyleBackColor = True
        '
        'EditCategoryButton
        '
        Me.EditCategoryButton.BackgroundImage = Global.AdvancedSoundBar.My.Resources.Resources.inventory_category_pencil
        Me.EditCategoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.EditCategoryButton.Location = New System.Drawing.Point(406, 66)
        Me.EditCategoryButton.Name = "EditCategoryButton"
        Me.EditCategoryButton.Size = New System.Drawing.Size(48, 48)
        Me.EditCategoryButton.TabIndex = 1
        Me.EditCategoryButton.UseVisualStyleBackColor = True
        '
        'DeleteCategoryButton
        '
        Me.DeleteCategoryButton.BackgroundImage = Global.AdvancedSoundBar.My.Resources.Resources.inventory_category_delete
        Me.DeleteCategoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DeleteCategoryButton.Location = New System.Drawing.Point(406, 120)
        Me.DeleteCategoryButton.Name = "DeleteCategoryButton"
        Me.DeleteCategoryButton.Size = New System.Drawing.Size(48, 48)
        Me.DeleteCategoryButton.TabIndex = 1
        Me.DeleteCategoryButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.BackgroundImage = Global.AdvancedSoundBar.My.Resources.Resources.system_log_out
        Me.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseButton.Location = New System.Drawing.Point(406, 254)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(48, 48)
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'CategoryInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CloseButton
        Me.ClientSize = New System.Drawing.Size(466, 314)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.DeleteCategoryButton)
        Me.Controls.Add(Me.EditCategoryButton)
        Me.Controls.Add(Me.AddCategoryButton)
        Me.Controls.Add(Me.CategoriesListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CategoryInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Kategorien"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CategoriesListBox As System.Windows.Forms.ListBox
    Friend WithEvents AddCategoryButton As System.Windows.Forms.Button
    Friend WithEvents EditCategoryButton As System.Windows.Forms.Button
    Friend WithEvents DeleteCategoryButton As System.Windows.Forms.Button
    Friend WithEvents CloseButton As System.Windows.Forms.Button
End Class
