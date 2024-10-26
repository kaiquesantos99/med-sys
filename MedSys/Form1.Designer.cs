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
            tlpMenu = new TableLayoutPanel();
            picBtnColaborador = new PictureBox();
            tlpBotoesPacientes = new TableLayoutPanel();
            picListaPaciente = new PictureBox();
            picCadastrarPaciente = new PictureBox();
            picBtnPaciente = new PictureBox();
            picBtnMedicamento = new PictureBox();
            picInicioMedSys = new PictureBox();
            pictureBox1 = new PictureBox();
            tlpMain.SuspendLayout();
            tlpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBtnColaborador).BeginInit();
            tlpBotoesPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picListaPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCadastrarPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnPaciente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBtnMedicamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picInicioMedSys).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 1;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.Controls.Add(tlpMenu, 0, 0);
            tlpMain.Controls.Add(tlpBotoesPacientes, 0, 1);
            tlpMain.Location = new Point(12, 11);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 3;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 61.34454F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 38.65546F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 306F));
            tlpMain.Size = new Size(776, 426);
            tlpMain.TabIndex = 0;
            // 
            // tlpMenu
            // 
            tlpMenu.ColumnCount = 5;
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpMenu.Controls.Add(pictureBox1, 3, 0);
            tlpMenu.Controls.Add(picBtnMedicamento, 4, 0);
            tlpMenu.Controls.Add(picBtnColaborador, 0, 0);
            tlpMenu.Controls.Add(picBtnPaciente, 1, 0);
            tlpMenu.Controls.Add(picInicioMedSys, 2, 0);
            tlpMenu.Dock = DockStyle.Fill;
            tlpMenu.Location = new Point(3, 3);
            tlpMenu.Name = "tlpMenu";
            tlpMenu.Padding = new Padding(20, 0, 20, 0);
            tlpMenu.RowCount = 1;
            tlpMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMenu.Size = new Size(770, 67);
            tlpMenu.TabIndex = 0;
            // 
            // picBtnColaborador
            // 
            picBtnColaborador.Image = Properties.Resources.btn_colaborador2;
            picBtnColaborador.Location = new Point(58, 3);
            picBtnColaborador.Margin = new Padding(38, 3, 3, 3);
            picBtnColaborador.Name = "picBtnColaborador";
            picBtnColaborador.Size = new Size(52, 52);
            picBtnColaborador.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnColaborador.TabIndex = 0;
            picBtnColaborador.TabStop = false;
            // 
            // tlpBotoesPacientes
            // 
            tlpBotoesPacientes.ColumnCount = 4;
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.3248749F));
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.6751251F));
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 236F));
            tlpBotoesPacientes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 146F));
            tlpBotoesPacientes.Controls.Add(picListaPaciente, 2, 0);
            tlpBotoesPacientes.Controls.Add(picCadastrarPaciente, 1, 0);
            tlpBotoesPacientes.Dock = DockStyle.Fill;
            tlpBotoesPacientes.Location = new Point(3, 76);
            tlpBotoesPacientes.Name = "tlpBotoesPacientes";
            tlpBotoesPacientes.RowCount = 1;
            tlpBotoesPacientes.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpBotoesPacientes.Size = new Size(770, 40);
            tlpBotoesPacientes.TabIndex = 1;
            tlpBotoesPacientes.Paint += tableLayoutPanel1_Paint_1;
            // 
            // picListaPaciente
            // 
            picListaPaciente.Location = new Point(390, 3);
            picListaPaciente.Name = "picListaPaciente";
            picListaPaciente.Size = new Size(183, 20);
            picListaPaciente.TabIndex = 1;
            picListaPaciente.TabStop = false;
            // 
            // picCadastrarPaciente
            // 
            picCadastrarPaciente.Location = new Point(151, 3);
            picCadastrarPaciente.Name = "picCadastrarPaciente";
            picCadastrarPaciente.Size = new Size(183, 20);
            picCadastrarPaciente.TabIndex = 0;
            picCadastrarPaciente.TabStop = false;
            // 
            // picBtnPaciente
            // 
            picBtnPaciente.Image = Properties.Resources.btn_paciente;
            picBtnPaciente.Location = new Point(214, 3);
            picBtnPaciente.Margin = new Padding(48, 3, 3, 3);
            picBtnPaciente.Name = "picBtnPaciente";
            picBtnPaciente.Size = new Size(52, 52);
            picBtnPaciente.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnPaciente.TabIndex = 1;
            picBtnPaciente.TabStop = false;
            // 
            // picBtnMedicamento
            // 
            picBtnMedicamento.Dock = DockStyle.Right;
            picBtnMedicamento.Image = Properties.Resources.btn_medicamento;
            picBtnMedicamento.Location = new Point(660, 3);
            picBtnMedicamento.Margin = new Padding(3, 3, 38, 3);
            picBtnMedicamento.Name = "picBtnMedicamento";
            picBtnMedicamento.Size = new Size(52, 61);
            picBtnMedicamento.SizeMode = PictureBoxSizeMode.Zoom;
            picBtnMedicamento.TabIndex = 2;
            picBtnMedicamento.TabStop = false;
            // 
            // picInicioMedSys
            // 
            picInicioMedSys.Image = Properties.Resources.medsys_logo;
            picInicioMedSys.Location = new Point(360, 3);
            picInicioMedSys.Margin = new Padding(48, 3, 3, 3);
            picInicioMedSys.Name = "picInicioMedSys";
            picInicioMedSys.Size = new Size(52, 61);
            picInicioMedSys.SizeMode = PictureBoxSizeMode.Zoom;
            picInicioMedSys.TabIndex = 3;
            picInicioMedSys.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.btn_prontuario;
            pictureBox1.Location = new Point(506, 3);
            pictureBox1.Margin = new Padding(48, 3, 3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
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
            tlpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBtnColaborador).EndInit();
            tlpBotoesPacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picListaPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCadastrarPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnPaciente).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBtnMedicamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)picInicioMedSys).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpMenu;
        private PictureBox picBtnColaborador;
        private TableLayoutPanel tlpBotoesPacientes;
        private PictureBox picCadastrarPaciente;
        private PictureBox picListaPaciente;
        private PictureBox picBtnMedicamento;
        private PictureBox picBtnPaciente;
        private PictureBox picInicioMedSys;
        private PictureBox pictureBox1;
    }
}
