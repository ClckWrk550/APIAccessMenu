<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Project2WebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server">
</asp:Panel>
<div _designerregion="0" style="height: 382px">
<div _designerregion="0" style="height: 454px">
<div _designerregion="0">
    <br />
    <br />
    <strong><span style="text-decoration: underline">Top10Words App</span> - Takes a URL &amp; returns the top ten most used words</strong><br />
    <br />
    Input URL Here :
    <asp:TextBox ID="TextBox1" runat="server" Width="278px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;<asp:Button ID="top10Btn" runat="server" Text="Find Top10!" OnClick="top10Btn_Click" />
    <br />
    <br />
    Output :
    <asp:TextBox ID="TextBox3" runat="server" Width="290px"></asp:TextBox>
    <br />
    <br />
    <br />
    <strong><span style="text-decoration: underline">WordFilter App</span> - Takes a string/sentence and removes common English words</strong><br />
    <br />
    Input String Here :
    <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" Width="245px"></asp:TextBox>
    <asp:Button ID="filtWords" runat="server" OnClick="filtWords_Click" Text="Filter Words!" />
    <br />
    <br />
    Ouput :
    <asp:TextBox ID="TextBox4" runat="server" Width="290px"></asp:TextBox>
    <br />
    <br />
    <br />
    <br />
    <br />
</div>
</div>
</div>
</asp:Content>
