Public Class ViewSubmissionsForm
    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0
    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        submissions = LoadSubmissions()
        DisplaySubmission()
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub DisplaySubmission()
        If submissions.Count > 0 Then
            txtName.Text = submissions(currentIndex).Name
            txtEmail.Text = submissions(currentIndex).Email
            txtPhone.Text = submissions(currentIndex).Phone
            txtGithub.Text = submissions(currentIndex).GitHub

        End If
    End Sub

    Private Function LoadSubmissions() As List(Of Submission)
        Return New List(Of Submission) From {
            New Submission("John Doe", "john@example.com", "9876543210", "https://github.com/johndoe")
        }

    End Function

End Class