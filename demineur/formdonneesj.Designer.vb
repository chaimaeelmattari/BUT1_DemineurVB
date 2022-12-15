<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formdonneesj
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBoxNom = New System.Windows.Forms.ListBox()
        Me.Labellistboxdonnees = New System.Windows.Forms.Label()
        Me.ComboBoxj = New System.Windows.Forms.ComboBox()
        Me.LabelRechercher = New System.Windows.Forms.Label()
        Me.Buttonmsgbox = New System.Windows.Forms.Button()
        Me.ListBoxcasesdec = New System.Windows.Forms.ListBox()
        Me.ListBoxtemps = New System.Windows.Forms.ListBox()
        Me.Labelcasesdec = New System.Windows.Forms.Label()
        Me.Labeltemps = New System.Windows.Forms.Label()
        Me.Labelpseudo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBoxNom
        '
        Me.ListBoxNom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ListBoxNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxNom.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ListBoxNom.FormattingEnabled = True
        Me.ListBoxNom.ItemHeight = 18
        Me.ListBoxNom.Location = New System.Drawing.Point(58, 232)
        Me.ListBoxNom.Name = "ListBoxNom"
        Me.ListBoxNom.Size = New System.Drawing.Size(264, 238)
        Me.ListBoxNom.Sorted = True
        Me.ListBoxNom.TabIndex = 0
        '
        'Labellistboxdonnees
        '
        Me.Labellistboxdonnees.AutoSize = True
        Me.Labellistboxdonnees.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Labellistboxdonnees.Font = New System.Drawing.Font("Stencil Std", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labellistboxdonnees.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Labellistboxdonnees.Location = New System.Drawing.Point(357, 60)
        Me.Labellistboxdonnees.Name = "Labellistboxdonnees"
        Me.Labellistboxdonnees.Size = New System.Drawing.Size(341, 42)
        Me.Labellistboxdonnees.TabIndex = 1
        Me.Labellistboxdonnees.Text = "Données Joueurs"
        '
        'ComboBoxj
        '
        Me.ComboBoxj.FormattingEnabled = True
        Me.ComboBoxj.Location = New System.Drawing.Point(406, 597)
        Me.ComboBoxj.Name = "ComboBoxj"
        Me.ComboBoxj.Size = New System.Drawing.Size(264, 21)
        Me.ComboBoxj.TabIndex = 3
        '
        'LabelRechercher
        '
        Me.LabelRechercher.AutoSize = True
        Me.LabelRechercher.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelRechercher.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRechercher.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelRechercher.Location = New System.Drawing.Point(416, 539)
        Me.LabelRechercher.Name = "LabelRechercher"
        Me.LabelRechercher.Size = New System.Drawing.Size(245, 37)
        Me.LabelRechercher.TabIndex = 4
        Me.LabelRechercher.Text = "Rechercher un joueur"
        '
        'Buttonmsgbox
        '
        Me.Buttonmsgbox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Buttonmsgbox.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonmsgbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Buttonmsgbox.Location = New System.Drawing.Point(406, 643)
        Me.Buttonmsgbox.Name = "Buttonmsgbox"
        Me.Buttonmsgbox.Size = New System.Drawing.Size(264, 54)
        Me.Buttonmsgbox.TabIndex = 5
        Me.Buttonmsgbox.Text = "Statistiques "
        Me.Buttonmsgbox.UseVisualStyleBackColor = False
        '
        'ListBoxcasesdec
        '
        Me.ListBoxcasesdec.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ListBoxcasesdec.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxcasesdec.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ListBoxcasesdec.FormattingEnabled = True
        Me.ListBoxcasesdec.ItemHeight = 18
        Me.ListBoxcasesdec.Location = New System.Drawing.Point(406, 232)
        Me.ListBoxcasesdec.Name = "ListBoxcasesdec"
        Me.ListBoxcasesdec.Size = New System.Drawing.Size(264, 238)
        Me.ListBoxcasesdec.Sorted = True
        Me.ListBoxcasesdec.TabIndex = 6
        '
        'ListBoxtemps
        '
        Me.ListBoxtemps.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ListBoxtemps.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxtemps.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ListBoxtemps.FormattingEnabled = True
        Me.ListBoxtemps.ItemHeight = 18
        Me.ListBoxtemps.Location = New System.Drawing.Point(758, 232)
        Me.ListBoxtemps.Name = "ListBoxtemps"
        Me.ListBoxtemps.Size = New System.Drawing.Size(264, 238)
        Me.ListBoxtemps.TabIndex = 7
        '
        'Labelcasesdec
        '
        Me.Labelcasesdec.AutoSize = True
        Me.Labelcasesdec.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Labelcasesdec.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcasesdec.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Labelcasesdec.Location = New System.Drawing.Point(399, 178)
        Me.Labelcasesdec.Name = "Labelcasesdec"
        Me.Labelcasesdec.Size = New System.Drawing.Size(283, 37)
        Me.Labelcasesdec.TabIndex = 8
        Me.Labelcasesdec.Text = "Record cases découvertes"
        '
        'Labeltemps
        '
        Me.Labeltemps.AutoSize = True
        Me.Labeltemps.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Labeltemps.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labeltemps.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Labeltemps.Location = New System.Drawing.Point(832, 172)
        Me.Labeltemps.Name = "Labeltemps"
        Me.Labeltemps.Size = New System.Drawing.Size(86, 37)
        Me.Labeltemps.TabIndex = 9
        Me.Labeltemps.Text = "Temps"
        '
        'Labelpseudo
        '
        Me.Labelpseudo.AutoSize = True
        Me.Labelpseudo.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Labelpseudo.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelpseudo.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Labelpseudo.Location = New System.Drawing.Point(112, 178)
        Me.Labelpseudo.Name = "Labelpseudo"
        Me.Labelpseudo.Size = New System.Drawing.Size(91, 37)
        Me.Labelpseudo.TabIndex = 10
        Me.Labelpseudo.Text = "Pseudo"
        '
        'formdonneesj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1098, 854)
        Me.Controls.Add(Me.Labelpseudo)
        Me.Controls.Add(Me.Labeltemps)
        Me.Controls.Add(Me.Labelcasesdec)
        Me.Controls.Add(Me.ListBoxtemps)
        Me.Controls.Add(Me.ListBoxcasesdec)
        Me.Controls.Add(Me.Buttonmsgbox)
        Me.Controls.Add(Me.LabelRechercher)
        Me.Controls.Add(Me.ComboBoxj)
        Me.Controls.Add(Me.Labellistboxdonnees)
        Me.Controls.Add(Me.ListBoxNom)
        Me.Name = "formdonneesj"
        Me.Text = "Démineur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxNom As ListBox
    Friend WithEvents Labellistboxdonnees As Label
    Friend WithEvents ComboBoxj As ComboBox
    Friend WithEvents LabelRechercher As Label
    Friend WithEvents Buttonmsgbox As Button
    Friend WithEvents ListBoxcasesdec As ListBox
    Friend WithEvents ListBoxtemps As ListBox
    Friend WithEvents Labelcasesdec As Label
    Friend WithEvents Labeltemps As Label
    Friend WithEvents Labelpseudo As Label
End Class
