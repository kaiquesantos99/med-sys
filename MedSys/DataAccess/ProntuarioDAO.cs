using MedSys.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSys.DataAccess
{
    internal class ProntuarioDAO
    {
        private Database db;

        public ProntuarioDAO()
        {
            db = new Database();
        }



        // Leitura
        public List<Internacao> ReadInternacaoForName(string p)
        {
            List<Internacao> listaInternacao = new List<Internacao>();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT i.id id, p.nome paciente, p.cpf cpf, p.nascimento nascimento, p.sexo sexo, i.leito leito, i.setor setor, i.internado_tempo tempo_internado, m.nome medico, m.especialidade especialidade, p.status_paciente status_paciente FROM medico m JOIN internacao i on m.id = i.id_medico JOIN paciente p on p.id = i.id_paciente WHERE p.nome LIKE @nome";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nome", p + "%");
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Internacao internacao = new Internacao()
                        {

                            Atendimento = reader.GetInt32("id"),
                            Paciente = reader.GetString("paciente"),
                            Cpf = reader.GetString("cpf"),
                            Nascimento = reader.GetDateTime("nascimento").ToString().Substring(0,10),
                            Sexo = reader.GetString("sexo"),
                            Leito = reader.GetString("leito"),
                            Setor = reader.GetString("setor"),
                            InternadoTempo = reader.GetDateTime("tempo_internado").ToString().Substring(0, 10),
                            Medico = reader.GetString("medico"),
                            Especialidade = reader.GetString("especialidade"),
                            StatusPaciente = reader.GetString("status_paciente")

                        };
                        listaInternacao.Add(internacao);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }

                return listaInternacao;

            }

        }

        public List<Internacao> ReadInternacao(string p)
        {
            List<Internacao> listaInternacao = new List<Internacao>();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT i.id id, p.nome paciente, p.cpf cpf, p.nascimento nascimento, p.sexo sexo, i.leito leito, i.setor setor, i.internado_tempo tempo_internado, m.nome medico, m.especialidade especialidade, p.status_paciente status_paciente FROM medico m JOIN internacao i on m.id = i.id_medico JOIN paciente p on p.id = i.id_paciente";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Internacao internacao = new Internacao()
                        {

                            Atendimento = reader.GetInt32("id"),
                            Paciente = reader.GetString("paciente"),
                            Cpf = reader.GetString("cpf"),
                            Nascimento = reader.GetDateTime("nascimento").ToString().Substring(0, 10),
                            Sexo = reader.GetString("sexo"),
                            Leito = reader.GetString("leito"),
                            Setor = reader.GetString("setor"),
                            InternadoTempo = reader.GetDateTime("tempo_internado").ToString().Substring(0, 10),
                            Medico = reader.GetString("medico"),
                            Especialidade = reader.GetString("especialidade"),
                            StatusPaciente = reader.GetString("status_paciente")

                        };
                        listaInternacao.Add(internacao);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }

                return listaInternacao;

            }

        }

        public List<DetalhesInternacao> ReadDetalhesInternacao(int i)
        {
            List<DetalhesInternacao> listaInternacaoDetalhes = new List<DetalhesInternacao>();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT di.data_atualizacao Data_Atualizacao, di.detalhes Detalhes FROM detalhes_internacao di JOIN internacao i ON di.id_internacao = i.id WHERE i.id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", i);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        DetalhesInternacao internacaoDetalhes = new DetalhesInternacao()
                        {
                            DataAtualizacao = reader.GetDateTime("Data_Atualizacao").ToString(),
                            Detalhes = reader.GetString("Detalhes")

                        };
                        listaInternacaoDetalhes.Add(internacaoDetalhes);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }

                return listaInternacaoDetalhes;

            }

        }



        // Inserção
        public void InternarPaciente(Internacao i, int idpaciente, int idmedico)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO internacao (id_paciente, leito, setor, id_medico) VALUES (@idpaciente, @leito, @setor, @idmedico)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idpaciente", idpaciente);
                    cmd.Parameters.AddWithValue("@leito", i.Leito);
                    cmd.Parameters.AddWithValue("@setor", i.Setor);
                    cmd.Parameters.AddWithValue("@idmedico", idmedico);

                    cmd.ExecuteNonQuery();
                }
                
                conn.Close();


                conn.Open();
                string query2 = "UPDATE paciente SET status_paciente = @statuspaciente WHERE id = @id";
                using (MySqlCommand cmd2 = new MySqlCommand(query2, conn))
                {
                    cmd2.Parameters.AddWithValue("@statuspaciente", "Internado");
                    cmd2.Parameters.AddWithValue("@id", idpaciente);

                    cmd2.ExecuteNonQuery();
                }

                conn.Close();



                conn.Open();
                int idinternacao;
                string query3 = "SELECT i.id FROM internacao i JOIN paciente p ON i.id_paciente = p.id WHERE id_paciente = @idpaciente AND p.status_paciente = @internado ";
                using (MySqlCommand cmd3 = new MySqlCommand(query3, conn))
                {
                    cmd3.Parameters.AddWithValue("@idpaciente", idpaciente);
                    cmd3.Parameters.AddWithValue("@internado", "Internado");
                    idinternacao = Convert.ToInt32(cmd3.ExecuteScalar());
                }
                    

               


                conn.Close();
                conn.Open();
                string query4 = "INSERT INTO detalhes_internacao (detalhes, id_internacao) VALUES (@detalhes, @idinternacao)";
                using (MySqlCommand cmd4 = new MySqlCommand(query4, conn))
                {
                    cmd4.Parameters.AddWithValue("@detalhes", "O paciente foi internado.");
                    cmd4.Parameters.AddWithValue("@idinternacao", idinternacao);

                    cmd4.ExecuteNonQuery();
                }

                MessageBox.Show("Paciente internado com sucesso!");


            }

        }




        
    }
}
