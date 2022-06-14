Public Class NewProfileDialog


    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        DialogResult = DialogResult.OK
        Hide()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
        Hide()
    End Sub


    Public ReadOnly Property NewProfileName As String
        Get
            Return txtName.Text
        End Get
    End Property



End Class