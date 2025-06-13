namespace controle_de_estoque
{
    partial class F_Registro
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
            this.btnregistrar = new System.Windows.Forms.Button();
            this.tbxUsuarioR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSenhaRR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxEmailR = new System.Windows.Forms.TextBox();
            this.tbxSenhaR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News701 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(107, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário:";
            // 
            // btnregistrar
            // 
            this.btnregistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrar.Location = new System.Drawing.Point(285, 310);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(111, 35);
            this.btnregistrar.TabIndex = 1;
            this.btnregistrar.Text = "Registrar";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // tbxUsuarioR
            // 
            this.tbxUsuarioR.Location = new System.Drawing.Point(212, 150);
            this.tbxUsuarioR.Name = "tbxUsuarioR";
            this.tbxUsuarioR.Size = new System.Drawing.Size(262, 26);
            this.tbxUsuarioR.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("News701 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirmar Senha:";
            // 
            // tbxSenhaRR
            // 
            this.tbxSenhaRR.Location = new System.Drawing.Point(212, 249);
            this.tbxSenhaRR.Name = "tbxSenhaRR";
            this.tbxSenhaRR.Size = new System.Drawing.Size(262, 26);
            this.tbxSenhaRR.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News701 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(121, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail:";
            // 
            // tbxEmailR
            // 
            this.tbxEmailR.Location = new System.Drawing.Point(212, 185);
            this.tbxEmailR.Name = "tbxEmailR";
            this.tbxEmailR.Size = new System.Drawing.Size(262, 26);
            this.tbxEmailR.TabIndex = 6;
            // 
            // tbxSenhaR
            // 
            this.tbxSenhaR.Location = new System.Drawing.Point(212, 217);
            this.tbxSenhaR.Name = "tbxSenhaR";
            this.tbxSenhaR.Size = new System.Drawing.Size(262, 26);
            this.tbxSenhaR.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("News701 BT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(121, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("News701 BT", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(262, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 39);
            this.label5.TabIndex = 17;
            this.label5.Text = "Registro";
            // 
            // F_Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxSenhaR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxEmailR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxSenhaRR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxUsuarioR);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.label1);
            this.Name = "F_Registro";
            this.Text = "F_Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.TextBox tbxUsuarioR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSenhaRR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxEmailR;
        private System.Windows.Forms.TextBox tbxSenhaR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}