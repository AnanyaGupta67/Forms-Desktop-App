Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class BackendService
    Private ReadOnly client As HttpClient

    Public Sub New()
        client = New HttpClient()
    End Sub

    Public Async Function PingBackend() As Task(Of String)
        Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/ping")
        If response.IsSuccessStatusCode Then
            Return Await response.Content.ReadAsStringAsync()
        Else
            Return "Error pinging backend."
        End If
    End Function

    Public Async Function SubmitData(name As String, email As String, phone As String, githubLink As String, stopwatchTime As String) As Task(Of String)
        Dim submissionData As New With {
            .name = name,
            .email = email,
            .phone = phone,
            .github_link = githubLink,
            .stopwatch_time = stopwatchTime
        }

        Dim json = JsonConvert.SerializeObject(submissionData)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
        If response.IsSuccessStatusCode Then
            Return "Submission received."
        Else
            Return "Error submitting data."
        End If
    End Function

    Public Async Function ReadData(index As Integer) As Task(Of String)
        Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
        If response.IsSuccessStatusCode Then
            Return Await response.Content.ReadAsStringAsync()
        Else
            Return "Error reading data."
        End If
    End Function
End Class
