Public Class Taxes
    'Ancien Taxe
    Dim ancienTaxe As Double
    Private Sub Taxes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CHarger les taxes dans le comboBox
        Dim tabutilisateur() As String = {"TPS", "TVQ", "", ""}
        Groupoperation.Enabled = False
        Combotaxes.DataSource = tabutilisateur


        ProcTaux()
        'trendre le curseur sur le comboTaxe
        Me.Combotaxes.Select()
    End Sub
    Sub ProcTaux()
        'REcuperer les taux desz taxes
        If Combotaxes.Text = "TPS" Then
            TextTaux.Text = TaxeTPS
            ancienTaxe = TaxeTPS
        ElseIf Combotaxes.Text = "TVQ" Then
            TextTaux.Text = TaxeTVQ
            'sauvegarder l"ancien Taux
            ancienTaxe = TaxeTVQ
        End If

    End Sub

    Private Sub TextTaux_TextChanged(sender As Object, e As EventArgs) Handles TextTaux.TextChanged

    End Sub



    Private Sub TextTaux_ModifiedChanged(sender As Object, e As EventArgs) Handles TextTaux.ModifiedChanged
        'Activer le menu
        Groupoperation.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'recuper taux avant la modification
        TextTaux.Text = ancienTaxe
        Groupoperation.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'tester sur le taux 
        If Trim(LTrim(TextTaux.Text)) = "" Then
            TextTaux.Text = 0
        End If
        'mise a jour les nouveaux Taxes
        If Combotaxes.Text = "TPS" Then
            TaxeTPS = Val(TextTaux.Text)
        ElseIf Combotaxes.Text = "TVQ" Then
            TaxeTVQ = Val(TextTaux.Text)

        End If
        'Groupoperation.Enabled = False
    End Sub

    Private Sub Combotaxes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combotaxes.SelectedIndexChanged

    End Sub
End Class