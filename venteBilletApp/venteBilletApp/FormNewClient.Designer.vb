<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNewClient
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
        Dim Numero_carteLabel As System.Windows.Forms.Label
        Dim Nom_clientLabel As System.Windows.Forms.Label
        Dim Adresse_clientLabel As System.Windows.Forms.Label
        Dim Sexe_clientLabel As System.Windows.Forms.Label
        Dim Telephone_clientLabel As System.Windows.Forms.Label
        Dim Type_clientLabel As System.Windows.Forms.Label
        Dim Type_carteLabel As System.Windows.Forms.Label
        Dim Date_fin_validiteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNewClient))
        Me.Sncc_vente_billets_dbDataSet = New venteBilletApp.sncc_vente_billets_dbDataSet()
        Me.Tb_clientsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_clientsTableAdapter = New venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.tb_clientsTableAdapter()
        Me.TableAdapterManager = New venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.TableAdapterManager()
        Me.Tb_clientsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Numero_carteTextBox = New System.Windows.Forms.TextBox()
        Me.Nom_clientTextBox = New System.Windows.Forms.TextBox()
        Me.Adresse_clientRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Sexe_clientComboBox = New System.Windows.Forms.ComboBox()
        Me.Telephone_clientTextBox = New System.Windows.Forms.TextBox()
        Me.Type_clientComboBox = New System.Windows.Forms.ComboBox()
        Me.Type_carteComboBox = New System.Windows.Forms.ComboBox()
        Me.Date_fin_validiteDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Tb_clientsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Numero_carteLabel = New System.Windows.Forms.Label()
        Nom_clientLabel = New System.Windows.Forms.Label()
        Adresse_clientLabel = New System.Windows.Forms.Label()
        Sexe_clientLabel = New System.Windows.Forms.Label()
        Telephone_clientLabel = New System.Windows.Forms.Label()
        Type_clientLabel = New System.Windows.Forms.Label()
        Type_carteLabel = New System.Windows.Forms.Label()
        Date_fin_validiteLabel = New System.Windows.Forms.Label()
        CType(Me.Sncc_vente_billets_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_clientsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_clientsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tb_clientsBindingNavigator.SuspendLayout()
        CType(Me.Tb_clientsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Numero_carteLabel
        '
        Numero_carteLabel.AutoSize = True
        Numero_carteLabel.Location = New System.Drawing.Point(504, 39)
        Numero_carteLabel.Name = "Numero_carteLabel"
        Numero_carteLabel.Size = New System.Drawing.Size(72, 13)
        Numero_carteLabel.TabIndex = 1
        Numero_carteLabel.Text = "numero carte:"
        '
        'Nom_clientLabel
        '
        Nom_clientLabel.AutoSize = True
        Nom_clientLabel.Location = New System.Drawing.Point(42, 43)
        Nom_clientLabel.Name = "Nom_clientLabel"
        Nom_clientLabel.Size = New System.Drawing.Size(58, 13)
        Nom_clientLabel.TabIndex = 3
        Nom_clientLabel.Text = "nom client:"
        '
        'Adresse_clientLabel
        '
        Adresse_clientLabel.AutoSize = True
        Adresse_clientLabel.Location = New System.Drawing.Point(25, 153)
        Adresse_clientLabel.Name = "Adresse_clientLabel"
        Adresse_clientLabel.Size = New System.Drawing.Size(75, 13)
        Adresse_clientLabel.TabIndex = 5
        Adresse_clientLabel.Text = "adresse client:"
        '
        'Sexe_clientLabel
        '
        Sexe_clientLabel.AutoSize = True
        Sexe_clientLabel.Location = New System.Drawing.Point(40, 73)
        Sexe_clientLabel.Name = "Sexe_clientLabel"
        Sexe_clientLabel.Size = New System.Drawing.Size(60, 13)
        Sexe_clientLabel.TabIndex = 7
        Sexe_clientLabel.Text = "sexe client:"
        '
        'Telephone_clientLabel
        '
        Telephone_clientLabel.AutoSize = True
        Telephone_clientLabel.Location = New System.Drawing.Point(15, 100)
        Telephone_clientLabel.Name = "Telephone_clientLabel"
        Telephone_clientLabel.Size = New System.Drawing.Size(85, 13)
        Telephone_clientLabel.TabIndex = 9
        Telephone_clientLabel.Text = "telephone client:"
        '
        'Type_clientLabel
        '
        Type_clientLabel.AutoSize = True
        Type_clientLabel.Location = New System.Drawing.Point(42, 123)
        Type_clientLabel.Name = "Type_clientLabel"
        Type_clientLabel.Size = New System.Drawing.Size(58, 13)
        Type_clientLabel.TabIndex = 11
        Type_clientLabel.Text = "type client:"
        '
        'Type_carteLabel
        '
        Type_carteLabel.AutoSize = True
        Type_carteLabel.Location = New System.Drawing.Point(519, 69)
        Type_carteLabel.Name = "Type_carteLabel"
        Type_carteLabel.Size = New System.Drawing.Size(57, 13)
        Type_carteLabel.TabIndex = 13
        Type_carteLabel.Text = "type carte:"
        '
        'Date_fin_validiteLabel
        '
        Date_fin_validiteLabel.AutoSize = True
        Date_fin_validiteLabel.Location = New System.Drawing.Point(495, 97)
        Date_fin_validiteLabel.Name = "Date_fin_validiteLabel"
        Date_fin_validiteLabel.Size = New System.Drawing.Size(81, 13)
        Date_fin_validiteLabel.TabIndex = 15
        Date_fin_validiteLabel.Text = "date fin validite:"
        '
        'Sncc_vente_billets_dbDataSet
        '
        Me.Sncc_vente_billets_dbDataSet.DataSetName = "sncc_vente_billets_dbDataSet"
        Me.Sncc_vente_billets_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tb_clientsBindingSource
        '
        Me.Tb_clientsBindingSource.DataMember = "tb_clients"
        Me.Tb_clientsBindingSource.DataSource = Me.Sncc_vente_billets_dbDataSet
        '
        'Tb_clientsTableAdapter
        '
        Me.Tb_clientsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tb_billetsTableAdapter = Nothing
        Me.TableAdapterManager.tb_clientsTableAdapter = Me.Tb_clientsTableAdapter
        Me.TableAdapterManager.tb_reservationsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Tb_clientsBindingNavigator
        '
        Me.Tb_clientsBindingNavigator.AddNewItem = Nothing
        Me.Tb_clientsBindingNavigator.BindingSource = Me.Tb_clientsBindingSource
        Me.Tb_clientsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Tb_clientsBindingNavigator.DeleteItem = Nothing
        Me.Tb_clientsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.Tb_clientsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Tb_clientsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Tb_clientsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Tb_clientsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Tb_clientsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Tb_clientsBindingNavigator.Name = "Tb_clientsBindingNavigator"
        Me.Tb_clientsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Tb_clientsBindingNavigator.Size = New System.Drawing.Size(968, 25)
        Me.Tb_clientsBindingNavigator.TabIndex = 0
        Me.Tb_clientsBindingNavigator.Text = "BindingNavigator1"
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
        'Numero_carteTextBox
        '
        Me.Numero_carteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_clientsBindingSource, "numero_carte", True))
        Me.Numero_carteTextBox.Location = New System.Drawing.Point(586, 36)
        Me.Numero_carteTextBox.Name = "Numero_carteTextBox"
        Me.Numero_carteTextBox.Size = New System.Drawing.Size(375, 20)
        Me.Numero_carteTextBox.TabIndex = 2
        '
        'Nom_clientTextBox
        '
        Me.Nom_clientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_clientsBindingSource, "nom_client", True))
        Me.Nom_clientTextBox.Location = New System.Drawing.Point(106, 40)
        Me.Nom_clientTextBox.Name = "Nom_clientTextBox"
        Me.Nom_clientTextBox.Size = New System.Drawing.Size(375, 20)
        Me.Nom_clientTextBox.TabIndex = 4
        '
        'Adresse_clientRichTextBox
        '
        Me.Adresse_clientRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_clientsBindingSource, "adresse_client", True))
        Me.Adresse_clientRichTextBox.Location = New System.Drawing.Point(106, 150)
        Me.Adresse_clientRichTextBox.Name = "Adresse_clientRichTextBox"
        Me.Adresse_clientRichTextBox.Size = New System.Drawing.Size(855, 62)
        Me.Adresse_clientRichTextBox.TabIndex = 6
        Me.Adresse_clientRichTextBox.Text = ""
        '
        'Sexe_clientComboBox
        '
        Me.Sexe_clientComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_clientsBindingSource, "sexe_client", True))
        Me.Sexe_clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Sexe_clientComboBox.FormattingEnabled = True
        Me.Sexe_clientComboBox.Items.AddRange(New Object() {"Homme", "Femme"})
        Me.Sexe_clientComboBox.Location = New System.Drawing.Point(106, 70)
        Me.Sexe_clientComboBox.Name = "Sexe_clientComboBox"
        Me.Sexe_clientComboBox.Size = New System.Drawing.Size(375, 21)
        Me.Sexe_clientComboBox.TabIndex = 8
        '
        'Telephone_clientTextBox
        '
        Me.Telephone_clientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_clientsBindingSource, "telephone_client", True))
        Me.Telephone_clientTextBox.Location = New System.Drawing.Point(106, 97)
        Me.Telephone_clientTextBox.Name = "Telephone_clientTextBox"
        Me.Telephone_clientTextBox.Size = New System.Drawing.Size(375, 20)
        Me.Telephone_clientTextBox.TabIndex = 10
        '
        'Type_clientComboBox
        '
        Me.Type_clientComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_clientsBindingSource, "type_client", True))
        Me.Type_clientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Type_clientComboBox.FormattingEnabled = True
        Me.Type_clientComboBox.Items.AddRange(New Object() {"Normal", "Infirme"})
        Me.Type_clientComboBox.Location = New System.Drawing.Point(106, 123)
        Me.Type_clientComboBox.Name = "Type_clientComboBox"
        Me.Type_clientComboBox.Size = New System.Drawing.Size(375, 21)
        Me.Type_clientComboBox.TabIndex = 12
        '
        'Type_carteComboBox
        '
        Me.Type_carteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Tb_clientsBindingSource, "type_carte", True))
        Me.Type_carteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Type_carteComboBox.FormattingEnabled = True
        Me.Type_carteComboBox.Items.AddRange(New Object() {"Passeport", "Carte d'electeur", "Carte Identity"})
        Me.Type_carteComboBox.Location = New System.Drawing.Point(586, 66)
        Me.Type_carteComboBox.Name = "Type_carteComboBox"
        Me.Type_carteComboBox.Size = New System.Drawing.Size(375, 21)
        Me.Type_carteComboBox.TabIndex = 14
        '
        'Date_fin_validiteDateTimePicker
        '
        Me.Date_fin_validiteDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Tb_clientsBindingSource, "date_fin_validite", True))
        Me.Date_fin_validiteDateTimePicker.Location = New System.Drawing.Point(586, 93)
        Me.Date_fin_validiteDateTimePicker.MinDate = New Date(2020, 11, 5, 0, 0, 0, 0)
        Me.Date_fin_validiteDateTimePicker.Name = "Date_fin_validiteDateTimePicker"
        Me.Date_fin_validiteDateTimePicker.Size = New System.Drawing.Size(375, 20)
        Me.Date_fin_validiteDateTimePicker.TabIndex = 16
        '
        'Tb_clientsDataGridView
        '
        Me.Tb_clientsDataGridView.AllowUserToOrderColumns = True
        Me.Tb_clientsDataGridView.AutoGenerateColumns = False
        Me.Tb_clientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Tb_clientsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tb_clientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tb_clientsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.Tb_clientsDataGridView.DataSource = Me.Tb_clientsBindingSource
        Me.Tb_clientsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Tb_clientsDataGridView.Location = New System.Drawing.Point(0, 276)
        Me.Tb_clientsDataGridView.Name = "Tb_clientsDataGridView"
        Me.Tb_clientsDataGridView.Size = New System.Drawing.Size(968, 217)
        Me.Tb_clientsDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "numero_carte"
        Me.DataGridViewTextBoxColumn1.HeaderText = "numero_carte"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nom_client"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nom_client"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "adresse_client"
        Me.DataGridViewTextBoxColumn3.HeaderText = "adresse_client"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "sexe_client"
        Me.DataGridViewTextBoxColumn4.HeaderText = "sexe_client"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "telephone_client"
        Me.DataGridViewTextBoxColumn5.HeaderText = "telephone_client"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "type_client"
        Me.DataGridViewTextBoxColumn6.HeaderText = "type_client"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "type_carte"
        Me.DataGridViewTextBoxColumn7.HeaderText = "type_carte"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "date_fin_validite"
        Me.DataGridViewTextBoxColumn8.HeaderText = "date_fin_validite"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(498, 225)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(225, 43)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Enregistrer client"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(736, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(225, 32)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Ajouter nouveau client"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(736, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(225, 43)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Modifier client"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FormNewClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 493)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Tb_clientsDataGridView)
        Me.Controls.Add(Numero_carteLabel)
        Me.Controls.Add(Me.Numero_carteTextBox)
        Me.Controls.Add(Nom_clientLabel)
        Me.Controls.Add(Me.Nom_clientTextBox)
        Me.Controls.Add(Adresse_clientLabel)
        Me.Controls.Add(Me.Adresse_clientRichTextBox)
        Me.Controls.Add(Sexe_clientLabel)
        Me.Controls.Add(Me.Sexe_clientComboBox)
        Me.Controls.Add(Telephone_clientLabel)
        Me.Controls.Add(Me.Telephone_clientTextBox)
        Me.Controls.Add(Type_clientLabel)
        Me.Controls.Add(Me.Type_clientComboBox)
        Me.Controls.Add(Type_carteLabel)
        Me.Controls.Add(Me.Type_carteComboBox)
        Me.Controls.Add(Date_fin_validiteLabel)
        Me.Controls.Add(Me.Date_fin_validiteDateTimePicker)
        Me.Controls.Add(Me.Tb_clientsBindingNavigator)
        Me.Name = "FormNewClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulaire de gestion des clients"
        CType(Me.Sncc_vente_billets_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_clientsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_clientsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tb_clientsBindingNavigator.ResumeLayout(False)
        Me.Tb_clientsBindingNavigator.PerformLayout()
        CType(Me.Tb_clientsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Sncc_vente_billets_dbDataSet As venteBilletApp.sncc_vente_billets_dbDataSet
    Friend WithEvents Tb_clientsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_clientsTableAdapter As venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.tb_clientsTableAdapter
    Friend WithEvents TableAdapterManager As venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Tb_clientsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Numero_carteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nom_clientTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Adresse_clientRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Sexe_clientComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Telephone_clientTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Type_clientComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Type_carteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Date_fin_validiteDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tb_clientsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
