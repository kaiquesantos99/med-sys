
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
        public void InserirEstoque(Estoque estoque)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO estoque (tipo, medicamento, quantidade) VALUES (@tipo, @medicamento, @quantidade)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tipo", estoque.Tipo);
                cmd.Parameters.AddWithValue("@medicamento", estoque.Medicamento);
                cmd.Parameters.AddWithValue("@quantidade", estoque.Quantidade);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Estoque> ReadEstoqueFor(string tipo)
        {
            List<Estoque> listaEstoque = new List<Estoque>();

            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM estoque WHERE tipo = @tipo";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@tipo", tipo);
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

        public void UpdateEstoque(string id, string valor)
        {

            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE estoque SET quantidade = @valor WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@valor", int.Parse(valor));
                    cmd.Parameters.AddWithValue("@id", int.Parse(id));
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Atualizado!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Digite somente números!");
            }

            
        }

        public void DeleteEstoque(int id)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM estoque WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Medicamento excluído com sucesso!");
            }
        }

    }

}

