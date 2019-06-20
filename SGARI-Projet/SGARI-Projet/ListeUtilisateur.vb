Public Class ListeUtilisateur
    Private Sub ListeUtilisateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        recherche()

    End Sub
    Sub recherche()
        Dim tabutilisateur() As String = {"administrateur", "Ahmed", "Mouna", "Grace"}
        Dim intCount As Integer = 0
        For intCount = 0 To tabutilisateur.Length - 1
            Listutlisateurs.Items.Add(tabutilisateur(intCount))
        Next


    End Sub

    Private Sub Listutlisateurs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Listutlisateurs.SelectedIndexChanged

    End Sub
End Class