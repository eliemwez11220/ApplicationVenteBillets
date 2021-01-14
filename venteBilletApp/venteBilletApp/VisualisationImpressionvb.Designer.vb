<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualisationImpressionvb
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.billetImpressionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.sncc_vente_billets_dbDataSet = New venteBilletApp.sncc_vente_billets_dbDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.billetImpressionTableAdapter = New venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.billetImpressionTableAdapter()
        Me.TableAdapterManager = New venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbbilletsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_billetsTableAdapter = New venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.tb_billetsTableAdapter()
        CType(Me.billetImpressionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sncc_vente_billets_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TbbilletsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'billetImpressionBindingSource
        '
        Me.billetImpressionBindingSource.DataMember = "billetImpression"
        Me.billetImpressionBindingSource.DataSource = Me.sncc_vente_billets_dbDataSet
        '
        'sncc_vente_billets_dbDataSet
        '
        Me.sncc_vente_billets_dbDataSet.DataSetName = "sncc_vente_billets_dbDataSet"
        Me.sncc_vente_billets_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Top
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.billetImpressionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "venteBilletApp.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1154, 510)
        Me.ReportViewer1.TabIndex = 0
        '
        'billetImpressionTableAdapter
        '
        Me.billetImpressionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.tb_billetsTableAdapter = Nothing
        Me.TableAdapterManager.tb_clientsTableAdapter = Nothing
        Me.TableAdapterManager.tb_reservationsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 511)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1154, 38)
        Me.Panel1.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TbbilletsBindingSource
        Me.ComboBox1.DisplayMember = "numeroBillet"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(185, 3)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(208, 28)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "numeroBillet"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(399, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 33)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Afficher Billet"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Selectionnez un billet"
        '
        'TbbilletsBindingSource
        '
        Me.TbbilletsBindingSource.DataMember = "tb_billets"
        Me.TbbilletsBindingSource.DataSource = Me.sncc_vente_billets_dbDataSet
        '
        'Tb_billetsTableAdapter
        '
        Me.Tb_billetsTableAdapter.ClearBeforeFill = True
        '
        'VisualisationImpressionvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1154, 549)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "VisualisationImpressionvb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VisualisationImpressionvb"
        CType(Me.billetImpressionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sncc_vente_billets_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TbbilletsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents billetImpressionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents sncc_vente_billets_dbDataSet As venteBilletApp.sncc_vente_billets_dbDataSet
    Friend WithEvents billetImpressionTableAdapter As venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.billetImpressionTableAdapter
    Friend WithEvents TableAdapterManager As venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TbbilletsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Tb_billetsTableAdapter As venteBilletApp.sncc_vente_billets_dbDataSetTableAdapters.tb_billetsTableAdapter
End Class
