namespace Cafetteria
{
    partial class frmCadFunc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblCadFunc = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.erpPreencherCampos = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCadastrarFunc = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pcbLogoCafe = new System.Windows.Forms.PictureBox();
            this.btnAltrarExcluir = new System.Windows.Forms.Button();
            this.pcbLimpar = new System.Windows.Forms.PictureBox();
            this.pcbSair = new System.Windows.Forms.PictureBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpPreencherCampos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoCafe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLimpar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlTop.Controls.Add(this.pcbSair);
            this.pnlTop.Controls.Add(this.btnCancelar);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(657, 56);
            this.pnlTop.TabIndex = 13;
            // 
            // lblCadFunc
            // 
            this.lblCadFunc.AutoSize = true;
            this.lblCadFunc.BackColor = System.Drawing.Color.Transparent;
            this.lblCadFunc.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadFunc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCadFunc.Location = new System.Drawing.Point(223, 92);
            this.lblCadFunc.Name = "lblCadFunc";
            this.lblCadFunc.Size = new System.Drawing.Size(269, 22);
            this.lblCadFunc.TabIndex = 34;
            this.lblCadFunc.Text = "Cadastro de Funcionários";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(138, 141);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(138, 26);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(72, 149);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 18);
            this.lblNome.TabIndex = 22;
            this.lblNome.Text = "Nome:";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.BackColor = System.Drawing.Color.Transparent;
            this.lblContato.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblContato.Location = new System.Drawing.Point(53, 254);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(79, 18);
            this.lblContato.TabIndex = 24;
            this.lblContato.Text = "Contato:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblEnd.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblEnd.Location = new System.Drawing.Point(43, 303);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(89, 18);
            this.lblEnd.TabIndex = 26;
            this.lblEnd.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(138, 295);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(439, 26);
            this.txtEndereco.TabIndex = 4;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCargo.Location = new System.Drawing.Point(72, 215);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(60, 18);
            this.lblCargo.TabIndex = 28;
            this.lblCargo.Text = "Cargo:";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(138, 211);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(237, 26);
            this.txtCargo.TabIndex = 3;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.BackColor = System.Drawing.Color.Transparent;
            this.lblSalario.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSalario.Location = new System.Drawing.Point(65, 340);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(67, 18);
            this.lblSalario.TabIndex = 30;
            this.lblSalario.Text = "Salário:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(138, 332);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(195, 26);
            this.txtSalario.TabIndex = 5;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(138, 177);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(237, 26);
            this.txtCPF.TabIndex = 1;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.BackColor = System.Drawing.Color.Transparent;
            this.lblCPF.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCPF.Location = new System.Drawing.Point(90, 181);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(42, 18);
            this.lblCPF.TabIndex = 33;
            this.lblCPF.Text = "CPF:";
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 475);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(657, 17);
            this.pnlBottom.TabIndex = 36;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSenha.Location = new System.Drawing.Point(65, 382);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(62, 18);
            this.lblSenha.TabIndex = 37;
            this.lblSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(138, 374);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(173, 26);
            this.txtSenha.TabIndex = 6;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // txtContato
            // 
            this.txtContato.Location = new System.Drawing.Point(138, 250);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(237, 26);
            this.txtContato.TabIndex = 2;
            // 
            // erpPreencherCampos
            // 
            this.erpPreencherCampos.ContainerControl = this;
            // 
            // btnCadastrarFunc
            // 
            this.btnCadastrarFunc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarFunc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCadastrarFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFunc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCadastrarFunc.Image = global::Cafetteria.Properties.Resources.cadastro__1_;
            this.btnCadastrarFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarFunc.Location = new System.Drawing.Point(483, 423);
            this.btnCadastrarFunc.Name = "btnCadastrarFunc";
            this.btnCadastrarFunc.Size = new System.Drawing.Size(145, 36);
            this.btnCadastrarFunc.TabIndex = 7;
            this.btnCadastrarFunc.Text = "Cadastrar";
            this.btnCadastrarFunc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarFunc.UseVisualStyleBackColor = false;
            this.btnCadastrarFunc.Click += new System.EventHandler(this.btnCadastrarFunc_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelar.Image = global::Cafetteria.Properties.Resources.botao_voltar__1_;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Location = new System.Drawing.Point(12, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(39, 31);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pcbLogoCafe
            // 
            this.pcbLogoCafe.Image = global::Cafetteria.Properties.Resources.logo_cafetteria;
            this.pcbLogoCafe.Location = new System.Drawing.Point(179, 81);
            this.pcbLogoCafe.Name = "pcbLogoCafe";
            this.pcbLogoCafe.Size = new System.Drawing.Size(38, 33);
            this.pcbLogoCafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogoCafe.TabIndex = 37;
            this.pcbLogoCafe.TabStop = false;
            // 
            // btnAltrarExcluir
            // 
            this.btnAltrarExcluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAltrarExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAltrarExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAltrarExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAltrarExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltrarExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAltrarExcluir.Image = global::Cafetteria.Properties.Resources.alterar__1_;
            this.btnAltrarExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAltrarExcluir.Location = new System.Drawing.Point(331, 423);
            this.btnAltrarExcluir.Name = "btnAltrarExcluir";
            this.btnAltrarExcluir.Size = new System.Drawing.Size(146, 36);
            this.btnAltrarExcluir.TabIndex = 9;
            this.btnAltrarExcluir.Text = "Alterar/Excluir";
            this.btnAltrarExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltrarExcluir.UseVisualStyleBackColor = false;
            this.btnAltrarExcluir.Click += new System.EventHandler(this.btnAltrarExcluir_Click);
            // 
            // pcbLimpar
            // 
            this.pcbLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbLimpar.Image = global::Cafetteria.Properties.Resources.borracha__1_;
            this.pcbLimpar.Location = new System.Drawing.Point(12, 433);
            this.pcbLimpar.Name = "pcbLimpar";
            this.pcbLimpar.Size = new System.Drawing.Size(39, 36);
            this.pcbLimpar.TabIndex = 38;
            this.pcbLimpar.TabStop = false;
            this.pcbLimpar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pcbSair
            // 
            this.pcbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbSair.Image = global::Cafetteria.Properties.Resources.fechar__1_;
            this.pcbSair.Location = new System.Drawing.Point(611, 12);
            this.pcbSair.Name = "pcbSair";
            this.pcbSair.Size = new System.Drawing.Size(34, 32);
            this.pcbSair.TabIndex = 83;
            this.pcbSair.TabStop = false;
            // 
            // frmCadFunc
            // 
            this.AcceptButton = this.btnCadastrarFunc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(657, 492);
            this.Controls.Add(this.pcbLogoCafe);
            this.Controls.Add(this.btnAltrarExcluir);
            this.Controls.Add(this.lblCadFunc);
            this.Controls.Add(this.pcbLimpar);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.btnCadastrarFunc);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadFunc";
            this.Load += new System.EventHandler(this.frmCadFunc_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erpPreencherCampos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoCafe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLimpar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblCadFunc;
        private System.Windows.Forms.Button btnCadastrarFunc;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.PictureBox pcbLogoCafe;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.ErrorProvider erpPreencherCampos;
        private System.Windows.Forms.PictureBox pcbLimpar;
        private System.Windows.Forms.Button btnAltrarExcluir;
        private System.Windows.Forms.PictureBox pcbSair;
    }
}