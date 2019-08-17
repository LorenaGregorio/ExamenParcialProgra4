using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataClass
{
    public static class QuerysRepo
    {
        public const string SelectAll = "SELECT * FROM cafeteriadb.clientetbl";
        public const string SelectByID = "SELECT * FROM odeodal.persona WHERE idpersona = ID";
        public const string SelectAllByFilters = "SELECT * FROM odeodal.persona ";
        public const string SelectByIDByFilters = "SELECT * FROM odeodal.persona WHERE idpersona = ID";

        public enum TipoQuery { Todos, PorId, TodosConFiltros, PorIdConFiltro, ConFiltros }
    }
}
