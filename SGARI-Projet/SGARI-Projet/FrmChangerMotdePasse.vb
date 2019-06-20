Public Class FrmChangerMotdePasse

    Private Sub FrmChangerMotdePasse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TxtBoxUtilisateur.Text = varUtilisateur
        'TextBoxAncPwd.Text = varancmotdepasse
        TextBoxNewPass.Select()



    End Sub

    Private Sub BtnValider_Click(sender As Object, e As EventArgs) Handles BtnValider.Click

        If TextBoxConfirmeMP.Text = TextBoxNewPass.Text Then
            varancmotdepasse = TextBoxNewPass.Text
            MsgBox("Le mot de passe est bien changer")

        Else
            MsgBox("Le mot de passe est erroné")
        End If
    End Sub

    'Effacer les donner des nouveau mit de passe
    Sub EffacerMP()
        TextBoxNewPass.Text = ""
        TextBoxConfirmeMP.Text = ""


    End Sub

    Private Sub BtnAnnuler_Click(sender As Object, e As EventArgs) Handles BtnAnnuler.Click
        EffacerMP()
    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Close()

    End Sub


End Class