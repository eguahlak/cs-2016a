<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ASP_WEB_Forms_Application.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>
      <asp:TextBox ID="GreetingText" runat="server"></asp:TextBox>
      Use this area to provide additional information.</p>
  <asp:Button ID="NokButton" Text="Tryk ikke her" runat="server" CommandName="Nedlæg" OnCommand="OkButton_Command"/>
  <asp:Button ID="OkButton" Text="Tryk her" runat="server" CommandName="Opret" OnCommand="OkButton_Command"/>
</asp:Content>
