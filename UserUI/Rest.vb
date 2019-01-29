Imports System.IO
Imports System.Net
Imports System.Text
Imports Entities_POJO
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports RestSharp

Public Class Rest
    Function PostRequest(ByVal DictionaryData As Dictionary(Of String, String), ByVal URL As String) As String
        Try
            Dim request As WebRequest = WebRequest.Create(URL)
            request.Method = "POST"
            Dim postData As String = JsonConvert.SerializeObject(DictionaryData, Formatting.None)
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(postData)
            request.ContentType = "application/json"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            Console.WriteLine((CType(response, HttpWebResponse)).StatusDescription)
            dataStream = response.GetResponseStream()
            Dim reader As StreamReader = New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            Console.WriteLine(responseFromServer)
            reader.Close()
            dataStream.Close()
            response.Close()
            Return responseFromServer
        Catch ex As Exception
            Console.WriteLine("Error en el PostRequest")
            Console.WriteLine(ex)
            Return Nothing
        End Try

    End Function


    Function PutRequest(ByVal DictionaryData As Dictionary(Of String, String), ByVal URL As String) As String
        Try
            Dim request As WebRequest = WebRequest.Create(URL)
            request.Method = "PUT"
            Dim putData As String = JsonConvert.SerializeObject(DictionaryData, Formatting.None)
            MessageBox.Show(putData)
            Dim byteArray As Byte() = Encoding.UTF8.GetBytes(putData)
            request.ContentType = "application/json"
            request.ContentLength = byteArray.Length
            Dim dataStream As Stream = request.GetRequestStream()
            dataStream.Write(byteArray, 0, byteArray.Length)
            dataStream.Close()
            Dim response As WebResponse = request.GetResponse()
            Console.WriteLine((CType(response, HttpWebResponse)).StatusDescription)
            dataStream = response.GetResponseStream()
            Dim reader As StreamReader = New StreamReader(dataStream)
            Dim responseFromServer As String = reader.ReadToEnd()
            Console.WriteLine(responseFromServer)
            reader.Close()
            dataStream.Close()
            response.Close()
            Return responseFromServer
        Catch ex As Exception
            Console.WriteLine("Error en el PostRequest")
            Console.WriteLine(ex)
        End Try

    End Function


    Function GetRequest(ByVal URL As String) As JObject
        Dim webClient As New WebClient
        Try
            Dim result As String = webClient.DownloadString(URL)
            Return JObject.Parse(result)
        Catch Err As Exception
            Console.WriteLine("Error while using GetRequest")
            Console.WriteLine(Err)
            Return Nothing
        End Try

    End Function

    Function GetRequestCounter(ByVal URL As String) As Int32
        Dim webClient As New WebClient
        Try
            Dim result As String = webClient.DownloadString(URL)
            Dim tamano As Int32 = result.Length()
            Dim caracteresCantidad As Int32

            Select Case tamano
                Case 16
                    caracteresCantidad = 1
                Case 17
                    caracteresCantidad = 2
                Case 18
                    caracteresCantidad = 3
                Case 19
                    caracteresCantidad = 4
                Case 20
                    caracteresCantidad = 5
                Case 21
                    caracteresCantidad = 6
                Case 22

            End Select

            result = result.Substring(13, caracteresCantidad)
            Return Int32.Parse(result)
        Catch Err As Exception
            Console.WriteLine("Error while using GetRequest")
            Console.WriteLine(Err)
            Return Nothing
        End Try

    End Function

    Function Post(data As Dictionary(Of String, String), url As String) As Object
        Dim client As New RestClient(url)
        Dim request As New RestRequest(Method.POST)
        request.AddJsonBody(data)
        Dim response = client.Execute(request)
        Return response.Content
    End Function

    'Function Put(data As Dictionary(Of String, String), url As String) As Object
    '    Dim client As New RestClient(url)
    '    Dim request As New RestRequest(Method.PUT)
    '    request.AddJsonBody(data)
    '    Dim response = client.Execute(request)
    '    Return response.Content
    'End Function

    'Function Delete(data As Dictionary(Of String, String), url As String) As Object
    '    Dim client As New RestClient(url)
    '    Dim request As New RestRequest(Method.DELETE)
    '    request.AddJsonBody(data)
    '    Dim response = client.Execute(request)
    '    Return response.Content
    'End Function

    Function Put(data As Dictionary(Of String, String), url As String) As Object
        Dim client As New RestClient(url)
        Dim request As New RestRequest(Method.PUT)
        request.AddJsonBody(data)
        Dim response = client.Execute(Of ApplicationMessage)(request)
        Return response.Content
    End Function

    Function Delete(data As Dictionary(Of String, String), url As String) As Object
        Dim client As New RestClient(url)
        Dim request As New RestRequest(Method.DELETE)
        request.AddJsonBody(data)
        Dim response = client.Execute(Of ApplicationMessage)(request)
        Return response.Content
    End Function
End Class
