Public Class frmDeskTop
    Public nTamanho As Integer = 1
    Public nCor As Integer = 0
    Private ObjAux As Button
    Private nCursorX As Integer = 47 'Correção da localização para o dragdrop
    Private nCursorY As Integer = 70 'Correção da localização para o dragdrop
    Private MouseIsDown As Boolean
    Private nAreaInicial As Integer = 327 '437
    Private nAreaFinal As Integer = 13
    Private lDrop As Boolean = False

    Private Sub frmDeskTop_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim nCod_Login As Integer
        Dim nTamano As Integer

        If IsNothing(g_Login) Then Exit Sub

        'Conectar com o Banco de dados
        If Not ConectarBanco() Then Exit Sub

        nCod_Login = getCodUsuario(ClassCrypt.Decrypt(g_Login))
        nTamano = ResgatarTamanho()

        For Each _control As Object In Me.Controls
            If TypeOf (_control) Is Button Then
                If Mid(_control.Name.ToString, 1, 3) = "btn" Then
                    If _control.visible Then
                        If Not GravarConfigIcones(nCod_Login, getCodOpcao(0, Trim(_control.name), ""), _
                                nTamanho, _control.location.x, _control.location.y, nCor) Then
                            MsgBox("Erro ao Gravar as configurações da Tela. Favor verificar com o Administrador !!!")
                        End If
                    End If
                End If
            End If
        Next

        g_ConnectBanco.close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Enabled = False
        Me.Hide()

        LoginForm.Show(Me)

        LoginForm.UsernameTextBox.Focus()

    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip.Show(e.X, e.Y)
        End If
    End Sub

    Private Sub btnCompras_Click(sender As Button, e As EventArgs) Handles btnCompras.DragEnter, btnCenso.DragEnter, btnColaboradores.DragEnter, btnContas_a_Pagar.DragEnter, btnContribuicoes.DragEnter, btnControle_de_Boletins.DragEnter, btnControle_de_Despesas.DragEnter, btnControle_de_Estoque.DragEnter, btnObras_Unidas.DragEnter, btnPlano_Financeiro.DragEnter, btnPonto_de_Venda.DragEnter, btnProtocolo.DragEnter, btnTesouraria.DragEnter, btnUnidades.DragEnter
        ObjAux = New Button()
        ObjAux = sender
    End Sub

    Private Sub btnCompras_MouseMove(sender As Object, e As MouseEventArgs) Handles btnCompras.MouseMove, btnCenso.MouseMove, btnColaboradores.MouseMove, btnContas_a_Pagar.MouseMove, btnContribuicoes.MouseMove, btnControle_de_Boletins.MouseMove, btnControle_de_Despesas.MouseMove, btnControle_de_Estoque.MouseMove, btnObras_Unidas.MouseMove, btnPlano_Financeiro.MouseMove, btnPonto_de_Venda.MouseMove, btnProtocolo.MouseMove, btnTesouraria.MouseMove, btnUnidades.MouseMove
        If MouseIsDown Then
            btnCompras.DoDragDrop(btnCompras, DragDropEffects.Copy)
            lDrop = True
        End If
    End Sub

    Private Sub btnCompras_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCompras.MouseDown, btnCenso.MouseDown, btnColaboradores.MouseDown, btnContas_a_Pagar.MouseDown, btnContribuicoes.MouseDown, btnControle_de_Boletins.MouseDown, btnControle_de_Despesas.MouseDown, btnControle_de_Estoque.MouseDown, btnObras_Unidas.MouseDown, btnPlano_Financeiro.MouseDown, btnPonto_de_Venda.MouseDown, btnProtocolo.MouseDown, btnTesouraria.MouseDown, btnUnidades.MouseDown
        MouseIsDown = True
        'OrganizaButtons()
    End Sub

    Private Sub btnCompras_MouseLeave(sender As Object, e As EventArgs) Handles btnCompras.MouseLeave, btnCenso.MouseLeave, btnColaboradores.MouseLeave, btnContas_a_Pagar.MouseLeave, btnContribuicoes.MouseLeave, btnControle_de_Boletins.MouseLeave, btnControle_de_Despesas.MouseLeave, btnControle_de_Estoque.MouseLeave, btnObras_Unidas.MouseLeave, btnPlano_Financeiro.MouseLeave, btnPonto_de_Venda.MouseLeave, btnProtocolo.MouseLeave, btnTesouraria.MouseLeave, btnUnidades.MouseLeave
        If lDrop Then
            MouseIsDown = False
            OrganizaButtons()
            lDrop = False
        End If
    End Sub

    Private Sub btnCenso_MouseClick(sender As Object, e As MouseEventArgs) Handles btnCenso.MouseClick, btnColaboradores.MouseClick, btnCompras.MouseClick, btnContas_a_Pagar.MouseClick, btnContribuicoes.MouseClick, btnControle_de_Boletins.MouseClick, btnControle_de_Despesas.MouseClick, btnControle_de_Estoque.MouseClick, btnObras_Unidas.MouseClick, btnPlano_Financeiro.MouseClick, btnPonto_de_Venda.MouseClick, btnProtocolo.MouseClick, btnTesouraria.MouseClick, btnUnidades.MouseClick
        ObjAux = New Button()
        ObjAux = sender
        MsgBox("Em desenvolvimento")
    End Sub

    Private Sub Rich_Enter(sender As Object, e As EventArgs) Handles RichTextBox1.DragEnter, RichTextBox1.Enter
        'ObjAux = New GroupBox()
        'ObjAux = GroupBox1
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Form1_DragLeave(sender As Object, e As EventArgs) Handles MyBase.DragLeave
        If Not IsNothing(ObjAux) Then
            Dim a As Cursor = New Cursor(Cursor.Current.Handle)

            ObjAux.Location = New Point(Cursor.Position.X - Me.Location.X - nCursorX, Cursor.Position.Y - Me.Location.X - nCursorY)
        End If
    End Sub

    Private Sub SairToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub ConfiguraçõesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraçõesToolStripMenuItem.Click
        Dim frmConfig As frmConfiguracao

        frmConfig = New frmConfiguracao()
        frmConfig.ShowDialog()
    End Sub

    Private Sub mnuPermissao_Acesso_Click(sender As Object, e As EventArgs) Handles menuPermissao_Acesso.Click
        Dim formAcesso As frmAcessos

        formAcesso = New frmAcessos()
        formAcesso.ShowDialog()

    End Sub

    Public Sub AtualizarTam(ByVal nTam As Integer, ByRef but As Button)
        If nTam = 0 Then
            but.Size = New Size(87, 60)
        ElseIf nTam = 1 Then
            but.Size = New Size(173, 79)
        ElseIf nTam = 2 Then
            but.Size = New Size(225, 120)
        End If
    End Sub

    Public Function ResgatarTamanho() As Integer
        If btnUnidades.Size.Width = 87 Then
            Return 0
        ElseIf btnUnidades.Size.Width = 173 Then
            Return 1
        ElseIf btnUnidades.Size.Width = 225 Then
            Return 2
        Else
            Return 0
        End If
    End Function

    Public Function GetWidth() As Integer
        If nTamanho = 0 Then
            Return 87
        ElseIf nTamanho = 1 Then
            Return 173
        ElseIf nTamanho = 2 Then
            Return 225
        Else
            Return 0
        End If
    End Function

    Public Sub AtualizarCor(ByVal nCor As Integer, ByRef but As Button)
        Select Case nCor
            Case 0
                Me.BackColor = SystemColors.Control
                but.BackColor = SystemColors.Control
            Case 1
                Me.BackColor = SystemColors.ControlLight
                but.BackColor = SystemColors.ControlLight
            Case 2
                Me.BackColor = SystemColors.ControlDark
                but.BackColor = SystemColors.ControlDark
            Case 3
                Me.BackColor = SystemColors.ControlDarkDark
                but.BackColor = SystemColors.ControlDarkDark
            Case 4
                Me.BackColor = SystemColors.Window
                but.BackColor = SystemColors.Window
            Case 5
                Me.BackColor = SystemColors.InactiveCaption
                but.BackColor = SystemColors.InactiveCaption
            Case 6
                Me.BackColor = Color.LightGreen
                but.BackColor = Color.LightGreen
            Case 7
                Me.BackColor = Color.DarkSeaGreen
                but.BackColor = Color.DarkSeaGreen
        End Select
    End Sub

    Public Function ResgatarCodigoCor() As Integer

        If Me.BackColor = SystemColors.Control Then
            Return 0
        ElseIf Me.BackColor = SystemColors.ControlLight Then
            Return 1
        ElseIf Me.BackColor = SystemColors.ControlDark Then
            Return 2
        ElseIf Me.BackColor = SystemColors.ControlDarkDark Then
            Return 3
        ElseIf Me.BackColor = SystemColors.Window Then
            Return 4
        ElseIf Me.BackColor = SystemColors.InactiveCaption Then
            Return 5
        ElseIf Me.BackColor = Color.LightGreen Then
            Return 6
        ElseIf Me.BackColor = Color.DarkSeaGreen Then
            Return 7
        Else
            Return 1
        End If

    End Function

    Protected Sub OrganizaButtons()
        If Not IsNothing(ObjAux) Then
            Dim nPosicaoX As Integer = ObjAux.Location.X
            Dim nPosicaoY As Integer = ObjAux.Location.Y
            Dim nSpace As Integer = GetWidth()
            Dim nColuna As Integer = nAreaInicial
            Dim nLoop As Integer
            Dim nGapX As Integer = 150
            Dim nGapY As Integer = 100

            'Definir A posição X
            For nLoop = nGapX To 1200 Step nGapX
                If nPosicaoX < nLoop Then
                    nPosicaoX = nLoop
                    Exit For
                End If
            Next

            'Definir a posição Y
            For nLoop = nGapY To 1200 Step nGapY
                If nPosicaoY < nLoop Then
                    nPosicaoY = nLoop
                    Exit For
                End If
            Next

            ObjAux.Location = New Point(nPosicaoX, nPosicaoY)

            'While (nLoop <= 6) 'Limite de 10 colunas
            'If (nPosicaoX + nSpace >= nColuna And nPosicaoX <= nColuna + nSpace) Then
            'ObjAux.Location = New Point(nColuna, nPosicaoY)
            'Exit While
            'End If '
            'nColuna += nSpace + 10
            'nLoop += 1
            'End While

            ObjAux = Nothing
        End If
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub menu_CadastroDeUsuarios_Click(sender As Object, e As EventArgs) Handles menu_CadastroDeUsuarios.Click
        '?? Alterar os parâmetros para passar ao Browse (Entudade e Form. do Cadastro) ??
        Dim frmBrowse_Usuario As frmBrowse = New frmBrowse("ESI000", "frmUsuario")

        frmBrowse_Usuario.MdiParent = Me
        frmBrowse_Usuario.Tag = menu_CadastroDeUsuarios.Tag 'é gravado no tag do menu o nível de acesso
        frmBrowse_Usuario.Text = menu_CadastroDeUsuarios.Text
        frmBrowse_Usuario.Show()
    End Sub

    Private Sub btnCompras_Click(sender As Object, e As EventArgs)

    End Sub
End Class
