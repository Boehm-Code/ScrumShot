<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Overview.aspx.cs" Inherits="Scrum_Shot.Admin_Overview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn_CreateProject" runat="server" OnClick="btn_CreateProject_Click" Text="Create Project" />
        </div>
        <p>
            <asp:Button ID="btn_UserEnquiries" runat="server" Text="User Enquiries" />
        </p>
    </form>
</body>
</html>
