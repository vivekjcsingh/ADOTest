<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="addressbookapplication.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>Address ID :</td>
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>First Name :</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Last Name</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Phone Number</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click" /></td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="delete" OnClick="Button2_Click" /> <asp:Button ID="Button3" runat="server" Text="search" OnClick="Button3_Click" /><asp:Button ID="Button4" runat="server" Text="update" OnClick="Button4_Click" /></td>
        </tr>
    </table>
        <h1>find the person by name</h1>
        <table>
             <tr>
            <td>Last name</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
        </tr>
        </table>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
