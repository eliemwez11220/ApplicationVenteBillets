Public Class FormNewClient

    Private Sub Tb_clientsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tb_clientsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Sncc_vente_billets_dbDataSet)

    End Sub

    Private Sub FormNewClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'Sncc_vente_billets_dbDataSet.tb_clients'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
        Me.Tb_clientsTableAdapter.Fill(Me.Sncc_vente_billets_dbDataSet.tb_clients)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Numero_carteTextBox.Text <> "" And Nom_clientTextBox.Text <> "") Then
            If (MessageBox.Show("Voulez-vous vraiment enregistrer ce client ?", "Enregistrement nouveau client",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                Tb_clientsTableAdapter.Insert(Numero_carteTextBox.Text, Nom_clientTextBox.Text, Adresse_clientRichTextBox.Text, Sexe_clientComboBox.Text, Telephone_clientTextBox.Text, Type_clientComboBox.Text, Type_carteComboBox.Text, Date_fin_validiteDateTimePicker.Text)
                Tb_clientsTableAdapter.Fill(Me.Sncc_vente_billets_dbDataSet.tb_clients)
                MessageBox.Show("Client enregistre avec success", "Enregistrement nouveau client",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
                Numero_carteTextBox.Clear()
                Nom_clientTextBox.Clear()
                Adresse_clientRichTextBox.Clear()
                Telephone_clientTextBox.Clear()
                Nom_clientTextBox.Focus()
            End If
        Else
            MessageBox.Show("Veuillez saisir le numero client et le nom du client", "Enregistrement nouveau client",
                           MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Numero_carteTextBox.Clear()
        Nom_clientTextBox.Clear()
        Adresse_clientRichTextBox.Clear()
        Telephone_clientTextBox.Clear()
        Nom_clientTextBox.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (Numero_carteTextBox.Text <> "" And Nom_clientTextBox.Text <> "") Then
            If (MessageBox.Show("Voulez-vous vraiment modifier ce client ?", "Modification client",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

                Me.Validate()
                Me.Tb_clientsBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.Sncc_vente_billets_dbDataSet)

                Tb_clientsTableAdapter.Fill(Me.Sncc_vente_billets_dbDataSet.tb_clients)
                MessageBox.Show("Client enregistre avec success", "Modification client",
                           MessageBoxButtons.OK, MessageBoxIcon.Information)
                Numero_carteTextBox.Clear()
                Nom_clientTextBox.Clear()
                Adresse_clientRichTextBox.Clear()
                Telephone_clientTextBox.Clear()
                Nom_clientTextBox.Focus()
            End If
        Else
            MessageBox.Show("Veuillez saisir le numero client et le nom du client", "Modification client",
                           MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
    End Sub
End Class
