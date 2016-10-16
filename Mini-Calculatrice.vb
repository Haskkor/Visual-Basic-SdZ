Module Module1

    Sub Main()

        'Déclaration des variables
        Dim Choix As String = ""
        Dim Chiffre1, Chiffre2 As Double
        Dim Valeur As String = ""

        'Message à l'utilisateur
        Console.WriteLine("-   Minicalculatrice   -")
        Console.WriteLine("- Opérations possibles -")
        Console.WriteLine("-     Addition = A     -")
        Console.WriteLine("-   Soustraction = S   -")
        Console.WriteLine("-  Multiplication = M  -")
        Console.WriteLine("-     Division = D     -")
        Console.WriteLine(" ")

        'Demande de l'opération à effectuer
        Do
            Console.WriteLine("Quelle opération voulez-vous effectuer?")
            Choix = Console.ReadLine()
        Loop Until Choix = "A" Or Choix = "S" Or Choix = "M" Or Choix = "D"

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

        'Opérations en fonction du choix
        Select Case Choix

            'Addition
            Case "A"
                Console.Write(Chiffre1 & " + " & Chiffre2 & " = " & Chiffre1 + Chiffre2)
                'Soustraction
            Case "S"
                Console.Write(Chiffre1 & " - " & Chiffre2 & " = " & Chiffre1 - Chiffre2)
                'Multiplication
            Case "M"
                Console.Write(Chiffre1 & " X " & Chiffre2 & " = " & Chiffre1 * Chiffre2)
                'Division
            Case "D"
                Console.WriteLine("Valeur exacte : " & Chiffre1 & " / " & Chiffre2 & " = " & Chiffre1 / Chiffre2)
                Console.WriteLine("Résultat entier : " & Chiffre1 \ Chiffre2)
                Console.WriteLine("Reste : " & Chiffre1 Mod Chiffre2)
        End Select

        'Pause factice
        Console.Read()
    End Sub

End Module
