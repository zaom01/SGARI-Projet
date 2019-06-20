<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTypeEquip
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
        Me.ListType = New System.Windows.Forms.ListBox()
        Me.TextType = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListType
        '
        Me.ListType.FormattingEnabled = True
        Me.ListType.ItemHeight = 20
        Me.ListType.Items.AddRange(New Object() {"Ordinateur", "Modem"})
        Me.ListType.Location = New System.Drawing.Point(18, 80)
        Me.ListType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListType.Name = "ListType"
        Me.ListType.Size = New System.Drawing.Size(288, 164)
        Me.ListType.TabIndex = 0
        '
        'TextType
        '
        Me.TextType.Location = New System.Drawing.Point(18, 42)
        Me.TextType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextType.Name = "TextType"
        Me.TextType.Size = New System.Drawing.Size(288, 26)
        Me.TextType.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(316, 37)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Inserer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(316, 82)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Supprimer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmTypeEquip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(435, 265)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextType)
        Me.Controls.Add(Me.ListType)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTypeEquip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des Type "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListType As ListBox
    Friend WithEvents TextType As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
