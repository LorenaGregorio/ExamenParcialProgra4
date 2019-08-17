using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelosExamenParcialProgra4.Clientes
{
    public class ClientesModel
    {
        public int IdCliente { get; set; }
        public string Nombres { get; set; } 
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Nit { get; set; }
        public int NumerodePedido { get; set; }
        public string DescripcionPedido { get; set; }
        public string FormadePago { get; set; }
    }
}
