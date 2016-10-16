Public Class Form1

    Private Sub CB_CHOIX_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_CHOIX.SelectedIndexChanged
        Me.TXT_CHOIX.Text = Me.CB_CHOIX.SelectedValue
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim MonTableau(9) As Integer
        For i As Integer = 0 To 9
            MonTableau(i) = i + 1
        Next
        Me.CB_CHOIX.DataSource = MonTableau
    End Sub
End Class
