Imports System.Net.Mail


Public Class FrmCreer
    ' On definit la connexionString qui contient l'information a utiliser pour ouvrir la connexion
    Dim objCnn As New System.Data.OleDb.OleDbConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zaoua\Desktop\SGARI-Projet\SGARI-Projet\SGARI-Projet\SGARI.mdf;Integrated Security=True")


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxTypeClient.SelectedIndexChanged
        ' Nous mettons en gris les cases qui ne peuvent pas être remplies en fonction du choix du type de client
        Select Case CmbBoxTypeClient.Text
            Case "Particulier"
                TxtBoxRaisonSociale.Enabled = False
                TxtBoxNomResponsable.Enabled = False
                TxtBoxNumEmploye.Enabled = False
                TxtBoxNas.Enabled = True
            Case "Employe"
                TxtBoxRaisonSociale.Enabled = False
                TxtBoxNomResponsable.Enabled = False
                TxtBoxNumEmploye.Enabled = True
                TxtBoxNas.Enabled = False
            Case "Entreprise"
                TxtBoxRaisonSociale.Enabled = True
                TxtBoxNomResponsable.Enabled = True
                TxtBoxNumEmploye.Enabled = False
                TxtBoxNas.Enabled = False
        End Select

    End Sub

    'Procédure permettant de fermer la fenêtre FrmCreer 
    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Close()
    End Sub

    'Procédure permettant d'envoyer un courriel
    Private Sub BtnCourriel_Click(sender As Object, e As EventArgs) Handles BtnCourriel.Click
        Dim EmailMessage As New MailMessage()
        Try
            EmailMessage.From = New MailAddress("uqosgari@gmail.com")
            EmailMessage.To.Add("uqosgari@gmail.com")
            EmailMessage.Subject = "Votre abonnent à SGARI"
            EmailMessage.Body = "Cher client, Voici les informations concernant votre abonnement"

            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("uqosgari@gmail.com", "Uqovb2018*")
            SMTP.Send(EmailMessage)

        Catch ex As Exception

        End Try
        MessageBox.Show("Le courriel a bien été envoyé", "Message de SGARI", MessageBoxButtons.OK, MessageBoxIcon.None)

    End Sub

    'Procédure permettant d'insérer un client et son contrat dans la base de données
    Private Sub BtnCreer_Click(sender As Object, e As EventArgs) Handles BtnCreer.Click

        ' Déclaration des variables qui seront utilisées pour ls base de données
        Dim strTypeClient, strNom, strPrenom, strAdresse, strTelephone, strTelecopie, strNas, strNumEmploye, strRaisonSociale, strNomResponsable As String
        Dim strTypeContrat, strDateOuverture, strDateMiseEnVigueur, strDateFermeture, strLocationEquipement, strServices As String
        Dim intNumClient, intNumContrat As Integer

        ' Affectation de données aux variables de la base de données
        strTypeClient = CmbBoxTypeClient.Text
        strNom = TxtBoxNom.Text
        strPrenom = TxtBoxPrenom.Text
        strAdresse = TxtBoxAdresse.Text
        strTelephone = TxtBoxTelphone.Text
        strTelecopie = TxtBoxTelecopieur.Text
        strNas = TxtBoxNas.Text
        strNumEmploye = TxtBoxNumEmploye.Text
        strRaisonSociale = TxtBoxRaisonSociale.Text
        strNomResponsable = TxtBoxRaisonSociale.Text
        strTypeContrat = CmbBoxTypeContrat.Text
        strDateOuverture = DTPickerDateOuverture.Value.ToString
        strDateMiseEnVigueur = DTPickerDateMiseEnVigueur.Value.ToString
        strDateFermeture = DateAdd("YYYY", 1, strDateOuverture)
        strLocationEquipement = CmbBoxLocation.Text
        strServices = CmbBoxService.Text

        'Si TxtBoxNom et CmbBoxTypeClient sont vide, le programme renvoi un message d'erreur
        'While TxtBoxNom.Text <> "" Or CmbBoxTypeClient.Text <> ""
        '    'Message d'erreur envoyé en cas de non remplissage des champs indispensables pour la création du contrat
        '    MessageBox.Show("Vérifier le type de Client et/ou le nom du client", "Message de SGARI", MessageBoxButtons.OK, MessageBoxIcon.Error)


        'End While


        Try
                'Définition des objets Commandes et des String qui seront utilisées dans la base de données
                Dim objCmd As New System.Data.OleDb.OleDbCommand
                Dim strSQLClient, strSQLContrat As String
                objCmd.CommandType = System.Data.CommandType.Text

                'Ouverture de la connexion
                objCnn.Open()

                ' Récupération du dernier enregistrement dans la base de données auquel nous ajoutons 1 et nous l'affichons
                strSQLClient = "SELECT MAX(NumClient) as 'NumClient' FROM Client"
                objCmd = New OleDb.OleDbCommand(strSQLClient, objCnn)
                objCmd.Connection = objCnn
                objCmd.ExecuteNonQuery()
                intNumClient = Convert.ToInt32(objCmd.ExecuteScalar()) + 1
                LblAfficheNumClient.Text = intNumClient.ToString

                strSQLContrat = "SELECT MAX(NumContrat) as 'NumContrat' FROM Contrat"
                objCmd = New OleDb.OleDbCommand(strSQLContrat, objCnn)
                objCmd.Connection = objCnn
                objCmd.ExecuteNonQuery()
                intNumContrat = Convert.ToInt32(objCmd.ExecuteScalar()) + 1
                LblAfficheNumContrat.Text = intNumContrat.ToString

                ' Boite de message affichant que l'enregistrement est en cours. Elle permet aussi de pouvoir voir le numéro client 
                MessageBox.Show("Ajout du client en cours. Cliquez sur ok pour continuer", "Message de SGARI", MessageBoxButtons.OK)

                ' Choix et exécution de la requête 1 dans les sous tables héritées Particulier Employé et Entreprise
                If CmbBoxTypeClient.Text = "Particulier" Then
                    objCmd.CommandText = "INSERT INTO particulier (Numclient, Typeclient, Adresse, Telephone, Telecopieur, nas, Nomparticulier, PrenomParticulier) 
                                                    VALUES ('" & intNumClient & "','" & strTypeClient & "','" & strAdresse & "','" & strTelephone & "','" & strTelecopie & "','" & strNas & "','" & strNom & "','" & strPrenom & "')"
                ElseIf CmbBoxTypeClient.Text = "Employe" Then
                    objCmd.CommandText = "INSERT INTO Employe (Numclient, Typeclient, Adresse, Telephone, Telecopieur, Numemploye, Nomemploye, PrenomEmploye) 
                                                    VALUES ('" & intNumClient & "','" & strTypeClient & "','" & strAdresse & "','" & strTelephone & "','" & strTelecopie & "','" & strNumEmploye & "','" & strNom & "','" & strPrenom & "')"
                ElseIf CmbBoxTypeClient.Text = "Entreprise" Then
                    objCmd.CommandText = "INSERT INTO Entreprise (Numclient, Typeclient, Adresse, Telephone, Telecopieur, NomCompagnie, NomResponsable) 
                                                    VALUES ('" & intNumClient & "','" & strTypeClient & "','" & strAdresse & "','" & strTelephone & "','" & strTelecopie & "','" & strRaisonSociale & "','" & strNomResponsable & "')"
                Else
                    MessageBox.Show("Le choix du type de client est obligatoire", "Message de SGARI", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                objCmd.Connection = objCnn
                objCmd.ExecuteNonQuery()

                ' Exécution de la requête 2 dans la table Client
                objCmd.CommandText = "INSERT INTO Client (Numclient, Typeclient, Adresse, Telephone, Telecopieur) VALUES ('" & intNumClient & "','" & strTypeClient & "','" & strAdresse & "','" & strTelephone & "','" & strTelecopie & "')"
                objCmd.ExecuteNonQuery()

                ' Exécution de la requête 3 dans la table Contrat
                objCmd.CommandText = "INSERT INTO Contrat (Numcontrat, Typecontrat, DateOuverture, DateFermeture, LocationEquipement, Services, Datemiseenvigueur) 
                                            VALUES ('" & intNumContrat & "','" & strTypeContrat & "','" & strDateOuverture & "','" & strDateFermeture & "','" & strLocationEquipement & "','" & strServices & "','" & strDateMiseEnVigueur & "')"
                objCmd.ExecuteNonQuery()


                ' Exécution de la requête 4 dans la table Souscrit
                objCmd.CommandText = "INSERT INTO Souscrit (Numclient, Numcontrat) VALUES ('" & intNumClient & "','" & intNumContrat & "')"
                objCmd.ExecuteNonQuery()

                ' Fermeture de la base de données
                objCnn.Close()
            Catch
            ' Message signalant l'échec de l'enregistrement du contrat et du client
            'MessageBox.Show("Impossible de procéder à l'ajout à la base de données", "Message de SGARI", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


            ' Confirmation de l'enregistrement
            MessageBox.Show("L'abonnement a bien été enregistré ", "Message de SGARI", MessageBoxButtons.OK, MessageBoxIcon.None)

            'Nous effaçons les boites de saisie
            EffacerTxtBx()

            'Nous réaffichons les numéros de contrat et de client
            NumCntCli()


    End Sub

    ' Procédure d'effacement des textbox et autres 
    Sub EffacerTxtBx()

        CmbBoxTypeClient.ResetText()
        CmbBoxTypeContrat.ResetText()
        CmbBoxLocation.ResetText()
        CmbBoxService.ResetText()
        CmbBoxRaccord.ResetText()
        LblAfficheNumClient.ResetText()
        LblAfficheNumContrat.ResetText()
        TxtBoxNom.Clear()
        TxtBoxPrenom.Clear()
        TxtBoxAdresse.Clear()
        TxtBoxTelphone.Clear()
        TxtBoxTelecopieur.Clear()
        TxtBoxNumEmploye.Clear()
        TxtBoxNas.Clear()
        TxtBoxRaisonSociale.Clear()
        TxtBoxNomResponsable.Clear()
        TxtBoxPaiement.Clear()
        CBoxAnnee.Checked = False
        CBoxMois.Checked = False

    End Sub

    'Procédure d'impression
    Private Sub BtnImprimer_Click(sender As Object, e As EventArgs) Handles BtnImprimer.Click

        Dim resultat As String
        resultat = PrintDialog1.ShowDialog
        Select Case resultat
            Case 1
                MsgBox("Les documents sont envoyés a l'imprimante avec succés", vbOK + vbInformation, "Impression du document")
            Case 2
                MsgBox("L'impression a ete annulée", vbOK + vbInformation, "Impression du document")
        End Select

    End Sub

    'Procédure d'affichage du numéro du client et du contrat
    Sub NumCntCli()
        Dim intNumClient, intNumContrat As Double
        Try
            Dim objCmd As New System.Data.OleDb.OleDbCommand
            Dim strSQLClient, strSQLContrat As String
            objCmd.CommandType = System.Data.CommandType.Text
            objCnn.Open()
            ' Récupération du dernier enregistrement dans la base de données auquel nous ajoutons 1 et nous l'affichons
            strSQLClient = "SELECT MAX(NumClient) as 'intNumClient' FROM Client"
            objCmd = New OleDb.OleDbCommand(strSQLClient, objCnn)
            objCmd.Connection = objCnn
            objCmd.ExecuteNonQuery()
            intNumClient = Convert.ToInt32(objCmd.ExecuteScalar()) + 1
            LblAfficheNumClient.Text = intNumClient.ToString
            intNumClient = Val(intNumClient)
            strSQLContrat = "SELECT MAX(NumContrat) as 'NumContrat' FROM Contrat"
            objCmd = New OleDb.OleDbCommand(strSQLContrat, objCnn)
            objCmd.Connection = objCnn
            objCmd.ExecuteNonQuery()
            intNumContrat = Convert.ToInt32(objCmd.ExecuteScalar()) + 1
            intNumContrat = Val(intNumContrat)
            LblAfficheNumContrat.Text = intNumContrat.ToString
            objCnn.Close()
        Catch
        End Try
    End Sub

    'Au chargement de la page, Nous mettons par defaut dans Type de contrat actif
    Private Sub FrmCreer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TabContrat() As String = {"Actif", "Inactif"}
        CmbBoxTypeContrat.DataSource = TabContrat
        NumCntCli()
    End Sub

    'Procédure de vérification et de calcul du montant payable mensuellement ou annuellement 
    Private Sub CBoxMois_CheckedChanged(sender As Object, e As EventArgs) Handles CBoxMois.CheckedChanged
        Dim CoutPaiement As Decimal
        Dim intLocation, intService, intRaccord As Decimal

        If CmbBoxLocation.Text = "$ 6 - Location HP" Then
            intLocation = 6
        ElseIf CmbBoxLocation.Text = "$ 5 - Location Cisco" Then
            intLocation = 5
        End If

        If CmbBoxService.Text = "$ 50 - Installation" Then
            intService = 50
        ElseIf CmbBoxService.Text = "$ 20 - Entretien" Then
            intService = 20
        ElseIf CmbBoxService.Text = "$ 60 - Déménagement" Then
            intService = 60
        End If

        If CmbBoxRaccord.Text = "$ 0 - Pas de raccordement" Then
            intRaccord = 0
        ElseIf CmbBoxRaccord.Text = "$ 45 - Raccordement requis" Then
            intRaccord = 45
        End If

        If CBoxMois.Checked = True Then
            If CmbBoxRaccord.Text <> "Choix de l'équipement" And CmbBoxService.Text <> "Choix du service" And CmbBoxLocation.Text <> "Besoin ou pas" Then
                CBoxAnnee.Checked = False
                CoutPaiement = (intLocation + ((intService + intRaccord) / 12))
                TxtBoxPaiement.Text = String.Format("{0:C}", CoutPaiement)
            Else
                CBoxAnnee.Checked = False
                CBoxMois.Checked = False
                MessageBox.Show("Veuillez réviser vos choix", "Information requise manquante", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub CBoxAnnee_CheckedChanged(sender As Object, e As EventArgs) Handles CBoxAnnee.CheckedChanged
        Dim CoutPaiement As Decimal
        Dim intLocation, intService, intRaccord As Decimal

        If CmbBoxLocation.Text = "$ 6 - Location HP" Then
            intLocation = 6
        ElseIf CmbBoxLocation.Text = "$ 5 - Location Cisco" Then
            intLocation = 5
        End If

        If CmbBoxService.Text = "$ 50 - Installation" Then
            intService = 50
        ElseIf CmbBoxService.Text = "$ 20 - Entretien" Then
            intService = 20
        ElseIf CmbBoxService.Text = "$ 60 - Déménagement" Then
            intService = 60
        End If

        If CmbBoxRaccord.Text = "$ 0 - Pas de raccordement" Then
            intRaccord = 0
        ElseIf CmbBoxRaccord.Text = "$ 45 - Raccordement requis" Then
            intRaccord = 45
        End If

        If CBoxAnnee.Checked = True Then
            If CmbBoxRaccord.Text <> "Choix de l'équipement" And CmbBoxService.Text <> "Choix du service" And CmbBoxLocation.Text <> "Besoin ou pas" Then
                CBoxMois.Checked = False
                CoutPaiement = (intLocation * 12) + (intService + intRaccord)
                TxtBoxPaiement.Text = String.Format("{0:C}", CoutPaiement)
            Else
                CBoxAnnee.Checked = False
                CBoxMois.Checked = False
                MessageBox.Show("Veuillez réviser vos choix", "Information requise manquante", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub TxtBoxAdresse_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxAdresse.TextChanged

    End Sub
End Class

