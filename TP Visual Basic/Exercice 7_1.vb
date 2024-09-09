Module Exercice_7_1
    Sub Main()

        Dim montant As Integer
        Console.WriteLine("Veuillez taper votre montant.")
        montant = Console.ReadLine()
        If montant < 2000 Then
            Console.WriteLine("Pas de remise.")
            Console.WriteLine("Le montant net est : " + montant.ToString)
        ElseIf montant > 2000 And montant < 5000 Then
            Console.WriteLine("Remise de 1%")
            Console.WriteLine("Le montant net est : " + (montant * 0.99).ToString)
        ElseIf montant > 5000 Then
            Console.WriteLine("Remise de 2%")
            Console.WriteLine("Le montant net est : " + (montant * 0.98).ToString)
        End If
        Console.WriteLine("Au revoir !")
        Console.ReadLine()


    End Sub
End Module
