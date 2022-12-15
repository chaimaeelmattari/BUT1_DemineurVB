<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPartie
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
        Me.buttonPartieScores = New System.Windows.Forms.Button()
        Me.buttonAccueilPartie = New System.Windows.Forms.Button()
        Me.TimerPartie = New System.Windows.Forms.Timer(Me.components)
        Me.labelTemps = New System.Windows.Forms.Label()
        Me.Panelmines = New System.Windows.Forms.Panel()
        Me.Buttonabandonner = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonPartieScores
        '
        Me.buttonPartieScores.Location = New System.Drawing.Point(781, 12)
        Me.buttonPartieScores.Name = "buttonPartieScores"
        Me.buttonPartieScores.Size = New System.Drawing.Size(128, 56)
        Me.buttonPartieScores.TabIndex = 65
        Me.buttonPartieScores.Text = "Scores"
        Me.buttonPartieScores.UseVisualStyleBackColor = True
        '
        'buttonAccueilPartie
        '
        Me.buttonAccueilPartie.Location = New System.Drawing.Point(12, 12)
        Me.buttonAccueilPartie.Name = "buttonAccueilPartie"
        Me.buttonAccueilPartie.Size = New System.Drawing.Size(128, 56)
        Me.buttonAccueilPartie.TabIndex = 66
        Me.buttonAccueilPartie.Text = "Accueil"
        Me.buttonAccueilPartie.UseVisualStyleBackColor = True
        '
        'TimerPartie
        '
        Me.TimerPartie.Interval = 1000
        '
        'labelTemps
        '
        Me.labelTemps.AutoSize = True
        Me.labelTemps.Location = New System.Drawing.Point(410, 12)
        Me.labelTemps.Name = "labelTemps"
        Me.labelTemps.Size = New System.Drawing.Size(39, 13)
        Me.labelTemps.TabIndex = 67
        Me.labelTemps.Text = "Label1"
        '
        'Panelmines
        '
        Me.Panelmines.Location = New System.Drawing.Point(192, 72)
        Me.Panelmines.Name = "Panelmines"
        Me.Panelmines.Size = New System.Drawing.Size(512, 420)
        Me.Panelmines.TabIndex = 68
        '
        'Buttonabandonner
        '
        Me.Buttonabandonner.Location = New System.Drawing.Point(12, 92)
        Me.Buttonabandonner.Name = "Buttonabandonner"
        Me.Buttonabandonner.Size = New System.Drawing.Size(128, 56)
        Me.Buttonabandonner.TabIndex = 0
        Me.Buttonabandonner.Text = "Abandonner la Partie"
        Me.Buttonabandonner.UseVisualStyleBackColor = True
        '
        'formPartie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 648)
        Me.Controls.Add(Me.Buttonabandonner)
        Me.Controls.Add(Me.Panelmines)
        Me.Controls.Add(Me.labelTemps)
        Me.Controls.Add(Me.buttonAccueilPartie)
        Me.Controls.Add(Me.buttonPartieScores)
        Me.Name = "formPartie"
        Me.Text = "²"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonPartieScores As Button
    Friend WithEvents buttonAccueilPartie As Button
    Friend WithEvents TimerPartie As Timer
    Friend WithEvents labelTemps As Label
    Friend WithEvents Panelmines As Panel
    Friend WithEvents Buttonabandonner As Button
End Class
