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
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // ldlEntrar
            // 
            ldlEntrar.AutoSize = true;
            ldlEntrar.Location = new Point(615, 271);
            ldlEntrar.Name = "ldlEntrar";
            ldlEntrar.Size = new Size(48, 20);
            ldlEntrar.TabIndex = 1;
            ldlEntrar.Text = "Entrar";
            ldlEntrar.Click += ldlEntrar_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(572, 220);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(125, 27);
            txtSenha.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(572, 177);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(125, 27);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(495, 184);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 4;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(495, 226);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 5;
            label3.Text = "Senha";
            label3.Click += label3_Click;
            // 
            // ViewLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(txtSenha);
            Controls.Add(ldlEntrar);
            Name = "ViewLogin";
            Text = "Login MedSys";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ldlEntrar;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label label2;
        private Label label3;
    }
}