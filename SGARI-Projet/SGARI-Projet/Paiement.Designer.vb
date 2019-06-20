<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paiement
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
        Me.NumFacture = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateFacture = New System.Windows.Forms.TextBox()
        Me.NomClient = New System.Windows.Forms.TextBox()
        Me.Montantapayer = New System.Windows.Forms.TextBox()
        Me.GroupInformation = New System.Windows.Forms.GroupBox()
        Me.GroupPaaiement = New System.Windows.Forms.GroupBox()
        Me.Balance = New System.Windows.Forms.TextBox()
        Me.DatePaiement = New System.Windows.Forms.TextBox()
        Me.MntPayer = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupeCartecredit = New System.Windows.Forms.GroupBox()
        Me.ComboTypeCarte = New System.Windows.Forms.ComboBox()
        Me.TextDateEXPIRATION = New System.Windows.Forms.TextBox()
        Me.TextNcarte = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupType = New System.Windows.Forms.GroupBox()
        Me.Radiocheque = New System.Windows.Forms.RadioButton()
        Me.RadioRetrait = New System.Windows.Forms.RadioButton()
        Me.Radiocarte = New System.Windows.Forms.RadioButton()
        Me.Groupcheque = New System.Windows.Forms.GroupBox()
        Me.TextDateCheque = New System.Windows.Forms.TextBox()
        Me.TextInstitution = New System.Windows.Forms.TextBox()
        Me.TextNcheque = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupMENU = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupFacture = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.numPaiement = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupRetrait = New System.Windows.Forms.GroupBox()
        Me.Combotypecompte = New System.Windows.Forms.ComboBox()
        Me.TextNcompte = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Titre = New System.Windows.Forms.Label()
        Me.GroupInformation.SuspendLayout()
        Me.GroupPaaiement.SuspendLayout()
        Me.GroupeCartecredit.SuspendLayout()
        Me.GroupType.SuspendLayout()
        Me.Groupcheque.SuspendLayout()
        Me.GroupMENU.SuspendLayout()
        Me.GroupFacture.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupRetrait.SuspendLayout()
        Me.SuspendLayout()
        '
        'NumFacture
        '
        Me.NumFacture.Location = New System.Drawing.Point(111, 29)
        Me.NumFacture.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NumFacture.Name = "NumFacture"
        Me.NumFacture.Size = New System.Drawing.Size(178, 26)
        Me.NumFacture.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NumFacture"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Date Facture"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(336, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Client"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(680, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Montant Facture"
        '
        'DateFacture
        '
        Me.DateFacture.Location = New System.Drawing.Point(123, 75)
        Me.DateFacture.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateFacture.Name = "DateFacture"
        Me.DateFacture.Size = New System.Drawing.Size(148, 26)
        Me.DateFacture.TabIndex = 5
        '
        'NomClient
        '
        Me.NomClient.Location = New System.Drawing.Point(410, 74)
        Me.NomClient.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NomClient.Name = "NomClient"
        Me.NomClient.Size = New System.Drawing.Size(148, 26)
        Me.NomClient.TabIndex = 6
        '
        'Montantapayer
        '
        Me.Montantapayer.Location = New System.Drawing.Point(837, 75)
        Me.Montantapayer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Montantapayer.Name = "Montantapayer"
        Me.Montantapayer.Size = New System.Drawing.Size(148, 26)
        Me.Montantapayer.TabIndex = 7
        '
        'GroupInformation
        '
        Me.GroupInformation.Controls.Add(Me.Label2)
        Me.GroupInformation.Controls.Add(Me.Label3)
        Me.GroupInformation.Controls.Add(Me.Montantapayer)
        Me.GroupInformation.Controls.Add(Me.Label4)
        Me.GroupInformation.Controls.Add(Me.NomClient)
        Me.GroupInformation.Controls.Add(Me.DateFacture)
        Me.GroupInformation.Location = New System.Drawing.Point(198, 178)
        Me.GroupInformation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupInformation.Name = "GroupInformation"
        Me.GroupInformation.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupInformation.Size = New System.Drawing.Size(1008, 154)
        Me.GroupInformation.TabIndex = 9
        Me.GroupInformation.TabStop = False
        Me.GroupInformation.Text = "Informations"
        '
        'GroupPaaiement
        '
        Me.GroupPaaiement.Controls.Add(Me.Balance)
        Me.GroupPaaiement.Controls.Add(Me.DatePaiement)
        Me.GroupPaaiement.Controls.Add(Me.MntPayer)
        Me.GroupPaaiement.Controls.Add(Me.Label7)
        Me.GroupPaaiement.Controls.Add(Me.Label6)
        Me.GroupPaaiement.Controls.Add(Me.Label5)
        Me.GroupPaaiement.Location = New System.Drawing.Point(198, 363)
        Me.GroupPaaiement.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupPaaiement.Name = "GroupPaaiement"
        Me.GroupPaaiement.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupPaaiement.Size = New System.Drawing.Size(1023, 137)
        Me.GroupPaaiement.TabIndex = 11
        Me.GroupPaaiement.TabStop = False
        Me.GroupPaaiement.Text = "Paiement"
        '
        'Balance
        '
        Me.Balance.Location = New System.Drawing.Point(837, 66)
        Me.Balance.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Balance.Name = "Balance"
        Me.Balance.Size = New System.Drawing.Size(148, 26)
        Me.Balance.TabIndex = 5
        '
        'DatePaiement
        '
        Me.DatePaiement.Location = New System.Drawing.Point(501, 66)
        Me.DatePaiement.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DatePaiement.Name = "DatePaiement"
        Me.DatePaiement.Size = New System.Drawing.Size(148, 26)
        Me.DatePaiement.TabIndex = 4
        '
        'MntPayer
        '
        Me.MntPayer.Location = New System.Drawing.Point(147, 62)
        Me.MntPayer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MntPayer.Name = "MntPayer"
        Me.MntPayer.Size = New System.Drawing.Size(148, 26)
        Me.MntPayer.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(759, 71)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Balance"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(338, 66)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 20)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Date de paiement"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Montant payer"
        '
        'GroupeCartecredit
        '
        Me.GroupeCartecredit.BackColor = System.Drawing.Color.White
        Me.GroupeCartecredit.Controls.Add(Me.ComboTypeCarte)
        Me.GroupeCartecredit.Controls.Add(Me.TextDateEXPIRATION)
        Me.GroupeCartecredit.Controls.Add(Me.TextNcarte)
        Me.GroupeCartecredit.Controls.Add(Me.Label10)
        Me.GroupeCartecredit.Controls.Add(Me.Label9)
        Me.GroupeCartecredit.Controls.Add(Me.Label8)
        Me.GroupeCartecredit.Location = New System.Drawing.Point(540, 529)
        Me.GroupeCartecredit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupeCartecredit.Name = "GroupeCartecredit"
        Me.GroupeCartecredit.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupeCartecredit.Size = New System.Drawing.Size(771, 226)
        Me.GroupeCartecredit.TabIndex = 13
        Me.GroupeCartecredit.TabStop = False
        Me.GroupeCartecredit.Text = "Carte Credit"
        '
        'ComboTypeCarte
        '
        Me.ComboTypeCarte.FormattingEnabled = True
        Me.ComboTypeCarte.Items.AddRange(New Object() {"Visa", "Master Carte ", "Amex"})
        Me.ComboTypeCarte.Location = New System.Drawing.Point(182, 169)
        Me.ComboTypeCarte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboTypeCarte.Name = "ComboTypeCarte"
        Me.ComboTypeCarte.Size = New System.Drawing.Size(277, 28)
        Me.ComboTypeCarte.TabIndex = 5
        '
        'TextDateEXPIRATION
        '
        Me.TextDateEXPIRATION.Location = New System.Drawing.Point(182, 103)
        Me.TextDateEXPIRATION.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextDateEXPIRATION.Name = "TextDateEXPIRATION"
        Me.TextDateEXPIRATION.Size = New System.Drawing.Size(205, 26)
        Me.TextDateEXPIRATION.TabIndex = 4
        '
        'TextNcarte
        '
        Me.TextNcarte.Location = New System.Drawing.Point(182, 49)
        Me.TextNcarte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextNcarte.Name = "TextNcarte"
        Me.TextNcarte.Size = New System.Drawing.Size(361, 26)
        Me.TextNcarte.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 169)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 20)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Type de carte"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 103)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Date Expiration"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 46)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "N Carte"
        '
        'GroupType
        '
        Me.GroupType.BackColor = System.Drawing.Color.White
        Me.GroupType.Controls.Add(Me.Radiocheque)
        Me.GroupType.Controls.Add(Me.RadioRetrait)
        Me.GroupType.Controls.Add(Me.Radiocarte)
        Me.GroupType.Location = New System.Drawing.Point(194, 548)
        Me.GroupType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupType.Name = "GroupType"
        Me.GroupType.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupType.Size = New System.Drawing.Size(336, 226)
        Me.GroupType.TabIndex = 12
        Me.GroupType.TabStop = False
        Me.GroupType.Text = "Type de paiement"
        '
        'Radiocheque
        '
        Me.Radiocheque.AutoSize = True
        Me.Radiocheque.Location = New System.Drawing.Point(46, 100)
        Me.Radiocheque.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Radiocheque.Name = "Radiocheque"
        Me.Radiocheque.Size = New System.Drawing.Size(157, 24)
        Me.Radiocheque.TabIndex = 3
        Me.Radiocheque.Text = "Chéque Bancaire"
        Me.Radiocheque.UseVisualStyleBackColor = True
        '
        'RadioRetrait
        '
        Me.RadioRetrait.AutoSize = True
        Me.RadioRetrait.Location = New System.Drawing.Point(46, 155)
        Me.RadioRetrait.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RadioRetrait.Name = "RadioRetrait"
        Me.RadioRetrait.Size = New System.Drawing.Size(175, 24)
        Me.RadioRetrait.TabIndex = 2
        Me.RadioRetrait.Text = "Retrait automatique"
        Me.RadioRetrait.UseVisualStyleBackColor = True
        '
        'Radiocarte
        '
        Me.Radiocarte.AutoSize = True
        Me.Radiocarte.Checked = True
        Me.Radiocarte.Location = New System.Drawing.Point(46, 51)
        Me.Radiocarte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Radiocarte.Name = "Radiocarte"
        Me.Radiocarte.Size = New System.Drawing.Size(119, 24)
        Me.Radiocarte.TabIndex = 1
        Me.Radiocarte.TabStop = True
        Me.Radiocarte.Text = "Carte Credit"
        Me.Radiocarte.UseVisualStyleBackColor = True
        '
        'Groupcheque
        '
        Me.Groupcheque.BackColor = System.Drawing.Color.White
        Me.Groupcheque.Controls.Add(Me.TextDateCheque)
        Me.Groupcheque.Controls.Add(Me.TextInstitution)
        Me.Groupcheque.Controls.Add(Me.TextNcheque)
        Me.Groupcheque.Controls.Add(Me.Label11)
        Me.Groupcheque.Controls.Add(Me.Label12)
        Me.Groupcheque.Controls.Add(Me.Label13)
        Me.Groupcheque.Location = New System.Drawing.Point(538, 548)
        Me.Groupcheque.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Groupcheque.Name = "Groupcheque"
        Me.Groupcheque.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Groupcheque.Size = New System.Drawing.Size(771, 226)
        Me.Groupcheque.TabIndex = 14
        Me.Groupcheque.TabStop = False
        Me.Groupcheque.Text = "Chéque Bancaire"
        Me.Groupcheque.Visible = False
        '
        'TextDateCheque
        '
        Me.TextDateCheque.Location = New System.Drawing.Point(172, 165)
        Me.TextDateCheque.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextDateCheque.Name = "TextDateCheque"
        Me.TextDateCheque.Size = New System.Drawing.Size(350, 26)
        Me.TextDateCheque.TabIndex = 5
        '
        'TextInstitution
        '
        Me.TextInstitution.Location = New System.Drawing.Point(172, 100)
        Me.TextInstitution.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextInstitution.Name = "TextInstitution"
        Me.TextInstitution.Size = New System.Drawing.Size(350, 26)
        Me.TextInstitution.TabIndex = 4
        '
        'TextNcheque
        '
        Me.TextNcheque.Location = New System.Drawing.Point(172, 46)
        Me.TextNcheque.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextNcheque.Name = "TextNcheque"
        Me.TextNcheque.Size = New System.Drawing.Size(350, 26)
        Me.TextNcheque.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(34, 169)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Date chèque"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(34, 103)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 20)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Nom institution"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(30, 46)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "No. chèque"
        '
        'GroupMENU
        '
        Me.GroupMENU.BackColor = System.Drawing.Color.White
        Me.GroupMENU.Controls.Add(Me.Button3)
        Me.GroupMENU.Controls.Add(Me.Button2)
        Me.GroupMENU.Location = New System.Drawing.Point(147, 783)
        Me.GroupMENU.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupMENU.Name = "GroupMENU"
        Me.GroupMENU.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupMENU.Size = New System.Drawing.Size(1162, 68)
        Me.GroupMENU.TabIndex = 16
        Me.GroupMENU.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(996, 14)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 35)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Annuler"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(687, 14)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Enregistrer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupFacture
        '
        Me.GroupFacture.BackColor = System.Drawing.Color.White
        Me.GroupFacture.Controls.Add(Me.Label17)
        Me.GroupFacture.Controls.Add(Me.numPaiement)
        Me.GroupFacture.Controls.Add(Me.Label1)
        Me.GroupFacture.Controls.Add(Me.NumFacture)
        Me.GroupFacture.Controls.Add(Me.Button1)
        Me.GroupFacture.Location = New System.Drawing.Point(198, 80)
        Me.GroupFacture.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupFacture.Name = "GroupFacture"
        Me.GroupFacture.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupFacture.Size = New System.Drawing.Size(1112, 89)
        Me.GroupFacture.TabIndex = 17
        Me.GroupFacture.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(496, 37)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 20)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "N* Paiement"
        '
        'numPaiement
        '
        Me.numPaiement.Location = New System.Drawing.Point(610, 32)
        Me.numPaiement.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.numPaiement.Name = "numPaiement"
        Me.numPaiement.Size = New System.Drawing.Size(148, 26)
        Me.numPaiement.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(780, 15)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 57)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Rechercher"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 80)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(146, 771)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(14, 329)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(112, 35)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "Quitter"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button6.Location = New System.Drawing.Point(9, 183)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(112, 88)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Supprimer"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button4.Location = New System.Drawing.Point(14, 37)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(112, 88)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Mise a Jour"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupRetrait
        '
        Me.GroupRetrait.BackColor = System.Drawing.Color.White
        Me.GroupRetrait.Controls.Add(Me.Combotypecompte)
        Me.GroupRetrait.Controls.Add(Me.TextNcompte)
        Me.GroupRetrait.Controls.Add(Me.Label14)
        Me.GroupRetrait.Controls.Add(Me.Label16)
        Me.GroupRetrait.Location = New System.Drawing.Point(538, 552)
        Me.GroupRetrait.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupRetrait.Name = "GroupRetrait"
        Me.GroupRetrait.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupRetrait.Size = New System.Drawing.Size(771, 212)
        Me.GroupRetrait.TabIndex = 20
        Me.GroupRetrait.TabStop = False
        Me.GroupRetrait.Text = "Retrait automatique"
        Me.GroupRetrait.Visible = False
        '
        'Combotypecompte
        '
        Me.Combotypecompte.FormattingEnabled = True
        Me.Combotypecompte.Items.AddRange(New Object() {"Chèque,", "Epargne, ", "Interêt quotidien, ", "Progréssif"})
        Me.Combotypecompte.Location = New System.Drawing.Point(165, 111)
        Me.Combotypecompte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Combotypecompte.Name = "Combotypecompte"
        Me.Combotypecompte.Size = New System.Drawing.Size(283, 28)
        Me.Combotypecompte.TabIndex = 5
        '
        'TextNcompte
        '
        Me.TextNcompte.Location = New System.Drawing.Point(165, 46)
        Me.TextNcompte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextNcompte.Name = "TextNcompte"
        Me.TextNcompte.Size = New System.Drawing.Size(283, 26)
        Me.TextNcompte.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 106)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 20)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Type de compte"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(30, 46)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 20)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "No. compte" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'Titre
        '
        Me.Titre.BackColor = System.Drawing.Color.White
        Me.Titre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(382, 14)
        Me.Titre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(575, 34)
        Me.Titre.TabIndex = 38
        Me.Titre.Text = "Paiement"
        Me.Titre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Paiement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1311, 848)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.GroupRetrait)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupeCartecredit)
        Me.Controls.Add(Me.GroupFacture)
        Me.Controls.Add(Me.GroupMENU)
        Me.Controls.Add(Me.Groupcheque)
        Me.Controls.Add(Me.GroupType)
        Me.Controls.Add(Me.GroupPaaiement)
        Me.Controls.Add(Me.GroupInformation)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Paiement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des Paiements"
        Me.GroupInformation.ResumeLayout(False)
        Me.GroupInformation.PerformLayout()
        Me.GroupPaaiement.ResumeLayout(False)
        Me.GroupPaaiement.PerformLayout()
        Me.GroupeCartecredit.ResumeLayout(False)
        Me.GroupeCartecredit.PerformLayout()
        Me.GroupType.ResumeLayout(False)
        Me.GroupType.PerformLayout()
        Me.Groupcheque.ResumeLayout(False)
        Me.Groupcheque.PerformLayout()
        Me.GroupMENU.ResumeLayout(False)
        Me.GroupFacture.ResumeLayout(False)
        Me.GroupFacture.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupRetrait.ResumeLayout(False)
        Me.GroupRetrait.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NumFacture As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateFacture As TextBox
    Friend WithEvents NomClient As TextBox
    Friend WithEvents Montantapayer As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupInformation As GroupBox
    Friend WithEvents GroupPaaiement As GroupBox
    Friend WithEvents Balance As TextBox
    Friend WithEvents DatePaiement As TextBox
    Friend WithEvents MntPayer As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupType As GroupBox
    Friend WithEvents Radiocarte As RadioButton
    Friend WithEvents Radiocheque As RadioButton
    Friend WithEvents RadioRetrait As RadioButton
    Friend WithEvents GroupeCartecredit As GroupBox
    Friend WithEvents ComboTypeCarte As ComboBox
    Friend WithEvents TextDateEXPIRATION As TextBox
    Friend WithEvents TextNcarte As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Groupcheque As GroupBox
    Friend WithEvents TextDateCheque As TextBox
    Friend WithEvents TextInstitution As TextBox
    Friend WithEvents TextNcheque As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupMENU As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupFacture As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupRetrait As GroupBox
    Friend WithEvents Combotypecompte As ComboBox
    Friend WithEvents TextNcompte As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents numPaiement As TextBox
    Friend WithEvents Titre As Label
End Class
