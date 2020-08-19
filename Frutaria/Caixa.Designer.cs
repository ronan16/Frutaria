namespace Frutaria
{
    partial class frmCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaixa));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.edtTotal = new System.Windows.Forms.TextBox();
            this.edtSubTotal = new System.Windows.Forms.TextBox();
            this.edtQtd = new System.Windows.Forms.TextBox();
            this.edtPreco = new System.Windows.Forms.TextBox();
            this.edtTipo = new System.Windows.Forms.TextBox();
            this.edtProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edtCodigo = new System.Windows.Forms.TextBox();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imgListaProd = new System.Windows.Forms.ImageList(this.components);
            this.imgProdutos = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.edtTotal, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.edtSubTotal, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.edtQtd, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.edtPreco, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.edtTipo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.edtProduto, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.edtCodigo, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(447, 184);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // edtTotal
            // 
            this.edtTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtTotal.Enabled = false;
            this.edtTotal.Location = new System.Drawing.Point(137, 159);
            this.edtTotal.Name = "edtTotal";
            this.edtTotal.Size = new System.Drawing.Size(307, 20);
            this.edtTotal.TabIndex = 13;
            this.edtTotal.Text = "0";
            // 
            // edtSubTotal
            // 
            this.edtSubTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtSubTotal.Enabled = false;
            this.edtSubTotal.Location = new System.Drawing.Point(137, 133);
            this.edtSubTotal.Name = "edtSubTotal";
            this.edtSubTotal.Size = new System.Drawing.Size(307, 20);
            this.edtSubTotal.TabIndex = 12;
            // 
            // edtQtd
            // 
            this.edtQtd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtQtd.Location = new System.Drawing.Point(137, 107);
            this.edtQtd.Name = "edtQtd";
            this.edtQtd.Size = new System.Drawing.Size(307, 20);
            this.edtQtd.TabIndex = 11;
            this.edtQtd.TextChanged += new System.EventHandler(this.edtQtd_TextChanged);
            // 
            // edtPreco
            // 
            this.edtPreco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtPreco.Enabled = false;
            this.edtPreco.Location = new System.Drawing.Point(137, 81);
            this.edtPreco.Name = "edtPreco";
            this.edtPreco.Size = new System.Drawing.Size(307, 20);
            this.edtPreco.TabIndex = 10;
            // 
            // edtTipo
            // 
            this.edtTipo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtTipo.Enabled = false;
            this.edtTipo.Location = new System.Drawing.Point(137, 55);
            this.edtTipo.Name = "edtTipo";
            this.edtTipo.Size = new System.Drawing.Size(307, 20);
            this.edtTipo.TabIndex = 9;
            // 
            // edtProduto
            // 
            this.edtProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtProduto.Enabled = false;
            this.edtProduto.Location = new System.Drawing.Point(137, 29);
            this.edtProduto.Name = "edtProduto";
            this.edtProduto.Size = new System.Drawing.Size(307, 20);
            this.edtProduto.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preco Unitário/Kg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Qtd/Kg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Subtotal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total";
            // 
            // edtCodigo
            // 
            this.edtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtCodigo.Location = new System.Drawing.Point(137, 3);
            this.edtCodigo.Name = "edtCodigo";
            this.edtCodigo.Size = new System.Drawing.Size(307, 20);
            this.edtCodigo.TabIndex = 7;
            this.edtCodigo.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // lstProdutos
            // 
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.Location = new System.Drawing.Point(12, 436);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(447, 121);
            this.lstProdutos.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Carrinho de Compras";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "AddProd";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Fechar Venda";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imgListaProd
            // 
            this.imgListaProd.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListaProd.ImageStream")));
            this.imgListaProd.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListaProd.Images.SetKeyName(0, "prod1.jpg");
            this.imgListaProd.Images.SetKeyName(1, "prod4.jpg");
            this.imgListaProd.Images.SetKeyName(2, "prod3.png");
            this.imgListaProd.Images.SetKeyName(3, "prod2.png");
            // 
            // imgProdutos
            // 
            this.imgProdutos.Location = new System.Drawing.Point(183, 290);
            this.imgProdutos.Name = "imgProdutos";
            this.imgProdutos.Size = new System.Drawing.Size(100, 100);
            this.imgProdutos.TabIndex = 6;
            this.imgProdutos.TabStop = false;
            // 
            // frmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 569);
            this.Controls.Add(this.imgProdutos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmCaixa";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtPreco;
        private System.Windows.Forms.TextBox edtTipo;
        private System.Windows.Forms.TextBox edtProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edtCodigo;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox edtTotal;
        private System.Windows.Forms.TextBox edtSubTotal;
        private System.Windows.Forms.TextBox edtQtd;
        private System.Windows.Forms.ImageList imgListaProd;
        private System.Windows.Forms.PictureBox imgProdutos;
    }
}