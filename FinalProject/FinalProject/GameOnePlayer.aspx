<%@ Page Title="Game One Player" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GameOnePlayer.aspx.cs" Inherits="FinalProject.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        
        <h3 style="text-align: center;">Vyberte si obtížnost hry: 
            <asp:DropDownList ID="DropDownListDifficulties" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Style="padding-left: 5px; padding-right: 20px; padding-bottom: 5px; padding-top: 3px; font-size: 19px; margin: 5px; border-radius: 2px;">
                <asp:ListItem>Lehká</asp:ListItem>
                <asp:ListItem>Střední</asp:ListItem>
                <asp:ListItem>Těžká</asp:ListItem>
            </asp:DropDownList>
        </h3>
        <h3 style="text-align: center;">Vyberte si, kolik zápalek chcete odebrat.</h3>

        <div style="text-align: center">
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Style="padding-left: 5px; padding-right: 20px; padding-bottom: 5px; padding-top: 3px; font-size: 19px; margin: 5px; border-radius: 2px;">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="Táhnout" OnClick="Button1_Click" CssClass="btn btn-primary btn-lg" />
        </div>

        <div style="text-align: center;">
            Ve hře zbývá 
        <asp:Label ID="Label1" runat="server" Text="" Font-Bold="true"></asp:Label>
            sirek.
        </div>

        <div>
            <asp:Image ID="Image1" runat="server" Style="width: 100%; height: 100%; border: 1px solid black;" />
        </div>
    </div>

</asp:Content>

