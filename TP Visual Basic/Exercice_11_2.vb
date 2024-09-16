Module Exercice_11_2
    Sub Main()
        Dim nombre, factorielle As Decimal
        Do
            Console.WriteLine("Saisir un nombre >= 0 (-1 pour sortir)")
            nombre = Console.ReadLine()
            If nombre < -1 Then
                Do
                    Console.WriteLine("Le nombre doit être égal ou supérieur à 0 !")
                    Console.WriteLine("Saisir un nombre >= 0")
                    nombre = Console.ReadLine()
                Loop Until nombre >= 0
            End If
            If nombre > 0 Then
                factorielle = nombre
                Do
                    nombre = nombre - 1
                    factorielle = factorielle * nombre
                Loop Until nombre = 1
                Console.WriteLine("La factorielle de ce nombre est : " + factorielle.ToString())
            End If
        Loop Until nombre = -1
        Console.WriteLine("Au revoir !")
        Console.ReadLine()
    End Sub
End Module
