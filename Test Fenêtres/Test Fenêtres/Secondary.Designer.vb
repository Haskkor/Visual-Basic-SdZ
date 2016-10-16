<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Secondary
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
        Me.BT_FERMER = New System.Windows.Forms.Button()
        Me.LBL_SECONDARY = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BT_FERMER
        '
        Me.BT_FERMER.Location = New System.Drawing.Point(61, 39)
        Me.BT_FERMER.Name = "BT_FERMER"
        Me.BT_FERMER.Size = New System.Drawing.Size(78, 30)
        Me.BT_FERMER.TabIndex = 0
        Me.BT_FERMER.Text = "Fermer"
        Me.BT_FERMER.UseVisualStyleBackColor = True
        '
        'LBL_SECONDARY
        '
        Me.LBL_SECONDARY.AutoSize = True
        Me.LBL_SECONDARY.Location = New System.Drawing.Point(38, 9)
        Me.LBL_SECONDARY.Name = "LBL_SECONDARY"
        Me.LBL_SECONDARY.Size = New System.Drawing.Size(0, 13)
        Me.LBL_SECONDARY.TabIndex = 1
        '
        'Secondary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 112)
        Me.Controls.Add(Me.LBL_SECONDARY)
        Me.Controls.Add(Me.BT_FERMER)
        Me.Name = "Secondary"
        Me.Text = "Secondary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BT_FERMER As System.Windows.Forms.Button
    Friend WithEvents LBL_SECONDARY As System.Windows.Forms.Label
End Class
