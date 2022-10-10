<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm0.aspx.cs" Inherits="producs.WebForm0" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
         <asp:Label ID="Label1" runat="server" Text="username"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="val1" runat="server" ControlToValidate="TextBox1" ErrorMessage="enter the username" ForeColor="Red"></asp:RequiredFieldValidator>
        <p>
            <asp:Label ID="Label2" runat="server" Text="password"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="val2" runat="server" ControlToValidate="TextBox2" ErrorMessage="enter the password" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
        </p>
    </form>
</body>
</html>
