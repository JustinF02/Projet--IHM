Public Class frmAjout
    Private Sub cmdAnnuler_Click(sender As Object, e As EventArgs) Handles cmdAnnuler.Click
        frmAccueil.Show()
        Me.Close()
    End Sub

    Private Sub cmdAjouter_Click(sender As Object, e As EventArgs) Handles cmdAjouter.Click
        frmAccueil.Show()
        Me.Close()

    End Sub
    Private Sub Ajout_activ(sender As Object, e As EventArgs) Handles txtNom.TextChanged, txtPrenom.TextChanged
        If ((txtNom.Text <> txtNom.Tag) And (txtNom.Text <> "")) And ((txtPrenom.Text <> txtPrenom.Tag) And (txtPrenom.Text <> "")) Then
            cmdAjouter.Enabled = True
        Else
            cmdAjouter.Enabled = False
        End If
    End Sub
    Private Sub txtInfosContact_Enter(sender As Object, e As EventArgs) Handles txtNom.Enter, txtPrenom.Enter
        If sender.Text = sender.tag Then
            sender.clear()
            sender.Font = New Font(CType(sender.Font, Font), FontStyle.Regular)
            sender.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtInfosContact_Leave(sender As Object, e As EventArgs) Handles txtNom.Leave, txtPrenom.Leave
        If sender.Text = Nothing Then
            sender.Text = sender.tag
            sender.Font = New Font(CType(sender.Font, Font), FontStyle.Italic)
            sender.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub nudNbEnfants_ValueChanged(sender As Object, e As EventArgs) Handles nudNbEnfants.ValueChanged
        Dim nomTxtBox As String
        Dim nbEnfant As Byte = nudNbEnfants.Value

        Dim newTxtBox As TextBox
        Dim nbBox As Byte = pnlEnfants.Controls.Count
        newTxtBox = New TextBox

        newTxtBox.Name = "txtEnfant" + Convert.ToString(nbBox + 1)
        newTxtBox.Text = "Saisie" & nbBox + 1
        newTxtBox.Size = New Size(140, 19)

        'Activation et désactivation box
        If (nbEnfant < 3 And nbEnfant >= 0) Then
            If (nudNbEnfants.Value > nudNbEnfants.Tag) Then
                nomTxtBox = "txtEnfant" & nbEnfant.ToString
                pnlEnfants.Controls(nomTxtBox).Enabled = True
            End If
            If (nudNbEnfants.Value < nudNbEnfants.Tag) Then
                nomTxtBox = "txtEnfant" & (nbEnfant + 1).ToString
                pnlEnfants.Controls(nomTxtBox).Enabled = False
            End If
        ElseIf (nbEnfant = 3) Then

            If (nudNbEnfants.Value > nudNbEnfants.Tag) Then
                nomTxtBox = "txtEnfant" & nbEnfant.ToString
                pnlEnfants.Controls(nomTxtBox).Enabled = True
            End If
            If (nudNbEnfants.Value < nudNbEnfants.Tag) Then
                pnlEnfants.Controls.RemoveByKey("txtEnfant" & nbBox)
            End If

            'Ajout et suppression de box à partir de nbBox > 3
        Else
            If (nudNbEnfants.Value > nudNbEnfants.Tag) Then
                newTxtBox.Location = New Point(15, pnlEnfants.Controls("txtEnfant" & nbBox).Location.Y + 30) 'location de maxbox + 30 en y
                pnlEnfants.Controls.Add(newTxtBox)
            End If
            If (nudNbEnfants.Value < nudNbEnfants.Tag) Then

                pnlEnfants.Controls.RemoveByKey("txtEnfant" & nbBox)
            End If
        End If
        nudNbEnfants.Tag = nbEnfant
    End Sub
End Class