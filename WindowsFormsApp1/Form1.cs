using ModelosExamenParcialProgra4.Clientes;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataClass;
using WindowsFormsApp1.Reader;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        QueryDataGrid con = new QueryDataGrid();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
           {
                ClientesModel cliente = new ClientesModel();
                ClientesReader reader = new ClientesReader(QuerysRepo.TipoQuery.Todos, cliente);
         

                    con.ActualizarGrid(this.dataGridView1, "SELECT * FROM cafeteriadb.clientetbl");


            }
            catch (Exception)
            {

                throw;
            }
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
