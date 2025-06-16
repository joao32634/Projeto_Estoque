namespace controle_de_estoque
{
    partial class F_Controle_de_Estoque
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigoProduto = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPreçoCusto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPreçoVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxQuantidadeInicial = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.tbxEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxFornecedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cbbUnidade = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.movimentoDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(286, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(344, 93);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(188, 20);
            this.tbxNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(280, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cadastro de Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(247, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codigo de Produto:";
            // 
            // lblCodigoProduto
            // 
            this.lblCodigoProduto.AutoSize = true;
            this.lblCodigoProduto.Location = new System.Drawing.Point(400, 59);
            this.lblCodigoProduto.Name = "lblCodigoProduto";
            this.lblCodigoProduto.Size = new System.Drawing.Size(0, 13);
            this.lblCodigoProduto.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(258, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(268, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Unidade:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbxPreçoCusto
            // 
            this.tbxPreçoCusto.Location = new System.Drawing.Point(344, 204);
            this.tbxPreçoCusto.Name = "tbxPreçoCusto";
            this.tbxPreçoCusto.Size = new System.Drawing.Size(188, 20);
            this.tbxPreçoCusto.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(221, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Preço de Custo:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbxPreçoVenda
            // 
            this.tbxPreçoVenda.Location = new System.Drawing.Point(344, 241);
            this.tbxPreçoVenda.Name = "tbxPreçoVenda";
            this.tbxPreçoVenda.Size = new System.Drawing.Size(188, 20);
            this.tbxPreçoVenda.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(220, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Preço de Venda:";
            // 
            // tbxQuantidadeInicial
            // 
            this.tbxQuantidadeInicial.Location = new System.Drawing.Point(344, 280);
            this.tbxQuantidadeInicial.Name = "tbxQuantidadeInicial";
            this.tbxQuantidadeInicial.Size = new System.Drawing.Size(188, 20);
            this.tbxQuantidadeInicial.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(203, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Quantidade Inicial:";
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.Items.AddRange(new object[] {
            "Eletrônicos",
            "Informática",
            "Celulares e Telefonia",
            "Áudio e Vídeo"});
            this.cbbCategoria.Location = new System.Drawing.Point(344, 128);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(188, 21);
            this.cbbCategoria.TabIndex = 15;
            // 
            // tbxEstoqueMinimo
            // 
            this.tbxEstoqueMinimo.Location = new System.Drawing.Point(344, 315);
            this.tbxEstoqueMinimo.Name = "tbxEstoqueMinimo";
            this.tbxEstoqueMinimo.Size = new System.Drawing.Size(188, 20);
            this.tbxEstoqueMinimo.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Location = new System.Drawing.Point(213, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Estoque Minimo:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // tbxFornecedor
            // 
            this.tbxFornecedor.Location = new System.Drawing.Point(344, 354);
            this.tbxFornecedor.Name = "tbxFornecedor";
            this.tbxFornecedor.Size = new System.Drawing.Size(188, 20);
            this.tbxFornecedor.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(174, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Fornecedor (Opcional):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(222, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(422, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(515, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // cbbUnidade
            // 
            this.cbbUnidade.FormattingEnabled = true;
            this.cbbUnidade.Items.AddRange(new object[] {
            "Unidade",
            "Kilograma",
            "Caixa"});
            this.cbbUnidade.Location = new System.Drawing.Point(344, 167);
            this.cbbUnidade.Name = "cbbUnidade";
            this.cbbUnidade.Size = new System.Drawing.Size(188, 21);
            this.cbbUnidade.TabIndex = 24;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movimentoDeEstoqueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // movimentoDeEstoqueToolStripMenuItem
            // 
            this.movimentoDeEstoqueToolStripMenuItem.Name = "movimentoDeEstoqueToolStripMenuItem";
            this.movimentoDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.movimentoDeEstoqueToolStripMenuItem.Text = "Movimento de Estoque";
            this.movimentoDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.movimentoDeEstoqueToolStripMenuItem_Click);
            // 
            // F_Controle_de_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::controle_de_estoque.Properties.Resources.jksjfdjs;
            this.ClientSize = new System.Drawing.Size(768, 431);
            this.Controls.Add(this.cbbUnidade);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxFornecedor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxEstoqueMinimo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbbCategoria);
            this.Controls.Add(this.tbxQuantidadeInicial);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxPreçoVenda);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxPreçoCusto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCodigoProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "F_Controle_de_Estoque";
            this.Text = "F_Controle_de_Estoque";
            this.Load += new System.EventHandler(this.F_Controle_de_Estoque_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCodigoProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPreçoCusto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPreçoVenda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxQuantidadeInicial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbCategoria;
        private System.Windows.Forms.TextBox tbxEstoqueMinimo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxFornecedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cbbUnidade;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem movimentoDeEstoqueToolStripMenuItem;
    }
}