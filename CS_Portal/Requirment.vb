Public Class Requirment

    Private Sub RequirmentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RequirmentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RequirmentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RequirmentDataSet)

    End Sub

    Private Sub Requirment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RequirmentDataSet.Requirment' table. You can move, or remove it, as needed.
        Me.RequirmentTableAdapter.Fill(Me.RequirmentDataSet.Requirment)

        If Form138CheckBox.Checked = False Then
            Label2.Text = "Please Submit your form 138 as soon as possible"
        End If
        If NSOCheckBox.Checked = False Then
            Label3.Text = "Please Submit your NSO as soon as possible"
        End If
        If Certificate_Of_GraduationCheckBox.Checked = False Then
            Label4.Text = "Please Submit your Certificate of Graduation as soon as possible"
        End If
        If Certificate_Of_Good_MoralCheckBox.Checked = False Then
            Label5.Text = "Please Submit your Good Moral as soon as possible"
        End If
    End Sub

    Private Sub StudentNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles StudentNoTextBox.TextChanged
        Me.RequirmentTableAdapter.FillBy(Me.RequirmentDataSet.Requirment, LogIn.txtSN.Text)
    End Sub
End Class