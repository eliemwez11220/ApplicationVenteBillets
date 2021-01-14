<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuGeneral))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BilletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeconnexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeClientsExistantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreerNouvelleReservationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeReservationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BilletsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouveauBilletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeBilletToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImpressionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.DodgerBlue
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ToolsMenu, Me.ReservationsToolStripMenuItem, Me.BilletsToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1148, 33)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripSeparator3, Me.PrintToolStripMenuItem, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem, Me.DeconnexionToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(81, 29)
        Me.FileMenu.Text = "&Fichier"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientToolStripMenuItem, Me.BilletToolStripMenuItem, Me.ReservationToolStripMenuItem})
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(233, 30)
        Me.NewToolStripMenuItem.Text = "&Nouveau"
        '
        'ClientToolStripMenuItem
        '
        Me.ClientToolStripMenuItem.Name = "ClientToolStripMenuItem"
        Me.ClientToolStripMenuItem.Size = New System.Drawing.Size(185, 30)
        Me.ClientToolStripMenuItem.Text = "Client"
        '
        'BilletToolStripMenuItem
        '
        Me.BilletToolStripMenuItem.Name = "BilletToolStripMenuItem"
        Me.BilletToolStripMenuItem.Size = New System.Drawing.Size(185, 30)
        Me.BilletToolStripMenuItem.Text = "Billet"
        '
        'ReservationToolStripMenuItem
        '
        Me.ReservationToolStripMenuItem.Name = "ReservationToolStripMenuItem"
        Me.ReservationToolStripMenuItem.Size = New System.Drawing.Size(185, 30)
        Me.ReservationToolStripMenuItem.Text = "Reservation"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(230, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(233, 30)
        Me.PrintToolStripMenuItem.Text = "&Imprimer"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(230, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(233, 30)
        Me.ExitToolStripMenuItem.Text = "&Quitter"
        '
        'DeconnexionToolStripMenuItem
        '
        Me.DeconnexionToolStripMenuItem.Name = "DeconnexionToolStripMenuItem"
        Me.DeconnexionToolStripMenuItem.Size = New System.Drawing.Size(233, 30)
        Me.DeconnexionToolStripMenuItem.Text = "Deconnexion"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauClientToolStripMenuItem, Me.ListeClientsExistantsToolStripMenuItem})
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(82, 29)
        Me.ToolsMenu.Text = "&Clients"
        '
        'NouveauClientToolStripMenuItem
        '
        Me.NouveauClientToolStripMenuItem.Name = "NouveauClientToolStripMenuItem"
        Me.NouveauClientToolStripMenuItem.Size = New System.Drawing.Size(264, 30)
        Me.NouveauClientToolStripMenuItem.Text = "Nouveau client"
        '
        'ListeClientsExistantsToolStripMenuItem
        '
        Me.ListeClientsExistantsToolStripMenuItem.Name = "ListeClientsExistantsToolStripMenuItem"
        Me.ListeClientsExistantsToolStripMenuItem.Size = New System.Drawing.Size(264, 30)
        Me.ListeClientsExistantsToolStripMenuItem.Text = "Liste clients existants"
        '
        'ReservationsToolStripMenuItem
        '
        Me.ReservationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreerNouvelleReservationToolStripMenuItem, Me.ListeReservationsToolStripMenuItem})
        Me.ReservationsToolStripMenuItem.Name = "ReservationsToolStripMenuItem"
        Me.ReservationsToolStripMenuItem.Size = New System.Drawing.Size(133, 29)
        Me.ReservationsToolStripMenuItem.Text = "Reservations"
        '
        'CreerNouvelleReservationToolStripMenuItem
        '
        Me.CreerNouvelleReservationToolStripMenuItem.Name = "CreerNouvelleReservationToolStripMenuItem"
        Me.CreerNouvelleReservationToolStripMenuItem.Size = New System.Drawing.Size(310, 30)
        Me.CreerNouvelleReservationToolStripMenuItem.Text = "Creer nouvelle reservation"
        '
        'ListeReservationsToolStripMenuItem
        '
        Me.ListeReservationsToolStripMenuItem.Name = "ListeReservationsToolStripMenuItem"
        Me.ListeReservationsToolStripMenuItem.Size = New System.Drawing.Size(310, 30)
        Me.ListeReservationsToolStripMenuItem.Text = "Liste reservations"
        '
        'BilletsToolStripMenuItem
        '
        Me.BilletsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauBilletToolStripMenuItem, Me.ListeBilletToolStripMenuItem, Me.ToolStripSeparator1, Me.ImpressionToolStripMenuItem})
        Me.BilletsToolStripMenuItem.Name = "BilletsToolStripMenuItem"
        Me.BilletsToolStripMenuItem.Size = New System.Drawing.Size(75, 29)
        Me.BilletsToolStripMenuItem.Text = "Billets"
        '
        'NouveauBilletToolStripMenuItem
        '
        Me.NouveauBilletToolStripMenuItem.Name = "NouveauBilletToolStripMenuItem"
        Me.NouveauBilletToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.NouveauBilletToolStripMenuItem.Text = "Nouveau Billet"
        '
        'ListeBilletToolStripMenuItem
        '
        Me.ListeBilletToolStripMenuItem.Name = "ListeBilletToolStripMenuItem"
        Me.ListeBilletToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.ListeBilletToolStripMenuItem.Text = "Liste Billets"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(207, 6)
        '
        'ImpressionToolStripMenuItem
        '
        Me.ImpressionToolStripMenuItem.Name = "ImpressionToolStripMenuItem"
        Me.ImpressionToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.ImpressionToolStripMenuItem.Text = "Impression"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1148, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(193, 17)
        Me.ToolStripStatusLabel1.Text = "Copyright 2020 - Trecazad Inc,"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1148, 398)
        Me.Panel1.TabIndex = 9
        '
        'MenuGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1148, 453)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MenuGeneral"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MenuGeneral"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BilletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouveauClientToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeClientsExistantsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReservationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreerNouvelleReservationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeReservationsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BilletsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouveauBilletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListeBilletToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeconnexionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImpressionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
