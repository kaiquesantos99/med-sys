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
            ldlEntrar.Location = new Point(600, 271);
            ldlEntrar.Name = "ldlEntrar";
            ldlEntrar.Size = new Size(48, 20);
            ldlEntrar.TabIndex = 1;
            ldlEntrar.Text = "Entrar";
            ldlEntrar.Click += ldlEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(571, 220);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(125, 27);
            txtSenha.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(571, 177);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // ViewLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_login;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 451);
            Controls.Add(txtUsuario);
            Controls.Add(txtSenha);
            Controls.Add(ldlEntrar);
            DoubleBuffered = true;
            Name = "ViewLogin";
            Text = "Login MedSys";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ldlEntrar;
        private TextBox txtSenha;
        private TextBox txtUsuario;
    }
}