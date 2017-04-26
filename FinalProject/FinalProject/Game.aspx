<%@ Page Title="Game" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GamePage.aspx.cs" Inherits="GamePage" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h2 style="text-align: center;"> 
            <asp:Label ID="Label4" runat="server" Font-Bolt ="true" Text="Hra pro dva hráče" style="color:#428bca"></asp:Label> 
        </h2>
        <h3 style="text-align: center;">Vyberte si, kolik zápalek chcete odebrat.</h3>
        <div class="row">
            <div class="col-md-3" style="text-align:center;">
                    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Style="padding-left: 5px; padding-right: 20px; padding-bottom: 5px; padding-top: 3px; font-size: 19px; margin: 5px; border-radius: 2px;">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="Button1" runat="server" Text="Táhnout" OnClick="Button1_Click" CssClass="btn btn-primary btn-lg" />
            </div>
            <div class="col-md-3"></div>
            <div class="col-md-3"></div>
            <div class="col-md-3" style="text-align:center;">
                <asp:Button ID="Button2" runat="server" Text="Táhnout" OnClick="Button2_Click" CssClass="btn btn-primary btn-lg" />
                <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Style="padding-left: 5px; padding-right: 20px; padding-bottom: 5px; padding-top: 3px; font-size: 19px; margin: 5px; border-radius: 2px;">
                    <asp:ListItem>1</asp:ListItem>
                    <asp:ListItem>2</asp:ListItem>
                    <asp:ListItem>3</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>
        <div style="text-align: center;">
            Ve hře zbývá 
        <asp:Label ID="Label1" runat="server" Text="" Font-Bold="true"></asp:Label>
            sirek.
        </div>

        <div>
            <asp:Image ID="Image1" runat="server" Style="width: 100%; height: 100%; border: 1px solid black; border-radius:4px;" />
        </div>
    </div>

</asp:Content>


