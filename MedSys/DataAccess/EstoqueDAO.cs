
using MedSys.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSys.DataAccess
{
    internal class EstoqueDAO
    {
        private Database db;

        public EstoqueDAO()
        {
            db = new Database();
        }

        public List<Estoque> ReadEstoque()
        {
            List<Estoque> listaEstoque = new List<Estoque>();

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM estoque";
                MySqlCommand cmd = new MySqlCommand(query, conn); 
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Estoque estoque = new Estoque()
                    {
                        Id = reader.GetInt32("id"),
                        Tipo = reader.GetString("tipo"),
                        Medicamento = reader.GetString("medicamento"),
                        Quantidade = reader.GetInt32("quantidade")
                    };
                    listaEstoque.Add(estoque);
                }
                return listaEstoque;
            } 
            
        }
        
    
    }

}

