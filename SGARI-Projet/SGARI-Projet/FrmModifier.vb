Imports System.Data.OleDb
Public Class FrmModifier
    'Déclaration des objets de la base de données et variables
    Dim objCnn As New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\SgariBdd.accdb")

    Dim objCmd As New System.Data.OleDb.OleDbCommand

    Dim strTBoxMTCnt, strTBoxMDO, strTBoxMDF, strTBoxMLocation, strTBoxMService, strTBoxMDMV As String
    Dim TYPECONTRAT, DATEOUVERTURE, DATEFERMETURE, LOCATIONEQUIPEMENT, SERVICES, DATEMISEENVIGUEUR As String

    Dim strSQLSearch, strSQLModif As String

    'Fermeture de la fenêtre
    Private Sub BtnMQuitter_Click(sender As Object, e As EventArgs) Handles BtnMQuitter.Click
        Me.Close()
    End Sub

    'Procédure de nettoyage de la fenêtre
    Private Sub BtnMNSearch_Click(sender As Object, e As EventArgs) Handles BtnMNSearch.Click
        EffacerTxtBxM()
    End Sub

    'Procédure de mise à jour de la base de données
    Private Sub BtnModifier_Click(sender As Object, e As EventArgs) Handles BtnModifier.Click
        Dim intLblMNCnt As Integer

        intLblMNCnt = Convert.ToInt32(LblMNC.Text)
        strTBoxMTCnt = TBoxMTCnt.Text
        strTBoxMDO = TBoxMDO.Text
        strTBoxMDF = TBoxMDF.Text
        strTBoxMLocation = TBoxMLocation.Text
        strTBoxMService = TBoxMService.Text
        strTBoxMDMV = TBoxMDMV.Text
        If objCnn.State = ConnectionState.Closed Then
            objCnn.Open()
        End If

        Try
            strSQLModif = "UPDATE CONTRAT SET TYPECONTRAT = " & strTBoxMTCnt &
                        ", DATEOUVERTURE = " & strTBoxMDO &
                        ", DATEFERMETURE = " & strTBoxMDF &
                        ", LOCATIONEQUIPEMENT = " & strTBoxMLocation &
                        ", SERVICES = " & strTBoxMService & " WHERE (((CONTRAT.NUMCONTRAT)=  " & intLblMNCnt & "))" '"
            objCmd = New OleDbCommand(strSQLModif, objCnn)
            objCmd.ExecuteNonQuery()

            LblMessageMaj.Visible = True
            LblMessageMaj.Text = "Le contrat a bien été mis à jour"

        Catch
            LblMessageMaj.Visible = True
            LblMessageMaj.Text = "Le contrat a bien été mis à jour"
        End Try
        objCnn.Close()
        EffacerTxtBxM()
    End Sub


    'Nous rendons invibles les Label dans cette procédure
    Private Sub FrmModifier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblMessage.Visible = False
        LblMessageMaj.Visible = False
    End Sub

    ' Procédure d'effacement des textbox et autres 
    Sub EffacerTxtBxM()


        LblMessage.ResetText()
        LblMessageMaj.ResetText()
        LblMNC.ResetText()
        TxtBoxNumCnt.Clear()
        TBoxMTCnt.Clear()
        TBoxMDO.Clear()
        TBoxMDF.Clear()
        TBoxMLocation.Clear()
        TBoxMService.Clear()
        TBoxMDMV.Clear()

    End Sub

    'Procédure de recherche et d'affichage du résultat
    Private Sub BtnRechercher_Click(sender As Object, e As EventArgs) Handles BtnRechercher.Click
        Dim objAdt As OleDbDataAdapter
        Dim objDs As New DataSet
        Dim intTxtBoxNumCnt As Integer
        intTxtBoxNumCnt = Convert.ToInt32(TxtBoxNumCnt.Text)
        objCmd.CommandType = System.Data.CommandType.Text

        EffacerTxtBxM()

        Try
            objCnn.Open()
            strSQLSearch = "SELECT CONTRAT.NUMCONTRAT, CONTRAT.TYPECONTRAT, CONTRAT.DATEOUVERTURE, CONTRAT.DATEFERMETURE, CONTRAT.LOCATIONEQUIPEMENT, CONTRAT.SERVICES, CONTRAT.DATEMISEENVIGUEUR
                        From CONTRAT
                        Where (((CONTRAT.NUMCONTRAT) = " & intTxtBoxNumCnt & "))" '"

            objAdt = New OleDbDataAdapter(strSQLSearch, objCnn)
            objAdt.Fill(objDs, "Contrat")

            If objDs.Tables("contrat").Rows.Count > 0 Then
                LblMNC.Text = objDs.Tables("Contrat").Rows(0)("NumContrat").ToString()
                TBoxMTCnt.Text = objDs.Tables("Contrat").Rows(0)("TYPECONTRAT").ToString()
                TBoxMDO.Text = objDs.Tables("Contrat").Rows(0)("DATEOUVERTURE").ToString()
                TBoxMDF.Text = objDs.Tables("Contrat").Rows(0)("DATEFERMETURE").ToString()
                TBoxMLocation.Text = objDs.Tables("Contrat").Rows(0)("LOCATIONEQUIPEMENT").ToString()
                TBoxMService.Text = objDs.Tables("Contrat").Rows(0)("SERVICES").ToString()
                TBoxMDMV.Text = objDs.Tables("Contrat").Rows(0)("DATEMISEENVIGUEUR").ToString()
                LblMessage.Visible = True
                LblMessage.Text = "Le contrat a été trouvé"
            Else
                LblMessage.Visible = True
                LblMessage.Text = "Le contrat n'a été trouvé"

            End If
            objCnn.Close()
            objAdt.Dispose()
        Catch ex As Exception
            LblMessage.Visible = True
            LblMessage.Text = ex.Message

        End Try

    End Sub

End Class