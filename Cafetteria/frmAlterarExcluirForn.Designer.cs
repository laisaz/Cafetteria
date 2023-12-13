namespace Cafetteria
{
    partial class frmAlterarExcluirForn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlterarExcluirForn));
            this.lblExpressoEncantado = new System.Windows.Forms.Label();
            this.lblCafetteria = new System.Windows.Forms.Label();
            this.lblBuscarCNPJ = new System.Windows.Forms.Label();
            this.lblFazerBusca = new System.Windows.Forms.Label();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.pcbLogoCafe = new System.Windows.Forms.PictureBox();
            this.btnBuscarCNPJ = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pcbSair = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblDadosForn = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblContato = new System.Windows.Forms.Label();
            this.lblRazaoSocial = new System.Windows.Forms.Label();
            this.lnlNome = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtContato = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoCafe)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExpressoEncantado
            // 
            this.lblExpressoEncantado.AutoSize = true;
            this.lblExpressoEncantado.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpressoEncantado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblExpressoEncantado.Location = new System.Drawing.Point(439, 134);
            this.lblExpressoEncantado.Name = "lblExpressoEncantado";
            this.lblExpressoEncantado.Size = new System.Drawing.Size(139, 18);
            this.lblExpressoEncantado.TabIndex = 87;
            this.lblExpressoEncantado.Text = "Expresso Encantado";
            // 
            // lblCafetteria
            // 
            this.lblCafetteria.AutoSize = true;
            this.lblCafetteria.BackColor = System.Drawing.Color.Transparent;
            this.lblCafetteria.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCafetteria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCafetteria.Location = new System.Drawing.Point(454, 112);
            this.lblCafetteria.Name = "lblCafetteria";
            this.lblCafetteria.Size = new System.Drawing.Size(110, 22);
            this.lblCafetteria.TabIndex = 86;
            this.lblCafetteria.Text = "Cafetteria";
            // 
            // lblBuscarCNPJ
            // 
            this.lblBuscarCNPJ.AutoSize = true;
            this.lblBuscarCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarCNPJ.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCNPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblBuscarCNPJ.Location = new System.Drawing.Point(53, 110);
            this.lblBuscarCNPJ.Name = "lblBuscarCNPJ";
            this.lblBuscarCNPJ.Size = new System.Drawing.Size(53, 18);
            this.lblBuscarCNPJ.TabIndex = 85;
            this.lblBuscarCNPJ.Text = "CNPJ:";
            // 
            // lblFazerBusca
            // 
            this.lblFazerBusca.AutoSize = true;
            this.lblFazerBusca.Font = new System.Drawing.Font("Kristen ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFazerBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFazerBusca.Location = new System.Drawing.Point(108, 67);
            this.lblFazerBusca.Name = "lblFazerBusca";
            this.lblFazerBusca.Size = new System.Drawing.Size(73, 22);
            this.lblFazerBusca.TabIndex = 84;
            this.lblFazerBusca.Text = "Buscar:";
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNPJ.Location = new System.Drawing.Point(112, 102);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(275, 26);
            this.txtCNPJ.TabIndex = 82;
            // 
            // pcbLogoCafe
            // 
            this.pcbLogoCafe.Image = global::Cafetteria.Properties.Resources.logo_cafetteria;
            this.pcbLogoCafe.Location = new System.Drawing.Point(486, 155);
            this.pcbLogoCafe.Name = "pcbLogoCafe";
            this.pcbLogoCafe.Size = new System.Drawing.Size(38, 23);
            this.pcbLogoCafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogoCafe.TabIndex = 88;
            this.pcbLogoCafe.TabStop = false;
            // 
            // btnBuscarCNPJ
            // 
            this.btnBuscarCNPJ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarCNPJ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCNPJ.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBuscarCNPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCNPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBuscarCNPJ.Image = global::Cafetteria.Properties.Resources._702988__1_;
            this.btnBuscarCNPJ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCNPJ.Location = new System.Drawing.Point(271, 134);
            this.btnBuscarCNPJ.Name = "btnBuscarCNPJ";
            this.btnBuscarCNPJ.Size = new System.Drawing.Size(116, 36);
            this.btnBuscarCNPJ.TabIndex = 83;
            this.btnBuscarCNPJ.Text = "Pesquisar";
            this.btnBuscarCNPJ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCNPJ.UseVisualStyleBackColor = false;
            this.btnBuscarCNPJ.Click += new System.EventHandler(this.btnBuscarCNPJ_Click);
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
            this.pnlTop.Size = new System.Drawing.Size(641, 53);
            this.pnlTop.TabIndex = 89;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // pcbSair
            // 
            this.pcbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbSair.Image = global::Cafetteria.Properties.Resources.fechar__1_;
            this.pcbSair.Location = new System.Drawing.Point(588, 12);
            this.pcbSair.Name = "pcbSair";
            this.pcbSair.Size = new System.Drawing.Size(34, 32);
            this.pcbSair.TabIndex = 84;
            this.pcbSair.TabStop = false;
            this.pcbSair.Click += new System.EventHandler(this.pcbSair_Click);
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
            this.btnCancelar.Size = new System.Drawing.Size(39, 33);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 443);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(641, 10);
            this.pnlBottom.TabIndex = 90;
            // 
            // lblDadosForn
            // 
            this.lblDadosForn.AutoSize = true;
            this.lblDadosForn.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosForn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDadosForn.Location = new System.Drawing.Point(109, 210);
            this.lblDadosForn.Name = "lblDadosForn";
            this.lblDadosForn.Size = new System.Drawing.Size(119, 36);
            this.lblDadosForn.TabIndex = 91;
            this.lblDadosForn.Text = "Dados \r\ndo Fornecedor:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblEnd.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblEnd.Location = new System.Drawing.Point(9, 302);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(89, 18);
            this.lblEnd.TabIndex = 101;
            this.lblEnd.Text = "Endereço:";
            // 
            // lblContato
            // 
            this.lblContato.AutoSize = true;
            this.lblContato.BackColor = System.Drawing.Color.Transparent;
            this.lblContato.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblContato.Location = new System.Drawing.Point(27, 336);
            this.lblContato.Name = "lblContato";
            this.lblContato.Size = new System.Drawing.Size(79, 18);
            this.lblContato.TabIndex = 100;
            this.lblContato.Text = "Contato:";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.BackColor = System.Drawing.Color.Transparent;
            this.lblRazaoSocial.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazaoSocial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblRazaoSocial.Location = new System.Drawing.Point(350, 343);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(118, 18);
            this.lblRazaoSocial.TabIndex = 99;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // lnlNome
            // 
            this.lnlNome.AutoSize = true;
            this.lnlNome.BackColor = System.Drawing.Color.Transparent;
            this.lnlNome.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lnlNome.Location = new System.Drawing.Point(41, 262);
            this.lnlNome.Name = "lnlNome";
            this.lnlNome.Size = new System.Drawing.Size(60, 18);
            this.lnlNome.TabIndex = 98;
            this.lnlNome.Text = "Nome:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExcluir.Image = global::Cafetteria.Properties.Resources.lata_de_lixo__1_;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(414, 381);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 36);
            this.btnExcluir.TabIndex = 103;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlterar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAlterar.Image = global::Cafetteria.Properties.Resources.alterar__1_;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(521, 381);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(101, 36);
            this.btnAlterar.TabIndex = 102;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(112, 262);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(275, 26);
            this.txtNome.TabIndex = 104;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(112, 294);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(510, 26);
            this.txtEndereco.TabIndex = 105;
            // 
            // txtContato
            // 
            this.txtContato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContato.Location = new System.Drawing.Point(112, 335);
            this.txtContato.Name = "txtContato";
            this.txtContato.Size = new System.Drawing.Size(219, 26);
            this.txtContato.TabIndex = 106;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Location = new System.Drawing.Point(474, 335);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(148, 26);
            this.txtRazaoSocial.TabIndex = 107;
            // 
            // frmAlterarExcluirForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(641, 453);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.txtContato);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblContato);
            this.Controls.Add(this.lblRazaoSocial);
            this.Controls.Add(this.lnlNome);
            this.Controls.Add(this.lblDadosForn);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lblExpressoEncantado);
            this.Controls.Add(this.lblCafetteria);
            this.Controls.Add(this.pcbLogoCafe);
            this.Controls.Add(this.lblBuscarCNPJ);
            this.Controls.Add(this.lblFazerBusca);
            this.Controls.Add(this.btnBuscarCNPJ);
            this.Controls.Add(this.txtCNPJ);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAlterarExcluirForn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlterarExcluirForn";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoCafe)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExpressoEncantado;
        private System.Windows.Forms.Label lblCafetteria;
        private System.Windows.Forms.PictureBox pcbLogoCafe;
        private System.Windows.Forms.Label lblBuscarCNPJ;
        private System.Windows.Forms.Label lblFazerBusca;
        private System.Windows.Forms.Button btnBuscarCNPJ;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pcbSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblDadosForn;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblContato;
        private System.Windows.Forms.Label lblRazaoSocial;
        private System.Windows.Forms.Label lnlNome;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtContato;
        private System.Windows.Forms.TextBox txtRazaoSocial;
    }
}