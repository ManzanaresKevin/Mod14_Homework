
Public Class StudentInfo
    Dim realStudent As New Student
    Private Sub txtInst_TextChanged(sender As Object, e As EventArgs) Handles txtInst.TextChanged


        If txtInst.Text = "W. Sean" Then
            txtInst.Enabled = False
            MessageBox.Show("Great, now next step (Choose Course)")

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        realStudent.Last_name = txtStudentLast.Text
        realStudent.email = txtStudentmail.Text
        realStudent.StudentNumb = txtStudentNum.Text
        MessageBox.Show("data transfered")
    End Sub
End Class