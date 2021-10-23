using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Almacen
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        WebForm5 wf = new WebForm5();
        Consultas consultas = new Consultas();
        public static int identificacion, cantidad;
        public static double precio,valor_compra;
        SqlCommand consultar_produc;
        Conexion conexcion = new Conexion();
        SqlDataAdapter dataa = new SqlDataAdapter();
        DataSet datas = new DataSet();
        public SqlDataReader datos;
        public static string idcate;
        public void consultar_pro()
        {
            consultar_produc = new SqlCommand("select nombre_productos,precio_productos from productos", conexcion.conectar());
            consultar_produc.CommandType = CommandType.Text;
            consultar_produc.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(consultar_produc);
          DataTable dtab = new DataTable();
            da.Fill(dtab);
            try
            {
                GridView1.DataSource = dtab;
                GridView1.DataBind();
            }
            catch (Exception e) //muestra posible error
            {
               //MessageBox.Show("");
            }
        }
        public void Consultar_Producto_Cate(string idecate)
        {
            SqlDataReader dtorigen;
            SqlCommand consulta;
            consulta = new SqlCommand("select  nombre_productos,precio_productos from productos where id_categoria=@id_categoria", conexcion.conectar());
            consulta.CommandType = CommandType.Text;
            consulta.Parameters.AddWithValue("@id_categoria", idecate);
            consulta.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            DataTable dtab = new DataTable();
            da.Fill(dtab);
            dtorigen = consulta.ExecuteReader();
            try
            {
                GridView1.DataSource = dtab;
                GridView1.DataBind();
            }
            catch (Exception error)
            {
              
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            consultar_pro();
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            Label1.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Button1.Visible = false;
            ListBox1.Enabled = false;           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            precio = double.Parse(TextBox2.Text);
            cantidad = int.Parse(TextBox3.Text);
            valor_compra = valor_compra + (precio * cantidad);
            
            if (TextBox3.Text != "0")
            {
                ListBox1.Items.Add("Nombre producto: "+  TextBox1.Text.ToString());
                ListBox1.Items.Add("$ " + TextBox2.Text.ToString());
                ListBox1.Items.Add("Cantidad: " + TextBox3.Text.ToString());
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            TextBox2.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            TextBox1.Enabled = false;
            TextBox2.Enabled = false;
            TextBox1.Visible = true;
            TextBox3.Text = "1";
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            Label1.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Button1.Visible = true; 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            valor_compra = 0;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "1";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
            ListBox1.Items.Add("Valor total a pagar: " + valor_compra.ToString());
            //Response.Redirect("WebForm5.aspx?parametro="+valor_compra);
        }
    }
}