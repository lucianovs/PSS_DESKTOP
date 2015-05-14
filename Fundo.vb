Public Class Fundo

    Private Sub Button2_Click(sender As Button, e As EventArgs) Handles btn1.Click, Button34.Click, Button35.Click, Button36.Click, Button37.Click, Button38.Click, Button39.Click, Button40.Click

        frmDeskTop.nCor = sender.Tag
        For Each _control As Object In frmDeskTop.Controls
            If TypeOf (_control) Is Button Then
                If _control.Name.ToString.StartsWith("btn") Then
                    If _control.visible Then
                        frmDeskTop.AtualizarCor(frmDeskTop.nCor, _control)
                    End If
                End If
            End If
        Next
        frmDeskTop.Refresh()
        Application.DoEvents()

    End Sub

    Private Sub Fundo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        Me.Close()
    End Sub
End Class