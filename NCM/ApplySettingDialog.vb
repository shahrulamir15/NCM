Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

''' <summary>
''' Shows progress and status of process while applying profile
''' </summary>
Public Class ApplySettingDialog
    Friend Sub ApplySetting(ByVal profile As Profile)
        lblProfileName.Text = profile.Name

        Dim manager As ProfileManager = New ProfileManager(profile)
        AddHandler manager.OnStatusUpdate, New StatusUpdate(AddressOf manager_OnStatusUpdate)
        manager.Run()
        btnOK.Enabled = True
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
        Call Application.[Exit]()
    End Sub

    Private Sub btnOK_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    ''' <summary>
    ''' Callback function for ProfileManager to show messages
    ''' </summary>
    ''' <param name="message"></param>
    Private Sub manager_OnStatusUpdate(ByVal message As String)
        txtStatus.AppendText(message)
    End Sub

    Private Sub btnOK_Click_1(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()

    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Hide()

    End Sub

    Private Sub ApplySettingDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class