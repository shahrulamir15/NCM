Imports System
Imports System.Collections
Imports System.Management
Imports System.Runtime.InteropServices

''' <summary>
''' A Helper class which provides convenient methods to set/get network
''' configuration
''' </summary>
Public Class WMIHelper

    ''' <summary>
    ''' Enable DHCP on the NIC
    ''' </summary>
    ''' <param name="nicName">Name of the NIC</param>
    Public Shared Sub SetDHCP(ByVal nicName As String)
        Dim objMC As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim objMOC As ManagementObjectCollection = objMC.GetInstances()
        'Dim objMO As ManagementObject
        For Each objMO As ManagementObject In objMOC
            'Make sure this is enabled device. Not VMWare or memory card
            If objMO("IPEnabled") Then
                If objMO("Caption").Equals(nicName) Then
                    Dim newDNS = objMO.GetMethodParameters("SetDNSServerSearchOrder")
                    newDNS("DNSServerSearchOrder") = Nothing
                    Dim enableDHCP = objMO.InvokeMethod("EnableDHCP", Nothing, Nothing)
                    Dim setDNS = objMO.InvokeMethod("SetDNSServerSearchOrder", newDNS, Nothing)
                End If
            End If
        Next


    End Sub


    ''' <summary>
    ''' Set IP for the specified network card name
    ''' </summary>
    ''' <param name="nicName">Caption of the network card</param>
    ''' <param name="IpAddresses">Comma delimited string containing one or more IP</param>
    ''' <param name="SubnetMask">Subnet mask</param>
    ''' <param name="Gateway">Gateway IP</param>
    ''' <param name="dnsSearch">Comma delimited DNS IP</param>
    Public Shared Sub SetIP(ByVal nicName As String, ByVal IpAddresses As String, ByVal SubnetMask As String, ByVal gateway As String, ByVal dnsSearch As String)
        Dim objMC As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim objMOC As ManagementObjectCollection = objMC.GetInstances()

        'Dim objMO As ManagementObject
        For Each objMO As ManagementObject In objMOC
            'Make sure this is enabled device. Not VMWare or memory card
            If objMO("IPEnabled") Then


                If (objMO("Caption").Equals(nicName)) Then

                    Dim objNewIP As ManagementBaseObject = objMO.GetMethodParameters("EnableStatic")
                    Dim objNewGate As ManagementBaseObject = objMO.GetMethodParameters("SetGateways")
                    Dim objNewDns As ManagementBaseObject = objMO.GetMethodParameters("SetDNSServerSearchOrder")

                    'Set DefaultGateway
                    objNewGate("DefaultIPGateway") = New String() {gateway}
                    objNewGate("GatewayCostMetric") = New Integer() {1}

                    'Set IPAddress and Subnet Mask
                    objNewIP("IPAddress") = IpAddresses.Split(","c)     'major changes
                    objNewIP("SubnetMask") = New String() {SubnetMask}

                    'Set DNS
                    objNewDns("DNSServerSearchOrder") = dnsSearch.Split(","c)

                    Dim setIP = objMO.InvokeMethod("EnableStatic", objNewIP, Nothing)
                    Dim setGateways = objMO.InvokeMethod("SetGateways", objNewGate, Nothing)
                    Dim setDns = objMO.InvokeMethod("SetDNSServerSearchOrder", objNewDns, Nothing)

                    Exit For

                End If
            End If

        Next

    End Sub

    ''' <summary>
    ''' Returns the network card configuration of the specified NIC
    ''' </summary>
    ''' <param name="nicName">Name of the NIC</param>
    ''' <param name="ipAddresses">Array of IP</param>
    ''' <param name="subnets">Array of subnet masks</param>
    ''' <param name="gateways">Array of gateways</param>
    ''' <param name="dnses">Array of DNS IP</param>
    Public Shared Sub GetIP(ByVal nicName As String, <Out> ByRef ipAddresses() As String, <Out> ByRef subnets() As String, <Out> ByRef gateways() As String, <Out> ByRef dnses() As String) 'buang <Out> kejap

        ipAddresses = Nothing
        subnets = Nothing
        gateways = Nothing
        dnses = Nothing

        Dim objMC As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim objMOC As ManagementObjectCollection = objMC.GetInstances()

        'Dim objMO As ManagementObject

        For Each objMO As ManagementObject In objMOC
            'Make sure this is enabled device. Not VMWare or memory card
            If objMO("ipEnabled") Then


                If (objMO("Caption").Equals(nicName)) Then

                    'major changes CType
                    ipAddresses = CType(objMO("IPAddress"), String())
                    subnets = CType(objMO("IPSubnet"), String())
                    gateways = CType(objMO("DefaultIPGateway"), String())
                    dnses = CType(objMO("DNSServerSearchOrder"), String())

                    Exit For

                End If
            End If
        Next

    End Sub



    ''' <summary>
    ''' Returns the list of Network Interfaces installed
    ''' Return Intel Wifi, Ethernet,...
    ''' </summary>
    ''' <returns>Array list of string</returns>
    Public Shared Function GetNICNames() As ArrayList
        Dim nicNames As ArrayList = New ArrayList()

        Dim objMC As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim objMOC As ManagementObjectCollection = objMC.GetInstances()

        For Each objMO As ManagementObject In objMOC
            If objMO("ipEnabled") Then
                nicNames.Add(objMO("Caption"))
            End If
        Next

        Return nicNames
    End Function




End Class
