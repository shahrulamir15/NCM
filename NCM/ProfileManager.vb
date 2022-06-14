Imports System

Public Delegate Sub StatusUpdate(ByVal message As String)

''' <summary>
''' Applies profile
''' </summary>
Public Class ProfileManager

    Private _Profile As Profile
    Public Event OnStatusUpdate As StatusUpdate

    Public Sub New()

    End Sub

    Public Sub New(profile As Profile)
        Me._Profile = profile
    End Sub


    ''' <summary>
    ''' Call this to apply the specified profile for the specified NIC
    ''' </summary>
    ''' <param name="nicName"></param>
    Public Sub Run(nicName As String)
        applyNIC(nicName)
    End Sub


    ''' <summary>
    ''' Apply on all NICs
    ''' </summary>
    Public Sub Run()
        For Each nic As NICProfile In _Profile.NICProfiles
            Run(nic.Name)
        Next
    End Sub

    ''' <summary>
    ''' Applies configuration for the specified NIC
    ''' </summary>
    ''' <param name="nicName"></param>
    Private Sub applyNIC(nicName As String)

        Dim nicProfile As NICProfile = getNICProfile(nicName)

        If Nothing Is nicProfile Then Return

        UpdateStatus("Setting configuration for: " & nicName)

        Try

            If nicProfile.UseDHP Then
                WMIHelper.SetDHCP(nicName)
            Else
                WMIHelper.SetIP(nicProfile.Name, nicProfile.IP, nicProfile.Subnet, nicProfile.Gateway, nicProfile.DNS)
            End If

        Catch x As Exception
            UpdateStatus("Error occured while setting network configuration.")
            UpdateStatus(x.Message)
            Return
        End Try

        UpdateStatus("Done.")
    End Sub

    ''' <summary>
    ''' Returns the profile for the specified NIC
    ''' </summary>
    ''' <param name="nicName"></param>
    ''' <returns></returns>
    Private Function getNICProfile(nicName As String) As NICProfile

        For Each profile As NICProfile In _Profile.NICProfiles
            If profile.Name.Equals(nicName) Then Return profile
        Next

        Return Nothing
    End Function

    ''' <summary>
    ''' Raises event to update status
    ''' </summary>
    ''' <param name="message"></param>
    Private Sub UpdateStatus(ByVal message As String)
        RaiseEvent OnStatusUpdate(message & Environment.NewLine)
    End Sub


End Class
