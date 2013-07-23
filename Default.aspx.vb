Imports System.Net

Partial Class ObtenerIP_Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim strHostName As String = Dns.GetHostName()
        Dim ipEntry As IPHostEntry = Dns.GetHostEntry(strHostName)

        lblIPAddress.Text = Convert.ToString(ipEntry.AddressList(ipEntry.AddressList.Length - 1))
        lblHostName.Text = Convert.ToString(ipEntry.HostName)

        'Find IP Address Behind Proxy Or Client Machine In ASP.NET
        Dim IPAdd As String = String.Empty
        IPAdd = Request.ServerVariables("HTTP_X_FORWARDED_FOR")

        If String.IsNullOrEmpty(IPAdd) Then
            IPAdd = Request.ServerVariables("REMOTE_ADDR")
            lblIPBehindProxy.Text = IPAdd
        End If
    End Sub
End Class
