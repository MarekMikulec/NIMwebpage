<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FinalProject._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="text-align:center">
        <h1>Tahání zápalek</h1>
        <p class="lead">Webowá hra vytvořená jako semestrální projekt do předmětu BOOP.</p>
        <p>Autoři: Marek Mikulec, Petr Vančo</p>



        <div class="row">
            <div class="col-md-4">
                <p><a href="/GameOnePlayer" class="btn btn-primary btn-lg">Spustit hru pro jednoho hráče &raquo;</a></p>


                <%--    <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>--%>
            </div>
            <div class="col-md-4">
                <%--<h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>--%>
            </div>
            <div class="col-md-4">
                <p><a href="/Game" class="btn btn-primary btn-lg">Spustit hru pro dva hráče &raquo;</a></p>

                <%--            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>--%>
            </div>

        </div>
    </div>
    <div>
        <asp:Image ID="ImageMain" runat="server" Style="width: 100%; height: 100%;" />
    </div>

</asp:Content>
