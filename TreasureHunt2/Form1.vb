Imports System.Data.DataTable
Imports System.IO
Public Class frmTreasureHunt
    Implements IComparable(Of frmTreasureHunt)

    Dim _Number As Integer
    Dim _AfterNumber As String
    Public _line As String
    Dim i As Integer = 0
    Dim j  As Integer = 0
    Dim first As New frmFirst
    Dim frmresult As New frmHighScores
    Dim bonusAmount As Integer = 0
    Dim TreasureAmount(3) As Integer
    Dim Bonus(5) As Integer
    Dim SearchValue As Integer
    Dim resultrow As Integer
    Dim resultcolumn As Integer
    Dim Rrow As Integer
    Dim Rcolumn As Integer
    Dim Wnumber As Integer
    Dim Found As Integer = 0
    Dim resultmark As Integer = 0
    Dim table As New DataTable()
    Dim Number As New Random
    Dim guessamount As Integer
    Dim mdArray(,) As Integer = {{0, 1, 2, 3, 4, 5, 6, 7, 8, 9}, {10, 11, 12, 13, 14, 15, 16, 17, 18, 19}, {20, 21, 22, 23, 24, 25, 26, 27, 28, 29}, {30, 31, 32, 33, 34, 35, 36, 37, 38, 39}, {40, 41, 42, 43, 44, 45, 46, 47, 48, 49}, {50, 51, 52, 53, 54, 55, 56, 57, 58, 59}, {60, 61, 62, 63, 64, 65, 66, 67, 68, 69}, {70, 71, 72, 73, 74, 75, 76, 77, 78, 79}}
    Public Sub New(ByVal frmS As frmFirst)
        first = frmS
        InitializeComponent()
    End Sub
    Public Sub New(ByVal frmR As frmHighScores)
        InitializeComponent()
        frmresult = frmR
    End Sub
    Private Sub frmtreasuremap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPlayerName.Text = first.txtEnterName.Text

        If first.rdoEasy.Checked = True Then
            lblLevel.Text = first.rdoEasy.Text
            btnNormalMode.Enabled = False
            btnHardMode.Enabled = False
            btnEasyBonus.Enabled = False
            btnNormalBonus.Enabled = False
            btnHardBonus.Enabled = False
        ElseIf first.rdoNormal.Checked = True Then
            lblLevel.Text = first.rdoNormal.Text
            btnEasyMode.Enabled = False
            btnHardMode.Enabled = False
            btnEasyBonus.Enabled = False
            btnNormalBonus.Enabled = False
            btnHardBonus.Enabled = False
        Else
            lblLevel.Text = first.rdoHard.Text
            btnEasyMode.Enabled = False
            btnNormalMode.Enabled = False
            btnEasyBonus.Enabled = False
            btnNormalBonus.Enabled = False
            btnHardBonus.Enabled = False
        End If
        SetTreasures()

        MakeBoard()
        System.IO.File.WriteAllLines("treasure.txt", Array.ConvertAll(TreasureAmount, New Converter(Of Integer, String)(Function(t As Integer) t.ToString())))
        Dim FileToDelete As String = "bonusGuesses.txt"
        My.Computer.FileSystem.GetFiles(Application.StartupPath)

        If System.IO.File.Exists(FileToDelete) = True Then

            System.IO.File.Delete(FileToDelete)

        End If


    End Sub
    Private Sub SetTreasures()
        Dim Number As New Random
        Dim i As Integer
        For i = 0 To 2
            TreasureAmount(i) = Number.Next(80)

        Next
        bonusAmount = TreasureAmount(0)
    End Sub
    Private Sub SetBonusGuesses()
        Dim Number As New Random
        For i = 0 To 4
            Bonus(i) = Number.Next(80)
            lblBonus.Text += Bonus(i) & vbCrLf
        Next

    End Sub
    Public Sub MakeBoard()
        table.Columns.Clear()
        table.Rows.Clear()
        table.Columns.Add("0")
        table.Columns.Add("1")
        table.Columns.Add("2")
        table.Columns.Add("3")
        table.Columns.Add("4")
        table.Columns.Add("5")
        table.Columns.Add("6")
        table.Columns.Add("7")
        table.Columns.Add("8")
        table.Columns.Add("9")
        For i As Integer = 0 To 7
            Dim newRow As DataRow = table.NewRow()
            For j As Integer = 0 To 9
                newRow(j) = mdArray(i, j)
            Next
            table.Rows.Add(newRow)
        Next
        DataGridView1.DataSource = table
        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(1).Width = 50
        DataGridView1.Columns(2).Width = 50
        DataGridView1.Columns(3).Width = 50
        DataGridView1.Columns(4).Width = 50
        DataGridView1.Columns(5).Width = 50
        DataGridView1.Columns(6).Width = 50
        DataGridView1.Columns(7).Width = 50
        DataGridView1.Columns(8).Width = 50
        DataGridView1.Columns(9).Width = 50

    End Sub
    Private Sub SearchBoard()
        Dim mdArray(,) As Integer = {{0, 1, 2, 3, 4, 5, 6, 7, 8, 9}, {10, 11, 12, 13, 14, 15, 16, 17, 18, 19}, {20, 21, 22, 23, 24, 25, 26, 27, 28, 29}, {30, 31, 32, 33, 34, 35, 36, 37, 38, 39}, {40, 41, 42, 43, 44, 45, 46, 47, 48, 49}, {50, 51, 52, 53, 54, 55, 56, 57, 58, 59}, {60, 61, 62, 63, 64, 65, 66, 67, 68, 69}, {70, 71, 72, 73, 74, 75, 76, 77, 78, 79}}
        Dim SearchRow As Integer
        Dim SearchColumn As Integer


        Dim GuessCount As Integer = 0
        Dim tc As Integer
        txtEnterNumber.Focus()
        SearchValue = Val(txtEnterNumber.Text)
        If SearchValue < 0 Or SearchValue > 79 Then
            Wnumber += 1
            MessageBox.Show("Invalid Number.You can enter 0 to 79")
        End If
        lblFound.Text = "Any Treasure are Here!!!"
        For tc = 0 To 2
            If SearchValue = TreasureAmount(tc) Then

                For SearchRow = 0 To mdArray.GetUpperBound(0)
                    For SearchColumn = 0 To mdArray.GetUpperBound(1)
                        If mdArray(SearchRow, SearchColumn) = SearchValue Then
                            resultrow = SearchRow
                            resultcolumn = SearchColumn
                            Exit For

                        End If

                    Next
                Next
                Found += 1
                GuessCount += 1
                resultmark += 10
                lblFound.Text = Found & " Treasures is Found!!!"

                DataGridView1.Rows(resultrow).Cells(resultcolumn).Style.BackColor = Color.Green
            Else
                If GuessCount = 0 Then
                    lblFound.Text = "Any Treasure are Here!!!"
                    For SearchRow = 0 To mdArray.GetUpperBound(0)
                        For SearchColumn = 0 To mdArray.GetUpperBound(1)
                            If mdArray(SearchRow, SearchColumn) = SearchValue Then
                                Rrow = SearchRow
                                Rcolumn = SearchColumn
                                Exit For
                            End If
                        Next
                    Next
                    DataGridView1.Rows(Rrow).Cells(Rcolumn).Style.BackColor = Color.Red
                End If
            End If
        Next
        If Found = 3 Then
            MessageBox.Show("Ohh!!You win the game!!!")
            txtEnterNumber.Text = ""
            txtEnterNumber.Enabled = False
        End If

    End Sub
    Private Sub btnEasyMode_Click(sender As Object, e As EventArgs) Handles btnEasyMode.Click
        Dim start As New frmFirst

        Static countguess As Integer = 0
        guessamount += 1
        countguess += 1
        lblLevel.Text = "Easy"
        If countguess > start.EasyMode Then
            MessageBox.Show("Sorry Game Over!!!")
            MessageBox.Show("If you got bonus, you keep play only your bonus guesses or not Quit the Game")
        Else
            SearchBoard()
        End If
        If countguess > 0 And countguess <= 40 Then
            lblGuessCount.Text = guessamount
            lblCountLeft.Text = 40 - countguess & "times"
        End If
        If bonusAmount = TreasureAmount(0) And Found <> 0 Then
            MessageBox.Show("You found " & Found & " treasures!. So you got 10 bonus guesses")
            btnEasyBonus.Enabled = True
            bonusAmount = 0
        End If

    End Sub

    Private Sub btnNormalMode_Click(sender As Object, e As EventArgs) Handles btnNormalMode.Click
        Dim start As New frmFirst
        Static countguess As Integer = 0
        guessamount += 1
        countguess += 1
        lblLevel.Text = "Normal"
        If countguess > start.NormalMode Then
            MessageBox.Show("Sorry Game Over!!!")
            MessageBox.Show("If you got bonus, you keep play only your bonus guesses or not Quit the Game")
        Else
            SearchBoard()
        End If
        If countguess > 0 And countguess <= 35 Then
            lblGuessCount.Text = guessamount
            lblCountLeft.Text = 35 - countguess & "times"
        End If
        If bonusAmount = TreasureAmount(0) And Found <> 0 Then
            MessageBox.Show("You found " & Found & " treasures!. So you got 6 bonus guesses")
            btnNormalBonus.Enabled = True
            bonusAmount = 0
        End If
    End Sub


    Private Sub btnHardMode_Click(sender As Object, e As EventArgs) Handles btnHardMode.Click
        Dim start As New frmFirst
        Static countguess As Integer = 0
        guessamount += 1
        countguess += 1
        lblLevel.Text = "Hard"
        If countguess > start.EasyMode Then
            MessageBox.Show("Game Over!!!")
            MessageBox.Show("If you got bonus, you keep play only your bonus guesses or not Quit the Game")
        Else
            SearchBoard()

        End If
        If countguess > 0 And countguess <= 30 Then
            lblGuessCount.Text = guessamount
            lblCountLeft.Text = 30 - countguess & "times"
        End If
        If bonusAmount = TreasureAmount(0) And Found <> 0 Then
            MessageBox.Show("You found " & Found & " treasures!. So you got 3 bonus guesses")
            btnHardBonus.Enabled = True
            bonusAmount = 0
        End If
    End Sub
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnExit.Click


        MessageBox.Show("Sorry Game Over!!!")
        End


    End Sub

    Private Sub btnBonus_Click(sender As Object, e As EventArgs) Handles btnEasyBonus.Click
        Dim FileName As String = "bonusGuesses.txt"
        My.Computer.FileSystem.GetFiles(Application.StartupPath)
        Dim start As New frmFirst
        Dim bonusguesses As String = ""
        Static countguess As Integer = 0
        countguess += 1
        bonusguesses += txtEnterNumber.Text
        bonusguesses = bonusguesses & vbCrLf
        If countguess <= 10 Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath().TrimEnd("\") & "\" & FileName, bonusguesses, True)
        End If
        If countguess > 10 Then
            MessageBox.Show("Your Bonus Guess Completd So, Game Over!!!")
            MessageBox.Show("You found " & Found & " treasures!.")
        Else
            SearchBoard()
        End If
        If countguess > 0 And countguess <= 10 Then
            lblCountLeft.Text = 10 - countguess & "times"
        End If
    End Sub

    Private Sub btnHardBonus_Click(sender As Object, e As EventArgs) Handles btnHardBonus.Click
        Dim FileName As String = "bonusGuesses.txt"
        My.Computer.FileSystem.GetFiles(Application.StartupPath)
        Dim start As New frmFirst
        Dim bonusguesses As String = ""
        Static countguess As Integer = 0
        countguess += 1
        bonusguesses += txtEnterNumber.Text
        bonusguesses = bonusguesses & vbCrLf
        If countguess <= 3 Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath().TrimEnd("\") & "\" & FileName, bonusguesses, True)
        End If
        If countguess > 3 Then
            MessageBox.Show("Your Bonus Guess Completd So, Game Over!!!")
            MessageBox.Show("You found " & Found & " treasures!.")
        Else

            SearchBoard()
        End If
        If countguess > 0 And countguess <= 3 Then
            lblCountLeft.Text = 3 - countguess & "times"
        End If

    End Sub

    Private Sub btnNormalBonus_Click(sender As Object, e As EventArgs) Handles btnNormalBonus.Click
        Dim FileName As String = "bonusGuesses.txt"
        My.Computer.FileSystem.GetFiles(Application.StartupPath)
        Dim start As New frmFirst
        Dim bonusguesses As String = ""
        Static countguess As Integer = 0
        countguess += 1
        bonusguesses += txtEnterNumber.Text
        bonusguesses = bonusguesses & vbCrLf
        If countguess <= 6 Then
            My.Computer.FileSystem.WriteAllText(Application.StartupPath().TrimEnd("\") & "\" & FileName, bonusguesses, True)
        End If
        If countguess > 6 Then
            MessageBox.Show("Your Bonus Guess Completd So, Game Over!!!")
            MessageBox.Show("You found " & Found & " treasures!.")
        Else
            SearchBoard()
        End If
        If countguess > 0 And countguess <= 6 Then
            lblCountLeft.Text = 6 - countguess & "times"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim data As String = ""
        If lblLevel.Text = "Easy" Then
            If lblGuessCount.Text > 0 Then
                data += lblGuessCount.Text + " - "
            Else
                MessageBox.Show("You must guess number")
            End If
            data += txtPlayerName.Text

            If Found = 3 Then
                Try

                    Dim FileName As String = "e.txt"
                    My.Computer.FileSystem.GetFiles(Application.StartupPath)
                    data = data & vbCrLf
                    My.Computer.FileSystem.WriteAllText(Application.StartupPath().TrimEnd("\") & "\" & FileName, data, True)
                    MessageBox.Show("Successfully Saved")

                    Dim lines As List(Of frmTreasureHunt) = New List(Of frmTreasureHunt)()


                    Dim reader = New FileStream("e.txt", FileMode.OpenOrCreate, FileAccess.Read)
                    Dim sr As StreamReader = New StreamReader(reader)

                    While True
                        Dim line As String = sr.ReadLine
                        If line = Nothing Then
                            Exit While
                        End If
                        lines.Add(New frmTreasureHunt(line))
                    End While

                    lines.Sort()

                    For Each value As frmTreasureHunt In lines
                        ListBox .Items.Add(value._line)
                    Next
                    Dim SW As IO.StreamWriter = IO.File.CreateText("easyScores.txt")
                    For Each S As String In ListBox.Items
                        SW.WriteLine(S)
                    Next
                    SW.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.ToString())
                    Return
                End Try
                txtPlayerName.Text = ""
                lblLevel.Text = ""
                lblResult.Text = ""


            Else
                MessageBox.Show("You are not found all(3) treasures")
            End If

        ElseIf lblLevel.Text = "Normal" Then
            If lblGuessCount.Text > 0 Then
                data += lblGuessCount.Text + " - "
            Else
                MessageBox.Show("You must guess number")
            End If
            data += txtPlayerName.Text

            If Found = 3 Then
                Try

                    Dim FileName As String = "m.txt"
                    My.Computer.FileSystem.GetFiles(Application.StartupPath)
                    data = data & vbCrLf
                    My.Computer.FileSystem.WriteAllText(Application.StartupPath().TrimEnd("\") & "\" & FileName, data, True)
                    MessageBox.Show("Successfully Saved")

                    Dim lines As List(Of frmTreasureHunt) = New List(Of frmTreasureHunt)()


                    Dim reader = New FileStream("m.txt", FileMode.OpenOrCreate, FileAccess.Read)
                    Dim sr As StreamReader = New StreamReader(reader)

                    While True
                        Dim line As String = sr.ReadLine
                        If line = Nothing Then
                            Exit While
                        End If
                        lines.Add(New frmTreasureHunt(line))
                    End While

                    lines.Sort()

                    For Each value As frmTreasureHunt In lines
                        ListBox.Items.Add(value._line)
                    Next
                    Dim SW As IO.StreamWriter = IO.File.CreateText("mediumScores.txt")
                    For Each S As String In ListBox.Items
                        SW.WriteLine(S)
                    Next
                    SW.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.ToString())
                    Return
                End Try
                txtPlayerName.Text = ""
                lblLevel.Text = ""
                lblResult.Text = ""
                ListBox.Items.Clear()

            Else
                MessageBox.Show("You are not found all(3) treasures")
            End If
            btnResults.Enabled = True
        Else
            If lblGuessCount.Text > 0 Then
                data += lblGuessCount.Text + " - "
            Else
                MessageBox.Show("You must guess number")
            End If
            data += txtPlayerName.Text

            If Found = 3 Then
                Try
                    Dim FileName As String = "h.txt"
                    My.Computer.FileSystem.GetFiles(Application.StartupPath)
                    data = data & vbCrLf
                    My.Computer.FileSystem.WriteAllText(Application.StartupPath().TrimEnd("\") & "\" & FileName, data, True)
                    MessageBox.Show("Complete Saved")
                    Dim lines As List(Of frmTreasureHunt) = New List(Of frmTreasureHunt)()
                    Dim reader = New FileStream("h.txt", FileMode.OpenOrCreate, FileAccess.Read)
                    Dim sr As StreamReader = New StreamReader(reader)
                    While True
                        Dim line As String = sr.ReadLine
                        If line = Nothing Then
                            Exit While
                        End If
                        lines.Add(New frmTreasureHunt(line))
                    End While
                    lines.Sort()
          
                    For Each value As frmTreasureHunt In lines
                        ListBox.Items.Add(value._line)
                    Next

                    Dim SW As IO.StreamWriter = IO.File.CreateText("hardScores.txt")
                    For Each S As String In ListBox.Items
                        SW.WriteLine(S)
                    Next
                    SW.Close()
                Catch ex As Exception
                    Console.WriteLine(ex.ToString())
                    Return
                End Try
                txtPlayerName.Text = ""
                lblLevel.Text = ""
                lblResult.Text = ""

            Else
                MessageBox.Show("You are not found all(3) treasures")
            End If
            btnResults.Enabled = True
        End If

    End Sub
    Public Sub New(ByVal line As String)
        Dim firstSpace As Integer = line.IndexOf(" "c)
        Dim digits As String = line.Substring(0, firstSpace)

        _Number = Integer.Parse(digits)
        _AfterNumber = line.Substring(firstSpace)
        _line = line
    End Sub
    Public Function CompareTo(other As frmTreasureHunt) As Integer _
       Implements IComparable(Of frmTreasureHunt).CompareTo
      
        Dim result1 As Integer = _Number.CompareTo(other._Number)
        If Not result1 = 0 Then
            Return result1
        End If
        Return _AfterNumber.CompareTo(other._AfterNumber)
    End Function

    Private Sub btnResults_Click(sender As Object, e As EventArgs) Handles btnResults.Click

        Dim EasyFileName As String = "easyScores.txt"
        Dim NormalFileName As String = "normalScores.txt"
        Dim HardFileName As String = "hardScores.txt"
        My.Computer.FileSystem.GetFiles(Application.StartupPath)
        If System.IO.File.Exists(EasyFileName) = True Then
            Dim easylines() As String = IO.File.ReadAllLines(EasyFileName)
            frmresult.lstEasyResult.Items.AddRange(easylines)
        End If
        If System.IO.File.Exists(NormalFileName) = True Then
            Dim normallines() As String = IO.File.ReadAllLines(NormalFileName)
            frmresult.lstNormalResult.Items.AddRange(normallines)

        End If
        If System.IO.File.Exists(hardFileName) = True Then
            Dim hardlines() As String = IO.File.ReadAllLines("hardScores.txt")
            frmresult.lstHardResult.Items.AddRange(hardlines)

        End If
        frmresult.ShowDialog()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class