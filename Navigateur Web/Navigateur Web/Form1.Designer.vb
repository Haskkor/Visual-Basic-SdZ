<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fenêtre
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Fenêtre))
        Me.STAT = New System.Windows.Forms.StatusStrip()
        Me.LBL_STAT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStp = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.BT_SRCH = New System.Windows.Forms.Button()
        Me.TXT_SRCH = New System.Windows.Forms.TextBox()
        Me.BT_HOME = New System.Windows.Forms.Button()
        Me.BT_NEXT = New System.Windows.Forms.Button()
        Me.PGB = New System.Windows.Forms.ProgressBar()
        Me.TXT_URL = New System.Windows.Forms.TextBox()
        Me.BT_BCK = New System.Windows.Forms.Button()
        Me.BT_Refrsh = New System.Windows.Forms.Button()
        Me.BT_GO = New System.Windows.Forms.Button()
        Me.BT_STOP = New System.Windows.Forms.Button()
        Me.WB = New System.Windows.Forms.WebBrowser()
        Me.TOOLTIP_BT_PANEL = New System.Windows.Forms.ToolTip(Me.components)
        Me.STAT.SuspendLayout()
        Me.MenuStp.SuspendLayout()
        Me.Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'STAT
        '
        Me.STAT.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LBL_STAT})
        Me.STAT.Location = New System.Drawing.Point(0, 489)
        Me.STAT.Name = "STAT"
        Me.STAT.Size = New System.Drawing.Size(984, 22)
        Me.STAT.TabIndex = 0
        Me.STAT.Text = "g"
        '
        'LBL_STAT
        '
        Me.LBL_STAT.Name = "LBL_STAT"
        Me.LBL_STAT.Size = New System.Drawing.Size(0, 17)
        '
        'MenuStp
        '
        Me.MenuStp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem})
        Me.MenuStp.Location = New System.Drawing.Point(0, 0)
        Me.MenuStp.Name = "MenuStp"
        Me.MenuStp.Size = New System.Drawing.Size(984, 24)
        Me.MenuStp.TabIndex = 4
        Me.MenuStp.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'Panel
        '
        Me.Panel.Controls.Add(Me.BT_SRCH)
        Me.Panel.Controls.Add(Me.TXT_SRCH)
        Me.Panel.Controls.Add(Me.BT_HOME)
        Me.Panel.Controls.Add(Me.BT_NEXT)
        Me.Panel.Controls.Add(Me.PGB)
        Me.Panel.Controls.Add(Me.TXT_URL)
        Me.Panel.Controls.Add(Me.BT_BCK)
        Me.Panel.Controls.Add(Me.BT_Refrsh)
        Me.Panel.Controls.Add(Me.BT_GO)
        Me.Panel.Controls.Add(Me.BT_STOP)
        Me.Panel.Location = New System.Drawing.Point(1, 23)
        Me.Panel.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(1000, 32)
        Me.Panel.TabIndex = 5
        '
        'BT_SRCH
        '
        Me.BT_SRCH.FlatAppearance.BorderSize = 0
        Me.BT_SRCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_SRCH.Image = CType(resources.GetObject("BT_SRCH.Image"), System.Drawing.Image)
        Me.BT_SRCH.Location = New System.Drawing.Point(934, 4)
        Me.BT_SRCH.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BT_SRCH.Name = "BT_SRCH"
        Me.BT_SRCH.Size = New System.Drawing.Size(24, 24)
        Me.BT_SRCH.TabIndex = 9
        Me.TOOLTIP_BT_PANEL.SetToolTip(Me.BT_SRCH, "Rechercher.")
        Me.BT_SRCH.UseVisualStyleBackColor = True
        '
        'TXT_SRCH
        '
        Me.TXT_SRCH.Location = New System.Drawing.Point(808, 6)
        Me.TXT_SRCH.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TXT_SRCH.Name = "TXT_SRCH"
        Me.TXT_SRCH.Size = New System.Drawing.Size(120, 20)
        Me.TXT_SRCH.TabIndex = 7
        '
        'BT_HOME
        '
        Me.BT_HOME.FlatAppearance.BorderSize = 0
        Me.BT_HOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_HOME.Image = CType(resources.GetObject("BT_HOME.Image"), System.Drawing.Image)
        Me.BT_HOME.Location = New System.Drawing.Point(85, 4)
        Me.BT_HOME.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BT_HOME.Name = "BT_HOME"
        Me.BT_HOME.Size = New System.Drawing.Size(24, 24)
        Me.BT_HOME.TabIndex = 10
        Me.TOOLTIP_BT_PANEL.SetToolTip(Me.BT_HOME, "Retourner à la page d'accueuil.")
        Me.BT_HOME.UseVisualStyleBackColor = True
        '
        'BT_NEXT
        '
        Me.BT_NEXT.FlatAppearance.BorderSize = 0
        Me.BT_NEXT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_NEXT.Image = CType(resources.GetObject("BT_NEXT.Image"), System.Drawing.Image)
        Me.BT_NEXT.Location = New System.Drawing.Point(25, 4)
        Me.BT_NEXT.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BT_NEXT.Name = "BT_NEXT"
        Me.BT_NEXT.Size = New System.Drawing.Size(24, 24)
        Me.BT_NEXT.TabIndex = 1
        Me.TOOLTIP_BT_PANEL.SetToolTip(Me.BT_NEXT, "Aller à la page suivante.")
        Me.BT_NEXT.UseVisualStyleBackColor = True
        '
        'PGB
        '
        Me.PGB.Location = New System.Drawing.Point(591, 6)
        Me.PGB.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PGB.Name = "PGB"
        Me.PGB.Size = New System.Drawing.Size(100, 20)
        Me.PGB.TabIndex = 6
        '
        'TXT_URL
        '
        Me.TXT_URL.Location = New System.Drawing.Point(115, 6)
        Me.TXT_URL.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TXT_URL.Name = "TXT_URL"
        Me.TXT_URL.Size = New System.Drawing.Size(576, 20)
        Me.TXT_URL.TabIndex = 4
        '
        'BT_BCK
        '
        Me.BT_BCK.FlatAppearance.BorderSize = 0
        Me.BT_BCK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_BCK.Image = CType(resources.GetObject("BT_BCK.Image"), System.Drawing.Image)
        Me.BT_BCK.Location = New System.Drawing.Point(0, 4)
        Me.BT_BCK.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BT_BCK.Name = "BT_BCK"
        Me.BT_BCK.Size = New System.Drawing.Size(24, 24)
        Me.BT_BCK.TabIndex = 0
        Me.TOOLTIP_BT_PANEL.SetToolTip(Me.BT_BCK, "Retourner à la page précédente.")
        Me.BT_BCK.UseVisualStyleBackColor = True
        '
        'BT_Refrsh
        '
        Me.BT_Refrsh.FlatAppearance.BorderSize = 0
        Me.BT_Refrsh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_Refrsh.Image = CType(resources.GetObject("BT_Refrsh.Image"), System.Drawing.Image)
        Me.BT_Refrsh.Location = New System.Drawing.Point(55, 4)
        Me.BT_Refrsh.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BT_Refrsh.Name = "BT_Refrsh"
        Me.BT_Refrsh.Size = New System.Drawing.Size(24, 24)
        Me.BT_Refrsh.TabIndex = 2
        Me.TOOLTIP_BT_PANEL.SetToolTip(Me.BT_Refrsh, "Recharger la page.")
        Me.BT_Refrsh.UseVisualStyleBackColor = True
        '
        'BT_GO
        '
        Me.BT_GO.FlatAppearance.BorderSize = 0
        Me.BT_GO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_GO.Image = CType(resources.GetObject("BT_GO.Image"), System.Drawing.Image)
        Me.BT_GO.Location = New System.Drawing.Point(698, 4)
        Me.BT_GO.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BT_GO.Name = "BT_GO"
        Me.BT_GO.Size = New System.Drawing.Size(24, 24)
        Me.BT_GO.TabIndex = 5
        Me.TOOLTIP_BT_PANEL.SetToolTip(Me.BT_GO, "Aller à l'adresse choisie.")
        Me.BT_GO.UseVisualStyleBackColor = True
        '
        'BT_STOP
        '
        Me.BT_STOP.FlatAppearance.BorderSize = 0
        Me.BT_STOP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_STOP.Image = CType(resources.GetObject("BT_STOP.Image"), System.Drawing.Image)
        Me.BT_STOP.Location = New System.Drawing.Point(728, 4)
        Me.BT_STOP.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BT_STOP.Name = "BT_STOP"
        Me.BT_STOP.Size = New System.Drawing.Size(24, 24)
        Me.BT_STOP.TabIndex = 3
        Me.TOOLTIP_BT_PANEL.SetToolTip(Me.BT_STOP, "Arrêter le chargement de la page.")
        Me.BT_STOP.UseVisualStyleBackColor = True
        '
        'WB
        '
        Me.WB.Location = New System.Drawing.Point(0, 139)
        Me.WB.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.WB.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WB.Name = "WB"
        Me.WB.Size = New System.Drawing.Size(250, 250)
        Me.WB.TabIndex = 6
        '
        'Fenêtre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 511)
        Me.Controls.Add(Me.WB)
        Me.Controls.Add(Me.Panel)
        Me.Controls.Add(Me.STAT)
        Me.Controls.Add(Me.MenuStp)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "Fenêtre"
        Me.Text = "Haskkor's Browser"
        Me.STAT.ResumeLayout(False)
        Me.STAT.PerformLayout()
        Me.MenuStp.ResumeLayout(False)
        Me.MenuStp.PerformLayout()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents STAT As System.Windows.Forms.StatusStrip
    Friend WithEvents LBL_STAT As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStp As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel As System.Windows.Forms.Panel
    Friend WithEvents BT_GO As System.Windows.Forms.Button
    Friend WithEvents TXT_URL As System.Windows.Forms.TextBox
    Friend WithEvents BT_STOP As System.Windows.Forms.Button
    Friend WithEvents BT_Refrsh As System.Windows.Forms.Button
    Friend WithEvents BT_NEXT As System.Windows.Forms.Button
    Friend WithEvents BT_BCK As System.Windows.Forms.Button
    Friend WithEvents WB As System.Windows.Forms.WebBrowser
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PGB As System.Windows.Forms.ProgressBar
    Friend WithEvents BT_SRCH As System.Windows.Forms.Button
    Friend WithEvents TXT_SRCH As System.Windows.Forms.TextBox
    Friend WithEvents BT_HOME As System.Windows.Forms.Button
    Friend WithEvents TOOLTIP_BT_PANEL As System.Windows.Forms.ToolTip

End Class
