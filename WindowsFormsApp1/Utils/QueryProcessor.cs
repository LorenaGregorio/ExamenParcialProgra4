using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Utils
{
    public static class QueryProcessor
    {

        public static string QueryAll(string query, string NombreTabla)
        {
            return query.Replace("TABLA", NombreTabla);

        }
       


        public static string QueryAll(string query, string NombreTabla, object DataModel)
        {
            return query.Replace("TABLA", NombreTabla) + " WHERE " + ProcessDataModel(DataModel);
        }
        private static string ProcessDataModel(object DataModel)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var propertyInfo in DataModel.GetType().GetProperties())
            {
                if (propertyInfo.GetValue(DataModel) != null)
                {
                    sb.Append(propertyInfo.Name + " = " + " '" + propertyInfo.GetValue(DataModel).ToString() + "' AND ");
                }
            }


            return sb.ToString().Substring(0, sb.ToString().Length - 4);
        }
    }

}

