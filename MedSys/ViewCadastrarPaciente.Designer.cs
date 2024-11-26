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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCadastrarPaciente));
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
            pictureBox1.Location = new Point(10, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblNomeP
            // 
            lblNomeP.AutoSize = true;
            lblNomeP.BackColor = Color.FromArgb(187, 210, 236);
            lblNomeP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomeP.Location = new Point(135, 29);
            lblNomeP.Name = "lblNomeP";
            lblNomeP.Size = new Size(45, 15);
            lblNomeP.TabIndex = 1;
            lblNomeP.Text = "Nome";
            // 
            // txtNomeP
            // 
            txtNomeP.BackColor = Color.FromArgb(223, 233, 245);
            txtNomeP.Location = new Point(184, 26);
            txtNomeP.Margin = new Padding(3, 2, 3, 2);
            txtNomeP.MaxLength = 200;
            txtNomeP.Multiline = true;
            txtNomeP.Name = "txtNomeP";
            txtNomeP.Size = new Size(292, 18);
            txtNomeP.TabIndex = 2;
            // 
            // lblNascimentoP
            // 
            lblNascimentoP.AutoSize = true;
            lblNascimentoP.BackColor = Color.FromArgb(187, 210, 236);
            lblNascimentoP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNascimentoP.Location = new Point(135, 56);
            lblNascimentoP.Name = "lblNascimentoP";
            lblNascimentoP.Size = new Size(137, 15);
            lblNascimentoP.TabIndex = 3;
            lblNascimentoP.Text = "Data de Nascimento";
            // 
            // txtNascimentoP
            // 
            txtNascimentoP.BackColor = Color.FromArgb(223, 233, 245);
            txtNascimentoP.Location = new Point(282, 54);
            txtNascimentoP.Margin = new Padding(3, 2, 3, 2);
            txtNascimentoP.Multiline = true;
            txtNascimentoP.Name = "txtNascimentoP";
            txtNascimentoP.Size = new Size(120, 18);
            txtNascimentoP.TabIndex = 4;
            txtNascimentoP.TextChanged += textBox1_TextChanged;
            // 
            // lblCPFP
            // 
            lblCPFP.AutoSize = true;
            lblCPFP.BackColor = Color.FromArgb(187, 210, 236);
            lblCPFP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCPFP.Location = new Point(481, 28);
            lblCPFP.Name = "lblCPFP";
            lblCPFP.Size = new Size(33, 15);
            lblCPFP.TabIndex = 5;
            lblCPFP.Text = "CPF";
            // 
            // txtCPFP
            // 
            txtCPFP.BackColor = Color.FromArgb(223, 233, 245);
            txtCPFP.Location = new Point(522, 26);
            txtCPFP.Margin = new Padding(3, 2, 3, 2);
            txtCPFP.MaxLength = 14;
            txtCPFP.Multiline = true;
            txtCPFP.Name = "txtCPFP";
            txtCPFP.Size = new Size(136, 18);
            txtCPFP.TabIndex = 6;
            // 
            // lblRGP
            // 
            lblRGP.AutoSize = true;
            lblRGP.BackColor = Color.FromArgb(187, 210, 236);
            lblRGP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRGP.Location = new Point(410, 57);
            lblRGP.Name = "lblRGP";
            lblRGP.Size = new Size(27, 15);
            lblRGP.TabIndex = 7;
            lblRGP.Text = "RG";
            // 
            // txtRGP
            // 
            txtRGP.BackColor = Color.FromArgb(223, 233, 245);
            txtRGP.Location = new Point(444, 55);
            txtRGP.Margin = new Padding(3, 2, 3, 2);
            txtRGP.MaxLength = 10;
            txtRGP.Multiline = true;
            txtRGP.Name = "txtRGP";
            txtRGP.Size = new Size(120, 18);
            txtRGP.TabIndex = 8;
            // 
            // lblCarteirinhaP
            // 
            lblCarteirinhaP.AutoSize = true;
            lblCarteirinhaP.BackColor = Color.FromArgb(187, 210, 236);
            lblCarteirinhaP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarteirinhaP.Location = new Point(135, 81);
            lblCarteirinhaP.Name = "lblCarteirinhaP";
            lblCarteirinhaP.Size = new Size(78, 15);
            lblCarteirinhaP.TabIndex = 9;
            lblCarteirinhaP.Text = "Carteirinha";
            // 
            // txtCarteirinhaP
            // 
            txtCarteirinhaP.BackColor = Color.FromArgb(223, 233, 245);
            txtCarteirinhaP.Location = new Point(218, 79);
            txtCarteirinhaP.Margin = new Padding(3, 2, 3, 2);
            txtCarteirinhaP.MaxLength = 23;
            txtCarteirinhaP.Multiline = true;
            txtCarteirinhaP.Name = "txtCarteirinhaP";
            txtCarteirinhaP.Size = new Size(221, 18);
            txtCarteirinhaP.TabIndex = 10;
            // 
            // lblConvenioP
            // 
            lblConvenioP.AutoSize = true;
            lblConvenioP.BackColor = Color.FromArgb(187, 210, 236);
            lblConvenioP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConvenioP.Location = new Point(443, 82);
            lblConvenioP.Name = "lblConvenioP";
            lblConvenioP.Size = new Size(66, 15);
            lblConvenioP.TabIndex = 11;
            lblConvenioP.Text = "Convênio";
            // 
            // txtConvenioP
            // 
            txtConvenioP.BackColor = Color.FromArgb(223, 233, 245);
            txtConvenioP.Location = new Point(515, 80);
            txtConvenioP.Margin = new Padding(3, 2, 3, 2);
            txtConvenioP.MaxLength = 50;
            txtConvenioP.Multiline = true;
            txtConvenioP.Name = "txtConvenioP";
            txtConvenioP.Size = new Size(142, 18);
            txtConvenioP.TabIndex = 12;
            // 
            // lblCEPP
            // 
            lblCEPP.AutoSize = true;
            lblCEPP.BackColor = Color.FromArgb(187, 210, 236);
            lblCEPP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCEPP.Location = new Point(51, 122);
            lblCEPP.Name = "lblCEPP";
            lblCEPP.Size = new Size(34, 15);
            lblCEPP.TabIndex = 13;
            lblCEPP.Text = "CEP";
            // 
            // txtCEPP
            // 
            txtCEPP.BackColor = Color.FromArgb(223, 233, 245);
            txtCEPP.Location = new Point(92, 119);
            txtCEPP.Margin = new Padding(3, 2, 3, 2);
            txtCEPP.MaxLength = 9;
            txtCEPP.Multiline = true;
            txtCEPP.Name = "txtCEPP";
            txtCEPP.Size = new Size(112, 18);
            txtCEPP.TabIndex = 14;
            // 
            // lblLogradouroP
            // 
            lblLogradouroP.AutoSize = true;
            lblLogradouroP.BackColor = Color.FromArgb(187, 210, 236);
            lblLogradouroP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLogradouroP.Location = new Point(213, 122);
            lblLogradouroP.Name = "lblLogradouroP";
            lblLogradouroP.Size = new Size(81, 15);
            lblLogradouroP.TabIndex = 15;
            lblLogradouroP.Text = "Logradouro";
            // 
            // txtLogradouroP
            // 
            txtLogradouroP.BackColor = Color.FromArgb(223, 233, 245);
            txtLogradouroP.Location = new Point(303, 118);
            txtLogradouroP.Margin = new Padding(3, 2, 3, 2);
            txtLogradouroP.MaxLength = 200;
            txtLogradouroP.Multiline = true;
            txtLogradouroP.Name = "txtLogradouroP";
            txtLogradouroP.Size = new Size(177, 18);
            txtLogradouroP.TabIndex = 16;
            // 
            // lblNumP
            // 
            lblNumP.AutoSize = true;
            lblNumP.BackColor = Color.FromArgb(187, 210, 236);
            lblNumP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumP.Location = new Point(486, 121);
            lblNumP.Name = "lblNumP";
            lblNumP.Size = new Size(22, 15);
            lblNumP.TabIndex = 17;
            lblNumP.Text = "Nº";
            // 
            // txtNumP
            // 
            txtNumP.BackColor = Color.FromArgb(223, 233, 245);
            txtNumP.Location = new Point(515, 118);
            txtNumP.Margin = new Padding(3, 2, 3, 2);
            txtNumP.Multiline = true;
            txtNumP.Name = "txtNumP";
            txtNumP.Size = new Size(51, 18);
            txtNumP.TabIndex = 18;
            // 
            // lblUFP
            // 
            lblUFP.AutoSize = true;
            lblUFP.BackColor = Color.FromArgb(187, 210, 236);
            lblUFP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUFP.Location = new Point(574, 121);
            lblUFP.Name = "lblUFP";
            lblUFP.Size = new Size(25, 15);
            lblUFP.TabIndex = 19;
            lblUFP.Text = "UF";
            // 
            // txtUFP
            // 
            txtUFP.BackColor = Color.FromArgb(223, 233, 245);
            txtUFP.Location = new Point(606, 118);
            txtUFP.Margin = new Padding(3, 2, 3, 2);
            txtUFP.MaxLength = 2;
            txtUFP.Multiline = true;
            txtUFP.Name = "txtUFP";
            txtUFP.Size = new Size(36, 18);
            txtUFP.TabIndex = 20;
            // 
            // lblComplementoP
            // 
            lblComplementoP.AutoSize = true;
            lblComplementoP.BackColor = Color.FromArgb(187, 210, 236);
            lblComplementoP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComplementoP.Location = new Point(51, 148);
            lblComplementoP.Name = "lblComplementoP";
            lblComplementoP.Size = new Size(96, 15);
            lblComplementoP.TabIndex = 21;
            lblComplementoP.Text = "Complemento";
            // 
            // txtComplementoP
            // 
            txtComplementoP.BackColor = Color.FromArgb(223, 233, 245);
            txtComplementoP.Location = new Point(152, 146);
            txtComplementoP.Margin = new Padding(3, 2, 3, 2);
            txtComplementoP.MaxLength = 100;
            txtComplementoP.Multiline = true;
            txtComplementoP.Name = "txtComplementoP";
            txtComplementoP.Size = new Size(144, 18);
            txtComplementoP.TabIndex = 22;
            // 
            // lblBairroP
            // 
            lblBairroP.AutoSize = true;
            lblBairroP.BackColor = Color.FromArgb(187, 210, 236);
            lblBairroP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBairroP.Location = new Point(302, 148);
            lblBairroP.Name = "lblBairroP";
            lblBairroP.Size = new Size(46, 15);
            lblBairroP.TabIndex = 23;
            lblBairroP.Text = "Bairro";
            // 
            // lblCidadeP
            // 
            lblCidadeP.AutoSize = true;
            lblCidadeP.BackColor = Color.FromArgb(187, 210, 236);
            lblCidadeP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCidadeP.Location = new Point(471, 150);
            lblCidadeP.Name = "lblCidadeP";
            lblCidadeP.Size = new Size(52, 15);
            lblCidadeP.TabIndex = 24;
            lblCidadeP.Text = "Cidade";
            // 
            // txtBairroP
            // 
            txtBairroP.BackColor = Color.FromArgb(223, 233, 245);
            txtBairroP.Location = new Point(353, 147);
            txtBairroP.Margin = new Padding(3, 2, 3, 2);
            txtBairroP.MaxLength = 100;
            txtBairroP.Multiline = true;
            txtBairroP.Name = "txtBairroP";
            txtBairroP.Size = new Size(113, 18);
            txtBairroP.TabIndex = 25;
            // 
            // txtCidadeP
            // 
            txtCidadeP.BackColor = Color.FromArgb(223, 233, 245);
            txtCidadeP.Location = new Point(528, 148);
            txtCidadeP.Margin = new Padding(3, 2, 3, 2);
            txtCidadeP.MaxLength = 100;
            txtCidadeP.Multiline = true;
            txtCidadeP.Name = "txtCidadeP";
            txtCidadeP.Size = new Size(113, 18);
            txtCidadeP.TabIndex = 26;
            // 
            // lblTelefoneP
            // 
            lblTelefoneP.AutoSize = true;
            lblTelefoneP.BackColor = Color.FromArgb(187, 210, 236);
            lblTelefoneP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefoneP.Location = new Point(104, 180);
            lblTelefoneP.Name = "lblTelefoneP";
            lblTelefoneP.Size = new Size(63, 15);
            lblTelefoneP.TabIndex = 27;
            lblTelefoneP.Text = "Telefone";
            // 
            // lblEmergenciaP
            // 
            lblEmergenciaP.AutoSize = true;
            lblEmergenciaP.BackColor = Color.FromArgb(187, 210, 236);
            lblEmergenciaP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmergenciaP.Location = new Point(306, 181);
            lblEmergenciaP.Name = "lblEmergenciaP";
            lblEmergenciaP.Size = new Size(164, 15);
            lblEmergenciaP.TabIndex = 28;
            lblEmergenciaP.Text = "Telefone de Emergência";
            // 
            // lblAcompanhanteP
            // 
            lblAcompanhanteP.AutoSize = true;
            lblAcompanhanteP.BackColor = Color.FromArgb(187, 210, 236);
            lblAcompanhanteP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAcompanhanteP.Location = new Point(51, 218);
            lblAcompanhanteP.Name = "lblAcompanhanteP";
            lblAcompanhanteP.Size = new Size(102, 15);
            lblAcompanhanteP.TabIndex = 29;
            lblAcompanhanteP.Text = "Acompanhante";
            // 
            // txtTelefoneP
            // 
            txtTelefoneP.BackColor = Color.FromArgb(223, 233, 245);
            txtTelefoneP.Location = new Point(175, 178);
            txtTelefoneP.Margin = new Padding(3, 2, 3, 2);
            txtTelefoneP.MaxLength = 16;
            txtTelefoneP.Multiline = true;
            txtTelefoneP.Name = "txtTelefoneP";
            txtTelefoneP.Size = new Size(120, 18);
            txtTelefoneP.TabIndex = 30;
            // 
            // txtTelefone_2
            // 
            txtTelefone_2.BackColor = Color.FromArgb(223, 233, 245);
            txtTelefone_2.Location = new Point(480, 178);
            txtTelefone_2.Margin = new Padding(3, 2, 3, 2);
            txtTelefone_2.MaxLength = 16;
            txtTelefone_2.Multiline = true;
            txtTelefone_2.Name = "txtTelefone_2";
            txtTelefone_2.Size = new Size(120, 18);
            txtTelefone_2.TabIndex = 31;
            // 
            // txtAcompanhanteP
            // 
            txtAcompanhanteP.BackColor = Color.FromArgb(223, 233, 245);
            txtAcompanhanteP.Location = new Point(160, 206);
            txtAcompanhanteP.Margin = new Padding(3, 2, 3, 2);
            txtAcompanhanteP.MaxLength = 200;
            txtAcompanhanteP.Multiline = true;
            txtAcompanhanteP.Name = "txtAcompanhanteP";
            txtAcompanhanteP.Size = new Size(482, 36);
            txtAcompanhanteP.TabIndex = 32;
            // 
            // lblAlturaP
            // 
            lblAlturaP.AutoSize = true;
            lblAlturaP.BackColor = Color.FromArgb(187, 210, 236);
            lblAlturaP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlturaP.Location = new Point(51, 270);
            lblAlturaP.Name = "lblAlturaP";
            lblAlturaP.Size = new Size(44, 15);
            lblAlturaP.TabIndex = 33;
            lblAlturaP.Text = "Altura";
            // 
            // lblPesoP
            // 
            lblPesoP.AutoSize = true;
            lblPesoP.BackColor = Color.FromArgb(187, 210, 236);
            lblPesoP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPesoP.Location = new Point(51, 248);
            lblPesoP.Name = "lblPesoP";
            lblPesoP.Size = new Size(39, 15);
            lblPesoP.TabIndex = 34;
            lblPesoP.Text = "Peso";
            // 
            // txtPesoP
            // 
            txtPesoP.BackColor = Color.FromArgb(223, 233, 245);
            txtPesoP.Location = new Point(98, 246);
            txtPesoP.Margin = new Padding(3, 2, 3, 2);
            txtPesoP.Multiline = true;
            txtPesoP.Name = "txtPesoP";
            txtPesoP.Size = new Size(84, 18);
            txtPesoP.TabIndex = 35;
            // 
            // txtAlturaP
            // 
            txtAlturaP.BackColor = Color.FromArgb(223, 233, 245);
            txtAlturaP.Location = new Point(98, 268);
            txtAlturaP.Margin = new Padding(3, 2, 3, 2);
            txtAlturaP.Multiline = true;
            txtAlturaP.Name = "txtAlturaP";
            txtAlturaP.Size = new Size(84, 18);
            txtAlturaP.TabIndex = 36;
            // 
            // lblObservacaoP
            // 
            lblObservacaoP.AutoSize = true;
            lblObservacaoP.BackColor = Color.FromArgb(187, 210, 236);
            lblObservacaoP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblObservacaoP.Location = new Point(192, 278);
            lblObservacaoP.Name = "lblObservacaoP";
            lblObservacaoP.Size = new Size(93, 15);
            lblObservacaoP.TabIndex = 37;
            lblObservacaoP.Text = "Observações ";
            // 
            // txtObservacoesP
            // 
            txtObservacoesP.BackColor = Color.FromArgb(223, 233, 245);
            txtObservacoesP.Location = new Point(296, 248);
            txtObservacoesP.Margin = new Padding(3, 2, 3, 2);
            txtObservacoesP.Multiline = true;
            txtObservacoesP.Name = "txtObservacoesP";
            txtObservacoesP.Size = new Size(222, 81);
            txtObservacoesP.TabIndex = 38;
            // 
            // btnGravar
            // 
            btnGravar.BackgroundImage = Properties.Resources.cadastrarbutton5;
            btnGravar.BackgroundImageLayout = ImageLayout.Zoom;
            btnGravar.FlatAppearance.BorderSize = 0;
            btnGravar.FlatStyle = FlatStyle.Flat;
            btnGravar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGravar.Location = new Point(540, 274);
            btnGravar.Margin = new Padding(3, 2, 3, 2);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(130, 39);
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
            lblSexo.Location = new Point(51, 295);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(39, 15);
            lblSexo.TabIndex = 40;
            lblSexo.Text = "Sexo";
            // 
            // txtSexoP
            // 
            txtSexoP.BackColor = Color.FromArgb(223, 233, 245);
            txtSexoP.Location = new Point(99, 292);
            txtSexoP.Margin = new Padding(3, 2, 3, 2);
            txtSexoP.MaxLength = 50;
            txtSexoP.Multiline = true;
            txtSexoP.Name = "txtSexoP";
            txtSexoP.Size = new Size(84, 18);
            txtSexoP.TabIndex = 41;
            // 
            // ViewCadastrarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewCadastrarPaciente";
            Text = "MedSys | Cadastrar Paciente";
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