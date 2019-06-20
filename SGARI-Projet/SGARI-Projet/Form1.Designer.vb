<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.mnuContrat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCrée = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRenouveler = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRésilier = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuConsulter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModifier = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuQuitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuÉquipement = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuService = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFacturation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFactures = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaiement = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuTaxe = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFournisseur = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRapport = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÉquipementsÀCommanderToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.AchévementDesContratsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÉquipementsÀCommanderToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÉquipementsÀRetournerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ControleDesAccésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContratsOuvertsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratsRésiliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator()
        Me.PaiementParCarteCréditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaiementParRetraitDirectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClientsContentieuxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSécurité = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjoutModificationDestructionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangerLeMotDePasseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListeDesUtililisateursToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÀProposSGARIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuContrat, Me.mnuÉquipement, Me.mnuService, Me.mnuFacturation, Me.mnuFournisseur, Me.mnuRapport, Me.mnuSécurité, Me.ToolStripMenuItem2})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(9, 3, 0, 3)
        Me.MenuStrip2.Size = New System.Drawing.Size(1108, 35)
        Me.MenuStrip2.TabIndex = 3
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'mnuContrat
        '
        Me.mnuContrat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCrée, Me.mnuRenouveler, Me.mnuRésilier, Me.ToolStripMenuItem4, Me.mnuConsulter, Me.mnuModifier, Me.ToolStripMenuItem5, Me.mnuQuitter})
        Me.mnuContrat.Name = "mnuContrat"
        Me.mnuContrat.Size = New System.Drawing.Size(83, 29)
        Me.mnuContrat.Text = "&Contrat"
        '
        'mnuCrée
        '
        Me.mnuCrée.Name = "mnuCrée"
        Me.mnuCrée.Size = New System.Drawing.Size(183, 30)
        Me.mnuCrée.Text = "C&réer"
        '
        'mnuRenouveler
        '
        Me.mnuRenouveler.Name = "mnuRenouveler"
        Me.mnuRenouveler.Size = New System.Drawing.Size(183, 30)
        Me.mnuRenouveler.Text = "Re&nouveler"
        '
        'mnuRésilier
        '
        Me.mnuRésilier.Name = "mnuRésilier"
        Me.mnuRésilier.Size = New System.Drawing.Size(183, 30)
        Me.mnuRésilier.Text = "Ré&silier"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(180, 6)
        '
        'mnuConsulter
        '
        Me.mnuConsulter.Name = "mnuConsulter"
        Me.mnuConsulter.Size = New System.Drawing.Size(183, 30)
        Me.mnuConsulter.Text = "Consul&ter"
        '
        'mnuModifier
        '
        Me.mnuModifier.Name = "mnuModifier"
        Me.mnuModifier.Size = New System.Drawing.Size(183, 30)
        Me.mnuModifier.Text = "&Modifier"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(180, 6)
        '
        'mnuQuitter
        '
        Me.mnuQuitter.Name = "mnuQuitter"
        Me.mnuQuitter.Size = New System.Drawing.Size(183, 30)
        Me.mnuQuitter.Text = "&Quitter"
        '
        'mnuÉquipement
        '
        Me.mnuÉquipement.Name = "mnuÉquipement"
        Me.mnuÉquipement.Size = New System.Drawing.Size(119, 29)
        Me.mnuÉquipement.Text = "&Équipement"
        '
        'mnuService
        '
        Me.mnuService.Name = "mnuService"
        Me.mnuService.Size = New System.Drawing.Size(79, 29)
        Me.mnuService.Text = "Ser&vice"
        '
        'mnuFacturation
        '
        Me.mnuFacturation.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFactures, Me.mnuPaiement, Me.ToolStripMenuItem6, Me.mnuTaxe})
        Me.mnuFacturation.Name = "mnuFacturation"
        Me.mnuFacturation.Size = New System.Drawing.Size(111, 29)
        Me.mnuFacturation.Text = "&Facturation"
        '
        'mnuFactures
        '
        Me.mnuFactures.Name = "mnuFactures"
        Me.mnuFactures.Size = New System.Drawing.Size(168, 30)
        Me.mnuFactures.Text = "F&actures"
        '
        'mnuPaiement
        '
        Me.mnuPaiement.Name = "mnuPaiement"
        Me.mnuPaiement.Size = New System.Drawing.Size(168, 30)
        Me.mnuPaiement.Text = "&Paiement"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(165, 6)
        '
        'mnuTaxe
        '
        Me.mnuTaxe.Name = "mnuTaxe"
        Me.mnuTaxe.Size = New System.Drawing.Size(168, 30)
        Me.mnuTaxe.Text = "&Taxe"
        '
        'mnuFournisseur
        '
        Me.mnuFournisseur.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem, Me.ModifierToolStripMenuItem})
        Me.mnuFournisseur.Name = "mnuFournisseur"
        Me.mnuFournisseur.Size = New System.Drawing.Size(115, 29)
        Me.mnuFournisseur.Text = "&Fournisseur"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(167, 30)
        Me.NouveauToolStripMenuItem.Text = "Nouveau"
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(167, 30)
        Me.ModifierToolStripMenuItem.Text = "Modifier"
        '
        'mnuRapport
        '
        Me.mnuRapport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÉquipementsÀCommanderToolStripMenuItem, Me.AchévementDesContratsToolStripMenuItem, Me.ÉquipementsÀCommanderToolStripMenuItem1, Me.ÉquipementsÀRetournerToolStripMenuItem, Me.ToolStripMenuItem7, Me.ControleDesAccésToolStripMenuItem, Me.ToolStripMenuItem8, Me.ContratsOuvertsToolStripMenuItem, Me.ContratsRésiliersToolStripMenuItem, Me.ToolStripMenuItem9, Me.PaiementParCarteCréditToolStripMenuItem, Me.PaiementParRetraitDirectToolStripMenuItem, Me.ToolStripMenuItem10, Me.ClientsContentieuxToolStripMenuItem})
        Me.mnuRapport.Name = "mnuRapport"
        Me.mnuRapport.Size = New System.Drawing.Size(97, 29)
        Me.mnuRapport.Text = "&Rapports"
        '
        'ÉquipementsÀCommanderToolStripMenuItem
        '
        Me.ÉquipementsÀCommanderToolStripMenuItem.Name = "ÉquipementsÀCommanderToolStripMenuItem"
        Me.ÉquipementsÀCommanderToolStripMenuItem.Size = New System.Drawing.Size(311, 6)
        '
        'AchévementDesContratsToolStripMenuItem
        '
        Me.AchévementDesContratsToolStripMenuItem.Name = "AchévementDesContratsToolStripMenuItem"
        Me.AchévementDesContratsToolStripMenuItem.Size = New System.Drawing.Size(314, 30)
        Me.AchévementDesContratsToolStripMenuItem.Text = "&Achévement des contrats"
        '
        'ÉquipementsÀCommanderToolStripMenuItem1
        '
        Me.ÉquipementsÀCommanderToolStripMenuItem1.Name = "ÉquipementsÀCommanderToolStripMenuItem1"
        Me.ÉquipementsÀCommanderToolStripMenuItem1.Size = New System.Drawing.Size(314, 30)
        Me.ÉquipementsÀCommanderToolStripMenuItem1.Text = "&Équipements à commander"
        '
        'ÉquipementsÀRetournerToolStripMenuItem
        '
        Me.ÉquipementsÀRetournerToolStripMenuItem.Name = "ÉquipementsÀRetournerToolStripMenuItem"
        Me.ÉquipementsÀRetournerToolStripMenuItem.Size = New System.Drawing.Size(314, 30)
        Me.ÉquipementsÀRetournerToolStripMenuItem.Text = "Équipements à Retourner"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(311, 6)
        '
        'ControleDesAccésToolStripMenuItem
        '
        Me.ControleDesAccésToolStripMenuItem.Name = "ControleDesAccésToolStripMenuItem"
        Me.ControleDesAccésToolStripMenuItem.Size = New System.Drawing.Size(314, 30)
        Me.ControleDesAccésToolStripMenuItem.Text = "Controle des accés"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(311, 6)
        '
        'ContratsOuvertsToolStripMenuItem
        '
        Me.ContratsOuvertsToolStripMenuItem.Name = "ContratsOuvertsToolStripMenuItem"
        Me.ContratsOuvertsToolStripMenuItem.Size = New System.Drawing.Size(314, 30)
        Me.ContratsOuvertsToolStripMenuItem.Text = "Contrats ouverts"
        '
        'ContratsRésiliersToolStripMenuItem
        '
        Me.ContratsRésiliersToolStripMenuItem.Name = "ContratsRésiliersToolStripMenuItem"
        Me.ContratsRésiliersToolStripMenuItem.Size = New System.Drawing.Size(314, 30)
        Me.ContratsRésiliersToolStripMenuItem.Text = "Contrats résiliers"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(311, 6)
        '
        'PaiementParCarteCréditToolStripMenuItem
        '
        Me.PaiementParCarteCréditToolStripMenuItem.Name = "PaiementParCarteCréditToolStripMenuItem"
        Me.PaiementParCarteCréditToolStripMenuItem.Size = New System.Drawing.Size(314, 30)
        Me.PaiementParCarteCréditToolStripMenuItem.Text = "Paiement par carte crédit"
        '
        'PaiementParRetraitDirectToolStripMenuItem
        '
        Me.PaiementParRetraitDirectToolStripMenuItem.Name = "PaiementParRetraitDirectToolStripMenuItem"
        Me.PaiementParRetraitDirectToolStripMenuItem.Size = New System.Drawing.Size(314, 30)
        Me.PaiementParRetraitDirectToolStripMenuItem.Text = "Paiement par retrait direct"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(311, 6)
        '
        'ClientsContentieuxToolStripMenuItem
        '
        Me.ClientsContentieuxToolStripMenuItem.Name = "ClientsContentieuxToolStripMenuItem"
        Me.ClientsContentieuxToolStripMenuItem.Size = New System.Drawing.Size(314, 30)
        Me.ClientsContentieuxToolStripMenuItem.Text = "Clients contentieux"
        '
        'mnuSécurité
        '
        Me.mnuSécurité.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjoutModificationDestructionToolStripMenuItem, Me.ChangerLeMotDePasseToolStripMenuItem, Me.ToolStripMenuItem11, Me.ListeDesUtililisateursToolStripMenuItem})
        Me.mnuSécurité.Name = "mnuSécurité"
        Me.mnuSécurité.Size = New System.Drawing.Size(86, 29)
        Me.mnuSécurité.Text = "&Sécurité"
        '
        'AjoutModificationDestructionToolStripMenuItem
        '
        Me.AjoutModificationDestructionToolStripMenuItem.Name = "AjoutModificationDestructionToolStripMenuItem"
        Me.AjoutModificationDestructionToolStripMenuItem.Size = New System.Drawing.Size(371, 30)
        Me.AjoutModificationDestructionToolStripMenuItem.Text = "Ajout/ Modification / Destruction..."
        '
        'ChangerLeMotDePasseToolStripMenuItem
        '
        Me.ChangerLeMotDePasseToolStripMenuItem.Name = "ChangerLeMotDePasseToolStripMenuItem"
        Me.ChangerLeMotDePasseToolStripMenuItem.Size = New System.Drawing.Size(371, 30)
        Me.ChangerLeMotDePasseToolStripMenuItem.Text = "Changer le mot de passe"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(368, 6)
        '
        'ListeDesUtililisateursToolStripMenuItem
        '
        Me.ListeDesUtililisateursToolStripMenuItem.Name = "ListeDesUtililisateursToolStripMenuItem"
        Me.ListeDesUtililisateursToolStripMenuItem.Size = New System.Drawing.Size(371, 30)
        Me.ListeDesUtililisateursToolStripMenuItem.Text = "Liste des utililisateurs..."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÀProposSGARIToolStripMenuItem})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(32, 29)
        Me.ToolStripMenuItem2.Text = "?"
        '
        'ÀProposSGARIToolStripMenuItem
        '
        Me.ÀProposSGARIToolStripMenuItem.Name = "ÀProposSGARIToolStripMenuItem"
        Me.ÀProposSGARIToolStripMenuItem.Size = New System.Drawing.Size(252, 30)
        Me.ÀProposSGARIToolStripMenuItem.Text = "À propos SGARI "
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SGARI_Projet.My.Resources.Resources.Abonnetf
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1108, 520)
        Me.Controls.Add(Me.MenuStrip2)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Gestion SGARI : Abonnet Inc"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents mnuContrat As ToolStripMenuItem
    Friend WithEvents mnuCrée As ToolStripMenuItem
    Friend WithEvents mnuRenouveler As ToolStripMenuItem
    Friend WithEvents mnuRésilier As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents mnuConsulter As ToolStripMenuItem
    Friend WithEvents mnuModifier As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents mnuQuitter As ToolStripMenuItem
    Friend WithEvents mnuÉquipement As ToolStripMenuItem
    Friend WithEvents mnuService As ToolStripMenuItem
    Friend WithEvents mnuFacturation As ToolStripMenuItem
    Friend WithEvents mnuFactures As ToolStripMenuItem
    Friend WithEvents mnuPaiement As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
    Friend WithEvents mnuTaxe As ToolStripMenuItem
    Friend WithEvents mnuFournisseur As ToolStripMenuItem
    Friend WithEvents mnuRapport As ToolStripMenuItem
    Friend WithEvents AchévementDesContratsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÉquipementsÀCommanderToolStripMenuItem As ToolStripSeparator
    Friend WithEvents ÉquipementsÀCommanderToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ÉquipementsÀRetournerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripSeparator
    Friend WithEvents ControleDesAccésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripSeparator
    Friend WithEvents ContratsOuvertsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContratsRésiliersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripSeparator
    Friend WithEvents PaiementParCarteCréditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaiementParRetraitDirectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripSeparator
    Friend WithEvents ClientsContentieuxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuSécurité As ToolStripMenuItem
    Friend WithEvents AjoutModificationDestructionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangerLeMotDePasseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripSeparator
    Friend WithEvents ListeDesUtililisateursToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ÀProposSGARIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents NouveauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifierToolStripMenuItem As ToolStripMenuItem
End Class
