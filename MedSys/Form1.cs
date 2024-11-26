using MedSys.DataAccess;
using MedSys.Model;
using System.Windows.Forms;

namespace MedSys
{
    public partial class Form1 : Form
    {
        private bool CheckedEnfermeiro { get; set; } = false;
        private bool CheckedMedico { get; set; } = false;
        private bool CheckedRecepcionista { get; set; } = false;

        private int UserId { get; set; }
        private string UserName { get; set; }
        private string UserCpf { get; set; }

        private ViewLogin TelaLogin { get; set; }

        public Form1(string usuario, ViewLogin login)
        {
            InitializeComponent();
            CheckTipoColaborador(usuario); // Verifica o tipo de colaborador para limitar acesso ao sistema

            TelaLogin = login;

            tlpBotoesColaboradores.Dock = DockStyle.Fill;
            tlpBotoesPacientes.Dock = DockStyle.Fill;
            tlpBotoesProntuario.Dock = DockStyle.Fill;
            tlpBtnListaColaboradores.Dock = DockStyle.Fill;
            tlpMedicamento.Dock = DockStyle.Fill;
            tlpInternacao.Dock = DockStyle.Fill;
            tlpBotoesEstoque.Dock = DockStyle.Fill;
            tlpListaPacientes.Dock = DockStyle.Fill;


            ReadTables();


            // Add ComboBox Values Pacientes Status
            cbFiltroStatusPaciente.Items.Add("Aguardando");
            cbFiltroStatusPaciente.Items.Add("Internado");
            cbFiltroStatusPaciente.Items.Add("Alta");

            // Add ComboBox Values Pacientes Dados
            cbFiltroDadosPaciente.Items.Add("Exibir dados");
            cbFiltroDadosPaciente.Items.Add("Exibir dados filtrados");

            // Add ComboBox Values Colaboradores
            cbColaboradores.Items.Add("Enfermeiros");
            cbColaboradores.Items.Add("Médicos");
            cbColaboradores.Items.Add("Recepcionistas");

            //Add ComboBox Values Estoque
            cbMedicamentos.Items.Add("Analgésicos");
            cbMedicamentos.Items.Add("Anti-inflamatórios");
            cbMedicamentos.Items.Add("Antieméticos");
            cbMedicamentos.Items.Add("Antibióticos");
            cbMedicamentos.Items.Add("Antifúngicos");
            cbMedicamentos.Items.Add("Antivirais");
            cbMedicamentos.Items.Add("Antibióticos e Antifúngicos de amplo espectro");
            cbMedicamentos.Items.Add("Ansiolíticos");
            cbMedicamentos.Items.Add("Antipsicóticos");
            cbMedicamentos.Items.Add("Anti-histamínicos");
            cbMedicamentos.Items.Add("Anticoagulantes");
            cbMedicamentos.Items.Add("Antidiabéticos");
            cbMedicamentos.Items.Add("Anti-hipertensivos");
            cbMedicamentos.Items.Add("Broncodilatadores");
            cbMedicamentos.Items.Add("Laxantes");
            cbMedicamentos.Items.Add("Diuréticos");
            cbMedicamentos.Items.Add("Anticoncepcionais");
            cbMedicamentos.Items.Add("Vacinas");
            cbMedicamentos.Items.Add("Suplementos nutricionais");
            cbMedicamentos.Items.Add("Hormônios");
            cbMedicamentos.Items.Add("Corticosteroides");
            cbMedicamentos.Items.Add("Relaxantes musculares");
            cbMedicamentos.Items.Add("Antitussígenos");
            cbMedicamentos.Items.Add("Antiácidos");
            cbMedicamentos.Items.Add("Anti-infecciosos tópicos");
            cbMedicamentos.Items.Add("Anestésicos");
            cbMedicamentos.Items.Add("Antidiarreicos");
            cbMedicamentos.Items.Add("Estimulantes do Sistema Nervoso Central");




        }

