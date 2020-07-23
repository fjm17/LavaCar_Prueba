<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reports.aspx.cs" Inherits="LavaCar.pages.reports" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link href="../css/reports.css" rel="stylesheet" />
</head>
<body>
    <div class="dGeneral">
        <div class="dSubG">
            <h1 class="titles">Reporte de Servicio</h1>
            <form id="form1" runat="server">
                
                <div>
                    <asp:DropDownList CssClass="ddl" ID="ddlServices" runat="server" OnSelectedIndexChanged="loadForm" AutoPostBack="True"></asp:DropDownList>
                </div>

                 <div class="eachService lt">
                     <div class="service serviceLabel">
                        <asp:Label  ID="lblId" runat="server" Text="Número"></asp:Label>
                    </div>
                    <div class="service serviceLabel">
                        <asp:Label  ID="lblCarRegistration" runat="server" Text="Placa"></asp:Label>
                    </div>
                    <div class="service serviceLabel">
                        <asp:Label ID="lblBrand" runat="server" Text="Marca"></asp:Label>
                    </div>
                    <div class="service serviceLabel">
                        <asp:Label ID="lblName" runat="server" Text="Dueño"></asp:Label>
                    </div>
                </div>

                <div id="containerService" runat="server">
                    
                </div>

                <div class="text-center">
                    <asp:Button CssClass="btn btn-warning btnBack" ID="btnBack" runat="server" Text="Regresar" OnClick="btnBack_Click"/>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
