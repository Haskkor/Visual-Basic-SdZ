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
        Me.PB_1 = New System.Windows.Forms.ProgressBar()
        Me.TB_1 = New System.Windows.Forms.TrackBar()
        CType(Me.TB_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PB_1
        '
        Me.PB_1.Location = New System.Drawing.Point(15, 65)
        Me.PB_1.Maximum = 10
        Me.PB_1.Name = "PB_1"
        Me.PB_1.Size = New System.Drawing.Size(350, 25)
        Me.PB_1.TabIndex = 0
        '
        'TB_1
        '
        Me.TB_1.Location = New System.Drawing.Point(15, 12)
        Me.TB_1.Name = "TB_1"
        Me.TB_1.Size = New System.Drawing.Size(350, 45)
        Me.TB_1.TabIndex = 1
        Me.TB_1.TickFrequency = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 112)
        Me.Controls.Add(Me.TB_1)
        Me.Controls.Add(Me.PB_1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TB_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PB_1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TB_1 As System.Windows.Forms.TrackBar

End Class
