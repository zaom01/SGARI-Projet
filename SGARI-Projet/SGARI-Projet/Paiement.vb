Public Class Paiement


    Private Sub Radiocarte_CheckedChanged(sender As Object, e As EventArgs) Handles Radiocarte.CheckedChanged
        GroupeCartecredit.Visible = True
        Groupcheque.Visible = False
        GroupRetrait.Visible = False
    End Sub

    Private Sub Radiocheque_CheckedChanged(sender As Object, e As EventArgs) Handles Radiocheque.CheckedChanged
        GroupeCartecredit.Visible = False
        Groupcheque.Visible = True
        GroupRetrait.Visible = False
    End Sub

    Private Sub RadioRetrait_CheckedChanged(sender As Object, e As EventArgs) Handles RadioRetrait.CheckedChanged
        GroupeCartecredit.Visible = False
        Groupcheque.Visible = False
        GroupRetrait.Visible = True
    End Sub
    'Boutton Recherche
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If numPaiement.Text <> "" Then


            GroupFacture.Enabled = False
        'GroupInformation.Enabled = True
        GroupPaaiement.Enabled = True
        GroupType.Enabled = True
        GroupeCartecredit.Enabled = True
        Groupcheque.Enabled = True
        GroupRetrait.Enabled = True
        GroupMENU.Enabled = True
        End If
        If NumFacture.Text = "1" And numPaiement.Text = "1/2018" Then
            NumFacture.Text = "1"
            numPaiement.Text = "01/2018"
            DateFacture.Text = "01/01/2018"
            NomClient.Text = "Adam Slaoui"
            Montantapayer.Text = 2300
            DatePaiement.Text = "01/04/2018"
            MntPayer.Text = 2300
            Balance.Text = 0
            Radiocarte.Checked = True
            TextNcarte.Text = "111111111111111111111"
            TextInstitution.Text = "Banque de Montereal"
            TextDateEXPIRATION.Text = "01/01/2022"
            ComboTypeCarte.Text = "Visa"
        End If

        If NumFacture.Text = "2" And numPaiement.Text = "1/2018" Then
            NumFacture.Text = "2"
            numPaiement.Text = "01/2018"
            DateFacture.Text = "01/03/2018"
            NomClient.Text = "Rayan Safir"
            Montantapayer.Text = 3500
            DatePaiement.Text = "01/04/2018"
            MntPayer.Text = 2000
            Balance.Text = 1500
            Radiocarte.Checked = True
            TextNcarte.Text = "111111111111111111111"
            TextInstitution.Text = "Td canada"
            TextDateEXPIRATION.Text = "01/01/2022"
            ComboTypeCarte.Text = "Visa"
        End If
        If NumFacture.Text = "2" And numPaiement.Text = "2/2018" Then
            NumFacture.Text = "2"
            numPaiement.Text = "02/2018"
            DateFacture.Text = "01/03/2018"
            NomClient.Text = "Rayan Safir"
            Montantapayer.Text = 1500
            DatePaiement.Text = "01/04/2018"
            MntPayer.Text = 1500
            Balance.Text = 0
            Radiocarte.Checked = True
            TextNcarte.Text = "111111111111111111111"
            TextInstitution.Text = "Td canada"
            TextDateEXPIRATION.Text = "01/01/2022"
            ComboTypeCarte.Text = "Visa"
        End If
    End Sub
    'Boutton Enregistrer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'les information
        If MntPayer.Text = "" Then
            MsgBox("Veuillez Entrer le Montant Payer", vbOKOnly, "Erreur")
            MntPayer.Select()
        ElseIf DatePaiement.Text = "" Then
            MsgBox("Veuillez Entrer la date de paiement", vbOKOnly, "Erreur")
            DatePaiement.Select()
        Else
            MsgBox("   1 Enregistremnt est ajouté ", vbOKOnly, "Validation")
        End If
    End Sub
    ' boutton Annuler
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("Annulation de l'enregitrement des données", vbOKOnly + vbInformation, "Annulation")
    End Sub

    Private Sub Paiement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Desactiver les champs
        GroupFacture.Enabled = False
        GroupInformation.Enabled = False
        GroupPaaiement.Enabled = False
        GroupType.Enabled = False
        GroupMENU.Enabled = False
        GroupeCartecredit.Enabled = False
        Groupcheque.Enabled = False
        GroupRetrait.Enabled = False


    End Sub

    Sub effacer()
        'Effacer les données

        'les information
        DateFacture.Text = ""
        numPaiement.Text = ""
        NomClient.Text = ""
        Montantapayer.Text = ""
        'Paiement
        MntPayer.Text = ""
        DatePaiement.Text = ""
        Balance.Text = ""
        'Type de paiement carte credit
        TextNcarte.Text = ""
        TextDateEXPIRATION.Text = ""
        ComboTypeCarte.Text = ""
        'cheque bancaire
        TextNcheque.Text = ""
        TextInstitution.Text = ""
        TextDateCheque.Text = ""
        'Retrait automatique
        TextNcompte.Text = ""
        Combotypecompte.Text = ""


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        effacer()
        GroupFacture.Enabled = True
        NumFacture.Select()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        effacer()
        MntPayer.Select()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        effacer()
        If MsgBox("Voulez-Vous Vraiment Supprimer ce paiement", MsgBoxStyle.YesNo + vbQuestion, "Paiement") = MsgBoxResult.Yes Then
            effacer()
            MsgBox("1 Enregistrement est effacé")
            GroupInformation.Enabled = False
            GroupPaaiement.Enabled = False
            GroupType.Enabled = False
        End If
    End Sub

    Private Sub GroupType_Enter(sender As Object, e As EventArgs) Handles GroupType.Enter

    End Sub
End Class