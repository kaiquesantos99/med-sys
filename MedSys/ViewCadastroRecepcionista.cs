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
        public ViewCadastroRecepcionista()
        {
            InitializeComponent();
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

            MessageBox.Show("Cadastrado com sucesso!");
        }
    }
}
