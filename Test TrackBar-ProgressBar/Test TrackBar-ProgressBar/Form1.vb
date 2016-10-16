Public Class Form1

    Private Sub TB_1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_1.Scroll
        Me.PB_1.Value = Me.TB_1.Value
    End Sub
End Class
