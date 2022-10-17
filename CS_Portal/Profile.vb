Public Class Profile

    Private Sub ProfileBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProfileBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProfileBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProfileDataSet)

    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProfileDataSet.Profile' table. You can move, or remove it, as needed.
        Me.ProfileTableAdapter.Fill(Me.ProfileDataSet.Profile)

    End Sub

    Private Sub StudentNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles StudentNoTextBox.TextChanged
        Me.ProfileTableAdapter.FillBy(Me.ProfileDataSet.Profile, LogIn.txtSN.Text)
    End Sub
End Class