Module Exercice_7_2
    Sub Main()
        Dim nombre_jours, distance, montant_essence, montant_diesel As Integer
        Console.WriteLine("Nombre de jours de location ?")
        nombre_jours = Console.ReadLine()
        Console.WriteLine("Distance à parcourir (en kms) ?")
        distance = Console.ReadLine()
        montant_essence = nombre_jours * 30 + distance * 0.85
        montant_diesel = nombre_jours * 35 + distance * 0.65
        If montant_essence < montant_diesel Then
            Console.WriteLine("Meilleur choix : Essence")
        ElseIf montant_diesel < montant_essence Then
            Console.WriteLine("Meilleur choix : Diesel")
        End If
        Console.WriteLine("Au revoir !")
        Console.ReadLine()
    End Sub

End Module
