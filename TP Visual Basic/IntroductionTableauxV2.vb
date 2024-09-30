Module IntroductionTableauxV2

    Sub Main()

        Const NOMBREDENOTES = 10

        Dim notes(9) As Integer 'Déclaration d'un tableau de 10 entiers

        Dim noNote, somme As Integer

        ' Saisie des notes

        For noNote = 0 To NOMBREDENOTES - 1

            Do

                Console.WriteLine(" Saisir le note n°:" + (noNote + 1).ToString())

                notes(noNote) = Console.ReadLine()

            Loop Until notes(noNote) >= 0 And notes(noNote) <= 20

        Next

        ' Calcul de la moyenne

        somme = 0

        For noNote = 0 To NOMBREDENOTES - 1

            somme = somme + notes(noNote)

        Next

        Console.WriteLine("La moyenne est :" + (somme / NOMBREDENOTES).ToString())

        ' Le tri du tableau en ordre croissant sera fait plus loin

        Console.ReadLine()

    End Sub

End Module