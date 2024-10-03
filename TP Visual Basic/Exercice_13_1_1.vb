Module Exercice_13_1_1

    Sub main()
        Dim mois(11), reponse As String
        Dim choix As Integer
        Do
            mois(0) = "Janvier"
            mois(1) = "Février"
            mois(2) = "Mars"
            mois(3) = "Avril"
            mois(4) = "Mai"
            mois(5) = "Juin"
            mois(6) = "Juillet"
            mois(7) = "Août"
            mois(8) = "Septembre"
            mois(9) = "Octobre"
            mois(10) = "Novembre"
            mois(11) = "Décembre"
            Console.WriteLine("Quel mois voulez-vous consulter ?")
            choix = Console.ReadLine()
            Console.WriteLine("Ce mois est : " + mois(choix))
            Console.WriteLine("Autre mois ? (O/N)")
            reponse = Console.ReadLine()
        Loop Until reponse = "N"
    End Sub

End Module
