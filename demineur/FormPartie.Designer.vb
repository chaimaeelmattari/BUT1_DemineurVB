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
        Me.Labelcompteur = New System.Windows.Forms.Label()
        Me.labelnomjoueur = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonPartieScores
        '
        Me.buttonPartieScores.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.buttonPartieScores.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonPartieScores.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.buttonPartieScores.Location = New System.Drawing.Point(1083, 26)
        Me.buttonPartieScores.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonPartieScores.Name = "buttonPartieScores"
        Me.buttonPartieScores.Size = New System.Drawing.Size(171, 69)
        Me.buttonPartieScores.TabIndex = 65
        Me.buttonPartieScores.Text = "Scores"
        Me.buttonPartieScores.UseVisualStyleBackColor = False
        '
        'buttonAccueilPartie
        '
        Me.buttonAccueilPartie.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.buttonAccueilPartie.FlatAppearance.BorderSize = 3
        Me.buttonAccueilPartie.Font = New System.Drawing.Font("Segoe Print", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonAccueilPartie.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.buttonAccueilPartie.Location = New System.Drawing.Point(24, 27)
        Me.buttonAccueilPartie.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonAccueilPartie.Name = "buttonAccueilPartie"
        Me.buttonAccueilPartie.Size = New System.Drawing.Size(223, 69)
        Me.buttonAccueilPartie.TabIndex = 66
        Me.buttonAccueilPartie.Text = "Accueil"
        Me.buttonAccueilPartie.UseVisualStyleBackColor = False
        '
        'TimerPartie
        '
        Me.TimerPartie.Interval = 1000
        '
        'labelTemps
        '
        Me.labelTemps.AutoSize = True
        Me.labelTemps.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTemps.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.labelTemps.Location = New System.Drawing.Point(1121, 210)
        Me.labelTemps.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelTemps.Name = "labelTemps"
        Me.labelTemps.Size = New System.Drawing.Size(75, 35)
        Me.labelTemps.TabIndex = 67
        Me.labelTemps.Text = "temps"
        '
        'Panelmines
        '
        Me.Panelmines.Location = New System.Drawing.Point(343, 134)
        Me.Panelmines.Margin = New System.Windows.Forms.Padding(4)
        Me.Panelmines.Name = "Panelmines"
        Me.Panelmines.Size = New System.Drawing.Size(657, 539)
        Me.Panelmines.TabIndex = 68
        '
        'Buttonabandonner
        '
        Me.Buttonabandonner.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Buttonabandonner.Font = New System.Drawing.Font("Segoe Print", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonabandonner.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Buttonabandonner.Location = New System.Drawing.Point(24, 572)
        Me.Buttonabandonner.Margin = New System.Windows.Forms.Padding(4)
        Me.Buttonabandonner.Name = "Buttonabandonner"
        Me.Buttonabandonner.Size = New System.Drawing.Size(223, 101)
        Me.Buttonabandonner.TabIndex = 0
        Me.Buttonabandonner.Text = "Abandonner la Partie"
        Me.Buttonabandonner.UseVisualStyleBackColor = False
        '
        'Labelcompteur
        '
        Me.Labelcompteur.AutoSize = True
        Me.Labelcompteur.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcompteur.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Labelcompteur.Location = New System.Drawing.Point(59, 210)
        Me.Labelcompteur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labelcompteur.Name = "Labelcompteur"
        Me.Labelcompteur.Size = New System.Drawing.Size(159, 35)
        Me.Labelcompteur.TabIndex = 69
        Me.Labelcompteur.Text = "compteurmine"
        Me.Labelcompteur.UseMnemonic = False
        '
        'labelnomjoueur
        '
        Me.labelnomjoueur.AutoSize = True
        Me.labelnomjoueur.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelnomjoueur.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.labelnomjoueur.Location = New System.Drawing.Point(733, 61)
        Me.labelnomjoueur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelnomjoueur.Name = "labelnomjoueur"
        Me.labelnomjoueur.Size = New System.Drawing.Size(76, 35)
        Me.labelnomjoueur.TabIndex = 70
        Me.labelnomjoueur.Text = "joueur"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 21)
        Me.Label1.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(502, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 35)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Pseudo :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(40, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 35)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Mines découvertes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(1065, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 44)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Temps restant  "
        '
        'formPartie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1299, 712)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.labelnomjoueur)
        Me.Controls.Add(Me.Labelcompteur)
        Me.Controls.Add(Me.Buttonabandonner)
        Me.Controls.Add(Me.Panelmines)
        Me.Controls.Add(Me.labelTemps)
        Me.Controls.Add(Me.buttonAccueilPartie)
        Me.Controls.Add(Me.buttonPartieScores)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents Labelcompteur As Label
    Friend WithEvents labelnomjoueur As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
