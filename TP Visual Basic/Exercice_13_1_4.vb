Module Exercice_13_1_4

    Sub Main()
        Dim devises() As String = {"ATS", "BEF", "DEM", "ESP", "FRF", "IEP", "ITL", "FIM",
                                   "LUF", "NLG", "GRD", "SIT", "ATS", "PTE", "CYP", "MTL", "SKK"}
        Dim taux() As Double = {13.76, 40.33, 1.95, 166.38, 6.55, 0.78, 1936.27, 5.94,
                                40.33, 2.2, 340.75, 239.64, 13.76, 200.48, 0.58, 0.42, 30.12}
        Dim choixMontant, nocase As Double
        Dim choixCodeDevise, reponse As String

        Do
            Do
                Console.WriteLine("Montant en euro ?")
                choixMontant = Console.ReadLine()
                nocase = -1
                If choixMontant < 0 Then
                    Do
                        Console.WriteLine("La valeur doit être égale ou supérieure à 0 !")
                        Console.WriteLine("Montant en euro ?")
                        choixMontant = Console.ReadLine()
                    Loop Until choixMontant >= 0
                End If
                Console.WriteLine("Code de la devise ?")
                choixCodeDevise = Console.ReadLine()
                For noDevise = 0 To 16
                    If devises(noDevise) = choixCodeDevise Then
                        nocase = noDevise
                        Exit For
                    End If
                    If noDevise = 16 And devises(noDevise) <> choixCodeDevise Then
                        Console.WriteLine("Devise non trouvée !")
                        Console.WriteLine("//////////////////////////////")
                        Exit For
                    End If
                Next
            Loop Until nocase <> -1

            Console.WriteLine("Montant dans l'ancienne monnaie nationale : " + (choixMontant * taux(nocase)).ToString() + " " + devises(nocase).ToString())

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
        Console.WriteLine("Au revoir !")
        Console.ReadLine()
    End Sub

End Module
