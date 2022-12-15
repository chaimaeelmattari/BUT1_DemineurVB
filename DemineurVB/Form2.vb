Public Class Form2
    Dim temps As Integer = 60
    Dim taille As Integer = 8
    Dim nbMines As Integer = 10

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = temps \ 60 & ":" & (temps Mod 60) \ 10 & (temps Mod 60) Mod 10

        Dim hauteur As Integer = Panel1.Height
        Dim largeur As Integer = Panel1.Width
        Dim hauteurBouton As Integer = hauteur \ taille
        Dim largeurBouton As Integer = largeur \ taille
        Dim nbCases As Integer = taille * taille
        For i As Integer = 0 To nbCases - 1
            Dim bouton As Button = New Windows.Forms.Button
            bouton.Name = i
            bouton.Size = New Size(largeurBouton, hauteurBouton)
            bouton.Location = New Point(largeurBouton * (i Mod taille), hauteurBouton * (i \ taille))
            AddHandler bouton.Click, AddressOf DébutTemps
            Panel1.Controls.Add(bouton)
        Next

        Dim cpt As Integer = 0
        Randomize()
        While cpt < nbMines
            Dim nb As Integer = CInt((taille * taille - 1) * Rnd())
            If Not Panel1.Controls.Item(nb).Text = "mines" Then
                Panel1.Controls.Item(nb).Text = "mines"
                cpt += 1
            End If
        End While

    End Sub

    Private Sub DébutTemps()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        temps -= 1
        Label1.Text = temps \ 60 & ":" & (temps Mod 60) \ 10 & (temps Mod 60) Mod 10
        If temps = 0 Then
            Timer1.Stop()
            MsgBox("Message Partie perdue", , "Nom de la fenêtre")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

End Class