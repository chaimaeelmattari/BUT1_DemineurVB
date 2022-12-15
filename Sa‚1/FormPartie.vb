Public Class formPartie

    Dim Temps As Integer = 60


    Private Sub formPartie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        labelTemps.Text = Temps \ 60 & ":" & ((Temps Mod 60) \ 10) & (Temps Mod 60) Mod 10
        Casefonction()
        Mines()

    End Sub

    Private Sub buttonPartieScores_Click(sender As Object, e As EventArgs) Handles buttonPartieScores.Click

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
            MsgBox("       GAME OVER", , "Temps écoulé")
        End If
    End Sub




    Private Sub Buttonabandonner_Click(sender As Object, e As EventArgs) Handles Buttonabandonner.Click
        Dim Réponse As MsgBoxResult = MsgBox("Etes-vous sûr d'abandonner la partie ?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Démineur")
        If Réponse = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class