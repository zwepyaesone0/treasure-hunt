<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTreasureHunt
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
        Me.lblCountLeft = New System.Windows.Forms.Label()
        Me.txtPlayerName = New System.Windows.Forms.TextBox()
        Me.lblGuessCount = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFound = New System.Windows.Forms.Label()
        Me.txtEnterNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHardBonus = New System.Windows.Forms.Button()
        Me.btnEasyBonus = New System.Windows.Forms.Button()
        Me.btnNormalBonus = New System.Windows.Forms.Button()
        Me.btnEasyMode = New System.Windows.Forms.Button()
        Me.btnNormalMode = New System.Windows.Forms.Button()
        Me.btnHardMode = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnResults = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblBonus = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCountLeft
        '
        Me.lblCountLeft.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblCountLeft.Location = New System.Drawing.Point(575, 276)
        Me.lblCountLeft.Name = "lblCountLeft"
        Me.lblCountLeft.Size = New System.Drawing.Size(97, 23)
        Me.lblCountLeft.TabIndex = 45
        '
        'txtPlayerName
        '
        Me.txtPlayerName.Location = New System.Drawing.Point(460, 101)
        Me.txtPlayerName.Name = "txtPlayerName"
        Me.txtPlayerName.Size = New System.Drawing.Size(100, 20)
        Me.txtPlayerName.TabIndex = 44
        '
        'lblGuessCount
        '
        Me.lblGuessCount.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblGuessCount.Location = New System.Drawing.Point(574, 221)
        Me.lblGuessCount.Name = "lblGuessCount"
        Me.lblGuessCount.Size = New System.Drawing.Size(97, 23)
        Me.lblGuessCount.TabIndex = 43
        '
        'lblLevel
        '
        Me.lblLevel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblLevel.Location = New System.Drawing.Point(461, 54)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(97, 23)
        Me.lblLevel.TabIndex = 42
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label6.Location = New System.Drawing.Point(572, 255)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Left Guess count"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label5.Location = New System.Drawing.Point(459, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Player's Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label4.Location = New System.Drawing.Point(462, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Level"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label3.Location = New System.Drawing.Point(572, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Guess Count"
        '
        'lblFound
        '
        Me.lblFound.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblFound.Location = New System.Drawing.Point(284, 39)
        Me.lblFound.Name = "lblFound"
        Me.lblFound.Size = New System.Drawing.Size(156, 21)
        Me.lblFound.TabIndex = 36
        '
        'txtEnterNumber
        '
        Me.txtEnterNumber.Location = New System.Drawing.Point(165, 37)
        Me.txtEnterNumber.Name = "txtEnterNumber"
        Me.txtEnterNumber.Size = New System.Drawing.Size(87, 20)
        Me.txtEnterNumber.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label1.Location = New System.Drawing.Point(22, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Enter A Guess Number"
        '
        'btnHardBonus
        '
        Me.btnHardBonus.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnHardBonus.Location = New System.Drawing.Point(343, 98)
        Me.btnHardBonus.Name = "btnHardBonus"
        Me.btnHardBonus.Size = New System.Drawing.Size(85, 23)
        Me.btnHardBonus.TabIndex = 33
        Me.btnHardBonus.Text = "Hard Bonus"
        Me.btnHardBonus.UseVisualStyleBackColor = False
        '
        'btnEasyBonus
        '
        Me.btnEasyBonus.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnEasyBonus.Location = New System.Drawing.Point(25, 99)
        Me.btnEasyBonus.Name = "btnEasyBonus"
        Me.btnEasyBonus.Size = New System.Drawing.Size(91, 23)
        Me.btnEasyBonus.TabIndex = 32
        Me.btnEasyBonus.Text = "Easy Bonus"
        Me.btnEasyBonus.UseVisualStyleBackColor = False
        '
        'btnNormalBonus
        '
        Me.btnNormalBonus.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnNormalBonus.Location = New System.Drawing.Point(165, 99)
        Me.btnNormalBonus.Name = "btnNormalBonus"
        Me.btnNormalBonus.Size = New System.Drawing.Size(87, 23)
        Me.btnNormalBonus.TabIndex = 31
        Me.btnNormalBonus.Text = "Normal Bonus"
        Me.btnNormalBonus.UseVisualStyleBackColor = False
        '
        'btnEasyMode
        '
        Me.btnEasyMode.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnEasyMode.Location = New System.Drawing.Point(25, 70)
        Me.btnEasyMode.Name = "btnEasyMode"
        Me.btnEasyMode.Size = New System.Drawing.Size(91, 23)
        Me.btnEasyMode.TabIndex = 30
        Me.btnEasyMode.Text = "Easy Mode"
        Me.btnEasyMode.UseVisualStyleBackColor = False
        '
        'btnNormalMode
        '
        Me.btnNormalMode.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnNormalMode.Location = New System.Drawing.Point(165, 70)
        Me.btnNormalMode.Name = "btnNormalMode"
        Me.btnNormalMode.Size = New System.Drawing.Size(87, 23)
        Me.btnNormalMode.TabIndex = 29
        Me.btnNormalMode.Text = "Normal Mode"
        Me.btnNormalMode.UseVisualStyleBackColor = False
        '
        'btnHardMode
        '
        Me.btnHardMode.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnHardMode.Location = New System.Drawing.Point(343, 70)
        Me.btnHardMode.Name = "btnHardMode"
        Me.btnHardMode.Size = New System.Drawing.Size(85, 23)
        Me.btnHardMode.TabIndex = 28
        Me.btnHardMode.Text = "Hard Mode"
        Me.btnHardMode.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnSave.Location = New System.Drawing.Point(573, 344)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnExit.Location = New System.Drawing.Point(656, 345)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnResults
        '
        Me.btnResults.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnResults.Location = New System.Drawing.Point(573, 315)
        Me.btnResults.Name = "btnResults"
        Me.btnResults.Size = New System.Drawing.Size(75, 23)
        Me.btnResults.TabIndex = 25
        Me.btnResults.Text = "Results"
        Me.btnResults.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 127)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(542, 240)
        Me.DataGridView1.TabIndex = 24
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.Location = New System.Drawing.Point(572, 169)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(98, 17)
        Me.ListBox.TabIndex = 46
        '
        'lblResult
        '
        Me.lblResult.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblResult.Location = New System.Drawing.Point(573, 127)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(97, 23)
        Me.lblResult.TabIndex = 47
        '
        'lblBonus
        '
        Me.lblBonus.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblBonus.Location = New System.Drawing.Point(659, 316)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(65, 23)
        Me.lblBonus.TabIndex = 48
        '
        'frmTreasureHunt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(741, 385)
        Me.Controls.Add(Me.lblBonus)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.ListBox)
        Me.Controls.Add(Me.lblCountLeft)
        Me.Controls.Add(Me.txtPlayerName)
        Me.Controls.Add(Me.lblGuessCount)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblFound)
        Me.Controls.Add(Me.txtEnterNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHardBonus)
        Me.Controls.Add(Me.btnEasyBonus)
        Me.Controls.Add(Me.btnNormalBonus)
        Me.Controls.Add(Me.btnEasyMode)
        Me.Controls.Add(Me.btnNormalMode)
        Me.Controls.Add(Me.btnHardMode)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnResults)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmTreasureHunt"
        Me.Text = "treasurehunt"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCountLeft As System.Windows.Forms.Label
    Friend WithEvents txtPlayerName As System.Windows.Forms.TextBox
    Friend WithEvents lblGuessCount As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblFound As System.Windows.Forms.Label
    Friend WithEvents txtEnterNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHardBonus As System.Windows.Forms.Button
    Friend WithEvents btnEasyBonus As System.Windows.Forms.Button
    Friend WithEvents btnNormalBonus As System.Windows.Forms.Button
    Friend WithEvents btnEasyMode As System.Windows.Forms.Button
    Friend WithEvents btnNormalMode As System.Windows.Forms.Button
    Friend WithEvents btnHardMode As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnResults As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ListBox As System.Windows.Forms.ListBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblBonus As System.Windows.Forms.Label

End Class
