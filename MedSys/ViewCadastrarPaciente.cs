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
    public partial class ViewCadastrarPaciente : Form
    {
        public ViewCadastrarPaciente()
        {
            InitializeComponent();
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

            MessageBox.Show("Cadastrado com sucesso!");
        }
    }
}
