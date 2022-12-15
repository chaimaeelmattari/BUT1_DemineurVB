Public Class FormAccueil
    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub buttonQuitter_Click(sender As Object, e As EventArgs)
        Dim Réponse As MsgBoxResult = MsgBox("Voulez-vous quitter le jeu ?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Démineur")
        If Réponse = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub labelJoueur_Click(sender As Object, e As EventArgs) Handles labelJoueur.Click

    End Sub

    Private Sub comboboxJoueur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxJoueur.SelectedIndexChanged


    End Sub

    Private Sub buttonScores_Click(sender As Object, e As EventArgs) Handles buttonScores.Click
        formScores.Show()
    End Sub

    Private Sub buttonPartie_Click(sender As Object, e As EventArgs) Handles buttonPartie.Click
        If comboboxJoueur.Text.Length >= 3 Then
            formPartie.Show()
            Me.Hide()
        Else MsgBox("Veuillez saisir un nom de plus de 3 caractères", , "Message d'erreur")

        End If






    End Sub
End Class
