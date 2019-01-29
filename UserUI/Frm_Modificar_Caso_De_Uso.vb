Imports Entities_POJO
Imports Newtonsoft.Json

Public Class Frm_Modificar_Caso_De_Uso
    Private Sub BtnGuardarCambiosCU_Click(sender As Object, e As EventArgs) Handles BtnGuardarCambiosCU.Click
        If Txt_Codigo.Text = "" Or Txt_Descripcion.Text = "" Or Txt_Nombre.Text = "" Then
            MsgBox("Llene los campos necesarios")
        Else
            Dim RestClient As New Rest
            Dim InformacionCasoDeUso As New Dictionary(Of String, String)
            InformacionCasoDeUso.Add("CODIGO", Txt_Codigo.Text)
            InformacionCasoDeUso.Add("NOMBRE", Txt_Nombre.Text)
            InformacionCasoDeUso.Add("DESCRIPCION", Txt_Descripcion.Text)
            Dim json = RestClient.Put(InformacionCasoDeUso, "http://localhost:65509/api/CasoDeUso")
            Txt_Descripcion.Text = ""
            Txt_Nombre.Text = ""
            Txt_Codigo.Text = ""
            Dim response = JsonConvert.DeserializeObject(Of ApplicationMessage)(json)
            MsgBox(response.Message)
        End If
    End Sub

    Private Sub BtnCancelarCambiosCU_Click(sender As Object, e As EventArgs) Handles BtnCancelarCambiosCU.Click
        Frm_Listar_Casos_De_Uso.Show()
        Me.Close()
    End Sub
End Class