<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SlidelyForm
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
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Khaki
        Button1.Location = New Point(416, 234)
        Button1.Margin = New Padding(4, 3, 4, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(694, 64)
        Button1.TabIndex = 1
        Button1.Text = "VIEW SUBMISSION ( CTRL + V)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.GradientActiveCaption
        Button2.Location = New Point(416, 337)
        Button2.Name = "Button2"
        Button2.Size = New Size(694, 59)
        Button2.TabIndex = 2
        Button2.Text = "CREATE NEW SUBMISSION (CTRL + N)" & vbCrLf & vbCrLf
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(394, 48)
        Label1.Name = "Label1"
        Label1.Size = New Size(716, 34)
        Label1.TabIndex = 3
        Label1.Text = "Ananya Gupta, Slidely Task 2 - Slidely Form App"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11.0F, 22.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1558, 746)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Font = New Font("Times New Roman", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label

End Class
