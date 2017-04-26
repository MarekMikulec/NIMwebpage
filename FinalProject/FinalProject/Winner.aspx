<%@ Page Title="Winner" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Winner.aspx.cs" Inherits="FinalProject.Winner" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron" style="text-align: center">
        <h1 style="text-align: center">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h1>
        <h3 style="text-align: center;">Děkujeme za hru!</h3>
        <asp:Image ID="Image1" runat="server" ImageUrl="images/goblet.png" Width="30%" ImageAlign="AbsMiddle" />
        <div style="text-align: center">
            <%--<a href="/GameOnePlayer" class="btn btn-primary btn-lg">Nová hra pro jednoho hráče &raquo;</a>
            <a href="/Game" class="btn btn-primary btn-lg">Nová hra pro dva hráče &raquo;</a>
            --%>
            <a href="/Default" class="btn btn-primary btn-lg" style="background-color:black">Domů &raquo;</a>
        </div>
    </div>
</asp:Content>
