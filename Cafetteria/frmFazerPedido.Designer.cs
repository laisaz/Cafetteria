namespace Cafetteria
{
    partial class frmFazerPedido
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pcbSair = new System.Windows.Forms.PictureBox();
            this.pcbVoltar = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.txtCodForn = new System.Windows.Forms.TextBox();
            this.lblCodForn = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.mskValidade = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCadastrarForn = new System.Windows.Forms.Button();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlTop.Controls.Add(this.pcbSair);
            this.pnlTop.Controls.Add(this.pcbVoltar);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(657, 55);
            this.pnlTop.TabIndex = 15;
            // 
            // pcbSair
            // 
            this.pcbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbSair.Image = global::Cafetteria.Properties.Resources.fechar__1_;
            this.pcbSair.Location = new System.Drawing.Point(611, 12);
            this.pcbSair.Name = "pcbSair";
            this.pcbSair.Size = new System.Drawing.Size(34, 32);
            this.pcbSair.TabIndex = 97;
            this.pcbSair.TabStop = false;
            this.pcbSair.Click += new System.EventHandler(this.pcbSair_Click);
            // 
            // pcbVoltar
            // 
            this.pcbVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbVoltar.Image = global::Cafetteria.Properties.Resources.botao_voltar__1_;
            this.pcbVoltar.Location = new System.Drawing.Point(12, 12);
            this.pcbVoltar.Name = "pcbVoltar";
            this.pcbVoltar.Size = new System.Drawing.Size(33, 30);
            this.pcbVoltar.TabIndex = 96;
            this.pcbVoltar.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 482);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(657, 10);
            this.pnlBottom.TabIndex = 96;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.BackColor = System.Drawing.SystemColors.Window;
            this.txtCNPJ.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCNPJ.Location = new System.Drawing.Point(282, 109);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(241, 26);
            this.txtCNPJ.TabIndex = 98;
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.lblCNPJ.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCNPJ.Location = new System.Drawing.Point(223, 113);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(53, 18);
            this.lblCNPJ.TabIndex = 99;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // txtCodForn
            // 
            this.txtCodForn.BackColor = System.Drawing.SystemColors.Window;
            this.txtCodForn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCodForn.Location = new System.Drawing.Point(132, 109);
            this.txtCodForn.Name = "txtCodForn";
            this.txtCodForn.Size = new System.Drawing.Size(85, 26);
            this.txtCodForn.TabIndex = 100;
            // 
            // lblCodForn
            // 
            this.lblCodForn.AutoSize = true;
            this.lblCodForn.BackColor = System.Drawing.Color.Transparent;
            this.lblCodForn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodForn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCodForn.Location = new System.Drawing.Point(57, 113);
            this.lblCodForn.Name = "lblCodForn";
            this.lblCodForn.Size = new System.Drawing.Size(69, 18);
            this.lblCodForn.TabIndex = 101;
            this.lblCodForn.Text = "Código:";
            // 
            // lblFornecedor
            // 
            this.lblFornecedor.AutoSize = true;
            this.lblFornecedor.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFornecedor.ForeColor = System.Drawing.Color.DimGray;
            this.lblFornecedor.Location = new System.Drawing.Point(128, 73);
            this.lblFornecedor.Name = "lblFornecedor";
            this.lblFornecedor.Size = new System.Drawing.Size(117, 23);
            this.lblFornecedor.TabIndex = 102;
            this.lblFornecedor.Text = "Fornecedor:";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.Color.DimGray;
            this.lblProduto.Location = new System.Drawing.Point(128, 156);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(89, 23);
            this.lblProduto.TabIndex = 103;
            this.lblProduto.Text = "Produto:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 309);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(414, 147);
            this.dataGridView1.TabIndex = 104;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(132, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(307, 26);
            this.textBox2.TabIndex = 107;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(66, 200);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 18);
            this.lblNome.TabIndex = 108;
            this.lblNome.Text = "Nome:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox3.Location = new System.Drawing.Point(132, 229);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(85, 26);
            this.textBox3.TabIndex = 109;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblValor.Location = new System.Drawing.Point(66, 237);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(54, 18);
            this.lblValor.TabIndex = 110;
            this.lblValor.Text = "Valor:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox4.Location = new System.Drawing.Point(282, 229);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(85, 26);
            this.textBox4.TabIndex = 111;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.BackColor = System.Drawing.Color.Transparent;
            this.lblQtd.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblQtd.Location = new System.Drawing.Point(234, 233);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(42, 18);
            this.lblQtd.TabIndex = 112;
            this.lblQtd.Text = "Qtd:";
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.BackColor = System.Drawing.Color.Transparent;
            this.lblValidade.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblValidade.Location = new System.Drawing.Point(39, 268);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(81, 18);
            this.lblValidade.TabIndex = 114;
            this.lblValidade.Text = "Validade:";
            // 
            // mskValidade
            // 
            this.mskValidade.Location = new System.Drawing.Point(132, 260);
            this.mskValidade.Mask = "00/00/0000";
            this.mskValidade.Name = "mskValidade";
            this.mskValidade.Size = new System.Drawing.Size(121, 26);
            this.mskValidade.TabIndex = 115;
            this.mskValidade.ValidatingType = typeof(System.DateTime);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPesquisar.Image = global::Cafetteria.Properties.Resources._6423875__1_;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(515, 107);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(31, 28);
            this.btnPesquisar.TabIndex = 116;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrarForn
            // 
            this.btnCadastrarForn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarForn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarForn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCadastrarForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarForn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCadastrarForn.Image = global::Cafetteria.Properties.Resources.cadastro__1_;
            this.btnCadastrarForn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarForn.Location = new System.Drawing.Point(498, 391);
            this.btnCadastrarForn.Name = "btnCadastrarForn";
            this.btnCadastrarForn.Size = new System.Drawing.Size(108, 45);
            this.btnCadastrarForn.TabIndex = 117;
            this.btnCadastrarForn.Text = "FAZER\r\nPEDIDO";
            this.btnCadastrarForn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarForn.UseVisualStyleBackColor = false;
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalCompra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotalCompra.Location = new System.Drawing.Point(498, 348);
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(112, 26);
            this.txtTotalCompra.TabIndex = 118;
            // 
            // lblTotalCompra
            // 
            this.lblTotalCompra.AutoSize = true;
            this.lblTotalCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCompra.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTotalCompra.Location = new System.Drawing.Point(495, 309);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(74, 36);
            this.lblTotalCompra.TabIndex = 119;
            this.lblTotalCompra.Text = "Total \r\nCompra:";
            // 
            // frmFazerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(657, 492);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtTotalCompra);
            this.Controls.Add(this.lblTotalCompra);
            this.Controls.Add(this.btnCadastrarForn);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.mskValidade);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.txtCodForn);
            this.Controls.Add(this.lblCodForn);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFazerPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFazerPedido";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pcbSair;
        private System.Windows.Forms.PictureBox pcbVoltar;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.TextBox txtCodForn;
        private System.Windows.Forms.Label lblCodForn;
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.MaskedTextBox mskValidade;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCadastrarForn;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Label lblTotalCompra;
    }
}