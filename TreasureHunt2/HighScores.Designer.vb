<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighScores
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstHardResult = New System.Windows.Forms.ListBox()
        Me.lstNormalResult = New System.Windows.Forms.ListBox()
        Me.lstEasyResult = New System.Windows.Forms.ListBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(15, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Easy Mode High scores"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(137, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Normal Mode High Scores"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(268, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Hard Mode High Scores"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DarkGray
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "High Scores Results"
        '
        'lstHardResult
        '
        Me.lstHardResult.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lstHardResult.ForeColor = System.Drawing.Color.DarkViolet
        Me.lstHardResult.FormattingEnabled = True
        Me.lstHardResult.Location = New System.Drawing.Point(266, 96)
        Me.lstHardResult.Name = "lstHardResult"
        Me.lstHardResult.Size = New System.Drawing.Size(120, 160)
        Me.lstHardResult.TabIndex = 23
        '
        'lstNormalResult
        '
        Me.lstNormalResult.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lstNormalResult.ForeColor = System.Drawing.Color.DarkViolet
        Me.lstNormalResult.FormattingEnabled = True
        Me.lstNormalResult.Location = New System.Drawing.Point(140, 96)
        Me.lstNormalResult.Name = "lstNormalResult"
        Me.lstNormalResult.Size = New System.Drawing.Size(120, 160)
        Me.lstNormalResult.TabIndex = 22
        '
        'lstEasyResult
        '
        Me.lstEasyResult.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lstEasyResult.ForeColor = System.Drawing.Color.DarkViolet
        Me.lstEasyResult.FormattingEnabled = True
        Me.lstEasyResult.Location = New System.Drawing.Point(14, 96)
        Me.lstEasyResult.Name = "lstEasyResult"
        Me.lstEasyResult.Size = New System.Drawing.Size(120, 160)
        Me.lstEasyResult.TabIndex = 21
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnClose.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnClose.Location = New System.Drawing.Point(325, 279)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(89, 24)
        Me.btnClose.TabIndex = 28
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmHighScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(426, 324)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstHardResult)
        Me.Controls.Add(Me.lstNormalResult)
        Me.Controls.Add(Me.lstEasyResult)
        Me.Name = "frmHighScores"
        Me.Text = "HighScores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstHardResult As System.Windows.Forms.ListBox
    Friend WithEvents lstNormalResult As System.Windows.Forms.ListBox
    Friend WithEvents lstEasyResult As System.Windows.Forms.ListBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
