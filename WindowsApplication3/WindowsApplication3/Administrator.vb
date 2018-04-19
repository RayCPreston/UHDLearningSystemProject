Public Class Administrator
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvStudentList.SelectedRows.Count > 0 Then
            Select Case MsgBox("Delete this student?", MsgBoxStyle.YesNo, "Delete Student")
                Case MsgBoxResult.Yes
                    dgvStudentList.Rows.RemoveAt(dgvStudentList.CurrentRow.Index)
                Case MsgBoxResult.No
            End Select
            'MessageBox.Show("Delete this Student?", "Delete Student?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        frmStudentInfo.ShowDialog()

    End Sub

    Private Sub Administrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvStudentList.Rows.Add()
        dgvStudentList.Rows(0).Cells(0).Value = "meow"
        dgvStudentList.Rows(0).Cells(1).Value = "mix"


    End Sub

    Private Sub btnVE_Click(sender As Object, e As EventArgs) Handles btnVE.Click




    End Sub
End Class