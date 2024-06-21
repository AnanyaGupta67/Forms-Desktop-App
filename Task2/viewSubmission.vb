Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class viewSubmission
    Private ReadOnly backendService As BackendService

    Public Sub New()
        InitializeComponent()
        backendService = New BackendService()
    End Sub

    Private Sub viewSubmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Additional initialization code can go here
    End Sub

    Private Async Sub btnFetchSubmission_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim index As Integer = 0 ' Set the index of the submission you want to fetch
        Dim result As String = Await backendService.ReadData(index)
        btnPrevious.Text = result
    End Sub
End Class
