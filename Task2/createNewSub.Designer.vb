<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createNewSub
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtName = New TextBox()
        TxtEmail = New TextBox()
        TxtPhone = New TextBox()
        txtGithubLink = New TextBox()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        Label6 = New Label()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(337, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(743, 34)
        Label1.TabIndex = 0
        Label1.Text = "Ananya Gupta, Slidely Task 2 - Create Submission"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(836, 488)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 26)
        Label2.TabIndex = 1
        Label2.Text = "00:00:00"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(389, 211)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 26)
        Label3.TabIndex = 1
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(389, 280)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 26)
        Label4.TabIndex = 1
        Label4.Text = "Phone No"
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(389, 363)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 57)
        Label5.TabIndex = 1
        Label5.Text = "Github Link For Task 2"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(597, 138)
        txtName.Name = "txtName"
        txtName.Size = New Size(396, 27)
        txtName.TabIndex = 2
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(597, 210)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(396, 27)
        TxtEmail.TabIndex = 2
        ' 
        ' TxtPhone
        ' 
        TxtPhone.Location = New Point(597, 279)
        TxtPhone.Name = "TxtPhone"
        TxtPhone.Size = New Size(396, 27)
        TxtPhone.TabIndex = 2
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(597, 363)
        txtGithubLink.Multiline = True
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(396, 56)
        txtGithubLink.TabIndex = 2
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.Khaki
        btnToggleStopwatch.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnToggleStopwatch.Location = New Point(389, 481)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(369, 43)
        btnToggleStopwatch.TabIndex = 3
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = SystemColors.GradientActiveCaption
        btnSubmit.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(389, 562)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(604, 45)
        btnSubmit.TabIndex = 4
        btnSubmit.Text = "SUBMIT (CTRL +S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(389, 137)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 26)
        Label6.TabIndex = 1
        Label6.Text = "Name"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' createNewSub
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1225, 685)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(txtGithubLink)
        Controls.Add(TxtPhone)
        Controls.Add(TxtEmail)
        Controls.Add(txtName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "createNewSub"
        Text = "createNewSub"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
End Class
