Module Exercice_13_2
    Sub AfficherLesNombres(ByRef tableau(,) As Double)
        Dim noLigne, noColonne As Double
        For noLigne = 0 To 3
            For noColonne = 0 To 3
                Console.Write(tableau(noLigne, noColonne).ToString + vbTab)
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub Main()
        Dim lesNombres(,) As Double = {
        {1, 2, 3, 4},
        {5, 6, 7, 8},
        {9, 10, 11, 12},
        {13, 14, 15, 16}
    }
        Console.WriteLine("Matrice avant inversion :")
        AfficherLesNombres(lesNombres)
        Console.WriteLine("Matrice après inversion :")

        Console.ReadLine()
    End Sub
End Module
