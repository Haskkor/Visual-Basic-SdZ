<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GB_LECTURE = New System.Windows.Forms.GroupBox()
        Me.BT_VIDER_LECTURE = New System.Windows.Forms.Button()
        Me.BT_LIRE = New System.Windows.Forms.Button()
        Me.TB_LECTURE = New System.Windows.Forms.TextBox()
        Me.GB_ECRITURE = New System.Windows.Forms.GroupBox()
        Me.CB_ECRITURE = New System.Windows.Forms.CheckBox()
        Me.BT_VIDER_ECRITURE = New System.Windows.Forms.Button()
        Me.BT_ECRIRE = New System.Windows.Forms.Button()
        Me.TB_ECRITURE = New System.Windows.Forms.TextBox()
        Me.BT_VIDERLEFICHIER = New System.Windows.Forms.Button()
        Me.GB_LECTURE.SuspendLayout()
        Me.GB_ECRITURE.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB_LECTURE
        '
        Me.GB_LECTURE.Controls.Add(Me.BT_VIDER_LECTURE)
        Me.GB_LECTURE.Controls.Add(Me.BT_LIRE)
        Me.GB_LECTURE.Controls.Add(Me.TB_LECTURE)
        Me.GB_LECTURE.Location = New System.Drawing.Point(15, 15)
        Me.GB_LECTURE.Name = "GB_LECTURE"
        Me.GB_LECTURE.Size = New System.Drawing.Size(505, 230)
        Me.GB_LECTURE.TabIndex = 0
        Me.GB_LECTURE.TabStop = False
        Me.GB_LECTURE.Text = "Lecture"
        '
        'BT_VIDER_LECTURE
        '
        Me.BT_VIDER_LECTURE.Location = New System.Drawing.Point(256, 201)
        Me.BT_VIDER_LECTURE.Name = "BT_VIDER_LECTURE"
        Me.BT_VIDER_LECTURE.Size = New System.Drawing.Size(75, 23)
        Me.BT_VIDER_LECTURE.TabIndex = 2
        Me.BT_VIDER_LECTURE.Text = "Vider"
        Me.BT_VIDER_LECTURE.UseVisualStyleBackColor = True
        '
        'BT_LIRE
        '
        Me.BT_LIRE.Location = New System.Drawing.Point(175, 201)
        Me.BT_LIRE.Name = "BT_LIRE"
        Me.BT_LIRE.Size = New System.Drawing.Size(75, 23)
        Me.BT_LIRE.TabIndex = 1
        Me.BT_LIRE.Text = "Lire"
        Me.BT_LIRE.UseVisualStyleBackColor = True
        '
        'TB_LECTURE
        '
        Me.TB_LECTURE.Location = New System.Drawing.Point(13, 20)
        Me.TB_LECTURE.Multiline = True
        Me.TB_LECTURE.Name = "TB_LECTURE"
        Me.TB_LECTURE.ReadOnly = True
        Me.TB_LECTURE.Size = New System.Drawing.Size(480, 175)
        Me.TB_LECTURE.TabIndex = 0
        '
        'GB_ECRITURE
        '
        Me.GB_ECRITURE.Controls.Add(Me.CB_ECRITURE)
        Me.GB_ECRITURE.Controls.Add(Me.BT_VIDER_ECRITURE)
        Me.GB_ECRITURE.Controls.Add(Me.BT_ECRIRE)
        Me.GB_ECRITURE.Controls.Add(Me.TB_ECRITURE)
        Me.GB_ECRITURE.Location = New System.Drawing.Point(15, 250)
        Me.GB_ECRITURE.Name = "GB_ECRITURE"
        Me.GB_ECRITURE.Size = New System.Drawing.Size(505, 180)
        Me.GB_ECRITURE.TabIndex = 3
        Me.GB_ECRITURE.TabStop = False
        Me.GB_ECRITURE.Text = "Ecriture"
        '
        'CB_ECRITURE
        '
        Me.CB_ECRITURE.AutoSize = True
        Me.CB_ECRITURE.Location = New System.Drawing.Point(44, 150)
        Me.CB_ECRITURE.Name = "CB_ECRITURE"
        Me.CB_ECRITURE.Size = New System.Drawing.Size(111, 17)
        Me.CB_ECRITURE.TabIndex = 3
        Me.CB_ECRITURE.Text = "Réécrire au début"
        Me.CB_ECRITURE.UseVisualStyleBackColor = True
        '
        'BT_VIDER_ECRITURE
        '
        Me.BT_VIDER_ECRITURE.Location = New System.Drawing.Point(256, 150)
        Me.BT_VIDER_ECRITURE.Name = "BT_VIDER_ECRITURE"
        Me.BT_VIDER_ECRITURE.Size = New System.Drawing.Size(75, 23)
        Me.BT_VIDER_ECRITURE.TabIndex = 2
        Me.BT_VIDER_ECRITURE.Text = "Vider"
        Me.BT_VIDER_ECRITURE.UseVisualStyleBackColor = True
        '
        'BT_ECRIRE
        '
        Me.BT_ECRIRE.Location = New System.Drawing.Point(175, 150)
        Me.BT_ECRIRE.Name = "BT_ECRIRE"
        Me.BT_ECRIRE.Size = New System.Drawing.Size(75, 23)
        Me.BT_ECRIRE.TabIndex = 1
        Me.BT_ECRIRE.Text = "Ecrire"
        Me.BT_ECRIRE.UseVisualStyleBackColor = True
        '
        'TB_ECRITURE
        '
        Me.TB_ECRITURE.Location = New System.Drawing.Point(13, 19)
        Me.TB_ECRITURE.Multiline = True
        Me.TB_ECRITURE.Name = "TB_ECRITURE"
        Me.TB_ECRITURE.Size = New System.Drawing.Size(480, 125)
        Me.TB_ECRITURE.TabIndex = 0
        '
        'BT_VIDERLEFICHIER
        '
        Me.BT_VIDERLEFICHIER.Location = New System.Drawing.Point(213, 436)
        Me.BT_VIDERLEFICHIER.Name = "BT_VIDERLEFICHIER"
        Me.BT_VIDERLEFICHIER.Size = New System.Drawing.Size(100, 23)
        Me.BT_VIDERLEFICHIER.TabIndex = 4
        Me.BT_VIDERLEFICHIER.Text = "Vider le fichier"
        Me.BT_VIDERLEFICHIER.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 462)
        Me.Controls.Add(Me.BT_VIDERLEFICHIER)
        Me.Controls.Add(Me.GB_ECRITURE)
        Me.Controls.Add(Me.GB_LECTURE)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GB_LECTURE.ResumeLayout(False)
        Me.GB_LECTURE.PerformLayout()
        Me.GB_ECRITURE.ResumeLayout(False)
        Me.GB_ECRITURE.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GB_LECTURE As System.Windows.Forms.GroupBox
    Friend WithEvents BT_VIDER_LECTURE As System.Windows.Forms.Button
    Friend WithEvents BT_LIRE As System.Windows.Forms.Button
    Friend WithEvents TB_LECTURE As System.Windows.Forms.TextBox
    Friend WithEvents GB_ECRITURE As System.Windows.Forms.GroupBox
    Friend WithEvents CB_ECRITURE As System.Windows.Forms.CheckBox
    Friend WithEvents BT_VIDER_ECRITURE As System.Windows.Forms.Button
    Friend WithEvents BT_ECRIRE As System.Windows.Forms.Button
    Friend WithEvents TB_ECRITURE As System.Windows.Forms.TextBox
    Friend WithEvents BT_VIDERLEFICHIER As System.Windows.Forms.Button

End Class
