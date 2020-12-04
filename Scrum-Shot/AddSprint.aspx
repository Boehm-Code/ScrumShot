<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddSprint.aspx.cs" Inherits="Scrum_Shot.Sprintplanning" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btn_AddSprint" runat="server" Text="Add Sprint" OnClick="btn_AddSprint_Click" />
        </div>
        <asp:Label ID="lbl_Workhours" runat="server" Text="Workhours:"></asp:Label>
        <asp:TextBox ID="txt_Workhours" runat="server" TextMode="Number"></asp:TextBox>
        <p>
            <asp:Label ID="lbl_StartDate" runat="server" Text="Start Date:"></asp:Label>
            <asp:TextBox ID="txt_StartDate" runat="server" TextMode="Date"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lbl_EndDate" runat="server" Text="End Date:"></asp:Label>
            <asp:TextBox ID="txt_EndDate" runat="server" TextMode="Date"></asp:TextBox>
        </p>
    </form>
</body>
</html>
