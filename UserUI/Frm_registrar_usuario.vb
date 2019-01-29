Imports Exceptions
Imports Newtonsoft.Json
Imports WebAPI.Models

Public Class Frm_registrar_usuario
    Public LstTextBox As Dictionary(Of String, String)

    Private Sub Btn_registrar_Click(sender As Object, e As EventArgs) Handles Btn_registrar.Click
        If Not IsTextBoxEmpty() Then
            Try
                InitDictionary()
                Dim ApiRest As New Rest
                Dim json = ApiRest.Post(LstTextBox, "http://localhost:65509/api/user/")
                Dim response = JsonConvert.DeserializeObject(Of ApiResponse)(json)
                MessageBox.Show(response.Message, "Aviso",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close()
            Catch ex As BusinessException
                MessageBox.Show(ex.AppMessage.Message, "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub InitDictionary()
        LstTextBox = New Dictionary(Of String, String) From {
            {"Id", Txt_identificacion.Text},
            {"Email", txt_correo.Text},
            {"Name", Txt_nombre1.Text},
            {"LastName", Txt_apellido1.Text},
            {"UserName", Txt_nomUsuario.Text},
            {"Password", Txt_clave.Text}
        }
    End Sub

    Private Function IsTextBoxEmpty() As Boolean
        If Txt_nombre1.Text = "" Or
           Txt_apellido1.Text = "" Or
           Txt_identificacion.Text = "" Or
           txt_correo.Text = "" Or
           Txt_nomUsuario.Text = "" Or
           Txt_clave.Text = "" Then
            MessageBox.Show("Por favor, llene los campos", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End If
        Return False
    End Function

    Private Sub Btn_cancelar_Click(sender As Object, e As EventArgs) Handles Btn_cancelar.Click
        Frm_iniciar_sesion.Show()
        Close()
    End Sub
End Class