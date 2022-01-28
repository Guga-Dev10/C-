<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASPXM1_ModoDev.aspx.cs" Inherits="ASPM1_02_ComponestesModoDev.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Aula 2 Modulo 1 - Componentes Button, DropDownList, ListBox e tabela </title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Aula 2 Modulo 1 - Componentes Button, DropDownList, ListBox e Tabela</h1>
        <div>
            <table style="width: 100%">
                <tr width="100%">
                    <td width="33%">Site</td>
                    <td width="33%">Endereço</td>
                    <td width="33%">Opções</td>
                </tr>
                <tr width="100%">
                    <td width="33%">
                        <asp:TextBox
                            ID="txtSite"
                            runat="server"
                            Width="90%">
                        </asp:TextBox>
                    </td>
                    <td width="33%">
                        <asp:TextBox
                            ID="txtEndereço"
                            runat="server"
                            Width="90%">
                        </asp:TextBox>
                    </td>
                    <td width="33%">
                        <asp:Button
                            ID="btnInserir"
                            runat="server"
                            Text="Inserir Site"
                            Width="30%"
                            OnClick="btnInserir_Click" />
                    </td>
                </tr>
                <tr width="100%">
                    <td width="33%">
                        <asp:DropDownList
                            ID="dlSite"
                            runat="server"
                            heigth="35%"
                            Width="90%">
                            <asp:ListItem Value="1">Ferrari</asp:ListItem>
                            <asp:ListItem Value="2">Lamborghini</asp:ListItem>
                            <asp:ListItem Value="3">Tesla</asp:ListItem>
                            <asp:ListItem Value="4">Audi</asp:ListItem>
                            <asp:ListItem Value="5">Harley Davidson</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td width="33%">
                        <asp:ListBox
                            ID="lbEndereco"
                            runat="server"
                            Width="90%">
                            <asp:ListItem Value="1">www.ferrari.com</asp:ListItem>
                            <asp:ListItem Value="2">www.lamborghini.com</asp:ListItem>
                            <asp:ListItem Value="3">www.tesla.com</asp:ListItem>
                            <asp:ListItem Value="4">www.audi.com</asp:ListItem>
                            <asp:ListItem Value="5">www.harleydavidson.com</asp:ListItem>
                        </asp:ListBox>
                    </td>
                    <td width="33%">
                        <asp:Button
                            id="btnSelecionar"
                            runat="server"
                            text="Selecionar Item"
                            width="30%"
                            OnClick="btnSelecionar_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
