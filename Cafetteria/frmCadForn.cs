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
    public partial class frmCadForn : Form
    {
        public frmCadForn()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var frmMenu = new frmMenu();
            this.Hide();
            frmMenu.Show();
        }

        private void btnCadastrarForn_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoSQL.Conectar();

                String sql = @"INSERT INTO caf.Fornecedor VALUES (@Nome, @Razao, @Contato, @Endereco)";

                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                cmd.Parameters.AddWithValue("Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("Razao", txtRazaoSocial.Text);
                cmd.Parameters.AddWithValue("Contato", txtContato.Text);
                cmd.Parameters.AddWithValue("Endereco", txtEndereco.Text);



                cmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor cadastrado com sucesso");

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

        private void btnAltrarExcluir_Click(object sender, EventArgs e)
        {
            frmAlterarExcluirForn teste = new frmAlterarExcluirForn();
            this.Hide();
            teste.Show();
        }

        private void pcbSair_Click(object sender, EventArgs e)
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
}
