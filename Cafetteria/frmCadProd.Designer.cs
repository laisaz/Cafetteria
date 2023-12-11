namespace Cafetteria
{
    partial class frmCadProd
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAltrarExcluir = new System.Windows.Forms.Button();
            this.pcbLimpar = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCadastrarProd = new System.Windows.Forms.Button();
            this.pcbLogoCafe = new System.Windows.Forms.PictureBox();
            this.lblCadProd = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblValidade = new System.Windows.Forms.Label();
            this.lblCNPJ = new System.Windows.Forms.Label();
            this.mskValidade = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLimpar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoCafe)).BeginInit();
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
            this.pnlTop.TabIndex = 41;
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
            this.btnCancelar.Size = new System.Drawing.Size(39, 31);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.UseVisualStyleBackColor = false;
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
            this.btnAltrarExcluir.Location = new System.Drawing.Point(308, 423);
            this.btnAltrarExcluir.Name = "btnAltrarExcluir";
            this.btnAltrarExcluir.Size = new System.Drawing.Size(146, 36);
            this.btnAltrarExcluir.TabIndex = 40;
            this.btnAltrarExcluir.Text = "Alterar/Excluir";
            this.btnAltrarExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAltrarExcluir.UseVisualStyleBackColor = false;
            // 
            // pcbLimpar
            // 
            this.pcbLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbLimpar.Image = global::Cafetteria.Properties.Resources.borracha__1_;
            this.pcbLimpar.Location = new System.Drawing.Point(12, 433);
            this.pcbLimpar.Name = "pcbLimpar";
            this.pcbLimpar.Size = new System.Drawing.Size(39, 36);
            this.pcbLimpar.TabIndex = 43;
            this.pcbLimpar.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 475);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(657, 17);
            this.pnlBottom.TabIndex = 42;
            // 
            // btnCadastrarProd
            // 
            this.btnCadastrarProd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastrarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrarProd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCadastrarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCadastrarProd.Image = global::Cafetteria.Properties.Resources.cadastro__1_;
            this.btnCadastrarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarProd.Location = new System.Drawing.Point(460, 423);
            this.btnCadastrarProd.Name = "btnCadastrarProd";
            this.btnCadastrarProd.Size = new System.Drawing.Size(145, 36);
            this.btnCadastrarProd.TabIndex = 39;
            this.btnCadastrarProd.Text = "Cadastrar";
            this.btnCadastrarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrarProd.UseVisualStyleBackColor = false;
            // 
            // pcbLogoCafe
            // 
            this.pcbLogoCafe.Image = global::Cafetteria.Properties.Resources.logo_cafetteria;
            this.pcbLogoCafe.Location = new System.Drawing.Point(194, 103);
            this.pcbLogoCafe.Name = "pcbLogoCafe";
            this.pcbLogoCafe.Size = new System.Drawing.Size(38, 33);
            this.pcbLogoCafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogoCafe.TabIndex = 47;
            this.pcbLogoCafe.TabStop = false;
            // 
            // lblCadProd
            // 
            this.lblCadProd.AutoSize = true;
            this.lblCadProd.BackColor = System.Drawing.Color.Transparent;
            this.lblCadProd.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCadProd.Location = new System.Drawing.Point(243, 114);
            this.lblCadProd.Name = "lblCadProd";
            this.lblCadProd.Size = new System.Drawing.Size(228, 22);
            this.lblCadProd.TabIndex = 46;
            this.lblCadProd.Text = "Cadastro de Produtos";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(135, 185);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(470, 26);
            this.txtNome.TabIndex = 44;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(69, 189);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 18);
            this.lblNome.TabIndex = 45;
            this.lblNome.Text = "Nome:";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.BackColor = System.Drawing.Color.Transparent;
            this.lblDesc.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDesc.Location = new System.Drawing.Point(36, 228);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(93, 18);
            this.lblDesc.TabIndex = 48;
            this.lblDesc.Text = "Descrição:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BackColor = System.Drawing.Color.Transparent;
            this.lblValor.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblValor.Location = new System.Drawing.Point(69, 267);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(54, 18);
            this.lblValor.TabIndex = 49;
            this.lblValor.Text = "Valor:";
            // 
            // lblValidade
            // 
            this.lblValidade.AutoSize = true;
            this.lblValidade.BackColor = System.Drawing.Color.Transparent;
            this.lblValidade.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblValidade.Location = new System.Drawing.Point(42, 309);
            this.lblValidade.Name = "lblValidade";
            this.lblValidade.Size = new System.Drawing.Size(81, 18);
            this.lblValidade.TabIndex = 50;
            this.lblValidade.Text = "Validade:";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.BackColor = System.Drawing.Color.Transparent;
            this.lblCNPJ.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCNPJ.Location = new System.Drawing.Point(69, 350);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(53, 18);
            this.lblCNPJ.TabIndex = 51;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // mskValidade
            // 
            this.mskValidade.Location = new System.Drawing.Point(135, 305);
            this.mskValidade.Mask = "00/00/0000";
            this.mskValidade.Name = "mskValidade";
            this.mskValidade.Size = new System.Drawing.Size(205, 26);
            this.mskValidade.TabIndex = 52;
            this.mskValidade.ValidatingType = typeof(System.DateTime);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(135, 224);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(470, 26);
            this.txtDescricao.TabIndex = 53;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(135, 263);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(205, 26);
            this.txtValor.TabIndex = 54;
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(135, 346);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(205, 26);
            this.txtCNPJ.TabIndex = 55;
            // 
            // frmCadProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(657, 492);
            this.Controls.Add(this.txtCNPJ);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.mskValidade);
            this.Controls.Add(this.lblCNPJ);
            this.Controls.Add(this.lblValidade);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.pcbLogoCafe);
            this.Controls.Add(this.lblCadProd);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnAltrarExcluir);
            this.Controls.Add(this.pcbLimpar);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.btnCadastrarProd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCadProd";
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLimpar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoCafe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pcbSair;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAltrarExcluir;
        private System.Windows.Forms.PictureBox pcbLimpar;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnCadastrarProd;
        private System.Windows.Forms.PictureBox pcbLogoCafe;
        private System.Windows.Forms.Label lblCadProd;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblValidade;
        private System.Windows.Forms.Label lblCNPJ;
        private System.Windows.Forms.MaskedTextBox mskValidade;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtCNPJ;
    }
}