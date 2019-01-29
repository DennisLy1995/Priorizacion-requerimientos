Imports Entities_POJO
Imports Newtonsoft.Json

Public Class Frm_Registrar_Caso_De_Uso
    Private Sub Frm_Registrar_Caso_De_Uso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnRegistrarCasoDeUso_Click(sender As Object, e As EventArgs) Handles BtnRegistrarCasoDeUso.Click
        If Txt_Codigo.Text = "" Or Txt_Nombre.Text = "" Or Txt_Descripcion.Text = "" Then
            MsgBox("Por favor llene todos los campos")
        Else
            LblUpdateText.Text = ""
            Dim RestClient As New Rest
            Dim InformacionCasoDeUso As New Dictionary(Of String, String)
            InformacionCasoDeUso.Add("CODIGO", Txt_Codigo.Text)
            InformacionCasoDeUso.Add("ID_PROYECTO", 6)
            InformacionCasoDeUso.Add("PRIORIDAD", 0)
            InformacionCasoDeUso.Add("NOMBRE", Txt_Nombre.Text)
            InformacionCasoDeUso.Add("DESCRIPCION", Txt_Descripcion.Text)
            Dim json = RestClient.Post(InformacionCasoDeUso, "http://localhost:65509/api/CasoDeUso")
            Txt_Codigo.Text = ""
            Txt_Descripcion.Text = ""
            Txt_Nombre.Text = ""
            Dim response = JsonConvert.DeserializeObject(Of ApplicationMessage)(json)
            MsgBox(response.Message)
        End If

    End Sub

    Private Sub Btn_Volver_Click(sender As Object, e As EventArgs) Handles Btn_Volver.Click

        Frm_Listar_Casos_De_Uso.Show()
        Me.Close()
    End Sub


    ''Este boton solo se agrego para poder probar el registrar requerimientos.
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim registrarRequerimientos As Frm_Registrar_Requerimiento = New Frm_Registrar_Requerimiento()
    '    registrarRequerimientos.Show()
    'End Sub

    ''Este boton solo se agrego para poder probar el registrar requerimientos.
    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim listarRequerimientos As Frm_Listar_Requerimiento = New Frm_Listar_Requerimiento()
    '    listarRequerimientos.Show()
    'End Sub
End Class
