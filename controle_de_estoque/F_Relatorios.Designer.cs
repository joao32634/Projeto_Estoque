namespace controle_de_estoque
{
    partial class F_Relatorios
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbTipoRelatorio = new System.Windows.Forms.ComboBox();
            this.dgvRelatorios = new System.Windows.Forms.DataGridView();
            this.tbxFiltro = new System.Windows.Forms.TextBox();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.tbxFornecedor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gerenciamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cbbProdutos = new System.Windows.Forms.ComboBox();
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.rdbCompra = new System.Windows.Forms.RadioButton();
            this.rdbVenda = new System.Windows.Forms.RadioButton();
            this.tbxPreco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorios)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News701 BT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Relatórios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Relatório:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filtros:";
            // 
            // cbbTipoRelatorio
            // 
            this.cbbTipoRelatorio.FormattingEnabled = true;
            this.cbbTipoRelatorio.Items.AddRange(new object[] {
            "Produto",
            "Compra",
            "Venda"});
            this.cbbTipoRelatorio.Location = new System.Drawing.Point(177, 47);
            this.cbbTipoRelatorio.Name = "cbbTipoRelatorio";
            this.cbbTipoRelatorio.Size = new System.Drawing.Size(166, 21);
            this.cbbTipoRelatorio.TabIndex = 3;
            this.cbbTipoRelatorio.SelectedIndexChanged += new System.EventHandler(this.cbbTipoRelatorio_SelectedIndexChanged);
            // 
            // dgvRelatorios
            // 
            this.dgvRelatorios.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRelatorios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRelatorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorios.Location = new System.Drawing.Point(12, 131);
            this.dgvRelatorios.Name = "dgvRelatorios";
            this.dgvRelatorios.ReadOnly = true;
            this.dgvRelatorios.RowHeadersVisible = false;
            this.dgvRelatorios.Size = new System.Drawing.Size(903, 471);
            this.dgvRelatorios.TabIndex = 7;
            this.dgvRelatorios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRelatorios_CellContentClick);
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.AcceptsTab = true;
            this.tbxFiltro.Location = new System.Drawing.Point(177, 91);
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(166, 20);
            this.tbxFiltro.TabIndex = 8;
            this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltros_TextChanged);
            // 
            // btnFiltro
            // 
            this.btnFiltro.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFiltro.Location = new System.Drawing.Point(349, 89);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnFiltro.TabIndex = 9;
            this.btnFiltro.Text = "Filtro";
            this.btnFiltro.UseVisualStyleBackColor = false;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(946, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Categoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(934, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quantidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1154, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Preço:";
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.AcceptsTab = true;
            this.tbxQuantidade.Location = new System.Drawing.Point(1034, 241);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(110, 20);
            this.tbxQuantidade.TabIndex = 21;
            // 
            // tbxFornecedor
            // 
            this.tbxFornecedor.AcceptsTab = true;
            this.tbxFornecedor.Location = new System.Drawing.Point(1034, 303);
            this.tbxFornecedor.Name = "tbxFornecedor";
            this.tbxFornecedor.Size = new System.Drawing.Size(237, 20);
            this.tbxFornecedor.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(928, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Fornecedor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(980, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Data:";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1061, 490);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(83, 28);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(1162, 490);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(84, 28);
            this.btnSelecionar.TabIndex = 30;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(959, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 18);
            this.label12.TabIndex = 31;
            this.label12.Text = "Produto:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(956, 490);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(84, 28);
            this.btnDeletar.TabIndex = 33;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerenciamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1432, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gerenciamentoToolStripMenuItem
            // 
            this.gerenciamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeProdutosToolStripMenuItem,
            this.movimentoDeProdutosToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.gerenciamentoToolStripMenuItem.Name = "gerenciamentoToolStripMenuItem";
            this.gerenciamentoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.gerenciamentoToolStripMenuItem.Text = "Janelas";
            this.gerenciamentoToolStripMenuItem.Click += new System.EventHandler(this.gerenciamentoToolStripMenuItem_Click);
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos";
            this.cadastroDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProdutosToolStripMenuItem_Click);
            // 
            // movimentoDeProdutosToolStripMenuItem
            // 
            this.movimentoDeProdutosToolStripMenuItem.Name = "movimentoDeProdutosToolStripMenuItem";
            this.movimentoDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.movimentoDeProdutosToolStripMenuItem.Text = "Movimento de Produtos";
            this.movimentoDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.movimentoDeProdutosToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1068, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 24);
            this.label8.TabIndex = 35;
            this.label8.Text = "Gerenciar Produtos";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(1117, 343);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(84, 28);
            this.btnRegistrar.TabIndex = 36;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // cbbProdutos
            // 
            this.cbbProdutos.FormattingEnabled = true;
            this.cbbProdutos.Location = new System.Drawing.Point(1034, 187);
            this.cbbProdutos.Name = "cbbProdutos";
            this.cbbProdutos.Size = new System.Drawing.Size(290, 21);
            this.cbbProdutos.TabIndex = 37;
            this.cbbProdutos.SelectedIndexChanged += new System.EventHandler(this.cbbProdutos_SelectedIndexChanged);
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.Location = new System.Drawing.Point(1034, 214);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(290, 21);
            this.cbbCategoria.TabIndex = 38;
            this.cbbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbbCategoria_SelectedIndexChanged);
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(1034, 277);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(86, 20);
            this.dtpData.TabIndex = 39;
            // 
            // rdbCompra
            // 
            this.rdbCompra.AutoSize = true;
            this.rdbCompra.Location = new System.Drawing.Point(1140, 277);
            this.rdbCompra.Name = "rdbCompra";
            this.rdbCompra.Size = new System.Drawing.Size(61, 17);
            this.rdbCompra.TabIndex = 40;
            this.rdbCompra.TabStop = true;
            this.rdbCompra.Text = "Compra";
            this.rdbCompra.UseVisualStyleBackColor = true;
            // 
            // rdbVenda
            // 
            this.rdbVenda.AutoSize = true;
            this.rdbVenda.Location = new System.Drawing.Point(1231, 277);
            this.rdbVenda.Name = "rdbVenda";
            this.rdbVenda.Size = new System.Drawing.Size(56, 17);
            this.rdbVenda.TabIndex = 41;
            this.rdbVenda.TabStop = true;
            this.rdbVenda.Text = "Venda";
            this.rdbVenda.UseVisualStyleBackColor = true;
            // 
            // tbxPreco
            // 
            this.tbxPreco.AcceptsTab = true;
            this.tbxPreco.Location = new System.Drawing.Point(1214, 241);
            this.tbxPreco.Name = "tbxPreco";
            this.tbxPreco.Size = new System.Drawing.Size(110, 20);
            this.tbxPreco.TabIndex = 42;
            // 
            // F_Relatorios
            // 
            this.AcceptButton = this.btnFiltro;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 636);
            this.Controls.Add(this.tbxPreco);
            this.Controls.Add(this.rdbVenda);
            this.Controls.Add(this.rdbCompra);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.cbbCategoria);
            this.Controls.Add(this.cbbProdutos);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.tbxFornecedor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxQuantidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.tbxFiltro);
            this.Controls.Add(this.dgvRelatorios);
            this.Controls.Add(this.cbbTipoRelatorio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_Relatorios";
            this.Text = "F_Relatorios";
            this.Load += new System.EventHandler(this.F_Relatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorios)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbTipoRelatorio;
        private System.Windows.Forms.DataGridView dgvRelatorios;
        private System.Windows.Forms.TextBox tbxFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private System.Windows.Forms.TextBox tbxFornecedor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gerenciamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentoDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cbbProdutos;
        private System.Windows.Forms.ComboBox cbbCategoria;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.RadioButton rdbCompra;
        private System.Windows.Forms.RadioButton rdbVenda;
        private System.Windows.Forms.TextBox tbxPreco;
    }
}