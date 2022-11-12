<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Exp9Sessions.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <h1>SESSIONS - LOGIN LOGOUT</h1>
                <hr />
            <fieldset style="border:3px solid red;border-radius:40px; text-align:left;padding-left:25px;height:150px;width:300px;">
                <legend>Login</legend>
            <table>
                <tr>
                    <td>Username :</td>
                    <td>
                        <asp:TextBox ID="TUser" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>Password :</td>
                    <td><asp:TextBox ID="TPass" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="BLogin" runat="server" Text="LOGIN" OnClick="BLogin_Click" /></td>
                    <td>
                        <asp:Literal ID="LitMsg" runat="server"></asp:Literal></td> 
                </tr>
            </table>
            </fieldset>
            </center>
        </div>
    </form>
</body>
</html>
