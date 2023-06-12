Public Class frmHighScores


    Private Sub frmHighScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Easyfilename As String = "lstEasyResult.text"
        Dim NormalFilename As String = "lstNormalResult.text"
        Dim HardFilename As String = "lstHardResult.text"
        If System.IO.File.Exists(Easyfilename) = True Then
            Dim easyline() As String = IO.File.ReadAllLines(Easyfilename)
            lstEasyResult.Items.AddRange(easyline)

        End If
        If System.IO.File.Exists(NormalFilename) = True Then
            Dim normalline() As String = IO.File.ReadAllLines(NormalFilename)
            lstNormalResult.Items.AddRange(normalline)
        End If
        If System.IO.File.Exists(HardFilename) = True Then
            Dim hardline() As String = IO.File.ReadAllLines(HardFilename)
            lstHardResult.Items.AddRange(hardline)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class