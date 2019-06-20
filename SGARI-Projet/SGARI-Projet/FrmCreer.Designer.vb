<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCreer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LblNumContrat = New System.Windows.Forms.Label()
        Me.LblTypeContrat = New System.Windows.Forms.Label()
        Me.LblDateOuverture = New System.Windows.Forms.Label()
        Me.LblLocation = New System.Windows.Forms.Label()
        Me.LblService = New System.Windows.Forms.Label()
        Me.LblDateMiseEnVigueur = New System.Windows.Forms.Label()
        Me.CmbBoxTypeContrat = New System.Windows.Forms.ComboBox()
        Me.LblPaiementMensuel = New System.Windows.Forms.Label()
        Me.TxtBoxPaiement = New System.Windows.Forms.TextBox()
        Me.GBoxOptionContrat = New System.Windows.Forms.GroupBox()
        Me.CBoxAnnee = New System.Windows.Forms.CheckBox()
        Me.CBoxMois = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbBoxRaccord = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbBoxService = New System.Windows.Forms.ComboBox()
        Me.CmbBoxLocation = New System.Windows.Forms.ComboBox()
        Me.LblAfficheNumContrat = New System.Windows.Forms.Label()
        Me.DTPickerDateMiseEnVigueur = New System.Windows.Forms.DateTimePicker()
        Me.DTPickerDateOuverture = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtBoxNomResponsable = New System.Windows.Forms.TextBox()
        Me.TxtBoxRaisonSociale = New System.Windows.Forms.TextBox()
        Me.TxtBoxNas = New System.Windows.Forms.TextBox()
        Me.TxtBoxNumEmploye = New System.Windows.Forms.TextBox()
        Me.TxtBoxTelecopieur = New System.Windows.Forms.TextBox()
        Me.TxtBoxTelphone = New System.Windows.Forms.TextBox()
        Me.TxtBoxAdresse = New System.Windows.Forms.TextBox()
        Me.TxtBoxPrenom = New System.Windows.Forms.TextBox()
        Me.TxtBoxNom = New System.Windows.Forms.TextBox()
        Me.CmbBoxTypeClient = New System.Windows.Forms.ComboBox()
        Me.LblNomResponsable = New System.Windows.Forms.Label()
        Me.LblRaisonSociale = New System.Windows.Forms.Label()
        Me.LblNas = New System.Windows.Forms.Label()
        Me.LblTelecopieur = New System.Windows.Forms.Label()
        Me.LblNumEmploye = New System.Windows.Forms.Label()
        Me.LblTelephone = New System.Windows.Forms.Label()
        Me.LblAdresse = New System.Windows.Forms.Label()
        Me.LblNom = New System.Windows.Forms.Label()
        Me.LblPrenom = New System.Windows.Forms.Label()
        Me.LblAfficheNumClient = New System.Windows.Forms.Label()
        Me.LblNumClient = New System.Windows.Forms.Label()
        Me.LblTypeClient = New System.Windows.Forms.Label()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.BtnCourriel = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.BtnImprimer = New System.Windows.Forms.Button()
        Me.BtnCreer = New System.Windows.Forms.Button()
        Me.Titre = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.GBoxOptionContrat.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblNumContrat
        '
        Me.LblNumContrat.AutoSize = True
        Me.LblNumContrat.Location = New System.Drawing.Point(602, 49)
        Me.LblNumContrat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNumContrat.Name = "LblNumContrat"
        Me.LblNumContrat.Size = New System.Drawing.Size(144, 20)
        Me.LblNumContrat.TabIndex = 1
        Me.LblNumContrat.Text = "Numéro du Contrat"
        '
        'LblTypeContrat
        '
        Me.LblTypeContrat.AutoSize = True
        Me.LblTypeContrat.Location = New System.Drawing.Point(15, 60)
        Me.LblTypeContrat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTypeContrat.Name = "LblTypeContrat"
        Me.LblTypeContrat.Size = New System.Drawing.Size(119, 20)
        Me.LblTypeContrat.TabIndex = 2
        Me.LblTypeContrat.Text = "Type de contrat"
        '
        'LblDateOuverture
        '
        Me.LblDateOuverture.AutoSize = True
        Me.LblDateOuverture.Location = New System.Drawing.Point(9, 120)
        Me.LblDateOuverture.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDateOuverture.Name = "LblDateOuverture"
        Me.LblDateOuverture.Size = New System.Drawing.Size(127, 20)
        Me.LblDateOuverture.TabIndex = 3
        Me.LblDateOuverture.Text = "Date d'ouverture"
        '
        'LblLocation
        '
        Me.LblLocation.AutoSize = True
        Me.LblLocation.Location = New System.Drawing.Point(602, 120)
        Me.LblLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblLocation.Name = "LblLocation"
        Me.LblLocation.Size = New System.Drawing.Size(158, 20)
        Me.LblLocation.TabIndex = 5
        Me.LblLocation.Text = "Location équipement"
        '
        'LblService
        '
        Me.LblService.AutoSize = True
        Me.LblService.Location = New System.Drawing.Point(602, 172)
        Me.LblService.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblService.Name = "LblService"
        Me.LblService.Size = New System.Drawing.Size(61, 20)
        Me.LblService.TabIndex = 6
        Me.LblService.Text = "Service"
        '
        'LblDateMiseEnVigueur
        '
        Me.LblDateMiseEnVigueur.AutoSize = True
        Me.LblDateMiseEnVigueur.Location = New System.Drawing.Point(9, 169)
        Me.LblDateMiseEnVigueur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDateMiseEnVigueur.Name = "LblDateMiseEnVigueur"
        Me.LblDateMiseEnVigueur.Size = New System.Drawing.Size(180, 20)
        Me.LblDateMiseEnVigueur.TabIndex = 7
        Me.LblDateMiseEnVigueur.Text = "Date de mise en vigueur"
        '
        'CmbBoxTypeContrat
        '
        Me.CmbBoxTypeContrat.FormattingEnabled = True
        Me.CmbBoxTypeContrat.Items.AddRange(New Object() {"Actif", "Inactif"})
        Me.CmbBoxTypeContrat.Location = New System.Drawing.Point(195, 48)
        Me.CmbBoxTypeContrat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbBoxTypeContrat.Name = "CmbBoxTypeContrat"
        Me.CmbBoxTypeContrat.Size = New System.Drawing.Size(180, 28)
        Me.CmbBoxTypeContrat.TabIndex = 15
        '
        'LblPaiementMensuel
        '
        Me.LblPaiementMensuel.AutoSize = True
        Me.LblPaiementMensuel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPaiementMensuel.Location = New System.Drawing.Point(436, 325)
        Me.LblPaiementMensuel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPaiementMensuel.Name = "LblPaiementMensuel"
        Me.LblPaiementMensuel.Size = New System.Drawing.Size(99, 22)
        Me.LblPaiementMensuel.TabIndex = 16
        Me.LblPaiementMensuel.Text = "Paiement "
        '
        'TxtBoxPaiement
        '
        Me.TxtBoxPaiement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxPaiement.Location = New System.Drawing.Point(558, 320)
        Me.TxtBoxPaiement.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxPaiement.Name = "TxtBoxPaiement"
        Me.TxtBoxPaiement.Size = New System.Drawing.Size(180, 28)
        Me.TxtBoxPaiement.TabIndex = 17
        Me.TxtBoxPaiement.Text = "0.00 $"
        Me.TxtBoxPaiement.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GBoxOptionContrat
        '
        Me.GBoxOptionContrat.BackColor = System.Drawing.Color.Transparent
        Me.GBoxOptionContrat.Controls.Add(Me.CBoxAnnee)
        Me.GBoxOptionContrat.Controls.Add(Me.CBoxMois)
        Me.GBoxOptionContrat.Controls.Add(Me.Label2)
        Me.GBoxOptionContrat.Controls.Add(Me.CmbBoxRaccord)
        Me.GBoxOptionContrat.Controls.Add(Me.Label1)
        Me.GBoxOptionContrat.Controls.Add(Me.CmbBoxService)
        Me.GBoxOptionContrat.Controls.Add(Me.CmbBoxLocation)
        Me.GBoxOptionContrat.Controls.Add(Me.LblAfficheNumContrat)
        Me.GBoxOptionContrat.Controls.Add(Me.DTPickerDateMiseEnVigueur)
        Me.GBoxOptionContrat.Controls.Add(Me.DTPickerDateOuverture)
        Me.GBoxOptionContrat.Controls.Add(Me.CmbBoxTypeContrat)
        Me.GBoxOptionContrat.Controls.Add(Me.TxtBoxPaiement)
        Me.GBoxOptionContrat.Controls.Add(Me.LblPaiementMensuel)
        Me.GBoxOptionContrat.Controls.Add(Me.LblDateMiseEnVigueur)
        Me.GBoxOptionContrat.Controls.Add(Me.LblDateOuverture)
        Me.GBoxOptionContrat.Controls.Add(Me.LblService)
        Me.GBoxOptionContrat.Controls.Add(Me.LblTypeContrat)
        Me.GBoxOptionContrat.Controls.Add(Me.LblLocation)
        Me.GBoxOptionContrat.Controls.Add(Me.LblNumContrat)
        Me.GBoxOptionContrat.Location = New System.Drawing.Point(240, 428)
        Me.GBoxOptionContrat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GBoxOptionContrat.Name = "GBoxOptionContrat"
        Me.GBoxOptionContrat.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GBoxOptionContrat.Size = New System.Drawing.Size(1251, 372)
        Me.GBoxOptionContrat.TabIndex = 18
        Me.GBoxOptionContrat.TabStop = False
        Me.GBoxOptionContrat.Text = "Options du contrat"
        '
        'CBoxAnnee
        '
        Me.CBoxAnnee.AutoSize = True
        Me.CBoxAnnee.Location = New System.Drawing.Point(657, 282)
        Me.CBoxAnnee.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBoxAnnee.Name = "CBoxAnnee"
        Me.CBoxAnnee.Size = New System.Drawing.Size(85, 24)
        Me.CBoxAnnee.TabIndex = 27
        Me.CBoxAnnee.Text = "Annuel"
        Me.CBoxAnnee.UseVisualStyleBackColor = True
        '
        'CBoxMois
        '
        Me.CBoxMois.AutoSize = True
        Me.CBoxMois.Location = New System.Drawing.Point(556, 282)
        Me.CBoxMois.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CBoxMois.Name = "CBoxMois"
        Me.CBoxMois.Size = New System.Drawing.Size(95, 24)
        Me.CBoxMois.TabIndex = 26
        Me.CBoxMois.Text = "Mensuel"
        Me.CBoxMois.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(382, 283)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Mode de paiement"
        '
        'CmbBoxRaccord
        '
        Me.CmbBoxRaccord.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBoxRaccord.FormattingEnabled = True
        Me.CmbBoxRaccord.Items.AddRange(New Object() {"$ 0 - Pas de raccordement ", "$ 45 - Raccordement requis"})
        Me.CmbBoxRaccord.Location = New System.Drawing.Point(556, 232)
        Me.CmbBoxRaccord.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbBoxRaccord.Name = "CmbBoxRaccord"
        Me.CmbBoxRaccord.Size = New System.Drawing.Size(250, 30)
        Me.CmbBoxRaccord.TabIndex = 24
        Me.CmbBoxRaccord.Text = "Besoin ou pas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(362, 240)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Frais de raccordement"
        '
        'CmbBoxService
        '
        Me.CmbBoxService.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBoxService.FormattingEnabled = True
        Me.CmbBoxService.Items.AddRange(New Object() {"$ 50 - Installation", "$ 20 - Entretien", "$ 60 - Déménagement"})
        Me.CmbBoxService.Location = New System.Drawing.Point(796, 163)
        Me.CmbBoxService.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbBoxService.Name = "CmbBoxService"
        Me.CmbBoxService.Size = New System.Drawing.Size(180, 30)
        Me.CmbBoxService.TabIndex = 22
        Me.CmbBoxService.Text = "Choix du service"
        '
        'CmbBoxLocation
        '
        Me.CmbBoxLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbBoxLocation.FormattingEnabled = True
        Me.CmbBoxLocation.Items.AddRange(New Object() {"$ 6 - Location HP", "$ 5 - Location Cisco"})
        Me.CmbBoxLocation.Location = New System.Drawing.Point(796, 109)
        Me.CmbBoxLocation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbBoxLocation.Name = "CmbBoxLocation"
        Me.CmbBoxLocation.Size = New System.Drawing.Size(180, 30)
        Me.CmbBoxLocation.TabIndex = 21
        Me.CmbBoxLocation.Text = "Choix de l'équipement"
        '
        'LblAfficheNumContrat
        '
        Me.LblAfficheNumContrat.AutoSize = True
        Me.LblAfficheNumContrat.Location = New System.Drawing.Point(940, 49)
        Me.LblAfficheNumContrat.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAfficheNumContrat.Name = "LblAfficheNumContrat"
        Me.LblAfficheNumContrat.Size = New System.Drawing.Size(21, 20)
        Me.LblAfficheNumContrat.TabIndex = 20
        Me.LblAfficheNumContrat.Text = "   "
        '
        'DTPickerDateMiseEnVigueur
        '
        Me.DTPickerDateMiseEnVigueur.Location = New System.Drawing.Point(194, 165)
        Me.DTPickerDateMiseEnVigueur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DTPickerDateMiseEnVigueur.Name = "DTPickerDateMiseEnVigueur"
        Me.DTPickerDateMiseEnVigueur.Size = New System.Drawing.Size(298, 26)
        Me.DTPickerDateMiseEnVigueur.TabIndex = 19
        '
        'DTPickerDateOuverture
        '
        Me.DTPickerDateOuverture.Location = New System.Drawing.Point(194, 111)
        Me.DTPickerDateOuverture.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DTPickerDateOuverture.Name = "DTPickerDateOuverture"
        Me.DTPickerDateOuverture.Size = New System.Drawing.Size(298, 26)
        Me.DTPickerDateOuverture.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.TxtBoxNomResponsable)
        Me.GroupBox2.Controls.Add(Me.TxtBoxRaisonSociale)
        Me.GroupBox2.Controls.Add(Me.TxtBoxNas)
        Me.GroupBox2.Controls.Add(Me.TxtBoxNumEmploye)
        Me.GroupBox2.Controls.Add(Me.TxtBoxTelecopieur)
        Me.GroupBox2.Controls.Add(Me.TxtBoxTelphone)
        Me.GroupBox2.Controls.Add(Me.TxtBoxAdresse)
        Me.GroupBox2.Controls.Add(Me.TxtBoxPrenom)
        Me.GroupBox2.Controls.Add(Me.TxtBoxNom)
        Me.GroupBox2.Controls.Add(Me.CmbBoxTypeClient)
        Me.GroupBox2.Controls.Add(Me.LblNomResponsable)
        Me.GroupBox2.Controls.Add(Me.LblRaisonSociale)
        Me.GroupBox2.Controls.Add(Me.LblNas)
        Me.GroupBox2.Controls.Add(Me.LblTelecopieur)
        Me.GroupBox2.Controls.Add(Me.LblNumEmploye)
        Me.GroupBox2.Controls.Add(Me.LblTelephone)
        Me.GroupBox2.Controls.Add(Me.LblAdresse)
        Me.GroupBox2.Controls.Add(Me.LblNom)
        Me.GroupBox2.Controls.Add(Me.LblPrenom)
        Me.GroupBox2.Controls.Add(Me.LblAfficheNumClient)
        Me.GroupBox2.Controls.Add(Me.LblNumClient)
        Me.GroupBox2.Controls.Add(Me.LblTypeClient)
        Me.GroupBox2.Location = New System.Drawing.Point(240, 108)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(1251, 285)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Identification du client"
        '
        'TxtBoxNomResponsable
        '
        Me.TxtBoxNomResponsable.Location = New System.Drawing.Point(796, 197)
        Me.TxtBoxNomResponsable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxNomResponsable.Name = "TxtBoxNomResponsable"
        Me.TxtBoxNomResponsable.Size = New System.Drawing.Size(180, 26)
        Me.TxtBoxNomResponsable.TabIndex = 25
        '
        'TxtBoxRaisonSociale
        '
        Me.TxtBoxRaisonSociale.Location = New System.Drawing.Point(796, 158)
        Me.TxtBoxRaisonSociale.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxRaisonSociale.Name = "TxtBoxRaisonSociale"
        Me.TxtBoxRaisonSociale.Size = New System.Drawing.Size(180, 26)
        Me.TxtBoxRaisonSociale.TabIndex = 24
        '
        'TxtBoxNas
        '
        Me.TxtBoxNas.Location = New System.Drawing.Point(796, 117)
        Me.TxtBoxNas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxNas.Name = "TxtBoxNas"
        Me.TxtBoxNas.Size = New System.Drawing.Size(180, 26)
        Me.TxtBoxNas.TabIndex = 23
        '
        'TxtBoxNumEmploye
        '
        Me.TxtBoxNumEmploye.Location = New System.Drawing.Point(796, 74)
        Me.TxtBoxNumEmploye.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxNumEmploye.Name = "TxtBoxNumEmploye"
        Me.TxtBoxNumEmploye.Size = New System.Drawing.Size(180, 26)
        Me.TxtBoxNumEmploye.TabIndex = 22
        '
        'TxtBoxTelecopieur
        '
        Me.TxtBoxTelecopieur.Location = New System.Drawing.Point(194, 246)
        Me.TxtBoxTelecopieur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxTelecopieur.Name = "TxtBoxTelecopieur"
        Me.TxtBoxTelecopieur.Size = New System.Drawing.Size(180, 26)
        Me.TxtBoxTelecopieur.TabIndex = 21
        '
        'TxtBoxTelphone
        '
        Me.TxtBoxTelphone.Location = New System.Drawing.Point(195, 208)
        Me.TxtBoxTelphone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxTelphone.Name = "TxtBoxTelphone"
        Me.TxtBoxTelphone.Size = New System.Drawing.Size(180, 26)
        Me.TxtBoxTelphone.TabIndex = 20
        '
        'TxtBoxAdresse
        '
        Me.TxtBoxAdresse.Location = New System.Drawing.Point(195, 163)
        Me.TxtBoxAdresse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxAdresse.Name = "TxtBoxAdresse"
        Me.TxtBoxAdresse.Size = New System.Drawing.Size(180, 26)
        Me.TxtBoxAdresse.TabIndex = 19
        '
        'TxtBoxPrenom
        '
        Me.TxtBoxPrenom.Location = New System.Drawing.Point(194, 122)
        Me.TxtBoxPrenom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxPrenom.Name = "TxtBoxPrenom"
        Me.TxtBoxPrenom.Size = New System.Drawing.Size(180, 26)
        Me.TxtBoxPrenom.TabIndex = 18
        '
        'TxtBoxNom
        '
        Me.TxtBoxNom.Location = New System.Drawing.Point(195, 80)
        Me.TxtBoxNom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxNom.Name = "TxtBoxNom"
        Me.TxtBoxNom.Size = New System.Drawing.Size(180, 26)
        Me.TxtBoxNom.TabIndex = 17
        '
        'CmbBoxTypeClient
        '
        Me.CmbBoxTypeClient.FormattingEnabled = True
        Me.CmbBoxTypeClient.Items.AddRange(New Object() {"Employe", "Particulier", "Entreprise"})
        Me.CmbBoxTypeClient.Location = New System.Drawing.Point(195, 43)
        Me.CmbBoxTypeClient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CmbBoxTypeClient.Name = "CmbBoxTypeClient"
        Me.CmbBoxTypeClient.Size = New System.Drawing.Size(180, 28)
        Me.CmbBoxTypeClient.TabIndex = 16
        '
        'LblNomResponsable
        '
        Me.LblNomResponsable.AutoSize = True
        Me.LblNomResponsable.Location = New System.Drawing.Point(602, 208)
        Me.LblNomResponsable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNomResponsable.Name = "LblNomResponsable"
        Me.LblNomResponsable.Size = New System.Drawing.Size(155, 20)
        Me.LblNomResponsable.TabIndex = 14
        Me.LblNomResponsable.Text = "Nom du responsable"
        '
        'LblRaisonSociale
        '
        Me.LblRaisonSociale.AutoSize = True
        Me.LblRaisonSociale.Location = New System.Drawing.Point(602, 168)
        Me.LblRaisonSociale.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblRaisonSociale.Name = "LblRaisonSociale"
        Me.LblRaisonSociale.Size = New System.Drawing.Size(112, 20)
        Me.LblRaisonSociale.TabIndex = 13
        Me.LblRaisonSociale.Text = "Raison sociale"
        '
        'LblNas
        '
        Me.LblNas.AutoSize = True
        Me.LblNas.Location = New System.Drawing.Point(602, 122)
        Me.LblNas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNas.Name = "LblNas"
        Me.LblNas.Size = New System.Drawing.Size(42, 20)
        Me.LblNas.TabIndex = 12
        Me.LblNas.Text = "NAS"
        '
        'LblTelecopieur
        '
        Me.LblTelecopieur.AutoSize = True
        Me.LblTelecopieur.Location = New System.Drawing.Point(27, 246)
        Me.LblTelecopieur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTelecopieur.Name = "LblTelecopieur"
        Me.LblTelecopieur.Size = New System.Drawing.Size(91, 20)
        Me.LblTelecopieur.TabIndex = 11
        Me.LblTelecopieur.Text = "Télécopieur"
        '
        'LblNumEmploye
        '
        Me.LblNumEmploye.AutoSize = True
        Me.LblNumEmploye.Location = New System.Drawing.Point(602, 85)
        Me.LblNumEmploye.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNumEmploye.Name = "LblNumEmploye"
        Me.LblNumEmploye.Size = New System.Drawing.Size(128, 20)
        Me.LblNumEmploye.TabIndex = 10
        Me.LblNumEmploye.Text = "Numéro employé"
        '
        'LblTelephone
        '
        Me.LblTelephone.AutoSize = True
        Me.LblTelephone.Location = New System.Drawing.Point(27, 208)
        Me.LblTelephone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTelephone.Name = "LblTelephone"
        Me.LblTelephone.Size = New System.Drawing.Size(84, 20)
        Me.LblTelephone.TabIndex = 9
        Me.LblTelephone.Text = "Téléphone"
        '
        'LblAdresse
        '
        Me.LblAdresse.AutoSize = True
        Me.LblAdresse.Location = New System.Drawing.Point(27, 163)
        Me.LblAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAdresse.Name = "LblAdresse"
        Me.LblAdresse.Size = New System.Drawing.Size(68, 20)
        Me.LblAdresse.TabIndex = 8
        Me.LblAdresse.Text = "Adresse"
        '
        'LblNom
        '
        Me.LblNom.AutoSize = True
        Me.LblNom.Location = New System.Drawing.Point(27, 80)
        Me.LblNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNom.Name = "LblNom"
        Me.LblNom.Size = New System.Drawing.Size(42, 20)
        Me.LblNom.TabIndex = 7
        Me.LblNom.Text = "Nom"
        '
        'LblPrenom
        '
        Me.LblPrenom.AutoSize = True
        Me.LblPrenom.Location = New System.Drawing.Point(27, 122)
        Me.LblPrenom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblPrenom.Name = "LblPrenom"
        Me.LblPrenom.Size = New System.Drawing.Size(64, 20)
        Me.LblPrenom.TabIndex = 6
        Me.LblPrenom.Text = "Prenom"
        '
        'LblAfficheNumClient
        '
        Me.LblAfficheNumClient.AutoSize = True
        Me.LblAfficheNumClient.Location = New System.Drawing.Point(945, 43)
        Me.LblAfficheNumClient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAfficheNumClient.Name = "LblAfficheNumClient"
        Me.LblAfficheNumClient.Size = New System.Drawing.Size(21, 20)
        Me.LblAfficheNumClient.TabIndex = 5
        Me.LblAfficheNumClient.Text = "   "
        '
        'LblNumClient
        '
        Me.LblNumClient.AutoSize = True
        Me.LblNumClient.Location = New System.Drawing.Point(602, 43)
        Me.LblNumClient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNumClient.Name = "LblNumClient"
        Me.LblNumClient.Size = New System.Drawing.Size(128, 20)
        Me.LblNumClient.TabIndex = 4
        Me.LblNumClient.Text = "Numéro du client"
        '
        'LblTypeClient
        '
        Me.LblTypeClient.AutoSize = True
        Me.LblTypeClient.Location = New System.Drawing.Point(27, 43)
        Me.LblTypeClient.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTypeClient.Name = "LblTypeClient"
        Me.LblTypeClient.Size = New System.Drawing.Size(106, 20)
        Me.LblTypeClient.TabIndex = 3
        Me.LblTypeClient.Text = "Type de client"
        '
        'BtnQuitter
        '
        Me.BtnQuitter.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitter.Location = New System.Drawing.Point(33, 569)
        Me.BtnQuitter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(136, 83)
        Me.BtnQuitter.TabIndex = 20
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = False
        '
        'BtnCourriel
        '
        Me.BtnCourriel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCourriel.Location = New System.Drawing.Point(33, 222)
        Me.BtnCourriel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCourriel.Name = "BtnCourriel"
        Me.BtnCourriel.Size = New System.Drawing.Size(136, 75)
        Me.BtnCourriel.TabIndex = 24
        Me.BtnCourriel.Text = "Envoyer par Courriel"
        Me.BtnCourriel.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.White
        Me.GroupBox8.Controls.Add(Me.BtnCourriel)
        Me.GroupBox8.Controls.Add(Me.BtnQuitter)
        Me.GroupBox8.Controls.Add(Me.BtnImprimer)
        Me.GroupBox8.Controls.Add(Me.BtnCreer)
        Me.GroupBox8.Location = New System.Drawing.Point(18, 108)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox8.Size = New System.Drawing.Size(196, 692)
        Me.GroupBox8.TabIndex = 25
        Me.GroupBox8.TabStop = False
        '
        'BtnImprimer
        '
        Me.BtnImprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimer.Location = New System.Drawing.Point(33, 369)
        Me.BtnImprimer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnImprimer.Name = "BtnImprimer"
        Me.BtnImprimer.Size = New System.Drawing.Size(136, 95)
        Me.BtnImprimer.TabIndex = 22
        Me.BtnImprimer.Text = "Imprimer"
        Me.BtnImprimer.UseVisualStyleBackColor = True
        '
        'BtnCreer
        '
        Me.BtnCreer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreer.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCreer.Location = New System.Drawing.Point(33, 85)
        Me.BtnCreer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnCreer.Name = "BtnCreer"
        Me.BtnCreer.Size = New System.Drawing.Size(136, 75)
        Me.BtnCreer.TabIndex = 21
        Me.BtnCreer.Text = "Créer"
        Me.BtnCreer.UseVisualStyleBackColor = True
        '
        'Titre
        '
        Me.Titre.BackColor = System.Drawing.Color.Transparent
        Me.Titre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(530, 46)
        Me.Titre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(575, 34)
        Me.Titre.TabIndex = 39
        Me.Titre.Text = "Nouveau contrat"
        Me.Titre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'FrmCreer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(1626, 1050)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBoxOptionContrat)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmCreer"
        Me.Text = "Nouveau contrat"
        Me.GBoxOptionContrat.ResumeLayout(False)
        Me.GBoxOptionContrat.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblNumContrat As Label
    Friend WithEvents LblTypeContrat As Label
    Friend WithEvents LblDateOuverture As Label
    Friend WithEvents LblLocation As Label
    Friend WithEvents LblService As Label
    Friend WithEvents LblDateMiseEnVigueur As Label
    Friend WithEvents CmbBoxTypeContrat As ComboBox
    Friend WithEvents LblPaiementMensuel As Label
    Friend WithEvents TxtBoxPaiement As TextBox
    Friend WithEvents GBoxOptionContrat As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtBoxNomResponsable As TextBox
    Friend WithEvents TxtBoxRaisonSociale As TextBox
    Friend WithEvents TxtBoxNas As TextBox
    Friend WithEvents TxtBoxNumEmploye As TextBox
    Friend WithEvents TxtBoxTelecopieur As TextBox
    Friend WithEvents TxtBoxTelphone As TextBox
    Friend WithEvents TxtBoxAdresse As TextBox
    Friend WithEvents TxtBoxPrenom As TextBox
    Friend WithEvents TxtBoxNom As TextBox
    Friend WithEvents CmbBoxTypeClient As ComboBox
    Friend WithEvents LblNomResponsable As Label
    Friend WithEvents LblRaisonSociale As Label
    Friend WithEvents LblNas As Label
    Friend WithEvents LblTelecopieur As Label
    Friend WithEvents LblNumEmploye As Label
    Friend WithEvents LblTelephone As Label
    Friend WithEvents LblAdresse As Label
    Friend WithEvents LblNom As Label
    Friend WithEvents LblPrenom As Label
    Friend WithEvents LblNumClient As Label
    Friend WithEvents LblTypeClient As Label
    Friend WithEvents DTPickerDateOuverture As DateTimePicker
    Friend WithEvents DTPickerDateMiseEnVigueur As DateTimePicker
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents BtnCreer As Button
    Friend WithEvents BtnImprimer As Button
    Friend WithEvents BtnCourriel As Button
    Friend WithEvents LblAfficheNumContrat As Label
    Friend WithEvents CmbBoxLocation As ComboBox
    Friend WithEvents CmbBoxService As ComboBox
    Friend WithEvents CmbBoxRaccord As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBoxAnnee As CheckBox
    Friend WithEvents CBoxMois As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Titre As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents LblAfficheNumClient As Label
End Class
