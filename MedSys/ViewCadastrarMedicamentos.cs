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
    public partial class ViewCadastrarMedicamentos : Form
    {
        public ViewCadastrarMedicamentos()
        {
            InitializeComponent();

            //Add ComboBox Values Estoque
            cmbTipo.Items.Add("Analgésicos");
            cmbTipo.Items.Add("Anti-inflamatórios");
            cmbTipo.Items.Add("Antieméticos");
            cmbTipo.Items.Add("Antibióticos");
            cmbTipo.Items.Add("Antifúngicos");
            cmbTipo.Items.Add("Antivirais");
            cmbTipo.Items.Add("Antibióticos e Antifúngicos de amplo espectro");
            cmbTipo.Items.Add("Ansiolíticos");
            cmbTipo.Items.Add("Antipsicóticos");
            cmbTipo.Items.Add("Anti-histamínicos");
            cmbTipo.Items.Add("Anticoagulantes");
            cmbTipo.Items.Add("Antidiabéticos");
            cmbTipo.Items.Add("Anti-hipertensivos");
            cmbTipo.Items.Add("Broncodilatadores");
            cmbTipo.Items.Add("Laxantes");
            cmbTipo.Items.Add("Diuréticos");
            cmbTipo.Items.Add("Anticoncepcionais");
            cmbTipo.Items.Add("Vacinas");
            cmbTipo.Items.Add("Suplementos nutricionais");
            cmbTipo.Items.Add("Hormônios");
            cmbTipo.Items.Add("Corticosteroides");
            cmbTipo.Items.Add("Relaxantes musculares");
            cmbTipo.Items.Add("Antitussígenos");
            cmbTipo.Items.Add("Antiácidos");
            cmbTipo.Items.Add("Anti-infecciosos tópicos");
            cmbTipo.Items.Add("Anestésicos");
            cmbTipo.Items.Add("Antidiarreicos");
            cmbTipo.Items.Add("Estimulantes do Sistema Nervoso Central");
        }

        private void btnCadastrarMedicamento_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque
            {
                Tipo = cmbTipo.Text,
                Medicamento = txtMedicamento.Text,
                Quantidade = int.Parse(txtQuantidade.Text),

            };

            EstoqueDAO edao = new EstoqueDAO();
            edao.InserirEstoque(estoque);

            cmbTipo.Text = "";
            txtMedicamento.Text = "";
            txtQuantidade.Text = "";



            MessageBox.Show("Cadastrado com sucesso!");
        }

        private void ViewCadastrarMedicamentos_Load(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

