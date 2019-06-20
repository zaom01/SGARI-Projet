<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRenouveller
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
        Dim NUMCONTRATLabel As System.Windows.Forms.Label
        Dim TYPECONTRATLabel As System.Windows.Forms.Label
        Dim DATEOUVERTURELabel As System.Windows.Forms.Label
        Dim DATEFERMETURELabel As System.Windows.Forms.Label
        Dim LOCATIONEQUIPEMENTLabel As System.Windows.Forms.Label
        Dim SERVICESLabel As System.Windows.Forms.Label
        Dim DATEMISEENVIGUEURLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRenouveller))
        Me.SgariBddDataSet = New SGARI_Projet.SgariBddDataSet()
        Me.CONTRATBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTRATTableAdapter = New SGARI_Projet.SgariBddDataSetTableAdapters.CONTRATTableAdapter()
        Me.TableAdapterManager = New SGARI_Projet.SgariBddDataSetTableAdapters.TableAdapterManager()
        Me.CONTRATBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CONTRATBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CONTRATDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NUMCONTRATTextBox = New System.Windows.Forms.TextBox()
        Me.TYPECONTRATTextBox = New System.Windows.Forms.TextBox()
        Me.DATEOUVERTUREDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DATEFERMETUREDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LOCATIONEQUIPEMENTTextBox = New System.Windows.Forms.TextBox()
        Me.SERVICESTextBox = New System.Windows.Forms.TextBox()
        Me.DATEMISEENVIGUEURDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BtnRenouveller = New System.Windows.Forms.Button()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.Titre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        NUMCONTRATLabel = New System.Windows.Forms.Label()
        TYPECONTRATLabel = New System.Windows.Forms.Label()
        DATEOUVERTURELabel = New System.Windows.Forms.Label()
        DATEFERMETURELabel = New System.Windows.Forms.Label()
        LOCATIONEQUIPEMENTLabel = New System.Windows.Forms.Label()
        SERVICESLabel = New System.Windows.Forms.Label()
        DATEMISEENVIGUEURLabel = New System.Windows.Forms.Label()
        CType(Me.SgariBddDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRATBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTRATBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CONTRATBindingNavigator.SuspendLayout()
        CType(Me.CONTRATDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NUMCONTRATLabel
        '
        NUMCONTRATLabel.AutoSize = True
        NUMCONTRATLabel.Location = New System.Drawing.Point(442, 497)
        NUMCONTRATLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NUMCONTRATLabel.Name = "NUMCONTRATLabel"
        NUMCONTRATLabel.Size = New System.Drawing.Size(124, 20)
        NUMCONTRATLabel.TabIndex = 2
        NUMCONTRATLabel.Text = "NUMCONTRAT:"
        '
        'TYPECONTRATLabel
        '
        TYPECONTRATLabel.AutoSize = True
        TYPECONTRATLabel.Location = New System.Drawing.Point(442, 537)
        TYPECONTRATLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TYPECONTRATLabel.Name = "TYPECONTRATLabel"
        TYPECONTRATLabel.Size = New System.Drawing.Size(129, 20)
        TYPECONTRATLabel.TabIndex = 4
        TYPECONTRATLabel.Text = "TYPECONTRAT:"
        '
        'DATEOUVERTURELabel
        '
        DATEOUVERTURELabel.AutoSize = True
        DATEOUVERTURELabel.Location = New System.Drawing.Point(442, 578)
        DATEOUVERTURELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DATEOUVERTURELabel.Name = "DATEOUVERTURELabel"
        DATEOUVERTURELabel.Size = New System.Drawing.Size(158, 20)
        DATEOUVERTURELabel.TabIndex = 6
        DATEOUVERTURELabel.Text = "DATEOUVERTURE:"
        '
        'DATEFERMETURELabel
        '
        DATEFERMETURELabel.AutoSize = True
        DATEFERMETURELabel.Location = New System.Drawing.Point(442, 618)
        DATEFERMETURELabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DATEFERMETURELabel.Name = "DATEFERMETURELabel"
        DATEFERMETURELabel.Size = New System.Drawing.Size(157, 20)
        DATEFERMETURELabel.TabIndex = 8
        DATEFERMETURELabel.Text = "DATEFERMETURE:"
        '
        'LOCATIONEQUIPEMENTLabel
        '
        LOCATIONEQUIPEMENTLabel.AutoSize = True
        LOCATIONEQUIPEMENTLabel.Location = New System.Drawing.Point(442, 657)
        LOCATIONEQUIPEMENTLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LOCATIONEQUIPEMENTLabel.Name = "LOCATIONEQUIPEMENTLabel"
        LOCATIONEQUIPEMENTLabel.Size = New System.Drawing.Size(198, 20)
        LOCATIONEQUIPEMENTLabel.TabIndex = 10
        LOCATIONEQUIPEMENTLabel.Text = "LOCATIONEQUIPEMENT:"
        '
        'SERVICESLabel
        '
        SERVICESLabel.AutoSize = True
        SERVICESLabel.Location = New System.Drawing.Point(442, 697)
        SERVICESLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SERVICESLabel.Name = "SERVICESLabel"
        SERVICESLabel.Size = New System.Drawing.Size(96, 20)
        SERVICESLabel.TabIndex = 12
        SERVICESLabel.Text = "SERVICES:"
        '
        'DATEMISEENVIGUEURLabel
        '
        DATEMISEENVIGUEURLabel.AutoSize = True
        DATEMISEENVIGUEURLabel.Location = New System.Drawing.Point(442, 738)
        DATEMISEENVIGUEURLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DATEMISEENVIGUEURLabel.Name = "DATEMISEENVIGUEURLabel"
        DATEMISEENVIGUEURLabel.Size = New System.Drawing.Size(194, 20)
        DATEMISEENVIGUEURLabel.TabIndex = 14
        DATEMISEENVIGUEURLabel.Text = "DATEMISEENVIGUEUR:"
        '
        'SgariBddDataSet
        '
        Me.SgariBddDataSet.DataSetName = "SgariBddDataSet"
        Me.SgariBddDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONTRATBindingSource
        '
        Me.CONTRATBindingSource.DataMember = "CONTRAT"
        Me.CONTRATBindingSource.DataSource = Me.SgariBddDataSet
        '
        'CONTRATTableAdapter
        '
        Me.CONTRATTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLIENTTableAdapter = Nothing
        Me.TableAdapterManager.CONTRATTableAdapter = Me.CONTRATTableAdapter
        Me.TableAdapterManager.EMPLOYETableAdapter = Nothing
        Me.TableAdapterManager.ENTREPRISETableAdapter = Nothing
        Me.TableAdapterManager.PARTICULIERTableAdapter = Nothing
        Me.TableAdapterManager.SOUSCRITTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SGARI_Projet.SgariBddDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CONTRATBindingNavigator
        '
        Me.CONTRATBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CONTRATBindingNavigator.BindingSource = Me.CONTRATBindingSource
        Me.CONTRATBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CONTRATBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CONTRATBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CONTRATBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CONTRATBindingNavigatorSaveItem})
        Me.CONTRATBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CONTRATBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CONTRATBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CONTRATBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CONTRATBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CONTRATBindingNavigator.Name = "CONTRATBindingNavigator"
        Me.CONTRATBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.CONTRATBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CONTRATBindingNavigator.Size = New System.Drawing.Size(1214, 31)
        Me.CONTRATBindingNavigator.TabIndex = 0
        Me.CONTRATBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Ajouter nouveau"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(57, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Nombre total d'éléments"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Supprimer"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Placer en premier"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Position actuelle"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Déplacer vers le bas"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Placer en dernier"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'CONTRATBindingNavigatorSaveItem
        '
        Me.CONTRATBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CONTRATBindingNavigatorSaveItem.Image = CType(resources.GetObject("CONTRATBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CONTRATBindingNavigatorSaveItem.Name = "CONTRATBindingNavigatorSaveItem"
        Me.CONTRATBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.CONTRATBindingNavigatorSaveItem.Text = "Enregistrer les données"
        '
        'CONTRATDataGridView
        '
        Me.CONTRATDataGridView.AutoGenerateColumns = False
        Me.CONTRATDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CONTRATDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.CONTRATDataGridView.DataSource = Me.CONTRATBindingSource
        Me.CONTRATDataGridView.Location = New System.Drawing.Point(32, 111)
        Me.CONTRATDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CONTRATDataGridView.Name = "CONTRATDataGridView"
        Me.CONTRATDataGridView.Size = New System.Drawing.Size(1118, 309)
        Me.CONTRATDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NUMCONTRAT"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NUMCONTRAT"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TYPECONTRAT"
        Me.DataGridViewTextBoxColumn2.HeaderText = "TYPECONTRAT"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DATEOUVERTURE"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DATEOUVERTURE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "DATEFERMETURE"
        Me.DataGridViewTextBoxColumn4.HeaderText = "DATEFERMETURE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "LOCATIONEQUIPEMENT"
        Me.DataGridViewTextBoxColumn5.HeaderText = "LOCATIONEQUIPEMENT"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SERVICES"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SERVICES"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DATEMISEENVIGUEUR"
        Me.DataGridViewTextBoxColumn7.HeaderText = "DATEMISEENVIGUEUR"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'NUMCONTRATTextBox
        '
        Me.NUMCONTRATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTRATBindingSource, "NUMCONTRAT", True))
        Me.NUMCONTRATTextBox.Enabled = False
        Me.NUMCONTRATTextBox.Location = New System.Drawing.Point(654, 492)
        Me.NUMCONTRATTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NUMCONTRATTextBox.Name = "NUMCONTRATTextBox"
        Me.NUMCONTRATTextBox.Size = New System.Drawing.Size(370, 26)
        Me.NUMCONTRATTextBox.TabIndex = 3
        '
        'TYPECONTRATTextBox
        '
        Me.TYPECONTRATTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTRATBindingSource, "TYPECONTRAT", True))
        Me.TYPECONTRATTextBox.Enabled = False
        Me.TYPECONTRATTextBox.Location = New System.Drawing.Point(654, 532)
        Me.TYPECONTRATTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TYPECONTRATTextBox.Name = "TYPECONTRATTextBox"
        Me.TYPECONTRATTextBox.Size = New System.Drawing.Size(370, 26)
        Me.TYPECONTRATTextBox.TabIndex = 5
        '
        'DATEOUVERTUREDateTimePicker
        '
        Me.DATEOUVERTUREDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CONTRATBindingSource, "DATEOUVERTURE", True))
        Me.DATEOUVERTUREDateTimePicker.Enabled = False
        Me.DATEOUVERTUREDateTimePicker.Location = New System.Drawing.Point(654, 572)
        Me.DATEOUVERTUREDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DATEOUVERTUREDateTimePicker.Name = "DATEOUVERTUREDateTimePicker"
        Me.DATEOUVERTUREDateTimePicker.Size = New System.Drawing.Size(370, 26)
        Me.DATEOUVERTUREDateTimePicker.TabIndex = 7
        '
        'DATEFERMETUREDateTimePicker
        '
        Me.DATEFERMETUREDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CONTRATBindingSource, "DATEFERMETURE", True))
        Me.DATEFERMETUREDateTimePicker.Location = New System.Drawing.Point(654, 612)
        Me.DATEFERMETUREDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DATEFERMETUREDateTimePicker.Name = "DATEFERMETUREDateTimePicker"
        Me.DATEFERMETUREDateTimePicker.Size = New System.Drawing.Size(370, 26)
        Me.DATEFERMETUREDateTimePicker.TabIndex = 9
        '
        'LOCATIONEQUIPEMENTTextBox
        '
        Me.LOCATIONEQUIPEMENTTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTRATBindingSource, "LOCATIONEQUIPEMENT", True))
        Me.LOCATIONEQUIPEMENTTextBox.Enabled = False
        Me.LOCATIONEQUIPEMENTTextBox.Location = New System.Drawing.Point(654, 652)
        Me.LOCATIONEQUIPEMENTTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LOCATIONEQUIPEMENTTextBox.Name = "LOCATIONEQUIPEMENTTextBox"
        Me.LOCATIONEQUIPEMENTTextBox.Size = New System.Drawing.Size(370, 26)
        Me.LOCATIONEQUIPEMENTTextBox.TabIndex = 11
        '
        'SERVICESTextBox
        '
        Me.SERVICESTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTRATBindingSource, "SERVICES", True))
        Me.SERVICESTextBox.Enabled = False
        Me.SERVICESTextBox.Location = New System.Drawing.Point(654, 692)
        Me.SERVICESTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SERVICESTextBox.Name = "SERVICESTextBox"
        Me.SERVICESTextBox.Size = New System.Drawing.Size(370, 26)
        Me.SERVICESTextBox.TabIndex = 13
        '
        'DATEMISEENVIGUEURDateTimePicker
        '
        Me.DATEMISEENVIGUEURDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.CONTRATBindingSource, "DATEMISEENVIGUEUR", True))
        Me.DATEMISEENVIGUEURDateTimePicker.Enabled = False
        Me.DATEMISEENVIGUEURDateTimePicker.Location = New System.Drawing.Point(654, 732)
        Me.DATEMISEENVIGUEURDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DATEMISEENVIGUEURDateTimePicker.Name = "DATEMISEENVIGUEURDateTimePicker"
        Me.DATEMISEENVIGUEURDateTimePicker.Size = New System.Drawing.Size(370, 26)
        Me.DATEMISEENVIGUEURDateTimePicker.TabIndex = 15
        '
        'BtnRenouveller
        '
        Me.BtnRenouveller.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRenouveller.Location = New System.Drawing.Point(62, 532)
        Me.BtnRenouveller.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnRenouveller.Name = "BtnRenouveller"
        Me.BtnRenouveller.Size = New System.Drawing.Size(202, 57)
        Me.BtnRenouveller.TabIndex = 16
        Me.BtnRenouveller.Text = "Renouveller "
        Me.BtnRenouveller.UseVisualStyleBackColor = True
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitter.Location = New System.Drawing.Point(62, 637)
        Me.BtnQuitter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(202, 57)
        Me.BtnQuitter.TabIndex = 17
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'Titre
        '
        Me.Titre.BackColor = System.Drawing.Color.White
        Me.Titre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titre.Location = New System.Drawing.Point(252, 54)
        Me.Titre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Titre.Name = "Titre"
        Me.Titre.Size = New System.Drawing.Size(575, 34)
        Me.Titre.TabIndex = 37
        Me.Titre.Text = "La liste des contrats"
        Me.Titre.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(252, 445)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(575, 34)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Détails du contrat"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(32, 492)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(244, 252)
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(396, 452)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(692, 329)
        Me.Label2.TabIndex = 39
        '
        'FrmRenouveller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1214, 803)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Titre)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.BtnRenouveller)
        Me.Controls.Add(NUMCONTRATLabel)
        Me.Controls.Add(Me.NUMCONTRATTextBox)
        Me.Controls.Add(TYPECONTRATLabel)
        Me.Controls.Add(Me.TYPECONTRATTextBox)
        Me.Controls.Add(DATEOUVERTURELabel)
        Me.Controls.Add(Me.DATEOUVERTUREDateTimePicker)
        Me.Controls.Add(DATEFERMETURELabel)
        Me.Controls.Add(Me.DATEFERMETUREDateTimePicker)
        Me.Controls.Add(LOCATIONEQUIPEMENTLabel)
        Me.Controls.Add(Me.LOCATIONEQUIPEMENTTextBox)
        Me.Controls.Add(SERVICESLabel)
        Me.Controls.Add(Me.SERVICESTextBox)
        Me.Controls.Add(DATEMISEENVIGUEURLabel)
        Me.Controls.Add(Me.DATEMISEENVIGUEURDateTimePicker)
        Me.Controls.Add(Me.CONTRATDataGridView)
        Me.Controls.Add(Me.CONTRATBindingNavigator)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmRenouveller"
        Me.Text = "Renouveller contrat"
        CType(Me.SgariBddDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRATBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTRATBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CONTRATBindingNavigator.ResumeLayout(False)
        Me.CONTRATBindingNavigator.PerformLayout()
        CType(Me.CONTRATDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SgariBddDataSet As SgariBddDataSet
    Friend WithEvents CONTRATBindingSource As BindingSource
    Friend WithEvents CONTRATTableAdapter As SgariBddDataSetTableAdapters.CONTRATTableAdapter
    Friend WithEvents TableAdapterManager As SgariBddDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CONTRATBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CONTRATBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CONTRATDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents NUMCONTRATTextBox As TextBox
    Friend WithEvents TYPECONTRATTextBox As TextBox
    Friend WithEvents DATEOUVERTUREDateTimePicker As DateTimePicker
    Friend WithEvents DATEFERMETUREDateTimePicker As DateTimePicker
    Friend WithEvents LOCATIONEQUIPEMENTTextBox As TextBox
    Friend WithEvents SERVICESTextBox As TextBox
    Friend WithEvents DATEMISEENVIGUEURDateTimePicker As DateTimePicker
    Friend WithEvents BtnRenouveller As Button
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Titre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
