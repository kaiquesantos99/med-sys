using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSys.DataAccess
{
    internal class ColaboradorDAO
    {
        // ATRIBUTOS
        private Database db;
        


        // METODOS
        public ColaboradorDAO()
        {
            db = new Database();
        }

        public bool VerificarIdentidade (string usuario, string senha)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open ();
                string query = "SELECT COUNT(*) FROM COLABORADORES WHERE usuario = @usuario AND senha = @senha";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@senha", senha);
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    return result == 1;
                }   
                
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                    return false;
                }

            }
        }
        
    }
}
