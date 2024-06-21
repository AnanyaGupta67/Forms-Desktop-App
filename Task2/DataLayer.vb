Imports System.IO
Imports Newtonsoft.Json

Public Class DataLayer
    Private ReadOnly filePath As String = "C:\Users\hp\source\repos\Task2Backend\Task2Backend\src\db.json"

    Public Function ReadSubmissions() As List(Of Object)
        If File.Exists(filePath) Then
            Dim submissionsJson As String = File.ReadAllText(filePath)
            Dim submissions = JsonConvert.DeserializeObject(Of List(Of Object))(submissionsJson)
            Return If(submissions, New List(Of Object)())
        Else
            Return New List(Of Object)()
        End If
    End Function

    Public Sub WriteSubmissions(submissions As List(Of Object))
        Dim updatedJson As String = JsonConvert.SerializeObject(submissions, Formatting.Indented)
        File.WriteAllText(filePath, updatedJson)
    End Sub
End Class

