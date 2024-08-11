<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CakesList.aspx.cs" Inherits="Q2_ProductsDropdown.Cakes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CAKE FACTORY</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Select a Cake :</h2>
            <asp:DropDownList ID="id" runat="server" AutoPostBack="true" OnSelectedIndexChanged="CakeList_SelectedIndexChanged">
                <asp:ListItem Value="Select" Text="Select"></asp:ListItem>
                <asp:ListItem Value="Caramel Crunch" Text="Caramel Crunch"></asp:ListItem>
                <asp:ListItem Value="Chocolate Truffle" Text="Chocolate Truffle"></asp:ListItem>
                <asp:ListItem Value="Fruit n Nut" Text="Fruit n Nut"></asp:ListItem>
                <asp:ListItem Value="Macaron Rush" Text="Macaron Rush"></asp:ListItem>
                <asp:ListItem Value="Red Velvet" Text="Red Velvet"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Image ID="img" runat="server" Width="327px" Height="299px"/>
            <br />
            <br />
            <asp:Button ID="Btn_GetPrice" runat="server" Text="Cake Price" OnClick="Btn_GetPrice_Click" />
            <br />
            <br />
            <asp:Label ID="label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
