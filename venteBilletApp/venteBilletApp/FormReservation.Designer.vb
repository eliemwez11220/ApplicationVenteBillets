<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReservation
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
        Dim DateReservationLabel As System.Windows.Forms.Label
        Dim NumeroPlaceLabel As System.Windows.Forms.Label
        Dim DateVoyageLabel As System.Windows.Forms.Label
        Dim CodeClasseLabel As System.Windows.Forms.Label
        Dim CompartimentLabel As System.Windows.Forms.Label
        Dim ProvenanceLabel As System.Windows.Forms.Label
        Dim DestinationLabel As System.Windows.Forms.Label
        Dim ClientIDLabel As System.Windows.Forms.Label
        Dim VoitureIDLabel As System.Windows.Forms.Label
        Dim TrainIDLabel As System.Windows.Forms.Label
        Dim NomAgentLabel As System.Windows.Forms.Label
        Dim FonctionAgentLabel As System.Windows.Forms.Label
        Dim HeureVoyageLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReservation))
        Me.Sncc_vente_billets_dbDataSet = New venteBilletApp.sncc_vente_billets_dbDataSet()
        Me.Tb_reservationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_reservationsTableAdapter = New venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.tb_reservationsTableAdapter()
        Me.TableAdapterManager = New venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.TableAdapterManager()
        Me.Tb_clientsTableAdapter = New venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.tb_clientsTableAdapter()
        Me.Tb_reservationsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Tb_reservationsDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateReservationDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NumeroPlaceTextBox = New System.Windows.Forms.TextBox()
        Me.DateVoyageDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CodeClasseComboBox = New System.Windows.Forms.ComboBox()
        Me.CompartimentComboBox = New System.Windows.Forms.ComboBox()
        Me.ProvenanceTextBox = New System.Windows.Forms.TextBox()
        Me.ClientIDComboBox = New System.Windows.Forms.ComboBox()
        Me.TbclientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VoitureIDTextBox = New System.Windows.Forms.TextBox()
        Me.NomAgentTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.HeureVoyageMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.FonctionAgentComboBox = New System.Windows.Forms.ComboBox()
        Me.TrainIDComboBox = New System.Windows.Forms.ComboBox()
        Me.DestinationComboBox = New System.Windows.Forms.ComboBox()
        Me.Nom_clientTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        DateReservationLabel = New System.Windows.Forms.Label()
        NumeroPlaceLabel = New System.Windows.Forms.Label()
        DateVoyageLabel = New System.Windows.Forms.Label()
        CodeClasseLabel = New System.Windows.Forms.Label()
        CompartimentLabel = New System.Windows.Forms.Label()
        ProvenanceLabel = New System.Windows.Forms.Label()
        DestinationLabel = New System.Windows.Forms.Label()
        ClientIDLabel = New System.Windows.Forms.Label()
        VoitureIDLabel = New System.Windows.Forms.Label()
        TrainIDLabel = New System.Windows.Forms.Label()
        NomAgentLabel = New System.Windows.Forms.Label()
        FonctionAgentLabel = New System.Windows.Forms.Label()
        HeureVoyageLabel = New System.Windows.Forms.Label()
        CType(Me.Sncc_vente_billets_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_reservationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_reservationsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_reservationsBindingNavigator.SuspendLayout()
        CType(Me.Tb_reservationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbclientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateReservationLabel
        '
        DateReservationLabel.AutoSize = True
        DateReservationLabel.Location = New System.Drawing.Point(19, 205)
        DateReservationLabel.Name = "DateReservationLabel"
        DateReservationLabel.Size = New System.Drawing.Size(91, 13)
        DateReservationLabel.TabIndex = 2
        DateReservationLabel.Text = "date Reservation:"
        '
        'NumeroPlaceLabel
        '
        NumeroPlaceLabel.AutoSize = True
        NumeroPlaceLabel.Location = New System.Drawing.Point(19, 42)
        NumeroPlaceLabel.Name = "NumeroPlaceLabel"
        NumeroPlaceLabel.Size = New System.Drawing.Size(75, 13)
        NumeroPlaceLabel.TabIndex = 4
        NumeroPlaceLabel.Text = "numero Place:"
        '
        'DateVoyageLabel
        '
        DateVoyageLabel.AutoSize = True
        DateVoyageLabel.Location = New System.Drawing.Point(19, 69)
        DateVoyageLabel.Name = "DateVoyageLabel"
        DateVoyageLabel.Size = New System.Drawing.Size(70, 13)
        DateVoyageLabel.TabIndex = 6
        DateVoyageLabel.Text = "date Voyage:"
        '
        'CodeClasseLabel
        '
        CodeClasseLabel.AutoSize = True
        CodeClasseLabel.Location = New System.Drawing.Point(19, 94)
        CodeClasseLabel.Name = "CodeClasseLabel"
        CodeClasseLabel.Size = New System.Drawing.Size(68, 13)
        CodeClasseLabel.TabIndex = 8
        CodeClasseLabel.Text = "code Classe:"
        '
        'CompartimentLabel
        '
        CompartimentLabel.AutoSize = True
        CompartimentLabel.Location = New System.Drawing.Point(19, 121)
        CompartimentLabel.Name = "CompartimentLabel"
        CompartimentLabel.Size = New System.Drawing.Size(73, 13)
        CompartimentLabel.TabIndex = 10
        CompartimentLabel.Text = "compartiment:"
        '
        'ProvenanceLabel
        '
        ProvenanceLabel.AutoSize = True
        ProvenanceLabel.Location = New System.Drawing.Point(19, 148)
        ProvenanceLabel.Name = "ProvenanceLabel"
        ProvenanceLabel.Size = New System.Drawing.Size(67, 13)
        ProvenanceLabel.TabIndex = 12
        ProvenanceLabel.Text = "provenance:"
        '
        'DestinationLabel
        '
        DestinationLabel.AutoSize = True
        DestinationLabel.Location = New System.Drawing.Point(19, 174)
        DestinationLabel.Name = "DestinationLabel"
        DestinationLabel.Size = New System.Drawing.Size(61, 13)
        DestinationLabel.TabIndex = 14
        DestinationLabel.Text = "destination:"
        '
        'ClientIDLabel
        '
        ClientIDLabel.AutoSize = True
        ClientIDLabel.Location = New System.Drawing.Point(592, 56)
        ClientIDLabel.Name = "ClientIDLabel"
        ClientIDLabel.Size = New System.Drawing.Size(49, 13)
        ClientIDLabel.TabIndex = 16
        ClientIDLabel.Text = "client ID:"
        '
        'VoitureIDLabel
        '
        VoitureIDLabel.AutoSize = True
        VoitureIDLabel.Location = New System.Drawing.Point(585, 87)
        VoitureIDLabel.Name = "VoitureIDLabel"
        VoitureIDLabel.Size = New System.Drawing.Size(56, 13)
        VoitureIDLabel.TabIndex = 18
        VoitureIDLabel.Text = "voiture ID:"
        '
        'TrainIDLabel
        '
        TrainIDLabel.AutoSize = True
        TrainIDLabel.Location = New System.Drawing.Point(602, 113)
        TrainIDLabel.Name = "TrainIDLabel"
        TrainIDLabel.Size = New System.Drawing.Size(44, 13)
        TrainIDLabel.TabIndex = 20
        TrainIDLabel.Text = "train ID:"
        '
        'NomAgentLabel
        '
        NomAgentLabel.AutoSize = True
        NomAgentLabel.Location = New System.Drawing.Point(585, 137)
        NomAgentLabel.Name = "NomAgentLabel"
        NomAgentLabel.Size = New System.Drawing.Size(61, 13)
        NomAgentLabel.TabIndex = 22
        NomAgentLabel.Text = "nom Agent:"
        '
        'FonctionAgentLabel
        '
        FonctionAgentLabel.AutoSize = True
        FonctionAgentLabel.Location = New System.Drawing.Point(570, 164)
        FonctionAgentLabel.Name = "FonctionAgentLabel"
        FonctionAgentLabel.Size = New System.Drawing.Size(79, 13)
        FonctionAgentLabel.TabIndex = 24
        FonctionAgentLabel.Text = "fonction Agent:"
        '
        'HeureVoyageLabel
        '
        HeureVoyageLabel.AutoSize = True
        HeureVoyageLabel.Location = New System.Drawing.Point(570, 191)
        HeureVoyageLabel.Name = "HeureVoyageLabel"
        HeureVoyageLabel.Size = New System.Drawing.Size(76, 13)
        HeureVoyageLabel.TabIndex = 26
        HeureVoyageLabel.Text = "heure Voyage:"
        '
        'Sncc_vente_billets_dbDataSet
        '
        Me.Sncc_vente_billets_dbDataSet.DataSetName = "sncc_vente_billets_dbDataSet"
        Me.Sncc_vente_billets_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_reservationsBindingSource
        '
        Me.Tb_reservationsBindingSource.DataMember = "tb_reservations"
        Me.Tb_reservationsBindingSource.DataSource = Me.Sncc_vente_billets_dbDataSet
        '
        'Tb_reservationsTableAdapter
        '
        Me.Tb_reservationsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_billetsTableAdapter = Nothing
        Me.TableAdapterManager.tb_clientsTableAdapter = Me.Tb_clientsTableAdapter
        Me.TableAdapterManager.tb_reservationsTableAdapter = Me.Tb_reservationsTableAdapter
        Me.TableAdapterManager.UpdateOrder = venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_clientsTableAdapter
        '
        Me.Tb_clientsTableAdapter.ClearBeforeFill = True
        '
        'Tb_reservationsBindingNavigator
        '
        Me.Tb_reservationsBindingNavigator.AddNewItem = Nothing
        Me.Tb_reservationsBindingNavigator.BindingSource = Me.Tb_reservationsBindingSource
        Me.Tb_reservationsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_reservationsBindingNavigator.DeleteItem = Nothing
        Me.Tb_reservationsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Tb_reservationsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_reservationsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_reservationsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_reservationsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_reservationsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_reservationsBindingNavigator.Name = "Tb_reservationsBindingNavigator"
        Me.Tb_reservationsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_reservationsBindingNavigator.Size = New System.Drawing.Size(1056, 25)
        Me.Tb_reservationsBindingNavigator.TabIndex = 0
        Me.Tb_reservationsBindingNavigator.Text = "BindingNavigator1"
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
        'Tb_reservationsDataGridView
        '
        Me.Tb_reservationsDataGridView.AutoGenerateColumns = False
        Me.Tb_reservationsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Tb_reservationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_reservationsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.Tb_reservationsDataGridView.DataSource = Me.Tb_reservationsBindingSource
        Me.Tb_reservationsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Tb_reservationsDataGridView.Location = New System.Drawing.Point(0, 288)
        Me.Tb_reservationsDataGridView.Name = "Tb_reservationsDataGridView"
        Me.Tb_reservationsDataGridView.Size = New System.Drawing.Size(1056, 227)
        Me.Tb_reservationsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "dateReservation"
        Me.DataGridViewTextBoxColumn1.HeaderText = "dateReservation"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "numeroPlace"
        Me.DataGridViewTextBoxColumn2.HeaderText = "numeroPlace"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "dateVoyage"
        Me.DataGridViewTextBoxColumn3.HeaderText = "dateVoyage"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "codeClasse"
        Me.DataGridViewTextBoxColumn4.HeaderText = "codeClasse"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "compartiment"
        Me.DataGridViewTextBoxColumn5.HeaderText = "compartiment"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "provenance"
        Me.DataGridViewTextBoxColumn6.HeaderText = "provenance"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "destination"
        Me.DataGridViewTextBoxColumn7.HeaderText = "destination"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "clientID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "clientID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "voitureID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "voitureID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "trainID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "trainID"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "nomAgent"
        Me.DataGridViewTextBoxColumn11.HeaderText = "nomAgent"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "fonctionAgent"
        Me.DataGridViewTextBoxColumn12.HeaderText = "fonctionAgent"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "heureVoyage"
        Me.DataGridViewTextBoxColumn13.HeaderText = "heureVoyage"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DateReservationDateTimePicker
        '
        Me.DateReservationDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tb_reservationsBindingSource, "dateReservation", True))
        Me.DateReservationDateTimePicker.Location = New System.Drawing.Point(116, 205)
        Me.DateReservationDateTimePicker.Name = "DateReservationDateTimePicker"
        Me.DateReservationDateTimePicker.Size = New System.Drawing.Size(384, 20)
        Me.DateReservationDateTimePicker.TabIndex = 3
        '
        'NumeroPlaceTextBox
        '
        Me.NumeroPlaceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_reservationsBindingSource, "numeroPlace", True))
        Me.NumeroPlaceTextBox.Location = New System.Drawing.Point(116, 39)
        Me.NumeroPlaceTextBox.Name = "NumeroPlaceTextBox"
        Me.NumeroPlaceTextBox.Size = New System.Drawing.Size(384, 20)
        Me.NumeroPlaceTextBox.TabIndex = 5
        '
        'DateVoyageDateTimePicker
        '
        Me.DateVoyageDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tb_reservationsBindingSource, "dateVoyage", True))
        Me.DateVoyageDateTimePicker.Location = New System.Drawing.Point(116, 65)
        Me.DateVoyageDateTimePicker.Name = "DateVoyageDateTimePicker"
        Me.DateVoyageDateTimePicker.Size = New System.Drawing.Size(384, 20)
        Me.DateVoyageDateTimePicker.TabIndex = 7
        '
        'CodeClasseComboBox
        '
        Me.CodeClasseComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_reservationsBindingSource, "codeClasse", True))
        Me.CodeClasseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CodeClasseComboBox.FormattingEnabled = True
        Me.CodeClasseComboBox.Items.AddRange(New Object() {"1ere", "2eme", "3eme", "4eme", "5eme"})
        Me.CodeClasseComboBox.Location = New System.Drawing.Point(116, 91)
        Me.CodeClasseComboBox.Name = "CodeClasseComboBox"
        Me.CodeClasseComboBox.Size = New System.Drawing.Size(384, 21)
        Me.CodeClasseComboBox.TabIndex = 9
        '
        'CompartimentComboBox
        '
        Me.CompartimentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_reservationsBindingSource, "compartiment", True))
        Me.CompartimentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompartimentComboBox.FormattingEnabled = True
        Me.CompartimentComboBox.Items.AddRange(New Object() {"CompA", "CompB", "CompC", "CompD", "CompE", "CompF", "CompG", "CompH", "CompI", "CompJ", "CompK", "CompL", "CompM", "CompN", "CompO", "CompP", "CompQ", "CompR", "CompS", "CompU", "CompV", "CompT", "CompW", "CompX", "CompY", "CompZ"})
        Me.CompartimentComboBox.Location = New System.Drawing.Point(116, 118)
        Me.CompartimentComboBox.Name = "CompartimentComboBox"
        Me.CompartimentComboBox.Size = New System.Drawing.Size(384, 21)
        Me.CompartimentComboBox.TabIndex = 11
        '
        'ProvenanceTextBox
        '
        Me.ProvenanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_reservationsBindingSource, "provenance", True))
        Me.ProvenanceTextBox.Location = New System.Drawing.Point(116, 145)
        Me.ProvenanceTextBox.Name = "ProvenanceTextBox"
        Me.ProvenanceTextBox.Size = New System.Drawing.Size(384, 20)
        Me.ProvenanceTextBox.TabIndex = 13
        Me.ProvenanceTextBox.Text = "Lubumbashi"
        '
        'ClientIDComboBox
        '
        Me.ClientIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_reservationsBindingSource, "clientID", True))
        Me.ClientIDComboBox.DataSource = Me.TbclientsBindingSource
        Me.ClientIDComboBox.DisplayMember = "numero_carte"
        Me.ClientIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClientIDComboBox.FormattingEnabled = True
        Me.ClientIDComboBox.Location = New System.Drawing.Point(652, 53)
        Me.ClientIDComboBox.Name = "ClientIDComboBox"
        Me.ClientIDComboBox.Size = New System.Drawing.Size(167, 21)
        Me.ClientIDComboBox.TabIndex = 17
        Me.ClientIDComboBox.ValueMember = "numero_carte"
        '
        'TbclientsBindingSource
        '
        Me.TbclientsBindingSource.DataMember = "tb_clients"
        Me.TbclientsBindingSource.DataSource = Me.Sncc_vente_billets_dbDataSet
        '
        'VoitureIDTextBox
        '
        Me.VoitureIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_reservationsBindingSource, "voitureID", True))
        Me.VoitureIDTextBox.Location = New System.Drawing.Point(652, 80)
        Me.VoitureIDTextBox.Name = "VoitureIDTextBox"
        Me.VoitureIDTextBox.Size = New System.Drawing.Size(384, 20)
        Me.VoitureIDTextBox.TabIndex = 19
        '
        'NomAgentTextBox
        '
        Me.NomAgentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_reservationsBindingSource, "nomAgent", True))
        Me.NomAgentTextBox.Location = New System.Drawing.Point(652, 132)
        Me.NomAgentTextBox.Name = "NomAgentTextBox"
        Me.NomAgentTextBox.Size = New System.Drawing.Size(384, 20)
        Me.NomAgentTextBox.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(652, 219)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(225, 40)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Enregistrer reservation"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(652, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(384, 32)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "Ajouter une nouvelle reservation"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'HeureVoyageMaskedTextBox
        '
        Me.HeureVoyageMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_reservationsBindingSource, "heureVoyage", True))
        Me.HeureVoyageMaskedTextBox.Location = New System.Drawing.Point(652, 184)
        Me.HeureVoyageMaskedTextBox.Mask = "90:00"
        Me.HeureVoyageMaskedTextBox.Name = "HeureVoyageMaskedTextBox"
        Me.HeureVoyageMaskedTextBox.Size = New System.Drawing.Size(384, 20)
        Me.HeureVoyageMaskedTextBox.TabIndex = 31
        Me.HeureVoyageMaskedTextBox.ValidatingType = GetType(Date)
        '
        'FonctionAgentComboBox
        '
        Me.FonctionAgentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_reservationsBindingSource, "fonctionAgent", True))
        Me.FonctionAgentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FonctionAgentComboBox.FormattingEnabled = True
        Me.FonctionAgentComboBox.Items.AddRange(New Object() {"Taxateur", "Guichetier", "Chef Consigne", "Chef Receveur"})
        Me.FonctionAgentComboBox.Location = New System.Drawing.Point(652, 156)
        Me.FonctionAgentComboBox.Name = "FonctionAgentComboBox"
        Me.FonctionAgentComboBox.Size = New System.Drawing.Size(384, 21)
        Me.FonctionAgentComboBox.TabIndex = 32
        '
        'TrainIDComboBox
        '
        Me.TrainIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_reservationsBindingSource, "trainID", True))
        Me.TrainIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TrainIDComboBox.FormattingEnabled = True
        Me.TrainIDComboBox.Items.AddRange(New Object() {"DELUXE", "DIAMANT", "VIP", "ELECTRIQUE", "AUTRE"})
        Me.TrainIDComboBox.Location = New System.Drawing.Point(652, 104)
        Me.TrainIDComboBox.Name = "TrainIDComboBox"
        Me.TrainIDComboBox.Size = New System.Drawing.Size(384, 21)
        Me.TrainIDComboBox.TabIndex = 33
        '
        'DestinationComboBox
        '
        Me.DestinationComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_reservationsBindingSource, "destination", True))
        Me.DestinationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DestinationComboBox.FormattingEnabled = True
        Me.DestinationComboBox.Items.AddRange(New Object() {"DIAMANT", "DILOLO", "ILEBO", "IRONDELE", "KALEMIE", "KAMBELEMBELE", "SAKANIA"})
        Me.DestinationComboBox.Location = New System.Drawing.Point(116, 175)
        Me.DestinationComboBox.Name = "DestinationComboBox"
        Me.DestinationComboBox.Size = New System.Drawing.Size(384, 21)
        Me.DestinationComboBox.TabIndex = 34
        '
        'Nom_clientTextBox
        '
        Me.Nom_clientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TbclientsBindingSource, "nom_client", True))
        Me.Nom_clientTextBox.Location = New System.Drawing.Point(825, 53)
        Me.Nom_clientTextBox.Name = "Nom_clientTextBox"
        Me.Nom_clientTextBox.ReadOnly = True
        Me.Nom_clientTextBox.Size = New System.Drawing.Size(211, 20)
        Me.Nom_clientTextBox.TabIndex = 35
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(907, 219)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(129, 40)
        Me.Button4.TabIndex = 36
        Me.Button4.Text = "Modifier"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'FormReservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 515)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Nom_clientTextBox)
        Me.Controls.Add(Me.DestinationComboBox)
        Me.Controls.Add(Me.TrainIDComboBox)
        Me.Controls.Add(Me.FonctionAgentComboBox)
        Me.Controls.Add(Me.HeureVoyageMaskedTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DateReservationLabel)
        Me.Controls.Add(Me.DateReservationDateTimePicker)
        Me.Controls.Add(NumeroPlaceLabel)
        Me.Controls.Add(Me.NumeroPlaceTextBox)
        Me.Controls.Add(DateVoyageLabel)
        Me.Controls.Add(Me.DateVoyageDateTimePicker)
        Me.Controls.Add(CodeClasseLabel)
        Me.Controls.Add(Me.CodeClasseComboBox)
        Me.Controls.Add(CompartimentLabel)
        Me.Controls.Add(Me.CompartimentComboBox)
        Me.Controls.Add(ProvenanceLabel)
        Me.Controls.Add(Me.ProvenanceTextBox)
        Me.Controls.Add(DestinationLabel)
        Me.Controls.Add(ClientIDLabel)
        Me.Controls.Add(Me.ClientIDComboBox)
        Me.Controls.Add(VoitureIDLabel)
        Me.Controls.Add(Me.VoitureIDTextBox)
        Me.Controls.Add(TrainIDLabel)
        Me.Controls.Add(NomAgentLabel)
        Me.Controls.Add(Me.NomAgentTextBox)
        Me.Controls.Add(FonctionAgentLabel)
        Me.Controls.Add(HeureVoyageLabel)
        Me.Controls.Add(Me.Tb_reservationsDataGridView)
        Me.Controls.Add(Me.Tb_reservationsBindingNavigator)
        Me.Name = "FormReservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormReservation"
        CType(Me.Sncc_vente_billets_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_reservationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_reservationsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_reservationsBindingNavigator.ResumeLayout(False)
        Me.Tb_reservationsBindingNavigator.PerformLayout()
        CType(Me.Tb_reservationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbclientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Sncc_vente_billets_dbDataSet As venteBilletApp.sncc_vente_billets_dbDataSet
    Friend WithEvents Tb_reservationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_reservationsTableAdapter As venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.tb_reservationsTableAdapter
    Friend WithEvents TableAdapterManager As venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_reservationsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Tb_reservationsDataGridView As System.Windows.Forms.DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateReservationDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents NumeroPlaceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateVoyageDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CodeClasseComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CompartimentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ProvenanceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClientIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VoitureIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomAgentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Tb_clientsTableAdapter As venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.tb_clientsTableAdapter
    Friend WithEvents TbclientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HeureVoyageMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents FonctionAgentComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TrainIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DestinationComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Nom_clientTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
