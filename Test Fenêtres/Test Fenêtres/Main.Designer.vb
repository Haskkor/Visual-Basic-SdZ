<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.BT_OUVRIR = New System.Windows.Forms.Button()
        Me.LBL_MAIN = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BT_OUVRIR
        '
        Me.BT_OUVRIR.Location = New System.Drawing.Point(58, 45)
        Me.BT_OUVRIR.Name = "BT_OUVRIR"
        Me.BT_OUVRIR.Size = New System.Drawing.Size(75, 23)
        Me.BT_OUVRIR.TabIndex = 0
        Me.BT_OUVRIR.Text = "Ouvrir"
        Me.BT_OUVRIR.UseVisualStyleBackColor = True
        '
        'LBL_MAIN
        '
        Me.LBL_MAIN.AutoSize = True
        Me.LBL_MAIN.Location = New System.Drawing.Point(78, 13)
        Me.LBL_MAIN.Name = "LBL_MAIN"
        Me.LBL_MAIN.Size = New System.Drawing.Size(0, 13)
        Me.LBL_MAIN.TabIndex = 1
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(182, 124)
        Me.Controls.Add(Me.LBL_MAIN)
        Me.Controls.Add(Me.BT_OUVRIR)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BT_OUVRIR As System.Windows.Forms.Button
    Friend WithEvents LBL_MAIN As System.Windows.Forms.Label

End Class
