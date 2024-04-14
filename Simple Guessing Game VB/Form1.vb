Imports System.IO

Public Class Form1
    Public generatedNumber, totalGuesses, guessedNumbers As Integer
    Public guessed As String = "guessedNumbers.txt"
    Public guesses As String = "totalGuesses.txt"

    Private Sub BtnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        Dim min, max As Integer
        Try
            min = tbxMin.Text
            max = tbxMax.Text
        Catch ex As Exception
            MessageBox.Show("Enter a valid minimum/maximum value")
            Exit Sub
        End Try
        Randomize()
        generatedNumber = Int((max - min + 1) * Rnd() + min)
        tboxGuess.Enabled = True
        btnGuess.Enabled = True
    End Sub

    Private Sub BtnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        Dim guess, distance As Integer
        If File.Exists(guessed) Then
            guessedNumbers = File.ReadAllText(guessed)
        Else
            guessedNumbers = 0
        End If
        If File.Exists(guesses) Then
            totalGuesses = File.ReadAllText(guesses)
        Else
            totalGuesses = 0
        End If
        guess = tboxGuess.Text
        If guess < generatedNumber Then
            distance = generatedNumber - guess
            totalGuesses += 1
            LabelMaiMareMaiMic.Text = "You need a bigger number"
        ElseIf guess > generatedNumber Then
            distance = guess - generatedNumber
            LabelMaiMareMaiMic.Text = "You need a smaller number"
            totalGuesses += 1
        Else
            LabelMaiMareMaiMic.Text = "You guessed the number! (" + generatedNumber.ToString + ")"
            tboxGuess.Enabled = False
            btnGuess.Enabled = False
            guessedNumbers += 1
            totalGuesses += 1
        End If

        If distance < generatedNumber / 90 Then
            lblApproach1.Text = "!!!"
            lblApproach2.Text = "!!!"
        ElseIf distance < generatedNumber / 50 Then
            lblApproach1.Text = "!!"
            lblApproach2.Text = "!!"
        ElseIf distance < generatedNumber / 10 Then
            lblApproach1.Text = "!"
            lblApproach2.Text = "!"
        Else lblApproach1.Text = ""
            lblApproach2.Text = ""
        End If
        Label3.Text = "Last number guessed: " + guess.ToString

        File.WriteAllText(guessed, guessedNumbers)
        File.WriteAllText(guesses, totalGuesses)
        tboxGuess.Clear()
    End Sub

    Private Sub BtnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        If tbxStats.Visible Then
            tbxStats.Visible = False
        Else
            tbxStats.Visible = True
        End If
        If File.Exists(guessed) Then
            guessedNumbers = File.ReadAllText(guessed)
        Else
            guessedNumbers = 0
        End If

        If File.Exists(guesses) Then
            totalGuesses = File.ReadAllText(guesses)
        Else
            totalGuesses = 0
        End If
        tbxStats.Text = "Numbers guessed: " + guessedNumbers.ToString + vbCrLf + "Total guesses: " + totalGuesses.ToString


    End Sub


End Class
