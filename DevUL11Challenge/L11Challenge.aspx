<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="L11Challenge.aspx.cs" Inherits="DevUL11Challenge.L11Challenge" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="~ PART 1 ~" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="~ PART 2 ~" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="~ PART 3 ~" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
