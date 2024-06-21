<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        view = New Button()
        create = New Button()
        SuspendLayout()
        ' 
        ' title
        ' 
        title.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        title.AutoSize = True
        title.BackColor = Color.Gainsboro
        title.Font = New Font("Calibri", 11.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        title.ForeColor = SystemColors.ControlDarkDark
        title.Location = New Point(212, 51)
        title.Name = "title"
        title.Size = New Size(365, 27)
        title.TabIndex = 0
        title.Text = "Priya Slidely Task 2, Window Form App"
        ' 
        ' view
        ' 
        view.BackColor = Color.Khaki
        view.Font = New Font("Calibri", 10.0F)
        view.Location = New Point(258, 123)
        view.Name = "view"
        view.Size = New Size(253, 67)
        view.TabIndex = 1
        view.Text = "View Submission ( Ctrl + V )"
        view.UseVisualStyleBackColor = False
        ' 
        ' create
        ' 
        create.BackColor = Color.LightSkyBlue
        create.Font = New Font("Calibri", 10.0F)
        create.Location = New Point(203, 227)
        create.Name = "create"
        create.Size = New Size(371, 77)
        create.TabIndex = 2
        create.Text = "Create New Submissions ( Ctrl + N )"
        create.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(764, 416)
        Controls.Add(create)
        Controls.Add(view)
        Controls.Add(title)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents title As Label
    Friend WithEvents view As Button
    Friend WithEvents create As Button
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Form load event handler
    End Sub

    Private Sub view_Click(sender As Object, e As EventArgs) Handles view.Click
        Dim viewForm As New viewsubmission()
        viewForm.Show()
    End Sub

    Private Sub create_Click(sender As Object, e As EventArgs) Handles create.Click
        Dim createForm As New createnewsubmission()
        createForm.Show()
    End Sub
End Class
