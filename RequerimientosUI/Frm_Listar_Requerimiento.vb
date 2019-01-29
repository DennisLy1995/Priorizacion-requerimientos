Imports Entities_POJO
Imports Newtonsoft.Json.Linq
Imports Newtonsoft.Json


Public Class Frm_Listar_Requerimiento
    Private Sub Frm_Listar_Casos_De_Uso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RestClient As New Rest
        BtnVisualizarRequerimientos.Enabled = False
        Dim JsonData As JObject = RestClient.GetRequest("http://localhost:65509/api/CasoDeUso")
        Dim ListaCU As New List(Of CasoDeUso)
        For Each Caso In JsonData.SelectToken("Data")

            Dim CU As String = JsonConvert.SerializeObject(Caso)
            ListaCU.Add(JsonConvert.DeserializeObject(Of CasoDeUso)(CU))
        Next
        DataGridRequerimientos.DataSource = ListaCU
        LblUpdate.Hide()

    End Sub

    Private Sub BtnAgregarCasosDeUso_Click(sender As Object, e As EventArgs) Handles BtnAgregarRequerimiento.Click
        Me.Hide()
        Frm_Registrar_Requerimiento.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridRequerimientos.CellContentClick

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

                DataGridRequerimientos.DataSource = ListaCU
            End If
        Else
            BtnVisualizarRequerimientos.Enabled = False
            Dim JsonData As JObject = RestClient.GetRequest("http://localhost:65509/api/CasoDeUso")
            Dim ListaCU As New List(Of CasoDeUso)
            For Each Caso In JsonData.SelectToken("Data")

                Dim CU As String = JsonConvert.SerializeObject(Caso)
                ListaCU.Add(JsonConvert.DeserializeObject(Of CasoDeUso)(CU))
            Next
            DataGridRequerimientos.DataSource = ListaCU
            LblUpdate.Hide()
        End If


    End Sub
End Class