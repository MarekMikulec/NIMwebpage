<%@ Page Title="Game" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Game.aspx.cs" Inherits="FinalProject.Contact" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h3 style="text-align:center;">"Vyberte si, kolik zápalek chcete odebrat."</h3>
        <div style="margin-left: 12%;">
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Style="padding-left: 5px; padding-right: 20px; padding-bottom: 5px; padding-top: 3px; font-size: 19px; margin: 5px; border-radius: 2px;">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="Táhnout" OnClick="Button1_Click" Style="padding: 5px; border-radius: 2px; margin: 5px; background-color: navajowhite; font-weight: bold;" />

            <asp:Button ID="Button2" runat="server" Text="Táhnout" OnClick="Button2_Click" Style="padding: 5px; border-radius: 2px; margin-left:45%; margin-right:5px; background-color: navajowhite; font-weight: bold;" />
            <asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Style="padding-left: 5px; padding-right: 20px; padding-bottom: 5px; padding-top: 3px; font-size: 19px; margin: 5px; border-radius: 2px;">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
            </asp:DropDownList>
            
        </div>
        <div style="text-align:center;">
            Ve hře zbývá 
        <asp:Label ID="Label1" runat="server" Text="" Font-Bold="true"></asp:Label>
             sirek.
        </div>

        <div>
            <asp:Image ID="Image1" runat="server" Style="width: 100%; height: 100%; border: 1px solid black;" />
        </div>
    </div>

</asp:Content>


