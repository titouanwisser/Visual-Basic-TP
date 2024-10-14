Module Exercice_9_3
    Sub main()
        Dim choix, compteur As Integer
        Dim réponse As String
        Dim nombre As Double
        Do
            nombre = 0
            Console.WriteLine("Jusqu'à combien voulez vous aller ? (>0)")
            choix = Console.ReadLine()
            If choix < 0 Then
                Do
                    Console.WriteLine("La valeur doit être supérieure à 0 !")
                    Console.WriteLine("Jusqu'à combien voulez vous aller ? (>0)")
                    choix = Console.ReadLine()
                Loop Until choix > 0
            End If
            Console.WriteLine("La suite est :")
            For compteur = 1 To choix
                nombre = nombre + 2
                Console.WriteLine(nombre)
            Next
            Console.WriteLine("Autre suite  ? (O/N)")
            réponse = Console.ReadLine()
        Loop Until (réponse = "N")
        Console.WriteLine("Au revoir !")
        Console.ReadLine()
    End Sub
End Module
