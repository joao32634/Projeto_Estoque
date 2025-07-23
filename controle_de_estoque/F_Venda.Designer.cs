namespace controle_de_estoque
{
    partial class F_Venda
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
            this.cbbProduto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxQuantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPreco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbProduto
            // 
            this.cbbProduto.FormattingEnabled = true;
            this.cbbProduto.Location = new System.Drawing.Point(260, 122);
            this.cbbProduto.Name = "cbbProduto";
            this.cbbProduto.Size = new System.Drawing.Size(201, 21);
            this.cbbProduto.TabIndex = 16;
            this.cbbProduto.SelectedIndexChanged += new System.EventHandler(this.cbbProduto_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("News701 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(229, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 26);
            this.label4.TabIndex = 15;
            this.label4.Text = "Venda de Produtos";
            // 
            // tbxQuantidade
            // 
            this.tbxQuantidade.Location = new System.Drawing.Point(260, 175);
            this.tbxQuantidade.Name = "tbxQuantidade";
            this.tbxQuantidade.Size = new System.Drawing.Size(201, 20);
            this.tbxQuantidade.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(146, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantidade:";
            // 
            // tbxPreco
            // 
            this.tbxPreco.Location = new System.Drawing.Point(260, 149);
            this.tbxPreco.Name = "tbxPreco";
            this.tbxPreco.Size = new System.Drawing.Size(201, 20);
            this.tbxPreco.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(193, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Preço:";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(307, 227);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(106, 24);
            this.btnComprar.TabIndex = 10;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(128, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome Produto:";
            // 
            // F_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::controle_de_estoque.Properties.Resources.top_view_toy_shopping_cart_with_boxes_gift_red_background_copy_space_text_design_339191_203;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 355);
            this.Controls.Add(this.cbbProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxQuantidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.label1);
            this.Name = "F_Venda";
            this.Text = "F_Venda";
            this.Load += new System.EventHandler(this.F_Venda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPreco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Label label1;
    }
}