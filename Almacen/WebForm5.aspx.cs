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
    public partial class WebForm5 : System.Web.UI.Page
    {
        Consultas consultas = new Consultas();
        public string identificacion;
        int id_admin;
        SqlCommand consultar_produc;
        Conexion conexcion = new Conexion();
        SqlDataAdapter dataa = new SqlDataAdapter();
        DataSet datas = new DataSet();
        public SqlDataReader datos;
        public void consultar_pro()
        {
            consultar_produc = new SqlCommand("select * from productos", conexcion.conectar());
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
        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (Request.Params["parametro"] != null)
            {
                Label1.Text = Request.Params["parametro"];
            }*/
            consultar_pro();
            texboxt1.Visible = false;
            TextBox2.Visible = false;
            TextBox3.Visible = false;
            TextBox4.Visible = false;
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Label4.Visible = false;
            Button1.Visible = false;
            Button2.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            texboxt1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            Label1.Visible = true;
            Label2.Visible = true;
            Label3.Visible = true;
            Label4.Visible = true;
            Button1.Visible = true;
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            id_admin = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
            consultas.eliminar_admin(id_admin);
            consultar_pro();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           consultas.registro_productos(texboxt1.Text,TextBox2.Text,TextBox3.Text,TextBox4.Text);
           consultar_pro();
        }
    }
}