Imports System.Data.OleDb

Public Class frmAltSenha

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Dim cSql As String = ""
        Dim cMensagem As String = ""
        Dim cmd As OleDbCommand
        Dim cUsuario As String

        If Not txtNovaSenha1.Text = txtNovaSenha2.Text Then
            MsgBox("As novas senhas não conferem")
            Exit Sub
        End If

        'g_login
        cUsuario = LerUsuario(g_Param(1), txtOldPass.Text)
        If cUsuario <> "" Then
            If ConectarBanco() Then
                cSql = "UPDATE ESI000 set SI000_PASLGI='" & ClassCrypt.Encrypt(txtNovaSenha1.Text) & _
                                "', SI000_ALTPAS=0" & _
                                " where SI000_LGIUSU = '" & g_Param(1) & "'"
                'acessoWEB=" & If(chkSIM.Checked = 0, False, True)
            End If
            cmd = New OleDbCommand(cSql, g_ConnectBanco)

            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.ToString())
            Finally
                Me.Close()
            End Try
        End If

    End Sub
End Class