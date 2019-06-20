Public Class FrmLogin


    Private Sub BtnSeconnecter_Click(sender As Object, e As EventArgs) Handles BtnSeconnecter.Click
        Dim username, password As String
        username = "administrateur"
        password = "Master"





        If UsrTxt.Text = LTrim(username) And PwTxt.Text = LTrim(password) Then
            MsgBox("Connection avec succès", MsgBoxStyle.OkOnly + vbInformation, "Ouverture de session/SGARI")
            ActiverMenu()
            Me.Close()

        ElseIf UsrTxt.Text <> username Or PwTxt.Text <> password Then

            MessageBox.Show("Votre nom utilisateur et/ou mot de passe sont invalides", "Message Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Me.PwTxt.Select()

        End If
    End Sub

    Private Sub Annuler_Click(sender As Object, e As EventArgs) Handles Annuler.Click
        End
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabutilisateur() As String = {"administrateur", "Ahmed", "Mouna", "Grace"}
        UsrTxt.DataSource = tabutilisateur
        ' UsrTxt.Items.Add("Administrateur")
        PwTxt.Text = "Master"
        varancmotdepasse = PwTxt.Text
        varUtilisateur = UsrTxt.Text
        Me.PwTxt.Select()
    End Sub
    'Activer le menu Principal du Form1(Feuille pricipale de démarrage)
    Sub ActiverMenu()
        Form1.mnuContrat.Enabled = True
        Form1.mnuÉquipement.Enabled = True
        Form1.mnuService.Enabled = True
        Form1.mnuFacturation.Enabled = True
        Form1.mnuFournisseur.Enabled = True
        Form1.mnuRapport.Enabled = True
        Form1.mnuSécurité.Enabled = True

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub UsrTxt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UsrTxt.SelectedIndexChanged

    End Sub
End Class
