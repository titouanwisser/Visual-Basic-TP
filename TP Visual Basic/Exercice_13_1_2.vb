Module Exercice_13_1_2

    Sub main()
        Dim nombres(9), noNombre, nbr_nbrs, min, max As Integer
        Dim reponse As String
        nbr_nbrs = 10
        Do
            For noNombre = 0 To nbr_nbrs - 1
                Do
                    Console.WriteLine("Nombre n° " + (noNombre + 1).ToString() + " :")
                    nombres(noNombre) = Console.ReadLine()
                Loop Until nombres(noNombre) >= 0 And nombres(noNombre) <= 20
            Next
            min = nombres(0)
            For noNombre = 0 To nbr_nbrs - 1
                If nombres(noNombre) < min Then
                    min = nombres(noNombre)
                End If
            Next
            max = nombres(0)
            For noNombre = 0 To nbr_nbrs - 1
                If nombres(noNombre) > max Then
                    max = nombres(noNombre)
                End If
            Next
            Console.WriteLine("Min = " + min.ToString())
            Console.WriteLine("Max = " + max.ToString())
            Console.WriteLine("Autre tableau ? (O/N)")
            reponse = Console.ReadLine()
        Loop Until reponse = "N"
    End Sub

End Module

