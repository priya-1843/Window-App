Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewsubmission
    Inherits System.Windows.Forms.Form


    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        title = New Label()
        user = New Label()
        email = New Label()
        contact = New Label()
        link = New Label()
        timer = New Label()
        prev = New Button()
        agla = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        SuspendLayout()
        ' 
        ' title
        ' 
        title.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        title.AutoSize = True
        title.BackColor = Color.Gainsboro
        title.Font = New Font("Calibri", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        title.ForeColor = SystemColors.ControlDarkDark
        title.Location = New Point(248, 34)
        title.Name = "title"
        title.Size = New Size(347, 27)
        title.TabIndex = 1
        title.Text = "Priya Slidely Task 2, View Submission"
        ' 
        ' user
        ' 
        user.AutoSize = True
        user.BackColor = Color.Transparent
        user.Location = New Point(208, 109)
        user.Name = "user"
        user.Size = New Size(59, 25)
        user.TabIndex = 2
        user.Text = "Name"
        ' 
        ' email
        ' 
        email.AutoSize = True
        email.Location = New Point(208, 158)
        email.Name = "email"
        email.Size = New Size(54, 25)
        email.TabIndex = 3
        email.Text = "Email"
        ' 
        ' contact
        ' 
        contact.AutoSize = True
        contact.Location = New Point(187, 207)
        contact.Name = "contact"
        contact.Size = New Size(106, 25)
        contact.TabIndex = 4
        contact.Text = "Phone Num"
        ' 
        ' link
        ' 
        link.AutoSize = True
        link.Location = New Point(155, 252)
        link.Name = "link"
        link.Size = New Size(150, 25)
        link.TabIndex = 5
        link.Text = "GitHub Repo Link"
        ' 
        ' timer
        ' 
        timer.AutoSize = True
        timer.Location = New Point(155, 312)
        timer.Name = "timer"
        timer.Size = New Size(138, 25)
        timer.TabIndex = 6
        timer.Text = "Stopwatch Time"
        ' 
        ' prev
        ' 
        prev.Location = New Point(138, 391)
        prev.Name = "prev"
        prev.Size = New Size(255, 53)
        prev.TabIndex = 7
        prev.Text = "Previous ( Ctrl + P )"
        prev.UseVisualStyleBackColor = True
        ' 
        ' agla
        ' 
        agla.Location = New Point(438, 391)
        agla.Name = "agla"
        agla.Size = New Size(251, 53)
        agla.TabIndex = 8
        agla.Text = "Next ( Ctrl + N )"
        agla.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(335, 103)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(354, 31)
        TextBox1.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(335, 152)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(354, 31)
        TextBox2.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(335, 201)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(354, 31)
        TextBox3.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(335, 252)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(354, 31)
        TextBox4.TabIndex = 12
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(335, 306)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(354, 31)
        TextBox5.TabIndex = 13
        ' 
        ' viewsubmission
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(891, 500)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(agla)
        Controls.Add(prev)
        Controls.Add(timer)
        Controls.Add(link)
        Controls.Add(contact)
        Controls.Add(email)
        Controls.Add(user)
        Controls.Add(title)
        Name = "viewsubmission"
        Text = "viewsubmission"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents title As Label
    Friend WithEvents user As Label
    Friend WithEvents email As Label
    Friend WithEvents contact As Label
    Friend WithEvents link As Label
    Friend WithEvents timer As Label
    Friend WithEvents prev As Button
    Friend WithEvents agla As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox



    Public Class viewsubmissions
        Private currentIndex As Integer = 0
        Private submissions As List(Of Submission)

        Public Class Submission
            Public Property Name As String
            Public Property Email As String
            Public Property Phone As String
            Public Property GitHubLink As String
            Public Property StopwatchTime As String
        End Class

        Public Class ApiClient
            Private Shared client As New HttpClient

            Public Shared Function Geet(endpoint As String) As String
                Dim response As HttpResponseMessage = client.GetAsync(endpoint).Result
                Return response.Content.ReadAsStringAsync.Result
            End Function

            Public Shared Function Post(endpoint As String, data As Object) As String
                Dim content As New StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json")
                Dim response As HttpResponseMessage = client.PostAsync(endpoint, content).Result
                Return response.Content.ReadAsStringAsync.Result
            End Function
        End Class
        Private WithEvents prev As TextBox
        Private WithEvents agla As TextBox


        Public Sub New()
            LoadSubmissions()
        End Sub

        Private Sub LoadSubmissions()
            ' Make API call to backend to retrieve submissions
            Dim response As String = ApiClient.Geet("read")
            submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(response)
        End Sub

        Private Sub prev_Click(sender As Object, e As EventArgs) Handles prev.Click
            If currentIndex > 0 Then
                currentIndex -= 1
                DisplaySubmission()
            End If
        End Sub

        Private Sub agla_Click(sender As Object, e As EventArgs) Handles agla.Click
            If currentIndex < submissions.Count - 1 Then
                currentIndex += 1
                DisplaySubmission()
            End If
        End Sub
        Private WithEvents contact As TextBox
        Private WithEvents user As TextBox
        Private WithEvents email As TextBox
        Private WithEvents link As TextBox
        Private WithEvents timer As TextBox


        Private Sub DisplaySubmission()
            'isplay the current submission

            Dim submission As Submission = submissions(currentIndex)

            'ssuming that user, email, contact, link, and timer are controls on your form
            If Me.user IsNot Nothing Then
                Me.user.Text = submission.Name
            End If
            If Me.email IsNot Nothing Then
                Me.email.Text = submission.Email
            End If
            If Me.contact IsNot Nothing Then
                Me.contact.Text = submission.Phone
            End If
            If Me.link IsNot Nothing Then
                Me.link.Text = submission.GitHubLink
            End If
            If Me.timer IsNot Nothing Then
                Me.timer.Text = submission.StopwatchTime
            End If
        End Sub


    End Class



End Class
