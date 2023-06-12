<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFirst
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
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.txtEnterName = New System.Windows.Forms.TextBox()
        Me.btnGameInstructions = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdoEasy = New System.Windows.Forms.RadioButton()
        Me.rdoNormal = New System.Windows.Forms.RadioButton()
        Me.rdoHard = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnQuit.Location = New System.Drawing.Point(232, 124)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 20
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'btnPlay
        '
        Me.btnPlay.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnPlay.Location = New System.Drawing.Point(156, 124)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 19
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = False
        '
        'txtEnterName
        '
        Me.txtEnterName.Location = New System.Drawing.Point(158, 86)
        Me.txtEnterName.Name = "txtEnterName"
        Me.txtEnterName.Size = New System.Drawing.Size(102, 20)
        Me.txtEnterName.TabIndex = 18
        '
        'btnGameInstructions
        '
        Me.btnGameInstructions.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnGameInstructions.ForeColor = System.Drawing.Color.Black
        Me.btnGameInstructions.Location = New System.Drawing.Point(75, 158)
        Me.btnGameInstructions.Name = "btnGameInstructions"
        Me.btnGameInstructions.Size = New System.Drawing.Size(234, 23)
        Me.btnGameInstructions.TabIndex = 17
        Me.btnGameInstructions.Text = "Click here to read game instructions"
        Me.btnGameInstructions.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(151, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = " Need  Enter Your Name"
        '
        'rdoEasy
        '
        Me.rdoEasy.AutoSize = True
        Me.rdoEasy.Location = New System.Drawing.Point(27, 82)
        Me.rdoEasy.Name = "rdoEasy"
        Me.rdoEasy.Size = New System.Drawing.Size(78, 17)
        Me.rdoEasy.TabIndex = 21
        Me.rdoEasy.TabStop = True
        Me.rdoEasy.Text = "Easy Mode"
        Me.rdoEasy.UseVisualStyleBackColor = True
        '
        'rdoNormal
        '
        Me.rdoNormal.AutoSize = True
        Me.rdoNormal.Location = New System.Drawing.Point(26, 107)
        Me.rdoNormal.Name = "rdoNormal"
        Me.rdoNormal.Size = New System.Drawing.Size(88, 17)
        Me.rdoNormal.TabIndex = 22
        Me.rdoNormal.TabStop = True
        Me.rdoNormal.Text = "Normal Mode"
        Me.rdoNormal.UseVisualStyleBackColor = True
        '
        'rdoHard
        '
        Me.rdoHard.AutoSize = True
        Me.rdoHard.Location = New System.Drawing.Point(26, 130)
        Me.rdoHard.Name = "rdoHard"
        Me.rdoHard.Size = New System.Drawing.Size(78, 17)
        Me.rdoHard.TabIndex = 23
        Me.rdoHard.TabStop = True
        Me.rdoHard.Text = "Hard Mode"
        Me.rdoHard.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(26, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Choose A Level"
        '
        'frmFirst
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(319, 198)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rdoHard)
        Me.Controls.Add(Me.rdoNormal)
        Me.Controls.Add(Me.rdoEasy)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.txtEnterName)
        Me.Controls.Add(Me.btnGameInstructions)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmFirst"
        Me.Text = "first"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents txtEnterName As System.Windows.Forms.TextBox
    Friend WithEvents btnGameInstructions As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdoEasy As System.Windows.Forms.RadioButton
    Friend WithEvents rdoNormal As System.Windows.Forms.RadioButton
    Friend WithEvents rdoHard As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
