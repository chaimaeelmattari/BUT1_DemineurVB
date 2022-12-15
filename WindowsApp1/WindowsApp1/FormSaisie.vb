Public Class FormSaisie
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Trim(TextBox1.Text) <> "" And Trim(TextBox2.Text) <> "" Then
            Dim p As Pers
            With p
                .nom = TextBox1.Text
                .prenom = TextBox2.Text
            End With

            Enregistrement.enregistrer(p)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim s As String = "Personnes enregistrées :" & vbCr
        For i As Integer = 0 To Enregistrement.getNbPers - 1
            Dim p As Pers = Enregistrement.getPers(i)
            s &= p.nom & " " & p.prenom & vbCr
        Next

        MsgBox(s, vbOKOnly, "Recap")
    End Sub

    Private Sub FormSaisie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
