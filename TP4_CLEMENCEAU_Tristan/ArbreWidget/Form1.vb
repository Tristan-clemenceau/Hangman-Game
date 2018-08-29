Public Class Form1

    Private tabMot() As String 'Declaration tab string'
    Private Essais As Integer = 8
    Private ValAlea As Integer
    Private NbMotTrouve As Integer
    Private NbPartie As Integer = 1
    Private nbCoupPartie As Integer = 0
    Private PartieEtat As Boolean = False
    Private nbVictoire As Integer = 0
    Private nbDefaite As Integer = 0
    Private niveau As Integer = 0
    Private xpPlayer As Integer = 0
    Private Const VICT As Integer = 50
    Private Const DEFAITE As Integer = 20


    Private Sub Initialisation()

        ColorUpdate(212, 101, 232, 51, 55, 69, 119, 196, 211, 225, 237, 100, 234, 46, 73)
        tabMot = {"FOOO", "BAR", "AN", "OTHER", "STRING"}
        lblResult.Text = Essais
        xpPlayer = 10
        ListBox1.Items.Add("Bienvenue Profil + " + CStr(xpPlayer) + " XP")
        progBar.Value = xpPlayer

        Dim rand As New Random()

        ValAlea = rand.Next(0, (tabMot.Length - 1))
        Melanger(tabMot(ValAlea))

        lblResNombrePartie.Text = NbPartie
        lblResDefaite.Text = nbDefaite
        lblResVictoire.Text = nbVictoire
        lblNivAct.Text = "LVL" + CStr(niveau)
        lblNivPro.Text = "LVL" + CStr(niveau + 1)

    End Sub

    Private Function Melanger(ByVal chaine As String) As String
        Dim rand As New Random()
        Dim newchaine = ""
        For cpt As Integer = 0 To (chaine.Length - 1)
            newchaine = newchaine.Insert(rand.Next(0, newchaine.Length), chaine(cpt))
        Next
        lblMotADeviner.Text = newchaine
        Return newchaine
    End Function

    Private Sub NouvellePartie()

        lblMotADeviner.Text = ""
        Dim rand As New Random()
        ValAlea = rand.Next(0, (tabMot.Length - 1))
        lblMotADeviner.Text = Melanger(tabMot(ValAlea))
        Historique()
        MiseAjour()
        NbPartie = NbPartie + 1
        ListBox2.Items.Clear()
        nbCoupPartie = 0
        txtSaisie.Text = ""
        Essais = 8
        lblResult.Text = Essais
        PartieEtat = False

    End Sub


    Private Sub MotCorrect()
        nbCoupPartie = nbCoupPartie + 1
        If (txtSaisie.Text.ToUpper Like tabMot(ValAlea)) Then
            PartieEtat = True
            NbMotTrouve = NbMotTrouve + 1
            xpPlayer = xpPlayer + VICT
            If MessageBox.Show("Voulez-vous rejouez ?", "Partie Gagnée", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                NouvellePartie()
            End If
        Else
            ListBox2.Items.Add(txtSaisie.Text)
            Essais = Essais - 1
            MotInorrect()
        End If
    End Sub

    Private Sub MotInorrect()
        MiseAjour()
        If (Essais = 0) Then
            xpPlayer = xpPlayer + DEFAITE
            If MessageBox.Show("Tu as perdu , le mot etait [" + tabMot(ValAlea) + "] , Voulez vous rejouer ?", "Partie PERDU", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                lblMotADeviner.Text = ""
                NouvellePartie()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialisation()
    End Sub

    Private Sub btnRejouer_Click(sender As Object, e As EventArgs) Handles btnRejouer.Click
        If lblMotADeviner.Text = "" Then
            NouvellePartie()
        Else
            MessageBox.Show("Tu ne peux pas relancer une nouvelle partie ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub NiveauUpdate()
        If xpPlayer >= 100 Then
            niveau = niveau + 1
            ListBox1.Items.Add("Vous venez de passer LVL : " + CStr(niveau))
            xpPlayer = 0
        End If
    End Sub

    Private Sub MiseAjour()

        lblResDefaite.Text = nbDefaite
        lblResVictoire.Text = nbVictoire
        lblNivAct.Text = "LVL" + CStr(niveau)
        lblNivPro.Text = "LVL" + CStr(niveau + 1)
        lblResNombrePartie.Text = NbPartie
        lblResult.Text = Essais
        NiveauUpdate()
        progBar.Value = xpPlayer
        txtSaisie.Clear()
    End Sub

    Private Sub ColorUpdate(R01 As Integer, G01 As Integer, B01 As Integer, R02 As Integer, G02 As Integer, B02 As Integer, R03 As Integer, G03 As Integer, B03 As Integer, R04 As Integer, G04 As Integer, B04 As Integer, R05 As Integer, G05 As Integer, B05 As Integer) 'Permet de Changer la couleur des elements presents dans la fenetres'
        'RGB 1="BackGround application" RGB 2=Background Label RGB 3=Color Police RGB 4=GroupeBox RGB 5=Bouton Color'
        Me.BackColor = Color.FromArgb(R01, G01, B01)
        btnTester.ForeColor = Color.FromArgb(R01, G01, B01)
        btnDarkTheme.ForeColor = Color.FromArgb(R01, G01, B01)
        btnDefautMode.ForeColor = Color.FromArgb(R01, G01, B01)
        btnGamerMode.ForeColor = Color.FromArgb(R01, G01, B01)
        btnWhiteTheme.ForeColor = Color.FromArgb(R01, G01, B01)
        btnQuitter.ForeColor = Color.FromArgb(R01, G01, B01)
        btnRejouer.ForeColor = Color.FromArgb(R01, G01, B01)

        lblHistorique.BackColor = Color.FromArgb(R02, G02, B02)
        lblMAO.BackColor = Color.FromArgb(R02, G02, B02)
        lblMotADeviner.BackColor = Color.FromArgb(R02, G02, B02)
        lblPropositions.BackColor = Color.FromArgb(R02, G02, B02)
        lblResult.BackColor = Color.FromArgb(R02, G02, B02)
        gpEssais.BackColor = Color.FromArgb(R02, G02, B02)
        gpProposition.BackColor = Color.FromArgb(R02, G02, B02)
        gpBoxColor.BackColor = Color.FromArgb(R02, G02, B02)
        GroupBoxInfo.BackColor = Color.FromArgb(R02, G02, B02)
        ListBox2.ForeColor = Color.FromArgb(R02, G02, B02)
        ListBox1.ForeColor = Color.FromArgb(R02, G02, B02)
        txtSaisie.ForeColor = Color.FromArgb(R02, G02, B02)

        lblHistorique.ForeColor = Color.FromArgb(R03, G03, B03)
        lblMAO.ForeColor = Color.FromArgb(R03, G03, B03)
        lblMotADeviner.ForeColor = Color.FromArgb(R03, G03, B03)
        lblPropositions.ForeColor = Color.FromArgb(R03, G03, B03)
        lblResult.ForeColor = Color.FromArgb(R03, G03, B03)
        GroupBoxInfo.ForeColor = Color.FromArgb(R03, G03, B03)
        gpEssais.ForeColor = Color.FromArgb(R03, G03, B03)
        gpProposition.ForeColor = Color.FromArgb(R03, G03, B03)
        gpBoxColor.ForeColor = Color.FromArgb(R03, G03, B03)
        lblDispnbPartie.ForeColor = Color.FromArgb(R03, G03, B03)
        lblResNombrePartie.ForeColor = Color.FromArgb(R03, G03, B03)
        lblDispDef.ForeColor = Color.FromArgb(R03, G03, B03)
        lblDispVic.ForeColor = Color.FromArgb(R03, G03, B03)
        lblResVictoire.ForeColor = Color.FromArgb(R03, G03, B03)
        lblResDefaite.ForeColor = Color.FromArgb(R03, G03, B03)
        lblNivPro.ForeColor = Color.FromArgb(R03, G03, B03)
        lblNivAct.ForeColor = Color.FromArgb(R03, G03, B03)


        btnTester.BackColor = Color.FromArgb(R04, G04, B04)
        btnDefautMode.BackColor = Color.FromArgb(R04, G04, B04)
        btnDarkTheme.BackColor = Color.FromArgb(R04, G04, B04)
        btnGamerMode.BackColor = Color.FromArgb(R04, G04, B04)
        btnWhiteTheme.BackColor = Color.FromArgb(R04, G04, B04)
        btnQuitter.BackColor = Color.FromArgb(R04, G04, B04)
        btnRejouer.BackColor = Color.FromArgb(R04, G04, B04)


        'GRIS'
        txtSaisie.BackColor = Color.FromArgb(R05, G05, B05)
        ListBox2.BackColor = Color.FromArgb(R05, G05, B05)
        ListBox1.BackColor = Color.FromArgb(R05, G05, B05)




    End Sub

    Private Sub Historique()
        If PartieEtat = True Then
            nbVictoire = nbVictoire + 1
            ListBox1.Items.Add("Partie" + CStr(NbPartie) + " : Gagné " + " [" + CStr(nbCoupPartie) + " Essai(s)]")
        Else
            nbDefaite = nbDefaite + 1
            ListBox1.Items.Add("Partie" + CStr(NbPartie) + " : Perdu")
        End If
    End Sub

    Private Sub btnTester_Click(sender As Object, e As EventArgs) Handles btnTester.Click
        If txtSaisie.Text = "" Then
        Else
            MotCorrect()
            MotInorrect()
        End If
    End Sub

    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click

        If MessageBox.Show(CStr(NbMotTrouve) + " mot(s) trouvée sur " + CStr(NbPartie) + " partie(s)", "Quitter", MessageBoxButtons.OK, MessageBoxIcon.Question) = vbOK Then
            Me.Dispose()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDarkTheme.Click 'Dark theme https://color.adobe.com/fr/ATLANTHYS-TOOL-color-theme-8090318/edit/?copy=true'
        ColorUpdate(1, 0, 0, 92, 0, 9, 189, 183, 184, 148, 3, 21, 57, 56, 69)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnWhiteTheme.Click 'White theme https://color.adobe.com/fr/ad4fce445f05340350b92478ebeaa1f6-color-theme-10551296/edit/?copy=true'
        ColorUpdate(73, 49, 168, 113, 109, 249, 117, 226, 228, 128, 126, 251, 72, 205, 210)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGamerMode.Click 'Gamer Mode https://color.adobe.com/fr/CS04-color-theme-1994456/edit/?copy=true'
        ColorUpdate(51, 55, 69, 218, 237, 226, 51, 55, 69, 119, 196, 211, 234, 46, 73)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnDefautMode.Click 'Default Mode'
        ColorUpdate(212, 101, 232, 51, 55, 69, 119, 196, 211, 225, 237, 100, 234, 46, 73)
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles progBar.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblResNombrePartie.Click

    End Sub
End Class
