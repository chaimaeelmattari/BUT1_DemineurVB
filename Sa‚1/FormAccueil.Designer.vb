<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAccueil
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
        Dim buttonQuitter As System.Windows.Forms.Button
        Me.labelJoueur = New System.Windows.Forms.Label()
        Me.comboboxJoueur = New System.Windows.Forms.ComboBox()
        Me.buttonScores = New System.Windows.Forms.Button()
        Me.buttonPartie = New System.Windows.Forms.Button()
        buttonQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'buttonQuitter
        '
        buttonQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        buttonQuitter.Location = New System.Drawing.Point(12, 193)
        buttonQuitter.Name = "buttonQuitter"
        buttonQuitter.Size = New System.Drawing.Size(124, 55)
        buttonQuitter.TabIndex = 3
        buttonQuitter.Text = "Quitter le jeu"
        buttonQuitter.UseVisualStyleBackColor = True
        AddHandler buttonQuitter.Click, AddressOf Me.buttonQuitter_Click
        '
        'labelJoueur
        '
        Me.labelJoueur.AutoSize = True
        Me.labelJoueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelJoueur.Location = New System.Drawing.Point(81, 74)
        Me.labelJoueur.Name = "labelJoueur"
        Me.labelJoueur.Size = New System.Drawing.Size(203, 20)
        Me.labelJoueur.TabIndex = 0
        Me.labelJoueur.Text = "Saisissez un nom de joueur"
        '
        'comboboxJoueur
        '
        Me.comboboxJoueur.FormattingEnabled = True
        Me.comboboxJoueur.Location = New System.Drawing.Point(85, 116)
        Me.comboboxJoueur.Name = "comboboxJoueur"
        Me.comboboxJoueur.Size = New System.Drawing.Size(199, 21)
        Me.comboboxJoueur.TabIndex = 1
        '
        'buttonScores
        '
        Me.buttonScores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonScores.Location = New System.Drawing.Point(289, 21)
        Me.buttonScores.Name = "buttonScores"
        Me.buttonScores.Size = New System.Drawing.Size(86, 36)
        Me.buttonScores.TabIndex = 2
        Me.buttonScores.Text = "Scores"
        Me.buttonScores.UseVisualStyleBackColor = True
        '
        'buttonPartie
        '
        Me.buttonPartie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonPartie.Location = New System.Drawing.Point(245, 193)
        Me.buttonPartie.Name = "buttonPartie"
        Me.buttonPartie.Size = New System.Drawing.Size(130, 55)
        Me.buttonPartie.TabIndex = 4
        Me.buttonPartie.Text = "Nouvelle Partie"
        Me.buttonPartie.UseVisualStyleBackColor = True
        '
        'FormAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 260)
        Me.Controls.Add(Me.buttonPartie)
        Me.Controls.Add(buttonQuitter)
        Me.Controls.Add(Me.buttonScores)
        Me.Controls.Add(Me.comboboxJoueur)
        Me.Controls.Add(Me.labelJoueur)
        Me.Name = "FormAccueil"
        Me.Text = "Démineur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labelJoueur As Label
    Friend WithEvents comboboxJoueur As ComboBox
    Friend WithEvents buttonScores As Button
    Friend WithEvents buttonPartie As Button
End Class
