<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="LavaCar.pages.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <link href="../css/register.css" rel="stylesheet" />
</head>
<body>
    <div class="dGeneral">
        <div class="dSubG">
            <h1 class="titles">Registro de Vehículo</h1>
            <form class="form-horizontal" id="form1" runat="server">
                <div class="form-group lt">
                    <asp:Label ID="lblName" runat="server" Text="Nombre del Dueño:"></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="Debe ingresar el nombre" ControlToValidate="txtName" Font-Italic="True" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group lt">
                    <asp:Label ID="lblCarRegistration" runat="server" Text="Placa del Vehículo: "></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtCarRegistration" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvCarRegistartion" runat="server" ErrorMessage="Debe ingresar la placa" ControlToValidate="txtCarRegistration" Font-Italic="True" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                </div>

                <div class="form-group lt">
                    <asp:Label ID="lblBrand" runat="server" Text="Marca del Vehículo: "></asp:Label>
                    <asp:TextBox CssClass="form-control" ID="txtBrand" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvBrand" runat="server" ErrorMessage="Debe ingresar la marca" ControlToValidate="txtBrand" Font-Italic="True" ForeColor="#FF5050"></asp:RequiredFieldValidator>
                </div>

                <h2 class="titles">Seleccionar Servicios</h2>
                <div class="servicesContainer">
                    <div>
                        <asp:CheckBoxList class="service" ID="cBoxServices" runat="server"  RepeatColumns="3">
                            
                        </asp:CheckBoxList>
                    </div>
                </div>

                <asp:Label CssClass="errorM" ID="lblErrorMessage" runat="server" Text="Debe seleccionar al menos un servicio" Visible="false"></asp:Label>


                <div class="text-center">
                    <asp:Button CssClass="btn btn-success btnRegistry" ID="btnRegister" runat="server" Text="Registrar" OnClick="btnRegister_Click" />
                    <asp:Button CssClass="btn btn-warning btnRegistry" ID="btnBack" runat="server" Text="Regresar" OnClick="btnBack_Click" CausesValidation="False" />
                </div>
            </form>
        </div>
    </div>
</body>
</html>
