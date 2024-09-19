Imports System.Net.NetworkInformation

Module Exercice_11_1

    Function PérimètreCercle(ByVal rX As Decimal) As Decimal
        Return 2 * 3.1415926535897931 * rX
    End Function

    Function SurfaceCercle(ByVal rX As Decimal) As Decimal
        Return rX * rX * 3.1415926535897931
    End Function

    Function PérimètreRectangle(ByVal loR As Decimal, ByVal laR As Decimal) As Decimal
        Return (loR + laR) * 2
    End Function

    Function SurfaceRectangle(ByVal loR As Decimal, ByVal laR As Decimal) As Decimal
        Return loR * laR
    End Function

    Sub Main()
        Dim choix As Integer
        Dim rx, loR, laR, pi As Decimal
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
                    rX = Console.ReadLine()
                    If rX <= 0 Then
                        Do
                            Console.WriteLine("Le rayon doit être supérieur à 0 !")
                            Console.WriteLine("Quel est le rayon du cercle ? (Rayon > 0)")
                            rx = Console.ReadLine()
                        Loop Until rX > 0
                    End If
                    Console.WriteLine("Le périmètre du cerle est de " + PérimètreCercle(rx).ToString())
                    Console.WriteLine(". . . Rappel menu . . .")

                Case 2
                    Console.WriteLine("Quel est le rayon du cercle ? (Rayon > 0)")
                    rx = Console.ReadLine()
                    If rx <= 0 Then
                        Do
                            Console.WriteLine("Le rayon doit être supérieur à 0 !")
                            Console.WriteLine("Quel est le rayon du cercle ? (Rayon > 0)")
                            rx = Console.ReadLine()
                        Loop Until rX > 0
                    End If
                    Console.WriteLine("La surface du cerle est de " + SurfaceCercle(rx).ToString())
                    Console.WriteLine(". . . Rappel menu . . .")

                Case 3
                    Console.WriteLine("Quelle est la longueur du rectangle ? (Longueur > 0)")
                    loR = Console.ReadLine()
                    Console.WriteLine("Quelle est la largeur du rectangle ? (Largeur > 0)")
                    laR = Console.ReadLine()
                    If loR <= 0 Then
                        Do
                            Console.WriteLine("La longueur doit être supérieure à 0 !")
                            Console.WriteLine("Quelle est la longueur du rectangle ? (Longueur > 0)")
                            loR = Console.ReadLine()
                        Loop Until loR > 0
                    End If
                    If laR <= 0 Then
                        Do
                            Console.WriteLine("La largeur doit être supérieure à 0 !")
                            Console.WriteLine("Quelle est la largeur du rectangle ? (Largeur > 0)")
                            laR = Console.ReadLine()
                        Loop Until laR > 0
                    End If
                    Console.WriteLine("Le périmètre du rectangle est de " + PérimètreRectangle(loR, laR).ToString())
                    Console.WriteLine(". . . Rappel menu . . .")

                Case 4
                    Console.WriteLine("Quelle est la longueur du rectangle ? (Longueur > 0)")
                    loR = Console.ReadLine()
                    Console.WriteLine("Quelle est la largeur du rectangle ? (Largeur > 0)")
                    laR = Console.ReadLine()
                    If loR <= 0 Then
                        Do
                            Console.WriteLine("La longueur doit être supérieure à 0 !")
                            Console.WriteLine("Quelle est la longueur du rectangle ? (Longueur > 0)")
                            loR = Console.ReadLine()
                        Loop Until loR > 0
                    End If
                    If laR <= 0 Then
                        Do
                            Console.WriteLine("La largeur doit être supérieure à 0 !")
                            Console.WriteLine("Quelle est la largeur du rectangle ? (Largeur > 0)")
                            laR = Console.ReadLine()
                        Loop Until laR > 0
                    End If
                    Console.WriteLine("La surface du rectangle est de " + SurfaceRectangle(loR, laR).ToString())
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
