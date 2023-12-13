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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFazerPedido));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pcbSair = new System.Windows.Forms.PictureBox();
            this.pcbVoltar = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.lblFornecedor = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.dgvProdutosForn = new System.Windows.Forms.DataGridView();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.mskValidade = new System.Windows.Forms.MaskedTextBox();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.lblTotalCompra = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCadastrarForn = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtIDProd = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosForn)).BeginInit();
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
            this.pcbVoltar.Click += new System.EventHandler(this.pcbVoltar_Click);
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
            this.txtCNPJ.Location = new System.Drawing.Point(132, 99);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(241, 26);
            this.txtCNPJ.TabIndex = 98;
            this.txtCNPJ.TextChanged += new System.EventHandler(this.txtCNPJ_TextChanged);
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.lblCNPJ.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCNPJ.Location = new System.Drawing.Point(73, 103);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(53, 18);
            this.lblCNPJ.TabIndex = 99;
            this.lblCNPJ.Text = "CNPJ:";
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
            this.lblProduto.Location = new System.Drawing.Point(128, 263);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(231, 23);
            this.lblProduto.TabIndex = 103;
            this.lblProduto.Text = "Fazer pedido de produto:";
            // 
            // dgvProdutosForn
            // 
            this.dgvProdutosForn.BackgroundColor = System.Drawing.Color.OldLace;
            this.dgvProdutosForn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosForn.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvProdutosForn.Location = new System.Drawing.Point(132, 131);
            this.dgvProdutosForn.Name = "dgvProdutosForn";
            this.dgvProdutosForn.ReadOnly = true;
            this.dgvProdutosForn.Size = new System.Drawing.Size(479, 114);
            this.dgvProdutosForn.TabIndex = 104;
            this.dgvProdutosForn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutosForn_CellContentClick);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(66, 293);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 18);
            this.lblNome.TabIndex = 108;
            this.lblNome.Text = "Nome:";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.SystemColors.Window;
            this.txtValor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtValor.Location = new System.Drawing.Point(132, 322);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(161, 26);
            this.txtValor.TabIndex = 109;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblValor.Location = new System.Drawing.Point(66, 330);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(54, 18);
            this.lblValor.TabIndex = 110;
            this.lblValor.Text = "Valor:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantidade.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQuantidade.Location = new System.Drawing.Point(132, 385);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(85, 26);
            this.txtQuantidade.TabIndex = 111;
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.BackColor = System.Drawing.Color.Transparent;
            this.lblQtd.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblQtd.Location = new System.Drawing.Point(78, 391);
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
            this.lblValidade.Location = new System.Drawing.Point(39, 361);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(81, 18);
            this.lblValidade.TabIndex = 114;
            this.lblValidade.Text = "Validade:";
            // 
            // mskValidade
            // 
            this.mskValidade.Location = new System.Drawing.Point(132, 353);
            this.mskValidade.Mask = "00/00/0000";
            this.mskValidade.Name = "mskValidade";
            this.mskValidade.Size = new System.Drawing.Size(161, 26);
            this.mskValidade.TabIndex = 115;
            this.mskValidade.ValidatingType = typeof(System.DateTime);
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalCompra.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTotalCompra.Location = new System.Drawing.Point(503, 380);
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
            this.lblTotalCompra.Location = new System.Drawing.Point(500, 326);
            this.lblTotalCompra.Name = "lblTotalCompra";
            this.lblTotalCompra.Size = new System.Drawing.Size(74, 36);
            this.lblTotalCompra.TabIndex = 119;
            this.lblTotalCompra.Text = "Total \r\nCompra:";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.SystemColors.Window;
            this.txtNome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNome.Location = new System.Drawing.Point(132, 289);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(313, 26);
            this.txtNome.TabIndex = 107;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPesquisar.Image = global::Cafetteria.Properties.Resources._6423875__1_;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.Location = new System.Drawing.Point(379, 97);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(110, 28);
            this.btnPesquisar.TabIndex = 120;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
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
            this.btnCadastrarForn.Location = new System.Drawing.Point(503, 412);
            this.btnCadastrarForn.Name = "btnCadastrarForn";
            this.btnCadastrarForn.Size = new System.Drawing.Size(108, 45);
            this.btnCadastrarForn.TabIndex = 117;
            this.btnCadastrarForn.Text = "FAZER\r\nPEDIDO";
            this.btnCadastrarForn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarForn.UseVisualStyleBackColor = false;
            this.btnCadastrarForn.Click += new System.EventHandler(this.btnCadastrarForn_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.Location = new System.Drawing.Point(132, 427);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(106, 39);
            this.btnCalcular.TabIndex = 116;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtIDProd
            // 
            this.txtIDProd.BackColor = System.Drawing.SystemColors.Window;
            this.txtIDProd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtIDProd.Location = new System.Drawing.Point(333, 322);
            this.txtIDProd.Name = "txtIDProd";
            this.txtIDProd.Size = new System.Drawing.Size(112, 26);
            this.txtIDProd.TabIndex = 121;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblId.Location = new System.Drawing.Point(299, 330);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 18);
            this.lblId.TabIndex = 122;
            this.lblId.Text = "ID:";
            // 
            // frmFazerPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(657, 492);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtIDProd);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtTotalCompra);
            this.Controls.Add(this.lblTotalCompra);
            this.Controls.Add(this.btnCadastrarForn);
            this.Controls.Add(this.mskValidade);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lblQtd);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dgvProdutosForn);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblFornecedor);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnCalcular);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmFazerPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFazerPedido";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosForn)).EndInit();
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
        private System.Windows.Forms.Label lblFornecedor;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.DataGridView dgvProdutosForn;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.MaskedTextBox mskValidade;
        private System.Windows.Forms.Button btnCadastrarForn;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.Label lblTotalCompra;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtIDProd;
        private System.Windows.Forms.Label lblId;
    }
}