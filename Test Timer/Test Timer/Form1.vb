Public Class Form1

    ' Lorsque l'on clique sur "Démarrer", le timer commence, le bouton démarrer est désactivé et le RAZ est activé
    Private Sub BT_DEMAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_DEMAR.Click
        Me.TIM_TIM.Enabled = True
        Me.BT_DEMAR.Enabled = False
        Me.BT_RAZ.Enabled = True
    End Sub

    'Si le bouton RAZ est enfoncé, on remet la progressbar à 0, on désactive le timer, 
    'on active le bouton démarrer et on désactive le bouton RAZ
    Private Sub BT_RAZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_RAZ.Click
        Me.PGB_TIM.Value = 0
        Me.TIM_TIM.Enabled = False
        Me.BT_DEMAR.Enabled = True
        Me.BT_RAZ.Enabled = False
    End Sub

    'Si la progressbar est arrivée au bout, on désactive le timer, on réactive le bouton démarrer sinon augmente de 1 la progressbar
    Private Sub TIM_TIM_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIM_TIM.Tick
        If Me.PGB_TIM.Value = Me.PGB_TIM.Maximum Then
            Me.TIM_TIM.Enabled = False
            Me.BT_DEMAR.Enabled = True
        Else
            Me.PGB_TIM.Value += 1
        End If
    End Sub

End Class

