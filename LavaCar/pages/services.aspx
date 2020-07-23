<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="services.aspx.cs" Inherits="LavaCar.pages.services" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link href="../css/services.css" rel="stylesheet" />
</head>
<body>
    <div class="dGeneral">
        <div class="dSubG">
            <h1 class="titles">Servicios</h1>
            <form id="form1" runat="server">
                <div class="eachService ls" id="eachS">
                    <div class="service serviceLabel">
                        <asp:Label ID="lblName1" runat="server" Text="Descripción"></asp:Label>
                    </div>
                    <div class="service serviceLabel">
                        <asp:Label ID="lblPrice" runat="server" Text="Precio"></asp:Label>
                    </div>
                    <div class="service serviceLabel">
                        <asp:Label ID="lblAction" runat="server" Text="Acción"></asp:Label>
                    </div>
                </div>

                <div id="containerS" runat="server">

                    
                </div>

                <div class="text-center">
                    <asp:Button CssClass="btn btn-warning btnBack" ID="btnBack" runat="server" Text="Regresar" OnClick="btnBack_Click" />
                </div>
            </form>
        </div>
    </div>
</body>
</html>
