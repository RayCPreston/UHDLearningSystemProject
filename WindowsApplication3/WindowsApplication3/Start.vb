Public Class Start
    Private Sub Student_Enter_Click(sender As Object, e As EventArgs) Handles Student_Enter.Click
        Me.Hide()
        Student.Show()
    End Sub

    Private Sub Admin_Enter_Click(sender As Object, e As EventArgs) Handles Admin_Enter.Click
        Me.Hide()
        Administrator.Show()
    End Sub

    Private Sub Exit_Start_Click(sender As Object, e As EventArgs) Handles Exit_Start.Click
        Me.Close()
    End Sub
End Class