<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pra2_ApplicationLevelStateManagement.aspx.cs" Inherits="TestWebApp2.practice.StateManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Numb Users: <asp:TextBox ID="txtUsers" runat="server"></asp:TextBox>
        online Users: <asp:TextBox ID="txtOnlineUsers" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="btnLogout" runat="server" Text="Logout" />
        
    </div>
    </form>
</body>
</html>
