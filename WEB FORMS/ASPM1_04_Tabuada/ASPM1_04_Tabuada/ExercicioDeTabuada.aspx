<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExercicioDeTabuada.aspx.cs" Inherits="ASPM1_04_Tabuada.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Tabuada</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>ASPM1 - Aula 04 - Exercício de Tabuada</h1>
        <div>

            <asp:DropDownList
                ID="dlNumeros"
                runat="server"
                Height="20px"
                Width="201px">
            </asp:DropDownList>

            <asp:Button 
                Id="btnExecutar"
                runat="server"
                text="Executar Tabuada"
                Onclick="btnExecutar_Click"/>
            <br />
            <br />
            <asp:ListBox
                id="lbResultados"
                runat="server" 
                height="200px"
                Width="199px">
            </asp:ListBox>
        </div>
    </form>
</body>
</html>
