using MedSys.DataAccess;
using MedSys.Model;

namespace MedSys
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            tlpBotoesColaboradores.Dock = DockStyle.Fill;
            tlpBotoesPacientes.Dock = DockStyle.Fill;
            tlpBotoesProntuario.Dock = DockStyle.Fill;
            tlpBtnListaColaboradores.Dock = DockStyle.Fill;
            tlpMedicamento.Dock = DockStyle.Fill;
            tlpInternacao.Dock = DockStyle.Fill;
            tlpBotoesEstoque.Dock = DockStyle.Fill;


            EstoqueDAO edao = new EstoqueDAO();
            dgvEstoque.DataSource = edao.ReadEstoque();
            ColaboradorDAO cdao = new ColaboradorDAO();
            dgvListaColaboradores.DataSource = cdao.ReadEnfermeiro();


            // Add ComboBox Values
            cbColaboradores.Items.Add("Enfermeiros");
            cbColaboradores.Items.Add("M�dicos");
            cbColaboradores.Items.Add("Recepcionistas");

            //Add ComboBox Values Estoque
            cbMedicamentos.Items.Add("Analg�sicos");
            cbMedicamentos.Items.Add("Anti-inflamat�rios");
            cbMedicamentos.Items.Add("Antiem�ticos");
            cbMedicamentos.Items.Add("Antibi�ticos");
            cbMedicamentos.Items.Add("Antif�ngicos");
            cbMedicamentos.Items.Add("Antivirais");
            cbMedicamentos.Items.Add("Antibi�ticos e Antif�ngicos de amplo espectro");
            cbMedicamentos.Items.Add("Ansiol�ticos");
            cbMedicamentos.Items.Add("Antipsic�ticos");
            cbMedicamentos.Items.Add("Anti-histam�nicos");
            cbMedicamentos.Items.Add("Anticoagulantes");
            cbMedicamentos.Items.Add("Antidiab�ticos");
            cbMedicamentos.Items.Add("Anti-hipertensivos");
            cbMedicamentos.Items.Add("Broncodilatadores");
            cbMedicamentos.Items.Add("Laxantes");
            cbMedicamentos.Items.Add("Diur�ticos");
            cbMedicamentos.Items.Add("Anticoncepcionais");
            cbMedicamentos.Items.Add("Vacinas");
            cbMedicamentos.Items.Add("Suplementos nutricionais");
            cbMedicamentos.Items.Add("Horm�nios");
            cbMedicamentos.Items.Add("Corticosteroides");
            cbMedicamentos.Items.Add("Relaxantes musculares");
            cbMedicamentos.Items.Add("Antituss�genos");
            cbMedicamentos.Items.Add("Anti�cidos");
            cbMedicamentos.Items.Add("Anti-infecciosos t�picos");
            cbMedicamentos.Items.Add("Anest�sicos");
            cbMedicamentos.Items.Add("Antidiarreicos");
            cbMedicamentos.Items.Add("Estimulantes do Sistema Nervoso Central");




        }




        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void picInicioMedSys_MouseEnter(object sender, EventArgs e)
        {
            picInicioMedSys.Image = Properties.Resources.medsys_neon_logo;
        }

        private void picInicioMedSys_MouseLeave(object sender, EventArgs e)
        {
            picInicioMedSys.Image = Properties.Resources.medsys_logo;
        }

        private void tlpMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlpMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBtnMedicamento_Click(object sender, EventArgs e)
        {
            tlpBotoesColaboradores.Visible = false;
            tlpBotoesPacientes.Visible = false;
            tlpBotoesProntuario.Visible = false;
            tlpBotoesEstoque.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picBtnColaborador_Click(object sender, EventArgs e)
        {
            tlpBotoesColaboradores.Visible = true;
            tlpBotoesPacientes.Visible = false;
            tlpBotoesProntuario.Visible = false;
            tlpBotoesEstoque.Visible = false;

        }

        private void picCadastrarPaciente_Click(object sender, EventArgs e)
        {
            new ViewCadastrarPaciente().Show();
        }

        private void picListaPaciente_Click(object sender, EventArgs e)
        {

        }

        private void panOptionsButtons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void picCadastrarMedico_Click(object sender, EventArgs e)
        {
            new ViewCadastroMedico().Show();
        }

        private void picBtnPaciente_Click(object sender, EventArgs e)
        {
            tlpBotoesColaboradores.Visible = false;
            tlpBotoesPacientes.Visible = true;
            tlpBotoesProntuario.Visible = false;
            tlpBotoesEstoque.Visible = false;
        }

        private void picCadastrarEnfermeiros_Click(object sender, EventArgs e)
        {
            new ViewCadastrarEnfermeiro().Show();
        }

        private void picCadastrarRecepcionista_Click(object sender, EventArgs e)
        {
            new ViewCadastroRecepcionista().Show();
        }

        private void picBtnConsulta_MouseEnter(object sender, EventArgs e)
        {
            picBtnConsulta.Image = Properties.Resources.btnConsultaSelect;
        }

        private void picBtnConsulta_MouseLeave(object sender, EventArgs e)
        {
            picBtnConsulta.Image = Properties.Resources.btnConsulta;
        }

        private void picBtnProntuario_Click(object sender, EventArgs e)
        {
            tlpBotoesColaboradores.Visible = false;
            tlpBotoesPacientes.Visible = false;
            tlpBotoesProntuario.Visible = true;
            tlpBotoesEstoque.Visible = false;
        }

        private void picInicioMedSys_Click(object sender, EventArgs e)
        {
            tlpBotoesColaboradores.Visible = false;
            tlpBotoesPacientes.Visible = false;
            tlpBotoesProntuario.Visible = false;
            tlpBotoesEstoque.Visible = false;
            tlpBtnListaColaboradores.Visible = false;
            tlpMedicamento.Visible = false;
            tlpInternacao.Visible = false;
        }

        private void picBtnExame_Click(object sender, EventArgs e)
        {

        }

        private void picBtnExame_MouseEnter(object sender, EventArgs e)
        {
            picBtnExame.Image = Properties.Resources.btnExameSelect;
        }

        private void picBtnExame_MouseLeave(object sender, EventArgs e)
        {
            picBtnExame.Image = Properties.Resources.btnExame;
        }

        private void picBtnInternacoes_MouseEnter(object sender, EventArgs e)
        {
            picBtnInternacoes.Image = Properties.Resources.btnInternacaoSelect;
        }

        private void picBtnInternacoes_MouseLeave(object sender, EventArgs e)
        {
            picBtnInternacoes.Image = Properties.Resources.btnInternacao;
        }

        private void picCadastrarColaboradores_Click(object sender, EventArgs e)
        {
            tlpBotoesColaboradores.Visible = false;
            tlpBotoesPacientes.Visible = false;
            tlpBotoesProntuario.Visible = false;
            tlpBtnListaColaboradores.Visible = true;

        }

        private void dgvListaColaboradores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbColaboradores_SelectedIndexChanged(object sender, EventArgs e)
        {
            ColaboradorDAO cdao = new ColaboradorDAO();
            string valorSelecionado = cbColaboradores.SelectedItem.ToString();

            if (valorSelecionado == "Enfermeiros")
            {
                dgvListaColaboradores.DataSource = cdao.ReadEnfermeiro();
            }
            else if (valorSelecionado == "M�dicos")
            {
                dgvListaColaboradores.DataSource = cdao.ReadMedico();
            }
            else if (valorSelecionado == "Recepcionistas")
            {
                dgvListaColaboradores.DataSource = cdao.ReadRecepcionista();
            }
        }

        private void panMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picBtnInternacoes_Click(object sender, EventArgs e)
        {
            tlpInternacao.Visible = true;
        }

        private void picBtnEstoque_Click(object sender, EventArgs e)
        {
            tlpBtnListaColaboradores.Visible = false;
            tlpInternacao.Visible = false;
            tlpMedicamento.Visible = true;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ProntuarioDAO pdao = new ProntuarioDAO();
            dgvInternacao.DataSource = pdao.ReadInternacao(txtBusca.Text);
        }

        private void picBtnCadastrarMedicamento_Click(object sender, EventArgs e)
        {
            new ViewCadastrarMedicamentos().Show();
        }

        private void cbMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            EstoqueDAO edao = new EstoqueDAO();
            string valorSelecionado = cbMedicamentos.SelectedItem.ToString();

            if (valorSelecionado == "Analg�sicos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Analg�sicos");
            }
            else if (valorSelecionado == "Anti-inflamat�rios")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Anti-inflamat�rios");
            }
            else if (valorSelecionado == "Antiem�ticos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Antiem�ticos");
            }
            else if (valorSelecionado == "Antibi�ticos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Antibi�ticos");
            }
            else if (valorSelecionado == "Antif�ngicos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Antif�ngicos");
            }
            else if (valorSelecionado == "Antivirais")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Antivirais");
            }
            else if (valorSelecionado == "Antibi�ticos e Antif�ngicos de amplo")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Antibi�ticos e Antif�ngicos de amplo");
            }
            else if (valorSelecionado == "Ansiol�ticos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Ansiol�ticos");
            }
            else if (valorSelecionado == "Antipsic�ticos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Antipsic�ticos");
            }
            else if (valorSelecionado == "Anti-histam�nicos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Anti-histam�nicos");
            }
            else if (valorSelecionado == "Anticoagulantes")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Anticoagulantes");
            }
            else if (valorSelecionado == "Antidiab�ticos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Antidiab�ticos");
            }
            else if (valorSelecionado == "Anti-hipertensivos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Anti-hipertensivos");
            }
            else if (valorSelecionado == "Broncodilatadores")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Broncodilatadores");
            }
            else if (valorSelecionado == "Laxantes")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Laxantes");
            }
            else if (valorSelecionado == "Diur�ticos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Diur�ticos");
            }
            else if (valorSelecionado == "Anticoncepcionais")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Anticoncepcionais");
            }
            else if (valorSelecionado == "Vacinas")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Vacinas");
            }
            else if (valorSelecionado == "Suplementos nutricionais")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Suplementos nutricionais");
            }
            else if (valorSelecionado == "Horm�nios")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Horm�nios");
            }
            else if (valorSelecionado == "Corticosteroides")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Corticosteroides");
            }
            else if (valorSelecionado == "Relaxantes musculares")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Relaxantes musculares");
            }
            else if (valorSelecionado == "Antituss�genos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Antituss�genos");
            }
            else if (valorSelecionado == "Anti�cidos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Anti�cidos");
            }
            else if (valorSelecionado == "Anti-infecciosos t�picos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Anti-infecciosos t�picos");
            }
            else if (valorSelecionado == "Anest�sicos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Anest�sicos");
            }
            else if (valorSelecionado == "Antidiarreicos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Antidiarreicos");
            }
            else if (valorSelecionado == "Estimulantes do Sistema Nervoso Central")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Estimulantes do Sistema Nervoso Central");
            }

        }
    }
}
