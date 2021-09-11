Public Class frmAccueil
    Private Sub cmdAjout_Click(sender As Object, e As EventArgs) Handles cmdAjout.Click
        frmAjout.Show()
        Me.Close()
    End Sub

    Private Sub cmdModif_Click(sender As Object, e As EventArgs) Handles cmdModif.Click
        frmModif.Show()
        Me.Close()
    End Sub

    Private Sub cmdSuppr_Click(sender As Object, e As EventArgs) Handles cmdSuppr.Click
        frmSupp.Show()
        Me.Close()
    End Sub
End Class
