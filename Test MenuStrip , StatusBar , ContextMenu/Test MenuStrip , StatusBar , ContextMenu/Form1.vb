Public Class Form1

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        Me.LBL_TEXTE.Text = ""
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        If MsgBox("Voulez-vous vraiment quitter le programme?", 36, "Quitter") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        Me.LBL_TEXTE.Text = Me.ToolStripComboBox1.SelectedItem
    End Sub

    Private Sub CrireLeMessaegeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrireLeMessaegeToolStripMenuItem.Click
        Me.ToolStripStatusLabel1.Text = "Chargement..."
        Me.ToolStripProgressBar1.Value = 0
        Me.Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.ToolStripProgressBar1.Value += 1
        If Me.ToolStripProgressBar1.Value = 100 Then
            Me.Timer1.Enabled = False
            Me.ToolStripStatusLabel1.Text = "Prêt"
            Me.LBL_TEXTE.Text = Me.ToolStripTextBox1.Text
            Me.ToolStripProgressBar1.Value = 0
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ToolStripStatusLabel1.Text = ""
    End Sub

    Private Sub DéplacerLeLabelIciToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DéplacerLeLabelIciToolStripMenuItem.Click
        Me.LBL_TEXTE.Location = Control.MousePosition - Me.Location
    End Sub
End Class
