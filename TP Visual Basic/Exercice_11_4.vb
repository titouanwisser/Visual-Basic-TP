Module Exercice_11_4

    Sub main()
        Dim choix, compteur, compteur_fois, compteur_etoiles As Integer
        compteur_etoiles = 1
        Console.WriteLine("Combien de lignes pour votre triangle ? (>= 0)")
        choix = Console.ReadLine()
        If choix < 0 Then
            Do
                Console.WriteLine("La valeur doit être égale ou supérieure à 0 !")
                Console.WriteLine("Combien de lignes pour votre triangle ? (>= 0)")
                choix = Console.ReadLine()
            Loop Until choix >= 0
        End If
        Do
            For compteur = 1 To compteur_etoiles
                Console.Write("*")
            Next
            Console.WriteLine()
            compteur_etoiles = compteur_etoiles + 2
            compteur_fois = compteur_fois + 1
        Loop Until choix = compteur_fois
        Console.ReadLine()

    End Sub

End Module
