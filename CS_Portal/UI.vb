Public Class UI
    Public Property Pass As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        switchPanel3(Home)
    End Sub
    Sub switchPanel3(ByVal panel As Form)
        Panel3.Controls.Clear()
        panel.TopLevel = False
        Panel3.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchPanel3(Profile)
     
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchPanel3(Grade)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        switchPanel3(Schedule)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        LogIn.txtSN.Text = ""
        Me.Close()
        Profile.Close()
        Grade.Close()
        Schedule.Close()
        Home.Close()
        Requirment.Close()
        LogIn.Show()

    End Sub

  
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        switchPanel3(Requirment)
    End Sub

  
    Private Sub UI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class