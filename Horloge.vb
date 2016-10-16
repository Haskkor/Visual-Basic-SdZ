Module Module1

    Sub Main()

        'Déclaration d'une variable stockant l'heure actuelle
        Dim Horloge As Date

        Do
            'Récupération de la date actuelle
            Horloge = Date.Now
            'Affiche une horloge
            Console.WriteLine("----------------")
            Console.WriteLine("--- " & Horloge.ToLongTimeString & " ---")
            Console.WriteLine("----------------")
            'Met le programme en pause pendant une seconde
            System.Threading.Thread.Sleep(1000)
            'Efface le contenu de la console
            Console.Clear()
        Loop While 1

    End Sub

End Module
