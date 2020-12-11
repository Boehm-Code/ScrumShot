<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Scrum_Shot.index" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" href="StylesheetTSKB.css" type="text/css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Taskboard</title>


  <script language="javascript" type="text/javascript">
  var dragEle = null;
  var eleX = 0;
  var eleY = 0;
  var mouseX = 0;
  var mouseY = 0;
  document.onmousemove = move;
  document.onmouseup   = dragStop;
  function dragStart(element)
  {
    dragEle = element;
    eleX = mouseX - dragEle.offsetLeft;
    eleY = mouseY - dragEle.offsetTop;
  }
  function dragStop()
  {
    dragEle=null;
  }
  function move(dragEvent)
  {
    mouseX = document.all ? window.event.clientX : dragEvent.pageX;
    mouseY = document.all ? window.event.clientY : dragEvent.pageY;
    if(dragEle != null)
    {
      dragEle.style.left = (mouseX - eleX) + "px";
      dragEle.style.top = (mouseY - eleY) + "px";
      }
  }

</script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <p>TASKBOARD</p>
                </tr>
                <tr>
                    <th>To do</th>
                    <th>In progress</th>
                    <th>To verify</th>
                    <th>Done</th>
                </tr>
                <tr>

                    <td class="heightofTable">
                        <div id="dragContBox">hallo</div>  

                    </td>
                    <td class="heightofTable">&nbsp;</td>
                    <td class="heightofTable">&nbsp;</td>
                    <td class="heightofTable">&nbsp;</td>
                </tr>
            </table>
           
        </div>        
       
    </form>
</body>
</html>