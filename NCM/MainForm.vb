Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class MainForm

    'declare arraylist of all profiles
    Private profileArray As ArrayList = New ArrayList()

#Region "Getter"

    ''' <summary>
    ''' Returns the currently selected profile object
    ''' </summary>
    Private ReadOnly Property CurrentProfile As Profile

        Get

            For Each profile As Profile In profileArray
                If profile.Name.Equals(NICProfile) Then Return profile
            Next

            Return Nothing
        End Get

    End Property



    ''' <summary>
    ''' Returns the NICProfile object for the currently selected NIC Name
    ''' </summary>
    Private ReadOnly Property CurrentNIC As NICProfile
        Get
            'find the nic profile for the currently selected nic name
            For Each profile As NICProfile In CurrentProfile.NICProfiles
                If profile.Name.Equals(NICName) Then
                    Return profile
                End If
            Next

            'not found, create a new NIC Profile
            Dim newProfile As NICProfile = New NICProfile(listNetwork.Text)
            CurrentProfile.NICProfiles.Add(newProfile)
            Return newProfile
        End Get
    End Property


    Private ReadOnly Property NICName As String
        Get
            Return TryCast(listNetwork.SelectedItem, String)
        End Get
    End Property



    Private ReadOnly Property NICProfile As String
        Get
            Return TryCast(listProfiles.SelectedItem, String)
        End Get
    End Property

#End Region





#Region "Method()"


    ''' <summary>
    ''' Load profile from configuration file
    ''' </summary>
    ''' 
    Private Sub loadProfiles()
        profileArray = ConfigurationHelper.LoadConfig()

        ' populate the profile drop down list
        listProfiles.Items.Clear()
        For Each profile As Profile In profileArray
            listProfiles.Items.Add(profile.Name)
        Next
    End Sub


    ''' <summary>
    ''' Load a particular profile
    ''' </summary>
    ''' <param name="profile"></param>
    Private Sub loadProfile(ByVal profile As Profile)
        loadNICs()
        btnActivate.Enabled = True
    End Sub

    ''' <summary>
    ''' Load NIC names in listNetworks
    ''' </summary>
    Private Sub loadNICs()

        Dim nicNames As ArrayList = WMIHelper.GetNICNames()

        listNetwork.Items.Clear()

        For Each name As String In nicNames
            listNetwork.Items.Add(name)
        Next

        If listNetwork.Items.Count > 0 Then
            listNetwork.SelectedIndex = 0
            ipConfigure.Enabled = True
        End If
    End Sub


    ''' <summary>
    ''' Show the IP, DNS, Gateway and Subnet mask for the NIC name
    ''' </summary>
    ''' <param name="nicName"></param>
    Private Sub loadNICProfile(ByVal nicName As String)
        Dim nicProfile As NICProfile = CurrentNIC
        If Nothing Is nicProfile Then Return

        inputIP.Text = nicProfile.IP
        inputSubnet.Text = nicProfile.Subnet
        inputGateway.Text = nicProfile.Gateway
        inputDNS1.Text = nicProfile.DNS
        autoIP.Checked = nicProfile.UseDHP
    End Sub


    Private Sub saveProfiles()
        ConfigurationHelper.SaveConfig(profileArray)
    End Sub


    Private Sub createNewProfile()
        Using newProfileDialog As NewProfileDialog = New NewProfileDialog()

            If DialogResult.OK = newProfileDialog.ShowDialog(Me) Then
                Dim newProfile As Profile = New Profile(newProfileDialog.NewProfileName)
                profileArray.Add(newProfile)
                listProfiles.SelectedIndex = listProfiles.Items.Add(newProfile.Name)

                'load NICs list
                loadNICs()
            End If

        End Using
    End Sub

    ''' <summary>
    ''' Loads current network configuration for the specified NIC and show in 
    ''' the current configuration block
    ''' </summary>
    ''' <param name="nicName"></param>
    Private Sub loadCurrentSetting(ByVal nicName As String)

        ''set nothing to prevent null references
        Dim ipAddresses() As String = Nothing
        Dim subnets() As String = Nothing
        Dim gateways() As String = Nothing
        Dim dnses() As String = Nothing

        WMIHelper.GetIP(nicName, ipAddresses, subnets, gateways, dnses)
        If Nothing Is ipAddresses OrElse Nothing Is subnets OrElse Nothing Is gateways OrElse Nothing Is dnses Then Return

        cIP.Text = String.Join(",", ipAddresses)
        cSubnet.Text = String.Join(",", subnets)
        cGateway.Text = String.Join(",", gateways)
        cDns1.Text = String.Join(",", dnses)

    End Sub


    'apply currently selected profile
    Private Sub applyProfile()
        Dim applyDialog As ApplySettingDialog = New ApplySettingDialog()
        applyDialog.Show()
        applyDialog.Refresh()

        applyDialog.ApplySetting(CurrentProfile)
        loadCurrentSetting(NICName)
    End Sub


    Private Sub loadApp()
        loadProfiles()
    End Sub

