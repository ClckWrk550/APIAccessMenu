<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TryitEncryption._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
    &nbsp;</p>
<p>
    E<span style="color: rgb(51, 51, 51); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">ncryption Service Sourced @<span>&nbsp;http://venus.sod.asu.edu/WSRepository/Services/EncryptionWcf/Service.svc?wsdl</span></span></p>
<p>
    &nbsp;</p>
<p>
    Encrypt/Decrypt App - Takes a string and encrypts/decrypts it using AES standards</p>
<p>
    &nbsp;</p>
<p>
    Input String You Wish to Encrypt:
    <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
&nbsp;<asp:Button ID="Button1" runat="server" Text="Encrypt!" OnClick="Button1_Click" />
</p>
<p>
    Encrypted String :
    <asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox>
</p>
<p>
    Decrypted (Check) :
    <asp:TextBox ID="TextBox3" runat="server" Width="200px"></asp:TextBox>
</p>
&nbsp;

</asp:Content>
