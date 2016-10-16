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
        Me.CB_CHOIX = New System.Windows.Forms.ComboBox()
        Me.TXT_CHOIX = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CB_CHOIX
        '
        Me.CB_CHOIX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_CHOIX.FormattingEnabled = True
        Me.CB_CHOIX.Location = New System.Drawing.Point(15, 20)
        Me.CB_CHOIX.Name = "CB_CHOIX"
        Me.CB_CHOIX.Size = New System.Drawing.Size(200, 21)
        Me.CB_CHOIX.TabIndex = 0
        '
        'TXT_CHOIX
        '
        Me.TXT_CHOIX.Location = New System.Drawing.Point(15, 60)
        Me.TXT_CHOIX.Name = "TXT_CHOIX"
        Me.TXT_CHOIX.Size = New System.Drawing.Size(200, 20)
        Me.TXT_CHOIX.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 112)
        Me.Controls.Add(Me.TXT_CHOIX)
        Me.Controls.Add(Me.CB_CHOIX)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CB_CHOIX As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_CHOIX As System.Windows.Forms.TextBox

End Class
