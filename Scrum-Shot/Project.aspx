<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Project.aspx.cs" Inherits="Scrum_Shot.Project" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <style>
        body {
            font-family: Calibri;
            font-size: 20px;
        }

        .buttons {
            padding: 2px;
            background-color: lightblue;
            cursor: pointer;
        }
        .myProjectTable {
            text-align: left;
            position: relative;
            border-collapse: collapse;
        }
        #buttonEdit {
            visibility: hidden;
        }

        .myProjectTable tr:hover > #buttonEdit {
            visibility: visible;
        }
        .myProjectTable td {
            padding: 5px;
        }

        .myProjectTable th {
            background-color: lightgray;
            position: -webkit-sticky;
            position: sticky;
            top: 0;
            border: solid 1px;
        }
    </style>
    <form id="form1" runat="server">
        <h1>Projects</h1>

        <a id="ButtonShowCreateProject" class="buttons" onclick="showProjectCreateMode()">create new project</a><br />
        <div id="ProjectCreateMode" style="display: none">
            Projectname: <asp:TextBox ID="TxtBoxProjectName" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnCreateProject" runat="server" Text="Create Project" OnClick="btnCreateProject_Click" />
        </div>
        
            <h2>My Projects</h2>
            <asp:Button ID="BtnReload" runat="server" Text="Reload" OnClick="BtnReload_Click" />
        <div id="myProjects" runat="server">

        </div>
        <script>
            function showProjectCreateMode() {
                document.getElementById("ProjectCreateMode").style.display == "inline" ? document.getElementById("ProjectCreateMode").style.display = "none" : document.getElementById("ProjectCreateMode").style.display = "inline";
                document.getElementById("ButtonShowCreateProject").innerText == "create new project" ? document.getElementById("ButtonShowCreateProject").innerText = "X" : document.getElementById("ButtonShowCreateProject").innerText = "create new project";

            }
        </script>
    </form>
</body>
</html>
