Imports System.Net.Http
Imports System.Windows.Forms
Imports System.Diagnostics
Imports WinFormsApp1.viewsubmission.viewsubmissions

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class createnewsubmission
    Inherits System.Windows.Forms.Form
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
    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        title = New Label()
        user = New Label()
        email = New Label()
        contact = New Label()
        link = New Label()
        btnsubmit = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        clicker = New Button()
        SuspendLayout()
        ' 
        ' title
        ' 
        title.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        title.AutoSize = True
        title.BackColor = Color.Gainsboro
        title.Font = New Font("Calibri", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        title.ForeColor = SystemColors.ControlDarkDark
        title.Location = New Point(281, 56)
        title.Name = "title"
        title.Size = New Size(409, 27)
        title.TabIndex = 1
        title.Text = "Priya Slidely Task 2, Create New Submission"
        ' 
        ' user
        ' 
        user.AutoSize = True
        user.BackColor = Color.Transparent
        user.Location = New Point(250, 122)
        user.Name = "user"
        user.Size = New Size(59, 25)
        user.TabIndex = 15
        user.Text = "Name"
        ' 
        ' email
        ' 
        email.AutoSize = True
        email.Location = New Point(250, 171)
        email.Name = "email"
        email.Size = New Size(54, 25)
        email.TabIndex = 16
        email.Text = "Email"
        ' 
        ' contact
        ' 
        contact.AutoSize = True
        contact.Location = New Point(229, 220)
        contact.Name = "contact"
        contact.Size = New Size(106, 25)
        contact.TabIndex = 17
        contact.Text = "Phone Num"
        ' 
        ' link
        ' 
        link.AutoSize = True
        link.Location = New Point(197, 265)
        link.Name = "link"
        link.Size = New Size(150, 25)
        link.TabIndex = 18
        link.Text = "GitHub Repo Link"
        ' 
        ' btnsubmit
        ' 
        btnsubmit.Location = New Point(331, 406)
        btnsubmit.Name = "btnsubmit"
        btnsubmit.Size = New Size(255, 53)
        btnsubmit.TabIndex = 20
        btnsubmit.Text = "Submit ( Ctrl + S )"
        btnsubmit.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(377, 116)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(354, 31)
        TextBox1.TabIndex = 22
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(377, 165)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(354, 31)
        TextBox2.TabIndex = 23
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(377, 214)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(354, 31)
        TextBox3.TabIndex = 24
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(377, 265)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(354, 31)
        TextBox4.TabIndex = 25
        ' 
        ' clicker
        ' 
        clicker.Location = New Point(197, 329)
        clicker.Name = "clicker"
        clicker.Size = New Size(264, 34)
        clicker.TabIndex = 26
        clicker.Text = "Stopwatch"
        clicker.UseVisualStyleBackColor = True
        ' 
        ' createnewsubmission
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(941, 539)
        Controls.Add(clicker)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(btnsubmit)
        Controls.Add(link)
        Controls.Add(contact)
        Controls.Add(email)
        Controls.Add(user)
        Controls.Add(title)
        Name = "createnewsubmission"
        Text = "Create New Submission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents title As Label
    Friend WithEvents user As Label
    Friend WithEvents email As Label
    Friend WithEvents contact As Label
    Friend WithEvents link As Label
    Friend WithEvents btnsubmit As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents clicker As Button


    Public Class createnewsubmission
        Private stopwatch As New Stopwatch
        Private isRunning As Boolean = False

        Private WithEvents clicker As Button
        Private WithEvents btnsubmit As Button 'hange this to Button

        Private WithEvents contact As TextBox
        Private WithEvents user As TextBox
        Private WithEvents email As TextBox
        Private WithEvents link As TextBox

        Private isStarted As Boolean = False

        Private Sub clicker_Click(sender As Object, e As EventArgs) Handles clicker.Click
            If isStarted Then
                'ause functionality
                '... code to pause...
                clicker.Text = "Start" 'pdate button text
            Else
                'tart functionality
                '... code to start...
                clicker.Text = "Pause" 'pdate button text
            End If
            isStarted = Not isStarted 'oggle the flag
        End Sub
    End Class

    Private stopwatch As New Stopwatch
    Private isRunning As Boolean = False
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        ' Make API call to backend to submit form

        Dim submission As New Submission With {
            .Name = user.Text,
            .Email = email.Text,
            .Phone = contact.Text,
            .GitHubLink = link.Text,
            .StopwatchTime = stopwatch.Elapsed.ToString
        }
            Dim response As String = ApiClient.Post("submit", submission)
            If response = "True" Then
                MessageBox.Show("Submission successful!")
            Else
                MessageBox.Show("Error submitting form")
            End If
        End Sub



End Class

