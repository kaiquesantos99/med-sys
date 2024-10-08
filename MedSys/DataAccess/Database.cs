using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSys.DataAccess
{
    internal class Database
    {
        private string connectionString = "Server=localhost;Database=medsys;Uid=root;Pwd=;";

        public MySqlConnection GetConnection ()
        {
            return new MySqlConnection (connectionString);
        }
    }
}
