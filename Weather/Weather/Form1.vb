Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Device.Location

Public Class Form1
    Private Sub btnGrab_Click(sender As Object, e As EventArgs) Handles btnGrab.Click
        Dim webClient As New System.Net.WebClient
        'Dim watcher As New System.Device.Location.GeoCoordinate


        'lblOutput.Text = watcher.Latitude() & ", " & watcher.Longitude()

        'Dim result As String = webClient.DownloadString("file:///C:/Users/iklone/Pictures/Hackathon/weatherExa")
        Dim result As String = webClient.DownloadString("http://api.openweathermap.org/data/2.5/weather?q=" & txtInput.Text & "&appid=9fa217a2b241a8c23b5a351e6ef09755")
        Dim WeatherGrab = JsonConvert.DeserializeObject(result)
        lblOutput.Text = WeatherGrab("weather")(0)("description")
    End Sub
End Class