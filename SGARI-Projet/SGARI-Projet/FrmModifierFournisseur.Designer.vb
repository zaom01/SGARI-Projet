﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModifierFournisseur
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtBoxCompte = New System.Windows.Forms.TextBox()
        Me.TxtBoxCodeBanque = New System.Windows.Forms.TextBox()
        Me.TxtBoxVilleBanque = New System.Windows.Forms.TextBox()
        Me.TxtBoxAdresseBanque = New System.Windows.Forms.TextBox()
        Me.TxtBoxNomBanque = New System.Windows.Forms.TextBox()
        Me.TxtBoxNomComptable = New System.Windows.Forms.TextBox()
        Me.LabelCompte = New System.Windows.Forms.Label()
        Me.LabelCodeBanque = New System.Windows.Forms.Label()
        Me.labelVillebanque = New System.Windows.Forms.Label()
        Me.LabelAdresseBanque = New System.Windows.Forms.Label()
        Me.LabelNomBanque = New System.Windows.Forms.Label()
        Me.LabelNomComptable = New System.Windows.Forms.Label()
        Me.BoxContactFournisseur = New System.Windows.Forms.GroupBox()
        Me.TxtBoxAdresse = New System.Windows.Forms.TextBox()
        Me.TxtBoxVille = New System.Windows.Forms.TextBox()
        Me.TxtBoxProvince = New System.Windows.Forms.TextBox()
        Me.TxtBoxCodePostal = New System.Windows.Forms.TextBox()
        Me.TxtBoxPays = New System.Windows.Forms.TextBox()
        Me.TxtBoxTéléphone1 = New System.Windows.Forms.TextBox()
        Me.TxtBoxTéléphone2 = New System.Windows.Forms.TextBox()
        Me.TxtBoxFax = New System.Windows.Forms.TextBox()
        Me.TxtBoxSiteWeb = New System.Windows.Forms.TextBox()
        Me.LabelSiteWeb = New System.Windows.Forms.Label()
        Me.LabelFax = New System.Windows.Forms.Label()
        Me.LabelTel2 = New System.Windows.Forms.Label()
        Me.LabelTel1 = New System.Windows.Forms.Label()
        Me.LabelPays = New System.Windows.Forms.Label()
        Me.LabelCodePostal = New System.Windows.Forms.Label()
        Me.LabelProvince = New System.Windows.Forms.Label()
        Me.TxtBoxEmail = New System.Windows.Forms.TextBox()
        Me.LabelNoCompte = New System.Windows.Forms.Label()
        Me.TxtBoxFonction = New System.Windows.Forms.TextBox()
        Me.LabelVille = New System.Windows.Forms.Label()
        Me.LabelSocieté = New System.Windows.Forms.Label()
        Me.LabelAdresse = New System.Windows.Forms.Label()
        Me.TxtBoxContact = New System.Windows.Forms.TextBox()
        Me.LabelContact = New System.Windows.Forms.Label()
        Me.TxtBoxSocieté = New System.Windows.Forms.TextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelFonction = New System.Windows.Forms.Label()
        Me.TxtBoxNoCompte = New System.Windows.Forms.TextBox()
        Me.BtnChercher = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSupprimer = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.BoxContactFournisseur.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.TxtBoxCompte)
        Me.GroupBox1.Controls.Add(Me.TxtBoxCodeBanque)
        Me.GroupBox1.Controls.Add(Me.TxtBoxVilleBanque)
        Me.GroupBox1.Controls.Add(Me.TxtBoxAdresseBanque)
        Me.GroupBox1.Controls.Add(Me.TxtBoxNomBanque)
        Me.GroupBox1.Controls.Add(Me.TxtBoxNomComptable)
        Me.GroupBox1.Controls.Add(Me.LabelCompte)
        Me.GroupBox1.Controls.Add(Me.LabelCodeBanque)
        Me.GroupBox1.Controls.Add(Me.labelVillebanque)
        Me.GroupBox1.Controls.Add(Me.LabelAdresseBanque)
        Me.GroupBox1.Controls.Add(Me.LabelNomBanque)
        Me.GroupBox1.Controls.Add(Me.LabelNomComptable)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.MenuText
        Me.GroupBox1.Location = New System.Drawing.Point(273, 549)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1287, 198)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information du compte"
        '
        'TxtBoxCompte
        '
        Me.TxtBoxCompte.Location = New System.Drawing.Point(914, 143)
        Me.TxtBoxCompte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxCompte.Name = "TxtBoxCompte"
        Me.TxtBoxCompte.Size = New System.Drawing.Size(262, 26)
        Me.TxtBoxCompte.TabIndex = 35
        '
        'TxtBoxCodeBanque
        '
        Me.TxtBoxCodeBanque.Location = New System.Drawing.Point(914, 91)
        Me.TxtBoxCodeBanque.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxCodeBanque.Name = "TxtBoxCodeBanque"
        Me.TxtBoxCodeBanque.Size = New System.Drawing.Size(262, 26)
        Me.TxtBoxCodeBanque.TabIndex = 34
        '
        'TxtBoxVilleBanque
        '
        Me.TxtBoxVilleBanque.Location = New System.Drawing.Point(914, 32)
        Me.TxtBoxVilleBanque.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxVilleBanque.Name = "TxtBoxVilleBanque"
        Me.TxtBoxVilleBanque.Size = New System.Drawing.Size(262, 26)
        Me.TxtBoxVilleBanque.TabIndex = 33
        '
        'TxtBoxAdresseBanque
        '
        Me.TxtBoxAdresseBanque.Location = New System.Drawing.Point(266, 149)
        Me.TxtBoxAdresseBanque.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxAdresseBanque.Name = "TxtBoxAdresseBanque"
        Me.TxtBoxAdresseBanque.Size = New System.Drawing.Size(290, 26)
        Me.TxtBoxAdresseBanque.TabIndex = 32
        '
        'TxtBoxNomBanque
        '
        Me.TxtBoxNomBanque.Location = New System.Drawing.Point(266, 85)
        Me.TxtBoxNomBanque.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxNomBanque.Name = "TxtBoxNomBanque"
        Me.TxtBoxNomBanque.Size = New System.Drawing.Size(290, 26)
        Me.TxtBoxNomBanque.TabIndex = 31
        '
        'TxtBoxNomComptable
        '
        Me.TxtBoxNomComptable.Location = New System.Drawing.Point(266, 26)
        Me.TxtBoxNomComptable.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxNomComptable.Name = "TxtBoxNomComptable"
        Me.TxtBoxNomComptable.Size = New System.Drawing.Size(290, 26)
        Me.TxtBoxNomComptable.TabIndex = 30
        '
        'LabelCompte
        '
        Me.LabelCompte.AutoSize = True
        Me.LabelCompte.Location = New System.Drawing.Point(741, 154)
        Me.LabelCompte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCompte.Name = "LabelCompte"
        Me.LabelCompte.Size = New System.Drawing.Size(155, 20)
        Me.LabelCompte.TabIndex = 5
        Me.LabelCompte.Text = "Numero du Compte :"
        '
        'LabelCodeBanque
        '
        Me.LabelCodeBanque.AutoSize = True
        Me.LabelCodeBanque.Location = New System.Drawing.Point(746, 95)
        Me.LabelCodeBanque.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCodeBanque.Name = "LabelCodeBanque"
        Me.LabelCodeBanque.Size = New System.Drawing.Size(115, 20)
        Me.LabelCodeBanque.TabIndex = 4
        Me.LabelCodeBanque.Text = "Code Banque :"
        '
        'labelVillebanque
        '
        Me.labelVillebanque.AutoSize = True
        Me.labelVillebanque.Location = New System.Drawing.Point(746, 37)
        Me.labelVillebanque.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelVillebanque.Name = "labelVillebanque"
        Me.labelVillebanque.Size = New System.Drawing.Size(46, 20)
        Me.labelVillebanque.TabIndex = 29
        Me.labelVillebanque.Text = "Ville :"
        '
        'LabelAdresseBanque
        '
        Me.LabelAdresseBanque.AutoSize = True
        Me.LabelAdresseBanque.Location = New System.Drawing.Point(30, 154)
        Me.LabelAdresseBanque.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAdresseBanque.Name = "LabelAdresseBanque"
        Me.LabelAdresseBanque.Size = New System.Drawing.Size(76, 20)
        Me.LabelAdresseBanque.TabIndex = 28
        Me.LabelAdresseBanque.Text = "Adresse :"
        '
        'LabelNomBanque
        '
        Me.LabelNomBanque.AutoSize = True
        Me.LabelNomBanque.Location = New System.Drawing.Point(32, 95)
        Me.LabelNomBanque.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNomBanque.Name = "LabelNomBanque"
        Me.LabelNomBanque.Size = New System.Drawing.Size(146, 20)
        Me.LabelNomBanque.TabIndex = 27
        Me.LabelNomBanque.Text = "Nom de la banque :"
        '
        'LabelNomComptable
        '
        Me.LabelNomComptable.AutoSize = True
        Me.LabelNomComptable.Location = New System.Drawing.Point(32, 37)
        Me.LabelNomComptable.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNomComptable.Name = "LabelNomComptable"
        Me.LabelNomComptable.Size = New System.Drawing.Size(150, 20)
        Me.LabelNomComptable.TabIndex = 26
        Me.LabelNomComptable.Text = "Nom du comptable :"
        '
        'BoxContactFournisseur
        '
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxAdresse)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxVille)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxProvince)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxCodePostal)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxPays)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxTéléphone1)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxTéléphone2)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxFax)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxSiteWeb)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelSiteWeb)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelFax)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelTel2)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelTel1)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelPays)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelCodePostal)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelProvince)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxEmail)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelNoCompte)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxFonction)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelVille)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelSocieté)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelAdresse)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxContact)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelContact)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxSocieté)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelEmail)
        Me.BoxContactFournisseur.Controls.Add(Me.LabelFonction)
        Me.BoxContactFournisseur.Controls.Add(Me.TxtBoxNoCompte)
        Me.BoxContactFournisseur.ForeColor = System.Drawing.Color.Black
        Me.BoxContactFournisseur.Location = New System.Drawing.Point(276, 89)
        Me.BoxContactFournisseur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BoxContactFournisseur.Name = "BoxContactFournisseur"
        Me.BoxContactFournisseur.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BoxContactFournisseur.Size = New System.Drawing.Size(1284, 432)
        Me.BoxContactFournisseur.TabIndex = 27
        Me.BoxContactFournisseur.TabStop = False
        Me.BoxContactFournisseur.Text = "Information  Fournisseur"
        '
        'TxtBoxAdresse
        '
        Me.TxtBoxAdresse.Location = New System.Drawing.Point(266, 325)
        Me.TxtBoxAdresse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxAdresse.Name = "TxtBoxAdresse"
        Me.TxtBoxAdresse.Size = New System.Drawing.Size(290, 26)
        Me.TxtBoxAdresse.TabIndex = 17
        '
        'TxtBoxVille
        '
        Me.TxtBoxVille.Location = New System.Drawing.Point(266, 375)
        Me.TxtBoxVille.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxVille.Name = "TxtBoxVille"
        Me.TxtBoxVille.Size = New System.Drawing.Size(290, 26)
        Me.TxtBoxVille.TabIndex = 18
        '
        'TxtBoxProvince
        '
        Me.TxtBoxProvince.Location = New System.Drawing.Point(914, 23)
        Me.TxtBoxProvince.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxProvince.Name = "TxtBoxProvince"
        Me.TxtBoxProvince.Size = New System.Drawing.Size(262, 26)
        Me.TxtBoxProvince.TabIndex = 19
        '
        'TxtBoxCodePostal
        '
        Me.TxtBoxCodePostal.Location = New System.Drawing.Point(914, 83)
        Me.TxtBoxCodePostal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxCodePostal.Name = "TxtBoxCodePostal"
        Me.TxtBoxCodePostal.Size = New System.Drawing.Size(262, 26)
        Me.TxtBoxCodePostal.TabIndex = 20
        '
        'TxtBoxPays
        '
        Me.TxtBoxPays.Location = New System.Drawing.Point(914, 145)
        Me.TxtBoxPays.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxPays.Name = "TxtBoxPays"
        Me.TxtBoxPays.Size = New System.Drawing.Size(262, 26)
        Me.TxtBoxPays.TabIndex = 21
        '
        'TxtBoxTéléphone1
        '
        Me.TxtBoxTéléphone1.Location = New System.Drawing.Point(914, 205)
        Me.TxtBoxTéléphone1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxTéléphone1.Name = "TxtBoxTéléphone1"
        Me.TxtBoxTéléphone1.Size = New System.Drawing.Size(262, 26)
        Me.TxtBoxTéléphone1.TabIndex = 22
        '
        'TxtBoxTéléphone2
        '
        Me.TxtBoxTéléphone2.Location = New System.Drawing.Point(914, 260)
        Me.TxtBoxTéléphone2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxTéléphone2.Name = "TxtBoxTéléphone2"
        Me.TxtBoxTéléphone2.Size = New System.Drawing.Size(262, 26)
        Me.TxtBoxTéléphone2.TabIndex = 23
        '
        'TxtBoxFax
        '
        Me.TxtBoxFax.Location = New System.Drawing.Point(914, 318)
        Me.TxtBoxFax.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxFax.Name = "TxtBoxFax"
        Me.TxtBoxFax.Size = New System.Drawing.Size(262, 26)
        Me.TxtBoxFax.TabIndex = 24
        '
        'TxtBoxSiteWeb
        '
        Me.TxtBoxSiteWeb.Location = New System.Drawing.Point(914, 375)
        Me.TxtBoxSiteWeb.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxSiteWeb.Name = "TxtBoxSiteWeb"
        Me.TxtBoxSiteWeb.Size = New System.Drawing.Size(262, 26)
        Me.TxtBoxSiteWeb.TabIndex = 25
        '
        'LabelSiteWeb
        '
        Me.LabelSiteWeb.AutoSize = True
        Me.LabelSiteWeb.Location = New System.Drawing.Point(746, 380)
        Me.LabelSiteWeb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSiteWeb.Name = "LabelSiteWeb"
        Me.LabelSiteWeb.Size = New System.Drawing.Size(83, 20)
        Me.LabelSiteWeb.TabIndex = 22
        Me.LabelSiteWeb.Text = "Site-Web :"
        '
        'LabelFax
        '
        Me.LabelFax.AutoSize = True
        Me.LabelFax.Location = New System.Drawing.Point(746, 329)
        Me.LabelFax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFax.Name = "LabelFax"
        Me.LabelFax.Size = New System.Drawing.Size(43, 20)
        Me.LabelFax.TabIndex = 21
        Me.LabelFax.Text = "Fax :"
        '
        'LabelTel2
        '
        Me.LabelTel2.AutoSize = True
        Me.LabelTel2.Location = New System.Drawing.Point(746, 277)
        Me.LabelTel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTel2.Name = "LabelTel2"
        Me.LabelTel2.Size = New System.Drawing.Size(105, 20)
        Me.LabelTel2.TabIndex = 20
        Me.LabelTel2.Text = "Téléphone 2 :"
        '
        'LabelTel1
        '
        Me.LabelTel1.AutoSize = True
        Me.LabelTel1.Location = New System.Drawing.Point(746, 220)
        Me.LabelTel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTel1.Name = "LabelTel1"
        Me.LabelTel1.Size = New System.Drawing.Size(105, 20)
        Me.LabelTel1.TabIndex = 19
        Me.LabelTel1.Text = "Téléphone 1 :"
        '
        'LabelPays
        '
        Me.LabelPays.AutoSize = True
        Me.LabelPays.Location = New System.Drawing.Point(746, 155)
        Me.LabelPays.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPays.Name = "LabelPays"
        Me.LabelPays.Size = New System.Drawing.Size(51, 20)
        Me.LabelPays.TabIndex = 18
        Me.LabelPays.Text = "Pays :"
        '
        'LabelCodePostal
        '
        Me.LabelCodePostal.AutoSize = True
        Me.LabelCodePostal.Location = New System.Drawing.Point(746, 94)
        Me.LabelCodePostal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelCodePostal.Name = "LabelCodePostal"
        Me.LabelCodePostal.Size = New System.Drawing.Size(102, 20)
        Me.LabelCodePostal.TabIndex = 17
        Me.LabelCodePostal.Text = "Code postal :"
        '
        'LabelProvince
        '
        Me.LabelProvince.AutoSize = True
        Me.LabelProvince.Location = New System.Drawing.Point(746, 40)
        Me.LabelProvince.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelProvince.Name = "LabelProvince"
        Me.LabelProvince.Size = New System.Drawing.Size(77, 20)
        Me.LabelProvince.TabIndex = 16
        Me.LabelProvince.Text = "Province :"
        '
        'TxtBoxEmail
        '
        Me.TxtBoxEmail.Location = New System.Drawing.Point(266, 266)
        Me.TxtBoxEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxEmail.Name = "TxtBoxEmail"
        Me.TxtBoxEmail.Size = New System.Drawing.Size(290, 26)
        Me.TxtBoxEmail.TabIndex = 4
        '
        'LabelNoCompte
        '
        Me.LabelNoCompte.AutoSize = True
        Me.LabelNoCompte.Location = New System.Drawing.Point(32, 46)
        Me.LabelNoCompte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNoCompte.Name = "LabelNoCompte"
        Me.LabelNoCompte.Size = New System.Drawing.Size(119, 20)
        Me.LabelNoCompte.TabIndex = 0
        Me.LabelNoCompte.Text = "No de Compte :"
        '
        'TxtBoxFonction
        '
        Me.TxtBoxFonction.Location = New System.Drawing.Point(266, 205)
        Me.TxtBoxFonction.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxFonction.Name = "TxtBoxFonction"
        Me.TxtBoxFonction.Size = New System.Drawing.Size(290, 26)
        Me.TxtBoxFonction.TabIndex = 3
        '
        'LabelVille
        '
        Me.LabelVille.AutoSize = True
        Me.LabelVille.Location = New System.Drawing.Point(32, 386)
        Me.LabelVille.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelVille.Name = "LabelVille"
        Me.LabelVille.Size = New System.Drawing.Size(46, 20)
        Me.LabelVille.TabIndex = 6
        Me.LabelVille.Text = "Ville: "
        '
        'LabelSocieté
        '
        Me.LabelSocieté.AutoSize = True
        Me.LabelSocieté.Location = New System.Drawing.Point(32, 100)
        Me.LabelSocieté.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelSocieté.Name = "LabelSocieté"
        Me.LabelSocieté.Size = New System.Drawing.Size(71, 20)
        Me.LabelSocieté.TabIndex = 1
        Me.LabelSocieté.Text = "Societé :"
        '
        'LabelAdresse
        '
        Me.LabelAdresse.AutoSize = True
        Me.LabelAdresse.Location = New System.Drawing.Point(30, 335)
        Me.LabelAdresse.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelAdresse.Name = "LabelAdresse"
        Me.LabelAdresse.Size = New System.Drawing.Size(80, 20)
        Me.LabelAdresse.TabIndex = 5
        Me.LabelAdresse.Text = "Adresse : "
        '
        'TxtBoxContact
        '
        Me.TxtBoxContact.Location = New System.Drawing.Point(266, 151)
        Me.TxtBoxContact.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxContact.Name = "TxtBoxContact"
        Me.TxtBoxContact.Size = New System.Drawing.Size(290, 26)
        Me.TxtBoxContact.TabIndex = 2
        '
        'LabelContact
        '
        Me.LabelContact.AutoSize = True
        Me.LabelContact.Location = New System.Drawing.Point(30, 162)
        Me.LabelContact.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelContact.Name = "LabelContact"
        Me.LabelContact.Size = New System.Drawing.Size(73, 20)
        Me.LabelContact.TabIndex = 2
        Me.LabelContact.Text = "Contact :"
        '
        'TxtBoxSocieté
        '
        Me.TxtBoxSocieté.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBoxSocieté.Location = New System.Drawing.Point(266, 89)
        Me.TxtBoxSocieté.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxSocieté.Name = "TxtBoxSocieté"
        Me.TxtBoxSocieté.Size = New System.Drawing.Size(288, 26)
        Me.TxtBoxSocieté.TabIndex = 1
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Location = New System.Drawing.Point(32, 277)
        Me.LabelEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(61, 20)
        Me.LabelEmail.TabIndex = 4
        Me.LabelEmail.Text = "E-mail :"
        '
        'LabelFonction
        '
        Me.LabelFonction.AutoSize = True
        Me.LabelFonction.Location = New System.Drawing.Point(30, 215)
        Me.LabelFonction.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelFonction.Name = "LabelFonction"
        Me.LabelFonction.Size = New System.Drawing.Size(79, 20)
        Me.LabelFonction.TabIndex = 3
        Me.LabelFonction.Text = "Fonction :"
        '
        'TxtBoxNoCompte
        '
        Me.TxtBoxNoCompte.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.TxtBoxNoCompte.Location = New System.Drawing.Point(266, 35)
        Me.TxtBoxNoCompte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxNoCompte.Name = "TxtBoxNoCompte"
        Me.TxtBoxNoCompte.Size = New System.Drawing.Size(290, 26)
        Me.TxtBoxNoCompte.TabIndex = 0
        '
        'BtnChercher
        '
        Me.BtnChercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChercher.Location = New System.Drawing.Point(39, 146)
        Me.BtnChercher.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnChercher.Name = "BtnChercher"
        Me.BtnChercher.Size = New System.Drawing.Size(202, 57)
        Me.BtnChercher.TabIndex = 29
        Me.BtnChercher.Text = "Chercher"
        Me.BtnChercher.UseVisualStyleBackColor = True
        '
        'BtnModifier
        '
        Me.BtnModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModifier.Location = New System.Drawing.Point(39, 268)
        Me.BtnModifier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(202, 57)
        Me.BtnModifier.TabIndex = 30
        Me.BtnModifier.Text = "Modifier"
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnnuler.Location = New System.Drawing.Point(39, 491)
        Me.BtnAnnuler.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(202, 57)
        Me.BtnAnnuler.TabIndex = 31
        Me.BtnAnnuler.Text = "Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = True
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitter.Location = New System.Drawing.Point(39, 658)
        Me.BtnQuitter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(202, 57)
        Me.BtnQuitter.TabIndex = 32
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(500, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(575, 34)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Modifier / Supprimer fournisseur"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnSupprimer
        '
        Me.BtnSupprimer.Location = New System.Drawing.Point(39, 382)
        Me.BtnSupprimer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSupprimer.Name = "BtnSupprimer"
        Me.BtnSupprimer.Size = New System.Drawing.Size(202, 57)
        Me.BtnSupprimer.TabIndex = 42
        Me.BtnSupprimer.Text = "Supprimer"
        Me.BtnSupprimer.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(18, 89)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(244, 656)
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'FrmModifierFournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1626, 785)
        Me.Controls.Add(Me.BtnSupprimer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.BtnAnnuler)
        Me.Controls.Add(Me.BtnModifier)
        Me.Controls.Add(Me.BtnChercher)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BoxContactFournisseur)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmModifierFournisseur"
        Me.Text = "Modifier fournisseur"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.BoxContactFournisseur.ResumeLayout(False)
        Me.BoxContactFournisseur.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtBoxCompte As TextBox
    Friend WithEvents TxtBoxCodeBanque As TextBox
    Friend WithEvents TxtBoxVilleBanque As TextBox
    Friend WithEvents TxtBoxAdresseBanque As TextBox
    Friend WithEvents TxtBoxNomBanque As TextBox
    Friend WithEvents TxtBoxNomComptable As TextBox
    Friend WithEvents LabelCompte As Label
    Friend WithEvents LabelCodeBanque As Label
    Friend WithEvents labelVillebanque As Label
    Friend WithEvents LabelAdresseBanque As Label
    Friend WithEvents LabelNomBanque As Label
    Friend WithEvents LabelNomComptable As Label
    Friend WithEvents BoxContactFournisseur As GroupBox
    Friend WithEvents TxtBoxAdresse As TextBox
    Friend WithEvents TxtBoxVille As TextBox
    Friend WithEvents TxtBoxProvince As TextBox
    Friend WithEvents TxtBoxCodePostal As TextBox
    Friend WithEvents TxtBoxPays As TextBox
    Friend WithEvents TxtBoxTéléphone1 As TextBox
    Friend WithEvents TxtBoxTéléphone2 As TextBox
    Friend WithEvents TxtBoxFax As TextBox
    Friend WithEvents TxtBoxSiteWeb As TextBox
    Friend WithEvents LabelSiteWeb As Label
    Friend WithEvents LabelFax As Label
    Friend WithEvents LabelTel2 As Label
    Friend WithEvents LabelTel1 As Label
    Friend WithEvents LabelPays As Label
    Friend WithEvents LabelCodePostal As Label
    Friend WithEvents LabelProvince As Label
    Friend WithEvents TxtBoxEmail As TextBox
    Friend WithEvents LabelNoCompte As Label
    Friend WithEvents TxtBoxFonction As TextBox
    Friend WithEvents LabelVille As Label
    Friend WithEvents LabelSocieté As Label
    Friend WithEvents LabelAdresse As Label
    Friend WithEvents TxtBoxContact As TextBox
    Friend WithEvents LabelContact As Label
    Friend WithEvents TxtBoxSocieté As TextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelFonction As Label
    Friend WithEvents TxtBoxNoCompte As TextBox
    Friend WithEvents BtnChercher As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSupprimer As Button
End Class
