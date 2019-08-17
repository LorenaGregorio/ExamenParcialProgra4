using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelosExamenParcialProgra4.Clientes;
using WindowsFormsApp1.DataClass;

namespace WindowsFormsApp1.Reader
{
    class ClientesReader
    {
        private QuerysRepo.TipoQuery conFiltros;
        private ClientesModel clientemodel;

        public ClientesReader(QuerysRepo.TipoQuery conFiltros, ClientesModel clientemodel)
        {
            this.conFiltros = conFiltros;
            this.clientemodel = clientemodel;
        }

        internal Collection<ClientesModel> Execute()
        {
            throw new NotImplementedException();
        }
    }
}
