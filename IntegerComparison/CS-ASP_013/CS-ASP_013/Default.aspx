﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CS_ASP_013.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Is&nbsp;&nbsp;
        <asp:TextBox ID="firstTextBox" runat="server" OnTextChanged="firstTextBox_TextChanged"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="comparisonTypeLabel" runat="server"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
&nbsp;&nbsp; ?<br />
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="OK" />
        <br />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>