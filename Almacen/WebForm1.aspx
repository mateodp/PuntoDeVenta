<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Almacen.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="Style_admin.css"/>
    <style type="text/css">
        .auto-style19 {
            width: 265px;
            height: 223px;
            position: relative;
            top: -151px;
            left: 637px;
            margin-left: 0px;
            z-index: 1;
        }
        .auto-style20 {
            z-index: 1;
            left: 15px;
            top: 16px;
            position: relative;
            height: 227px;
            width: 546px;
        }
        .auto-style22 {
            width: 187px;
            z-index: 1;
            left: 725px;
            top: 179px;
            position: absolute;
            height: 45px;
        }
        .auto-style23 {
            width: 842px;
        }
        .auto-style24 {
            z-index: 1;
            left: 324px;
            top: 185px;
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
            <section class="seccion" class="auto-style23">	
                <article id="entradas">
		                <article id="portada"> 
        <asp:Panel ID="Panel2" runat="server" CssClass="auto-style20">
            <asp:GridView ID="GridView1" runat="server" Height="51px" Width="538px" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="id_admin" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="True" EditText="Actualizar" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </asp:Panel> 
        <div class="auto-style22">
        <asp:Panel ID="Panel1" runat="server" >
                 <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="¿Agregar administradores?" Height="35px" Width="180px" CssClass="auto-style24"/>
        </asp:Panel>
        </div>
         <asp:Panel ID="Panel3" runat="server" CssClass="auto-style19">
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2"></asp:TextBox>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style3"></asp:TextBox>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style4"></asp:TextBox>
                    <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style5"></asp:TextBox>
                    <asp:Label ID="Label3" runat="server" CssClass="auto-style8" Text="ID: "></asp:Label>
                    <asp:Label ID="Label4" runat="server" CssClass="auto-style9" Text="Contraseña: "></asp:Label>
                    <asp:Label ID="Label2" runat="server" CssClass="auto-style11" Text="Apellido: "></asp:Label>
                    <asp:Label ID="Label1" runat="server" CssClass="auto-style7" Text="Nombre: "></asp:Label>
                    <asp:Label ID="Label6" runat="server" Text="Ingreso de datos" CssClass="auto-style14"></asp:Label>
                    <asp:Button ID="Button5" runat="server" CssClass="auto-style12" OnClick="Button5_Click" Text="Registrar" />
                    <asp:Button ID="Button6" runat="server" CssClass="auto-style17" Text="Modificar" OnClick="Button6_Click" />
                </asp:Panel>
                            </article>
                    </article>
            </section>
        </div>
        
    </form>
</body>
</html>
