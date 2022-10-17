Public Class Grade

    Private Sub MidtermGradeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MidtermGradeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MidtermGradeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProfileDataSet)

    End Sub

    Private Sub Grade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProfileDataSet.FinalGrade' table. You can move, or remove it, as needed.
        Me.FinalGradeTableAdapter.Fill(Me.ProfileDataSet.FinalGrade)
        'TODO: This line of code loads data into the 'ProfileDataSet.MidtermGrade' table. You can move, or remove it, as needed.
        Me.MidtermGradeTableAdapter.Fill(Me.ProfileDataSet.MidtermGrade)

        'Midterm
        Dim a As Decimal
        Dim b As Decimal
        Dim c As Decimal
        Dim d As Decimal
        Dim d1 As Decimal
        Dim f As Decimal
        Dim g As Decimal
        Dim h As Decimal
        Dim i As Decimal
        Dim j As Decimal
        Dim k As Decimal
        Dim gwa As Decimal
        a = Val(Communicative_Proficiency_in_Business_Correspondence_and_ResearcTextBox.Text)
        b = Val(Discrete_StructureTextBox.Text)
        c = Val(Object_Oriented_Programming_LectureTextBox.Text)
        d = Val(Object_Oriented_Programming__Laboratory_TextBox.Text)
        d1 = Val(Digital_Logic_Design_Lecture_TextBox.Text)
        f = Val(Digital_Logic_Design__LaboratoryTextBox.Text)
        g = Val(Data_Structure_and_Algorithm__Lecture_TextBox.Text)
        h = Val(Data_Structure_and_Algorthm_Laboratory_TextBox.Text)
        i = Val(Physics_for_Computer_Scientist_Lecture_TextBox.Text)
        j = Val(Physics_for_Computer_Scientist_Laboratory_TextBox.Text)
        k = Val(Physical_Activity_Towards_Health_and_Fitness_1TextBox.Text)

        gwa = Convert.ToDouble(a + b + c + d + d1 + f + g + h + i + j + k) / 11
        TextBox1.Text = gwa

        'Finals
        Dim a2 As Decimal
        Dim b2 As Decimal
        Dim c2 As Decimal
        Dim d2 As Decimal
        Dim d12 As Decimal
        Dim f2 As Decimal
        Dim g2 As Decimal
        Dim h2 As Decimal
        Dim i2 As Decimal
        Dim j2 As Decimal
        Dim k2 As Decimal
        Dim gwa2 As Decimal
        a2 = Val(Communicative_Proficiency_in_Business_Correspondence_and_ResearcTextBox1.Text)
        b2 = Val(Discrete_StructureTextBox1.Text)
        c2 = Val(Object_Oriented_Programming_LectureTextBox1.Text)
        d2 = Val(Object_Oriented_Programming__Laboratory_TextBox1.Text)
        d12 = Val(Digital_Logic_Design_Lecture_TextBox1.Text)
        f2 = Val(Digital_Logic_Design__LaboratoryTextBox1.Text)
        g2 = Val(Data_Structure_and_Algorithm__Lecture_TextBox1.Text)
        h2 = Val(Data_Structure_and_Algorthm_Laboratory_TextBox1.Text)
        i2 = Val(Physics_for_Computer_Scientist_Lecture_TextBox1.Text)
        j2 = Val(Physics_for_Computer_Scientist_Laboratory_TextBox1.Text)
        k2 = Val(Physical_Activity_Towards_Health_and_Fitness_1TextBox1.Text)

        gwa2 = Convert.ToDouble(a2 + b2 + c2 + d2 + d12 + f2 + g2 + h2 + i2 + j2 + k2) / 11
        TextBox2.Text = gwa2
    End Sub


    Private Sub StudentNoTextBox1_TextChanged(sender As Object, e As EventArgs) Handles StudentNoTextBox1.TextChanged
        Me.FinalGradeTableAdapter.FillBy(Me.ProfileDataSet.FinalGrade, LogIn.txtSN.Text)
    End Sub

    Private Sub StudentNoTextBox_TextChanged(sender As Object, e As EventArgs) Handles StudentNoTextBox.TextChanged
        Me.MidtermGradeTableAdapter.FillBy(Me.ProfileDataSet.MidtermGrade, LogIn.txtSN.Text)
    End Sub

  
  
End Class