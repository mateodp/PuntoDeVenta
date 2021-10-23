<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Almacen.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" href="user.css"/>
    <style type="text/css">
        .auto-style2 {
            border-style: dashed;
            border-color: inherit;
            border-width: medium;
            position: absolute;
            top: 39px;
            left: 144px;
            z-index: 1;
            bottom: 190px;
        }
        .auto-style3 {
            border-style: dashed;
            border-color: inherit;
            border-width: medium;
            position: absolute;
            top: 74px;
            left: 144px;
            z-index: 1;
            }
        .auto-style4 {
            border-style: dashed;
            border-color: inherit;
            border-width: medium;
            position: absolute;
            top: 105px;
            left: 144px;
            z-index: 1;
            }
        .auto-style8 {
            position: absolute;
            top: 42px;
            left: 24px;
            z-index: 1;
            width: 112px;
            text-align:right;
        }
        .auto-style9 {
            position: absolute;
            top: 77px;
            left: -2px;
            z-index: 1;
            width: 142px;
            text-align:right;
        }
        .auto-style12 {
            position: absolute;
            top: 155px;
            left: 47px;
            z-index: 1;
            right: 157px;
            height: 26px;
        }
        .auto-style13 {
            width: 282px;
            height: 255px;
            position: absolute;
            top: 240px;
            left: 633px;
            margin-left: 0px;
            z-index: 1;
        }
        .auto-style15 {
            width: 268px;
            height: 38px;
            position: absolute;
            top: 4px;
            left: 5px;
            z-index: 1;
        }
        .auto-style16 {
            width: 281px;
            z-index: 1;
            left: 634px;
            top: 187px;
            position: absolute;
            height: 46px;
        }
        .auto-style17 {
         position: absolute;
            top: 160px;
            left: 100px;
            z-index: 1;
            right: 104px;
            height: 26px;
        }
        .auto-style18 {
            z-index: 1;
            left: 10px;
            top: 109px;
            position: absolute;
            right: 148px;
        }
        .auto-style19 {
            position: absolute;
            top: 5px;
            left: 93px;
            z-index: 1;
        }
        .auto-style20 {
            z-index: 1;
            left: 23px;
            top: 22px;
            position: absolute;
            height: 196px;
            width: 541px;
        }
        .auto-style21 {
            width: 586px;
            height: 237px;
            z-index: 1;
            left: 22px;
            top: 207px;
            position: absolute;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
             <div class="contenedor">
        <div class="auto-style16">
        <asp:Panel ID="Panel1" runat="server" CssClass="auto-style15">
                 <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 324px; top: 185px; " Text="¿Agregar Categoria?" Height="35px" Width="266px"/>
        </asp:Panel>
        </div>
         <asp:Panel ID="Panel3" runat="server" CssClass="auto-style13">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2"></asp:TextBox>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style3"></asp:TextBox>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style4"></asp:TextBox>
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style8" Text="ID categoria: "></asp:Label>
                    <asp:Label ID="Label2" runat="server" CssClass="auto-style9" Text="Nombre categoria: "></asp:Label>
                    <asp:Button ID="Button5" runat="server" CssClass="auto-style12" OnClick="Button5_Click" Text="Registrar" />
                    <asp:Button ID="Button6" runat="server" CssClass="auto-style17" Text="Modificar" OnClick="Button6_Click" />
                    <asp:Label ID="Label4" runat="server" Text="Id Administrador" CssClass="auto-style18"></asp:Label>
                    <asp:Label ID="Label5" runat="server" Text="Ingreso de datos" CssClass="auto-style19"></asp:Label>
                </asp:Panel>
         <header>
	    <div class="ancho"> 
		<div class="logo">
			<p class="txtlogo"><a href="Default.aspx">Inicio</a></p>
		</div>
		<nav>
			<ul id="barra">
				<li><a href="WebForm1.aspx">Administradores</a></li>
				<li><a href="WebForm2.aspx">Usuarios</a></li>
                <li><a href="WebForm3.aspx">Categorias</a></li>
                <li><a href="WebForm5.aspx">Productos</a></li>
			</ul>
		</nav>
	    </div>
        </header>
        <div class="auto-style21">
        <asp:Panel ID="Panel2" runat="server" Height="196px" Width="541px" CssClass="auto-style20">
            <asp:GridView ID="GridView1" runat="server" OnRowDeleting="GridView1_RowDeleting1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" DataKeyNames="id_categorias">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </asp:Panel>
        </div>
            </div>
    </form>
</body>
</html>
