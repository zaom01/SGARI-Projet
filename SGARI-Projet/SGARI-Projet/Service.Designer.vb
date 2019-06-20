<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Service
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
        Me.GroupMenu = New System.Windows.Forms.GroupBox()
        Me.ButtonTaxe = New System.Windows.Forms.Button()
        Me.Buttondel = New System.Windows.Forms.Button()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.ButtonModifier = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Groupoperation = New System.Windows.Forms.GroupBox()
        Me.Annuler = New System.Windows.Forms.Button()
        Me.Valider = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Groupprincipal = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.ComboBox()
        Me.PrixService = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupMenu.SuspendLayout()
        Me.Groupoperation.SuspendLayout()
        Me.Groupprincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupMenu
        '
        Me.GroupMenu.BackColor = System.Drawing.Color.White
        Me.GroupMenu.Controls.Add(Me.ButtonTaxe)
        Me.GroupMenu.Controls.Add(Me.Buttondel)
        Me.GroupMenu.Controls.Add(Me.ButtonPrint)
        Me.GroupMenu.Controls.Add(Me.ButtonModifier)
        Me.GroupMenu.Controls.Add(Me.Button2)
        Me.GroupMenu.Location = New System.Drawing.Point(3, 38)
        Me.GroupMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupMenu.Name = "GroupMenu"
        Me.GroupMenu.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupMenu.Size = New System.Drawing.Size(132, 498)
        Me.GroupMenu.TabIndex = 10
        Me.GroupMenu.TabStop = False
        '
        'ButtonTaxe
        '
        Me.ButtonTaxe.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ButtonTaxe.Location = New System.Drawing.Point(15, 414)
        Me.ButtonTaxe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonTaxe.Name = "ButtonTaxe"
        Me.ButtonTaxe.Size = New System.Drawing.Size(93, 74)
        Me.ButtonTaxe.TabIndex = 5
        Me.ButtonTaxe.Text = "Quitter"
        Me.ButtonTaxe.UseVisualStyleBackColor = True
        '
        'Buttondel
        '
        Me.Buttondel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Buttondel.Location = New System.Drawing.Point(9, 291)
        Me.Buttondel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Buttondel.Name = "Buttondel"
        Me.Buttondel.Size = New System.Drawing.Size(99, 83)
        Me.Buttondel.TabIndex = 4
        Me.Buttondel.Text = "Supprimer"
        Me.Buttondel.UseVisualStyleBackColor = True
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Location = New System.Drawing.Point(9, 580)
        Me.ButtonPrint.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(99, 60)
        Me.ButtonPrint.TabIndex = 3
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'ButtonModifier
        '
        Me.ButtonModifier.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ButtonModifier.Location = New System.Drawing.Point(9, 166)
        Me.ButtonModifier.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtonModifier.Name = "ButtonModifier"
        Me.ButtonModifier.Size = New System.Drawing.Size(99, 85)
        Me.ButtonModifier.TabIndex = 2
        Me.ButtonModifier.Text = "Modifier"
        Me.ButtonModifier.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button2.Location = New System.Drawing.Point(9, 28)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 85)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Ajouter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Groupoperation
        '
        Me.Groupoperation.BackColor = System.Drawing.Color.White
        Me.Groupoperation.Controls.Add(Me.Annuler)
        Me.Groupoperation.Controls.Add(Me.Valider)
        Me.Groupoperation.Location = New System.Drawing.Point(144, 455)
        Me.Groupoperation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Groupoperation.Name = "Groupoperation"
        Me.Groupoperation.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Groupoperation.Size = New System.Drawing.Size(866, 82)
        Me.Groupoperation.TabIndex = 11
        Me.Groupoperation.TabStop = False
        '
        'Annuler
        '
        Me.Annuler.Location = New System.Drawing.Point(718, 12)
        Me.Annuler.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Annuler.Name = "Annuler"
        Me.Annuler.Size = New System.Drawing.Size(94, 60)
        Me.Annuler.TabIndex = 4
        Me.Annuler.UseVisualStyleBackColor = True
        '
        'Valider
        '
        Me.Valider.Location = New System.Drawing.Point(550, 12)
        Me.Valider.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Valider.Name = "Valider"
        Me.Valider.Size = New System.Drawing.Size(90, 60)
        Me.Valider.TabIndex = 0
        Me.Valider.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Valider.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(351, 35)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Gestion des Services"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Groupprincipal
        '
        Me.Groupprincipal.Controls.Add(Me.Label3)
        Me.Groupprincipal.Controls.Add(Me.Description)
        Me.Groupprincipal.Controls.Add(Me.PrixService)
        Me.Groupprincipal.Controls.Add(Me.Label2)
        Me.Groupprincipal.Location = New System.Drawing.Point(166, 105)
        Me.Groupprincipal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Groupprincipal.Name = "Groupprincipal"
        Me.Groupprincipal.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Groupprincipal.Size = New System.Drawing.Size(801, 283)
        Me.Groupprincipal.TabIndex = 17
        Me.Groupprincipal.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(64, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 35)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Prix service" & Global.Microsoft.VisualBasic.ChrW(9)
        '
        'Description
        '
        Me.Description.FormattingEnabled = True
        Me.Description.Items.AddRange(New Object() {"Installation Des équipements", "Formation des personnel", "Réparation deds équipements", "Programation des pages web", "Assiostance téléphoniques"})
        Me.Description.Location = New System.Drawing.Point(272, 65)
        Me.Description.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(430, 28)
        Me.Description.TabIndex = 17
        '
        'PrixService
        '
        Me.PrixService.Location = New System.Drawing.Point(272, 125)
        Me.PrixService.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PrixService.Name = "PrixService"
        Me.PrixService.Size = New System.Drawing.Size(248, 26)
        Me.PrixService.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(64, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 35)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Description service"
        '
        'Service
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1010, 542)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Groupoperation)
        Me.Controls.Add(Me.GroupMenu)
        Me.Controls.Add(Me.Groupprincipal)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Service"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des Services"
        Me.GroupMenu.ResumeLayout(False)
        Me.Groupoperation.ResumeLayout(False)
        Me.Groupprincipal.ResumeLayout(False)
        Me.Groupprincipal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupMenu As GroupBox
    Friend WithEvents Buttondel As Button
    Friend WithEvents ButtonPrint As Button
    Friend WithEvents ButtonModifier As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Groupoperation As GroupBox
    Friend WithEvents Annuler As Button
    Friend WithEvents Valider As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Groupprincipal As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Description As ComboBox
    Friend WithEvents PrixService As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonTaxe As Button
End Class
