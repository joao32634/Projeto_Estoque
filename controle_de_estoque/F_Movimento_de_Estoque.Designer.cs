namespace controle_de_estoque
{
    partial class F_Movimento_de_Estoque
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
            this.btnRegistro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbProduto = new System.Windows.Forms.ComboBox();
            this.dtpDataMovimentacao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbEntrada = new System.Windows.Forms.RadioButton();
            this.rdbSaida = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.cbbMotivo = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbbCategoria = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxFornecedor = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(297, 362);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(75, 23);
            this.btnRegistro.TabIndex = 0;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto:";
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.Location = new System.Drawing.Point(227, 194);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(218, 20);
            this.tbxQuantidade.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Motivo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(130, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fornecedor:";
            // 
            // cbbProduto
            // 
            this.cbbProduto.FormattingEnabled = true;
            this.cbbProduto.Location = new System.Drawing.Point(159, 60);
            this.cbbProduto.Name = "cbbProduto";
            this.cbbProduto.Size = new System.Drawing.Size(331, 21);
            this.cbbProduto.TabIndex = 8;
            this.cbbProduto.SelectedIndexChanged += new System.EventHandler(this.cbbProduto_SelectedIndexChanged);
            // 
            // dtpDataMovimentacao
            // 
            this.dtpDataMovimentacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataMovimentacao.Location = new System.Drawing.Point(345, 133);
            this.dtpDataMovimentacao.Name = "dtpDataMovimentacao";
            this.dtpDataMovimentacao.Size = new System.Drawing.Size(145, 20);
            this.dtpDataMovimentacao.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data de Movimentação:";
            // 
            // rdbEntrada
            // 
            this.rdbEntrada.AutoSize = true;
            this.rdbEntrada.Location = new System.Drawing.Point(345, 159);
            this.rdbEntrada.Name = "rdbEntrada";
            this.rdbEntrada.Size = new System.Drawing.Size(62, 17);
            this.rdbEntrada.TabIndex = 11;
            this.rdbEntrada.TabStop = true;
            this.rdbEntrada.Text = "Entrada";
            this.rdbEntrada.UseVisualStyleBackColor = true;
            this.rdbEntrada.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbSaida
            // 
            this.rdbSaida.AutoSize = true;
            this.rdbSaida.Location = new System.Drawing.Point(424, 159);
            this.rdbSaida.Name = "rdbSaida";
            this.rdbSaida.Size = new System.Drawing.Size(52, 17);
            this.rdbSaida.TabIndex = 12;
            this.rdbSaida.TabStop = true;
            this.rdbSaida.Text = "Saida";
            this.rdbSaida.UseVisualStyleBackColor = true;
            this.rdbSaida.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(391, 362);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cbbMotivo
            // 
            this.cbbMotivo.FormattingEnabled = true;
            this.cbbMotivo.Items.AddRange(new object[] {
            "Compra",
            "Transferencia",
            "Venda",
            "Produto Defeituoso",
            "Devolução de Compra",
            "Devolução de Venda",
            "Pouco Estoque",
            "",
            ""});
            this.cbbMotivo.Location = new System.Drawing.Point(227, 234);
            this.cbbMotivo.Name = "cbbMotivo";
            this.cbbMotivo.Size = new System.Drawing.Size(218, 21);
            this.cbbMotivo.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            this.relatóriosToolStripMenuItem.Click += new System.EventHandler(this.relatóriosToolStripMenuItem_Click);
            // 
            // cbbCategoria
            // 
            this.cbbCategoria.FormattingEnabled = true;
            this.cbbCategoria.Items.AddRange(new object[] {
            "Eletrônicos",
            "Informática",
            "Celulares e Telefonia",
            "Áudio e Vídeo"});
            this.cbbCategoria.Location = new System.Drawing.Point(159, 106);
            this.cbbCategoria.Name = "cbbCategoria";
            this.cbbCategoria.Size = new System.Drawing.Size(331, 21);
            this.cbbCategoria.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(134, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Categoria:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(227, 261);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(218, 21);
            this.comboBox4.TabIndex = 20;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(156, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Usuário:";
            // 
            // tbxFornecedor
            // 
            this.tbxFornecedor.Location = new System.Drawing.Point(227, 288);
            this.tbxFornecedor.Name = "tbxFornecedor";
            this.tbxFornecedor.Size = new System.Drawing.Size(218, 20);
            this.tbxFornecedor.TabIndex = 21;
            // 
            // F_Movimento_de_Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxFornecedor);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbCategoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbbMotivo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rdbSaida);
            this.Controls.Add(this.rdbEntrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDataMovimentacao);
            this.Controls.Add(this.cbbProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxQuantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_Movimento_de_Estoque";
            this.Text = "F_Movimento_de_Estoque";
            this.Load += new System.EventHandler(this.F_Movimento_de_Estoque_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbProduto;
        private System.Windows.Forms.DateTimePicker dtpDataMovimentacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbEntrada;
        private System.Windows.Forms.RadioButton rdbSaida;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbbMotivo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbbCategoria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxFornecedor;
    }
}