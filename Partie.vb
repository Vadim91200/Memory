Public Class Partie
    Dim nbDeCarteRetourner As Integer, nbcarre As Integer
    Dim tabNbDeCartesRetourner As New ArrayList
    Dim valeurActuelle As Integer
    Private Décompte As Integer = Options.HScrollBar1.Value
    Private TMt As Integer = Options.HScrollBar1.Value
    Dim tmppourcompleter As Integer = 0
    Private Sub btnabandon_Click(sender As Object, e As EventArgs) Handles btnabandon.Click
        Timer1.Stop()
        Dim answer As Integer
        answer = MsgBox("Voulez vous abandonner la partie en cours?", vbQuestion + vbYesNo + vbDefaultButton2)
        If answer = vbYes Then
            Me.Close()
            Form1.Show()
        Else
            Timer1.Start()
        End If
    End Sub
    Private Sub WaitFor(Sec%)
        Dim Dt As DateTime = DateTime.Now
        Do
            Application.DoEvents()
        Loop While Dt.AddSeconds(Sec) > DateTime.Now
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (nbcarre = 5) Then
            Timer1.Stop()
            MsgBox("Félicitation vous avez trouvé les cinqs carrés en " & tmppourcompleter & " secondes")
        End If
        If Décompte > 0 Then
            If Décompte < 20 Then
                lblcompteur.ForeColor = Color.Red
            End If
            Dim temps As Date = "#00:" & Décompte \ 60 & ":" & Décompte Mod 60 & "#"
            lblcompteur.Text = Format(temps, "m:ss")

        Else
            Timer1.Stop()
            MsgBox("Le temps est écoulé, perdu vous avez trouvez " & nbcarre & " carrée en " & tmppourcompleter)
        End If
        If (nbcarre = 5 Or Décompte <= 0) Then
            Dim P As JOUEUR
            P.Nom = lblnom.Text
            P.nbdecarré = nbcarre
            P.nbpartie = 1
            P.tmpJoué = (TMt - Décompte)
            P.tmpmini = tmppourcompleter
            Verif(P)
            Me.Close()
            Form1.Show()
        End If
        Décompte -= 1
    End Sub
    Private Sub Partie_Load(sender As Object, e As EventArgs) Handles Me.Load
        If TMt = 0 Then
            TMt = 60
            Décompte = 60
        End If
        Dim temps As Date = "#00:" & TMt \ 60 & ":" & TMt Mod 60 & "#"
        lblcompteur.Text = Format(temps, "m:ss")
        For Each Element As PictureBox In Panel1.Controls
            Element.Size = New Size(90, 125)
            Element.Image = Memory.My.Resources.Resources.BackCard
        Next
        Décompte -= 1
        nbDeCarteRetourner = 0
        nbcarre = 0
    End Sub
    Function GetValeur(indice As Integer) As Integer
        Return Module1.GetValeur(indice)
    End Function
    Function GetIndice(sender As Object) As Integer
        Dim i As Integer = 0
        For Each pn1 In Panel1.Controls
            If TypeOf pn1 Is PictureBox Then
                i += 1
                If sender.name = pn1.name Then
                    Return i
                End If
            End If
        Next
        Return -1
    End Function
    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click, PictureBox4.Click, PictureBox5.Click, PictureBox6.Click, PictureBox7.Click, PictureBox8.Click, PictureBox9.Click, PictureBox10.Click, PictureBox11.Click, PictureBox12.Click, PictureBox13.Click, PictureBox14.Click, PictureBox15.Click, PictureBox16.Click, PictureBox17.Click, PictureBox18.Click, PictureBox19.Click, PictureBox20.Click
        Timer1.Interval = 1000
        Timer1.Start()
        Dim valeur As Integer = GetValeur(GetIndice(sender))
        revelerLesCartes(sender, valeur)
        nbDeCarteRetourner += 1
        tabNbDeCartesRetourner.Add(GetIndice(sender))
        If nbDeCarteRetourner < 2 Then
            valeurActuelle = valeur
        Else
            If valeurActuelle = valeur Then
                If nbDeCarteRetourner = 4 Then
                    nbcarre += 1
                    tmppourcompleter = TMt - Décompte
                    Desactivé(tabNbDeCartesRetourner)
                    valeurActuelle = 0
                    nbDeCarteRetourner = 0
                    tabNbDeCartesRetourner.Clear()
                End If
            Else
                valeurActuelle = 0
                nbDeCarteRetourner = 0
                Panel1.Enabled = False
                WaitFor(1)
                Panel1.Enabled = True
                retournerCarte(tabNbDeCartesRetourner)
                tabNbDeCartesRetourner.Clear()
            End If
        End If
    End Sub
    Private Sub retournerCarte(tab As ArrayList)

        For j As Integer = 0 To tab.Count() - 1
            Dim i As Integer = 0
            For Each Element As PictureBox In Panel1.Controls
                i += 1
                If i = tab(j) Then
                    Element.Image = Memory.My.Resources.Resources.BackCard
                    Element.Enabled = True
                End If
            Next
        Next
    End Sub
    Private Sub Desactivé(tab As ArrayList)
        For j As Integer = 0 To tab.Count() - 1
            Dim i As Integer = 0
            For Each Element As PictureBox In Panel1.Controls
                i += 1
                If i = tab(j) Then
                    Element.Enabled = False
                    Element.Visible = False
                End If
            Next
        Next
    End Sub
    Private Sub revelerLesCartes(sender As Object, valeur As Integer)
        If valeur = 1 Then
            sender.Image = Memory.My.Resources.Resources.Card0
        ElseIf valeur = 2 Then
            sender.Image = Memory.My.Resources.Resources.Card1
        ElseIf valeur = 3 Then
            sender.Image = Memory.My.Resources.Resources.Card2
        ElseIf valeur = 4 Then
            sender.Image = Memory.My.Resources.Resources.Card3
        ElseIf valeur = 5 Then
            sender.Image = Memory.My.Resources.Resources.Card4
        End If
        sender.Enabled = False
    End Sub
End Class
