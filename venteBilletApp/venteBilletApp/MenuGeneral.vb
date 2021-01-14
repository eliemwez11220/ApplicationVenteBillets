Imports System.Windows.Forms

Public Class MenuGeneral

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click
        ' Créez une nouvelle instance du formulaire enfant.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Configurez-la en tant qu'enfant de ce formulaire MDI avant de l'afficher.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Fenêtre " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: ajoutez le code ici pour ouvrir le fichier.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Fichiers texte (*.txt)|*.txt|Tous les fichiers (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: ajoutez le code ici pour enregistrer le contenu actuel du formulaire dans un fichier.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        If (MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Quitter Application",
                           MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilisez My.Computer.Clipboard pour insérer les images ou le texte sélectionné dans le Presse-papiers
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilisez My.Computer.Clipboard pour insérer les images ou le texte sélectionné dans le Presse-papiers
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilisez My.Computer.Clipboard.GetText() ou My.Computer.Clipboard.GetData pour extraire les informations du Presse-papiers.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Fermez tous les formulaires enfants du parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub MenuGeneral_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DeconnexionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeconnexionToolStripMenuItem.Click
        If (MessageBox.Show("Voulez-vous vraiment vous deconnecter du systeme ?", "Deconnexion",
                          MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes) Then
            Me.Hide()
            LoginForm1.Show()
        End If
    End Sub

    Private Sub NouveauClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouveauClientToolStripMenuItem.Click
        FormNewClient.MdiParent = Me
        FormNewClient.Show()

    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        FormImpressionBillet.MdiParent = Me
        FormImpressionBillet.Show()
    End Sub

    Private Sub CreerNouvelleReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreerNouvelleReservationToolStripMenuItem.Click
        FormReservation.MdiParent = Me
        FormReservation.Show()
    End Sub

    Private Sub ListeReservationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeReservationsToolStripMenuItem.Click
        FormReservation.MdiParent = Me
        FormReservation.Show()
    End Sub

    Private Sub ListeClientsExistantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeClientsExistantsToolStripMenuItem.Click
        FormNewClient.MdiParent = Me
        FormNewClient.Show()
    End Sub

    Private Sub NouveauBilletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouveauBilletToolStripMenuItem.Click
        FormBillets.MdiParent = Me
        FormBillets.Show()
    End Sub

    Private Sub ListeBilletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeBilletToolStripMenuItem.Click
        FormBillets.MdiParent = Me
        FormBillets.Show()
    End Sub

    Private Sub ClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientToolStripMenuItem.Click
        FormNewClient.MdiParent = Me
        FormNewClient.Show()
    End Sub

    Private Sub BilletToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BilletToolStripMenuItem.Click
        FormBillets.MdiParent = Me
        FormBillets.Show()
    End Sub

    Private Sub ReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationToolStripMenuItem.Click
        FormReservation.MdiParent = Me
        FormReservation.Show()
    End Sub

    Private Sub ImpressionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImpressionToolStripMenuItem.Click
        VisualisationImpressionvb.MdiParent = Me
        VisualisationImpressionvb.Show()
    End Sub
End Class
