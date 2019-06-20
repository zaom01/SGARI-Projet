Public Class FrmRenouveller
    Private Sub CONTRATBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CONTRATBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CONTRATBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.SgariBddDataSet)

    End Sub

    Private Sub Renouveller2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'SgariBddDataSet.CONTRAT'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.CONTRATTableAdapter.Fill(Me.SgariBddDataSet.CONTRAT)

    End Sub

    Private Sub BtnRenouveller_Click(sender As Object, e As EventArgs) Handles BtnRenouveller.Click
        Try
            CONTRATBindingSource.EndEdit()
            CONTRATTableAdapter.Update(SgariBddDataSet)
            MsgBox("Le contrat est bien renouveller")


        Catch
        End Try
    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        Me.Close()

    End Sub

    Private Sub CONTRATDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CONTRATDataGridView.CellContentClick

    End Sub
End Class