Public Class Scoresvb
    Private Sub btnfermer_Click(sender As Object, e As EventArgs) Handles btnfermer.Click
        Me.Close()
        Form1.Show()
    End Sub
    Private Sub Scoresvb_Load(sender As Object, e As EventArgs) Handles Me.Load
        For i As Integer = 0 To getNb() - 1
            ComboBox1.Items.Add(getP(i).Nom)
            lbstat.Items.Insert(i, getP(i).nbdecarré)
            lbnom.Items.Insert(i, getP(i).Nom)
            DataGridView1.Rows.Add(getP(i).Nom, getP(i).nbdecarré, getP(i).tmpmini, getP(i).tmpJoué, getP(i).nbpartie)
        Next
    End Sub

    Private Sub btnaffichestat_Click(sender As Object, e As EventArgs) Handles btnaffichestat.Click
        For i As Integer = 0 To getNb() - 1
            If getP(i).Nom = ComboBox1.SelectedItem Then
                MsgBox(getP(i).Nom & Chr(13) & getP(i).nbdecarré & " carré au maximum " & Chr(13) & getP(i).tmpmini & " sec pour trouvé le plus de carré" & Chr(13) & getP(i).nbpartie & " partie joué " & Chr(13) & getP(i).tmpJoué & " sec joué au total ")
            End If
        Next
    End Sub
End Class