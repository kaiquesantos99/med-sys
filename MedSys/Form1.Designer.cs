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
            tlpMain = new TableLayoutPanel();
            panOptionsButtons = new Panel();
            tlpBotoesEstoque = new TableLayoutPanel();
            picBtnEstoque = new PictureBox();
            picBtnCadastrarMedicamento = new PictureBox();
            tlpBotoesProntuario = new TableLayoutPanel();
            picBtnConsulta = new PictureBox();
            picBtnExame = new PictureBox();
            picBtnInternacoes = new PictureBox();
            tlpBotoesPacientes = new TableLayoutPanel();
            picCadastrarPaciente = new PictureBox();
            picListaPaciente = new PictureBox();
            tlpBotoesColaboradores = new TableLayoutPanel();
            picCadastrarEnfermeiros = new PictureBox();
            picCadastrarMedico = new PictureBox();
            picCadastrarRecepcionista = new PictureBox();
            picBtnListaColaboradores = new PictureBox();
            tlpMenu = new TableLayoutPanel();
            picBtnColaborador = new PictureBox();
            picBtnPaciente = new PictureBox();
            picInicioMedSys = new PictureBox();
            picBtnProntuario = new PictureBox();
            picBtnMedicamento = new PictureBox();
            panMain = new Panel();
            tlpMedicamento = new TableLayoutPanel();
            dgvEstoque = new DataGridView();
            cbMedicamentos = new ComboBox();
            tlpInternacao = new TableLayoutPanel();
            dgvInternacao = new DataGridView();
            dgvInternacaoDetalhes = new DataGridView();
            panel1 = new Panel();
            btnInternar = new Button();
            btnAlta = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtBusca = new TextBox();
            btnBuscar = new Button();
            tlpBtnListaColaboradores = new TableLayoutPanel();
            cbColaboradores = new ComboBox();
            dgvListaColaboradores = new DataGridView();
            tlpMain.SuspendLayout();
            panOptionsButtons.SuspendLayout();
            tlpBotoesEstoque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBtnEstoque).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnCadastrarMedicamento).BeginInit();
            tlpBotoesProntuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBtnConsulta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnExame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnInternacoes).BeginInit();
            tlpBotoesPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCadastrarPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picListaPaciente).BeginInit();
            tlpBotoesColaboradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCadastrarEnfermeiros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCadastrarMedico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCadastrarRecepcionista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnListaColaboradores).BeginInit();
            tlpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBtnColaborador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInicioMedSys).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnProntuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnMedicamento).BeginInit();
            panMain.SuspendLayout();
            tlpMedicamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            tlpInternacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInternacao).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInternacaoDetalhes).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tlpBtnListaColaboradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaColaboradores).BeginInit();
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
            panOptionsButtons.Controls.Add(tlpBotoesEstoque);
            panOptionsButtons.Controls.Add(tlpBotoesProntuario);
            panOptionsButtons.Controls.Add(tlpBotoesPacientes);
            panOptionsButtons.Controls.Add(tlpBotoesColaboradores);
            panOptionsButtons.Dock = DockStyle.Fill;
            panOptionsButtons.Location = new Point(4, 110);
            panOptionsButtons.Name = "panOptionsButtons";
            panOptionsButtons.Size = new Size(1101, 34);
            panOptionsButtons.TabIndex = 2;
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
            tlpBotoesEstoque.Dock = DockStyle.Fill;
            tlpBotoesEstoque.Location = new Point(0, 0);
            tlpBotoesEstoque.Name = "tlpBotoesEstoque";
            tlpBotoesEstoque.RowCount = 1;
            tlpBotoesEstoque.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotoesEstoque.Size = new Size(1101, 34);
            tlpBotoesEstoque.TabIndex = 4;
            tlpBotoesEstoque.Visible = false;
            // 
            // picBtnEstoque
            // 
            picBtnEstoque.Dock = DockStyle.Fill;
            picBtnEstoque.Image = Properties.Resources.btnEstoque;
            picBtnEstoque.Location = new Point(738, 3);
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
            picBtnCadastrarMedicamento.Location = new Point(245, 3);
            picBtnCadastrarMedicamento.Name = "picBtnCadastrarMedicamento";
            picBtnCadastrarMedicamento.Size = new Size(245, 28);
            picBtnCadastrarMedicamento.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnCadastrarMedicamento.TabIndex = 1;
            picBtnCadastrarMedicamento.TabStop = false;
            picBtnCadastrarMedicamento.Click += picBtnCadastrarMedicamento_Click;
            // 
            // tlpBotoesProntuario
            // 
            tlpBotoesProntuario.ColumnCount = 7;
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.9999943F));
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 134F));
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0000019F));
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 108F));
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0000019F));
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 149F));
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.0000019F));
            tlpBotoesProntuario.Controls.Add(picBtnConsulta, 1, 0);
            tlpBotoesProntuario.Controls.Add(picBtnExame, 3, 0);
            tlpBotoesProntuario.Controls.Add(picBtnInternacoes, 5, 0);
            tlpBotoesProntuario.Location = new Point(755, 0);
            tlpBotoesProntuario.Name = "tlpBotoesProntuario";
            tlpBotoesProntuario.RowCount = 1;
            tlpBotoesProntuario.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotoesProntuario.Size = new Size(74, 34);
            tlpBotoesProntuario.TabIndex = 3;
            tlpBotoesProntuario.Visible = false;
            // 
            // picBtnConsulta
            // 
            picBtnConsulta.Dock = DockStyle.Fill;
            picBtnConsulta.Image = Properties.Resources.btnConsulta;
            picBtnConsulta.Location = new Point(-76, 3);
            picBtnConsulta.Name = "picBtnConsulta";
            picBtnConsulta.Size = new Size(128, 28);
            picBtnConsulta.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnConsulta.TabIndex = 0;
            picBtnConsulta.TabStop = false;
            picBtnConsulta.MouseEnter += picBtnConsulta_MouseEnter;
            picBtnConsulta.MouseLeave += picBtnConsulta_MouseLeave;
            // 
            // picBtnExame
            // 
            picBtnExame.Dock = DockStyle.Fill;
            picBtnExame.Image = Properties.Resources.btnExame;
            picBtnExame.Location = new Point(-21, 3);
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
            picBtnInternacoes.Location = new Point(8, 3);
            picBtnInternacoes.Name = "picBtnInternacoes";
            picBtnInternacoes.Size = new Size(143, 28);
            picBtnInternacoes.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnInternacoes.TabIndex = 2;
            picBtnInternacoes.TabStop = false;
            picBtnInternacoes.Click += picBtnInternacoes_Click;
            picBtnInternacoes.MouseEnter += picBtnInternacoes_MouseEnter;
            picBtnInternacoes.MouseLeave += picBtnInternacoes_MouseLeave;
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
            tlpBotoesPacientes.Location = new Point(266, 3);
            tlpBotoesPacientes.Name = "tlpBotoesPacientes";
            tlpBotoesPacientes.RowCount = 1;
            tlpBotoesPacientes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotoesPacientes.Size = new Size(74, 30);
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
            picCadastrarPaciente.Size = new Size(207, 24);
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
            picListaPaciente.Size = new Size(192, 24);
            picListaPaciente.SizeMode = PictureBoxSizeMode.Zoom;
            picListaPaciente.TabIndex = 1;
            picListaPaciente.TabStop = false;
            picListaPaciente.Click += picListaPaciente_Click;
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
            panMain.Controls.Add(tlpMedicamento);
            panMain.Controls.Add(tlpInternacao);
            panMain.Controls.Add(tlpBtnListaColaboradores);
            panMain.Dock = DockStyle.Fill;
            panMain.Location = new Point(4, 151);
            panMain.Name = "panMain";
            panMain.Size = new Size(1101, 407);
            panMain.TabIndex = 3;
            panMain.Paint += panMain_Paint;
            // 
            // tlpMedicamento
            // 
            tlpMedicamento.ColumnCount = 2;
            tlpMedicamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.97617F));
            tlpMedicamento.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.0238285F));
            tlpMedicamento.Controls.Add(dgvEstoque, 0, 0);
            tlpMedicamento.Controls.Add(cbMedicamentos, 1, 0);
            tlpMedicamento.Dock = DockStyle.Fill;
            tlpMedicamento.Location = new Point(0, 0);
            tlpMedicamento.Margin = new Padding(3, 2, 3, 2);
            tlpMedicamento.Name = "tlpMedicamento";
            tlpMedicamento.RowCount = 1;
            tlpMedicamento.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMedicamento.Size = new Size(1101, 407);
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
            dgvEstoque.Size = new Size(764, 403);
            dgvEstoque.TabIndex = 0;
            dgvEstoque.CellBeginEdit += dgvEstoque_CellBeginEdit;
            dgvEstoque.CellEndEdit += dgvEstoque_CellEndEdit;
            dgvEstoque.KeyDown += dgvEstoque_KeyDown;
            // 
            // cbMedicamentos
            // 
            cbMedicamentos.Dock = DockStyle.Fill;
            cbMedicamentos.FormattingEnabled = true;
            cbMedicamentos.Location = new Point(773, 2);
            cbMedicamentos.Margin = new Padding(3, 2, 3, 2);
            cbMedicamentos.Name = "cbMedicamentos";
            cbMedicamentos.Size = new Size(325, 23);
            cbMedicamentos.TabIndex = 1;
            cbMedicamentos.SelectedIndexChanged += cbMedicamentos_SelectedIndexChanged;
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
            tlpInternacao.Location = new Point(738, 0);
            tlpInternacao.Name = "tlpInternacao";
            tlpInternacao.RowCount = 3;
            tlpInternacao.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tlpInternacao.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpInternacao.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpInternacao.Size = new Size(117, 113);
            tlpInternacao.TabIndex = 6;
            tlpInternacao.Visible = false;
            // 
            // dgvInternacao
            // 
            dgvInternacao.BackgroundColor = SystemColors.Control;
            dgvInternacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternacao.Dock = DockStyle.Fill;
            dgvInternacao.Location = new Point(3, 40);
            dgvInternacao.Name = "dgvInternacao";
            dgvInternacao.RowHeadersWidth = 51;
            dgvInternacao.Size = new Size(52, 32);
            dgvInternacao.TabIndex = 0;
            dgvInternacao.CellClick += dgvInternacao_CellClick;
            // 
            // dgvInternacaoDetalhes
            // 
            dgvInternacaoDetalhes.BackgroundColor = SystemColors.Control;
            dgvInternacaoDetalhes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInternacaoDetalhes.Dock = DockStyle.Fill;
            dgvInternacaoDetalhes.Location = new Point(61, 40);
            dgvInternacaoDetalhes.Name = "dgvInternacaoDetalhes";
            dgvInternacaoDetalhes.RowHeadersWidth = 51;
            dgvInternacaoDetalhes.Size = new Size(53, 32);
            dgvInternacaoDetalhes.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnInternar);
            panel1.Controls.Add(btnAlta);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 78);
            panel1.Name = "panel1";
            panel1.Size = new Size(52, 32);
            panel1.TabIndex = 2;
            // 
            // btnInternar
            // 
            btnInternar.Location = new Point(70, 46);
            btnInternar.Name = "btnInternar";
            btnInternar.Size = new Size(75, 23);
            btnInternar.TabIndex = 0;
            btnInternar.Text = "Internar";
            btnInternar.Click += btnInternar_Click;
            // 
            // btnAlta
            // 
            btnAlta.Location = new Point(263, 77);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(75, 23);
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
            tableLayoutPanel1.Size = new Size(52, 31);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // txtBusca
            // 
            txtBusca.Dock = DockStyle.Fill;
            txtBusca.Location = new Point(3, 3);
            txtBusca.Name = "txtBusca";
            txtBusca.Size = new Size(11, 23);
            txtBusca.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Dock = DockStyle.Fill;
            btnBuscar.Location = new Point(20, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(11, 25);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tlpBtnListaColaboradores
            // 
            tlpBtnListaColaboradores.ColumnCount = 2;
            tlpBtnListaColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.73842F));
            tlpBtnListaColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.26158F));
            tlpBtnListaColaboradores.Controls.Add(cbColaboradores, 1, 0);
            tlpBtnListaColaboradores.Controls.Add(dgvListaColaboradores, 0, 0);
            tlpBtnListaColaboradores.Location = new Point(0, 0);
            tlpBtnListaColaboradores.Name = "tlpBtnListaColaboradores";
            tlpBtnListaColaboradores.RowCount = 1;
            tlpBtnListaColaboradores.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBtnListaColaboradores.Size = new Size(80, 48);
            tlpBtnListaColaboradores.TabIndex = 4;
            tlpBtnListaColaboradores.Visible = false;
            // 
            // cbColaboradores
            // 
            cbColaboradores.Dock = DockStyle.Top;
            cbColaboradores.FormattingEnabled = true;
            cbColaboradores.Location = new Point(73, 3);
            cbColaboradores.Name = "cbColaboradores";
            cbColaboradores.Size = new Size(4, 23);
            cbColaboradores.TabIndex = 0;
            cbColaboradores.SelectedIndexChanged += cbColaboradores_SelectedIndexChanged;
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
            dgvListaColaboradores.Size = new Size(64, 42);
            dgvListaColaboradores.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 562);
            Controls.Add(tlpMain);
            Name = "Form1";
            Text = "MedSys";
            WindowState = FormWindowState.Maximized;
            tlpMain.ResumeLayout(false);
            panOptionsButtons.ResumeLayout(false);
            tlpBotoesEstoque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBtnEstoque).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnCadastrarMedicamento).EndInit();
            tlpBotoesProntuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBtnConsulta).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnExame).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnInternacoes).EndInit();
            tlpBotoesPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCadastrarPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)picListaPaciente).EndInit();
            tlpBotoesColaboradores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCadastrarEnfermeiros).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCadastrarMedico).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCadastrarRecepcionista).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnListaColaboradores).EndInit();
            tlpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBtnColaborador).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInicioMedSys).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnProntuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnMedicamento).EndInit();
            panMain.ResumeLayout(false);
            tlpMedicamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            tlpInternacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInternacao).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInternacaoDetalhes).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tlpBtnListaColaboradores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaColaboradores).EndInit();
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
        private PictureBox picBtnConsulta;
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
        private Button btnInternar;
        private TableLayoutPanel tlpBotoesEstoque;
        private PictureBox picBtnEstoque;
        private PictureBox picBtnCadastrarMedicamento;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtBusca;
        private Button btnBuscar;
    }
}
