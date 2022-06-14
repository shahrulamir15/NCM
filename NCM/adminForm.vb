Public Class adminForm

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim admin As New Admin
        Dim checking As Boolean = False

        checking = admin.adminCheck(Trim(inputAdminID.Text), Trim(inputAdminPassword.Text), checking)

        If (checking = True) Then
            MainForm.adminCheck.Checked = True
            MainForm.Enabled = True
            Me.Close()

        ElseIf (checking = False) Then
            MainForm.adminCheck.Checked = False
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainForm.adminCheck.Checked = False
        Me.Close()
        MainForm.Enabled = True
    End Sub

    Private Sub adminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainForm.Enabled = False
    End Sub
End Class