<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AloMundo.aspx.cs" Inherits="ASPM1_AloMundo.AloMundo" %>

<%-- A página de formulário do webForms funciona à partir de uma página HTML, podendo-se utilizar das mesmas propriedades que uma página HTML utiliza --%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Alô Mundo - Aula 1</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtMsg" runat="server" Width="499px"></asp:TextBox>
            <asp:Button ID="btnExecutar" runat="server" OnClick="btnExecutar_Click" Text="Executar" />
            <br />
            <asp:Label ID="Lmsg" runat="server" Text="Escreva o que deseja informar"></asp:Label>
        </div>
    </form>
</body>
</html>
