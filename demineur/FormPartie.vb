Public Class formPartie

    Dim Temps As Integer


    Private Sub formPartie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Casefonction()
        Mines()
        afficherGrille()
        labelTemps.Text = Temps \ 60 & ":" & ((Temps Mod 60) \ 10) & (Temps Mod 60) Mod 10
        Labelcompteur.Text = getCaseDecouverte()
        labelnomjoueur.Text = FormAccueil.comboboxJoueur.Text


    End Sub
    Sub settemps(ByVal tmp As Integer)
        Temps = tmp
    End Sub
    Private Sub buttonPartieScores_Click(sender As Object, e As EventArgs) Handles buttonPartieScores.Click
        Dim LItem As New ListViewItem()
        'For Each item In Cases.ls LstScore
        formScores.LstViewScore.Items.Add(LItem)
        formScores.Show()


    End Sub

    Public Sub DébutTemps(sender As Object, e As EventArgs)

        TimerPartie.Start()
    End Sub
    Private Sub buttonAccueilPartie_Click(sender As Object, e As EventArgs) Handles buttonAccueilPartie.Click
        Me.Close()
    End Sub

    Private Sub formPartie_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        FormAccueil.Show()


    End Sub

    Private Sub TimerPartie_Tick(sender As Object, e As EventArgs) Handles TimerPartie.Tick
        Temps -= 1
        labelTemps.Text = Temps \ 60 & ":" & ((Temps Mod 60) \ 10) & (Temps Mod 60) Mod 10
        If Temps = 0 Then
            TimerPartie.Stop()
            Dim Msg As String
            Msg = "       GAME OVER" & vbCrLf & "vous avez revele: " & getCaseDecouverte() & " cases en " & gettemps2revele() & " secondes"
            MsgBox(Msg, , "Temps écoulé")
            Dim eltjoeur As FormAccueil.ClsJoueur = New FormAccueil.ClsJoueur(labelnomjoueur.Text, getCaseDecouverte(), gettemps2revele())
            If Not FormAccueil.LstJoueur.ContainsKey(labelnomjoueur.Text) Then
                FormAccueil.LstJoueur.Add(labelnomjoueur.Text, eltjoeur)
            Else
                Dim acteltjoueur As FormAccueil.ClsJoueur = FormAccueil.LstJoueur.Item(labelnomjoueur.Text)
                If acteltjoueur.getscore < eltjoeur.getscore Then
                    acteltjoueur.setscore(eltjoeur.getscore)
                    acteltjoueur.settemps(eltjoeur.gettemps)
                End If
                acteltjoueur.IncCumtemps(eltjoeur.gettemps)
                acteltjoueur.setnbrpartie(acteltjoueur.getnbrpartie() + 1)
                FormAccueil.LstJoueur.Item(labelnomjoueur.Text) = acteltjoueur
            End If


                'Dim Item As New ListViewItem()
                'LItem.Text = labelnomjoueur.Text
                'LItem.SubItems.Add(getCaseDecouverte())
                'LItem.SubItems.Add(gettemps2revele())
                'Cases.LstScoreadd(LItem)
                'formScores.LstViewScore.Items.Add(LItem)

                'Dim enreg() = ("kkk", "555", "777")
                'formScores.LstViewScore.Items.Add(record)

            End If

    End Sub

    Public Function getTemps()
        Return Temps
    End Function


    Private Sub Buttonabandonner_Click(sender As Object, e As EventArgs) Handles Buttonabandonner.Click
        Dim Réponse As MsgBoxResult = MsgBox("Etes-vous sûr d'abandonner la partie ?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Démineur")
        If Réponse = MsgBoxResult.Yes Then
            FormAccueil.Show()
            'Me.Close()
            Me.Dispose()

        End If
    End Sub

    Private Sub labelTemps_Click(sender As Object, e As EventArgs) Handles labelTemps.Click

    End Sub

    Private Sub Labelcompteur_Click(sender As Object, e As EventArgs) Handles Labelcompteur.Click

    End Sub

    Private Sub labelnomjoueur_Click(sender As Object, e As EventArgs) Handles labelnomjoueur.Click

    End Sub

    Private Sub Panelmines_Paint(sender As Object, e As PaintEventArgs) Handles Panelmines.Paint

    End Sub
End Class