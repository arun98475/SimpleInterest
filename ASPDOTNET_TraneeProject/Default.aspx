<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjectTrials._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <div class="container p-3 mt-5 bg-primary text-white text-center" style="margin-top:20px;border-radius:5px;box-shadow: -3px -1px 15px -2px #000000;">
       <h1>
           <asp:Label ID="LabelDefaultText1" runat="server"></asp:Label>

       </h1>
       <h1>
           <asp:Label ID="LabelDefaultText2" runat="server"></asp:Label>

       </h1>
   </div>

</asp:Content>
