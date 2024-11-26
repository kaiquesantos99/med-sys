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
            txtPaciente.Location = new Point(338, 23);
            txtPaciente.Name = "txtPaciente";
            txtPaciente.Size = new Size(263, 27);
            txtPaciente.TabIndex = 0;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.BackColor = Color.FromArgb(187, 210, 236);
            lblPaciente.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPaciente.Location = new Point(183, 29);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(147, 18);
            lblPaciente.TabIndex = 1;
            lblPaciente.Text = "Nome do Paciente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 99);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.CornflowerBlue;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(291, 62);
            label2.Name = "label2";
            label2.Size = new Size(166, 18);
            label2.TabIndex = 3;
            label2.Text = "Prontuário de Exame";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(223, 233, 245);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 122);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(775, 286);
            dataGridView1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(321, 87);
            label3.Name = "label3";
            label3.Size = new Size(109, 20);
            label3.TabIndex = 5;
            label3.Text = "Vinicius Toledo";
            // 
            // ViewProntuarioExame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 414);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPaciente);
            Controls.Add(txtPaciente);
            Name = "ViewProntuarioExame";
            Text = "ViewProntuarioExame";
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