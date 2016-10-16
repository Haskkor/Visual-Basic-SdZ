Module Module1

    Sub Main()

        'Déclaration des variable
        Dim MonTableau(50), TableauDeComptage(10) As Integer

        'Génération d'un tableau remplit de chiffres aléatoires
        For i As Integer = 0 To MonTableau.Length - 1
            MonTableau(i) = Rnd(1) * 10
        Next

        'Initialisation des cases du tableau de comptage avec des 0
        For i = 0 To TableauDeComptage.Length - 1
            TableauDeComptage(i) = 0
        Next

        'Compte des occurrences
        For i As Integer = 0 To MonTableau.Length - 1
            TableauDeComptage(MonTableau(i)) += 1
        Next

        'Affichage du résultat
        For i As Integer = 0 To TableauDeComptage.Length - 1
            Console.WriteLine("Nombre de " & i & " dans le tableau = " & TableauDeComptage(i))
        Next

        'Pause factice
        Console.Read()

    End Sub

End Module
