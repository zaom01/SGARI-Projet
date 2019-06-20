Public Class Service
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Groupprincipal.Enabled = True
        Groupoperation.Enabled = True
        Description.Select()
    End Sub

    Private Sub Service_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Groupprincipal.Enabled = False
        Groupoperation.Enabled = False
    End Sub

    Private Sub ButtonModifier_Click(sender As Object, e As EventArgs) Handles ButtonModifier.Click
        Groupprincipal.Enabled = True
        Groupoperation.Enabled = True
        Description.Select()
    End Sub

    Private Sub Valider_Click(sender As Object, e As EventArgs) Handles Valider.Click
        MsgBox("1 Enregistrement est ajouter")
    End Sub

    Private Sub Buttondel_Click(sender As Object, e As EventArgs) Handles Buttondel.Click
        If MsgBox("Voulez-Vous Vraiment Supprimer ce paiement", MsgBoxStyle.YesNo + vbQuestion, "Paiement") = MsgBoxResult.Yes Then
            Description.Text = ""
            PrixService.Text = ""
            MsgBox("1 Enregistrement est effacé")
            Groupprincipal.Enabled = False
            Groupoperation.Enabled = False
            GroupMenu.Enabled = True
        End If
    End Sub

    Private Sub Annuler_Click(sender As Object, e As EventArgs) Handles Annuler.Click
        Description.Text = ""
        PrixService.Text = ""
        Groupprincipal.Enabled = False
        Groupoperation.Enabled = False
        GroupMenu.Enabled = True
    End Sub

    Private Sub ButtonTaxe_Click(sender As Object, e As EventArgs) Handles ButtonTaxe.Click
        Me.Close()

    End Sub
End Class