<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Auth</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>ASP.NET Web Forms</h1>
        <hr />
        <hr />
        <asp:Button runat="server" OnClick="ChangeTheme" Text="Apply theme:" />
        <asp:RadioButton ID="RBThemeBlue" runat="server" GroupName="theme" Text="Blue" Checked="true" />
        <asp:RadioButton ID="RBThemeRed" runat="server" GroupName="theme" Text="Red" />
        <hr />
        <p>Login:</p>
        <asp:TextBox ID="TBLogin" runat="server" />
        <br />
        <p>Password:</p>
        <asp:TextBox ID="TBPassword" runat="server" />
        <p>Sex:</p>
        <asp:RadioButton ID="RBSexMale" runat="server" GroupName="sex" Text="Male" />
        <asp:RadioButton ID="RBSexFeale" runat="server" GroupName="sex" Text="Female" />
        <asp:RadioButton ID="RBSexOther" runat="server" GroupName="sex" Text="Other" />
        <br />
        <p>About:</p>
        <asp:TextBox ID="TBAbout" TextMode="multiline" Columns="40" Rows="5" runat="server"></asp:TextBox>
        <br />
        <p>Weekend:</p>
        <asp:CheckBoxList ID="CBLWeekend" runat="server"></asp:CheckBoxList>
        <hr />
        <hr />
        <asp:ListBox ID="LBProducts" runat="server" Rows="10" Width="400" Height="150" SelectionMode="Multiple"></asp:ListBox>
        <asp:ListBox ID="LBCart" runat="server" Rows="10" Width="400" Height="150" SelectionMode="Multiple"></asp:ListBox>
        <asp:Button runat="server" OnClick="AddProducts" Text="Add" />
        <asp:Button runat="server" OnClick="AddAllProducts" Text="Add all" />
        <asp:Button runat="server" OnClick="RemoveProducts" Text="Remove" />
        <asp:Button runat="server" OnClick="RemoveAllProducts" Text="Remove all" />
    </form>
</body>
</html>
