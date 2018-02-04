<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: "Times New Roman", Times, serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Height="150px" ImageUrl="~/epic-spies-logo.jpg" />
        </div>
        <h2 style="font-family: Arial, Helvetica, sans-serif">Asset Performance Tracker</h2>
        <p class="auto-style1">
            Asset Name :&nbsp;
            <asp:TextBox ID="assetNameTextBox" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            Elections Rigged:&nbsp;
            <asp:TextBox ID="electionsRiggedTextBox" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            Acts of Subterfuge Performed:&nbsp;
            <asp:TextBox ID="actsOfSubterfugeTextBox" runat="server"></asp:TextBox>
        </p>
        <p class="auto-style1">
            <asp:Button ID="addButton" runat="server" OnClick="addButton_Click" Text="Add Asset" />
        </p>
        <p class="auto-style1">
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
        <p class="auto-style1">
            &nbsp;</p>
    </form>
</body>
</html>
