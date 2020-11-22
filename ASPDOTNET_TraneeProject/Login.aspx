<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectTrials.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container bg-primary text-white"  style="padding:30px;border-radius:5px;max-width:50%;box-shadow: -3px -1px 15px -2px #000000;">
        <table class="table">
            <tbody>
                <tr style="text-align: center">
                    <td colspan="2"><b>Please Enter Your username and password</b></td>
                </tr>
                <tr>
                    <td>Enter your username</td>
                    <td>
                        <asp:TextBox ID="Username" runat="server" CssClass="form-control"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>Enter your password</td>
                    <td><asp:TextBox ID="Password" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr style="text-align: center">
                    <td colspan="2">
                        <asp:Button ID="LoginButton" runat="server" Text="Login" CssClass="btn btn-success" OnClick="LoginButton_Click"  /></td>
                </tr>
            </tbody>
        </table>
        <div class="row justify-content-center">
            <div class="col-md-12">
                <asp:Label ID="LabelMessage" runat="server" CssClass="text-danger text-center" Text="Please enter a valid username and password " Visible="False"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
