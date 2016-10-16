Public Class CalculVoyage

    Private Sub BT_VALID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_VALID.Click
        If Vérifié() Then
            LBL_TOTAL.Visible = True
            Me.LBL_TOTAL.Text = "Le coût du trajet sera de " & Total(Me.TXTBX_CONSO.Text, Me.TXTBX_DIST.Text, Me.TXTBX_PRIXCARBU.Text) & "€."
        Else
            LBL_ERROR.Visible = True
        End If
    End Sub


    Private Sub BT_ERASE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_ERASE.Click
        LBL_TOTAL.Visible = False
        LBL_ERROR.Visible = False
        TXTBX_CONSO.Text = Nothing
        TXTBX_DIST.Text = Nothing
        TXTBX_PRIXCARBU.Text = Nothing
    End Sub

    ''' <summary>
    ''' Vérifie que les valeurs fournies permettent de faire le calcul
    ''' </summary>
    ''' <returns></returns> Booléen indiquant si le calcul peut se faire ou non
    ''' <remarks></remarks>
    Function Vérifié() As Boolean
        Dim Ok As Boolean = True
        If TXTBX_CONSO.Text Is Nothing Or Not IsNumeric(Me.TXTBX_CONSO.Text) Then
            Ok = False
        End If
        If TXTBX_DIST.Text Is Nothing Or Not IsNumeric(Me.TXTBX_CONSO.Text) Then
            Ok = False
        End If
        If TXTBX_PRIXCARBU Is Nothing Or Not IsNumeric(Me.TXTBX_CONSO.Text) Then
            Ok = False
        End If
        Return Ok
    End Function

    ''' <summary>
    ''' Calcule le prix final
    ''' </summary>
    ''' <param name="Conso"></param> Consommation de la voiture utilisée
    ''' <param name="Dist"></param> Distance à parcourir
    ''' <param name="PrixCarbu"></param> Prix du carburant utilisé
    ''' <returns></returns> Total de la dépense
    ''' <remarks></remarks>
    Function Total(ByVal Conso As Double, ByVal Dist As Double, ByVal PrixCarbu As Double) As Double
        Dim Ttl As Double
        Ttl = (Conso / 100) * Dist * PrixCarbu
        Return Ttl
    End Function

End Class

