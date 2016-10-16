Imports System.IO

Public Class Form1

    Dim RepertoireALister As String

    Private Sub TB_TextChanged(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles TB.KeyPress
        Try
            If e.KeyChar = ControlChars.Cr Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 13 Then
                RepertoireALister = Me.TB.Text
                Me.TV.TopNode = Me.TV.Nodes.Add(RepertoireALister, RepertoireALister)
                For Each Repertoire As String In Directory.GetDirectories(RepertoireALister)
                    Me.TV.TopNode.Nodes.Add(Repertoire, Path.GetFileName(Repertoire) & Path.GetExtension(Repertoire))
                    ListeArborescenceDossier(Repertoire, Me.TV.TopNode)
                Next
                For Each Fichier As String In Directory.GetFiles(RepertoireALister)
                    Me.TV.TopNode.Nodes.Add(Path.GetFileName(Fichier))
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub

    Sub ListeArborescenceDossier(ByVal RepertoireActuel As String, ByVal NodeActuel As TreeNode)
        Try
            Dim Node As TreeNode = NodeActuel.Nodes(RepertoireActuel)
            For Each Repertoire As String In Directory.GetDirectories(RepertoireActuel)
                Node.Nodes.Add(Repertoire, Path.GetFileName(Repertoire))
                ListeArborescenceDossier(Repertoire, Node)
            Next
            For Each Fichier As String In Directory.GetFiles(RepertoireActuel)
                Node.Nodes.Add(Path.GetFileName(Fichier))
            Next
        Catch ex As Exception
        End Try
    End Sub

End Class
