
Imports System.IO
Public Class FrmNewFournisseur


    'Procedure pour effacer les données afficher sur le form de nouveau fournisseur 
    Sub EffacerDonner()
        TxtBoxNoCompte.Text = ""
        TxtBoxSocieté.Text = ""
        TxtBoxNomComptable.Text = ""
        TxtBoxAdresse.Text = ""
        TxtBoxAdresseBanque.Text = ""
        TxtBoxCodeBanque.Text = ""
        TxtBoxCompte.Text = ""
        TxtBoxContact.Text = ""
        TxtBoxEmail.Text = ""
        TxtBoxFax.Text = ""
        TxtBoxFonction.Text = ""
        TxtBoxNomBanque.Text = ""
        TxtBoxPays.Text = ""
        TxtBoxProvince.Text = ""
        TxtBoxSiteWeb.Text = ""
        TxtBoxTéléphone1.Text = ""
        TxtBoxTéléphone2.Text = ""
        TxtBoxVille.Text = ""
        TxtBoxVilleBanque.Text = ""
        TxtBoxCodePostal.Text = ""

    End Sub


    'Procedure pour vérifier le remplisage des champs de saisie
    Sub verifierSaisie()
        If TxtBoxNoCompte.Text = "" Then
            MsgBox("Veuillez Entrer le numero de compte du fournisseur", vbOKOnly, "Erreur")

        ElseIf TxtBoxSocieté.Text = "" Then
            MsgBox("Veuillez Entrer le Nom de la societe ", vbOKOnly, "Erreur")

        ElseIf TxtBoxContact.Text = "" Then
            MsgBox("Veuillez Entrer le contact de fournisseur", vbOKOnly, "Erreur")

        ElseIf TxtBoxAdresse.Text = "" Then
            MsgBox("Veuillez Entrer l'adresse du fournisseur", vbOKOnly, "Erreur")

        ElseIf TxtBoxTéléphone1.Text = "" Then
            MsgBox("Veuillez Entrer le téléphone du fournisseur", vbOKOnly, "Erreur")


        Else
            MsgBox("Le  fournisseur est bien enregistrer", vbOKOnly, "Nouveau fournisseur")
        End If


    End Sub




    'Botton pour valider l'enregistrement d'un fournisseur
    Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click

        verifierSaisie()

    End Sub


    'Bouton pour vider les champ remplie et entrer les donner d'un nouveau fournisseur 
    Private Sub BtnNouveau_Click(sender As Object, e As EventArgs) Handles BtnNouveau.Click
        EffacerDonner()
    End Sub
    'Boutton pour fermer le form de nouveau fournisseur 
    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        EffacerDonner()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub BoxContactFournisseur_Enter(sender As Object, e As EventArgs) Handles BoxContactFournisseur.Enter

    End Sub
End Class