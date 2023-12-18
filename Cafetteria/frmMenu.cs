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

        }

        private void pcbVoltar_Click(object sender, EventArgs e)
        {
         
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            var frmCadFunc = new frmCadFunc();
            this.Hide();
            frmCadFunc.Show();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            var frmCaixa = new frmCaixa();
            this.Hide();
            frmCaixa.Show();
        }

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            var frmCadProd = new frmCadProd();
            this.Hide();
            frmCadProd.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            var frmEstoque = new frmEstoque();
            this.Hide();
            frmEstoque.Show();
        }

        private void btnCadForn_Click(object sender, EventArgs e)
        {
            var frmCadForn = new frmCadForn();
            this.Hide();
            frmCadForn.Show();

        }

        private void btnFazerPedido_Click(object sender, EventArgs e)
        {
            var frmFazerPedido = new frmFazerPedido();
            this.Hide();
            frmFazerPedido.Show();

        }

        private void pcbSair_Click_1(object sender, EventArgs e)
        {
            DialogResult sair1 =
         MessageBox.Show("Você deseja realmente sair do aplicativo?",
                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sair1 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
