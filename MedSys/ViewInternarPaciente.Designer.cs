namespace MedSys
{
    partial class ViewInternarPaciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewInternarPaciente));
            txtLeito = new TextBox();
            txtSetor = new TextBox();
            lblLeito = new Label();
            lblSetor = new Label();
            btnInternar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtLeito
            // 
            txtLeito.BackColor = Color.FromArgb(223, 233, 245);
            txtLeito.Location = new Point(200, 50);
            txtLeito.Name = "txtLeito";
            txtLeito.Size = new Size(100, 23);
            txtLeito.TabIndex = 0;
            // 
            // txtSetor
            // 
            txtSetor.BackColor = Color.FromArgb(223, 233, 245);
            txtSetor.Location = new Point(200, 80);
            txtSetor.Name = "txtSetor";
            txtSetor.Size = new Size(100, 23);
            txtSetor.TabIndex = 1;
            // 
            // lblLeito
            // 
            lblLeito.AutoSize = true;
            lblLeito.BackColor = Color.FromArgb(187, 210, 236);
            lblLeito.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLeito.Location = new Point(152, 54);
            lblLeito.Name = "lblLeito";
            lblLeito.Size = new Size(39, 15);
            lblLeito.TabIndex = 2;
            lblLeito.Text = "Leito";
            // 
            // lblSetor
            // 
            lblSetor.AutoSize = true;
            lblSetor.BackColor = Color.FromArgb(187, 210, 236);
            lblSetor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSetor.Location = new Point(151, 83);
            lblSetor.Name = "lblSetor";
            lblSetor.Size = new Size(41, 15);
            lblSetor.TabIndex = 3;
            lblSetor.Text = "Setor";
            // 
            // btnInternar
            // 
            btnInternar.BackColor = Color.Transparent;
            btnInternar.BackgroundImage = Properties.Resources.cadastrarbutton10;
            btnInternar.BackgroundImageLayout = ImageLayout.Zoom;
            btnInternar.FlatAppearance.BorderSize = 0;
            btnInternar.FlatStyle = FlatStyle.Flat;
            btnInternar.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInternar.Location = new Point(158, 114);
            btnInternar.Name = "btnInternar";
            btnInternar.Size = new Size(130, 44);
            btnInternar.TabIndex = 4;
            btnInternar.Text = "INTERNAR";
            btnInternar.UseVisualStyleBackColor = false;
            btnInternar.Click += btnInternar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.g1int;
            pictureBox1.Location = new Point(40, 31);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(93, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // ViewInternarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 200);
            Controls.Add(pictureBox1);
            Controls.Add(btnInternar);
            Controls.Add(lblSetor);
            Controls.Add(lblLeito);
            Controls.Add(txtSetor);
            Controls.Add(txtLeito);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewInternarPaciente";
            Text = "MedSys | Finalizar Internação";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLeito;
        private TextBox txtSetor;
        private Label lblLeito;
        private Label lblSetor;
        private Button btnInternar;
        private PictureBox pictureBox1;
    }
}