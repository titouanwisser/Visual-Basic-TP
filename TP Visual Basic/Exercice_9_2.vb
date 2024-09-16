Module Exercice_9_2
    Sub Main()
        Dim s, note, nbr_note, moyenne As Decimal
        Do
            Console.WriteLine("Entrez une note entre 0 et 20 (-1 pour sortir) :")
            note = Console.ReadLine()
            If note < 0 Or note > 20 Then
                If note = -1 Then
                    If nbr_note < 1 Then
                        Console.WriteLine("Vous devez entrer au moins une note !")
                    End If
                Else
                    Console.WriteLine("La note doit être entre 0 et 20 !")
                End If
            Else
                nbr_note = nbr_note + 1
                s = s + note
            End If
        Loop Until note = -1 And nbr_note >= 1
        moyenne = s / nbr_note
        moyenne = Decimal.Parse(moyenne).ToString("N2")
        Console.WriteLine("La somme est de : " + s.ToString())
        Console.WriteLine("Le compteur est de : " + nbr_note.ToString())
        Console.WriteLine("Votre moyenne est de " + moyenne.ToString())
        Console.ReadLine()
    End Sub

End Module
