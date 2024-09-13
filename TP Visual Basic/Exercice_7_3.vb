Module Exercice_7_3
    Sub Main()
        Dim taux_horaire, heures_travail, heures_supp_25, heures_supp_50, taux25, taux50, salaire_hebdo As Decimal
        Console.WriteLine("Nombre d'heures travaillées cette semaine ?")
        heures_travail = Console.ReadLine()
        If heures_travail < 39 Then
            Console.WriteLine("Vous ne travaillez pas assez !")
            Console.WriteLine("Salaire hebdomadaire : 0")
        ElseIf heures_travail > 39 And heures_travail < 47 Then
            Console.WriteLine("Taux horaire ?")
            taux_horaire = Console.ReadLine()
            heures_supp_25 = heures_travail - 39
            taux25 = taux_horaire * heures_supp_25 * 1.25
            salaire_hebdo = ((heures_travail - heures_supp_25) * taux_horaire) + taux25
            Console.WriteLine("Salaire hebdomadaire : " + salaire_hebdo.ToString())
        ElseIf heures_travail > 47 Then
            Console.WriteLine("Taux horaire ?")
            taux_horaire = Console.ReadLine()
            heures_supp_25 = 8
            heures_supp_50 = heures_travail - 47
            taux25 = taux_horaire * heures_supp_25 * 1.25
            taux50 = taux_horaire * heures_supp_50 * 1.5
            salaire_hebdo = ((heures_travail - heures_supp_25 - heures_supp_50) * taux_horaire) + taux25 + taux50
            Console.WriteLine("Le salaire hebdomadaire est de " + salaire_hebdo.ToString() + " euros")
        End If
        Console.WriteLine("Au revoir !")
        Console.ReadLine()
    End Sub

End Module
