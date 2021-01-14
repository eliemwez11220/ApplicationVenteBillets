<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBillets
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
        Dim NumeroBilletLabel As System.Windows.Forms.Label
        Dim DateBilletLabel As System.Windows.Forms.Label
        Dim NomAgentLabel As System.Windows.Forms.Label
        Dim FonctionAgentLabel As System.Windows.Forms.Label
        Dim PrixBilletLabel As System.Windows.Forms.Label
        Dim PourcReductionLabel As System.Windows.Forms.Label
        Dim MotifReductionLabel As System.Windows.Forms.Label
        Dim TVALabel As System.Windows.Forms.Label
        Dim ClientIDLabel As System.Windows.Forms.Label
        Dim PlaceReserveeIDLabel As System.Windows.Forms.Label
        Dim Nom_clientLabel As System.Windows.Forms.Label
        Dim Type_clientLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBillets))
        Me.Sncc_vente_billets_dbDataSet = New venteBilletApp.sncc_vente_billets_dbDataSet()
        Me.Tb_billetsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_billetsTableAdapter = New venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.tb_billetsTableAdapter()
        Me.TableAdapterManager = New venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.TableAdapterManager()
        Me.Tb_clientsTableAdapter = New venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.tb_clientsTableAdapter()
        Me.Tb_reservationsTableAdapter = New venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.tb_reservationsTableAdapter()
        Me.Tb_billetsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NumeroBilletTextBox = New System.Windows.Forms.TextBox()
        Me.DateBilletDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NomAgentTextBox = New System.Windows.Forms.TextBox()
        Me.FonctionAgentComboBox = New System.Windows.Forms.ComboBox()
        Me.PrixBilletTextBox = New System.Windows.Forms.TextBox()
        Me.PourcReductionTextBox = New System.Windows.Forms.TextBox()
        Me.MotifReductionTextBox = New System.Windows.Forms.TextBox()
        Me.MontantTotalTextBox = New System.Windows.Forms.TextBox()
        Me.TVATextBox = New System.Windows.Forms.TextBox()
        Me.ClientIDComboBox = New System.Windows.Forms.ComboBox()
        Me.TbclientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlaceReserveeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.TbreservationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_billetsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Nom_clientTextBox = New System.Windows.Forms.TextBox()
        Me.Type_clientTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        NumeroBilletLabel = New System.Windows.Forms.Label()
        DateBilletLabel = New System.Windows.Forms.Label()
        NomAgentLabel = New System.Windows.Forms.Label()
        FonctionAgentLabel = New System.Windows.Forms.Label()
        PrixBilletLabel = New System.Windows.Forms.Label()
        PourcReductionLabel = New System.Windows.Forms.Label()
        MotifReductionLabel = New System.Windows.Forms.Label()
        TVALabel = New System.Windows.Forms.Label()
        ClientIDLabel = New System.Windows.Forms.Label()
        PlaceReserveeIDLabel = New System.Windows.Forms.Label()
        Nom_clientLabel = New System.Windows.Forms.Label()
        Type_clientLabel = New System.Windows.Forms.Label()
        CType(Me.Sncc_vente_billets_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_billetsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_billetsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_billetsBindingNavigator.SuspendLayout()
        CType(Me.TbclientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbreservationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_billetsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumeroBilletLabel
        '
        NumeroBilletLabel.AutoSize = True
        NumeroBilletLabel.Location = New System.Drawing.Point(34, 43)
        NumeroBilletLabel.Name = "NumeroBilletLabel"
        NumeroBilletLabel.Size = New System.Drawing.Size(70, 13)
        NumeroBilletLabel.TabIndex = 1
        NumeroBilletLabel.Text = "numero Billet:"
        '
        'DateBilletLabel
        '
        DateBilletLabel.AutoSize = True
        DateBilletLabel.Location = New System.Drawing.Point(48, 69)
        DateBilletLabel.Name = "DateBilletLabel"
        DateBilletLabel.Size = New System.Drawing.Size(56, 13)
        DateBilletLabel.TabIndex = 3
        DateBilletLabel.Text = "date Billet:"
        '
        'NomAgentLabel
        '
        NomAgentLabel.AutoSize = True
        NomAgentLabel.Location = New System.Drawing.Point(43, 95)
        NomAgentLabel.Name = "NomAgentLabel"
        NomAgentLabel.Size = New System.Drawing.Size(61, 13)
        NomAgentLabel.TabIndex = 5
        NomAgentLabel.Text = "nom Agent:"
        '
        'FonctionAgentLabel
        '
        FonctionAgentLabel.AutoSize = True
        FonctionAgentLabel.Location = New System.Drawing.Point(25, 118)
        FonctionAgentLabel.Name = "FonctionAgentLabel"
        FonctionAgentLabel.Size = New System.Drawing.Size(79, 13)
        FonctionAgentLabel.TabIndex = 7
        FonctionAgentLabel.Text = "fonction Agent:"
        '
        'PrixBilletLabel
        '
        PrixBilletLabel.AutoSize = True
        PrixBilletLabel.Location = New System.Drawing.Point(53, 148)
        PrixBilletLabel.Name = "PrixBilletLabel"
        PrixBilletLabel.Size = New System.Drawing.Size(51, 13)
        PrixBilletLabel.TabIndex = 9
        PrixBilletLabel.Text = "prix Billet:"
        '
        'PourcReductionLabel
        '
        PourcReductionLabel.AutoSize = True
        PourcReductionLabel.Location = New System.Drawing.Point(34, 204)
        PourcReductionLabel.Name = "PourcReductionLabel"
        PourcReductionLabel.Size = New System.Drawing.Size(70, 13)
        PourcReductionLabel.TabIndex = 11
        PourcReductionLabel.Text = "% Reduction:"
        '
        'MotifReductionLabel
        '
        MotifReductionLabel.AutoSize = True
        MotifReductionLabel.Location = New System.Drawing.Point(544, 121)
        MotifReductionLabel.Name = "MotifReductionLabel"
        MotifReductionLabel.Size = New System.Drawing.Size(84, 13)
        MotifReductionLabel.TabIndex = 13
        MotifReductionLabel.Text = "motif Reduction:"
        '
        'TVALabel
        '
        TVALabel.AutoSize = True
        TVALabel.Location = New System.Drawing.Point(73, 178)
        TVALabel.Name = "TVALabel"
        TVALabel.Size = New System.Drawing.Size(31, 13)
        TVALabel.TabIndex = 17
        TVALabel.Text = "TVA:"
        '
        'ClientIDLabel
        '
        ClientIDLabel.AutoSize = True
        ClientIDLabel.Location = New System.Drawing.Point(579, 38)
        ClientIDLabel.Name = "ClientIDLabel"
        ClientIDLabel.Size = New System.Drawing.Size(49, 13)
        ClientIDLabel.TabIndex = 19
        ClientIDLabel.Text = "client ID:"
        '
        'PlaceReserveeIDLabel
        '
        PlaceReserveeIDLabel.AutoSize = True
        PlaceReserveeIDLabel.Location = New System.Drawing.Point(528, 96)
        PlaceReserveeIDLabel.Name = "PlaceReserveeIDLabel"
        PlaceReserveeIDLabel.Size = New System.Drawing.Size(100, 13)
        PlaceReserveeIDLabel.TabIndex = 21
        PlaceReserveeIDLabel.Text = "Place Reservee ID:"
        '
        'Nom_clientLabel
        '
        Nom_clientLabel.AutoSize = True
        Nom_clientLabel.Location = New System.Drawing.Point(581, 67)
        Nom_clientLabel.Name = "Nom_clientLabel"
        Nom_clientLabel.Size = New System.Drawing.Size(58, 13)
        Nom_clientLabel.TabIndex = 26
        Nom_clientLabel.Text = "nom client:"
        '
        'Type_clientLabel
        '
        Type_clientLabel.AutoSize = True
        Type_clientLabel.Location = New System.Drawing.Point(815, 69)
        Type_clientLabel.Name = "Type_clientLabel"
        Type_clientLabel.Size = New System.Drawing.Size(58, 13)
        Type_clientLabel.TabIndex = 28
        Type_clientLabel.Text = "type client:"
        '
        'Sncc_vente_billets_dbDataSet
        '
        Me.Sncc_vente_billets_dbDataSet.DataSetName = "sncc_vente_billets_dbDataSet"
        Me.Sncc_vente_billets_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_billetsBindingSource
        '
        Me.Tb_billetsBindingSource.DataMember = "tb_billets"
        Me.Tb_billetsBindingSource.DataSource = Me.Sncc_vente_billets_dbDataSet
        '
        'Tb_billetsTableAdapter
        '
        Me.Tb_billetsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_billetsTableAdapter = Me.Tb_billetsTableAdapter
        Me.TableAdapterManager.tb_clientsTableAdapter = Me.Tb_clientsTableAdapter
        Me.TableAdapterManager.tb_reservationsTableAdapter = Me.Tb_reservationsTableAdapter
        Me.TableAdapterManager.UpdateOrder = venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_clientsTableAdapter
        '
        Me.Tb_clientsTableAdapter.ClearBeforeFill = True
        '
        'Tb_reservationsTableAdapter
        '
        Me.Tb_reservationsTableAdapter.ClearBeforeFill = True
        '
        'Tb_billetsBindingNavigator
        '
        Me.Tb_billetsBindingNavigator.AddNewItem = Nothing
        Me.Tb_billetsBindingNavigator.BindingSource = Me.Tb_billetsBindingSource
        Me.Tb_billetsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_billetsBindingNavigator.DeleteItem = Nothing
        Me.Tb_billetsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Tb_billetsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_billetsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_billetsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_billetsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_billetsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_billetsBindingNavigator.Name = "Tb_billetsBindingNavigator"
        Me.Tb_billetsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_billetsBindingNavigator.Size = New System.Drawing.Size(1032, 25)
        Me.Tb_billetsBindingNavigator.TabIndex = 0
        Me.Tb_billetsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(68, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Premier"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(80, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Precedent"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(66, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Suivant"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(65, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Dernier"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'NumeroBilletTextBox
        '
        Me.NumeroBilletTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_billetsBindingSource, "numeroBillet", True))
        Me.NumeroBilletTextBox.Location = New System.Drawing.Point(121, 40)
        Me.NumeroBilletTextBox.Name = "NumeroBilletTextBox"
        Me.NumeroBilletTextBox.Size = New System.Drawing.Size(366, 20)
        Me.NumeroBilletTextBox.TabIndex = 2
        '
        'DateBilletDateTimePicker
        '
        Me.DateBilletDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tb_billetsBindingSource, "dateBillet", True))
        Me.DateBilletDateTimePicker.Location = New System.Drawing.Point(121, 66)
        Me.DateBilletDateTimePicker.Name = "DateBilletDateTimePicker"
        Me.DateBilletDateTimePicker.Size = New System.Drawing.Size(366, 20)
        Me.DateBilletDateTimePicker.TabIndex = 4
        '
        'NomAgentTextBox
        '
        Me.NomAgentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_billetsBindingSource, "nomAgent", True))
        Me.NomAgentTextBox.Location = New System.Drawing.Point(121, 92)
        Me.NomAgentTextBox.Name = "NomAgentTextBox"
        Me.NomAgentTextBox.Size = New System.Drawing.Size(366, 20)
        Me.NomAgentTextBox.TabIndex = 6
        '
        'FonctionAgentComboBox
        '
        Me.FonctionAgentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_billetsBindingSource, "fonctionAgent", True))
        Me.FonctionAgentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FonctionAgentComboBox.FormattingEnabled = True
        Me.FonctionAgentComboBox.Items.AddRange(New Object() {"Taxateur", "Guichetier", "Chef Consigne", "Chef Receveur"})
        Me.FonctionAgentComboBox.Location = New System.Drawing.Point(121, 118)
        Me.FonctionAgentComboBox.Name = "FonctionAgentComboBox"
        Me.FonctionAgentComboBox.Size = New System.Drawing.Size(366, 21)
        Me.FonctionAgentComboBox.TabIndex = 8
        '
        'PrixBilletTextBox
        '
        Me.PrixBilletTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_billetsBindingSource, "prixBillet", True))
        Me.PrixBilletTextBox.Location = New System.Drawing.Point(121, 145)
        Me.PrixBilletTextBox.Name = "PrixBilletTextBox"
        Me.PrixBilletTextBox.Size = New System.Drawing.Size(366, 20)
        Me.PrixBilletTextBox.TabIndex = 10
        '
        'PourcReductionTextBox
        '
        Me.PourcReductionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_billetsBindingSource, "pourcReduction", True))
        Me.PourcReductionTextBox.Location = New System.Drawing.Point(121, 201)
        Me.PourcReductionTextBox.Name = "PourcReductionTextBox"
        Me.PourcReductionTextBox.Size = New System.Drawing.Size(366, 20)
        Me.PourcReductionTextBox.TabIndex = 12
        '
        'MotifReductionTextBox
        '
        Me.MotifReductionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_billetsBindingSource, "motifReduction", True))
        Me.MotifReductionTextBox.Location = New System.Drawing.Point(645, 118)
        Me.MotifReductionTextBox.Name = "MotifReductionTextBox"
        Me.MotifReductionTextBox.Size = New System.Drawing.Size(366, 20)
        Me.MotifReductionTextBox.TabIndex = 14
        '
        'MontantTotalTextBox
        '
        Me.MontantTotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_billetsBindingSource, "montantTotal", True))
        Me.MontantTotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontantTotalTextBox.Location = New System.Drawing.Point(844, 144)
        Me.MontantTotalTextBox.Multiline = True
        Me.MontantTotalTextBox.Name = "MontantTotalTextBox"
        Me.MontantTotalTextBox.Size = New System.Drawing.Size(167, 48)
        Me.MontantTotalTextBox.TabIndex = 16
        '
        'TVATextBox
        '
        Me.TVATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_billetsBindingSource, "TVA", True))
        Me.TVATextBox.Location = New System.Drawing.Point(121, 175)
        Me.TVATextBox.Name = "TVATextBox"
        Me.TVATextBox.Size = New System.Drawing.Size(366, 20)
        Me.TVATextBox.TabIndex = 18
        '
        'ClientIDComboBox
        '
        Me.ClientIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_billetsBindingSource, "clientID", True))
        Me.ClientIDComboBox.DataSource = Me.TbclientsBindingSource
        Me.ClientIDComboBox.DisplayMember = "numero_carte"
        Me.ClientIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClientIDComboBox.FormattingEnabled = True
        Me.ClientIDComboBox.Location = New System.Drawing.Point(645, 37)
        Me.ClientIDComboBox.Name = "ClientIDComboBox"
        Me.ClientIDComboBox.Size = New System.Drawing.Size(366, 21)
        Me.ClientIDComboBox.TabIndex = 20
        Me.ClientIDComboBox.ValueMember = "numero_carte"
        '
        'TbclientsBindingSource
        '
        Me.TbclientsBindingSource.DataMember = "tb_clients"
        Me.TbclientsBindingSource.DataSource = Me.Sncc_vente_billets_dbDataSet
        '
        'PlaceReserveeIDComboBox
        '
        Me.PlaceReserveeIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_billetsBindingSource, "PlaceReserveeID", True))
        Me.PlaceReserveeIDComboBox.DataSource = Me.TbreservationsBindingSource
        Me.PlaceReserveeIDComboBox.DisplayMember = "numeroPlace"
        Me.PlaceReserveeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PlaceReserveeIDComboBox.FormattingEnabled = True
        Me.PlaceReserveeIDComboBox.Location = New System.Drawing.Point(645, 92)
        Me.PlaceReserveeIDComboBox.Name = "PlaceReserveeIDComboBox"
        Me.PlaceReserveeIDComboBox.Size = New System.Drawing.Size(366, 21)
        Me.PlaceReserveeIDComboBox.TabIndex = 22
        Me.PlaceReserveeIDComboBox.ValueMember = "numeroPlace"
        '
        'TbreservationsBindingSource
        '
        Me.TbreservationsBindingSource.DataMember = "tb_reservations"
        Me.TbreservationsBindingSource.DataSource = Me.Sncc_vente_billets_dbDataSet
        '
        'Tb_billetsDataGridView
        '
        Me.Tb_billetsDataGridView.AutoGenerateColumns = False
        Me.Tb_billetsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Tb_billetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_billetsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.Tb_billetsDataGridView.DataSource = Me.Tb_billetsBindingSource
        Me.Tb_billetsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Tb_billetsDataGridView.Location = New System.Drawing.Point(0, 268)
        Me.Tb_billetsDataGridView.Name = "Tb_billetsDataGridView"
        Me.Tb_billetsDataGridView.Size = New System.Drawing.Size(1032, 208)
        Me.Tb_billetsDataGridView.TabIndex = 23
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "numeroBillet"
        Me.DataGridViewTextBoxColumn1.HeaderText = "numeroBillet"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "dateBillet"
        Me.DataGridViewTextBoxColumn2.HeaderText = "dateBillet"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "nomAgent"
        Me.DataGridViewTextBoxColumn3.HeaderText = "nomAgent"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fonctionAgent"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fonctionAgent"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "prixBillet"
        Me.DataGridViewTextBoxColumn5.HeaderText = "prixBillet"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "pourcReduction"
        Me.DataGridViewTextBoxColumn6.HeaderText = "pourcReduction"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "motifReduction"
        Me.DataGridViewTextBoxColumn7.HeaderText = "motifReduction"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "montantTotal"
        Me.DataGridViewTextBoxColumn8.HeaderText = "montantTotal"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TVA"
        Me.DataGridViewTextBoxColumn9.HeaderText = "TVA"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "clientID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "clientID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "PlaceReserveeID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "PlaceReserveeID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(645, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 47)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Calculer montant"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(645, 201)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 47)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Enregistrer billet"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(771, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(240, 29)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Creer nouveau billet"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Nom_clientTextBox
        '
        Me.Nom_clientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientsBindingSource, "nom_client", True))
        Me.Nom_clientTextBox.Location = New System.Drawing.Point(645, 64)
        Me.Nom_clientTextBox.Name = "Nom_clientTextBox"
        Me.Nom_clientTextBox.ReadOnly = True
        Me.Nom_clientTextBox.Size = New System.Drawing.Size(164, 20)
        Me.Nom_clientTextBox.TabIndex = 27
        '
        'Type_clientTextBox
        '
        Me.Type_clientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientsBindingSource, "type_client", True))
        Me.Type_clientTextBox.Location = New System.Drawing.Point(879, 64)
        Me.Type_clientTextBox.Name = "Type_clientTextBox"
        Me.Type_clientTextBox.ReadOnly = True
        Me.Type_clientTextBox.Size = New System.Drawing.Size(132, 20)
        Me.Type_clientTextBox.TabIndex = 29
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(844, 201)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(167, 47)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "Modifier"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FormBillets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 476)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Type_clientLabel)
        Me.Controls.Add(Me.Type_clientTextBox)
        Me.Controls.Add(Nom_clientLabel)
        Me.Controls.Add(Me.Nom_clientTextBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tb_billetsDataGridView)
        Me.Controls.Add(NumeroBilletLabel)
        Me.Controls.Add(Me.NumeroBilletTextBox)
        Me.Controls.Add(DateBilletLabel)
        Me.Controls.Add(Me.DateBilletDateTimePicker)
        Me.Controls.Add(NomAgentLabel)
        Me.Controls.Add(Me.NomAgentTextBox)
        Me.Controls.Add(FonctionAgentLabel)
        Me.Controls.Add(Me.FonctionAgentComboBox)
        Me.Controls.Add(PrixBilletLabel)
        Me.Controls.Add(Me.PrixBilletTextBox)
        Me.Controls.Add(PourcReductionLabel)
        Me.Controls.Add(Me.PourcReductionTextBox)
        Me.Controls.Add(MotifReductionLabel)
        Me.Controls.Add(Me.MotifReductionTextBox)
        Me.Controls.Add(Me.MontantTotalTextBox)
        Me.Controls.Add(TVALabel)
        Me.Controls.Add(Me.TVATextBox)
        Me.Controls.Add(ClientIDLabel)
        Me.Controls.Add(Me.ClientIDComboBox)
        Me.Controls.Add(PlaceReserveeIDLabel)
        Me.Controls.Add(Me.PlaceReserveeIDComboBox)
        Me.Controls.Add(Me.Tb_billetsBindingNavigator)
        Me.Name = "FormBillets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBillets"
        CType(Me.Sncc_vente_billets_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_billetsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_billetsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_billetsBindingNavigator.ResumeLayout(False)
        Me.Tb_billetsBindingNavigator.PerformLayout()
        CType(Me.TbclientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbreservationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_billetsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Sncc_vente_billets_dbDataSet As venteBilletApp.sncc_vente_billets_dbDataSet
    Friend WithEvents Tb_billetsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_billetsTableAdapter As venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.tb_billetsTableAdapter
    Friend WithEvents TableAdapterManager As venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_billetsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NumeroBilletTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateBilletDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NomAgentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FonctionAgentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PrixBilletTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PourcReductionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MotifReductionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MontantTotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TVATextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClientIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PlaceReserveeIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Tb_billetsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Tb_clientsTableAdapter As venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.tb_clientsTableAdapter
    Friend WithEvents TbclientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_reservationsTableAdapter As venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.tb_reservationsTableAdapter
    Friend WithEvents TbreservationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Nom_clientTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Type_clientTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
