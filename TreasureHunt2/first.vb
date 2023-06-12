Public Class frmFirst
    Public EasyMode As Integer = 40
    Public NormalMode As Integer = 35
    Public HardMode As Integer = 30


    Private Sub frmFirst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEnterName.Focus()
    End Sub


    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        End
    End Sub


    Private Sub btnGameInstructions_Click(sender As Object, e As EventArgs) Handles btnGameInstructions.Click
        Static gameinstructions As New frmgameinstructions
        gameinstructions.ShowDialog()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Static frm As New frmTreasureHunt(Me)
        If txtEnterName.Text = "" Then
            MessageBox.Show("Need Enter Player's Name", "Input")
            txtEnterName.Focus()
        ElseIf rdoEasy.Checked = False And rdoNormal.Checked = False And rdoHard.Checked = False Then
            MessageBox.Show("Please Choose A Level!!!", "Input")
        End If
        If rdoEasy.Checked = True And txtEnterName.Text <> "" Then
            frm.ShowDialog()

        ElseIf rdoNormal.Checked = True And txtEnterName.Text <> "" Then
            frm.ShowDialog()

        ElseIf rdoHard.Checked = True And txtEnterName.Text <> "" Then
            frm.ShowDialog()
        End If

    End Sub
End Class