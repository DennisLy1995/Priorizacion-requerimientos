Imports CoreAPI
Imports Entities_POJO
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Frm_priorizar_requerimientos

    'Dim objApp As Excel.Application
    'Dim objBook As Excel._Workbook
    Dim FilaUltimoRequerimiento As Int32 = 0
    Dim ColumnaValorPrioridades As Int32 = 0
    Dim Requerimientos() As String

    'Evento de lectura de los valores del archivo de excel.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCalcularHoja.Click

        If TextBoxInteresados.Text = "" Then
            MessageBox.Show("Ingrese la cantidad de actores, tiene un limite de 9.")
        Else
            Try
                Dim valorLectura As Int32 = Int32.Parse(TextBoxInteresados.Text)

                If valorLectura <= 9 And valorLectura > 0 Then

                    Label4.Text = "Procesando hoja de calculos."
                    Dim altoCeldas = 30
                    Dim anchoCeldas = 15
                    Dim total As Int32 = 0
                    Dim InicioDesarrollo As Int32 = 0

                    Dim excelApp = New Microsoft.Office.Interop.Excel.Application
                    Dim Libro = excelApp.Workbooks.Add
                    'En caso de que quiera leer un archivo ya existente

                    For i As Integer = 0 To Requerimientos.Length - 1
                        Libro.Sheets(1).cells(i + 4, 1) = Requerimientos(i)
                        Libro.Sheets(1).cells(i + 4, 1).ColumnWidth = 50
                        total = i + 5
                    Next

                    Libro.Sheets(1).cells(1, 1) = "Relative Weights"
                    Libro.Sheets(1).cells(3, 1) = "Feature"
                    Libro.Sheets(1).cells(total, 1) = "Total"


                    Dim cantidadInteresados As Int32 = Convert.ToInt32(TextBoxInteresados.Text)
                    For i As Integer = 2 To (cantidadInteresados * 2) + 1
                        Libro.Sheets(1).cells(3, i) = "Relative benefit"
                        Libro.Sheets(1).cells(3, i).ColumnWidth = anchoCeldas
                        Libro.Sheets(1).cells(3, i).RowHeight = altoCeldas
                        i = i + 1
                    Next

                    'Formula de la hoja de excel
                    For i As Integer = 2 To (cantidadInteresados * 2) + 10
                        Dim valorTemporal As String = Convert.ToString(total - 2)
                        Libro.Sheets(1).cells(total, i) = "=SUM(" + retornarLetra(i) + "4" + ":" + retornarLetra(i) + valorTemporal + ")"
                        Libro.Sheets(1).cells(total, i).ColumnWidth = anchoCeldas
                        Libro.Sheets(1).cells(total, i).RowHeight = altoCeldas
                        i = i + 1
                    Next


                    For i As Integer = 3 To (cantidadInteresados * 2) + 3
                        Libro.Sheets(1).cells(3, i) = "Relative penalty"
                        Libro.Sheets(1).cells(3, i).ColumnWidth = anchoCeldas
                        i = i + 1
                    Next

                    'Formula de la hoja de excel
                    For i As Integer = 3 To (cantidadInteresados * 2) + 10
                        Dim valorTemporal As String = Convert.ToString(total - 2)
                        Libro.Sheets(1).cells(total, i) = "=SUM(" + retornarLetra(i) + "4" + ":" + retornarLetra(i) + valorTemporal + ")"
                        Libro.Sheets(1).cells(total, i).ColumnWidth = anchoCeldas
                        Libro.Sheets(1).cells(total, i).RowHeight = altoCeldas
                        i = i + 1
                    Next

                    Libro.Sheets(1).cells(3, (cantidadInteresados * 2) + 2) = "Total Benefit"
                    Libro.Sheets(1).cells(3, (cantidadInteresados * 2) + 2).ColumnWidth = anchoCeldas

                    'Formula de la hoja de excel: Total Benefit
                    For i As Integer = 4 To Requerimientos.Length + 2
                        Libro.Sheets(1).cells(i, (cantidadInteresados * 2) + 2) = "=" + generarTotalBenefit(i, cantidadInteresados)
                    Next

                    Libro.Sheets(1).cells(3, (cantidadInteresados * 2) + 3) = "Total penalty"
                    Libro.Sheets(1).cells(3, (cantidadInteresados * 2) + 3).ColumnWidth = anchoCeldas

                    'Formula de la hoja de excel: Total Penalty
                    For i As Integer = 4 To Requerimientos.Length + 2
                        Libro.Sheets(1).cells(i, (cantidadInteresados * 2) + 3) = "=" + generarTotalPenalty(i, cantidadInteresados)
                    Next

                    'Formula de la hoja de excel: Total Value
                    Dim benefitColumn As Int32 = (cantidadInteresados * 2) + 2
                    Dim penaltyColum As Int32 = (cantidadInteresados * 2) + 3
                    For i As Integer = 4 To Requerimientos.Length + 2
                        Libro.Sheets(1).cells(i, (cantidadInteresados * 2) + 4) = "=" + retornarLetra(benefitColumn) + Convert.ToString(i) + "*" + retornarLetra(benefitColumn) + "1" + "+" + retornarLetra(penaltyColum) + Convert.ToString(i) + "*" + retornarLetra(penaltyColum) + "1"
                    Next

                    'Formula de la hoja de excel: Value%
                    For i As Integer = 4 To Requerimientos.Length + 2
                        Libro.Sheets(1).cells(i, (cantidadInteresados * 2) + 5) = "= 100*" + retornarLetra(benefitColumn + 1) + Convert.ToString(i) + "/" + retornarLetra(benefitColumn + 1) + Convert.ToString(total)
                    Next

                    'Formula de la hoja de excel: Cost%
                    For i As Integer = 4 To Requerimientos.Length + 2
                        Libro.Sheets(1).cells(i, (cantidadInteresados * 2) + 7) = "= 100*" + retornarLetra(benefitColumn + 4) + Convert.ToString(i) + "/" + retornarLetra(benefitColumn + 4) + Convert.ToString(total)
                    Next

                    'Formula de la hoja de excel: Risk%
                    For i As Integer = 4 To Requerimientos.Length + 2
                        Libro.Sheets(1).cells(i, (cantidadInteresados * 2) + 9) = "= 100*" + retornarLetra(benefitColumn + 6) + Convert.ToString(i) + "/" + retornarLetra(benefitColumn + 6) + Convert.ToString(total)
                    Next

                    InicioDesarrollo = (cantidadInteresados * 2) + 4

                    'Formula de la hoja de excel: Priority
                    Dim valueColumn As Int32 = InicioDesarrollo + 1
                    Dim costColumn As Int32 = InicioDesarrollo + 3
                    Dim riskColumn As Int32 = InicioDesarrollo + 5

                    For i As Integer = 4 To Requerimientos.Length + 2
                        Libro.Sheets(1).cells(i, (cantidadInteresados * 2) + 10) = "=" + retornarLetra(valueColumn) + Convert.ToString(i) + "/(" + retornarLetra(costColumn) + Convert.ToString(i) + "*" + retornarLetra(costColumn - 1) + "1" + "+" + retornarLetra(riskColumn) + Convert.ToString(i) + "*" + retornarLetra(riskColumn - 1) + "1)"
                    Next

                    Libro.Sheets(1).cells(3, InicioDesarrollo) = "Total Value"
                    Libro.Sheets(1).cells(3, InicioDesarrollo).ColumnWidth = anchoCeldas
                    Libro.Sheets(1).cells(3, InicioDesarrollo + 1) = "Value%"
                    Libro.Sheets(1).cells(3, InicioDesarrollo + 1).ColumnWidth = anchoCeldas
                    Libro.Sheets(1).cells(3, InicioDesarrollo + 2) = "Relative Cost"
                    Libro.Sheets(1).cells(3, InicioDesarrollo + 2).ColumnWidth = anchoCeldas
                    Libro.Sheets(1).cells(3, InicioDesarrollo + 3) = "Cost%"
                    Libro.Sheets(1).cells(3, InicioDesarrollo + 3).ColumnWidth = anchoCeldas
                    Libro.Sheets(1).cells(3, InicioDesarrollo + 4) = "Relative Risk"
                    Libro.Sheets(1).cells(3, InicioDesarrollo + 4).ColumnWidth = anchoCeldas
                    Libro.Sheets(1).cells(3, InicioDesarrollo + 5) = "Risk%"
                    Libro.Sheets(1).cells(3, InicioDesarrollo + 5).ColumnWidth = anchoCeldas
                    Libro.Sheets(1).cells(3, InicioDesarrollo + 6) = "Priority"
                    Libro.Sheets(1).cells(3, InicioDesarrollo + 6).ColumnWidth = anchoCeldas

                    Libro.SaveAs("C:\Users\Public\Documents\Prioridad.xlsx")

                    Label4.Text = "Path: C:\Users\Public\Documents\Prioridad.xlsx"
                    ButtonGuardar.Enabled = True
                    ButtonCalcularHoja.Enabled = False
                    TextBoxInteresados.Enabled = False

                    excelApp.ActiveWorkbook.Close()

                    ButtonGuardar.Enabled = True
                    FilaUltimoRequerimiento = total - 2
                    ColumnaValorPrioridades = InicioDesarrollo + 6

                Else
                    MessageBox.Show("Ingrese una cantidad de interesados del 1 al 9")

                End If

            Catch ex As Exception
                Label4.Text = "Upsss algo ha pasado."
                TextBoxInteresados.Enabled = False
                ButtonCalcularHoja.Enabled = False
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click

        Dim excelApp = New Microsoft.Office.Interop.Excel.Application
        Dim Libro = excelApp.Workbooks.Open("C:\Users\Public\Documents\Prioridad.xlsx")
        Dim mng As New RequerimientoManager

        Dim a As String = Libro.Sheets(1).cells(4, 1).text
        Dim Reqs(FilaUltimoRequerimiento - 4) As Requerimientos

        Try
            Dim RestClient As New Rest

            For i As Integer = 4 To FilaUltimoRequerimiento
                Dim req As New Requerimientos
                req.DESCRIPCION = Libro.Sheets(1).cells(i, 1).text
                req.PRIORIDAD = Libro.Sheets(1).cells(i, ColumnaValorPrioridades).text
                Reqs(i - 4) = req

                Dim InformacionCasoDeUso As New Dictionary(Of String, String)
                InformacionCasoDeUso.Add("ID_REQUERIMIENTO", req.ID_REQUERIMIENTO)
                InformacionCasoDeUso.Add("CODIGO", req.CODIGO)
                InformacionCasoDeUso.Add("PRIORIDAD", req.PRIORIDAD)
                InformacionCasoDeUso.Add("DESCRIPCION", req.DESCRIPCION)
                InformacionCasoDeUso.Add("ID_PROYECTO", req.ID_PROYECTO)
                Dim response = RestClient.PutRequest(InformacionCasoDeUso, "http://localhost:65509/api/Requerimiento/PutPrioridad")
                If response Is Nothing Then
                    Label4.Text = "Ocurrió un error"
                Else
                    Label4.Text = "Se guardo el requerimiento"
                End If
            Next

            ButtonSeleccionar.Enabled = True
            ButtonCalcularHoja.Enabled = False
            ButtonGuardar.Enabled = False
            TextBoxProyecto.Enabled = True
            TextBoxProyecto.Text = ""
            TextBoxInteresados.Text = ""

            excelApp.ActiveWorkbook.Close()
        Catch ex As Exception
            Label4.Text = "Revise que todos los requerimientos tengan un valor de prioridad."
            excelApp.ActiveWorkbook.Close()
        End Try

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonSeleccionar.Click

        Try
            Dim RestClient As New Rest
            Dim JsonData As JObject = RestClient.GetRequest("http://localhost:65509/api/Requerimiento")
            Dim ListaReqs As New List(Of Requerimientos)
            For Each req In JsonData.SelectToken("Data")

                Dim requerimiento As String = JsonConvert.SerializeObject(req)

                If JsonConvert.DeserializeObject(Of Requerimientos)(requerimiento).ID_PROYECTO = TextBoxProyecto.Text Then
                    ListaReqs.Add(JsonConvert.DeserializeObject(Of Requerimientos)(requerimiento))
                End If

            Next
            Dim ListaRequerimientos(ListaReqs.Count()) As String
            For Each req As Requerimientos In ListaReqs
                ListaRequerimientos(ListaReqs.IndexOf(req)) = req.DESCRIPCION
            Next

            Requerimientos = ListaRequerimientos
            Label4.Text = "El proyecto fue seleccionado exitosamente."
            TextBoxInteresados.Enabled = True
            TextBoxProyecto.Enabled = False
            ButtonCalcularHoja.Enabled = True
            ButtonSeleccionar.Enabled = False
        Catch ex As Exception
            Label4.Text = "Upss algo ha salido mal."
        End Try

    End Sub

    'Seccion de funciones complementarias
    Function retornarLetra(ByVal columna As Int32) As String
        Dim letra As String = ""
        Select Case [columna]
            Case 1
                letra = "A"
            Case 2
                letra = "B"
            Case 3
                letra = "C"
            Case 4
                letra = "D"
            Case 5
                letra = "E"
            Case 6
                letra = "F"
            Case 7
                letra = "G"
            Case 8
                letra = "H"
            Case 9
                letra = "I"
            Case 10
                letra = "J"
            Case 11
                letra = "K"
            Case 12
                letra = "L"
            Case 13
                letra = "M"
            Case 14
                letra = "N"
            Case 15
                letra = "O"
            Case 16
                letra = "P"
            Case 17
                letra = "Q"
            Case 18
                letra = "R"
            Case 19
                letra = "S"
            Case 20
                letra = "T"
            Case 21
                letra = "U"
            Case 22
                letra = "V"
            Case 23
                letra = "W"
            Case 24
                letra = "X"
            Case 25
                letra = "Y"
            Case 26
                letra = "Z"
        End Select
        Return letra
    End Function

    Function generarTotalBenefit(ByVal row As Int32, ByVal cantidadInteresados As Int32) As String
        Dim Sumatoria As String = ""
        For i As Integer = 2 To (cantidadInteresados * 2) + 1
            Sumatoria = Sumatoria + retornarLetra(i) + Convert.ToString(row) + "*" + retornarLetra(i) + "1" + "/" + sumarPesoTotalInteresados(2, cantidadInteresados) + " + "
            i = i + 1
        Next
        Return Sumatoria + "0"
    End Function

    Function generarTotalPenalty(ByVal row As Int32, ByVal cantidadInteresados As Int32) As String
        Dim Sumatoria As String = ""
        For i As Integer = 3 To (cantidadInteresados * 2) + 1
            Sumatoria = Sumatoria + retornarLetra(i) + Convert.ToString(row) + "*" + retornarLetra(i) + "1" + "/" + sumarPesoTotalInteresados(3, cantidadInteresados) + " + "
            i = i + 1
        Next
        Return Sumatoria + "0"
    End Function

    Function sumarPesoTotalInteresados(ByVal opcion As Int32, ByVal cantidadInteresados As Int32) As String
        Dim Sumatoria As String = ""
        For i As Integer = opcion To (cantidadInteresados * 2) + 1
            Sumatoria = Sumatoria + retornarLetra(i) + "1" + "+"
            i = i + 1
        Next
        Return "(" + Sumatoria + "0)"
    End Function
End Class

