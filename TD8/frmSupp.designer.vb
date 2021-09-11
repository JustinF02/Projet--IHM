<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSupp
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupp))
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lstContacts = New System.Windows.Forms.ListBox()
        Me.cmdVoir = New System.Windows.Forms.Button()
        Me.lblListe = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.lblPrenom = New System.Windows.Forms.Label()
        Me.lblNbreEnfants = New System.Windows.Forms.Label()
        Me.lblNbreValeur = New System.Windows.Forms.Label()
        Me.grpEnfants = New System.Windows.Forms.GroupBox()
        Me.lblEnfant3 = New System.Windows.Forms.Label()
        Me.lblEnfant2 = New System.Windows.Forms.Label()
        Me.lblEnfant1 = New System.Windows.Forms.Label()
        Me.cmdAnnuler = New System.Windows.Forms.Button()
        Me.cmdSuppr = New System.Windows.Forms.Button()
        Me.grpEnfants.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.Black
        Me.lblTitre.Location = New System.Drawing.Point(0, 28)
        Me.lblTitre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(598, 37)
        Me.lblTitre.TabIndex = 2
        Me.lblTitre.Text = "Suppression d'un contact"
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstContacts
        '
        Me.lstContacts.FormattingEnabled = True
        Me.lstContacts.Items.AddRange(New Object() {"GRANGER Hermione", "LONDUBAT Neville", "MALFOY Lucius", "POTTER Harry", "WEASLEY Molly"})
        Me.lstContacts.Location = New System.Drawing.Point(31, 123)
        Me.lstContacts.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstContacts.Name = "lstContacts"
        Me.lstContacts.Size = New System.Drawing.Size(146, 147)
        Me.lstContacts.TabIndex = 3
        '
        'cmdVoir
        '
        Me.cmdVoir.Enabled = False
        Me.cmdVoir.Location = New System.Drawing.Point(31, 284)
        Me.cmdVoir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdVoir.Name = "cmdVoir"
        Me.cmdVoir.Size = New System.Drawing.Size(145, 22)
        Me.cmdVoir.TabIndex = 4
        Me.cmdVoir.Text = "Visualiser"
        Me.cmdVoir.UseVisualStyleBackColor = True
        '
        'lblListe
        '
        Me.lblListe.AutoSize = True
        Me.lblListe.Location = New System.Drawing.Point(31, 106)
        Me.lblListe.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblListe.Name = "lblListe"
        Me.lblListe.Size = New System.Drawing.Size(120, 13)
        Me.lblListe.TabIndex = 5
        Me.lblListe.Text = "Sélectionner un contact"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.ForeColor = System.Drawing.Color.Gray
        Me.lblNom.Location = New System.Drawing.Point(208, 146)
        Me.lblNom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(83, 13)
        Me.lblNom.TabIndex = 6
        Me.lblNom.Tag = "Nom du contact"
        Me.lblNom.Text = "Nom du contact"
        '
        'lblPrenom
        '
        Me.lblPrenom.AutoSize = True
        Me.lblPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrenom.ForeColor = System.Drawing.Color.Gray
        Me.lblPrenom.Location = New System.Drawing.Point(208, 179)
        Me.lblPrenom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrenom.Name = "lblPrenom"
        Me.lblPrenom.Size = New System.Drawing.Size(97, 13)
        Me.lblPrenom.TabIndex = 7
        Me.lblPrenom.Tag = "Prénom du contact"
        Me.lblPrenom.Text = "Prénom du contact"
        '
        'lblNbreEnfants
        '
        Me.lblNbreEnfants.AutoSize = True
        Me.lblNbreEnfants.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbreEnfants.ForeColor = System.Drawing.Color.Gray
        Me.lblNbreEnfants.Location = New System.Drawing.Point(208, 210)
        Me.lblNbreEnfants.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNbreEnfants.Name = "lblNbreEnfants"
        Me.lblNbreEnfants.Size = New System.Drawing.Size(90, 13)
        Me.lblNbreEnfants.TabIndex = 8
        Me.lblNbreEnfants.Text = "Nombre d'enfants"
        '
        'lblNbreValeur
        '
        Me.lblNbreValeur.AutoSize = True
        Me.lblNbreValeur.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbreValeur.ForeColor = System.Drawing.Color.Gray
        Me.lblNbreValeur.Location = New System.Drawing.Point(312, 210)
        Me.lblNbreValeur.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNbreValeur.Name = "lblNbreValeur"
        Me.lblNbreValeur.Size = New System.Drawing.Size(13, 13)
        Me.lblNbreValeur.TabIndex = 9
        Me.lblNbreValeur.Text = "0"
        '
        'grpEnfants
        '
        Me.grpEnfants.Controls.Add(Me.lblEnfant3)
        Me.grpEnfants.Controls.Add(Me.lblEnfant2)
        Me.grpEnfants.Controls.Add(Me.lblEnfant1)
        Me.grpEnfants.ForeColor = System.Drawing.Color.Gray
        Me.grpEnfants.Location = New System.Drawing.Point(388, 106)
        Me.grpEnfants.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpEnfants.Name = "grpEnfants"
        Me.grpEnfants.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpEnfants.Size = New System.Drawing.Size(171, 162)
        Me.grpEnfants.TabIndex = 10
        Me.grpEnfants.TabStop = False
        Me.grpEnfants.Text = "Prénom des enfants"
        '
        'lblEnfant3
        '
        Me.lblEnfant3.AutoSize = True
        Me.lblEnfant3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnfant3.Location = New System.Drawing.Point(12, 103)
        Me.lblEnfant3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEnfant3.Name = "lblEnfant3"
        Me.lblEnfant3.Size = New System.Drawing.Size(66, 13)
        Me.lblEnfant3.TabIndex = 13
        Me.lblEnfant3.Text = "3ème enfant"
        '
        'lblEnfant2
        '
        Me.lblEnfant2.AutoSize = True
        Me.lblEnfant2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnfant2.Location = New System.Drawing.Point(12, 72)
        Me.lblEnfant2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEnfant2.Name = "lblEnfant2"
        Me.lblEnfant2.Size = New System.Drawing.Size(66, 13)
        Me.lblEnfant2.TabIndex = 12
        Me.lblEnfant2.Text = "2ème enfant"
        '
        'lblEnfant1
        '
        Me.lblEnfant1.AutoSize = True
        Me.lblEnfant1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnfant1.Location = New System.Drawing.Point(12, 40)
        Me.lblEnfant1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEnfant1.Name = "lblEnfant1"
        Me.lblEnfant1.Size = New System.Drawing.Size(55, 13)
        Me.lblEnfant1.TabIndex = 11
        Me.lblEnfant1.Text = "1er enfant"
        '
        'cmdAnnuler
        '
        Me.cmdAnnuler.Location = New System.Drawing.Point(476, 318)
        Me.cmdAnnuler.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdAnnuler.Name = "cmdAnnuler"
        Me.cmdAnnuler.Size = New System.Drawing.Size(82, 22)
        Me.cmdAnnuler.TabIndex = 11
        Me.cmdAnnuler.Text = "Annuler"
        Me.cmdAnnuler.UseVisualStyleBackColor = True
        '
        'cmdSuppr
        '
        Me.cmdSuppr.Enabled = False
        Me.cmdSuppr.Location = New System.Drawing.Point(388, 318)
        Me.cmdSuppr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdSuppr.Name = "cmdSuppr"
        Me.cmdSuppr.Size = New System.Drawing.Size(82, 22)
        Me.cmdSuppr.TabIndex = 12
        Me.cmdSuppr.Text = "Supprimer"
        Me.cmdSuppr.UseVisualStyleBackColor = True
        '
        'frmSupp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.cmdSuppr)
        Me.Controls.Add(Me.cmdAnnuler)
        Me.Controls.Add(Me.grpEnfants)
        Me.Controls.Add(Me.lblNbreValeur)
        Me.Controls.Add(Me.lblNbreEnfants)
        Me.Controls.Add(Me.lblPrenom)
        Me.Controls.Add(Me.lblNom)
        Me.Controls.Add(Me.lblListe)
        Me.Controls.Add(Me.cmdVoir)
        Me.Controls.Add(Me.lstContacts)
        Me.Controls.Add(Me.lblTitre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmSupp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supprimer contact"
        Me.grpEnfants.ResumeLayout(False)
        Me.grpEnfants.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre As Label
    Friend WithEvents lstContacts As ListBox
    Friend WithEvents cmdVoir As Button
    Friend WithEvents lblListe As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents lblPrenom As Label
    Friend WithEvents lblNbreEnfants As Label
    Friend WithEvents lblNbreValeur As Label
    Friend WithEvents grpEnfants As GroupBox
    Friend WithEvents lblEnfant3 As Label
    Friend WithEvents lblEnfant2 As Label
    Friend WithEvents lblEnfant1 As Label
    Friend WithEvents cmdAnnuler As Button
    Friend WithEvents cmdSuppr As Button
End Class
