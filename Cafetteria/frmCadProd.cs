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
            try
            {
                ConexaoSQL.Conectar();

                String sql = @"INSERT INTO caf.Produto VALUES (@Nome, @Descricao, @Valor, @Validade, @CNPJ)";

                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                cmd.Parameters.AddWithValue("Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("Descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("Valor", txtValor.Text);
                cmd.Parameters.AddWithValue("Validade", mskValidade.Text);
                cmd.Parameters.AddWithValue("CNPJ", txtCNPJ.Text);



                cmd.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado com sucesso");

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

        private void pcbLimpar_Click(object sender, EventArgs e)
        {
            {
                DialogResult limparCampos =
             MessageBox.Show("Você deseja realmente limpar todos os campos?",
                        "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (limparCampos == DialogResult.Yes)
                {
                    txtNome.Clear();
                    txtDescricao.Clear();
                    txtValor.Clear();
                    mskValidade.Clear();
                    txtCNPJ.Clear();
                }
            }
        }

        private void btnAltrarExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                ConexaoSQL.Conectar();
                string sql = @"delete from caf.Produto where nm_prod = @Nome";

                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                cmd.Parameters.AddWithValue("Nome", txtNome.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto excluido com sucesso!");

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

            try
            {
                String sql = @"update caf.Produto set  Nm_prod = @Nome, desc_prod = @Descricao, 
                val_prod = @Valor, validade_prod = @Validade, CNPJ = @CNPJ)";
                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                cmd.Parameters.AddWithValue("Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("Descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("valor", txtValor.Text);
                cmd.Parameters.AddWithValue("Validade", mskValidade.Text);
                cmd.Parameters.AddWithValue("CNPJ", txtCNPJ.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto alterado com sucesso");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: ", ex.Message);
                throw;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
