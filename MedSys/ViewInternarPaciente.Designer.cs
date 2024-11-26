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
            txtLeito = new TextBox();
            txtSetor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnInternar = new Button();
            SuspendLayout();
            // 
            // txtLeito
            // 
            txtLeito.Location = new Point(112, 49);
            txtLeito.Name = "txtLeito";
            txtLeito.Size = new Size(100, 23);
            txtLeito.TabIndex = 0;
            // 
            // txtSetor
            // 
            txtSetor.Location = new Point(112, 78);
            txtSetor.Name = "txtSetor";
            txtSetor.Size = new Size(100, 23);
            txtSetor.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 52);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "Leito";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 81);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "Setor";
            // 
            // btnInternar
            // 
            btnInternar.Location = new Point(247, 63);
            btnInternar.Name = "btnInternar";
            btnInternar.Size = new Size(75, 23);
            btnInternar.TabIndex = 4;
            btnInternar.Text = "Internar";
            btnInternar.UseVisualStyleBackColor = true;
            btnInternar.Click += btnInternar_Click;
            // 
            // ViewInternarPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 200);
            Controls.Add(btnInternar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSetor);
            Controls.Add(txtLeito);
            Name = "ViewInternarPaciente";
            Text = "MedSys | Finalizar Internação";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLeito;
        private TextBox txtSetor;
        private Label label1;
        private Label label2;
        private Button btnInternar;
    }
}