<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Productowner-ScrumMaster_View.aspx.cs" Inherits="Scrum_Shot.Productowner_ScrumMaster_View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <asp:Button ID="btn_EditProductBacklog" runat="server" Text="Edit ProductBacklog" />
        <asp:Button ID="btn_EditTaskboard" runat="server" Text="Edit Taskbord" />
        <p>
            <asp:Button ID="btn_Sprintplanning" runat="server" Text="Sprintplanning" />
        </p>
        <p>
            <asp:Button ID="btn_ViewProductbacklog" runat="server" Text="View Productbacklog" Width="200px" />
            <asp:Button ID="btn_ViewTaskboard" runat="server" Text="View Taskboard" />
        </p>
    </form>
</body>
</html>
