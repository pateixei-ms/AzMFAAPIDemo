<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="AzMFAAPIDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <table style="width: 100%;">
            <tr>
                <td colspan="2" style="font-size: xx-large; font-family: Arial, Helvetica, sans-serif"><strong style="text-align: center">Demo Azure MFA - Multi-factor authentication<br />
                    One-way OTP<br />
                    </strong></td>
            </tr>
            <tr>
                <td>Telefone:</td>
                <td>
                    <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
                &nbsp;(DDD+Número) digite somente os digitos incluindo ddd e sem traços</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Obter código de acesso" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Codigo de acesso</td>
                <td>
                    <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
&nbsp;&lt;== Digite aqui o código de acesso recebido no seu telefone.</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Continuar" />
                </td>
            </tr>
            <tr>
                <td>Resultado:</td>
                <td>
                    <asp:Label ID="LabelResultado" runat="server" Text=" "></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
