<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Assignment_1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblQ1" runat="server" Text="What is your name?"></asp:Label><asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
            
            <p>What ice-cream flavors do you like?</p>
            <asp:CheckBox ID="cbVanilla" runat="server" /><asp:Label ID="lblA" runat="server" Text="Vanilla"></asp:Label><br />
            <asp:CheckBox ID="cbChocolate" runat="server" /><asp:Label ID="lblB" runat="server" Text="Chocolate"></asp:Label><br />
            <asp:CheckBox ID="cbCookie" runat="server" /><asp:Label ID="lblC" runat="server" Text="Cookies 'N Cream"></asp:Label><br />
            <asp:CheckBox ID="cbPistachio" runat="server" /><asp:Label ID="lblD" runat="server" Text="Pistachio"></asp:Label><br />
            <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />
        </div>
    </form>
</body>
</html>
