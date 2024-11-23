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
                    return result == 1;
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
    }
        }
    



