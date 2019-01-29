Imports CoreAPI
Imports Newtonsoft.Json
Imports WebAPI.Models

Public Class Frm_Modificar_Usuario
    Dim lstInfo As Dictionary(Of String, String)

    Public Sub InitDictionary()
        lstInfo = New Dictionary(Of String, String) From {
            {"Id", Txt_identificacion.Text},
            {"Email", txt_correo.Text},
            {"Name", Txt_nombre1.Text},
            {"LastName", Txt_apellido1.Text},
            {"UserName", Txt_nomUsuario.Text},
            {"Password", SessionManager.GetInstance.GetFinalUser.Password}
        }
    End Sub

    Private Sub Frm_Modificar_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txt_identificacion.Text = SessionManager.GetInstance.GetFinalUser.Id
        Txt_identificacion.Enabled = False
        Txt_nombre1.Text = SessionManager.GetInstance.GetFinalUser.Name
        Txt_apellido1.Text = SessionManager.GetInstance.GetFinalUser.LastName
        Txt_nomUsuario.Text = SessionManager.GetInstance.GetFinalUser.UserName
        Txt_nomUsuario.Enabled = False
        txt_correo.Text = SessionManager.GetInstance.GetFinalUser.Email
    End Sub

    Private Sub Btn_modificar_Click(sender As Object, e As EventArgs) Handles Btn_modificar.Click
        If IsBoxEmpty() Then
            InitDictionary()
            Dim client As New Rest
            Dim json = client.Put(lstInfo, "http://localhost:65509/api/user/")
            Dim response = JsonConvert.DeserializeObject(Of ApiResponse)(json)
            MessageBox.Show(response.Message, "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim usuario = SessionManager.GetInstance.GetFinalUser.UserName
            Dim clave = SessionManager.GetInstance.GetFinalUser.Password
            SessionManager.GetInstance.LogIn(usuario, clave)
            Clear()
        End If
    End Sub

    Private Sub Clear()
        Dim vw As New Frm_Perfil_Usuario
        vw.Show()
        Close()
    End Sub

    Private Function IsBoxEmpty() As Boolean
        If Txt_nombre1.Text = "" Or Txt_apellido1.Text = "" Or txt_correo.Text = "" Then
            MessageBox.Show("Por favor, llene los campos", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function
End Class