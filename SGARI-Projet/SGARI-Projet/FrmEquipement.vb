Option Explicit On

Public Class FrmEquipement
    'on utilise la variable choix pour completer le message si l'utilisateur a choisi la touche Annuler
    Dim choix As String = ""
    'cette variable pour le code d'equipement
    Dim VarCodeEquipement As String
    Dim VarVerifier As Boolean = False
    Private Sub FrmEquipement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Titre.Text = "Gestion des Équipement"
        'Appel le procedure DesactiverChamps pour  Desactiver les champs de saise
        DesactiverChamp()
        'Appel le procedure pour cacher le menu opération (Enregistrer et Annuler
        operationMenu()
        'Desactiver Date de retour et Commentaire pour retour
        GroupRetour.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles ButtonClendar.Click
        Calendar1.Visible = True

    End Sub

    Private Sub Calendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Calendar1.DateChanged
        DateAcquisition.Text = Calendar1.SelectionRange.Start.Date.ToShortDateString()
        Calendar1.Visible = False
    End Sub

    Private Sub Calendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles Calendar1.DateSelected
        DateAcquisition.Text = Calendar1.SelectionRange.Start.Date.ToShortDateString()
    End Sub

    Private Sub Calendar1_Click(sender As Object, e As EventArgs) Handles Calendar1.Click
        DateAcquisition.Text = Calendar1.SelectionRange.Start.Date.ToShortDateString()
        Calendar1.Visible = False
    End Sub



    Private Sub Calendar2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles Calendar2.DateChanged
        DateMiseService.Text = Calendar2.SelectionRange.Start.Date.ToShortDateString()
        Calendar2.Visible = False
    End Sub
    Private Sub Calendar2_DateSelected(sender As Object, e As DateRangeEventArgs) Handles Calendar2.DateSelected
        DateMiseService.Text = Calendar2.SelectionRange.Start.Date.ToShortDateString()
        DateMiseService.Select()
    End Sub

    Private Sub Calendar2_Click(sender As Object, e As EventArgs) Handles Calendar2.Click
        DateMiseService.Text = Calendar2.SelectionRange.Start.Date.ToShortDateString()
        Calendar2.Visible = False
        TxtMarque.Select()
    End Sub

    Private Sub ButtonAjout_Click(sender As Object, e As EventArgs) Handles ButtonAjout.Click
        ButtonAjout.Enabled = False
        ButtonRetour.Enabled = False
        ButtonModifier.Enabled = False
        ButtonConsulter.Enabled = False
        ButtonMajType.Enabled = False
        ButtonQuitter.Enabled = False

        'Activer et Effacer les champs pour une nouvelle saisie
        ActiverChamp()
        Effacer()
        'Visualier le Menu Enregistrer et Annuleer
        GroupBox6.Visible = True
        '  Ajout Équipement
        choix = "Nouvelle Enregistrement"
        Titre.Text = Titre.Text & "/" & choix
        TxtCode.Select()
    End Sub
    Sub Effacer()
        TxtCode.Text = ""
        TxtNom.Text = ""
        TxtFamille.Text = ""
        ComboType.Text = ""
        TxtDesignation.Text = ""
        TxtEtat.Text = ""
        TxtPrix.Text = ""
        Txtreel.Text = ""
        TxtStock.Text = ""
        TxtFrs.Text = ""
        DateAcquisition.Text = ""
        DateMiseService.Text = ""
        TxtMarque.Text = ""
        TxtConstructeur.Text = ""
    End Sub
    'Desactiver les champs de saisie
    Sub DesactiverChamp()
        TxtCode.Enabled = False
        TxtNom.Enabled = False
        TxtFamille.Enabled = False
        ComboType.Enabled = False
        TxtDesignation.Enabled = False
        TxtEtat.Enabled = False
        TxtPrix.Enabled = False
        Txtreel.Enabled = False
        TxtStock.Enabled = False
        TxtFrs.Enabled = False
        ' DateAcquisition.Enabled = False
        ' DateMiseService.Enabled = False
        TxtMarque.Enabled = False
        TxtConstructeur.Enabled = False
    End Sub
    'Activer les champs de saisie
    Sub ActiverChamp()
        TxtCode.Enabled = True
        TxtNom.Enabled = True
        TxtFamille.Enabled = True
        ComboType.Enabled = True
        TxtDesignation.Enabled = True
        TxtEtat.Enabled = True
        TxtPrix.Enabled = True
        Txtreel.Enabled = True
        TxtStock.Enabled = True
        TxtFrs.Enabled = True
        TxtMarque.Enabled = True
        TxtConstructeur.Enabled = True
    End Sub
    Sub ActiverMenu()
        ButtonAjout.Enabled = True
        ButtonRetour.Enabled = True
        ButtonModifier.Enabled = True
        ButtonConsulter.Enabled = True
        ButtonMajType.Enabled = True
        ButtonQuitter.Enabled = True
    End Sub
    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Me.Close()
    End Sub

    Private Sub ButtonRetour_Click(sender As Object, e As EventArgs) Handles ButtonRetour.Click
        VarCodeEquipement = InputBox("Entrer le code Équipement a retourner", "Retour d'un équipement")
        If (Trim(LTrim(VarCodeEquipement))) <> "" Then
            recherche()
            GroupRetour.Enabled = True
            'Visualiser Menu Opération (Enregistrer,Annuler)
            GroupBox6.Visible = True
            'Pose le curseur sur Date de retoir
            DateRetour.Select()
        End If
    End Sub
    Sub recherche()
        Select Case VarCodeEquipement
            Case 1
                TxtCode.Text = VarCodeEquipement
                TxtNom.Text = "Ordinateur Personnel"
                TxtFamille.Text = "HelpProvider personnel"
                ComboType.Text = "Ordsinateur"
                TxtDesignation.Text = "Ordinateur personnel 5 i"
                TxtEtat.Text = "Neuf"
                TxtPrix.Text = "800"
                Txtreel.Text = "1300"
                TxtStock.Text = "10"
                TxtFrs.Text = "BEST BUY"
                DateAcquisition.Text = "01/01/2017"
                DateMiseService.Text = "15/03/2018"
                TxtMarque.Text = "DTX 300"
                TxtConstructeur.Text = "HP"
        End Select
    End Sub
    Sub operationMenu()
        'Cacher le menu Enregistrer . Annuler
        GroupBox6.Visible = False
    End Sub
    Private Sub ButtonDateEnservice_Click(sender As Object, e As EventArgs) Handles ButtonDateEnservice.Click
        Calendar2.Visible = True
    End Sub

    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        If MsgBox("Voulez-Vous Vraiment Annuler " & choix, MsgBoxStyle.YesNo + vbQuestion, "SGARI") = MsgBoxResult.Yes Then
            Effacer()
            DesactiverChamp()
            Titre.Text = "Gestion des Équipements"
            MenuActiver()
            'Ccher lenu opération
            GroupBox6.Visible = False
        End If
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click

        'appel Procedure pour verifier Remplisage des champs de saisie
        verifierSaisie()
        'Si tous les champs de saisie ont bien rempli ,faire sauvegader les données dana la table
        If VarVerifier = True Then
            MsgBox("L'opération (Enregistrer) est bien effectué", MsgBoxStyle.OkOnly + vbInformation, "Gestion des équipements")
        End If
    End Sub
    'Procedure pour verifier Remplisage des champs de saisie
    Sub verifierSaisie()
        If TxtCode.Text = "" Then
            MsgBox("Veuillez Entrer le code de l'equipement", vbOKOnly, "Erreur")

        ElseIf TxtNom.Text = "" Then
            MsgBox("Veuillez Entrer le Nom de l'equipement", vbOKOnly, "Erreur")

        ElseIf TxtFamille.Text = "" Then
            MsgBox("Veuillez Entrer la Famille de l'article", vbOKOnly, "Erreur")

        ElseIf ComboType.Text = "" Then
            MsgBox("Veuillez Entrer le code de l'equipement", vbOKOnly, "Erreur")

        ElseIf TxtDesignation.Text = "" Then
            MsgBox("Veuillez Entrer la designation", vbOKOnly, "Erreur")

        ElseIf TxtEtat.Text = "" Then
            MsgBox("Veuillez Entrer l'etat de l'equipement", vbOKOnly, "Erreur")

        ElseIf TxtPrix.Text = "" Then
            MsgBox("Veuillez Entrer le Prix de location", vbOKOnly, "Erreur")

        ElseIf Txtreel.Text = "" Then
            MsgBox("Veuillez Entrer le Prix Réel", vbOKOnly, "Erreur")

        ElseIf TxtStock.Text = "" Then
            MsgBox("Veuillez Entrer le Stock disponible", vbOKOnly, "Erreur")

        ElseIf TxtFrs.Text = "" Then
            MsgBox("Veuillez Entrer le Fournisseur", vbOKOnly, "Erreur")

        ElseIf DateAcquisition.Text = "" Then
            MsgBox("Veuillez Entrer la date d'acquisition", vbOKOnly, "Erreur")

        ElseIf DateMiseService.Text = "" Then
            MsgBox("Veuillez Entrer la date de mise en service", vbOKOnly, "Erreur")

        ElseIf TxtMarque.Text = "" Then
            MsgBox("Veuillez Entrer la Marque", vbOKOnly, "Erreur")

        ElseIf TxtConstructeur.Text = "" Then
            MsgBox("Veuillez Entrer le constructeur", vbOKOnly, "Erreur")
        Else
            varVerifier = True
        End If
    End Sub

    Private Sub ButtonModifier_Click(sender As Object, e As EventArgs) Handles ButtonModifier.Click
        'desactiver le menu
        ButtonAjout.Enabled = False
        ButtonRetour.Enabled = False
        ButtonModifier.Enabled = False
        ButtonConsulter.Enabled = False
        ButtonMajType.Enabled = False
        ButtonQuitter.Enabled = False
        '----------------------------
        'InputBox pour demander le code Équipement
        VarCodeEquipement = InputBox("Entrer le code Équipement a Modifier", "Modification Équipement")
        If (Trim(LTrim(VarCodeEquipement))) <> "" Then
            'Chercher le code et Extraire les données
            recherche()
            GroupBox6.Visible = True
            'Activer les champs
            ActiverChamp()
        TxtCode.Enabled = False
            TxtNom.Select()
        End If
    End Sub



    Private Sub ButtonConsulter_Click(sender As Object, e As EventArgs) Handles ButtonConsulter.Click
        'desactiver le menu
        ButtonAjout.Enabled = False
        ButtonRetour.Enabled = False
        ButtonModifier.Enabled = False
        ButtonConsulter.Enabled = False
        ButtonMajType.Enabled = False
        ButtonQuitter.Enabled = False
        VarCodeEquipement = InputBox("Entrer le code Équipement a Supprimer", "Supprimer Équipement")
        If (Trim(LTrim(VarCodeEquipement))) <> "" Then
            'Chercher le code et Extraire les données
            recherche()

            If MsgBox("Voulez-Vous Vraiment Supprimer ce paiement", MsgBoxStyle.YesNo + vbQuestion, "Paiement") = MsgBoxResult.Yes Then
                Effacer()
                MsgBox(" 1 Enregistrement est supprimer")
            End If
        End If
        MenuActiver()
    End Sub

    Private Sub ButtonMajType_Click(sender As Object, e As EventArgs) Handles ButtonMajType.Click

        FrmTypeEquip.Show()

    End Sub

    Sub MenuActiver()
        ButtonAjout.Enabled = True
        ButtonRetour.Enabled = True
        ButtonModifier.Enabled = True
        ButtonConsulter.Enabled = True
        ButtonMajType.Enabled = True
        ButtonQuitter.Enabled = True
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub
End Class