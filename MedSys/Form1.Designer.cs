namespace MedSys
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tlpMain = new TableLayoutPanel();
            panOptionsButtons = new Panel();
            tlpBotoesColaboradores = new TableLayoutPanel();
            picCadastrarEnfermeiros = new PictureBox();
            picCadastrarMedico = new PictureBox();
            picCadastrarRecepcionista = new PictureBox();
            picBtnListaColaboradores = new PictureBox();
            tlpBotoesEstoque = new TableLayoutPanel();
            picBtnEstoque = new PictureBox();
            picBtnCadastrarMedicamento = new PictureBox();
            tlpBotoesPacientes = new TableLayoutPanel();
            picCadastrarPaciente = new PictureBox();
            picListaPaciente = new PictureBox();
            tlpBotoesProntuario = new TableLayoutPanel();
            picBtnExame = new PictureBox();
            picBtnInternacoes = new PictureBox();
            tlpMenu = new TableLayoutPanel();
            picBtnColaborador = new PictureBox();
            picBtnPaciente = new PictureBox();
            picInicioMedSys = new PictureBox();
            picBtnProntuario = new PictureBox();
            picBtnMedicamento = new PictureBox();
            panMain = new Panel();
            tlpListaPacientes = new TableLayoutPanel();
            dgvListaPacientes = new DataGridView();
            tlpListaPacientesRight = new TableLayoutPanel();
            tlpListaPacientesRightTop = new TableLayoutPanel();
            lblFiltro = new Label();
            lblDados = new Label();
            cbFiltroStatusPaciente = new ComboBox();
            cbFiltroDadosPaciente = new ComboBox();
            tlpBuscaPaciente = new TableLayoutPanel();
            btnBuscaPaciente = new Button();
            txtBuscaPaciente = new TextBox();
            btnInternarPaciente = new Button();
            tlpInternacao = new TableLayoutPanel();
            dgvInternacao = new DataGridView();
            dgvInternacaoDetalhes = new DataGridView();
            panel1 = new Panel();
            btnAlta = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtBusca = new TextBox();
            btnBuscar = new Button();
            tlpBtnListaColaboradores = new TableLayoutPanel();
            dgvListaColaboradores = new DataGridView();
            cbColaboradores = new ComboBox();
            tlpMedicamento = new TableLayoutPanel();
            dgvEstoque = new DataGridView();
            cbMedicamentos = new ComboBox();
            tlpMain.SuspendLayout();
            panOptionsButtons.SuspendLayout();
            tlpBotoesColaboradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCadastrarEnfermeiros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCadastrarMedico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCadastrarRecepcionista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnListaColaboradores).BeginInit();
            tlpBotoesEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBtnEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnCadastrarMedicamento).BeginInit();
            tlpBotoesPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCadastrarPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picListaPaciente).BeginInit();
            tlpBotoesProntuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBtnExame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnInternacoes).BeginInit();
            tlpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBtnColaborador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInicioMedSys).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnProntuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnMedicamento).BeginInit();
            panMain.SuspendLayout();
            tlpListaPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaPacientes).BeginInit();
            tlpListaPacientesRight.SuspendLayout();
            tlpListaPacientesRightTop.SuspendLayout();
            tlpBuscaPaciente.SuspendLayout();
            tlpInternacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInternacaoDetalhes).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tlpBtnListaColaboradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaColaboradores).BeginInit();
            tlpMedicamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(panOptionsButtons, 0, 1);
            tlpMain.Controls.Add(tlpMenu, 0, 0);
            tlpMain.Controls.Add(panMain, 0, 2);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1109, 562);
            tlpMain.TabIndex = 0;
            tlpMain.Paint += tlpMain_Paint;
            // 
            // panOptionsButtons
            // 
            panOptionsButtons.Controls.Add(tlpBotoesColaboradores);
            panOptionsButtons.Controls.Add(tlpBotoesEstoque);
            panOptionsButtons.Controls.Add(tlpBotoesPacientes);
            panOptionsButtons.Controls.Add(tlpBotoesProntuario);
            panOptionsButtons.Dock = DockStyle.Fill;
            panOptionsButtons.Location = new Point(4, 110);
            panOptionsButtons.Name = "panOptionsButtons";
            panOptionsButtons.Size = new Size(1101, 34);
            panOptionsButtons.TabIndex = 2;
            // 
            // tlpBotoesColaboradores
            // 
            tlpBotoesColaboradores.ColumnCount = 9;
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9999981F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 232F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 199F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 243F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotoesColaboradores.Controls.Add(picCadastrarEnfermeiros, 1, 0);
            tlpBotoesColaboradores.Controls.Add(picCadastrarMedico, 3, 0);
            tlpBotoesColaboradores.Controls.Add(picCadastrarRecepcionista, 5, 0);
            tlpBotoesColaboradores.Controls.Add(picBtnListaColaboradores, 7, 0);
            tlpBotoesColaboradores.Location = new Point(20, 0);
            tlpBotoesColaboradores.Name = "tlpBotoesColaboradores";
            tlpBotoesColaboradores.RowCount = 1;
            tlpBotoesColaboradores.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotoesColaboradores.Size = new Size(74, 34);
            tlpBotoesColaboradores.TabIndex = 2;
            tlpBotoesColaboradores.Visible = false;
            tlpBotoesColaboradores.Paint += tableLayoutPanel1_Paint_2;
            // 
            // picCadastrarEnfermeiros
            // 
            picCadastrarEnfermeiros.Dock = DockStyle.Fill;
            picCadastrarEnfermeiros.Image = Properties.Resources.btnCadastrarEnfermeiro;
            picCadastrarEnfermeiros.Location = new Point(-166, 3);
            picCadastrarEnfermeiros.Name = "picCadastrarEnfermeiros";
            picCadastrarEnfermeiros.Size = new Size(226, 28);
            picCadastrarEnfermeiros.SizeMode = PictureBoxSizeMode.Zoom;
            picCadastrarEnfermeiros.TabIndex = 0;
            picCadastrarEnfermeiros.TabStop = false;
            picCadastrarEnfermeiros.Click += picCadastrarEnfermeiros_Click;
            // 
            // picCadastrarMedico
            // 
            picCadastrarMedico.Dock = DockStyle.Fill;
            picCadastrarMedico.Image = Properties.Resources.btnCadastrarMedico;
            picCadastrarMedico.Location = new Point(-104, 3);
            picCadastrarMedico.Name = "picCadastrarMedico";
            picCadastrarMedico.Size = new Size(193, 28);
            picCadastrarMedico.SizeMode = PictureBoxSizeMode.Zoom;
            picCadastrarMedico.TabIndex = 1;
            picCadastrarMedico.TabStop = false;
            picCadastrarMedico.Click += picCadastrarMedico_Click;
            // 
            // picCadastrarRecepcionista
            // 
            picCadastrarRecepcionista.Dock = DockStyle.Fill;
            picCadastrarRecepcionista.Image = Properties.Resources.btnCadastrarRecepcionista;
            picCadastrarRecepcionista.Location = new Point(-75, 3);
            picCadastrarRecepcionista.Name = "picCadastrarRecepcionista";
            picCadastrarRecepcionista.Size = new Size(244, 28);
            picCadastrarRecepcionista.SizeMode = PictureBoxSizeMode.Zoom;
            picCadastrarRecepcionista.TabIndex = 2;
            picCadastrarRecepcionista.TabStop = false;
            picCadastrarRecepcionista.Click += picCadastrarRecepcionista_Click;
            // 
            // picBtnListaColaboradores
            // 
            picBtnListaColaboradores.Dock = DockStyle.Fill;
            picBtnListaColaboradores.Image = Properties.Resources.btnListaColaboradores;
            picBtnListaColaboradores.Location = new Point(5, 3);
            picBtnListaColaboradores.Name = "picBtnListaColaboradores";
            picBtnListaColaboradores.Size = new Size(237, 28);
            picBtnListaColaboradores.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnListaColaboradores.TabIndex = 3;
            picBtnListaColaboradores.TabStop = false;
            picBtnListaColaboradores.Click += picCadastrarColaboradores_Click;
            // 
            // tlpBotoesEstoque
            // 
            tlpBotoesEstoque.ColumnCount = 5;
            tlpBotoesEstoque.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpBotoesEstoque.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 251F));
            tlpBotoesEstoque.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpBotoesEstoque.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 123F));
            tlpBotoesEstoque.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpBotoesEstoque.Controls.Add(picBtnEstoque, 3, 0);
            tlpBotoesEstoque.Controls.Add(picBtnCadastrarMedicamento, 1, 0);
            tlpBotoesEstoque.Location = new Point(1000, 0);
            tlpBotoesEstoque.Name = "tlpBotoesEstoque";
            tlpBotoesEstoque.RowCount = 1;
            tlpBotoesEstoque.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotoesEstoque.Size = new Size(101, 34);
            tlpBotoesEstoque.TabIndex = 4;
            tlpBotoesEstoque.Visible = false;
            // 
            // picBtnEstoque
            // 
            picBtnEstoque.Dock = DockStyle.Fill;
            picBtnEstoque.Image = Properties.Resources.btnEstoque;
            picBtnEstoque.Location = new Point(72, 3);
            picBtnEstoque.Name = "picBtnEstoque";
            picBtnEstoque.Size = new Size(117, 28);
            picBtnEstoque.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnEstoque.TabIndex = 0;
            picBtnEstoque.TabStop = false;
            picBtnEstoque.Click += picBtnEstoque_Click;
            // 
            // picBtnCadastrarMedicamento
            // 
            picBtnCadastrarMedicamento.Dock = DockStyle.Fill;
            picBtnCadastrarMedicamento.Image = Properties.Resources.btnCadastrarMedicamento;
            picBtnCadastrarMedicamento.Location = new Point(-88, 3);
            picBtnCadastrarMedicamento.Name = "picBtnCadastrarMedicamento";
            picBtnCadastrarMedicamento.Size = new Size(245, 28);
            picBtnCadastrarMedicamento.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnCadastrarMedicamento.TabIndex = 1;
            picBtnCadastrarMedicamento.TabStop = false;
            picBtnCadastrarMedicamento.Click += picBtnCadastrarMedicamento_Click;
            // 
            // tlpBotoesPacientes
            // 
            tlpBotoesPacientes.ColumnCount = 5;
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 213F));
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 198F));
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpBotoesPacientes.Controls.Add(picCadastrarPaciente, 1, 0);
            tlpBotoesPacientes.Controls.Add(picListaPaciente, 3, 0);
            tlpBotoesPacientes.Location = new Point(265, 0);
            tlpBotoesPacientes.Name = "tlpBotoesPacientes";
            tlpBotoesPacientes.RowCount = 1;
            tlpBotoesPacientes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotoesPacientes.Size = new Size(74, 34);
            tlpBotoesPacientes.TabIndex = 1;
            tlpBotoesPacientes.Visible = false;
            tlpBotoesPacientes.Paint += tableLayoutPanel1_Paint_1;
            // 
            // picCadastrarPaciente
            // 
            picCadastrarPaciente.Dock = DockStyle.Fill;
            picCadastrarPaciente.Image = Properties.Resources.btnCadastrarPaciente;
            picCadastrarPaciente.Location = new Point(-109, 3);
            picCadastrarPaciente.Name = "picCadastrarPaciente";
            picCadastrarPaciente.Size = new Size(207, 28);
            picCadastrarPaciente.SizeMode = PictureBoxSizeMode.Zoom;
            picCadastrarPaciente.TabIndex = 0;
            picCadastrarPaciente.TabStop = false;
            picCadastrarPaciente.Click += picCadastrarPaciente_Click;
            // 
            // picListaPaciente
            // 
            picListaPaciente.Dock = DockStyle.Fill;
            picListaPaciente.Image = Properties.Resources.btnListaPacientes;
            picListaPaciente.Location = new Point(-8, 3);
            picListaPaciente.Name = "picListaPaciente";
            picListaPaciente.Size = new Size(192, 28);
            picListaPaciente.SizeMode = PictureBoxSizeMode.Zoom;
            picListaPaciente.TabIndex = 1;
            picListaPaciente.TabStop = false;
            picListaPaciente.Click += picListaPaciente_Click;
            // 
            // tlpBotoesProntuario
            // 
            tlpBotoesProntuario.ColumnCount = 5;
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 149F));
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tlpBotoesProntuario.Controls.Add(picBtnExame, 1, 0);
            tlpBotoesProntuario.Controls.Add(picBtnInternacoes, 3, 0);
            tlpBotoesProntuario.Location = new Point(755, 0);
            tlpBotoesProntuario.Name = "tlpBotoesProntuario";
            tlpBotoesProntuario.RowCount = 1;
            tlpBotoesProntuario.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotoesProntuario.Size = new Size(74, 34);
            tlpBotoesProntuario.TabIndex = 3;
            tlpBotoesProntuario.Visible = false;
            // 
            // picBtnExame
            // 
            picBtnExame.Dock = DockStyle.Fill;
            picBtnExame.Image = Properties.Resources.btnExame;
            picBtnExame.Location = new Point(-58, 3);
            picBtnExame.Name = "picBtnExame";
            picBtnExame.Size = new Size(102, 28);
            picBtnExame.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnExame.TabIndex = 1;
            picBtnExame.TabStop = false;
            picBtnExame.Click += picBtnExame_Click;
            picBtnExame.MouseEnter += picBtnExame_MouseEnter;
            picBtnExame.MouseLeave += picBtnExame_MouseLeave;
            // 
            // picBtnInternacoes
            // 
            picBtnInternacoes.Dock = DockStyle.Fill;
            picBtnInternacoes.Image = Properties.Resources.btnInternacao;
            picBtnInternacoes.Location = new Point(-11, 3);
            picBtnInternacoes.Name = "picBtnInternacoes";
            picBtnInternacoes.Size = new Size(143, 28);
            picBtnInternacoes.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnInternacoes.TabIndex = 2;
            picBtnInternacoes.TabStop = false;
            picBtnInternacoes.Click += picBtnInternacoes_Click;
            picBtnInternacoes.MouseEnter += picBtnInternacoes_MouseEnter;
            picBtnInternacoes.MouseLeave += picBtnInternacoes_MouseLeave;
            // 
            // tlpMenu
            // 
            tlpMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpMenu.BackColor = Color.FromArgb(192, 255, 255);
            tlpMenu.ColumnCount = 11;
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 27F));
            tlpMenu.Controls.Add(picBtnColaborador, 1, 1);
            tlpMenu.Controls.Add(picBtnPaciente, 3, 1);
            tlpMenu.Controls.Add(picInicioMedSys, 5, 1);
            tlpMenu.Controls.Add(picBtnProntuario, 7, 1);
            tlpMenu.Controls.Add(picBtnMedicamento, 9, 1);
            tlpMenu.Location = new Point(1, 1);
            tlpMenu.Margin = new Padding(0);
            tlpMenu.Name = "tlpMenu";
            tlpMenu.RowCount = 3;
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tlpMenu.Size = new Size(1107, 105);
            tlpMenu.TabIndex = 0;
            tlpMenu.Paint += tlpMenu_Paint;
            // 
            // picBtnColaborador
            // 
            picBtnColaborador.Dock = DockStyle.Fill;
            picBtnColaborador.Image = Properties.Resources.btn_colaborador2;
            picBtnColaborador.Location = new Point(23, 15);
            picBtnColaborador.Name = "picBtnColaborador";
            picBtnColaborador.Size = new Size(74, 74);
            picBtnColaborador.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnColaborador.TabIndex = 0;
            picBtnColaborador.TabStop = false;
            picBtnColaborador.Click += picBtnColaborador_Click;
            // 
            // picBtnPaciente
            // 
            picBtnPaciente.Dock = DockStyle.Fill;
            picBtnPaciente.Image = Properties.Resources.btn_paciente;
            picBtnPaciente.Location = new Point(268, 15);
            picBtnPaciente.Name = "picBtnPaciente";
            picBtnPaciente.Size = new Size(74, 74);
            picBtnPaciente.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnPaciente.TabIndex = 1;
            picBtnPaciente.TabStop = false;
            picBtnPaciente.Click += picBtnPaciente_Click;
            // 
            // picInicioMedSys
            // 
            picInicioMedSys.Dock = DockStyle.Fill;
            picInicioMedSys.Image = Properties.Resources.medsys_logo;
            picInicioMedSys.Location = new Point(513, 15);
            picInicioMedSys.Name = "picInicioMedSys";
            picInicioMedSys.Size = new Size(74, 74);
            picInicioMedSys.SizeMode = PictureBoxSizeMode.Zoom;
            picInicioMedSys.TabIndex = 3;
            picInicioMedSys.TabStop = false;
            picInicioMedSys.Click += picInicioMedSys_Click;
            picInicioMedSys.MouseEnter += picInicioMedSys_MouseEnter;
            picInicioMedSys.MouseLeave += picInicioMedSys_MouseLeave;
            // 
            // picBtnProntuario
            // 
            picBtnProntuario.Dock = DockStyle.Fill;
            picBtnProntuario.Image = Properties.Resources.btn_prontuario;
            picBtnProntuario.Location = new Point(758, 15);
            picBtnProntuario.Name = "picBtnProntuario";
            picBtnProntuario.Size = new Size(74, 74);
            picBtnProntuario.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnProntuario.TabIndex = 4;
            picBtnProntuario.TabStop = false;
            picBtnProntuario.Click += picBtnProntuario_Click;
            // 
            // picBtnMedicamento
            // 
            picBtnMedicamento.Dock = DockStyle.Fill;
            picBtnMedicamento.Image = Properties.Resources.btn_medicamento;
            picBtnMedicamento.Location = new Point(1003, 15);
            picBtnMedicamento.Name = "picBtnMedicamento";
            picBtnMedicamento.Size = new Size(74, 74);
            picBtnMedicamento.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnMedicamento.TabIndex = 2;
            picBtnMedicamento.TabStop = false;
            picBtnMedicamento.Click += picBtnMedicamento_Click;
            // 
            // panMain
            // 
            panMain.Controls.Add(tlpListaPacientes);
            panMain.Controls.Add(tlpInternacao);
            panMain.Controls.Add(tlpBtnListaColaboradores);
            panMain.Controls.Add(tlpMedicamento);
            panMain.Dock = DockStyle.Fill;
            panMain.Location = new Point(4, 151);
            panMain.Name = "panMain";
            panMain.Size = new Size(1101, 407);
            panMain.TabIndex = 3;
            panMain.Paint += panMain_Paint;
            // 
            // tlpListaPacientes
            // 
            tlpListaPacientes.ColumnCount = 2;
            tlpListaPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.84469F));
            tlpListaPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.1553135F));
            tlpListaPacientes.Controls.Add(dgvListaPacientes, 0, 0);
            tlpListaPacientes.Controls.Add(tlpListaPacientesRight, 1, 0);
            tlpListaPacientes.Location = new Point(284, 3);
            tlpListaPacientes.Name = "tlpListaPacientes";
            tlpListaPacientes.RowCount = 1;
            tlpListaPacientes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpListaPacientes.Size = new Size(102, 60);
            tlpListaPacientes.TabIndex = 7;
            tlpListaPacientes.Visible = false;
            // 
            // dgvListaPacientes
            // 
            dgvListaPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaPacientes.BackgroundColor = Color.FromArgb(223, 233, 245);
            dgvListaPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaPacientes.Dock = DockStyle.Fill;
            dgvListaPacientes.Location = new Point(3, 3);
            dgvListaPacientes.Name = "dgvListaPacientes";
            dgvListaPacientes.RowHeadersWidth = 51;
            dgvListaPacientes.Size = new Size(66, 54);
            dgvListaPacientes.TabIndex = 0;
            dgvListaPacientes.CellBeginEdit += dgvListaPacientes_CellBeginEdit;
            dgvListaPacientes.SelectionChanged += dgvListaPacientes_SelectionChanged;
            // 
            // tlpListaPacientesRight
            // 
            tlpListaPacientesRight.ColumnCount = 1;
            tlpListaPacientesRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpListaPacientesRight.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpListaPacientesRight.Controls.Add(tlpListaPacientesRightTop, 0, 0);
            tlpListaPacientesRight.Controls.Add(btnInternarPaciente, 0, 1);
            tlpListaPacientesRight.Dock = DockStyle.Fill;
            tlpListaPacientesRight.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tlpListaPacientesRight.Location = new Point(75, 3);
            tlpListaPacientesRight.Name = "tlpListaPacientesRight";
            tlpListaPacientesRight.RowCount = 2;
            tlpListaPacientesRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            tlpListaPacientesRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 117F));
            tlpListaPacientesRight.Size = new Size(24, 54);
            tlpListaPacientesRight.TabIndex = 1;
            // 
            // tlpListaPacientesRightTop
            // 
            tlpListaPacientesRightTop.ColumnCount = 2;
            tlpListaPacientesRightTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpListaPacientesRightTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpListaPacientesRightTop.Controls.Add(lblFiltro, 0, 0);
            tlpListaPacientesRightTop.Controls.Add(lblDados, 1, 0);
            tlpListaPacientesRightTop.Controls.Add(cbFiltroStatusPaciente, 0, 1);
            tlpListaPacientesRightTop.Controls.Add(cbFiltroDadosPaciente, 1, 1);
            tlpListaPacientesRightTop.Controls.Add(tlpBuscaPaciente, 1, 2);
            tlpListaPacientesRightTop.Controls.Add(txtBuscaPaciente, 0, 2);
            tlpListaPacientesRightTop.Dock = DockStyle.Fill;
            tlpListaPacientesRightTop.Location = new Point(3, 3);
            tlpListaPacientesRightTop.Name = "tlpListaPacientesRightTop";
            tlpListaPacientesRightTop.RowCount = 3;
            tlpListaPacientesRightTop.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpListaPacientesRightTop.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpListaPacientesRightTop.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tlpListaPacientesRightTop.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpListaPacientesRightTop.Size = new Size(18, 92);
            tlpListaPacientesRightTop.TabIndex = 0;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.BackColor = Color.FromArgb(187, 210, 236);
            lblFiltro.Dock = DockStyle.Fill;
            lblFiltro.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltro.Location = new Point(3, 0);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(3, 30);
            lblFiltro.TabIndex = 0;
            lblFiltro.Text = "Status";
            lblFiltro.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDados
            // 
            lblDados.AutoSize = true;
            lblDados.BackColor = Color.FromArgb(187, 210, 236);
            lblDados.Dock = DockStyle.Fill;
            lblDados.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDados.Location = new Point(12, 0);
            lblDados.Name = "lblDados";
            lblDados.Size = new Size(3, 30);
            lblDados.TabIndex = 1;
            lblDados.Text = "Exibir Dados";
            lblDados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbFiltroStatusPaciente
            // 
            cbFiltroStatusPaciente.BackColor = Color.FromArgb(223, 233, 245);
            cbFiltroStatusPaciente.Dock = DockStyle.Fill;
            cbFiltroStatusPaciente.FormattingEnabled = true;
            cbFiltroStatusPaciente.Location = new Point(3, 33);
            cbFiltroStatusPaciente.Name = "cbFiltroStatusPaciente";
            cbFiltroStatusPaciente.Size = new Size(3, 23);
            cbFiltroStatusPaciente.TabIndex = 2;
            cbFiltroStatusPaciente.SelectedIndexChanged += cbFiltroStatusPaciente_SelectedIndexChanged;
            // 
            // cbFiltroDadosPaciente
            // 
            cbFiltroDadosPaciente.BackColor = Color.FromArgb(223, 233, 245);
            cbFiltroDadosPaciente.Dock = DockStyle.Fill;
            cbFiltroDadosPaciente.FormattingEnabled = true;
            cbFiltroDadosPaciente.Location = new Point(12, 33);
            cbFiltroDadosPaciente.Name = "cbFiltroDadosPaciente";
            cbFiltroDadosPaciente.Size = new Size(3, 23);
            cbFiltroDadosPaciente.TabIndex = 3;
            cbFiltroDadosPaciente.SelectedIndexChanged += cbFiltroDadosPaciente_SelectedIndexChanged;
            // 
            // tlpBuscaPaciente
            // 
            tlpBuscaPaciente.ColumnCount = 3;
            tlpBuscaPaciente.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 39F));
            tlpBuscaPaciente.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.34884F));
            tlpBuscaPaciente.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.6511631F));
            tlpBuscaPaciente.Controls.Add(btnBuscaPaciente, 1, 0);
            tlpBuscaPaciente.Dock = DockStyle.Fill;
            tlpBuscaPaciente.Location = new Point(12, 63);
            tlpBuscaPaciente.Name = "tlpBuscaPaciente";
            tlpBuscaPaciente.RowCount = 1;
            tlpBuscaPaciente.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBuscaPaciente.Size = new Size(3, 26);
            tlpBuscaPaciente.TabIndex = 5;
            // 
            // btnBuscaPaciente
            // 
            btnBuscaPaciente.BackColor = Color.FromArgb(187, 210, 236);
            btnBuscaPaciente.BackgroundImage = Properties.Resources.pngtree_cartoon_blue_magnifying_glass_illustration_image_1214215_removebg_preview1;
            btnBuscaPaciente.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscaPaciente.Dock = DockStyle.Fill;
            btnBuscaPaciente.Location = new Point(42, 3);
            btnBuscaPaciente.Name = "btnBuscaPaciente";
            btnBuscaPaciente.Size = new Size(1, 20);
            btnBuscaPaciente.TabIndex = 0;
            btnBuscaPaciente.UseVisualStyleBackColor = false;
            btnBuscaPaciente.Click += btnBuscaPaciente_Click;
            // 
            // txtBuscaPaciente
            // 
            txtBuscaPaciente.BackColor = Color.FromArgb(223, 233, 245);
            txtBuscaPaciente.Dock = DockStyle.Fill;
            txtBuscaPaciente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscaPaciente.ForeColor = Color.Black;
            txtBuscaPaciente.Location = new Point(3, 63);
            txtBuscaPaciente.Name = "txtBuscaPaciente";
            txtBuscaPaciente.Size = new Size(3, 21);
            txtBuscaPaciente.TabIndex = 4;
            // 
            // btnInternarPaciente
            // 
            btnInternarPaciente.BackColor = Color.Transparent;
            btnInternarPaciente.BackgroundImage = Properties.Resources.cadastrarbutton10;
            btnInternarPaciente.BackgroundImageLayout = ImageLayout.Zoom;
            btnInternarPaciente.Dock = DockStyle.Top;
            btnInternarPaciente.FlatAppearance.BorderSize = 0;
            btnInternarPaciente.FlatStyle = FlatStyle.Flat;
            btnInternarPaciente.Location = new Point(3, 101);
            btnInternarPaciente.Name = "btnInternarPaciente";
            btnInternarPaciente.Size = new Size(18, 25);
            btnInternarPaciente.TabIndex = 1;
            btnInternarPaciente.Text = "Internar";
            btnInternarPaciente.UseVisualStyleBackColor = false;
            btnInternarPaciente.Visible = false;
            btnInternarPaciente.Click += btnInternarPaciente_Click;
            // 
            // tlpInternacao
            // 
            tlpInternacao.ColumnCount = 2;
            tlpInternacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpInternacao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpInternacao.Controls.Add(dgvInternacao, 0, 1);
            tlpInternacao.Controls.Add(dgvInternacaoDetalhes, 1, 1);
            tlpInternacao.Controls.Add(panel1, 0, 2);
            tlpInternacao.Controls.Add(tableLayoutPanel1, 0, 0);
            tlpInternacao.Location = new Point(755, 6);
            tlpInternacao.Name = "tlpInternacao";
            tlpInternacao.RowCount = 3;
            tlpInternacao.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tlpInternacao.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpInternacao.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpInternacao.Size = new Size(60, 45);
            tlpInternacao.TabIndex = 6;
            tlpInternacao.Visible = false;
            // 
            // dgvInternacao
            // 
            dgvInternacao.BackgroundColor = Color.FromArgb(223, 233, 245);
            dgvInternacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternacao.Dock = DockStyle.Fill;
            dgvInternacao.Location = new Point(3, 40);
            dgvInternacao.Name = "dgvInternacao";
            dgvInternacao.RowHeadersWidth = 51;
            dgvInternacao.Size = new Size(24, 1);
            dgvInternacao.TabIndex = 0;
            dgvInternacao.CellClick += dgvInternacao_CellClick;
            // 
            // dgvInternacaoDetalhes
            // 
            dgvInternacaoDetalhes.BackgroundColor = Color.FromArgb(223, 233, 245);
            dgvInternacaoDetalhes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternacaoDetalhes.Dock = DockStyle.Fill;
            dgvInternacaoDetalhes.Location = new Point(33, 40);
            dgvInternacaoDetalhes.Name = "dgvInternacaoDetalhes";
            dgvInternacaoDetalhes.RowHeadersWidth = 51;
            dgvInternacaoDetalhes.Size = new Size(24, 1);
            dgvInternacaoDetalhes.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAlta);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(24, 1);
            panel1.TabIndex = 2;
            // 
            // btnAlta
            // 
            btnAlta.BackgroundImage = Properties.Resources.cadastrarbutton9;
            btnAlta.BackgroundImageLayout = ImageLayout.Zoom;
            btnAlta.FlatAppearance.BorderSize = 0;
            btnAlta.FlatStyle = FlatStyle.Flat;
            btnAlta.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAlta.Location = new Point(316, 11);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(139, 64);
            btnAlta.TabIndex = 1;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(txtBusca, 0, 0);
            tableLayoutPanel1.Controls.Add(btnBuscar, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(24, 31);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // txtBusca
            // 
            txtBusca.BackColor = Color.FromArgb(223, 233, 245);
            txtBusca.Dock = DockStyle.Fill;
            txtBusca.Location = new Point(3, 3);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(2, 23);
            txtBusca.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(187, 210, 236);
            btnBuscar.Dock = DockStyle.Fill;
            btnBuscar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(11, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(2, 25);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tlpBtnListaColaboradores
            // 
            tlpBtnListaColaboradores.ColumnCount = 2;
            tlpBtnListaColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.73842F));
            tlpBtnListaColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.26158F));
            tlpBtnListaColaboradores.Controls.Add(dgvListaColaboradores, 0, 0);
            tlpBtnListaColaboradores.Controls.Add(cbColaboradores, 1, 0);
            tlpBtnListaColaboradores.Location = new Point(0, 0);
            tlpBtnListaColaboradores.Name = "tlpBtnListaColaboradores";
            tlpBtnListaColaboradores.RowCount = 1;
            tlpBtnListaColaboradores.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBtnListaColaboradores.Size = new Size(94, 63);
            tlpBtnListaColaboradores.TabIndex = 4;
            tlpBtnListaColaboradores.Visible = false;
            // 
            // dgvListaColaboradores
            // 
            dgvListaColaboradores.AllowUserToAddRows = false;
            dgvListaColaboradores.AllowUserToDeleteRows = false;
            dgvListaColaboradores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaColaboradores.BackgroundColor = SystemColors.Control;
            dgvListaColaboradores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaColaboradores.Dock = DockStyle.Fill;
            dgvListaColaboradores.Location = new Point(3, 3);
            dgvListaColaboradores.Name = "dgvListaColaboradores";
            dgvListaColaboradores.ReadOnly = true;
            dgvListaColaboradores.RowHeadersWidth = 51;
            dgvListaColaboradores.Size = new Size(76, 57);
            dgvListaColaboradores.TabIndex = 1;
            // 
            // cbColaboradores
            // 
            cbColaboradores.Dock = DockStyle.Top;
            cbColaboradores.FormattingEnabled = true;
            cbColaboradores.Location = new Point(85, 3);
            cbColaboradores.Name = "cbColaboradores";
            cbColaboradores.Size = new Size(6, 23);
            cbColaboradores.TabIndex = 0;
            cbColaboradores.SelectedIndexChanged += cbColaboradores_SelectedIndexChanged;
            // 
            // tlpMedicamento
            // 
            tlpMedicamento.ColumnCount = 2;
            tlpMedicamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.97617F));
            tlpMedicamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0238285F));
            tlpMedicamento.Controls.Add(dgvEstoque, 0, 0);
            tlpMedicamento.Controls.Add(cbMedicamentos, 1, 0);
            tlpMedicamento.Location = new Point(1000, 0);
            tlpMedicamento.Margin = new Padding(3, 2, 3, 2);
            tlpMedicamento.Name = "tlpMedicamento";
            tlpMedicamento.RowCount = 1;
            tlpMedicamento.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMedicamento.Size = new Size(79, 48);
            tlpMedicamento.TabIndex = 5;
            tlpMedicamento.Visible = false;
            // 
            // dgvEstoque
            // 
            dgvEstoque.BackgroundColor = SystemColors.Control;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Dock = DockStyle.Fill;
            dgvEstoque.GridColor = SystemColors.Control;
            dgvEstoque.Location = new Point(3, 2);
            dgvEstoque.Margin = new Padding(3, 2, 3, 2);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.RowHeadersWidth = 51;
            dgvEstoque.Size = new Size(49, 44);
            dgvEstoque.TabIndex = 0;
            dgvEstoque.CellBeginEdit += dgvEstoque_CellBeginEdit;
            dgvEstoque.CellEndEdit += dgvEstoque_CellEndEdit;
            dgvEstoque.KeyDown += dgvEstoque_KeyDown;
            // 
            // cbMedicamentos
            // 
            cbMedicamentos.Dock = DockStyle.Fill;
            cbMedicamentos.FormattingEnabled = true;
            cbMedicamentos.Location = new Point(58, 2);
            cbMedicamentos.Margin = new Padding(3, 2, 3, 2);
            cbMedicamentos.Name = "cbMedicamentos";
            cbMedicamentos.Size = new Size(18, 23);
            cbMedicamentos.TabIndex = 1;
            cbMedicamentos.SelectedIndexChanged += cbMedicamentos_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 562);
            Controls.Add(tlpMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Medical System";
            WindowState = FormWindowState.Maximized;
            tlpMain.ResumeLayout(false);
            panOptionsButtons.ResumeLayout(false);
            tlpBotoesColaboradores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCadastrarEnfermeiros).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCadastrarMedico).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCadastrarRecepcionista).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnListaColaboradores).EndInit();
            tlpBotoesEstoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBtnEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnCadastrarMedicamento).EndInit();
            tlpBotoesPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCadastrarPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)picListaPaciente).EndInit();
            tlpBotoesProntuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBtnExame).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnInternacoes).EndInit();
            tlpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBtnColaborador).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInicioMedSys).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnProntuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnMedicamento).EndInit();
            panMain.ResumeLayout(false);
            tlpListaPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaPacientes).EndInit();
            tlpListaPacientesRight.ResumeLayout(false);
            tlpListaPacientesRightTop.ResumeLayout(false);
            tlpListaPacientesRightTop.PerformLayout();
            tlpBuscaPaciente.ResumeLayout(false);
            tlpInternacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInternacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInternacaoDetalhes).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tlpBtnListaColaboradores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaColaboradores).EndInit();
            tlpMedicamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpMenu;
        private PictureBox picBtnColaborador;
        private TableLayoutPanel tlpBotoesPacientes;
        private PictureBox picCadastrarPaciente;
        private PictureBox picListaPaciente;
        private PictureBox picBtnPaciente;
        private PictureBox picBtnProntuario;
        private PictureBox picBtnMedicamento;
        private PictureBox picInicioMedSys;
        private Panel panOptionsButtons;
        private TableLayoutPanel tlpBotoesColaboradores;
        private PictureBox picCadastrarEnfermeiros;
        private PictureBox picCadastrarMedico;
        private PictureBox picCadastrarRecepcionista;
        private PictureBox picBtnListaColaboradores;
        private TableLayoutPanel tlpBotoesProntuario;
        private PictureBox picBtnExame;
        private PictureBox picBtnInternacoes;
        private Panel panMain;
        private TableLayoutPanel tlpBtnListaColaboradores;
        private ComboBox cbColaboradores;
        private DataGridView dgvListaColaboradores;
        private TableLayoutPanel tlpMedicamento;
        private DataGridView dgvEstoque;
        private ComboBox cbMedicamentos;
        private TableLayoutPanel tlpInternacao;
        private DataGridView dgvInternacao;
        private DataGridView dgvInternacaoDetalhes;
        private Panel panel1;
        private Button btnAlta;
        private TableLayoutPanel tlpBotoesEstoque;
        private PictureBox picBtnEstoque;
        private PictureBox picBtnCadastrarMedicamento;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtBusca;
        private Button btnBuscar;
        private TableLayoutPanel tlpListaPacientes;
        private DataGridView dgvListaPacientes;
        private TableLayoutPanel tlpListaPacientesRight;
        private TableLayoutPanel tlpListaPacientesRightTop;
        private Label lblFiltro;
        private Label lblDados;
        private ComboBox cbFiltroStatusPaciente;
        private ComboBox cbFiltroDadosPaciente;
        private TextBox txtBuscaPaciente;
        private TableLayoutPanel tlpBuscaPaciente;
        private Button btnBuscaPaciente;
        private Button btnInternarPaciente;
    }
}
