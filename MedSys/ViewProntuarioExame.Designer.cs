namespace MedSys
{
    partial class ViewProntuarioExame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProntuarioExame));
            txtPaciente = new TextBox();
            lblPaciente = new Label();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtPaciente
            // 
            txtPaciente.BackColor = Color.FromArgb(223, 233, 245);
            txtPaciente.Location = new Point(296, 17);
            txtPaciente.Margin = new Padding(3, 2, 3, 2);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(231, 23);
            txtPaciente.TabIndex = 0;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.BackColor = Color.FromArgb(187, 210, 236);
            lblPaciente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaciente.Location = new Point(160, 22);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(125, 15);
            lblPaciente.TabIndex = 1;
            lblPaciente.Text = "Nome do Paciente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 74);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.CornflowerBlue;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(255, 46);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 3;
            label2.Text = "Prontuário de Exame";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(223, 233, 245);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 92);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(678, 214);
            dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 65);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 5;
            label3.Text = "Vinicius Toledo";
            // 
            // ViewProntuarioExame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 310);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPaciente);
            Controls.Add(txtPaciente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "ViewProntuarioExame";
            Text = "MedSys | Prontuário de Exame";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPaciente;
        private Label lblPaciente;
        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
    }
}