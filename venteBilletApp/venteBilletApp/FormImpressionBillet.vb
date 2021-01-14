Public Class FormImpressionBillet

    Private Sub FormImpressionBillet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Sncc_vente_billets_dbDataSet.billetImpression'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.BilletImpressionTableAdapter.Fill(Me.Sncc_vente_billets_dbDataSet.billetImpression)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        VisualisationImpressionvb.MdiParent = MenuGeneral
        VisualisationImpressionvb.Show()
    End Sub
End Class