Public Class frmSupp
    Private Sub cmdSuppr_Click(sender As Object, e As EventArgs) Handles cmdSuppr.Click
        Dim RetourMsgBox As DialogResult
        RetourMsgBox = MessageBox.Show("Souhaitez vous supprimer le contact ?", "Supprimer", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If (RetourMsgBox.OK) Then
            lstContacts.Items.RemoveAt(lstContacts.SelectedIndex)
            frmAccueil.lblFeedback.Text = "Contact supprimé"
        End If
    End Sub

    Private Sub cmdAnnuler_Click(sender As Object, e As EventArgs) Handles cmdAnnuler.Click
        frmAccueil.Show()
        Me.Close()
    End Sub

    Private Sub lstContacts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstContacts.SelectedIndexChanged
        lblNom.Font = New Font(lblNom.Font, FontStyle.Italic)
        lblPrenom.Font = New Font(lblPrenom.Font, FontStyle.Italic)
        Dim gray As Color = Color.Gray
        lblNom.ForeColor = gray
        lblPrenom.ForeColor = gray
        cmdVoir.Enabled = True
        cmdSuppr.Enabled = True
        lblNom.Text = lblNom.Tag
        lblPrenom.Text = lblPrenom.Tag
    End Sub

    Private Sub cmdVoir_Click(sender As Object, e As EventArgs) Handles cmdVoir.Click
        lblNom.Font = New Font(lblNom.Font, FontStyle.Regular)
        lblPrenom.Font = New Font(lblPrenom.Font, FontStyle.Regular)
        Dim black As Color = Color.Black
        lblNom.ForeColor = black
        lblPrenom.ForeColor = black
        Dim Machaine As String = lstContacts.SelectedItem
        Dim MachaineDecoupee As String()
        Dim Nom As String, Prenom As String
        MachaineDecoupee = Machaine.Split
        Nom = MachaineDecoupee(0)
        Prenom = MachaineDecoupee(1)
        lblNom.Text = Nom
        lblPrenom.Text = Prenom
    End Sub
End Class