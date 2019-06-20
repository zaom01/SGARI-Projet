<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListeUtilisateur
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
        Me.Listutlisateurs = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Listutlisateurs
        '
        Me.Listutlisateurs.BackColor = System.Drawing.Color.White
        Me.Listutlisateurs.FormattingEnabled = True
        Me.Listutlisateurs.ItemHeight = 20
        Me.Listutlisateurs.Location = New System.Drawing.Point(3, 18)
        Me.Listutlisateurs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Listutlisateurs.Name = "Listutlisateurs"
        Me.Listutlisateurs.Size = New System.Drawing.Size(582, 364)
        Me.Listutlisateurs.TabIndex = 0
        '
        'ListeUtilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 402)
        Me.Controls.Add(Me.Listutlisateurs)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ListeUtilisateur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liste des utilisateurs"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Listutlisateurs As ListBox
End Class
