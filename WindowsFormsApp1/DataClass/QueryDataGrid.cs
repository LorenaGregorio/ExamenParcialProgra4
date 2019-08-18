using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.DataClass
{
      class QueryDataGrid
    {
        //variables
        MySqlConnection conn;



        //Conexion

        public void Conectar()
        {
            conn = new MySqlConnection("Server= 127.0.0.1; Database=odeodal; Uid=root;");
            conn.Open();
        }


        //metodo para desconectar
        public void Desconectar()
        {
            conn.Close();
        }
        //Metodo para actualizar en DataGridView
        public void ActualizarGrid(DataGridView dg, string consulta)
        {
            //llamo al metodo conectar que me da la conexion con la base de datos
            this.Conectar();

            //se Crea una referencia para los datos 
            //Para que se tome los datos de la base de datos y los jale en datagridview
            System.Data.DataSet ds = new System.Data.DataSet();



            //se crea un adaptador para los datos de la base de datos
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, conn);



            //Se realiza una funcion de llenado para la tabla del datagridview
            da.Fill(ds, "clientetbl");

            //se agregan las propiedades al datagridview
            dg.DataSource = ds;

            //esta fucnion va a traer todo el contenido de la tabla que mecionamos arriba
            dg.DataMember = "clientetbl";

            this.Desconectar();
        }
    }
}
