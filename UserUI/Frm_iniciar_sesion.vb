Imports CoreAPI
Imports Exceptions

Public Class Frm_iniciar_sesion
    Private Sub Link_registrarse_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Link_registrarse.LinkClicked
        Me.Hide()
        Frm_registrar_usuario.Show()
        Me.Close()
    End Sub

    Private Sub Btn_iniciar_Click(sender As Object, e As EventArgs) Handles Btn_iniciar.Click
        If Txt_nom_usuario.Text = "" Or Txt_clave.Text = "" Then
            MessageBox.Show("Por favor, llene los campos", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                SessionManager.GetInstance().LogIn(Txt_nom_usuario.Text, Txt_clave.Text)
                MessageBox.Show("Inicio de sesión con éxito", "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Frm_Menu_Principal.Show()
                Txt_nom_usuario.Clear()
                Txt_clave.Clear()
                Hide()
            Catch ex As BusinessException
                MessageBox.Show(ex.AppMessage.Message, "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub
End Class