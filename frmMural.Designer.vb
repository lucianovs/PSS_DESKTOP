<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMural
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMural))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnIncluir = New System.Windows.Forms.ToolStripButton()
        Me.btnAlterar = New System.Windows.Forms.ToolStripButton()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnGravar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAnterior = New System.Windows.Forms.ToolStripButton()
        Me.btnProximo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLocalizar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tssContReg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtMenMur = New System.Windows.Forms.TextBox()
        Me.txtCodMur = New System.Windows.Forms.TextBox()
        Me.lblMenMur = New System.Windows.Forms.Label()
        Me.lblCodMur = New System.Windows.Forms.Label()
        Me.lblDatPub = New System.Windows.Forms.Label()
        Me.dtpDatPub = New System.Windows.Forms.DateTimePicker()
        Me.lblStaMur = New System.Windows.Forms.Label()
        Me.cbStaMur = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnIncluir, Me.btnAlterar, Me.btnExcluir, Me.ToolStripSeparator1, Me.btnGravar, Me.btnCancelar, Me.ToolStripSeparator3, Me.btnAnterior, Me.btnProximo, Me.ToolStripSeparator2, Me.btnLocalizar, Me.btnImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(648, 39)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnIncluir
        '
        Me.btnIncluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnIncluir.Image = CType(resources.GetObject("btnIncluir.Image"), System.Drawing.Image)
        Me.btnIncluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIncluir.Name = "btnIncluir"
        Me.btnIncluir.Size = New System.Drawing.Size(36, 36)
        Me.btnIncluir.Text = "Incluir"
        '
        'btnAlterar
        '
        Me.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(36, 36)
        Me.btnAlterar.Text = "Alterar"
        '
        'btnExcluir
        '
        Me.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(36, 36)
        Me.btnExcluir.Text = "Excluir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'btnGravar
        '
        Me.btnGravar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGravar.Image = CType(resources.GetObject("btnGravar.Image"), System.Drawing.Image)
        Me.btnGravar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(36, 36)
        Me.btnGravar.Text = "Gravar"
        '
        'btnCancelar
        '
        Me.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(36, 36)
        Me.btnCancelar.Text = "Cancelar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'btnAnterior
        '
        Me.btnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAnterior.Image = CType(resources.GetObject("btnAnterior.Image"), System.Drawing.Image)
        Me.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(36, 36)
        Me.btnAnterior.Text = "Anterior"
        '
        'btnProximo
        '
        Me.btnProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnProximo.Image = CType(resources.GetObject("btnProximo.Image"), System.Drawing.Image)
        Me.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProximo.Name = "btnProximo"
        Me.btnProximo.Size = New System.Drawing.Size(36, 36)
        Me.btnProximo.Text = "Próximo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'btnLocalizar
        '
        Me.btnLocalizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnLocalizar.Image = CType(resources.GetObject("btnLocalizar.Image"), System.Drawing.Image)
        Me.btnLocalizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(36, 36)
        Me.btnLocalizar.Text = "Localizar"
        '
        'btnImprimir
        '
        Me.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(36, 36)
        Me.btnImprimir.Text = "Imprimir"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tssContReg})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 228)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(648, 25)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tssContReg
        '
        Me.tssContReg.Name = "tssContReg"
        Me.tssContReg.Size = New System.Drawing.Size(98, 20)
        Me.tssContReg.Text = "Registro n / n"
        '
        'txtMenMur
        '
        Me.txtMenMur.Location = New System.Drawing.Point(110, 145)
        Me.txtMenMur.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMenMur.MaxLength = 60
        Me.txtMenMur.Name = "txtMenMur"
        Me.txtMenMur.Size = New System.Drawing.Size(507, 22)
        Me.txtMenMur.TabIndex = 14
        '
        'txtCodMur
        '
        Me.txtCodMur.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodMur.Location = New System.Drawing.Point(91, 62)
        Me.txtCodMur.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCodMur.MaxLength = 8
        Me.txtCodMur.Name = "txtCodMur"
        Me.txtCodMur.Size = New System.Drawing.Size(83, 22)
        Me.txtCodMur.TabIndex = 10
        '
        'lblMenMur
        '
        Me.lblMenMur.AutoSize = True
        Me.lblMenMur.ForeColor = System.Drawing.Color.Red
        Me.lblMenMur.Location = New System.Drawing.Point(24, 145)
        Me.lblMenMur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMenMur.Name = "lblMenMur"
        Me.lblMenMur.Size = New System.Drawing.Size(81, 17)
        Me.lblMenMur.TabIndex = 14
        Me.lblMenMur.Text = "Mensagem:"
        '
        'lblCodMur
        '
        Me.lblCodMur.AutoSize = True
        Me.lblCodMur.Location = New System.Drawing.Point(25, 63)
        Me.lblCodMur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCodMur.Name = "lblCodMur"
        Me.lblCodMur.Size = New System.Drawing.Size(56, 17)
        Me.lblCodMur.TabIndex = 10
        Me.lblCodMur.Text = "Código:"
        '
        'lblDatPub
        '
        Me.lblDatPub.AutoSize = True
        Me.lblDatPub.ForeColor = System.Drawing.Color.Red
        Me.lblDatPub.Location = New System.Drawing.Point(25, 110)
        Me.lblDatPub.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDatPub.Name = "lblDatPub"
        Me.lblDatPub.Size = New System.Drawing.Size(75, 17)
        Me.lblDatPub.TabIndex = 12
        Me.lblDatPub.Text = "Descrição:"
        '
        'dtpDatPub
        '
        Me.dtpDatPub.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDatPub.Location = New System.Drawing.Point(110, 105)
        Me.dtpDatPub.Name = "dtpDatPub"
        Me.dtpDatPub.Size = New System.Drawing.Size(91, 22)
        Me.dtpDatPub.TabIndex = 12
        '
        'lblStaMur
        '
        Me.lblStaMur.AutoSize = True
        Me.lblStaMur.ForeColor = System.Drawing.Color.Red
        Me.lblStaMur.Location = New System.Drawing.Point(25, 191)
        Me.lblStaMur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStaMur.Name = "lblStaMur"
        Me.lblStaMur.Size = New System.Drawing.Size(52, 17)
        Me.lblStaMur.TabIndex = 16
        Me.lblStaMur.Text = "Status:"
        '
        'cbStaMur
        '
        Me.cbStaMur.FormattingEnabled = True
        Me.cbStaMur.Items.AddRange(New Object() {"PUBLICADA", "AGUARDANDO", "CONCLUIDA"})
        Me.cbStaMur.Location = New System.Drawing.Point(110, 184)
        Me.cbStaMur.Name = "cbStaMur"
        Me.cbStaMur.Size = New System.Drawing.Size(179, 24)
        Me.cbStaMur.TabIndex = 16
        '
        'frmMural
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 253)
        Me.Controls.Add(Me.cbStaMur)
        Me.Controls.Add(Me.lblStaMur)
        Me.Controls.Add(Me.dtpDatPub)
        Me.Controls.Add(Me.lblDatPub)
        Me.Controls.Add(Me.txtMenMur)
        Me.Controls.Add(Me.txtCodMur)
        Me.Controls.Add(Me.lblMenMur)
        Me.Controls.Add(Me.lblCodMur)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmMural"
        Me.Text = "frmMural"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnIncluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAlterar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnGravar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAnterior As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnProximo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnLocalizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tssContReg As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtMenMur As System.Windows.Forms.TextBox
    Friend WithEvents txtCodMur As System.Windows.Forms.TextBox
    Friend WithEvents lblMenMur As System.Windows.Forms.Label
    Friend WithEvents lblCodMur As System.Windows.Forms.Label
    Friend WithEvents lblDatPub As System.Windows.Forms.Label
    Private WithEvents dtpDatPub As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStaMur As System.Windows.Forms.Label
    Friend WithEvents cbStaMur As System.Windows.Forms.ComboBox
End Class
