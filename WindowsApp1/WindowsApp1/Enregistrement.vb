Module Enregistrement
    Public Structure Pers
        Dim nom As String
        Dim prenom As String
    End Structure

    Private Const PAS_EXT As Integer = 10
    Private tabPers() As Pers
    Private nbP As Integer = 0

    Public Sub enregistrer(p As Pers)
        If nbP > UBound(tabPers) Then
            ReDim Preserve tabPers(nbP + PAS_EXT)
        End If

        tabPers(nbP) = p
        nbP += 1
    End Sub

    Public Function getPers(i As Integer) As Pers
        Debug.Assert(i >= 0 AndAlso i < nbP)

        Return tabPers(i)
    End Function

    Public Function getNbPers() As Integer
        Return nbP
    End Function


    Sub main()
        Dim nb As Integer
        Do
            nb = CInt(Trim(InputBox("Combien de Personne")))
        Loop While nb <= 0

        ReDim tabPers(nb - 1)

        Application.Run(FormSaisie)

        MsgBox("Fin du programme")
    End Sub
End Module
