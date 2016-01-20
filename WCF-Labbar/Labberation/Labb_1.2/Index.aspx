<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Labb_1._2.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        
    
    </div>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="AddNumbers" runat="server" Text="SummerTal" OnClick="AddNumbers_Click" />
        <br/>
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
       
    </form>
</body>
</html>
