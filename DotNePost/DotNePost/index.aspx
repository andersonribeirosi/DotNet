<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="DotNePost.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="350px"></asp:ListBox>
    <div>
    </div>
        <asp:TextBox ID="TextBox1" runat="server" Height="114px" Width="339px"></asp:TextBox>
        <p>
        <asp:Button ID="Button1" runat="server" Text="Comentar" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
