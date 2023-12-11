using System;
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
    public partial class frmCadProd : Form
    {
        public frmCadProd()
        {
            InitializeComponent();
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

        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {

        }
    }
}
