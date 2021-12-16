<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ButtonTextBoxDropDownList.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Conhecendo componentes - Button, Textbox, DropDownList</title>
    <style type="text/css">
        .auto-style1 {
            width: 172px;
        }
        .auto-style2 {
            width: 188px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table style="width:100%;">
                <%-- Criada uma tabela com três linhas e três colunas --%>
                <tr>
                    <td class="auto-style1">Site</td>
                    <td class="auto-style2">Endereço</td>
                    <td>Opções</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtSite" runat="server" Width="182px"></asp:TextBox>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtEndereco" runat="server" Width="182px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnInserir" runat="server" OnClick="btnInserir_Click" Text="Inserir Site" Width="95px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:DropDownList ID="dlSite" runat="server" Width="188px">
                            <asp:ListItem Value="DotNet.com">Csharp</asp:ListItem>
                            <asp:ListItem Value="ReactNative.com">JavaScript</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
