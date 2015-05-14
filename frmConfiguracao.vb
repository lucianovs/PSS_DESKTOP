Public Class frmConfiguracao
    Dim bStart As Boolean 'Usado para inibir execuções indevidas na inicialização
    Dim bAtualizaON As Boolean

    Private Sub frmConfiguracao_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

        If Trim(cbModulo.Text) <> "" Then
            Select Case e.KeyCode
                Case Is = Keys.Right
                    If nudCol.Value < 4 Then nudCol.Value += 1
                Case Is = Keys.Left
                    If nudCol.Value > 1 Then nudCol.Value -= 1
                Case Is = Keys.Up
                    If nudLin.Value > 1 Then nudLin.Value -= 1
                Case Is = Keys.Down
                    If nudLin.Value < 4 Then nudLin.Value += 1
            End Select
        End If

    End Sub

    Private Sub frmConfiguracao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bAtualizaON = True

        bStart = True
        cbModulo.Items.Clear()
        With mdiDesktop
            If .btnCompras.Visible Then
                btnCompras.Visible = True
                cbModulo.Items.Add("Compras")
                nudCol.Value = CalcularColuna(.btnCompras.Location.X)
                nudLin.Value = CalcularLinha(.btnCompras.Location.Y)
                cbModulo.Text = "Compras"
            End If
            If .btnContribuicoes.Visible Then
                btnContribuicoes.Visible = True
                cbModulo.Items.Add("Contribuições")
                nudCol.Value = CalcularColuna(.btnContribuicoes.Location.X)
                nudLin.Value = CalcularLinha(.btnContribuicoes.Location.Y)
                cbModulo.Text = "Contribuições"
            End If
            If .btnTesouraria.Visible Then
                btnTesouraria.Visible = True
                cbModulo.Items.Add("Tesouraria")

                nudCol.Value = CalcularColuna(mdiDesktop.btnTesouraria.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnTesouraria.Location.Y)
                cbModulo.Text = "Tesouraria"
            End If
            If .btnProtocolo.Visible Then
                btnProtocolo.Visible = True
                cbModulo.Items.Add("Protocolo")

                nudCol.Value = CalcularColuna(mdiDesktop.btnProtocolo.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnProtocolo.Location.Y)
                cbModulo.Text = "Protocolo"
            End If
            If .btnPonto_de_Venda.Visible Then
                btnPonto_de_Venda.Visible = True
                cbModulo.Items.Add("Ponto de Venda")

                nudCol.Value = CalcularColuna(mdiDesktop.btnPonto_de_Venda.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnPonto_de_Venda.Location.Y)
                cbModulo.Text = "Ponto de Venda"
            End If
            If .btnPlano_Financeiro.Visible Then
                btnPlano_Financeiro.Visible = True
                cbModulo.Items.Add("Plano Financeiro")

                nudCol.Value = CalcularColuna(mdiDesktop.btnPlano_Financeiro.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnPlano_Financeiro.Location.Y)
                cbModulo.Text = "Plano Financeiro"
            End If
            If .btnControle_de_Boletins.Visible Then
                btnControle_de_Boletins.Visible = True
                cbModulo.Items.Add("Controle de Boletins")

                nudCol.Value = CalcularColuna(mdiDesktop.btnControle_de_Boletins.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnControle_de_Boletins.Location.Y)
                cbModulo.Text = "Controle de Boletins"
            End If
            If .btnCenso.Visible Then
                btnCenso.Visible = True
                cbModulo.Items.Add("Censo")

                nudCol.Value = CalcularColuna(mdiDesktop.btnCenso.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnCenso.Location.Y)
                cbModulo.Text = "Censo"
            End If
            If .btnContas_a_Pagar.Visible Then
                btnContas_a_Pagar.Visible = True
                cbModulo.Items.Add("Contas a Pagar")

                nudCol.Value = CalcularColuna(mdiDesktop.btnContas_a_Pagar.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnContas_a_Pagar.Location.Y)
                cbModulo.Text = "Contas a Pagar"
            End If
            If .btnObras_Unidas.Visible Then
                btnObras_Unidas.Visible = True
                cbModulo.Items.Add("Obras Unidas")

                nudCol.Value = CalcularColuna(mdiDesktop.btnObras_Unidas.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnObras_Unidas.Location.Y)
                cbModulo.Text = "Obras Unidas"
            End If
            If .btnEstoque.Visible Then
                btnControle_de_Estoque.Visible = True
                cbModulo.Items.Add("Controle de Estoque")

                nudCol.Value = CalcularColuna(mdiDesktop.btnEstoque.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnEstoque.Location.Y)
                cbModulo.Text = "Controle de Estoque"
            End If
            If .btnUnidades.Visible Then
                btnUnidades.Visible = True
                cbModulo.Items.Add("Unidades")

                nudCol.Value = CalcularColuna(mdiDesktop.btnUnidades.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnUnidades.Location.Y)
                cbModulo.Text = "Unidades"
            End If
            If .btnColaboradores.Visible Then
                btnColaboradores.Visible = True
                cbModulo.Items.Add("Colaboradores")

                nudCol.Value = CalcularColuna(mdiDesktop.btnColaboradores.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnColaboradores.Location.Y)
                cbModulo.Text = "Colaboradores"
            End If
            If .btnControle_de_Despesas.Visible Then
                btnControle_de_Despesas.Visible = True
                cbModulo.Items.Add("Controle de Despesas")

                nudCol.Value = CalcularColuna(.btnControle_de_Despesas.Location.X)
                nudLin.Value = CalcularLinha(.btnControle_de_Despesas.Location.Y)
                cbModulo.Text = "Controle de Despesas"
            End If
        End With
        bStart = False
        cbModulo.Sorted = True

    End Sub

    Private Function CalcularY(fLinha As Integer) As Double
        Select Case fLinha
            Case Is = 1
                Return 20
            Case Is = 2
                Return 180
            Case Is = 3
                Return 340
            Case Is = 4
                Return 500
            Case Else
                Return 20
        End Select

    End Function

    Private Function LinGrade(fLinha As Integer) As Double
        Select Case fLinha
            Case Is = 1
                Return 100
            Case Is = 2
                Return 180
            Case Is = 3
                Return 260
            Case Is = 4
                Return 340
            Case Else
                Return 100
        End Select

    End Function

    Private Function CalcularX(fColuna As Integer) As Double
        Select Case fColuna
            Case Is = 1
                Return 425
            Case Is = 2
                Return 655
            Case Is = 3
                Return 885
            Case Is = 4
                Return 1115
            Case Else
                Return 425
        End Select
    End Function

    Private Function ColGrade(fColuna As Integer) As Double
        Select Case fColuna
            Case Is = 1
                Return 460
            Case Is = 2
                Return 600
            Case Is = 3
                Return 740
            Case Is = 4
                Return 880
            Case Else
                Return 460
        End Select
    End Function

    Private Function CalcularLinha(fYps As Integer) As Integer
        Select Case fYps
            Case Is = 20
                Return 1
            Case Is = 180
                Return 2
            Case Is = 340
                Return 3
            Case Is = 500
                Return 4
            Case Else
                Return 1
        End Select
    End Function

    Private Function CalcularColuna(fXis As Integer) As Integer
        Select Case fXis
            Case Is = 425
                Return 1
            Case Is = 655
                Return 2
            Case Is = 885
                Return 3
            Case Is = 1115
                Return 4
            Case Else
                Return 1
        End Select
    End Function

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        Me.Close()
    End Sub

    Private Sub Pequeno_Click(sender As Object, e As EventArgs) Handles Pequeno.Click, Medio.Click, Grande.Click
        mdiDesktop.nTamanho = sender.Tag
        For Each _control As Object In mdiDesktop.Controls
            If TypeOf (_control) Is Button Then
                If Mid(_control.Name.ToString, 1, 3) = "btn" Then
                    If _control.visible Then
                        mdiDesktop.AtualizarTam(mdiDesktop.nTamanho, _control)
                    End If
                End If
            End If
        Next
        mdiDesktop.Refresh()
        Application.DoEvents()
    End Sub

    Private Sub AlterarCor_Click(sender As Object, e As EventArgs) Handles btnCor1.Click, btnCor2.Click, btnCor3.Click, btnCor4.Click, btnCor5.Click, btnCor6.Click, btnCor7.Click, btnCor8.Click
        mdiDesktop.nCor = sender.Tag
        For Each _control As Object In mdiDesktop.Controls
            If TypeOf (_control) Is Button Then
                If Mid(_control.Name.ToString, 1, 3) = "btn" Then
                    If _control.visible Then
                        mdiDesktop.AtualizarCor(mdiDesktop.nCor, _control)
                    End If
                End If
            End If
        Next
        mdiDesktop.Refresh()
        Application.DoEvents()
    End Sub

    Private Sub MudaPosicao()
        Dim nQtdIcon_pos As Integer

        If IsNumeric(nudCol.Value) And IsNumeric(nudLin.Value) Then
            If Int(nudCol.Value) > 0 And Int(nudCol.Value) < 5 And Int(nudLin.Value) > 0 And Int(nudLin.Value) < 5 Then

                Select Case cbModulo.Text
                    Case Is = "Compras"
                        nQtdIcon_pos = VerQtdIcon_Posicao(Int(nudCol.Value), Int(nudLin.Value), "btnCompras")
                        btnCompras.Location = New System.Drawing.Point(CDbl(ColGrade(Int(nudCol.Value)) + nQtdIcon_pos * 5), CDbl(LinGrade(Int(nudLin.Value)) + nQtdIcon_pos * 5))
                        mdiDesktop.btnCompras.Location = New System.Drawing.Point(CDbl(CalcularX(nudCol.Value)), CDbl(CalcularY(nudLin.Value)))
                    Case Is = "Contribuições"
                        nQtdIcon_pos = VerQtdIcon_Posicao(Int(nudCol.Value), Int(nudLin.Value), "btnContribuicoes")
                        btnContribuicoes.Location = New System.Drawing.Point(CDbl(ColGrade(Int(nudCol.Value)) + nQtdIcon_pos * 5), CDbl(LinGrade(Int(nudLin.Value)) + nQtdIcon_pos * 5))
                        mdiDesktop.btnContribuicoes.Location = New System.Drawing.Point(CDbl(CalcularX(nudCol.Value)), CDbl(CalcularY(nudLin.Value)))
                    Case Is = "Tesouraria"
                        nQtdIcon_pos = VerQtdIcon_Posicao(Int(nudCol.Value), Int(nudLin.Value), "btnTesouraria")
                        btnTesouraria.Location = New System.Drawing.Point(CDbl(ColGrade(Int(nudCol.Value)) + nQtdIcon_pos * 5), CDbl(LinGrade(Int(nudLin.Value)) + nQtdIcon_pos * 5))
                        mdiDesktop.btnTesouraria.Location = New System.Drawing.Point(CDbl(CalcularX(nudCol.Value)), CDbl(CalcularY(nudLin.Value)))
                    Case Is = "Protocolo"
                        nQtdIcon_pos = VerQtdIcon_Posicao(Int(nudCol.Value), Int(nudLin.Value), "btnProtocolo")
                        btnProtocolo.Location = New System.Drawing.Point(CDbl(ColGrade(Int(nudCol.Value)) + nQtdIcon_pos * 5), CDbl(LinGrade(Int(nudLin.Value)) + nQtdIcon_pos * 5))
                        mdiDesktop.btnProtocolo.Location = New System.Drawing.Point(CDbl(CalcularX(nudCol.Value)), CDbl(CalcularY(nudLin.Value)))
                    Case Is = "Ponto de Venda"
                        nQtdIcon_pos = VerQtdIcon_Posicao(Int(nudCol.Value), Int(nudLin.Value), "btnPonto_de_Venda")
                        btnPonto_de_Venda.Location = New System.Drawing.Point(CDbl(ColGrade(Int(nudCol.Value)) + nQtdIcon_pos * 5), CDbl(LinGrade(Int(nudLin.Value)) + nQtdIcon_pos * 5))
                        mdiDesktop.btnPonto_de_Venda.Location = New System.Drawing.Point(CDbl(CalcularX(nudCol.Value)), CDbl(CalcularY(nudLin.Value)))
                    Case Is = "Plano Financeiro"
                        nQtdIcon_pos = VerQtdIcon_Posicao(Int(nudCol.Value), Int(nudLin.Value), "btnPlano_Financeiro")
                        btnPlano_Financeiro.Location = New System.Drawing.Point(CDbl(ColGrade(Int(nudCol.Value)) + nQtdIcon_pos * 5), CDbl(LinGrade(Int(nudLin.Value)) + nQtdIcon_pos * 5))
                        mdiDesktop.btnPlano_Financeiro.Location = New System.Drawing.Point(CDbl(CalcularX(nudCol.Value)), CDbl(CalcularY(nudLin.Value)))
                    Case Is = "Controle de Boletins"
                        nQtdIcon_pos = VerQtdIcon_Posicao(Int(nudCol.Value), Int(nudLin.Value), "btnControle_de_Boletins")
                        btnControle_de_Boletins.Location = New System.Drawing.Point(CDbl(ColGrade(Int(nudCol.Value)) + nQtdIcon_pos * 5), CDbl(LinGrade(Int(nudLin.Value)) + nQtdIcon_pos * 5))
                        mdiDesktop.btnControle_de_Boletins.Location = New System.Drawing.Point(CDbl(CalcularX(nudCol.Value)), CDbl(CalcularY(nudLin.Value)))
                    Case Is = "Censo"
                        nQtdIcon_pos = VerQtdIcon_Posicao(Int(nudCol.Value), Int(nudLin.Value), "btnCenso")
                        btnCenso.Location = New System.Drawing.Point(CDbl(ColGrade(Int(nudCol.Value)) + nQtdIcon_pos * 5), CDbl(LinGrade(Int(nudLin.Value)) + nQtdIcon_pos * 5))
                        mdiDesktop.btnCenso.Location = New System.Drawing.Point(CDbl(CalcularX(Int(nudCol.Value))), CDbl(CalcularY(Int(nudLin.Value))))
                    Case Is = "Contas a Pagar"
                        nQtdIcon_pos = VerQtdIcon_Posicao(Int(nudCol.Value), Int(nudLin.Value), "btnContas_a_Pagar")
                        btnContas_a_Pagar.Location = New System.Drawing.Point(CDbl(ColGrade(Int(nudCol.Value)) + nQtdIcon_pos * 5), CDbl(LinGrade(Int(nudLin.Value)) + nQtdIcon_pos * 5))
                        mdiDesktop.btnContas_a_Pagar.Location = New System.Drawing.Point(CDbl(CalcularX(nudCol.Value)), CDbl(CalcularY(nudLin.Value)))
                    Case Is = "Obras Unidas"
                        nQtdIcon_pos = VerQtdIcon_Posicao(Int(nudCol.Value), Int(nudLin.Value), "btnObras_Unidas")
                        btnObras_Unidas.Location = New System.Drawing.Point(CDbl(ColGrade(Int(nudCol.Value)) + nQtdIcon_pos * 5), CDbl(LinGrade(Int(nudLin.Value)) + nQtdIcon_pos * 5))
                        mdiDesktop.btnObras_Unidas.Location = New System.Drawing.Point(CDbl(CalcularX(nudCol.Value)), CDbl(CalcularY(nudLin.Value)))
                    Case Is = "Controle de Estoque"
                        nQtdIcon_pos = VerQtdIcon_Posicao(Int(nudCol.Value), Int(nudLin.Value), "btnControle_de_Estoque")
                        btnControle_de_Estoque.Location = New System.Drawing.Point(CDbl(ColGrade(Int(nudCol.Value)) + nQtdIcon_pos * 5), CDbl(LinGrade(Int(nudLin.Value)) + nQtdIcon_pos * 5))
                        mdiDesktop.btnEstoque.Location = New System.Drawing.Point(CDbl(CalcularX(nudCol.Value)), CDbl(CalcularY(nudLin.Value)))
                    Case Is = "Unidades"
                        nQtdIcon_pos = VerQtdIcon_Posicao(Int(nudCol.Value), Int(nudLin.Value), "btnUnidades")
                        btnUnidades.Location = New System.Drawing.Point(CDbl(ColGrade(Int(nudCol.Value)) + nQtdIcon_pos * 5), CDbl(LinGrade(Int(nudLin.Value)) + nQtdIcon_pos * 5))
                        mdiDesktop.btnUnidades.Location = New System.Drawing.Point(CDbl(CalcularX(nudCol.Value)), CDbl(CalcularY(nudLin.Value)))
                    Case Is = "Colaboradores"
                        nQtdIcon_pos = VerQtdIcon_Posicao(Int(nudCol.Value), Int(nudLin.Value), "btnColaboradores")
                        btnColaboradores.Location = New System.Drawing.Point(CDbl(ColGrade(Int(nudCol.Value)) + nQtdIcon_pos * 5), CDbl(LinGrade(Int(nudLin.Value)) + nQtdIcon_pos * 5))
                        mdiDesktop.btnColaboradores.Location = New System.Drawing.Point(CDbl(CalcularX(Int(nudCol.Value))), CDbl(CalcularY(Int(nudLin.Value))))
                    Case Is = "Controle de Despesas"
                        nQtdIcon_pos = VerQtdIcon_Posicao(Int(nudCol.Value), Int(nudLin.Value), "btnControle_de_Despesas")
                        btnControle_de_Despesas.Location = New System.Drawing.Point(CDbl(ColGrade(Int(nudCol.Value)) + nQtdIcon_pos * 5), CDbl(LinGrade(Int(nudLin.Value)) + nQtdIcon_pos * 5))
                        mdiDesktop.btnControle_de_Despesas.Location = New System.Drawing.Point(CDbl(CalcularX(Int(nudCol.Value))), CDbl(CalcularY(Int(nudLin.Value))))
                End Select
                mdiDesktop.Refresh()
            End If
        End If

    End Sub

    Private Sub nudLin_ValueChanged(sender As Object, e As EventArgs) Handles nudLin.ValueChanged, nudCol.ValueChanged

        If Not bAtualizaON Then Exit Sub 'Não atualizar o posicionamento

        If Not bStart = True Then
            Call MudaPosicao()
            'Call AtualizaPosicionamento()
        End If

    End Sub

    Private Sub AtualizaPosicionamento()
        Dim cbModulo_Ant As String

        If Not bAtualizaON Then Exit Sub 'Não atualizar o posicionamento

        bStart = True
        cbModulo_Ant = cbModulo.Text

        For x = 0 To cbModulo.Items.Count - 1
            With mdiDesktop
                Select Case cbModulo.Items(x)
                    Case Is = "Compras"
                        nudCol.Value = CalcularColuna(.btnCompras.Location.X)
                        nudLin.Value = CalcularLinha(.btnCompras.Location.Y)
                    Case Is = "Contribuições"
                        nudCol.Value = CalcularColuna(.btnContribuicoes.Location.X)
                        nudLin.Value = CalcularLinha(.btnContribuicoes.Location.Y)
                    Case Is = "Tesouraria"
                        nudCol.Value = CalcularColuna(.btnTesouraria.Location.X)
                        nudLin.Value = CalcularLinha(.btnTesouraria.Location.Y)
                    Case Is = "Protocolo"
                        nudCol.Value = CalcularColuna(mdiDesktop.btnProtocolo.Location.X)
                        nudLin.Value = CalcularLinha(mdiDesktop.btnProtocolo.Location.Y)
                    Case Is = "Ponto de Venda"
                        nudCol.Value = CalcularColuna(mdiDesktop.btnPonto_de_Venda.Location.X)
                        nudLin.Value = CalcularLinha(mdiDesktop.btnPonto_de_Venda.Location.Y)
                    Case Is = "Plano Financeiro"
                        nudCol.Value = CalcularColuna(mdiDesktop.btnPlano_Financeiro.Location.X)
                        nudLin.Value = CalcularLinha(mdiDesktop.btnPlano_Financeiro.Location.Y)
                    Case Is = "Controle de Boletins"
                        nudCol.Value = CalcularColuna(mdiDesktop.btnControle_de_Boletins.Location.X)
                        nudLin.Value = CalcularLinha(mdiDesktop.btnControle_de_Boletins.Location.Y)
                    Case Is = "Censo"
                        nudCol.Value = CalcularColuna(.btnCenso.Location.X)
                        nudLin.Value = CalcularLinha(.btnCenso.Location.Y)
                    Case Is = "Contas a Pagar"
                        nudCol.Value = CalcularColuna(mdiDesktop.btnContas_a_Pagar.Location.X)
                        nudLin.Value = CalcularLinha(mdiDesktop.btnContas_a_Pagar.Location.Y)
                    Case Is = "Obras Unidas"
                        nudCol.Value = CalcularColuna(mdiDesktop.btnObras_Unidas.Location.X)
                        nudLin.Value = CalcularLinha(mdiDesktop.btnObras_Unidas.Location.Y)
                    Case Is = "Controle de Estoque"
                        nudCol.Value = CalcularColuna(mdiDesktop.btnEstoque.Location.X)
                        nudLin.Value = CalcularLinha(mdiDesktop.btnEstoque.Location.Y)
                    Case Is = "Unidades"
                        nudCol.Value = CalcularColuna(mdiDesktop.btnUnidades.Location.X)
                        nudLin.Value = CalcularLinha(mdiDesktop.btnUnidades.Location.Y)
                    Case Is = "Colaboradores"
                        nudCol.Value = CalcularColuna(mdiDesktop.btnColaboradores.Location.X)
                        nudLin.Value = CalcularLinha(mdiDesktop.btnColaboradores.Location.Y)
                    Case Is = "Controle de Despesas"
                        nudCol.Value = CalcularColuna(.btnControle_de_Despesas.Location.X)
                        nudLin.Value = CalcularLinha(.btnControle_de_Despesas.Location.Y)
                End Select
            End With
        Next
        bStart = False
        cbModulo.Text = "" 'Forçar a execução do TextChanged
        cbModulo.Text = cbModulo_Ant

    End Sub

    Private Sub cbModulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModulo.SelectedIndexChanged, cbModulo.TextChanged

        Select Case cbModulo.Text
            Case Is = "Compras"
                nudCol.Value = CalcularColuna(mdiDesktop.btnCompras.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnCompras.Location.Y)
            Case Is = "Contribuições"
                nudCol.Value = CalcularColuna(mdiDesktop.btnContribuicoes.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnContribuicoes.Location.Y)
            Case Is = "Tesouraria"
                nudCol.Value = CalcularColuna(mdiDesktop.btnTesouraria.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnTesouraria.Location.Y)
            Case Is = "Protocolo"
                nudCol.Value = CalcularColuna(mdiDesktop.btnProtocolo.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnProtocolo.Location.Y)
            Case Is = "Ponto de Venda"
                nudCol.Value = CalcularColuna(mdiDesktop.btnPonto_de_Venda.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnPonto_de_Venda.Location.Y)
            Case Is = "Plano Financeiro"
                nudCol.Value = CalcularColuna(mdiDesktop.btnPlano_Financeiro.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnPlano_Financeiro.Location.Y)
            Case Is = "Controle de Boletins"
                nudCol.Value = CalcularColuna(mdiDesktop.btnControle_de_Boletins.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnControle_de_Boletins.Location.Y)
            Case Is = "Censo"
                nudCol.Value = CalcularColuna(mdiDesktop.btnCenso.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnCenso.Location.Y)
            Case Is = "Contas a Pagar"
                nudCol.Value = CalcularColuna(mdiDesktop.btnContas_a_Pagar.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnContas_a_Pagar.Location.Y)
            Case Is = "Obras Unidas"
                nudCol.Value = CalcularColuna(mdiDesktop.btnObras_Unidas.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnObras_Unidas.Location.Y)
            Case Is = "Controle de Estoque"
                nudCol.Value = CalcularColuna(mdiDesktop.btnEstoque.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnEstoque.Location.Y)
            Case Is = "Unidades"
                nudCol.Value = CalcularColuna(mdiDesktop.btnUnidades.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnUnidades.Location.Y)
            Case Is = "Colaboradores"
                nudCol.Value = CalcularColuna(mdiDesktop.btnColaboradores.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnColaboradores.Location.Y)
            Case Is = "Controle de Despesas"
                nudCol.Value = CalcularColuna(mdiDesktop.btnControle_de_Despesas.Location.X)
                nudLin.Value = CalcularLinha(mdiDesktop.btnControle_de_Despesas.Location.Y)
        End Select

        Call MudaPosicao()
    End Sub

    Private Function VerQtdIcon_Posicao(fCol As Integer, fLin As Integer, fNomeButton As String) As Integer
        Dim nPosX As Integer, nposY As Integer

        VerQtdIcon_Posicao = 0

        For Each _control As Object In mdiDesktop.Controls
            If TypeOf (_control) Is Button Then
                If Mid(_control.Name, 1, 3) = "btn" Then
                    If _control.Name <> fNomeButton Then
                        If _control.visible Then
                            nposY = CalcularLinha(_control.location.y)
                            nPosX = CalcularColuna(_control.location.x)
                            If nPosX = fCol And nposY = fLin Then
                                VerQtdIcon_Posicao += 1
                            End If
                        End If
                    Else
                        Exit For
                    End If
                End If
            End If
        Next
    End Function

    Private Sub btnCompras_Click(sender As Object, e As EventArgs) Handles btnCompras.Click, btnControle_de_Despesas.Click, btnColaboradores.Click, btnUnidades.Click, btnContribuicoes.Click, btnTesouraria.Click, btnProtocolo.Click, btnPonto_de_Venda.Click, btnPlano_Financeiro.Click, btnControle_de_Boletins.Click, btnCenso.Click, btnContas_a_Pagar.Click, btnControle_de_Estoque.Click, btnObras_Unidas.Click
        Dim fButton As Button

        fButton = sender
        cbModulo.Text = "" 'Forçar a executar o TextChanged do Objeto

        bAtualizaON = False 'Não atualizar o posicionamento

        If fButton.Name = "btnCompras" Then
            cbModulo.Text = "Compras"
        ElseIf fButton.Name = "btnContribuicoes" Then
            cbModulo.Text = "Contribuições"
        ElseIf fButton.Name = "btnTesouraria" Then
            cbModulo.Text = "Tesouraria"
        ElseIf fButton.Name = "btnProtocolo" Then
            cbModulo.Text = "Protocolo"
        ElseIf fButton.Name = "btnPonto_de_Venda" Then
            cbModulo.Text = "Ponto de Venda"
        ElseIf fButton.Name = "btnPlano_Financeiro" Then
            cbModulo.Text = "Plano Financeiro"
        ElseIf fButton.Name = "btnControle_de_Boletins" Then
            cbModulo.Text = "Controle de Boletins"
        ElseIf fButton.Name = "btnCenso" Then
            cbModulo.Text = "Censo"
        ElseIf fButton.Name = "btnContas_a_Pagar" Then
            cbModulo.Text = "Contas a Pagar"
        ElseIf fButton.Name = "btnObras_Unidas" Then
            cbModulo.Text = "Obras Unidas"
        ElseIf fButton.Name = "btnControle_de_Estoque" Then
            cbModulo.Text = "Controle de Estoque"
        ElseIf fButton.Name = "btnUnidades" Then
            cbModulo.Text = "Unidades"
        ElseIf fButton.Name = "btnColaboradores" Then
            cbModulo.Text = "Colaboradores"
        ElseIf fButton.Name = "btnControle_de_Despesas" Then
            cbModulo.Text = "Controle de Despesas"
        End If

        bAtualizaON = True 'Atualizar o posicionamento

    End Sub

End Class