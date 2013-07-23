<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="ObtenerIP_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Obtener dirección IP y Host Name</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-weight:bold; border:1px;">
        Tu dirección IP es: <asp:Label ID="lblIPAddress" runat="server" Text=""></asp:Label><br /><br />
        Tu computadora/Host Name es: <asp:Label ID="lblHostName" runat="server" Text=""></asp:Label>
        <br /><br />
        Tu dirección IP detrás del Proxy es:- <asp:Label ID="lblIPBehindProxy" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
