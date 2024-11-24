namespace MedSys
{
    partial class ViewLogin
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
            ldlEntrar = new Label();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            SuspendLayout();
            // 
            // ldlEntrar
            // 
            ldlEntrar.AutoSize = true;
            ldlEntrar.Location = new Point(525, 203);
            ldlEntrar.Name = "ldlEntrar";
            ldlEntrar.Size = new Size(38, 15);
            ldlEntrar.TabIndex = 1;
            ldlEntrar.Text = "Entrar";
            ldlEntrar.Click += ldlEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(500, 165);
            txtSenha.Margin = new Padding(3, 2, 3, 2);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(110, 23);
            txtSenha.TabIndex = 3;
            txtSenha.Text = "05031999";
            txtSenha.KeyDown += txtSenha_KeyDown;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(500, 133);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(110, 23);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "kaka.01";
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // ViewLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_login;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(700, 338);
            Controls.Add(txtUsuario);
            Controls.Add(txtSenha);
            Controls.Add(ldlEntrar);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewLogin";
            Text = "Login MedSys";
            KeyDown += ViewLogin_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ldlEntrar;
        private TextBox txtSenha;
        private TextBox txtUsuario;
    }
}