Imports System.Linq.Expressions

Module Exercice_9_4
    Sub Main()
        Dim nom, réponse As String
        Dim nbr_ventes, semaine, compteur As Integer
        Dim s, commission, ventes, total_ventes As Decimal
        compteur = 0
        Do
            semaine = 1
            Console.WriteLine("Quel est le nom du représentant ?")
            nom = Console.ReadLine()
            Do
                Console.WriteLine("Semaine " + semaine.ToString() + " : Ventes H.T. hebdomadaires (0 pour stopper la saisie, 4 semaines max) :")
                ventes = Console.ReadLine()
                If ventes = 0 Then
                    If nbr_ventes < 1 Then
                        Console.WriteLine("Vous devez entrer au moins une valeur !")
                    End If
                ElseIf ventes < 0 Then
                    Console.WriteLine("La valeur ne peut pas être inférieure à 0 !")
                Else
                    semaine = semaine + 1
                    nbr_ventes = nbr_ventes + 1
                    s = s + ventes
                    compteur = compteur + 1
                End If
            Loop Until (ventes = 0 And nbr_ventes >= 1) Or compteur = 4
            commission = s / 10
            ventes = Decimal.Parse(ventes).ToString("N2")
            total_ventes = Decimal.Parse(total_ventes).ToString("N2")
            Console.WriteLine("Bilan pour " + nom)
            Console.WriteLine("Total des ventes H.T. : " + s.ToString())
            Console.WriteLine("Commission : " + commission.ToString())
            Console.WriteLine("Autre représentant ? (O/N)")
            réponse = Console.ReadLine()
        Loop Until (réponse = "N")
        Console.WriteLine("Au revoir !")
        Console.ReadLine()
    End Sub
End Module
