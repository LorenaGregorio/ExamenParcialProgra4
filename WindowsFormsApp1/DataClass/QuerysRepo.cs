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
       

        public enum TipoQuery { Todos }
    }
}
