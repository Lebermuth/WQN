<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="WhatQuestNext.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 48px;
            width: 2735px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblTest" runat="server" style="z-index: 1; left: 341px; top: 358px; position: absolute"></asp:Label>
        <asp:Button ID="btnSearch" runat="server" style="z-index: 1; left: 290px; top: 277px; position: absolute" Text="Search Character" OnClick="LoadCharacter" />
        <asp:TextBox ID="txtUsername" runat="server" style="z-index: 1; left: 302px; top: 216px; position: absolute" ToolTip="Enter username"></asp:TextBox>
        <asp:Table ID="tblCharacterStats" runat="server" BorderStyle="Solid" BorderWidth="1px" style="z-index: 1; left: 824px; top: 177px; position: absolute; height: 42px; width: 945px">
            <asp:TableRow ID="Attack" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Defence" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Strength" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Hitpoints" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Ranged" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Prayer" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Magic" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Cooking" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Woodcutting" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Fletching" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Fishing" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Firemaking" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Crafting" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Smithing" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Mining" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Herblore" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Agility" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Thieving" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Slayer" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Farming" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Runecraft" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Hunter" runat="server">
            </asp:TableRow>
            <asp:TableRow ID="Construction" runat="server">
            </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>
