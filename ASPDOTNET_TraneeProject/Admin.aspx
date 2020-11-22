<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="ProjectTrials.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <div class="container bg-primary text-white"  style="padding:30px;border-radius:5px;max-width:50%;box-shadow: -3px -1px 15px -2px #000000;">
        <table class="table">
            <tbody>
                <tr style="text-align: center">
                    <td colspan="2"><b>ADMIN CONTROL PANEL</b></td>
                </tr>
                <tr>
                    <td>Default Page Text1</td>
                    <td>
                        <asp:TextBox ID="Text1" runat="server" CssClass="form-control"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>Default Page Text2</td>
                    <td><asp:TextBox ID="Text2" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Header Text</td>
                    <td><asp:TextBox ID="HeaderText" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Footer Text</td>
                    <td><asp:TextBox ID="FooterText" runat="server" CssClass="form-control"></asp:TextBox></td>
                </tr>
                <tr style="text-align: center">
                    <td colspan="2">
                        <asp:Button ID="Button1" runat="server" Text="Save Settings" CssClass="btn btn-success" OnClick="Button1_Click" /></td>
                </tr>
            </tbody>
        </table>
    </div>
</asp:Content>
