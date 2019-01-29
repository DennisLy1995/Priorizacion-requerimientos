Imports CoreAPI

Public Class Frm_Menu_Principal
    'Eventos del click del menu lateral'
    Private Sub Btn_perfil_Click(sender As Object, e As EventArgs) Handles Btn_perfil.Click, Jb_perfil.Click, img_perfil.Click
        Frm_Perfil_Usuario.Show()
        Close()
    End Sub

    Private Sub Btn_proyecto_Click(sender As Object, e As EventArgs) Handles Btn_proyecto.Click, Jb_proyecto.Click, img_pro.Click
        Frm_Listar_Proyectos.Show()
        Close()
    End Sub

    Private Sub Btn_req_Click(sender As Object, e As EventArgs) Handles Btn_req.Click, Lb_req.Click, img_req.Click
        Frm_Listar_Requerimiento.Show()
        Close()
    End Sub

    Private Sub Btn_cu_Click(sender As Object, e As EventArgs) Handles Btn_cu.Click, Jb_cu.Click, img_cu.Click
        Frm_Listar_Casos_De_Uso.Show()
        Close()
    End Sub

    Private Sub Btn_cliente_Click(sender As Object, e As EventArgs) Handles Btn_cliente.Click, Jb_cliente.Click, img_cliente.Click

    End Sub

    Private Sub Btn_salir_Click(sender As Object, e As EventArgs) Handles Btn_salir.Click, Jb_salir.Click, img_salir.Click
        If MessageBox.Show("¿Seguro que desea salir?", "Aviso",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            SessionManager.GetInstance.LogOut()
            Frm_iniciar_sesion.Show()
            Close()
        End If

    End Sub

    'Estilos de los botones del menu lateral'
    Private Sub Btn_req_MouseHover(sender As Object, e As EventArgs) Handles Btn_req.MouseHover, Lb_req.MouseHover, img_req.MouseHover
        Btn_req.BackColor = Color.FromArgb(19, 79, 92)
        Btn_req.Cursor = Cursors.Hand
    End Sub

    Private Sub Btn_req_MouseLeave(sender As Object, e As EventArgs) Handles Btn_req.MouseLeave, Lb_req.MouseLeave, img_req.MouseLeave
        Btn_req.BackColor = Color.FromArgb(12, 52, 61)
    End Sub

    Private Sub Btn_cu_MouseHover(sender As Object, e As EventArgs) Handles Btn_cu.MouseHover, Jb_cu.MouseHover, img_cu.MouseHover
        Btn_cu.BackColor = Color.FromArgb(19, 79, 92)
        Btn_cu.Cursor = Cursors.Hand
    End Sub

    Private Sub Btn_cliente_MouseHover(sender As Object, e As EventArgs) Handles Btn_cliente.MouseHover, Jb_cliente.MouseHover, img_cliente.MouseHover
        Btn_cliente.BackColor = Color.FromArgb(19, 79, 92)
        Btn_cliente.Cursor = Cursors.Hand
    End Sub

    Private Sub Btn_perfil_MouseHover(sender As Object, e As EventArgs) Handles Btn_perfil.MouseHover, Jb_perfil.MouseHover, img_perfil.MouseHover
        Btn_perfil.BackColor = Color.FromArgb(19, 79, 92)
        Btn_perfil.Cursor = Cursors.Hand
    End Sub

    Private Sub Btn_salir_MouseHover(sender As Object, e As EventArgs) Handles Btn_salir.MouseHover, Jb_salir.MouseHover, img_salir.MouseHover
        Btn_salir.BackColor = Color.FromArgb(19, 79, 92)
        Btn_salir.Cursor = Cursors.Hand
    End Sub

    Private Sub Btn_cu_MouseLeave(sender As Object, e As EventArgs) Handles Btn_cu.MouseLeave, Jb_cu.MouseLeave, img_cu.MouseLeave
        Btn_cu.BackColor = Color.FromArgb(12, 52, 61)
    End Sub

    Private Sub Btn_cliente_MouseLeave(sender As Object, e As EventArgs) Handles Btn_cliente.MouseLeave, Jb_cliente.MouseLeave, img_cliente.MouseLeave
        Btn_cliente.BackColor = Color.FromArgb(12, 52, 61)
    End Sub

    Private Sub Btn_perfil_MouseLeave(sender As Object, e As EventArgs) Handles Btn_perfil.MouseLeave, Jb_perfil.MouseLeave, img_perfil.MouseLeave
        Btn_perfil.BackColor = Color.FromArgb(12, 52, 61)
    End Sub

    Private Sub Btn_salir_MouseLeave(sender As Object, e As EventArgs) Handles Btn_salir.MouseLeave, Jb_salir.MouseLeave, img_salir.MouseLeave
        Btn_salir.BackColor = Color.FromArgb(12, 52, 61)
    End Sub

    'Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    '    Dim vm As New Frm_Listar_Requerimiento
    '    vm.Show()
    'End Sub
End Class