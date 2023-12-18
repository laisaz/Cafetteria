namespace Cafetteria
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pcbSair = new System.Windows.Forms.PictureBox();
            this.lblExpressoEncantado = new System.Windows.Forms.Label();
            this.lblCafetteria = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadFunc = new System.Windows.Forms.Button();
            this.btnCadForn = new System.Windows.Forms.Button();
            this.btnFazerPedido = new System.Windows.Forms.Button();
            this.btnCadProd = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.pcbLogoCafe = new System.Windows.Forms.PictureBox();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoCafe)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnlLeft.Controls.Add(this.pcbSair);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(657, 51);
            this.pnlLeft.TabIndex = 6;
            // 
            // pcbSair
            // 
            this.pcbSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbSair.Image = global::Cafetteria.Properties.Resources.fechar__1_;
            this.pcbSair.Location = new System.Drawing.Point(611, 12);
            this.pcbSair.Name = "pcbSair";
            this.pcbSair.Size = new System.Drawing.Size(34, 32);
            this.pcbSair.TabIndex = 98;
            this.pcbSair.TabStop = false;
            this.pcbSair.Click += new System.EventHandler(this.pcbSair_Click_1);
            // 
            // lblExpressoEncantado
            // 
            this.lblExpressoEncantado.AutoSize = true;
            this.lblExpressoEncantado.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpressoEncantado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblExpressoEncantado.Location = new System.Drawing.Point(274, 403);
            this.lblExpressoEncantado.Name = "lblExpressoEncantado";
            this.lblExpressoEncantado.Size = new System.Drawing.Size(139, 18);
            this.lblExpressoEncantado.TabIndex = 16;
            this.lblExpressoEncantado.Text = "Expresso Encantado";
            // 
            // lblCafetteria
            // 
            this.lblCafetteria.AutoSize = true;
            this.lblCafetteria.BackColor = System.Drawing.Color.Transparent;
            this.lblCafetteria.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCafetteria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCafetteria.Location = new System.Drawing.Point(289, 381);
            this.lblCafetteria.Name = "lblCafetteria";
            this.lblCafetteria.Size = new System.Drawing.Size(110, 22);
            this.lblCafetteria.TabIndex = 15;
            this.lblCafetteria.Text = "Cafetteria";
            this.lblCafetteria.Click += new System.EventHandler(this.lblCafetteria_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Lucida Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblMenu.Location = new System.Drawing.Point(304, 91);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(71, 22);
            this.lblMenu.TabIndex = 19;
            this.lblMenu.Text = "MENU";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 13);
            this.panel1.TabIndex = 25;
            // 
            // btnCadFunc
            // 
            this.btnCadFunc.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCadFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadFunc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCadFunc.Image = global::Cafetteria.Properties.Resources.funcionarios__1_;
            this.btnCadFunc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadFunc.Location = new System.Drawing.Point(342, 207);
            this.btnCadFunc.Name = "btnCadFunc";
            this.btnCadFunc.Size = new System.Drawing.Size(150, 63);
            this.btnCadFunc.TabIndex = 5;
            this.btnCadFunc.Text = "CADASTRO DE\r\nFUNCIONÁRIO\r\n\r\n";
            this.btnCadFunc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadFunc.UseVisualStyleBackColor = false;
            this.btnCadFunc.Click += new System.EventHandler(this.btnCadFunc_Click);
            // 
            // btnCadForn
            // 
            this.btnCadForn.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCadForn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadForn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadForn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadForn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCadForn.Image = global::Cafetteria.Properties.Resources.entregador__1_;
            this.btnCadForn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadForn.Location = new System.Drawing.Point(186, 276);
            this.btnCadForn.Name = "btnCadForn";
            this.btnCadForn.Size = new System.Drawing.Size(150, 63);
            this.btnCadForn.TabIndex = 3;
            this.btnCadForn.Text = "CADASTRO DE \r\nFORNECEDOR";
            this.btnCadForn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadForn.UseVisualStyleBackColor = false;
            this.btnCadForn.Click += new System.EventHandler(this.btnCadForn_Click);
            // 
            // btnFazerPedido
            // 
            this.btnFazerPedido.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnFazerPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFazerPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFazerPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFazerPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFazerPedido.Image = global::Cafetteria.Properties.Resources.pedido_online__1_;
            this.btnFazerPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFazerPedido.Location = new System.Drawing.Point(342, 129);
            this.btnFazerPedido.Name = "btnFazerPedido";
            this.btnFazerPedido.Size = new System.Drawing.Size(150, 63);
            this.btnFazerPedido.TabIndex = 4;
            this.btnFazerPedido.Text = "FAZER PEDIDO \r\n(PRODUTO)\r\n";
            this.btnFazerPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFazerPedido.UseVisualStyleBackColor = false;
            this.btnFazerPedido.Click += new System.EventHandler(this.btnFazerPedido_Click);
            // 
            // btnCadProd
            // 
            this.btnCadProd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCadProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCadProd.Image = global::Cafetteria.Properties.Resources.cadastro__1_;
            this.btnCadProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadProd.Location = new System.Drawing.Point(186, 207);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(150, 63);
            this.btnCadProd.TabIndex = 2;
            this.btnCadProd.Text = "CADASTRO DE\r\nPRODUTO\r\n";
            this.btnCadProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadProd.UseVisualStyleBackColor = false;
            this.btnCadProd.Click += new System.EventHandler(this.btnCadProd_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnCaixa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCaixa.Image = global::Cafetteria.Properties.Resources.caixa_registradora__1_;
            this.btnCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.Location = new System.Drawing.Point(186, 129);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(150, 63);
            this.btnCaixa.TabIndex = 0;
            this.btnCaixa.Text = "CAIXA";
            this.btnCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaixa.UseVisualStyleBackColor = false;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // pcbLogoCafe
            // 
            this.pcbLogoCafe.Image = global::Cafetteria.Properties.Resources.logo_cafetteria;
            this.pcbLogoCafe.Location = new System.Drawing.Point(321, 424);
            this.pcbLogoCafe.Name = "pcbLogoCafe";
            this.pcbLogoCafe.Size = new System.Drawing.Size(38, 23);
            this.pcbLogoCafe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbLogoCafe.TabIndex = 17;
            this.pcbLogoCafe.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(657, 492);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCadFunc);
            this.Controls.Add(this.btnCadForn);
            this.Controls.Add(this.btnFazerPedido);
            this.Controls.Add(this.btnCadProd);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.lblExpressoEncantado);
            this.Controls.Add(this.lblCafetteria);
            this.Controls.Add(this.pcbLogoCafe);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogoCafe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblExpressoEncantado;
        private System.Windows.Forms.Label lblCafetteria;
        private System.Windows.Forms.PictureBox pcbLogoCafe;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Button btnCadProd;
        private System.Windows.Forms.Button btnFazerPedido;
        private System.Windows.Forms.Button btnCadForn;
        private System.Windows.Forms.Button btnCadFunc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcbSair;
    }
}