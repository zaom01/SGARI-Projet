Imports System.IO
Public Class Form1
    Public Property vbnetForm As Object

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub mnuQuitter_Click(sender As Object, e As EventArgs) Handles mnuQuitter.Click
        If MsgBox("Voulez-Vous Vraiment quitter le logiciel SGARI", MsgBoxStyle.YesNo + vbQuestion, "SGARI") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub AchévementDesContratsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AchévementDesContratsToolStripMenuItem.Click
        Dim resultat As String
        resultat = PrintDialog1.ShowDialog
        Select Case resultat
            Case 1
                MsgBox("Les documents sont envoyés a l'imprimante avec succés", vbOK + vbInformation, "Impression du document")
            Case 2
                MsgBox("L'impression a ete annulée", vbOK + vbInformation, "Impression du document")
        End Select
    End Sub
    Sub DesactiverMenu()
        Me.mnuContrat.Enabled = False
        Me.mnuÉquipement.Enabled = False
        Me.mnuService.Enabled = False
        Me.mnuFacturation.Enabled = False

        Me.mnuFournisseur.Enabled = False
        Me.mnuRapport.Enabled = False
        Me.mnuSécurité.Enabled = False

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesactiverMenu()

        FrmLogin.MdiParent = Me
        FrmLogin.Show()
    End Sub

    Private Sub mnuÉquipement_Click(sender As Object, e As EventArgs) Handles mnuÉquipement.Click
        'FrmEquipement.MdiParent = Me
        FrmEquipement.Show()
    End Sub

    Private Sub mnuFactures_Click(sender As Object, e As EventArgs) Handles mnuFactures.Click
        FrmFacture.Show()
    End Sub

    Private Sub NouveauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem.Click
        FrmNewFournisseur.Show()
    End Sub

    Private Sub mnuCrée_Click(sender As Object, e As EventArgs) Handles mnuCrée.Click
        FrmCreer.Show()
    End Sub

    Private Sub mnuRenouveler_Click(sender As Object, e As EventArgs) Handles mnuRenouveler.Click
        FrmRenouveller.Show()
    End Sub

    Private Sub mnuRésilier_Click(sender As Object, e As EventArgs) Handles mnuRésilier.Click
        FrmResilier.Show()


    End Sub

    Private Sub mnuConsulter_Click(sender As Object, e As EventArgs) Handles mnuConsulter.Click
        FrmConsulter.Show()

    End Sub

    Private Sub mnuModifier_Click(sender As Object, e As EventArgs) Handles mnuModifier.Click
        FrmModifier.Show()

    End Sub







    Private Sub ÀProposSGARIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÀProposSGARIToolStripMenuItem.Click
        Apropos.Show()
    End Sub

    Private Sub ListeDesUtililisateursToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesUtililisateursToolStripMenuItem.Click
        ListeUtilisateur.Show()

    End Sub

    Private Sub ChangerLeMotDePasseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangerLeMotDePasseToolStripMenuItem.Click
        FrmChangerMotdePasse.Show()

    End Sub

    Private Sub ModifierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifierToolStripMenuItem.Click
        FrmModifierFournisseur.Show()

    End Sub

    Private Sub ÉquipementsÀCommanderToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ÉquipementsÀCommanderToolStripMenuItem1.Click
        Dim resultat As String
        resultat = PrintDialog1.ShowDialog
        Select Case resultat
            Case 1
                MsgBox("Les documents sont envoyés a l'imprimante avec succés", vbOK + vbInformation, "Impression du document")
            Case 2
                MsgBox("L'impression a ete annulée", vbOK + vbInformation, "Impression du document")
        End Select
    End Sub

    Private Sub ÉquipementsÀRetournerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÉquipementsÀRetournerToolStripMenuItem.Click
        Dim resultat As String
        resultat = PrintDialog1.ShowDialog
        Select Case resultat
            Case 1
                MsgBox("Les documents sont envoyés a l'imprimante avec succés", vbOK + vbInformation, "Impression du document")
            Case 2
                MsgBox("L'impression a ete annulée", vbOK + vbInformation, "Impression du document")
        End Select
    End Sub

    Private Sub ControleDesAccésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControleDesAccésToolStripMenuItem.Click
        Dim resultat As String
        resultat = PrintDialog1.ShowDialog
        Select Case resultat
            Case 1
                MsgBox("Les documents sont envoyés a l'imprimante avec succés", vbOK + vbInformation, "Impression du document")
            Case 2
                MsgBox("L'impression a ete annulée", vbOK + vbInformation, "Impression du document")
        End Select
    End Sub

    Private Sub ContratsOuvertsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratsOuvertsToolStripMenuItem.Click
        Dim resultat As String
        resultat = PrintDialog1.ShowDialog
        Select Case resultat
            Case 1
                MsgBox("Les documents sont envoyés a l'imprimante avec succés", vbOK + vbInformation, "Impression du document")
            Case 2
                MsgBox("L'impression a ete annulée", vbOK + vbInformation, "Impression du document")
        End Select
    End Sub

    Private Sub ContratsRésiliersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ContratsRésiliersToolStripMenuItem.Click
        Dim resultat As String
        resultat = PrintDialog1.ShowDialog
        Select Case resultat
            Case 1
                MsgBox("Les documents sont envoyés a l'imprimante avec succés", vbOK + vbInformation, "Impression du document")
            Case 2
                MsgBox("L'impression a ete annulée", vbOK + vbInformation, "Impression du document")
        End Select
    End Sub

    Private Sub PaiementParCarteCréditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaiementParCarteCréditToolStripMenuItem.Click
        Dim resultat As String
        resultat = PrintDialog1.ShowDialog
        Select Case resultat
            Case 1
                MsgBox("Les documents sont envoyés a l'imprimante avec succés", vbOK + vbInformation, "Impression du document")
            Case 2
                MsgBox("L'impression a ete annulée", vbOK + vbInformation, "Impression du document")
        End Select
    End Sub

    Private Sub PaiementParRetraitDirectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaiementParRetraitDirectToolStripMenuItem.Click
        Dim resultat As String
        resultat = PrintDialog1.ShowDialog
        Select Case resultat
            Case 1
                MsgBox("Les documents sont envoyés a l'imprimante avec succés", vbOK + vbInformation, "Impression du document")
            Case 2
                MsgBox("L'impression a ete annulée", vbOK + vbInformation, "Impression du document")
        End Select
    End Sub

    Private Sub ClientsContentieuxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientsContentieuxToolStripMenuItem.Click
        Dim resultat As String
        resultat = PrintDialog1.ShowDialog
        Select Case resultat
            Case 1
                MsgBox("Les documents sont envoyés a l'imprimante avec succés", vbOK + vbInformation, "Impression du document")
            Case 2
                MsgBox("L'impression a ete annulée", vbOK + vbInformation, "Impression du document")
        End Select
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        FrmCreer.Show()

    End Sub

    Private Sub mnuPaiement_Click(sender As Object, e As EventArgs) Handles mnuPaiement.Click
        Paiement.Show()

    End Sub

    Private Sub mnuService_Click(sender As Object, e As EventArgs) Handles mnuService.Click
        Service.Show()

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub
End Class
