<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tabuada.aspx.cs" Inherits="ASPM1_04_TabuadaModoDev.Tabuada" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList
                ID="dlOperadores"
                runat="server"
                Width="200px">
            </asp:DropDownList>

            <asp:Button
                ID="btnExecutar"
                runat="server"
                Text="Executar Tabuada"
                OnClick="btnExecutar_Click" />

            <br />
            <br />

            <asp:listbox
                id="lbOperacao"
                runat="server"
                height="200px"
                width="200px">
            </asp:listbox>
        </div>
    </form>
</body>
</html>
