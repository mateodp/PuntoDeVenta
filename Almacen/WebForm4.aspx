<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Almacen.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="user.css"/>
    <style type="text/css">
        .auto-style1 {
            height: 9px;
            width: 259px;
        }
        
        .auto-style2 {
            z-index: 1;
            left: 118px;
            top: 207px;
            position: absolute;
            width: 121px;
        }
        .auto-style3 {
            position: absolute;
            top: 250px;
            left: 120px;
            z-index: 1;
        }
        
        .auto-style4 {
            position: absolute;
            top: 520px;
            left: 153px;
            z-index: 1;
            width: 124px;
            height: 45px;
            bottom: 36px;
            right: 692px;
        }
        .auto-style5 {
            z-index: 1;
            left: 507px;
            top: 187px;
            position: absolute;
            height: 182px;
            width: 492px;
        }
        .auto-style6 {
            position: absolute;
            top: 376px;
            left: 134px;
            z-index: 1;
            width: 301px;
            height: 132px;
        }
        
        .auto-style7 {
            position: absolute;
            top: 520px;
            left: 304px;
            z-index: 1;
            width: 116px;
            height: 45px;
        }
        
        .auto-style8 {
            z-index: 1;
            left: 220px;
            top: 337px;
            position: absolute;
        }
        
        .auto-style9 {
            z-index: 1;
            left: 183px;
            top: 293px;
            position: absolute;
            width: 66px;
            right: 720px;
        }
        .auto-style10 {
            z-index: 1;
            left: 255px;
            top: 293px;
            position: absolute;
        }
        .auto-style11 {
            z-index: 1;
            left: 254px;
            top: 250px;
            position: absolute;
        }
        .auto-style12 {
            z-index: 1;
            left: 252px;
            top: 206px;
            position: absolute;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="contenedor">
        <header>
	    <div class="ancho"> 
		<div class="logo">
			<p class="txtlogo"><a href="Default.aspx">Inicio</a></p>
		</div>
            </header>
    <div class="auto-style1">
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="auto-style5">
            <Columns>
                <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style12"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style11"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style10"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Cantidad" CssClass="auto-style9"></asp:Label>
        <asp:Label ID="Label1" runat="server" Text="Nombre Producto" CssClass="auto-style2"></asp:Label>
            <asp:Button ID="Button1" runat="server" Text="Agregar al Carrito" OnClick="Button1_Click" CssClass="auto-style8" />
        <asp:Label ID="Label4" runat="server" CssClass="auto-style3" Text="Precio del producto"></asp:Label>
    </div>  
        <asp:Button ID="Button3" runat="server" CssClass="auto-style7" Text="Realizar compra" OnClick="Button3_Click" />
        <asp:Button ID="Button2" runat="server" CssClass="auto-style4" OnClick="Button2_Click" Text="Cancelar Compra" />
        <asp:ListBox ID="ListBox1" runat="server" CssClass="auto-style6"></asp:ListBox>
        </div>
    </form>
</body>
</html>
