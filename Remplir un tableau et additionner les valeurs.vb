Module Module1

    Sub Main()

        'Déclaration des variables
        Dim Tableau(9), Résultat As Integer

        'Remplissage du tableau
        For i As Integer = 0 To Tableau.Length - 1
            Tableau(i) = RemplirTableau(i)
        Next

        'Calcul du total
        Résultat = 0
        For i As Integer = 0 To Tableau.Length - 1
            Résultat += Tableau(i)
        Next

        'Affichage du résultat
        Console.WriteLine("Le total est de : " & Résultat)
        Console.Read()

    End Sub

    ''' <summary>
    ''' Remplit un tableau en vérifiant si la valeur rentrée est un chiffre
    ''' </summary>
    ''' <param name="Numéro"> Rang de la valeur dans le tableau</param>
    ''' <returns> Valeur à rentrer dans le tableau</returns>
    ''' <remarks></remarks>
    Function RemplirTableau(ByVal Numéro As Integer) As Integer
        Dim Valeur As String
        Do
            Console.Write("Entrez la valeur " & Numéro + 1 & " : ")
            Valeur = Console.ReadLine()
        Loop Until IsNumeric(Valeur)
        Return CInt(Valeur)
    End Function

End Module
