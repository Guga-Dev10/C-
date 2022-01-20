<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASM1_ModoDev.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Aula 1 - Alô mundo - Escrevendo as tags e os códigos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox
                ID="txtMsg"
                runat="server"
                Width="499px">
            </asp:TextBox>
            <asp:Button
                ID="btnExecutar"
                runat="server"
                OnClick="btnExecutar_Click"
                text="Executar" />
            <br />
            <asp:Label
                ID="lMsg"
                runat="server"
                Text="Escreva o que deseja informar">
            </asp:Label>
        </div>
    </form>
</body>
</html>
