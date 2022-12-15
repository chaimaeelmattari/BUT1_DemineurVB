<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formScores
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
        Me.LstViewScore = New System.Windows.Forms.ListView()
        Me.Colpseudo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColScore = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColTemps = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TableauScoreLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LstViewScore
        '
        Me.LstViewScore.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Colpseudo, Me.ColScore, Me.ColTemps})
        Me.LstViewScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstViewScore.HideSelection = False
        Me.LstViewScore.Location = New System.Drawing.Point(18, 76)
        Me.LstViewScore.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.LstViewScore.Name = "LstViewScore"
        Me.LstViewScore.Size = New System.Drawing.Size(764, 460)
        Me.LstViewScore.TabIndex = 0
        Me.LstViewScore.UseCompatibleStateImageBehavior = False
        Me.LstViewScore.View = System.Windows.Forms.View.Details
        '
        'Colpseudo
        '
        Me.Colpseudo.Text = "Pseudo"
        Me.Colpseudo.Width = 357
        '
        'ColScore
        '
        Me.ColScore.Text = "Score"
        Me.ColScore.Width = 288
        '
        'ColTemps
        '
        Me.ColTemps.Text = "Temps"
        Me.ColTemps.Width = 597
        '
        'TableauScoreLabel
        '
        Me.TableauScoreLabel.AutoSize = True
        Me.TableauScoreLabel.Font = New System.Drawing.Font("Segoe Print", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableauScoreLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TableauScoreLabel.Location = New System.Drawing.Point(245, 7)
        Me.TableauScoreLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TableauScoreLabel.Name = "TableauScoreLabel"
        Me.TableauScoreLabel.Size = New System.Drawing.Size(239, 43)
        Me.TableauScoreLabel.TabIndex = 1
        Me.TableauScoreLabel.Text = "Tableau des scores"
        '
        'formScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(800, 574)
        Me.Controls.Add(Me.TableauScoreLabel)
        Me.Controls.Add(Me.LstViewScore)
        Me.Name = "formScores"
        Me.Text = "Démineur Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstViewScore As ListView
    Friend WithEvents Colpseudo As ColumnHeader
    Friend WithEvents ColScore As ColumnHeader
    Friend WithEvents ColTemps As ColumnHeader
    Friend WithEvents TableauScoreLabel As Label
End Class
