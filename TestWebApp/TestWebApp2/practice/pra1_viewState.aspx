<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pra1_viewState.aspx.cs" Inherits="TestWebApp2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        First Name :<asp:TextBox runat="server" ID="txtFname"></asp:TextBox><br /><br />
        Last Name :<asp:TextBox runat="server" ID="txtLname"></asp:TextBox><br /><br /><br />
        <asp:Button runat="server" OnClick="btnSubmit_Click" ID="btnSubmit" Text="Submit"/>
        <asp:Button runat="server" OnClick="btnRestore_Click" ID="btnRestore" Text="Restore"/>
    </div>
    </form>
</body>
</html>
