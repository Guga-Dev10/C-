<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ButtonTextBoxDrodownList.aspx.cs" Inherits="ASPM1_02_Componentes.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Conhecendo os componentes - Button, TexBox, DropDownList - Parte 1</title>
    <style type="text/css">
        .auto-style1 {
            width: 490px;
        }

        .auto-style2 {
            width: 490px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Conhecendo os componentes - Button, TexBox, DropDownList - Parte 1</h1>
            <br />
            <%-- Construindo um código HTML de tabela --%>
            <table style="width: 100%;">
                <%-- A Tag TR indica quantas linhas há na tabela enquando a tag TD indica quantas colunas existes 
                    em cada uma das colunas. No caso da tabela de exemplo serão criadas três linhas (tr) e em cada linha haverão três colunas (td) --%>
                <tr>
                    <td class="auto-style1">Site</td>
                    <td class="auto-style2">Endereço</td>
                    <td>Opções</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:TextBox
                            ID="txtSite"
                            runat="server"
                            Width="473px">
                        </asp:TextBox>
                    </td>

                    <td class="auto-style2">
                        <asp:TextBox
                            ID="txtEndereco"
                            runat="server"
                            Width="431px">
                        </asp:TextBox>
                    </td>
                    <td>
                        <asp:Button 
                            ID="btnInserir"
                            runat="server" 
                            Text="Inserir Site"
                            Width="129px" 
                            OnClick="btnInserir_Click"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:DropDownList ID="dlSite" runat="server" Height="35px" Width="477px">
                            <asp:ListItem Value="1">Vulkan S 650</asp:ListItem>
                            <asp:ListItem Value="2">Apache RTR 200</asp:ListItem>
                            <asp:ListItem Value="3">Fat Boy</asp:ListItem>
                            <asp:ListItem Value="4">Mustang GT 500</asp:ListItem>
                            <asp:ListItem Value="5">Porsche 911</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style2">
                        <asp:ListBox ID="lbEndereco" runat="server" Width="442px">
                            <asp:ListItem Value="1">www.fordcarrera.com</asp:ListItem>
                            <asp:ListItem Value="2">www.harleydavidson.com</asp:ListItem>
                            <asp:ListItem Value="3">www.kawasaki.com</asp:ListItem>
                        </asp:ListBox>
                    </td>
                    <td>
                        <asp:Button 
                            ID="btnSelecionar" 
                            runat="server" 
                            Text="Selecionar Item" 
                            Width="127px" 
                            OnClick="btnSelecionar_Click"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
