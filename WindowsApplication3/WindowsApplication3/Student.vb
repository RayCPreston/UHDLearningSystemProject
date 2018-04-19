Public Class Student
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        If dgvStudentList.SelectedRows.Count > 0 Then
            Dim result As Integer = MessageBox.Show("message", "caption", MessageBoxButtons.YesNo)
            Select Case MsgBox("Delete this student?", MsgBoxStyle.YesNo, "Delete Student?")
                Case MsgBoxResult.Yes
                    dgvStudentList.Rows.RemoveAt(dgvStudentList.CurrentRow.Index)
                Case MsgBoxResult.No
            End Select
            'MessageBox.Show("Delete this Student?", "Delete Student?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)


        frmStudentInfo.ShowDialog()

    End Sub
End Class