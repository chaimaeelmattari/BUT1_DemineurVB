Public Class formScores
    Private Sub formScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim elt As FormAccueil.ClsJoueur

        For Each pair As KeyValuePair(Of String, FormAccueil.ClsJoueur) In FormAccueil.LstJoueur
            Dim LItem As New ListViewItem()
            LItem.Text = pair.Value.getpseudo()
            LItem.SubItems.Add(pair.Value.getscore())
            LItem.SubItems.Add(pair.Value.gettemps())
            'Cases.LstScoreadd(LItem)
            LstViewScore.Items.Add(LItem)
            'WriteLine(num, pair.Value.ToString())
        Next

    End Sub

    Private Sub LstViewScore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstViewScore.SelectedIndexChanged

    End Sub

    Private Sub LstViewScore_Disposed(sender As Object, e As EventArgs) Handles LstViewScore.Disposed

    End Sub
End Class