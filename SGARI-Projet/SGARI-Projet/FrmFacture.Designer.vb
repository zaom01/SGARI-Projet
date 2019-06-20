<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFacture
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFacture))
        Me.GroupIDFacture = New System.Windows.Forms.GroupBox()
        Me.CodeContrat = New System.Windows.Forms.TextBox()
        Me.CodeClient = New System.Windows.Forms.TextBox()
        Me.DateFacture = New System.Windows.Forms.TextBox()
        Me.NumFacture = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupFacturation = New System.Windows.Forms.GroupBox()
        Me.MaskedTelFact = New System.Windows.Forms.MaskedTextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.VilleFact = New System.Windows.Forms.TextBox()
        Me.AdresseFact = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupLivraison = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.MaskedTelLiv = New System.Windows.Forms.MaskedTextBox()
        Me.VilleLiv = New System.Windows.Forms.TextBox()
        Me.AdresseLiv = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Annuler = New System.Windows.Forms.Button()
        Me.Valider = New System.Windows.Forms.Button()
        Me.GrouplineCommande = New System.Windows.Forms.GroupBox()
        Me.LigneCommande = New System.Windows.Forms.DataGridView()
        Me.RefProduit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Désignation = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantité = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prix = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Montant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.soustotal = New System.Windows.Forms.TextBox()
        Me.prixunitaire = New System.Windows.Forms.TextBox()
        Me.QuantiteCmd = New System.Windows.Forms.TextBox()
        Me.Designation = New System.Windows.Forms.TextBox()
        Me.RefPrd = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupPiedFact = New System.Windows.Forms.GroupBox()
        Me.TOTALTTC = New System.Windows.Forms.TextBox()
        Me.TauxTVQ = New System.Windows.Forms.TextBox()
        Me.TauxTPS = New System.Windows.Forms.TextBox()
        Me.MontantTVQ = New System.Windows.Forms.TextBox()
        Me.MontantTPS = New System.Windows.Forms.TextBox()
        Me.MontantHT = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupReglement = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.GroupMenu = New System.Windows.Forms.GroupBox()
        Me.ButtonTaxe = New System.Windows.Forms.Button()
        Me.Buttondel = New System.Windows.Forms.Button()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.ButtonModifier = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.GroupIDFacture.SuspendLayout()
        Me.GroupFacturation.SuspendLayout()
        Me.GroupLivraison.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GrouplineCommande.SuspendLayout()
        CType(Me.LigneCommande, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPiedFact.SuspendLayout()
        Me.GroupReglement.SuspendLayout()
        Me.GroupMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupIDFacture
        '
        Me.GroupIDFacture.BackColor = System.Drawing.Color.White
        Me.GroupIDFacture.Controls.Add(Me.CodeContrat)
        Me.GroupIDFacture.Controls.Add(Me.CodeClient)
        Me.GroupIDFacture.Controls.Add(Me.DateFacture)
        Me.GroupIDFacture.Controls.Add(Me.NumFacture)
        Me.GroupIDFacture.Controls.Add(Me.Label4)
        Me.GroupIDFacture.Controls.Add(Me.Label3)
        Me.GroupIDFacture.Controls.Add(Me.Label2)
        Me.GroupIDFacture.Controls.Add(Me.Label1)
        Me.GroupIDFacture.Location = New System.Drawing.Point(146, 18)
        Me.GroupIDFacture.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupIDFacture.Name = "GroupIDFacture"
        Me.GroupIDFacture.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupIDFacture.Size = New System.Drawing.Size(604, 174)
        Me.GroupIDFacture.TabIndex = 0
        Me.GroupIDFacture.TabStop = False
        Me.GroupIDFacture.Text = "ID Facture"
        '
        'CodeContrat
        '
        Me.CodeContrat.Location = New System.Drawing.Point(435, 103)
        Me.CodeContrat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CodeContrat.Name = "CodeContrat"
        Me.CodeContrat.Size = New System.Drawing.Size(148, 26)
        Me.CodeContrat.TabIndex = 7
        '
        'CodeClient
        '
        Me.CodeClient.Location = New System.Drawing.Point(128, 103)
        Me.CodeClient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CodeClient.Name = "CodeClient"
        Me.CodeClient.Size = New System.Drawing.Size(148, 26)
        Me.CodeClient.TabIndex = 6
        '
        'DateFacture
        '
        Me.DateFacture.Location = New System.Drawing.Point(435, 54)
        Me.DateFacture.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateFacture.Name = "DateFacture"
        Me.DateFacture.Size = New System.Drawing.Size(148, 26)
        Me.DateFacture.TabIndex = 5
        '
        'NumFacture
        '
        Me.NumFacture.Location = New System.Drawing.Point(128, 46)
        Me.NumFacture.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NumFacture.Name = "NumFacture"
        Me.NumFacture.Size = New System.Drawing.Size(148, 26)
        Me.NumFacture.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(338, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 35)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contrat "
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 35)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Code client"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(310, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date Facture"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(18, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N* Facture"
        '
        'GroupFacturation
        '
        Me.GroupFacturation.BackColor = System.Drawing.Color.White
        Me.GroupFacturation.Controls.Add(Me.MaskedTelFact)
        Me.GroupFacturation.Controls.Add(Me.TextBox3)
        Me.GroupFacturation.Controls.Add(Me.VilleFact)
        Me.GroupFacturation.Controls.Add(Me.AdresseFact)
        Me.GroupFacturation.Controls.Add(Me.Label7)
        Me.GroupFacturation.Controls.Add(Me.Label6)
        Me.GroupFacturation.Controls.Add(Me.Label5)
        Me.GroupFacturation.Location = New System.Drawing.Point(759, 18)
        Me.GroupFacturation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupFacturation.Name = "GroupFacturation"
        Me.GroupFacturation.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupFacturation.Size = New System.Drawing.Size(416, 174)
        Me.GroupFacturation.TabIndex = 1
        Me.GroupFacturation.TabStop = False
        Me.GroupFacturation.Text = "Adresse Fcturation"
        '
        'MaskedTelFact
        '
        Me.MaskedTelFact.Location = New System.Drawing.Point(110, 118)
        Me.MaskedTelFact.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaskedTelFact.Mask = "000 000 0000 "
        Me.MaskedTelFact.Name = "MaskedTelFact"
        Me.MaskedTelFact.Size = New System.Drawing.Size(148, 26)
        Me.MaskedTelFact.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(254, 172)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(148, 26)
        Me.TextBox3.TabIndex = 5
        '
        'VilleFact
        '
        Me.VilleFact.Location = New System.Drawing.Point(86, 69)
        Me.VilleFact.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.VilleFact.Name = "VilleFact"
        Me.VilleFact.Size = New System.Drawing.Size(316, 26)
        Me.VilleFact.TabIndex = 4
        '
        'AdresseFact
        '
        Me.AdresseFact.Location = New System.Drawing.Point(86, 29)
        Me.AdresseFact.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdresseFact.Name = "AdresseFact"
        Me.AdresseFact.Size = New System.Drawing.Size(316, 26)
        Me.AdresseFact.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 118)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Telephone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 74)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Ville"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 25)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Adresse"
        '
        'GroupLivraison
        '
        Me.GroupLivraison.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupLivraison.Controls.Add(Me.Label20)
        Me.GroupLivraison.Controls.Add(Me.Label19)
        Me.GroupLivraison.Controls.Add(Me.Label18)
        Me.GroupLivraison.Controls.Add(Me.MaskedTelLiv)
        Me.GroupLivraison.Controls.Add(Me.VilleLiv)
        Me.GroupLivraison.Controls.Add(Me.AdresseLiv)
        Me.GroupLivraison.Location = New System.Drawing.Point(1239, 18)
        Me.GroupLivraison.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupLivraison.Name = "GroupLivraison"
        Me.GroupLivraison.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupLivraison.Size = New System.Drawing.Size(423, 174)
        Me.GroupLivraison.TabIndex = 2
        Me.GroupLivraison.TabStop = False
        Me.GroupLivraison.Text = "Adresse de livraison"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(14, 128)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 20)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Telephone"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(9, 72)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(38, 20)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Ville"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 34)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 20)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Adresse"
        '
        'MaskedTelLiv
        '
        Me.MaskedTelLiv.Location = New System.Drawing.Point(110, 117)
        Me.MaskedTelLiv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaskedTelLiv.Mask = "000 000 0000 "
        Me.MaskedTelLiv.Name = "MaskedTelLiv"
        Me.MaskedTelLiv.Size = New System.Drawing.Size(148, 26)
        Me.MaskedTelLiv.TabIndex = 2
        '
        'VilleLiv
        '
        Me.VilleLiv.Location = New System.Drawing.Point(90, 74)
        Me.VilleLiv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.VilleLiv.Name = "VilleLiv"
        Me.VilleLiv.Size = New System.Drawing.Size(322, 26)
        Me.VilleLiv.TabIndex = 1
        '
        'AdresseLiv
        '
        Me.AdresseLiv.Location = New System.Drawing.Point(90, 34)
        Me.AdresseLiv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AdresseLiv.Name = "AdresseLiv"
        Me.AdresseLiv.Size = New System.Drawing.Size(322, 26)
        Me.AdresseLiv.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.Annuler)
        Me.GroupBox4.Controls.Add(Me.Valider)
        Me.GroupBox4.Location = New System.Drawing.Point(146, 783)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(1508, 82)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'Annuler
        '
        Me.Annuler.Image = CType(resources.GetObject("Annuler.Image"), System.Drawing.Image)
        Me.Annuler.Location = New System.Drawing.Point(1330, 12)
        Me.Annuler.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Annuler.Name = "Annuler"
        Me.Annuler.Size = New System.Drawing.Size(94, 60)
        Me.Annuler.TabIndex = 4
        Me.Annuler.UseVisualStyleBackColor = True
        '
        'Valider
        '
        Me.Valider.Image = CType(resources.GetObject("Valider.Image"), System.Drawing.Image)
        Me.Valider.Location = New System.Drawing.Point(1107, 12)
        Me.Valider.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Valider.Name = "Valider"
        Me.Valider.Size = New System.Drawing.Size(90, 60)
        Me.Valider.TabIndex = 0
        Me.Valider.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Valider.UseVisualStyleBackColor = True
        '
        'GrouplineCommande
        '
        Me.GrouplineCommande.BackColor = System.Drawing.Color.White
        Me.GrouplineCommande.Controls.Add(Me.LigneCommande)
        Me.GrouplineCommande.Controls.Add(Me.Button6)
        Me.GrouplineCommande.Controls.Add(Me.soustotal)
        Me.GrouplineCommande.Controls.Add(Me.prixunitaire)
        Me.GrouplineCommande.Controls.Add(Me.QuantiteCmd)
        Me.GrouplineCommande.Controls.Add(Me.Designation)
        Me.GrouplineCommande.Controls.Add(Me.RefPrd)
        Me.GrouplineCommande.Controls.Add(Me.Label12)
        Me.GrouplineCommande.Controls.Add(Me.Label11)
        Me.GrouplineCommande.Controls.Add(Me.Label10)
        Me.GrouplineCommande.Controls.Add(Me.Label9)
        Me.GrouplineCommande.Controls.Add(Me.Label8)
        Me.GrouplineCommande.Location = New System.Drawing.Point(146, 226)
        Me.GrouplineCommande.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GrouplineCommande.Name = "GrouplineCommande"
        Me.GrouplineCommande.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GrouplineCommande.Size = New System.Drawing.Size(1508, 338)
        Me.GrouplineCommande.TabIndex = 4
        Me.GrouplineCommande.TabStop = False
        Me.GrouplineCommande.Text = "Ligne de commande"
        '
        'LigneCommande
        '
        Me.LigneCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LigneCommande.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RefProduit, Me.Désignation, Me.Quantité, Me.Prix, Me.Montant})
        Me.LigneCommande.Location = New System.Drawing.Point(42, 106)
        Me.LigneCommande.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LigneCommande.MultiSelect = False
        Me.LigneCommande.Name = "LigneCommande"
        Me.LigneCommande.Size = New System.Drawing.Size(1330, 217)
        Me.LigneCommande.TabIndex = 11
        '
        'RefProduit
        '
        Me.RefProduit.HeaderText = "Réf. Produit"
        Me.RefProduit.Name = "RefProduit"
        Me.RefProduit.ReadOnly = True
        Me.RefProduit.Width = 150
        '
        'Désignation
        '
        Me.Désignation.HeaderText = "Désignation"
        Me.Désignation.Name = "Désignation"
        Me.Désignation.Width = 300
        '
        'Quantité
        '
        Me.Quantité.HeaderText = "QTé Commandée"
        Me.Quantité.Name = "Quantité"
        Me.Quantité.ReadOnly = True
        Me.Quantité.Width = 130
        '
        'Prix
        '
        Me.Prix.HeaderText = "Prix Unitaire Ht"
        Me.Prix.Name = "Prix"
        Me.Prix.ReadOnly = True
        Me.Prix.Width = 130
        '
        'Montant
        '
        Me.Montant.HeaderText = "MontantHt"
        Me.Montant.Name = "Montant"
        Me.Montant.ReadOnly = True
        Me.Montant.Width = 130
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(1352, 58)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 43)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Inserer"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'soustotal
        '
        Me.soustotal.Enabled = False
        Me.soustotal.Location = New System.Drawing.Point(1184, 65)
        Me.soustotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.soustotal.Name = "soustotal"
        Me.soustotal.Size = New System.Drawing.Size(148, 26)
        Me.soustotal.TabIndex = 9
        '
        'prixunitaire
        '
        Me.prixunitaire.Location = New System.Drawing.Point(1020, 65)
        Me.prixunitaire.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.prixunitaire.Name = "prixunitaire"
        Me.prixunitaire.Size = New System.Drawing.Size(148, 26)
        Me.prixunitaire.TabIndex = 8
        '
        'QuantiteCmd
        '
        Me.QuantiteCmd.Location = New System.Drawing.Point(861, 65)
        Me.QuantiteCmd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.QuantiteCmd.Name = "QuantiteCmd"
        Me.QuantiteCmd.Size = New System.Drawing.Size(148, 26)
        Me.QuantiteCmd.TabIndex = 7
        '
        'Designation
        '
        Me.Designation.Location = New System.Drawing.Point(321, 65)
        Me.Designation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Designation.Name = "Designation"
        Me.Designation.Size = New System.Drawing.Size(516, 26)
        Me.Designation.TabIndex = 6
        '
        'RefPrd
        '
        Me.RefPrd.FormattingEnabled = True
        Me.RefPrd.Location = New System.Drawing.Point(99, 65)
        Me.RefPrd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RefPrd.Name = "RefPrd"
        Me.RefPrd.Size = New System.Drawing.Size(211, 28)
        Me.RefPrd.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(1131, 25)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 20)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Total"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(976, 29)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 20)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Prix"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(796, 29)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Quantité"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(351, 42)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Désignation Produit"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(117, 42)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Réf. Produit"
        '
        'GroupPiedFact
        '
        Me.GroupPiedFact.BackColor = System.Drawing.Color.White
        Me.GroupPiedFact.Controls.Add(Me.TOTALTTC)
        Me.GroupPiedFact.Controls.Add(Me.TauxTVQ)
        Me.GroupPiedFact.Controls.Add(Me.TauxTPS)
        Me.GroupPiedFact.Controls.Add(Me.MontantTVQ)
        Me.GroupPiedFact.Controls.Add(Me.MontantTPS)
        Me.GroupPiedFact.Controls.Add(Me.MontantHT)
        Me.GroupPiedFact.Controls.Add(Me.Label16)
        Me.GroupPiedFact.Controls.Add(Me.Label15)
        Me.GroupPiedFact.Controls.Add(Me.Label14)
        Me.GroupPiedFact.Controls.Add(Me.Label13)
        Me.GroupPiedFact.ForeColor = System.Drawing.Color.Black
        Me.GroupPiedFact.Location = New System.Drawing.Point(146, 574)
        Me.GroupPiedFact.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupPiedFact.Name = "GroupPiedFact"
        Me.GroupPiedFact.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupPiedFact.Size = New System.Drawing.Size(714, 200)
        Me.GroupPiedFact.TabIndex = 7
        Me.GroupPiedFact.TabStop = False
        Me.GroupPiedFact.Text = "Pied de la facture"
        '
        'TOTALTTC
        '
        Me.TOTALTTC.Location = New System.Drawing.Point(213, 160)
        Me.TOTALTTC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TOTALTTC.Name = "TOTALTTC"
        Me.TOTALTTC.Size = New System.Drawing.Size(211, 26)
        Me.TOTALTTC.TabIndex = 9
        '
        'TauxTVQ
        '
        Me.TauxTVQ.Location = New System.Drawing.Point(436, 106)
        Me.TauxTVQ.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TauxTVQ.Name = "TauxTVQ"
        Me.TauxTVQ.Size = New System.Drawing.Size(85, 26)
        Me.TauxTVQ.TabIndex = 8
        '
        'TauxTPS
        '
        Me.TauxTPS.Location = New System.Drawing.Point(436, 66)
        Me.TauxTPS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TauxTPS.Name = "TauxTPS"
        Me.TauxTPS.Size = New System.Drawing.Size(85, 26)
        Me.TauxTPS.TabIndex = 7
        '
        'MontantTVQ
        '
        Me.MontantTVQ.Location = New System.Drawing.Point(213, 108)
        Me.MontantTVQ.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MontantTVQ.Name = "MontantTVQ"
        Me.MontantTVQ.Size = New System.Drawing.Size(211, 26)
        Me.MontantTVQ.TabIndex = 6
        '
        'MontantTPS
        '
        Me.MontantTPS.Location = New System.Drawing.Point(213, 68)
        Me.MontantTPS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MontantTPS.Name = "MontantTPS"
        Me.MontantTPS.Size = New System.Drawing.Size(211, 26)
        Me.MontantTPS.TabIndex = 5
        '
        'MontantHT
        '
        Me.MontantHT.Location = New System.Drawing.Point(213, 20)
        Me.MontantHT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MontantHT.Name = "MontantHT"
        Me.MontantHT.Size = New System.Drawing.Size(211, 26)
        Me.MontantHT.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(50, 175)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 20)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Total TTC"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(50, 120)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 20)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Montant TVH"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(50, 68)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 20)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Montant TPS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(54, 31)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Montant H.T"
        '
        'GroupReglement
        '
        Me.GroupReglement.BackColor = System.Drawing.Color.White
        Me.GroupReglement.Controls.Add(Me.ComboBox2)
        Me.GroupReglement.Location = New System.Drawing.Point(868, 574)
        Me.GroupReglement.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupReglement.Name = "GroupReglement"
        Me.GroupReglement.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupReglement.Size = New System.Drawing.Size(784, 195)
        Me.GroupReglement.TabIndex = 8
        Me.GroupReglement.TabStop = False
        Me.GroupReglement.Text = "Etat Facture"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Complétée", "Payée, ", "Annulée,", "Imprimée, ", "En préparation"})
        Me.ComboBox2.Location = New System.Drawing.Point(26, 55)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(560, 28)
        Me.ComboBox2.TabIndex = 1
        '
        'GroupMenu
        '
        Me.GroupMenu.BackColor = System.Drawing.Color.White
        Me.GroupMenu.Controls.Add(Me.ButtonTaxe)
        Me.GroupMenu.Controls.Add(Me.Buttondel)
        Me.GroupMenu.Controls.Add(Me.ButtonPrint)
        Me.GroupMenu.Controls.Add(Me.ButtonModifier)
        Me.GroupMenu.Controls.Add(Me.Button2)
        Me.GroupMenu.Location = New System.Drawing.Point(4, 25)
        Me.GroupMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupMenu.Name = "GroupMenu"
        Me.GroupMenu.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupMenu.Size = New System.Drawing.Size(132, 802)
        Me.GroupMenu.TabIndex = 9
        Me.GroupMenu.TabStop = False
        '
        'ButtonTaxe
        '
        Me.ButtonTaxe.Location = New System.Drawing.Point(15, 414)
        Me.ButtonTaxe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonTaxe.Name = "ButtonTaxe"
        Me.ButtonTaxe.Size = New System.Drawing.Size(93, 74)
        Me.ButtonTaxe.TabIndex = 5
        Me.ButtonTaxe.Text = " Taxes"
        Me.ButtonTaxe.UseVisualStyleBackColor = True
        '
        'Buttondel
        '
        Me.Buttondel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Buttondel.Location = New System.Drawing.Point(9, 291)
        Me.Buttondel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Buttondel.Name = "Buttondel"
        Me.Buttondel.Size = New System.Drawing.Size(99, 83)
        Me.Buttondel.TabIndex = 4
        Me.Buttondel.Text = "Supprimer"
        Me.Buttondel.UseVisualStyleBackColor = True
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Location = New System.Drawing.Point(9, 689)
        Me.ButtonPrint.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(99, 60)
        Me.ButtonPrint.TabIndex = 3
        Me.ButtonPrint.Text = "Imprimer"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'ButtonModifier
        '
        Me.ButtonModifier.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ButtonModifier.Location = New System.Drawing.Point(9, 166)
        Me.ButtonModifier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonModifier.Name = "ButtonModifier"
        Me.ButtonModifier.Size = New System.Drawing.Size(99, 85)
        Me.ButtonModifier.TabIndex = 2
        Me.ButtonModifier.Text = "Modifier"
        Me.ButtonModifier.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(9, 28)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 85)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Ajouter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.Maroon
        Me.Button9.Location = New System.Drawing.Point(1176, 69)
        Me.Button9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(54, 35)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = ">>>"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'FrmFacture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1680, 877)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.GroupMenu)
        Me.Controls.Add(Me.GroupReglement)
        Me.Controls.Add(Me.GroupPiedFact)
        Me.Controls.Add(Me.GrouplineCommande)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupLivraison)
        Me.Controls.Add(Me.GroupFacturation)
        Me.Controls.Add(Me.GroupIDFacture)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFacture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion de la Facturation"
        Me.GroupIDFacture.ResumeLayout(False)
        Me.GroupIDFacture.PerformLayout()
        Me.GroupFacturation.ResumeLayout(False)
        Me.GroupFacturation.PerformLayout()
        Me.GroupLivraison.ResumeLayout(False)
        Me.GroupLivraison.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GrouplineCommande.ResumeLayout(False)
        Me.GrouplineCommande.PerformLayout()
        CType(Me.LigneCommande, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPiedFact.ResumeLayout(False)
        Me.GroupPiedFact.PerformLayout()
        Me.GroupReglement.ResumeLayout(False)
        Me.GroupMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupIDFacture As GroupBox
    Friend WithEvents GroupFacturation As GroupBox
    Friend WithEvents GroupLivraison As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Annuler As Button
    Friend WithEvents ButtonPrint As Button
    Friend WithEvents ButtonModifier As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Valider As Button
    Friend WithEvents GrouplineCommande As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents soustotal As TextBox
    Friend WithEvents prixunitaire As TextBox
    Friend WithEvents QuantiteCmd As TextBox
    Friend WithEvents Designation As TextBox
    Friend WithEvents RefPrd As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LigneCommande As DataGridView
    Friend WithEvents GroupPiedFact As GroupBox
    Friend WithEvents TOTALTTC As TextBox
    Friend WithEvents TauxTVQ As TextBox
    Friend WithEvents TauxTPS As TextBox
    Friend WithEvents MontantTVQ As TextBox
    Friend WithEvents MontantTPS As TextBox
    Friend WithEvents MontantHT As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupReglement As GroupBox
    Friend WithEvents GroupMenu As GroupBox
    Friend WithEvents ButtonTaxe As Button
    Friend WithEvents Buttondel As Button
    Friend WithEvents DateFacture As TextBox
    Friend WithEvents NumFacture As TextBox
    Friend WithEvents VilleFact As TextBox
    Friend WithEvents AdresseFact As TextBox
    Friend WithEvents VilleLiv As TextBox
    Friend WithEvents AdresseLiv As TextBox
    Friend WithEvents CodeContrat As TextBox
    Friend WithEvents CodeClient As TextBox
    Friend WithEvents MaskedTelFact As MaskedTextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents MaskedTelLiv As MaskedTextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents RefProduit As DataGridViewTextBoxColumn
    Friend WithEvents Désignation As DataGridViewTextBoxColumn
    Friend WithEvents Quantité As DataGridViewTextBoxColumn
    Friend WithEvents Prix As DataGridViewTextBoxColumn
    Friend WithEvents Montant As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox2 As ComboBox
End Class
