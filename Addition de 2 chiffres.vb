Module Module1

    Sub Main()

        'Déclaration des variables
        Dim Chiffre1, Chiffre2 As Double
        Dim Valeur As String

        'Message à l'utilisateur
        Console.WriteLine("- Addition de deux nombres -")

        'Demande de la première valeur
        Do
            Console.WriteLine("Entrez la première valeur : ")
            Valeur = Console.ReadLine()
        Loop Until IsNumeric(Valeur)
        Chiffre1 = Valeur

        'Demande de la seconde valeur
        Do
            Console.WriteLine("Entrez la seconde valeur : ")
            Valeur = Console.ReadLine()
        Loop Until IsNumeric(Valeur)
        Chiffre2 = Valeur

        'Affichage du résultat
        Console.Write(Chiffre1 & " + " & Chiffre2 & " = " & Chiffre1 + Chiffre2)
        Console.Read()

    End Sub

End Module
