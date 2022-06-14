Imports System
Imports System.Xml.Serialization
Imports System.Collections

''' <summary>
''' Store a profile information.
''' </summary>
<XmlInclude(GetType(NICProfile))>
Public Class Profile

    Public Name As String = String.Empty   'e.g HOYA Profiles, HOME Profiles

    ''' <summary>
    ''' tell the xmlserializer to treat the property as array and 
    ''' serialize it according its parameters for the element names
    ''' </summary>

    <XmlArray("NICProfiles")>
    Public NICProfiles As ArrayList = New ArrayList()   'Collect NIC setting of the profiles 


    'default constructor
    Public Sub New()

    End Sub

    'normal constructor
    'Me.Name is important to write XML
    Public Sub New(ByVal name As String)
        Me.Name = name
    End Sub


End Class
