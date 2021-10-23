<%@ Page Title="Página principal" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Almacen._Default" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="Styl.css">
    <style type="text/css">
        .auto-style4 {
            position: relative;
            left: 61px;
            top: -7px;
            width: 130px;
        }
        .auto-style5 {
            position: relative;
            text-align:center;
            left: 2px;
            top: 5px;
        }
        .auto-style6 {
            position: relative;
            left: 60px;
            top: 11px;
            width: 132px;
        }
        .auto-style7 {
            position: relative;
            left: 3px;
            top: 23px;
            text-align:center;
        }
       
        .auto-style9 {
            width: 258px;
            padding: 0.5%;
            margin: 20px 0px;
            border-style: double;
            background: rgb(0,200,255,0.1);
            height: 209px;
            position: absolute;
            top: 195px;
            left: 527px;
            z-index: 1;
        }
        
    </style>
</head>
<body class="auto-style8">
    <form id="form1" runat="server" class="auto-style2">
        
            <asp:Panel ID="Panel1" runat="server" Height="200px" Width="250px" CssClass="auto-style9">
                 <p class="auto-style7">Usuario</p>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style6"></asp:TextBox>
                <p class="auto-style5">Contraseña</p>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" CssClass="auto-style4"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Iniciar sesion" CssClass="auto-style8" />
            </asp:Panel>  
       
    </form>
    
</body>
</html>
