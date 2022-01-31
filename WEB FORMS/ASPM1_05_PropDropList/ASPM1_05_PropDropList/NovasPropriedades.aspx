<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NovasPropriedades.aspx.cs" Inherits="ASPM1_05_PropDropList.NovasPropriedades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width="100%">
                <tr width="100%">
                    <td width="33%">Nome do Site</td>
                    <td width="33%">Endereço do Site</td>
                    <td width="33%">Botões</td>
                </tr>
                <tr width="100%">
                    <td width="33%">
                        <asp:TextBox
                            ID="txtNomeSite"
                            runat="server"
                            Width="90%">
                        </asp:TextBox>
                    </td>
                    <td width="33%">
                        <asp:TextBox
                            ID="txtEderecoSite"
                            runat="server"
                            Width="90%">
                        </asp:TextBox>
                    </td>
                    <td width="33%">
                        <asp:Button
                            ID="btnInserirDados"
                            runat="server"
                            Text="Inserir Dados"
                            OnClick="btnInserirDados_Click" />
                    </td>
                </tr>
                <tr width="100%">
                    <td width="33%">
                        <asp:DropDownList
                            ID="dlDadosSite"
                            runat="server"
                            Width="90%">
                            <asp:ListItem Value="1">Ferrari</asp:ListItem>
                            <asp:ListItem Value="2">Lamborghini</asp:ListItem>
                            <asp:ListItem Value="3">Tesla</asp:ListItem>
                            <asp:ListItem Value="4">Fiat</asp:ListItem>
                            <asp:ListItem Value="5">Audi</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td width="33%">
                        <asp:ListBox
                            ID="lbDadosEnderecoSite"
                            runat="server"
                            Width="90%">
                            <asp:ListItem Value="1">Ferrari.com</asp:ListItem>
                            <asp:ListItem Value="2">Lamborghini.com</asp:ListItem>
                            <asp:ListItem Value="3">Tesla.com</asp:ListItem>
                            <asp:ListItem Value="4">Fiat.com</asp:ListItem>
                            <asp:ListItem Value="5">Audi.com</asp:ListItem>
                        </asp:ListBox>
                    </td>
                    <td width="33%">
                        <asp:Button 
                            id="btnSelecionarItemSite"
                            runat="server"
                            text="Selecionar Item"
                            OnClick="btnSelecionarItemSite_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
