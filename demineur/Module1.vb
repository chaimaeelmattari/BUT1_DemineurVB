Module Module1
    Sub mines()
        Dim mines As Integer
        While cpt < nombreMines
            mines = Int((64 * Rnd()) + 0)
            If Not Panelmines.Controls.Item(mines).Text = "mines" Then
                Panelmines.Controls.Item(mines).Text = "mines"
                cpt += 1
            End If

    End Sub
End Module
