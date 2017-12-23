<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Value A"></asp:Label>
        <asp:TextBox ID="txta" runat="server"></asp:TextBox>
        <br />
        Value B<asp:TextBox ID="txtB" runat="server"></asp:TextBox>
        <asp:Button ID="btnPlus" runat="server" OnClick="Button1_Click" Text="Plus" />
        <asp:Button ID="btnSub" runat="server" Text="Sub" />
        <asp:Button ID="btnMul" runat="server" Text="Multiple" />
        <asp:Button ID="btnDiv" runat="server" Text="Div" />
        <br />
        <br />
        Result:<br />
        <asp:TextBox ID="txtResult" runat="server"></asp:TextBox>
    </form>
</body>
</html>
