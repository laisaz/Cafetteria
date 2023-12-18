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
using System.IO;

namespace Cafetteria
{
    public partial class frmCadFunc : Form
    {
        public frmCadFunc()
        {
            InitializeComponent();
        }

        private void btnCadastrarFunc_Click(object sender, EventArgs e)
        {
            if (txtNome.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtNome, "Preencha o campo nome");
                return;
            }

            else
            {
                erpPreencherCampos.SetError(txtNome, "");
            }

            if (txtContato.Text.Trim().Length == 0)
            {
                erpPreencherCampos.SetError(txtContato, "Preencha o campo de Contato");
                return;
            }

            try
            {
                ConexaoSQL.Conectar();
                String sql = @"INSERT INTO caf.Funcionario VALUES (@CPF, @nome, @endereco, @contato, @cargo ,@salario)";

                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                cmd.Parameters.AddWithValue("CPF", txtCPF.Text);
                cmd.Parameters.AddWithValue("nome", txtNome.Text);
                cmd.Parameters.AddWithValue("endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("contato", txtCargo.Text);
                cmd.Parameters.AddWithValue("cargo", txtCargo.Text);
                cmd.Parameters.AddWithValue("salario", txtSalario.Text);
 
                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario cadastrado com sucesso!");

                ConexaoSQL.Fechar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }

            try
            {
                ConexaoSQL.Conectar();

                String sql = @"INSERT INTO caf.Login VALUES (@senha, @CPF)";

                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                cmd.Parameters.AddWithValue("CPF", txtCPF.Text);
                cmd.Parameters.AddWithValue("senha", txtSenha.Text);



                cmd.ExecuteNonQuery();

                MessageBox.Show("Login feito com sucesso!");

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult limparCampos =
         MessageBox.Show("Você deseja realmente limpar todos os campos?",
                    "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (limparCampos == DialogResult.Yes)
            {
                txtCargo.Clear();
                txtContato.Clear();
                txtCPF.Clear();
                txtEndereco.Clear();
                txtNome.Clear();
                txtSalario.Clear();
                txtSenha.Clear();
            }
        }

        private void frmCadFunc_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
            menu.ShowDialog();
        }

        private void btnAltrarExcluir_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu menu = new frmMenu();
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
    }
}


