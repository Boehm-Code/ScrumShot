<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Scrum_Shot.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>username:</td>
                    <td><asp:TextBox ID="txt_username" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txt_username" EnableClientScript="False"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td>password:</td>
                    <td><asp:TextBox ID="txt_password" type="password" runat="server" ></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="txt_password" EnableClientScript="False"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td style="text-align:center;" colspan="2"><asp:Button ID="btn_login" runat="server" Text="login" OnClick="btn_login_Click" /></td>
                </tr>
                <tr>
                    <td style="text-align:center;" colspan="2">
                        <asp:Label ID="lbl_errorMessage" runat="server" Text="info: "></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
