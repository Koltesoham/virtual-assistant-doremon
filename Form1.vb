Imports System.Speech.Synthesis


Public Class Form1
    Dim synth As New SpeechSynthesizer()

    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        Dim command As String = txtCommand.Text.ToLower().Trim()

        Select Case command
            Case "hello"
                lblResponse.Text = "Hello! How can I help you?"
                synth.SpeakAsync("Hello! How can I help you?")
            Case "hi"
                lblResponse.Text = "Hello! How can I help you?"
                synth.SpeakAsync("Hello! How can I help you?")

            Case "open youtube"
                lblResponse.Text = "Opening YouTube..."
                synth.SpeakAsync("Opening YouTube")
                Process.Start(New ProcessStartInfo("https://www.youtube.com") With {.UseShellExecute = True})


            Case "open calculator"
                lblResponse.Text = "Opening Calculator..."
                synth.SpeakAsync("Opening Calculator")
                Process.Start("calc.exe")

            Case "good bye"
                lblResponse.Text = "Goodbye!"
                synth.SpeakAsync("Goodbye!")
                Me.Close()

            Case "what is your name"
                lblResponse.Text = "I am your doremon virtual assistant."
                synth.SpeakAsync("I am your doremon virtual assistant.")
            Case "what time is it"
                Dim currentTime As String = DateTime.Now.ToString("h:mm tt")
                lblResponse.Text = "The current time is " & currentTime
                synth.SpeakAsync("The current time is " & currentTime)
            Case "open notepad"
                lblResponse.Text = "Opening Notepad..."
                synth.SpeakAsync("Opening Notepad")
                Process.Start("notepad.exe")
            Case "tell me a joke"
                lblResponse.Text = "Aek Tha Raja Aek Thi Rani Or Fir Khatan Hogayi Khani!!"
                synth.SpeakAsync("Aek Tha Raja Aek Thi Rani Or Fir Khatan Hogayi Khani!!")
            Case "who is your developer"
                lblResponse.Text = "I was developed by Soham Kolte."
                synth.SpeakAsync("I was developed by Soham Kolte.")
            Case "open google"
                lblResponse.Text = "Opening Google..."
                synth.SpeakAsync("Opening Google")
                Process.Start(New ProcessStartInfo("https://www.google.com") With {.UseShellExecute = True})

            Case Else
                lblResponse.Text = "Sorry, I didn't understand that."
                synth.SpeakAsync("Sorry, I didn't understand that.")
        End Select
    End Sub



End Class

