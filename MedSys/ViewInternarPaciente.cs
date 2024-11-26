using MedSys.DataAccess;
using MedSys.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedSys
{
    public partial class ViewInternarPaciente : Form
    {
        Form1 f;
        private int IdMedico { get; set; }
        private int IdPaciente { get; set; }

        public ViewInternarPaciente(int idMedico, int idPaciente, Form1 f)
        {
            InitializeComponent();
            IdMedico = idMedico;
            IdPaciente = idPaciente;
            this.f = f;
        }

        private void btnInternar_Click(object sender, EventArgs e)
        {
            ProntuarioDAO pdao = new ProntuarioDAO();
            Internacao internacao = new Internacao();
            internacao.Leito = txtLeito.Text;
            internacao.Setor = txtSetor.Text;
            pdao.InternarPaciente(internacao, IdPaciente, IdMedico);
            f.ReadTables();
            this.Close();
        }
    }
}
