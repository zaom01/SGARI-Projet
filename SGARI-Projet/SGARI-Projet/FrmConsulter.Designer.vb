<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsulter
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SgariBddDataSet = New SGARI_Projet.SgariBddDataSet()
        Me.SgariBddDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Titre = New System.Windows.Forms.Label()
        Me.CLIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTTableAdapter = New SGARI_Projet.SgariBddDataSetTableAdapters.CLIENTTableAdapter()
        Me.TableAdapterManager = New SGARI_Projet.SgariBddDataSetTableAdapters.TableAdapterManager()
        Me.CONTRATTableAdapter = New SGARI_Projet.SgariBddDataSetTableAdapters.CONTRATTableAdapter()
        Me.CONTRATBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SgariBddDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SgariBddDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRATBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitter.Location = New System.Drawing.Point(1083, 757)
        Me.BtnQuitter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(202, 57)
        Me.BtnQuitter.TabIndex = 1
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 105)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(1268, 625)
        Me.DataGridView1.TabIndex = 6
        '
        'SgariBddDataSet
        '
        Me.SgariBddDataSet.DataSetName = "SgariBddDataSet"
        Me.SgariBddDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SgariBddDataSetBindingSource
        '
        Me.SgariBddDataSetBindingSource.DataSource = Me.SgariBddDataSet
        Me.SgariBddDataSetBindingSource.Position = 0
        '
        'Titre
        '
        Me.Titre.BackColor = System.Drawing.Color.White
        Me.Titre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(344, 43)
        Me.Titre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(575, 34)
        Me.Titre.TabIndex = 38
        Me.Titre.Text = "La liste des clients et des contrats"
        Me.Titre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CLIENTBindingSource
        '
        Me.CLIENTBindingSource.DataMember = "CLIENT"
        Me.CLIENTBindingSource.DataSource = Me.SgariBddDataSet
        '
        'CLIENTTableAdapter
        '
        Me.CLIENTTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTTableAdapter = Me.CLIENTTableAdapter
        Me.TableAdapterManager.CONTRATTableAdapter = Me.CONTRATTableAdapter
        Me.TableAdapterManager.EMPLOYETableAdapter = Nothing
        Me.TableAdapterManager.ENTREPRISETableAdapter = Nothing
        Me.TableAdapterManager.PARTICULIERTableAdapter = Nothing
        Me.TableAdapterManager.SOUSCRITTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SGARI_Projet.SgariBddDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CONTRATTableAdapter
        '
        Me.CONTRATTableAdapter.ClearBeforeFill = True
        '
        'CONTRATBindingSource
        '
        Me.CONTRATBindingSource.DataMember = "CONTRAT"
        Me.CONTRATBindingSource.DataSource = Me.SgariBddDataSet
        '
        'FrmConsulter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1326, 863)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmConsulter"
        Me.Text = "Consulter Contrat"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SgariBddDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SgariBddDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRATBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SgariBddDataSetBindingSource As BindingSource
    Friend WithEvents SgariBddDataSet As SgariBddDataSet
    Friend WithEvents Titre As Label
    Friend WithEvents CLIENTBindingSource As BindingSource
    Friend WithEvents CLIENTTableAdapter As SgariBddDataSetTableAdapters.CLIENTTableAdapter
    Friend WithEvents TableAdapterManager As SgariBddDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CONTRATTableAdapter As SgariBddDataSetTableAdapters.CONTRATTableAdapter
    Friend WithEvents CONTRATBindingSource As BindingSource
End Class
