Module Exercice_13_3
    Const MAXSALLES As Integer = 10  ' mis à 10 (au lieu de 50) pour test
    Const MAXJOURS As Integer = 6
    Const MAXTRANCHES As Integer = 10

    Sub Initialiser(ByRef pTab(,,) As Integer)
        Dim noSalle, noJour, noTranche As Integer

        For noSalle = 1 To 10
            For noJour = 1 To 6
                For noTranche = 1 To 10
                    pTab(noSalle, noJour, noTranche) = 0
                Next
            Next
        Next

    End Sub

    Sub Main()

        Dim capaciteLue, heureLue, jourLu, occupation(MAXSALLES, MAXJOURS, MAXTRANCHES) As Integer

        Dim capacité() As Integer = {20, 40, 30, 20, 10,
                                    50, 10, 20, 20, 25}

        Initialiser(occupation)

        occupation(3, 2, 4) = 1
        occupation(1, 1, 1) = 1
        occupation(1, 2, 1) = 1
        occupation(4, 5, 1) = 1
        occupation(2, 2, 4) = 1
        occupation(8, 3, 2) = 1
        occupation(5, 3, 3) = 1

        Do
            Console.WriteLine("Jour ?")
            jourLu = Console.ReadLine()
            If jourLu < 0 Or jourLu > 6 Then
                Console.WriteLine("La valeur n'est pas correcte !")
            End If
        Loop Until jourLu > 0 And jourLu <= 6
        Do
            Console.WriteLine("Tranche horaire ?")
            heureLue = Console.ReadLine()
            If heureLue <= 0 Or heureLue > 10 Then
                Console.WriteLine("La valeur n'est pas correcte !")
            End If
        Loop Until heureLue > 0 And heureLue <= 10
        Do
            Console.WriteLine("Capacité ?")
            capaciteLue = Console.ReadLine()
            If capaciteLue <= 0 Then
                Console.WriteLine("La valeur n'est pas correcte !")
            End If
        Loop Until capaciteLue > 0
        Console.Write("Les salles ")

        For salle = 1 To MAXSALLES
            If occupation(salle, jourLu, heureLue) = 0 Then
                If capacité(salle - 1) > capaciteLue Then
                    Console.Write((salle).ToString() + ", ")
                End If
            End If
        Next

        Console.Write("sont disponibles.")

        Console.ReadLine()

    End Sub
End Module
