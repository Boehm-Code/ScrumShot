<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Scrum_Shot.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td style="text-align:right;">email:</td>
                    <td><asp:TextBox ID="txt_email" runat="server" Width="190px"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator_email" runat="server" ErrorMessage="please enter your email address" ControlToValidate="txt_email" EnableClientScript="False"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td style="text-align:right;">password:</td>
                    <td><asp:TextBox ID="txt_password" type="password" runat="server" Width="190px" ></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator_password" runat="server" ErrorMessage="please enter a password" ControlToValidate="txt_password" EnableClientScript="False"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <td />
                    <td style="text-align:center;"><asp:Button ID="btn_login" runat="server" Text="login" OnClick="btn_login_Click" Width="90px" /></td>
                </tr>
            </table>
            <asp:Label ID="lbl_errorMessage" runat="server" Text="info: "></asp:Label>
        </div>
    </form>
</body>
</html>
