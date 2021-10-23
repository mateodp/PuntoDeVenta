 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
//using System.Windows.Forms;
namespace Almacen
{
    public class Consultas
    {
        Conexion conexcion = new Conexion();
        SqlDataAdapter dataa = new SqlDataAdapter();
        DataSet datas = new DataSet();
        Boolean estado_conexcion = false;
        SqlCommand registro;
        public SqlDataReader datos;
       SqlDataReader Lista;
        public int id;
        public int i;
        public int d;
        public Boolean inicio_sesion(int user, string pass)
        {
            if (i == 0)
            {
                SqlCommand conectar;//SqlCommand → escribe la consulta que se quiere ejecutar
                conectar = new SqlCommand("select id_admin, pass from administrador where id_admin=@id_admin and pass=@pass", conexcion.conectar());//consulta SqlServer
                conectar.Parameters.AddWithValue("@id_admin", user.ToString());//especifica el tipo de comando
                conectar.Parameters.AddWithValue("@pass", pass);//pasa los valores que tiene el metodo,el de abajo tambien ↓
                conectar.ExecuteNonQuery();//ejecuta la consulta Sql
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(conectar);//asocia la consulta que se va a ejecutar
                    da.Fill(datas, "administrador");//especifica de que tabla se van a tomar(llenar) los datos. Fill → llenar
                    DataRow dr;//hace referencia a las filas de una tabla
                    dr = datas.Tables["administrador"].Rows[0];//asigna una fila a la variable
                    if (user.ToString() == dr["id_admin"].ToString() & pass == dr["pass"].ToString())
                    {
                        WebForm1 wf = new WebForm1();
                       // wf.identificacion = user ;
                        d = 1;
                        estado_conexcion = true;
                    }
                    else
                    {
                        i = 1;
                    }
                }
                catch (Exception ex)
                {
                    i = 1;
                    if (i == 0)
                    {
                       // MessageBox.Show(ex.Message);
                    }
                }
            } if (i == 1)
            {
                SqlCommand conectar;//SqlCommand → escribe la consulta que se quiere ejecutar
                conectar = new SqlCommand("select id_user, pass from usuarios where id_user=@id_user and pass=@pass", conexcion.conectar());//consulta SqlServer
                conectar.Parameters.AddWithValue("@id_user", user.ToString());//especifica el tipo de comando
                conectar.Parameters.AddWithValue("@pass", pass);//pasa los valores que tiene el metodo,el de abajo tambien ↓
                conectar.ExecuteNonQuery();//ejecuta la consulta Sql
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(conectar);//asocia la consulta que se va a ejecutar
                    da.Fill(datas, "usuarios");//especifica de que tabla se van a tomar(llenar) los datos. Fill → llenar
                    DataRow dr;//hace referencia a las filas de una tabla
                    dr = datas.Tables["usuarios"].Rows[0];//asigna una fila a la variable
                    if (user.ToString() == dr["id_user"].ToString() & pass == dr["pass"].ToString())
                    {
                        d = 2;
                        estado_conexcion = true;
                    }
                    else
                    {
                        i = 1;
                    }
                }
                catch (Exception ex)
                {
                    i = 2;
                    if (i == 0)
                    {
                        //MessageBox.Show(ex.Message);
                    }
                }
            }
            if (i == 2)
            {
                //MessageBox.Show("no esta registrado", "aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return estado_conexcion;
        }
        public SqlCommand registro_admin(string user, string pass, string nombre, string apellido)
        {
            try
            {
                registro = new SqlCommand("insert into administrador(id_admin,pass,nombre,apellido) values (@id_admin,@pass,@nombre,@apellido)", conexcion.conectar());
                registro.CommandType = CommandType.Text;
                registro.Parameters.AddWithValue("@id_admin", SqlDbType.VarChar).Value = user;
                registro.Parameters.AddWithValue("@pass", SqlDbType.VarChar).Value = pass;
                registro.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = nombre;
                registro.Parameters.AddWithValue("@apellido", SqlDbType.VarChar).Value = apellido;
                registro.ExecuteNonQuery();
               //MessageBox.Show("Usuario registrado con excito");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return registro;
        }
        public SqlCommand registro_compra(string user, string pass, string nombre, string apellido, string admin)
        {
            try
            {
                registro = new SqlCommand("insert into usuarios(id_user,pass,nombre,apellido,id_admin) values (@id_user,@pass,@nombre,@apellido,@id_admin)", conexcion.conectar());
                registro.CommandType = CommandType.Text;
                registro.Parameters.AddWithValue("@id_user", SqlDbType.VarChar).Value = user;
                registro.Parameters.AddWithValue("@pass", SqlDbType.VarChar).Value = pass;
                registro.Parameters.AddWithValue("@nombre", SqlDbType.VarChar).Value = nombre;
                registro.Parameters.AddWithValue("@apellido", SqlDbType.VarChar).Value = apellido;
                registro.Parameters.AddWithValue("@id_admin", SqlDbType.VarChar).Value = admin;
                registro.ExecuteNonQuery();
            }
            catch (Exception ex)
            {}
            return registro;
        }
        public SqlCommand registro_categorias(string user, string nombre, string id_admi)
        {
            try
            {
                registro = new SqlCommand("insert into categorias(id_categorias,nombre_categorias,id_admin) values (@id_categorias,@nombre_categorias,@id_admin)", conexcion.conectar());
                registro.CommandType = CommandType.Text;
                registro.Parameters.AddWithValue("@id_categorias", SqlDbType.VarChar).Value = user;
                registro.Parameters.AddWithValue("@nombre_categorias", SqlDbType.VarChar).Value = nombre;
                registro.Parameters.AddWithValue("@id_admin", SqlDbType.VarChar).Value = id_admi;
                registro.ExecuteNonQuery();
                //MessageBox.Show("Usuario registrado con excito");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return registro;
        }
        public void eliminar_admin(int user)
        {
            SqlCommand borrarctg = new SqlCommand("DELETE from categorias where id_admin=@id_admin", conexcion.conectar());
            borrarctg.Parameters.AddWithValue("@id_admin", user);
            borrarctg.ExecuteNonQuery();
            SqlCommand comando = new SqlCommand("DELETE from Administrador where id_admin=@id_admin", conexcion.conectar());
            comando.Parameters.AddWithValue("@id_admin", user);
            comando.ExecuteNonQuery();
        }
        public void eliminar_comprador(int user)
        {
            SqlCommand comando = new SqlCommand("DELETE from usuarios where id_user=@id_user", conexcion.conectar());
            comando.Parameters.AddWithValue("@id_user", user);
            comando.ExecuteNonQuery();
        }
        public void eliminar_categorias(int user)
        {
            SqlCommand comando = new SqlCommand("DELETE from categorias where id_categorias=@id_categorias", conexcion.conectar());
            comando.Parameters.AddWithValue("@id_categorias", user);
            comando.ExecuteNonQuery();
        }
        public void Modificar_admin(string user, string pass, string nombre, string apellido)
        {
            SqlCommand actualizar = new SqlCommand("update administrador set pass=@pass, nombre=@nombre, apellido=@apellido where id_admin=@id_admin", conexcion.conectar());
            try
            {
                actualizar.Parameters.AddWithValue("@id_admin", user);
                actualizar.Parameters.AddWithValue("@pass", pass);
                actualizar.Parameters.AddWithValue("@nombre", nombre);
                actualizar.Parameters.AddWithValue("@apellido", apellido);
                actualizar.ExecuteNonQuery();
                datas.Clear();
                
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
        }
        public void Modificar_user(string user, string pass, string nombre, string apellido)
        {
            SqlCommand actualizar = new SqlCommand("update usuarios set pass=@pass, nombre=@nombre, apellido=@apellido where id_user=@id_user", conexcion.conectar());
            try
            {
                actualizar.Parameters.AddWithValue("@id_user", user);
                actualizar.Parameters.AddWithValue("@pass", pass);
                actualizar.Parameters.AddWithValue("@nombre", nombre);
                actualizar.Parameters.AddWithValue("@apellido", apellido);
                actualizar.ExecuteNonQuery();
                datas.Clear();
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
        }
        public void Modificar_carat(string user, string nombre, string id_admin)
        {
            SqlCommand actualizar = new SqlCommand("update categorias set nombre_categorias=@nombre_categorias where id_categorias=@id_categorias", conexcion.conectar());
            try
            {
                actualizar.Parameters.AddWithValue("@id_categorias", user);
                actualizar.Parameters.AddWithValue("@nombre_categorias", nombre);
                actualizar.Parameters.AddWithValue("@id_admin", id_admin);
                actualizar.ExecuteNonQuery();
                datas.Clear();
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
            }
        }
        public void consultarid_cat(string nomb)//
        {
            DataSet ds = new DataSet();
            SqlCommand consulta;
            consulta = new SqlCommand("select id_categorias from categorias where nombre_categorias=@nombre_categorias", conexcion.conectar());
            consulta.CommandType = CommandType.Text;
            consulta.Parameters.AddWithValue("@nombre_categorias", nomb);
            consulta.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(consulta);
            da.Fill(ds, "categorias");
            datos = consulta.ExecuteReader();//saca los datos de la tabla
            try
            {

            }
            catch (Exception error)
            {

            }
        }
        public void Lista_categorias(DropDownList cb)
        {
            cb.Items.Clear();
            conexcion.conectar();
            SqlCommand cmd = new SqlCommand("select nombre_categorias from categorias", conexcion.conectar());
            Lista = cmd.ExecuteReader();
            while (Lista.Read())
            {
                cb.Items.Add(Lista[0].ToString());
            }
            cb.Items.Insert(0, "Categorias");
            cb.SelectedIndex = 0;
        }
        public SqlCommand registro_productos(string idprod, string idcat, string nombreprod, string precioprod)
        {
            try
            {
                registro = new SqlCommand("insert into productos(id_productos,id_categoria,nombre_productos,precio_productos) values (@id_productos,@id_categoria,@nombre_productos,@precio_productos)", conexcion.conectar());
                registro.CommandType = CommandType.Text;
                registro.Parameters.AddWithValue("@id_productos", SqlDbType.VarChar).Value = idprod;
                registro.Parameters.AddWithValue("@id_categoria", SqlDbType.VarChar).Value = idcat;
                registro.Parameters.AddWithValue("@nombre_productos", SqlDbType.VarChar).Value = nombreprod;
                registro.Parameters.AddWithValue("@precio_productos", SqlDbType.Float).Value = precioprod;
                registro.ExecuteNonQuery();
                //MessageBox.Show("Producto registrado con excito");
            }
            catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
            }
            return registro;
        }
    }
        
}