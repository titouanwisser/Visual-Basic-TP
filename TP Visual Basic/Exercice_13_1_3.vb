Module Exercice_13_1_3

    Sub Main()
        Dim choix, base, resultat, quotient, reste, nbr_nbrs As Double

        Do
            Console.WriteLine("Choisis un nombre compris entre 0 et 255 à convertir : ")
            choix = Console.ReadLine()
            If choix < 0 Or choix > 255 Then
                Console.WriteLine("La valeur doit être comprise entre 0 et 255 !")
            End If
        Loop Until choix >= 0 And choix <= 255
        Do
            Console.WriteLine("Choisis ta base de conversion (2 / 8) : ")
            base = Console.ReadLine()
            If base <> 2 And base <> 8 Then
                Console.WriteLine("La base de conversion est erronée !")
            End If
        Loop Until base = 2 Or base = 8

        quotient = choix
        If base = 2 Then
            Dim base2(7) As Double
            nbr_nbrs = 8
            For noNombre = 0 To nbr_nbrs - 1
                reste = quotient Mod 2
                quotient = quotient \ 2
                base2(noNombre) = reste
            Next
            For noNombre = 0 To nbr_nbrs - 1
                Console.Write(base2(7 - noNombre))
            Next

        Else

        End If

        Console.ReadLine()

    End Sub

End Module
