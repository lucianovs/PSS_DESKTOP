Imports System.Data.OleDb

Public Class frmAcessos
    Dim nCodGrupo As Integer
    Dim nCodUsu As Integer
    Dim nCodModulo As Integer
    Dim nCodOpcao As Integer
    Dim cQuery As String

    Dim dtUsuarios As DataTable = New DataTable("ESI000")
    Dim dtGrupos As DataTable = New DataTable("ESI001")
    Dim dtOpcoes As DataTable = New DataTable("ESI003")
    Dim dtAcesso As DataTable = New DataTable("ESI002")
    Dim dtModulos As DataTable = New DataTable("ESI004")

    Private Sub frmAcessos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        g_ConnectBanco.close()
    End Sub

    Private Sub frmAcessos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i_node, i As Integer

        Dim nodo_level1 As TreeNode
        Dim nodo As TreeNode

        'Conectar com o Banco de dados
        If Not ConectarBanco() Then
            Me.Close()
        End If

        'treeView_Acessos.Nodes.Add("GRUPOS", "GRUPOS", 2, 2)
        nodo_level1 = treeView_Acessos.Nodes.Add("GRUPOS", "GRUPOS", 2, 2)
        i_node = 0

        'Montar a Arvore do TreeView - Grupos
        cQuery = "SELECT SI001_CODGRU, SI001_DESGRU FROM ESI001 order by SI001_DESGRU"
        Using da As New OleDbDataAdapter()
            da.SelectCommand = New OleDbCommand(cQuery, g_ConnectBanco)

            ' Preencher o DataTable 
            da.Fill(dtGrupos)
            If dtGrupos.Rows.Count() > 0 Then
                For i = 0 To dtGrupos.Rows.Count() - 1
                    nodo_level1.Nodes.Add(dtGrupos.Rows(i).Item("SI001_CODGRU").ToString, dtGrupos.Rows(i).Item("SI001_DESGRU").ToString, 0)
                    'treeView_Acessos.Nodes.Add(dtGrupos.Rows(i).Item("SI001_CODGRU").ToString, dtGrupos.Rows(i).Item("SI001_DESGRU").ToString, 0)
                    'i_node += 1

                    'Ler Os módulos cadastrados
                    cQuery = "Select SI004_CODMOD, SI004_DESMOD FROM ESI004 order by SI004_DESMOD"
                    Using daModulo As New OleDbDataAdapter()
                        daModulo.SelectCommand = New OleDbCommand(cQuery, g_ConnectBanco)

                        daModulo.Fill(dtModulos)
                        For i_mod = 0 To dtModulos.Rows.Count() - 1
                            'nodo = treeView_Acessos.Nodes(i_node).Nodes.Add(dtModulos.Rows(i_mod).Item("SI004_CODMOD").ToString, _
                            '            dtModulos.Rows(i_mod).Item("SI004_DESMOD"), 0)
                            nodo = nodo_level1.Nodes(i_node).Nodes.Add(dtModulos.Rows(i_mod).Item("SI004_CODMOD").ToString, _
                                        dtModulos.Rows(i_mod).Item("SI004_DESMOD"), 0)
                            'i_node += 1
                            'Ler as Opções deste Módulos
                            cQuery = "SELECT SI003_CODOPC, SI003_DESOPC FROM ESI003 WHERE SI003_CODMOD=" & _
                                dtModulos.Rows(i_mod).Item("SI004_CODMOD").ToString & " order by SI003_DESOPC"
                            Using daOpcao As New OleDbDataAdapter()
                                daOpcao.SelectCommand = New OleDbCommand(cQuery, g_ConnectBanco)

                                daOpcao.Fill(dtOpcoes)
                                For i_Opcao = 0 To dtOpcoes.Rows.Count() - 1

                                    nodo.Nodes.Add(dtOpcoes.Rows(i_Opcao).Item("SI003_CODOPC").ToString, _
                                               dtOpcoes.Rows(i_Opcao).Item("SI003_DESOPC"), 1, 4)

                                Next
                            End Using
                            dtOpcoes.Clear()
                        Next
                        i_node += 1
                    End Using
                    dtModulos.Clear()
                Next
            End If
        End Using
        dtGrupos.Clear()

        'treeView_Acessos.Nodes.Add("USUÁRIOS", "USUÁRIOS", 3)
        nodo_level1 = treeView_Acessos.Nodes.Add("USUÁRIOS", "USUÁRIOS", 3, 3)
        i_node = 0

        'Montar a Arvore do TreeView - Grupos
        cQuery = "SELECT SI000_CODUSU, SI000_NOMUSU FROM ESI000 order by SI000_NOMUSU"
        Using da As New OleDbDataAdapter()
            da.SelectCommand = New OleDbCommand(cQuery, g_ConnectBanco)

            ' Preencher o DataTable 
            da.Fill(dtUsuarios)
            If dtUsuarios.Rows.Count() > 0 Then
                For i = 0 To dtUsuarios.Rows.Count() - 1
                    'treeView_Acessos.Nodes.Add(dtUsuarios.Rows(i).Item("SI000_CODUSU").ToString, _
                    '        dtUsuarios.Rows(i).Item("SI000_NOMUSU").ToString, 0)
                    nodo_level1.Nodes.Add(dtUsuarios.Rows(i).Item("SI000_CODUSU").ToString, _
                            dtUsuarios.Rows(i).Item("SI000_NOMUSU").ToString, 0)

                    'Ler Os módulos cadastrados
                    cQuery = "Select SI004_CODMOD, SI004_DESMOD FROM ESI004 order by SI004_DESMOD"
                    Using daModulo As New OleDbDataAdapter()
                        daModulo.SelectCommand = New OleDbCommand(cQuery, g_ConnectBanco)

                        daModulo.Fill(dtModulos)
                        For i_mod = 0 To dtModulos.Rows.Count() - 1
                            'nodo = treeView_Acessos.Nodes(i_node).Nodes.Add(dtModulos.Rows(i_mod).Item("SI004_CODMOD").ToString, _
                            '            dtModulos.Rows(i_mod).Item("SI004_DESMOD"), 0)
                            nodo = nodo_level1.Nodes(i_node).Nodes.Add(dtModulos.Rows(i_mod).Item("SI004_CODMOD").ToString, _
                                        dtModulos.Rows(i_mod).Item("SI004_DESMOD"), 0)
                            'Ler as Opções deste Módulos
                            cQuery = "SELECT SI003_CODOPC, SI003_DESOPC FROM ESI003 WHERE SI003_CODMOD=" & _
                                dtModulos.Rows(i_mod).Item("SI004_CODMOD").ToString & " order by SI003_DESOPC"
                            Using daOpcao As New OleDbDataAdapter()
                                daOpcao.SelectCommand = New OleDbCommand(cQuery, g_ConnectBanco)

                                daOpcao.Fill(dtOpcoes)
                                For i_Opcao = 0 To dtOpcoes.Rows.Count() - 1

                                    nodo.Nodes.Add(dtOpcoes.Rows(i_Opcao).Item("SI003_CODOPC").ToString, _
                                               dtOpcoes.Rows(i_Opcao).Item("SI003_DESOPC"), 1, 4)

                                Next
                            End Using
                            dtOpcoes.Clear()
                        Next
                        i_node += 1
                    End Using
                    dtModulos.Clear()
                Next
            End If
        End Using
        dtUsuarios.Clear()

    End Sub

    Private Sub treeView_Acessos_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treeView_Acessos.AfterSelect

        Dim sLevel As String
        Dim sGruUsu As String = ""
        Dim sModulo As String = ""
        Dim sOpcao As String = ""
        Dim nPos As Integer
        Dim nNivelAcesso As Integer

        nPos = InStr(1, treeView_Acessos.SelectedNode.FullPath, "\", CompareMethod.Text)
        If nPos > 0 Then
            sLevel = Mid(treeView_Acessos.SelectedNode.FullPath, 1, nPos - 1)
            nPos = InStr(nPos + 1, treeView_Acessos.SelectedNode.FullPath, "\", CompareMethod.Text)
            If nPos > 0 Then
                sGruUsu = Mid(treeView_Acessos.SelectedNode.FullPath, Len(sLevel) + 2, nPos - Len(sLevel) - 2)
                nPos = InStr(nPos + 1, treeView_Acessos.SelectedNode.FullPath, "\", CompareMethod.Text)
                If nPos > 0 Then
                    sModulo = Mid(treeView_Acessos.SelectedNode.FullPath, Len(sLevel) + Len(sGruUsu) + 3, nPos - Len(sLevel) - Len(sGruUsu) - 3)
                    sOpcao = Mid(treeView_Acessos.SelectedNode.FullPath, nPos + 1, Len(treeView_Acessos.SelectedNode.FullPath) - nPos)
                Else
                    sModulo = Mid(treeView_Acessos.SelectedNode.FullPath, Len(sLevel) + Len(sGruUsu) + 3)
                End If
            Else
                sGruUsu = Mid(treeView_Acessos.SelectedNode.FullPath, Len(sLevel) + 2)
            End If
        Else
            sLevel = treeView_Acessos.SelectedNode.FullPath
        End If

        lblGruUsu.Text = sLevel
        txtGruUsu.Text = sGruUsu
        txtModulo.Text = sModulo
        txtOpcao.Text = sOpcao

        If sOpcao <> "" Then
            cbNivelAcesso.Enabled = True

            'Ler o Código do usuário/Grupo
            If sLevel = "GRUPOS" Then
                nCodUsu = 0
                cQuery = "SELECT SI001_CODGRU, SI001_DESGRU FROM ESI001 where SI001_DESGRU='" & sGruUsu & "'"
                Using da As New OleDbDataAdapter()
                    da.SelectCommand = New OleDbCommand(cQuery, g_ConnectBanco)

                    ' Preencher o DataTable 
                    da.Fill(dtGrupos)
                    If dtGrupos.Rows.Count() > 0 Then
                        nCodGrupo = dtGrupos.Rows(0).Item("SI001_CODGRU")
                    End If
                End Using
                dtGrupos.Clear()
            Else
                nCodGrupo = 0
                cQuery = "SELECT SI000_CODUSU, SI000_NOMUSU FROM ESI000 where SI000_NOMUSU='" & sGruUsu & "'"
                Using da As New OleDbDataAdapter()
                    da.SelectCommand = New OleDbCommand(cQuery, g_ConnectBanco)

                    ' Preencher o DataTable 
                    da.Fill(dtUsuarios)
                    If dtUsuarios.Rows.Count() > 0 Then
                        nCodUsu = dtUsuarios.Rows(0).Item("SI000_CODUSU")
                    End If
                End Using
                dtUsuarios.Clear()
            End If

            'Ler o Código do Módulo
            cQuery = "Select SI004_CODMOD, SI004_DESMOD FROM ESI004 where SI004_DESMOD='" & sModulo & "'"
            Using da As New OleDbDataAdapter()
                da.SelectCommand = New OleDbCommand(cQuery, g_ConnectBanco)

                ' Preencher o DataTable 
                da.Fill(dtModulos)
                If dtModulos.Rows.Count() > 0 Then
                    nCodModulo = dtModulos.Rows(0).Item("SI004_CODMOD")
                End If
            End Using
            dtModulos.Clear()

            'Ler o Código da Opção
            cQuery = "SELECT SI003_CODOPC, SI003_DESOPC FROM ESI003 WHERE SI003_CODMOD=" & _
                nCodModulo.ToString & " and SI003_DESOPC='" & sOpcao & "'"
            Using da As New OleDbDataAdapter()
                da.SelectCommand = New OleDbCommand(cQuery, g_ConnectBanco)

                da.Fill(dtOpcoes)
                If dtOpcoes.Rows.Count() > 0 Then
                    nCodOpcao = dtOpcoes.Rows(0).Item("SI003_CODOPC")
                End If

            End Using
            dtOpcoes.Clear()

            'Ler o Nivel de Acesso 
            cQuery = "SELECT SI002_NIVACE FROM ESI002 WHERE SI002_CODOPC=" & nCodOpcao.ToString
            If nCodGrupo > 0 Then
                cQuery += " and SI002_CODGRU=" & nCodGrupo.ToString
            Else
                cQuery += " and SI002_CODUSU=" & nCodUsu.ToString
            End If
            Using da As New OleDbDataAdapter()
                da.SelectCommand = New OleDbCommand(cQuery, g_ConnectBanco)

                da.Fill(dtAcesso)
                If dtAcesso.Rows.Count() > 0 Then
                    nNivelAcesso = dtAcesso.Rows(0).Item("SI002_NIVACE")
                    cbNivelAcesso.Tag = 1
                Else
                    nNivelAcesso = 0
                    cbNivelAcesso.Tag = 0
                End If
            End Using
            dtAcesso.Clear()

            Select Case nNivelAcesso
                Case 0
                    cbNivelAcesso.Text = "0 – Nenhum Acesso"
                Case 1
                    cbNivelAcesso.Text = "1 – Somente Leitura"
                Case 2
                    cbNivelAcesso.Text = "2 – Leitura e Alteração"
                Case 3
                    cbNivelAcesso.Text = "3 – Acesso Completo (Exlusão com restrições)"
                Case 4
                    cbNivelAcesso.Text = "4 – Acesso Completo"
            End Select
        Else
            cbNivelAcesso.Text = ""
            cbNivelAcesso.Enabled = False
        End If

        btnGravar.Enabled = False

        'MsgBox(treeView_Acessos.Nodes.Item(0).Text)
        'MsgBox(treeView_Acessos.SelectedNode.Nodes)
        'MsgBox(sLevel & Chr(13) & sGruUsu & Chr(13) & sModulo & Chr(13) & sOpcao)

        'MsgBox(treeView_Acessos.Nodes.Item(0).TreeView)
    End Sub

    Private Sub cbNivelAcesso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNivelAcesso.SelectedIndexChanged
        btnGravar.Enabled = True
    End Sub

    Private Sub btnGravar_Click(sender As Object, e As EventArgs) Handles btnGravar.Click
        Dim cSql As String = ""
        Dim cmd As OleDbCommand

        If ConectarBanco() Then
            If cbNivelAcesso.Tag = 1 Then
                'Gravar a Configuração do Icone no Banco para o Usuário
                cSql = "UPDATE ESI002 SET SI002_NIVACE=" & CInt(Mid(cbNivelAcesso.Text, 1, 1)) & _
                    " where SI002_CODUSU=" & nCodUsu.ToString & " and SI002_CODGRU = " & nCodGrupo.ToString & _
                    " and SI002_CODOPC=" & nCodOpcao.ToString
            Else
                cSql = "INSERT INTO ESI002 (SI002_CODGRU, SI002_CODUSU, SI002_CODOPC, SI002_NIVACE) Values (" & _
                        nCodGrupo.ToString & "," & nCodUsu.ToString & "," & nCodOpcao.ToString & _
                        "," & CInt(Mid(cbNivelAcesso.Text, 1, 1)).ToString & ")"
            End If
            cmd = New OleDbCommand(cSql, g_ConnectBanco)

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                cbNivelAcesso.Tag = 1
                btnGravar.Enabled = False
            End Try
        End If

    End Sub

End Class