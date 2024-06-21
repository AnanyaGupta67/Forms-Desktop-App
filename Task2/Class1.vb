Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class Class1
    Private ReadOnly baseUrl As String = "http://localhost:3000" ' Replace with your actual backend URL

    Public Async Function SubmitData(name As String, email As String, phone As String, githubLink As String, stopwatchTime As String) As Task(Of String)
        Try
            Dim submissionData As New With {
                .name = name,
                .email = email,
                .phone = phone,
                .github_link = githubLink,
                .stopwatch_time = stopwatchTime
            }

            Dim json = JsonConvert.SerializeObject(submissionData)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")

            Using client As New HttpClient()
                Dim response = Await client.PostAsync($"{baseUrl}/submit", content)

                If response.IsSuccessStatusCode Then
                    Return "Submission successful"
                Else
                    Return "Submission failed"
                End If
            End Using

        Catch ex As Exception
            Return $"Error submitting data: {ex.Message}"
        End Try
    End Function

    Public Async Function ReadData(index As Integer) As Task(Of String)
        Try
            Using client As New HttpClient()
                Dim response = Await client.GetAsync($"{baseUrl}/read?index={index}")

                If response.IsSuccessStatusCode Then
                    Dim json = Await response.Content.ReadAsStringAsync()
                    Return json
                Else
                    Return $"Error fetching data: {response.StatusCode}"
                End If
            End Using

        Catch ex As Exception
            Return $"Error fetching data: {ex.Message}"
        End Try
    End Function
End Class

