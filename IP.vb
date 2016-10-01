Public Class STEAYOIP
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call GetIPAddress()


    End Sub


    Sub GetIPAddress()

        Dim strHostName As String

        Dim strIPAddress As String



        strHostName = System.Net.Dns.GetHostName()

        strIPAddress = System.Net.Dns.GetHostByName(strHostName).AddressList(0).ToString()


        MessageBox.Show("Host Name: " & strHostName & "; IP Address: " & strIPAddress)

    End Sub



End Class
