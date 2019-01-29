Imports CoreAPI

Public Class Frm_Registrar_Proyecto
    Dim idUsuario As String = SessionManager.GetInstance.GetFinalUser.Id 'Me imagino que el id del usuario lo toma del que inició sesión.

    Private Sub Btn_registrar_Click(sender As Object, e As EventArgs) Handles Btn_registrar.Click
        If Txt_idCliente.Text = "" Or Txt_nombre.Text = "" Or Txt_descripcion.Text = "" Or Txt_industria.Text = "" Then
            MsgBox("Por favor llene todos los campos", vbExclamation, "Formulario incompleto")
        Else
            Dim fechaInicio As DateTime = DateTime.Now.Date
            Dim fechaFinal As DateTime = Calendario.SelectionEnd.Date

            Dim fechaI As String = fechaInicio.ToString("d")
            Dim fechaF As String = fechaFinal.ToString("d")

            Dim InfoProyecto As New Dictionary(Of String, String) From {
                {"IdUsuario", idUsuario},
                {"IdCliente", Txt_idCliente.Text},
                {"Nombre", Txt_nombre.Text},
                {"Industria", Txt_industria.Text},
                {"Descripcion", Txt_descripcion.Text},
                {"FechaInicio", fechaI},
                {"FechaFinal", fechaF}
            }

            Dim RestClient As New Rest
            Dim response = RestClient.PostRequest(InfoProyecto, "http://localhost:65509/api/Proyecto")

            If response Is Nothing Then
                MsgBox("No se pudo registrar el proyecto", vbCritical, "Error")
            Else
                MsgBox("El proyecto ha sido registrado", vbInformation, "Éxito")
            End If

            Txt_idCliente.Clear()
            Txt_nombre.Clear()
            Txt_descripcion.Clear()
            Txt_industria.Clear()

        End If
    End Sub

    Private Sub Btn_Volver_Click(sender As Object, e As EventArgs) Handles Btn_Volver.Click
        Frm_Listar_Proyectos.Listar_Proyectos()
        Me.Visible = False
        Frm_Menu_Principal.Visible = True
    End Sub
End Class