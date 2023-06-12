Public Class frmgameinstructions

    Private Sub frmgameinstructions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "You have to enter coordinates between 0 to 79 to find treasures"
        Label3.Text = "EasyMode will get 40 guesses, NormalMode will get 35 guesses and HardMode will get 30 guesses"
        Label4.Text = "If a treasure is found, that location will change green color and If not found, it will change to red color"
        Label5.Text = "If you found a treasure, you will get bonus guesses"
        Label6.Text = "EasyMode will get 10 bounus guesses, NormalMode will get 6 bonus guesses and HardMode will get 3 bonus guesses"
        Label7.Text = " When you found all(3) treasures, you have to press 'Save' button to save your scores"
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

   
End Class