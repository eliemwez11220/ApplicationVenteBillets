Public Class FormBillets

    Private Sub Tb_billetsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tb_billetsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sncc_vente_billets_dbDataSet)

    End Sub

    Private Sub FormBillets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Sncc_vente_billets_dbDataSet.tb_reservations'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Tb_reservationsTableAdapter.Fill(Me.Sncc_vente_billets_dbDataSet.tb_reservations)
        'TODO: cette ligne de code charge les données dans la table 'Sncc_vente_billets_dbDataSet.tb_clients'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Tb_clientsTableAdapter.Fill(Me.Sncc_vente_billets_dbDataSet.tb_clients)
        'TODO: cette ligne de code charge les données dans la table 'Sncc_vente_billets_dbDataSet.tb_billets'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Tb_billetsTableAdapter.Fill(Me.Sncc_vente_billets_dbDataSet.tb_billets)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim tva, montantReduit, netApayer As Decimal
            tva = PrixBilletTextBox.Text * TVATextBox.Text / 100

            netApayer = tva + PrixBilletTextBox.Text
            If Type_clientTextBox.Text = "infirme" Or Type_clientTextBox.Text = "Infirme" Then
                montantReduit = netApayer * PourcReductionTextBox.Text / 100
                MontantTotalTextBox.Text = netApayer - montantReduit
            Else
                MessageBox.Show("La reduction n'est accordee qu'aux personnes infirmes", "Poucentage reduction",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)
                MontantTotalTextBox.Text = netApayer + "CDF"
            End If

        Catch ex As Exception
            MessageBox.Show("Erreur de calcul. Valeur non numerique detectee")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If (MontantTotalTextBox.Text <> "" And NumeroBilletTextBox.Text <> "") Then
                If (MessageBox.Show("Voulez-vous vraiment creer ce billet ?", "Nouveau billet voyage",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    Tb_billetsTableAdapter.Insert(NumeroBilletTextBox.Text, DateBilletDateTimePicker.Text, NomAgentTextBox.Text, FonctionAgentComboBox.Text, PrixBilletTextBox.Text, PourcReductionTextBox.Text, MotifReductionTextBox.Text, MontantTotalTextBox.Text, TVATextBox.Text, ClientIDComboBox.Text, PlaceReserveeIDComboBox.Text)
                    Tb_billetsTableAdapter.Fill(Me.Sncc_vente_billets_dbDataSet.tb_billets)
                    MessageBox.Show("Billet de voyage etabli avec success", "Creation billet voyage",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NumeroBilletTextBox.Clear()
                    PrixBilletTextBox.Clear()

                    NomAgentTextBox.Clear()
                    PourcReductionTextBox.Clear()
                    MotifReductionTextBox.Clear()
                    MontantTotalTextBox.Clear()
                    TVATextBox.Clear()

                    NumeroBilletTextBox.Focus()
                End If
            Else
                MessageBox.Show("Le numero billet et le montant sont obligatoire", "Enregistrement billet voyage",
                               MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Le numero billet et le montant sont obligatoire", "Enregistrement billet voyage",
                               MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NumeroBilletTextBox.Clear()
        PrixBilletTextBox.Clear()

        NomAgentTextBox.Clear()
        PourcReductionTextBox.Clear()
        MotifReductionTextBox.Clear()
        MontantTotalTextBox.Clear()
        TVATextBox.Clear()

        NumeroBilletTextBox.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If (MontantTotalTextBox.Text <> "" And NumeroBilletTextBox.Text <> "") Then
                If (MessageBox.Show("Voulez-vous vraiment modifier ce billet ?", "Modification billet voyage",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

                    Me.Validate()
                    Me.Tb_billetsBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.Sncc_vente_billets_dbDataSet)
                    Tb_billetsTableAdapter.Fill(Me.Sncc_vente_billets_dbDataSet.tb_billets)
                    MessageBox.Show("Billet de voyage modifie avec success", "Modification billet voyage",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Le numero billet et le montant sont obligatoire", "Modification billet voyage",
                               MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Le numero billet et le montant sont obligatoire", "Modification billet voyage",
                               MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class