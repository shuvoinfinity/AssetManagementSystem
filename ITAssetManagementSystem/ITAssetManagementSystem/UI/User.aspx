<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="ITAssetManagementSystem.UI.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <div class="row">
     <asp:Label ID="lblUser" runat="server"></asp:Label>
     <h2 class="lead"> Users List </h2>
     <asp:GridView ID="GridUsers" runat="server">
         
     </asp:GridView>
 </div>   
</asp:Content>
