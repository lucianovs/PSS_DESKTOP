Public Class frmArrangeIcon

    Private Sub frmArrangeIcon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLin.Text = CalcularLinha(mdiDesktop.btnCompras.Location.Y)
        txtCol.Text = CalcularColuna(mdiDesktop.btnCompras.Location.X)

    End Sub

    Private Function CalcularY(fLinha As Integer)
        Select Case fLinha
            Case Is = 1
                Return 20
            Case Is = 2
                Return 220
            Case Is = 3
                Return 420
            Case Is = 4
                Return 620
            Case Else
                Return 20
        End Select

    End Function

    Private Function LinGrade(fLinha As Integer)
        Select Case fLinha
            Case Is = 1
                Return 4
            Case Is = 2
                Return 82
            Case Is = 3
                Return 164
            Case Is = 4
                Return 246
            Case Else
                Return 4
        End Select

    End Function

    Private Function CalcularX(fColuna As Integer)
        Select Case fColuna
            Case Is = 1
                Return 425
            Case Is = 2
                Return 675
            Case Is = 3
                Return 925
            Case Is = 4
                Return 1175
            Case Else
                Return 425
        End Select
    End Function

    Private Function ColGrade(fColuna As Integer)
        Select Case fColuna
            Case Is = 1
                Return 4
            Case Is = 2
                Return 124
            Case Is = 3
                Return 244
            Case Is = 4
                Return 363
            Case Else
                Return 4
        End Select
    End Function

    Private Function CalcularLinha(fYps As Integer)
        Select Case fYps
            Case Is = 20
                Return 1
            Case Is = 220
                Return 2
            Case Is = 420
                Return 3
            Case Is = 620
                Return 4
            Case Else
                Return 1
        End Select
    End Function

    Private Function CalcularColuna(fXis As Integer)
        Select Case fXis
            Case Is = 425
                Return 1
            Case Is = 675
                Return 2
            Case Is = 925
                Return 3
            Case Is = 1175
                Return 4
            Case Else
                Return 1
        End Select
    End Function

    Private Sub txtLin_TextChanged(sender As Object, e As EventArgs) Handles txtLin.TextChanged
        If IsNumeric(txtLin.Text) Then
            If Int(txtLin.Text) > 0 And Int(txtLin.Text) < 5 Then
                Select Case cbModulo.Text
                    Case Is = "Compras"
                        btnCompras.Location = New System.Drawing.Point(ColGrade(txtCol.Text), LinGrade(txtLin.Text))
                        mdiDesktop.btnCompras.Location = New System.Drawing.Point(CalcularColuna(txtCol.Text), CalcularLinha(txtLin.Text))
                End Select
            End If
        End If

    End Sub

End Class