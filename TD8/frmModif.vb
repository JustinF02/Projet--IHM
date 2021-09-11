Public Class frmModif
    Private Sub cmdModifier_Click(sender As Object, e As EventArgs) Handles cmdModifier.Click
        frmAccueil.Show()
        Me.Close()
    End Sub

    Private Sub cmdAnnuler_Click(sender As Object, e As EventArgs) Handles cmdAnnuler.Click
        frmAccueil.Show()
        Me.Close()
    End Sub
    Private Sub txtInfosContact_Enter(sender As Object, e As EventArgs) Handles txtNom.Enter, txtPrenom.Enter
        If sender.Text = sender.tag Then
            sender.clear()
        End If
    End Sub
    Private Sub txtInfosContact_Leave(sender As Object, e As EventArgs) Handles txtNom.Leave, txtPrenom.Leave
        If sender.Text = Nothing Then
            sender.Text = sender.tag
        End If
    End Sub
End Class