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
    public partial class ViewCadastroMedico : Form
    {
        Form1 f;
        public ViewCadastroMedico(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void ViewCadastroMedico_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarM_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico
            {
                Nome = txtNomeM.Text,
                Dt_Admissao = txtAdmissaoM.Text,
                Matricula = int.Parse(txtMatriculaM.Text),
                Crm = int.Parse(txtCRM.Text),
                Nascimento = txtNascimentoM.Text,
                Cpf = txtCPFM.Text,
                Rg = txtRGM.Text,
                Pis = int.Parse(txtPisM.Text),
                Especialidade = txtEspecialidade.Text,
                Cep = txtCepM.Text,
                Logradouro = txtLogradouroM.Text,
                Numero = int.Parse(txtNumM.Text),
                Complemento = txtComplementoM.Text,
                Bairro = txtBairroM.Text,
                Cidade = txtCidadeM.Text,
                Uf = txtUFM.Text,
                Telefone = txtTelefoneM.Text,
                Email = txtEmailM.Text,
                Usuario = txtUsuarioM.Text,
                Senha = txtSenhaM.Text,
            };

            ColaboradorDAO cdao = new ColaboradorDAO();
            cdao.InserirMedico(medico);

            txtNomeM.Text = "";
            txtAdmissaoM.Text = "";
            txtMatriculaM.Text = "";
            txtCRM.Text = "";
            txtNascimentoM.Text = "";
            txtCPFM.Text = "";
            txtRGM.Text = "";
            txtPisM.Text = "";
            txtEspecialidade.Text = "";
            txtCepM.Text = "";
            txtLogradouroM.Text = "";
            txtNumM.Text = "";
            txtComplementoM.Text = "";
            txtBairroM.Text = "";
            txtCidadeM.Text = "";
            txtUFM.Text = "";
            txtTelefoneM.Text = "";
            txtEmailM.Text = "";
            txtUsuarioM.Text = "";
            txtSenhaM.Text = "";

            f.ReadTables();

            MessageBox.Show("Cadastrado com sucesso!");
        }
    }
}
