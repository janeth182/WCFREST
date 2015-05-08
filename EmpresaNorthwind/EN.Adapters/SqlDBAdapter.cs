using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace EN.Adapters
{
    public static class SqlDBAdapter
    {
        public static string GetConexion() 
        {
            return ConfigurationManager.ConnectionStrings["cnnenNorthwind"].ConnectionString;
        }
    }
}
