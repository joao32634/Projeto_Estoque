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
            this.tbxCategoriaEditar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxPrecoCustoEditar = new System.Windows.Forms.TextBox();
            this.cbbUnidadeEditar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxQuantidadeInicialEditar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxPrecoVendaEditar = new System.Windows.Forms.TextBox();
            this.tbxFornecedorEditar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxEstoqueMinimoEditar = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.tbxNomeEditar = new System.Windows.Forms.TextBox();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorios)).BeginInit();
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
            "Cadastro de Produtos",
            "Movimento de Produtos"});
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
            // tbxCategoriaEditar
            // 
            this.tbxCategoriaEditar.AcceptsTab = true;
            this.tbxCategoriaEditar.Location = new System.Drawing.Point(1105, 242);
            this.tbxCategoriaEditar.Name = "tbxCategoriaEditar";
            this.tbxCategoriaEditar.Size = new System.Drawing.Size(166, 20);
            this.tbxCategoriaEditar.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1017, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1045, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nome:";
            // 
            // tbxPrecoCustoEditar
            // 
            this.tbxPrecoCustoEditar.AcceptsTab = true;
            this.tbxPrecoCustoEditar.Location = new System.Drawing.Point(1105, 295);
            this.tbxPrecoCustoEditar.Name = "tbxPrecoCustoEditar";
            this.tbxPrecoCustoEditar.Size = new System.Drawing.Size(166, 20);
            this.tbxPrecoCustoEditar.TabIndex = 17;
            // 
            // cbbUnidadeEditar
            // 
            this.cbbUnidadeEditar.FormattingEnabled = true;
            this.cbbUnidadeEditar.Items.AddRange(new object[] {
            "Unidade",
            "Kilogram",
            "Caixa"});
            this.cbbUnidadeEditar.Location = new System.Drawing.Point(1105, 268);
            this.cbbUnidadeEditar.Name = "cbbUnidadeEditar";
            this.cbbUnidadeEditar.Size = new System.Drawing.Size(166, 21);
            this.cbbUnidadeEditar.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(966, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Preço_de_Custo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1028, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Unidade:";
            // 
            // tbxQuantidadeInicialEditar
            // 
            this.tbxQuantidadeInicialEditar.AcceptsTab = true;
            this.tbxQuantidadeInicialEditar.Location = new System.Drawing.Point(1105, 347);
            this.tbxQuantidadeInicialEditar.Name = "tbxQuantidadeInicialEditar";
            this.tbxQuantidadeInicialEditar.Size = new System.Drawing.Size(166, 20);
            this.tbxQuantidadeInicialEditar.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(953, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Quantidade_Inicial:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(963, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Preço_de_Venda:";
            // 
            // tbxPrecoVendaEditar
            // 
            this.tbxPrecoVendaEditar.AcceptsTab = true;
            this.tbxPrecoVendaEditar.Location = new System.Drawing.Point(1105, 321);
            this.tbxPrecoVendaEditar.Name = "tbxPrecoVendaEditar";
            this.tbxPrecoVendaEditar.Size = new System.Drawing.Size(166, 20);
            this.tbxPrecoVendaEditar.TabIndex = 22;
            // 
            // tbxFornecedorEditar
            // 
            this.tbxFornecedorEditar.AcceptsTab = true;
            this.tbxFornecedorEditar.Location = new System.Drawing.Point(1105, 399);
            this.tbxFornecedorEditar.Name = "tbxFornecedorEditar";
            this.tbxFornecedorEditar.Size = new System.Drawing.Size(166, 20);
            this.tbxFornecedorEditar.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(926, 398);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Fornecedor(Opcional):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(963, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Estoque_Minimo:";
            // 
            // tbxEstoqueMinimoEditar
            // 
            this.tbxEstoqueMinimoEditar.AcceptsTab = true;
            this.tbxEstoqueMinimoEditar.Location = new System.Drawing.Point(1105, 373);
            this.tbxEstoqueMinimoEditar.Name = "tbxEstoqueMinimoEditar";
            this.tbxEstoqueMinimoEditar.Size = new System.Drawing.Size(166, 20);
            this.tbxEstoqueMinimoEditar.TabIndex = 27;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1188, 439);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(83, 28);
            this.btnEditar.TabIndex = 28;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // tbxNomeEditar
            // 
            this.tbxNomeEditar.AcceptsTab = true;
            this.tbxNomeEditar.Location = new System.Drawing.Point(1105, 216);
            this.tbxNomeEditar.Name = "tbxNomeEditar";
            this.tbxNomeEditar.Size = new System.Drawing.Size(166, 20);
            this.tbxNomeEditar.TabIndex = 29;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSelecionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelecionar.Location = new System.Drawing.Point(1008, 439);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(84, 28);
            this.btnSelecionar.TabIndex = 30;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // tbxID
            // 
            this.tbxID.AcceptsTab = true;
            this.tbxID.Location = new System.Drawing.Point(1105, 190);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(166, 20);
            this.tbxID.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1070, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 18);
            this.label12.TabIndex = 31;
            this.label12.Text = "ID:";
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.Location = new System.Drawing.Point(1098, 439);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(84, 28);
            this.btnDeletar.TabIndex = 33;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // F_Relatorios
            // 
            this.AcceptButton = this.btnFiltro;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 636);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.tbxID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.tbxNomeEditar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.tbxEstoqueMinimoEditar);
            this.Controls.Add(this.tbxFornecedorEditar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbxPrecoVendaEditar);
            this.Controls.Add(this.tbxQuantidadeInicialEditar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbxPrecoCustoEditar);
            this.Controls.Add(this.cbbUnidadeEditar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxCategoriaEditar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.tbxFiltro);
            this.Controls.Add(this.dgvRelatorios);
            this.Controls.Add(this.cbbTipoRelatorio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_Relatorios";
            this.Text = "F_Relatorios";
            this.Load += new System.EventHandler(this.F_Relatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorios)).EndInit();
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
        private System.Windows.Forms.TextBox tbxCategoriaEditar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxPrecoCustoEditar;
        private System.Windows.Forms.ComboBox cbbUnidadeEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxQuantidadeInicialEditar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxPrecoVendaEditar;
        private System.Windows.Forms.TextBox tbxFornecedorEditar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxEstoqueMinimoEditar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox tbxNomeEditar;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDeletar;
    }
}