using MedSys.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public bool VerificarIdentidade(string usuario, string senha)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
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
                    return result > 0;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                    return false;
                }

            }
        }


        public void InserirMedico(Medico medico)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO medico (nome, dt_admissao, matricula, crm, nascimento, cpf, rg, pis, especialidade, cep, logradouro, numero, complemento, bairro, cidade, uf, telefone, email, usuario, senha) VALUES (@nome, @dt_admissao, @matricula, @crm, @nascimento, @cpf, @rg, @pis, @especialidade, @cep, @logradouro, @numero, @complemento, @bairro, @cidade, @uf, @telefone, @email, @usuario, @senha)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", medico.Nome);
                cmd.Parameters.AddWithValue("@dt_admissao", medico.Dt_Admissao);
                cmd.Parameters.AddWithValue("@matricula", medico.Matricula);
                cmd.Parameters.AddWithValue("@crm", medico.Crm);
                cmd.Parameters.AddWithValue("@nascimento", medico.Nascimento);
                cmd.Parameters.AddWithValue("@cpf", medico.Cpf);
                cmd.Parameters.AddWithValue("@rg", medico.Rg);
                cmd.Parameters.AddWithValue("@pis", medico.Pis); cmd.Parameters.AddWithValue("@especialidade", medico.Especialidade);
                cmd.Parameters.AddWithValue("@cep", medico.Cep); cmd.Parameters.AddWithValue("@logradouro", medico.Logradouro);
                cmd.Parameters.AddWithValue("@numero", medico.Numero);
                cmd.Parameters.AddWithValue("@complemento", medico.Complemento);
                cmd.Parameters.AddWithValue("@bairro", medico.Bairro);
                cmd.Parameters.AddWithValue("@cidade", medico.Cidade);
                cmd.Parameters.AddWithValue("@uf", medico.Uf);
                cmd.Parameters.AddWithValue("@telefone", medico.Telefone);
                cmd.Parameters.AddWithValue("@email", medico.Email);
                cmd.Parameters.AddWithValue("@usuario", medico.Usuario);
                cmd.Parameters.AddWithValue("@senha", medico.Senha);

                cmd.ExecuteNonQuery();


            }

        }
        public void InserirEnfermeiro(Enfermeiro enfermeiro)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO enfermeiro (nome, dt_admissao, matricula, coren, nascimento, cpf, rg, pis, cep, logradouro, numero, complemento, bairro, cidade, uf, telefone, email, usuario, senha) VALUES (@nome, @dt_admissao, @matricula, @coren, @nascimento, @cpf, @rg, @pis, @cep, @logradouro, @numero, @complemento, @bairro, @cidade, @uf, @telefone, @email, @usuario, @senha)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", enfermeiro.Nome);
                cmd.Parameters.AddWithValue("@dt_admissao", enfermeiro.Dt_Admissao);
                cmd.Parameters.AddWithValue("@matricula", enfermeiro.Matricula);
                cmd.Parameters.AddWithValue("@coren", enfermeiro.Coren);
                cmd.Parameters.AddWithValue("@nascimento", enfermeiro.Nascimento);
                cmd.Parameters.AddWithValue("@cpf", enfermeiro.Cpf);
                cmd.Parameters.AddWithValue("@rg", enfermeiro.Rg);
                cmd.Parameters.AddWithValue("@pis", enfermeiro.Pis);
                cmd.Parameters.AddWithValue("@cep", enfermeiro.Cep);
                cmd.Parameters.AddWithValue("@logradouro", enfermeiro.Logradouro);
                cmd.Parameters.AddWithValue("@numero", enfermeiro.Numero);
                cmd.Parameters.AddWithValue("@complemento", enfermeiro.Complemento);
                cmd.Parameters.AddWithValue("@bairro", enfermeiro.Bairro);
                cmd.Parameters.AddWithValue("@cidade", enfermeiro.Cidade);
                cmd.Parameters.AddWithValue("@uf", enfermeiro.Uf);
                cmd.Parameters.AddWithValue("@telefone", enfermeiro.Telefone);
                cmd.Parameters.AddWithValue("@email", enfermeiro.Email);
                cmd.Parameters.AddWithValue("@usuario", enfermeiro.Usuario);
                cmd.Parameters.AddWithValue("@senha", enfermeiro.Senha);

                cmd.ExecuteNonQuery();


            }
        }
        public void InserirRecepcionista(Recepcionista recepcionista)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO recepcionista (nome, dt_admissao, matricula, nascimento, cpf, rg, pis, cep, logradouro, numero, complemento, bairro, cidade, uf, telefone, email, usuario, senha) VALUES (@nome, @dt_admissao, @matricula, @nascimento, @cpf, @rg, @pis, @cep, @logradouro, @numero, @complemento, @bairro, @cidade, @uf, @telefone, @email, @usuario, @senha)";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nome", recepcionista.Nome);
                cmd.Parameters.AddWithValue("@dt_admissao", recepcionista.Dt_Admissao);
                cmd.Parameters.AddWithValue("@matricula", recepcionista.Matricula);
                cmd.Parameters.AddWithValue("@nascimento", recepcionista.Nascimento);
                cmd.Parameters.AddWithValue("@cpf", recepcionista.Cpf);
                cmd.Parameters.AddWithValue("@rg", recepcionista.Rg);
                cmd.Parameters.AddWithValue("@pis", recepcionista.Pis);
                cmd.Parameters.AddWithValue("@cep", recepcionista.Cep);
                cmd.Parameters.AddWithValue("@logradouro", recepcionista.Logradouro);
                cmd.Parameters.AddWithValue("@numero", recepcionista.Numero);
                cmd.Parameters.AddWithValue("@complemento", recepcionista.Complemento);
                cmd.Parameters.AddWithValue("@bairro", recepcionista.Bairro);
                cmd.Parameters.AddWithValue("@cidade", recepcionista.Cidade);
                cmd.Parameters.AddWithValue("@uf", recepcionista.Uf);
                cmd.Parameters.AddWithValue("@telefone", recepcionista.Telefone);
                cmd.Parameters.AddWithValue("@email", recepcionista.Email);
                cmd.Parameters.AddWithValue("@usuario", recepcionista.Usuario);
                cmd.Parameters.AddWithValue("@senha", recepcionista.Senha);

                cmd.ExecuteNonQuery();
            }
        }

        public void InserirPaciente(Paciente paciente)
        {
            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO paciente (nome, nascimento, cpf, rg, cep, logradouro, numero, complemento, bairro, cidade, uf, telefone, telefone_2, acompanhante, carteirinha, convenio, peso, altura, observacoes, sexo) VALUES (@nome, @nascimento, @cpf, @rg, @cep, @logradouro, @numero, @complemento, @bairro, @cidade, @uf, @telefone, @telefone_2, @acompanhante, @carteirinha, @convenio, @peso, @altura, @observacoes, @sexo)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nome", paciente.Nome);
                    cmd.Parameters.AddWithValue("@nascimento", paciente.Nascimento);
                    cmd.Parameters.AddWithValue("@cpf", paciente.Cpf);
                    cmd.Parameters.AddWithValue("@rg", paciente.Rg);
                    cmd.Parameters.AddWithValue("@cep", paciente.Cep);
                    cmd.Parameters.AddWithValue("@logradouro", paciente.Logradouro);
                    cmd.Parameters.AddWithValue("@numero", paciente.Numero);
                    cmd.Parameters.AddWithValue("@complemento", paciente.Complemento);
                    cmd.Parameters.AddWithValue("@bairro", paciente.Bairro);
                    cmd.Parameters.AddWithValue("@cidade", paciente.Cidade);
                    cmd.Parameters.AddWithValue("@uf", paciente.Uf);
                    cmd.Parameters.AddWithValue("@telefone", paciente.Telefone);
                    cmd.Parameters.AddWithValue("@telefone_2", paciente.Telefone_2);
                    cmd.Parameters.AddWithValue("@acompanhante", paciente.Acompanhante);
                    cmd.Parameters.AddWithValue("@carteirinha", paciente.Carteirinha);
                    cmd.Parameters.AddWithValue("@convenio", paciente.Convenio);
                    cmd.Parameters.AddWithValue("@peso", paciente.Peso);
                    cmd.Parameters.AddWithValue("@altura", paciente.Altura);
                    cmd.Parameters.AddWithValue("@observacoes", paciente.Observacoes);
                    cmd.Parameters.AddWithValue("@sexo", paciente.Sexo);


                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }
                 
               
            }
        }

        public Colaborador ReadUserData(string usuario) // Retorna o CPF e o nome do usuário
        {
            Colaborador nomeCpf = null;

            try
            {
                // VERIFICAÇÃO 1
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query1 = "SELECT id, nome, cpf FROM enfermeiro WHERE usuario = @usuario";
                    MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                    cmd1.Parameters.AddWithValue("usuario", usuario);
                    MySqlDataReader reader1 = cmd1.ExecuteReader();


                    while (reader1.Read())
                    {
                        nomeCpf = new Colaborador
                        {
                            Id = reader1.GetInt32("id"),
                            Nome = reader1.GetString("nome"),
                            Cpf = reader1.GetString("cpf")
                        };
                        return nomeCpf;

                    }


                    // VERIFICAÇÃO 2
                    conn.Close();
                    conn.Open();
                    string query2 = "SELECT id, nome, cpf FROM medico WHERE usuario = @usuario";
                    MySqlCommand cmd2 = new MySqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("usuario", usuario);
                    MySqlDataReader reader2 = cmd2.ExecuteReader();

                    while (reader2.Read())
                    {
                        nomeCpf = new Colaborador
                        {
                            Id = reader2.GetInt32("id"),
                            Nome = reader2.GetString("nome"),
                            Cpf = reader2.GetString("cpf")
                        };
                        return nomeCpf;
                    }


                    // VERIFICAÇÃO 3
                    conn.Close();
                    conn.Open();
                    string query3 = "SELECT id, nome, cpf FROM recepcionista WHERE usuario = @usuario";
                    MySqlCommand cmd3 = new MySqlCommand(query3, conn);
                    cmd3.Parameters.AddWithValue("usuario", usuario);
                    MySqlDataReader reader3 = cmd3.ExecuteReader();

                    while (reader3.Read())
                    {
                        nomeCpf = new Colaborador
                        {
                            Id = reader3.GetInt32("id"),
                            Nome = reader3.GetString("nome"),
                            Cpf = reader3.GetString("cpf")
                        };

                        return nomeCpf;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }


            return nomeCpf;
            

        }

        public List<EnfermeiroDgv> ReadEnfermeiro()
        {
            List<EnfermeiroDgv> listaEnfermeiros = new List<EnfermeiroDgv>();
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, nome, dt_admissao, coren, telefone FROM enfermeiro";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    EnfermeiroDgv enfermeiroDgv = new EnfermeiroDgv
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Dt_Admissao = reader.GetDateTime("dt_admissao").ToString().Substring(0,10),
                        Coren = reader.GetInt32("coren"),
                        Telefone = reader.GetString("telefone")
                    };
                    listaEnfermeiros.Add(enfermeiroDgv);
                }
            }
            return listaEnfermeiros;
        }

        public List<MedicoDgv> ReadMedico()
        {
            List<MedicoDgv> listaMedico = new List<MedicoDgv>();
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, nome, dt_admissao, crm, telefone FROM medico";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MedicoDgv medicoDgv = new MedicoDgv
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Dt_Admissao = reader.GetDateTime("dt_admissao").ToString().Substring(0, 10),
                        Crm = reader.GetInt32("crm"),
                        Telefone = reader.GetString("telefone")
                    };
                    listaMedico.Add(medicoDgv);
                }
            }
            return listaMedico;
        }

        public List<RecepcionistaDgv> ReadRecepcionista()
        {
            List<RecepcionistaDgv> listaRecepcionista = new List<RecepcionistaDgv>();
            using (MySqlConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT id, nome, dt_admissao, telefone FROM recepcionista";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    RecepcionistaDgv recepcionistaDgv = new RecepcionistaDgv
                    {
                        Id = reader.GetInt32("id"),
                        Nome = reader.GetString("nome"),
                        Dt_Admissao = reader.GetDateTime("dt_admissao").ToString().Substring(0, 10),
                        Telefone = reader.GetString("telefone")
                    };
                    listaRecepcionista.Add(recepcionistaDgv);
                }
            }
            return listaRecepcionista;
        }

        // CHECK FUNÇÃO
        public bool CheckRecepcionista(string usuario)
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(usuario) FROM recepcionista WHERE usuario = @usuario";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", usuario);


                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return false;
            }

            
            
        }

        public bool CheckEnfermeiro(string usuario)
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(usuario) FROM enfermeiro WHERE usuario = @usuario";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return false;
            }

            
            
        }

        public bool CheckMedico(string usuario)
        {
            try
            {
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(usuario) FROM medico WHERE usuario = @usuario";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@usuario", usuario);

                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                return false;
            }


            
            
        }

    }
}
    



