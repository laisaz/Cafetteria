using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cafetteria
{
    public partial class frmCaixa : Form
    {
        int count = 0;

        public frmCaixa()
        {
            InitializeComponent();
        }

        private void lblCadProd_Click(object sender, EventArgs e)
        {

        }

        private void lblFazerBusca_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void btnCancela_Click(object sender, EventArgs e)
        {
            txtCPFCliente.Clear();
            txtNumProd.Clear();
            txtTotal.Clear();
            lstPrice.Items.Clear();
            lstProd.Items.Clear();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int x;
            decimal total = 0;
            count++;

            try
            {
                ConexaoSQL.Conectar();
                string sql = @"select nm_prod,val_prod from caf.Produto where id_prod = @cod";
                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                cmd.Parameters.AddWithValue("cod", txtNumProd.Text);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgvProduct.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro :", ex.Message);
                throw;
            }
            finally
            {
                ConexaoSQL.Fechar();
            }
            DataGridViewRow Linha;
            Linha = dgvProduct.CurrentRow;
            lstProd.Items.Add(Linha.Cells[0].Value.ToString());
            lstPrice.Items.Add(Linha.Cells[1].Value.ToString());


            for (x = 0; x < count; x++)
            {
                String str = lstPrice.Items[x].ToString();
                total += decimal.Parse(str);
            }
            txtTotal.Text = total.ToString();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            int y;
            String ProdutosTotal = lstPrice.Items[0].ToString(), 
                Data = DateTime.Now.ToString();
            
            for (y = 1; y < count; y++)
            {
                String str = lstPrice.Items[y].ToString();
                ProdutosTotal = ( ProdutosTotal + "," + str);
            }
            try
            {
                ConexaoSQL.Conectar();

                String sql = @"INSERT INTO caf.Caixa(val_total,quant_itens,CPF_cliente,Prods_caixa) VALUES (@ValorTotal, @Quantidade, @CPF, @Produtos)";

                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                cmd.Parameters.AddWithValue("ValorTotal", txtTotal.Text.Replace(",","."));
                cmd.Parameters.AddWithValue("Quantidade", lstProd.Items.Count.ToString());
                cmd.Parameters.AddWithValue("CPF", txtCPFCliente.Text);
                cmd.Parameters.AddWithValue("Produtos", ProdutosTotal);



                cmd.ExecuteNonQuery();

                MessageBox.Show("Compra bem sucedida");

                ConexaoSQL.Fechar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
            finally
            {
                ConexaoSQL.Fechar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }
    }
}
