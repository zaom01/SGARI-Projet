<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangerMotdePasse
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBoxUtilisateur = New System.Windows.Forms.TextBox()
        Me.TextBoxAncPwd = New System.Windows.Forms.TextBox()
        Me.TextBoxNewPass = New System.Windows.Forms.TextBox()
        Me.TextBoxConfirmeMP = New System.Windows.Forms.TextBox()
        Me.BtnValider = New System.Windows.Forms.Button()
        Me.BtnAnnuler = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 162)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Utilisateur :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 235)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ancien mot de passe :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(99, 300)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nouveau mot de passe :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(99, 369)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(288, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Confirmer mot de passe : "
        '
        'TxtBoxUtilisateur
        '
        Me.TxtBoxUtilisateur.Enabled = False
        Me.TxtBoxUtilisateur.Location = New System.Drawing.Point(356, 158)
        Me.TxtBoxUtilisateur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtBoxUtilisateur.Name = "TxtBoxUtilisateur"
        Me.TxtBoxUtilisateur.Size = New System.Drawing.Size(241, 26)
        Me.TxtBoxUtilisateur.TabIndex = 4
        '
        'TextBoxAncPwd
        '
        Me.TextBoxAncPwd.Location = New System.Drawing.Point(356, 235)
        Me.TextBoxAncPwd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxAncPwd.Name = "TextBoxAncPwd"
        Me.TextBoxAncPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxAncPwd.Size = New System.Drawing.Size(241, 26)
        Me.TextBoxAncPwd.TabIndex = 5
        '
        'TextBoxNewPass
        '
        Me.TextBoxNewPass.Location = New System.Drawing.Point(356, 297)
        Me.TextBoxNewPass.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxNewPass.Name = "TextBoxNewPass"
        Me.TextBoxNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxNewPass.Size = New System.Drawing.Size(241, 26)
        Me.TextBoxNewPass.TabIndex = 6
        '
        'TextBoxConfirmeMP
        '
        Me.TextBoxConfirmeMP.Location = New System.Drawing.Point(356, 369)
        Me.TextBoxConfirmeMP.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBoxConfirmeMP.Name = "TextBoxConfirmeMP"
        Me.TextBoxConfirmeMP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxConfirmeMP.Size = New System.Drawing.Size(241, 26)
        Me.TextBoxConfirmeMP.TabIndex = 7
        '
        'BtnValider
        '
        Me.BtnValider.Location = New System.Drawing.Point(104, 468)
        Me.BtnValider.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnValider.Name = "BtnValider"
        Me.BtnValider.Size = New System.Drawing.Size(148, 51)
        Me.BtnValider.TabIndex = 8
        Me.BtnValider.Text = "Valider"
        Me.BtnValider.UseVisualStyleBackColor = True
        '
        'BtnAnnuler
        '
        Me.BtnAnnuler.Location = New System.Drawing.Point(285, 468)
        Me.BtnAnnuler.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAnnuler.Name = "BtnAnnuler"
        Me.BtnAnnuler.Size = New System.Drawing.Size(159, 51)
        Me.BtnAnnuler.TabIndex = 9
        Me.BtnAnnuler.Text = "Annuler"
        Me.BtnAnnuler.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(-8, 448)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(736, 82)
        Me.Label5.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(69, 131)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(594, 302)
        Me.Label6.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(74, 45)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(588, 34)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Changer mot de passe"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Location = New System.Drawing.Point(480, 468)
        Me.BtnQuitter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(146, 51)
        Me.BtnQuitter.TabIndex = 42
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'FrmChangerMotdePasse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(720, 525)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnAnnuler)
        Me.Controls.Add(Me.BtnValider)
        Me.Controls.Add(Me.TextBoxConfirmeMP)
        Me.Controls.Add(Me.TextBoxNewPass)
        Me.Controls.Add(Me.TextBoxAncPwd)
        Me.Controls.Add(Me.TxtBoxUtilisateur)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmChangerMotdePasse"
        Me.Text = "Changer mot de passe utilisateur"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBoxUtilisateur As TextBox
    Friend WithEvents TextBoxAncPwd As TextBox
    Friend WithEvents TextBoxNewPass As TextBox
    Friend WithEvents TextBoxConfirmeMP As TextBox
    Friend WithEvents BtnValider As Button
    Friend WithEvents BtnAnnuler As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnQuitter As Button
End Class
