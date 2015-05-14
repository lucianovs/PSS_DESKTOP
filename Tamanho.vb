Public Class Tamanho

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Pequeno_Click(sender As Button, e As EventArgs) Handles Pequeno.Click, Button2.Click, Button3.Click

        frmDeskTop.nTamanho = sender.Tag
        For Each _control As Object In frmDeskTop.Controls
            If TypeOf (_control) Is Button Then
                If _control.Name.ToString.StartsWith("btn") Then
                    If _control.visible Then
                        frmDeskTop.AtualizarTam(frmDeskTop.nTamanho, _control)
                    End If
                End If
            End If
        Next
        frmDeskTop.Refresh()
        Application.DoEvents()

    End Sub
End Class