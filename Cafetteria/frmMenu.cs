﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafetteria
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void lblCafetteria_Click(object sender, EventArgs e)
        {

        }

        private void pcbSair_Click(object sender, EventArgs e)
        {
            {
                DialogResult sair =
                MessageBox.Show("Você deseja realmente sair do aplicativo?",
                           "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (sair == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        private void pcbVoltar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {

        }

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            

        }

        private void btnCadForn_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
