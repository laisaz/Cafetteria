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
using static System.Net.Mime.MediaTypeNames;

namespace Cafetteria
{
    public partial class frmExcluirAlterar : Form
    {
        public frmExcluirAlterar()
        {
            InitializeComponent();
        }

        private void lblCPF_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        { 
            try
            {

                ConexaoSQL.Conectar();
                string sql = @"delete from caf.Login where CPF = @CPF";

                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                cmd.Parameters.AddWithValue("CPF", txtCPF.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Login excluido com sucesso!");

                //Utils.limparCampos(this);
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

                ConexaoSQL.Conectar();
                string sql = @"delete from caf.Funcionario where CPF = @CPF";

                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                cmd.Parameters.AddWithValue("CPF", txtCPF.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Funcionario excluido com sucesso!");

                //Utils.limparCampos(this);
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
            txtCPF.Clear();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoSQL.Conectar();
                string sql = @"update caf.Funcionario set nm_func = @nome,end_func = @endereco, cont_func = @contato, cargo_func = @cargo ,sal_func = @salario  where CPF=@CPF";

                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                cmd.Parameters.AddWithValue("CPF",txtCPF.Text);
                cmd.Parameters.AddWithValue("nome", txtNome.Text);
                cmd.Parameters.AddWithValue("endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("contato", txtContato.Text);
                cmd.Parameters.AddWithValue("cargo", txtCargo.Text);
                cmd.Parameters.AddWithValue("salario", txtSalario.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario alterado com sucesso");

                //Utils.LimparCampos(this);
                txtNome.Focus();
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
                ConexaoSQL.Conectar();
                string sql = @"update caf.Login set  senha = @senha where CPF = @CPF";

                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                cmd.Parameters.AddWithValue("CPF", txtCPF.Text);
                cmd.Parameters.AddWithValue("senha", txtSenha.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Login alterado com sucesso");

                //Utils.LimparCampos(this);
                txtNome.Focus();
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
            txtCPF.Clear();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text != "")
            {
                try
                {
                    ConexaoSQL.Conectar();
                    string sql = @"select * from caf.Login where CPF like '%" + txtCPF.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dgvFunc.DataSource = dt;
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
                Linha = dgvFunc.CurrentRow;
                txtSenha.Text = Linha.Cells[0].Value.ToString();

                try
                {
                    ConexaoSQL.Conectar();
                    string sql = @"select * from caf.Funcionario where CPF like '%" + txtCPF.Text + "%'";
                    SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    dgvFunc.DataSource = dt;
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

                DataGridViewRow Linha1;
                Linha1 = dgvFunc.CurrentRow;
                txtNome.Text = Linha1.Cells[0].Value.ToString();
                txtEndereco.Text = Linha1.Cells[1].Value.ToString();
                txtContato.Text = Linha1.Cells[2].Value.ToString();
                txtCargo.Text = Linha1.Cells[3].Value.ToString();
                txtSalario.Text = Linha1.Cells[4].Value.ToString();

            }
            else
            {
                MessageBox.Show("Precisa digitar um CPF primeiro");
            }
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