        public void ReadTables()
        {
            EstoqueDAO edao = new EstoqueDAO();
            dgvEstoque.DataSource = edao.ReadEstoque();
            ColaboradorDAO cdao = new ColaboradorDAO();
            dgvListaColaboradores.DataSource = cdao.ReadEnfermeiro();
            PacienteDAO pfdao = new PacienteDAO();
            dgvListaPacientes.DataSource = pfdao.ReadPacientesFiltro();
            ProntuarioDAO pdao = new ProntuarioDAO();
            dgvInternacao.DataSource = pdao.ReadInternacao(txtBusca.Text);
        }

        private void CheckTipoColaborador(string usuario)
        {
            Colaborador colaborador = new Colaborador();
            ColaboradorDAO cdao = new ColaboradorDAO();
            if (cdao.CheckEnfermeiro(usuario))
            {
                CheckedEnfermeiro = true;
            }
            else if (cdao.CheckMedico(usuario))
            {
                CheckedMedico = true;
            }
            else if (cdao.CheckRecepcionista(usuario))
            {
                CheckedRecepcionista = true;
            }

            colaborador = cdao.ReadUserData(usuario);
            UserName = colaborador.Nome;
            UserCpf = colaborador.Cpf;
            UserId = colaborador.Id;
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
            if (CheckedEnfermeiro)
            {
                if (!tlpBotoesEstoque.Visible)
                {
                    tlpBotoesColaboradores.Visible = false;
                    tlpBotoesPacientes.Visible = false;
                    tlpBotoesProntuario.Visible = false;
                    tlpBotoesEstoque.Visible = true;
                }
                else
                {
                    tlpBotoesColaboradores.Visible = false;
                    tlpBotoesPacientes.Visible = false;
                    tlpBotoesProntuario.Visible = false;
                    tlpBotoesEstoque.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("Você não tem permissão para acessar as abas de estoque!");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picBtnColaborador_Click(object sender, EventArgs e)
        {
            if (CheckedRecepcionista)
            {
                if (!tlpBotoesColaboradores.Visible)
                {
                    tlpBotoesColaboradores.Visible = true;
                    tlpBotoesPacientes.Visible = false;
                    tlpBotoesProntuario.Visible = false;
                    tlpBotoesEstoque.Visible = false;
                }
                else
                {
                    tlpBotoesColaboradores.Visible = false;
                    tlpBotoesPacientes.Visible = false;
                    tlpBotoesProntuario.Visible = false;
                    tlpBotoesEstoque.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Você não tem permissão para acessar as abas de colaborador!");
            }



        }

        private void picCadastrarPaciente_Click(object sender, EventArgs e)
        {
            new ViewCadastrarPaciente(this).Show();
        }

        private void picListaPaciente_Click(object sender, EventArgs e)
        {

            if (!tlpListaPacientes.Visible)
            {
                ReadTables();
                tlpBtnListaColaboradores.Visible = false;
                tlpListaPacientes.Visible = true;
                tlpInternacao.Visible = false;
                tlpMedicamento.Visible = false;
            }
            else
            {
                tlpBtnListaColaboradores.Visible = false;
                tlpListaPacientes.Visible = false;
                tlpInternacao.Visible = false;
                tlpMedicamento.Visible = false;
            }
        }

        private void panOptionsButtons_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void picCadastrarMedico_Click(object sender, EventArgs e)
        {
            new ViewCadastroMedico(this).Show();
        }

        private void picBtnPaciente_Click(object sender, EventArgs e)
        {

            if (CheckedRecepcionista || CheckedMedico)
            {
                if (!tlpBotoesPacientes.Visible)
                {
                    tlpBotoesColaboradores.Visible = false;
                    tlpBotoesPacientes.Visible = true;
                    tlpBotoesProntuario.Visible = false;
                    tlpBotoesEstoque.Visible = false;
                }
                else
                {
                    tlpBotoesColaboradores.Visible = false;
                    tlpBotoesPacientes.Visible = false;
                    tlpBotoesProntuario.Visible = false;
                    tlpBotoesEstoque.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Você não tem permissão para acessar as abas de paciente!");
            }

        }

        private void picCadastrarEnfermeiros_Click(object sender, EventArgs e)
        {
            new ViewCadastrarEnfermeiro(this).Show();
        }

        private void picCadastrarRecepcionista_Click(object sender, EventArgs e)
        {
            new ViewCadastroRecepcionista(this).Show();
        }

        private void picBtnConsulta_MouseEnter(object sender, EventArgs e)
        {

        }

        private void picBtnConsulta_MouseLeave(object sender, EventArgs e)
        {

        }

        private void picBtnProntuario_Click(object sender, EventArgs e)
        {
            if (CheckedMedico || CheckedEnfermeiro)
            {
                if (!tlpBotoesProntuario.Visible)
                {
                    tlpBotoesColaboradores.Visible = false;
                    tlpBotoesPacientes.Visible = false;
                    tlpBotoesProntuario.Visible = true;
                    tlpBotoesEstoque.Visible = false;
                }
                else
                {
                    tlpBotoesColaboradores.Visible = false;
                    tlpBotoesPacientes.Visible = false;
                    tlpBotoesProntuario.Visible = false;
                    tlpBotoesEstoque.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Você não tem permissão para acessar as abas de prontuário!");
            }

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
            tlpListaPacientes.Visible = false;
        }

        private void picBtnExame_Click(object sender, EventArgs e)
        {
            new ViewProntuarioExame().Show();
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

            if (!tlpBtnListaColaboradores.Visible)
            {
                ReadTables();
                tlpBtnListaColaboradores.Visible = true;
                tlpListaPacientes.Visible = false;
                tlpInternacao.Visible = false;
                tlpMedicamento.Visible = false;
            }
            else
            {
                tlpBtnListaColaboradores.Visible = false;
                tlpListaPacientes.Visible = false;
                tlpInternacao.Visible = false;
                tlpMedicamento.Visible = false;
            }



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

            if (!tlpInternacao.Visible)
            {
                ReadTables();
                tlpBtnListaColaboradores.Visible = false;
                tlpListaPacientes.Visible = false;
                tlpInternacao.Visible = true; tlpRegistroDetalhes.Visible = false;
                tlpMedicamento.Visible = false;
            }
            else
            {
                tlpBtnListaColaboradores.Visible = false;
                tlpListaPacientes.Visible = false;
                tlpInternacao.Visible = false;
                tlpMedicamento.Visible = false;
            }
        }

        private void picBtnEstoque_Click(object sender, EventArgs e)
        {


            if (!tlpMedicamento.Visible)
            {
                ReadTables();
                tlpBtnListaColaboradores.Visible = false;
                tlpListaPacientes.Visible = false;
                tlpInternacao.Visible = false;
                tlpMedicamento.Visible = true;
            }
            else
            {
                tlpBtnListaColaboradores.Visible = false;
                tlpListaPacientes.Visible = false;
                tlpInternacao.Visible = false;
                tlpMedicamento.Visible = false;
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ProntuarioDAO pdao = new ProntuarioDAO();
            dgvInternacao.DataSource = pdao.ReadInternacaoForName(txtBusca.Text);
        }

        private void picBtnCadastrarMedicamento_Click(object sender, EventArgs e)
        {
            new ViewCadastrarMedicamentos(this).Show();
        }

        private void cbMedicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            EstoqueDAO edao = new EstoqueDAO();
            string valorSelecionado = cbMedicamentos.SelectedItem.ToString();

            if (valorSelecionado == "Analgésicos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Analgésicos");
            }
            else if (valorSelecionado == "Anti-inflamatórios")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Anti-inflamatórios");
            }
            else if (valorSelecionado == "Antieméticos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Antieméticos");
            }
            else if (valorSelecionado == "Antibióticos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Antibióticos");
            }
            else if (valorSelecionado == "Antifúngicos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Antifúngicos");
            }
            else if (valorSelecionado == "Antivirais")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Antivirais");
            }
            else if (valorSelecionado == "Antibióticos e Antifúngicos de amplo")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Antibióticos e Antifúngicos de amplo");
            }
            else if (valorSelecionado == "Ansiolíticos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Ansiolíticos");
            }
            else if (valorSelecionado == "Antipsicóticos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Antipsicóticos");
            }
            else if (valorSelecionado == "Anti-histamínicos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Anti-histamínicos");
            }
            else if (valorSelecionado == "Anticoagulantes")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Anticoagulantes");
            }
            else if (valorSelecionado == "Antidiabéticos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Antidiabéticos");
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
            else if (valorSelecionado == "Diuréticos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Diuréticos");
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
            else if (valorSelecionado == "Hormônios")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Hormônios");
            }
            else if (valorSelecionado == "Corticosteroides")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Corticosteroides");
            }
            else if (valorSelecionado == "Relaxantes musculares")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Relaxantes musculares");
            }
            else if (valorSelecionado == "Antitussígenos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Antitussígenos");
            }
            else if (valorSelecionado == "Antiácidos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Antiácidos");
            }
            else if (valorSelecionado == "Anti-infecciosos tópicos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Anti-infecciosos tópicos");
            }
            else if (valorSelecionado == "Anestésicos")
            {
                dgvEstoque.DataSource = edao.ReadEstoqueFor("Anestésicos");
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

        private void dgvInternacao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                DataGridViewRow linhaSelecionada = dgvInternacao.Rows[e.RowIndex];
                string valorCelulaSelecionada = linhaSelecionada.Cells[0].Value.ToString();
                ProntuarioDAO pdao = new ProntuarioDAO();
                dgvInternacaoDetalhes.DataSource = pdao.ReadDetalhesInternacao(int.Parse(valorCelulaSelecionada));
            }
        }

        private void btnInternar_Click(object sender, EventArgs e)
        {

        }

        private void dgvEstoque_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEstoque.Columns[e.ColumnIndex].Name == "quantidade")
            {

                string id = dgvEstoque.Rows[e.RowIndex].Cells["id"].Value.ToString();
                string novoValor = dgvEstoque.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                EstoqueDAO edao = new EstoqueDAO();
                edao.UpdateEstoque(id, novoValor);
            }
        }

        private void dgvEstoque_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgvEstoque.Columns[e.ColumnIndex].Name == "Quantidade")
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }



        }

        private void dgvEstoque_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvEstoque.SelectedRows.Count > 0)
                {
                    int id = int.Parse(dgvEstoque.SelectedRows[0].Cells["id"].Value.ToString());

                    if (MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        EstoqueDAO edao = new EstoqueDAO();
                        edao.DeleteEstoque(id);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um medicamento que deseja excluir!");
                }
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbFiltroDadosPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            PacienteDAO pdao = new PacienteDAO();

            string valorSelecionado = cbFiltroDadosPaciente.SelectedItem.ToString();

            if (valorSelecionado == "Exibir dados")
            {
                dgvListaPacientes.DataSource = pdao.ReadPacientes();
            }
            else if (valorSelecionado == "Exibir dados filtrados")
            {
                dgvListaPacientes.DataSource = pdao.ReadPacientesFiltro();
            }

        }

        private void cbFiltroStatusPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {
            PacienteDAO pdao = new PacienteDAO();

            string valorSelecionado = cbFiltroStatusPaciente.SelectedItem.ToString();

            if (valorSelecionado == "Aguardando")
            {
                dgvListaPacientes.DataSource = pdao.ReadPacientesForStatus("Aguardando");
            }
            else if (valorSelecionado == "Internado")
            {
                dgvListaPacientes.DataSource = pdao.ReadPacientesForStatus("Internado");
            }
            else if (valorSelecionado == "Alta")
            {
                dgvListaPacientes.DataSource = pdao.ReadPacientesForStatus("Alta");
            }
        }

        private void btnBuscaPaciente_Click(object sender, EventArgs e)
        {
            PacienteDAO pdao = new PacienteDAO();
            dgvListaPacientes.DataSource = pdao.SearchPacienteForName(txtBuscaPaciente.Text);
        }

        private void dgvListaPacientes_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {


            if (dgvEstoque.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvEstoque.SelectedRows[0].Cells["id"].Value.ToString());

                if (MessageBox.Show("Deseja realmente excluir este registro?", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    EstoqueDAO edao = new EstoqueDAO();
                    edao.DeleteEstoque(id);
                }
            }
            else
            {
                MessageBox.Show("Selecione um medicamento que deseja excluir!");
            }
        }

        private void dgvListaPacientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListaPacientes.SelectedRows.Count > 0)
            {
                int linhaSelecionada = dgvListaPacientes.SelectedRows[0].Index;
                string valor = dgvListaPacientes.Rows[linhaSelecionada].Cells["status_paciente"].Value?.ToString();

                if (valor == "aguardando")
                {
                    btnInternarPaciente.Visible = true;
                }
                else
                {
                    btnInternarPaciente.Visible = false;
                }
            }
            else if (dgvListaPacientes.CurrentRow != null)
            {
                int linhaSelecionada = dgvListaPacientes.CurrentRow.Index;
                string valor = dgvListaPacientes.Rows[linhaSelecionada].Cells["status_paciente"].Value?.ToString();

                if (valor == "aguardando")
                {
                    btnInternarPaciente.Visible = true;
                }
                else
                {
                    btnInternarPaciente.Visible = false;
                }
            }


        }

        private void btnInternarPaciente_Click(object sender, EventArgs e)
        {


            if (CheckedMedico)
            {
                if (dgvListaPacientes.SelectedRows.Count > 0)
                {
                    int linhaSelecionada = dgvListaPacientes.SelectedRows[0].Index;
                    string valor = dgvListaPacientes.Rows[linhaSelecionada].Cells["id"].Value?.ToString();

                    new ViewInternarPaciente(UserId, int.Parse(valor), this).Show();
                    btnInternarPaciente.Visible = false;
                }
                else if (dgvListaPacientes.CurrentRow != null)
                {
                    int linhaSelecionada = dgvListaPacientes.CurrentRow.Index;
                    string valor = dgvListaPacientes.Rows[linhaSelecionada].Cells["id"].Value?.ToString();

                    new ViewInternarPaciente(UserId, int.Parse(valor), this).Show();
                    btnInternarPaciente.Visible = false;
                }
            }
            else
            {
                MessageBox.Show("Você não tem permissão para internar um paciente!");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvInternacaoDetalhes_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dgvInternacaoDetalhes_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void dgvInternacaoDetalhes_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {


        }

        private void dgvInternacaoDetalhes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInternacaoDetalhes.SelectedRows.Count > 0)
            {

            }
            else if (dgvInternacaoDetalhes.CurrentRow != null)
            {

            }


        }

        private void dgvInternacao_SelectionChanged(object sender, EventArgs e)
        {
            // AO SELECIONAR UM REGISTRO DA TABELA, SE CASO TIVER INTERNADO ELE OCULTA OS BOTOES DE DETALHES, SENAO ELE EXIBE
            if (dgvInternacao.SelectedRows.Count > 0)
            {
                int linhaSelecionada = dgvInternacao.SelectedRows[0].Index;
                string valor = dgvInternacao.Rows[linhaSelecionada].Cells["StatusPaciente"].Value?.ToString();

                if (valor == "Internado")
                {
                    tlpRegistroDetalhes.Visible = true;
                    btnAlta.Visible = true;
                }
                else
                {
                    tlpRegistroDetalhes.Visible = false;
                    btnAlta.Visible = false;
                }
            }
            else if (dgvInternacao.CurrentRow != null)
            {
                int linhaSelecionada = dgvInternacao.CurrentRow.Index;
                string valor = dgvInternacao.Rows[linhaSelecionada].Cells["StatusPaciente"].Value?.ToString();

                if (valor == "Internado")
                {
                    tlpRegistroDetalhes.Visible = true;
                    btnAlta.Visible = true;
                }
                else
                {
                    tlpRegistroDetalhes.Visible = false;
                    btnAlta.Visible = false;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (TelaLogin != null)
            {
                TelaLogin = new ViewLogin();
                TelaLogin.Show();
            }
        }

        private void picBtnEstoque_MouseEnter(object sender, EventArgs e)
        {
            picBtnEstoque.Image = Properties.Resources.btnEstoqueSelect;
        }

        private void picBtnEstoque_MouseLeave(object sender, EventArgs e)
        {
            picBtnEstoque.Image = Properties.Resources.btnEstoque;
        }

        private void picBtnCadastrarMedicamento_MouseEnter(object sender, EventArgs e)
        {
            picBtnCadastrarMedicamento.Image = Properties.Resources.btnCadastrarMedicamentoSelect;
        }

        private void picBtnCadastrarMedicamento_MouseLeave(object sender, EventArgs e)
        {
            picBtnCadastrarMedicamento.Image = Properties.Resources.btnCadastrarMedicamento;
        }

        private void picCadastrarEnfermeiros_MouseEnter(object sender, EventArgs e)
        {
            picCadastrarEnfermeiros.Image = Properties.Resources.btnCadastrarEnfermeiroSelect;
        }

        private void picCadastrarEnfermeiros_MouseLeave(object sender, EventArgs e)
        {
            picCadastrarEnfermeiros.Image = Properties.Resources.btnCadastrarEnfermeiro;
        }

        private void picCadastrarMedico_MouseEnter(object sender, EventArgs e)
        {
            picCadastrarMedico.Image = Properties.Resources.btnCadastrarMedicoSelect;
        }

        private void picCadastrarMedico_MouseLeave(object sender, EventArgs e)
        {
            picCadastrarMedico.Image = Properties.Resources.btnCadastrarMedico;
        }

        private void picCadastrarRecepcionista_MouseEnter(object sender, EventArgs e)
        {
            picCadastrarRecepcionista.Image = Properties.Resources.btnCadastrarRecepcionistaSelect;
        }

        private void picCadastrarRecepcionista_MouseLeave(object sender, EventArgs e)
        {
            picCadastrarRecepcionista.Image = Properties.Resources.btnCadastrarRecepcionista;
        }

        private void picBtnListaColaboradores_MouseEnter(object sender, EventArgs e)
        {
            picBtnListaColaboradores.Image = Properties.Resources.btnListaColaboradoresSelect;
        }

        private void picBtnListaColaboradores_MouseLeave(object sender, EventArgs e)
        {
            picBtnListaColaboradores.Image = Properties.Resources.btnListaColaboradores;
        }

        private void picCadastrarPaciente_MouseEnter(object sender, EventArgs e)
        {
            picCadastrarPaciente.Image = Properties.Resources.btnCadastrarPacienteSelect;
        }

        private void picCadastrarPaciente_MouseLeave(object sender, EventArgs e)
        {
            picCadastrarPaciente.Image = Properties.Resources.btnCadastrarPaciente;
        }

        private void picListaPaciente_MouseEnter(object sender, EventArgs e)
        {
            picListaPaciente.Image = Properties.Resources.btnListaPacienteSelect;
        }

        private void picListaPaciente_MouseLeave(object sender, EventArgs e)
        {
            picListaPaciente.Image = Properties.Resources.btnListaPacientes;
        }
    }
}
