<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member_View.aspx.cs" Inherits="Scrum_Shot.Member_View" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      <asp:Button ID="btn_Sprintplanning" runat="server" Text="Sprintplanning" />
        
        <p>
            <asp:Button ID="btn_ViewTaskboard" runat="server" Text="View Taskboard" />
            <asp:Button ID="btn_ViewProductbacklog" runat="server" Text="View Productbacklog" Width="200px" />
            </p>
    </form>
</body>
</html>
