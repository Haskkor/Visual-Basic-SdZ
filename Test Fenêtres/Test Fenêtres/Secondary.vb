Public Class Secondary

    Public LabelText As String = ""

    Private Sub BT_FERMER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_FERMER.Click
        Main.LBL_MAIN.Text = "Ceci est une bite."
        Me.Close()
    End Sub

    Private Sub Secondary_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LBL_SECONDARY.Text = LabelText
    End Sub
End Class