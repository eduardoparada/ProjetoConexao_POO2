namespace Aula_1_POO_2
{
    partial class TelaProduto
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btn_gravar_prod = new System.Windows.Forms.Button();
            this.btn_pesq_produto = new System.Windows.Forms.Button();
            this.btn_excluir_produto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_pdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(111, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(111, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(317, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(111, 83);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(317, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(111, 136);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(127, 20);
            this.txtValor.TabIndex = 3;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(111, 109);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(317, 21);
            this.cbxCategoria.TabIndex = 4;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(40, 228);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(667, 114);
            this.dgvDados.TabIndex = 5;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            // 
            // btn_gravar_prod
            // 
            this.btn_gravar_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gravar_prod.Location = new System.Drawing.Point(40, 170);
            this.btn_gravar_prod.Name = "btn_gravar_prod";
            this.btn_gravar_prod.Size = new System.Drawing.Size(138, 41);
            this.btn_gravar_prod.TabIndex = 6;
            this.btn_gravar_prod.Text = "Gravar";
            this.btn_gravar_prod.UseVisualStyleBackColor = true;
            this.btn_gravar_prod.Click += new System.EventHandler(this.btn_gravar_prod_Click);
            // 
            // btn_pesq_produto
            // 
            this.btn_pesq_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesq_produto.Location = new System.Drawing.Point(206, 170);
            this.btn_pesq_produto.Name = "btn_pesq_produto";
            this.btn_pesq_produto.Size = new System.Drawing.Size(138, 41);
            this.btn_pesq_produto.TabIndex = 7;
            this.btn_pesq_produto.Text = "Atualizar";
            this.btn_pesq_produto.UseVisualStyleBackColor = true;
            this.btn_pesq_produto.Click += new System.EventHandler(this.btn_pesq_produto_Click);
            // 
            // btn_excluir_produto
            // 
            this.btn_excluir_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir_produto.Location = new System.Drawing.Point(378, 170);
            this.btn_excluir_produto.Name = "btn_excluir_produto";
            this.btn_excluir_produto.Size = new System.Drawing.Size(138, 41);
            this.btn_excluir_produto.TabIndex = 8;
            this.btn_excluir_produto.Text = "Excluir";
            this.btn_excluir_produto.UseVisualStyleBackColor = true;
            this.btn_excluir_produto.Click += new System.EventHandler(this.btn_excluir_produto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Valor";
            // 
            // btn_pdf
            // 
            this.btn_pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pdf.Location = new System.Drawing.Point(569, 170);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(138, 41);
            this.btn_pdf.TabIndex = 14;
            this.btn_pdf.Text = "Gerar PDF";
            this.btn_pdf.UseVisualStyleBackColor = true;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click_1);
            // 
            // TelaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_excluir_produto);
            this.Controls.Add(this.btn_pesq_produto);
            this.Controls.Add(this.btn_gravar_prod);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Name = "TelaProduto";
            this.Text = "TelaProduto";
            this.Load += new System.EventHandler(this.TelaProduto_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btn_gravar_prod;
        private System.Windows.Forms.Button btn_pesq_produto;
        private System.Windows.Forms.Button btn_excluir_produto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_pdf;
    }
}