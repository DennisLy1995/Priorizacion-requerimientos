Imports Entities_POJO
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json


Public Class Frm_Listar_Requerimiento

    Private Sub BtnAgregarCasosDeUso_Click(sender As Object, e As EventArgs) Handles BtnAgregarRequerimiento.Click
        Me.Hide()
        Frm_Registrar_Requerimiento.Show()
        Me.Close()
    End Sub

    Private Sub Btn_Buscar_Click(sender As Object, e As EventArgs) Handles Btn_Buscar.Click
        If Txt_Buscar.Text = "" Then
            LabelMensaje.Text = "Por favor ingrese la descripcion y el proyecto."
        Else
            LabelMensaje.Text = ""

            Dim RestClient As New Rest
            Dim response = RestClient.GetRequest("http://localhost:65509/api/Requerimiento/GetByCodigo/" + Txt_Buscar.Text)
            If response Is Nothing Then
                LabelMensaje.Text = "No se ha encontrado ningun requerimiento con el codigo" + Txt_Buscar.Text
                Txt_Buscar.Text = ""
            Else
                Dim valorJson As String = JsonConvert.SerializeObject(response.SelectToken("Data"))
                Dim Requerimiento As Requerimientos = JsonConvert.DeserializeObject(Of Requerimientos)(valorJson)
                Dim ListaReq As New List(Of Requerimientos)
                ListaReq.Add(Requerimiento)
                DataGridRequerimientos.DataSource = ListaReq
                Btn_Buscar.Visible = False
                Btn_Listar.Visible = True
                Txt_Buscar.Visible = False
            End If

            If response Is Nothing Then
                LabelMensaje.Text = "Verifique que el codigo sea correcto."
            Else
                LabelMensaje.Text = "Se localizo el requerimiento"
            End If
            Txt_Buscar.Text = ""
        End If
    End Sub

    Private Sub Frm_Listar_Requerimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RestClient As New Rest
        Dim JsonData As JObject = RestClient.GetRequest("http://localhost:65509/api/Requerimiento")
        Dim ListaReq As New List(Of Requerimientos)
        For Each Requerimiento In JsonData.SelectToken("Data")

            Dim Req As String = JsonConvert.SerializeObject(Requerimiento)
            ListaReq.Add(JsonConvert.DeserializeObject(Of Requerimientos)(Req))
        Next
        DataGridRequerimientos.DataSource = ListaReq
        LblUpdate.Hide()
    End Sub

    Private Sub DataGridRequerimientos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridRequerimientos.CellContentClick

    End Sub

    Private Sub ButtonListar_Click(sender As Object, e As EventArgs) Handles Btn_Listar.Click
        Dim RestClient As New Rest
        Dim JsonData As JObject = RestClient.GetRequest("http://localhost:65509/api/Requerimiento")
        Dim ListaReq As New List(Of Requerimientos)
        For Each Requerimiento In JsonData.SelectToken("Data")

            Dim Req As String = JsonConvert.SerializeObject(Requerimiento)
            ListaReq.Add(JsonConvert.DeserializeObject(Of Requerimientos)(Req))
        Next
        DataGridRequerimientos.DataSource = ListaReq
        LblUpdate.Hide()
        Btn_Listar.Visible = False
        Btn_Buscar.Visible = True
        Txt_Buscar.Visible = True
    End Sub

    Private Sub ButtonPriorizar_Click(sender As Object, e As EventArgs) Handles ButtonPriorizar.Click
        Me.Hide()
        Frm_priorizar_requerimientos.Show()
        Me.Close()
    End Sub
End Class