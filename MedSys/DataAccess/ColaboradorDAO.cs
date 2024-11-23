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
                string query = "SELECT COUNT(*) FROM MEDICO m, ENFERMEIRO e, RECEPCIONISTA r WHERE e.usuario = @usuarioe AND e.senha = @senhae OR m.usuario = @usuariom AND m.senha = @senham OR r.usuario = @usuarior AND r.senha = @senhar";

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuarioe", usuario);
                    cmd.Parameters.AddWithValue("@senhae", senha);
                    cmd.Parameters.AddWithValue("@usuariom", usuario);
                    cmd.Parameters.AddWithValue("@senham", senha);
                    cmd.Parameters.AddWithValue("@usuarior", usuario);
                    cmd.Parameters.AddWithValue("@senhar", senha);
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
