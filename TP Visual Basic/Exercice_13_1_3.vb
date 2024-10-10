Module Exercice_13_1_3

    Sub Main()
        Dim choix, base, quotient, reste, nbr_nbrs As Double
        Dim reponse As String

        Do
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
                Console.Write("Voici le résultat : ")
                For noNombre = 0 To nbr_nbrs - 1
                    Console.Write(base2((nbr_nbrs - 1) - noNombre))
                Next
                Console.WriteLine()
            Else
                Dim base8(2) As Double
                nbr_nbrs = 3
                For noNombre = 0 To nbr_nbrs - 1
                    reste = quotient Mod 8
                    quotient = quotient \ 8
                    base8(noNombre) = reste
                Next
                Console.Write("Voici le résultat : ")
                For noNombre = 0 To nbr_nbrs - 1
                    Console.Write(base8((nbr_nbrs - 1) - noNombre))
                Next
                Console.WriteLine()
            End If

            Console.WriteLine("Autre conversion ? (O / N)")
            reponse = Console.ReadLine()
            If reponse <> "O" And reponse <> "N" Then
                Do
                    Console.WriteLine("Veuillez répondre avec O ou N !")
                    Console.WriteLine("Autre conversion ? (O / N)")
                    reponse = Console.ReadLine()
                Loop Until reponse = "N" Or reponse = "O"
            End If

        Loop Until reponse = "N"
    End Sub

End Module
