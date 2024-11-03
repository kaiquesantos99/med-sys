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
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.Controls.Add(panOptionsButtons, 0, 1);
            tlpMain.Controls.Add(tlpMenu, 0, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 61.34454F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 38.65546F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 306F));
            tlpMain.Size = new Size(800, 450);
            tlpMain.TabIndex = 0;
            tlpMain.Paint += tlpMain_Paint;
            // 
            // panOptionsButtons
            // 
            panOptionsButtons.Controls.Add(tlpBotoesColaboradores);
            panOptionsButtons.Controls.Add(tlpBotoesPacientes);
            panOptionsButtons.Dock = DockStyle.Fill;
            panOptionsButtons.Location = new Point(3, 91);
            panOptionsButtons.Name = "panOptionsButtons";
            panOptionsButtons.Size = new Size(794, 49);
            panOptionsButtons.TabIndex = 2;
            // 
            // tlpBotoesColaboradores
            // 
            tlpBotoesColaboradores.ColumnCount = 9;
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.75778055F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5527744F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.75778055F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5527744F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.75778055F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5527744F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.75778055F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5527744F));
            tlpBotoesColaboradores.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.75778055F));
            tlpBotoesColaboradores.Controls.Add(picCadastrarEnfermeiros, 1, 0);
            tlpBotoesColaboradores.Controls.Add(picCadastrarMedico, 3, 0);
            tlpBotoesColaboradores.Controls.Add(picCadastrarRecepcionista, 5, 0);
            tlpBotoesColaboradores.Controls.Add(picCadastrarColaboradores, 7, 0);
            tlpBotoesColaboradores.Dock = DockStyle.Fill;
            tlpBotoesColaboradores.Location = new Point(0, 0);
            tlpBotoesColaboradores.Name = "tlpBotoesColaboradores";
            tlpBotoesColaboradores.RowCount = 1;
            tlpBotoesColaboradores.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotoesColaboradores.Size = new Size(794, 49);
            tlpBotoesColaboradores.TabIndex = 2;
            tlpBotoesColaboradores.Visible = false;
            tlpBotoesColaboradores.Paint += tableLayoutPanel1_Paint_2;
            // 
            // picCadastrarEnfermeiros
            // 
            picCadastrarEnfermeiros.Dock = DockStyle.Fill;
            picCadastrarEnfermeiros.Image = Properties.Resources.btnCadastrarEnfermeiro;
            picCadastrarEnfermeiros.Location = new Point(24, 3);
            picCadastrarEnfermeiros.Name = "picCadastrarEnfermeiros";
            picCadastrarEnfermeiros.Size = new Size(165, 43);
            picCadastrarEnfermeiros.SizeMode = PictureBoxSizeMode.Zoom;
            picCadastrarEnfermeiros.TabIndex = 0;
            picCadastrarEnfermeiros.TabStop = false;
            // 
            // picCadastrarMedico
            // 
            picCadastrarMedico.Dock = DockStyle.Fill;
            picCadastrarMedico.Image = Properties.Resources.btnCadastrarMedico;
            picCadastrarMedico.Location = new Point(216, 3);
            picCadastrarMedico.Name = "picCadastrarMedico";
            picCadastrarMedico.Size = new Size(165, 43);
            picCadastrarMedico.SizeMode = PictureBoxSizeMode.Zoom;
            picCadastrarMedico.TabIndex = 1;
            picCadastrarMedico.TabStop = false;
            picCadastrarMedico.Click += picCadastrarMedico_Click;
            // 
            // picCadastrarRecepcionista
            // 
            picCadastrarRecepcionista.Dock = DockStyle.Fill;
            picCadastrarRecepcionista.Image = Properties.Resources.btnCadastrarRecepcionista;
            picCadastrarRecepcionista.Location = new Point(408, 3);
            picCadastrarRecepcionista.Name = "picCadastrarRecepcionista";
            picCadastrarRecepcionista.Size = new Size(165, 43);
            picCadastrarRecepcionista.SizeMode = PictureBoxSizeMode.Zoom;
            picCadastrarRecepcionista.TabIndex = 2;
            picCadastrarRecepcionista.TabStop = false;
            // 
            // picCadastrarColaboradores
            // 
            picCadastrarColaboradores.Dock = DockStyle.Fill;
            picCadastrarColaboradores.Image = Properties.Resources.btnListaColaboradores;
            picCadastrarColaboradores.Location = new Point(600, 3);
            picCadastrarColaboradores.Name = "picCadastrarColaboradores";
            picCadastrarColaboradores.Size = new Size(165, 43);
            picCadastrarColaboradores.SizeMode = PictureBoxSizeMode.Zoom;
            picCadastrarColaboradores.TabIndex = 3;
            picCadastrarColaboradores.TabStop = false;
            // 
            // tlpBotoesPacientes
            // 
            tlpBotoesPacientes.ColumnCount = 5;
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpBotoesPacientes.Controls.Add(picCadastrarPaciente, 1, 0);
            tlpBotoesPacientes.Controls.Add(picListaPaciente, 3, 0);
            tlpBotoesPacientes.Location = new Point(246, 13);
            tlpBotoesPacientes.Name = "tlpBotoesPacientes";
            tlpBotoesPacientes.RowCount = 1;
            tlpBotoesPacientes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpBotoesPacientes.Size = new Size(24, 20);
            tlpBotoesPacientes.TabIndex = 1;
            tlpBotoesPacientes.Visible = false;
            tlpBotoesPacientes.Paint += tableLayoutPanel1_Paint_1;
            // 
            // picCadastrarPaciente
            // 
            picCadastrarPaciente.Dock = DockStyle.Fill;
            picCadastrarPaciente.Image = Properties.Resources.btnCadastrarPaciente;
            picCadastrarPaciente.Location = new Point(7, 3);
            picCadastrarPaciente.Name = "picCadastrarPaciente";
            picCadastrarPaciente.Size = new Size(1, 14);
            picCadastrarPaciente.SizeMode = PictureBoxSizeMode.Zoom;
            picCadastrarPaciente.TabIndex = 0;
            picCadastrarPaciente.TabStop = false;
            picCadastrarPaciente.Click += picCadastrarPaciente_Click;
            // 
            // picListaPaciente
            // 
            picListaPaciente.Dock = DockStyle.Fill;
            picListaPaciente.Image = Properties.Resources.btnListaPacientes;
            picListaPaciente.Location = new Point(15, 3);
            picListaPaciente.Name = "picListaPaciente";
            picListaPaciente.Size = new Size(1, 14);
            picListaPaciente.SizeMode = PictureBoxSizeMode.Zoom;
            picListaPaciente.TabIndex = 1;
            picListaPaciente.TabStop = false;
            picListaPaciente.Click += picListaPaciente_Click;
            // 
            // tlpMenu
            // 
            tlpMenu.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpMenu.ColumnCount = 11;
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.090909F));
            tlpMenu.Controls.Add(picBtnColaborador, 1, 0);
            tlpMenu.Controls.Add(picBtnPaciente, 3, 0);
            tlpMenu.Controls.Add(picInicioMedSys, 5, 0);
            tlpMenu.Controls.Add(picBtnProntuario, 7, 0);
            tlpMenu.Controls.Add(picBtnMedicamento, 9, 0);
            tlpMenu.Dock = DockStyle.Fill;
            tlpMenu.Location = new Point(3, 3);
            tlpMenu.Name = "tlpMenu";
            tlpMenu.Padding = new Padding(20, 0, 20, 0);
            tlpMenu.RowCount = 1;
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMenu.Size = new Size(794, 82);
            tlpMenu.TabIndex = 0;
            tlpMenu.Paint += tlpMenu_Paint;
            // 
            // picBtnColaborador
            // 
            picBtnColaborador.Image = Properties.Resources.btn_colaborador2;
            picBtnColaborador.Location = new Point(92, 4);
            picBtnColaborador.Name = "picBtnColaborador";
            picBtnColaborador.Size = new Size(61, 74);
            picBtnColaborador.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnColaborador.TabIndex = 0;
            picBtnColaborador.TabStop = false;
            picBtnColaborador.Click += picBtnColaborador_Click;
            // 
            // picBtnPaciente
            // 
            picBtnPaciente.Image = Properties.Resources.btn_paciente;
            picBtnPaciente.Location = new Point(228, 4);
            picBtnPaciente.Name = "picBtnPaciente";
            picBtnPaciente.Size = new Size(61, 74);
            picBtnPaciente.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnPaciente.TabIndex = 1;
            picBtnPaciente.TabStop = false;
            picBtnPaciente.Click += picBtnPaciente_Click;
            // 
            // picInicioMedSys
            // 
            picInicioMedSys.Image = Properties.Resources.medsys_logo;
            picInicioMedSys.Location = new Point(364, 4);
            picInicioMedSys.Name = "picInicioMedSys";
            picInicioMedSys.Size = new Size(61, 74);
            picInicioMedSys.SizeMode = PictureBoxSizeMode.Zoom;
            picInicioMedSys.TabIndex = 3;
            picInicioMedSys.TabStop = false;
            picInicioMedSys.MouseEnter += picInicioMedSys_MouseEnter;
            picInicioMedSys.MouseLeave += picInicioMedSys_MouseLeave;
            // 
            // picBtnProntuario
            // 
            picBtnProntuario.Image = Properties.Resources.btn_prontuario;
            picBtnProntuario.Location = new Point(500, 4);
            picBtnProntuario.Name = "picBtnProntuario";
            picBtnProntuario.Size = new Size(61, 74);
            picBtnProntuario.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnProntuario.TabIndex = 4;
            picBtnProntuario.TabStop = false;
            // 
            // picBtnMedicamento
            // 
            picBtnMedicamento.Image = Properties.Resources.btn_medicamento;
            picBtnMedicamento.Location = new Point(636, 4);
            picBtnMedicamento.Name = "picBtnMedicamento";
            picBtnMedicamento.Size = new Size(61, 74);
            picBtnMedicamento.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnMedicamento.TabIndex = 2;
            picBtnMedicamento.TabStop = false;
            picBtnMedicamento.Click += picBtnMedicamento_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
