Imports System.Diagnostics

Public Class CreateSubmissionForm
    Private stopwatch As Stopwatch
    Private stopwatchRunning As Boolean = False

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stopwatch = New Stopwatch()
        lblStopwatch.Text = "00:00:00"
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission(txtName.Text, txtEmail.Text, txtPhone.Text, txtGithub.Text)
        SaveSubmission(submission)
        MessageBox.Show("Submission saved!")
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        stopwatchRunning = Not stopwatchRunning
        UpdateStopwatch()
    End Sub

    Private Sub SaveSubmission(submission As Submission)
        ' Save the submission to a data source, e.g., a file or database
    End Sub

    Private Sub UpdateStopwatch()
        lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.S) Then
            btnSubmit.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GitHub As String

    Public Sub New(name As String, email As String, phone As String, github As String)
        Me.Name = name
        Me.Email = email
        Me.Phone = phone
        Me.GitHub = github
    End Sub
End Class
