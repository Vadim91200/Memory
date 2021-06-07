Public Class Options
    Private Sub MyBase_load(sender As Object, e As EventArgs) Handles MyBase.Load
        HScrollBar1.Value = 60
        lbldch.Text = HScrollBar1.Value
    End Sub
    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        Partie.lblcompteur.Text = lbldch.Text
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        lbldch.Text = HScrollBar1.Value & " seconde "

        'set_chrono
    End Sub

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles Me.Load
        HScrollBar1.Minimum = 20
        HScrollBar1.Maximum = 180
        HScrollBar1.SmallChange = 1
        HScrollBar1.LargeChange = 7
    End Sub

    Private Sub lblah_Click(sender As Object, e As EventArgs) Handles lblah.Click

    End Sub
End Class