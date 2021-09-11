<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccueil))
        Me.cmdAjout = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.cmdModif = New System.Windows.Forms.Button()
        Me.cmdSuppr = New System.Windows.Forms.Button()
        Me.lblFeedback = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdAjout
        '
        Me.cmdAjout.BackColor = System.Drawing.Color.White
        Me.cmdAjout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdAjout.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAjout.Image = CType(resources.GetObject("cmdAjout.Image"), System.Drawing.Image)
        Me.cmdAjout.Location = New System.Drawing.Point(26, 105)
        Me.cmdAjout.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdAjout.Name = "cmdAjout"
        Me.cmdAjout.Size = New System.Drawing.Size(169, 68)
        Me.cmdAjout.TabIndex = 0
        Me.cmdAjout.Text = " Ajout"
        Me.cmdAjout.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAjout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAjout.UseVisualStyleBackColor = False
        '
        'lblTitre
        '
        Me.lblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.Black
        Me.lblTitre.Location = New System.Drawing.Point(0, 28)
        Me.lblTitre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(598, 37)
        Me.lblTitre.TabIndex = 1
        Me.lblTitre.Text = "Gestion des contacts"
        Me.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdModif
        '
        Me.cmdModif.BackColor = System.Drawing.Color.White
        Me.cmdModif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModif.Image = CType(resources.GetObject("cmdModif.Image"), System.Drawing.Image)
        Me.cmdModif.Location = New System.Drawing.Point(212, 105)
        Me.cmdModif.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdModif.Name = "cmdModif"
        Me.cmdModif.Size = New System.Drawing.Size(169, 68)
        Me.cmdModif.TabIndex = 2
        Me.cmdModif.Text = "Modification"
        Me.cmdModif.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdModif.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdModif.UseVisualStyleBackColor = False
        '
        'cmdSuppr
        '
        Me.cmdSuppr.BackColor = System.Drawing.Color.White
        Me.cmdSuppr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmdSuppr.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSuppr.Image = CType(resources.GetObject("cmdSuppr.Image"), System.Drawing.Image)
        Me.cmdSuppr.Location = New System.Drawing.Point(399, 105)
        Me.cmdSuppr.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdSuppr.Name = "cmdSuppr"
        Me.cmdSuppr.Size = New System.Drawing.Size(169, 68)
        Me.cmdSuppr.TabIndex = 3
        Me.cmdSuppr.Text = "Suppression"
        Me.cmdSuppr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSuppr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSuppr.UseVisualStyleBackColor = False
        '
        'lblFeedback
        '
        Me.lblFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblFeedback.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedback.Location = New System.Drawing.Point(26, 204)
        Me.lblFeedback.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFeedback.Name = "lblFeedback"
        Me.lblFeedback.Size = New System.Drawing.Size(542, 29)
        Me.lblFeedback.TabIndex = 4
        Me.lblFeedback.Text = "zone de confirmation de l'action réalisée"
        Me.lblFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmAccueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(600, 254)
        Me.Controls.Add(Me.lblFeedback)
        Me.Controls.Add(Me.cmdSuppr)
        Me.Controls.Add(Me.cmdModif)
        Me.Controls.Add(Me.lblTitre)
        Me.Controls.Add(Me.cmdAjout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmAccueil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Accueil"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdAjout As Button
    Friend WithEvents lblTitre As Label
    Friend WithEvents cmdModif As Button
    Friend WithEvents cmdSuppr As Button
    Friend WithEvents lblFeedback As Label
End Class
