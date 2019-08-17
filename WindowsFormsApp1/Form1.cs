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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClientesModel clientemodel = new ClientesModel();
                clientemodel.IdCliente = 1;
                clientemodel.Nombres = "Carmela Ines";
                clientemodel.Apellidos = "Lopez Gonzalez";
                clientemodel.Direccion = "Ciudad";
                clientemodel.Nit = "12582-K";
                clientemodel.NumerodePedido = 5;
                clientemodel.DescripcionPedido = "Te frío";
                clientemodel.FormadePago = "Contado";

                ClientesReader reader = new ClientesReader(QuerysRepo.TipoQuery.ConFiltros, clientemodel);
                Collection<ClientesModel> clientes = reader.Execute();

                foreach (ClientesModel c  in clientes)
                {

                    ActualizarGrid(this.dataGridView1, "SELECT * FROM cafeteriadb.clientetbl");

                }



            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ActualizarGrid(DataGridView dataGridView1, string v)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
    }
}
