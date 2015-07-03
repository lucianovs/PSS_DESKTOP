Imports Microsoft.VisualBasic.Interaction
Imports System.Windows.Forms
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.IO

Public Class mdiDesktop
    Public nTamanho As Integer = 1
    Public nCor As Integer = 0
    Public ObjAux As Button
    Private nCursorX As Integer = 47 'Correção da localização para o dragdrop
    Private nCursorY As Integer = 70 'Correção da localização para o dragdrop
    Private MouseIsDown As Boolean
    Private nAreaInicial As Integer = 327 '437
    Private nAreaFinal As Integer = 13
    Private lDrop As Boolean = False
    Private sMensagemVPN As String = ""

    Dim bPingVPN As Boolean
    Dim bUsarVPN As Boolean = IIf(LerDadosINI(nomeArquivoINI(), "VPN", "Ativar", "nao") = "nao", False, True)
    'Colocar o default da seção acima para false no arquivo ini, qdo for compilar no conselho

    'Private Sub mdiDesktop_Activated(sender As Object, e As EventArgs) Handles Me.Activated
    'g_Modulo = "Desktop" 'manter a variável global
    'End Sub

    Private Sub mdiDesktop_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        If g_ConnectBanco.state = 1 Then
            g_ConnectBanco.close()
        End If

    End Sub

    Private Sub mdiDesktop_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim myprocesses As Process()
        Dim nCod_Login As Integer
        Dim nTamanho As Integer
        Dim sModulo As String

        If g_Login = "" Then Exit Sub

        'Conectar com o Banco de dados
        If Not ConectarBanco() Then Exit Sub

        nCod_Login = getCodUsuario(ClassCrypt.Decrypt(g_Login))
        nTamanho = ResgatarTamanho()

        For Each _control As Object In Me.Controls
            If TypeOf (_control) Is Button Then
                If Mid(_control.Name.ToString, 1, 3) = "btn" Then
                    If _control.visible Then
                        'Verificar se existe algum módulo ativo
                        sModulo = Microsoft.VisualBasic.Right(_control.name, Microsoft.VisualBasic.Len(_control.name) - 3)
                        myprocesses = Process.GetProcessesByName(sModulo)
                        If myprocesses.Length > 0 Then
                            MsgBox("Favor fechar todos os módulos antes de encerrar a aplicação!!")
                            e.Cancel = True
                            Exit For
                        ElseIf Not GravarConfigIcones(nCod_Login, getCodOpcao(0, Trim(_control.name), ""), _
                                nTamanho, _control.location.x, _control.location.y, nCor) Then
                            MsgBox("Erro ao Gravar as configurações da Tela. Favor verificar com o Administrador !!!")
                        End If
                    End If
                End If
            End If
        Next

    End Sub

    Private Sub mdiDesktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sDirVPN As String = LerDadosINI(nomeArquivoINI(), "VPN", "DIR", "%Roaming%\Microsoft\Network\Connections\Pbk")
        Dim sNomeArqVPN As String = LerDadosINI(nomeArquivoINI(), "VPN", "ARQ", "rasphone.Pbk")
        Dim sDirAppUser As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim nTimer As Integer = 1 'Para limitar a recarga em 3

        sDirVPN = Replace(LCase(sDirVPN), "%roaming%", sDirAppUser)

        g_Modulo = "Desktop" 'Módulo Principal

        'Seção para poder executar novamente a carga do formulário, quando VPN for reconectada
