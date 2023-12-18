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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoSQL.Conectar();

                string sql = @"select * from caf.Login
                            where login = @usuario 
                            AND senha = @senha";

                SqlCommand cmd = new SqlCommand(sql, ConexaoSQL.conn);
                cmd.Parameters.AddWithValue("usuario", txtLogin.Text);
                cmd.Parameters.AddWithValue("senha", txtSenha.Text);

                // select sempre com reader
                SqlDataReader dr = cmd.ExecuteReader();

                //verificação se houve retorno de algum registro
                if (dr.HasRows)
                {
                    //Abrir o sistema - LOGIN EFETUADO
                    dr.Read();
                    var frmMenu = new frmMenu();
                    this.Hide();
                    frmMenu.Show();
                }
                else
                {
                    // ERRO NO LOGIN
                    MessageBox.Show("Usuário e/ou Senha inválidos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
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
