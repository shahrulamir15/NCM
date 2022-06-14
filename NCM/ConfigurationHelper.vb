Imports System
Imports System.Collections
Imports System.IO
Imports System.Xml
Imports System.Runtime.Serialization.Formatters.Soap
Imports System.Runtime.Serialization
Imports System.Xml.Serialization


'''class to help configure things
''' read and load xml files
''' save configuration files
''' 
Public Class ConfigurationHelper

    'profiles name
    Private Const PROFILES_NAME As String = "Profiles.XML"

    'load the collection of profiles
    Public Shared Function LoadConfig() As ArrayList


        If (File.Exists(PROFILES_NAME)) Then
            'Use XML Deserializer to load the serialized collection
            Dim serializer As XmlSerializer = New XmlSerializer(GetType(ConfigWrapper))

            'Read profile data
            Dim reader As StreamReader = New StreamReader(PROFILES_NAME)

            'deserialize the profile collection from the file
            Dim wrapper As ConfigWrapper = CType(serializer.Deserialize(reader.BaseStream), ConfigWrapper)  'add as ConfigWrapper

            'close file handle
            reader.Close()

            Return wrapper.Profiles

        Else
            Return New ArrayList()
        End If
    End Function

    ''' <summary>
    ''' Saves the profiles in the configuration file.
    ''' </summary>
    ''' <param name="profiles"></param>
    Public Shared Sub SaveConfig(profiles As ArrayList)


        'use XML Serializer to serialize content of specific arraylist
        Dim serializer As XmlSerializer = New XmlSerializer(GetType(ConfigWrapper))

        'open Profile.xml file
        Dim writer As StreamWriter = New StreamWriter(PROFILES_NAME, False)


        Try
            Dim wrapper As ConfigWrapper = New ConfigWrapper()
            wrapper.Profiles = profiles

            'Serialize the array list to the file
            serializer.Serialize(writer.BaseStream, wrapper)

        Catch x As Exception
            Debug.WriteLine(x.Message)

        End Try

        'close the file
        writer.Close()
    End Sub
End Class

''' <summary>
''' Configuration wrapper class
''' </summary>
<XmlInclude(GetType(Profile))>
Public Class ConfigWrapper

    <XmlArrayAttribute("Profiles")>
    Public Profiles As ArrayList

End Class



