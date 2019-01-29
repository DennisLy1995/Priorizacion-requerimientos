Imports CoreAPI
Imports Newtonsoft.Json
Imports WebAPI.Models

Public Class Frm_Perfil_Usuario
    Private Sub Frm_Perfil_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lb_Id.Text = SessionManager.GetInstance.GetFinalUser.Id
        Lb_Correo.Text = SessionManager.GetInstance.GetFinalUser.Email
        Lb_Nombre.Text = SessionManager.GetInstance.GetFinalUser.Name
        Lb_Apellido.Text = SessionManager.GetInstance.GetFinalUser.LastName
        Lb_usuario.Text = SessionManager.GetInstance.GetFinalUser.UserName
    End Sub

    Private Sub Btn_modificar_Click(sender As Object, e As EventArgs) Handles Btn_modificar.Click
        Dim vw As New Frm_Modificar_Usuario
        vw.Show()
        Close()
    End Sub

    Private Sub Btn_eliminar_Click(sender As Object, e As EventArgs) Handles Btn_eliminar.Click
        If MessageBox.Show("¿Desea eliminar su usuario?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim client As New Rest
            Dim json = client.Delete(CreateJson(), "http://localhost:65509/api/user/")
            Dim response = JsonConvert.DeserializeObject(Of ApiResponse)(json)
            MessageBox.Show(response.Message, "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            SessionManager.GetInstance.LogOut()
            Me.Hide()
            Frm_iniciar_sesion.Show()
            Me.Close()
        End If
    End Sub

    Private Sub CloseAll()
        For Each form As Form In Application.OpenForms
            If Not (form.Equals(Frm_iniciar_sesion)) Then
                form.Close()
            End If
        Next
    End Sub

    Private Function CreateJson() As Object
        Dim dic As New Dictionary(Of String, String) From {
            {"UserName", SessionManager.GetInstance.GetFinalUser.UserName}
        }
        Return dic
    End Function

    'Eventos del click del menu lateral'
    Private Sub Btn_perfil_Click(sender As Object, e As EventArgs) Handles Btn_perfil.Click, Jb_perfil.Click, img_perfil.Click
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
End Class