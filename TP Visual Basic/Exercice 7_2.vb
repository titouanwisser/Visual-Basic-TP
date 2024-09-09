Module Exercice_7_2
    Sub Main()
        Dim nombre_jours, distance, nombre_jours_essence, distance_essence, nombre_jours_diesel, distance_diesel, montant_essence, montant_diesel As Integer
        Console.WriteLine("Nombre de jours de location ?")
        nombre_jours = Console.ReadLine()
        Console.WriteLine("Distance à parcourir (en kms) ?")
        distance = Console.ReadLine()
        nombre_jours_essence = nombre_jours * 30
        distance_essence = distance * 0.85
        nombre_jours_diesel = nombre_jours * 35
        distance_essence = distance * 0.65
        montant_essence = nombre_jours_essence + distance_diesel
        montant_diesel = nombre_jours_diesel + distance_diesel
        If montant_essence < montant_diesel Then
            Console.WriteLine("Meilleur choix : Essence")
        ElseIf montant_diesel < montant_diesel Then
            Console.WriteLine("Meilleur choix : Diesel")
        End If
        Console.WriteLine("Au revoir !")
        Console.ReadLine()
    End Sub

End Module
