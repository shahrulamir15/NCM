Imports System.Xml

Public Class Admin

    Public adminName As String
    Public adminPassword As String

    Public Sub New()

    End Sub

    Public Sub New(adminname As String, adminpassword As String)
        Me.adminName = adminname
        Me.adminPassword = adminpassword
    End Sub

    Public Function adminCheck(adminname As String, adminpassword As String, check As Boolean)

        'Load adminForm.XML files
        Dim xmlDoc As New XmlDocument()
        xmlDoc.Load("C:\Users\shaarimsa\source\repos\NCM\NCM\adminForm.xml")
        Dim nodes As XmlNodeList = xmlDoc.DocumentElement.SelectNodes("/Table/Admin")
        Dim adminId As String, adminPass As String
        Dim checkAdmin As Boolean

        'check admin credentials
        For Each node As XmlNode In nodes

            adminId = node.SelectSingleNode("adminID").InnerText
            adminPass = node.SelectSingleNode("adminPassword").InnerText

            If (adminname = adminId) And (adminpassword = adminPass) Then
                checkAdmin = True
                Exit For
            Else
                checkAdmin = False
            End If
        Next

        Return checkAdmin

    End Function

End Class
