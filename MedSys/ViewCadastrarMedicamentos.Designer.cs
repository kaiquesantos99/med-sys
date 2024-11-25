namespace MedSys
{
    partial class ViewCadastrarMedicamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            label1 = new Label();
            txtMedicamento = new TextBox();
            pictureBox1 = new PictureBox();
            btnCadastrarMedicamento = new Button();
            lblQuantidade = new Label();
            txtQuantidade = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.BackColor = Color.FromArgb(187, 210, 236);
            lblTipo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipo.Location = new Point(237, 118);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(202, 18);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "TIPO DE MEDICAMENTO";
            // 
            // cmbTipo
            // 
            cmbTipo.BackColor = Color.FromArgb(223, 233, 245);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(451, 114);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(222, 28);
            cmbTipo.TabIndex = 1;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(187, 210, 236);
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 158);
            label1.Name = "label1";
            label1.Size = new Size(131, 18);
            label1.TabIndex = 2;
            label1.Text = "MEDICAMENTO";
            // 
            // txtMedicamento
            // 
            txtMedicamento.BackColor = Color.FromArgb(223, 233, 245);
            txtMedicamento.Location = new Point(375, 155);
            txtMedicamento.Multiline = true;
            txtMedicamento.Name = "txtMedicamento";
            txtMedicamento.Size = new Size(298, 24);
            txtMedicamento.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.estoque;
            pictureBox1.Location = new Point(46, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnCadastrarMedicamento
            // 
            btnCadastrarMedicamento.BackgroundImage = Properties.Resources.cadastrarbutton6;
            btnCadastrarMedicamento.BackgroundImageLayout = ImageLayout.Zoom;
            btnCadastrarMedicamento.FlatAppearance.BorderSize = 0;
            btnCadastrarMedicamento.FlatStyle = FlatStyle.Flat;
            btnCadastrarMedicamento.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarMedicamento.Location = new Point(237, 262);
            btnCadastrarMedicamento.Name = "btnCadastrarMedicamento";
            btnCadastrarMedicamento.Size = new Size(260, 87);
            btnCadastrarMedicamento.TabIndex = 5;
            btnCadastrarMedicamento.Text = "CADASTRAR MEDICAMENTO";
            btnCadastrarMedicamento.UseVisualStyleBackColor = true;
            btnCadastrarMedicamento.Click += btnCadastrarMedicamento_Click;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.BackColor = Color.FromArgb(187, 210, 236);
            lblQuantidade.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantidade.Location = new Point(238, 200);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(114, 18);
            lblQuantidade.TabIndex = 6;
            lblQuantidade.Text = "QUANTIDADE";
            // 
            // txtQuantidade
            // 
            txtQuantidade.BackColor = Color.FromArgb(223, 233, 245);
            txtQuantidade.Location = new Point(359, 196);
            txtQuantidade.Multiline = true;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(314, 24);
            txtQuantidade.TabIndex = 7;
            // 
            // ViewCadastrarMedicamentos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 450);
            Controls.Add(txtQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(btnCadastrarMedicamento);
            Controls.Add(pictureBox1);
            Controls.Add(txtMedicamento);
            Controls.Add(label1);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Name = "ViewCadastrarMedicamentos";
            Text = "ViewCadastrarMedicamentos";
            Load += ViewCadastrarMedicamentos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipo;
        private ComboBox cmbTipo;
        private Label label1;
        private TextBox txtMedicamento;
        private PictureBox pictureBox1;
        private Button btnCadastrarMedicamento;
        private Label lblQuantidade;
        private TextBox txtQuantidade;
    }
}