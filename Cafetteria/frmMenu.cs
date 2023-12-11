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
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            frmCadFunc cadfun = new frmCadFunc();
            this.Hide();
            cadfun.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            frmCaixa caixa = new frmCaixa();
            this.Hide();
            caixa.ShowDialog();
        }

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            frmCadProd cadprod = new frmCadProd();
            this.Hide();
            cadprod.ShowDialog();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque estoque = new frmEstoque();
            this.Hide();
            estoque.ShowDialog();

        }

        private void btnCadForn_Click(object sender, EventArgs e)
        {
            frmCadForn cadforn = new frmCadForn();
            this.Hide();
            cadforn.ShowDialog();
            
        }

        private void btnFazerPedido_Click(object sender, EventArgs e)
        {
            frmFazerPedido pedido = new frmFazerPedido();
            this.Hide();
            pedido.ShowDialog();
        }
    }
}
