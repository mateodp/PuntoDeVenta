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
    public partial class WebForm2 : System.Web.UI.Page
    {
        Consultas consultas = new Consultas();
        public string identificacion;
        int id_user;

        SqlCommand consultar_compra;
        Conexion conexcion = new Conexion();
        SqlDataAdapter dataa = new SqlDataAdapter();
        DataSet datas = new DataSet();
        public SqlDataReader datos;
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel3.Visible = false;
            consultar_comprad();
            identificacion = Request.Params["parametro"];
        }
        public void consultar_comprad()
        {
            consultar_compra = new SqlCommand("select * from usuarios", conexcion.conectar());
            consultar_compra.CommandType = CommandType.Text;
            consultar_compra.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(consultar_compra);
            DataTable dtab = new DataTable();
            da.Fill(dtab);
            try
            {
                GridView1.DataSource = dtab;
                GridView1.DataBind();
            }
            catch (Exception e) //muestra posible error
            {
                //MessageBox.Show("usuario NO esta registrado");
            }
        }
        
        protected void Button5_Click(object sender, EventArgs e)
        {
            consultas.registro_compra(TextBox3.Text, TextBox4.Text, TextBox1.Text, TextBox2.Text,TextBox5.Text);
            TextBox4.Text = "";
            TextBox3.Text = "";
            TextBox2.Text = "";
            TextBox1.Text = "";
            consultar_comprad();
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
            TextBox5.Text = identificacion;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            consultas.Modificar_user(TextBox3.Text, TextBox4.Text, TextBox1.Text, TextBox2.Text);
            TextBox4.Text = "";
            TextBox3.Text = "";
            TextBox2.Text = "";
            TextBox1.Text = "";
            consultar_comprad();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            id_user = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
           consultas.eliminar_comprador(id_user);
           consultar_comprad();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox3.Text = GridView1.SelectedRow.Cells[1].Text.ToString();
            TextBox4.Text = GridView1.SelectedRow.Cells[2].Text.ToString();
            TextBox1.Text = GridView1.SelectedRow.Cells[3].Text.ToString();
            TextBox2.Text = GridView1.SelectedRow.Cells[4].Text.ToString();
            TextBox5.Text = GridView1.SelectedRow.Cells[5].Text.ToString();
            TextBox3.Enabled = false;
            TextBox5.Enabled = false;
            Button5.Visible = false;
            Button6.Visible = true;
            Label6.Text = "Edicion de datos";
            Panel3.Visible = true;
        }        
    }
}