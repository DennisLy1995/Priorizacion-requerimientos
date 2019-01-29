Imports CoreAPI
Imports Newtonsoft.Json
Imports SimpleJson

Public Class Frm_Registrar_Requerimiento
    Private Sub Frm_Registrar_Caso_De_Uso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnRegistrarCasoDeUso_Click(sender As Object, e As EventArgs) Handles BtnRegistrarReq.Click
        If Txt_Proyecto.Text = "" Or Txt_Descripcion.Text = "" Then
            LabelMensaje.Text = "Por favor ingrese la descripcion y el proyecto."
        Else
            LabelMensaje.Text = ""
            Dim InformacionRequerimiento As New Dictionary(Of String, String)
            'BLOQUE PARA DAR NUMERO INCREMENTAL AL CODIGO DEL REQUERIMIENTO.
            Dim RestC As New Rest
            Dim resp As Int32 = RestC.GetRequestCounter("http://localhost:65509/api/Requerimiento/GetByID_Proyecto/" + Convert.ToString(Txt_Proyecto.Text))
            resp = (resp + 1)
            InformacionRequerimiento.Add("CODIGO", "Req-Proy" + Txt_Proyecto.Text + "-" + Convert.ToString(resp))

            If CheckBox_Urgencia.Checked = True Then
                InformacionRequerimiento.Add("PRIORIDAD", "3")
            Else
                InformacionRequerimiento.Add("PRIORIDAD", "0")
            End If

            InformacionRequerimiento.Add("DESCRIPCION", Txt_Descripcion.Text)
            InformacionRequerimiento.Add("ID_PROYECTO", Txt_Proyecto.Text)
            InformacionRequerimiento.Add("ESTADO", "true")

            Dim RestClient As New Rest
            Dim response = RestClient.PostRequest(InformacionRequerimiento, "http://localhost:65509/api/Requerimiento")
            MessageBox.Show(response)
            If response Is Nothing Then
                LabelMensaje.Text = "Verifique que el numero de proyecto sea correcto."
            Else
                LabelMensaje.Text = "Se registró un nuevo requerimiento"
            End If
            Txt_Proyecto.Text = ""
            Txt_Descripcion.Text = ""
        End If

    End Sub

    'Evento usado para pruebas del form listar requerimientos.
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim FormListarRequerimientos As New Frm_Listar_Requerimiento
        FormListarRequerimientos.Show()
    End Sub
End Class
