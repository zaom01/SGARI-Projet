<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Annuler = New System.Windows.Forms.Button()
        Me.BtnSeconnecter = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UsrTxt = New System.Windows.Forms.ComboBox()
        Me.PwTxt = New System.Windows.Forms.TextBox()
        Me.LabelPass = New System.Windows.Forms.Label()
        Me.LabelNom = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Label4.Location = New System.Drawing.Point(72, 62)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(465, 29)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Application de la gestion des abonnets"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(224, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 37)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "SGARI"
        '
        'Annuler
        '
        Me.Annuler.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Annuler.Location = New System.Drawing.Point(456, 342)
        Me.Annuler.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Annuler.Name = "Annuler"
        Me.Annuler.Size = New System.Drawing.Size(142, 35)
        Me.Annuler.TabIndex = 4
        Me.Annuler.Text = "Annuler"
        Me.Annuler.UseVisualStyleBackColor = True
        '
        'BtnSeconnecter
        '
        Me.BtnSeconnecter.Location = New System.Drawing.Point(52, 342)
        Me.BtnSeconnecter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnSeconnecter.Name = "BtnSeconnecter"
        Me.BtnSeconnecter.Size = New System.Drawing.Size(138, 35)
        Me.BtnSeconnecter.TabIndex = 3
        Me.BtnSeconnecter.Text = "Se connecter"
        Me.BtnSeconnecter.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.UsrTxt)
        Me.GroupBox1.Controls.Add(Me.PwTxt)
        Me.GroupBox1.Controls.Add(Me.LabelPass)
        Me.GroupBox1.Controls.Add(Me.LabelNom)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(0, 126)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(676, 206)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        '
        'UsrTxt
        '
        Me.UsrTxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UsrTxt.FormattingEnabled = True
        Me.UsrTxt.Items.AddRange(New Object() {"", "siham", "kwasi", "hassan"})
        Me.UsrTxt.Location = New System.Drawing.Point(330, 48)
        Me.UsrTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UsrTxt.Name = "UsrTxt"
        Me.UsrTxt.Size = New System.Drawing.Size(194, 28)
        Me.UsrTxt.TabIndex = 1
        '
        'PwTxt
        '
        Me.PwTxt.Location = New System.Drawing.Point(330, 111)
        Me.PwTxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PwTxt.MaxLength = 8
        Me.PwTxt.Name = "PwTxt"
        Me.PwTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PwTxt.Size = New System.Drawing.Size(194, 26)
        Me.PwTxt.TabIndex = 2
        '
        'LabelPass
        '
        Me.LabelPass.AutoSize = True
        Me.LabelPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPass.Location = New System.Drawing.Point(74, 114)
        Me.LabelPass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelPass.Name = "LabelPass"
        Me.LabelPass.Size = New System.Drawing.Size(170, 29)
        Me.LabelPass.TabIndex = 20
        Me.LabelPass.Text = "Mot de passe :"
        '
        'LabelNom
        '
        Me.LabelNom.AutoSize = True
        Me.LabelNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNom.Location = New System.Drawing.Point(74, 52)
        Me.LabelNom.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelNom.Name = "LabelNom"
        Me.LabelNom.Size = New System.Drawing.Size(204, 29)
        Me.LabelNom.TabIndex = 19
        Me.LabelNom.Text = "Nom d'utilisateur :"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.Annuler
        Me.ClientSize = New System.Drawing.Size(676, 388)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Annuler)
        Me.Controls.Add(Me.BtnSeconnecter)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ouverture de Session"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Annuler As Button
    Friend WithEvents BtnSeconnecter As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents UsrTxt As ComboBox
    Friend WithEvents PwTxt As TextBox
    Friend WithEvents LabelPass As Label
    Friend WithEvents LabelNom As Label
    Friend WithEvents ImageList1 As ImageList
End Class
