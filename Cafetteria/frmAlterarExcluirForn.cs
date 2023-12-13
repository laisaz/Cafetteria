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
    public partial class frmAlterarExcluirForn : Form
    {
        public frmAlterarExcluirForn()
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                String sql = @"update caf.Fornecedor set  CNPJ = @CNPJ, nm_forn = @Nome, razao_social = @Razao, contato_func = @Contato, end_forn = @Endereco)";

                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                cmd.Parameters.AddWithValue("CNPJ", txtCNPJ.Text);
                cmd.Parameters.AddWithValue("Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("Razao", txtRazaoSocial.Text);
                cmd.Parameters.AddWithValue("Contato", txtContato.Text);
                cmd.Parameters.AddWithValue("Endereco", txtEndereco.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Os dados do Fornecedor foi alterado com sucesso!");

                //Utils.LimparCampos(this);
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: ", ex.Message);
                throw;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {

                ConexaoSQL.Conectar();
                string sql = @"delete from caf.Fornecedor where CNPJ = @CNPJ";

                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                cmd.Parameters.AddWithValue("CNPJ", txtCNPJ);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Fornecedor excluido com sucesso!");

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

        private void btnBuscarCNPJ_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoSQL.Conectar();
                string sql = @"SELECT * FROM caf.Fornecedor
                    WHERE CNPJ LIKE '" + txtCNPJ.Text + "%'";
                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);

                SqlDataReader forn = cmd.ExecuteReader();

                forn.Read();

                txtNome.Text = forn["nm_forn"].ToString();
                txtContato.Text = forn["contato_forn"].ToString();
                txtEndereco.Text = forn["end_forn"].ToString();
                txtRazaoSocial.Text = forn["razao_social"].ToString();
                forn.Close();
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

        private void frmAlterarExcluirForn_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            this.Hide();
            menu.ShowDialog();
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

