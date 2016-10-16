Public Class Fenêtre

    'Redimensionne et positionne les différents controles.
    Private Sub Fenêtre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Panel.Width = Me.ClientSize.Width
        Me.WB.Width = Me.ClientSize.Width
        Me.WB.Height = Me.ClientSize.Height - Me.MenuStp.Height - Me.Panel.Height - Me.STAT.Height
        Me.WB.Top = Me.MenuStp.Height + Me.Panel.Height
        Me.TXT_URL.Width = ((Me.ClientSize.Width - 115) / 4) * 3
        Me.PGB.Left = 115 + Me.TXT_URL.Width - Me.PGB.Width
        Me.BT_GO.Left = 121 + Me.TXT_URL.Width
        Me.BT_STOP.Left = 151 + Me.TXT_URL.Width
        Me.TXT_SRCH.Left = 181 + Me.TXT_URL.Width
        Me.TXT_SRCH.Width = Me.ClientSize.Width - Me.TXT_URL.Width - 217
        Me.BT_SRCH.Left = 187 + Me.TXT_URL.Width + Me.TXT_SRCH.Width
    End Sub

    'Au lancement affiche Google, active les boutons voulus, désactive les autres.
    Private Sub Fenêtre_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WB.Navigate("Http://www.google.com")
        Me.BT_BCK.Enabled = False
        Me.BT_NEXT.Enabled = False
        Me.BT_STOP.Enabled = False
        Me.TXT_SRCH.Text = "Rechercher avec Google"
    End Sub

#Region "WB"

    Sub WB_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WB.DocumentCompleted
        Me.TXT_URL.Text = Me.WB.Url.ToString
        Me.BT_STOP.Enabled = False
        Me.PGB.Visible = False
    End Sub

    Private Sub WB_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WB.Navigating
        Me.BT_STOP.Enabled = True
        Me.PGB.Visible = True
    End Sub

    Sub WB_CanGoBackChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WB.CanGoBackChanged
        If Me.WB.CanGoBack Then
            Me.BT_BCK.Enabled = True
        Else
            Me.BT_BCK.Enabled = False
        End If
    End Sub

    Sub WB_CanGoForwardChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WB.CanGoForwardChanged
        If Me.WB.CanGoForward Then
            Me.BT_NEXT.Enabled = True
        Else
            Me.BT_NEXT.Enabled = False
        End If
    End Sub

    Sub WB_StatusChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WB.StatusTextChanged
        Me.LBL_STAT.Text = WB.StatusText
    End Sub

    Sub WB_ProgressChanged(ByVal sender As System.Object, ByVal e As WebBrowserProgressChangedEventArgs) Handles WB.ProgressChanged
        On Error Resume Next
        Me.PGB.Maximum = e.MaximumProgress
        If e.CurrentProgress >= 0 Then
            Me.PGB.Value = e.CurrentProgress
        Else
            Me.PGB.Value = 0
        End If
    End Sub

#End Region

#Region "Boutons"

    'Controles des différents boutons.

    Private Sub BT_GO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_GO.Click
        Me.WB.Navigate(Me.TXT_URL.Text)
    End Sub

    Private Sub BT_NEXT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_NEXT.Click
        Me.WB.GoForward()
    End Sub

    Private Sub BT_BCK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_BCK.Click
        Me.WB.GoBack()
    End Sub


    Private Sub BT_Refrsh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_Refrsh.Click
        Me.WB.Refresh()
    End Sub

    Private Sub BT_STOP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_STOP.Click
        Me.WB.Stop()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click
        If MsgBox("Voulez-vous vraiment quitter?", 36, "Quitter Navigateur") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BT_SRCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_SRCH.Click
        Me.WB.Navigate("http://www.google.fr/search?q=" & Me.TXT_SRCH.Text)
    End Sub

    Private Sub BT_HOME_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BT_HOME.Click
        Me.WB.Navigate("http://www.google.fr")
    End Sub

#End Region

#Region "TextBox"

    Private Sub TXT_URL_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles TXT_URL.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.WB.Navigate(Me.TXT_URL.Text)
        End If
        If e.KeyChar = ControlChars.Cr Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_SRCH_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles TXT_SRCH.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Me.WB.Navigate("http://www.google.fr/search?q=" & Me.TXT_SRCH.Text)
        End If
        If e.KeyChar = ControlChars.Cr Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXT_SRCH_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_SRCH.LostFocus
        If Me.TXT_SRCH.Text = Nothing Then
            Me.TXT_SRCH.Text = "Rechercher avec Google"
        End If
    End Sub

    Private Sub TXT_SRCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_SRCH.Click
        If Me.TXT_SRCH.Text = "Rechercher avec Google" Then
            Me.TXT_SRCH.Clear()
        Else
            Me.TXT_SRCH.SelectAll()
        End If
    End Sub

    Private Sub TXT_URL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_URL.Click
        Me.TXT_URL.SelectAll()
    End Sub

#End Region

End Class
