<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmModif
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
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.cmdModifier = New System.Windows.Forms.Button()
        Me.cmdAnnuler = New System.Windows.Forms.Button()
        Me.grpEnfants = New System.Windows.Forms.GroupBox()
        Me.TxtEnfant3 = New System.Windows.Forms.TextBox()
        Me.txtEnfant2 = New System.Windows.Forms.TextBox()
        Me.txtEnfant1 = New System.Windows.Forms.TextBox()
        Me.lblNbreEnfants = New System.Windows.Forms.Label()
        Me.lblListe = New System.Windows.Forms.Label()
        Me.lstContacts = New System.Windows.Forms.ListBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.nudNbEnfants = New System.Windows.Forms.NumericUpDown()
        Me.grpEnfants.SuspendLayout()
        CType(Me.nudNbEnfants, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitre.Text = "Modification d'un contact"
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdModifier
        '
        Me.cmdModifier.Enabled = False
        Me.cmdModifier.Location = New System.Drawing.Point(388, 318)
        Me.cmdModifier.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdModifier.Name = "cmdModifier"
        Me.cmdModifier.Size = New System.Drawing.Size(82, 22)
        Me.cmdModifier.TabIndex = 22
        Me.cmdModifier.Text = "Modifier"
        Me.cmdModifier.UseVisualStyleBackColor = True
        '
        'cmdAnnuler
        '
        Me.cmdAnnuler.Location = New System.Drawing.Point(484, 318)
        Me.cmdAnnuler.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdAnnuler.Name = "cmdAnnuler"
        Me.cmdAnnuler.Size = New System.Drawing.Size(82, 22)
        Me.cmdAnnuler.TabIndex = 21
        Me.cmdAnnuler.Text = "Annuler"
        Me.cmdAnnuler.UseVisualStyleBackColor = True
        '
        'grpEnfants
        '
        Me.grpEnfants.Controls.Add(Me.TxtEnfant3)
        Me.grpEnfants.Controls.Add(Me.txtEnfant2)
        Me.grpEnfants.Controls.Add(Me.txtEnfant1)
        Me.grpEnfants.Enabled = False
        Me.grpEnfants.Location = New System.Drawing.Point(388, 106)
        Me.grpEnfants.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpEnfants.Name = "grpEnfants"
        Me.grpEnfants.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpEnfants.Size = New System.Drawing.Size(178, 162)
        Me.grpEnfants.TabIndex = 20
        Me.grpEnfants.TabStop = False
        Me.grpEnfants.Text = "Prénom des enfants"
        '
        'TxtEnfant3
        '
        Me.TxtEnfant3.Enabled = False
        Me.TxtEnfant3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnfant3.Location = New System.Drawing.Point(14, 101)
        Me.TxtEnfant3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtEnfant3.Name = "TxtEnfant3"
        Me.TxtEnfant3.Size = New System.Drawing.Size(140, 19)
        Me.TxtEnfant3.TabIndex = 28
        Me.TxtEnfant3.Text = "3ème enfant"
        '
        'txtEnfant2
        '
        Me.txtEnfant2.Enabled = False
        Me.txtEnfant2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnfant2.Location = New System.Drawing.Point(14, 69)
        Me.txtEnfant2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEnfant2.Name = "txtEnfant2"
        Me.txtEnfant2.Size = New System.Drawing.Size(140, 19)
        Me.txtEnfant2.TabIndex = 27
        Me.txtEnfant2.Text = "2ème enfant"
        '
        'txtEnfant1
        '
        Me.txtEnfant1.Enabled = False
        Me.txtEnfant1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnfant1.Location = New System.Drawing.Point(14, 37)
        Me.txtEnfant1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEnfant1.Name = "txtEnfant1"
        Me.txtEnfant1.Size = New System.Drawing.Size(140, 19)
        Me.txtEnfant1.TabIndex = 26
        Me.txtEnfant1.Text = "1er enfant"
        '
        'lblNbreEnfants
        '
        Me.lblNbreEnfants.AutoSize = True
        Me.lblNbreEnfants.Enabled = False
        Me.lblNbreEnfants.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbreEnfants.Location = New System.Drawing.Point(206, 210)
        Me.lblNbreEnfants.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNbreEnfants.Name = "lblNbreEnfants"
        Me.lblNbreEnfants.Size = New System.Drawing.Size(90, 13)
        Me.lblNbreEnfants.TabIndex = 18
        Me.lblNbreEnfants.Text = "Nombre d'enfants"
        '
        'lblListe
        '
        Me.lblListe.AutoSize = True
        Me.lblListe.Location = New System.Drawing.Point(31, 106)
        Me.lblListe.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblListe.Name = "lblListe"
        Me.lblListe.Size = New System.Drawing.Size(120, 13)
        Me.lblListe.TabIndex = 15
        Me.lblListe.Text = "Sélectionner un contact"
        '
        'lstContacts
        '
        Me.lstContacts.FormattingEnabled = True
        Me.lstContacts.Location = New System.Drawing.Point(31, 123)
        Me.lstContacts.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstContacts.Name = "lstContacts"
        Me.lstContacts.Size = New System.Drawing.Size(140, 147)
        Me.lstContacts.TabIndex = 13
        '
        'txtPrenom
        '
        Me.txtPrenom.Enabled = False
        Me.txtPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrenom.Location = New System.Drawing.Point(208, 176)
        Me.txtPrenom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(140, 19)
        Me.txtPrenom.TabIndex = 23
        Me.txtPrenom.Text = "Prénom du contact"
        '
        'txtNom
        '
        Me.txtNom.Enabled = False
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(208, 144)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(140, 19)
        Me.txtNom.TabIndex = 24
        Me.txtNom.Text = "Nom du contact"
        '
        'nudNbEnfants
        '
        Me.nudNbEnfants.Enabled = False
        Me.nudNbEnfants.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNbEnfants.Location = New System.Drawing.Point(310, 208)
        Me.nudNbEnfants.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.nudNbEnfants.Name = "nudNbEnfants"
        Me.nudNbEnfants.Size = New System.Drawing.Size(37, 19)
        Me.nudNbEnfants.TabIndex = 25
        '
        'frmModif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.nudNbEnfants)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.cmdModifier)
        Me.Controls.Add(Me.cmdAnnuler)
        Me.Controls.Add(Me.grpEnfants)
        Me.Controls.Add(Me.lblNbreEnfants)
        Me.Controls.Add(Me.lblListe)
        Me.Controls.Add(Me.lstContacts)
        Me.Controls.Add(Me.lblTitre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmModif"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifier contact"
        Me.grpEnfants.ResumeLayout(False)
        Me.grpEnfants.PerformLayout()
        CType(Me.nudNbEnfants, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre As Label
    Friend WithEvents cmdModifier As Button
    Friend WithEvents cmdAnnuler As Button
    Friend WithEvents grpEnfants As GroupBox
    Friend WithEvents lblNbreEnfants As Label
    Friend WithEvents lblListe As Label
    Friend WithEvents lstContacts As ListBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtEnfant1 As TextBox
    Friend WithEvents nudNbEnfants As NumericUpDown
    Friend WithEvents TxtEnfant3 As TextBox
    Friend WithEvents txtEnfant2 As TextBox
End Class
