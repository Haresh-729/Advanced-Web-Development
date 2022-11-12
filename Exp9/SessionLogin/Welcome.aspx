<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Exp9Sessions.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome...!<asp:Label ID="LWelcome" runat="server"></asp:Label></h1><br />
            <asp:LinkButton ID="BLogout" runat="server" OnClick="BLogout_Click">LOGOUT</asp:LinkButton>
        </div>
    </form>
</body>
</html>
