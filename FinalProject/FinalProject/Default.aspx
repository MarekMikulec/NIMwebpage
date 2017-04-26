<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FinalProject._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="text-align:center">
        <h1>Tahání zápalek</h1>
        <p class="lead">Webová hra vytvořená jako semestrální projekt do předmětu BOOP.</p>
        <p class="lead">Autoři: Marek Mikulec, Petr Vančo</p>



        <div class="row">
            <div class="col-md-4">
                <p><a href="/GameOnePlayer" class="btn btn-primary btn-lg">Spustit hru pro jednoho hráče &raquo;</a></>
            </div>
            <div class="col-md-4">
            </div>
            <div class="col-md-4">
                <p><a href="/Game" class="btn btn-primary btn-lg">Spustit hru pro dva hráče &raquo;</a></p>
            </div>

        </div>
        <h1 style="text-align:center">Pravidla hry</h1>
        <p class="lead">Ve hře je 20 sirek. Hráč má možnost táhnout 1, 2 nebo 3 sirky. Vyhrává ten hráč, který táhne jako poslední.
        Jinými slovy prohrává ten hráč, na kterého už nezbudou žádné sirky.</p>
    </div>
    <div>
        <asp:Image ID="ImageMain" runat="server" Style="width: 100%; height: 100%;" />
    </div>

</asp:Content>
