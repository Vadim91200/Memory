Module Module1
    Dim tab(19) As Integer
    Public Structure JOUEUR
        Public Nom As String
        Public nbdecarré As Integer
        Public tmpmini As Integer
        Public nbpartie As Integer
        Public tmpJoué As Integer
    End Structure
    Private TailleT As Integer = 10
    Private TJOUEUR As JOUEUR()
    Private NbPERS As Integer = 0
    Public Function getP(i As Integer)
        Return TJOUEUR(i)
    End Function
    Public Function getNb() As Integer
        Return NbPERS
    End Function
    Public Function Recharger()
        Dim num As Integer = FreeFile()
        FileOpen(num, "Joueur.txt", OpenMode.Input)
        Dim t As Integer = 0
        Dim PC As JOUEUR
        Input(num, t)
        For i As Integer = 0 To t - 1
            Input(num, PC.Nom)
            Input(num, PC.nbdecarré)
            Input(num, PC.tmpmini)
            Input(num, PC.tmpJoué)
            Input(num, PC.nbpartie)
            Verif(PC)
            Form1.cbnom.Items.Add(PC.Nom)
        Next

        FileClose(num)
    End Function
    Sub Main()
        ReDim TJOUEUR(TailleT - 1)
        For i As Integer = 0 To 19
            If (i <= 3) Then
                tab(i) = 1
            End If
            If (i > 3 And i <= 7) Then
                tab(i) = 2
            End If
            If (i > 7 And i <= 11) Then
                tab(i) = 3
            End If
            If (i > 11 And i <= 15) Then
                tab(i) = 4
            End If
            If (i > 15 And i <= 19) Then
                tab(i) = 5
            End If
        Next
        Recharger()
        Mélange()
        Application.Run(Form1)
    End Sub

    Public Function Verif(ByVal PC As JOUEUR)
        Dim o As Integer = 0
        For i = 0 To NbPERS
            If TJOUEUR(i).Nom = PC.Nom Then
                If PC.nbdecarré > TJOUEUR(i).nbdecarré Then
                    TJOUEUR(i).tmpmini = PC.tmpmini
                    TJOUEUR(i).nbdecarré = PC.nbdecarré
                End If
                If PC.tmpmini < TJOUEUR(i).tmpmini Then
                    TJOUEUR(i).tmpmini = PC.tmpmini
                End If
                TJOUEUR(i).nbpartie += 1
                TJOUEUR(i).tmpJoué += PC.tmpJoué
                o += 1
            End If
        Next
        If o = 0 Then
            If (NbPERS = TailleT) Then
                ReDim Preserve TJOUEUR(NbPERS * 2)
            End If
            TJOUEUR(NbPERS) = PC
            NbPERS += 1
        End If
    End Function
    Function GetValeur(indice As Integer) As Integer
        Return tab(indice - 1)
    End Function
    Public Sub Mélange()
        Dim Tmp As Integer = 0
        Dim random As Random = New Random()
        For i As Integer = 0 To tab.Length - 1
            Dim j As Integer = random.Next(0, tab.Length - 1)
            Tmp = tab(i)
            tab(i) = tab(j)
            tab(j) = Tmp
        Next
    End Sub
End Module