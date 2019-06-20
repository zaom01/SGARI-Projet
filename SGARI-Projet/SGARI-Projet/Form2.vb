Public Class FrmTypeEquip
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListType.Items.Add(TextType.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListType.Items.Remove(ListType.SelectedItems(0))
        Button2.Enabled = False
    End Sub

    Private Sub ListType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListType.SelectedIndexChanged
        Button2.Enabled = True
        TextType.Text = ListType.SelectedItem.ToString
    End Sub

    Private Sub FrmTypeEquip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Enabled = False
    End Sub

    Private Sub TextType_TextChanged(sender As Object, e As EventArgs) Handles TextType.TextChanged

    End Sub
End Class