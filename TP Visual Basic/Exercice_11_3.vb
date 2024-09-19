Module Exercice_11_3
    Sub Main()
        Dim choix As Integer
        Dim duree_terre, vitesse_lumiere, vitesse_fusee, duree_fusee As Double
        Dim pi As Decimal
        vitesse_lumiere = 300000
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
                    duree_terre = duree_fusee / Math.Sqrt(1 - (vitesse_fusee * vitesse_fusee / (vitesse_lumiere * vitesse_lumiere)))
                    Console.WriteLine("Durée écoulée sur Terre : " + duree_terre.ToString())
                    Console.WriteLine(". . . Rappel menu . . .")

                Case 2
                    Console.WriteLine("Quel est le rayon du cercle ? (Rayon > 0)")

                    Console.WriteLine(". . . Rappel menu . . .")

                Case 3
                    Console.WriteLine("Quelle est la longueur du rectangle ? (Longueur > 0)")

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
