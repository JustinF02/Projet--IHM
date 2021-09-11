<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAjout))
        Me.nudNbEnfants = New System.Windows.Forms.NumericUpDown()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.cmdAjouter = New System.Windows.Forms.Button()
        Me.cmdAnnuler = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.TxtEnfant3 = New System.Windows.Forms.TextBox()
        Me.txtEnfant1 = New System.Windows.Forms.TextBox()
        Me.txtEnfant2 = New System.Windows.Forms.TextBox()
        Me.lblNbreEnfants = New System.Windows.Forms.Label()
        Me.lblPrénomEnfants = New System.Windows.Forms.Label()
        Me.pnlEnfants = New System.Windows.Forms.Panel()
        CType(Me.nudNbEnfants, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlEnfants.SuspendLayout()
        Me.SuspendLayout()
        '
        'nudNbEnfants
        '
        Me.nudNbEnfants.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudNbEnfants.Location = New System.Drawing.Point(133, 205)
        Me.nudNbEnfants.Margin = New System.Windows.Forms.Padding(2)
        Me.nudNbEnfants.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.nudNbEnfants.Name = "nudNbEnfants"
        Me.nudNbEnfants.ReadOnly = True
        Me.nudNbEnfants.Size = New System.Drawing.Size(37, 19)
        Me.nudNbEnfants.TabIndex = 3
        Me.nudNbEnfants.TabStop = False
        Me.nudNbEnfants.Tag = "0"
        '
        'txtNom
        '
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.ForeColor = System.Drawing.Color.Gray
        Me.txtNom.Location = New System.Drawing.Point(30, 142)
        Me.txtNom.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(140, 19)
        Me.txtNom.TabIndex = 1
        Me.txtNom.Tag = "Nom du contact"
        Me.txtNom.Text = "Nom du contact"
        '
        'txtPrenom
        '
        Me.txtPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrenom.ForeColor = System.Drawing.Color.Gray
        Me.txtPrenom.Location = New System.Drawing.Point(30, 172)
        Me.txtPrenom.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(140, 19)
        Me.txtPrenom.TabIndex = 2
        Me.txtPrenom.TabStop = False
        Me.txtPrenom.Tag = "Prénom du contact"
        Me.txtPrenom.Text = "Prénom du contact"
        '
        'cmdAjouter
        '
        Me.cmdAjouter.Enabled = False
        Me.cmdAjouter.Location = New System.Drawing.Point(225, 317)
        Me.cmdAjouter.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdAjouter.Name = "cmdAjouter"
        Me.cmdAjouter.Size = New System.Drawing.Size(82, 22)
        Me.cmdAjouter.TabIndex = 4
        Me.cmdAjouter.TabStop = False
        Me.cmdAjouter.Text = "Ajouter"
        Me.cmdAjouter.UseVisualStyleBackColor = True
        '
        'cmdAnnuler
        '
        Me.cmdAnnuler.Location = New System.Drawing.Point(321, 317)
        Me.cmdAnnuler.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdAnnuler.Name = "cmdAnnuler"
        Me.cmdAnnuler.Size = New System.Drawing.Size(82, 22)
        Me.cmdAnnuler.TabIndex = 37
        Me.cmdAnnuler.TabStop = False
        Me.cmdAnnuler.Text = "Annuler"
        Me.cmdAnnuler.UseVisualStyleBackColor = True
        '
        'lblTitre
        '
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.Black
        Me.lblTitre.Location = New System.Drawing.Point(-1, 27)
        Me.lblTitre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(440, 37)
        Me.lblTitre.TabIndex = 35
        Me.lblTitre.Text = "Ajout d'un contact"
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtEnfant3
        '
        Me.TxtEnfant3.Enabled = False
        Me.TxtEnfant3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEnfant3.ForeColor = System.Drawing.Color.Gray
        Me.TxtEnfant3.Location = New System.Drawing.Point(14, 97)
        Me.TxtEnfant3.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtEnfant3.Name = "TxtEnfant3"
        Me.TxtEnfant3.Size = New System.Drawing.Size(140, 19)
        Me.TxtEnfant3.TabIndex = 7
        Me.TxtEnfant3.Tag = "3ème enfant"
        Me.TxtEnfant3.Text = "3ème enfant"
        '
        'txtEnfant1
        '
        Me.txtEnfant1.Enabled = False
        Me.txtEnfant1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnfant1.ForeColor = System.Drawing.Color.Gray
        Me.txtEnfant1.Location = New System.Drawing.Point(14, 37)
        Me.txtEnfant1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEnfant1.Name = "txtEnfant1"
        Me.txtEnfant1.Size = New System.Drawing.Size(140, 19)
        Me.txtEnfant1.TabIndex = 5
        Me.txtEnfant1.Tag = "1er enfant"
        Me.txtEnfant1.Text = "1er enfant"
        '
        'txtEnfant2
        '
        Me.txtEnfant2.Enabled = False
        Me.txtEnfant2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnfant2.ForeColor = System.Drawing.Color.Gray
        Me.txtEnfant2.Location = New System.Drawing.Point(14, 67)
        Me.txtEnfant2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEnfant2.Name = "txtEnfant2"
        Me.txtEnfant2.Size = New System.Drawing.Size(140, 19)
        Me.txtEnfant2.TabIndex = 6
        Me.txtEnfant2.Tag = "2ème enfant"
        Me.txtEnfant2.Text = "2ème enfant"
        '
        'lblNbreEnfants
        '
        Me.lblNbreEnfants.AutoSize = True
        Me.lblNbreEnfants.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbreEnfants.Location = New System.Drawing.Point(28, 206)
        Me.lblNbreEnfants.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNbreEnfants.Name = "lblNbreEnfants"
        Me.lblNbreEnfants.Size = New System.Drawing.Size(90, 13)
        Me.lblNbreEnfants.TabIndex = 42
        Me.lblNbreEnfants.Text = "Nombre d'enfants"
        '
        'lblPrénomEnfants
        '
        Me.lblPrénomEnfants.AutoSize = True
        Me.lblPrénomEnfants.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrénomEnfants.Location = New System.Drawing.Point(230, 98)
        Me.lblPrénomEnfants.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrénomEnfants.Name = "lblPrénomEnfants"
        Me.lblPrénomEnfants.Size = New System.Drawing.Size(101, 13)
        Me.lblPrénomEnfants.TabIndex = 43
        Me.lblPrénomEnfants.Text = "Prénom des enfants"
        '
        'pnlEnfants
        '
        Me.pnlEnfants.AutoScroll = True
        Me.pnlEnfants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEnfants.Controls.Add(Me.TxtEnfant3)
        Me.pnlEnfants.Controls.Add(Me.txtEnfant1)
        Me.pnlEnfants.Controls.Add(Me.txtEnfant2)
        Me.pnlEnfants.Location = New System.Drawing.Point(225, 105)
        Me.pnlEnfants.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlEnfants.Name = "pnlEnfants"
        Me.pnlEnfants.Size = New System.Drawing.Size(179, 163)
        Me.pnlEnfants.TabIndex = 36
        '
        'frmAjout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(438, 366)
        Me.Controls.Add(Me.nudNbEnfants)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.cmdAjouter)
        Me.Controls.Add(Me.cmdAnnuler)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.lblNbreEnfants)
        Me.Controls.Add(Me.lblPrénomEnfants)
        Me.Controls.Add(Me.pnlEnfants)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAjout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajouter Contact"
        CType(Me.nudNbEnfants, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlEnfants.ResumeLayout(False)
        Me.pnlEnfants.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nudNbEnfants As NumericUpDown
    Friend WithEvents txtNom As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents cmdAjouter As Button
    Friend WithEvents cmdAnnuler As Button
    Friend WithEvents lblTitre As Label
    Friend WithEvents TxtEnfant3 As TextBox
    Friend WithEvents txtEnfant1 As TextBox
    Friend WithEvents txtEnfant2 As TextBox
    Friend WithEvents lblNbreEnfants As Label
    Friend WithEvents lblPrénomEnfants As Label
    Friend WithEvents pnlEnfants As Panel
End Class
