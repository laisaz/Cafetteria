﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafetteria
{
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void lblCadFunc_Click(object sender, EventArgs e)
        {

        }

        private void pcbSair_Click(object sender, EventArgs e)
        {
            DialogResult sair =
         MessageBox.Show("Você deseja realmente sair do aplicativo?",
                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
        }

        private void pcbVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }
    }
}
