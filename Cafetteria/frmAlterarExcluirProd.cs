using System;
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
    public partial class frmAlterarExcluirProd : Form
    {
        public frmAlterarExcluirProd()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.ShowDialog();
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                ConexaoSQL.Conectar();
                string sql = @"delete from caf.Produto where id_prod = @Nome";

                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                cmd.Parameters.AddWithValue("Nome", txtIdProd.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto excluido com sucesso!");

                txtNome.Clear();
                txtDescricao.Clear();
                txtValor.Clear();
                mskValidade.Clear();
                txtCnpj.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: ", ex.Message);
                throw;
            }
            finally
            {
                ConexaoSQL.Fechar();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {

                ConexaoSQL.Conectar();

                String sql = @"update caf.Produto set desc_prod = @Descricao, nm_prod = @Nome, val_prod = @Valor, validade_prod = @Validade, CNPJ = @CNPJ where id_prod = @id";

                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                cmd.Parameters.AddWithValue("id", txtIdProd.Text);
                cmd.Parameters.AddWithValue("Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("Descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("valor", Convert.ToDecimal(txtValor.Text));
                cmd.Parameters.AddWithValue("Validade", mskValidade.Text);
                cmd.Parameters.AddWithValue("CNPJ", txtCnpj.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto alterado com sucesso");

                //Utils.LimparCampos(this);
                //LIMPAR OS CAMPOS

                txtNome.Clear();
                txtDescricao.Clear();
                txtCnpj.Clear();
                txtValor.Clear();
                mskValidade.Text = "";

                ConexaoSQL.Fechar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: ", ex.Message);
                throw;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoSQL.Conectar();
                string sql = @"SELECT * FROM caf.Produto
                    WHERE nm_prod LIKE '" + txtNome.Text + "%'";
                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);

                SqlDataReader prod = cmd.ExecuteReader();

                prod.Read();

                txtIdProd.Text = prod["id_prod"].ToString();
                txtNomeProduto.Text = prod["nm_prod"].ToString();
                txtDescricao.Text = prod["desc_prod"].ToString();
                txtValor.Text = prod["val_prod"].ToString();
                txtCnpj.Text = prod["CNPJ"].ToString();
                mskValidade.Text = prod["validade_prod"].ToString();
                prod.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                ConexaoSQL.Fechar();
            }
        }

        private void pcbSair_Click_1(object sender, EventArgs e)
        {
            DialogResult sair =
       MessageBox.Show("Você deseja realmente sair do aplicativo?",
                  "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (sair == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var frmCadProd = new frmCadProd();
            this.Hide();
            frmCadProd.Show();
        }
    }
}
