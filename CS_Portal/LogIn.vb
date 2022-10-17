Public Class LogIn

    Private Sub ProfileBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProfileBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProfileBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProfileDataSet)

    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProfileDataSet.Profile' table. You can move, or remove it, as needed.
        Me.ProfileTableAdapter.Fill(Me.ProfileDataSet.Profile)

    End Sub

    Private Sub txtSN_MouseEnter(sender As Object, e As EventArgs) Handles txtSN.MouseEnter
        If txtSN.Text = "STUDENT NUMBER" Then
            txtSN.Text = ""
            txtSN.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSN_MouseLeave(sender As Object, e As EventArgs) Handles txtSN.MouseLeave
        If txtSN.Text = "" Then
            txtSN.Text = "STUDENT NUMBER"
            txtSN.ForeColor = Color.Silver
        End If

    End Sub

    Private Sub txtSN_TextChanged(sender As Object, e As EventArgs) Handles txtSN.TextChanged
        Me.ProfileTableAdapter.FillBy(Me.ProfileDataSet.Profile, txtSN.Text)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If StudentNoTextBox.Text = "" Then
            MsgBox("Invalid Student Number", MsgBoxStyle.OkCancel, "Message")
        ElseIf StudentNoTextBox.Text = txtSN.Text Then
            MsgBox("Log In Success", MsgBoxStyle.OkOnly, "Welcome  " + FirstNameTextBox.Text)
            UI.Show()
            Me.Hide()

        Else
            MsgBox("Invalid Student Number", MsgBoxStyle.OkCancel, "Message")
        End If
        UI.switchPanel3(Home)
    End Sub

   
End Class