<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Almacen.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="Style_user.css"/>
    <style type="text/css">
        .auto-style2 {
            border-style: dashed;
            border-color: inherit;
            border-width: medium;
            position: absolute;
            top: 39px;
            left: 122px;
            z-index: 1;
             }
        .auto-style3 {
            border-style: dashed;
            border-color: inherit;
            border-width: medium;
            position: absolute;
            top: 74px;
            left: 123px;
            z-index: 1;
            }
        .auto-style4 {
            border-style: dashed;
            border-color: inherit;
            border-width: medium;
            position: absolute;
            top: 105px;
            left: 123px;
            z-index: 1;
            }
        .auto-style5 {
            border-style: dashed;
            border-color: inherit;
            border-width: medium;
            position: absolute;
            top: 137px;
            left: 124px;
            z-index: 1;
            }
        .auto-style6 {
             border-style: dashed;
            border-color: inherit;
            border-width: medium;
            position: absolute;
            top: 170px;
            left: 124px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 43px;
            left: 16px;
            z-index: 1;
            width: 90px;
            text-align:right;
        }
        .auto-style8 {
            position: absolute;
            top: 107px;
            left: 14px;
            z-index: 1;
            width: 90px;
            text-align:right;
        }
        .auto-style9 {
            position: absolute;
            top: 140px;
            left: 20px;
            z-index: 1;
            width: 90px;
            text-align:right;
        }
        .auto-style11 {
            position: absolute;
            top: 78px;
            left: 13px;
            z-index: 1;
            width: 90px;
            text-align:right;
        }
        .auto-style12 {
            position: absolute;
            top: 209px;
            left: 139px;
            z-index: 1;
            right: 65px;
            height: 26px;
        }
        .auto-style13 {
            width: 282px;
            height: 255px;
            position: absolute;
            top: 307px;
            left: 683px;
            margin-left: 0px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 15px;
            left: 91px;
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
            left: 686px;
            top: 247px;
            position: absolute;
            height: 46px;
        }
        .auto-style17 {
         position: absolute;
            top: 208px;
            left: 140px;
            z-index: 1;
            right: 64px;
            height: 26px;
        }
        .auto-style18 {
            width: 110%;
            max-width: 1200px;
            margin: 20px 20px;
            overflow: hidden;
            height: 680px;
        }
        .auto-style19 {
            width: 1000px;
            padding: 0.5%;
            margin: 20px 20px;
            border-style: double;
            background: rgb(0,200,255,0.1);
            height: 437px;
        }
        .auto-style20 {
            width: 586px;
            height: 237px;
            z-index: 1;
            left: 79px;
            top: 246px;
            position: absolute;
        }
        .auto-style21 {
            height: 396px;
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
              <section class="auto-style19" class="auto-style23">	
                <article id="entradas">
		                <article id="portada" class="auto-style21"> 
        <div class="auto-style16">
        <asp:Panel ID="Panel1" runat="server" CssClass="auto-style15">
                 <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 324px; top: 185px; " Text="¿Agregar comprador?" Height="35px" Width="266px"/>
        </asp:Panel>
        </div>
         <asp:Panel ID="Panel3" runat="server" CssClass="auto-style13">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2"></asp:TextBox>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style3"></asp:TextBox>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style4"></asp:TextBox>
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style5"></asp:TextBox>
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style6"></asp:TextBox>
                    <asp:Label ID="Label3" runat="server" CssClass="auto-style8" Text="ID: "></asp:Label>
                    <asp:Label ID="Label4" runat="server" CssClass="auto-style9" Text="Contraseña: "></asp:Label>
                    <asp:Label ID="Label2" runat="server" CssClass="auto-style11" Text="Apellido: "></asp:Label>
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style7" Text="Nombre: "></asp:Label>
                    <asp:Label ID="Label6" runat="server" Text="Ingreso de datos" CssClass="auto-style14"></asp:Label>
                    <asp:Button ID="Button5" runat="server" CssClass="auto-style12" OnClick="Button5_Click" Text="Registrar" />
                    <asp:Button ID="Button6" runat="server" CssClass="auto-style17" Text="Modificar" OnClick="Button6_Click" />
                    <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 3px; top: 175px; position: absolute; right: 166px;" Text="Id Administrador"></asp:Label>
                </asp:Panel>
        <div class="auto-style20">
        <asp:Panel ID="Panel2" runat="server" Height="196px" Width="541px" style="z-index: 1; left: 24px; top: 22px; position: absolute; height: 196px; width: 541px">
            <asp:GridView ID="GridView1" runat="server" DataKeyNames="id_user" OnRowDeleting="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </asp:Panel>
        </div>
                            </article>
                    </article>
                  </section>
            </div>
    </form>
</body>
</html>
