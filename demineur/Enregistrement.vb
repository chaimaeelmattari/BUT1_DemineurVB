Module Enregistrement
    Public Structure Joueur
        Dim pseudo As String
        Dim score As Integer
        Dim temps As Timer

    End Structure

    Dim lirefichier, lignesuivante As String

    'Public Sub inscrire()
    'Dim tabpseudo(199) As String
    'Dim tabscore(199) As Integer
    'Dim i As Integer
    'Dim s1 As String = FormAccueil.comboboxJoueur.Text
    'Dim s2 As String = "totiti  a,zr ar "
    'Dim num As Integer = FreeFile()
    '  FileOpen(num, "enregistrement.txt", OpenMode.Append)
    '  WriteLine(num, s1)
    '  ' WriteLine(num, s2)
    '  FileClose(num)
    '   formPartie.labelnomjoueur.Text = s1
    '  End Sub
    ' Public Sub Recupere()
    '     Dim s As String
    'Dim num As Integer = FreeFile()
    '   FileOpen(num, "enregistrement.txt", OpenMode.Input)
    '  Input(num, s)
    '  MsgBox(s)
    ' Input(num, s)
    '  MsgBox(s)
    '  FileClose(num)
    '   End Sub

    ' Public Sub Lire()
    'Dim num As Integer = FreeFile()
    'do Until EOF(num)
    '  lignesuivante = LineInput(num)
    '        lirefichier = lirefichier & lignesuivante & vbCr
    'Loop
    ' End Sub




    Sub SauvegarderDonnees(ByVal Fichier As String)
        Dim elt As FormAccueil.ClsJoueur
        Dim num As Integer = FreeFile()
        FileOpen(num, "test.txt", OpenMode.Output)
        For Each pair As KeyValuePair(Of String, FormAccueil.ClsJoueur) In FormAccueil.LstJoueur
            WriteLine(num, pair.Value.ToString())
        Next

        'For Each elt In FormAccueil.LstJoueur
        ' WriteLine(num, elt.ToString())
        'MsgBox(elt.ToString())
        ' Next
        FileClose(num)
    End Sub
    Sub Chargerdonnees()

        Dim Line As String
        Dim strArr() As String
        Dim count As Integer
        Dim num As Integer = FreeFile()
        If System.IO.File.Exists("test.txt") Then
            FileOpen(num, "test.txt", OpenMode.Input)
            Do Until EOF(num)

                'Dim eltjoeur As FormAccueil.ClsJoueur = New FormAccueil.ClsJoueur(formPartie.labelnomjoueur.Text, getCaseDecouverte(), gettemps2revele())
                'FormAccueil.LstJoueur.Add(eltjoeur)
                Dim Strline As String = LineInput(num)
                Strline = Strline.Replace(Chr(34), "")
                strArr = Strline.Split("|")
                Dim eltjoeur As FormAccueil.ClsJoueur = New FormAccueil.ClsJoueur(strArr(0), strArr(1), strArr(2))
                FormAccueil.LstJoueur.Add(strArr(0), eltjoeur)
                If Not FormAccueil.comboboxJoueur.Items.Contains(strArr(0)) Then
                    FormAccueil.comboboxJoueur.Items.Add(strArr(0))
                End If
                'For count = 0 To strArr.Length - 1
                'MsgBox(strArr(count))
                'Next
            Loop
            FileClose(num)
        End If
    End Sub
    Sub add2listbox(ByRef dic As Dictionary(Of String, FormAccueil.ClsJoueur), ByRef lsb1 As ListBox, ByRef lsb2 As ListBox, ByRef lsb3 As ListBox)
        For Each pair As KeyValuePair(Of String, FormAccueil.ClsJoueur) In dic
            lsb1.Items.Add(pair.Value.getpseudo)
            lsb2.Items.Add(pair.Value.getscore)
            lsb3.Items.Add(pair.Value.gettemps)
        Next

    End Sub
End Module
