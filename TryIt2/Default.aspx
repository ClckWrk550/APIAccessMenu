<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryIt2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
    &nbsp;</p>
<p>
    <span style="color: rgb(51, 51, 51); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Temp/Sort Services Implemented @ <a href="http://webstrar26.fulton.asu.edu/page0/">http://webstrar26.fulton.asu.edu/page3/</a></span></p>
<p>
    &nbsp;</p>
<p>
    <strong><span style="text-decoration: underline">Temp Conversion App</span> - Takes an int &amp; returns proper unit conversion</strong></p>
<p>
    Input Farenheight :
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Convert!" />
</p>
<p>
    Output (Celsius) :
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    Input Celsius :
    &nbsp;<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Convert!" />
</p>
<p>
    Output (Farenheight) :
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
</p>
<p>
    &nbsp;</p>
<p>
    <strong><span style="text-decoration: underline">Sorter App</span> - Takes a string of ints (must be separated by commas) and sorts them from least to greatest</strong></p>
<p>
    Input :
    <asp:TextBox ID="TextBox5" runat="server" Width="210px"></asp:TextBox>
&nbsp;<asp:Button ID="Button3" runat="server" Text="Sort!" OnClick="Button3_Click" />
</p>
<p>
    Sorted Output :
    <asp:TextBox ID="TextBox6" runat="server" Width="210px"></asp:TextBox>
    <br />
</p>
<p>
</p>

</asp:Content>
