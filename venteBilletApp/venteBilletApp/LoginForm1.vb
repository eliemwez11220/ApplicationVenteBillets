﻿Public Class LoginForm1

    ' TODO: insérez le code pour effectuer une authentification personnalisée à l'aide du nom d'utilisateur et du mot de passe fournis 
    ' (Voir http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' L'objet Principal personnalisé peut ensuite être associé à l'objet Principal du thread actuel comme suit : 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' CustomPrincipal est l'implémentation IPrincipal utilisée pour effectuer l'authentification. 
    ' Par la suite, My.User retournera les informations d'identité encapsulées dans l'objet CustomPrincipal
    ' telles que le nom d'utilisateur, le nom complet, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "nsenga" Or UsernameTextBox.Text = "NSENGA" Or UsernameTextBox.Text = "Nsenga" And PasswordTextBox.Text = "2020" Then
            MenuGeneral.Show()
            Me.Hide()
        Else
            MessageBox.Show("Vous devez disposer un compte utilisateur", "Access refused", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

End Class
