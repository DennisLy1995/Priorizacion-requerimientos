Imports CoreAPI
Imports Entities_POJO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Frm_Listar_Proyectos
    Dim idUsuario As String = SessionManager.GetInstance.GetFinalUser.Id 'Me imagino que el id del usuario lo toma del que inició sesión.
    Dim proyecto = New Proyecto()

    Private Sub Frm_Listar_Proyectos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar_Proyectos()
        Btn_Desactivar.Hide()
        Btn_Modificar.Hide()
    End Sub

    Private Sub Btn_registrar_Click(sender As Object, e As EventArgs) Handles Btn_registrar.Click
        Me.Visible = False
        Frm_Registrar_Proyecto.Visible = True
    End Sub

    Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click
        Dim RestProyecto As New Rest
        If Not Txt_Buscar.Text = "" Then
            Dim JsonData As JObject = RestProyecto.GetRequest("http://localhost:65509/api/Proyecto?idUsuario=" + idUsuario + "&nombre=" + Txt_Buscar.Text)
            Dim LstPro As New List(Of Proyecto)
            If JsonData Is Nothing Then
                MsgBox("El proyecto solicitado no se encuentra registrado", vbExclamation, "No encontrado")
                Txt_Buscar.Clear()
            Else

                Txt_Buscar.Clear()
                Dim pro As String = JsonConvert.SerializeObject(JsonData.SelectToken("Data"))
                LstPro.Add(JsonConvert.DeserializeObject(Of Proyecto)(pro))

                DataGridViewProyecto.DataSource = LstPro

            End If
        Else
            Listar_Proyectos()
        End If
    End Sub

    Public Sub Listar_Proyectos()
        Dim RestProyecto As New Rest
        Dim JsonData As JObject = RestProyecto.GetRequest("http://localhost:65509/api/Proyecto")
        Dim LstPro As New List(Of Proyecto)
        For Each proy In JsonData.SelectToken("Data")
            Dim pro As String = JsonConvert.SerializeObject(proy)
            LstPro.Add(JsonConvert.DeserializeObject(Of Proyecto)(pro))
        Next
        DataGridViewProyecto.DataSource = LstPro
    End Sub

    Private Sub Btn_Desactivar_Click(sender As Object, e As EventArgs) Handles Btn_Desactivar.Click
        Dim respuesta = MsgBox("¿Desea desactivar este proyecto?", vbYesNo + vbExclamation, "Desactivar proyecto")
        Select Case respuesta
            Case vbYes
                Desactivar_Proyecto()
                MsgBox("El proyecto se ha desactivado", vbInformation, "Desactivado")
            Case vbNo
                MsgBox("Operación cancelada", vbExclamation, "Cancelado")
        End Select
    End Sub

    Private Sub DataGridViewProyecto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProyecto.CellClick
        Btn_Desactivar.Show()
        Btn_Modificar.Show()
        proyecto.IdProyecto = CInt(DataGridViewProyecto.CurrentRow.Cells("IdProyecto").Value)
        proyecto.Nombre = CStr(DataGridViewProyecto.CurrentRow.Cells("Nombre").Value)
    End Sub

    Private Sub Desactivar_Proyecto()
        Dim infoProyecto As New Dictionary(Of String, String)
        infoProyecto.Add("IdProyecto", proyecto.IdProyecto)
        Dim ApiRest As New Rest

        Dim val As Integer = proyecto.IdProyecto

        Dim json = ApiRest.Delete(infoProyecto, "http://localhost:65509/api/Proyecto?idProyecto=" + proyecto.IdProyecto.ToString)
        Dim response = JsonConvert.DeserializeObject(Of ApplicationMessage)(json)
        proyecto = Nothing
        Listar_Proyectos()
    End Sub

    Private Sub Btn_Modificar_Click(sender As Object, e As EventArgs) Handles Btn_Modificar.Click
        Frm_Modificar_Proyecto.recibirProyecto(proyecto)
        Me.Visible = False
        Frm_Modificar_Proyecto.Visible = True
        proyecto = Nothing
    End Sub

    'Eventos del click del menu lateral'
    Private Sub Btn_perfil_Click(sender As Object, e As EventArgs) Handles Btn_perfil.Click, Jb_perfil.Click, img_perfil.Click
        Frm_Perfil_Usuario.Show()
        Close()
    End Sub

    Private Sub Btn_proyecto_Click(sender As Object, e As EventArgs) Handles Btn_proyecto.Click, Jb_proyecto.Click, img_pro.Click
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