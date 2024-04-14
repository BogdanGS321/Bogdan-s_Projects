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
        tbxMin = New TextBox()
        tbxMax = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btnGenerate = New Button()
        tboxGuess = New TextBox()
        lblApproach1 = New Label()
        lblApproach2 = New Label()
        btnGuess = New Button()
        LabelMaiMareMaiMic = New Label()
        btnStats = New Button()
        tbxStats = New TextBox()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' tbxMin
        ' 
        tbxMin.Location = New Point(92, 33)
        tbxMin.Name = "tbxMin"
        tbxMin.Size = New Size(100, 23)
        tbxMin.TabIndex = 0
        ' 
        ' tbxMax
        ' 
        tbxMax.Location = New Point(372, 33)
        tbxMax.Name = "tbxMax"
        tbxMax.Size = New Size(100, 23)
        tbxMax.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 2
        Label1.Text = "Minimum"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(304, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(62, 15)
        Label2.TabIndex = 3
        Label2.Text = "Maximum"
        ' 
        ' btnGenerate
        ' 
        btnGenerate.Location = New Point(217, 87)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(115, 23)
        btnGenerate.TabIndex = 4
        btnGenerate.Text = "Generate number"
        btnGenerate.UseVisualStyleBackColor = True
        ' 
        ' tboxGuess
        ' 
        tboxGuess.Enabled = False
        tboxGuess.Location = New Point(200, 145)
        tboxGuess.Name = "tboxGuess"
        tboxGuess.Size = New Size(152, 23)
        tboxGuess.TabIndex = 5
        ' 
        ' lblApproach1
        ' 
        lblApproach1.AutoSize = True
        lblApproach1.Location = New Point(178, 148)
        lblApproach1.Name = "lblApproach1"
        lblApproach1.Size = New Size(0, 15)
        lblApproach1.TabIndex = 6
        ' 
        ' lblApproach2
        ' 
        lblApproach2.AutoSize = True
        lblApproach2.Location = New Point(358, 148)
        lblApproach2.Name = "lblApproach2"
        lblApproach2.Size = New Size(0, 15)
        lblApproach2.TabIndex = 7
        ' 
        ' btnGuess
        ' 
        btnGuess.Enabled = False
        btnGuess.Location = New Point(239, 174)
        btnGuess.Name = "btnGuess"
        btnGuess.Size = New Size(75, 23)
        btnGuess.TabIndex = 9
        btnGuess.Text = "Guess"
        btnGuess.UseVisualStyleBackColor = True
        ' 
        ' LabelMaiMareMaiMic
        ' 
        LabelMaiMareMaiMic.AutoSize = True
        LabelMaiMareMaiMic.Location = New Point(200, 127)
        LabelMaiMareMaiMic.Name = "LabelMaiMareMaiMic"
        LabelMaiMareMaiMic.Size = New Size(0, 15)
        LabelMaiMareMaiMic.TabIndex = 10
        ' 
        ' btnStats
        ' 
        btnStats.Location = New Point(12, 246)
        btnStats.Name = "btnStats"
        btnStats.Size = New Size(75, 23)
        btnStats.TabIndex = 11
        btnStats.Text = "Stats"
        btnStats.UseVisualStyleBackColor = True
        ' 
        ' tbxStats
        ' 
        tbxStats.Enabled = False
        tbxStats.Location = New Point(12, 122)
        tbxStats.Multiline = True
        tbxStats.Name = "tbxStats"
        tbxStats.Size = New Size(115, 118)
        tbxStats.TabIndex = 12
        tbxStats.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(200, 214)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 15)
        Label3.TabIndex = 13
        ' 
        ' Form1
        ' 
        AcceptButton = btnGuess
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(563, 281)
        Controls.Add(Label3)
        Controls.Add(tbxStats)
        Controls.Add(btnStats)
        Controls.Add(LabelMaiMareMaiMic)
        Controls.Add(btnGuess)
        Controls.Add(lblApproach2)
        Controls.Add(lblApproach1)
        Controls.Add(tboxGuess)
        Controls.Add(btnGenerate)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(tbxMax)
        Controls.Add(tbxMin)
        Name = "Form1"
        Text = "Guessing Game"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbxMin As TextBox
    Friend WithEvents tbxMax As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGenerate As Button
    Friend WithEvents tboxGuess As TextBox
    Friend WithEvents lblApproach1 As Label
    Friend WithEvents lblApproach2 As Label
    Friend WithEvents btnGuess As Button
    Friend WithEvents LabelMaiMareMaiMic As Label
    Friend WithEvents btnStats As Button
    Friend WithEvents tbxStats As TextBox
    Friend WithEvents Label3 As Label
End Class
