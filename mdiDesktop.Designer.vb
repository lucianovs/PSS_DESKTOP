<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiDesktop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiDesktop))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpBoxUpdate = New System.Windows.Forms.GroupBox()
        Me.lblSetup = New System.Windows.Forms.Label()
        Me.ProgressBarUpdate = New System.Windows.Forms.ProgressBar()
        Me.treeview_Mural = New System.Windows.Forms.TreeView()
        Me.ImageList_Mural = New System.Windows.Forms.ImageList(Me.components)
        Me.btnUnidades = New System.Windows.Forms.Button()
        Me.btnTesouraria = New System.Windows.Forms.Button()
        Me.btnProtocolo = New System.Windows.Forms.Button()
        Me.btnPonto_de_Venda = New System.Windows.Forms.Button()
        Me.btnPlano_Financeiro = New System.Windows.Forms.Button()
        Me.btnObras_Unidas = New System.Windows.Forms.Button()
        Me.btnEstoque = New System.Windows.Forms.Button()
        Me.btnControle_de_Despesas = New System.Windows.Forms.Button()
        Me.btnControle_de_Boletins = New System.Windows.Forms.Button()
        Me.btnContribuicoes = New System.Windows.Forms.Button()
        Me.btnContas_a_Pagar = New System.Windows.Forms.Button()
        Me.btnColaboradores = New System.Windows.Forms.Button()
        Me.btnCenso = New System.Windows.Forms.Button()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuConfiguracoes = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuCadastroDeGrupos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuPermissao_Acesso = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarSenhaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.timerSetup = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.grpBoxUpdate.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grpBoxUpdate)
        Me.GroupBox1.Controls.Add(Me.treeview_Mural)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(396, 631)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mural de Mensagens"
        '
        'grpBoxUpdate
        '
        Me.grpBoxUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grpBoxUpdate.Controls.Add(Me.lblSetup)
        Me.grpBoxUpdate.Controls.Add(Me.ProgressBarUpdate)
        Me.grpBoxUpdate.Location = New System.Drawing.Point(7, 174)
        Me.grpBoxUpdate.Name = "grpBoxUpdate"
        Me.grpBoxUpdate.Size = New System.Drawing.Size(382, 113)
        Me.grpBoxUpdate.TabIndex = 34
        Me.grpBoxUpdate.TabStop = False
        Me.grpBoxUpdate.Text = "Aguarde, Atualizando o Sistema da SSVP ..."
        Me.grpBoxUpdate.Visible = False
        '
        'lblSetup
        '
        Me.lblSetup.AutoSize = True
        Me.lblSetup.Location = New System.Drawing.Point(13, 85)
        Me.lblSetup.Name = "lblSetup"
        Me.lblSetup.Size = New System.Drawing.Size(51, 17)
        Me.lblSetup.TabIndex = 1
        Me.lblSetup.Text = "Label1"
        '
        'ProgressBarUpdate
        '
        Me.ProgressBarUpdate.Location = New System.Drawing.Point(6, 33)
        Me.ProgressBarUpdate.Name = "ProgressBarUpdate"
        Me.ProgressBarUpdate.Size = New System.Drawing.Size(370, 43)
        Me.ProgressBarUpdate.TabIndex = 0
        '
        'treeview_Mural
        '
        Me.treeview_Mural.ImageIndex = 1
        Me.treeview_Mural.ImageList = Me.ImageList_Mural
        Me.treeview_Mural.Location = New System.Drawing.Point(7, 22)
        Me.treeview_Mural.Name = "treeview_Mural"
        Me.treeview_Mural.SelectedImageIndex = 3
        Me.treeview_Mural.Size = New System.Drawing.Size(382, 602)
        Me.treeview_Mural.TabIndex = 0
        '
        'ImageList_Mural
        '
        Me.ImageList_Mural.ImageStream = CType(resources.GetObject("ImageList_Mural.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList_Mural.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList_Mural.Images.SetKeyName(0, "ball green.png")
        Me.ImageList_Mural.Images.SetKeyName(1, "Ball yellow.png")
        Me.ImageList_Mural.Images.SetKeyName(2, "Ball Blue.png")
        Me.ImageList_Mural.Images.SetKeyName(3, "cmd_Direita.png")
        '
        'btnUnidades
        '
        Me.btnUnidades.AllowDrop = True
        Me.btnUnidades.BackgroundImage = CType(resources.GetObject("btnUnidades.BackgroundImage"), System.Drawing.Image)
        Me.btnUnidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUnidades.FlatAppearance.BorderSize = 0
        Me.btnUnidades.Location = New System.Drawing.Point(1042, 107)
        Me.btnUnidades.Margin = New System.Windows.Forms.Padding(4)
        Me.btnUnidades.Name = "btnUnidades"
        Me.btnUnidades.Size = New System.Drawing.Size(124, 79)
        Me.btnUnidades.TabIndex = 33
        Me.btnUnidades.UseVisualStyleBackColor = True
        Me.btnUnidades.Visible = False
        '
        'btnTesouraria
        '
        Me.btnTesouraria.AllowDrop = True
        Me.btnTesouraria.BackgroundImage = CType(resources.GetObject("btnTesouraria.BackgroundImage"), System.Drawing.Image)
        Me.btnTesouraria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTesouraria.FlatAppearance.BorderSize = 0
        Me.btnTesouraria.Location = New System.Drawing.Point(1042, 24)
        Me.btnTesouraria.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTesouraria.Name = "btnTesouraria"
        Me.btnTesouraria.Size = New System.Drawing.Size(124, 79)
        Me.btnTesouraria.TabIndex = 32
        Me.btnTesouraria.UseVisualStyleBackColor = True
        Me.btnTesouraria.Visible = False
        '
        'btnProtocolo
        '
        Me.btnProtocolo.AllowDrop = True
        Me.btnProtocolo.BackgroundImage = CType(resources.GetObject("btnProtocolo.BackgroundImage"), System.Drawing.Image)
        Me.btnProtocolo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnProtocolo.FlatAppearance.BorderSize = 0
        Me.btnProtocolo.Location = New System.Drawing.Point(742, 107)
        Me.btnProtocolo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProtocolo.Name = "btnProtocolo"
        Me.btnProtocolo.Size = New System.Drawing.Size(123, 79)
        Me.btnProtocolo.TabIndex = 31
        Me.btnProtocolo.UseVisualStyleBackColor = True
        Me.btnProtocolo.Visible = False
        '
        'btnPonto_de_Venda
        '
        Me.btnPonto_de_Venda.AllowDrop = True
        Me.btnPonto_de_Venda.BackgroundImage = CType(resources.GetObject("btnPonto_de_Venda.BackgroundImage"), System.Drawing.Image)
        Me.btnPonto_de_Venda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPonto_de_Venda.FlatAppearance.BorderSize = 0
        Me.btnPonto_de_Venda.Location = New System.Drawing.Point(587, 107)
        Me.btnPonto_de_Venda.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPonto_de_Venda.Name = "btnPonto_de_Venda"
        Me.btnPonto_de_Venda.Size = New System.Drawing.Size(132, 79)
        Me.btnPonto_de_Venda.TabIndex = 30
        Me.btnPonto_de_Venda.UseVisualStyleBackColor = True
        Me.btnPonto_de_Venda.Visible = False
        '
        'btnPlano_Financeiro
        '
        Me.btnPlano_Financeiro.AllowDrop = True
        Me.btnPlano_Financeiro.BackgroundImage = CType(resources.GetObject("btnPlano_Financeiro.BackgroundImage"), System.Drawing.Image)
        Me.btnPlano_Financeiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPlano_Financeiro.FlatAppearance.BorderSize = 0
        Me.btnPlano_Financeiro.Location = New System.Drawing.Point(439, 108)
        Me.btnPlano_Financeiro.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPlano_Financeiro.Name = "btnPlano_Financeiro"
        Me.btnPlano_Financeiro.Size = New System.Drawing.Size(127, 79)
        Me.btnPlano_Financeiro.TabIndex = 29
        Me.btnPlano_Financeiro.UseVisualStyleBackColor = True
        Me.btnPlano_Financeiro.Visible = False
        '
        'btnObras_Unidas
        '
        Me.btnObras_Unidas.AllowDrop = True
        Me.btnObras_Unidas.BackgroundImage = CType(resources.GetObject("btnObras_Unidas.BackgroundImage"), System.Drawing.Image)
        Me.btnObras_Unidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnObras_Unidas.FlatAppearance.BorderSize = 0
        Me.btnObras_Unidas.Location = New System.Drawing.Point(587, 20)
        Me.btnObras_Unidas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnObras_Unidas.Name = "btnObras_Unidas"
        Me.btnObras_Unidas.Size = New System.Drawing.Size(132, 79)
        Me.btnObras_Unidas.TabIndex = 28
        Me.btnObras_Unidas.UseVisualStyleBackColor = True
        Me.btnObras_Unidas.Visible = False
        '
        'btnEstoque
        '
        Me.btnEstoque.AllowDrop = True
        Me.btnEstoque.BackgroundImage = CType(resources.GetObject("btnEstoque.BackgroundImage"), System.Drawing.Image)
        Me.btnEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEstoque.FlatAppearance.BorderSize = 0
        Me.btnEstoque.Location = New System.Drawing.Point(888, 107)
        Me.btnEstoque.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEstoque.Name = "btnEstoque"
        Me.btnEstoque.Size = New System.Drawing.Size(126, 79)
        Me.btnEstoque.TabIndex = 27
        Me.btnEstoque.UseVisualStyleBackColor = True
        Me.btnEstoque.Visible = False
        '
        'btnControle_de_Despesas
        '
        Me.btnControle_de_Despesas.AllowDrop = True
        Me.btnControle_de_Despesas.BackgroundImage = CType(resources.GetObject("btnControle_de_Despesas.BackgroundImage"), System.Drawing.Image)
        Me.btnControle_de_Despesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnControle_de_Despesas.FlatAppearance.BorderSize = 0
        Me.btnControle_de_Despesas.Location = New System.Drawing.Point(888, 210)
        Me.btnControle_de_Despesas.Margin = New System.Windows.Forms.Padding(4)
        Me.btnControle_de_Despesas.Name = "btnControle_de_Despesas"
        Me.btnControle_de_Despesas.Size = New System.Drawing.Size(126, 76)
        Me.btnControle_de_Despesas.TabIndex = 26
        Me.btnControle_de_Despesas.UseVisualStyleBackColor = True
        Me.btnControle_de_Despesas.Visible = False
        '
        'btnControle_de_Boletins
        '
        Me.btnControle_de_Boletins.AllowDrop = True
        Me.btnControle_de_Boletins.BackgroundImage = CType(resources.GetObject("btnControle_de_Boletins.BackgroundImage"), System.Drawing.Image)
        Me.btnControle_de_Boletins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnControle_de_Boletins.FlatAppearance.BorderSize = 0
        Me.btnControle_de_Boletins.Location = New System.Drawing.Point(888, 24)
        Me.btnControle_de_Boletins.Margin = New System.Windows.Forms.Padding(4)
        Me.btnControle_de_Boletins.Name = "btnControle_de_Boletins"
        Me.btnControle_de_Boletins.Size = New System.Drawing.Size(126, 79)
        Me.btnControle_de_Boletins.TabIndex = 25
        Me.btnControle_de_Boletins.UseVisualStyleBackColor = True
        Me.btnControle_de_Boletins.Visible = False
        '
        'btnContribuicoes
        '
        Me.btnContribuicoes.AllowDrop = True
        Me.btnContribuicoes.BackgroundImage = CType(resources.GetObject("btnContribuicoes.BackgroundImage"), System.Drawing.Image)
        Me.btnContribuicoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnContribuicoes.FlatAppearance.BorderSize = 0
        Me.btnContribuicoes.Location = New System.Drawing.Point(439, 20)
        Me.btnContribuicoes.Margin = New System.Windows.Forms.Padding(4)
        Me.btnContribuicoes.Name = "btnContribuicoes"
        Me.btnContribuicoes.Size = New System.Drawing.Size(127, 80)
        Me.btnContribuicoes.TabIndex = 24
        Me.btnContribuicoes.UseVisualStyleBackColor = True
        Me.btnContribuicoes.Visible = False
        '
        'btnContas_a_Pagar
        '
        Me.btnContas_a_Pagar.AllowDrop = True
        Me.btnContas_a_Pagar.BackgroundImage = CType(resources.GetObject("btnContas_a_Pagar.BackgroundImage"), System.Drawing.Image)
        Me.btnContas_a_Pagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnContas_a_Pagar.FlatAppearance.BorderSize = 0
        Me.btnContas_a_Pagar.Location = New System.Drawing.Point(587, 207)
        Me.btnContas_a_Pagar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnContas_a_Pagar.Name = "btnContas_a_Pagar"
        Me.btnContas_a_Pagar.Size = New System.Drawing.Size(132, 79)
        Me.btnContas_a_Pagar.TabIndex = 23
        Me.btnContas_a_Pagar.UseVisualStyleBackColor = True
        Me.btnContas_a_Pagar.Visible = False
        '
        'btnColaboradores
        '
        Me.btnColaboradores.AllowDrop = True
        Me.btnColaboradores.BackgroundImage = CType(resources.GetObject("btnColaboradores.BackgroundImage"), System.Drawing.Image)
        Me.btnColaboradores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnColaboradores.FlatAppearance.BorderSize = 0
        Me.btnColaboradores.Location = New System.Drawing.Point(742, 207)
        Me.btnColaboradores.Margin = New System.Windows.Forms.Padding(4)
        Me.btnColaboradores.Name = "btnColaboradores"
        Me.btnColaboradores.Size = New System.Drawing.Size(123, 79)
        Me.btnColaboradores.TabIndex = 22
        Me.btnColaboradores.UseVisualStyleBackColor = True
        Me.btnColaboradores.Visible = False
        '
        'btnCenso
        '
        Me.btnCenso.AllowDrop = True
        Me.btnCenso.BackgroundImage = CType(resources.GetObject("btnCenso.BackgroundImage"), System.Drawing.Image)
        Me.btnCenso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCenso.FlatAppearance.BorderSize = 0
        Me.btnCenso.Location = New System.Drawing.Point(437, 207)
        Me.btnCenso.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCenso.Name = "btnCenso"
        Me.btnCenso.Size = New System.Drawing.Size(129, 79)
        Me.btnCenso.TabIndex = 21
        Me.btnCenso.UseVisualStyleBackColor = True
        Me.btnCenso.Visible = False
        '
        'btnCompras
        '
        Me.btnCompras.AllowDrop = True
        Me.btnCompras.BackgroundImage = CType(resources.GetObject("btnCompras.BackgroundImage"), System.Drawing.Image)
        Me.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCompras.FlatAppearance.BorderSize = 0
        Me.btnCompras.Location = New System.Drawing.Point(742, 24)
        Me.btnCompras.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(123, 75)
        Me.btnCompras.TabIndex = 20
        Me.btnCompras.UseVisualStyleBackColor = True
        Me.btnCompras.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraçõesToolStripMenuItem, Me.menuConfiguracoes, Me.SairToolStripMenuItem1, Me.ToolStripMenuItem1, Me.menuCadastroDeGrupos, Me.menuUsuarios, Me.menuPermissao_Acesso, Me.AlterarSenhaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(219, 178)
        '
        'ConfiguraçõesToolStripMenuItem
        '
        Me.ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        Me.ConfiguraçõesToolStripMenuItem.Size = New System.Drawing.Size(218, 24)
        Me.ConfiguraçõesToolStripMenuItem.Text = "Configurações"
        '
        'menuConfiguracoes
        '
        Me.menuConfiguracoes.Name = "menuConfiguracoes"
        Me.menuConfiguracoes.Size = New System.Drawing.Size(218, 24)
        Me.menuConfiguracoes.Text = "Parâmetros"
        '
        'SairToolStripMenuItem1
        '
        Me.SairToolStripMenuItem1.Name = "SairToolStripMenuItem1"
        Me.SairToolStripMenuItem1.Size = New System.Drawing.Size(218, 24)
        Me.SairToolStripMenuItem1.Text = "Sair"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(215, 6)
        '
        'menuCadastroDeGrupos
        '
        Me.menuCadastroDeGrupos.Name = "menuCadastroDeGrupos"
        Me.menuCadastroDeGrupos.Size = New System.Drawing.Size(218, 24)
        Me.menuCadastroDeGrupos.Text = "Cadastro de Grupos"
        '
        'menuUsuarios
        '
        Me.menuUsuarios.Name = "menuUsuarios"
        Me.menuUsuarios.Size = New System.Drawing.Size(218, 24)
        Me.menuUsuarios.Text = "Cadastro de Usuários"
        '
        'menuPermissao_Acesso
        '
        Me.menuPermissao_Acesso.Name = "menuPermissao_Acesso"
        Me.menuPermissao_Acesso.Size = New System.Drawing.Size(218, 24)
        Me.menuPermissao_Acesso.Text = "Permissão e Acesso"
        '
        'AlterarSenhaToolStripMenuItem
        '
        Me.AlterarSenhaToolStripMenuItem.Name = "AlterarSenhaToolStripMenuItem"
        Me.AlterarSenhaToolStripMenuItem.Size = New System.Drawing.Size(218, 24)
        Me.AlterarSenhaToolStripMenuItem.Text = "Alterar Senha"
        '
        'timerSetup
        '
        Me.timerSetup.Interval = 500
        '
        'mdiDesktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 676)
        Me.Controls.Add(Me.btnUnidades)
        Me.Controls.Add(Me.btnTesouraria)
        Me.Controls.Add(Me.btnProtocolo)
        Me.Controls.Add(Me.btnPonto_de_Venda)
        Me.Controls.Add(Me.btnPlano_Financeiro)
        Me.Controls.Add(Me.btnObras_Unidas)
        Me.Controls.Add(Me.btnEstoque)
        Me.Controls.Add(Me.btnControle_de_Despesas)
        Me.Controls.Add(Me.btnControle_de_Boletins)
        Me.Controls.Add(Me.btnContribuicoes)
        Me.Controls.Add(Me.btnContas_a_Pagar)
        Me.Controls.Add(Me.btnColaboradores)
        Me.Controls.Add(Me.btnCenso)
        Me.Controls.Add(Me.btnCompras)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "mdiDesktop"
        Me.Text = "CONSELHO NACIONAL DA SOCIEDADE SÃO VICENTE DE PAULO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.grpBoxUpdate.ResumeLayout(False)
        Me.grpBoxUpdate.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnUnidades As System.Windows.Forms.Button
    Friend WithEvents btnTesouraria As System.Windows.Forms.Button
    Friend WithEvents btnProtocolo As System.Windows.Forms.Button
    Friend WithEvents btnPonto_de_Venda As System.Windows.Forms.Button
    Friend WithEvents btnPlano_Financeiro As System.Windows.Forms.Button
    Friend WithEvents btnObras_Unidas As System.Windows.Forms.Button
    Friend WithEvents btnEstoque As System.Windows.Forms.Button
    Friend WithEvents btnControle_de_Despesas As System.Windows.Forms.Button
    Friend WithEvents btnControle_de_Boletins As System.Windows.Forms.Button
    Friend WithEvents btnContribuicoes As System.Windows.Forms.Button
    Friend WithEvents btnContas_a_Pagar As System.Windows.Forms.Button
    Friend WithEvents btnColaboradores As System.Windows.Forms.Button
    Friend WithEvents btnCenso As System.Windows.Forms.Button
    Friend WithEvents btnCompras As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ConfiguraçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuPermissao_Acesso As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuConfiguracoes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlterarSenhaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuCadastroDeGrupos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents treeview_Mural As System.Windows.Forms.TreeView
    Friend WithEvents ImageList_Mural As System.Windows.Forms.ImageList
    Friend WithEvents timerSetup As System.Windows.Forms.Timer
    Friend WithEvents grpBoxUpdate As System.Windows.Forms.GroupBox
    Friend WithEvents lblSetup As System.Windows.Forms.Label
    Friend WithEvents ProgressBarUpdate As System.Windows.Forms.ProgressBar

End Class
