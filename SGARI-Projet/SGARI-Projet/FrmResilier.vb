Public Class FrmResilier
    Private Sub CONTRATBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CONTRATBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CONTRATBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SgariBddDataSet)

    End Sub

    Private Sub FrmResilier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'SgariBddDataSet.CONTRAT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.CONTRATTableAdapter.Fill(Me.SgariBddDataSet.CONTRAT)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnResilier.Click

        TYPECONTRATTextBox.Text = "Inactif"
        Try
            CONTRATBindingSource.EndEdit()
            CONTRATTableAdapter.Update(SgariBddDataSet)
            MessageBox.Show("Modification effectuée", "Message de SGARI", MessageBoxButtons.OK, MessageBoxIcon.None)
        Catch
            MessageBox.Show("Échec de la modification, Merci de revérifier les champs", "Message de SGARI", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Close()

    End Sub

    Private Sub ButtonClendar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class