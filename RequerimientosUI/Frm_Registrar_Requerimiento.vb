Public Class Frm_Registrar_Requerimiento
    Private Sub Frm_Registrar_Caso_De_Uso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnRegistrarCasoDeUso_Click(sender As Object, e As EventArgs) Handles BtnRegistrarReq.Click
        If Txt_Codigo.Text = "" Or Txt_Nombre.Text = "" Or Txt_Descripcion.Text = "" Then
            LblUpdateText.Text = "Por favor llene todos los campos"
        Else
            LblUpdateText.Text = ""
            Dim InformacionCasoDeUso As New Dictionary(Of String, String)
            InformacionCasoDeUso.Add("CODIGO", Txt_Codigo.Text)
            InformacionCasoDeUso.Add("ID_PROYECTO", 6)
            InformacionCasoDeUso.Add("PRIORIDAD", 0)
            InformacionCasoDeUso.Add("NOMBRE", Txt_Nombre.Text)
            InformacionCasoDeUso.Add("DESCRIPCION", Txt_Descripcion.Text)
            Dim RestClient As New Rest
            Dim response = RestClient.PostRequest(InformacionCasoDeUso, "http://localhost:65509/api/CasoDeUso")
            If response Is Nothing Then
                LblUpdateText.Text = "Ocurrió un error"
            Else
                LblUpdateText.Text = "Se registró un nuevo caso de uso"
            End If
            Txt_Codigo.Text = ""
            Txt_Descripcion.Text = ""
            Txt_Nombre.Text = ""
        End If

    End Sub
End Class
