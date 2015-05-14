Public Class Form1
    Public nTamanho As Integer = 1
    Public nCor As Integer = 0
    Private ObjAux As Object
    Private nCursorX As Integer = 47 'Correção da localização para o dragdrop
    Private nCursorY As Integer = 70 'Correção da localização para o dragdrop

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizarForm()
    End Sub

    Private Sub Button1_Click(sender As Button, e As EventArgs) Handles Button1.DragEnter, Button2.DragEnter
        ObjAux = New Button()
        ObjAux = sender
    End Sub

    Private Sub Rich_Enter(sender As Object, e As EventArgs) Handles RichTextBox1.DragEnter, RichTextBox1.Enter
        ObjAux = New GroupBox()
        ObjAux = GroupBox1
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown, Button2.MouseDown, RichTextBox1.MouseDown
        sender.DoDragDrop(sender, DragDropEffects.Move)
    End Sub

    Private Sub Form1_DragLeave(sender As Object, e As EventArgs) Handles MyBase.DragLeave
        Dim a As Cursor = New Cursor(Cursor.Current.Handle)
        ObjAux.Location = New Point(Cursor.Position.X - Me.Location.X - nCursorX, Cursor.Position.Y - Me.Location.X - nCursorY)
    End Sub

    Private Sub SairToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub FundoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FundoToolStripMenuItem1.Click
        Dim frmFundo As Fundo
        frmFundo = New Fundo()
        frmFundo.ShowDialog()
    End Sub

    Private Sub TamanhoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TamanhoToolStripMenuItem.Click
        Dim frmTamanho As Tamanho
        frmTamanho = New Tamanho()
        frmTamanho.ShowDialog()
    End Sub

    Public Sub AtualizarForm()
        AtualizarTam(nTamanho, Button1)
        AtualizarTam(nTamanho, Button2)
        AtualizarCor(nCor)
    End Sub

    Private Sub AtualizarTam(ByVal nTam As Integer, ByRef but As Button)
        If nTam = 0 Then
            but.Size = New Size(55, 50)
            nCursorX = 33
            nCursorY = 53
        ElseIf nTam = 1 Then
            but.Size = New Size(85, 80)
            nCursorX = 47
            nCursorY = 70
        ElseIf nTam = 2 Then
            but.Size = New Size(115, 110)
            nCursorX = 61
            nCursorY = 87
        End If
    End Sub

    Public Sub AtualizarCor(ByVal nCor As Integer)
        Select Case nCor
            Case 0
                Me.BackColor = SystemColors.Control
                Button1.BackColor = SystemColors.Control
                Button2.BackColor = SystemColors.Control
            Case 1
                Me.BackColor = SystemColors.ControlLight
                Button1.BackColor = SystemColors.ControlLight
                Button2.BackColor = SystemColors.ControlLight
            Case 2
                Me.BackColor = SystemColors.ControlDark
                Button1.BackColor = SystemColors.ControlDark
                Button2.BackColor = SystemColors.ControlDark
            Case 3
                Me.BackColor = SystemColors.ControlDarkDark
                Button1.BackColor = SystemColors.ControlDarkDark
                Button2.BackColor = SystemColors.ControlDarkDark
            Case 4
                Me.BackColor = SystemColors.Window
                Button1.BackColor = SystemColors.Window
                Button2.BackColor = SystemColors.Window
            Case 5
                Me.BackColor = SystemColors.InactiveCaption
                Button1.BackColor = SystemColors.InactiveCaption
                Button2.BackColor = SystemColors.InactiveCaption
            Case 6
                Me.BackColor = Color.LightGreen
                Button1.BackColor = Color.LightGreen
                Button2.BackColor = Color.LightGreen
            Case 7
                Me.BackColor = Color.DarkSeaGreen
                Button1.BackColor = Color.DarkSeaGreen
                Button2.BackColor = Color.DarkSeaGreen
        End Select
    End Sub

    Private Sub Rich_Enter(sender As Object, e As DragEventArgs)

    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ContextMenuStrip.Show(e.X, e.Y)
        End If
    End Sub
End Class
