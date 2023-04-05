namespace Aula_1_POO_2
{
    partial class TelaFornecedor
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
            this.TelFornecedor_txt = new System.Windows.Forms.MaskedTextBox();
            this.cnpj_txt = new System.Windows.Forms.MaskedTextBox();
            this.NomeFornecedor_txt = new System.Windows.Forms.TextBox();
            this.id_forn_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pesquisa_fornecedor_btn = new System.Windows.Forms.Button();
            this.btn_excluir_fornecedor = new System.Windows.Forms.Button();
            this.btn_fornecedor_gravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TelFornecedor_txt
            // 
            this.TelFornecedor_txt.Location = new System.Drawing.Point(235, 118);
            this.TelFornecedor_txt.Mask = "(99) 00000-0000";
            this.TelFornecedor_txt.Name = "TelFornecedor_txt";
            this.TelFornecedor_txt.Size = new System.Drawing.Size(319, 20);
            this.TelFornecedor_txt.TabIndex = 17;
            // 
            // cnpj_txt
            // 
            this.cnpj_txt.Location = new System.Drawing.Point(235, 88);
            this.cnpj_txt.Mask = "00.000.000/0000-00";
            this.cnpj_txt.Name = "cnpj_txt";
            this.cnpj_txt.Size = new System.Drawing.Size(319, 20);
            this.cnpj_txt.TabIndex = 16;
            // 
            // NomeFornecedor_txt
            // 
            this.NomeFornecedor_txt.Location = new System.Drawing.Point(235, 58);
            this.NomeFornecedor_txt.Name = "NomeFornecedor_txt";
            this.NomeFornecedor_txt.Size = new System.Drawing.Size(319, 20);
            this.NomeFornecedor_txt.TabIndex = 15;
            // 
            // id_forn_txt
            // 
            this.id_forn_txt.Location = new System.Drawing.Point(235, 29);
            this.id_forn_txt.Name = "id_forn_txt";
            this.id_forn_txt.Size = new System.Drawing.Size(319, 20);
            this.id_forn_txt.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Contato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "CNPJ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome do Fornecedor";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(17, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(122, 20);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "Id Fornecedor";
            // 
            // pesquisa_fornecedor_btn
            // 
            this.pesquisa_fornecedor_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisa_fornecedor_btn.Location = new System.Drawing.Point(224, 177);
            this.pesquisa_fornecedor_btn.Name = "pesquisa_fornecedor_btn";
            this.pesquisa_fornecedor_btn.Size = new System.Drawing.Size(114, 45);
            this.pesquisa_fornecedor_btn.TabIndex = 20;
            this.pesquisa_fornecedor_btn.Text = "Pesquisar";
            this.pesquisa_fornecedor_btn.UseVisualStyleBackColor = true;
            // 
            // btn_excluir_fornecedor
            // 
            this.btn_excluir_fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir_fornecedor.Location = new System.Drawing.Point(372, 177);
            this.btn_excluir_fornecedor.Name = "btn_excluir_fornecedor";
            this.btn_excluir_fornecedor.Size = new System.Drawing.Size(114, 45);
            this.btn_excluir_fornecedor.TabIndex = 19;
            this.btn_excluir_fornecedor.Text = "Excluir";
            this.btn_excluir_fornecedor.UseVisualStyleBackColor = true;
            // 
            // btn_fornecedor_gravar
            // 
            this.btn_fornecedor_gravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fornecedor_gravar.Location = new System.Drawing.Point(80, 177);
            this.btn_fornecedor_gravar.Name = "btn_fornecedor_gravar";
            this.btn_fornecedor_gravar.Size = new System.Drawing.Size(114, 45);
            this.btn_fornecedor_gravar.TabIndex = 18;
            this.btn_fornecedor_gravar.Text = "Gravar";
            this.btn_fornecedor_gravar.UseVisualStyleBackColor = true;
            // 
            // TelaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 258);
            this.Controls.Add(this.pesquisa_fornecedor_btn);
            this.Controls.Add(this.btn_excluir_fornecedor);
            this.Controls.Add(this.btn_fornecedor_gravar);
            this.Controls.Add(this.TelFornecedor_txt);
            this.Controls.Add(this.cnpj_txt);
            this.Controls.Add(this.NomeFornecedor_txt);
            this.Controls.Add(this.id_forn_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl1);
            this.Name = "TelaFornecedor";
            this.Text = "TelaFornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TelFornecedor_txt;
        private System.Windows.Forms.MaskedTextBox cnpj_txt;
        private System.Windows.Forms.TextBox NomeFornecedor_txt;
        private System.Windows.Forms.TextBox id_forn_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button pesquisa_fornecedor_btn;
        private System.Windows.Forms.Button btn_excluir_fornecedor;
        private System.Windows.Forms.Button btn_fornecedor_gravar;
    }
}