using MedSys.DataAccess;
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
    public partial class ViewCadastroRecepcionista : Form
    {
        Form1 f;
        public ViewCadastroRecepcionista(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void btnCadastrarR_Click(object sender, EventArgs e)
        {
            Recepcionista recepcionista = new Recepcionista
            {
                Nome = txtNomeR.Text,
                Dt_Admissao = txtAdmissaoR.Text,
                Matricula = int.Parse(txtMatriculaR.Text),
                Nascimento = txtNascimentoR.Text,
                Cpf = txtCPFR.Text,
                Rg = txtRGR.Text,
                Pis = int.Parse(txtPISR.Text),
                Cep = txtCEPR.Text,
                Logradouro = txtLogradouroR.Text,
                Numero = int.Parse(txtNumR.Text),
                Complemento = txtComplementoR.Text,
                Bairro = txtBairroR.Text,
                Cidade = txtCidadeR.Text,
                Uf = txtUFR.Text,
                Telefone = txtTelefoneR.Text,
                Email = txtEmailR.Text,
                Usuario = txtUsuarioR.Text,
                Senha = txtSenhaR.Text,
            };

            ColaboradorDAO cdao = new ColaboradorDAO();
            cdao.InserirRecepcionista(recepcionista);

            txtNomeR.Text = "";
            txtAdmissaoR.Text = "";
            txtMatriculaR.Text = "";
            txtNascimentoR.Text = "";
            txtCPFR.Text = "";
            txtRGR.Text = "";
            txtPISR.Text = "";
            txtCEPR.Text = "";
            txtLogradouroR.Text = "";
            txtNumR.Text = "";
            txtComplementoR.Text = "";
            txtBairroR.Text = "";
            txtCidadeR.Text = "";
            txtUFR.Text = "";
            txtTelefoneR.Text = "";
            txtEmailR.Text = "";
            txtUsuarioR.Text = "";
            txtSenhaR.Text = "";

            f.ReadTables();

            MessageBox.Show("Cadastrado com sucesso!");
        }

        private void ViewCadastroRecepcionista_Load(object sender, EventArgs e)
        {

        }
    }
}
