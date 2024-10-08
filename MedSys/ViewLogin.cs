﻿using MedSys.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MedSys
{
    public partial class ViewLogin : Form
    {
        public ViewLogin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void ldlEntrar_Click(object sender, EventArgs e)
        {
            bool aprovado;

            string usuario = txtUsuario.Text;

            string senha = txtSenha.Text;
            
            ColaboradorDAO cdao = new ColaboradorDAO();

            aprovado = cdao.VerificarIdentidade(usuario, senha);

            if (aprovado)
            {
                Form1 form1 = new Form1();  
                form1.Show();
              
            }
            else
            {
                MessageBox.Show("Login ou Senha incorreta.");
            }
        }
    }
}
