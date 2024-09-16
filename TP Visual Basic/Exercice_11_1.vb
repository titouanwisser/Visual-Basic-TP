Module Exercice_11_1
    Sub Main()
        Dim choix As Integer
        Dim rayon_cercle, périmètre_cercle, surface_cercle, longueur_rectangle, largeur_rectangle, périmètre_rectangle, surface_rectangle, pi As Decimal
        pi = 3.1415926535897931
        Console.WriteLine("1. Calcul du périmètre d'un cercle.")
        Console.WriteLine("2. Calcul de la surface d'un cercle.")
        Console.WriteLine("3. Calcul du périmètre d'un rectangle.")
        Console.WriteLine("4. Calcul de la surface d'un rectangle.")
        Console.WriteLine("5. Quitter.")
        Do
            Console.WriteLine("Quel est votre choix ?")
            choix = Console.ReadLine()
            Select Case choix

                Case 1
                    Console.WriteLine("Quel est le rayon du cercle ? (Rayon > 0)")
                    rayon_cercle = Console.ReadLine()
                    If rayon_cercle <= 0 Then
                        Do
                            Console.WriteLine("Le rayon doit être supérieur à 0 !")
                            Console.WriteLine("Quel est le rayon du cercle ? (Rayon > 0)")
                            rayon_cercle = Console.ReadLine()
                        Loop Until rayon_cercle > 0
                    End If
                    périmètre_cercle = 2 * pi * rayon_cercle
                    Console.WriteLine("Le périmètre du cerle est de " + périmètre_cercle.ToString())
                    Console.WriteLine(". . . Rappel menu . . .")

                Case 2
                    Console.WriteLine("Quel est le rayon du cercle ? (Rayon > 0)")
                    rayon_cercle = Console.ReadLine()
                    If rayon_cercle <= 0 Then
                        Do
                            Console.WriteLine("Le rayon doit être supérieur à 0 !")
                            Console.WriteLine("Quel est le rayon du cercle ? (Rayon > 0)")
                            rayon_cercle = Console.ReadLine()
                        Loop Until rayon_cercle > 0
                    End If
                    surface_cercle = rayon_cercle * rayon_cercle * pi
                    Console.WriteLine("La surface du cerle est de " + surface_cercle.ToString())
                    Console.WriteLine(". . . Rappel menu . . .")

                Case 3
                    Console.WriteLine("Quelle est la longueur du rectangle ? (Longueur > 0)")
                    longueur_rectangle = Console.ReadLine()
                    Console.WriteLine("Quelle est la largeur du rectangle ? (Largeur > 0)")
                    largeur_rectangle = Console.ReadLine()
                    If longueur_rectangle <= 0 Then
                        Do
                            Console.WriteLine("La longueur doit être supérieure à 0 !")
                            Console.WriteLine("Quelle est la longueur du rectangle ? (Longueur > 0)")
                            longueur_rectangle = Console.ReadLine()
                        Loop Until longueur_rectangle > 0
                    End If
                    If largeur_rectangle <= 0 Then
                        Do
                            Console.WriteLine("La largeur doit être supérieure à 0 !")
                            Console.WriteLine("Quelle est la largeur du rectangle ? (Largeur > 0)")
                            largeur_rectangle = Console.ReadLine()
                        Loop Until largeur_rectangle > 0
                    End If
                    périmètre_rectangle = (longueur_rectangle + largeur_rectangle) * 2
                    Console.WriteLine("Le périmètre du rectangle est de " + périmètre_rectangle.ToString())
                    Console.WriteLine(". . . Rappel menu . . .")

                Case 4
                    Console.WriteLine("Quelle est la longueur du rectangle ? (Longueur > 0)")
                    longueur_rectangle = Console.ReadLine()
                    Console.WriteLine("Quelle est la largeur du rectangle ? (Largeur > 0)")
                    largeur_rectangle = Console.ReadLine()
                    If longueur_rectangle <= 0 Then
                        Do
                            Console.WriteLine("La longueur doit être supérieure à 0 !")
                            Console.WriteLine("Quelle est la longueur du rectangle ? (Longueur > 0)")
                            longueur_rectangle = Console.ReadLine()
                        Loop Until longueur_rectangle > 0
                    End If
                    If largeur_rectangle <= 0 Then
                        Do
                            Console.WriteLine("La largeur doit être supérieure à 0 !")
                            Console.WriteLine("Quelle est la largeur du rectangle ? (Largeur > 0)")
                            largeur_rectangle = Console.ReadLine()
                        Loop Until largeur_rectangle > 0
                    End If
                    surface_rectangle = longueur_rectangle * largeur_rectangle
                    Console.WriteLine("La surface du rectangle est de " + surface_rectangle.ToString())
                    Console.WriteLine(". . . Rappel menu . . .")

                Case 5

                Case Else
                    Console.WriteLine("Votre saisie est incorrecte.")
                    Console.WriteLine(". . . Rappel menu . . .")

            End Select
        Loop Until (choix = 5)
        Console.WriteLine("Au revoir !")
        Console.ReadLine()
    End Sub
End Module
