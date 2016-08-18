Imports AdvancedSoundBar.Functions, AdvancedSoundBar.Enumerations

Public Class CategoryConfigForm
    Public ActionMode As CategoryConfigMode = CategoryConfigMode.Add
    Public SelectedCategoryIndex As Integer = 0

    Private Sub CategoryForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Select Case ActionMode
                Case CategoryConfigMode.Add
                    NameTextBox.Clear()
                    SetDefaultCheckBox.Checked = False
                    SetDefaultCheckBox.Text = "Setze Kategorie als Standard"
                    SetDefaultCheckBox.Enabled = Not CategoriesDefaultIsSet
                Case CategoryConfigMode.Modify
                    NameTextBox.Text = Categories(SelectedCategoryIndex).Name
                    SetDefaultCheckBox.Checked = Categories(SelectedCategoryIndex).IsDefault
                    SetDefaultCheckBox.Text = "Setze Kategorie als Standard"
                    SetDefaultCheckBox.Enabled = Not CategoriesDefaultIsSet
                Case CategoryConfigMode.ModifyDefault
                    NameTextBox.Text = Categories(SelectedCategoryIndex).Name
                    SetDefaultCheckBox.Checked = False
                    SetDefaultCheckBox.Text = "Kategorie als Standard entfernen"
                    SetDefaultCheckBox.Enabled = True
                Case Else
            End Select
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub CloseButton_Click(sender As System.Object, e As System.EventArgs) Handles CloseButton.Click
        Try
            Me.Close()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub SaveButton_Click(sender As System.Object, e As System.EventArgs) Handles SaveButton.Click
        Try
            Select Case ActionMode
                Case CategoryConfigMode.Add
                    Categories.Add(New Category(NameTextBox.Text, SetDefaultCheckBox.Checked))
                Case CategoryConfigMode.Modify
                    Categories(SelectedCategoryIndex) = New Category(NameTextBox.Text, SetDefaultCheckBox.Checked)
                Case CategoryConfigMode.ModifyDefault
                    Categories(SelectedCategoryIndex) = New Category(NameTextBox.Text, Not SetDefaultCheckBox.Checked)
            End Select

            CategoryInterface.refreshCategoryList()
            Me.Close()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub
End Class