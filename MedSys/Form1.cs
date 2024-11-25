using MedSys.DataAccess;
using MedSys.Model;

namespace MedSys
{
    public partial class Form1 : Form
    {
        private string cpfFuturoInternado;

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
            cbColaboradores.Items.Add("Médicos");
            cbColaboradores.Items.Add("Recepcionistas");

            
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
            else if (valorSelecionado == "Médicos")
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

        private void dgvInternacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                
                DataGridViewRow linhaSelecionada = dgvInternacao.Rows[e.RowIndex];
                string valorCelulaSelecionada = linhaSelecionada.Cells[0].Value.ToString();
                cpfFuturoInternado = valorCelulaSelecionada;

                ProntuarioDAO pdao = new ProntuarioDAO();
                dgvInternacaoDetalhes.DataSource = pdao.ReadDetalhesInternacao(int.Parse(valorCelulaSelecionada));
            }
        }

        private void dgvInternacao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInternar_Click(object sender, EventArgs e)
        {
            if (dgvInternacao.CurrentRow != null)
            {
                

                var cellValue = dgvInternacao.CurrentRow.Cells["cpf"].Value?.ToString();
                ProntuarioDAO pdao = new ProntuarioDAO();
                pdao.InternarPaciente(cellValue.ToString());
                dgvInternacao.DataSource = pdao.ReadInternacao(cellValue.ToString());
                MessageBox.Show("Paciente interado com sucesso!");
            }
            else
            {
                MessageBox.Show("Selecione um paciente para internar!");
            }

            


        }
    }
}
