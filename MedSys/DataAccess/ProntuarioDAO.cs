﻿using MedSys.Model;
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
        public List<Internacao> ReadInternacao(string p)
        {
            List<Internacao> listaInternacao = new List<Internacao>();

            using (MySqlConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT i.id id, p.nome paciente, p.nascimento nascimento, p.sexo sexo, i.leito leito, i.setor setor, i.internado_tempo tempo_internado, m.nome medico, m.especialidade especialidade, p.status_paciente status_paciente FROM medico m JOIN internacao i on m.id = i.id_medico JOIN paciente p on p.id = i.id_paciente WHERE p.nome LIKE @nome";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nome", p + "%");
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Internacao internacao = new Internacao()
                        {

                            Atendimento = reader.GetInt32("id"),
                            Paciente = reader.GetString("paciente"),
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

        // Atualização
    }
}
