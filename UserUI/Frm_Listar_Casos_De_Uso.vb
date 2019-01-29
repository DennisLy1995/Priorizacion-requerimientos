Imports Entities_POJO
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json
Imports CoreAPI

Public Class Frm_Listar_Casos_De_Uso
    Private Sub Frm_Listar_Casos_De_Uso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RestClient As New Rest
        BtnVisualizarRequerimientos.Enabled = False
        Dim JsonData As JObject = RestClient.GetRequest("http://localhost:65509/api/CasoDeUso")
        Dim ListaCU As New List(Of CasoDeUso)
        For Each Caso In JsonData.SelectToken("Data")

            Dim CU As String = JsonConvert.SerializeObject(Caso)
            ListaCU.Add(JsonConvert.DeserializeObject(Of CasoDeUso)(CU))
        Next
        DataGridCasosDeUso.DataSource = ListaCU
        LblUpdate.Hide()

    End Sub

    Private Sub BtnAgregarCasosDeUso_Click(sender As Object, e As EventArgs) Handles BtnAgregarCasosDeUso.Click
        Me.Hide()
        Frm_Registrar_Caso_De_Uso.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridCasosDeUso.CellContentClick

    End Sub

    Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click
        Dim RestClient As New Rest
        If Not Txt_Buscar.Text = "" Then
            BtnVisualizarRequerimientos.Enabled = False
            Dim JsonData As JObject = RestClient.GetRequest("http://localhost:65509/api/CasoDeUso?code=" + Txt_Buscar.Text)
            Dim ListaCU As New List(Of CasoDeUso)
            If JsonData Is Nothing Then
                LblUpdate.Text = "No se encontró el registro."
                LblUpdate.Show()
                Txt_Buscar.Text = ""
            Else
                LblUpdate.Hide()
                Txt_Buscar.Text = ""
                Dim CU As String = JsonConvert.SerializeObject(JsonData.SelectToken("Data"))
                ListaCU.Add(JsonConvert.DeserializeObject(Of CasoDeUso)(CU))

                DataGridCasosDeUso.DataSource = ListaCU
            End If
        Else
            BtnVisualizarRequerimientos.Enabled = False
            Dim JsonData As JObject = RestClient.GetRequest("http://localhost:65509/api/CasoDeUso")
            Dim ListaCU As New List(Of CasoDeUso)
            For Each Caso In JsonData.SelectToken("Data")

                Dim CU As String = JsonConvert.SerializeObject(Caso)
                ListaCU.Add(JsonConvert.DeserializeObject(Of CasoDeUso)(CU))
            Next
            DataGridCasosDeUso.DataSource = ListaCU
            LblUpdate.Hide()
        End If


    End Sub

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

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Me.Hide()
        Frm_Modificar_Caso_De_Uso.Show()
        Me.Close()
    End Sub
End Class