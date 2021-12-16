<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<%-- Tag asp = <%
    Toda a programação estará dentro cdo codebehind
    uma página aspx é baseada em HTML 5--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Alô Mundo! </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
            <asp:TextBox
                ID="txtMSG"
                runat="server"
                Width="413px">
            </asp:TextBox>
            <asp:Button
                ID="Executar"
                runat="server"
                OnClick="Executar_Click"
                Text="Executar" />
            </div>            
            <asp:Label
                ID="Lmsg"
                runat="server"
                Text="Escreva o que deseja">
            </asp:Label>
        </div>
    </form>
</body>
</html>
