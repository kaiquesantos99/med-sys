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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCadastrarMedicamentos));
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
            lblTipo.Location = new Point(207, 88);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(166, 15);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "TIPO DE MEDICAMENTO";
            // 
            // cmbTipo
            // 
            cmbTipo.BackColor = Color.FromArgb(223, 233, 245);
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(395, 86);
            cmbTipo.Margin = new Padding(3, 2, 3, 2);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(195, 23);
            cmbTipo.TabIndex = 1;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(187, 210, 236);
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(208, 118);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 2;
            label1.Text = "MEDICAMENTO";
            // 
            // txtMedicamento
            // 
            txtMedicamento.BackColor = Color.FromArgb(223, 233, 245);
            txtMedicamento.Location = new Point(328, 116);
            txtMedicamento.Margin = new Padding(3, 2, 3, 2);
            txtMedicamento.Multiline = true;
            txtMedicamento.Name = "txtMedicamento";
            txtMedicamento.Size = new Size(261, 19);
            txtMedicamento.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.estoque;
            pictureBox1.Location = new Point(40, 77);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 94);
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
            btnCadastrarMedicamento.Location = new Point(207, 196);
            btnCadastrarMedicamento.Margin = new Padding(3, 2, 3, 2);
            btnCadastrarMedicamento.Name = "btnCadastrarMedicamento";
            btnCadastrarMedicamento.Size = new Size(228, 65);
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
            lblQuantidade.Location = new Point(208, 150);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(94, 15);
            lblQuantidade.TabIndex = 6;
            lblQuantidade.Text = "QUANTIDADE";
            // 
            // txtQuantidade
            // 
            txtQuantidade.BackColor = Color.FromArgb(223, 233, 245);
            txtQuantidade.Location = new Point(314, 147);
            txtQuantidade.Margin = new Padding(3, 2, 3, 2);
            txtQuantidade.Multiline = true;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(275, 19);
            txtQuantidade.TabIndex = 7;
            // 
            // ViewCadastrarMedicamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 338);
            Controls.Add(txtQuantidade);
            Controls.Add(lblQuantidade);
            Controls.Add(btnCadastrarMedicamento);
            Controls.Add(pictureBox1);
            Controls.Add(txtMedicamento);
            Controls.Add(label1);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewCadastrarMedicamentos";
            Text = "MedSys | Cadastrar Medicamento";
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