#End Region


#Region "EventMainFrom"

    'closing windows
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        saveProfiles()
        Close()
    End Sub

    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        saveProfiles()
        applyProfile()
    End Sub

    Private Sub listProfiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listProfiles.SelectedIndexChanged
        loadProfile(CurrentProfile)
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadApp()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        createNewProfile()
    End Sub

    Private Sub listNetwork_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listNetwork.SelectedIndexChanged

        loadNICProfile(NICName)
        loadCurrentSetting(NICName)

    End Sub

    Private Sub adminCheck_CheckedChanged(sender As Object, e As EventArgs) Handles adminCheck.CheckedChanged
        adminForm.Show()

        'control user input
        If (adminCheck.Checked) Then
            inputIP.ReadOnly = False
            inputSubnet.ReadOnly = False
            inputGateway.ReadOnly = False
            inputDNS1.ReadOnly = False
            'inputDNS1.ReadOnly = False
            LinkLabel1.Visible = True
        ElseIf (Not adminCheck.Checked) Then
            inputIP.ReadOnly = True
            inputSubnet.ReadOnly = True
            inputGateway.ReadOnly = True
            inputDNS1.ReadOnly = True
            'inputDNS1.ReadOnly = True
            LinkLabel1.Visible = False
        End If

    End Sub

    'Private Sub chkDHCP_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim allowIP = Not autoIP.Checked
    '    'inputIP.Enabled = CSharpImpl.__Assign(txtSubnet.Enabled, CSharpImpl.__Assign(txtGateway.Enabled, CSharpImpl.__Assign(txtDNS.Enabled, allowIP)))
    '    CurrentNIC.UseDHP = autoIP.Checked
    'End Sub

    Private Sub MainForm_Closing(ByVal sender As Object, ByVal e As CancelEventArgs)
        saveProfiles()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        saveProfiles()
    End Sub

    Private Sub autoIP_CheckedChanged(sender As Object, e As EventArgs) Handles autoIP.CheckedChanged

        If (autoIP.Checked) Then
            inputIP.Enabled = False
            inputSubnet.Enabled = False
            inputGateway.Enabled = False
            inputDNS1.Enabled = False
        ElseIf (Not autoIP.Checked) Then
            inputIP.Enabled = True
            inputSubnet.Enabled = True
            inputGateway.Enabled = True
            inputDNS1.Enabled = True
        End If

        CurrentNIC.UseDHP = autoIP.Checked
    End Sub


    Private Sub inputIP_Leave(sender As Object, e As EventArgs) Handles inputIP.Leave
        CurrentNIC.IP = inputIP.Text
    End Sub

    Private Sub inputSubnet_Leave(sender As Object, e As EventArgs) Handles inputSubnet.Leave
        CurrentNIC.Subnet = inputSubnet.Text
    End Sub

    Private Sub inputGateway_Leave(sender As Object, e As EventArgs) Handles inputGateway.Leave
        CurrentNIC.Gateway = inputGateway.Text
    End Sub

    Private Sub inputDNS1_Leave(sender As Object, e As EventArgs) Handles inputDNS1.Leave
        CurrentNIC.DNS = inputDNS1.Text
    End Sub

    'Private Sub inputPreferDNS_Leave(sender As Object, e As EventArgs) Handles inputPreferDNS.Leave
    '    CurrentNIC.DNS = inputPreferDNS.Text
    'End Sub


#End Region
End Class
