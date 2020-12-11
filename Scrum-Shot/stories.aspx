<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Stories.aspx.cs" Inherits="ScrumShot_CreateStory.Stories" %>

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

        .yourStory {
            text-align: left;
            position: relative;
            border-collapse: collapse;
            font-size: 20px;
        }

        .yourStory th {
            background-color: lightgray;
            position: -webkit-sticky;
            position: sticky;
            top: 0;
            border: solid 1px;
        }

        .yourStory td {
            border: solid 1px;
        }
        #RenameBox {
            display:none;
        }
        #AddMemberBox{
            display:none;
        }
    </style>
    <form id="form1" runat="server">
        <div id="header">
            <a href="Project.aspx"><</a>
            <h1><asp:Label ID="lblGreeting" runat="server"></asp:Label></h1>
            <h3><asp:Label ID="lblProjectName" runat="server"></asp:Label>
            </h3>

            <a id="ButtonShowRenameBox" class="buttons" onclick="showRenameBox()">rename</a>
            <div id="RenameBox">
                <asp:TextBox ID="TxtBoxRename" runat="server"></asp:TextBox>
                <asp:Button ID="BtnRename" runat="server" Text="rename" OnClick="BtnRename_Click" onClientClick="showRenameBox()"/>
            </div>

             <asp:Button ID="BtnDelete" runat="server" Text="delete Project" OnClick="BtnDelete_Click" />
            <br />

            <a id="ButtonShowAddMemberBox" class="buttons" onclick="showAddMemberBox()">add Member</a>
            <div id="AddMemberBox">
                <asp:TextBox ID="txtBoxAddMember" runat="server" placeholder="e-Mail"></asp:TextBox>
                <asp:TextBox ID="txtBoxMemberRole" runat="server"></asp:TextBox>
                <asp:Button ID="btnAddMember" runat="server" Text="add" OnClick="BtnAddMember_Click" onClientClick="showRenameBox()"/>
            </div>
        </div>
        <div style="margin-top:50px; margin-bottom:20px;">
            <div>
                <a id="ButtonShowCreateStory" class="buttons" onclick="showCreateMode()">create new story</a>
            </div>

            <div id="CreateMode" style="display: none;">
                <asp:TextBox ID="TxtBoxStory" runat="server" Height="72px" Width="382px" TextMode="MultiLine" Placeholder="Enter your story here" MaxLength="255"></asp:TextBox><br />
                Stroypoints: <asp:TextBox ID="TxtBoxStoryPoints" runat="server" Placeholder="1"></asp:TextBox>
                <asp:Button ID="BtnSave" runat="server" Text="Save" Width="60px" OnClick="BtnSave_Click" />
                <asp:Button ID="BtnCancel" runat="server" Text="Cancel" onClientClick="showCreateMode()" OnClick="BtnCancel_Click"/>
            </div>
        </div>

        <asp:Button ID="BtnReload" runat="server" Text="Reload" OnClick="BtnReload_Click" />

        <div id="yourSories" runat="server"/>

        <div id="yourMembers" runat="server"/>

        <script>
            function showCreateMode() {
                document.getElementById("CreateMode").style.display == "inline" ? document.getElementById("CreateMode").style.display = "none" : document.getElementById("CreateMode").style.display = "inline";
                document.getElementById("ButtonShowCreateStory").innerText == "create new story" ? document.getElementById("ButtonShowCreateStory").innerText = "X" : document.getElementById("ButtonShowCreateStory").innerText = "create new story";

            }

            function showRenameBox() {
                document.getElementById("RenameBox").style.display == "inline" ? document.getElementById("RenameBox").style.display = "none" : document.getElementById("RenameBox").style.display = "inline";
                document.getElementById("ButtonShowRenameBox").innerText == "rename" ? document.getElementById("ButtonShowRenameBox").innerText = "X" : document.getElementById("ButtonShowRenameBox").innerText = "rename";
            }

            function showAddMemberBox() {
                document.getElementById("AddMemberBox").style.display == "inline" ? document.getElementById("AddMemberBox").style.display = "none" : document.getElementById("AddMemberBox").style.display = "inline";
                document.getElementById("ButtonShowAddMemberBox").innerText == "add Member" ? document.getElementById("ButtonShowAddMemberBox").innerText = "X" : document.getElementById("ButtonShowAddMemberBox").innerText = "add Member";
            }
        </script>

    </form>
</body>
</html>
