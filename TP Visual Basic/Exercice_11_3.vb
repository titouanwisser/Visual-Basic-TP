Module Exercice_11_3

    Function DilatationTemps(ByVal v As Decimal, ByVal t As Decimal) As Decimal
        Dim vitesselumiere As Double
        vitesselumiere = 300000
        Return t / Math.Sqrt(1 - (v * v / (vitesselumiere * vitesselumiere)))
    End Function

    Function ContractionLongueurs(ByVal v As Decimal, ByVal l As Decimal) As Decimal
        Dim vitesselumiere As Double
        vitesselumiere = 300000
        Return l * Math.Sqrt(1 - (v * v / (vitesselumiere * vitesselumiere)))
    End Function

    Function CompositionVitesses(ByVal vF As Decimal, ByVal vO As Decimal) As Decimal
        Dim vitesselumiere As Decimal
        vitesselumiere = 300000
        Return (vO + vF) / (1 + ((vO * vF) / (vitesselumiere * vitesselumiere)))
    End Function

    Sub Main()
        Dim choix As Integer
        Dim vitesse_fusee, vitesse_obus, duree_fusee, taille_fusee As Double
        Dim pi As Decimal
        pi = 3.1415926535897931
        Console.WriteLine("1. La dilatation du temps")
        Console.WriteLine("2. La contraction des longueurs")
        Console.WriteLine("3. Loi de composition des vitesses")
        Console.WriteLine("4. Quitter")

        Do
            Console.WriteLine("Quel est votre choix ?")
            choix = Console.ReadLine()
            Select Case choix

                Case 1
                    Console.WriteLine("Quel est la vitesse de la fusée ? (en km/s)")
                    vitesse_fusee = Console.ReadLine()
                    Console.WriteLine("Quelle est la durée écoulée dans la fusée ? (en secondes)")
                    duree_fusee = Console.ReadLine()
                    Console.WriteLine("Durée écoulée sur Terre : " + DilatationTemps(vitesse_fusee, duree_fusee).ToString())
                    Console.WriteLine(". . . Rappel menu . . .")

                Case 2
                    Console.WriteLine("Quel est la vitesse de la fusée ? (en km/s)")
                    vitesse_fusee = Console.ReadLine()
                    Console.WriteLine("Quelle est la taille de la fusée ? (en kms)")
                    taille_fusee = Console.ReadLine()
                    Console.WriteLine("Taille de la fusée vue de la Terre : " + ContractionLongueurs(vitesse_fusee, taille_fusee).ToString())
                    Console.WriteLine(". . . Rappel menu . . .")

                Case 3
                    Console.WriteLine("Quel est la vitesse de la fusée ? (en km/s)")
                    vitesse_fusee = Console.ReadLine()
                    Console.WriteLine("Quelle est la vitesse de l'obus, dans le repère de la fusée ? (en kms)")
                    vitesse_obus = Console.ReadLine()
                    Console.WriteLine("Vitesse de l'obus par rapport à la Terre : " + CompositionVitesses(vitesse_fusee, vitesse_obus).ToString())
                    Console.WriteLine(". . . Rappel menu . . .")

                Case 4

                Case Else
                    Console.WriteLine("Votre saisie est incorrecte.")
                    Console.WriteLine(". . . Rappel menu . . .")

            End Select
        Loop Until (choix = 4)
        Console.WriteLine("Au revoir !")
        Console.ReadLine()
    End Sub
End Module
