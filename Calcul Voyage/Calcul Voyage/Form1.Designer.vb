<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculVoyage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CalculVoyage))
        Me.LBL_TITRE = New System.Windows.Forms.Label()
        Me.LBL_CONSO = New System.Windows.Forms.Label()
        Me.LBL_DIST = New System.Windows.Forms.Label()
        Me.LBL_PRIXCARBU = New System.Windows.Forms.Label()
        Me.TXTBX_PRIXCARBU = New System.Windows.Forms.TextBox()
        Me.TXTBX_CONSO = New System.Windows.Forms.TextBox()
        Me.TXTBX_DIST = New System.Windows.Forms.TextBox()
        Me.LBL_ERROR = New System.Windows.Forms.Label()
        Me.LBL_TOTAL = New System.Windows.Forms.Label()
        Me.BT_VALID = New System.Windows.Forms.Button()
        Me.BT_ERASE = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LBL_TITRE
        '
        Me.LBL_TITRE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_TITRE.Font = New System.Drawing.Font("Curlz MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TITRE.ForeColor = System.Drawing.Color.Red
        Me.LBL_TITRE.Location = New System.Drawing.Point(24, 9)
        Me.LBL_TITRE.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_TITRE.Name = "LBL_TITRE"
        Me.LBL_TITRE.Size = New System.Drawing.Size(350, 39)
        Me.LBL_TITRE.TabIndex = 0
        Me.LBL_TITRE.Text = "Budget en essence d'un trajet"
        Me.LBL_TITRE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LBL_CONSO
        '
        Me.LBL_CONSO.BackColor = System.Drawing.Color.Transparent
        Me.LBL_CONSO.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CONSO.ForeColor = System.Drawing.Color.Yellow
        Me.LBL_CONSO.Location = New System.Drawing.Point(25, 90)
        Me.LBL_CONSO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_CONSO.Name = "LBL_CONSO"
        Me.LBL_CONSO.Size = New System.Drawing.Size(185, 25)
        Me.LBL_CONSO.TabIndex = 1
        Me.LBL_CONSO.Text = "Consommation de la voiture (l/100km)"
        '
        'LBL_DIST
        '
        Me.LBL_DIST.BackColor = System.Drawing.Color.Transparent
        Me.LBL_DIST.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_DIST.ForeColor = System.Drawing.Color.Yellow
        Me.LBL_DIST.Location = New System.Drawing.Point(25, 130)
        Me.LBL_DIST.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_DIST.Name = "LBL_DIST"
        Me.LBL_DIST.Size = New System.Drawing.Size(185, 25)
        Me.LBL_DIST.TabIndex = 2
        Me.LBL_DIST.Text = "Nombre de kilomètres (km)"
        '
        'LBL_PRIXCARBU
        '
        Me.LBL_PRIXCARBU.BackColor = System.Drawing.Color.Transparent
        Me.LBL_PRIXCARBU.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_PRIXCARBU.ForeColor = System.Drawing.Color.Yellow
        Me.LBL_PRIXCARBU.Location = New System.Drawing.Point(25, 170)
        Me.LBL_PRIXCARBU.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBL_PRIXCARBU.Name = "LBL_PRIXCARBU"
        Me.LBL_PRIXCARBU.Size = New System.Drawing.Size(185, 25)
        Me.LBL_PRIXCARBU.TabIndex = 3
        Me.LBL_PRIXCARBU.Text = "Prix du litre de carburant (€/l)"
        '
        'TXTBX_PRIXCARBU
        '
        Me.TXTBX_PRIXCARBU.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBX_PRIXCARBU.Location = New System.Drawing.Point(300, 170)
        Me.TXTBX_PRIXCARBU.Name = "TXTBX_PRIXCARBU"
        Me.TXTBX_PRIXCARBU.Size = New System.Drawing.Size(60, 25)
        Me.TXTBX_PRIXCARBU.TabIndex = 6
        '
        'TXTBX_CONSO
        '
        Me.TXTBX_CONSO.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBX_CONSO.Location = New System.Drawing.Point(300, 90)
        Me.TXTBX_CONSO.Name = "TXTBX_CONSO"
        Me.TXTBX_CONSO.Size = New System.Drawing.Size(60, 25)
        Me.TXTBX_CONSO.TabIndex = 4
        '
        'TXTBX_DIST
        '
        Me.TXTBX_DIST.Font = New System.Drawing.Font("Copperplate Gothic Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBX_DIST.Location = New System.Drawing.Point(300, 130)
        Me.TXTBX_DIST.Name = "TXTBX_DIST"
        Me.TXTBX_DIST.Size = New System.Drawing.Size(60, 25)
        Me.TXTBX_DIST.TabIndex = 5
        '
        'LBL_ERROR
        '
        Me.LBL_ERROR.BackColor = System.Drawing.Color.Transparent
        Me.LBL_ERROR.Font = New System.Drawing.Font("Algerian", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_ERROR.ForeColor = System.Drawing.Color.Fuchsia
        Me.LBL_ERROR.Location = New System.Drawing.Point(0, 220)
        Me.LBL_ERROR.Name = "LBL_ERROR"
        Me.LBL_ERROR.Size = New System.Drawing.Size(400, 20)
        Me.LBL_ERROR.TabIndex = 7
        Me.LBL_ERROR.Text = "Mauvaises valeurs saisies"
        Me.LBL_ERROR.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.LBL_ERROR.Visible = False
        '
        'LBL_TOTAL
        '
        Me.LBL_TOTAL.BackColor = System.Drawing.Color.Transparent
        Me.LBL_TOTAL.Font = New System.Drawing.Font("Magneto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_TOTAL.ForeColor = System.Drawing.Color.Chartreuse
        Me.LBL_TOTAL.Location = New System.Drawing.Point(0, 310)
        Me.LBL_TOTAL.Name = "LBL_TOTAL"
        Me.LBL_TOTAL.Size = New System.Drawing.Size(400, 20)
        Me.LBL_TOTAL.TabIndex = 8
        Me.LBL_TOTAL.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BT_VALID
        '
        Me.BT_VALID.Font = New System.Drawing.Font("Curlz MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_VALID.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.BT_VALID.Location = New System.Drawing.Point(48, 255)
        Me.BT_VALID.Name = "BT_VALID"
        Me.BT_VALID.Size = New System.Drawing.Size(110, 33)
        Me.BT_VALID.TabIndex = 9
        Me.BT_VALID.Text = "Valider"
        Me.BT_VALID.UseVisualStyleBackColor = True
        '
        'BT_ERASE
        '
        Me.BT_ERASE.Font = New System.Drawing.Font("Curlz MT", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BT_ERASE.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.BT_ERASE.Location = New System.Drawing.Point(255, 255)
        Me.BT_ERASE.Name = "BT_ERASE"
        Me.BT_ERASE.Size = New System.Drawing.Size(110, 33)
        Me.BT_ERASE.TabIndex = 10
        Me.BT_ERASE.Text = "Effacer"
        Me.BT_ERASE.UseVisualStyleBackColor = True
        '
        'CalculVoyage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(398, 362)
        Me.Controls.Add(Me.BT_ERASE)
        Me.Controls.Add(Me.BT_VALID)
        Me.Controls.Add(Me.LBL_TOTAL)
        Me.Controls.Add(Me.LBL_ERROR)
        Me.Controls.Add(Me.TXTBX_DIST)
        Me.Controls.Add(Me.TXTBX_CONSO)
        Me.Controls.Add(Me.TXTBX_PRIXCARBU)
        Me.Controls.Add(Me.LBL_PRIXCARBU)
        Me.Controls.Add(Me.LBL_DIST)
        Me.Controls.Add(Me.LBL_CONSO)
        Me.Controls.Add(Me.LBL_TITRE)
        Me.Name = "CalculVoyage"
        Me.Text = "Calcul Voyage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL_TITRE As System.Windows.Forms.Label
    Friend WithEvents LBL_CONSO As System.Windows.Forms.Label
    Friend WithEvents LBL_DIST As System.Windows.Forms.Label
    Friend WithEvents LBL_PRIXCARBU As System.Windows.Forms.Label
    Friend WithEvents TXTBX_PRIXCARBU As System.Windows.Forms.TextBox
    Friend WithEvents TXTBX_CONSO As System.Windows.Forms.TextBox
    Friend WithEvents TXTBX_DIST As System.Windows.Forms.TextBox
    Friend WithEvents LBL_ERROR As System.Windows.Forms.Label
    Friend WithEvents LBL_TOTAL As System.Windows.Forms.Label
    Friend WithEvents BT_VALID As System.Windows.Forms.Button
    Friend WithEvents BT_ERASE As System.Windows.Forms.Button

End Class
