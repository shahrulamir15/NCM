Imports System
Imports System.Xml.Serialization

''' <summary>
''' Stores network card configuration for a profile
''' </summary>

Public Class NICProfile

    Public Name As String = String.Empty

    Public IP As String = String.Empty
    Public Subnet As String = String.Empty
    Public Gateway As String = String.Empty
    Public DNS As String = String.Empty
    Public UseDHP As Boolean = False

    Public Sub New()
    End Sub

    Public Sub New(name As String)
        Me.Name = name
    End Sub


    'below have function to validate IPs and others input
    Public Sub IsValid()
        Dim IPs As String() = IP.Split(","c)
        If 0 = IPs.Length Then Throw New Exception("No IP specified")

        For Each ip As String In IPs
            isValidIP(ip)
        Next

        isValidIP(Subnet)
        isValidIP(Gateway)
        Dim Dnses As String() = DNS.Split(","c)

        If Dnses.Length > 0 Then

            For Each dns As String In Dnses
                isValidIP(dns)
            Next
        End If
    End Sub

    Private Function isValidIP(ByVal IP As String) As Boolean
        Dim segments As String() = IP.Split("."c)
        If segments.Length <> 4 Then Throw New Exception("Invalid IP format. Valid format is XXX.XXX.XXX.XXX")

        For Each segment As String In segments

            Try
                Dim value As Byte = Byte.Parse(segment)
                Return True
            Catch
                Throw New Exception("Only values from 0 to 255 allowed")
            End Try
        Next

        Return False
    End Function

End Class
