<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductBacklog.aspx.cs" Inherits="Scrum_Shot.ProductBacklog1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Backlog</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    <h3>Product Backlog Overview</h3>
    <asp:Table id="Table1" 
        GridLines="Both" 
        HorizontalAlign="Center" 
        Font-Names="Verdana" 
        Font-Size="8pt" 
        CellPadding="15" 
        CellSpacing="0" 
        Runat="server"/>

    </div>
    </form>
</body>
</html>
