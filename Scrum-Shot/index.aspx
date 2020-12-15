<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Scrum_Shot.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>SCRUMshot</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome to index.aspx!
            <asp:Button ID="btn_signOut" runat="server" OnClick="btn_signOut_Click" Text="sign out" />
        </div>
    </form>
</body>
</html>
