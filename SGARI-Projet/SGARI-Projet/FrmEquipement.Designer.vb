<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEquipement
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
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ButtonAjout = New System.Windows.Forms.Button()
        Me.ButtonRetour = New System.Windows.Forms.Button()
        Me.ButtonConsulter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txtreel = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtPrix = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtEtat = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtDesignation = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtMarque = New System.Windows.Forms.TextBox()
        Me.TxtConstructeur = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Calendar2 = New System.Windows.Forms.MonthCalendar()
        Me.Calendar1 = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ButtonDateEnservice = New System.Windows.Forms.Button()
        Me.ButtonClendar = New System.Windows.Forms.Button()
        Me.DateAcquisition = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateMiseService = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtFrs = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.TxtCode = New System.Windows.Forms.TextBox()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.TxtFamille = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ComboType = New System.Windows.Forms.ComboBox()
        Me.ButtonModifier = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ButtonQuitter = New System.Windows.Forms.Button()
        Me.ButtonMajType = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.Titre = New System.Windows.Forms.Label()
        Me.GroupRetour = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCommentaire = New System.Windows.Forms.RichTextBox()
        Me.DateRetour = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupRetour.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 780)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 21, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1636, 22)
        Me.StatusStrip1.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ButtonAjout
        '
        Me.ButtonAjout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAjout.Location = New System.Drawing.Point(28, 77)
        Me.ButtonAjout.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonAjout.Name = "ButtonAjout"
        Me.ButtonAjout.Size = New System.Drawing.Size(152, 57)
        Me.ButtonAjout.TabIndex = 2
        Me.ButtonAjout.Text = "&Ajout "
        Me.ButtonAjout.UseVisualStyleBackColor = True
        '
        'ButtonRetour
        '
        Me.ButtonRetour.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRetour.Location = New System.Drawing.Point(28, 169)
        Me.ButtonRetour.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonRetour.Name = "ButtonRetour"
        Me.ButtonRetour.Size = New System.Drawing.Size(152, 57)
        Me.ButtonRetour.TabIndex = 3
        Me.ButtonRetour.Text = "&Retour Équipement"
        Me.ButtonRetour.UseVisualStyleBackColor = True
        '
        'ButtonConsulter
        '
        Me.ButtonConsulter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConsulter.Location = New System.Drawing.Point(28, 360)
        Me.ButtonConsulter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonConsulter.Name = "ButtonConsulter"
        Me.ButtonConsulter.Size = New System.Drawing.Size(152, 54)
        Me.ButtonConsulter.TabIndex = 4
        Me.ButtonConsulter.Text = "&Supprimer"
        Me.ButtonConsulter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Code équipement"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(9, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nom d'equipement"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(9, 118)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Famille"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(9, 185)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Type d'équipement"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.Txtreel)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TxtPrix)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtEtat)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TxtDesignation)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(747, 88)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(814, 145)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Caractéristique de l'équipement"
        '
        'Txtreel
        '
        Me.Txtreel.Location = New System.Drawing.Point(627, 74)
        Me.Txtreel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txtreel.Name = "Txtreel"
        Me.Txtreel.Size = New System.Drawing.Size(166, 26)
        Me.Txtreel.TabIndex = 24
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(484, 85)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 20)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Prix réel"
        '
        'TxtPrix
        '
        Me.TxtPrix.Location = New System.Drawing.Point(627, 26)
        Me.TxtPrix.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtPrix.Name = "TxtPrix"
        Me.TxtPrix.Size = New System.Drawing.Size(166, 26)
        Me.TxtPrix.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(484, 34)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Prix de location "
        '
        'TxtEtat
        '
        Me.TxtEtat.Location = New System.Drawing.Point(128, 69)
        Me.TxtEtat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtEtat.Name = "TxtEtat"
        Me.TxtEtat.Size = New System.Drawing.Size(326, 26)
        Me.TxtEtat.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 74)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Etat"
        '
        'TxtDesignation
        '
        Me.TxtDesignation.Location = New System.Drawing.Point(128, 34)
        Me.TxtDesignation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtDesignation.Name = "TxtDesignation"
        Me.TxtDesignation.Size = New System.Drawing.Size(326, 26)
        Me.TxtDesignation.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 37)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Désignation"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtMarque)
        Me.GroupBox2.Controls.Add(Me.TxtConstructeur)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(746, 242)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(816, 83)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Données commérciales"
        '
        'TxtMarque
        '
        Me.TxtMarque.Location = New System.Drawing.Point(188, 42)
        Me.TxtMarque.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtMarque.Name = "TxtMarque"
        Me.TxtMarque.Size = New System.Drawing.Size(206, 26)
        Me.TxtMarque.TabIndex = 22
        '
        'TxtConstructeur
        '
        Me.TxtConstructeur.Location = New System.Drawing.Point(612, 31)
        Me.TxtConstructeur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtConstructeur.Name = "TxtConstructeur"
        Me.TxtConstructeur.Size = New System.Drawing.Size(182, 26)
        Me.TxtConstructeur.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(484, 35)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 20)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Constructeur"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 48)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Marque"
        '
        'Calendar2
        '
        Me.Calendar2.Location = New System.Drawing.Point(1202, 545)
        Me.Calendar2.Margin = New System.Windows.Forms.Padding(14)
        Me.Calendar2.Name = "Calendar2"
        Me.Calendar2.TabIndex = 28
        Me.Calendar2.Visible = False
        '
        'Calendar1
        '
        Me.Calendar1.Location = New System.Drawing.Point(760, 545)
        Me.Calendar1.Margin = New System.Windows.Forms.Padding(14)
        Me.Calendar1.Name = "Calendar1"
        Me.Calendar1.TabIndex = 27
        Me.Calendar1.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ButtonDateEnservice)
        Me.GroupBox3.Controls.Add(Me.ButtonClendar)
        Me.GroupBox3.Controls.Add(Me.DateAcquisition)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.DateMiseService)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(746, 458)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(848, 77)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Date"
        '
        'ButtonDateEnservice
        '
        Me.ButtonDateEnservice.Image = Global.SGARI_Projet.My.Resources.Resources.calendar_icon
        Me.ButtonDateEnservice.Location = New System.Drawing.Point(788, 35)
        Me.ButtonDateEnservice.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonDateEnservice.Name = "ButtonDateEnservice"
        Me.ButtonDateEnservice.Size = New System.Drawing.Size(44, 42)
        Me.ButtonDateEnservice.TabIndex = 27
        Me.ButtonDateEnservice.UseVisualStyleBackColor = True
        '
        'ButtonClendar
        '
        Me.ButtonClendar.Image = Global.SGARI_Projet.My.Resources.Resources.calendar_icon
        Me.ButtonClendar.Location = New System.Drawing.Point(324, 28)
        Me.ButtonClendar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonClendar.Name = "ButtonClendar"
        Me.ButtonClendar.Size = New System.Drawing.Size(44, 46)
        Me.ButtonClendar.TabIndex = 24
        Me.ButtonClendar.UseVisualStyleBackColor = True
        '
        'DateAcquisition
        '
        Me.DateAcquisition.Location = New System.Drawing.Point(186, 37)
        Me.DateAcquisition.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateAcquisition.Name = "DateAcquisition"
        Me.DateAcquisition.Size = New System.Drawing.Size(150, 26)
        Me.DateAcquisition.TabIndex = 23
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(424, 52)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(188, 20)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Date mise en service"
        '
        'DateMiseService
        '
        Me.DateMiseService.Location = New System.Drawing.Point(622, 46)
        Me.DateMiseService.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateMiseService.Name = "DateMiseService"
        Me.DateMiseService.Size = New System.Drawing.Size(154, 26)
        Me.DateMiseService.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 46)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(161, 20)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Date d'acquisition"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.TxtFrs)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.TxtStock)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(746, 348)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox4.Size = New System.Drawing.Size(816, 83)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Consultation Article"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(484, 29)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 20)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Fournisseur"
        '
        'TxtFrs
        '
        Me.TxtFrs.Location = New System.Drawing.Point(612, 29)
        Me.TxtFrs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtFrs.Name = "TxtFrs"
        Me.TxtFrs.Size = New System.Drawing.Size(182, 26)
        Me.TxtFrs.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 46)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 20)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Stock disponible"
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(188, 35)
        Me.TxtStock.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(208, 26)
        Me.TxtStock.TabIndex = 21
        '
        'TxtCode
        '
        Me.TxtCode.Location = New System.Drawing.Point(188, 34)
        Me.TxtCode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(220, 26)
        Me.TxtCode.TabIndex = 16
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(188, 74)
        Me.TxtNom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(220, 26)
        Me.TxtNom.TabIndex = 17
        '
        'TxtFamille
        '
        Me.TxtFamille.Location = New System.Drawing.Point(188, 118)
        Me.TxtFamille.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtFamille.Name = "TxtFamille"
        Me.TxtFamille.Size = New System.Drawing.Size(220, 26)
        Me.TxtFamille.TabIndex = 18
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ComboType)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.TxtCode)
        Me.GroupBox5.Controls.Add(Me.TxtFamille)
        Me.GroupBox5.Controls.Add(Me.TxtNom)
        Me.GroupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(286, 88)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox5.Size = New System.Drawing.Size(442, 237)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        '
        'ComboType
        '
        Me.ComboType.FormattingEnabled = True
        Me.ComboType.Items.AddRange(New Object() {"Ordinateur", "Modem"})
        Me.ComboType.Location = New System.Drawing.Point(188, 172)
        Me.ComboType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboType.Name = "ComboType"
        Me.ComboType.Size = New System.Drawing.Size(220, 28)
        Me.ComboType.TabIndex = 28
        '
        'ButtonModifier
        '
        Me.ButtonModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModifier.Location = New System.Drawing.Point(28, 254)
        Me.ButtonModifier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonModifier.Name = "ButtonModifier"
        Me.ButtonModifier.Size = New System.Drawing.Size(152, 62)
        Me.ButtonModifier.TabIndex = 25
        Me.ButtonModifier.Text = "&Modifier"
        Me.ButtonModifier.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ButtonQuitter
        '
        Me.ButtonQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonQuitter.Image = Global.SGARI_Projet.My.Resources.Resources.if_Exit_button_132189
        Me.ButtonQuitter.Location = New System.Drawing.Point(28, 640)
        Me.ButtonQuitter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonQuitter.Name = "ButtonQuitter"
        Me.ButtonQuitter.Size = New System.Drawing.Size(136, 54)
        Me.ButtonQuitter.TabIndex = 27
        Me.ButtonQuitter.UseVisualStyleBackColor = True
        '
        'ButtonMajType
        '
        Me.ButtonMajType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMajType.Location = New System.Drawing.Point(28, 475)
        Me.ButtonMajType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonMajType.Name = "ButtonMajType"
        Me.ButtonMajType.Size = New System.Drawing.Size(152, 57)
        Me.ButtonMajType.TabIndex = 29
        Me.ButtonMajType.Text = "M.a.j Type Équipement"
        Me.ButtonMajType.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox6.Controls.Add(Me.ButtonAnnuler)
        Me.GroupBox6.Controls.Add(Me.ButtonSave)
        Me.GroupBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(213, 691)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox6.Size = New System.Drawing.Size(543, 72)
        Me.GroupBox6.TabIndex = 30
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Opération"
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.Location = New System.Drawing.Point(316, 31)
        Me.ButtonAnnuler.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(112, 35)
        Me.ButtonAnnuler.TabIndex = 1
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.ForeColor = System.Drawing.Color.Maroon
        Me.ButtonSave.Location = New System.Drawing.Point(92, 28)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(128, 35)
        Me.ButtonSave.TabIndex = 0
        Me.ButtonSave.Text = "Enregestrer"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'Titre
        '
        Me.Titre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(584, 14)
        Me.Titre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(575, 34)
        Me.Titre.TabIndex = 31
        Me.Titre.Text = "Gestion des Équipements"
        Me.Titre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupRetour
        '
        Me.GroupRetour.Controls.Add(Me.Label16)
        Me.GroupRetour.Controls.Add(Me.Label6)
        Me.GroupRetour.Controls.Add(Me.TxtCommentaire)
        Me.GroupRetour.Controls.Add(Me.DateRetour)
        Me.GroupRetour.ForeColor = System.Drawing.Color.Black
        Me.GroupRetour.Location = New System.Drawing.Point(286, 348)
        Me.GroupRetour.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupRetour.Name = "GroupRetour"
        Me.GroupRetour.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupRetour.Size = New System.Drawing.Size(442, 288)
        Me.GroupRetour.TabIndex = 32
        Me.GroupRetour.TabStop = False
        Me.GroupRetour.Text = "Retour Équipement"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(30, 72)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(150, 34)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Commentaire"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(30, 35)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 35)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Date de retour"
        '
        'TxtCommentaire
        '
        Me.TxtCommentaire.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtCommentaire.Location = New System.Drawing.Point(30, 111)
        Me.TxtCommentaire.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCommentaire.Name = "TxtCommentaire"
        Me.TxtCommentaire.Size = New System.Drawing.Size(404, 166)
        Me.TxtCommentaire.TabIndex = 1
        Me.TxtCommentaire.Text = "Commentaire"
        '
        'DateRetour
        '
        Me.DateRetour.Location = New System.Drawing.Point(188, 37)
        Me.DateRetour.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DateRetour.Name = "DateRetour"
        Me.DateRetour.Size = New System.Drawing.Size(169, 26)
        Me.DateRetour.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(0, 42)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 719)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'FrmEquipement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1636, 802)
        Me.Controls.Add(Me.Calendar1)
        Me.Controls.Add(Me.GroupRetour)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.Calendar2)
        Me.Controls.Add(Me.ButtonMajType)
        Me.Controls.Add(Me.ButtonQuitter)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ButtonModifier)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtonConsulter)
        Me.Controls.Add(Me.ButtonRetour)
        Me.Controls.Add(Me.ButtonAjout)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEquipement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des Equipements"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupRetour.ResumeLayout(False)
        Me.GroupRetour.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ButtonAjout As Button
    Friend WithEvents ButtonRetour As Button
    Friend WithEvents ButtonConsulter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Txtreel As TextBox
    Friend WithEvents TxtPrix As TextBox
    Friend WithEvents TxtEtat As TextBox
    Friend WithEvents TxtDesignation As TextBox
    Friend WithEvents DateAcquisition As TextBox
    Friend WithEvents TxtFrs As TextBox
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents TxtFamille As TextBox
    Friend WithEvents TxtMarque As TextBox
    Friend WithEvents TxtConstructeur As TextBox
    Friend WithEvents DateMiseService As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ButtonModifier As Button
    Friend WithEvents Calendar1 As MonthCalendar
    Friend WithEvents ButtonClendar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Calendar2 As MonthCalendar
    Friend WithEvents ButtonQuitter As Button
    Friend WithEvents ComboType As ComboBox
    Friend WithEvents ButtonMajType As Button
    Friend WithEvents ButtonDateEnservice As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents ButtonAnnuler As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents Titre As Label
    Friend WithEvents GroupRetour As GroupBox
    Friend WithEvents TxtCommentaire As RichTextBox
    Friend WithEvents DateRetour As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label16 As Label
End Class
