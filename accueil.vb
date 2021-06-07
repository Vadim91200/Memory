Public Class Form1
    Private Sub btnquitter_Click(sender As Object, e As EventArgs) Handles btnquitter.Click
        Dim answer As Integer
        answer = MsgBox("Voulez vous quitter l'application ?", vbQuestion + vbYesNo + vbDefaultButton2)
        If answer = vbYes Then
            Dim num As Integer = FreeFile()
            FileOpen(num, "Joueur.txt", OpenMode.Output)
            Print(num, getNb)
            Print(num, Chr(13))
            For i As Integer = 0 To getNb() - 1
                Print(num, getP(i).Nom)
                Print(num, Chr(13))
                Print(num, getP(i).nbdecarré)
                Print(num, Chr(13))
                Print(num, getP(i).tmpmini)
                Print(num, Chr(13))
                Print(num, getP(i).tmpJoué)
                Print(num, Chr(13))
                Print(num, getP(i).nbpartie)
                Print(num, Chr(13))
            Next
            FileClose(num)
            Application.Exit()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        btnjouer.Enabled = False
    End Sub

    Private Sub cbnom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbnom.TextUpdate
        ' pas despace dans nom! 
        If (cbnom.Text.Length >= 3) Then
            btnjouer.Enabled = True
        Else
            btnjouer.Enabled = False
        End If
    End Sub

    Private Sub btnjouer_Click(sender As Object, e As EventArgs) Handles btnjouer.Click
        Partie.lblnom.Text = cbnom.Text
        cbnom.Items.Add(cbnom.Text)
        Mélange()
        Me.Hide()
        Partie.Show()
    End Sub

    Private Sub btnoptions_Click(sender As Object, e As EventArgs) Handles btnoptions.Click
        Me.Hide()
        Options.Show()
    End Sub

    Private Sub btnscores_Click(sender As Object, e As EventArgs) Handles btnscores.Click
        Me.Hide()
        Scoresvb.Show()
    End Sub

    Private Sub Cbnom_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbnom.SelectedIndexChanged

    End Sub
End Class
