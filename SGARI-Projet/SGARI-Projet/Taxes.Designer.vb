<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Taxes
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
        Me.Combotaxes = New System.Windows.Forms.ComboBox()
        Me.TextTaux = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Groupoperation = New System.Windows.Forms.GroupBox()
        Me.Groupoperation.SuspendLayout()
        Me.SuspendLayout()
        '
        'Combotaxes
        '
        Me.Combotaxes.FormattingEnabled = True
        Me.Combotaxes.Items.AddRange(New Object() {"TPS", "TVQ"})
        Me.Combotaxes.Location = New System.Drawing.Point(12, 46)
        Me.Combotaxes.Name = "Combotaxes"
        Me.Combotaxes.Size = New System.Drawing.Size(260, 21)
        Me.Combotaxes.TabIndex = 0
        '
        'TextTaux
        '
        Me.TextTaux.Location = New System.Drawing.Point(54, 98)
        Me.TextTaux.Name = "TextTaux"
        Me.TextTaux.Size = New System.Drawing.Size(117, 20)
        Me.TextTaux.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Valider"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(160, 24)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 22)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Groupoperation
        '
        Me.Groupoperation.Controls.Add(Me.Button1)
        Me.Groupoperation.Controls.Add(Me.Button2)
        Me.Groupoperation.Location = New System.Drawing.Point(12, 159)
        Me.Groupoperation.Name = "Groupoperation"
        Me.Groupoperation.Size = New System.Drawing.Size(260, 57)
        Me.Groupoperation.TabIndex = 4
        Me.Groupoperation.TabStop = False
        '
        'Taxes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 228)
        Me.Controls.Add(Me.Groupoperation)
        Me.Controls.Add(Me.TextTaux)
        Me.Controls.Add(Me.Combotaxes)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Taxes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des Taxes"
        Me.Groupoperation.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Combotaxes As ComboBox
    Friend WithEvents TextTaux As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Groupoperation As GroupBox
End Class
