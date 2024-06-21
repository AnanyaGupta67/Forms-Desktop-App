Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.IO

Public Class createNewSub
    Dim mm As Integer
    Dim ss As Integer
    Dim ms As Integer
    Dim isStopwatchRunning As Boolean = False
    Private ReadOnly backendService As BackendService
    Private ReadOnly dataLayer As DataLayer

    Public Sub New()
        InitializeComponent()
        backendService = New BackendService()
        dataLayer = New DataLayer()
    End Sub

    Private Sub createNewSub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 10
        Me.KeyPreview = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ms += 1
        If ms = 100 Then
            ms = 0
            ss += 1
            If ss = 60 Then
                ss = 0
                mm += 1
                If mm = 60 Then
                    mm = 0
                    ss = 0
                    ms = 0
                    Timer1.Stop()
                End If
            End If
        End If

        Label2.Text = String.Format("{0:00}:{1:00}:{2:00}", mm, ss, ms)
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If isStopwatchRunning Then
            Timer1.Stop()
            btnToggleStopwatch.Text = "Start Stopwatch"
        Else
            Timer1.Start()
            btnToggleStopwatch.Text = "Stop Stopwatch"
        End If

        isStopwatchRunning = Not isStopwatchRunning
    End Sub

    Private Sub createNewSub_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Collect the information from user inputs
        Dim name As String = txtName.Text
        Dim email As String = TxtEmail.Text
        Dim phone As String = TxtPhone.Text
        Dim githubLink As String = txtGithubLink.Text
        Dim stopwatchTime As String = String.Format("{0:00}:{1:00}:{2:00}", mm, ss, ms)

        ' Construct the submission object
        Dim submission As New With {
            .name = name,
            .email = email,
            .phone = phone,
            .github_link = githubLink,
            .stopwatch_time = stopwatchTime
        }

        Try
            ' Read existing submissions, add new one, and save back
            Dim submissions = dataLayer.ReadSubmissions()
            submissions.Add(submission)
            dataLayer.WriteSubmissions(submissions)

            ' Show success message
            MessageBox.Show("Submission saved successfully.")

        Catch ex As Exception
            ' Show error message if any exception occurs
            MessageBox.Show($"Error saving submission: {ex.Message}")
        End Try
    End Sub
End Class
