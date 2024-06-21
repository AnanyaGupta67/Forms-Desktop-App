<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewSubmission
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
        Label1 = New Label()
        Label2 = New Label()
        TxtName = New TextBox()
        Label3 = New Label()
        TxtEmail = New TextBox()
        Label4 = New Label()
        TxtPhone = New TextBox()
        Label5 = New Label()
        TxtGithub = New TextBox()
        Label6 = New Label()
        txtwatch = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(275, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(730, 34)
        Label1.TabIndex = 0
        Label1.Text = "Ananya Gupta, Slidely Task 2 - View Submissions"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(285, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 26)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' TxtName
        ' 
        TxtName.BackColor = SystemColors.ControlLight
        TxtName.Location = New Point(494, 129)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(429, 27)
        TxtName.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(287, 202)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 26)
        Label3.TabIndex = 3
        Label3.Text = "Email"
        ' 
        ' TxtEmail
        ' 
        TxtEmail.BackColor = SystemColors.ControlLight
        TxtEmail.Location = New Point(494, 201)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(429, 27)
        TxtEmail.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(287, 273)
        Label4.Name = "Label4"
        Label4.Size = New Size(105, 26)
        Label4.TabIndex = 5
        Label4.Text = "Phone No"
        ' 
        ' TxtPhone
        ' 
        TxtPhone.BackColor = SystemColors.ControlLight
        TxtPhone.Location = New Point(494, 272)
        TxtPhone.Name = "TxtPhone"
        TxtPhone.Size = New Size(429, 27)
        TxtPhone.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.FlatStyle = FlatStyle.System
        Label5.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(285, 349)
        Label5.Name = "Label5"
        Label5.Size = New Size(139, 54)
        Label5.TabIndex = 7
        Label5.Text = "Github Link for Task2"
        ' 
        ' TxtGithub
        ' 
        TxtGithub.BackColor = SystemColors.ControlLight
        TxtGithub.Location = New Point(494, 349)
        TxtGithub.Multiline = True
        TxtGithub.Name = "TxtGithub"
        TxtGithub.Size = New Size(435, 54)
        TxtGithub.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(285, 442)
        Label6.Name = "Label6"
        Label6.Size = New Size(125, 52)
        Label6.TabIndex = 9
        Label6.Text = "Stopwatch time"
        ' 
        ' txtwatch
        ' 
        txtwatch.BackColor = SystemColors.ControlLight
        txtwatch.Location = New Point(494, 458)
        txtwatch.Name = "txtwatch"
        txtwatch.Size = New Size(429, 27)
        txtwatch.TabIndex = 10
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Khaki
        btnPrevious.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPrevious.Location = New Point(251, 545)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(372, 47)
        btnPrevious.TabIndex = 11
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.GradientActiveCaption
        btnNext.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnNext.Location = New Point(629, 545)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(331, 47)
        btnNext.TabIndex = 12
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' viewSubmission
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1184, 685)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtwatch)
        Controls.Add(Label6)
        Controls.Add(TxtGithub)
        Controls.Add(Label5)
        Controls.Add(TxtPhone)
        Controls.Add(Label4)
        Controls.Add(TxtEmail)
        Controls.Add(Label3)
        Controls.Add(TxtName)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "viewSubmission"
        Text = "viewSubmission"
        TransparencyKey = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtGithub As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtwatch As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
