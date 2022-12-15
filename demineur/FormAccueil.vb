Public Class FormAccueil
    'Public LstJoueur As New List(Of ClsJoueur)
    Public LstJoueur As New Dictionary(Of String, ClsJoueur)
    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Chargerdonnees()
        comboboxJoueur.Items.Add(comboboxJoueur.Text)
    End Sub


    Private Sub buttonQuitter_Click(sender As Object, e As EventArgs)
        Dim Réponse As MsgBoxResult = MsgBox("Voulez-vous quitter le jeu ?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Démineur")
        If Réponse = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub labelJoueur_Click(sender As Object, e As EventArgs) Handles labelJoueur.Click

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


    Public Class ClsJoueur
        Dim pseudo As String
        Dim score As Integer
        Dim temps As String
        Dim nbrpartie As Integer
        Dim Cumtemps As UInteger

        Public Sub New(pseudo As String, score As Integer, temps As String)
            Me.pseudo = pseudo
            Me.score = score
            Me.temps = temps

        End Sub
        Function getpseudo()
            Return Me.pseudo
        End Function
        Function getscore()
            Return Me.score
        End Function
        Sub setscore(sc As Integer)
            Me.score = sc
        End Sub
        Function gettemps()
            Return Me.temps
        End Function
        Function getnbrpartie()
            Return Me.nbrpartie
        End Function
        Sub setnbrpartie(nbp As Integer)
            Me.nbrpartie = nbp
        End Sub

        Function getCumtemps()
            Return Me.Cumtemps
        End Function
        Sub settemps(tmp As String)
            Me.temps = tmp
        End Sub
        Sub setCumtemps(nbp As UInteger)
            Me.Cumtemps = nbp
        End Sub
        Sub IncCumtemps(nbp As Integer)
            Me.Cumtemps += nbp
        End Sub


        Public Overrides Function ToString() As String
            Return Me.pseudo & "|" & Me.score & "|" & Me.temps & "|" & Me.nbrpartie & "|" & Me.Cumtemps
        End Function
    End Class



    Private Sub buttondonneesjoueurs_Click(sender As Object, e As EventArgs) Handles buttondonneesjoueurs.Click
        formdonneesj.Show()
    End Sub


End Class