ProcessoInicial:
        If bUsarVPN Then
            '***************
            For i = 1 To 5
                bPingVPN = PingVPN("192.168.2.1")
                If bPingVPN Then
                    Exit For
                Else
                    Threading.Thread.Sleep(1000) 'Delay de 1 segundo)
                End If
            Next
            '***************
        Else
            bPingVPN = True
        End If

        If bPingVPN Then
            Me.Enabled = False
            Me.Hide()

            LoginForm.Show(Me)

            LoginForm.UsernameTextBox.Focus()
        Else
            If MsgBox("Erro: " & sMensagemVPN & Chr(13) & _
                    "É possível que a VPN esteja desativada." & Chr(13) & _
                    "Deseja conectar com a VPN agora?", vbYesNo) = vbYes Then
                Try
                    Dim startInfo2 As New ProcessStartInfo(sDirVPN & "\" & sNomeArqVPN)
                    startInfo2.WindowStyle = ProcessWindowStyle.Normal
                    Process.Start(startInfo2)
                Catch
                    MsgBox(Err.Description)
                Finally
                    bPingVPN = True
                    nTimer += 1
                End Try
                If bPingVPN And nTimer < 4 Then
                    MsgBox("Clique em OK após digitar suas credenciais e conectar na VPN para reiniciar o sistema.")
                    GoTo ProcessoInicial
                Else
                    MsgBox("Foi executado 3 Tentativas de conexão com o servidor do CNB. " & _
                        "Favor verificar suas conexões e tente mais tarde")
                End If
            End If

            Me.Close()
            Application.Exit()
        End If

    End Sub

    Private Function PingVPN(fIPNum As String) As Boolean
        Dim PingSender As New Ping

        Try
            Dim reply As PingReply = PingSender.Send(fIPNum)

            If (reply.Status = IPStatus.Success) Then
                Return True
            Else
                sMensagemVPN = "O Servidor do CNB não está respondendo. Possíveis causas:" & Chr(13) & _
                    "1 - Você está sem Internet;" & Chr(13) & _
                    "2 - A VPN não está conectada;" & Chr(13) & _
                    "3 - A rede do CNB está offline."
                Return False
            End If

            Return True
        Catch err As Exception
            sMensagemVPN = "O Servidor do CNB não está respondendo. Possíveis causas:" & Chr(13) & _
                   "1 - Está sem Internet na sua rede;" & Chr(13) & _
                   "2 - A VPN não está conectada;" & Chr(13) & _
                   "3 - A rede do CNB está off line."
            Return False
        End Try

    End Function

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub mdiDesktop_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        g_Modulo = "Desktop"
    End Sub

    Private Sub mdiDesktop_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip1.Show(e.X, e.Y)
        End If

    End Sub

    Private Sub btnUnidades_DoubleClick(sender As Object, e As EventArgs) Handles btnUnidades.DoubleClick

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

    Private Sub menu_CadastroDeUsuarios_Click(sender As Object, e As EventArgs) Handles menuUsuarios.Click
        '?? Alterar os parâmetros para passar ao Browse (Entidade e Form. do Cadastro) ??
        Dim sWhere As String = "SI000_STAUSU<>'E'"
        Dim nCodigoUsu As Integer = getCodUsuario(ClassCrypt.Decrypt(g_Login))

        If Not UsuarioAdministrador(nCodigoUsu) Then
            sWhere += " and SI000_CODUSU=" & nCodigoUsu.ToString
        End If

        Dim frmBrowse_Usuario As frmBrowse = New frmBrowse("ESI000", "frmUsuario", , sWhere)

        'frmBrowse_Usuario.MdiParent = Me
        frmBrowse_Usuario.Tag = menuUsuarios.Tag 'é gravado no tag do menu o nível de acesso
        frmBrowse_Usuario.Text = menuUsuarios.Text
        frmBrowse_Usuario.Show(Me)
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

    Private Sub menuConfiguracoes_Click(sender As Object, e As EventArgs) Handles menuConfiguracoes.Click
        Dim ChildForm As New Parametros

        'ChildForm.MdiParent = Me
        ChildForm.Tag = menuConfiguracoes.Tag 'é gravado no tag do menu o nível de acesso
        ChildForm.Show(Me)

    End Sub

    Private Sub AlterarSenhaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlterarSenhaToolStripMenuItem.Click
        Dim ChildForm As New frmAltSenha

        g_Param(1) = ClassCrypt.Decrypt(g_Login)

        'ChildForm.MdiParent = Me
        ChildForm.Show(Me)
    End Sub


    Private Sub menuCadastroDeGrupos_Click(sender As Object, e As EventArgs) Handles menuCadastroDeGrupos.Click
        '?? Alterar os parâmetros para passar ao Browse (Entudade e Form. do Cadastro) ??
        Dim frmBrowse_Grupo As frmBrowse = New frmBrowse("ESI001", "frmGrupo")

        'frmBrowse_Usuario.MdiParent = Me
        frmBrowse_Grupo.Tag = menuCadastroDeGrupos.Tag 'é gravado no tag do menu o nível de acesso
        frmBrowse_Grupo.Text = menuCadastroDeGrupos.Text
        frmBrowse_Grupo.Show(Me)

    End Sub

    Private Sub btnUnidades_Click(sender As Object, e As EventArgs) Handles btnUnidades.Click, btnCenso.Click, btnAssociados.Click
        Dim myprocesses As Process()

        ObjAux = New Button()
        ObjAux = sender

        '& ClassCrypt.Decrypt(g_Login)
        'Application.StartupPath & 
        Dim s As String = ""
        'O Programa a ser executado, o Nome do Objeto sem o "btn" inicial Ex.: btnUnidades (Unidades.exe)
        Dim sModulo As String = Microsoft.VisualBasic.Right(ObjAux.Name, Microsoft.VisualBasic.Len(ObjAux.Name) - 3)

        s = Application.StartupPath & "\" & UCase(sModulo) & ".EXE"
        If My.Computer.FileSystem.FileExists(s) Then
            'If Not Dir(s) = "" Then
            'Verificar se o Programa está aberto
            myprocesses = Process.GetProcessesByName(sModulo)
            If myprocesses.Length = 0 Then
                'Process.Start(s & " -" & g_Login & "-")
                s = """" & s & """ -" & g_Login & "-"
                Shell(s, , True, 1000)
                'Shell(sModulo & ".exe -" & g_Login & "-", , True, 1000)
            Else
                MsgBox("Este módulo se encontra aberto no sistema!!")
            End If
        Else
            MsgBox("O Módulo não foi encontrado. Contactar o administrador do sistema.")
        End If

    End Sub

    Private Sub treeview_Mural_DoubleClick(sender As Object, e As EventArgs) Handles treeview_Mural.DoubleClick
        Dim nPos As Integer
        Dim nCodMural As Integer

        nPos = InStr(1, treeview_Mural.SelectedNode.FullPath, "|", CompareMethod.Text) 'Data
        nPos = InStr(nPos + 1, treeview_Mural.SelectedNode.FullPath, "|", CompareMethod.Text) 'Mensagem
        nCodMural = CInt(Trim(Microsoft.VisualBasic.Right(treeview_Mural.SelectedNode.FullPath,
                        Len(treeview_Mural.SelectedNode.FullPath) - nPos)))
        'MsgBox(nCodMural.ToString)

        Dim frmBrowse_Mural As frmBrowse = New frmBrowse("ESI007", "frmMural", "inner join ESI008 on ESI008.SI008_CODMUR=ESI007.SI007_CODMUR", _
                                                    "ESI008.SI008_CODUSU=" & getCodUsuario(ClassCrypt.Decrypt(g_Login)).ToString & _
                                                    " AND ESI007.SI007_CODMUR=" & nCodMural.ToString)

        frmBrowse_Mural.Tag = 4 'menuUsuarios.Tag 'é gravado no tag do menu o nível de acesso
        frmBrowse_Mural.Text = "Mural de Mensagens" 'menuUsuarios.Text
        frmBrowse_Mural.Show(Me)

    End Sub

    Private Sub timerSetup_Tick(sender As Object, e As EventArgs) Handles timerSetup.Tick

        'Desabilitar o Timer
        timerSetup.Enabled = False

        'Verificar se existe Atualizações
        Dim bUpdate As Boolean = False

        If bUsarVPN Then
            'Ler os arquivos executáveis no diretório
            Dim DirServer As DirectoryInfo = New DirectoryInfo("\\192.168.2.1\publicos\App_SSVP")
            Dim oFileInfoCollectionServer() As FileInfo
            Dim oFileInfoServer As FileInfo

            Dim DirLocal As DirectoryInfo = New DirectoryInfo(Application.StartupPath)
            Dim oFileInfoCollectionLocal() As FileInfo
            Dim oFileInfoLocal As FileInfo

            Dim sFileName As String
            Dim i, j, nPos As Integer

            oFileInfoCollectionLocal = DirLocal.GetFiles("*.exe")

            'Ler cada arquivo exe do diretório do Servidor
            For i = 0 To oFileInfoCollectionLocal.Length() - 1
                oFileInfoLocal = oFileInfoCollectionLocal.GetValue(i)
                'Verificar se é o arquivo vshot (tem dois pontos)
                nPos = InStr(1, oFileInfoLocal.Name, ".", vbTextCompare)
                nPos = InStr(nPos + 1, oFileInfoLocal.Name, ".", vbTextCompare)
                If nPos = 0 And Microsoft.VisualBasic.Left(LCase(oFileInfoLocal.Name), 7) <> "desktop" Then 'é o módulo Principal, não Verificar
                    'Ler o Arquivo no servidor
                    oFileInfoCollectionServer = DirServer.GetFiles(oFileInfoLocal.Name)
                    If oFileInfoCollectionServer.Length() > 0 Then 'Verificar se foi encontrado
                        'For k = 0 To oFileInfoCollectionServer.Length() - 1
                        'oFileInfoServer = oFileInfoCollectionServer.GetValue(k)
                        'If oFileInfoServer.Name = oFileInfoLocal.Name Then
                        ' Exit For
                        'end If
                        'Next k
                        oFileInfoServer = oFileInfoCollectionServer.GetValue(0)
                        'MsgBox(oFileInfoServer.Name & " Dt:" & Format(oFileInfoServer.LastWriteTime, "dd/MM/yy HH:mm:ss") & oFileInfoLocal.Name & " Local:" & Format(oFileInfoLocal.LastWriteTime, "dd/MM/yy HH:mm:ss"))

                        'Comparar a data de criação
                        If oFileInfoServer.LastWriteTime <> oFileInfoLocal.LastWriteTime Then
                            'MsgBox("Atualizar")
                            If Not bUpdate Then
                                bUpdate = MsgBox("Deseja atualizar o sistema da SSVP agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = vbYes
                                If Not bUpdate Then
                                    Exit Sub
                                End If
                            End If

                            'Atualizar Arquivos
                            'Separar o nome do arquivo, sem extensão
                            nPos = InStr(1, oFileInfoLocal.Name, ".", vbTextCompare)
                            sFileName = Microsoft.VisualBasic.Left(oFileInfoLocal.Name, nPos - 1)

                            'Ler os Arquivos do módulo no servidor
                            oFileInfoCollectionServer = DirServer.GetFiles(sFileName & "*.*")

                            'carregar o Painel de Acompanhamento
                            grpBoxUpdate.Visible = True

                            ProgressBarUpdate.Minimum = 0
                            ProgressBarUpdate.Maximum = oFileInfoCollectionServer.Length()
                            ProgressBarUpdate.Value = 0
                            For j = 0 To oFileInfoCollectionServer.Length() - 1
                                lblSetup.Text = "Copiando Arquivo ... " & oFileInfoServer.Name
                                lblSetup.Refresh()

                                ProgressBarUpdate.Value += 1
                                ProgressBarUpdate.Refresh()
                                grpBoxUpdate.Refresh()
                                Application.DoEvents()

                                oFileInfoServer = oFileInfoCollectionServer.GetValue(j)
                                'MsgBox(oFileInfoServer.DirectoryName & "\" & oFileInfoServer.Name & " -> " & Application.StartupPath & "\" & oFileInfoServer.Name)
                                System.IO.File.Copy(oFileInfoServer.DirectoryName & "\" & oFileInfoServer.Name, Application.StartupPath & "\" & oFileInfoServer.Name, True)
                            Next
                            'Else
                            'MsgBox("Não Atualizar")
                        End If
                    End If
                End If
            Next

            'Atualizar os manuais do usuário
            oFileInfoCollectionLocal = DirLocal.GetFiles("*.pdf")
            'Ler cada arquivo RPT do diretório do Servidor
            For i = 0 To oFileInfoCollectionLocal.Length() - 1
                oFileInfoLocal = oFileInfoCollectionLocal.GetValue(i)
                'Ler o Arquivo no servidor
                oFileInfoCollectionServer = DirServer.GetFiles(oFileInfoLocal.Name)
                If oFileInfoCollectionServer.Length() > 0 Then 'Verificar se foi encontrado
                    oFileInfoServer = oFileInfoCollectionServer.GetValue(0)

                    'Comparar a data de criação
                    If oFileInfoServer.LastWriteTime <> oFileInfoLocal.LastWriteTime Then
                        If Not bUpdate Then
                            bUpdate = MsgBox("Deseja atualizar o sistema da SSVP agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = vbYes
                            If Not bUpdate Then
                                Exit Sub
                            End If
                        End If

                        'Atualizar Arquivos
                        'Separar o nome do arquivo, sem extensão
                        nPos = InStr(1, oFileInfoLocal.Name, ".", vbTextCompare)
                        sFileName = Microsoft.VisualBasic.Left(oFileInfoLocal.Name, nPos - 1)

                        'Ler os Arquivos do módulo no servidor
                        oFileInfoCollectionServer = DirServer.GetFiles(sFileName & "*.*")

                        'carregar o Painel de Acompanhamento
                        grpBoxUpdate.Visible = True

                        ProgressBarUpdate.Minimum = 0
                        ProgressBarUpdate.Maximum = oFileInfoCollectionServer.Length()
                        ProgressBarUpdate.Value = 0
                        For j = 0 To oFileInfoCollectionServer.Length() - 1
                            lblSetup.Text = "Copiando Arquivo ... " & oFileInfoServer.Name
                            lblSetup.Refresh()

                            ProgressBarUpdate.Value += 1
                            ProgressBarUpdate.Refresh()
                            grpBoxUpdate.Refresh()
                            Application.DoEvents()

                            oFileInfoServer = oFileInfoCollectionServer.GetValue(j)
                            'MsgBox(oFileInfoServer.DirectoryName & "\" & oFileInfoServer.Name & " -> " & Application.StartupPath & "\" & oFileInfoServer.Name)
                            System.IO.File.Copy(oFileInfoServer.DirectoryName & "\" & oFileInfoServer.Name, oFileInfoLocal.DirectoryName & "\" & oFileInfoServer.Name, True)
                        Next
                    End If
                End If
            Next

            'Atualizar os Relatórios
            DirLocal = New DirectoryInfo(Application.StartupPath & "\reports")
            DirServer = New DirectoryInfo("\\192.168.2.1\publicos\App_SSVP\reports")

            oFileInfoCollectionLocal = DirLocal.GetFiles("*.rpt")

            'Ler cada arquivo RPT do diretório do Servidor
            For i = 0 To oFileInfoCollectionLocal.Length() - 1
                oFileInfoLocal = oFileInfoCollectionLocal.GetValue(i)
                'Ler o Arquivo no servidor
                oFileInfoCollectionServer = DirServer.GetFiles(oFileInfoLocal.Name)
                If oFileInfoCollectionServer.Length() > 0 Then 'Verificar se foi encontrado
                    oFileInfoServer = oFileInfoCollectionServer.GetValue(0)

                    'Comparar a data de criação
                    If oFileInfoServer.LastWriteTime <> oFileInfoLocal.LastWriteTime Then
                        'MsgBox("Atualizar")
                        If Not bUpdate Then
                            bUpdate = MsgBox("Deseja atualizar o sistema da SSVP agora?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = vbYes
                            If Not bUpdate Then
                                Exit Sub
                            End If
                        End If

                        'Atualizar Arquivos
                        'Separar o nome do arquivo, sem extensão
                        nPos = InStr(1, oFileInfoLocal.Name, ".", vbTextCompare)
                        sFileName = Microsoft.VisualBasic.Left(oFileInfoLocal.Name, nPos - 1)

                        'Ler os Arquivos do módulo no servidor
                        oFileInfoCollectionServer = DirServer.GetFiles(sFileName & "*.*")

                        'carregar o Painel de Acompanhamento
                        grpBoxUpdate.Visible = True

                        ProgressBarUpdate.Minimum = 0
                        ProgressBarUpdate.Maximum = oFileInfoCollectionServer.Length()
                        ProgressBarUpdate.Value = 0
                        For j = 0 To oFileInfoCollectionServer.Length() - 1
                            lblSetup.Text = "Copiando Arquivo ... " & oFileInfoServer.Name
                            lblSetup.Refresh()

                            ProgressBarUpdate.Value += 1
                            ProgressBarUpdate.Refresh()
                            grpBoxUpdate.Refresh()
                            Application.DoEvents()

                            oFileInfoServer = oFileInfoCollectionServer.GetValue(j)
                            'MsgBox(oFileInfoServer.DirectoryName & "\" & oFileInfoServer.Name & " -> " & Application.StartupPath & "\" & oFileInfoServer.Name)
                            System.IO.File.Copy(oFileInfoServer.DirectoryName & "\" & oFileInfoServer.Name, oFileInfoLocal.DirectoryName & "\" & oFileInfoServer.Name, True)
                        Next
                    End If
                End If
            Next

        End If
        grpBoxUpdate.Visible = False

        'MsgBox("Seu Sistema está atualizado !")

    End Sub

    Private Sub Manual_Click(sender As Object, e As EventArgs) Handles Manual.Click

        Process.Start(Application.ProductName & ".pdf")

    End Sub

    Private Sub Sobre_Click(sender As Object, e As EventArgs) Handles Sobre.Click
        Dim frmSobre As frmSobre = New frmSobre

        'frmSobre.MdiParent = Me
        frmSobre.Text = Sobre.Text
        frmSobre.Show()
    End Sub
End Class
