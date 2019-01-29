Imports CoreAPI
Imports Entities_POJO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports WebAPI.Models

Public Class Frm_Modificar_Proyecto
    Dim idUsuario As String = SessionManager.GetInstance.GetFinalUser.Id 'Me imagino que el id del usuario lo toma del que inició sesión.
    Dim proyecto = New Proyecto()

    Public Sub recibirProyecto(pro As Proyecto)
        proyecto = pro
    End Sub

    Private Sub Frm_Modificar_Proyecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RestProyecto As New Rest
        Dim JsonData As JObject = RestProyecto.GetRequest("http://localhost:65509/api/Proyecto?idUsuario=" + idUsuario + "&nombre=" + proyecto.Nombre)
        Dim pro As String = JsonConvert.SerializeObject(JsonData.SelectToken("Data"))
        proyecto = JsonConvert.DeserializeObject(Of Proyecto)(pro)

        Me.Txt_idCliente.Text = proyecto.IdCliente
        Me.Txt_nombre.Text = proyecto.Nombre
        Me.Txt_descripcion.Text = proyecto.Descripcion
        Me.Txt_industria.Text = proyecto.Industria
        Calendario.SetDate(DateTime.Parse(proyecto.FechaFinal))
    End Sub

    Private Sub Btn_volver_Click(sender As Object, e As EventArgs) Handles Btn_volver.Click
        Me.Visible = False
        Frm_Listar_Proyectos.Visible = True
    End Sub

    Private Sub Btn_modifcar_Click(sender As Object, e As EventArgs) Handles Btn_modifcar.Click
        If Txt_idCliente.Text = "" Or Txt_nombre.Text = "" Or Txt_descripcion.Text = "" Or Txt_industria.Text = "" Then
            MsgBox("Por favor no dejar campos en blanco", vbExclamation, "Formulario incompleto")
        Else
            Dim respuesta = MsgBox("¿Desea modificar el proyecto con estos datos?", vbYesNo + vbExclamation, "Modificar proyecto")
            Select Case respuesta
                Case vbYes
                    Modificar_Proyecto()
                Case vbNo
                    MsgBox("Operación cancelada", vbExclamation, "Cancelado")
            End Select
        End If
    End Sub

    Private Sub Modificar_Proyecto()
        Dim fechaFinal As DateTime = Calendario.SelectionEnd.Date
        Dim fechaF As String = fechaFinal.ToString("d")

        Dim InfoProyecto As New Dictionary(Of String, String)
        InfoProyecto.Add("IdProyecto", proyecto.IdProyecto)
        InfoProyecto.Add("Nombre", Txt_nombre.Text)
        InfoProyecto.Add("Industria", Txt_industria.Text)
        InfoProyecto.Add("Descripcion", Txt_descripcion.Text)
        InfoProyecto.Add("FechaFinal", fechaF)

        Dim RestClient As New Rest
        Dim json = RestClient.Put(InfoProyecto, "http://localhost:65509/api/Proyecto/")
        Dim response = JsonConvert.DeserializeObject(Of ApiResponse)(json)

        Frm_Listar_Proyectos.Listar_Proyectos()

        If response Is Nothing Then
            MsgBox("No se pudo modificar el proyecto", vbCritical, "Error")
        Else
            MsgBox("El proyecto ha sido actualizado", vbInformation, "Éxito")
        End If

        Txt_idCliente.Clear()
        Txt_nombre.Clear()
        Txt_descripcion.Clear()
        Txt_industria.Clear()

        Me.Visible = False
        Frm_Listar_Proyectos.Visible = True
    End Sub
End Class