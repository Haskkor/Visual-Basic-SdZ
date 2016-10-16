Public Class Banderole

    'Désactive le bouton stop au lancement du programme.
    Private Sub Banderole_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BT_STOP.Enabled = False
    End Sub

    'Lance le défilement, active le bouton stop, désactive le bouton play, active la groupbox.
    Private Sub BT_PLAY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_PLAY.Click
        Me.BT_STOP.Enabled = True
        Me.BT_PLAY.Enabled = False
        Me.TIM_1.Enabled = True
        Me.GB_1.Enabled = True
    End Sub

    'Arrête le défilement, active le bouton play, désactive le bouton stop, désactive la groupbox, décheck les radiobuttons, remet la trackbar à 0.
    Private Sub BT_STOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_STOP.Click
        Me.BT_STOP.Enabled = False
        Me.BT_PLAY.Enabled = True
        Me.TIM_1.Enabled = False
        Me.GB_1.Enabled = False
        Dim TableauDeBoutons(9) As RadioButton
        TableauDeBoutons(0) = RB_1
        TableauDeBoutons(1) = RB_2
        TableauDeBoutons(2) = RB_3
        TableauDeBoutons(3) = RB_4
        TableauDeBoutons(4) = RB_5
        TableauDeBoutons(5) = RB_6
        TableauDeBoutons(6) = RB_7
        TableauDeBoutons(7) = RB_8
        TableauDeBoutons(8) = RB_9
        TableauDeBoutons(9) = RB_10
        For i As Integer = 0 To 9
            TableauDeBoutons(i).Checked = False
        Next
        TB_VIT.Value = 0
    End Sub

    'Change la vitesse du défilement en fonction de la position de la trackbar.
    Private Sub TB_VIT_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_VIT.Scroll
        Me.TIM_1.Interval = 1100 - Me.TB_VIT.Value * 100
    End Sub

    'Variable de parcours pour le tableau de boutons.
    Dim i As Integer = 0
    'Allume les radiobuttons au rythme du timer.
    Private Sub TIM_1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TIM_1.Tick
        Dim TableauDeBoutons(9) As RadioButton
        TableauDeBoutons(0) = RB_1
        TableauDeBoutons(1) = RB_2
        TableauDeBoutons(2) = RB_3
        TableauDeBoutons(3) = RB_4
        TableauDeBoutons(4) = RB_5
        TableauDeBoutons(5) = RB_6
        TableauDeBoutons(6) = RB_7
        TableauDeBoutons(7) = RB_8
        TableauDeBoutons(8) = RB_9
        TableauDeBoutons(9) = RB_10
        If i = 10 Then
            i = 0
        End If
        TableauDeBoutons(i).Checked = True
        i += 1
    End Sub

End Class
