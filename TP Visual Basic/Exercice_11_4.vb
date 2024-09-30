Module Exercice_11_4

    Sub main()
        Dim choix, compteur, compteur_fois, nombre_etoiles, nombre_espaces, compteur_etoiles, compteur_espaces As Integer
        Console.WriteLine("Combien de lignes pour votre triangle ? (>= 0)")
        choix = Console.ReadLine()
        If choix < 0 Then
            Do
                Console.WriteLine("La valeur doit être égale ou supérieure à 0 !")
                Console.WriteLine("Combien de lignes pour votre triangle ? (>= 0)")
                choix = Console.ReadLine()
            Loop Until choix >= 0
        End If
        nombre_espaces = choix - 1
        compteur_etoiles = 1
        Do
            For compteur_espaces = 1 To nombre_espaces
                Console.Write(" ")
            Next
            For compteur_etoiles = 0 To nombre_etoiles
                Console.Write("*")
            Next
            Console.WriteLine()
            nombre_etoiles = compteur_etoiles + 1
            nombre_espaces = nombre_espaces - 1
            compteur_fois = compteur_fois + 1
        Loop Until choix = compteur_fois
        Console.ReadLine()

    End Sub

End Module
