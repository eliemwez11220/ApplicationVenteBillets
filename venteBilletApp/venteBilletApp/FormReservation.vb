Public Class FormReservation

    Private Sub Tb_reservationsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tb_reservationsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sncc_vente_billets_dbDataSet)

    End Sub

    Private Sub FormReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Sncc_vente_billets_dbDataSet.tb_clients'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Tb_clientsTableAdapter.Fill(Me.Sncc_vente_billets_dbDataSet.tb_clients)
        'TODO: cette ligne de code charge les données dans la table 'Sncc_vente_billets_dbDataSet.tb_reservations'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Tb_reservationsTableAdapter.Fill(Me.Sncc_vente_billets_dbDataSet.tb_reservations)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If (NumeroPlaceTextBox.Text <> "" And ClientIDComboBox.Text <> "") Then
                If (MessageBox.Show("Voulez-vous vraiment enregistrer cette reservation ?", "Nouvelle Reservation",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                    Tb_reservationsTableAdapter.Insert(DateReservationDateTimePicker.Text, NumeroPlaceTextBox.Text, DateVoyageDateTimePicker.Text, CodeClasseComboBox.Text, CompartimentComboBox.Text, ProvenanceTextBox.Text, DestinationComboBox.Text, ClientIDComboBox.Text, VoitureIDTextBox.Text, TrainIDComboBox.Text, NomAgentTextBox.Text, FonctionAgentComboBox.Text, HeureVoyageMaskedTextBox.Text)
                    Tb_reservationsTableAdapter.Fill(Me.Sncc_vente_billets_dbDataSet.tb_reservations)
                    MessageBox.Show("Reservation enregistree avec success", "Enregistrement nouvelle reservation",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NumeroPlaceTextBox.Clear()
                    ProvenanceTextBox.Clear()
                    NomAgentTextBox.Clear()

                    VoitureIDTextBox.Clear()

                    NumeroPlaceTextBox.Focus()
                End If
            Else
                MessageBox.Show("Veuillez saisir le numero client et le nom du client", "Enregistrement nouveau client",
                               MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Veuillez saisir le numero client et le nom du client", "Enregistrement nouveau client",
                               MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        NumeroPlaceTextBox.Clear()
        ProvenanceTextBox.Clear()

        NomAgentTextBox.Clear()

        VoitureIDTextBox.Clear()

        NumeroPlaceTextBox.Focus()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            If (NumeroPlaceTextBox.Text <> "" And ClientIDComboBox.Text <> "") Then
                If (MessageBox.Show("Voulez-vous vraiment modifier cette reservation ?", "Modification Reservation",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

                    Me.Validate()
                    Me.Tb_reservationsBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.Sncc_vente_billets_dbDataSet)

                    Tb_reservationsTableAdapter.Fill(Me.Sncc_vente_billets_dbDataSet.tb_reservations)
                    MessageBox.Show("Reservation modifiee avec success", "Modification reservation",
                               MessageBoxButtons.OK, MessageBoxIcon.Information)
                    NumeroPlaceTextBox.Clear()
                    ProvenanceTextBox.Clear()
                    NomAgentTextBox.Clear()

                    VoitureIDTextBox.Clear()

                    NumeroPlaceTextBox.Focus()
                End If
            Else
                MessageBox.Show("Veuillez saisir les informations sur la reservation", "Modification Reservation",
                               MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Veuillez saisir les informations sur la reservation", "Modification Reservation",
                                MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class