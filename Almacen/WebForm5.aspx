<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="Almacen.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" href="user.css"/>
    <style type="text/css">
        .auto-style2 {
            width: 365px;
            height: 188px;
            position: absolute;
            top: 188px;
            left: 38px;
            z-index: 1;
        }
        .auto-style3 {
            position: absolute;
            top: 199px;
            left: 786px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 239px;
            left: 786px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 281px;
            left: 786px;
            z-index: 1;
        }
        .auto-style6 {
            position: absolute;
            top: 326px;
            left: 787px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 202px;
            left: 705px;
            z-index: 1;
        }
        .auto-style8 {
            position: absolute;
            top: 240px;
            left: 704px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 283px;
            left: 666px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 328px;
            left: 674px;
            z-index: 1;
            bottom: 214px;
        }
        .auto-style11 {
            position: absolute;
            top: 382px;
            left: 775px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 384px;
            left: 709px;
            z-index: 1;
            right: 182px;
        }
        .auto-style13 {
            position: absolute;
            top: 158px;
            left: 659px;
            z-index: 1;
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
          <asp:GridView ID="GridView1" runat="server" CssClass="auto-style2" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
              <Columns>
                  <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowSelectButton="True" />
              </Columns>
          </asp:GridView>
          <asp:TextBox ID="texboxt1" runat="server" CssClass="auto-style3"></asp:TextBox>
          <asp:Label ID="Label1" runat="server" Text="Id prodcuto: " CssClass="auto-style7"></asp:Label>
          <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style4"></asp:TextBox>
          <asp:Label ID="Label2" runat="server" Text="Id categoria: " CssClass="auto-style8"></asp:Label>
          <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style5"></asp:TextBox>
          <asp:Label ID="Label3" runat="server" Text="Nombre producto: " CssClass="auto-style9"></asp:Label>
          <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style6"></asp:TextBox>
          <asp:Label ID="Label4" runat="server" Text="Precio producto: " CssClass="auto-style10"></asp:Label>
           <asp:Button ID="Button1" runat="server" CssClass="auto-style11" Text="Registrar" OnClick="Button1_Click" />
           <asp:Button ID="Button2" runat="server" CssClass="auto-style12" Text="Modificar" />
          <asp:Button ID="Button3" runat="server" CssClass="auto-style13" Text="¿Registrar producto?" OnClick="Button3_Click" />
        </div>
       
    </form>
</body>
</html>
