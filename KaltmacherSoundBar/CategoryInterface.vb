Imports AdvancedSoundBar.Functions, AdvancedSoundBar.Enumerations

Public Class CategoryInterface

    Private Sub CategoryInterface_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        AdminInterface.refreshSoundsListView()
    End Sub

    Private Sub CategoryInterface_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            refreshCategoryList()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Public Sub refreshCategoryList()
        CategoriesListBox.Items.Clear()
        refreshDefaultIsSet()

        For Each category As Category In Categories
            If category.IsDefault = True Then
                CategoriesListBox.Items.Add(category.Name + " [✔]")
            Else
                CategoriesListBox.Items.Add(category.Name)
            End If
        Next
    End Sub

    Private Sub AddCategoryButton_Click(sender As System.Object, e As System.EventArgs) Handles AddCategoryButton.Click
        Try
            CategoryConfigForm.ActionMode = CategoryConfigMode.Add
            CategoryConfigForm.ShowDialog()
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub EditCategoryButton_Click(sender As System.Object, e As System.EventArgs) Handles EditCategoryButton.Click
        Try
            If CategoriesListBox.SelectedIndex >= 0 Then
                If Categories(CategoriesListBox.SelectedIndex).IsDefault = True Then
                    CategoryConfigForm.ActionMode = CategoryConfigMode.ModifyDefault
                    CategoryConfigForm.ShowDialog()
                Else
                    CategoryConfigForm.ActionMode = CategoryConfigMode.Modify
                    CategoryConfigForm.ShowDialog()
                End If
            End If
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub DeleteCategoryButton_Click(sender As System.Object, e As System.EventArgs) Handles DeleteCategoryButton.Click
        Try
            If CategoriesListBox.SelectedIndex >= 0 Then
                If Categories(CategoriesListBox.SelectedIndex).IsDefault = False Then
                    If MessageBox.Show("Wollen Sie die Kategorie """ + Categories(CategoriesListBox.SelectedIndex).Name + """ wirklich löchen?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        Categories.Remove(Categories(CategoriesListBox.SelectedIndex))
                        refreshCategoryList()
                        AdminInterface.UnsavedSettings = True
                    End If
                Else
                    MessageBox.Show("Die Kategorie """ + Categories(CategoriesListBox.SelectedIndex).Name + """ kann nicht gelöscht werden, da diese als Standard gesetzt ist!", "Löschen nicht möglich", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub

    Private Sub CategoriesListBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CategoriesListBox.SelectedIndexChanged
        Try
            CategoryConfigForm.SelectedCategoryIndex = CategoriesListBox.SelectedIndex
        Catch ex As Exception
            ThrowExceptionMessageBox(ex)
        End Try
    End Sub
End Class