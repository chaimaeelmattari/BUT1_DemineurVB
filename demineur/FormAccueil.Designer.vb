<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAccueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        SauvegarderDonnees(".\test.txt")
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim buttonQuitter As System.Windows.Forms.Button
        Me.buttonScores = New System.Windows.Forms.Button()
        Me.buttonPartie = New System.Windows.Forms.Button()
        Me.buttondonneesjoueurs = New System.Windows.Forms.Button()
        Me.labelJoueur = New System.Windows.Forms.Label()
        Me.comboboxJoueur = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        buttonQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonQuitter
        '
        buttonQuitter.BackColor = System.Drawing.SystemColors.InactiveCaption
        buttonQuitter.Font = New System.Drawing.Font("Segoe Print", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        buttonQuitter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        buttonQuitter.Location = New System.Drawing.Point(557, 566)
        buttonQuitter.Name = "buttonQuitter"
        buttonQuitter.Size = New System.Drawing.Size(226, 63)
        buttonQuitter.TabIndex = 3
        buttonQuitter.Text = "Quitter le jeu"
        buttonQuitter.UseVisualStyleBackColor = False
        AddHandler buttonQuitter.Click, AddressOf Me.buttonQuitter_Click
        '
        'buttonScores
        '
        Me.buttonScores.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.buttonScores.Font = New System.Drawing.Font("Segoe Print", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonScores.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.buttonScores.Location = New System.Drawing.Point(22, 565)
        Me.buttonScores.Name = "buttonScores"
        Me.buttonScores.Size = New System.Drawing.Size(248, 62)
        Me.buttonScores.TabIndex = 2
        Me.buttonScores.Text = "Scores"
        Me.buttonScores.UseVisualStyleBackColor = False
        '
        'buttonPartie
        '
        Me.buttonPartie.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.buttonPartie.Font = New System.Drawing.Font("Segoe Print", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonPartie.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.buttonPartie.Location = New System.Drawing.Point(85, 325)
        Me.buttonPartie.Name = "buttonPartie"
        Me.buttonPartie.Size = New System.Drawing.Size(284, 63)
        Me.buttonPartie.TabIndex = 4
        Me.buttonPartie.Text = "Nouvelle Partie"
        Me.buttonPartie.UseVisualStyleBackColor = False
        '
        'buttondonneesjoueurs
        '
        Me.buttondonneesjoueurs.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.buttondonneesjoueurs.Font = New System.Drawing.Font("Segoe Print", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttondonneesjoueurs.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.buttondonneesjoueurs.Location = New System.Drawing.Point(455, 325)
        Me.buttondonneesjoueurs.Name = "buttondonneesjoueurs"
        Me.buttondonneesjoueurs.Size = New System.Drawing.Size(284, 63)
        Me.buttondonneesjoueurs.TabIndex = 5
        Me.buttondonneesjoueurs.Text = "Données Joueurs"
        Me.buttondonneesjoueurs.UseVisualStyleBackColor = False
        '
        'labelJoueur
        '
        Me.labelJoueur.AutoSize = True
        Me.labelJoueur.Font = New System.Drawing.Font("Segoe Print", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelJoueur.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.labelJoueur.Location = New System.Drawing.Point(250, 168)
        Me.labelJoueur.Name = "labelJoueur"
        Me.labelJoueur.Size = New System.Drawing.Size(311, 38)
        Me.labelJoueur.TabIndex = 0
        Me.labelJoueur.Text = "Saisissez un nom de joueur"
        '
        'comboboxJoueur
        '
        Me.comboboxJoueur.FormattingEnabled = True
        Me.comboboxJoueur.Location = New System.Drawing.Point(257, 240)
        Me.comboboxJoueur.Name = "comboboxJoueur"
        Me.comboboxJoueur.Size = New System.Drawing.Size(295, 21)
        Me.comboboxJoueur.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil Std", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(211, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 84)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Démineur"
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(844, 640)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboboxJoueur)
        Me.Controls.Add(Me.labelJoueur)
        Me.Controls.Add(Me.buttondonneesjoueurs)
        Me.Controls.Add(Me.buttonPartie)
        Me.Controls.Add(buttonQuitter)
        Me.Controls.Add(Me.buttonScores)
        Me.Name = "FormAccueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Démineur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonScores As Button
    Friend WithEvents buttonPartie As Button
    Friend WithEvents buttondonneesjoueurs As Button
    Friend WithEvents labelJoueur As Label
    Friend WithEvents comboboxJoueur As ComboBox
    Friend WithEvents Label1 As Label
End Class
