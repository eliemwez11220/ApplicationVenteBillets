Public Class VisualisationImpressionvb

    Private Sub VisualisationImpressionvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'sncc_vente_billets_dbDataSet.tb_billets'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Tb_billetsTableAdapter.Fill(Me.sncc_vente_billets_dbDataSet.tb_billets)
        'TODO: cette ligne de code charge les données dans la table 'sncc_vente_billets_dbDataSet.billetImpression'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.billetImpressionTableAdapter.Fill(Me.sncc_vente_billets_dbDataSet.billetImpression)

        Me.ReportViewer1.RefreshReport()

        ' Me.ToolStripComboBox1.Text = billetImpressionBindingSource.DataSource.ToString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.billetImpressionTableAdapter.BilletFillBy(sncc_vente_billets_dbDataSet.billetImpression, ComboBox1.Text)
        ReportViewer1.RefreshReport()
    End Sub
End Class