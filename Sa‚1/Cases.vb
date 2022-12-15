Module Cases
    Dim Taille = 8
    Dim nombreMines = 10

    Dim hauteurpanel As Integer = formPartie.Panelmines.Height
    Dim largeurpanel As Integer = formPartie.Panelmines.Width
    Dim hauteurbouton As Integer = hauteurpanel \ Taille
    Dim largeurbouton As Integer = largeurpanel \ Taille
    Dim nbbouton As Integer = Taille * Taille
    Dim cpt As Integer = 0

    Public Sub Casefonction()
        For i As Integer = 0 To nbbouton - 1
            Dim bouton As Button = New Windows.Forms.Button
            bouton.Name = "Case"
            bouton.Size = New Size(largeurbouton, hauteurbouton)
            bouton.Location = New Point(largeurbouton * (i Mod Taille), hauteurbouton * (i \ Taille))
            formPartie.Panelmines.Controls.Add(bouton)
            AddHandler bouton.Click, AddressOf formPartie.DébutTemps


        Next

    End Sub

    Public Sub Mines()
        Randomize()
        Dim mines As Integer
        While cpt < nombreMines
            mines = Int((64 * Rnd()) + 0)
            If Not formPartie.Panelmines.Controls.Item(mines).Text = "mines" Then
                formPartie.Panelmines.Controls.Item(mines).Text = "mines"

                cpt += 1
            End If

        End While
    End Sub





End Module
