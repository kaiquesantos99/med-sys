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
    public partial class ViewCadastrarEnfermeiro : Form
    {
        Form1 f;
        public ViewCadastrarEnfermeiro(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Enfermeiro enfermeiro = new Enfermeiro
            {
                Nome = txtNome.Text,
                Dt_Admissao = txtAdmissao.Text,
                Matricula = int.Parse(txtMatricula.Text),
                Coren = int.Parse(txtCoren.Text),
                Nascimento = txtNascimento.Text,
                Cpf = txtCPF.Text,
                Rg = txtRG.Text,
                Pis = int.Parse(txtPis.Text),
                Cep = txtCep.Text,
                Logradouro = txtLogradouro.Text,
                Numero = int.Parse(txtNum.Text),
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Uf = txtUF.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text,
                Usuario = txtUsuario.Text,
                Senha = txtSenha.Text,
            };

            ColaboradorDAO cdao = new ColaboradorDAO();
            cdao.InserirEnfermeiro(enfermeiro);

            txtNome.Text = "";
            txtAdmissao.Text = "";
            txtMatricula.Text = "";
            txtCoren.Text = "";
            txtNascimento.Text = "";
            txtCPF.Text = "";
            txtRG.Text = "";
            txtPis.Text = "";
            txtCep.Text = "";
            txtLogradouro.Text = "";
            txtNum.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUF.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";

            f.ReadTables();
            MessageBox.Show("Cadastrado com sucesso!");
        }
    }
}
