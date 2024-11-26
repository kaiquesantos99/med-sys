using MedSys.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSys.DataAccess
{
    internal class PacienteDAO
    {
        // ATRIBUTOS
        private Database db;



        // METODOS
        public PacienteDAO()
        {
            db = new Database();
        }

        public List<PacienteFiltrado> ReadPacientesFiltro()
        {
            List<PacienteFiltrado> listaPacientes = new List<PacienteFiltrado>();
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, nome, cpf, nascimento, status_paciente FROM paciente";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PacienteFiltrado paciente = new PacienteFiltrado
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Cpf = reader.GetString("cpf"),
                        Nascimento = reader.GetDateTime("nascimento").ToString().Substring(0,10),
                        Status_paciente = reader.GetString("status_paciente")
                    };
                    listaPacientes.Add(paciente);
                }
            }
            return listaPacientes;
        }

        public List<Paciente> ReadPacientes()
        {
            List<Paciente> listaPacientes = new List<Paciente>();
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM paciente";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Paciente paciente = new Paciente
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Nascimento = reader.GetDateTime("nascimento").ToString().Substring(0, 10),
                        Cpf = reader.GetString("cpf"),
                        Rg = reader.GetString("rg"),
                        Cep = reader.GetString("cep"),
                        Logradouro = reader.GetString("logradouro"),
                        Numero = reader.GetInt32("numero"),
                        Complemento = reader["complemento"] != DBNull.Value ? reader["complemento"].ToString() : "",
                        Bairro = reader.GetString("bairro"),
                        Cidade = reader.GetString("cidade"),
                        Uf = reader.GetString("uf"),
                        Telefone = reader.GetString("telefone"),
                        Telefone_2 = reader["telefone_2"] != DBNull.Value ? reader["telefone_2"].ToString() : "",
                        Acompanhante = reader["acompanhante"] != DBNull.Value ? reader["acompanhante"].ToString() : "",
                        Carteirinha = reader.GetString("carteirinha"),
                        Convenio = reader.GetString("convenio"),
                        Peso = reader.GetFloat("peso"),
                        Altura = reader.GetFloat("altura"),
                        Observacoes = reader.GetString("observacoes"),
                        Status_Paciente = reader.GetString("status_paciente"),
                        Sexo = reader.GetString("sexo")
                    };
                    listaPacientes.Add(paciente);
                }
            }
            return listaPacientes;
        }

        public List<PacienteFiltrado> ReadPacientesForStatus(string status)
        {
            List<PacienteFiltrado> listaPacientes = new List<PacienteFiltrado>();
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, nome, cpf, nascimento, status_paciente FROM paciente WHERE status_paciente = @statuspaciente";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@statuspaciente", status);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    PacienteFiltrado paciente = new PacienteFiltrado
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Cpf = reader.GetString("cpf"),
                        Nascimento = reader.GetDateTime("nascimento").ToString().Substring(0, 10),
                        Status_paciente = reader.GetString("status_paciente")
                    };
                    listaPacientes.Add(paciente);
                }
            }
            return listaPacientes;
        }

        public List<PacienteFiltrado> SearchPacienteForName(string nome)
        {
            List<PacienteFiltrado> listaPaciente = new List<PacienteFiltrado>();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, nome, cpf, nascimento, status_paciente FROM paciente WHERE nome LIKE @nome";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nome", nome + "%");
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        PacienteFiltrado paciente = new PacienteFiltrado()
                        {

                            Id = reader.GetInt32("id"),
                            Nome = reader.GetString("nome"),
                            Cpf = reader.GetString("cpf"),
                            Nascimento = reader.GetDateTime("nascimento").ToString().Substring(0, 10),
                            Status_paciente = reader.GetString("status_paciente")

                        };
                        listaPaciente.Add(paciente);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }

                return listaPaciente;

            }

        }
    }
}
