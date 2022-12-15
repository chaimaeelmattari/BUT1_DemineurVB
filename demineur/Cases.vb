Module Cases
    Dim Taille = 8
    Dim nombreMines = 10
    Dim DureePartie As Integer = 60
    Dim hauteurpanel As Integer = formPartie.Panelmines.Height
    Dim largeurpanel As Integer = formPartie.Panelmines.Width
    Dim hauteurbouton As Integer = hauteurpanel \ Taille
    Dim largeurbouton As Integer = largeurpanel \ Taille
    Dim nbcases As Integer = Taille * Taille
    Dim cpt As Integer = 1
    Dim nombrecasedecouverte = 0
    Dim temps2revele As String
    Dim Grille(nbcases) As Cellule

    Dim LstScore As New ListViewItem()


    Private Structure Cellule
        Public statut As Integer '0-> masquée,'1 -> visible,'2 -> marquée
        Public valeur As Integer
    End Structure


    Public Sub Casefonction()
        For i As Integer = 0 To nbcases - 1
            Dim bouton As Button = New Windows.Forms.Button
            bouton.Name = "Case"
            'bouton.FlatAppearance
            bouton.Size = New Size(largeurbouton, hauteurbouton)
            bouton.Location = New Point(largeurbouton * (i Mod Taille), hauteurbouton * (i \ Taille))
            'bouton.Text = 0
            formPartie.Panelmines.Controls.Add(bouton)
            AddHandler bouton.Click, AddressOf formPartie.DébutTemps
            AddHandler bouton.Click, AddressOf EventHandlerNtnclic

        Next
    End Sub



    Public Sub Mines()
        Randomize()
        Dim mines As Integer
        initGrille()
        Dim cpt As Integer = 0
        While cpt < nombreMines
            mines = Int((nbcases * Rnd()) + 0)
            'If Not formPartie.Panelmines.Controls.Item(mines).Text = "mine" Then
            If Grille(mines).valeur > -1 Then
                'formPartie.Panelmines.Controls.Item(mines).Text = "mine"
                Grille(mines).valeur = -1

                majcasesadjacentesmines(mines)

                'AddHandler formPartie.Panelmines.Controls.Item(mines).Click, AddressOf formPartie.PartiePerdu

                cpt += 1

            End If

        End While


    End Sub

    Public Sub majcasesadjacentesmines(ByVal idx_mine As Integer)
        Dim li As Integer = Int((idx_mine / Taille))
        Dim co As Integer = idx_mine Mod Taille
        'MsgBox("idx_mine= " & idx_mine & " li=" & li & " co=" & co)
        'MsgBox(formPartie.Panelmines.Controls.Item(idx_mine).TabIndex & " " & li & " " & co)

        'li - 1, co -1 
        Dim Pos As Integer = ((li - 1) * Taille) + (co - 1)
        If ((li - 1 > -1) And (co - 1 > -1)) Then
            If (Grille(Pos).valeur > -1) Then
                'formPartie.Panelmines.Controls.Item(Pos).Text += 1
                Grille(Pos).valeur += 1
            End If
        End If

        'li - 1, même co que la mine
        Pos = ((li - 1) * Taille) + (co)
        If ((li - 1 > -1)) Then
            If (Grille(Pos).valeur > -1) Then
                'formPartie.Panelmines.Controls.Item(Pos).Text += 1
                Grille(Pos).valeur += 1
            End If
        End If

        'li - 1 co +1
        Pos = ((li - 1) * Taille) + (co + 1)
        If ((li - 1 > -1) And (co + 1 < Taille)) Then
            If (Grille(Pos).valeur > -1) Then
                'formPartie.Panelmines.Controls.Item(Pos).Text += 1
                Grille(Pos).valeur += 1
            End If
        End If

        ' co -1 
        Pos = (li * Taille) + (co - 1)
        If ((co - 1 > -1)) Then
            If (Grille(Pos).valeur > -1) Then
                'formPartie.Panelmines.Controls.Item(Pos).Text += 1
                Grille(Pos).valeur += 1
            End If
        End If

        'même li que la mine, co +1 
        Pos = (li * Taille) + (co + 1)
        If (co + 1 < Taille) Then
            If (Grille(Pos).valeur > -1) Then
                'formPartie.Panelmines.Controls.Item(Pos).Text += 1
                Grille(Pos).valeur += 1
            End If
        End If

        'li + 1, co -1
        Pos = ((li + 1) * Taille) + (co - 1)
        If ((li + 1 < Taille) And (co - 1 > -1)) Then
            If (Grille(Pos).valeur > -1) Then
                'formPartie.Panelmines.Controls.Item(Pos).Text += 1
                Grille(Pos).valeur += 1
            End If
        End If

        'li + 1, même co que la mine

        Pos = ((li + 1) * Taille) + (co)
        If (li + 1 < Taille) Then
            If (Grille(Pos).valeur > -1) Then
                'formPartie.Panelmines.Controls.Item(Pos).Text += 1
                Grille(Pos).valeur += 1
            End If
        End If

        'li + 1,  co +1 
        Pos = ((li + 1) * Taille) + (co + 1)
        If ((li + 1 < Taille) And (co + 1 < Taille)) Then
            If (Grille(Pos).valeur > -1) Then
                'formPartie.Panelmines.Controls.Item(Pos).Text += 1
                Grille(Pos).valeur += 1
            End If
        End If

    End Sub

    Public Sub afficherGrille()

        '0-> masquée,'1 -> visible,'2 -> marquée
        Dim i As Integer
        For i = 0 To nbcases - 1
            'If Grille(i).statut = 1 And Grille(i).valeur > -1 Then
            ' If Grille(i).statut <> 0 Then
            ' formPartie.Panelmines.Controls.Item(i).Text = Grille(i).valeur
            ' End If
            ' If Grille(i).statut = 1 Then
            ' formPartie.Panelmines.Controls.Item(i).BackColor = Colorlightcyan
            ' End If
            'End If
            'End If

            If Grille(i).statut = 1 Then
                formPartie.Panelmines.Controls.Item(i).BackColor = Color.LightBlue
                If Grille(i).valeur > 0 Then
                    formPartie.Panelmines.Controls.Item(i).Text = Grille(i).valeur
                End If
            End If


        Next
    End Sub

    Public Sub JouerCoup(ByVal i As Integer)
        'Dim i As Integer
        Grille(i).statut = 1
        afficherGrille()

    End Sub
    Public Sub revelecases(ByVal idxcase As Integer)
        Dim li As Integer = Int((idxcase / Taille))
        Dim co As Integer = idxcase Mod Taille
        Dim Pos As Integer = ((li - 1) * Taille) + (co - 1)

        If Grille(idxcase).valeur = 0 And Grille(idxcase).statut <> 1 Then
            Grille(idxcase).statut = 1
            'sender.backcolor = Colorlightcyan
            nombrecasedecouverte += 1
            formPartie.Labelcompteur.Text = nombrecasedecouverte

            If ((li - 1 > -1) And (co - 1 > -1)) Then
                Pos = ((li - 1) * Taille) + (co - 1)
                If Grille(Pos).valeur <> -1 And Grille(Pos).statut = 0 Then
                    revelecases(Pos)
                    'Grille(Pos).statut = 1
                    'formPartie.Panelmines.Controls.Item(Pos).BackColor = Colorlightcyan
                    'nombrecasedecouverte += 1
                    'formPartie.Labelcompteur.Text = nombrecasedecouverte
                End If
            End If

            'li - 1, même co que la mine
            If ((li - 1 > -1)) Then
                Pos = ((li - 1) * Taille) + (co)
                If (Grille(Pos).valeur <> -1 And Grille(Pos).statut = 0) Then
                    revelecases(Pos)
                End If
            End If

            'li - 1 co +1
            If ((li - 1 > -1) And (co + 1 < Taille)) Then
                Pos = ((li - 1) * Taille) + (co + 1)
                If (Grille(Pos).valeur <> -1 And Grille(Pos).statut = 0) Then
                    revelecases(Pos)
                End If
            End If

            ' co -1 
            If ((co - 1 > -1)) Then
                Pos = (li * Taille) + (co - 1)
                If (Grille(Pos).valeur <> -1 And Grille(Pos).statut = 0) Then
                    revelecases(Pos)
                End If
            End If

            'même li que la mine, co +1 

            If (co + 1 < Taille) Then
                Pos = (li * Taille) + (co + 1)
                If (Grille(Pos).valeur <> -1 And Grille(Pos).statut = 0) Then
                    revelecases(Pos)
                End If
            End If

            'li + 1, co -1
            If ((li + 1 < Taille) And (co - 1 > -1)) Then
                Pos = ((li + 1) * Taille) + (co - 1)
                If (Grille(Pos).valeur <> -1 And Grille(Pos).statut = 0) Then
                    revelecases(Pos)
                End If
            End If

            'li + 1, même co que la mine
            If (li + 1 < Taille) Then
                Pos = ((li + 1) * Taille) + (co)
                If (Grille(Pos).valeur <> -1 And Grille(Pos).statut = 0) Then
                    revelecases(Pos)
                End If
            End If

            'li + 1,  co +1 

            If ((li + 1 < Taille) And (co + 1 < Taille)) Then
                Pos = ((li + 1) * Taille) + (co + 1)
                If (Grille(Pos).valeur <> -1 And Grille(Pos).statut = 0) Then
                    revelecases(Pos)
                End If
            End If
        ElseIf Grille(idxcase).valeur > 0 And Grille(idxcase).statut <> 1 Then
            Grille(idxcase).statut = 1
            nombrecasedecouverte += 1
            formPartie.Labelcompteur.Text = nombrecasedecouverte
        End If
    End Sub
    Public Sub EventHandlerNtnclic(sender As Object, e As EventArgs)

        Dim Idx As Integer = formPartie.Panelmines.Controls.IndexOf(sender)
        Dim li As Integer = Int((Idx / Taille))
        Dim co As Integer = Idx Mod Taille
        Dim Pos As Integer = ((li - 1) * Taille) + (co - 1)


        If Grille(Idx).valeur = -1 Then
            formPartie.TimerPartie.Stop()
            sender.backcolor = Color.Red

            MsgBox("Vous avez perdu !", , "Démineur")
            afficherGrille()
            formPartie.Close()
            Exit Sub
        End If
        revelecases(Idx)

        Dim tmp As Object
        tmp = Split(formPartie.labelTemps.Text, ":")
        temps2revele = DureePartie - tmp(1)
        afficherGrille()
        If nombrecasedecouverte = nbcases - nombreMines Then
            MsgBox("Bravo, vous avez gagné la partie", , "Demineur")
        End If

    End Sub
    Public Sub initGrille()

        '0-> masquée,'1 -> visible
        Dim i As Integer
        For i = 0 To nbcases - 1
            Grille(i).valeur = 0
            Grille(i).statut = 0
            nombrecasedecouverte = 0
        Next
        formPartie.settemps(getDureePartie())
    End Sub

    Function getCaseDecouverte()
        Return nombrecasedecouverte
    End Function
    Function gettemps2revele()
        Return temps2revele
    End Function
    Function getDureePartie()
        Return DureePartie
    End Function

End Module
