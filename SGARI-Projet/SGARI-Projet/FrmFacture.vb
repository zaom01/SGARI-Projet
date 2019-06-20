
Public Class FrmFacture
    Dim vartext As Double
    Dim Vartotalht As Double = 0
    'VERIFIER SI TOUS LES CHAMPS SONT REMPLIS
    Dim varVerifier As Boolean = False
    ' UTILISER POUR RECOUPERER LE CODE DA FACTURE DANS 
    Dim ModifNumFacture As String
    'SELECTION DANS DARAGRIDVIEW
    Dim Varoption As String
    'Montant de sous total a modifier et faire soustraire du montant HT
    Dim montantModif As Double
    Private Sub FrmFacture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DESACTIVER LES CHAMPS
        Desactiver()
        'VISUALISER LE MENU 
        GroupMenu.Enabled = True
        'INITIALISER LES TAXES
        TauxTPS.Text = TaxeTPS
        TauxTVQ.Text = TaxeTVQ
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim VarMontantTVQ As Integer
        Dim VarMontantTPS As Integer

        vartext = Val(QuantiteCmd.Text) * Val(prixunitaire.Text)
        soustotal.Text = vartext

        verifierSaisie()
        If varVerifier = True And Varoption = "A" Then
            LigneCommande.Rows.Add(RefPrd.Text, Designation.Text, QuantiteCmd.Text, prixunitaire.Text, soustotal.Text)
            Vartotalht = Vartotalht + vartext
            VarMontantTPS = Vartotalht * TaxeTPS / 100
            VarMontantTVQ = Vartotalht * TaxeTVQ / 100
            MontantHT.Text = Vartotalht
            MontantTPS.Text = VarMontantTPS
            MontantTVQ.Text = VarMontantTVQ
            TOTALTTC.Text = Vartotalht + VarMontantTPS + VarMontantTVQ
        ElseIf varVerifier = True And Varoption = "M" Then
            ' LigneCommande.Rows.Insert(RefPrd.Text, Designation.Text, QuantiteCmd.Text, prixunitaire.Text, soustotal.Text)
            Vartotalht = (Vartotalht + vartext) - montantModif
            VarMontantTPS = Vartotalht * TaxeTPS / 100
            VarMontantTVQ = Vartotalht * TaxeTVQ / 100
            Varoption = "A"
        End If
    End Sub
    Sub verifierSaisie()
        If RefPrd.Text = "" Then
            MsgBox("Veuillez Entrer Réference Produit", vbOKOnly, "Erreur")
            RefPrd.Select()
        ElseIf Designation.Text = "" Then
            MsgBox("Veuillez Entrer la Désignation", vbOKOnly, "Erreur")
            Designation.Select()
        ElseIf QuantiteCmd.Text = "" Then
            MsgBox("Veuillez Entrer la Quantité Commandée", vbOKOnly, "Erreur")
            QuantiteCmd.Select()
        ElseIf prixunitaire.Text = "" Then
            MsgBox("Veuillez Entrer le Prix Unitaire", vbOKOnly, "Erreur")
            prixunitaire.Select()
        Else
            varVerifier = True
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        AdresseLiv.Text = AdresseFact.Text
        VilleLiv.Text = VilleFact.Text
        MaskedTelLiv.Text = MaskedTelFact.Text
    End Sub
    Sub Activer()
        GroupIDFacture.Enabled = True
        'GroupFacturation.Enabled = False
        GroupLivraison.Enabled = True
        GrouplineCommande.Enabled = True
        ' GroupPiedFact.Enabled = False
        GroupReglement.Enabled = True
        Valider.Enabled = True
        Annuler.Enabled = True
    End Sub
    Sub Desactiver()
        GroupIDFacture.Enabled = False
        GroupFacturation.Enabled = False
        GroupLivraison.Enabled = False
        GrouplineCommande.Enabled = False
        GroupPiedFact.Enabled = False
        GroupReglement.Enabled = False
        '  GroupMenu.Enabled = False
        Valider.Enabled = False
        Annuler.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Activer()
        cleardonnées()
        GroupMenu.Enabled = False
        TauxTPS.Text = TaxeTPS
        TauxTVQ.Text = TaxeTVQ
        'INITIALISER VAOPTION A INSERER UNE LIGNE DANS DATAGRID
        Varoption = "A"
        NumFacture.Select()
    End Sub


    Private Sub Valider_Click(sender As Object, e As EventArgs) Handles Valider.Click
        If NumFacture.Text = "" Then
            MsgBox("Veuillez Entrer le numero de facture", vbOKOnly, "Erreur")
            NumFacture.Select()
        ElseIf DateFacture.Text = "" Then
            MsgBox("Veuillez Entrer la date Facture de facture", vbOKOnly, "Erreur")
            DateFacture.Select()
        ElseIf codeclient.Text = "" Then
            MsgBox("Veuillez Entrer la date Facture de facture", vbOKOnly, "Erreur")
            CodeClient.Select()
        ElseIf CodeContrat.Text Then
            MsgBox("Veuillez Entrer la date Facture de facture", vbOKOnly, "Erreur")
            CodeContrat.Select()
        ElseIf RefPrd.Text = "" Then
            MsgBox("Veuillez Entrer Réference Produit", vbOKOnly, "Erreur")
                RefPrd.Select()
            ElseIf Designation.Text = "" Then
                MsgBox("Veuillez Entrer la Désignation", vbOKOnly, "Erreur")
                Designation.Select()
            ElseIf QuantiteCmd.Text = "" Then
                MsgBox("Veuillez Entrer la Quantité Commandée", vbOKOnly, "Erreur")
                QuantiteCmd.Select()
            ElseIf prixunitaire.Text = "" Then
                MsgBox("Veuillez Entrer le Prix Unitaire", vbOKOnly, "Erreur")
                prixunitaire.Select()
            Else
                MsgBox("   1 Enregistremnt est ajouté ", vbOKOnly, "Validation")
            GroupMenu.Enabled = True
            Desactiver()
            Valider.Enabled = False
            Annuler.Enabled = False
        End If
    End Sub

    Private Sub Annuler_Click(sender As Object, e As EventArgs) Handles Annuler.Click
        cleardonnées()

        Desactiver()
        Valider.Enabled = False
        Annuler.Enabled = False
        GroupMenu.Enabled = True
    End Sub


    Sub cleardonnées()
        NumFacture.Text = ""
        DateFacture.Text = ""
        CodeClient.Text = ""
        CodeContrat.Text = ""
        AdresseFact.Text = ""
        VilleFact.Text = ""
        MaskedTelFact.Text = ""
        AdresseLiv.Text = ""
        VilleLiv.Text = ""
        MaskedTelLiv.Text = ""
        RefPrd.Text = ""
        Designation.Text = " "
        prixunitaire.Text = ""
        QuantiteCmd.Text = ""
        soustotal.Text = ""
        LigneCommande.Rows.Clear()
        Vartotalht = 0
        MontantHT.Text = ""
        MontantTPS.Text = ""
        MontantTVQ.Text = ""
        TOTALTTC.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonModifier.Click

        'desactiver le menu
        GroupMenu.Enabled = False
        'Button2.Enabled = False
        'ButtonModifier.Enabled = False
        'Buttondel.Enabled = False
        'ButtonTaxe.Enabled = False        '----------------------------
        'InputBox pour demander le code Équipement
        ModifNumFacture = InputBox("Entrer le Numéro de la Facture a Modifier", "Modification Facture")
        If (Trim(LTrim(ModifNumFacture))) <> "" Then
            'Chercher le Numéro et Extraire les données
            recherche()
            'Activer les champs
            Activer()
            NumFacture.Enabled = False
            NumFacture.Select()
        End If

    End Sub
    Sub recherche()
        Select Case ModifNumFacture
            Case 1
                NumFacture.Text = "0000001"
                DateFacture.Text = "01/01/2018"
                CodeClient.Text = "1"
                CodeContrat.Text = "1"
                AdresseFact.Text = "128 Boulevard Saint Joseph"
                VilleFact.Text = "Gatineau"
                MaskedTelFact.Text = "8195852124"
                AdresseLiv.Text = "55 carlign avenue"
                VilleLiv.Text = "Ottawa"
                MaskedTelLiv.Text = "6163555333"
                LigneCommande.Rows.Add("HPvDeski5", "Ordinateur portable, RAM 1tr", "2", "1200", "2400")
                MontantHT.Text = "2400"
                MontantTPS.Text = "120"
                MontantTVQ.Text = "239.4"
                TOTALTTC.Text = "2759"

        End Select


    End Sub

    Private Sub Buttondel_Click(sender As Object, e As EventArgs) Handles Buttondel.Click

        'desactiver le menu
        GroupMenu.Enabled = False

        'InputBox pour demander le code Équipement
        ModifNumFacture = InputBox("Entrer le Numéro de la Facture a Spprimer", "Supprission Facture")
        If (Trim(LTrim(ModifNumFacture))) <> "" Then
            'Chercher le Numéro et Extraire les données
            recherche()
            'Activer les champs
            If MsgBox("Voulez-Vous Vraiment supprimer cette facture", MsgBoxStyle.YesNo + vbQuestion, "SGARI") = MsgBoxResult.Yes Then
                cleardonnées()
                MsgBox("   1 Enregistremnt est supprime ", vbOKOnly, "Suppression")
            End If

        End If

    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click
        Dim resultat As String
        resultat = PrintDialog1.ShowDialog
        Select Case resultat
            Case 1
                MsgBox("Les documents sont envoyés a l'imprimante avec succés", vbOK + vbInformation, "Impression du document")
        Case 2
                MsgBox("L'impression a ete annulée", vbOK + vbInformation, "Impression du document")
        End Select
    End Sub

    Private Sub LigneCommande_SelectionChanged(sender As Object, e As EventArgs) Handles LigneCommande.SelectionChanged
        Try
            RefPrd.Text = LigneCommande.CurrentRow.Cells("RefProduit").Value.ToString
            Designation.Text = LigneCommande.CurrentRow.Cells("Désignation").Value.ToString
            QuantiteCmd.Text = LigneCommande.CurrentRow.Cells("Quantité").Value.ToString
            prixunitaire.Text = LigneCommande.CurrentRow.Cells("Prix").Value.ToString
            soustotal.Text = LigneCommande.CurrentRow.Cells("Montant").Value.ToString
            'Ancien Montant
            montantModif = Val(soustotal.Text)
            'AFFECTER (M) A VAROPTION POUR INDIQUER LA MODIFACTION D'UNE LIGNE A DATAGRID
            Varoption = "M"
        Catch
        End Try
    End Sub

    Private Sub ButtonTaxe_Click(sender As Object, e As EventArgs) Handles ButtonTaxe.Click
        Taxes.Show()
    End Sub

    Private Sub GroupPiedFact_Enter(sender As Object, e As EventArgs) Handles GroupPiedFact.Enter

    End Sub

    Private Sub GroupReglement_Enter(sender As Object, e As EventArgs) Handles GroupReglement.Enter

    End Sub

    Private Sub GroupFacturation_Enter(sender As Object, e As EventArgs) Handles GroupFacturation.Enter

    End Sub
End Class