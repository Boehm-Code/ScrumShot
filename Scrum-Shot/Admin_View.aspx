<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_View.aspx.cs" Inherits="Scrum_Shot.Admin_View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btn_EditProductBacklog" runat="server" Text="Edit ProductBacklog" />
        <asp:Button ID="btn_EditTaskboard" runat="server" Text="Edit Taskbord" />
        <asp:Button ID="btn_AdministrateMembers" runat="server" Text="Administrate Members" />
        <p style="height: 28px">
            <asp:Button ID="btn_Sprintplanning" runat="server" Text="Sprintplanning" />
        </p>
        <p style="height: 40px">
            <asp:Button ID="btn_ViewTaskboard" runat="server" Text="View Taskboard" />
            <asp:Button ID="btn_ViewProductbacklog" runat="server" Text="View Productbacklog" Width="200px" />
            </p>
    </form>
</body>
</html>
