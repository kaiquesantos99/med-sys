namespace MedSys
{
    partial class ViewCadastrarPaciente
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
            pictureBox1 = new PictureBox();
            lblNomeP = new Label();
            txtNomeP = new TextBox();
            lblNascimentoP = new Label();
            txtNascimentoP = new TextBox();
            lblCPFP = new Label();
            txtCPFP = new TextBox();
            lblRGP = new Label();
            txtRGP = new TextBox();
            lblCarteirinhaP = new Label();
            txtCarteirinhaP = new TextBox();
            lblConvenioP = new Label();
            txtConvenioP = new TextBox();
            lblCEPP = new Label();
            txtCEPP = new TextBox();
            lblLogradouroP = new Label();
            txtLogradouroP = new TextBox();
            lblNumP = new Label();
            txtNumP = new TextBox();
            lblUFP = new Label();
            txtUFP = new TextBox();
            lblComplementoP = new Label();
            txtComplementoP = new TextBox();
            lblBairroP = new Label();
            lblCidadeP = new Label();
            txtBairroP = new TextBox();
            txtCidadeP = new TextBox();
            lblTelefoneP = new Label();
            lblEmergenciaP = new Label();
            lblAcompanhanteP = new Label();
            txtTelefoneP = new TextBox();
            txtTelefone_2 = new TextBox();
            txtAcompanhanteP = new TextBox();
            lblAlturaP = new Label();
            lblPesoP = new Label();
            txtPesoP = new TextBox();
            txtAlturaP = new TextBox();
            lblObservacaoP = new Label();
            txtObservacoesP = new TextBox();
            btnGravar = new Button();
            lblSexo = new Label();
            txtSexoP = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.paciente;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblNomeP
            // 
            lblNomeP.AutoSize = true;
            lblNomeP.BackColor = Color.FromArgb(187, 210, 236);
            lblNomeP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeP.Location = new Point(154, 39);
            lblNomeP.Name = "lblNomeP";
            lblNomeP.Size = new Size(53, 18);
            lblNomeP.TabIndex = 1;
            lblNomeP.Text = "Nome";
            // 
            // txtNomeP
            // 
            txtNomeP.BackColor = Color.FromArgb(223, 233, 245);
            txtNomeP.Location = new Point(210, 35);
            txtNomeP.MaxLength = 200;
            txtNomeP.Multiline = true;
            txtNomeP.Name = "txtNomeP";
            txtNomeP.Size = new Size(333, 23);
            txtNomeP.TabIndex = 2;
            // 
            // lblNascimentoP
            // 
            lblNascimentoP.AutoSize = true;
            lblNascimentoP.BackColor = Color.FromArgb(187, 210, 236);
            lblNascimentoP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNascimentoP.Location = new Point(154, 75);
            lblNascimentoP.Name = "lblNascimentoP";
            lblNascimentoP.Size = new Size(161, 18);
            lblNascimentoP.TabIndex = 3;
            lblNascimentoP.Text = "Data de Nascimento";
            // 
            // txtNascimentoP
            // 
            txtNascimentoP.BackColor = Color.FromArgb(223, 233, 245);
            txtNascimentoP.Location = new Point(322, 72);
            txtNascimentoP.Multiline = true;
            txtNascimentoP.Name = "txtNascimentoP";
            txtNascimentoP.Size = new Size(137, 23);
            txtNascimentoP.TabIndex = 4;
            txtNascimentoP.TextChanged += textBox1_TextChanged;
            // 
            // lblCPFP
            // 
            lblCPFP.AutoSize = true;
            lblCPFP.BackColor = Color.FromArgb(187, 210, 236);
            lblCPFP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCPFP.Location = new Point(550, 37);
            lblCPFP.Name = "lblCPFP";
            lblCPFP.Size = new Size(41, 18);
            lblCPFP.TabIndex = 5;
            lblCPFP.Text = "CPF";
            // 
            // txtCPFP
            // 
            txtCPFP.BackColor = Color.FromArgb(223, 233, 245);
            txtCPFP.Location = new Point(596, 34);
            txtCPFP.MaxLength = 14;
            txtCPFP.Multiline = true;
            txtCPFP.Name = "txtCPFP";
            txtCPFP.Size = new Size(155, 23);
            txtCPFP.TabIndex = 6;
            // 
            // lblRGP
            // 
            lblRGP.AutoSize = true;
            lblRGP.BackColor = Color.FromArgb(187, 210, 236);
            lblRGP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRGP.Location = new Point(468, 76);
            lblRGP.Name = "lblRGP";
            lblRGP.Size = new Size(33, 18);
            lblRGP.TabIndex = 7;
            lblRGP.Text = "RG";
            // 
            // txtRGP
            // 
            txtRGP.BackColor = Color.FromArgb(223, 233, 245);
            txtRGP.Location = new Point(507, 73);
            txtRGP.MaxLength = 10;
            txtRGP.Multiline = true;
            txtRGP.Name = "txtRGP";
            txtRGP.Size = new Size(137, 23);
            txtRGP.TabIndex = 8;
            // 
            // lblCarteirinhaP
            // 
            lblCarteirinhaP.AutoSize = true;
            lblCarteirinhaP.BackColor = Color.FromArgb(187, 210, 236);
            lblCarteirinhaP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarteirinhaP.Location = new Point(154, 108);
            lblCarteirinhaP.Name = "lblCarteirinhaP";
            lblCarteirinhaP.Size = new Size(90, 18);
            lblCarteirinhaP.TabIndex = 9;
            lblCarteirinhaP.Text = "Carteirinha";
            // 
            // txtCarteirinhaP
            // 
            txtCarteirinhaP.BackColor = Color.FromArgb(223, 233, 245);
            txtCarteirinhaP.Location = new Point(249, 105);
            txtCarteirinhaP.MaxLength = 23;
            txtCarteirinhaP.Multiline = true;
            txtCarteirinhaP.Name = "txtCarteirinhaP";
            txtCarteirinhaP.Size = new Size(252, 23);
            txtCarteirinhaP.TabIndex = 10;
            // 
            // lblConvenioP
            // 
            lblConvenioP.AutoSize = true;
            lblConvenioP.BackColor = Color.FromArgb(187, 210, 236);
            lblConvenioP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConvenioP.Location = new Point(506, 109);
            lblConvenioP.Name = "lblConvenioP";
            lblConvenioP.Size = new Size(79, 18);
            lblConvenioP.TabIndex = 11;
            lblConvenioP.Text = "Convênio";
            // 
            // txtConvenioP
            // 
            txtConvenioP.BackColor = Color.FromArgb(223, 233, 245);
            txtConvenioP.Location = new Point(589, 106);
            txtConvenioP.MaxLength = 50;
            txtConvenioP.Multiline = true;
            txtConvenioP.Name = "txtConvenioP";
            txtConvenioP.Size = new Size(162, 23);
            txtConvenioP.TabIndex = 12;
            // 
            // lblCEPP
            // 
            lblCEPP.AutoSize = true;
            lblCEPP.BackColor = Color.FromArgb(187, 210, 236);
            lblCEPP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCEPP.Location = new Point(58, 162);
            lblCEPP.Name = "lblCEPP";
            lblCEPP.Size = new Size(42, 18);
            lblCEPP.TabIndex = 13;
            lblCEPP.Text = "CEP";
            // 
            // txtCEPP
            // 
            txtCEPP.BackColor = Color.FromArgb(223, 233, 245);
            txtCEPP.Location = new Point(105, 159);
            txtCEPP.MaxLength = 9;
            txtCEPP.Multiline = true;
            txtCEPP.Name = "txtCEPP";
            txtCEPP.Size = new Size(128, 23);
            txtCEPP.TabIndex = 14;
            // 
            // lblLogradouroP
            // 
            lblLogradouroP.AutoSize = true;
            lblLogradouroP.BackColor = Color.FromArgb(187, 210, 236);
            lblLogradouroP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogradouroP.Location = new Point(243, 162);
            lblLogradouroP.Name = "lblLogradouroP";
            lblLogradouroP.Size = new Size(95, 18);
            lblLogradouroP.TabIndex = 15;
            lblLogradouroP.Text = "Logradouro";
            // 
            // txtLogradouroP
            // 
            txtLogradouroP.BackColor = Color.FromArgb(223, 233, 245);
            txtLogradouroP.Location = new Point(346, 158);
            txtLogradouroP.MaxLength = 200;
            txtLogradouroP.Multiline = true;
            txtLogradouroP.Name = "txtLogradouroP";
            txtLogradouroP.Size = new Size(202, 23);
            txtLogradouroP.TabIndex = 16;
            // 
            // lblNumP
            // 
            lblNumP.AutoSize = true;
            lblNumP.BackColor = Color.FromArgb(187, 210, 236);
            lblNumP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumP.Location = new Point(556, 161);
            lblNumP.Name = "lblNumP";
            lblNumP.Size = new Size(26, 18);
            lblNumP.TabIndex = 17;
            lblNumP.Text = "Nº";
            // 
            // txtNumP
            // 
            txtNumP.BackColor = Color.FromArgb(223, 233, 245);
            txtNumP.Location = new Point(589, 158);
            txtNumP.Multiline = true;
            txtNumP.Name = "txtNumP";
            txtNumP.Size = new Size(58, 23);
            txtNumP.TabIndex = 18;
            // 
            // lblUFP
            // 
            lblUFP.AutoSize = true;
            lblUFP.BackColor = Color.FromArgb(187, 210, 236);
            lblUFP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUFP.Location = new Point(656, 161);
            lblUFP.Name = "lblUFP";
            lblUFP.Size = new Size(30, 18);
            lblUFP.TabIndex = 19;
            lblUFP.Text = "UF";
            // 
            // txtUFP
            // 
            txtUFP.BackColor = Color.FromArgb(223, 233, 245);
            txtUFP.Location = new Point(693, 158);
            txtUFP.MaxLength = 2;
            txtUFP.Multiline = true;
            txtUFP.Name = "txtUFP";
            txtUFP.Size = new Size(40, 23);
            txtUFP.TabIndex = 20;
            // 
            // lblComplementoP
            // 
            lblComplementoP.AutoSize = true;
            lblComplementoP.BackColor = Color.FromArgb(187, 210, 236);
            lblComplementoP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComplementoP.Location = new Point(58, 198);
            lblComplementoP.Name = "lblComplementoP";
            lblComplementoP.Size = new Size(113, 18);
            lblComplementoP.TabIndex = 21;
            lblComplementoP.Text = "Complemento";
            // 
            // txtComplementoP
            // 
            txtComplementoP.BackColor = Color.FromArgb(223, 233, 245);
            txtComplementoP.Location = new Point(174, 195);
            txtComplementoP.MaxLength = 100;
            txtComplementoP.Multiline = true;
            txtComplementoP.Name = "txtComplementoP";
            txtComplementoP.Size = new Size(164, 23);
            txtComplementoP.TabIndex = 22;
            // 
            // lblBairroP
            // 
            lblBairroP.AutoSize = true;
            lblBairroP.BackColor = Color.FromArgb(187, 210, 236);
            lblBairroP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBairroP.Location = new Point(345, 198);
            lblBairroP.Name = "lblBairroP";
            lblBairroP.Size = new Size(54, 18);
            lblBairroP.TabIndex = 23;
            lblBairroP.Text = "Bairro";
            // 
            // lblCidadeP
            // 
            lblCidadeP.AutoSize = true;
            lblCidadeP.BackColor = Color.FromArgb(187, 210, 236);
            lblCidadeP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCidadeP.Location = new Point(538, 200);
            lblCidadeP.Name = "lblCidadeP";
            lblCidadeP.Size = new Size(60, 18);
            lblCidadeP.TabIndex = 24;
            lblCidadeP.Text = "Cidade";
            // 
            // txtBairroP
            // 
            txtBairroP.BackColor = Color.FromArgb(223, 233, 245);
            txtBairroP.Location = new Point(403, 196);
            txtBairroP.MaxLength = 100;
            txtBairroP.Multiline = true;
            txtBairroP.Name = "txtBairroP";
            txtBairroP.Size = new Size(129, 23);
            txtBairroP.TabIndex = 25;
            // 
            // txtCidadeP
            // 
            txtCidadeP.BackColor = Color.FromArgb(223, 233, 245);
            txtCidadeP.Location = new Point(604, 197);
            txtCidadeP.MaxLength = 100;
            txtCidadeP.Multiline = true;
            txtCidadeP.Name = "txtCidadeP";
            txtCidadeP.Size = new Size(129, 23);
            txtCidadeP.TabIndex = 26;
            // 
            // lblTelefoneP
            // 
            lblTelefoneP.AutoSize = true;
            lblTelefoneP.BackColor = Color.FromArgb(187, 210, 236);
            lblTelefoneP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefoneP.Location = new Point(119, 240);
            lblTelefoneP.Name = "lblTelefoneP";
            lblTelefoneP.Size = new Size(73, 18);
            lblTelefoneP.TabIndex = 27;
            lblTelefoneP.Text = "Telefone";
            // 
            // lblEmergenciaP
            // 
            lblEmergenciaP.AutoSize = true;
            lblEmergenciaP.BackColor = Color.FromArgb(187, 210, 236);
            lblEmergenciaP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmergenciaP.Location = new Point(350, 241);
            lblEmergenciaP.Name = "lblEmergenciaP";
            lblEmergenciaP.Size = new Size(190, 18);
            lblEmergenciaP.TabIndex = 28;
            lblEmergenciaP.Text = "Telefone de Emergência";
            // 
            // lblAcompanhanteP
            // 
            lblAcompanhanteP.AutoSize = true;
            lblAcompanhanteP.BackColor = Color.FromArgb(187, 210, 236);
            lblAcompanhanteP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcompanhanteP.Location = new Point(58, 290);
            lblAcompanhanteP.Name = "lblAcompanhanteP";
            lblAcompanhanteP.Size = new Size(119, 18);
            lblAcompanhanteP.TabIndex = 29;
            lblAcompanhanteP.Text = "Acompanhante";
            // 
            // txtTelefoneP
            // 
            txtTelefoneP.BackColor = Color.FromArgb(223, 233, 245);
            txtTelefoneP.Location = new Point(200, 237);
            txtTelefoneP.MaxLength = 16;
            txtTelefoneP.Multiline = true;
            txtTelefoneP.Name = "txtTelefoneP";
            txtTelefoneP.Size = new Size(137, 23);
            txtTelefoneP.TabIndex = 30;
            // 
            // txtTelefone_2
            // 
            txtTelefone_2.BackColor = Color.FromArgb(223, 233, 245);
            txtTelefone_2.Location = new Point(548, 238);
            txtTelefone_2.MaxLength = 16;
            txtTelefone_2.Multiline = true;
            txtTelefone_2.Name = "txtTelefone_2";
            txtTelefone_2.Size = new Size(137, 23);
            txtTelefone_2.TabIndex = 31;
            // 
            // txtAcompanhanteP
            // 
            txtAcompanhanteP.BackColor = Color.FromArgb(223, 233, 245);
            txtAcompanhanteP.Location = new Point(183, 275);
            txtAcompanhanteP.MaxLength = 200;
            txtAcompanhanteP.Multiline = true;
            txtAcompanhanteP.Name = "txtAcompanhanteP";
            txtAcompanhanteP.Size = new Size(550, 46);
            txtAcompanhanteP.TabIndex = 32;
            // 
            // lblAlturaP
            // 
            lblAlturaP.AutoSize = true;
            lblAlturaP.BackColor = Color.FromArgb(187, 210, 236);
            lblAlturaP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlturaP.Location = new Point(58, 360);
            lblAlturaP.Name = "lblAlturaP";
            lblAlturaP.Size = new Size(51, 18);
            lblAlturaP.TabIndex = 33;
            lblAlturaP.Text = "Altura";
            // 
            // lblPesoP
            // 
            lblPesoP.AutoSize = true;
            lblPesoP.BackColor = Color.FromArgb(187, 210, 236);
            lblPesoP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPesoP.Location = new Point(58, 331);
            lblPesoP.Name = "lblPesoP";
            lblPesoP.Size = new Size(47, 18);
            lblPesoP.TabIndex = 34;
            lblPesoP.Text = "Peso";
            // 
            // txtPesoP
            // 
            txtPesoP.BackColor = Color.FromArgb(223, 233, 245);
            txtPesoP.Location = new Point(112, 328);
            txtPesoP.Multiline = true;
            txtPesoP.Name = "txtPesoP";
            txtPesoP.Size = new Size(95, 23);
            txtPesoP.TabIndex = 35;
            // 
            // txtAlturaP
            // 
            txtAlturaP.BackColor = Color.FromArgb(223, 233, 245);
            txtAlturaP.Location = new Point(112, 358);
            txtAlturaP.Multiline = true;
            txtAlturaP.Name = "txtAlturaP";
            txtAlturaP.Size = new Size(95, 23);
            txtAlturaP.TabIndex = 36;
            // 
            // lblObservacaoP
            // 
            lblObservacaoP.AutoSize = true;
            lblObservacaoP.BackColor = Color.FromArgb(187, 210, 236);
            lblObservacaoP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObservacaoP.Location = new Point(219, 371);
            lblObservacaoP.Name = "lblObservacaoP";
            lblObservacaoP.Size = new Size(113, 18);
            lblObservacaoP.TabIndex = 37;
            lblObservacaoP.Text = "Observações ";
            // 
            // txtObservacoesP
            // 
            txtObservacoesP.BackColor = Color.FromArgb(223, 233, 245);
            txtObservacoesP.Location = new Point(338, 331);
            txtObservacoesP.Multiline = true;
            txtObservacoesP.Name = "txtObservacoesP";
            txtObservacoesP.Size = new Size(253, 107);
            txtObservacoesP.TabIndex = 38;
            // 
            // btnGravar
            // 
            btnGravar.BackgroundImage = Properties.Resources.cadastrarbutton5;
            btnGravar.BackgroundImageLayout = ImageLayout.Zoom;
            btnGravar.FlatAppearance.BorderSize = 0;
            btnGravar.FlatStyle = FlatStyle.Flat;
            btnGravar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGravar.Location = new Point(617, 366);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(149, 52);
            btnGravar.TabIndex = 39;
            btnGravar.Text = "GRAVAR";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.BackColor = Color.FromArgb(187, 210, 236);
            lblSexo.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSexo.Location = new Point(58, 393);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(46, 18);
            lblSexo.TabIndex = 40;
            lblSexo.Text = "Sexo";
            // 
            // txtSexoP
            // 
            txtSexoP.BackColor = Color.FromArgb(223, 233, 245);
            txtSexoP.Location = new Point(113, 390);
            txtSexoP.MaxLength = 50;
            txtSexoP.Multiline = true;
            txtSexoP.Name = "txtSexoP";
            txtSexoP.Size = new Size(95, 23);
            txtSexoP.TabIndex = 41;
            // 
            // ViewCadastrarPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSexoP);
            Controls.Add(lblSexo);
            Controls.Add(btnGravar);
            Controls.Add(txtObservacoesP);
            Controls.Add(lblObservacaoP);
            Controls.Add(txtAlturaP);
            Controls.Add(txtPesoP);
            Controls.Add(lblPesoP);
            Controls.Add(lblAlturaP);
            Controls.Add(txtAcompanhanteP);
            Controls.Add(txtTelefone_2);
            Controls.Add(txtTelefoneP);
            Controls.Add(lblAcompanhanteP);
            Controls.Add(lblEmergenciaP);
            Controls.Add(lblTelefoneP);
            Controls.Add(txtCidadeP);
            Controls.Add(txtBairroP);
            Controls.Add(lblCidadeP);
            Controls.Add(lblBairroP);
            Controls.Add(txtComplementoP);
            Controls.Add(lblComplementoP);
            Controls.Add(txtUFP);
            Controls.Add(lblUFP);
            Controls.Add(txtNumP);
            Controls.Add(lblNumP);
            Controls.Add(txtLogradouroP);
            Controls.Add(lblLogradouroP);
            Controls.Add(txtCEPP);
            Controls.Add(lblCEPP);
            Controls.Add(txtConvenioP);
            Controls.Add(lblConvenioP);
            Controls.Add(txtCarteirinhaP);
            Controls.Add(lblCarteirinhaP);
            Controls.Add(txtRGP);
            Controls.Add(lblRGP);
            Controls.Add(txtCPFP);
            Controls.Add(lblCPFP);
            Controls.Add(txtNascimentoP);
            Controls.Add(lblNascimentoP);
            Controls.Add(txtNomeP);
            Controls.Add(lblNomeP);
            Controls.Add(pictureBox1);
            Name = "ViewCadastrarPaciente";
            Text = "ViewCadastrarPaciente";
            Load += ViewCadastrarPaciente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblNomeP;
        private TextBox txtNomeP;
        private Label lblNascimentoP;
        private TextBox txtNascimentoP;
        private Label lblCPFP;
        private TextBox txtCPFP;
        private Label lblRGP;
        private TextBox txtRGP;
        private Label lblCarteirinhaP;
        private TextBox txtCarteirinhaP;
        private Label lblConvenioP;
        private TextBox txtConvenioP;
        private Label lblCEPP;
        private TextBox txtCEPP;
        private Label lblLogradouroP;
        private TextBox txtLogradouroP;
        private Label lblNumP;
        private TextBox txtNumP;
        private Label lblUFP;
        private TextBox txtUFP;
        private Label lblComplementoP;
        private TextBox txtComplementoP;
        private Label lblBairroP;
        private Label lblCidadeP;
        private TextBox txtBairroP;
        private TextBox txtCidadeP;
        private Label lblTelefoneP;
        private Label lblEmergenciaP;
        private Label lblAcompanhanteP;
        private TextBox txtTelefoneP;
        private TextBox txtTelefone_2;
        private TextBox txtAcompanhanteP;
        private Label lblAlturaP;
        private Label lblPesoP;
        private TextBox txtPesoP;
        private TextBox txtAlturaP;
        private Label lblObservacaoP;
        private TextBox txtObservacoesP;
        private Button btnGravar;
        private Label lblSexo;
        private TextBox txtSexoP;
    }
}