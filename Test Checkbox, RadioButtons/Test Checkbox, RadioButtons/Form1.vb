Public Class Form1

    ''' <summary>
    ''' Définit quelles cases ont été coché et affiche le total dans la textbox correspondante
    '''
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BT_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_1.Click
        Dim Total As Integer = 0
        If Me.CHK_1.Checked Then
            Total += 1
        End If
        If Me.CHK_2.Checked Then
            Total += 2
        End If
        If Me.CHK_3.Checked Then
            Total += 4
        End If
        If Me.CHK_4.Checked Then
            Total += 8
        End If
        TXT_CHK.Text = Total
    End Sub

    ''' <summary>
    ''' Définit le chiffre sélectionné et l'affiche dans la textbox correspondante 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BT_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_2.Click
        If Me.RB_1.Checked Then
            Me.TXT_RBNB.Text = Me.RB_1.Text
        End If
        If Me.RB_2.Checked Then
            Me.TXT_RBNB.Text = Me.RB_2.Text
        End If
        If Me.RB_3.Checked Then
            Me.TXT_RBNB.Text = Me.RB_3.Text
        End If
        If Me.RB_4.Checked Then
            Me.TXT_RBNB.Text = Me.RB_4.Text
        End If
    End Sub

    ''' <summary>
    ''' Définit la couleur sélectionnée et l'affiche dans la textbox correspondante.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BT_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_3.Click
        If Me.RB_BLEU.Checked Then
            Me.TXT_RBCOL.Text = Me.RB_BLEU.Text
            Me.BackColor = Color.Blue
        End If
        If Me.RB_JAUNE.Checked Then
            Me.TXT_RBCOL.Text = Me.RB_JAUNE.Text
            Me.BackColor = Color.Yellow
        End If
        If Me.RB_ROUGE.Checked Then
            Me.TXT_RBCOL.Text = Me.RB_ROUGE.Text
            Me.BackColor = Color.Red
        End If
        If Me.RB_VERT.Checked Then
            Me.TXT_RBCOL.Text = Me.RB_VERT.Text
            Me.BackColor = Color.Green
        End If
    End Sub
End Class
