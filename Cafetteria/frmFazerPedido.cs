using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cafetteria
{
    public partial class frmFazerPedido : Form
    {
        public frmFazerPedido()
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

        private void txtCNPJ_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtValor.Text.Trim().Length == 0)
            {
                // se sim, vai aparecer essa mensagem de erro
                MessageBox.Show("Preencha o valor do produto");
                txtValor.Focus();
                //Volta a focar no campo número1
            }
            else if (txtQuantidade.Text.Trim().Length == 0)
            {
                MessageBox.Show("Preencha a quantidade necessária do produto!");
                txtQuantidade.Focus();
            }
            else
            {
                // Definindo a variável
                double valor, quantidade, resultado = 0;

                // Convertendo o string (campo do Numero01) em double
                valor = double.Parse(txtValor.Text);
                quantidade = double.Parse(txtQuantidade.Text);

                resultado = valor * quantidade;

                txtTotalCompra.Text = resultado.ToString();
            }
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            if (txtCNPJ.Text != "")
            {
                try
                {
                    ConexaoSQL.Conectar();
                    string sql = @"select * from caf.Produto where CNPJ like '%" + txtCNPJ.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dgvProdutosForn.DataSource = dt;

                    //add aqui
                    dgvProdutosForn.CellContentClick += dgvProdutosForn_CellContentClick;
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

                /*  DataGridViewRow Linha;
                Linha = dgvProdutosForn.CurrentRow;
                txtNome.Text = Linha.Cells[2].Value.ToString();
                txtValor.Text = Linha.Cells[3].Value.ToString();
                mskValidade.Text = Linha.Cells[4].Value.ToString();
                txtIDProd.Text = Linha.Cells[0].Value.ToString(); */


            }
            else
            {
                MessageBox.Show("Precisa digitar um CNPJ primeiro");
            }
        }

        private void btnCadastrarForn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTotalCompra.Text))
            {
                MessageBox.Show("Você ainda não calculou o preço total!");
            }
            else
            {
                MessageBox.Show("Seu pedido foi encaminhado para o FORNECEDOR com sucesso! Logo logo seu produto irá chegar até você.",
                   "PEDIDO FEITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNome.Clear();
                txtValor.Clear();
                //msk
                mskValidade.Text = "";
                txtCNPJ.Clear();
                txtQuantidade.Clear();
                txtTotalCompra.Clear();
                txtIDProd.Clear();

                /* try
                 {
                     ConexaoSQL.Conectar();
                     String sql = @"INSERT INTO caf.Estoque VALUES (@Quantidade, @ID)";

                     SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);


                     cmd.Parameters.AddWithValue("Quantidade", txtQuantidade.Text);
                     cmd.Parameters.AddWithValue("ID", txtIDProd.Text);

                     cmd.ExecuteNonQuery();

                     MessageBox.Show("Estoque atualizado!");

                     ConexaoSQL.Fechar();
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Erro" + ex.Message);
                 } */
            }
        }

        private void pcbVoltar_Click(object sender, EventArgs e)
        {
            var frmMenu = new frmMenu();
            this.Hide();
            frmMenu.Show();
        }

        private void dgvProdutosForn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linha = dgvProdutosForn.Rows[e.RowIndex];

                txtNome.Text = linha.Cells[2].Value.ToString();
                txtValor.Text = linha.Cells[3].Value.ToString();
                mskValidade.Text = linha.Cells[4].Value.ToString();
                txtIDProd.Text = linha.Cells[0].Value.ToString();
            }
        }
    }
}

          
