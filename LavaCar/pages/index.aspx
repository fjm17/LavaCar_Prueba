<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LavaCar.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link href="../css/main.css" rel="stylesheet" />
</head>
<body>
    <div class="dGeneral">
        <div class="dSubG">
            <h1>LavaCar</h1>
            <form runat="server">
                <div>
                    <asp:Button CssClass="btn btn-info options" ID="btnRegister" runat="server" Text="Registrar Vehículo" OnClick="btnRegiste_Click" />
                </div>

                <div>
                    <asp:Button CssClass="btn btn-info options" ID="btnServices" runat="server" Text="Servicios" OnClick="btnServices_Click" />
                </div>

                <div>
                    <asp:Button CssClass="btn btn-info options" ID="btnReport" runat="server" Text="Reporte de Servicios" OnClick="btnReport_Click" />
                </div>
            </form>
        </div>
    </div>
</body>
</html>
