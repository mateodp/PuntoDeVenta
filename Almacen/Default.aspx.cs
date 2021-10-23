using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Almacen
{
    public partial class _Default : Page
    {
        Consultas consultas = new Consultas();
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            consultas.inicio_sesion(int.Parse(TextBox1.Text), TextBox2.Text);
            if (consultas.d == 1)
            {
                Response.Redirect("WebForm1.aspx?parametro=" + TextBox1.Text);
              
            }
            if (consultas.d == 2)
            {
                Response.Redirect("WebForm4.aspx");
            }
            
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}