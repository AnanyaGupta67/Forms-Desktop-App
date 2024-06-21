Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class SlidelyForm
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        viewSubmission.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        createNewSub.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            Button1.PerformClick()
        End If

        If e.Control AndAlso e.KeyCode = Keys.N Then
            Button2.PerformClick()
        End If
    End Sub
End Class
