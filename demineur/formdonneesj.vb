Public Class formdonneesj
    Public Sub New()

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBoxNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxNom.SelectedIndexChanged
        ComboBoxj.Text = ListBoxNom.Text
    End Sub

    Private Sub formdonneesj_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        add2listbox(FormAccueil.LstJoueur, ListBoxNom, ListBoxcasesdec, ListBoxtemps)
    End Sub

    Private Sub ComboBoxj_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxj.SelectedIndexChanged

    End Sub

    Private Sub ListBoxNom_Click(sender As Object, e As EventArgs) Handles ListBoxNom.Click
        ComboBoxj.Text = ListBoxNom.Text
    End Sub

    Private Sub Buttonmsgbox_Click(sender As Object, e As EventArgs) Handles Buttonmsgbox.Click
        Dim msg As String
        'Dim idx As Integer = ListBoxNom.Items.IndexOf(istBoxNom.Text)
        Dim eltjoeur As FormAccueil.ClsJoueur = FormAccueil.LstJoueur.Item(ComboBoxj.Text)
        msg = "Pseudo :" & eltjoeur.getpseudo & vbCrLf
        msg = msg & "Meilleur Score : " & eltjoeur.gettemps & vbCrLf
        msg = msg & " Nombre de partie jouée : " & eltjoeur.getnbrpartie & vbCrLf
        msg = msg & " Temps cumulés : " & eltjoeur.getCumtemps & vbCrLf
        'MsgBox(eltjoeur.ToString())
        MsgBox(msg, , "Données Joueurs")

    End Sub
End Class