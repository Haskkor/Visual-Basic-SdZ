Module Module1

    Sub Main()

        'Déclaration des variable
        Dim MonTableau(20), Stock, Tailletableau As Integer
        Dim Trouvé As Boolean

        'Génération d'un tableau remplit de chiffres aléatoires
        For i As Integer = 0 To MonTableau.Length - 1
            MonTableau(i) = Rnd(1) * 10
        Next

        'Tri du tableau
        Tailletableau = MonTableau.Length
        Do
            Trouvé = False
            For i As Integer = 0 To Tailletableau - 2
                If MonTableau(i) > MonTableau(i + 1) Then
                    Stock = MonTableau(i)
                    MonTableau(i) = MonTableau(i + 1)
                    MonTableau(i + 1) = Stock
                    Trouvé = True
                End If
            Next
            Tailletableau -= 1
        Loop Until Not Trouvé

        'Affichage du tableau trié
        For i As Integer = 0 To MonTableau.Length - 1
            Console.Write(MonTableau(i) & "  ")
        Next

        'Pause factice
        Console.Read()
    End Sub

End Module
