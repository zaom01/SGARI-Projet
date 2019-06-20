<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModifier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnRechercher = New System.Windows.Forms.Button()
        Me.BtnMQuitter = New System.Windows.Forms.Button()
        Me.BtnMNSearch = New System.Windows.Forms.Button()
        Me.BtnModifier = New System.Windows.Forms.Button()
        Me.LblMDMService = New System.Windows.Forms.Label()
        Me.LblMService = New System.Windows.Forms.Label()
        Me.LblMLocation = New System.Windows.Forms.Label()
        Me.LblMDF = New System.Windows.Forms.Label()
        Me.LblMDO = New System.Windows.Forms.Label()
        Me.LblMTCnt = New System.Windows.Forms.Label()
        Me.LblMNumCnt = New System.Windows.Forms.Label()
        Me.TxtBoxNumCnt = New System.Windows.Forms.TextBox()
        Me.LblNumContratAModifier = New System.Windows.Forms.Label()
        Me.TBoxMTCnt = New System.Windows.Forms.TextBox()
        Me.TBoxMDO = New System.Windows.Forms.TextBox()
        Me.TBoxMDF = New System.Windows.Forms.TextBox()
        Me.TBoxMLocation = New System.Windows.Forms.TextBox()
        Me.TBoxMService = New System.Windows.Forms.TextBox()
        Me.TBoxMDMV = New System.Windows.Forms.TextBox()
        Me.LblMNC = New System.Windows.Forms.Label()
        Me.GBoxRecherche = New System.Windows.Forms.GroupBox()
        Me.LblMessage = New System.Windows.Forms.Label()
        Me.LblMessageMaj = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GBoxRecherche.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRechercher
        '
        Me.BtnRechercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRechercher.Location = New System.Drawing.Point(830, 72)
        Me.BtnRechercher.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnRechercher.Name = "BtnRechercher"
        Me.BtnRechercher.Size = New System.Drawing.Size(176, 35)
        Me.BtnRechercher.TabIndex = 34
        Me.BtnRechercher.Text = "Rechercher"
        Me.BtnRechercher.UseVisualStyleBackColor = True
        '
        'BtnMQuitter
        '
        Me.BtnMQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMQuitter.Location = New System.Drawing.Point(32, 654)
        Me.BtnMQuitter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnMQuitter.Name = "BtnMQuitter"
        Me.BtnMQuitter.Size = New System.Drawing.Size(122, 66)
        Me.BtnMQuitter.TabIndex = 33
        Me.BtnMQuitter.Text = "Quitter"
        Me.BtnMQuitter.UseVisualStyleBackColor = True
        '
        'BtnMNSearch
        '
        Me.BtnMNSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMNSearch.Location = New System.Drawing.Point(32, 429)
        Me.BtnMNSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnMNSearch.Name = "BtnMNSearch"
        Me.BtnMNSearch.Size = New System.Drawing.Size(122, 77)
        Me.BtnMNSearch.TabIndex = 32
        Me.BtnMNSearch.Text = "Nouvelle Recherche"
        Me.BtnMNSearch.UseVisualStyleBackColor = True
        '
        'BtnModifier
        '
        Me.BtnModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModifier.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnModifier.Location = New System.Drawing.Point(27, 302)
        Me.BtnModifier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnModifier.Name = "BtnModifier"
        Me.BtnModifier.Size = New System.Drawing.Size(122, 83)
        Me.BtnModifier.TabIndex = 31
        Me.BtnModifier.Text = "Modifier"
        Me.BtnModifier.UseVisualStyleBackColor = True
        '
        'LblMDMService
        '
        Me.LblMDMService.AutoSize = True
        Me.LblMDMService.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMDMService.Location = New System.Drawing.Point(525, 312)
        Me.LblMDMService.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMDMService.Name = "LblMDMService"
        Me.LblMDMService.Size = New System.Drawing.Size(285, 29)
        Me.LblMDMService.TabIndex = 29
        Me.LblMDMService.Text = "Date de mise en vigueur :"
        '
        'LblMService
        '
        Me.LblMService.AutoSize = True
        Me.LblMService.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMService.Location = New System.Drawing.Point(525, 240)
        Me.LblMService.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMService.Name = "LblMService"
        Me.LblMService.Size = New System.Drawing.Size(106, 29)
        Me.LblMService.TabIndex = 28
        Me.LblMService.Text = "Service :"
        '
        'LblMLocation
        '
        Me.LblMLocation.AutoSize = True
        Me.LblMLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMLocation.Location = New System.Drawing.Point(525, 157)
        Me.LblMLocation.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMLocation.Name = "LblMLocation"
        Me.LblMLocation.Size = New System.Drawing.Size(250, 29)
        Me.LblMLocation.TabIndex = 27
        Me.LblMLocation.Text = "Location équipement :"
        '
        'LblMDF
        '
        Me.LblMDF.AutoSize = True
        Me.LblMDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMDF.Location = New System.Drawing.Point(10, 308)
        Me.LblMDF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMDF.Name = "LblMDF"
        Me.LblMDF.Size = New System.Drawing.Size(218, 29)
        Me.LblMDF.TabIndex = 26
        Me.LblMDF.Text = "Date de fermeture :"
        '
        'LblMDO
        '
        Me.LblMDO.AutoSize = True
        Me.LblMDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMDO.Location = New System.Drawing.Point(10, 226)
        Me.LblMDO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMDO.Name = "LblMDO"
        Me.LblMDO.Size = New System.Drawing.Size(200, 29)
        Me.LblMDO.TabIndex = 25
        Me.LblMDO.Text = "Date d'ouverture :"
        '
        'LblMTCnt
        '
        Me.LblMTCnt.AutoSize = True
        Me.LblMTCnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMTCnt.Location = New System.Drawing.Point(9, 157)
        Me.LblMTCnt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMTCnt.Name = "LblMTCnt"
        Me.LblMTCnt.Size = New System.Drawing.Size(192, 29)
        Me.LblMTCnt.TabIndex = 24
        Me.LblMTCnt.Text = "Type de contrat :"
        '
        'LblMNumCnt
        '
        Me.LblMNumCnt.AutoSize = True
        Me.LblMNumCnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMNumCnt.Location = New System.Drawing.Point(372, 75)
        Me.LblMNumCnt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMNumCnt.Name = "LblMNumCnt"
        Me.LblMNumCnt.Size = New System.Drawing.Size(216, 29)
        Me.LblMNumCnt.TabIndex = 23
        Me.LblMNumCnt.Text = "Numéro du Contrat"
        '
        'TxtBoxNumCnt
        '
        Me.TxtBoxNumCnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxNumCnt.Location = New System.Drawing.Point(376, 75)
        Me.TxtBoxNumCnt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxNumCnt.Name = "TxtBoxNumCnt"
        Me.TxtBoxNumCnt.Size = New System.Drawing.Size(367, 33)
        Me.TxtBoxNumCnt.TabIndex = 22
        '
        'LblNumContratAModifier
        '
        Me.LblNumContratAModifier.AutoSize = True
        Me.LblNumContratAModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumContratAModifier.Location = New System.Drawing.Point(48, 80)
        Me.LblNumContratAModifier.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNumContratAModifier.Name = "LblNumContratAModifier"
        Me.LblNumContratAModifier.Size = New System.Drawing.Size(342, 29)
        Me.LblNumContratAModifier.TabIndex = 21
        Me.LblNumContratAModifier.Text = "Numéro du contrat à modifier : "
        '
        'TBoxMTCnt
        '
        Me.TBoxMTCnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxMTCnt.Location = New System.Drawing.Point(240, 152)
        Me.TBoxMTCnt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TBoxMTCnt.Name = "TBoxMTCnt"
        Me.TBoxMTCnt.Size = New System.Drawing.Size(247, 33)
        Me.TBoxMTCnt.TabIndex = 36
        '
        'TBoxMDO
        '
        Me.TBoxMDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxMDO.Location = New System.Drawing.Point(240, 226)
        Me.TBoxMDO.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TBoxMDO.Name = "TBoxMDO"
        Me.TBoxMDO.Size = New System.Drawing.Size(247, 33)
        Me.TBoxMDO.TabIndex = 37
        '
        'TBoxMDF
        '
        Me.TBoxMDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxMDF.Location = New System.Drawing.Point(240, 298)
        Me.TBoxMDF.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TBoxMDF.Name = "TBoxMDF"
        Me.TBoxMDF.Size = New System.Drawing.Size(247, 33)
        Me.TBoxMDF.TabIndex = 38
        '
        'TBoxMLocation
        '
        Me.TBoxMLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxMLocation.Location = New System.Drawing.Point(788, 162)
        Me.TBoxMLocation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TBoxMLocation.Name = "TBoxMLocation"
        Me.TBoxMLocation.Size = New System.Drawing.Size(222, 33)
        Me.TBoxMLocation.TabIndex = 39
        '
        'TBoxMService
        '
        Me.TBoxMService.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxMService.Location = New System.Drawing.Point(788, 228)
        Me.TBoxMService.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TBoxMService.Name = "TBoxMService"
        Me.TBoxMService.Size = New System.Drawing.Size(222, 33)
        Me.TBoxMService.TabIndex = 40
        '
        'TBoxMDMV
        '
        Me.TBoxMDMV.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxMDMV.Location = New System.Drawing.Point(788, 308)
        Me.TBoxMDMV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TBoxMDMV.Name = "TBoxMDMV"
        Me.TBoxMDMV.Size = New System.Drawing.Size(222, 33)
        Me.TBoxMDMV.TabIndex = 41
        '
        'LblMNC
        '
        Me.LblMNC.BackColor = System.Drawing.Color.White
        Me.LblMNC.Enabled = False
        Me.LblMNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMNC.Location = New System.Drawing.Point(597, 63)
        Me.LblMNC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMNC.Name = "LblMNC"
        Me.LblMNC.Size = New System.Drawing.Size(189, 40)
        Me.LblMNC.TabIndex = 42
        '
        'GBoxRecherche
        '
        Me.GBoxRecherche.BackColor = System.Drawing.Color.White
        Me.GBoxRecherche.Controls.Add(Me.LblNumContratAModifier)
        Me.GBoxRecherche.Controls.Add(Me.LblMessage)
        Me.GBoxRecherche.Controls.Add(Me.TxtBoxNumCnt)
        Me.GBoxRecherche.Controls.Add(Me.BtnRechercher)
        Me.GBoxRecherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBoxRecherche.Location = New System.Drawing.Point(18, 32)
        Me.GBoxRecherche.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GBoxRecherche.Name = "GBoxRecherche"
        Me.GBoxRecherche.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GBoxRecherche.Size = New System.Drawing.Size(1178, 203)
        Me.GBoxRecherche.TabIndex = 43
        Me.GBoxRecherche.TabStop = False
        Me.GBoxRecherche.Text = "Recherche du contrat"
        '
        'LblMessage
        '
        Me.LblMessage.AutoSize = True
        Me.LblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMessage.Location = New System.Drawing.Point(454, 155)
        Me.LblMessage.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMessage.Name = "LblMessage"
        Me.LblMessage.Size = New System.Drawing.Size(77, 20)
        Me.LblMessage.TabIndex = 44
        Me.LblMessage.Text = "Message"
        '
        'LblMessageMaj
        '
        Me.LblMessageMaj.AutoSize = True
        Me.LblMessageMaj.Location = New System.Drawing.Point(429, 411)
        Me.LblMessageMaj.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblMessageMaj.Name = "LblMessageMaj"
        Me.LblMessageMaj.Size = New System.Drawing.Size(112, 29)
        Me.LblMessageMaj.TabIndex = 45
        Me.LblMessageMaj.Text = "Message"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.LblMessageMaj)
        Me.GroupBox1.Controls.Add(Me.TBoxMService)
        Me.GroupBox1.Controls.Add(Me.LblMNC)
        Me.GroupBox1.Controls.Add(Me.TBoxMLocation)
        Me.GroupBox1.Controls.Add(Me.LblMDMService)
        Me.GroupBox1.Controls.Add(Me.TBoxMDMV)
        Me.GroupBox1.Controls.Add(Me.TBoxMDF)
        Me.GroupBox1.Controls.Add(Me.LblMTCnt)
        Me.GroupBox1.Controls.Add(Me.LblMService)
        Me.GroupBox1.Controls.Add(Me.TBoxMDO)
        Me.GroupBox1.Controls.Add(Me.TBoxMTCnt)
        Me.GroupBox1.Controls.Add(Me.LblMNumCnt)
        Me.GroupBox1.Controls.Add(Me.LblMLocation)
        Me.GroupBox1.Controls.Add(Me.LblMDO)
        Me.GroupBox1.Controls.Add(Me.LblMDF)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(183, 282)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1029, 460)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Résultat de la recherche et Mise à jour"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(18, 282)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(154, 458)
        Me.PictureBox2.TabIndex = 47
        Me.PictureBox2.TabStop = False
        '
        'FrmModifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1214, 809)
        Me.Controls.Add(Me.GBoxRecherche)
        Me.Controls.Add(Me.BtnMQuitter)
        Me.Controls.Add(Me.BtnMNSearch)
        Me.Controls.Add(Me.BtnModifier)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmModifier"
        Me.Text = "Modifier contrat"
        Me.GBoxRecherche.ResumeLayout(False)
        Me.GBoxRecherche.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnRechercher As Button
    Friend WithEvents BtnMQuitter As Button
    Friend WithEvents BtnMNSearch As Button
    Friend WithEvents BtnModifier As Button
    Friend WithEvents LblMDMService As Label
    Friend WithEvents LblMService As Label
    Friend WithEvents LblMLocation As Label
    Friend WithEvents LblMDF As Label
    Friend WithEvents LblMDO As Label
    Friend WithEvents LblMTCnt As Label
    Friend WithEvents LblMNumCnt As Label
    Friend WithEvents TxtBoxNumCnt As TextBox
    Friend WithEvents LblNumContratAModifier As Label
    Friend WithEvents TBoxMTCnt As TextBox
    Friend WithEvents TBoxMDO As TextBox
    Friend WithEvents TBoxMDF As TextBox
    Friend WithEvents TBoxMLocation As TextBox
    Friend WithEvents TBoxMService As TextBox
    Friend WithEvents TBoxMDMV As TextBox
    Friend WithEvents LblMNC As Label
    Friend WithEvents GBoxRecherche As GroupBox
    Friend WithEvents LblMessage As Label
    Friend WithEvents LblMessageMaj As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
