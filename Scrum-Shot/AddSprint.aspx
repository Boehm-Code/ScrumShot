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
        <asp:RequiredFieldValidator ID="rfv_workhours" runat="server" ControlToValidate="txt_Workhours" EnableClientScript="False" ErrorMessage="Workhours cant be empty"></asp:RequiredFieldValidator>
        <asp:RangeValidator ID="rv_workhours" runat="server" ControlToValidate="txt_Workhours" EnableClientScript="False" ErrorMessage="Workhours have to be &gt;0" MinimumValue="1" MaximumValue="2147483647"></asp:RangeValidator>
        <p>
            <asp:Label ID="lbl_StartDate" runat="server" Text="Start Date:"></asp:Label>
            <asp:TextBox ID="txt_StartDate" runat="server" TextMode="Date"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv_startDate" runat="server" ControlToValidate="txt_StartDate" EnableClientScript="False" ErrorMessage="Start Date cant be empty"></asp:RequiredFieldValidator>
        </p>
        <p>
            <asp:Label ID="lbl_EndDate" runat="server" Text="End Date:"></asp:Label>
            <asp:TextBox ID="txt_EndDate" runat="server" TextMode="Date"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfv_endDate" runat="server" ControlToValidate="txt_EndDate" EnableClientScript="False" ErrorMessage="End Date cant be empty"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txt_StartDate" ControlToValidate="txt_EndDate" EnableClientScript="False" ErrorMessage="End Date cant be earlier or on the same day as the Start Date " Operator="GreaterThan" Type="Date"></asp:CompareValidator>
        </p>
        <p>
            <asp:Label ID="lbl_Info" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
