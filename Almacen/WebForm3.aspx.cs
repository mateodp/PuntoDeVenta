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
    public partial class WebForm3 : System.Web.UI.Page
    {
        Consultas consultas = new Consultas();
        public int identificacion;
        int id_categoria;
        SqlCommand consultar_categoria;
        Conexion conexcion = new Conexion();
        SqlDataAdapter dataa = new SqlDataAdapter();
        DataSet datas = new DataSet();
        public SqlDataReader datos;
        public void consultar_cat()
        {
            consultar_categoria = new SqlCommand("select * from categorias", conexcion.conectar());
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
            consultar_cat();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Panel3.Visible = true;
            Label5.Text = "Datos de nuevo usuario";
            Button6.Visible = false;
            Button5.Visible = true;
            TextBox1.Enabled = true;
            TextBox3.Enabled = false;
            TextBox3.Text = "1044930444";
            TextBox2.Text = "";
            TextBox1.Text = "";
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            consultas.registro_categorias(TextBox1.Text, TextBox2.Text, TextBox3.Text);
            TextBox1.Text = "";
            TextBox2.Text = "";

            consultar_cat();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            consultas.Modificar_carat (TextBox1.Text, TextBox2.Text, TextBox3.Text);
            TextBox2.Text = "";
            TextBox1.Text = "";
            consultar_cat();
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            TextBox2.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            TextBox3.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            TextBox1.Enabled = false;
            TextBox3.Enabled = false;
            Button5.Visible = false;
            Button6.Visible = true;
            Label4.Text = "Edicion de datos";
            Panel3.Visible = true;
        }

        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            id_categoria = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            consultas.eliminar_categorias(id_categoria);
            consultar_cat();
        }

    }
}