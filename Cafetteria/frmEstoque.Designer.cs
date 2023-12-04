namespace Cafetteria
{
    partial class frmEstoque
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
            this.lblEstoqueId = new System.Windows.Forms.Label();
            this.lblFazerBusca = new System.Windows.Forms.Label();
            this.txtEstoqueID = new System.Windows.Forms.TextBox();
            this.lblIDProd = new System.Windows.Forms.Label();
            this.lblForn = new System.Windows.Forms.Label();
            this.lblDescProd = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.txtProd = new System.Windows.Forms.TextBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.mskValidadeProd = new System.Windows.Forms.MaskedTextBox();
            this.txtDescProd = new System.Windows.Forms.TextBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.pnlTop.TabIndex = 14;
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
            // lblEstoqueId
            // 
            this.lblEstoqueId.AutoSize = true;
            this.lblEstoqueId.BackColor = System.Drawing.Color.Transparent;
            this.lblEstoqueId.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstoqueId.ForeColor = System.Drawing.Color.Black;
            this.lblEstoqueId.Location = new System.Drawing.Point(200, 143);
            this.lblEstoqueId.Name = "lblEstoqueId";
            this.lblEstoqueId.Size = new System.Drawing.Size(104, 18);
            this.lblEstoqueId.TabIndex = 66;
            this.lblEstoqueId.Text = "Estoque ID:";
            // 
            // lblFazerBusca
            // 
            this.lblFazerBusca.AutoSize = true;
            this.lblFazerBusca.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFazerBusca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblFazerBusca.Location = new System.Drawing.Point(217, 79);
            this.lblFazerBusca.Name = "lblFazerBusca";
            this.lblFazerBusca.Size = new System.Drawing.Size(235, 29);
            this.lblFazerBusca.TabIndex = 74;
            this.lblFazerBusca.Text = "Estoque | Detalhes";
            // 
            // txtEstoqueID
            // 
            this.txtEstoqueID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstoqueID.Location = new System.Drawing.Point(304, 139);
            this.txtEstoqueID.Name = "txtEstoqueID";
            this.txtEstoqueID.Size = new System.Drawing.Size(148, 26);
            this.txtEstoqueID.TabIndex = 75;
            // 
            // lblIDProd
            // 
            this.lblIDProd.AutoSize = true;
            this.lblIDProd.BackColor = System.Drawing.Color.Transparent;
            this.lblIDProd.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDProd.ForeColor = System.Drawing.Color.Black;
            this.lblIDProd.Location = new System.Drawing.Point(199, 179);
            this.lblIDProd.Name = "lblIDProd";
            this.lblIDProd.Size = new System.Drawing.Size(101, 18);
            this.lblIDProd.TabIndex = 76;
            this.lblIDProd.Text = "Produto ID:";
            // 
            // lblForn
            // 
            this.lblForn.AutoSize = true;
            this.lblForn.BackColor = System.Drawing.Color.Transparent;
            this.lblForn.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForn.ForeColor = System.Drawing.Color.Black;
            this.lblForn.Location = new System.Drawing.Point(194, 225);
            this.lblForn.Name = "lblForn";
            this.lblForn.Size = new System.Drawing.Size(104, 18);
            this.lblForn.TabIndex = 77;
            this.lblForn.Text = "Fornecedor:";
            // 
            // lblDescProd
            // 
            this.lblDescProd.AutoSize = true;
            this.lblDescProd.BackColor = System.Drawing.Color.Transparent;
            this.lblDescProd.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescProd.ForeColor = System.Drawing.Color.Black;
            this.lblDescProd.Location = new System.Drawing.Point(102, 297);
            this.lblDescProd.Name = "lblDescProd";
            this.lblDescProd.Size = new System.Drawing.Size(189, 18);
            this.lblDescProd.TabIndex = 78;
            this.lblDescProd.Text = "Descrição do Produto:";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.BackColor = System.Drawing.Color.Transparent;
            this.lblQuant.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuant.ForeColor = System.Drawing.Color.Black;
            this.lblQuant.Location = new System.Drawing.Point(185, 341);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(106, 18);
            this.lblQuant.TabIndex = 79;
            this.lblQuant.Text = "Quantidade:";
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.BackColor = System.Drawing.Color.Transparent;
            this.lblValidade.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade.ForeColor = System.Drawing.Color.Black;
            this.lblValidade.Location = new System.Drawing.Point(140, 388);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(151, 18);
            this.lblValidade.TabIndex = 80;
            this.lblValidade.Text = "Validade Produto:";
            // 
            // txtProd
            // 
            this.txtProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProd.Location = new System.Drawing.Point(304, 180);
            this.txtProd.Name = "txtProd";
            this.txtProd.Size = new System.Drawing.Size(148, 26);
            this.txtProd.TabIndex = 83;
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornecedor.Location = new System.Drawing.Point(304, 226);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(148, 26);
            this.txtFornecedor.TabIndex = 84;
            // 
            // txtQuant
            // 
            this.txtQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuant.Location = new System.Drawing.Point(304, 337);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(148, 26);
            this.txtQuant.TabIndex = 87;
            // 
            // mskValidadeProd
            // 
            this.mskValidadeProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskValidadeProd.Location = new System.Drawing.Point(304, 384);
            this.mskValidadeProd.Mask = "00/00/0000";
            this.mskValidadeProd.Name = "mskValidadeProd";
            this.mskValidadeProd.Size = new System.Drawing.Size(115, 26);
            this.mskValidadeProd.TabIndex = 88;
            this.mskValidadeProd.ValidatingType = typeof(System.DateTime);
            // 
            // txtDescProd
            // 
            this.txtDescProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescProd.Location = new System.Drawing.Point(304, 293);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.Size = new System.Drawing.Size(223, 26);
            this.txtDescProd.TabIndex = 94;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 482);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(657, 10);
            this.pnlBottom.TabIndex = 95;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cafetteria.Properties.Resources.logo_cafetteria;
            this.pictureBox1.Location = new System.Drawing.Point(607, 454);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
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
            this.btnPesquisar.Location = new System.Drawing.Point(447, 178);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(31, 28);
            this.btnPesquisar.TabIndex = 93;
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(657, 492);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.txtDescProd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtProd);
            this.Controls.Add(this.mskValidadeProd);
            this.Controls.Add(this.txtQuant);
            this.Controls.Add(this.txtFornecedor);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.lblDescProd);
            this.Controls.Add(this.lblForn);
            this.Controls.Add(this.lblIDProd);
            this.Controls.Add(this.txtEstoqueID);
            this.Controls.Add(this.lblEstoqueId);
            this.Controls.Add(this.lblFazerBusca);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEstoque";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblEstoqueId;
        private System.Windows.Forms.Label lblFazerBusca;
        private System.Windows.Forms.TextBox txtEstoqueID;
        private System.Windows.Forms.Label lblIDProd;
        private System.Windows.Forms.Label lblForn;
        private System.Windows.Forms.Label lblDescProd;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.TextBox txtProd;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtQuant;
        private System.Windows.Forms.MaskedTextBox mskValidadeProd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtDescProd;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.PictureBox pcbVoltar;
        private System.Windows.Forms.PictureBox pcbSair;
    }
}