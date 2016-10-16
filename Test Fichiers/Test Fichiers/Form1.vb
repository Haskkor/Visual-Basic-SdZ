Imports System.IO

Public Class Form1

    Const PATHFICHIER As String = "Zero.txt"

    Private Sub BT_VIDER_LECTURE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_VIDER_LECTURE.Click
        Me.TB_LECTURE.Text = ""
    End Sub

    Private Sub BT_VIDER_ECRITURE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_VIDER_ECRITURE.Click
        Me.TB_ECRITURE.Text = ""
    End Sub

    Private Sub BT_VIDERLEFICHIER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_VIDERLEFICHIER.Click
        File.WriteAllText(PATHFICHIER, "")
    End Sub

    Private Sub BT_ECRIRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_ECRIRE.Click
        If Me.CB_ECRITURE.Checked Then
            File.WriteAllText(PATHFICHIER, Me.TB_ECRITURE.Text)
        Else
            File.AppendAllText(PATHFICHIER, Me.TB_ECRITURE.Text)
        End If
    End Sub

    Private Sub BT_LIRE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_LIRE.Click
        Me.TB_LECTURE.Text = File.ReadAllText(PATHFICHIER)
    End Sub

End Class
