<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAcessos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAcessos))
        Me.treeView_Acessos = New System.Windows.Forms.TreeView()
        Me.ListaImagem = New System.Windows.Forms.ImageList(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGruUsu = New System.Windows.Forms.Label()
        Me.txtGruUsu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtModulo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOpcao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbNivelAcesso = New System.Windows.Forms.ComboBox()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'treeView_Acessos
        '
        Me.treeView_Acessos.ImageIndex = 0
        Me.treeView_Acessos.ImageList = Me.ListaImagem
        Me.treeView_Acessos.Location = New System.Drawing.Point(12, 12)
        Me.treeView_Acessos.Name = "treeView_Acessos"
        Me.treeView_Acessos.SelectedImageIndex = 0
        Me.treeView_Acessos.Size = New System.Drawing.Size(561, 426)
        Me.treeView_Acessos.TabIndex = 0
        '
        'ListaImagem
        '
        Me.ListaImagem.ImageStream = CType(resources.GetObject("ListaImagem.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ListaImagem.TransparentColor = System.Drawing.Color.Transparent
        Me.ListaImagem.Images.SetKeyName(0, "My-Documents.png")
        Me.ListaImagem.Images.SetKeyName(1, "Locker.png")
        Me.ListaImagem.Images.SetKeyName(2, "Grupos.png")
        Me.ListaImagem.Images.SetKeyName(3, "Usuario.png")
        Me.ListaImagem.Images.SetKeyName(4, "Locker-blue.png")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(610, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PERMISSÕES E ACESSOS"
        '
        'lblGruUsu
        '
        Me.lblGruUsu.AutoSize = True
        Me.lblGruUsu.Location = New System.Drawing.Point(593, 62)
        Me.lblGruUsu.Name = "lblGruUsu"
        Me.lblGruUsu.Size = New System.Drawing.Size(101, 17)
        Me.lblGruUsu.TabIndex = 2
        Me.lblGruUsu.Text = "Grupo/Usuario"
        '
        'txtGruUsu
        '
        Me.txtGruUsu.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtGruUsu.Location = New System.Drawing.Point(741, 57)
        Me.txtGruUsu.Name = "txtGruUsu"
        Me.txtGruUsu.Size = New System.Drawing.Size(180, 22)
        Me.txtGruUsu.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(593, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Módulo"
        '
        'txtModulo
        '
        Me.txtModulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtModulo.Location = New System.Drawing.Point(741, 103)
        Me.txtModulo.Name = "txtModulo"
        Me.txtModulo.Size = New System.Drawing.Size(180, 22)
        Me.txtModulo.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(593, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Opção"
        '
        'txtOpcao
        '
        Me.txtOpcao.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtOpcao.Location = New System.Drawing.Point(741, 149)
        Me.txtOpcao.Name = "txtOpcao"
        Me.txtOpcao.Size = New System.Drawing.Size(180, 22)
        Me.txtOpcao.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(593, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nível de Acesso"
        '
        'cbNivelAcesso
        '
        Me.cbNivelAcesso.FormattingEnabled = True
        Me.cbNivelAcesso.Items.AddRange(New Object() {"0 – Nenhum Acesso ", "1 – Somente Leitura", "2 – Leitura e Alteração", "3 – Acesso Completo (Exlusão com restrição)", "4 – Acesso Completo"})
        Me.cbNivelAcesso.Location = New System.Drawing.Point(741, 216)
        Me.cbNivelAcesso.Name = "cbNivelAcesso"
        Me.cbNivelAcesso.Size = New System.Drawing.Size(180, 24)
        Me.cbNivelAcesso.TabIndex = 9
        '
        'btnGravar
        '
        Me.btnGravar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnGravar.BackgroundImage = CType(resources.GetObject("btnGravar.BackgroundImage"), System.Drawing.Image)
        Me.btnGravar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGravar.Location = New System.Drawing.Point(827, 260)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(94, 90)
        Me.btnGravar.TabIndex = 10
        Me.btnGravar.Text = "Gravar"
        Me.btnGravar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'frmAcessos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 450)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.cbNivelAcesso)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOpcao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtModulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGruUsu)
        Me.Controls.Add(Me.lblGruUsu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.treeView_Acessos)
        Me.Name = "frmAcessos"
        Me.Text = "Permissões e Acessos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents treeView_Acessos As System.Windows.Forms.TreeView
    Friend WithEvents ListaImagem As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblGruUsu As System.Windows.Forms.Label
    Friend WithEvents txtGruUsu As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtModulo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOpcao As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbNivelAcesso As System.Windows.Forms.ComboBox
    Friend WithEvents btnGravar As System.Windows.Forms.Button
End Class
