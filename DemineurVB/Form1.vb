Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text.Length < 3 Then
            MsgBox("Message Nom à plus de 3 caractères")
        Else
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim réponse As MsgBoxResult = MsgBox("Message Fermer le formulaire", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Nom de la MsgBox (de la fenêtre)")
        If réponse = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
