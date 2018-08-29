<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.btnRejouer = New System.Windows.Forms.Button()
        Me.gpProposition = New System.Windows.Forms.GroupBox()
        Me.btnTester = New System.Windows.Forms.Button()
        Me.txtSaisie = New System.Windows.Forms.TextBox()
        Me.lblHistorique = New System.Windows.Forms.Label()
        Me.gpEssais = New System.Windows.Forms.GroupBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblPropositions = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblMAO = New System.Windows.Forms.Label()
        Me.lblMotADeviner = New System.Windows.Forms.Label()
        Me.gpBoxColor = New System.Windows.Forms.GroupBox()
        Me.btnDefautMode = New System.Windows.Forms.Button()
        Me.btnWhiteTheme = New System.Windows.Forms.Button()
        Me.btnGamerMode = New System.Windows.Forms.Button()
        Me.btnDarkTheme = New System.Windows.Forms.Button()
        Me.GroupBoxInfo = New System.Windows.Forms.GroupBox()
        Me.progBar = New System.Windows.Forms.ProgressBar()
        Me.lblDispnbPartie = New System.Windows.Forms.Label()
        Me.lblDispVic = New System.Windows.Forms.Label()
        Me.lblNivAct = New System.Windows.Forms.Label()
        Me.lblDispDef = New System.Windows.Forms.Label()
        Me.lblResNombrePartie = New System.Windows.Forms.Label()
        Me.lblResVictoire = New System.Windows.Forms.Label()
        Me.lblResDefaite = New System.Windows.Forms.Label()
        Me.lblNivPro = New System.Windows.Forms.Label()
        Me.gpProposition.SuspendLayout()
        Me.gpEssais.SuspendLayout()
        Me.gpBoxColor.SuspendLayout()
        Me.GroupBoxInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(591, 528)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(92, 34)
        Me.btnQuitter.TabIndex = 0
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'btnRejouer
        '
        Me.btnRejouer.Location = New System.Drawing.Point(471, 528)
        Me.btnRejouer.Name = "btnRejouer"
        Me.btnRejouer.Size = New System.Drawing.Size(92, 34)
        Me.btnRejouer.TabIndex = 1
        Me.btnRejouer.Text = "Rejouer"
        Me.btnRejouer.UseVisualStyleBackColor = True
        '
        'gpProposition
        '
        Me.gpProposition.AutoSize = True
        Me.gpProposition.Controls.Add(Me.btnTester)
        Me.gpProposition.Controls.Add(Me.txtSaisie)
        Me.gpProposition.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gpProposition.Location = New System.Drawing.Point(24, 63)
        Me.gpProposition.Name = "gpProposition"
        Me.gpProposition.Size = New System.Drawing.Size(316, 114)
        Me.gpProposition.TabIndex = 2
        Me.gpProposition.TabStop = False
        Me.gpProposition.Text = "Proposition"
        '
        'btnTester
        '
        Me.btnTester.Location = New System.Drawing.Point(207, 46)
        Me.btnTester.Name = "btnTester"
        Me.btnTester.Size = New System.Drawing.Size(92, 34)
        Me.btnTester.TabIndex = 1
        Me.btnTester.Text = "Tester"
        Me.btnTester.UseVisualStyleBackColor = True
        '
        'txtSaisie
        '
        Me.txtSaisie.Location = New System.Drawing.Point(26, 51)
        Me.txtSaisie.Name = "txtSaisie"
        Me.txtSaisie.Size = New System.Drawing.Size(165, 23)
        Me.txtSaisie.TabIndex = 0
        '
        'lblHistorique
        '
        Me.lblHistorique.AutoSize = True
        Me.lblHistorique.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.25!)
        Me.lblHistorique.Location = New System.Drawing.Point(444, 23)
        Me.lblHistorique.Name = "lblHistorique"
        Me.lblHistorique.Size = New System.Drawing.Size(171, 39)
        Me.lblHistorique.TabIndex = 3
        Me.lblHistorique.Text = "Historique"
        '
        'gpEssais
        '
        Me.gpEssais.Controls.Add(Me.lblResult)
        Me.gpEssais.Controls.Add(Me.lblPropositions)
        Me.gpEssais.Controls.Add(Me.Label1)
        Me.gpEssais.Controls.Add(Me.ListBox2)
        Me.gpEssais.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gpEssais.Location = New System.Drawing.Point(24, 284)
        Me.gpEssais.Name = "gpEssais"
        Me.gpEssais.Size = New System.Drawing.Size(316, 273)
        Me.gpEssais.TabIndex = 4
        Me.gpEssais.TabStop = False
        Me.gpEssais.Text = "Essais"
        '
        'lblResult
        '
        Me.lblResult.Location = New System.Drawing.Point(97, 23)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(41, 26)
        Me.lblResult.TabIndex = 3
        '
        'lblPropositions
        '
        Me.lblPropositions.AutoSize = True
        Me.lblPropositions.Location = New System.Drawing.Point(29, 61)
        Me.lblPropositions.Name = "lblPropositions"
        Me.lblPropositions.Size = New System.Drawing.Size(94, 17)
        Me.lblPropositions.TabIndex = 2
        Me.lblPropositions.Text = "Propositions :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Restant :"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 17
        Me.ListBox2.Location = New System.Drawing.Point(26, 103)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(242, 140)
        Me.ListBox2.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(428, 63)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(233, 290)
        Me.ListBox1.TabIndex = 5
        '
        'lblMAO
        '
        Me.lblMAO.AutoSize = True
        Me.lblMAO.Location = New System.Drawing.Point(24, 13)
        Me.lblMAO.Name = "lblMAO"
        Me.lblMAO.Size = New System.Drawing.Size(81, 13)
        Me.lblMAO.TabIndex = 6
        Me.lblMAO.Text = "Mot à Ordonner"
        '
        'lblMotADeviner
        '
        Me.lblMotADeviner.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.lblMotADeviner.Location = New System.Drawing.Point(53, 30)
        Me.lblMotADeviner.Name = "lblMotADeviner"
        Me.lblMotADeviner.Size = New System.Drawing.Size(100, 23)
        Me.lblMotADeviner.TabIndex = 7
        '
        'gpBoxColor
        '
        Me.gpBoxColor.Controls.Add(Me.btnDefautMode)
        Me.gpBoxColor.Controls.Add(Me.btnWhiteTheme)
        Me.gpBoxColor.Controls.Add(Me.btnGamerMode)
        Me.gpBoxColor.Controls.Add(Me.btnDarkTheme)
        Me.gpBoxColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.gpBoxColor.Location = New System.Drawing.Point(368, 368)
        Me.gpBoxColor.Name = "gpBoxColor"
        Me.gpBoxColor.Size = New System.Drawing.Size(293, 140)
        Me.gpBoxColor.TabIndex = 8
        Me.gpBoxColor.TabStop = False
        Me.gpBoxColor.Text = "Mode"
        '
        'btnDefautMode
        '
        Me.btnDefautMode.Location = New System.Drawing.Point(163, 87)
        Me.btnDefautMode.Name = "btnDefautMode"
        Me.btnDefautMode.Size = New System.Drawing.Size(106, 31)
        Me.btnDefautMode.TabIndex = 3
        Me.btnDefautMode.Text = "Defaut Theme"
        Me.btnDefautMode.UseVisualStyleBackColor = True
        '
        'btnWhiteTheme
        '
        Me.btnWhiteTheme.Location = New System.Drawing.Point(163, 30)
        Me.btnWhiteTheme.Name = "btnWhiteTheme"
        Me.btnWhiteTheme.Size = New System.Drawing.Size(106, 31)
        Me.btnWhiteTheme.TabIndex = 2
        Me.btnWhiteTheme.Text = "White Theme"
        Me.btnWhiteTheme.UseVisualStyleBackColor = True
        '
        'btnGamerMode
        '
        Me.btnGamerMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btnGamerMode.Location = New System.Drawing.Point(19, 87)
        Me.btnGamerMode.Name = "btnGamerMode"
        Me.btnGamerMode.Size = New System.Drawing.Size(106, 31)
        Me.btnGamerMode.TabIndex = 1
        Me.btnGamerMode.Text = "Gamer Theme"
        Me.btnGamerMode.UseVisualStyleBackColor = True
        '
        'btnDarkTheme
        '
        Me.btnDarkTheme.Location = New System.Drawing.Point(19, 30)
        Me.btnDarkTheme.Name = "btnDarkTheme"
        Me.btnDarkTheme.Size = New System.Drawing.Size(106, 31)
        Me.btnDarkTheme.TabIndex = 0
        Me.btnDarkTheme.Text = "Dark Theme"
        Me.btnDarkTheme.UseVisualStyleBackColor = True
        '
        'GroupBoxInfo
        '
        Me.GroupBoxInfo.Controls.Add(Me.lblNivPro)
        Me.GroupBoxInfo.Controls.Add(Me.lblResDefaite)
        Me.GroupBoxInfo.Controls.Add(Me.lblResVictoire)
        Me.GroupBoxInfo.Controls.Add(Me.lblResNombrePartie)
        Me.GroupBoxInfo.Controls.Add(Me.lblDispDef)
        Me.GroupBoxInfo.Controls.Add(Me.lblNivAct)
        Me.GroupBoxInfo.Controls.Add(Me.lblDispVic)
        Me.GroupBoxInfo.Controls.Add(Me.lblDispnbPartie)
        Me.GroupBoxInfo.Controls.Add(Me.progBar)
        Me.GroupBoxInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.GroupBoxInfo.Location = New System.Drawing.Point(24, 183)
        Me.GroupBoxInfo.Name = "GroupBoxInfo"
        Me.GroupBoxInfo.Size = New System.Drawing.Size(316, 95)
        Me.GroupBoxInfo.TabIndex = 9
        Me.GroupBoxInfo.TabStop = False
        Me.GroupBoxInfo.Text = "Info"
        '
        'progBar
        '
        Me.progBar.Location = New System.Drawing.Point(82, 75)
        Me.progBar.Name = "progBar"
        Me.progBar.Size = New System.Drawing.Size(125, 14)
        Me.progBar.TabIndex = 4
        '
        'lblDispnbPartie
        '
        Me.lblDispnbPartie.AutoSize = True
        Me.lblDispnbPartie.Location = New System.Drawing.Point(6, 19)
        Me.lblDispnbPartie.Name = "lblDispnbPartie"
        Me.lblDispnbPartie.Size = New System.Drawing.Size(107, 17)
        Me.lblDispnbPartie.TabIndex = 5
        Me.lblDispnbPartie.Text = "Nombre Partie :"
        '
        'lblDispVic
        '
        Me.lblDispVic.AutoSize = True
        Me.lblDispVic.Location = New System.Drawing.Point(30, 36)
        Me.lblDispVic.Name = "lblDispVic"
        Me.lblDispVic.Size = New System.Drawing.Size(117, 17)
        Me.lblDispVic.TabIndex = 6
        Me.lblDispVic.Text = "Nombre Victoire :"
        '
        'lblNivAct
        '
        Me.lblNivAct.Location = New System.Drawing.Point(30, 72)
        Me.lblNivAct.Name = "lblNivAct"
        Me.lblNivAct.Size = New System.Drawing.Size(48, 17)
        Me.lblNivAct.TabIndex = 7
        '
        'lblDispDef
        '
        Me.lblDispDef.AutoSize = True
        Me.lblDispDef.Location = New System.Drawing.Point(30, 53)
        Me.lblDispDef.Name = "lblDispDef"
        Me.lblDispDef.Size = New System.Drawing.Size(115, 17)
        Me.lblDispDef.TabIndex = 9
        Me.lblDispDef.Text = "Nombre Defaite :"
        '
        'lblResNombrePartie
        '
        Me.lblResNombrePartie.Location = New System.Drawing.Point(108, 19)
        Me.lblResNombrePartie.Name = "lblResNombrePartie"
        Me.lblResNombrePartie.Size = New System.Drawing.Size(39, 17)
        Me.lblResNombrePartie.TabIndex = 10
        '
        'lblResVictoire
        '
        Me.lblResVictoire.Location = New System.Drawing.Point(153, 36)
        Me.lblResVictoire.Name = "lblResVictoire"
        Me.lblResVictoire.Size = New System.Drawing.Size(39, 17)
        Me.lblResVictoire.TabIndex = 11
        '
        'lblResDefaite
        '
        Me.lblResDefaite.Location = New System.Drawing.Point(153, 55)
        Me.lblResDefaite.Name = "lblResDefaite"
        Me.lblResDefaite.Size = New System.Drawing.Size(39, 17)
        Me.lblResDefaite.TabIndex = 12
        '
        'lblNivPro
        '
        Me.lblNivPro.Location = New System.Drawing.Point(217, 72)
        Me.lblNivPro.Name = "lblNivPro"
        Me.lblNivPro.Size = New System.Drawing.Size(58, 17)
        Me.lblNivPro.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 586)
        Me.Controls.Add(Me.GroupBoxInfo)
        Me.Controls.Add(Me.gpBoxColor)
        Me.Controls.Add(Me.lblMotADeviner)
        Me.Controls.Add(Me.lblMAO)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.gpEssais)
        Me.Controls.Add(Me.lblHistorique)
        Me.Controls.Add(Me.gpProposition)
        Me.Controls.Add(Me.btnRejouer)
        Me.Controls.Add(Me.btnQuitter)
        Me.Name = "Form1"
        Me.Text = "Jeu De Mots"
        Me.gpProposition.ResumeLayout(False)
        Me.gpProposition.PerformLayout()
        Me.gpEssais.ResumeLayout(False)
        Me.gpEssais.PerformLayout()
        Me.gpBoxColor.ResumeLayout(False)
        Me.GroupBoxInfo.ResumeLayout(False)
        Me.GroupBoxInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuitter As Button
    Friend WithEvents btnRejouer As Button
    Friend WithEvents gpProposition As GroupBox
    Friend WithEvents lblHistorique As Label
    Friend WithEvents btnTester As Button
    Friend WithEvents txtSaisie As TextBox
    Friend WithEvents gpEssais As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblPropositions As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents lblResult As Label
    Friend WithEvents lblMAO As Label
    Friend WithEvents lblMotADeviner As Label
    Friend WithEvents gpBoxColor As GroupBox
    Friend WithEvents btnWhiteTheme As Button
    Friend WithEvents btnGamerMode As Button
    Friend WithEvents btnDarkTheme As Button
    Friend WithEvents btnDefautMode As Button
    Friend WithEvents progBar As ProgressBar
    Friend WithEvents GroupBoxInfo As GroupBox
    Friend WithEvents lblNivAct As Label
    Friend WithEvents lblDispVic As Label
    Friend WithEvents lblDispnbPartie As Label
    Friend WithEvents lblDispDef As Label
    Friend WithEvents lblResNombrePartie As Label
    Friend WithEvents lblResDefaite As Label
    Friend WithEvents lblResVictoire As Label
    Friend WithEvents lblNivPro As Label
End Class
