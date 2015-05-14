Imports System.Data.OleDb

Public Class LoginForm
    Dim bCloseApp As Boolean = True

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim nCod_Login As Integer
        Dim pLocalx As Integer
        Dim pLocalY As Integer
        Dim pTamanho As Integer
        Dim pNivel As Integer
        Dim ChildForm As New Parametros
        Dim ChildForm_AltSenha As New frmAltSenha

        Dim sSqlMural As String
        Dim dtMural As DataTable = New DataTable("ESI007")
        Dim nodo_Level_Mural As TreeNode
        Dim nIndex_Image As Integer

        lblErroLogin.Visible = False

        'Conection String
        g_ConnectString = (LerDadosINI(nomeArquivoINI(), "CONEXAO", "ConnectString", _
            ClassCrypt.Encrypt("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SSVP.accdb;Persist Security Info=False;")))

        'Conectar com o Banco de dados
        If Not ConectarBanco() Then
            If UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "ssvp$00" Then
                'Se houver erro de acesso ao BD, carregar o form Parametro para solicitar o ConnectionString
                ChildForm.Tag = 4 'é gravado no tag do menu o nível de acesso
                ChildForm.Show(Me)
                Exit Sub
            Else
                Application.Exit()
                Exit Sub
            End If
        End If

        'Ler o Usuário e Validar o Acesso
        g_Param(2) = ""
        g_Login = LerUsuario(UsernameTextBox.Text, PasswordTextBox.Text)
        If g_Login <> "" Then
            If g_Param(2) <> "" Then 'Solicitado alteração de senha
                g_Param(1) = g_Login
                ChildForm_AltSenha.Show(Me)
                Exit Sub
            Else
                g_Login = ClassCrypt.Encrypt(g_Login)
                mdiDesktop.Text = "CONSELHO NACIONAL DA SOCIEDADE DE SÃO VICENTE DE PAULO " & _
                                "- Modulo Principal - Usuário: " & ClassCrypt.Decrypt(g_Login)
            End If
        Else
            lblErroLogin.Visible = True
            g_ConnectBanco.close()
            Exit Sub 'Application.Exit()
        End If

        nCod_Login = getCodUsuario(ClassCrypt.Decrypt(g_Login))
        'Verificar o acesso às opções do sistema
        Dim cModulo As Integer = getCodModulo("PRINCIPAL") 'Pegar o código do Módulo
        Dim nCodUsuario As Integer = getCodUsuario(ClassCrypt.Decrypt(g_Login)) 'pegar o código do usuario

        For Each _control As Object In mdiDesktop.Controls
            If TypeOf (_control) Is Button Then
                If Microsoft.VisualBasic.Mid(_control.name, 1, 3) = "btn" Then
                    pNivel = NivelAcesso(nCod_Login, cModulo, _control.Name, "")
                    _control.Visible = pNivel > 0
                    'MsgBox(_control.name & "-" & pNivel.ToString)
                    If pNivel > 0 Then
                        pLocalx = 0
                        pLocalY = 0
                        pTamanho = ConfigIcones(g_Login, _control.name, pLocalx, pLocalY, mdiDesktop.nCor)
                        If Not (pLocalx = 0 And pLocalx = 0) Then
                            mdiDesktop.AtualizarTam(pTamanho, _control)
                            mdiDesktop.AtualizarCor(mdiDesktop.nCor, _control)
                            _control.Location = New System.Drawing.Point(pLocalx, pLocalY)
                        End If
                    End If
                End If
            ElseIf TypeOf (_control) Is ContextMenuStrip Then
                For Each itm As ToolStripMenuItem In _control.items
                    If itm.Text <> "&Sair" And Microsoft.VisualBasic.Mid(_control.name, 1, 4) = "menu" Then
                        itm.Tag = NivelAcesso(nCod_Login, cModulo, itm.Name, "")
                        itm.Enabled = itm.Tag > 0
                        'Função para Verificar os SubItens do menu
                        If itm.DropDownItems.Count > 0 Then LoopMenuItems(itm, nCod_Login, cModulo, itm.Name)
                    End If
                Next
            End If
        Next

        'Configurar o acesso ao menu de configuração
        With mdiDesktop.ContextMenuStrip1.Items
            '  Parametros
            .Item(1).Tag = NivelAcesso(nCod_Login, cModulo, .Item(1).Name, "")
            .Item(1).Enabled = .Item(1).Tag > 3

            '  Permissão de Acesso
            .Item(4).Tag = NivelAcesso(nCod_Login, cModulo, .Item(4).Name, "")
            .Item(4).Enabled = .Item(4).Tag > 3

            '  Cadastro de Grupos
            .Item(5).Tag = NivelAcesso(nCod_Login, cModulo, .Item(5).Name, "")
            .Item(5).Enabled = .Item(5).Tag > 3

            '  Cadastro de Usuarios
            .Item(6).Tag = NivelAcesso(nCod_Login, cModulo, .Item(6).Name, "")
            .Item(6).Enabled = .Item(6).Tag > 3
        End With

        mdiDesktop.treeview_Mural.Nodes.Clear()

        'Preencher o Mural de Mensagens
        sSqlMural = "SELECT ESI007.SI007_CODMUR, ESI007.SI007_DATPUB, ESI007.SI007_MENMUR, ESI007.SI007_STAMUR "
        sSqlMural += "FROM (ESI007 inner join ESI008 on ESI008.SI008_CODMUR=ESI007.SI007_CODMUR) "
        sSqlMural += "WHERE ESI008.SI008_CODUSU=" & nCodUsuario.ToString
        sSqlMural += " ORDER BY ESI007.SI007_DATPUB DESC"
        Using daTabela As New OleDbDataAdapter()
            daTabela.SelectCommand = New OleDbCommand(sSqlMural, g_ConnectBanco)

            'Preencher o DataTable 
            daTabela.Fill(dtMural)
            If dtMural.Rows.Count > 0 Then
                For x = 0 To dtMural.Rows.Count - 1
                    'Status da Mensagem
                    If dtMural.Rows(x).Item("SI007_STAMUR") = "PUBLICADA" Then
                        nIndex_Image = 0
                    ElseIf dtMural.Rows(x).Item("SI007_STAMUR") = "CONCLUIDA" Then
                        nIndex_Image = 2
                    Else
                        nIndex_Image = 1
                    End If
                    nodo_Level_Mural = mdiDesktop.treeview_Mural.Nodes.Add(dtMural.Rows(x).Item("SI007_CODMUR"), _
                        Format(dtMural.Rows(x).Item("SI007_DATPUB"), "dd/MM/yy") & " | " & dtMural.Rows(x).Item("SI007_MENMUR") & _
                        " | " & dtMural.Rows(x).Item("SI007_CODMUR").ToString, nIndex_Image)
                Next
            End If
        End Using
        dtMural.Clear()

        mdiDesktop.Enabled = True
        mdiDesktop.Show()
        bCloseApp = False

        g_ConnectBanco.close()

        mdiDesktop.timerSetup.Enabled = True
        Me.Close()

    End Sub

    Private Function LoopMenuItems(ByVal parent As ToolStripMenuItem, nCodUsuario As Integer, cModulo As Integer, fPrincOpcao As String) As Object
        Dim retval As Object = Nothing

        For Each child As Object In parent.DropDownItems

            'MessageBox.Show("Child : " & child.name)

            If TypeOf (child) Is ToolStripMenuItem Then
                If child.Text <> "Sair" And child.Name.ToString.StartsWith("menu") Then
                    child.Tag = NivelAcesso(nCodUsuario, cModulo, child.Name, fPrincOpcao)
                    child.Enabled = child.Tag > 0
                    If child.DropDownItems.Count > 0 Then
                        retval = LoopMenuItems(child, nCodUsuario, cModulo, child.name)
                        If Not retval Is Nothing Then Exit For
                    End If
                End If
            End If
        Next

        Return retval
    End Function

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

        Me.Close()
        bCloseApp = True

        Application.Exit()

    End Sub

    Protected Overrides Sub Finalize()

        MyBase.Finalize()

    End Sub

    Private Sub LoginForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        If bCloseApp Then
            Application.Exit()
        Else
            'frmDeskTop.AtualizarForm()
        End If

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class
