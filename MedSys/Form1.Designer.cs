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
            tlpBotoesColaboradores = new TableLayoutPanel();
            picCadastrarEnfermeiros = new PictureBox();
            picCadastrarMedico = new PictureBox();
            picCadastrarRecepcionista = new PictureBox();
            picCadastrarColaboradores = new PictureBox();
            tlpBotoesPacientes = new TableLayoutPanel();
            picCadastrarPaciente = new PictureBox();
            picListaPaciente = new PictureBox();
            tlpBotoesProntuario = new TableLayoutPanel();
            picBtnConsulta = new PictureBox();
            picBtnExame = new PictureBox();
            pctBtnInternacao = new PictureBox();
            tlpMenu = new TableLayoutPanel();
            picBtnColaborador = new PictureBox();
            picBtnPaciente = new PictureBox();
            picInicioMedSys = new PictureBox();
            picBtnProntuario = new PictureBox();
            picBtnMedicamento = new PictureBox();
            tlpMain.SuspendLayout();
            panOptionsButtons.SuspendLayout();
            tlpBotoesColaboradores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCadastrarEnfermeiros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCadastrarMedico).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCadastrarRecepcionista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCadastrarColaboradores).BeginInit();
            tlpBotoesPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCadastrarPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picListaPaciente).BeginInit();
            tlpBotoesProntuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBtnConsulta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnExame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctBtnInternacao).BeginInit();
            tlpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBtnColaborador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInicioMedSys).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnProntuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnMedicamento).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpMain.Controls.Add(panOptionsButtons, 0, 1);
            tlpMain.Controls.Add(tlpMenu, 0, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 306F));
            tlpMain.Size = new Size(1140, 522);
            tlpMain.TabIndex = 0;
            tlpMain.Paint += tlpMain_Paint;
            // 
            // panOptionsButtons
            // 
            panOptionsButtons.Controls.Add(tlpBotoesColaboradores);
            panOptionsButtons.Controls.Add(tlpBotoesPacientes);
            panOptionsButtons.Controls.Add(tlpBotoesProntuario);
            panOptionsButtons.Dock = DockStyle.Fill;
            panOptionsButtons.Location = new Point(4, 110);
            panOptionsButtons.Name = "panOptionsButtons";
            panOptionsButtons.Size = new Size(1132, 34);
            panOptionsButtons.TabIndex = 2;
            // 
            // tlpBotoesColaboradores
            // 
            tlpBotoesColaboradores.ColumnCount = 9;
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 230F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 201F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 251F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 240F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpBotoesColaboradores.Controls.Add(picCadastrarEnfermeiros, 1, 0);
            tlpBotoesColaboradores.Controls.Add(picCadastrarMedico, 3, 0);
            tlpBotoesColaboradores.Controls.Add(picCadastrarRecepcionista, 5, 0);
            tlpBotoesColaboradores.Controls.Add(picCadastrarColaboradores, 7, 0);
            tlpBotoesColaboradores.Location = new Point(8, 3);
            tlpBotoesColaboradores.Name = "tlpBotoesColaboradores";
            tlpBotoesColaboradores.RowCount = 1;
            tlpBotoesColaboradores.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotoesColaboradores.Size = new Size(100, 28);
            tlpBotoesColaboradores.TabIndex = 2;
            tlpBotoesColaboradores.Visible = false;
            tlpBotoesColaboradores.Paint += tableLayoutPanel1_Paint_2;
            // 
            // picCadastrarEnfermeiros
            // 
            picCadastrarEnfermeiros.Dock = DockStyle.Fill;
            picCadastrarEnfermeiros.Image = Properties.Resources.btnCadastrarEnfermeiro;
            picCadastrarEnfermeiros.Location = new Point(-161, 3);
            picCadastrarEnfermeiros.Name = "picCadastrarEnfermeiros";
            picCadastrarEnfermeiros.Size = new Size(224, 22);
            picCadastrarEnfermeiros.SizeMode = PictureBoxSizeMode.Zoom;
            picCadastrarEnfermeiros.TabIndex = 0;
            picCadastrarEnfermeiros.TabStop = false;
            // 
            // picCadastrarMedico
            // 
            picCadastrarMedico.Dock = DockStyle.Fill;
            picCadastrarMedico.Image = Properties.Resources.btnCadastrarMedico;
            picCadastrarMedico.Location = new Point(-95, 3);
            picCadastrarMedico.Name = "picCadastrarMedico";
            picCadastrarMedico.Size = new Size(195, 22);
            picCadastrarMedico.SizeMode = PictureBoxSizeMode.Zoom;
            picCadastrarMedico.TabIndex = 1;
            picCadastrarMedico.TabStop = false;
            picCadastrarMedico.Click += picCadastrarMedico_Click;
            // 
            // picCadastrarRecepcionista
            // 
            picCadastrarRecepcionista.Dock = DockStyle.Fill;
            picCadastrarRecepcionista.Image = Properties.Resources.btnCadastrarRecepcionista;
            picCadastrarRecepcionista.Location = new Point(-58, 3);
            picCadastrarRecepcionista.Name = "picCadastrarRecepcionista";
            picCadastrarRecepcionista.Size = new Size(245, 22);
            picCadastrarRecepcionista.SizeMode = PictureBoxSizeMode.Zoom;
            picCadastrarRecepcionista.TabIndex = 2;
            picCadastrarRecepcionista.TabStop = false;
            // 
            // picCadastrarColaboradores
            // 
            picCadastrarColaboradores.Dock = DockStyle.Fill;
            picCadastrarColaboradores.Image = Properties.Resources.btnListaColaboradores;
            picCadastrarColaboradores.Location = new Point(29, 3);
            picCadastrarColaboradores.Name = "picCadastrarColaboradores";
            picCadastrarColaboradores.Size = new Size(234, 22);
            picCadastrarColaboradores.SizeMode = PictureBoxSizeMode.Zoom;
            picCadastrarColaboradores.TabIndex = 3;
            picCadastrarColaboradores.TabStop = false;
            // 
            // tlpBotoesPacientes
            // 
            tlpBotoesPacientes.ColumnCount = 5;
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 213F));
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 199F));
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tlpBotoesPacientes.Controls.Add(picCadastrarPaciente, 1, 0);
            tlpBotoesPacientes.Controls.Add(picListaPaciente, 3, 0);
            tlpBotoesPacientes.Location = new Point(274, 0);
            tlpBotoesPacientes.Name = "tlpBotoesPacientes";
            tlpBotoesPacientes.RowCount = 1;
            tlpBotoesPacientes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotoesPacientes.Size = new Size(89, 34);
            tlpBotoesPacientes.TabIndex = 1;
            tlpBotoesPacientes.Visible = false;
            tlpBotoesPacientes.Paint += tableLayoutPanel1_Paint_1;
            // 
            // picCadastrarPaciente
            // 
            picCadastrarPaciente.Dock = DockStyle.Fill;
            picCadastrarPaciente.Image = Properties.Resources.btnCadastrarPaciente;
            picCadastrarPaciente.Location = new Point(-104, 3);
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
            picListaPaciente.Location = new Point(2, 3);
            picListaPaciente.Name = "picListaPaciente";
            picListaPaciente.Size = new Size(193, 28);
            picListaPaciente.SizeMode = PictureBoxSizeMode.Zoom;
            picListaPaciente.TabIndex = 1;
            picListaPaciente.TabStop = false;
            picListaPaciente.Click += picListaPaciente_Click;
            // 
            // tlpBotoesProntuario
            // 
            tlpBotoesProntuario.ColumnCount = 7;
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.2251625F));
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 131F));
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.2251682F));
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 102F));
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.2251682F));
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 147F));
            tlpBotoesProntuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.3245029F));
            tlpBotoesProntuario.Controls.Add(picBtnConsulta, 1, 0);
            tlpBotoesProntuario.Controls.Add(picBtnExame, 3, 0);
            tlpBotoesProntuario.Controls.Add(pctBtnInternacao, 5, 0);
            tlpBotoesProntuario.Location = new Point(782, 3);
            tlpBotoesProntuario.Name = "tlpBotoesProntuario";
            tlpBotoesProntuario.RowCount = 1;
            tlpBotoesProntuario.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotoesProntuario.Size = new Size(93, 34);
            tlpBotoesProntuario.TabIndex = 3;
            tlpBotoesProntuario.Visible = false;
            // 
            // picBtnConsulta
            // 
            picBtnConsulta.BackColor = Color.Transparent;
            picBtnConsulta.BackgroundImage = Properties.Resources.btnConsulta;
            picBtnConsulta.BackgroundImageLayout = ImageLayout.Zoom;
            picBtnConsulta.Dock = DockStyle.Fill;
            picBtnConsulta.Location = new Point(-72, 3);
            picBtnConsulta.Name = "picBtnConsulta";
            picBtnConsulta.Size = new Size(125, 28);
            picBtnConsulta.TabIndex = 3;
            picBtnConsulta.TabStop = false;
            // 
            // picBtnExame
            // 
            picBtnExame.BackColor = Color.Transparent;
            picBtnExame.BackgroundImage = Properties.Resources.btnExame;
            picBtnExame.BackgroundImageLayout = ImageLayout.Zoom;
            picBtnExame.Dock = DockStyle.Fill;
            picBtnExame.Location = new Point(-16, 3);
            picBtnExame.Name = "picBtnExame";
            picBtnExame.Size = new Size(96, 28);
            picBtnExame.TabIndex = 4;
            picBtnExame.TabStop = false;
            // 
            // pctBtnInternacao
            // 
            pctBtnInternacao.BackColor = Color.Transparent;
            pctBtnInternacao.BackgroundImage = Properties.Resources.btnInternacao;
            pctBtnInternacao.BackgroundImageLayout = ImageLayout.Zoom;
            pctBtnInternacao.Dock = DockStyle.Fill;
            pctBtnInternacao.Location = new Point(11, 3);
            pctBtnInternacao.Name = "pctBtnInternacao";
            pctBtnInternacao.Size = new Size(141, 28);
            pctBtnInternacao.TabIndex = 5;
            pctBtnInternacao.TabStop = false;
            // 
            // tlpMenu
            // 
            tlpMenu.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlpMenu.BackColor = Color.FromArgb(225, 255, 255);
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
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
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
            tlpMenu.Size = new Size(1138, 105);
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
            picBtnPaciente.Location = new Point(277, 15);
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
            picInicioMedSys.Location = new Point(531, 15);
            picInicioMedSys.Name = "picInicioMedSys";
            picInicioMedSys.Size = new Size(74, 74);
            picInicioMedSys.SizeMode = PictureBoxSizeMode.Zoom;
            picInicioMedSys.TabIndex = 3;
            picInicioMedSys.TabStop = false;
            picInicioMedSys.MouseEnter += picInicioMedSys_MouseEnter;
            picInicioMedSys.MouseLeave += picInicioMedSys_MouseLeave;
            // 
            // picBtnProntuario
            // 
            picBtnProntuario.Dock = DockStyle.Fill;
            picBtnProntuario.Image = Properties.Resources.btn_prontuario;
            picBtnProntuario.Location = new Point(785, 15);
            picBtnProntuario.Name = "picBtnProntuario";
            picBtnProntuario.Size = new Size(74, 74);
            picBtnProntuario.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnProntuario.TabIndex = 4;
            picBtnProntuario.TabStop = false;
            // 
            // picBtnMedicamento
            // 
            picBtnMedicamento.Dock = DockStyle.Fill;
            picBtnMedicamento.Image = Properties.Resources.btn_medicamento;
            picBtnMedicamento.Location = new Point(1039, 15);
            picBtnMedicamento.Name = "picBtnMedicamento";
            picBtnMedicamento.Size = new Size(74, 74);
            picBtnMedicamento.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnMedicamento.TabIndex = 2;
            picBtnMedicamento.TabStop = false;
            picBtnMedicamento.Click += picBtnMedicamento_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 522);
            Controls.Add(tlpMain);
            Name = "Form1";
            Text = "MedSys";
            WindowState = FormWindowState.Maximized;
            tlpMain.ResumeLayout(false);
            panOptionsButtons.ResumeLayout(false);
            tlpBotoesColaboradores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCadastrarEnfermeiros).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCadastrarMedico).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCadastrarRecepcionista).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCadastrarColaboradores).EndInit();
            tlpBotoesPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCadastrarPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)picListaPaciente).EndInit();
            tlpBotoesProntuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBtnConsulta).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnExame).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctBtnInternacao).EndInit();
            tlpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBtnColaborador).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInicioMedSys).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnProntuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnMedicamento).EndInit();
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
        private PictureBox picCadastrarColaboradores;
        private TableLayoutPanel tlpBotoesProntuario;
        private PictureBox picBtnConsulta;
        private PictureBox picBtnExame;
        private PictureBox pctBtnInternacao;
    }
}
