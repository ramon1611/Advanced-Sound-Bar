Imports AdvancedSoundBar.Functions

Public Class CategoryConfigForm
    Public ActionMode As Mode = Mode.Add
    Public SelectedCategoryIndex As Integer = 0

    Public Enum Mode As Integer
        Add = 0
        Modify = 1
        ModifyDefault = 2
    End Enum

    Private Sub CategoryForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Select Case ActionMode
                Case Mode.Add
                    NameTextBox.Clear()
                    SetDefaultCheckBox.Checked = False
                    SetDefaultCheckBox.Text = "Setze Kategorie als Standard"
                    SetDefaultCheckBox.Enabled = Not CategoriesDefaultIsSet
                Case Mode.Modify
                    NameTextBox.Text = Categories(SelectedCategoryIndex).Name
                    SetDefaultCheckBox.Checked = Categories(SelectedCategoryIndex).IsDefault
                    SetDefaultCheckBox.Text = "Setze Kategorie als Standard"
                    SetDefaultCheckBox.Enabled = Not CategoriesDefaultIsSet
                Case Mode.ModifyDefault
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
                Case Mode.Add
                    Categories.Add(New Category(NameTextBox.Text, SetDefaultCheckBox.Checked))
                Case Mode.Modify
                    Categories(SelectedCategoryIndex) = New Category(NameTextBox.Text, SetDefaultCheckBox.Checked)
                Case Mode.ModifyDefault
                    Categories(SelectedCategoryIndex) = New Category(NameTextBox.Text, Not SetDefaultCheckBox.Checked)
            End Select

            CategoryInterface.refreshCategoryList()
            Me.Close()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub
End Class