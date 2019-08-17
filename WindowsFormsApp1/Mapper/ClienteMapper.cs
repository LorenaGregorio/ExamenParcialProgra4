using ModelosExamenParcialProgra4.Clientes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Mapper
{
    class ClienteMapper : MapperBase<ClientesModel>
    {
        protected override ClientesModel Map(IDataRecord registro)
        {
            try
            {
                ClientesModel Clientes = new ClientesModel
                {
                    IdCliente = registro["IdCliente"] == DBNull.Value ? 0 : (int)registro["IdCliente"],
                    Nombres = registro["Nombres"] == DBNull.Value ? string.Empty : (string)registro["Nombres"],
                    Apellidos = registro["Apellidos"] == DBNull.Value ? string.Empty : (string)registro["Apellidos"],
                    Direccion = registro["Direccion"] == DBNull.Value ? string.Empty : (string)registro["Direccion"],
                    Nit = registro["Nit"] == DBNull.Value ? string.Empty : (string)registro["Nit"],
                    NumerodePedido = registro["NumerodePedido"] == DBNull.Value ? 0 : (int)registro["NumerodePedido"],
                    DescripcionPedido = registro["DescripcioPedido"] == DBNull.Value ? string.Empty : (string)registro["DescripcionPedido"],
                    FormadePago = registro["FormadePago"] == DBNull.Value ? string.Empty : (string)registro["FormadePago"]

                };
                return Clientes;


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
