Module Exercice_9_1
    Sub Main()
        Dim s, note, nbr_note, moyenne As Decimal
        Dim nbr_note_sup_10 As Integer
        Console.WriteLine("Entrez une note (-1 pour fin) :")
        note = Console.ReadLine()
        While note > -1
            If note > 10 Then
                nbr_note_sup_10 = nbr_note_sup_10 + 1
            End If
            nbr_note = nbr_note + 1
            s = s + note
            Console.WriteLine("Entrez une note (-1 pour fin) :")
            note = Console.ReadLine()
        End While
        moyenne = s / nbr_note
        nbr_note_sup_10 = nbr_note_sup_10 / nbr_note * 100
        moyenne = Decimal.Parse(moyenne).ToString("N2")
        Console.WriteLine("Vous avez " + nbr_note_sup_10.ToString() + "% de notes supérieures à 10.")
        Console.WriteLine("Votre moyenne est de " + moyenne.ToString())
        Console.ReadLine()
    End Sub

End Module
