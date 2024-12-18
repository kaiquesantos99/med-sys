﻿using MedSys.DataAccess;
using MedSys.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedSys
{
    public partial class ViewCadastrarPaciente : Form
    {
        Form1 f;
        public ViewCadastrarPaciente(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewCadastrarPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente
            {
                Nome = txtNomeP.Text,
                Nascimento = txtNascimentoP.Text,
                Cpf = txtCPFP.Text,
                Rg = txtRGP.Text,
                Cep = txtCEPP.Text,
                Logradouro = txtLogradouroP.Text,
                Numero = int.Parse(txtNumP.Text),
                Complemento = txtComplementoP.Text,
                Bairro = txtBairroP.Text,
                Cidade = txtCidadeP.Text,
                Uf = txtUFP.Text,
                Telefone = txtTelefoneP.Text,
                Telefone_2 = txtTelefone_2.Text,
                Carteirinha = txtCarteirinhaP.Text,
                Convenio = txtConvenioP.Text,
                Peso = float.Parse (txtPesoP.Text),
                Altura = float.Parse(txtAlturaP.Text),
                Observacoes = txtObservacoesP.Text,
                Sexo = txtSexoP.Text,

            };

            ColaboradorDAO cdao = new ColaboradorDAO();
            cdao.InserirPaciente(paciente);

            txtNomeP.Text = "";
            txtNascimentoP.Text = "";
            txtCPFP.Text = "";
            txtRGP.Text = "";
            txtCEPP.Text = "";
            txtLogradouroP.Text = "";
            txtNumP.Text = "";
            txtComplementoP.Text = "";
            txtBairroP.Text = "";
            txtCidadeP.Text = "";
            txtUFP.Text = "";
            txtTelefoneP.Text = "";
            txtTelefone_2.Text = "";
            txtAcompanhanteP.Text = "";
            txtCarteirinhaP.Text = "";
            txtConvenioP.Text = "";
            txtPesoP.Text = "";
            txtAlturaP.Text = "";
            txtObservacoesP.Text = "";
            txtSexoP.Text = "";

            f.ReadTables();

            MessageBox.Show("Cadastrado com sucesso!");
        }
    }
}
