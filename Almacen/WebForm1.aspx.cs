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
    public partial class WebForm1 : System.Web.UI.Page
    {
        Consultas consultas = new Consultas();
        public string identificacion;
        int id_admin;
        SqlCommand consultar_categoria;
        Conexion conexcion = new Conexion();
        SqlDataAdapter dataa = new SqlDataAdapter();
        DataSet datas = new DataSet();
       // Boolean estado_conexcion = false;
        public SqlDataReader datos;
        public void consultar_Admin()
        {
            consultar_categoria = new SqlCommand("select * from administrador", conexcion.conectar());
            consultar_categoria.CommandType = CommandType.Text;
            consultar_categoria.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(consultar_categoria);
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

        protected void Page_Load(object sender, EventArgs e)
        {
            Panel3.Visible = false;
            consultar_Admin();
            identificacion = Request.Params["parametro"];
        }
       
        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel3.Visible = true;
            Label6.Text = "Datos de nuevo usuario";
            Button6.Visible = false;
            Button5.Visible = true;
            TextBox4.Text = "";
            TextBox3.Enabled = true;
            TextBox3.Text = "";
            TextBox2.Text = "";
            TextBox1.Text = "";
            //TextBox5.Text = identificacion;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Panel3.Visible = true;
            Button5.Visible = false; 
            Button6.Visible = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            consultas.registro_admin(TextBox3.Text,TextBox4.Text,TextBox1.Text,TextBox2.Text);
            TextBox4.Text = "";
            TextBox3.Text = "";
            TextBox2.Text = "";
            TextBox1.Text = "";
            consultar_Admin();
        }

        protected void GridView1_RowDeleting(object sender,  GridViewDeleteEventArgs e)
        {
            id_admin = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            consultas.eliminar_admin(id_admin);
            consultar_Admin();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            consultas.Modificar_admin(TextBox3.Text, TextBox4.Text, TextBox1.Text, TextBox2.Text);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox3.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            TextBox4.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            TextBox1.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            TextBox2.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
            TextBox3.Enabled = false;
            Button5.Visible = false;
            Button6.Visible = true;
            Label6.Text = "Edicion de datos";
            Panel3.Visible = true;
        }

        
    }
}