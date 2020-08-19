namespace Frutaria
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.edtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtSenha = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.imgUsuario = new System.Windows.Forms.PictureBox();
            this.imgLista = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 351);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.edtUsuario, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.edtSenha, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.imgUsuario, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.19355F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.90322F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.90322F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.90322F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.90322F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.19355F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(476, 351);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // edtUsuario
            // 
            this.edtUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtUsuario.Location = new System.Drawing.Point(3, 132);
            this.edtUsuario.Name = "edtUsuario";
            this.edtUsuario.Size = new System.Drawing.Size(470, 20);
            this.edtUsuario.TabIndex = 2;
            this.edtUsuario.Leave += new System.EventHandler(this.edtUsuario_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // edtSenha
            // 
            this.edtSenha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.edtSenha.Location = new System.Drawing.Point(3, 222);
            this.edtSenha.Name = "edtSenha";
            this.edtSenha.PasswordChar = '*';
            this.edtSenha.Size = new System.Drawing.Size(470, 20);
            this.edtSenha.TabIndex = 4;
            this.edtSenha.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnAcessar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCadastrar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 267);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(470, 81);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // btnAcessar
            // 
            this.btnAcessar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAcessar.Location = new System.Drawing.Point(238, 3);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(229, 75);
            this.btnAcessar.TabIndex = 0;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCadastrar.Location = new System.Drawing.Point(3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(229, 75);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // imgUsuario
            // 
            this.imgUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgUsuario.ImageLocation = "C:\\DADOS\\img";
            this.imgUsuario.Location = new System.Drawing.Point(3, 3);
            this.imgUsuario.Name = "imgUsuario";
            this.imgUsuario.Size = new System.Drawing.Size(470, 78);
            this.imgUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgUsuario.TabIndex = 6;
            this.imgUsuario.TabStop = false;
            // 
            // imgLista
            // 
            this.imgLista.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLista.ImageStream")));
            this.imgLista.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLista.Images.SetKeyName(0, "usu1.jpg");
            this.imgLista.Images.SetKeyName(1, "usu2.jpg");
            this.imgLista.Images.SetKeyName(2, "usu3.jpg");
            this.imgLista.Images.SetKeyName(3, "usu4.png");
            this.imgLista.Images.SetKeyName(4, "usu5.jpg");
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 351);
            this.Controls.Add(this.panel1);
            this.Name = "frmLogin";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtSenha;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox imgUsuario;
        private System.Windows.Forms.ImageList imgLista;
    }
}

